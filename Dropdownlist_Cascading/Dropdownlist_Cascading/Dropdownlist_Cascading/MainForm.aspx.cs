using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
namespace Dropdownlist_Cascading
{
    public partial class MainForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
               drpName.DataSource = callProcedure("prcStudentAllList", null);
               drpName.DataTextField = "Name";
               drpName.DataValueField = "stdID";
               drpName.DataBind();
            }
        }


        private DataSet callProcedure(string procedureName, SqlParameter parameter)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            SqlDataAdapter adapter = new SqlDataAdapter(procedureName,connectionString);
            adapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            if(parameter!=null)
            {
                adapter.SelectCommand.Parameters.Add(parameter);
            }
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;
        }

        protected void drpName_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = drpName.SelectedValue;
            SqlParameter parameter = new SqlParameter("@StudentId", id);
            drpAge.DataSource = callProcedure("prcStudentAge", parameter);
            drpAge.DataTextField = "Age";
            drpAge.DataBind();
        }
    }
}