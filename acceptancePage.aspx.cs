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
        protected void Page_Load(object sender, EventArgs e)
        {
            MatchData.ParseDateFile(@"C:\Temp\FakeMatch.txt");

        }

    }
}