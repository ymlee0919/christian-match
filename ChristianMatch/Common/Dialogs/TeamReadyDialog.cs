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
        private bool ltr;

        public TeamReadyDialog()
        {
            InitializeComponent();
            this.ltr = true;
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

        public bool LtR {
            set {
                this.ltr = value;
            }
        }

        private void characterImg_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(
                this.ltr
                ? Common.Characters.Instance[this.character].ImageLTR
                : Common.Characters.Instance[this.character].ImageRTL
                , 0, 0, 140, 140);
        }

        private void TeamReadyDialog_Shown(object sender, EventArgs e)
        {
            this.questionLabel.Text = Common.Characters.Instance[this.character].Name + (Common.Characters.Instance[this.character].gender == 'm' ? ", ¿listo?" : ", ¿lista?");
        }


    }
}
