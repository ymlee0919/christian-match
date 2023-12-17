using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ChristianMatch.Common
{
    public partial class QuestionForm : QForm
    {
        private ChristianMatch.Common.Question question;

        private int answer;

        private List<System.Windows.Forms.Label> labels;

        private List<System.Windows.Forms.Label> answers;

        private bool timed;

        private int maxTime;

        private long start;

        public QuestionForm()
        {
            this.answer = -1;
            this.question = null;

            InitializeComponent();

            this.labels = new List<Label>(5);
            this.labels.Add(this.Answer1);
            this.labels.Add(this.Answer2);
            this.labels.Add(this.Answer3);
            this.labels.Add(this.Answer4);
            this.labels.Add(this.Answer5);

            this.answers = new List<Label>(5);
            this.answers.Add(this.Answer1);
            this.answers.Add(this.Answer2);
            this.answers.Add(this.Answer3);
            this.answers.Add(this.Answer4);
            this.answers.Add(this.Answer5);

            this.timed = false;
            this.maxTime = -1;
            this.start = 0;
        }

        public override void Restart()
        {
            this.labels = new List<Label>(5);
            this.labels.Add(this.Answer1);
            this.labels.Add(this.Answer2);
            this.labels.Add(this.Answer3);
            this.labels.Add(this.Answer4);
            this.labels.Add(this.Answer5);

            this.answers = new List<Label>(5);
            this.answers.Add(this.Answer1);
            this.answers.Add(this.Answer2);
            this.answers.Add(this.Answer3);
            this.answers.Add(this.Answer4);
            this.answers.Add(this.Answer5);

            for (int i = 0; i < 5; i++)
            {
                this.answers[i].ForeColor = Color.MidnightBlue;
                this.answers[i].Font = new Font(this.answers[i].Font, FontStyle.Regular);
            }
        }

        public override void SetMaxTime(int maxSecondsTime)
        {
            this.timed = true;
            this.maxTime = maxSecondsTime;
        }

        public override void SetTheQuestion(Common.Question q)
        {
            this.question = q;

            string stars = "*";
            if (this.question.Level > 1)
                stars = stars.PadLeft(this.question.Level, '*');

            this.starsLabel.Text = stars;

            Random r = new Random();
            this.answer = r.Next(0, 100) % 5;

            this.labels[this.answer].Text = this.question.RightAnswer;
            this.labels.RemoveAt(this.answer);

            // Randomize the answers
            List<string> answers = new List<string>(this.question.AlternativeAnswers);
            int index;
            for (int i = 0; i < 4; i++)
            {
                index = r.Next(0, answers.Count - 1);
                this.labels[0].Text = answers[index];
                this.labels.RemoveAt(0);
                answers.RemoveAt(index);
            }

            this.Question.Text = this.question.MainQuestion;
        }

        private void SelectAnswer(int index)
        {
            this.timer.Stop();

            if (index == this.answer)
            {
                Common.Sounds.SoundPlayer.Instance.Play("fine");

                // Set a light color to the others
                for (int i = 0; i < 5; i++)
                    if (i == this.answer) continue;
                    else
                        this.answers[i].ForeColor = Color.AliceBlue;
                this.Question.Text = "Respuesta correcta !!!";
                this.Refresh(); this.Refresh();
                System.Threading.Thread.Sleep(2000);
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            else
            {
                Common.Sounds.SoundPlayer.Instance.Play("wrong");
                
                for (int i = 0; i < 5; i++)
                {
                    if (i == answer)
                    {
                        this.answers[i].Font = new Font(this.answers[i].Font, FontStyle.Bold);
                        continue;
                    }
                    if (i == index)
                        this.answers[i].ForeColor = Color.Red;
                    else
                        this.answers[i].ForeColor = Color.AliceBlue;
                }

                this.Question.Text = this.question.Reference;
                this.Refresh(); this.Refresh();
                System.Threading.Thread.Sleep(4000);
                this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }

        private void Option1Btn_Click(object sender, EventArgs e)
        {
            this.SelectAnswer(0);
        }

        private void Option2Btn_Click(object sender, EventArgs e)
        {
            this.SelectAnswer(1);
        }

        private void Option3Btn_Click(object sender, EventArgs e)
        {
            this.SelectAnswer(2);
        }

        private void Option4Btn_Click(object sender, EventArgs e)
        {
            this.SelectAnswer(3);
        }

        private void Option5Btn_Click(object sender, EventArgs e)
        {
            this.SelectAnswer(4);
        }

        private void Answer1_Click(object sender, EventArgs e)
        {
            this.SelectAnswer(0);
        }

        private void Answer2_Click(object sender, EventArgs e)
        {
            this.SelectAnswer(1);
        }

        private void Answer3_Click(object sender, EventArgs e)
        {
            this.SelectAnswer(2);
        }

        private void Answer4_Click(object sender, EventArgs e)
        {
            this.SelectAnswer(3);
        }

        private void Answer5_Click(object sender, EventArgs e)
        {
            this.SelectAnswer(4);
        }

        private void QuestionForm_Shown(object sender, EventArgs e)
        {
            this.timer.Start();
            this.start = System.Environment.TickCount;
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
                    
                    for (int i = 0; i < 5; i++)
                    {
                        if (i == answer)
                            this.answers[i].Font = new Font(this.answers[i].Font, FontStyle.Bold);
                        else   
                            this.answers[i].ForeColor = Color.AliceBlue;
                    }

                    this.Question.Text = this.question.Reference;
                    this.Refresh(); this.Refresh();
                    System.Threading.Thread.Sleep(4000);
                    this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
                }
            }
            
            minute = (int)seconds / 60;
            second = (int)seconds % 60;

            this.timeCounter.Text = minute.ToString().PadLeft(2, '0') + ":" + second.ToString().PadLeft(2, '0');

        }

    }
}
