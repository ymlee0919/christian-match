using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using ChristianMatch.Games.Baseball;
using ChristianMatch.Games.Core;

namespace ChristianMatch.Baseball
{
    public partial class GameScene : Form
    {
        private List<Point> yard;
        private List<Point> topLimit;
        private List<Point> bases;
        private List<Point> inField;

        private Dictionary<string, Image> players;

        private Dictionary<string, Image> teams;

        private HitSelector selector;

        private string team1, team2;

        private BaseballGame game;

        private ViewConfig view;

        private Common.QForm questionForm;

        private Common.TeamReadyDialog dialog;

        private Image sandTextureImage, wallTextureImage, grassTextureImage;

        public GameScene()
        {
            this.yard = new List<Point>();
            this.topLimit = new List<Point>();
            this.bases = new List<Point>();
            this.inField = new List<Point>();

            this.players = new Dictionary<string, Image>();
            this.teams = new Dictionary<string, Image>();
            string dir = System.Environment.CurrentDirectory + "\\resources\\images\\";

            this.players["Catcher"] = Image.FromFile(dir + "bb-catcher.png");
            this.players["Pitcher"] = Image.FromFile(dir + "bb-pitcher.png");
            this.players["FirstBase"] = Image.FromFile(dir + "bb-base1.png");
            this.players["SecondBase"] = Image.FromFile(dir + "bb-base2.png");
            this.players["MiddleBase"] = Image.FromFile(dir + "bb-base-middle.png");
            this.players["ThirdBase"] = Image.FromFile(dir + "bb-base3.png");
            this.players["CenterField"] = Image.FromFile(dir + "bb-field-c.png");
            this.players["LeftField"] = Image.FromFile(dir + "bb-field-l.png");
            this.players["RightField"] = Image.FromFile(dir + "bb-field-r.png");
            this.players["Batter"] = Image.FromFile(dir + "bb-batter.png");
            this.players["Runner"] = Image.FromFile(dir + "bb-runner.png");
            this.players["Bat"] = Image.FromFile(dir + "bb-bat.png");
            this.players["Mitt"] = Image.FromFile(dir + "bb-mitt.png");

            this.selector = new HitSelector();

            this.team1 = this.team2 = null;
            this.sandTextureImage = this.grassTextureImage = this.wallTextureImage = null;

            this.dialog = new Common.TeamReadyDialog();

            InitializeComponent();
        }

        public string Team1
        {
            set
            {
                this.team1 = value;
                this.teams[value] = Common.Characters.Instance[value].ImageLTR;
            }
        }

        public string Team2
        {
            set
            {
                this.team2 = value;
                this.teams[value] = Common.Characters.Instance[value].ImageRTL;
            }
        }

