using System;
using System.Collections.Generic;
using System.Text;

namespace ChristianMatch.Common
{
    [Serializable]
    public class Questionary
    {
        /// <summary>
        /// Current index
        /// </summary>
        private int index;

        /// <summary>
        /// List of questions
        /// </summary>
        private List<Question> questions;

        public Questionary()
        {
            this.index = 0;
            this.questions = new List<Question>();
        }

        /// <summary>
        /// Get the current question according the index
        /// </summary>
        public Question GetCurrent
        {
            get
            {
                return this.questions[this.index];
            }
        }

        /// <summary>
        /// Get the next question
        /// </summary>
        public Question Next
        {
            get
            {
                if (this.index + 1 == this.questions.Count)
                    ++this.index;
                return this.questions[this.index];
            }
        }

        /// <summary>
        /// Get the previous question
        /// </summary>
        public Question Previuos
        {
            get
            {
                if (this.index > 0)
                    --this.index;
                return this.questions[this.index];
            }
        }

        public void MoveNext()
        {
            if (this.index + 1 < this.questions.Count)
                ++this.index;
        }

        public void MovePreviuos()
        {
            if (this.index > 0)
                --this.index;
        }

        /// <summary>
        /// Get total number of questions
        /// </summary>
        public int GetCount
        {
            get
            {
                return this.questions.Count;
            }
        }

        /// <summary>
        /// Get the current index, it is 0-based
        /// </summary>
        public int GetIndex
        {
            get
            {
                return this.index;
            }
        }

        /// <summary>
        /// Add a question
        /// </summary>
        /// <param name="q">Question instance</param>
        public void Add(Question q)
        {
            this.questions.Add(q);
            this.index = this.questions.Count - 1;
        }

        /// <summary>
        /// Remove the question according the index
        /// </summary>
        public void RemoveCurrent()
        {
            this.questions.RemoveAt(this.index);
            if (this.index == this.questions.Count)
                --this.index;
        }

        /// <summary>
        /// Move the internal index
        /// </summary>
        /// <param name="index">New index</param>
        public void GoTo(int index)
        {
            if (index < 0 || index >= this.questions.Count)
                return;

            this.index = index;
        }

        public Question this[int index]
        {
            get
            {
                return this.questions[index];
            }
        }

    }
}
