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
    /// <summary>
    /// This is the code for Server Control 3. Server Control 3 is a simple object that contains a button
    /// and a label. The button changes from true and blue to false and red and back when clicked. This
    /// function was made so that my robotics team could set simple functions that only have a true/false
    /// option. Originally, check boxes were used, but cell phones could not see them, so this is the
    /// result of that issue.
    /// </summary>
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:ServerControl3 runat=server></{0}:ServerControl3>")]
    public class ServerControl3 : CompositeControl
    {

        Label title;
        Button yesButton;

            /// <summary>
            /// This function sets and reads the title.
            /// </summary>
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

            /// <summary>
            /// This function adds a new feature to the button, its current state. This will return Off
            /// if the button is red and false, but will return On if the button is blue and true. The 
            /// ViewState of this function must not be named "Enabled", unless you want a name conflict.
            /// </summary>
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
            
        /// <summary>
        /// This is where we create the properties of the objects in use here.
        /// </summary>
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
            
        /// <summary>
        /// This is called when the button is clicked. It is for changing the state of the button in the next
        /// replot of the client and for keeping track of our internal state.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Checks to see if the button is true or false. If true, it will return true.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// When the object is initialized, it needs to start false and red.
        /// </summary>
            public void InitTerm()
            {
                ButtonState = "OFF";
                yesButton.Text = "False";
                yesButton.BackColor = System.Drawing.Color.Red;
            }
 
       
    }
}

