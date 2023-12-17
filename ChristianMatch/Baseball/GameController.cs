using System;
using System.Collections.Generic;
using System.Text;

namespace ChristianMatch.Baseball
{
    enum HitType
    {
        Hit, Double, Triple, Homerun, Out
    }

    class BoardScore
    {
        private int team1, team2;

        public int Team2
        {
            get { return team2; }
            set { team2 = value; }
        }

        public int Team1
        {
            get { return team1; }
            set { team1 = value; }
        }

        public BoardScore(int scoreTeam1, int scoreTeam2)
        {
            this.team1 = scoreTeam1;
            this.team2 = scoreTeam2;
        }
    }

    class GameController
    {
        /// <summary>
        /// Indicate the index of the batter
        /// </summary>
        private int batter;

        /// <summary>
        /// Positions into bases
        /// </summary>
        private bool[] bases;

        /// <summary>
        /// Current inning indicator
        /// </summary>
        private int currentInning;

        /// <summary>
        /// Count of outs of the current inning
        /// </summary>
        private int outs;

        /// <summary>
        /// Score of the game
        /// </summary>
        private List<BoardScore> scoreBoard;

        /// <summary>
        /// Name of the firts team
        /// </summary>
        private string team1;

        /// <summary>
        /// Name of the second team
        /// </summary>
        private string team2;

        /// <summary>
        /// Indicate if play extrainning
        /// </summary>
        private bool extraInning;

        /// <summary>
        /// Indicate if it is the end of game
        /// </summary>
        private bool endOfGame;

        public GameController()
        {
            this.batter = -1;
            this.bases = new bool[3];
            this.currentInning = -1;
            this.scoreBoard = null;
        }

        public void Init(string team1, string team2, int innningCount, bool allowExtrainning)
        {
            this.team1 = team1;
            this.team2 = team2;

            this.extraInning = allowExtrainning;

            this.scoreBoard = new List<BoardScore>();
            for(int i = 0; i < innningCount; i++)
                this.scoreBoard.Add(new BoardScore(0,0));

            this.currentInning = 0;
            this.batter = 0;
            this.endOfGame = false;
        }

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

        public string BatterTeam
        {
            get
            {
                if (this.batter == 0)
                    return this.team1;
                return this.team2;
            }
        }

        public string CoverTeam
        {
            get
            {
                if (this.batter == 0)
                    return this.team2;
                return this.team1;
            }
        }

        public int Outs
        {
            get
            {
                return this.outs;
            }
        }

        public bool BaseBusy(int theBase)
        {
            return this.bases[theBase - 1];
        }

        public BoardScore[] ScoreBoard
        {
            get
            {
                return this.scoreBoard.ToArray();
            }
        }

        public int Innings
        {
            get
            {
                return this.scoreBoard.Count;
            }
        }

        public bool EndOfGame
        {
            get
            {
                return this.endOfGame;
            }
        }

        public int CurrentInning
        {
            get
            {
                return this.currentInning + 1;
            }
        }

        /// <summary>
        /// Indicate the controlle a hit. Return true is a race happend
        /// </summary>
        /// <param name="hit">Type of hit</param>
        /// <returns>Indicate if a race happend</returns>
        public bool HitAction(HitType hit)
        {
            bool flag = false;

            switch (hit)
            {
                case HitType.Out:
                    if (this.outs < 2)
                        this.outs++;
                    else
                    {
                        // Clean outs
                        this.outs = 0;
                        // Clean bases
                        this.bases[0] = this.bases[1] = this.bases[2] = false;
                        // New inning
                        if(this.batter == 1)
                            this.currentInning++;
                        // Change the batter
                        this.batter = (this.batter == 0) ? 1 : 0;
                        // Check it is the end of the game
                        this.checkEndOfGame();
                    }
                    break;

                case HitType.Hit:
                    // The man of the third base get in
                    if (this.bases[2])
                    {
                        if (this.batter == 0)
                            this.scoreBoard[this.currentInning].Team1 += 1;
                        else
                            this.scoreBoard[this.currentInning].Team2 += 1;

                        flag = true;
                    }

                    // Man in other bases get in
                    this.bases[2] = this.bases[1];
                    this.bases[1] = this.bases[0];

                    // Batter get first base
                    this.bases[0] = true;

                    break;

                case HitType.Double:
                    // The man of the third base get in
                    if (this.bases[2])
                    {
                        if (this.batter == 0)
                            this.scoreBoard[this.currentInning].Team1 += 1;
                        else
                            this.scoreBoard[this.currentInning].Team2 += 1;

                        flag = true;
                    }
                    // The man in first base goes to third
                    this.bases[2] = this.bases[0];

                    // The man in second base get in
                    if (this.bases[1])
                    {
                        if (this.batter == 0)
                            this.scoreBoard[this.currentInning].Team1 += 1;
                        else
                            this.scoreBoard[this.currentInning].Team2 += 1;

                        flag = true;
                    }
                    // The batter goes to second base
                    this.bases[1] = true;

                    // First base is allwais clean
                    this.bases[0] = false;
                    
                    break;

                case HitType.Triple:
                    // The man of the third base get in
                    if (this.bases[2])
                    {
                        if (this.batter == 0)
                            this.scoreBoard[this.currentInning].Team1 += 1;
                        else
                            this.scoreBoard[this.currentInning].Team2 += 1;

                        flag = true;
                    }
                    this.bases[2] = true;

                    // The man in second base get in
                    if (this.bases[1])
                    {
                        if (this.batter == 0)
                            this.scoreBoard[this.currentInning].Team1 += 1;
                        else
                            this.scoreBoard[this.currentInning].Team2 += 1;

                        flag = true;
                    }
                    this.bases[1] = false;

                    // The man in first base get in
                    if (this.bases[0])
                    {
                        if (this.batter == 0)
                            this.scoreBoard[this.currentInning].Team1 += 1;
                        else
                            this.scoreBoard[this.currentInning].Team2 += 1;

                        flag = true;
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

                    flag = true;

                    break;
            }

            this.checkEndOfGame();

            return flag;
        }

        private void checkEndOfGame()
        {
            if (this.currentInning == this.scoreBoard.Count)
            {
                this.endOfGame = true;
                return;
            }

            // The second team do not need to continue hitting
            if (this.batter == 1 && this.currentInning == this.scoreBoard.Count - 1)
            {
                if (this.Team2Races > this.Team1Races)
                {
                    this.endOfGame = true;
                    this.bases[0] = this.bases[1] = this.bases[2] = false;
                    this.endOfGame = true;
                }
            }
        }
    }
}
