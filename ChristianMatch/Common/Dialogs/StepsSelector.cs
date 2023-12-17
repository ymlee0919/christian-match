using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChristianMatch.Common
{
    public partial class StepsSelector : Form
    {
        private int steps;

        public StepsSelector()
        {
            InitializeComponent();
            this.steps = 0;
        }

        public int Steps
        {
            get
            {
                return this.steps;
            }
        }

        public string Team
        {
            set
            {
                this.topLabel.Text = Common.Characters.Instance[value].Name + ", ¿cuántos pasos vas a dar?";
            }
        }

        public void Reset()
        {
            this.firstStepBtn.Enabled = this.secondStepBtn.Enabled = this.thirdStepBtn.Enabled = true;
            this.steps = 0;
        }

        public void DisableSteps(int level)
        {
            switch (level)
            {
                case 1:
                    this.firstStepBtn.Enabled = false;
                    break;
                case 2:
                    this.secondStepBtn.Enabled = false;
                    break;
                case 3:
                    this.thirdStepBtn.Enabled = false;
                    break;
                default: break;
            }
        }

        private void stepsSelected(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            this.steps = int.Parse(btn.Tag.ToString());
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
