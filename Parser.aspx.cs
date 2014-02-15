using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ParserWebApplication
{
    public partial class acceptancePage : System.Web.UI.Page
    {

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

        public int StartLine
        {
            get
            {
                string s = (String)ViewState["StartLine"];
                return ((s == null) ? 0 : int.Parse(s));
            }

            set
            {
                ViewState["StartLine"] = value.ToString();
            }
        }
        /// <summary>
        /// This function takes in the data from the file that we will be analyzing for data.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                MultiView1.ActiveViewIndex = 0;
            }
            else if (FileName != "")
            {
                StartLine = MatchData.ParseDateFile(FileName, StartLine);
            }
            

        }

        static string[] ValidLogin = { "cpr3663", "guest", "FakeMatch" };

        /// <summary>
        /// This function allows a person to view their own data on a graph. In addition, it allows us to
        /// view our data without a conflict from other people's data. This button will take a file and view
        /// it.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (string name in ValidLogin)
            {
                if (TextBox1.Text == name)
                {
                    FileName = string.Format(@"C:\Temp\{0}.txt", name);
                    StartLine = MatchData.ParseDateFile(FileName, 0);
                    MultiView1.ActiveViewIndex = 1;
                    return;
                }
            }

            Label1.Text = "Enter team name or guest";
        }

        /// <summary>
        /// This function allows us to call a file in order to sort it into data and parse it out.
        /// </summary>
        public string FileNameChange
        {
            get
            {
                String s = (String)ViewState["FileNameChange"];
                return ((s == null) ? "" : s);
            }

            set
            {
                ViewState["FileNameChange"] = value;
            }
        }

        /// <summary>
        /// Changes the view from the entry page to the graph.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void Button2_Click(object sender, EventArgs e)
        {
            MultiView1.ActiveViewIndex = 1;
        }

        /// <summary>
        /// Changes the view from a less specific graph to a more specific graph.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // int teamNumber = (int)(GridView1.SelectedDataKey.Values["TeamNumber"]);
            MultiView1.ActiveViewIndex = 2;
        }

    }
}