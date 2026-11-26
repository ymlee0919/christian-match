using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChristianMatch.Help
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }
    }
}
