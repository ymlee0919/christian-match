using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChristianMatch
{
    public partial class MainForm : Form
    {
        private string team1, team2;
        private Image imgTeam1, imgTeam2;
        private int pointsTeam1, pointsTeam2;

        public MainForm()
        {
            InitializeComponent();

            this.team1 = null;
            this.team2 = null;

            this.pointsTeam1 = 0;
            this.pointsTeam2 = 0;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void questionsBtn_Click(object sender, EventArgs e)
        {
            Common.Sounds.SoundPlayer.Instance.Stop();
            Common.QuestionsForm form = new Common.QuestionsForm();
            this.Hide();
            form.ShowDialog(this);
            this.Show();
        }

        private void simpleMatchBtn_Click(object sender, EventArgs e)
        {
            SimpleMatch.GameConfig configWin = new SimpleMatch.GameConfig();
            if (configWin.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                SimpleMatch.GameScene scene = new SimpleMatch.GameScene();
                scene.Team1 = this.team1;
                scene.Team2 = this.team2;
                scene.Config = configWin.Config;

                Common.Sounds.SoundPlayer.Instance.Stop();
                this.Hide();
                scene.ShowDialog(this);
                this.Show();

                this.pointsTeam1 += scene.PointsTeam1;
                this.pointsTeam2 += scene.PointsTeam2;

                this.teamsImage.Invalidate();
            }
        }

        private void fastMatchBtn_Click(object sender, EventArgs e)
        {
            FastMatch.GameConfig configWin = new FastMatch.GameConfig();
            if (configWin.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                FastMatch.GameScene scene = new FastMatch.GameScene();
                scene.Team1 = this.team1;
                scene.Team2 = this.team2;
                scene.Config = configWin.Config;

                Common.Sounds.SoundPlayer.Instance.Stop();
                this.Hide();
                scene.ShowDialog(this);
                this.Show();

                this.pointsTeam1 += scene.PointsTeam1;
                this.pointsTeam2 += scene.PointsTeam2;

                this.teamsImage.Invalidate();
            }
        }

        private void wallkingUpBtn_Click(object sender, EventArgs e)
        {
            WalkingUp.GameConfig configWin = new WalkingUp.GameConfig();
            if (configWin.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                WalkingUp.GameScene scene = new WalkingUp.GameScene();
                scene.Team1 = this.team1;
                scene.Team2 = this.team2;
                scene.Config = configWin.Config;

                Common.Sounds.SoundPlayer.Instance.Stop();
                this.Hide();
                scene.ShowDialog(this);
                this.Show();

                this.pointsTeam1 += scene.PointsTeam1;
                this.pointsTeam2 += scene.PointsTeam2;

                this.teamsImage.Invalidate();
            }
        }

        private void baseballBtn_Click(object sender, EventArgs e)
        {
            Baseball.GameConfig configWin = new Baseball.GameConfig();
            if (configWin.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                Baseball.GameScene scene = new Baseball.GameScene();
                scene.Team1 = this.team1;
                scene.Team2 = this.team2;
                scene.Config = configWin.Config;

                Common.Sounds.SoundPlayer.Instance.Stop();
                this.Hide();
                scene.ShowDialog(this);
                this.Show();

                this.pointsTeam1 += scene.PointsTeam1;
                this.pointsTeam2 += scene.PointsTeam2;

                this.teamsImage.Invalidate();
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            // Locate DefineTeamsBtn
            int midX = this.Width / 2 - this.defineTeamsBtn.Width / 2;
            int midY = this.Height / 2 - this.topLabel.Height + this.topPanel.Height;

            this.defineTeamsBtn.Location = new Point(midX, midY);

            // Locate TeamsImage
            midX = this.Width / 2 - this.teamsImage.Width / 2;
            midY = this.topLabel.Height + this.topPanel.Height + 50;

            this.teamsImage.Location = new Point(midX, midY);

            // Locate SimpleMatchButton
            midX = midX / 2 - this.simpleMatchBtn.Width / 2;
            midY = this.topLabel.Height + this.topPanel.Height + 120;

            this.simpleMatchBtn.Location = new Point(midX, midY);

            // Locate FastMatchButton
            midX = midX * 3 / 2 + this.simpleMatchBtn.Width / 2;
            midY = this.topLabel.Height + this.topPanel.Height + 250;

            this.fastMatchBtn.Location = new Point(midX, midY);

            // Locate WalkingUpButton
            midX = this.Width / 2 - this.wallkingUpBtn.Width * 2;
            midY = midY + this.fastMatchBtn.Height + 30;

            this.wallkingUpBtn.Location = new Point(midX, midY);

            // Locate BaseballBtn
            midX = midX + this.wallkingUpBtn.Width * 3 / 2;
            //midY = midY + this.fastMatchBtn.Height + 30;
            
            this.baseballBtn.Location = new Point(midX, midY);

            // Locate HelpBtn
            midX = this.Width - this.helpBtn.Width * 5 / 4;
            midY = this.Height - this.helpBtn.Height * 5 / 4;
            this.helpBtn.Location = new Point(midX, midY);
        }

        private void defineTeamsBtn_Click(object sender, EventArgs e)
        {
            Common.CharacterSelector selector = new Common.CharacterSelector();
            if (selector.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                this.team1 = selector.Team1;
                this.team2 = selector.Team2;

                this.imgTeam1 = Common.Characters.Instance[this.team1].Image;
                this.imgTeam2 = Common.Characters.Instance[this.team2].Image;

                this.defineTeamsBtn.Hide();
                this.teamsImage.Invalidate();

                this.simpleMatchBtn.Show();
                this.fastMatchBtn.Show();
                this.wallkingUpBtn.Show();
                this.baseballBtn.Show();
                this.helpBtn.Show();
            }
        }

        private void teamsImage_Paint(object sender, PaintEventArgs e)
        {
            if (this.team1 == null || this.team2 == null) return;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            // Draw the characters
            int midX = this.teamsImage.Width / 2;
            int midY = this.teamsImage.Height / 2;

            // Draw first team
            e.Graphics.DrawImage(this.imgTeam1, midX - 200, midY - 80, 160, 160);
            // Draw second team
            e.Graphics.DrawImage(this.imgTeam2, midX + 40, midY - 80, 160, 160);

            Font f = new Font(new FontFamily("Forte"), 25, FontStyle.Bold, GraphicsUnit.Pixel);
            Font vs = new Font(new FontFamily("Kristen ITC"), 40, FontStyle.Bold, GraphicsUnit.Pixel);
            Font points = new Font(new FontFamily("Courier New"), 40, FontStyle.Bold, GraphicsUnit.Pixel);

            Brush namesBruch = new SolidBrush(Color.Navy);
            Brush brush = new SolidBrush(Color.Brown);
            Brush pointBruch = new SolidBrush(Color.DarkRed);

            // Write team names
            e.Graphics.DrawString(Common.Characters.Instance[this.team1].Name, f, namesBruch, midX - 160, midY + 90);
            e.Graphics.DrawString(Common.Characters.Instance[this.team2].Name, f, namesBruch, midX + 80, midY + 90);

            // Write Vs label
            e.Graphics.DrawString("Vs", vs, brush, midX - 40, midY + 30);
            // Write points of teams
            e.Graphics.DrawString(this.pointsTeam1.ToString(), points, pointBruch, midX - 150, 5);
            e.Graphics.DrawString(this.pointsTeam2.ToString(), points, pointBruch, midX + 80, 5);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            //Common.Sounds.SoundPlayer.Instance.Play("into");
            //this.player = new System.Media.SoundPlayer(System.Environment.CurrentDirectory + "\\resources\\sounds\\into.wav");
            //this.player.Play();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            Help.HelpForm form = new Help.HelpForm();            
            form.ShowDialog(this);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Common.Sounds.SoundPlayer.Instance.Play("into");
            Common.Characters.Load();
            this.defineTeamsBtn.Text = "Definir equipos";
            this.defineTeamsBtn.Enabled = true;
        }

        

        

        
    }
}
