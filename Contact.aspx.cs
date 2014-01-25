using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }



        protected void Button1_Click(object sender, EventArgs e)
        {
            System.IO.FileInfo MyFile = new System.IO.FileInfo(@"C:\Temp\Data.txt");
            System.IO.StreamWriter MyStream = MyFile.CreateText();
            String Banana = String.Format("Match Number: {0}", TextBox1.Text);
            MyStream.WriteLine(Banana);
            Banana = String.Format("Team Number: {0}", TextBox2.Text);
            MyStream.WriteLine(Banana);
            Banana = String.Format("High Goal: {0}", CheckBoxList1.Items[0].Selected);
            MyStream.WriteLine(Banana);
            Banana = String.Format("Low Goal: {0}", CheckBoxList1.Items[1].Selected);
            MyStream.WriteLine(Banana);
            Banana = String.Format("Hot Goal: {0}", CheckBoxList1.Items[2].Selected);
            MyStream.WriteLine(Banana);
            Banana = String.Format("Blocks: {0}", CheckBoxList1.Items[3].Selected);
            MyStream.WriteLine(Banana);
            Banana = String.Format("Movement: {0}", CheckBoxList1.Items[4].Selected);
            MyStream.WriteLine(Banana);
            Banana = String.Format("Goalie Box: {0}", PositionList.Items[0].Selected);
            MyStream.WriteLine(Banana);
            Banana = String.Format("Defense: {0}", PositionList.Items[1].Selected);
            MyStream.WriteLine(Banana);
            Banana = String.Format("Center: {0}", PositionList.Items[2].Selected);
            MyStream.WriteLine(Banana);
            Banana = String.Format("Offense: {0}", PositionList.Items[3].Selected);
            MyStream.WriteLine(Banana);
            Banana = String.Format("Out of play: {0}", PositionList.Items[4].Selected);
            MyStream.WriteLine(Banana);
            Banana = String.Format("Speed: {0}", ServerControl13.CurrentValue);
            MyStream.WriteLine(Banana);
            Banana = String.Format("Manueverability: {0}", ServerControl12.CurrentValue);
            MyStream.WriteLine(Banana);
            Banana = String.Format("Driver Competence: {0}", ServerControl11.CurrentValue);
            MyStream.WriteLine(Banana);
            Banana = String.Format("Cycles: {0}", ServerControl14.CurrentValue);
            MyStream.WriteLine(Banana);
            Banana = String.Format("Truss Made: {0}", ServerControl15.CurrentValue);
            MyStream.WriteLine(Banana);
            Banana = String.Format("Truss Missed: {0}", ServerControl16.CurrentValue);
            MyStream.WriteLine(Banana);
            Banana = String.Format("Catch Made: {0}", ServerControl17.CurrentValue);
            MyStream.WriteLine(Banana);
            Banana = String.Format("Catch Missed: {0}", ServerControl18.CurrentValue);
            MyStream.WriteLine(Banana);
            Banana = String.Format("High Goal Made: {0}", ServerControl19.CurrentValue);
            MyStream.WriteLine(Banana);
            Banana = String.Format("High Goal Missed: {0}", ServerControl110.CurrentValue);
            MyStream.WriteLine(Banana);
            Banana = String.Format("Low Goal Made: {0}", ServerControl111.CurrentValue);
            MyStream.WriteLine(Banana);
            Banana = String.Format("Low Goal Missed: {0}", ServerControl112.CurrentValue);
            MyStream.WriteLine(Banana);
            Banana = String.Format("Assists Received: {0}", ServerControl113.CurrentValue);
            MyStream.WriteLine(Banana);
            Banana = String.Format("Assists Given: {0}", ServerControl114.CurrentValue);
            MyStream.WriteLine(Banana);
            Banana = String.Format("Passes Blocked: {0}", ServerControl115.CurrentValue);
            MyStream.WriteLine(Banana);
            Banana = String.Format("Shots Blocked: {0}", ServerControl116.CurrentValue);
            MyStream.WriteLine(Banana);
            Banana = String.Format("Fouls: {0}", ServerControl117.CurrentValue);
            MyStream.WriteLine(Banana);
            Banana = String.Format("Comments: {0}", CommentsBox.Text);
            MyStream.WriteLine(Banana);

            MyStream.Close();
        }

    }
}