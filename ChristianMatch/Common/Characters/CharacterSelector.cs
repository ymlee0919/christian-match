using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChristianMatch.Common
{
    public partial class CharacterSelector : Form
    {
        private string[] characters;

        private Point team1, team2;

        public CharacterSelector()
        {
            this.team1 = new Point(-1, -1);
            this.team2 = new Point(-1, -1);

            this.characters = Common.Characters.Instance.ItemsNames.ToArray();

            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void charactersList_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            Font f = this.sampleLabel.Font;
            Brush b = new SolidBrush(Color.Red);

            // Draw the characters
            for (int i = 0; i < 12; i++)
                e.Graphics.DrawImage(Common.Characters.Instance[this.characters[i]].Image, (i % 4) * 90 + 4, (i / 4) * 110 + 4, 82, 82);

            // Draw the name
            for (int i = 0; i < 12; i++)
            {
                e.Graphics.DrawString(Common.Characters.Instance[this.characters[i]].Name, f, b, (i % 4) * 90 + 20, (i / 4) * 110 + 85);
            }

            // Draw the selection
            if (this.team1.X != -1) 
            {
                Pen p = new Pen(Color.DeepSkyBlue, 2);
                e.Graphics.DrawRectangle(p, this.team1.X * 90, this.team1.Y * 110, 90, 110);
            }

            if (this.team2.X != -1)
            {
                Pen p = new Pen(Color.IndianRed, 2);
                e.Graphics.DrawRectangle(p, this.team2.X * 90, this.team2.Y * 110, 90, 110);
            }

        }

        private void charactersList_MouseDown(object sender, MouseEventArgs e)
        {
            int x = (int)e.X / 90;
            int y = (int)e.Y / 100;
            int index; string name;

            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                if (this.team2.X != -1 && this.team2.X == x && this.team2.Y == y) return;
                this.team1 = new Point(x, y);
                index = y * 4 + x;
                name = this.characters[index];
                this.labelTeam1.Text = Common.Characters.Instance[name].Name;
                this.imgTeam1.Invalidate();
                this.statusLabel.Text = "Seleccione el personaje del equipo 2 usando el CLIC DERECHO";
            }
            else
            {
                if (this.team1.X != -1 && this.team1.X == x && this.team1.Y == y) return;
                this.team2 = new Point(x, y);
                index = y * 4 + x;
                name = this.characters[index];
                this.labelTeam2.Text = Common.Characters.Instance[name].Name;
                this.imgTeam2.Invalidate();
            }

            this.continueBtn.Enabled = (this.team1.X != -1 && this.team2.X != -1);
            this.charactersList.Invalidate();
        }

        public string Team1
        {
            get
            {
                int index = this.team1.Y * 4 + this.team1.X;
                return this.characters[index];
            }
        }

        public string Team2
        {
            get
            {
                int index = this.team2.Y * 4 + this.team2.X;
                return this.characters[index];
            }
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void imgTeam1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            if (this.team1.X == -1)
                e.Graphics.DrawImage(Common.Characters.Instance.None, 0, 0, this.imgTeam1.Width, this.imgTeam1.Height);
            else
            {
                int index = this.team1.Y * 4 + this.team1.X;
                string name = this.characters[index];
                e.Graphics.DrawImage(Common.Characters.Instance[name].Image, 0, 0, this.imgTeam1.Width, this.imgTeam1.Height);
            }
        }

        private void imgTeam2_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            if (this.team2.X == -1)
                e.Graphics.DrawImage(Common.Characters.Instance.None, 0, 0, this.imgTeam1.Width, this.imgTeam1.Height);
            else
            {
                int index = this.team2.Y * 4 + this.team2.X;
                string name = this.characters[index];
                e.Graphics.DrawImage(Common.Characters.Instance[name].Image, 0, 0, this.imgTeam1.Width, this.imgTeam1.Height);
            }
        }
    }
}
