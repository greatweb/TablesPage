using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default5 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }





  
    protected void RadioButtonList3_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (rbTables.SelectedValue == "M")
        {
            btn2TimesTables.Text = "2 X Tables";
        }
        if (rbTables.SelectedValue == "A")
        {
            btn2TimesTables.Text = "2 + Tables";
        }

    }
  

    protected void btn2TimesTables_Click(object sender, EventArgs e)
    {
        string operation = "";
        operation = rbTables.SelectedValue;



        Response.Redirect("TablesPage.aspx?mode="+ operation);
    }
}