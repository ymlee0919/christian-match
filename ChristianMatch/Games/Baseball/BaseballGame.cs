using System;
using System.Collections.Generic;

using ChristianMatch.Games.Core;

namespace ChristianMatch.Games.Baseball
{
    /// <summary>
    /// Logic of the Baseball game. The visualization reads the state of the
    /// game (innings, outs, bases, score, ...) and asks for the next question
    /// with the level of the hit the batter wants to play.
    /// </summary>
    public class BaseballGame : GameBase
    {
        /// <summary>
        /// Configuration of the game
        /// </summary>
        private BaseballConfig config;

        /// <summary>
        /// State of the game
        /// </summary>
        private BaseballState state;

        /// <summary>
        /// State of the game before the last answer, used by the rollback
        /// </summary>
        private BaseballState savedState;

        /// <summary>
        /// Level selected to play the pending question
        /// </summary>
        private int pendingHitLevel;

        /// <summary>
        /// Type of hit of the pending question
        /// </summary>
        private HitType pendingHitType;

        /// <summary>
        /// Indicate a hit level was selected for the pending question
        /// </summary>
        private bool hitLevelSelected;

        /// <summary>
        /// Type of hit applied by the last answer
        /// </summary>
        private HitType lastAppliedHit;

        /// <summary>
        /// Indicate the last answer scored at least one run
        /// </summary>
        private bool lastRaceScored;

        /// <summary>
        /// Constructor of the class
        /// </summary>
        /// <param name="config">Configuration of the game</param>
        public BaseballGame(BaseballConfig config)
            : base(config.Questionary)
        {
            if (config.Innings < 1)
                throw new ArgumentException("The number of innings must be at least one.", "config");

            this.config = config;
        }

        /// <summary>
        /// Get the number of innings of the game
        /// </summary>
        public int Innings
        {
            get
            {
                return this.config.Innings;
            }
        }

        /// <summary>
        /// Get the current inning, 1-based. It returns 0 before the game starts.
        /// </summary>
        public int CurrentInning
        {
            get
            {
                return (this.state == null) ? 0 : this.state.CurrentInning;
            }
        }

        /// <summary>
        /// Get the number of outs of the current batter
        /// </summary>
        public int Outs
        {
            get
            {
                return (this.state == null) ? 0 : this.state.Outs;
            }
        }

        /// <summary>
        /// Indicate the game is over because the innings finished
        /// </summary>
        public bool EndOfGame
        {
            get
            {
                return this.state != null && this.state.EndOfGame;
            }
        }

        /// <summary>
        /// Get the score of every inning
        /// </summary>
        public BoardScore[] ScoreBoard
        {
            get
            {
                return (this.state == null) ? new BoardScore[0] : this.state.ScoreBoard;
            }
        }

        /// <summary>
        /// Get the identifier of the team which is batting
        /// </summary>
        public string BatterTeam
        {
            get
            {
                if (this.state == null)
                    return null;

                return (this.state.BatterIndex == 0) ? this.Team1 : this.Team2;
            }
        }

        /// <summary>
        /// Get the identifier of the team which is covering the field
        /// </summary>
        public string CoverTeam
        {
            get
            {
                if (this.state == null)
                    return null;

                return (this.state.BatterIndex == 0) ? this.Team2 : this.Team1;
            }
        }

        /// <summary>
        /// Get the identifier of the team which is playing right now, that is,
        /// the team which is batting
        /// </summary>
        public override string CurrentTeam
        {
            get
            {
                return this.BatterTeam;
            }
        }

        /// <summary>
        /// Get the score of the first team. Every run is worth 10 points.
        /// </summary>
        public override int ScoreTeam1
        {
            get
            {
                return (this.state == null) ? 0 : this.state.Team1Races * 10;
            }
        }

        /// <summary>
        /// Get the score of the second team. Every run is worth 10 points.
        /// </summary>
        public override int ScoreTeam2
        {
            get
            {
                return (this.state == null) ? 0 : this.state.Team2Races * 10;
            }
        }

        /// <summary>
        /// Get the type of hit applied by the last answer. It returns Out when
        /// the answer was wrong.
        /// </summary>
        public HitType LastAppliedHit
        {
            get
            {
                return this.lastAppliedHit;
            }
        }

        /// <summary>
        /// Indicate the last answer scored at least one run
        /// </summary>
        public bool LastRaceScored
        {
            get
            {
                return this.lastRaceScored;
            }
        }

        /// <summary>
        /// Indicate the given base has a runner
        /// </summary>
        /// <param name="theBase">Number of the base, from 1 to 3</param>
        /// <returns>True if the base is busy, false if not</returns>
        public bool BaseBusy(int theBase)
        {
            return this.state != null && this.state.BaseBusy(theBase);
        }

