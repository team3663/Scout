using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ServerControl1
{
    /// <summary>
    /// This is our server control 1 class. This class has two buttons, a box containing an interger, and
    /// a title. The buttons are a minus button and a plus button. This function is supposed to allow the
    /// program to increment and decrement a number in a box within a given range. It is made to allow 
    /// our robotics team to add up the number of things our opponent (or teammate) does, and rate them on
    /// scales of 1-10 on speed, manueverability, and driver ability.
    /// </summary>
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:ServerControl1 runat=server></{0}:ServerControl1>")]
    public class ServerControl1 : CompositeControl
    {
        Label title;
        Button MinusButton;
        TextBox IntBox;
        Button PlusButton;
        int startingValue = 5;
        int maxValue = 10;
        int minValue = 0;

        /// <summary>
        /// This function initializes the Title of the object.
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
                return ((s == null)? "Title" : s);
            }
 
            set
            {
                ViewState["Title"] = value;
            }
        }

        /// <summary>
        /// This function initializes the minimum value of the object. The minimum value is the lowest number
        /// that is allowed in the text box.
        /// </summary>
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public int MinimumValue
        {
            get
            {
                return minValue;
            }
            set
            {
                minValue = value;
            }
        }

        /// <summary>
        /// This function initializes the maximum value, which is the highest number that is allowed in the
        /// text box.
        /// </summary>
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public int MaximumValue
        {
            get
            {
                return maxValue;
            }
            set
            {
                maxValue = value;
            }
        }

        /// <summary>
        /// This function checks for the current value in the text box.
        /// </summary>
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public int CurrentValue
        {
            get
            {
                String s = (String)ViewState["CurrentValue"];
                return ((s == null) ? 5 : int.Parse(s));
            }

            set
            {
                ViewState["CurrentValue"] = value.ToString();
            }
        }

        /// <summary>
        /// This function indicates the value that will appear in the text box when the object is first
        /// initialized.
        /// </summary>
        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public int StartingValue
        {
            get
            {
                return startingValue;
            }
            set
            {
                startingValue = value;
            }
        }

        /// <summary>
        /// This is where I set the important attributes to all my objects. Because the program is made to 
        /// be accessible by a cell phone user, the sizes are very large.
        /// </summary>
        protected override void CreateChildControls()
        {
            title = new Label();
            title.Text = Title;
            title.Width = 300;
            Controls.Add(title);
            title.Font.Size = 36;

            Controls.Add(new LiteralControl("&nbsp; &nbsp;"));

            MinusButton = new Button();
            MinusButton.Text = "-";
            MinusButton.BackColor = System.Drawing.Color.Red;
            MinusButton.Click += MinusButton_Click;
            MinusButton.Width = 150;
            MinusButton.Font.Size = 36;
            MinusButton.Height = 100;
            Controls.Add(MinusButton);

            Controls.Add(new LiteralControl("&nbsp; &nbsp;"));

            IntBox = new TextBox();
            IntBox.Text = CurrentValue.ToString();
            IntBox.Width = 100;
            IntBox.ReadOnly = true;
            Controls.Add(IntBox);
            IntBox.Height = 50;
            IntBox.Font.Size = 24;

            Controls.Add(new LiteralControl("&nbsp; &nbsp;"));

            PlusButton = new Button();
            PlusButton.Text = "+";
            PlusButton.BackColor = System.Drawing.Color.Green;
            PlusButton.Click += PlusButton_Click;
            PlusButton.Width = 150;
            PlusButton.Height = 100;
            PlusButton.Font.Size = 36;
            Controls.Add(PlusButton);

        }

        /// <summary>
        /// This function decrements the number in the text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void MinusButton_Click(object sender, EventArgs e)
        {
            int Temp = CurrentValue;
            
            if (Temp > minValue)
            {
                CurrentValue = Temp - 1;
                IntBox.Text = CurrentValue.ToString();
            }
            
        }

        /// <summary>
        /// This function increments the number in the text box.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void PlusButton_Click(object sender, EventArgs e)
        {
            int Temp = CurrentValue;
            
            if (Temp < maxValue)
            {
                CurrentValue = Temp + 1;
                IntBox.Text = CurrentValue.ToString();

            }
        }

        /// <summary>
        /// This function sets the value for the object when it is first initialized.
        /// </summary>
        public void InitValue()
        {
            CurrentValue = startingValue;
            IntBox.Text = CurrentValue.ToString();
        }
 
    }
}
