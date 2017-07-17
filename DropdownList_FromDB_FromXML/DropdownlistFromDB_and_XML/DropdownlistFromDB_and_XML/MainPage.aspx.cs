using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
namespace DropdownlistFromDB_and_XML
{
    public partial class MainPage : System.Web.UI.Page
    {
        string connectionString = ConfigurationManager.ConnectionStrings["DBMS"].ConnectionString;
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                //ListItem firstItem = new ListItem("Select Name");
                //DropDownList1.Items.Add(firstItem);
                //DropDownList1.SelectedIndex=0;
                using(SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand("select stdID, Name from student", con);
                    con.Open();
                    DropDownList1.DataSource = cmd.ExecuteReader();
                    DropDownList1.DataTextField = "Name";
                    DropDownList1.DataValueField = "stdID";
                    DropDownList1.DataBind();
                }
            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string a = (DropDownList1.DataValueField.Where(x => x.Equals(DropDownList1.SelectedIndex))).ToString();

            //string a = DropDownList1.SelectedValue;
            //Response.Write(a);
            using(SqlConnection conn = new SqlConnection(connectionString))
            {
                SqlCommand com = new SqlCommand("select Age from student where stdID = @id", conn);
                com.Parameters.AddWithValue("@id", Convert.ToInt32(DropDownList1.SelectedValue));
                conn.Open();
                DropDownList2.DataSource = com.ExecuteReader();
                DropDownList2.DataTextField = "Age";
                DropDownList2.DataBind();
            }
        }
    }
}