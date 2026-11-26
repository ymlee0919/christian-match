using System;

namespace ChristianMatch.Games.Core
{
    /// <summary>
    /// Possible statuses of a game.
    /// </summary>
    public enum GameStatus
    {
        /// <summary>
        /// The game has not been started yet
        /// </summary>
        NotStarted,

        /// <summary>
        /// The game is in progress
        /// </summary>
        Running,

        /// <summary>
        /// The game is over
        /// </summary>
        Finished
    }
}
