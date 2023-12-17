using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChristianMatch.SimpleMatch
{
    public struct Config
    {
        public bool LimitedTime;

        public bool EqualValue;

        public bool ShowPossibleAnswers;

        public int Time;

        public int QuestionValue;

        public string Questionarie;
    }

    public partial class GameConfig : Form
    {
        private Config configResult;

        public GameConfig()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            this.configResult.LimitedTime = this.timeLimitChBox.Checked;
            if (this.configResult.LimitedTime)
                this.configResult.Time = (int)this.timeLimitsUpDown.Value;

            this.configResult.EqualValue = this.questionsChBox.Checked;
            if (this.configResult.EqualValue)
                this.configResult.QuestionValue = (int)this.pointsUpDown.Value;

            this.configResult.ShowPossibleAnswers = this.possibleAnswersChBox.Checked;

            this.configResult.Questionarie = this.questionariesCBox.SelectedItem.ToString();

            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void pointsLimitChBox_CheckedChanged(object sender, EventArgs e)
        {
            this.timeLimitsUpDown.Visible = this.secondsLb.Visible = this.timeLimitChBox.Checked;
        }

        private void questionsChBox_CheckedChanged(object sender, EventArgs e)
        {
            this.pointsUpDown.Visible = this.pointsLb.Visible = this.questionsChBox.Checked;
        }

        public Config Config
        {
            get
            {
                return this.configResult;
            }
        }

        private void GameConfig_Load(object sender, EventArgs e)
        {
            Common.Questions.QuestionaryManager manager = Common.Questions.QuestionaryManager.Instance;
            List<string> questionaries = manager.GetList();
            foreach (string name in questionaries)
                this.questionariesCBox.Items.Add(name);
        }

        private void questionariesCBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.questionariesCBox.SelectedIndex != -1)
                this.continueBtn.Enabled = true;
        }
    }
}
