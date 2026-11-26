using System;

namespace ChristianMatch.Games.Core
{
    /// <summary>
    /// Base class shared by all the games. It implements the common behavior:
    /// status of the game, questionary handling, control of the question which
    /// is being played and the rollback mechanism. Every game only implements
    /// the rules which change its own state.
    /// </summary>
    public abstract class GameBase : IGame
    {
        /// <summary>
        /// Name of the questionary used by the game
        /// </summary>
        private string questionaryName;

        /// <summary>
        /// Current status of the game
        /// </summary>
        private GameStatus status;

        /// <summary>
        /// Indicate the game stopped because there were not enough questions
        /// </summary>
        private bool questionsExhausted;

        /// <summary>
        /// Identifier of the first team
        /// </summary>
        private string team1;

        /// <summary>
        /// Identifier of the second team
        /// </summary>
        private string team2;

        /// <summary>
        /// Pool of questions which have not been played yet
        /// </summary>
        private QuestionBag bag;

        /// <summary>
        /// Question which was requested and has not been answered yet
        /// </summary>
        private Common.Question pendingQuestion;

        /// <summary>
        /// Difficulty level of the question which was requested
        /// </summary>
        private int pendingQuestionLevel;

        /// <summary>
        /// Indicate an answer was applied and has not been rolled back yet
        /// </summary>
        private bool answerApplied;

        /// <summary>
        /// Status of the game before the last answer
        /// </summary>
        private GameStatus savedStatus;

        /// <summary>
        /// Exhausted flag of the game before the last answer
        /// </summary>
        private bool savedQuestionsExhausted;

        /// <summary>
        /// Constructor of the class
        /// </summary>
        /// <param name="questionaryName">Readable name of the questionary to play</param>
        protected GameBase(string questionaryName)
        {
            if (string.IsNullOrEmpty(questionaryName))
                throw new ArgumentException("The questionary name is required.", "questionaryName");

            this.questionaryName = questionaryName;
            this.status = GameStatus.NotStarted;
        }

        /// <summary>
        /// Get the current status of the game
        /// </summary>
        public GameStatus Status
        {
            get
            {
                return this.status;
            }
        }

        /// <summary>
        /// Indicate the game is over
        /// </summary>
        public bool IsFinished
        {
            get
            {
                return this.status == GameStatus.Finished;
            }
        }

        /// <summary>
        /// Indicate the game stopped because there were not enough questions
        /// to play a complete round
        /// </summary>
        public bool QuestionsExhausted
        {
            get
            {
                return this.questionsExhausted;
            }
        }

        /// <summary>
        /// Get the number of questions which have not been played yet
        /// </summary>
        public int RemainingQuestions
        {
            get
            {
                return (this.bag == null) ? 0 : this.bag.Remaining;
            }
        }

        /// <summary>
        /// Get the readable name of the questionary used by the game
        /// </summary>
        public string QuestionaryName
        {
            get
            {
                return this.questionaryName;
            }
        }

        /// <summary>
        /// Get the identifier of the first team
        /// </summary>
        public string Team1
        {
            get
            {
                return this.team1;
            }
        }

        /// <summary>
        /// Get the identifier of the second team
        /// </summary>
        public string Team2
        {
            get
            {
                return this.team2;
            }
        }

        /// <summary>
        /// Get the identifier of the team which is playing right now. It
        /// returns null when the game has no turns.
        /// </summary>
        public abstract string CurrentTeam { get; }

        /// <summary>
        /// Get the score of the first team
        /// </summary>
        public abstract int ScoreTeam1 { get; }

        /// <summary>
        /// Get the score of the second team
        /// </summary>
        public abstract int ScoreTeam2 { get; }

        /// <summary>
        /// Get the identifier of the winner. It returns null when the game is
        /// not finished or when the game finished tied.
        /// </summary>
        public string Winner
        {
            get
            {
                if (this.status != GameStatus.Finished)
                    return null;

                if (this.ScoreTeam1 == this.ScoreTeam2)
                    return null;

                return (this.ScoreTeam1 > this.ScoreTeam2) ? this.team1 : this.team2;
            }
        }

