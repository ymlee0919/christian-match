using System;

using ChristianMatch.Games.Core;

namespace ChristianMatch.Games.WalkingUp
{
    /// <summary>
    /// Logic of the WalkingUp game. The teams play in turns. Before the
    /// question, the team in turn chooses how many steps it wants to climb
    /// (from 1 to 3) and the difficulty level of the question depends on the
    /// chosen steps and on the current position of the team. A right answer
    /// climbs the chosen steps; a wrong answer makes the team go down.
    /// </summary>
    public class WalkingUpGame : GameBase
    {
        /// <summary>
        /// Index of the first team into the turns
        /// </summary>
        private const int FirstTeam = 0;

        /// <summary>
        /// Minimum number of steps of the mountain
        /// </summary>
        private const int MinimumSteps = 3;

        /// <summary>
        /// Configuration of the game
        /// </summary>
        private WalkingUpConfig config;

        /// <summary>
        /// Position of the first team into the mountain, from 0 to Steps
        /// </summary>
        private int positionTeam1;

        /// <summary>
        /// Position of the second team into the mountain, from 0 to Steps
        /// </summary>
        private int positionTeam2;

        /// <summary>
        /// Index of the team which plays the next question
        /// </summary>
        private int currentTurn;

        /// <summary>
        /// Number of steps chosen for the pending question
        /// </summary>
        private int pendingSteps;

        /// <summary>
        /// Difficulty level of the pending question
        /// </summary>
        private int pendingLevel;

        /// <summary>
        /// Indicate the steps were selected for the pending question
        /// </summary>
        private bool stepsSelected;

        /// <summary>
        /// State of the game before the last answer, used by the rollback
        /// </summary>
        private SavedState savedState;

        /// <summary>
        /// Copy of the parts of the state changed by an answer
        /// </summary>
        private struct SavedState
        {
            public int PositionTeam1;

            public int PositionTeam2;

            public int CurrentTurn;
        }

        /// <summary>
        /// Constructor of the class
        /// </summary>
        /// <param name="config">Configuration of the game</param>
        public WalkingUpGame(WalkingUpConfig config)
            : base(config.Questionary)
        {
            if (config.Steps < MinimumSteps)
                throw new ArgumentException("The number of steps must be at least " + MinimumSteps + ".", "config");

            this.config = config;
        }

        /// <summary>
        /// Get the number of steps needed to reach the top of the mountain
        /// </summary>
        public int TotalSteps
        {
            get
            {
                return this.config.Steps;
            }
        }

        /// <summary>
        /// Get the position of the first team, from 0 to TotalSteps
        /// </summary>
        public int PositionTeam1
        {
            get
            {
                return this.positionTeam1;
            }
        }

