using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChristianMatch.Common
{
    public partial class WinnerForm : Form
    {
        string winer;

        long start;

        public WinnerForm()
        {
            InitializeComponent();

            this.winer = null;
            this.start = 0;
        }

        public string Winner
        {
            set
            {
                this.winer = value;
                this.topLabel.Text = "Felicidades " + Common.Characters.Instance[value].Name + " !!!";
            }
        }

        private void mainImage_Paint(object sender, PaintEventArgs e)
        {
            if (this.winer == null) return;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            e.Graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            e.Graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;

            // Draw the character
            int midX = this.mainImage.Width / 2;
            int midY = this.mainImage.Height / 2;
            int offset = Math.Min(this.mainImage.Width * 4 / 5, this.mainImage.Height * 4 / 5);
            e.Graphics.DrawImage(
                Common.Characters.Instance[this.winer].Image,
                midX - offset / 2,
                midY - offset / 2 - 15,
                offset,
                offset);

            // Draw the golden meddal
            e.Graphics.DrawImage(
                Image.FromFile(System.Environment.CurrentDirectory + "\\resources\\images\\gold-medal.png"),
                midX + offset / 2 - 70,
                midY + offset / 2 - 90,
                75, 105);
        }

        private void WinnerForm_Shown(object sender, EventArgs e)
        {
            this.start = System.Environment.TickCount;
            this.timer.Start();
            Common.Sounds.SoundPlayer.Instance.Play("win");
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            long seconds = (System.Environment.TickCount - this.start) / 1000;
            if (seconds > 4)
            {
                this.timer.Stop();
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}
