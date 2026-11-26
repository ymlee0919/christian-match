using System;
using System.Collections.Generic;

using ChristianMatch.Common;
using ChristianMatch.Common.Questions;

namespace ChristianMatch.Games.Core
{
    /// <summary>
    /// Pool of questions loaded from a questionary. Every question is drawn
    /// only once, so the questions are never repeated during a game. The
    /// questions can be drawn in a random way or grouped by difficulty level.
    /// </summary>
    public class QuestionBag
    {
        /// <summary>
        /// Questionary which provides the questions
        /// </summary>
        private Questionary questionary;

        /// <summary>
        /// Indexes of the questions which have not been drawn yet
        /// </summary>
        private List<int> available;

        /// <summary>
        /// Indexes of the questions which have not been drawn yet, grouped by level
        /// </summary>
        private Dictionary<int, List<int>> pools;

        /// <summary>
        /// Random number generator
        /// </summary>
        private Random random;

        /// <summary>
        /// Constructor of the class. It loads the questionary from the disk.
        /// </summary>
        /// <param name="questionaryName">Readable name of the questionary</param>
        public QuestionBag(string questionaryName)
        {
            if (string.IsNullOrEmpty(questionaryName))
                throw new ArgumentException("The questionary name is required.", "questionaryName");

            this.random = new Random();
            this.available = new List<int>();
            this.pools = new Dictionary<int, List<int>>();

            // Every call to Open returns a brand new instance of the questionary
            this.questionary = QuestionaryManager.Instance.Open(questionaryName);

            for (int i = 0; i < this.questionary.GetCount; i++)
            {
                this.available.Add(i);

                int level = this.questionary[i].Level;
                List<int> pool;
                if (!this.pools.TryGetValue(level, out pool))
                {
                    pool = new List<int>();
                    this.pools[level] = pool;
                }

                pool.Add(i);
            }
        }

        /// <summary>
        /// Get the number of questions which have not been drawn yet
        /// </summary>
        public int Remaining
        {
            get
            {
                return this.available.Count;
            }
        }

        /// <summary>
        /// Indicate there is no question left
        /// </summary>
        public bool Empty
        {
            get
            {
                return this.available.Count == 0;
            }
        }

        /// <summary>
        /// Indicate there is at least one question of the given level
        /// </summary>
        /// <param name="level">Difficulty level</param>
        /// <returns>True if the level has questions, false if not</returns>
        public bool IsLevelAvailable(int level)
        {
            return this.RemainingAtLevel(level) > 0;
        }

        /// <summary>
        /// Get the number of questions of the given level which have not been drawn yet
        /// </summary>
        /// <param name="level">Difficulty level</param>
        /// <returns>Number of available questions</returns>
        public int RemainingAtLevel(int level)
        {
            List<int> pool;
            if (!this.pools.TryGetValue(level, out pool))
                return 0;

            return pool.Count;
        }

        /// <summary>
        /// Draw a random question. The question is removed from the pool, so it
        /// will never be drawn again.
        /// </summary>
        /// <returns>The question or null when there is no question left</returns>
        public Question Draw()
        {
            if (this.available.Count == 0)
                return null;

            int position = this.random.Next(0, this.available.Count);
            int index = this.available[position];

            this.available.RemoveAt(position);
            this.RemoveFromPool(this.questionary[index].Level, index);

            return this.questionary[index];
        }

        /// <summary>
        /// Draw a random question of the given level. The question is removed
        /// from the pool, so it will never be drawn again.
        /// </summary>
        /// <param name="level">Difficulty level</param>
        /// <returns>The question or null when the level has no question left</returns>
        public Question Draw(int level)
        {
            List<int> pool;
            if (!this.pools.TryGetValue(level, out pool) || pool.Count == 0)
                return null;

            int position = this.random.Next(0, pool.Count);
            int index = pool[position];

            pool.RemoveAt(position);
            this.available.Remove(index);

            return this.questionary[index];
        }

        /// <summary>
        /// Remove a question from the pool of its level
        /// </summary>
        /// <param name="level">Difficulty level of the question</param>
        /// <param name="index">Index of the question into the questionary</param>
        private void RemoveFromPool(int level, int index)
        {
            List<int> pool;
            if (this.pools.TryGetValue(level, out pool))
                pool.Remove(index);
        }
    }
}