        /// <summary>
        /// Indicate the game finished with the same score for both teams
        /// </summary>
        public bool IsTie
        {
            get
            {
                return this.status == GameStatus.Finished && this.ScoreTeam1 == this.ScoreTeam2;
            }
        }

        /// <summary>
        /// Start the game with the given teams. Calling it again restarts the
        /// game with a brand new set of questions.
        /// </summary>
        /// <param name="team1">Identifier of the first team</param>
        /// <param name="team2">Identifier of the second team</param>
        public void Start(string team1, string team2)
        {
            if (string.IsNullOrEmpty(team1))
                throw new ArgumentException("The first team is required.", "team1");

            if (string.IsNullOrEmpty(team2))
                throw new ArgumentException("The second team is required.", "team2");

            if (team1 == team2)
                throw new ArgumentException("The game needs two different teams.", "team2");

            this.team1 = team1;
            this.team2 = team2;

            // Every game starts with a brand new questionary, so the questions
            // played in a previous game are available again
            this.bag = new QuestionBag(this.questionaryName);

            this.ResetState();

            this.pendingQuestion = null;
            this.pendingQuestionLevel = 0;
            this.answerApplied = false;
            this.questionsExhausted = false;
            this.status = GameStatus.Running;
        }

        /// <summary>
        /// End the game manually. It has no effect when the game is not running.
        /// </summary>
        public void Finish()
        {
            if (this.status != GameStatus.Running)
                return;

            this.status = GameStatus.Finished;
            this.questionsExhausted = false;
        }

        /// <summary>
        /// Request the next question of the game. The questions are never
        /// repeated.
        /// </summary>
        /// <returns>The question or null when the game has no more questions</returns>
        public Common.Question NextQuestion()
        {
            if (!this.PrepareQuestionRequest())
                return null;

            return this.DrawAndSetPendingQuestion();
        }

        /// <summary>
        /// Give the outcome of the question which is being played in order to
        /// update the state of the game.
        /// </summary>
        /// <param name="outcome">Outcome of the answer</param>
        public void Answer(AnswerOutcome outcome)
        {
            if (this.status != GameStatus.Running)
                throw new InvalidOperationException("The game is not running.");

            if (this.pendingQuestion == null)
                throw new InvalidOperationException("There is no pending question. Request it with NextQuestion before answering.");

            if (!this.IsSupportedOutcome(outcome))
                throw new ArgumentException("The outcome '" + outcome.ToString() + "' is not supported by this game.", "outcome");

            // Take a snapshot of the current state to make the rollback possible
            this.savedStatus = this.status;
            this.savedQuestionsExhausted = this.questionsExhausted;
            this.SaveState();
            this.answerApplied = true;

            // The question is consumed, it never goes back to the bag
            this.pendingQuestion = null;

            this.ApplyAndCheck(outcome);
        }

        /// <summary>
        /// Indicate the last answer can be corrected with a rollback. It is
        /// only true after an answer and until the next question is requested.
        /// </summary>
        public bool CanRollback
        {
            get
            {
                return this.answerApplied && this.pendingQuestion == null;
            }
        }

        /// <summary>
        /// Correct the outcome of the last answer. The state of the game is
        /// restored to the previous situation and the new outcome is applied.
        /// The same answer can only be rolled back once.
        /// </summary>
        /// <param name="outcome">The real outcome of the last answer</param>
        public void Rollback(AnswerOutcome outcome)
        {
            if (!this.answerApplied)
                throw new InvalidOperationException("Only the last answer can be rolled back and only once.");

            if (this.pendingQuestion != null)
                throw new InvalidOperationException("The rollback is only available until the next question is requested.");

            if (!this.IsSupportedOutcome(outcome))
                throw new ArgumentException("The outcome '" + outcome.ToString() + "' is not supported by this game.", "outcome");

            // Restore the state previous to the last answer
            this.status = this.savedStatus;
            this.questionsExhausted = this.savedQuestionsExhausted;
            this.RestoreState();

            // The same answer can not be rolled back twice
            this.answerApplied = false;

            this.ApplyAndCheck(outcome);
        }

