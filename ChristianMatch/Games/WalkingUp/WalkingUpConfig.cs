using System;

namespace ChristianMatch.Games.WalkingUp
{
    /// <summary>
    /// Configuration of the WalkingUp game. It only contains the options which
    /// affect the state of the game; the visualization options live in
    /// Core.ViewConfig.
    /// </summary>
    public struct WalkingUpConfig
    {
        /// <summary>
        /// Readable name of the questionary used to play
        /// </summary>
        public string Questionary;

        /// <summary>
        /// Number of steps needed to reach the top of the mountain
        /// </summary>
        public int Steps;
    }
}
