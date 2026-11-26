using System;

namespace ChristianMatch.Games.Core
{
    /// <summary>
    /// Result of the answer given to a question. Every game defines which
    /// outcomes it supports:
    /// - Baseball, SimpleMatch and WalkingUp only support Correct and Incorrect.
    /// - FastMatch supports Team1, Team2, Both and None because both teams
    ///   answer at the same time.
    /// </summary>
    public enum AnswerOutcome
    {
        /// <summary>
        /// The answer was right
        /// </summary>
        Correct,

        /// <summary>
        /// The answer was wrong
        /// </summary>
        Incorrect,

        /// <summary>
        /// Only the first team answered right
        /// </summary>
        Team1,

        /// <summary>
        /// Only the second team answered right
        /// </summary>
        Team2,

        /// <summary>
        /// Both teams answered right
        /// </summary>
        Both,

        /// <summary>
        /// Neither team answered right
        /// </summary>
        None
    }
}