        /// <summary>
        /// Get the pool of questions of the game
        /// </summary>
        protected QuestionBag Bag
        {
            get
            {
                return this.bag;
            }
        }

        /// <summary>
        /// Get the difficulty level of the question which was requested
        /// </summary>
        protected int PendingQuestionLevel
        {
            get
            {
                return this.pendingQuestionLevel;
            }
        }

        /// <summary>
        /// Get the number of questions needed to request the next question.
        /// It is used to detect the game can not continue because the
        /// questionary is about to be exhausted.
        /// </summary>
        protected virtual int QuestionsRequiredForNextQuestion
        {
            get
            {
                return 1;
            }
        }

        /// <summary>
        /// Reset the state of the game. It is called from Start.
        /// </summary>
        protected abstract void ResetState();

        /// <summary>
        /// Take a copy of the state of the game before applying an answer.
        /// </summary>
        protected abstract void SaveState();

        /// <summary>
        /// Restore the copy of the state taken before applying an answer.
        /// </summary>
        protected abstract void RestoreState();

        /// <summary>
        /// Apply the outcome of an answer to the state of the game. It is
        /// called from Answer and from Rollback.
        /// </summary>
        /// <param name="outcome">Outcome of the answer</param>
        protected abstract void ApplyAnswer(AnswerOutcome outcome);

        /// <summary>
        /// Draw the next question of the game. It returns null when the
        /// selection can not be satisfied.
        /// </summary>
        /// <returns>The question or null</returns>
        protected abstract Common.Question DrawNextQuestion();

        /// <summary>
        /// Indicate the game supports the given outcome. Only Correct and
        /// Incorrect are supported by default.
        /// </summary>
        /// <param name="outcome">Outcome of the answer</param>
        /// <returns>True if the outcome is supported, false if not</returns>
        protected virtual bool IsSupportedOutcome(AnswerOutcome outcome)
        {
            return outcome == AnswerOutcome.Correct || outcome == AnswerOutcome.Incorrect;
        }

        /// <summary>
        /// Set the game as finished. It can be called from ApplyAnswer when
        /// the rules of the game decide the game is over.
        /// </summary>
        protected void MarkAsFinished()
        {
            if (this.status == GameStatus.Running)
                this.status = GameStatus.Finished;
        }

        /// <summary>
        /// Validate the game is able to provide a new question. It returns
        /// false when there are not enough questions left; in that case the
        /// game is marked as finished and exhausted.
        /// </summary>
        /// <returns>True if a question can be requested, false if not</returns>
        protected bool PrepareQuestionRequest()
        {
            if (this.status != GameStatus.Running)
                throw new InvalidOperationException("The game is not running.");

            if (this.pendingQuestion != null)
                throw new InvalidOperationException("There is a pending question. Answer it before requesting the next one.");

            if (this.RemainingQuestions < this.QuestionsRequiredForNextQuestion)
            {
                this.questionsExhausted = true;
                this.status = GameStatus.Finished;
                return false;
            }

            return true;
        }

        /// <summary>
        /// Draw a question from the bag and set it as the pending question.
        /// </summary>
        /// <returns>The pending question</returns>
        protected Common.Question DrawAndSetPendingQuestion()
        {
            this.pendingQuestion = this.DrawNextQuestion();

            if (this.pendingQuestion == null)
                throw new InvalidOperationException("There are no questions available for the current selection.");

            this.pendingQuestionLevel = this.pendingQuestion.Level;

            return this.pendingQuestion;
        }

        /// <summary>
        /// Apply the outcome of an answer and check the game can continue.
        /// </summary>
        /// <param name="outcome">Outcome of the answer</param>
        private void ApplyAndCheck(AnswerOutcome outcome)
        {
            this.ApplyAnswer(outcome);

            // The rules of the game may have finished the game (winner, end of
            // game, ...). Only a game still running can be stopped by the
            // lack of questions.
            if (this.status != GameStatus.Finished &&
                this.RemainingQuestions < this.QuestionsRequiredForNextQuestion)
            {
                this.questionsExhausted = true;
                this.status = GameStatus.Finished;
            }
        }
    }
}
