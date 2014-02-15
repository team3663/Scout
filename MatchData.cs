using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;

namespace ParserWebApplication
{
    /// <summary>
    /// This is the class MatchData. This is the major organizer for TeamData.cs and Default.aspx.
    /// TeamData.cs draws directly from the information provided in this class. Each member of this class
    /// contains the data from a single instance of the scouting application. They take lines of the text
    /// document that houses the data, organizes the data, and allows TeamData.cs to make a nice graph
    /// out of it.
    /// </summary>
    public class MatchData
    {
        private string matchName;
        // private int teamNumber;
        private bool highAuto;
        private bool lowAuto;
        private bool hotAuto;
        private bool blocking;
        private bool movement;
        private bool shotMade;
        private bool goalieBox;
        private bool defense;
        private bool center;
        private bool offense;
        private bool outOfPlay;
        private int speed;
        private int manueverability;
        private int driverCompetence;
        private int cycles;
        private int trussMade;
        private int trussMissed;
        private int catchMade;
        private int catchMissed;
        private int highGoalMade;
        private int highGoalMissed;
        private int lowGoalMade;
        private int lowGoalMissed;
        private int assistsReceived;
        private int assistsGiven;
        private int shotsBlocked;
        private int passesBlocked;
        private int fouls;
        private string commentBox;
        private static List<MatchData> matchDataList;

        /// <summary>
        /// This takes the data from a single line of the match data file and parses it into the 30 data
        /// pieces that will be used to construct the data graph.
        /// </summary>
        /// <param name="data">The strings that hold each piece of data for the round.</param>
        private MatchData(string[] data)
        {
            matchName = data[0];
           // teamNumber = int.Parse(data[1]);
            highAuto = bool.Parse(data[2]);
            lowAuto = bool.Parse(data[3]);
            hotAuto = bool.Parse(data[4]);
            blocking = bool.Parse(data[6]);
            movement = bool.Parse(data[5]);
            shotMade = bool.Parse(data[7]);
            goalieBox = bool.Parse(data[8]);
            defense = bool.Parse(data[9]);
            center = bool.Parse(data[10]);
            offense = bool.Parse(data[11]);
            outOfPlay = bool.Parse(data[12]);
            speed = int.Parse(data[13]);
            manueverability = int.Parse(data[14]);
            driverCompetence = int.Parse(data[15]);
            cycles = int.Parse(data[16]);
            trussMade = int.Parse(data[17]);
            trussMissed = int.Parse(data[18]);
            catchMade = int.Parse(data[19]);
            catchMissed = int.Parse(data[20]);
            highGoalMade = int.Parse(data[21]);
            highGoalMissed = int.Parse(data[22]);
            lowGoalMade = int.Parse(data[23]);
            lowGoalMissed = int.Parse(data[24]);
            assistsReceived = int.Parse(data[25]);
            assistsGiven = int.Parse(data[26]);
            shotsBlocked = int.Parse(data[27]);
            passesBlocked = int.Parse(data[28]);
            fouls = int.Parse(data[29]);
            commentBox = data[30];
        }

        /// <summary>
        /// Here be the public accessor functions. Abandon all hope of editing them, they are read only.
        /// </summary>
        public string MatchName
        {
            get { return matchName; }
        }

#if false
            public int TeamNumber
        {
            get { return teamNumber; }
        }
#endif

        public bool HighAuto
        {
            get { return highAuto; }
        }

        public bool LowAuto
        {
            get { return lowAuto; }
        }

        public bool HotAuto
        {
            get { return hotAuto; }
        }

        public bool Blocking
        {
            get { return blocking; }
        }
        
        public bool Movement
        {
            get { return movement; }
        }

        public bool ShotMade
        {
            get { return shotMade; }
        }

        public bool GoalieBox
        {
            get { return goalieBox; }
        }

        public bool Defense
        {
            get { return defense; }
        }

        public bool Center
        {
            get { return center; }
        }

        public bool Offense
        {
            get { return offense; }
        }

        public bool OutOfPlay
        {
            get { return outOfPlay; }
        }

        public int Speed
        {
            get { return speed; }
        }

        public int Manueverability
        {
            get { return manueverability; }
        }

        public int DriverCompetence
        {
            get { return driverCompetence; }
        }

        public int Cycles
        {
            get { return cycles; }
        }

        public int TrussMade
        {
            get { return trussMade; }
        }

        public int TrussMissed
        {
            get { return trussMissed; }
        }

        public int CatchMade
        {
            get { return catchMade; }
        }

        public int CatchMissed
        {
            get { return catchMissed; }
        }

        public int HighGoalMade
        {
            get { return highGoalMade; }
        }
        public int HighGoalMissed
        {
            get { return highGoalMissed; }
        }

        public int LowGoalMade
        {
            get { return lowGoalMade; }
        }

        public int LowGoalMissed
        {
            get { return lowGoalMissed; }
        }
        public int AssistsReceived
        {
            get { return assistsReceived; }
        }

        public int AssistsGiven
        {
            get { return assistsGiven; }
        }

        public int ShotsBlocked
        {
            get { return shotsBlocked; }
        }

        public int PassesBlocked
        {
            get { return passesBlocked; }
        }
        public int Fouls
        {
            get { return fouls; }
        }

        public string CommentBox
        {
            get { return commentBox; }
        }

        public int Ranking
        {
            get { return 0; } // To do later (week of 2/2)
        }

        /// <summary>
        /// This is our parser function. It reads the whole file in. Then it splits the file into lines 
        /// and parses each line. 
        /// </summary>
        /// <param name="filename"></param>
        public static int ParseDateFile(string filename, int startLine)
        {
            string[] readText = File.ReadAllLines(filename);
            for (int linenum = startLine; linenum < readText.Length; linenum++)
            {
                string line = readText[linenum];
                string[] subString = line.Split(new char[] { ',' });
                MatchData MyData = new MatchData(subString);
                int teamNumber = int.Parse(subString[1]);
                TeamData newTeam = TeamData.FindTeamData(teamNumber);
                if (newTeam == null)
                {
                    newTeam = new TeamData(teamNumber);
                }
                newTeam.AddTeamData(MyData);
            }
            return readText.Length;

        }

        /// <summary>
        /// This gets the match data and returns it.
        /// </summary>
        /// <returns></returns>
        public static List<MatchData> GetMatchData()
        {
            return matchDataList;
        }


 
    }
}