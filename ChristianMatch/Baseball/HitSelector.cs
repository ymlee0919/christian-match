using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChristianMatch.Baseball
{
    public partial class HitSelector : Form
    {
        private int selectedValue;
        private List<int> disableds;

        public HitSelector()
        {
            this.selectedValue = -1;
            this.disableds = new List<int>();

            InitializeComponent();
        }

        public int SelectedValue
        {
            get
            {
                return this.selectedValue;
            }
        }

        public void DisableHitType(int level)
        {
            if (level == 2 && this.disableds.Contains(1) || level == 1 && this.disableds.Contains(2))
                this.hitBtn.Hide();
            if (!this.disableds.Contains(level))
                this.disableds.Add(level);
            switch (level)
            {
                case 3:
                    this.doubleBtn.Hide();
                    break;
                case 4:
                    this.tripleBtn.Hide();
                    break;
                case 5:
                    this.homerunBtn.Hide();
                    break;
                default: break;
            }
        }

        private void hitSelected(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            this.selectedValue = int.Parse(btn.Tag.ToString());
            if (this.selectedValue == 2)
            {
                Random r = new Random();
                this.selectedValue = ((r.Next(1, 100) % 2) == 0) ? 1 : 2;
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
