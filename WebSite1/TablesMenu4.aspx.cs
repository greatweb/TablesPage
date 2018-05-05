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
            btn1TimesTables.Text = "1 × Tables";
            btn2TimesTables.Text = "2 × Tables";
            btn3TimesTables.Text = "3 × Tables";
            btn4TimesTables.Text = "4 × Tables";
            btn5TimesTables.Text = "5 × Tables";
            btn6TimesTables.Text = "6 × Tables";
            btn7TimesTables.Text = "7 × Tables";
            btn8TimesTables.Text = "8 × Tables";
            btn9TimesTables.Text = "9 × Tables";
            btn10TimesTables.Text = "10 × Tables";
            btn11TimesTables.Text = "11 × Tables";
            btn12TimesTables.Text = "12 × Tables";
        }
        if (rbTables.SelectedValue == "A")
        {
            btn1TimesTables.Text = "+ 1 Tables";
            btn2TimesTables.Text = "+ 2 Tables";
            btn3TimesTables.Text = "+ 3 Tables";
            btn4TimesTables.Text = "+ 4 Tables";
            btn5TimesTables.Text = "+ 5 Tables";
            btn6TimesTables.Text = "+ 6 Tables";
            btn7TimesTables.Text = "+ 7 Tables";
            btn8TimesTables.Text = "+ 8 Tables";
            btn9TimesTables.Text = "+ 9 Tables";
            btn10TimesTables.Text = "+ 10 Tables";
            btn11TimesTables.Text = "+ 11 Tables";
            btn12TimesTables.Text = "+ 12 Tables";
        }
        if (rbTables.SelectedValue == "S")
        {
            btn1TimesTables.Text = "1 - Tables";
            btn2TimesTables.Text = "2 - Tables";
            btn3TimesTables.Text = "3 - Tables";
            btn4TimesTables.Text = "4 - Tables";
            btn5TimesTables.Text = "5 - Tables";
            btn6TimesTables.Text = "6 - Tables";
            btn7TimesTables.Text = "7 - Tables";
            btn8TimesTables.Text = "8 - Tables";
            btn9TimesTables.Text = "9 - Tables";
            btn10TimesTables.Text = "10 - Tables";
            btn11TimesTables.Text = "11 - Tables";
            btn12TimesTables.Text = "12 - Tables";
        }
        if (rbTables.SelectedValue == "D")
        {
            btn1TimesTables.Text = "1 ÷ Tables";
            btn2TimesTables.Text = "2 ÷ Tables";
            btn3TimesTables.Text = "3 ÷ Tables";
            btn4TimesTables.Text = "4 ÷ Tables";
            btn5TimesTables.Text = "5 ÷ Tables";
            btn6TimesTables.Text = "6 ÷ Tables";
            btn7TimesTables.Text = "7 ÷ Tables";
            btn8TimesTables.Text = "8 ÷ Tables";
            btn9TimesTables.Text = "9 ÷ Tables";
            btn10TimesTables.Text = "10 ÷ Tables";
            btn11TimesTables.Text = "11 ÷ Tables";
            btn12TimesTables.Text = "12 ÷ Tables";
        }
    }
  

    protected void btn2TimesTables_Click(object sender, EventArgs e)
    {
        string operation = "";
        operation = rbTables.SelectedValue;

        Response.Redirect("default3.aspx?mode="+ operation + "&number=2");
    }

    protected void btn1TimesTables_Click(object sender, EventArgs e)
    {
        string operation = "";
        operation = rbTables.SelectedValue;

        Response.Redirect("default3.aspx?mode=" + operation + "&number=1");
    }

    protected void btn3TimesTables_Click(object sender, EventArgs e)
    {
        string operation = "";
        operation = rbTables.SelectedValue;

        Response.Redirect("default3.aspx?mode=" + operation + "&number=3");
    }

    protected void btn4TimesTables_Click(object sender, EventArgs e)
    {
        string operation = "";
        operation = rbTables.SelectedValue;

        Response.Redirect("default3.aspx?mode=" + operation + "&number=4");
    }

    protected void btn5TimesTables_Click(object sender, EventArgs e)
    {
        string operation = "";
        operation = rbTables.SelectedValue;

        Response.Redirect("default3.aspx?mode=" + operation + "&number=5");
    }

    protected void btn6TimesTables_Click(object sender, EventArgs e)
    {
        string operation = "";
        operation = rbTables.SelectedValue;

        Response.Redirect("default3.aspx?mode=" + operation + "&number=6");
    }

    protected void btn7TimesTables_Click(object sender, EventArgs e)
    {
        string operation = "";
        operation = rbTables.SelectedValue;

        Response.Redirect("default3.aspx?mode=" + operation + "&number=7");
    }

    protected void btn8TimesTables_Click(object sender, EventArgs e)
    {
        string operation = "";
        operation = rbTables.SelectedValue;

        Response.Redirect("default3.aspx?mode=" + operation + "&number=8");
    }

    protected void btn9TimesTables_Click(object sender, EventArgs e)
    {
        string operation = "";
        operation = rbTables.SelectedValue;

        Response.Redirect("default3.aspx?mode=" + operation + "&number=9");
    }

    protected void btn10TimesTables_Click(object sender, EventArgs e)
    {
        string operation = "";
        operation = rbTables.SelectedValue;

        Response.Redirect("default3.aspx?mode=" + operation + "&number=10");
    }

    protected void btn11TimesTables_Click(object sender, EventArgs e)
    {
        string operation = "";
        operation = rbTables.SelectedValue;

        Response.Redirect("default3.aspx?mode=" + operation + "&number=11");
    }

    protected void btn12TimesTables_Click(object sender, EventArgs e)
    {
        string operation = "";
        operation = rbTables.SelectedValue;

        Response.Redirect("default3.aspx?mode=" + operation + "&number=12");
    }
}