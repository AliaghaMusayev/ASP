using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Learning1
{
    public partial class SessionState2 : System.Web.UI.Page
    {
        int counter = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!IsPostBack)
            {
                Session["UserSession"] = 0;
                TextBox1.Text = "0";
            }

        }
        // NOTE: Session variables are single user global variables
        // It means these variables is available in all verforms for current session user
        protected void Button1_Click(object sender, EventArgs e)
        {
            counter = (int)Session["UserSession"] + 1;
            TextBox1.Text = counter.ToString();
            Session["UserSession"] = counter;
        }
    }
}