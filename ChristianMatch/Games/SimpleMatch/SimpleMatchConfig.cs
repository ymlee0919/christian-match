using System;

namespace ChristianMatch.Games.SimpleMatch
{
    /// <summary>
    /// Configuration of the SimpleMatch game. It only contains the options
    /// which affect the state of the game; the visualization options live in
    /// Core.ViewConfig.
    /// </summary>
    public struct SimpleMatchConfig
    {
        /// <summary>
        /// Readable name of the questionary used to play
        /// </summary>
        public string Questionary;

        /// <summary>
        /// Indicate every right answer gives the same number of points
        /// </summary>
        public bool EqualValue;

        /// <summary>
        /// Points of a right answer when EqualValue is enabled
        /// </summary>
        public int QuestionValue;
    }
}
