using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    int txtBoxAnswer = 0;
    int txtBoxAnswer2 = 0;
    int txtBoxAnswer3 = 0;

    int dividingNumber = 0;
    int ifSymbol = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        int txtBoxAnswer = 0;
        int txtBoxAnswer2 = 0;
        int txtBoxAnswer3 = 0;
        String strMode = Request.QueryString["mode"];
        String strNumber = Request.QueryString["number"];
        int dividingNumber = 0;
        int ifSymbol = 0;

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
            Label1x1.Text = dividingNumber * 1 + " ÷ " + strNumber + "=";
            Label1x2.Text = dividingNumber * 2 + " ÷ " + strNumber + " =";
            Label1x3.Text = dividingNumber * 3 + " ÷ " + strNumber + " =";
            Label1x4.Text = dividingNumber * 4 + " ÷ " + strNumber + " =";
            Label1x5.Text = dividingNumber * 5 + " ÷ " + strNumber + " =";
            Label1x6.Text = dividingNumber * 6 + " ÷ " + strNumber + " =";
            Label1x7.Text = dividingNumber * 7 + " ÷ " + strNumber + " =";
            Label1x8.Text = dividingNumber * 8 + " ÷ " + strNumber + " =";
            Label1x9.Text = dividingNumber * 9 + " ÷ " + strNumber + " =";
            Label1x10.Text = dividingNumber * 10 + " ÷ " + strNumber + " =";
            Label1x11.Text = dividingNumber * 11 + " ÷ " + strNumber + " =";
            Label1x12.Text = dividingNumber * 12 + " ÷ " + strNumber + " =";
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
            Label1x10.Text = strNumber + " ×  10 =";
            Label1x11.Text = strNumber + " ×  11 =";
            Label1x12.Text = strNumber + " ×  12 =";
        }

    }

    void Multiply()
    {
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        String strMode = Request.QueryString["mode"];
        String strNumber = Request.QueryString["number"];
            dividingNumber = Convert.ToInt32(strNumber);
            txtBoxAnswer = Convert.ToInt32(TextBox1.Text);
            txtBoxAnswer2 = Convert.ToInt32(TextBox2.Text);
            txtBoxAnswer3 = Convert.ToInt32(TextBox3.Text);
        if (strMode == "A")
        {
            
            if (dividingNumber + 1 == txtBoxAnswer)
            {
                Label1.Text = ("Correct");
            }
            else
            {
                Label1.Text = ("Incorrect");
            }
            if (dividingNumber + 2 == txtBoxAnswer2)
            {
                Label2.Text = ("Correct");
            }
            else
            {
                Label2.Text = ("Incorrect");
            }
            if (dividingNumber + 3 == txtBoxAnswer3)
            {
                Label3.Text = ("Correct");
            }
            else
            {
                Label3.Text = ("Incorrect");
            }
        }

        if (strMode == "S")
        {
            dividingNumber = Convert.ToInt32(strNumber);
            if (dividingNumber - 1 == txtBoxAnswer)
            {
                Label1.Text = ("Correct");
            }
            else
            {
                Label1.Text = ("Incorrect");
            }
            if (dividingNumber - 2 == txtBoxAnswer2)
            {
                Label2.Text = ("Correct");
            }
            else
            {
                Label2.Text = ("Incorrect");
            }
            if (dividingNumber - 3 == txtBoxAnswer)
            {
                Label3.Text = ("Correct");
            }
            else
            {
                Label3.Text = ("Incorrect");
            }
        }

        if (strMode == "M")
           {
            dividingNumber = Convert.ToInt32(strNumber);
            if (dividingNumber * 1 == txtBoxAnswer)
            {
                Label1.Text = ("Correct");
            }
            else
            {
                Label1.Text = ("Incorrect");
            }
            if (dividingNumber * 2 == txtBoxAnswer2)
            {
                Label2.Text = ("Correct");
            }
            else
            {
                Label2.Text = ("Incorrect");
            }
            if (dividingNumber * 3 == txtBoxAnswer)
            {
                Label3.Text = ("Correct");
            }
            else
            {
                Label3.Text = ("Incorrect");
            }
        }

        if (strMode == "D")
        {
            dividingNumber = Convert.ToInt32(strNumber);
            if (dividingNumber * 1 / dividingNumber == txtBoxAnswer)
            {
                Label1.Text = ("Correct");
            }
            else
            {
                Label1.Text = ("Incorrect");
            }
            if (dividingNumber * 2 / dividingNumber == txtBoxAnswer2)
            {
                Label2.Text = ("Correct");
            }
            else
            {
                Label2.Text = ("Incorrect");
            }
            if (dividingNumber * 3 / dividingNumber == txtBoxAnswer3)
            {
                Label3.Text = ("Correct");
            }
            else
            {
                Label3.Text = ("Incorrect");
            }
        }
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
}