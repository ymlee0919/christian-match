using System;
using System.Collections.Generic;

namespace ChristianMatch.Games.Baseball
{
    /// <summary>
    /// Type of hit the batter gets after answering a question
    /// </summary>
    public enum HitType
    {
        /// <summary>The batter reaches the first base</summary>
        Hit,

        /// <summary>The batter reaches the second base</summary>
        Double,

        /// <summary>The batter reaches the third base</summary>
        Triple,

        /// <summary>The batter hits a home run</summary>
        Homerun,

        /// <summary>The batter is out</summary>
        Out
    }

    /// <summary>
    /// Score of one inning for both teams
    /// </summary>
    public class BoardScore
    {
        private int team1;

        private int team2;

        /// <summary>
        /// Constructor of the class
        /// </summary>
        /// <param name="scoreTeam1">Runs of the first team</param>
        /// <param name="scoreTeam2">Runs of the second team</param>
        public BoardScore(int scoreTeam1, int scoreTeam2)
        {
            this.team1 = scoreTeam1;
            this.team2 = scoreTeam2;
        }

        /// <summary>
        /// Copy constructor of the class
        /// </summary>
        /// <param name="other">Instance to copy</param>
        public BoardScore(BoardScore other)
        {
            this.team1 = other.team1;
            this.team2 = other.team2;
        }

        /// <summary>
        /// Get or set the runs of the first team
        /// </summary>
        public int Team1
        {
            get
            {
                return this.team1;
            }
            set
            {
                this.team1 = value;
            }
        }

        /// <summary>
        /// Get or set the runs of the second team
        /// </summary>
        public int Team2
        {
            get
            {
                return this.team2;
            }
            set
            {
                this.team2 = value;
            }
        }

        /// <summary>
        /// Get a copy of this score
        /// </summary>
        /// <returns>The new instance</returns>
        public BoardScore Clone()
        {
            return new BoardScore(this);
        }
    }

    /// <summary>
    /// State of a Baseball game. It is a cloneable object because the rollback
    /// needs a snapshot of the state before every answer.
    /// </summary>
    public class BaseballState
    {
        /// <summary>
        /// Index of the team which is batting: 0 is the first team, 1 the second
        /// </summary>
        private int batter;

        /// <summary>
        /// Occupied bases. Index 0 is the first base, 1 the second, 2 the third
        /// </summary>
        private bool[] bases;

        /// <summary>
        /// Index of the current inning, 0-based
        /// </summary>
        private int currentInning;

        /// <summary>
        /// Number of outs of the current batter
        /// </summary>
        private int outs;

        /// <summary>
        /// Score of every inning
        /// </summary>
        private List<BoardScore> scoreBoard;

        /// <summary>
        /// Indicate the game is over
        /// </summary>
        private bool endOfGame;

        /// <summary>
        /// Constructor of the class
        /// </summary>
        /// <param name="inningCount">Number of innings of the game</param>
        public BaseballState(int inningCount)
        {
            if (inningCount < 1)
                throw new ArgumentException("The number of innings must be at least one.", "inningCount");

            this.batter = 0;
            this.bases = new bool[3];
            this.currentInning = 0;
            this.outs = 0;
            this.endOfGame = false;
            this.scoreBoard = new List<BoardScore>();

            for (int i = 0; i < inningCount; i++)
                this.scoreBoard.Add(new BoardScore(0, 0));
        }

        /// <summary>
        /// Copy constructor of the class
        /// </summary>
        /// <param name="other">Instance to copy</param>
        private BaseballState(BaseballState other)
        {
            this.batter = other.batter;
            this.bases = new bool[3];
            Array.Copy(other.bases, this.bases, other.bases.Length);
            this.currentInning = other.currentInning;
            this.outs = other.outs;
            this.endOfGame = other.endOfGame;
            this.scoreBoard = new List<BoardScore>();

            foreach (BoardScore score in other.scoreBoard)
                this.scoreBoard.Add(score.Clone());
        }

        /// <summary>
        /// Get a deep copy of this state
        /// </summary>
        /// <returns>The new instance</returns>
        public BaseballState Clone()
        {
            return new BaseballState(this);
        }

        /// <summary>
        /// Get the index of the team which is batting: 0 the first team, 1 the second
        /// </summary>
        public int BatterIndex
        {
            get
            {
                return this.batter;
            }
        }

        /// <summary>
        /// Get the total runs of the first team
        /// </summary>
        public int Team1Races
        {
            get
            {
                int result = 0;
                foreach (BoardScore score in this.scoreBoard)
                    result += score.Team1;

                return result;
            }
        }

        /// <summary>
        /// Get the total runs of the second team
        /// </summary>
        public int Team2Races
        {
            get
            {
                int result = 0;
                foreach (BoardScore score in this.scoreBoard)
                    result += score.Team2;

                return result;
            }
        }

