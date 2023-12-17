using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChristianMatch.WalkingUp
{
    public partial class GameScene : Form
    {
        private Image crown;

        private List<Point> polygon, positionsTeam1, positionsTeam2;

        private string team1, team2, nameTeam1, nameTeam2;

        private int posTeam1, posTeam2, steps;

        private Image imgTeam1, imgTeam2;

        private Config config;

        private Common.QForm questionForm;

        private Common.StepsSelector dialog;

        private Common.LevelQuestionsDispatcher dispatcher;

        public GameScene()
        {
            this.crown = Image.FromFile(System.Environment.CurrentDirectory + "\\resources\\images\\crown-sm.png");
            this.polygon = new List<Point>();
            this.positionsTeam1 = new List<Point>();
            this.positionsTeam2 = new List<Point>();

            InitializeComponent();

            this.posTeam1 = 0;
            this.posTeam2 = 0;

            this.dialog = new Common.StepsSelector();
            this.dispatcher = new Common.LevelQuestionsDispatcher();
        }

        public string Team1
        {
            set
            {
                this.team1 = value;
                this.nameTeam1 = Common.Characters.Instance[value].Name;
                this.imgTeam1 = Common.Characters.Instance[value].Image;
            }
        }

        public string Team2
        {
            set
            {
                this.team2 = value;
                this.nameTeam2 = Common.Characters.Instance[value].Name;
                this.imgTeam2 = Common.Characters.Instance[value].Image;
            }
        }

        public int PointsTeam1
        {
            get
            {
                return this.posTeam1 * 5;
            }
        }

        public int PointsTeam2
        {
            get
            {
                return this.posTeam2 * 5;
            }
        }

        public Config Config
        {
            set
            {
                this.config = value;
                this.dispatcher.Open(value.Questionarie);

                if (value.ShowPossibleAnswers)
                    this.questionForm = new Common.QuestionForm();
                else
                    this.questionForm = new Common.SimpleQuestionForm();

                if (value.LimitedTime)
                    this.questionForm.SetMaxTime(value.Time);

                this.steps = value.Steps;
                this.setSteps(this.steps);
            }
        }

        private void setSteps(int steps)
        {
            this.positionsTeam1.Clear();
            this.positionsTeam2.Clear();

            int level1, level2, level3, r;
            level1 = level2 = level3 = steps / 3;
            
            r = steps % 3;
            if (r != 0)
                level1++;
            if (r == 2)
                level2++;

            // Points of level 1
            int dx = this.Width / 4 - 2, dy = this.Height / 12 - 5;
            int xPos = dx / 10, yPos = dy / 10;
            int x1 = xPos, y1 = yPos;
            float xSteps = (dx - xPos) / level1, ySteps = (dy - yPos) / level1;

            this.positionsTeam1.Add(new Point(xPos, this.mainScene.Height * 10 / 12 - yPos));
            this.positionsTeam2.Add(new Point(this.mainScene.Width - xPos, this.mainScene.Height * 10 / 12 - yPos));
            for (int i = 1; i < level1; i++)
            {
                xPos = x1 + (int)(xSteps * i);
                yPos = y1 + (int)(ySteps * i);

                this.positionsTeam1.Add(new Point(xPos, this.mainScene.Height * 10 / 12 - yPos));
                this.positionsTeam2.Add(new Point(this.mainScene.Width - xPos, this.mainScene.Height * 10 / 12 - yPos));
            }

            // Points of level 2
            dx = this.Width / 5 - 20;
            dy = this.Height / 6 - 5;
            xPos = this.Width / 4;
            yPos = 0;
            x1 = xPos; y1 = yPos;
            xSteps = dx / level2;
            ySteps = dy / level2;

            this.positionsTeam1.Add(new Point(xPos, this.mainScene.Height * 9 / 12 - yPos));
            this.positionsTeam2.Add(new Point(this.mainScene.Width - xPos, this.mainScene.Height * 9 / 12 - yPos));
            for (int i = 1; i < level2; i++)
            {
                xPos = x1 + (int)(xSteps * i);
                yPos = y1 + (int)(ySteps * i);

                this.positionsTeam1.Add(new Point(xPos, this.mainScene.Height * 9 / 12 - yPos));
                this.positionsTeam2.Add(new Point(this.mainScene.Width - xPos, this.mainScene.Height * 9 / 12 - yPos));
            }

            // Points of level 3
            dx = this.Width / 12;
            dy = this.Height / 6;
            xPos = this.Width * 5 / 12;
            yPos = 0;
            x1 = xPos; y1 = yPos;
            xSteps = dx / level3;
            ySteps = dy / level3;

            this.positionsTeam1.Add(new Point(xPos, this.mainScene.Height * 7 / 12 - yPos));
            this.positionsTeam2.Add(new Point(this.mainScene.Width - xPos, this.mainScene.Height * 7 / 12 - yPos));
            for (int i = 1; i < level3; i++)
            {
                xPos = x1 + (int)(xSteps * i);
                yPos = y1 + (int)(ySteps * i);

                this.positionsTeam1.Add(new Point(xPos, this.mainScene.Height * 7 / 12 - yPos));
                this.positionsTeam2.Add(new Point(this.mainScene.Width - xPos, this.mainScene.Height * 7 / 12 - yPos));
            }

        }

        private void mainScene_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            // Draw the crown
            e.Graphics.DrawImage(this.crown, (this.mainScene.Width / 2) - 35, (this.mainScene.Height * 5 / 12) - 43, 71, 50);

            // Draw th mountain
            Brush b = new SolidBrush(Color.ForestGreen);
            e.Graphics.FillClosedCurve(b, this.polygon.ToArray());

            Pen p = new Pen(Color.Black, 2);
            Brush white = new SolidBrush(Color.White);
            Brush namesBruch = new SolidBrush(Color.Navy);
            Font f = new Font(new FontFamily("Forte"), 25, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw position of team 1
            e.Graphics.DrawImage(this.imgTeam1, 40, this.topLabel.Height + 30, this.mainScene.Width / 5, this.mainScene.Width / 5);
            e.Graphics.DrawString(this.nameTeam1, f, namesBruch, (this.mainScene.Width / 10) - 10, this.topLabel.Height + 25 + this.mainScene.Width / 5);

            Point pos = this.positionsTeam1[this.posTeam1];
            List<Point> list = new List<Point>();
            list.Add(pos);
            list.Add(new Point(pos.X - 15, pos.Y - 33));
            list.Add(new Point(pos.X + 15, pos.Y - 33));
            list.Add(pos);
            b = new SolidBrush(Color.Blue);
            e.Graphics.FillClosedCurve(b, list.ToArray(), System.Drawing.Drawing2D.FillMode.Alternate);
            e.Graphics.FillEllipse(b, pos.X - 15, pos.Y - 50, 30, 30);
            e.Graphics.FillEllipse(white, pos.X - 12, pos.Y - 47, 24, 24);

            // Draw position of team 2
            e.Graphics.DrawImage(this.imgTeam2, this.mainScene.Width - (this.mainScene.Width / 5) - 40, this.topLabel.Height + 30, this.mainScene.Width / 5, this.mainScene.Width / 5);
            e.Graphics.DrawString(this.nameTeam2, f, namesBruch, this.mainScene.Width - (this.mainScene.Width / 10) - 100, this.topLabel.Height + 25 + this.mainScene.Width / 5);

            pos = this.positionsTeam2[this.posTeam2];
            list.Clear();
            list.Add(pos);
            list.Add(new Point(pos.X - 15, pos.Y - 33));
            list.Add(new Point(pos.X + 15, pos.Y - 33));
            list.Add(pos);
            b = new SolidBrush(Color.Red);
            e.Graphics.FillClosedCurve(b, list.ToArray(), System.Drawing.Drawing2D.FillMode.Alternate);
            e.Graphics.FillEllipse(b, pos.X - 15, pos.Y - 50, 30, 30);
            e.Graphics.FillEllipse(white, pos.X - 12, pos.Y - 47, 24, 24);

        }

        private void endGameBtn_Click(object sender, EventArgs e)
        {
            if (this.posTeam1 != 0 || this.posTeam2 != 0)
                this.GameOver();
            else
                this.DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        private void GameScene_Resize(object sender, EventArgs e)
        {
            int y = (this.bottomPanel.Height - this.startBtn.Height) / 2;
            this.startBtn.Location = new Point(200, y);
            this.endGameBtn.Location = new Point(this.bottomPanel.Width - this.endGameBtn.Width - 200, y);

            this.polygon.Clear();
            this.polygon.Add(new Point(0, this.mainScene.Height));
            this.polygon.Add(new Point(0, this.mainScene.Height * 10 / 12));
            this.polygon.Add(new Point(this.mainScene.Width * 3 / 12, this.mainScene.Height * 9 / 12));
            this.polygon.Add(new Point(this.mainScene.Width * 5 / 12, this.mainScene.Height * 7 / 12));

            this.polygon.Add(new Point(this.mainScene.Width * 6 / 12, this.mainScene.Height * 5 / 12));

            this.polygon.Add(new Point(this.mainScene.Width * 7 / 12, this.mainScene.Height * 7 / 12));
            this.polygon.Add(new Point(this.mainScene.Width * 9 / 12, this.mainScene.Height * 9 / 12));
            this.polygon.Add(new Point(this.mainScene.Width, this.mainScene.Height * 10 / 12));
            this.polygon.Add(new Point(this.mainScene.Width, this.mainScene.Height));
            this.polygon.Add(new Point(0, this.mainScene.Height));

            if(this.steps != 0)
                this.setSteps(this.steps + 1);
        }

        private int calculateLevel(int steps, int position)
        {
            int level1, level2, r;
            level1 = level2 = steps / 3;

            r = steps % 3;
            if (r != 0) level1++;
            if (r == 2) level2++;

            level2 += level1;
            if (position <= level1) return 1;
            if (position <= level2) return 2;
            return 3;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            //// Playing team1
            // Calculate level
            int level = this.calculateLevel(this.steps, this.posTeam1);
            // Set team
            this.dialog.Team = this.team1;
            // Disable empty levels
            this.dialog.Reset();
            if (!this.dispatcher.isAllowed(level)) this.dialog.DisableSteps(1);
            if (!this.dispatcher.isAllowed(level + 1)) this.dialog.DisableSteps(2);
            if (!this.dispatcher.isAllowed(level + 2)) this.dialog.DisableSteps(3);

            this.dialog.ShowDialog(this);
            int steps = this.dialog.Steps;
            level = level + steps - 1;

            // Prepare the first quiestion
            Common.Question q = this.dispatcher.GetNext(level);
            this.questionForm.SetTheQuestion(q);
            System.Windows.Forms.DialogResult result = this.questionForm.ShowDialog(this);
            if (result == System.Windows.Forms.DialogResult.OK)
                this.posTeam1 = Math.Min(this.steps, this.posTeam1 + steps);
            else
            {
                if (steps == 3)
                    this.posTeam1 = Math.Max(0,  this.posTeam1 - 2);
                else
                    this.posTeam1 = Math.Max(0, this.posTeam1 - 1);
            }

            this.questionForm.Restart();
            this.mainScene.Invalidate();

            // The team 1 win
            if (this.posTeam1 == this.steps && this.posTeam2 < this.steps - 3)
            {
                this.startBtn.Enabled = false;

                Common.WinnerForm winner = new Common.WinnerForm();
                winner.Winner = this.team1;
                winner.ShowDialog();
                return;
            }

            System.Threading.Thread.Sleep(1300);

            //// Playing team2
            // Calculate level
            level = this.calculateLevel(this.steps, this.posTeam2);
            // Set team
            this.dialog.Team = this.team2;
            // Disable empty levels
            this.dialog.Reset();
            if (!this.dispatcher.isAllowed(level)) this.dialog.DisableSteps(1);
            if (!this.dispatcher.isAllowed(level + 1)) this.dialog.DisableSteps(2);
            if (!this.dispatcher.isAllowed(level + 2)) this.dialog.DisableSteps(3);

            this.dialog.ShowDialog(this);
            steps = this.dialog.Steps;
            level = level + steps - 1;

            // Prepare the first quiestion
            q = this.dispatcher.GetNext(level);
            this.questionForm.SetTheQuestion(q);
            result = this.questionForm.ShowDialog(this);
            if (result == System.Windows.Forms.DialogResult.OK)
                this.posTeam2 = Math.Min(this.steps, this.posTeam2 + steps);
            else
            {
                if (steps == 3)
                    this.posTeam2 = Math.Max(0, this.posTeam2 - 2);
                else
                    this.posTeam2 = Math.Max(0, this.posTeam2 - 1);
            }

            this.questionForm.Restart();

            this.mainScene.Invalidate();
            
            // End of game
            if (this.posTeam1 == this.steps || this.posTeam2 == this.steps)
                this.GameOver();

            // Check the questionary is not empty
            if (this.dispatcher.Remainder <= 2)
            {
                MessageBox.Show(this, "Lo sentimos.\nLas preguntas se han agotado...", "Upsss...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.GameOver();
            }
            else
                this.FlashTimer.Start();
        }

        private void GameOver()
        {
            if (this.posTeam1 == this.posTeam2)
                MessageBox.Show(this, "Juego terminado y EMPATADO.\n\n Buen trabajo equipos!!!", "Fin del Juego", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                Common.WinnerForm winner = new Common.WinnerForm();
                winner.Winner = (this.posTeam1 > this.posTeam2) ? this.team1 : this.team2;
                winner.ShowDialog();
            }

            this.DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        int flashStatus = 0;

        private void FlashTimer_Tick(object sender, EventArgs e)
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

        private void GameScene_Shown(object sender, EventArgs e)
        {
            this.FlashTimer.Start();
        }
    }
}
