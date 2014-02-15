using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    /// <summary>
    /// This is the web application for the scouting itself. This is where we submit the data that later
    /// gets analyzed. Enclosed is the code to make the 30 different scouting information pieces useable.
    /// All our scouting code this year is done with two server controls. The team number and match number
    /// are text boxes which can be edited, and the same is true for the comment box. When you click the
    /// submit button, all the data resets to where it was before the person started the scouting. The 
    /// scouting page starts with a login style page, allowing people to log in. Then they get to the major
    /// part of the scouting. Afterwards, they can choose to scout again or to exit.
    /// </summary>
    public partial class Submitance : System.Web.UI.Page
    {
        /// <summary>
        /// This code loads the page initially. Il loads the login page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            // ScriptManager.GetCurrent(Page).AuthenticationService.Path = "/Authentication_JSON_AppService.axd";
            if (!Page.IsPostBack)
            {
                MultiView1.ActiveViewIndex = 0;
                
            }
        }
        static string[] ValidLogin = {"cpr3663", "guest"};

        /// <summary>
        /// Checks to see if the log in is an acceptable one. This code will not let the person continue
        /// if the code is invalid.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button2_Click(object sender, EventArgs e)
        {
            foreach (string name in ValidLogin)
            {
                if (TextBox3.Text == name)
                {
                    FileName = string.Format(@"C:\Temp\{0}.txt", name);
                    MultiView1.ActiveViewIndex = 1;
                    return;
                }
            }

            Label3.Text = "Enter team name or guest";
            
        }

        /// <summary>
        /// This initializes the file name for graphing. Graphing is done on a seperate webpage later.
        /// </summary>
        public string FileName
        {
            get
            {
                String s = (String)ViewState["FileName"];
                return ((s == null) ? "" : s);
            }

            set
            {
                ViewState["FileName"] = value;
            }
        }

        /// <summary>
        /// This code sends the data in the scouting to a seperate file. It puts all of the data in a single
        /// line on a notepad.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {

            System.IO.FileInfo MyFile = new System.IO.FileInfo(FileName);
            System.IO.StreamWriter MyStream = null;
            if (!System.IO.File.Exists(FileName))
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
            Donut += String.Format("{0},", ServerControl35.ButtonSelected());
            Donut += String.Format("{0},", ServerControl34.ButtonSelected());
            Donut += String.Format("{0},", ServerControl36.ButtonSelected());
            Donut += String.Format("{0},", ServerControl37.ButtonSelected());
            Donut += String.Format("{0},", ServerControl38.ButtonSelected());
            Donut += String.Format("{0},", ServerControl39.ButtonSelected());
            Donut += String.Format("{0},", ServerControl310.ButtonSelected());
            Donut += String.Format("{0},", ServerControl311.ButtonSelected());
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

        /// <summary>
        /// This code sends us back into the scouting report. It is for if we want to continue our scouting
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button3_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        /// <summary>
        /// This code sends us to the log in page. It is for when we are done scouting.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button4_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 0;
        }
    }
}