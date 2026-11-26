using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using ChristianMatch.Games.Core;
using ChristianMatch.Games.FastMatch;

namespace ChristianMatch.FastMatch
{
    public partial class GameScene : Form
    {
        private string team1, team2, nameTeam1, nameTeam2;

        private Image imgTeam1, imgTeam2;

        private FastMatchGame game;

        private ViewConfig view;

        private Common.FastQuestionForm questionForm;

        public GameScene()
        {
            InitializeComponent();
        }

        public string Team1
        {
            set
            {
                this.team1 = value;
                this.nameTeam1 = Common.Characters.Instance[value].Name;
                this.imgTeam1 = Common.Characters.Instance[value].ImageLTR;
            }
        }

        public string Team2
        {
            set
            {
                this.team2 = value;
                this.nameTeam2 = Common.Characters.Instance[value].Name;
                this.imgTeam2 = Common.Characters.Instance[value].ImageRTL;
            }
        }

        public int PointsTeam1
        {
            get
            {
                return (this.game == null) ? 0 : this.game.ScoreTeam1;
            }
        }

        public int PointsTeam2
        {
            get
            {
                return (this.game == null) ? 0 : this.game.ScoreTeam2;
            }
        }

        public Config Config
        {
            set
            {
                this.view.LimitedTime = value.LimitedTime;
                this.view.Time = value.Time;

                FastMatchConfig gc = new FastMatchConfig();
                gc.Questionary = value.Questionarie;
                gc.EqualValue = value.EqualValue;
                gc.QuestionValue = value.QuestionValue;

                this.game = new FastMatchGame(gc);
                this.game.Start(this.team1, this.team2);

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
            if (this.game == null)
                return;

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
            e.Graphics.DrawString(this.game.ScoreTeam1.ToString(), points, pointBruch, midX - 225, midY - 250);
            e.Graphics.DrawString(this.game.ScoreTeam2.ToString(), points, pointBruch, midX + 175, midY - 250);
        }

        private void GameScene_Resize(object sender, EventArgs e)
        {
            int y = (this.bottomPanel.Height - this.startBtn.Height) / 2;
            this.startBtn.Location = new Point(200, y);
            this.endGameBtn.Location = new Point(this.bottomPanel.Width - this.endGameBtn.Width - 200, y);
        }

        private void endGameBtn_Click(object sender, EventArgs e)
        {
            if (this.game != null && (this.game.ScoreTeam1 != 0 || this.game.ScoreTeam2 != 0))
                this.GameOver();
            else
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        private void GameScene_Shown(object sender, EventArgs e)
        {
            this.FlashTimer.Start();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (this.game == null || this.game.IsFinished)
                return;

            // Prepare the question
            Common.Question q = this.game.NextQuestion();
            if (q == null)
            {
                MessageBox.Show(this, "Sorry.\nSe han agotado las preguntas...", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.GameOver();
                return;
            }

            this.questionForm.SetTheQuestion(q);
            System.Windows.Forms.DialogResult result = this.questionForm.ShowDialog(this);

            // Read the winner before restarting the form
            AnswerOutcome outcome;
            if (result != System.Windows.Forms.DialogResult.OK)
                outcome = AnswerOutcome.None;
            else if (this.questionForm.Winer == "team1")
                outcome = AnswerOutcome.Team1;
            else if (this.questionForm.Winer == "team2")
                outcome = AnswerOutcome.Team2;
            else
                outcome = AnswerOutcome.Both;

            this.game.Answer(outcome);

            this.questionForm.Restart();

            this.mainScene.Invalidate();

            if (this.game.IsFinished)
            {
                if (this.game.QuestionsExhausted)
                    MessageBox.Show(this, "Sorry.\nSe han agotado las preguntas...", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.GameOver();
            }
            else
                this.FlashTimer.Start();
        }

        private void GameOver()
        {
            this.game.Finish();

            if (this.game.IsTie)
                MessageBox.Show(this, "Juego terminado y EMPATADO.\n\n Buen trabajo equipos!!!", "Fin del Juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Common.WinnerForm winner = new Common.WinnerForm();
                winner.Winner = this.game.Winner;
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
