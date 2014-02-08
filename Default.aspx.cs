using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Submitance : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // ScriptManager.GetCurrent(Page).AuthenticationService.Path = "/Authentication_JSON_AppService.axd";
            if (!Page.IsPostBack)
            {
                MultiView1.ActiveViewIndex = 0;
                
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string fileName = @"C:\Temp\Data.txt";
            System.IO.FileInfo MyFile = new System.IO.FileInfo(fileName);
            System.IO.StreamWriter MyStream = null;
            if (!System.IO.File.Exists(fileName))
            {
                MyStream = MyFile.CreateText();
            }
            else
            {
                MyStream = MyFile.AppendText();
            }
            
            
            String Donut = String.Format("{0},", TextBox1.Text.Replace(",", "&com;"));
            Donut += String.Format("{0},", TextBox2.Text.Replace(",", "&com;"));
            Donut += String.Format("{0},", ServerControl31.ButtonSelected());
            Donut += String.Format("{0},", ServerControl32.ButtonSelected());
            Donut += String.Format("{0},", ServerControl33.ButtonSelected());
            Donut += String.Format("{0},", ServerControl34.ButtonSelected());
            Donut += String.Format("{0},", ServerControl35.ButtonSelected());
            Donut += String.Format("{0},", ServerControl36.ButtonSelected());
            Donut += String.Format("{0},", ServerControl37.ButtonSelected());
            Donut += String.Format("{0},", ServerControl38.ButtonSelected());
            Donut += String.Format("{0},", ServerControl39.ButtonSelected());
            Donut += String.Format("{0},", ServerControl310.ButtonSelected());
            Donut += String.Format("{0},", ServerControl13.CurrentValue);
            Donut += String.Format("{0},", ServerControl12.CurrentValue);
            Donut += String.Format("{0},", ServerControl11.CurrentValue);
            Donut += String.Format("{0},", ServerControl14.CurrentValue);
            Donut += String.Format("{0},", ServerControl15.CurrentValue);
            Donut += String.Format("{0},", ServerControl16.CurrentValue);
            Donut += String.Format("{0},", ServerControl17.CurrentValue);
            Donut += String.Format("{0},", ServerControl18.CurrentValue);
            Donut += String.Format("{0},", ServerControl19.CurrentValue);
            Donut += String.Format("{0},", ServerControl110.CurrentValue);
            Donut += String.Format("{0},", ServerControl111.CurrentValue);
            Donut += String.Format("{0},", ServerControl112.CurrentValue);
            Donut += String.Format("{0},", ServerControl113.CurrentValue);
            Donut += String.Format("{0},", ServerControl114.CurrentValue);
            Donut += String.Format("{0},", ServerControl115.CurrentValue);
            Donut += String.Format("{0},", ServerControl116.CurrentValue);
            Donut += String.Format("{0},", ServerControl117.CurrentValue);
            Donut += String.Format("{0}", CommentsBox.Text.Replace(",", "&com;"));
            MyStream.WriteLine(Donut);

            MyStream.Close();

            TextBox1.Text = "";
            TextBox2.Text = "";
            ServerControl31.InitTerm();
            ServerControl32.InitTerm();
            ServerControl33.InitTerm();
            ServerControl34.InitTerm();
            ServerControl35.InitTerm();
            ServerControl36.InitTerm();
            ServerControl37.InitTerm();
            ServerControl38.InitTerm();
            ServerControl39.InitTerm();
            ServerControl310.InitTerm();
            /* CheckBoxList1.Items[0].Selected = false;
            CheckBoxList1.Items[1].Selected = false;
            CheckBoxList1.Items[2].Selected = false;
            CheckBoxList1.Items[3].Selected = false;
            CheckBoxList1.Items[4].Selected = false;
            PositionList.Items[0].Selected = false;
            PositionList.Items[1].Selected = false;
            PositionList.Items[2].Selected = false;
            PositionList.Items[3].Selected = false;
            PositionList.Items[4].Selected = false; */
            ServerControl13.InitValue();
            ServerControl12.InitValue();
            ServerControl11.InitValue();
            ServerControl14.InitValue();
            ServerControl15.InitValue();
            ServerControl16.InitValue();
            ServerControl17.InitValue();
            ServerControl18.InitValue();
            ServerControl19.InitValue();
            ServerControl110.InitValue();
            ServerControl111.InitValue();
            ServerControl112.InitValue();
            ServerControl113.InitValue();
            ServerControl114.InitValue();
            ServerControl115.InitValue();
            ServerControl116.InitValue();
            ServerControl117.InitValue();
            CommentsBox.Text = "Comment Here";

            MultiView1.ActiveViewIndex = 2;
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }
    }
}