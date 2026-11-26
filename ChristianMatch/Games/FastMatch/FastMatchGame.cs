using System;

using ChristianMatch.Games.Core;

namespace ChristianMatch.Games.FastMatch
{
    /// <summary>
    /// Logic of the FastMatch game. Both teams answer the same question at
    /// the same time and the points go to the team which answers right. When
    /// both teams answer right the points are split between them.
    /// </summary>
    public class FastMatchGame : GameBase
    {
        /// <summary>
        /// Configuration of the game
        /// </summary>
        private FastMatchConfig config;

        /// <summary>
        /// Score of the first team
        /// </summary>
        private int pointsTeam1;

        /// <summary>
        /// Score of the second team
        /// </summary>
        private int pointsTeam2;

        /// <summary>
        /// State of the game before the last answer, used by the rollback
        /// </summary>
        private SavedState savedState;

        /// <summary>
        /// Copy of the parts of the state changed by an answer
        /// </summary>
        private struct SavedState
        {
            public int PointsTeam1;

            public int PointsTeam2;
        }

        /// <summary>
        /// Constructor of the class
        /// </summary>
        /// <param name="config">Configuration of the game</param>
        public FastMatchGame(FastMatchConfig config)
            : base(config.Questionary)
        {
            if (config.EqualValue && config.QuestionValue < 1)
                throw new ArgumentException("The question value must be at least one when the equal value option is enabled.", "config");

            this.config = config;
        }

        /// <summary>
        /// Get the identifier of the team which plays right now. It always
        /// returns null because both teams answer together.
        /// </summary>
        public override string CurrentTeam
        {
            get
            {
                return null;
            }
        }

        /// <summary>
        /// Get the score of the first team
        /// </summary>
        public override int ScoreTeam1
        {
            get
            {
                return this.pointsTeam1;
            }
        }

        /// <summary>
        /// Get the score of the second team
        /// </summary>
        public override int ScoreTeam2
        {
            get
            {
                return this.pointsTeam2;
            }
        }

        /// <summary>
        /// Reset the state of the game. It is called from Start.
        /// </summary>
        protected override void ResetState()
        {
            this.pointsTeam1 = 0;
            this.pointsTeam2 = 0;
        }

        /// <summary>
        /// Take a copy of the state of the game before applying an answer.
        /// </summary>
        protected override void SaveState()
        {
            this.savedState.PointsTeam1 = this.pointsTeam1;
            this.savedState.PointsTeam2 = this.pointsTeam2;
        }

        /// <summary>
        /// Restore the copy of the state taken before applying an answer.
        /// </summary>
        protected override void RestoreState()
        {
            this.pointsTeam1 = this.savedState.PointsTeam1;
            this.pointsTeam2 = this.savedState.PointsTeam2;
        }

        /// <summary>
        /// Apply the outcome of an answer: the points go to the team which
        /// answered right or they are split when both teams answered right.
        /// </summary>
        /// <param name="outcome">Outcome of the answer</param>
        protected override void ApplyAnswer(AnswerOutcome outcome)
        {
            int points = this.config.EqualValue ? this.config.QuestionValue : this.PendingQuestionLevel * 5;

            switch (outcome)
            {
                case AnswerOutcome.Team1:
                    this.pointsTeam1 += points;
                    break;

                case AnswerOutcome.Team2:
                    this.pointsTeam2 += points;
                    break;

                case AnswerOutcome.Both:
                    // Split the points between both teams. An odd value is
                    // rounded up to keep the split even.
                    if (points % 2 == 1)
                        points++;

                    this.pointsTeam1 += points / 2;
                    this.pointsTeam2 += points / 2;
                    break;

                case AnswerOutcome.None:
                    // Nobody answered right, nobody gets points
                    break;
            }
        }

        /// <summary>
        /// Indicate the game supports the outcomes of two teams answering at
        /// the same time.
        /// </summary>
        /// <param name="outcome">Outcome of the answer</param>
        /// <returns>True if the outcome is supported, false if not</returns>
        protected override bool IsSupportedOutcome(AnswerOutcome outcome)
        {
            return outcome == AnswerOutcome.Team1 ||
                   outcome == AnswerOutcome.Team2 ||
                   outcome == AnswerOutcome.Both ||
                   outcome == AnswerOutcome.None;
        }

        /// <summary>
        /// Draw a random question which has not been played yet.
        /// </summary>
        /// <returns>The question or null</returns>
        protected override Common.Question DrawNextQuestion()
        {
            return this.Bag.Draw();
        }
    }
}
