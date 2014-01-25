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
    [DefaultProperty("Text")]
    [ToolboxData("<{0}:ServerControl1 runat=server></{0}:ServerControl1>")]
    public class ServerControl1 : CompositeControl
    {
        Label title;
        Button MinusButton;
        TextBox IntBox;
        Button PlusButton;

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

        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public int MinimumValue
        {
            get
            {
                String s = (String)ViewState["MinimumValue"];
                return ((s == null) ? 0 : int.Parse(s));
            }

            set
            {
                ViewState["MinimumValue"] = value.ToString();
            }
        }

        [Bindable(true)]
        [Category("Appearance")]
        [DefaultValue("")]
        [Localizable(true)]
        public int MaximumValue
        {
            get
            {
                String s = (String)ViewState["MaximumValue"];
                return ((s == null) ? 10 : int.Parse(s));
            }

            set
            {
                ViewState["MaximumValue"] = value.ToString();
            }
        }

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

        protected override void CreateChildControls()
        {
            title = new Label();
            title.Text = Title;
            title.Width = 100;
            Controls.Add(title);

            Controls.Add(new LiteralControl("&nbsp; &nbsp;"));

            MinusButton = new Button();
            MinusButton.Text = "-";
            MinusButton.BackColor = System.Drawing.Color.Red;
            MinusButton.Click += MinusButton_Click;
            MinusButton.Width = 30;
            Controls.Add(MinusButton);

            Controls.Add(new LiteralControl("&nbsp; &nbsp;"));

            IntBox = new TextBox();
            IntBox.Text = CurrentValue.ToString();
            IntBox.Width = 50;
            IntBox.ReadOnly = true;
            Controls.Add(IntBox);

            Controls.Add(new LiteralControl("&nbsp; &nbsp;"));

            PlusButton = new Button();
            PlusButton.Text = "+";
            PlusButton.BackColor = System.Drawing.Color.Green;
            PlusButton.Click += PlusButton_Click;
            PlusButton.Width = 30;
            Controls.Add(PlusButton);

        }

        protected void MinusButton_Click(object sender, EventArgs e)
        {
            int Temp = CurrentValue;
            
            if (Temp > MinimumValue)
            {
                CurrentValue = Temp - 1;
            }
            
        }


        protected void PlusButton_Click(object sender, EventArgs e)
        {
            int Temp = CurrentValue;
            
            if (Temp < MaximumValue)
            {
                CurrentValue = Temp + 1;
            }
        }
 
    }
}
