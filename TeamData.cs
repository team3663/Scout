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
        private int matchCount;
        private int autoHighGoal;
        private int autoLowGoal;
        private int autoHotGoal;
        private int autoBlock;
        private int autoMovement;
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



        public int Ranking
        {
            get
            {
                int retval = 0;
                foreach(MatchData mData in matchDataList)
                {
                    retval += ((mData.AssistsGiven*5) + (mData.AssistsReceived*5) + (mData.HighGoalMade*3) + (mData.LowGoalMade*1) - (mData.Fouls*10) + (autoHotGoal*10));
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
            get { return matchCount; }
        }
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

        public int Cycles
        {
            get
            {
                return cycles;
            }
        }

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

        public int FoulsCommitted
        {
            get
            {
                return foulsCommitted;
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

        static IOrderedEnumerable<TeamData> DeriveSortExpression(string sortName, bool reverseSort)
        {
            switch(sortName)
            {
                case "TeamNumber":
                    {
                        if (reverseSort)
                        {
                            return from TeamData td in ourData
                                   orderby td.TeamNumber descending
                                   select td;
                        }
                        else
                        {
                            return from TeamData td in ourData
                                   orderby td.TeamNumber
                                   select td;
                        }
                    }
                case "MatchCount":
                    {
                       
                        if (reverseSort)
                        {
                            return from TeamData td in ourData
                                    orderby td.MatchCount descending
                                    select td;
                        }
                        else
                        {
                            return from TeamData td in ourData
                                    orderby td.MatchCount
                                    select td;
                        }
                    }
                case "AutoHighGoal":
                    {

                        if (reverseSort)
                        {
                            return from TeamData td in ourData
                                   orderby td.AutoHighGoal descending
                                   select td;
                        }
                        else
                        {
                            return from TeamData td in ourData
                                   orderby td.AutoHighGoal
                                   select td;
                        }
                    }
                case "AutoLowGoal":
                    {
                        if (reverseSort)
                        {
                            return from TeamData td in ourData
                                   orderby td.AutoLowGoal descending
                                   select td;
                        }
                        else
                        {
                            return from TeamData td in ourData
                                   orderby td.AutoLowGoal
                                   select td;
                        }
                    }
                case "AutoHotGoal":
                    {
                        if (reverseSort)
                        {
                            return from TeamData td in ourData
                                   orderby td.AutoHotGoal descending
                                   select td;
                        }
                        else
                        {
                            return from TeamData td in ourData
                                   orderby td.AutoHotGoal
                                   select td;
                        }
                    }
                case "AutoBlock":
                    {
                        if (reverseSort)
                        {
                            return from TeamData td in ourData
                                   orderby td.AutoBlock descending
                                   select td;
                        }
                        else
                        {
                            return from TeamData td in ourData
                                   orderby td.AutoBlock
                                   select td;
                        }
                    }
                case "AutoMovement":
                    {
                        if (reverseSort)
                        {
                            return from TeamData td in ourData
                                   orderby td.AutoMovement descending
                                   select td;
                        }
                        else
                        {
                            return from TeamData td in ourData
                                   orderby td.AutoMovement
                                   select td;
                        }
                    }
                case "GoalieBoxPos":
                    {
                        if (reverseSort)
                        {
                            return from TeamData td in ourData
                                   orderby td.GoalieBoxPos descending
                                   select td;
                        }
                        else
                        {
                            return from TeamData td in ourData
                                   orderby td.GoalieBoxPos
                                   select td;
                        }
                    }
                case "DefensePos":
                    {
                        if (reverseSort)
                        {
                            return from TeamData td in ourData
                                   orderby td.DefensePos descending
                                   select td;
                        }
                        else
                        {
                            return from TeamData td in ourData
                                   orderby td.DefensePos
                                   select td;
                        }
                    }
                case "CenterPos":
                    {
                        if (reverseSort)
                        {
                            return from TeamData td in ourData
                                   orderby td.CenterPos descending
                                   select td;
                        }
                        else
                        {
                            return from TeamData td in ourData
                                   orderby td.CenterPos
                                   select td;
                        }
                    }
                case "OffensePos":
                    {
                        if (reverseSort)
                        {
                            return from TeamData td in ourData
                                   orderby td.OffensePos descending
                                   select td;
                        }
                        else
                        {
                            return from TeamData td in ourData
                                   orderby td.OffensePos
                                   select td;
                        }
                    }
                case "OutOfPlayPos":
                    {
                        if (reverseSort)
                        {
                            return from TeamData td in ourData
                                   orderby td.OutOfPlayPos descending
                                   select td;
                        }
                        else
                        {
                            return from TeamData td in ourData
                                   orderby td.OutOfPlayPos
                                   select td;
                        }
                    }
                case "SpeedAverage":
                    {
                        if (reverseSort)
                        {
                            return from TeamData td in ourData
                                   orderby td.SpeedAverage descending
                                   select td;
                        }
                        else
                        {
                            return from TeamData td in ourData
                                   orderby td.SpeedAverage
                                   select td;
                        }
                    }
                case "ManueverabilityAverage":
                    {
                        if (reverseSort)
                        {
                            return from TeamData td in ourData
                                   orderby td.ManueverabilityAverage descending
                                   select td;
                        }
                        else
                        {
                            return from TeamData td in ourData
                                   orderby td.ManueverabilityAverage
                                   select td;
                        }
                    }
                case "CompetenceAverage":
                    {
                        if (reverseSort)
                        {
                            return from TeamData td in ourData
                                   orderby td.CompetenceAverage descending
                                   select td;
                        }
                        else
                        {
                            return from TeamData td in ourData
                                   orderby td.CompetenceAverage
                                   select td;
                        }
                    }
                case "Cycles":
                    {
                        if (reverseSort)
                        {
                            return from TeamData td in ourData
                                   orderby td.Cycles descending
                                   select td;
                        }
                        else
                        {
                            return from TeamData td in ourData
                                   orderby td.Cycles
                                   select td;
                        }
                    }
                case "TrussesMade":
                    {
                        if (reverseSort)
                        {
                            return from TeamData td in ourData
                                   orderby td.TrussesMade descending
                                   select td;
                        }
                        else
                        {
                            return from TeamData td in ourData
                                   orderby td.TrussesMade
                                   select td;
                        }
                    }
                case "TrussesMissed":
                    {
                        if (reverseSort)
                        {
                            return from TeamData td in ourData
                                   orderby td.TrussesMissed descending
                                   select td;
                        }
                        else
                        {
                            return from TeamData td in ourData
                                   orderby td.TrussesMissed
                                   select td;
                        }
                    }
                case "CatchesMade":
                    {
                        if (reverseSort)
                        {
                            return from TeamData td in ourData
                                   orderby td.CatchesMade descending
                                   select td;
                        }
                        else
                        {
                            return from TeamData td in ourData
                                   orderby td.CatchesMade
                                   select td;
                        }
                    }
                case "CatchesMissed":
                    {
                        if (reverseSort)
                        {
                            return from TeamData td in ourData
                                   orderby td.CatchesMissed descending
                                   select td;
                        }
                        else
                        {
                            return from TeamData td in ourData
                                   orderby td.CatchesMissed
                                   select td;
                        }
                    }
                case "HighGoalsMade":
                    {
                        if (reverseSort)
                        {
                            return from TeamData td in ourData
                                   orderby td.HighGoalsMade descending
                                   select td;
                        }
                        else
                        {
                            return from TeamData td in ourData
                                   orderby td.HighGoalsMade
                                   select td;
                        }
                    }
                case "HighGoalsMissed":
                    {
                        if (reverseSort)
                        {
                            return from TeamData td in ourData
                                   orderby td.HighGoalsMissed descending
                                   select td;
                        }
                        else
                        {
                            return from TeamData td in ourData
                                   orderby td.HighGoalsMissed
                                   select td;
                        }
                    }
                case "LowGoalsMade":
                    {
                        if (reverseSort)
                        {
                            return from TeamData td in ourData
                                   orderby td.LowGoalsMade descending
                                   select td;
                        }
                        else
                        {
                            return from TeamData td in ourData
                                   orderby td.LowGoalsMade
                                   select td;
                        }
                    }
                case "LowGoalsMissed":
                    {
                        if (reverseSort)
                        {
                            return from TeamData td in ourData
                                   orderby td.LowGoalsMissed descending
                                   select td;
                        }
                        else
                        {
                            return from TeamData td in ourData
                                   orderby td.LowGoalsMissed
                                   select td;
                        }
                    }
                case "AssistsReceived":
                    {
                        if (reverseSort)
                        {
                            return from TeamData td in ourData
                                   orderby td.AssistsReceived descending
                                   select td;
                        }
                        else
                        {
                            return from TeamData td in ourData
                                   orderby td.AssistsReceived
                                   select td;
                        }
                    }
                case "AssistsGiven":
                    {
                        if (reverseSort)
                        {
                            return from TeamData td in ourData
                                   orderby td.AssistsGiven descending
                                   select td;
                        }
                        else
                        {
                            return from TeamData td in ourData
                                   orderby td.AssistsGiven
                                   select td;
                        }
                    }
                case "ShotsBlocked":
                    {
                        if (reverseSort)
                        {
                            return from TeamData td in ourData
                                   orderby td.ShotsBlocked descending
                                   select td;
                        }
                        else
                        {
                            return from TeamData td in ourData
                                   orderby td.ShotsBlocked
                                   select td;
                        }
                    }
                case "PassesBlocked":
                    {
                        if (reverseSort)
                        {
                            return from TeamData td in ourData
                                   orderby td.PassesBlocked descending
                                   select td;
                        }
                        else
                        {
                            return from TeamData td in ourData
                                   orderby td.PassesBlocked
                                   select td;
                        }
                    }
                case "FoulsCommitted":
                    {
                        if (reverseSort)
                        {
                            return from TeamData td in ourData
                                   orderby td.FoulsCommitted descending
                                   select td;
                        }
                        else
                        {
                            return from TeamData td in ourData
                                   orderby td.FoulsCommitted
                                   select td;
                        }
                    }

                default:
                    {
                        if (reverseSort)
                        {
                            return from TeamData td in ourData
                                   orderby td.Ranking descending
                                   select td;
                        }
                        else
                        {
                            return from TeamData td in ourData
                                   orderby td.Ranking
                                   select td;
                        }
                    }
            }

        }

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

            var pleaseSort = DeriveSortExpression(sortName, reverseSort);

            List<TeamData> retData = new List<TeamData>();
            foreach(TeamData td in pleaseSort)
            {
                retData.Add(td);
            }
            return retData;

        }
    }
}