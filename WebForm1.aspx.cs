using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void MinusButton2_Click(object sender, EventArgs e)
        {
            int Temp;
            if (int.TryParse(TextBox3.Text, out Temp))
            {
                if (Temp > 0)
                {
                    Temp--;
                    TextBox3.Text = Temp.ToString();
                }
            }
        }

        protected void PlusButton1_Click(object sender, EventArgs e)
        {
            int Temp;
            if (int.TryParse(TextBox2.Text, out Temp))
            {
                if (Temp < 10)
                {
                    Temp++;
                    TextBox2.Text = Temp.ToString();
                }
            }
        }

        protected void MinusButton1_Click(object sender, EventArgs e)
        {
            int Temp;
            if (int.TryParse(TextBox2.Text, out Temp))
            {
                if (Temp > 0)
                {
                    Temp--;
                    TextBox2.Text = Temp.ToString();
                }
            }
        }

        protected void PlusButton2_Click(object sender, EventArgs e)
        {
            int Temp;
            if (int.TryParse(TextBox3.Text, out Temp))
            {
                if (Temp < 10)
                {
                    Temp++;
                    TextBox3.Text = Temp.ToString();
                }
            }
        }

        protected void MinusButton3_Click(object sender, EventArgs e)
        {
            int Temp;
            if (int.TryParse(TextBox4.Text, out Temp))
            {
                if (Temp > 0)
                {
                    Temp--;
                    TextBox4.Text = Temp.ToString();
                }
            }
        }

        protected void PlusButton3_Click(object sender, EventArgs e)
        {
            int Temp;
            if (int.TryParse(TextBox4.Text, out Temp))
            {
                if (Temp < 10)
                {
                    Temp++;
                    TextBox4.Text = Temp.ToString();
                }
            }
        }
    }
}