using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Learning1
{

    // ViewState-ler klient server arasinda muraciet zamani lazimi value-larin sifirlanmamasi ucun istifade edilir
    // Meselen asagidaki numunede ViewState yaratmaqla textbox-daki value-nin sifirlanmamasina calisdiq.. 
    // Qeyd edek ki ASP.NET-de butun controllar ve elementler internal ViewState-e malikdirler.. bunun ucun ViewState istifade etmeden de value-lari saxlamaq mumkundur
    //Button2_Click metoduna bax
    public partial class ViewState1 : System.Web.UI.Page
    {
        int counter=1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                TextBox1.Text = "0";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (ViewState["ClickView"] != null)
            {
                counter = (int)ViewState["ClickView"] + 1;
                Button1.Text = "Clicked";
            }
            //counter += 1;
            TextBox1.Text = counter.ToString();
            ViewState["ClickView"] = counter;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            int counter2 = Convert.ToInt32(TextBox1.Text) + 1;
            TextBox1.Text = counter2.ToString();
        }
    }
}