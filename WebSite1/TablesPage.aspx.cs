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
        String strNumber = Request.QueryString["number"];
        int dividingNumber = 0;
        
        if (strMode == "A")
        {
            Label1x1.Text = strNumber + " + 1 =";
            Label1x2.Text = strNumber + " + 2 =";
            Label1x3.Text = strNumber + " + 3 =";
            Label1x4.Text = strNumber + " + 4 =";
            Label1x5.Text = strNumber + " + 5 =";
            Label1x6.Text = strNumber + " + 6 =";
            Label1x7.Text = strNumber + " + 7 =";
            Label1x8.Text = strNumber + " + 8 =";
            Label1x9.Text = strNumber + " + 9 =";
            Label1x10.Text = strNumber + " + 10 =";
            Label1x11.Text = strNumber + " + 11 =";
            Label1x12.Text = strNumber + " + 12 =";
        }
        if (strMode == "S")
        {
            Label1x1.Text = strNumber + " - 1 =";
            Label1x2.Text = strNumber + " - 2 =";
            Label1x3.Text = strNumber + " - 3 =";
            Label1x4.Text = strNumber + " - 4 =";
            Label1x5.Text = strNumber + " - 5 =";
            Label1x6.Text = strNumber + " - 6 =";
            Label1x7.Text = strNumber + " - 7 =";
            Label1x8.Text = strNumber + " - 8 =";
            Label1x9.Text = strNumber + " - 9 =";
            Label1x10.Text = strNumber + " - 10 =";
            Label1x11.Text = strNumber + " - 11 =";
            Label1x12.Text = strNumber + " - 12 =";
        }
        if (strMode == "D")
        {
            dividingNumber = Convert.ToInt32(strNumber);
            Label1x1.Text = dividingNumber * 1 + " ÷ 1 =";
            Label1x2.Text = dividingNumber * 2 + " ÷ 2 =";
            Label1x3.Text = dividingNumber * 3 + " ÷ 3 =";
            Label1x4.Text = dividingNumber * 4 + " ÷ 4 =";
            Label1x5.Text = dividingNumber * 5 + " ÷ 5 =";
            Label1x6.Text = dividingNumber * 6 + " ÷ 6 =";
            Label1x7.Text = dividingNumber * 7 + " ÷ 7 =";
            Label1x8.Text = dividingNumber * 8 + " ÷ 8 =";
            Label1x9.Text = dividingNumber * 9 + " ÷ 9 =";
            Label1x10.Text = dividingNumber * 10 + " ÷ 10 =";
            Label1x11.Text = dividingNumber * 11 + " ÷ 11 =";
            Label1x12.Text = dividingNumber * 12 + " ÷ 12 =";
        }
        if (strMode == "M")
        {
            Label1x1.Text = strNumber + " ×  1 =";
            Label1x2.Text = strNumber + " ×  2 =";
            Label1x3.Text = strNumber + " ×  3 =";
            Label1x4.Text = strNumber + " ×  4 =";
            Label1x5.Text = strNumber + " ×  5 =";
            Label1x6.Text = strNumber + " ×  6 =";
            Label1x7.Text = strNumber + " ×  7 =";
            Label1x8.Text = strNumber + " ×  8 =";
            Label1x9.Text = strNumber + " ×  9 =";
            Label1x10.Text = strNumber + " ×  12 =";
            Label1x11.Text = strNumber + " ×  11 =";
            Label1x12.Text = strNumber + " ×  12 =";
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