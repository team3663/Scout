using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DummyData
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.FileInfo MyFile = new System.IO.FileInfo(@"C:\Temp\FakeMatch.txt");
            System.IO.StreamWriter MyStream = MyFile.CreateText();
            Random myRandom = new Random();
            for(int match = 0; match < 3; match++)
            {
                string matchname = string.Format("Match # {0}", match);
                for(int team = 0; team < 64; team++)
                {
                    int TeamNum = 1000 + 3 * team;
                    string Apple = String.Format("{0},{1},", matchname, TeamNum);

                    int HighAuto = myRandom.Next(0, 2);
                    Apple += String.Format("{0},", HighAuto==1 ? "true" : "false");
                    int LowAuto = myRandom.Next(0, 2);
                    Apple += String.Format("{0},", LowAuto==1 ? "true" : "false");
                    int HotAuto = myRandom.Next(0, 2);
                    Apple += String.Format("{0},", HotAuto == 1 ? "true" : "false");
                    int BlockAuto = myRandom.Next(0, 2);
                    Apple += String.Format("{0},", BlockAuto == 1 ? "true" : "false");
                    int MoveAuto = myRandom.Next(0, 2);
                    Apple += String.Format("{0},", MoveAuto == 1 ? "true" : "false");
                    int GoalieBox = myRandom.Next(0, 2);
                    Apple += String.Format("{0},", GoalieBox == 1 ? "true" : "false");
                    int Defense = myRandom.Next(0, 2);
                    Apple += String.Format("{0},", Defense == 1 ? "true" : "false");
                    int Center = myRandom.Next(0, 2);
                    Apple += String.Format("{0},", Center == 1 ? "true" : "false");
                    int Offense = myRandom.Next(0, 2);
                    Apple += String.Format("{0},", Offense == 1 ? "true" : "false");
                    int OOP = myRandom.Next(0, 2);
                    Apple += String.Format("{0},", OOP == 1 ? "true" : "false");
                    int DriveSpeed = myRandom.Next(1, 11);
                    Apple += String.Format("{0},", DriveSpeed);
                    int Manuever = myRandom.Next(1, 11);
                    Apple += String.Format("{0},", Manuever);
                    int Competence = myRandom.Next(1, 11);
                    Apple += String.Format("{0},", Competence);
                    int Cycles = myRandom.Next(1, 20);
                    Apple += String.Format("{0},", Cycles);
                    int TrussSuccess = myRandom.Next(0, 20);
                    Apple += String.Format("{0},", TrussSuccess);
                    int TrussFail = myRandom.Next(0, 20);
                    Apple += String.Format("{0},", TrussFail);
                    int CatchSuccess = myRandom.Next(0, 20);
                    Apple += String.Format("{0},", CatchSuccess);
                    int CatchFail = myRandom.Next(0, 40);
                    Apple += String.Format("{0},", CatchFail);
                    int HighSuccess = myRandom.Next(0, 20);
                    Apple += String.Format("{0},", HighSuccess);
                    int HighFail = myRandom.Next(0, 40);
                    Apple += String.Format("{0},", HighFail);
                    int LowSuccess = myRandom.Next(0, 20);
                    Apple += String.Format("{0},", LowSuccess);
                    int LowFail = myRandom.Next(0, 25);
                    Apple += String.Format("{0},", LowFail);
                    int AssistReceive = myRandom.Next(0, 20);
                    Apple += String.Format("{0},", AssistReceive);
                    int AssistGive = myRandom.Next(0, 20);
                    Apple += String.Format("{0},", AssistGive);
                    int PassBlock = myRandom.Next(0, 50);
                    Apple += String.Format("{0},", PassBlock);
                    int ShotBlock = myRandom.Next(0, 40);
                    Apple += String.Format("{0},", ShotBlock);
                    int Fouls = myRandom.Next(0, 5);
                    Apple += String.Format("{0},", Fouls);

                    Apple += String.Format("This is comment # {0}", myRandom.Next(0, 10000));

                    MyStream.WriteLine(Apple);

                }

            }
            MyStream.Close();
        }

    }
}
