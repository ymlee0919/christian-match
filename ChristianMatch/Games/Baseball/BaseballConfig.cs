using System;

namespace ChristianMatch.Games.Baseball
{
    /// <summary>
    /// Configuration of the Baseball game. It only contains the options which
    /// affect the state of the game; the visualization options live in
    /// Core.ViewConfig.
    /// </summary>
    public struct BaseballConfig
    {
        /// <summary>
        /// Readable name of the questionary used to play
        /// </summary>
        public string Questionary;

        /// <summary>
        /// Number of innings of the game
        /// </summary>
        public int Innings;
    }
}