        public Config Config
        {
            set
            {
                this.view.ShowPossibleAnswers = value.ShowPossibleAnswers;
                this.view.LimitedTime = value.LimitedTime;
                this.view.Time = value.Time;

                BaseballConfig gc = new BaseballConfig();
                gc.Questionary = value.Questionarie;
                gc.Innings = value.Innings;

                this.game = new BaseballGame(gc);
                this.game.Start(this.team1, this.team2);

                if (value.ShowPossibleAnswers)
                    this.questionForm = new Common.QuestionForm();
                else
                    this.questionForm = new Common.SimpleQuestionForm();

                if (value.LimitedTime)
                    this.questionForm.SetMaxTime(value.Time);

                // Disable the hit levels without questions in the questionary
                int[] availableLevels = this.game.GetAvailableHitLevels();
                for (int level = 1; level <= 5; level++)
                {
                    bool available = false;
                    foreach (int l in availableLevels)
                    {
                        if (l == level)
                        {
                            available = true;
                            break;
                        }
                    }
                    if (!available)
                        this.selector.DisableHitType(level);
                }
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

        private void GameScene_Resize(object sender, EventArgs e)
        {
            this.yard.Clear();
            this.topLimit.Clear();
            this.bases.Clear();
            this.inField.Clear();

            // Calculate the positions of items
            int width = this.ClientSize.Width, height = this.ClientSize.Height;

            // Set the run label
            this.raceLabel.Location = new Point(width / 2 - this.raceLabel.Width / 2, height / 4 - this.raceLabel.Height / 2);

            // Set the top limit
            this.topLimit.Add(new Point(0, height * 5 / 12));
            this.topLimit.Add(new Point(width / 3, height / 3));
            this.topLimit.Add(new Point(width * 2 / 3, height / 3));
            this.topLimit.Add(new Point(width, height * 5 / 12));
            this.topLimit.Add(new Point(width, height / 3));
            this.topLimit.Add(new Point(width * 2 / 3, height / 4));
            this.topLimit.Add(new Point(width / 3, height / 4));
            this.topLimit.Add(new Point(0, height / 3));
            this.topLimit.Add(new Point(0, height * 5 / 12));

            // Set the yard
            this.yard.Add(new Point(0, height * 5 / 12));
            this.yard.Add(new Point(width / 3, height / 3));
            this.yard.Add(new Point(width * 2 / 3, height / 3));
            this.yard.Add(new Point(width, height * 5 / 12));
            this.yard.Add(new Point(width, height));
            this.yard.Add(new Point(0, height));
            this.yard.Add(new Point(0, height / 3));

            // Set the bases, the first, index 0 is home
            this.bases.Add(new Point(width / 2, height * 11 / 12));
            this.bases.Add(new Point(width * 3 / 4, height * 2 / 3));
            this.bases.Add(new Point(width / 2, height * 7 / 12 - height / 36));
            this.bases.Add(new Point(width / 4, height * 2 / 3));

            // Calculate the in field rectangle
            this.inField.Add(new Point(width / 2, height * 11 / 12 - 15));
            this.inField.Add(new Point(width * 3 / 4 - width / 30, height * 2 / 3 + height / 60));
            this.inField.Add(new Point(width / 2, height * 7 / 12 - height / 36));
            this.inField.Add(new Point(width / 4 + width / 30, height * 2 / 3 + height / 60));

            this.startBtn.Location = new Point(width / 9, height * 7 / 8);

            //this.endBtn.Location = new Point(width * 8 / 9 - this.endBtn.Width, height * 7 / 8);
            this.endBtn.Location = new Point(this.Width - this.endBtn.Width - 3, 3);

            this.mainScene.Invalidate();
        }

        private void mainScene_Paint(object sender, PaintEventArgs e)
        {
            if (this.game == null)
                return;

            e.Graphics.Clear(Color.White);

            // Prepare canvas
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            // Prepare tools
            Brush background = new SolidBrush(Color.White);
            //Brush yardBrush = new SolidBrush(Color.Green);
            TextureBrush yardBrush = new TextureBrush(this.grassTextureImage);
            //Brush wall = new SolidBrush(Color.Gray);
            TextureBrush wall = new TextureBrush(this.wallTextureImage);
            //Brush soil = new SolidBrush(Color.LightSalmon);
            TextureBrush soil= new TextureBrush(this.sandTextureImage);
            
            Brush board = new SolidBrush(Color.Black);
            Brush races = new SolidBrush(Color.Yellow);

            Pen border = new Pen(Color.Black, 2);
            Pen lines = new Pen(Color.White, 3);
            Pen batterCircle = new Pen(Color.YellowGreen, 8);
            Pen coveringCircle = new Pen(Color.ForestGreen, 8);
            Pen marker = new Pen(Color.Gray, 2);

            int width = this.ClientSize.Width, height = this.ClientSize.Height;

            e.Graphics.FillRectangle(background, 0, 0, this.mainScene.Width, this.mainScene.Height);

            // Draw the yard
            e.Graphics.FillPolygon(yardBrush, this.yard.ToArray());

            // Draw the top wall
            e.Graphics.FillPolygon(wall, this.topLimit.ToArray());
            e.Graphics.DrawPolygon(border, this.topLimit.ToArray());
            e.Graphics.DrawLine(border, this.topLimit[1], this.topLimit[6]);
            e.Graphics.DrawLine(border, this.topLimit[2], this.topLimit[5]);

            // Draw the center soil
            // Calculate the angle
            double ang = Math.Atan((double)height / (double)width);
            ang = ang * 180 / Math.PI;

            e.Graphics.FillPie(soil, -20, height / 2 - height / 24, width + 40, height * 6 / 7 + height / 12 + 20, 180 + (int)ang, 180 - 2 * (int)ang);

            // Draw the inField
            e.Graphics.FillPolygon(yardBrush, this.inField.ToArray());

            // Draw the home circle
            e.Graphics.FillEllipse(soil, (width / 2) - (width / 16), this.bases[0].Y - (height / 18), width / 8, height / 9);
            // Draw second base circle
            e.Graphics.FillEllipse(soil, this.bases[2].X - (width / 36), this.bases[2].Y - (height / 48), width / 18, height / 24);
            // Draw center circle into inField
            e.Graphics.FillEllipse(soil, this.bases[0].X - (width / 36), this.bases[1].Y + (height / 48), width / 18, height / 24);

            //// Locate bases
            List<Point> points = new List<Point>();
            // First base
            points.Add(this.bases[1]);
            points.Add(new Point(this.bases[1].X - width / 60 + 2, this.bases[1].Y + height / 80));
            points.Add(new Point(this.bases[1].X - width / 30, this.bases[1].Y + 3));
            points.Add(new Point(this.bases[1].X - width / 60 - 2, this.bases[1].Y - height / 80 + 2));
            e.Graphics.FillPolygon(background, points.ToArray());

            // Second base
            points.Clear();
            points.Add(new Point(this.bases[2].X + width / 60, this.bases[2].Y));
            points.Add(new Point(this.bases[2].X, this.bases[2].Y + height / 100));
            points.Add(new Point(this.bases[2].X - width / 60, this.bases[2].Y));
            points.Add(new Point(this.bases[2].X, this.bases[2].Y - height / 100));
            e.Graphics.FillPolygon(background, points.ToArray());

            // Third base
            points.Clear();
            points.Add(this.bases[3]);
            points.Add(new Point(this.bases[3].X + width / 60 - 2, this.bases[3].Y + height / 80));
            points.Add(new Point(this.bases[3].X + width / 30, this.bases[3].Y + 3));
            points.Add(new Point(this.bases[3].X + width / 60 + 2, this.bases[3].Y - height / 80 + 2));
            e.Graphics.FillPolygon(background, points.ToArray());

            // Home base
            points.Clear();
            points.Add(new Point(this.bases[0].X - width / 120, this.bases[0].Y - height / 120));
            points.Add(new Point(this.bases[0].X + width / 120, this.bases[0].Y - height / 120));
            points.Add(new Point(this.bases[0].X + width / 120, this.bases[0].Y + height / 120));
            points.Add(new Point(this.bases[0].X, this.bases[0].Y + height / 60));
            points.Add(new Point(this.bases[0].X - width / 120, this.bases[0].Y + height / 120));
            e.Graphics.FillPolygon(background, points.ToArray());

            // Draw lateral lines
            e.Graphics.DrawLine(lines, this.topLimit[0], this.bases[0]);
            e.Graphics.DrawLine(lines, this.topLimit[3], this.bases[0]);

            //// Locate players (90px X 130px)
            int h = this.mainScene.Height / 10; int w = 5 * h / 8;
            // Pitcher
            e.Graphics.DrawImage(this.players["Pitcher"], this.bases[0].X - (w / 2), this.bases[1].Y - w * 3 / 4, w, h);
            // Catcher
            e.Graphics.DrawImage(this.players["Catcher"], this.bases[0].X - (w / 2), this.bases[0].Y - h / 3, w, h);
            // First Base
            e.Graphics.DrawImage(this.players["FirstBase"], this.bases[1].X - ((this.bases[1].X - this.bases[2].X) / 4) - (w / 2), this.bases[1].Y - 5 * ((this.bases[1].Y - this.bases[2].Y) / 4) - (h / 3), w, h);
            // Second Base
            e.Graphics.DrawImage(this.players["SecondBase"], this.bases[2].X + ((this.bases[1].X - this.bases[2].X) / 4) - (w / 2), this.bases[2].Y - 3 * ((this.bases[1].Y - this.bases[2].Y) / 4) - (h / 3), w, h);
            // Middle Base
            e.Graphics.DrawImage(this.players["MiddleBase"], this.bases[2].X - ((this.bases[1].X - this.bases[2].X) / 4) - w, this.bases[2].Y - 3 * ((this.bases[1].Y - this.bases[2].Y) / 4) - (h / 3), w, h);
            // Third Base
            e.Graphics.DrawImage(this.players["ThirdBase"], this.bases[3].X + ((this.bases[2].X - this.bases[3].X) / 4) - (w / 2), this.bases[3].Y + 5 * ((this.bases[2].Y - this.bases[3].Y) / 4) - (h / 3), w, h);
            // Center field
            e.Graphics.DrawImage(this.players["CenterField"], width / 2 - (w / 2), (height / 3) - (h / 3), w, h);
            // Left field
            e.Graphics.DrawImage(this.players["LeftField"], width / 4 - (w / 2), (height * 3 / 8) - (h / 3), w, h);
            // Right field
            e.Graphics.DrawImage(this.players["RightField"], width * 3 / 4 - (w / 2), (height * 3 / 8) - (h / 3), w, h);
            // Batter
            e.Graphics.DrawImage(this.players["Batter"], this.bases[0].X - (w * 6 / 5), this.bases[0].Y - h * 4 / 5, w, h);

            // Draw runners
            if (this.game.BaseBusy(1))
                e.Graphics.DrawImage(this.players["Runner"], this.bases[1].X - w, this.bases[1].Y - h, w, h);
            if (this.game.BaseBusy(2))
                e.Graphics.DrawImage(this.players["Runner"], this.bases[2].X - w / 2, this.bases[2].Y - h, w, h);
            if (this.game.BaseBusy(3))
                e.Graphics.DrawImage(this.players["Runner"], this.bases[3].X, this.bases[3].Y - h, w, h);

            // Draw batter circle
            e.Graphics.DrawEllipse(this.game.BatterTeam == this.team1 ? batterCircle : coveringCircle, width / 10, height * 9 / 13, width / 8, height / 9);
            e.Graphics.DrawEllipse(this.game.BatterTeam == this.team2 ? batterCircle : coveringCircle, width * 9 / 10 - width / 8, height * 9 / 13, width / 8, height / 9);

            // Draw number of outs
            if (this.game.Outs > 0)
            {
                Font outs = new Font(new FontFamily("Courier New"), 22, FontStyle.Bold, GraphicsUnit.Pixel);
                string outsTxt = (this.game.Outs == 1) ? "1 out" : "2 outs";
                SizeF sz = e.Graphics.MeasureString(outsTxt, outs);
                float outsXPos = this.game.BatterTeam == this.team1 
                    ? width / 10 + width / 16 - sz.Width / 2
                    : width * 9 / 10 - width / 8 + width / 16 - sz.Width / 2;
                e.Graphics.DrawString(outsTxt, outs, soil, outsXPos, height * 9 / 13 + height / 20 + sz.Height * 2);
            }

            // Draw the name of the teams
            Font f = new Font(new FontFamily("Forte"), 25, FontStyle.Bold, GraphicsUnit.Pixel);

            //string team = Common.Characters.Instance[this.game.BatterTeam].Name;
            string team = Common.Characters.Instance[this.team1].Name;
            SizeF s = e.Graphics.MeasureString(team, f);
            e.Graphics.DrawString(team, f, background, width / 10 + width / 16 - s.Width / 2, height * 9 / 13 + height / 27);

            //team = Common.Characters.Instance[this.game.CoverTeam].Name;
            team = Common.Characters.Instance[this.team2].Name;
            s = e.Graphics.MeasureString(team, f);
            e.Graphics.DrawString(team, f, background, width * 9 / 10 - width / 8 + width / 16 - s.Width / 2, height * 9 / 13 + height / 27);

            // Draw the images of the teams
            //e.Graphics.DrawImage(this.teams[this.game.BatterTeam], width / 13, height / 15, width / 10, width / 10);
            e.Graphics.DrawImage(this.teams[this.team1], width / 13, height / 15, width / 10, width / 10);
            //e.Graphics.DrawImage(this.teams[this.game.CoverTeam], width * 12 / 13 - width / 10, height / 15, width / 10, width / 10);
            e.Graphics.DrawImage(this.teams[this.team2], width * 12 / 13 - width / 10, height / 15, width / 10, width / 10);

            e.Graphics.DrawImage(this.players[this.game.BatterTeam == this.team1 ? "Bat" : "Mitt"], width / 13 + width / 20, height / 15 + width / 24, width / 15, width / 15);
            e.Graphics.DrawImage(this.players[this.game.BatterTeam == this.team2 ? "Bat" : "Mitt"], width * 12 / 13 - width / 10 - width / 20, height / 15 + width / 24, width / 15, width / 15);

            width = this.ClientSize.Width;
            this.startBtn.Location = new Point(this.game.BatterTeam == this.team1 ? width / 9 : width * 8 / 9 - this.startBtn.Width, height * 7 / 8);

            //// Draw scoreboard
            Font score = new Font(new FontFamily("Courier New"), 20, FontStyle.Bold, GraphicsUnit.Pixel);
            // Draw the rectangle
            points.Clear();
            points.Add(new Point(width * 7 / 24, height * 5 / 24));
            points.Add(new Point(width * 17 / 24, height * 5 / 24));
            points.Add(new Point(width * 17 / 24, height / 36));
            points.Add(new Point(width * 7 / 24, height / 36));
            e.Graphics.FillPolygon(board, points.ToArray());
            e.Graphics.DrawRectangle(new Pen(wall, 4), width * 7 / 24, height / 36, width * 5 / 12, height * 5 / 24 - height / 36);
            // Draw names
            e.Graphics.DrawString(Common.Characters.Instance[this.team1].Name, score, background, width * 7 / 24 + 15, height / 15);
            e.Graphics.DrawString(Common.Characters.Instance[this.team2].Name, score, background, width * 7 / 24 + 15, height / 7);
            // Draw innings score
            int ptr = 0, // Pointer for each inning
                space = (width * 17 / 24 - width * 7 / 24) * 5 / 7, // Space for the result
                offset = (space * 2 / 7) * 3 / 5 + 15, // Offset for the first inning
                dX = space / (this.game.Innings + 1);
            foreach (Games.Baseball.BoardScore bs in this.game.ScoreBoard)
            {
                ptr++;
                e.Graphics.DrawString(bs.Team1.ToString(), score, background, (width * 7 / 24 + offset) + ptr * dX, height / 15);
                e.Graphics.DrawString(bs.Team2.ToString(), score, background, (width * 7 / 24 + offset) + ptr * dX, height / 7);
            }
            // Draw the number of races
            e.Graphics.DrawString(this.GetTotalRunsTeam1().ToString(), score, races, (width * 17 / 24) - (dX / 2), height / 15);
            e.Graphics.DrawString(this.GetTotalRunsTeam2().ToString(), score, races, (width * 17 / 24) - (dX / 2), height / 7);
            // Draw a square around the current inning and batter into score board
            if (this.game.CurrentInning <= this.game.Innings)
                e.Graphics.DrawRectangle(marker, (width * 7 / 24 + offset) + this.game.CurrentInning * dX - 4, (this.team1 == this.game.BatterTeam) ? height / 15 - 3 : height / 7 - 3, 26, 26);
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (this.game == null || this.game.IsFinished)
                return;

            this.selector.ShowDialog(this);
            int level = this.selector.SelectedValue;

            // The selector was closed without choosing a level
            if (level < 1 || level > 5)
                return;

            // The level has no questions left
            if (!this.game.IsHitLevelAvailable(level))
            {
                this.selector.DisableHitType(level);
                return;
            }

            Common.Question q = this.game.NextQuestion(level);
            if (q == null)
            {
                MessageBox.Show(this, "Sorry.\nSe han agotado las preguntas...", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.GameOver();
                return;
            }

            this.questionForm.SetTheQuestion(q);
            System.Windows.Forms.DialogResult result = this.questionForm.ShowDialog(this);
            if (result == System.Windows.Forms.DialogResult.OK)
                this.game.Answer(AnswerOutcome.Correct);
            else
                this.game.Answer(AnswerOutcome.Incorrect);

            this.questionForm.Restart();

            this.mainScene.Invalidate();

            if (this.game.LastRaceScored)
            {
                this.raceTimer.Start();
                Common.Sounds.SoundPlayer.Instance.Play("applause");
            }

            if (this.game.LastAppliedHit == Games.Baseball.HitType.Out)
                Common.Sounds.SoundPlayer.Instance.Play("out");

            if (!this.game.IsHitLevelAvailable(level))
                this.selector.DisableHitType(level);

            if (this.game.IsFinished)
            {
                if (this.game.QuestionsExhausted)
                    MessageBox.Show(this, "Sorry.\nSe han agotado las preguntas...", "Oops...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.GameOver();
                return;
            }

            // Check end of inning
            if (result != System.Windows.Forms.DialogResult.OK && this.game.Outs == 0 && !this.game.EndOfGame)
            {
                this.startTimer.Start();
            }
            else
            {
                this.FlashTimer.Start();
            }
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

            this.startBtn.Hide();
        }

        private int GetTotalRunsTeam1()
        {
            int total = 0;
            foreach (Games.Baseball.BoardScore bs in this.game.ScoreBoard)
                total += bs.Team1;
            return total;
        }

        private int GetTotalRunsTeam2()
        {
            int total = 0;
            foreach (Games.Baseball.BoardScore bs in this.game.ScoreBoard)
                total += bs.Team2;
            return total;
        }

        private void endBtn_Click(object sender, EventArgs e)
        {
            if (this.game != null && (this.game.ScoreTeam1 != 0 || this.game.ScoreTeam2 != 0))
                this.GameOver();

            this.DialogResult = System.Windows.Forms.DialogResult.Abort;
        }

        private void GameScene_Shown(object sender, EventArgs e)
        {
            this.startTimer.Start();
        }

        private void startTimer_Tick(object sender, EventArgs e)
        {
            this.startTimer.Stop();
            this.dialog.Character = this.game.BatterTeam;
            this.dialog.LtR = this.game.BatterTeam == this.team1;
            this.dialog.ShowDialog(this);
            this.FlashTimer.Start();
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
                    this.startBtn.BackColor = Color.LightGreen;
                    this.startBtn.FlatAppearance.BorderSize = 1;
                }
                else
                {
                    this.startBtn.BackColor = Color.WhiteSmoke;
                    this.startBtn.FlatAppearance.BorderSize = 0;
                }
            }
        }

        private int raceTicks = 0;
        
        private void raceTimer_Tick(object sender, EventArgs e)
        {
            this.raceTicks++;
            this.raceLabel.Visible = !this.raceLabel.Visible;

            if (this.raceTicks >= 6)
            {
                this.raceTicks = 0;
                this.raceLabel.Visible = false;
                this.raceTimer.Stop();
            }
        }

        private void GameScene_Load(object sender, EventArgs e)
        {
            this.grassTextureImage = System.Drawing.Image.FromFile(System.Environment.CurrentDirectory + "\\resources\\textures\\grass-texture.jpg");
            this.wallTextureImage = System.Drawing.Image.FromFile(System.Environment.CurrentDirectory + "\\resources\\textures\\wall-texture.jpg");
            this.sandTextureImage = System.Drawing.Image.FromFile(System.Environment.CurrentDirectory + "\\resources\\textures\\sand-texture.jpg");
        }

        private void GameScene_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this.grassTextureImage != null) this.grassTextureImage.Dispose();
            if (this.wallTextureImage != null) this.wallTextureImage.Dispose();
            if (this.sandTextureImage != null) this.sandTextureImage.Dispose();
        }
    }
}
