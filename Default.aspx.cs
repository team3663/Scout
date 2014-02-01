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
            
            
            String Donut = String.Format("{0},", TextBox1.Text);
            Donut += String.Format("{0},", TextBox2.Text);
            Donut += String.Format("{0},", CheckBoxList1.Items[0].Selected);
            Donut += String.Format("{0},", CheckBoxList1.Items[1].Selected);
            Donut += String.Format("{0},", CheckBoxList1.Items[2].Selected);
            Donut += String.Format("{0},", CheckBoxList1.Items[3].Selected);
            Donut += String.Format("{0},", CheckBoxList1.Items[4].Selected);
            Donut += String.Format("{0},", PositionList.Items[0].Selected);
            Donut += String.Format("{0},", PositionList.Items[1].Selected);
            Donut += String.Format("{0},", PositionList.Items[2].Selected);
            Donut += String.Format("{0},", PositionList.Items[3].Selected);
            Donut += String.Format("{0},", PositionList.Items[4].Selected);
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
            Donut += String.Format("{0},", CommentsBox.Text);
            MyStream.WriteLine(Donut);

            MyStream.Close();

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