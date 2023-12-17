using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChristianMatch.Common
{
    public partial class SimpleQuestionForm : QForm
    {
        private ChristianMatch.Common.Question question;
        
        private bool timed;

        private int maxTime;

        private long start;

        public SimpleQuestionForm()
        {
            InitializeComponent();

            this.timed = false;
            this.maxTime = -1;
            this.start = 0;
        }

        public override void Restart()
        {
            this.answerLabel.Text = "Respuesta ...";
            this.cancelBtn.Visible = false;
            this.continueBtn.Visible = false;
        }

        public override void SetMaxTime(int maxSecondsTime)
        {
            this.timed = true;
            this.maxTime = maxSecondsTime;
        }

        public override void SetTheQuestion(Common.Question q)
        {
            this.question = q;
            this.Question.Text = this.question.MainQuestion;
            string stars = "*";
            if (this.question.Level > 1)
                stars = stars.PadLeft(this.question.Level, '*');

            this.starsLabel.Text = stars;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            long seconds = (System.Environment.TickCount - this.start) / 1000;
            int minute = 0; int second = 0;
            if (this.timed)
            {
                seconds = this.maxTime - (int)seconds;
                
                // The time is over
                if (seconds == 0)
                {
                    this.timeCounter.Text = "00:00";

                    this.timer.Stop();
                    Common.Sounds.SoundPlayer.Instance.Play("wrong");
                    
                    this.Question.Text = this.question.Reference;
                    this.answerLabel.Text = this.question.RightAnswer;
                    this.Refresh(); this.Refresh();
                    System.Threading.Thread.Sleep(4000);
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                }
            }
            
            minute = (int)seconds / 60;
            second = (int)seconds % 60;

            this.timeCounter.Text = minute.ToString().PadLeft(2, '0') + ":" + second.ToString().PadLeft(2, '0');
        }

        private void SimpleQuestionForm_Shown(object sender, EventArgs e)
        {
            this.timer.Start();
            this.start = System.Environment.TickCount;
        }

        private void answerLabel_Click(object sender, EventArgs e)
        {
            this.answerLabel.Text = this.question.RightAnswer;
            this.timer.Stop();
            this.cancelBtn.Visible = true;
            this.continueBtn.Visible = true;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Common.Sounds.SoundPlayer.Instance.Play("wrong");
            System.Threading.Thread.Sleep(1000);
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            Common.Sounds.SoundPlayer.Instance.Play("fine");
            System.Threading.Thread.Sleep(1000);
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

    }
}
