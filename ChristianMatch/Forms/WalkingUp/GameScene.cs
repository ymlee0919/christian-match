using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using ChristianMatch.Games.Core;
using ChristianMatch.Games.WalkingUp;

namespace ChristianMatch.WalkingUp
{
    public partial class GameScene : Form
    {
        private Image crown;

        private List<Point> polygon, positionsTeam1, positionsTeam2;

        private string team1, team2, nameTeam1, nameTeam2;

        private Image imgTeam1, imgTeam2;

        private WalkingUpGame game;

        private ViewConfig view;

        private Common.QForm questionForm;

        private Common.StepsSelector dialog;

        private int steps;

        private Image blockTexture;

        public GameScene()
        {
            this.crown = Image.FromFile(System.Environment.CurrentDirectory + "\\resources\\images\\crown-sm.png");
            this.polygon = new List<Point>();
            this.positionsTeam1 = new List<Point>();
            this.positionsTeam2 = new List<Point>();
            this.blockTexture = null;

            InitializeComponent();

            this.dialog = new Common.StepsSelector();
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
                this.view.ShowPossibleAnswers = value.ShowPossibleAnswers;
                this.view.LimitedTime = value.LimitedTime;
                this.view.Time = value.Time;

                WalkingUpConfig gc = new WalkingUpConfig();
                gc.Questionary = value.Questionarie;
                gc.Steps = value.Steps;

                this.game = new WalkingUpGame(gc);
                this.game.Start(this.team1, this.team2);

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

            // Pyramid steps

            // === Parámetros configurables ===
            int levels = this.steps + 1;
            int margin = 10;             // margin alrededor de la pirámide (px)
            int crownHeight = 50;

            // === Área útil ===
            int W = this.mainScene.ClientSize.Width - 2 * margin;
            int H = this.mainScene.ClientSize.Height - crownHeight - 2 * margin;
            if (W <= 0 || H <= 0 || this.steps < 1) return;

            float blockAspect = (float)(W) / (float)(H);
            // === Tamaño de bloque que se ajusta al espacio disponible ===
            float bw = Math.Min(W / (float)levels, H * blockAspect / levels);
            float bh = bw / blockAspect;

            float totalWidth = levels * bw;
            float totalHeight = levels * bh;
            float startX = (this.mainScene.ClientSize.Width - totalWidth) / 2f;
            float startY = (this.mainScene.ClientSize.Height - totalHeight) / 2f + crownHeight - margin / 2;

            // Recorremos this.steps: i = 0 es la cima, i = this.steps-1 es la base
            for (int i = 0; i < levels; i++)
            {
                int levelBlocks = i + 1;
                float anchoNivel = levelBlocks * bw;

                // Centrado horizontal del nivel
                float nivelX = startX + (totalWidth - anchoNivel) / 2f;
                float nivelY = startY + i * bh;
                float x1Pos = nivelX;
                float x2Pos = nivelX + (levelBlocks - 1) * bw;

                this.positionsTeam1.Add(new Point((int)(x1Pos + bw / 4), (int)nivelY - 2));
                this.positionsTeam2.Add(new Point((int)(x2Pos + bw * 3 / 4), (int)nivelY - 2));
            }
            
            this.positionsTeam1.Reverse();
            this.positionsTeam2.Reverse();
        }

