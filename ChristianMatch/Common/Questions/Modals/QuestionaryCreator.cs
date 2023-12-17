using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace ChristianMatch.Common.Questions.Modals
{
    public partial class QuestionaryCreator : Form
    {
        private Questionary questionary;

        private QuestionaryManager manager;

        public QuestionaryCreator()
        {
            this.questionary = null;
            this.manager = QuestionaryManager.Instance;

            InitializeComponent();
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            if (this.manager.ExistsQuestionary(this.NameTextBox.Text))
            {
                MessageBox.Show(this, "The new questionary already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.questionary = this.manager.Create(this.NameTextBox.Text);

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        public Questionary Questionary
        {
            get
            {
                return this.questionary;
            }
        }


    }
}
