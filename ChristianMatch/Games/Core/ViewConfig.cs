using System;

namespace ChristianMatch.Games.Core
{
    /// <summary>
    /// Options which only affect the visualization of a game. They are kept
    /// apart from the game configuration because they never change the state
    /// of the game.
    /// </summary>
    public struct ViewConfig
    {
        /// <summary>
        /// Indicate the possible answers must be shown to the players
        /// </summary>
        public bool ShowPossibleAnswers;

        /// <summary>
        /// Indicate every question has a time limit
        /// </summary>
        public bool LimitedTime;

        /// <summary>
        /// Number of seconds allowed to answer a question
        /// </summary>
        public int Time;
    }
}
