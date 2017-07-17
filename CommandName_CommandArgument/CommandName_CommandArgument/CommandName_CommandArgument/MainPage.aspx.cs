using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CommandName_CommandArgument
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Command_Handler(object sender, CommandEventArgs e)
        {
            switch(e.CommandName)
            {
                case "ClickMe1":
                    lblClicked.Text = ("ClickMe1 button clicked");
                    break;
                case "ClickMe2":
                    lblClicked.Text = ("ClickMe2 button clicked");
                    break;
                case "Repeat":
                    if(e.CommandArgument.ToString()=="Click1")
                    {
                        lblClicked.Text = ("RepeatClickMe1 button clicked");
                    }
                    else
                    {
                        lblClicked.Text = ("RepeatClickMe2 button clicked");
                    }
                    break;
                default:
                    lblClicked.Text = ("No any button clicked");
                    break;
            }
        }
    }
}