        /// <summary>
        /// Indicate there are questions left for the given hit level
        /// </summary>
        /// <param name="hitLevel">Level of the hit, from 1 to 5</param>
        /// <returns>True if the level can be played, false if not</returns>
        public bool IsHitLevelAvailable(int hitLevel)
        {
            return this.Bag != null && this.Bag.IsLevelAvailable(hitLevel);
        }

        /// <summary>
        /// Get the hit levels which can be played right now
        /// </summary>
        /// <returns>The array of available levels</returns>
        public int[] GetAvailableHitLevels()
        {
            List<int> levels = new List<int>();

            if (this.Bag != null)
            {
                for (int level = 1; level <= 5; level++)
                {
                    if (this.Bag.IsLevelAvailable(level))
                        levels.Add(level);
                }
            }

            return levels.ToArray();
        }

        /// <summary>
        /// Request the next question for the given hit level. The level selects
        /// the type of hit the batter will play when the answer is right.
        /// </summary>
        /// <param name="hitLevel">Level of the hit, from 1 to 5</param>
        /// <returns>The question or null when the game has no more questions</returns>
        public Common.Question NextQuestion(int hitLevel)
        {
            if (hitLevel < 1 || hitLevel > 5)
                throw new ArgumentOutOfRangeException("hitLevel", "The hit level must be between 1 and 5.");

            if (!this.PrepareQuestionRequest())
                return null;

            if (!this.Bag.IsLevelAvailable(hitLevel))
                throw new InvalidOperationException("There are no questions left for the hit level " + hitLevel + ".");

            this.pendingHitLevel = hitLevel;
            this.pendingHitType = HitTypeForLevel(hitLevel);
            this.hitLevelSelected = true;

            return this.DrawAndSetPendingQuestion();
        }

        /// <summary>
        /// Reset the state of the game. It is called from Start.
        /// </summary>
        protected override void ResetState()
        {
            this.state = new BaseballState(this.config.Innings);
            this.pendingHitLevel = 0;
            this.pendingHitType = HitType.Out;
            this.hitLevelSelected = false;
            this.lastAppliedHit = HitType.Out;
            this.lastRaceScored = false;
        }

        /// <summary>
        /// Take a copy of the state of the game before applying an answer.
        /// </summary>
        protected override void SaveState()
        {
            this.savedState = this.state.Clone();
        }

        /// <summary>
        /// Restore the copy of the state taken before applying an answer.
        /// </summary>
        protected override void RestoreState()
        {
            this.state = this.savedState.Clone();
        }

        /// <summary>
        /// Apply the outcome of an answer to the state of the game: a right
        /// answer produces the selected hit and a wrong answer produces an out.
        /// </summary>
        /// <param name="outcome">Outcome of the answer</param>
        protected override void ApplyAnswer(AnswerOutcome outcome)
        {
            if (outcome == AnswerOutcome.Correct)
            {
                this.lastAppliedHit = this.pendingHitType;
                this.lastRaceScored = this.state.HitAction(this.pendingHitType);
            }
            else
            {
                this.lastAppliedHit = HitType.Out;
                this.lastRaceScored = false;
                this.state.HitAction(HitType.Out);
            }

            if (this.state.EndOfGame)
                this.MarkAsFinished();
        }

        /// <summary>
        /// Draw a question of the selected hit level.
        /// </summary>
        /// <returns>The question or null</returns>
        protected override Common.Question DrawNextQuestion()
        {
            if (!this.hitLevelSelected)
                throw new InvalidOperationException("The hit level has not been selected. Use NextQuestion(int hitLevel).");

            // The selection is consumed by this question
            this.hitLevelSelected = false;

            Common.Question question = this.Bag.Draw(this.pendingHitLevel);

            if (question == null)
                throw new InvalidOperationException("There are no questions left for the hit level " + this.pendingHitLevel + ".");

            return question;
        }

        /// <summary>
        /// Map a hit level to its type of hit
        /// </summary>
        /// <param name="hitLevel">Level of the hit, from 1 to 5</param>
        /// <returns>The type of hit</returns>
        private static HitType HitTypeForLevel(int hitLevel)
        {
            switch (hitLevel)
            {
                case 1:
                case 2:
                    return HitType.Hit;

                case 3:
                    return HitType.Double;

                case 4:
                    return HitType.Triple;

                case 5:
                    return HitType.Homerun;

                default:
                    throw new ArgumentOutOfRangeException("hitLevel", "The hit level must be between 1 and 5.");
            }
        }
    }
}
