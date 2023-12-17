using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChristianMatch.FastMatch
{
    public partial class GameScene : Form
    {
        private string team1, team2, nameTeam1, nameTeam2;

        private Image imgTeam1, imgTeam2;

        private Config config;

        private int pointsTeam1, pointsTeam2;

        private Common.SimpleQuestionsDispatcher dispatcher;

        private Common.FastQuestionForm questionForm;

        public GameScene()
        {
            InitializeComponent();
            this.dispatcher = new Common.SimpleQuestionsDispatcher();
        }

        public string Team1
        {
            set
            {
                this.team1 = value;
                this.nameTeam1 = Common.Characters.Instance[value].Name;
            }
        }

        public string Team2
        {
            set
            {
                this.team2 = value;
                this.nameTeam2 = Common.Characters.Instance[value].Name;
            }
        }

        public int PointsTeam1
        {
            get
            {
                return this.pointsTeam1;
            }
        }

        public int PointsTeam2
        {
            get
            {
                return this.pointsTeam2;
            }
        }

        public Config Config
        {
            set
            {
                this.config = value;
                this.dispatcher.Open(value.Questionarie);

                // Build the question form
                this.questionForm = new Common.FastQuestionForm();
                this.questionForm.Team1 = this.team1;
                this.questionForm.Team2 = this.team2;

                if (value.LimitedTime)
                    this.questionForm.SetMaxTime(value.Time);

            }
        }

        private void mainScene_Paint(object sender, PaintEventArgs e)
        {
            // Draw the characters
            int midX = this.mainScene.Width / 2;
            int midY = this.mainScene.Height / 2;

            // Draw first team
            e.Graphics.DrawImage(this.imgTeam1, midX - 350, midY - 150, 300, 300);
            // Draw second team
            e.Graphics.DrawImage(this.imgTeam2, midX + 50, midY - 150, 300, 300);

            Font f = new Font(new FontFamily("Forte"), 35, FontStyle.Bold, GraphicsUnit.Pixel);
            Font vs = new Font(new FontFamily("Kristen ITC"), 50, FontStyle.Bold, GraphicsUnit.Pixel);
            Font points = new Font(new FontFamily("Courier New"), 70, FontStyle.Bold, GraphicsUnit.Pixel);

            Brush namesBruch = new SolidBrush(Color.Navy);
            Brush brush = new SolidBrush(Color.Brown);
            Brush pointBruch = new SolidBrush(Color.DarkRed);

            // Write team names
            e.Graphics.DrawString(this.nameTeam1, f, namesBruch, midX - 190, midY + 200);
            e.Graphics.DrawString(this.nameTeam2, f, namesBruch, midX + 100, midY + 200);

            // Write Vs label
            e.Graphics.DrawString("Vs", vs, brush, midX - 20, midY + 190);
            // Write points of teams
            e.Graphics.DrawString(this.pointsTeam1.ToString(), points, pointBruch, midX - 225, midY - 250);
            e.Graphics.DrawString(this.pointsTeam2.ToString(), points, pointBruch, midX + 175, midY - 250);
        }

        private void GameScene_Resize(object sender, EventArgs e)
        {
            int y = (this.bottomPanel.Height - this.startBtn.Height) / 2;
            this.startBtn.Location = new Point(200, y);
            this.endGameBtn.Location = new Point(this.bottomPanel.Width - this.endGameBtn.Width - 200, y);
        }

        private void endGameBtn_Click(object sender, EventArgs e)
        {
            if (this.pointsTeam1 != 0 || this.pointsTeam2 != 0)
                this.GameOver();
            else
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        private void GameScene_Shown(object sender, EventArgs e)
        {
            this.imgTeam1 = Common.Characters.Instance[this.team1].Image;
            this.imgTeam2 = Common.Characters.Instance[this.team2].Image;
            this.FlashTimer.Start();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            // Prepare the first quiestion
            Common.Question q = this.dispatcher.GetNext();
            this.questionForm.SetTheQuestion(q);
            System.Windows.Forms.DialogResult result = this.questionForm.ShowDialog(this);
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                switch (this.questionForm.Winer)
                {
                    case "team1":
                        if (this.config.EqualValue)
                            this.pointsTeam1 += this.config.QuestionValue;
                        else
                            this.pointsTeam1 += q.Level * 5;
                        break;

                    case "team2":
                        if (this.config.EqualValue)
                            this.pointsTeam2 += this.config.QuestionValue;
                        else
                            this.pointsTeam2 += q.Level * 5;
                        break;

                    default:
                        // Split points if both respond
                        int points = (this.config.EqualValue) ? this.config.QuestionValue : q.Level * 5;
                        if (points % 2 == 1) points++;
                        
                        this.pointsTeam1 += points / 2;
                        this.pointsTeam2 += points / 2;

                        break;
                }
            }

            this.questionForm.Restart();

            this.mainScene.Invalidate();

            // Check the questionary is not empty
            if (this.dispatcher.Remainder <= 1)
            {
                MessageBox.Show(this, "Lo sentimos.\nLas preguntas se han agotado...", "Upsss...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.GameOver();
            }
            else
                this.FlashTimer.Start();
        }

        private void GameOver()
        {
            if (this.pointsTeam1 == this.pointsTeam2)
                MessageBox.Show(this, "Juego terminado y EMPATADO.\n\n Buen trabajo equipos!!!", "Fin del Juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Common.WinnerForm winner = new Common.WinnerForm();
                winner.Winner = (this.pointsTeam1 > this.pointsTeam2) ? this.team1 : this.team2;
                winner.ShowDialog();
            }

            this.DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        int flashStatus = 0;

        private void flashTimer_Tick(object sender, EventArgs e)
        {
            if (this.flashStatus >= 4)
            {
                this.flashStatus = 0;
                this.FlashTimer.Stop();
            }
            else
            {
                this.flashStatus++;
                if (this.flashStatus % 2 == 1)
                {
                    this.startBtn.BackColor = Color.LightYellow;
                    this.startBtn.Location = new Point(startBtn.Location.X - 1, startBtn.Location.Y - 1);
                    this.startBtn.Size = new Size(startBtn.Size.Width + 2, startBtn.Size.Height + 2);
                    this.startBtn.FlatAppearance.BorderSize = 1;
                }
                else
                {
                    this.startBtn.BackColor = Color.Bisque;
                    this.startBtn.Location = new Point(startBtn.Location.X + 1, startBtn.Location.Y + 1);
                    this.startBtn.Size = new Size(startBtn.Size.Width - 2, startBtn.Size.Height - 2);
                    this.startBtn.FlatAppearance.BorderSize = 0;
                }
            }
        }
    }
}
