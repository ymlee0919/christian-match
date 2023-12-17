using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChristianMatch.Common.Questions.Modals
{
    public partial class QuestionarySelector : Form
    {
        private string questionary;

        private Questions.QuestionaryManager manager;

        public QuestionarySelector()
        {
            this.questionary = null;
            this.manager = Questions.QuestionaryManager.Instance;

            InitializeComponent();
        }

        private void QuestionarySelector_Load(object sender, EventArgs e)
        {
            List<string> questionaries = this.manager.GetList();

            foreach (string questionary in questionaries)
            {
                this.QuestionsListView.Items.Add(questionary);
            }
        }

        private void QuestionsListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.QuestionsListView.SelectedItems.Count > 0)
            {
                ListViewItem i = this.QuestionsListView.SelectedItems[0];
                this.questionary = i.Text;
                this.UpdateBtn.Enabled = true;
                this.DeleteBtn.Enabled = true;
                this.AcceptBtn.Enabled = true;
            }
        }

        private void AcceptBtn_Click(object sender, EventArgs e)
        {
            if (!manager.ExistsQuestionary(this.questionary))
            {
                MessageBox.Show(this, "The selected questionary do not exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        public Questionary SelectedCuestionary
        {
            get
            {
                return this.manager.Open(this.questionary);
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
