using System;

namespace ChristianMatch.Games.Core
{
    /// <summary>
    /// Contract every game must fulfill. A game owns its state and its
    /// configuration; the visualization only asks for the next question, gives
    /// the outcome of the answer and reads the results.
    /// </summary>
    public interface IGame
    {
        /// <summary>
        /// Get the current status of the game
        /// </summary>
        GameStatus Status { get; }

        /// <summary>
        /// Indicate the game is over
        /// </summary>
        bool IsFinished { get; }

        /// <summary>
        /// Indicate the game stopped because there were not enough questions
        /// to play a complete round
        /// </summary>
        bool QuestionsExhausted { get; }

        /// <summary>
        /// Get the number of questions which have not been played yet
        /// </summary>
        int RemainingQuestions { get; }

        /// <summary>
        /// Get the identifier of the first team
        /// </summary>
        string Team1 { get; }

        /// <summary>
        /// Get the identifier of the second team
        /// </summary>
        string Team2 { get; }

        /// <summary>
        /// Get the identifier of the team which is playing right now. It
        /// returns null when the game has no turns.
        /// </summary>
        string CurrentTeam { get; }

        /// <summary>
        /// Get the score of the first team
        /// </summary>
        int ScoreTeam1 { get; }

        /// <summary>
        /// Get the score of the second team
        /// </summary>
        int ScoreTeam2 { get; }

        /// <summary>
        /// Get the identifier of the winner. It returns null when the game is
        /// not finished or when the game finished tied.
        /// </summary>
        string Winner { get; }

        /// <summary>
        /// Indicate the game finished with the same score for both teams
        /// </summary>
        bool IsTie { get; }

        /// <summary>
        /// Start the game with the given teams. Calling it again restarts the
        /// game with a brand new set of questions.
        /// </summary>
        /// <param name="team1">Identifier of the first team</param>
        /// <param name="team2">Identifier of the second team</param>
        void Start(string team1, string team2);

        /// <summary>
        /// End the game manually. It has no effect when the game is not running.
        /// </summary>
        void Finish();

        /// <summary>
        /// Request the next question of the game. The questions are never
        /// repeated.
        /// </summary>
        /// <returns>The question or null when the game has no more questions</returns>
        Common.Question NextQuestion();

        /// <summary>
        /// Give the outcome of the question which is being played in order to
        /// update the state of the game.
        /// </summary>
        /// <param name="outcome">Outcome of the answer</param>
        void Answer(AnswerOutcome outcome);

        /// <summary>
        /// Indicate the last answer can be corrected with a rollback. It is
        /// only true after an answer and until the next question is requested.
        /// </summary>
        bool CanRollback { get; }

        /// <summary>
        /// Correct the outcome of the last answer. The state of the game is
        /// restored to the previous situation and the new outcome is applied.
        /// The same answer can only be rolled back once.
        /// </summary>
        /// <param name="outcome">The real outcome of the last answer</param>
        void Rollback(AnswerOutcome outcome);
    }
}
