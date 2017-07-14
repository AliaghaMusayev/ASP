using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IsPostback_Lesson
{
    public partial class MainPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //  1. Dropdown list doldurularken value-larin postback-dan sonra tekrar yuklenmemesi ucun en ideal varian IsPostback variantidi
            //  2. dropdownlist.Items.Clear() metodundan da istifade ede bilerik ancaq bu performnce baximdan yararli deyil
            
            //drpDown.Items.Clear();
            //fillDropdownController();

            // 3. Dropdown list-in propertiden ViewStat-ni sondururuk... View State sondurende deyisikleri ozunde saxlamir.
            // Ancaq bunu da menfisi odur ki hansisa value secib harasa daxil etmek istesek alinmayacaq... 

            if(!IsPostBack)
            {
                fillDropdownController();
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        public void fillDropdownController()
        {
            ListItem city1 = new ListItem("Baku");
            ListItem city2 = new ListItem("Sumqayit");
            ListItem city3 = new ListItem("Ganca");
            drpDown.Items.Add(city1);
            drpDown.Items.Add(city2);
            drpDown.Items.Add(city3);
        }
    }
}