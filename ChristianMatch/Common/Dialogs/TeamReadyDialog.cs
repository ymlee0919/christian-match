using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChristianMatch.Common
{
    public partial class TeamReadyDialog : Form
    {
        private string character;

        public TeamReadyDialog()
        {
            InitializeComponent();
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        public string Character
        {
            set 
            {
                this.character = value;
            }
        }

        private void characterImg_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(Common.Characters.Instance[this.character].Image, 0, 0, 140, 140);
        }

        private void TeamReadyDialog_Shown(object sender, EventArgs e)
        {
            this.questionLabel.Text = Common.Characters.Instance[this.character].Name + ", ¿listo?";
        }


    }
}
