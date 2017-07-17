using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace DropdownlistFromDB_and_XML
{
    public partial class FromXML : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet data = new DataSet();
            data.ReadXml(Server.MapPath("Regions.xml"));
            drpXML.DataTextField = "City";
            drpXML.DataValueField = "CountryName";
            drpXML.DataSource = data;
            drpXML.DataBind();
        }
    }
}