        /// <summary>
        /// Get the number of outs of the current batter
        /// </summary>
        public int Outs
        {
            get
            {
                return this.outs;
            }
        }

        /// <summary>
        /// Get the number of innings of the game
        /// </summary>
        public int Innings
        {
            get
            {
                return this.scoreBoard.Count;
            }
        }

        /// <summary>
        /// Get the current inning, 1-based
        /// </summary>
        public int CurrentInning
        {
            get
            {
                return this.currentInning + 1;
            }
        }

        /// <summary>
        /// Indicate the game is over
        /// </summary>
        public bool EndOfGame
        {
            get
            {
                return this.endOfGame;
            }
        }

        /// <summary>
        /// Indicate the given base has a runner
        /// </summary>
        /// <param name="theBase">Number of the base, from 1 to 3</param>
        /// <returns>True if the base is busy, false if not</returns>
        public bool BaseBusy(int theBase)
        {
            return this.bases[theBase - 1];
        }

        /// <summary>
        /// Get the score of every inning
        /// </summary>
        /// <returns>The array of scores</returns>
        public BoardScore[] ScoreBoard
        {
            get
            {
                return this.scoreBoard.ToArray();
            }
        }

        /// <summary>
        /// Apply a hit to the state of the game.
        /// </summary>
        /// <param name="hit">Type of hit</param>
        /// <returns>True when at least one run was scored, false if not</returns>
        public bool HitAction(HitType hit)
        {
            bool race = false;

            switch (hit)
            {
                case HitType.Out:
                    if (this.outs < 2)
                        this.outs++;
                    else
                    {
                        // Third out: clean outs, bases and change the batter
                        this.outs = 0;
                        this.bases[0] = this.bases[1] = this.bases[2] = false;

                        // The second team closes the inning
                        if (this.batter == 1)
                            this.currentInning++;

                        // Change the batter
                        this.batter = (this.batter == 0) ? 1 : 0;

                        this.CheckEndOfGame();
                    }
                    break;

                case HitType.Hit:
                    // The runner of the third base gets in
                    if (this.bases[2])
                    {
                        this.AddRace();
                        race = true;
                    }

                    // The runners advance one base
                    this.bases[2] = this.bases[1];
                    this.bases[1] = this.bases[0];

                    // The batter reaches the first base
                    this.bases[0] = true;
                    break;

                case HitType.Double:
                    // The runner of the third base gets in
                    if (this.bases[2])
                    {
                        this.AddRace();
                        race = true;
                    }

                    // The runner of the first base goes to the third base
                    this.bases[2] = this.bases[0];

                    // The runner of the second base gets in
                    if (this.bases[1])
                    {
                        this.AddRace();
                        race = true;
                    }

                    // The batter reaches the second base
                    this.bases[1] = true;

                    // The first base is always clean
                    this.bases[0] = false;
                    break;

                case HitType.Triple:
                    // The runner of the third base gets in
                    if (this.bases[2])
                    {
                        this.AddRace();
                        race = true;
                    }
                    this.bases[2] = true;

                    // The runner of the second base gets in
                    if (this.bases[1])
                    {
                        this.AddRace();
                        race = true;
                    }
                    this.bases[1] = false;

                    // The runner of the first base gets in
                    if (this.bases[0])
                    {
                        this.AddRace();
                        race = true;
                    }
                    this.bases[0] = false;
                    break;

                case HitType.Homerun:
                    int races = 1;
                    for (int i = 0; i < 3; i++)
                    {
                        if (this.bases[i])
                            races++;
                        this.bases[i] = false;
                    }

                    if (this.batter == 0)
                        this.scoreBoard[this.currentInning].Team1 += races;
                    else
                        this.scoreBoard[this.currentInning].Team2 += races;

                    race = true;
                    break;
            }

            this.CheckEndOfGame();

            return race;
        }

        /// <summary>
        /// Add one run to the team which is batting
        /// </summary>
        private void AddRace()
        {
            if (this.batter == 0)
                this.scoreBoard[this.currentInning].Team1 += 1;
            else
                this.scoreBoard[this.currentInning].Team2 += 1;
        }

        /// <summary>
        /// Check the game is over
        /// </summary>
        private void CheckEndOfGame()
        {
            // All the innings were played
            if (this.currentInning == this.scoreBoard.Count)
            {
                this.endOfGame = true;
                return;
            }

            // The second team does not need to continue hitting
            if (this.batter == 1 && this.currentInning == this.scoreBoard.Count - 1)
            {
                if (this.Team2Races > this.Team1Races)
                {
                    this.bases[0] = this.bases[1] = this.bases[2] = false;
                    this.endOfGame = true;
                }
            }
        }
    }
}
