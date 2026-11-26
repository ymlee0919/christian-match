using System;

using ChristianMatch.Games.Core;

namespace ChristianMatch.Games.SimpleMatch
{
    /// <summary>
    /// Logic of the SimpleMatch game. The teams play in turns: the first team
    /// answers a question and then the second team answers another one. The
    /// visualization reads the scores and the team which plays next.
    /// </summary>
    public class SimpleMatchGame : GameBase
    {
        /// <summary>
        /// Index of the first team into the turns
        /// </summary>
        private const int FirstTeam = 0;

        /// <summary>
        /// Configuration of the game
        /// </summary>
        private SimpleMatchConfig config;

        /// <summary>
        /// Score of the first team
        /// </summary>
        private int pointsTeam1;

        /// <summary>
        /// Score of the second team
        /// </summary>
        private int pointsTeam2;

        /// <summary>
        /// Index of the team which plays the next question
        /// </summary>
        private int currentTurn;

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

            public int CurrentTurn;
        }

        /// <summary>
        /// Constructor of the class
        /// </summary>
        /// <param name="config">Configuration of the game</param>
        public SimpleMatchGame(SimpleMatchConfig config)
            : base(config.Questionary)
        {
            if (config.EqualValue && config.QuestionValue < 1)
                throw new ArgumentException("The question value must be at least one when the equal value option is enabled.", "config");

            this.config = config;
        }

        /// <summary>
        /// Get the identifier of the team which plays the next question
        /// </summary>
        public override string CurrentTeam
        {
            get
            {
                return (this.currentTurn == FirstTeam) ? this.Team1 : this.Team2;
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
        /// Get the number of questions needed to play the next question. A
        /// round needs one question for each team, so two questions are needed
        /// when the first team starts the round.
        /// </summary>
        protected override int QuestionsRequiredForNextQuestion
        {
            get
            {
                return (this.currentTurn == FirstTeam) ? 2 : 1;
            }
        }

        /// <summary>
        /// Reset the state of the game. It is called from Start.
        /// </summary>
        protected override void ResetState()
        {
            this.pointsTeam1 = 0;
            this.pointsTeam2 = 0;
            this.currentTurn = FirstTeam;
        }

        /// <summary>
        /// Take a copy of the state of the game before applying an answer.
        /// </summary>
        protected override void SaveState()
        {
            this.savedState.PointsTeam1 = this.pointsTeam1;
            this.savedState.PointsTeam2 = this.pointsTeam2;
            this.savedState.CurrentTurn = this.currentTurn;
        }

        /// <summary>
        /// Restore the copy of the state taken before applying an answer.
        /// </summary>
        protected override void RestoreState()
        {
            this.pointsTeam1 = this.savedState.PointsTeam1;
            this.pointsTeam2 = this.savedState.PointsTeam2;
            this.currentTurn = this.savedState.CurrentTurn;
        }

        /// <summary>
        /// Apply the outcome of an answer: the team in turn gets the points of
        /// a right answer and the turn goes to the other team.
        /// </summary>
        /// <param name="outcome">Outcome of the answer</param>
        protected override void ApplyAnswer(AnswerOutcome outcome)
        {
            if (outcome == AnswerOutcome.Correct)
            {
                int points = this.config.EqualValue ? this.config.QuestionValue : this.PendingQuestionLevel * 5;

                if (this.currentTurn == FirstTeam)
                    this.pointsTeam1 += points;
                else
                    this.pointsTeam2 += points;
            }

            // The turn always goes to the other team
            this.currentTurn = (this.currentTurn == FirstTeam) ? 1 : FirstTeam;
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