        /// <summary>
        /// Get the position of the second team, from 0 to TotalSteps
        /// </summary>
        public int PositionTeam2
        {
            get
            {
                return this.positionTeam2;
            }
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
        /// Get the score of the first team. Every step is worth 5 points.
        /// </summary>
        public override int ScoreTeam1
        {
            get
            {
                return this.positionTeam1 * 5;
            }
        }

        /// <summary>
        /// Get the score of the second team. Every step is worth 5 points.
        /// </summary>
        public override int ScoreTeam2
        {
            get
            {
                return this.positionTeam2 * 5;
            }
        }

        /// <summary>
        /// Get the difficulty level of the questions the team in turn is able
        /// to play according its current position.
        /// </summary>
        public int CurrentLevel
        {
            get
            {
                return CalculateLevel(this.config.Steps, this.CurrentPosition);
            }
        }

        /// <summary>
        /// Get the position of the team in turn
        /// </summary>
        private int CurrentPosition
        {
            get
            {
                return (this.currentTurn == FirstTeam) ? this.positionTeam1 : this.positionTeam2;
            }
        }

        /// <summary>
        /// Indicate the team in turn can play the given number of steps, that
        /// is, there are questions left for the level the steps would select.
        /// </summary>
        /// <param name="stepCount">Number of steps, from 1 to 3</param>
        /// <returns>True if the steps can be chosen, false if not</returns>
        public bool IsStepAllowed(int stepCount)
        {
            if (this.Bag == null)
                return false;

            if (stepCount < 1 || stepCount > 3)
                return false;

            return this.Bag.IsLevelAvailable(this.CurrentLevel + stepCount - 1);
        }

        /// <summary>
        /// Get which number of steps the team in turn can choose: the first
        /// value is for 1 step, the second for 2 steps and the third for 3 steps.
        /// </summary>
        /// <returns>The array of flags</returns>
        public bool[] GetAllowedSteps()
        {
            return new bool[]
            {
                this.IsStepAllowed(1),
                this.IsStepAllowed(2),
                this.IsStepAllowed(3)
            };
        }

        /// <summary>
        /// Request the next question for the given number of steps. The
        /// difficulty level of the question is the level of the team in turn
        /// plus the chosen steps minus one.
        /// </summary>
        /// <param name="stepCount">Number of steps, from 1 to 3</param>
        /// <returns>The question or null when the game has no more questions</returns>
        public Common.Question NextQuestion(int stepCount)
        {
            if (stepCount < 1 || stepCount > 3)
                throw new ArgumentOutOfRangeException("stepCount", "The number of steps must be between 1 and 3.");

            if (!this.PrepareQuestionRequest())
                return null;

            if (!this.IsStepAllowed(stepCount))
                throw new InvalidOperationException("There are no questions left to play " + stepCount + " step(s).");

            this.pendingSteps = stepCount;
            this.pendingLevel = this.CurrentLevel + stepCount - 1;
            this.stepsSelected = true;

            return this.DrawAndSetPendingQuestion();
        }

        /// <summary>
        /// Reset the state of the game. It is called from Start.
        /// </summary>
        protected override void ResetState()
        {
            this.positionTeam1 = 0;
            this.positionTeam2 = 0;
            this.currentTurn = FirstTeam;
            this.pendingSteps = 0;
            this.pendingLevel = 0;
            this.stepsSelected = false;
        }

        /// <summary>
        /// Take a copy of the state of the game before applying an answer.
        /// </summary>
        protected override void SaveState()
        {
            this.savedState.PositionTeam1 = this.positionTeam1;
            this.savedState.PositionTeam2 = this.positionTeam2;
            this.savedState.CurrentTurn = this.currentTurn;
        }

        /// <summary>
        /// Restore the copy of the state taken before applying an answer.
        /// </summary>
        protected override void RestoreState()
        {
            this.positionTeam1 = this.savedState.PositionTeam1;
            this.positionTeam2 = this.savedState.PositionTeam2;
            this.currentTurn = this.savedState.CurrentTurn;
        }

        /// <summary>
        /// Apply the outcome of an answer: a right answer climbs the chosen
        /// steps and a wrong answer makes the team go down. The first team
        /// which reaches the top wins the game.
        /// </summary>
        /// <param name="outcome">Outcome of the answer</param>
        protected override void ApplyAnswer(AnswerOutcome outcome)
        {
            int position = this.CurrentPosition;

            if (outcome == AnswerOutcome.Correct)
                position = Math.Min(this.config.Steps, position + this.pendingSteps);
            else
                position = Math.Max(0, position - ((this.pendingSteps == 3) ? 2 : 1));

            if (this.currentTurn == FirstTeam)
                this.positionTeam1 = position;
            else
                this.positionTeam2 = position;

            // The team reached the top of the mountain
            if (position >= this.config.Steps)
            {
                this.MarkAsFinished();
                return;
            }

            // The turn goes to the other team
            this.currentTurn = (this.currentTurn == FirstTeam) ? 1 : FirstTeam;
        }

        /// <summary>
        /// Draw a question of the level selected with the chosen steps.
        /// </summary>
        /// <returns>The question or null</returns>
        protected override Common.Question DrawNextQuestion()
        {
            if (!this.stepsSelected)
                throw new InvalidOperationException("The number of steps has not been selected. Use NextQuestion(int stepCount).");

            // The selection is consumed by this question
            this.stepsSelected = false;

            Common.Question question = this.Bag.Draw(this.pendingLevel);

            if (question == null)
                throw new InvalidOperationException("There are no questions left for the level " + this.pendingLevel + ".");

            return question;
        }

        /// <summary>
        /// Calculate the difficulty level of the questions a team can play
        /// from a given position. The mountain has three levels; the first one
        /// is the largest.
        /// </summary>
        /// <param name="steps">Number of steps of the mountain</param>
        /// <param name="position">Current position of the team</param>
        /// <returns>The level, from 1 to 3</returns>
        private static int CalculateLevel(int steps, int position)
        {
            int level1 = steps / 3;
            int level2 = steps / 3;

            int rest = steps % 3;
            if (rest != 0)
                level1++;
            if (rest == 2)
                level2++;

            level2 += level1;

            if (position <= level1)
                return 1;

            if (position <= level2)
                return 2;

            return 3;
        }
    }
}
