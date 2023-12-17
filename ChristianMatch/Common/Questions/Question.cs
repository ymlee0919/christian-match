using System;
using System.Collections.Generic;
using System.Text;

namespace ChristianMatch.Common
{
    [Serializable]
    public class Question
    {
        private int level;

        private string main_question;

        private string rightAnswer;

        private List<string> answers;

        private string reference;

        public Question()
        {
            this.answers = new List<string>(4);
        }

        /// <summary>
        /// Get or set the question
        /// </summary>
        public string MainQuestion
        {
            get
            {
                return this.main_question;
            }
            set
            {
                this.main_question = value;
            }
        }

        /// <summary>
        /// Get or set the reference
        /// </summary>
        public string Reference
        {
            get
            {
                return this.reference;
            }
            set
            {
                this.reference = value;
            }
        }

        /// <summary>
        /// Get or set the right answer
        /// </summary>
        public string RightAnswer
        {
            get
            {
                return this.rightAnswer;
            }
        }

        /// <summary>
        /// Return the alternative answers
        /// </summary>
        public string[] AlternativeAnswers
        {
            get
            {
                return this.answers.ToArray();
            }
        }

        /// <summary>
        /// Set the answers
        /// </summary>
        /// <param name="right">The right answer</param>
        /// <param name="others">Alertnative answers</param>
        public void setAnswers(string right, params string[] others)
        {
            this.rightAnswer = right;
            this.answers.Clear();
            foreach (string answer in others)
                this.answers.Add(answer);
        }

        /// <summary>
        /// Get or set difficult level of the question
        /// </summary>
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value <= 0)
                    level = 1;
                if (value > 5)
                    level = 5;
                if (value >= 1 && value <= 5)
                    level = value;
            }

        }
    }
}
