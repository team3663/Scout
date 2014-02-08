using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerControl3
{
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:ServerControl3 runat=server></{0}:ServerControl3>")]
    public class ServerControl3 : CompositeControl
    {

        Label title;
        Button yesButton;

            [Bindable(true)]
            [Category("Appearance")]
            [DefaultValue("")]
            [Localizable(true)]
            public string Title
            {
                get
                {
                    String s = (String)ViewState["Title"];
                    return ((s == null) ? "Title" : s);
                 }

                set
                {
                    ViewState["Title"] = value;
                    
                }
            }


            [Bindable(true)]
            [Category("Appearance")]
            [DefaultValue("")]
            [Localizable(true)]
            public string ButtonState
            {
                get
                {
                    String s = (String)ViewState["Banana"];
                    return ((s == null) ? "OFF" : s);
                }

                set
                {
                    Console.WriteLine("value = {0}", value);
                    ViewState["Banana"] = value;
                }
            }

            protected override void CreateChildControls()
            {
                title = new Label();
                title.Text = Title;
                title.Width = 300;
                Controls.Add(title);
                title.Font.Size = 36;

                Controls.Add(new LiteralControl("&nbsp; &nbsp;"));

                yesButton = new Button();
                yesButton.Text = "False";
                yesButton.BackColor = System.Drawing.Color.Red;
                yesButton.Click += yesButton_Click;
                yesButton.Width = 200;
                yesButton.Font.Size = 36;
                yesButton.Height = 100;
                Controls.Add(yesButton);



                
            }

            protected void yesButton_Click(object sender, EventArgs e)
            {
                if (ButtonState == "OFF")
                {
                    yesButton.BackColor = System.Drawing.Color.Blue;
                    yesButton.Text = "True";
                    ButtonState = "ON";
                }

                else
                {
                    yesButton.BackColor = System.Drawing.Color.Red;
                    yesButton.Text = "False";
                    ButtonState = "OFF";
                }
            }

            public bool ButtonSelected()
            {
                if (ButtonState == "ON")
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }

            public void InitTerm()
            {
                ButtonState = "OFF";
                yesButton.Text = "False";
                yesButton.BackColor = System.Drawing.Color.Red;
            }
 
       
    }
}

