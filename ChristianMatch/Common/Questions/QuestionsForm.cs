using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace ChristianMatch.Common
{
    public enum AppStatus
    {
        None, NewQuestion
    }

    public partial class QuestionsForm : Form
    {
        private AppStatus status;

        private Questionary questionary;

        private Questions.QuestionaryManager manager;

        private Dictionary<int, string> levels;

        public QuestionsForm()
        {
            this.questionary = null;
            this.status = AppStatus.None;
            this.levels = new Dictionary<int, string>(5);

            this.levels[1] = "Easy";
            this.levels[2] = "Low";
            this.levels[3] = "Medium";
            this.levels[4] = "High";
            this.levels[5] = "Hard";

            this.manager = Questions.QuestionaryManager.Instance;

            InitializeComponent();
        }

        #region Privates

        private void enableAll()
        {
            this.SaveBtn.Enabled 
                = this.PrevBtn.Enabled 
                = this.NextBtn.Enabled 
                = this.NewQuestionBtn.Enabled
                = this.SaveQuestionBtn.Enabled 
                = this.DeleteQuestionBtn.Enabled 
                = true;
        }

        private void newQuestion()
        {
            this.TopPanel.Enabled
                = this.CenterPanel.Enabled
                = this.BottomPanel.Enabled
                = true;

            this.Question.Text
                = this.Reference.Text
                = this.RightAnswer.Text
                = this.Answer1.Text
                = this.Answer2.Text
                = this.Answer3.Text 
                = this.Answer4.Text = "";

            this.status = AppStatus.NewQuestion;
        }

        private void updatePosition()
        {
            int count = this.questionary.GetCount;
            int index = this.questionary.GetIndex + 1;

            this.ItemLabel.Text = "Question " + index.ToString() + " of " + count.ToString();
        }

        private void showQuestion()
        {
            Question q = this.questionary.GetCurrent;

            this.Question.Text = q.MainQuestion;
            this.Reference.Text = q.Reference;
            this.RightAnswer.Text = q.RightAnswer;

            string[] answers = q.AlternativeAnswers;
            this.Answer1.Text = answers[0];
            this.Answer2.Text = answers[1];
            this.Answer3.Text = answers[2];
            this.Answer4.Text = answers[3];

            this.levelCBox.SelectedIndex = q.Level - 1;
        }

        private void updateStatus(string message)
        {
            this.ItemLabel.Text = message;
            this.Timer.Enabled = true;
        }

        private void refreshQuestionsList()
        {
            this.questionsList.Enabled = true;
            int count = this.questionary.GetCount;
            this.questionsList.Items.Clear();

            ListViewItem item;
            Question q;
            
            for (int i = 0; i < count; i++)
            {
                item = this.questionsList.Items.Add((i + 1).ToString());
                q = this.questionary[i];
                item.SubItems.Add(q.MainQuestion);
                item.SubItems.Add(q.Level.ToString());
            }
        }

        #endregion


        #region Events

        private void Questions_Resize(object sender, EventArgs e)
        {
            this.Answer1.Width = this.Answer2.Width = this.Answer3.Width = Answer4.Width = this.RightAnswer.Width = this.MainContainer.Panel1.Width - 35;
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            /*
            if (this.SaveFileDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                this.StatusLabel.Text = this.fileName = this.SaveFileDialog.FileName;
                this.questionary = new Questionary();
                this.saveQuestionary();
                this.enableAll();
                this.updatePosition();
            }
             */

            ChristianMatch.Common.Questions.Modals.QuestionaryCreator creator = new Questions.Modals.QuestionaryCreator();
            if (creator.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                this.questionary = creator.Questionary;
                this.enableAll();
                this.updatePosition();
            }

        }

        private void NewQuestionBtn_Click(object sender, EventArgs e)
        {
            this.newQuestion();
        }

        private void SaveQuestionBtn_Click(object sender, EventArgs e)
        {
            if (this.status == AppStatus.NewQuestion)
            {
                Question q = new Question();
                q.MainQuestion = this.Question.Text;
                q.Reference = this.Reference.Text;
                q.setAnswers(this.RightAnswer.Text, this.Answer1.Text, this.Answer2.Text, this.Answer3.Text, this.Answer4.Text);
                q.Level = this.levelCBox.SelectedIndex + 1;

                this.questionary.Add(q);
                this.status = AppStatus.None;
            }
            else
            {
                Question q = this.questionary.GetCurrent;

                q.MainQuestion = this.Question.Text;
                q.Reference = this.Reference.Text;
                q.setAnswers(this.RightAnswer.Text, this.Answer1.Text, this.Answer2.Text, this.Answer3.Text, this.Answer4.Text);
                q.Level = this.levelCBox.SelectedIndex + 1;
            }

            this.updateStatus("Question saved");
            this.refreshQuestionsList();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            this.manager.SaveActiveQuestionary();
            this.updateStatus("Questionary saved");
        }

        private void DeleteQuestionBtn_Click(object sender, EventArgs e)
        {
            if (this.status == AppStatus.None)
            {
                this.questionary.RemoveCurrent();
                this.questionary.MoveNext();
                this.showQuestion();
            }
            else
            {
                this.newQuestion();
            }

            this.updatePosition();
            this.refreshQuestionsList();
        }

        private void PrevBtn_Click(object sender, EventArgs e)
        {
            this.questionary.MovePreviuos();
            this.showQuestion();
            this.updatePosition();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            this.questionary.MoveNext();
            this.showQuestion();
            this.updatePosition();
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            /*
            if (this.OpenFileDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                this.StatusLabel.Text = this.fileName = this.OpenFileDialog.FileName;
                this.openQuestionary();

                this.questionary.GoTo(0);
                this.showQuestion();
                this.enableAll();

                this.TopPanel.Enabled
                = this.CenterPanel.Enabled
                = this.BottomPanel.Enabled
                = true;

                this.updatePosition();
                this.refreshQuestionsList();
            }
            */

            ChristianMatch.Common.Questions.Modals.QuestionarySelector selector = new Questions.Modals.QuestionarySelector();
            if (selector.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
            {
                this.questionary = selector.SelectedCuestionary;

                this.questionary.GoTo(0);
                this.showQuestion();
                this.enableAll();

                this.TopPanel.Enabled
                = this.CenterPanel.Enabled
                = this.BottomPanel.Enabled
                = true;

                this.updatePosition();
                this.refreshQuestionsList();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            this.updatePosition();
            this.Timer.Enabled = false;
        }

        private void questionsList_ItemActivate(object sender, EventArgs e)
        {
            int index = this.questionsList.SelectedItems[0].Index;
            this.questionary.GoTo(index);
            this.showQuestion();
            this.updatePosition();
        }

        private void Reference_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 83)
            {
                //MessageBox.Show(e.KeyValue.ToString());
                this.SaveQuestionBtn_Click(sender, e);
                this.manager.SaveActiveQuestionary();
            }
        }

        private void splitContainer1_Panel1_Resize(object sender, EventArgs e)
        {
            this.Answer1.Width = this.Answer2.Width = this.Answer3.Width = Answer4.Width = this.RightAnswer.Width = this.MainContainer.Panel1.Width - 20;
        }

        #endregion

    }
}
