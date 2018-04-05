using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        String strMode = Request.QueryString["mode"];
        if (strMode == "A")
        {
            Label1x1.Text = "1 + 1 =";
        }
        if (strMode == "S")
        {
            Label1x1.Text = "1 - 1 =";
        }
        if (strMode == "D")
        {
            Label1x1.Text = "1 ÷ 1 =";
        }
        if (strMode == "M")
        {
            Label1x1.Text = "1 × 1 =";
        }
    }

    void Multiply()
    {
    }

    protected void Button2_Click(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}