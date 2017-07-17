using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace JavaScriptConfirms
{
    public partial class Form1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           LinkButton1.Click+=LinkButton1_Click;
            // yuxaridaki ve asaqidaki eyni neticeni verir
           //LinkButton1.Click += new EventHandler(LinkButton1_Click);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Write("Clicked");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Write("LinkButton1 Clicked");
        }

        protected void Command_Handler(object sender, CommandEventArgs e)
        {

        }
    }
}