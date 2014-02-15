using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParserWebApplication
{
    /// <summary>
    /// This is the class TeamData. It is a very important class, and is one of the most vital classes to 
    /// our robotics team's scouting report. This class takes the parsed information in MatchData.cs and 
    /// divides it into meaningful categories. The autonomous categories, driving categories, truss
    /// accuracy, high goal accuracy, low goal accuracy, and defense categories are organized to give us 
    /// a good idea on who the best teams are. The ranking is the overall score of every one of these
    /// categories, added together and weighted. All of these categories, as well as the important team
    /// information, are placed onto a graph in Default.aspx. The things in the graph can be arranged
    /// from best to worst or vice-versa very easily.
    /// </summary>
    public class TeamData
    {
        private int teamNumber;
        private List<MatchData> matchDataList;
        private static List<TeamData> ourData = new List<TeamData>();
        private int matchCount;
        private int autoHighGoal;
        private int autoLowGoal;
        private int autoHotGoal;
        private int autoBlock;
        private int autoMovement;
        private int autoShotMade;
        private int goalieBoxPos;
        private int defensePos;
        private int centerPos;
        private int offensePos;
        private int outOfPlayPos;
        private int speedAverage;
        private int manueverabilityAverage;
        private int competenceAverage;
        private int cycles;
        private int trussesMade;
        private int trussesMissed;
        private int catchesMade;
        private int catchesMissed;
        private int highGoalsMade;
        private int highGoalsMissed;
        private int lowGoalsMade;
        private int lowGoalsMissed;
        private int assistsReceived;
        private int assistsGiven;
        private int shotsBlocked;
        private int passesBlocked;
        private int foulsCommitted;


        /// <summary>
        /// The auto score constructor.
        /// </summary>
        public int AutonomousScore
        {
            get
            {
                return ((((autoHighGoal * 5) + (autoLowGoal * 5)) * (autoShotMade)) + (autoMovement * 5) + (autoBlock * 8) + (autoHotGoal * 5));
            }
        }

        /// <summary>
        /// The driving score constructor.
        /// </summary>
        public int DrivingScore
        {
            get
            {
                return (int)(((speedAverage / matchCount) * 2) + ((manueverabilityAverage / matchCount) * 3) + ((competenceAverage / matchCount) * 1.5));
            }
        }

        /// <summary>
        /// All the rest of the constructors work the same way and are weighted in such a way to make a fair
        /// ranking scale.
        /// </summary>
        public int TrussPercent
        {
            get
            {
                if (trussesMade + trussesMissed == 0)
                {
                    return 0;
                }
                return (100 * trussesMade / (trussesMade + trussesMissed));
            }
        }

        public int HighGoalPercent
        {
            get
            {
                if (highGoalsMade + highGoalsMissed == 0)
                {
                    return 0;
                }
                return (100 * highGoalsMade / (highGoalsMade + highGoalsMissed));
            }
            
        }

        public int LowGoalPercent
        {
            get
            {
                if (lowGoalsMade + lowGoalsMissed == 0)
                {
                    return 0;
                }
                return (100 * lowGoalsMade / (lowGoalsMade + lowGoalsMissed));
            }
        }

        public int DefenseScore
        {
            get
            {
                return ((passesBlocked) + (shotsBlocked * 2) - (foulsCommitted * 5));
            }
        }

        public int Ranking
        {
            get
            {
                return ((AutonomousScore * 2) + DefenseScore + (DrivingScore * 3)
                    + (int)(HighGoalPercent * (0.25 * highGoalsMade)) + (int)(LowGoalPercent * (0.125 * lowGoalsMade))
                    + (TrussPercent / 2)
                    + (assistsGiven * 5) + (assistsReceived * 5) + (Cycles * 4) - (FoulsCommitted * 10));
            }
        }
        public int TeamNumber
        {
            get { return teamNumber; }
        }

        public int MatchCount
        {
            get { return matchCount; }
        }
#if false
        public int AutoHighGoal
        {
            get
            {
                return autoHighGoal;
            }
        }

        public int AutoLowGoal
        {
            get
            {
                return autoLowGoal;
            }
        }

        public int AutoHotGoal
        {
            get
            {
                return autoHotGoal;
            }
        }

        public int AutoBlock
        {
            get
            {
                return autoBlock;
            }
        }

        public int AutoMovement
        {
            get
            {
                return autoMovement;
            }
        }

        public int AutoShotMade
        {
            get
            {
                return autoShotMade;
            }
        }

        public int GoalieBoxPos
        {
            get
            {
                return goalieBoxPos;
            }
        }

        public int DefensePos
        {
            get
            {
                return defensePos;
            }
        }

        public int CenterPos
        {
            get
            {
                return centerPos;
            }
        }

        public int OffensePos
        {
            get
            {
                return offensePos;
            }
        }

        public int OutOfPlayPos
        {
            get
            {
                return outOfPlayPos;
            }
        }

        public int SpeedAverage
        {
            get
            {
                return speedAverage / matchCount;

            }
        }

        public int ManueverabilityAverage
        {
            get
            {
                return manueverabilityAverage / matchCount;

            }
        }

        public int CompetenceAverage
        {
            get
            {
               return competenceAverage / matchCount;

            }
        }
#endif
        public int Cycles
        {
            get
            {
                return cycles;
            }
        }

#if false
        public int TrussesMade
        {
            get
            {
                return trussesMade;
            }
        }

        public int TrussesMissed
        {
            get
            {
                return trussesMissed;
            }
        }

        public int CatchesMade
        {
            get
            {
                return catchesMade;
            }
        }

        public int CatchesMissed
        {
            get
            {
                return catchesMissed;
            }
        }

        public int HighGoalsMade
        {
            get
            {
                return highGoalsMade;
            }
        }

        public int HighGoalsMissed
        {
            get
            {
                return highGoalsMissed;
            }
        }

        public int LowGoalsMade
        {
            get
            {
                return lowGoalsMade;
            }
        }

        public int LowGoalsMissed
        {
            get
            {
                return lowGoalsMissed;
            }
        }
#endif
        public int AssistsReceived
        {
            get
            {
                return assistsReceived;
            }
        }

        public int AssistsGiven
        {
            get
            {
                return assistsGiven;
            }
        }
#if false
        public int ShotsBlocked
        {
            get
            {
                return shotsBlocked;
            }
        }

        public int PassesBlocked
        {
            get
            {
                return passesBlocked;
            }
        }
#endif
        public int FoulsCommitted
        {
            get
            {
                return foulsCommitted;
            }
        }




        /// <summary>
        /// This checks for the team number and sets the team number to the number already acquired.
        /// </summary>
        /// <param name="MyTeamNumber"></param>
        public TeamData(int MyTeamNumber)
        {
            teamNumber = MyTeamNumber;
            matchDataList = new List<MatchData>();
            ourData.Add(this);
        }

        /// <summary>
        /// Checks to see if the team number = MyTeamNumber.
        /// </summary>
        /// <param name="MyTeamNumber"></param>
        /// <returns></returns>
        public static TeamData FindTeamData(int MyTeamNumber)
        {
            foreach(TeamData thisTeam in ourData)
            {
                if (thisTeam.teamNumber == MyTeamNumber)
                {
                    return thisTeam;
                }
            }

            return null;
        }

        /// <summary>
        /// Determines how all the things are calculated for our graph.
        /// </summary>
        /// <param name="teamMatchData"></param>
        public void AddTeamData(MatchData teamMatchData)
        {
            matchCount++;
            if (teamMatchData.HighAuto)
            {
                autoHighGoal++;
            }
            if (teamMatchData.LowAuto)
            {
                autoLowGoal++;
            }
            if (teamMatchData.HotAuto)
            {
                autoHotGoal++;
            }
            if (teamMatchData.Blocking)
            {
                autoBlock++;
            }
            if (teamMatchData.Movement)
            {
                autoMovement++;
            }
            if (teamMatchData.ShotMade)
            {
                autoShotMade++;
            }
            if (teamMatchData.GoalieBox)
            {
                goalieBoxPos++;
            }
            if (teamMatchData.Defense)
            {
                defensePos++;
            }
            if (teamMatchData.Center)
            {
                centerPos++;
            }
            if (teamMatchData.Offense)
            {
                offensePos++;
            }
            if (teamMatchData.OutOfPlay)
            {
                outOfPlayPos++;
            }
            speedAverage += teamMatchData.Speed;
            manueverabilityAverage += teamMatchData.Manueverability;
            competenceAverage += teamMatchData.DriverCompetence;
            cycles += teamMatchData.Cycles;
            trussesMade += teamMatchData.TrussMade;
            trussesMissed += teamMatchData.TrussMissed;
            catchesMade += teamMatchData.CatchMade;
            catchesMissed += teamMatchData.CatchMissed;
            highGoalsMade += teamMatchData.HighGoalMade;
            highGoalsMissed += teamMatchData.HighGoalMissed;
            lowGoalsMade += teamMatchData.LowGoalMade;
            lowGoalsMissed += teamMatchData.LowGoalMissed;
            assistsReceived += teamMatchData.AssistsReceived;
            assistsGiven += teamMatchData.AssistsGiven;
            shotsBlocked += teamMatchData.ShotsBlocked;
            passesBlocked += teamMatchData.PassesBlocked;
            foulsCommitted += teamMatchData.Fouls;


            matchDataList.Add(teamMatchData);
        }
        
        /// <summary>
        /// This prepares the list to sort from best to worst and vice-versa. It takes the name of the column
        /// for the graph.
        /// </summary>
        /// <param name="sortName">The name of the column.</param>
        /// <returns></returns>
        int SortValue(string sortName)
        {
            switch(sortName)
            {
                case "TeamNumber":
                    {
                        return teamNumber;
                    }
                case "MatchCount":
                    {
                       return matchCount;
                    }
#if false  
                    case "AutoHighGoal":
                    {
                        return autoHotGoal;
                    }
                case "AutoLowGoal":
                    {
                        return autoLowGoal;
                    }
                case "AutoHotGoal":
                    {
                        return autoHotGoal;
                    }
                case "AutoBlock":
                    {
                        return autoBlock;
                    }
                case "AutoMovement":
                    {
                        return autoMovement;
                    }
                case "AutoShotMade":
                    {
                        return autoShotMade;
                    }
                case "GoalieBoxPos":
                    {
                        return goalieBoxPos;
                    }
                case "DefensePos":
                    {
                       return defensePos;
                    }
                case "CenterPos":
                    {
                       return centerPos;
                    }
                case "OffensePos":
                    {
                        return offensePos;
                    }
                case "OutOfPlayPos":
                    {
                        return outOfPlayPos;
                    }
                case "SpeedAverage":
                    {
                        return SpeedAverage;
                    }
                case "ManueverabilityAverage":
                    {
                        return ManueverabilityAverage;
                    }
                case "CompetenceAverage":
                    {
                        return CompetenceAverage;
                    }
#endif
                case "Cycles":
                    {
                        return cycles;
                    }
#if false
                case "TrussesMade":
                    {
                        return trussesMade;
                    }
                case "TrussesMissed":
                    {
                        return trussesMissed;
                    }
                case "CatchesMade":
                    {
                        return catchesMade;
                    }
                case "CatchesMissed":
                    {
                        return catchesMissed;
                    }
                case "HighGoalsMade":
                    {
                        return highGoalsMade;
                    }
                case "HighGoalsMissed":
                    {
                        return highGoalsMissed;
                    }
                case "LowGoalsMade":
                    {
                       return lowGoalsMade;
                    }
                case "LowGoalsMissed":
                    {
                        return lowGoalsMissed;
                    }
#endif
                case "AssistsReceived":
                    {
                        return assistsReceived;
                    }
                case "AssistsGiven":
                    {
                        return assistsGiven;
                    }
#if false
                case "ShotsBlocked":
                    {
                        return shotsBlocked;
                    }
                case "PassesBlocked":
                    {
                        return passesBlocked;
                    }
#endif
                case "FoulsCommitted":
                    {
                       return foulsCommitted;
                    }
                case "AutonomousScore":
                    {
                        return AutonomousScore;
                    }
                case "DrivingScore":
                    {
                        return DrivingScore;
                    }
                case "TrussPercent":
                    {
                        return TrussPercent;
                    }
                case "HighGoalPercent":
                    {
                        return HighGoalPercent;
                    }
                case "LowGoalPercent":
                    {
                        return LowGoalPercent;
                    }
                case "DefenseScore":
                    {
                        return DefenseScore;
                    }

                default:
                    {
                        return Ranking;
                    }

            }

        }

        /// <summary>
        /// This function allows us to sort all the data and to sort in ascending or descending order in the
        /// columns.
        /// </summary>
        /// <param name="sortExpression"></param>
        /// <returns></returns>
        public static List<TeamData> GetTeamData(string sortExpression)
        {
            string sortName;
            bool reverseSort = false;
            if (sortExpression == "")
            {
                sortName = "ranking";
            }
            else
            {
                string[] substrings = sortExpression.Split(new char[] { ' ' });
                sortName = substrings[0];
                if (substrings.Length > 1)
                {
                    reverseSort = true;
                }
            }
            


            var pleaseSort = (reverseSort) 
                            ? from TeamData td in ourData
                              orderby td.SortValue(sortName) descending
                              select td
                              : from TeamData td in ourData
                                orderby td.SortValue(sortName)
                                select td;


            List<TeamData> retData = new List<TeamData>();
            foreach(TeamData td in pleaseSort)
            {
                retData.Add(td);
            }
            return retData;

        }

        public static List<MatchData> GetMatchData(int teamnum)
        {
            foreach (TeamData td in ourData)
            {
                if (td.teamNumber == teamnum)
                {
                    return td.matchDataList;
                }
            }
            return new List<MatchData>();
        }
    }
}