using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ParserWebApplication
{
    public class TeamData
    {
        private int teamNumber;
        private List<MatchData> matchDataList;
        private static List<TeamData> ourData = new List<TeamData>();


        public int ranking
        {
            get
            {
                int retval = 0;
                foreach(MatchData mData in matchDataList)
                {
                    retval += ((mData.AssistsGiven*5) + (mData.AssistsReceived*5) + (mData.HighGoalMade*3) + (mData.LowGoalMade*1));
                }
                return retval;
            }
        }
        public int TeamNumber
        {
            get { return teamNumber; }
        }

        public int MatchCount
        {
            get { return matchDataList.Count; }
        }
        public int AutoHighGoal
        {
            get
            {
                int retval = 0;
                foreach(MatchData mData in matchDataList)
                {
                    if (mData.HighAuto)
                    {
                        retval++;
                    }
                }
                return retval;
            }
        }

        public int AutoLowGoal
        {
            get
            {
                int retval = 0;
                foreach (MatchData mData in matchDataList)
                {
                    if (mData.LowAuto)
                    {
                        retval++;
                    }
                }
                return retval;
            }
        }

        public int AutoHotGoal
        {
            get
            {
                int retval = 0;
                foreach (MatchData mData in matchDataList)
                {
                    if (mData.HotAuto)
                    {
                        retval++;
                    }
                }
                return retval;
            }
        }

        public int AutoBlock
        {
            get
            {
                int retval = 0;
                foreach (MatchData mData in matchDataList)
                {
                    if (mData.Blocking)
                    {
                        retval++;
                    }
                }
                return retval;
            }
        }

        public int AutoMovement
        {
            get
            {
                int retval = 0;
                foreach (MatchData mData in matchDataList)
                {
                    if (mData.Movement)
                    {
                        retval++;
                    }
                }
                return retval;
            }
        }

        public int GoalieBoxPos
        {
            get
            {
                int retval = 0;
                foreach (MatchData mData in matchDataList)
                {
                    if (mData.GoalieBox)
                    {
                        retval++;
                    }
                }
                return retval;
            }
        }

        public int DefensePos
        {
            get
            {
                int retval = 0;
                foreach (MatchData mData in matchDataList)
                {
                    if (mData.Defense)
                    {
                        retval++;
                    }
                }
                return retval;
            }
        }

        public int CenterPos
        {
            get
            {
                int retval = 0;
                foreach (MatchData mData in matchDataList)
                {
                    if (mData.Center)
                    {
                        retval++;
                    }
                }
                return retval;
            }
        }

        public int OffensePos
        {
            get
            {
                int retval = 0;
                foreach (MatchData mData in matchDataList)
                {
                    if (mData.Offense)
                    {
                        retval++;
                    }
                }
                return retval;
            }
        }

        public int OutOfPlayPos
        {
            get
            {
                int retval = 0;
                foreach (MatchData mData in matchDataList)
                {
                    if (mData.OutOfPlay)
                    {
                        retval++;
                    }
                }
                return retval;
            }
        }

        public int SpeedAverage
        {
            get
            {
                int retval = 0;
                foreach (MatchData mData in matchDataList)
                {
                    retval += mData.Speed;
                }
                return retval / matchDataList.Count;

            }
        }

        public int ManueverabilityAverage
        {
            get
            {
                int retval = 0;
                foreach (MatchData mData in matchDataList)
                {
                    retval += mData.Manueverability;
                }
                return retval / matchDataList.Count;

            }
        }

        public int CompetenceAverage
        {
            get
            {
                int retval = 0;
                foreach (MatchData mData in matchDataList)
                {
                    retval += mData.DriverCompetence;
                }
                return retval / matchDataList.Count;

            }
        }

        public int Cycles
        {
            get
            {
                int retval = 0;
                foreach (MatchData mData in matchDataList)
                {
                    retval += mData.Cycles;
                }
                return retval;
            }
        }

        public int TrussesMade
        {
            get
            {
                int retval = 0;
                foreach (MatchData mData in matchDataList)
                {
                    retval += mData.TrussMade;
                }
                return retval;
            }
        }

        public int TrussesMissed
        {
            get
            {
                int retval = 0;
                foreach (MatchData mData in matchDataList)
                {
                    retval += mData.TrussMissed;
                }
                return retval;
            }
        }

        public int CatchesMade
        {
            get
            {
                int retval = 0;
                foreach (MatchData mData in matchDataList)
                {
                    retval += mData.CatchMade;
                }
                return retval;
            }
        }

        public int CatchesMissed
        {
            get
            {
                int retval = 0;
                foreach (MatchData mData in matchDataList)
                {
                    retval += mData.CatchMissed;
                }
                return retval;
            }
        }

        public int HighGoalsMade
        {
            get
            {
                int retval = 0;
                foreach (MatchData mData in matchDataList)
                {
                    retval += mData.HighGoalMade;
                }
                return retval;
            }
        }

        public int HighGoalsMissed
        {
            get
            {
                int retval = 0;
                foreach (MatchData mData in matchDataList)
                {
                    retval += mData.HighGoalMissed;
                }
                return retval;
            }
        }

        public int LowGoalsMade
        {
            get
            {
                int retval = 0;
                foreach (MatchData mData in matchDataList)
                {
                    retval += mData.LowGoalMade;
                }
                return retval;
            }
        }

        public int LowGoalsMissed
        {
            get
            {
                int retval = 0;
                foreach (MatchData mData in matchDataList)
                {
                    retval += mData.LowGoalMissed;
                }
                return retval;
            }
        }

        public int AssistsReceived
        {
            get
            {
                int retval = 0;
                foreach (MatchData mData in matchDataList)
                {
                    retval += mData.AssistsReceived;
                }
                return retval;
            }
        }

        public int AssistsGiven
        {
            get
            {
                int retval = 0;
                foreach (MatchData mData in matchDataList)
                {
                    retval += mData.AssistsGiven;
                }
                return retval;
            }
        }

        public int ShotsBlocked
        {
            get
            {
                int retval = 0;
                foreach (MatchData mData in matchDataList)
                {
                    retval += mData.ShotsBlocked;
                }
                return retval;
            }
        }

        public int PassesBlocked
        {
            get
            {
                int retval = 0;
                foreach (MatchData mData in matchDataList)
                {
                    retval += mData.PassesBlocked;
                }
                return retval;
            }
        }

        public int FoulsCommitted
        {
            get
            {
                int retval = 0;
                foreach (MatchData mData in matchDataList)
                {
                    retval += mData.Fouls;
                }
                return retval;
            }
        }




        public TeamData(int MyTeamNumber)
        {
            teamNumber = MyTeamNumber;
            matchDataList = new List<MatchData>();
            ourData.Add(this);
        }

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

        public void AddTeamData(MatchData teamMatchData)
        {
            matchDataList.Add(teamMatchData);
        }

        public static List<TeamData> GetTeamData()
        {
            return ourData;
        }
    }
}