        private void mainScene_Paint(object sender, PaintEventArgs e)
        {
            if (this.game == null)
                return;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            // Draw pyramid
            // === Parámetros configurables ===
            int levels = this.steps + 1;
            int margin = 10;             // margin alrededor de la pirámide (px)
            int crownHeight = 50;

            // === Área útil ===
            int W = this.mainScene.ClientSize.Width - 2 * margin;
            int H = this.mainScene.ClientSize.Height - crownHeight - margin * 2;
            if (W <= 0 || H <= 0 || this.steps < 1) return;

            float blockAspect = (float)(W) / (float)(H);
            // === Tamaño de bloque que se ajusta al espacio disponible ===
            float bw = Math.Min(W / (float)levels, H * blockAspect / levels);
            float bh = bw / blockAspect;

            float totalWidth = levels * bw;
            float totalHeight = levels * bh;
            float startX = (this.mainScene.ClientSize.Width - totalWidth) / 2f;
            float startY = (this.mainScene.ClientSize.Height - totalHeight) / 2f + crownHeight - margin / 2;

            using (TextureBrush texture = new TextureBrush(this.blockTexture))
            using (Pen borde = new Pen(Color.Black, 2f))
            {
                // textura.WrapMode = WrapMode.Tile; // opcional

                // Recorremos this.steps: i = 0 es la cima, i = this.steps-1 es la base
                for (int i = 0; i < this.steps; i++)
                {
                    int levelBlocks= i + 1;
                    float anchoNivel = levelBlocks * bw;

                    // Centrado horizontal del nivel
                    float nivelX = startX + (totalWidth - anchoNivel) / 2f;
                    float nivelY = startY + i * bh;

                    for (int j = 0; j < levelBlocks; j++)
                    {
                        float bx = nivelX + j * bw;
                        RectangleF block = new RectangleF(bx, nivelY, bw, bh);

                        // 1) Relleno con textura
                        e.Graphics.FillRectangle(texture, block);

                        // 2) Borde gris oscuro de 2 px
                        e.Graphics.DrawRectangle(borde, block.X, block.Y, block.Width, block.Height);
                    }
                }
            }

            Pen p = new Pen(Color.Black, 2);
            Brush white = new SolidBrush(Color.White);
            Brush name1Bruch = new SolidBrush(Color.Navy);
            Brush name2Bruch = new SolidBrush(Color.DarkRed);
            Font f = new Font(new FontFamily("Forte"), 25, FontStyle.Bold, GraphicsUnit.Pixel);

            // Draw position of team 1
            e.Graphics.DrawImage(this.imgTeam1, 40, this.topLabel.Height + 30, this.mainScene.Width / 5, this.mainScene.Width / 5);
            e.Graphics.DrawString(this.nameTeam1, f, name1Bruch, (this.mainScene.Width / 10) - 10, this.topLabel.Height + 25 + this.mainScene.Width / 5);

            List<Point> list = new List<Point>();

            Point pos = this.positionsTeam1[this.game.PositionTeam1];
            //foreach (Point pos in this.positionsTeam1) {
                list.Clear();
                list.Add(pos);
                list.Add(new Point(pos.X - 15, pos.Y - 33));
                list.Add(new Point(pos.X + 15, pos.Y - 33));
                list.Add(pos);
                e.Graphics.FillClosedCurve(name1Bruch, list.ToArray(), System.Drawing.Drawing2D.FillMode.Alternate);
                e.Graphics.FillEllipse(name1Bruch, pos.X - 15, pos.Y - 50, 30, 30);
                e.Graphics.FillEllipse(white, pos.X - 12, pos.Y - 47, 24, 24);
            //}
            
            
            // Draw position of team 2
            e.Graphics.DrawImage(this.imgTeam2, this.mainScene.Width - (this.mainScene.Width / 5) - 40, this.topLabel.Height + 30, this.mainScene.Width / 5, this.mainScene.Width / 5);
            e.Graphics.DrawString(this.nameTeam2, f, name2Bruch, this.mainScene.Width - (this.mainScene.Width / 10) - 100, this.topLabel.Height + 25 + this.mainScene.Width / 5);

            pos = this.positionsTeam2[this.game.PositionTeam2];
            //foreach (Point pos in this.positionsTeam2) {
                list.Clear();
                list.Add(pos);
                list.Add(new Point(pos.X - 15, pos.Y - 33));
                list.Add(new Point(pos.X + 15, pos.Y - 33));
                list.Add(pos);
                e.Graphics.FillClosedCurve(name2Bruch, list.ToArray(), System.Drawing.Drawing2D.FillMode.Alternate);
                e.Graphics.FillEllipse(name2Bruch, pos.X - 15, pos.Y - 50, 30, 30);
                e.Graphics.FillEllipse(white, pos.X - 12, pos.Y - 47, 24, 24);
            //}
            

            // Draw the crown
            e.Graphics.DrawImage(this.crown, (this.mainScene.Width / 2) - 35, 10, 71, crownHeight);
            
            
        }

        private void endGameBtn_Click(object sender, EventArgs e)
        {
            if (this.game != null && (this.game.ScoreTeam1 != 0 || this.game.ScoreTeam2 != 0))
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

            if (this.steps != 0)
                this.setSteps(this.steps + 1);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (this.game == null || this.game.IsFinished)
                return;

            // Playing team 1
            if (!this.PlayTurn())
                return;

            if (this.game.IsFinished)
            {
                if (this.game.QuestionsExhausted)
                    MessageBox.Show(this, "Sorry.\nSe han agotado las preguntas...", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    Common.WinnerForm winner = new Common.WinnerForm();
                    winner.Winner = this.game.Winner;
                    winner.ShowDialog();
                }
                this.startBtn.Enabled = false;
                this.GameOver();
                return;
            }

            System.Threading.Thread.Sleep(1300);

            // Playing team 2
            if (!this.PlayTurn())
                return;

            if (this.game.IsFinished)
            {
                if (this.game.QuestionsExhausted)
                    MessageBox.Show(this, "Sorry.\nSe han agotado las preguntas...", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.GameOver();
            }
            else
                this.FlashTimer.Start();
        }

        private bool PlayTurn()
        {
            this.dialog.Team = this.game.CurrentTeam;
            this.dialog.Reset();

            // Disable steps without questions
            bool[] allowed = this.game.GetAllowedSteps();
            if (!allowed[0])
                this.dialog.DisableSteps(1);
            if (!allowed[1])
                this.dialog.DisableSteps(2);
            if (!allowed[2])
                this.dialog.DisableSteps(3);

            this.dialog.ShowDialog(this);
            int stepCount = this.dialog.Steps;

            // The selector was closed without choosing steps
            if (stepCount < 1 || stepCount > 3)
                return false;

            Common.Question q = this.game.NextQuestion(stepCount);
            if (q == null)
            {
                MessageBox.Show(this, "Sorry.\nSe han agotado las preguntas...", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.GameOver();
                return false;
            }

            this.questionForm.SetTheQuestion(q);
            System.Windows.Forms.DialogResult result = this.questionForm.ShowDialog(this);
            if (result == System.Windows.Forms.DialogResult.OK)
                this.game.Answer(AnswerOutcome.Correct);
            else
                this.game.Answer(AnswerOutcome.Incorrect);

            this.questionForm.Restart();

            this.mainScene.Invalidate();
            return true;
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

        private void GameScene_Load(object sender, EventArgs e)
        {
            this.blockTexture = Image.FromFile(System.Environment.CurrentDirectory + "\\resources\\textures\\block-texture.jpg");
        }

        private void GameScene_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.blockTexture != null) this.blockTexture.Dispose();
        }
    }
}
