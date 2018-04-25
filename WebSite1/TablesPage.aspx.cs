using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class Default3 : System.Web.UI.Page
{
    int txtBoxAnswer = 0;
    int txtBoxAnswer2 = 0;
    int txtBoxAnswer3 = 0;
    int txtBoxAnswer4 = 0;
    int txtBoxAnswer5 = 0;
    int txtBoxAnswer6 = 0;
    int txtBoxAnswer7 = 0;
    int txtBoxAnswer8 = 0;
    int txtBoxAnswer9 = 0;
    int txtBoxAnswer10 = 0;
    int txtBoxAnswer11 = 0;
    int txtBoxAnswer12 = 0;
    int counter = 0;
    double timeTaken = 0.000;
    string strTimeTaken;
    string qAnswer1;
    string qAnswer2;
    string qAnswer3;
    string qAnswer4;
    string qAnswer5;
    string qAnswer6;
    string qAnswer7;
    string qAnswer8;
    string qAnswer9; 
    string qAnswer10;
    string qAnswer11;
    string qAnswer12;

    int dividingNumber = 0;
    int ifSymbol = 0;

    SqlConnection con = new SqlConnection(@"Data Source=IESURFACEPRO2A\SQLEXPRESS;Initial Catalog=MaximGame;Integrated Security=True");

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
            txtBoxAnswer4 = Convert.ToInt32(TextBox4.Text);
            txtBoxAnswer5 = Convert.ToInt32(TextBox5.Text);
            txtBoxAnswer6 = Convert.ToInt32(TextBox6.Text);
            txtBoxAnswer7 = Convert.ToInt32(TextBox7.Text);
            txtBoxAnswer8 = Convert.ToInt32(TextBox8.Text);
            txtBoxAnswer9 = Convert.ToInt32(TextBox12.Text);
            txtBoxAnswer10 = Convert.ToInt32(TextBox9.Text);
            txtBoxAnswer11 = Convert.ToInt32(TextBox10.Text);
            txtBoxAnswer12 = Convert.ToInt32(TextBox11.Text);


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
            if (dividingNumber + 4 == txtBoxAnswer4)
            {
                Label4.Text = ("Correct");
            }
            else
            {
                Label4.Text = ("Incorrect");
            }
            if (dividingNumber + 5 == txtBoxAnswer5)
            {
                Label5.Text = ("Correct");
            }
            else
            {
                Label5.Text = ("Incorrect");
            }
            if (dividingNumber + 6 == txtBoxAnswer6)
            {
                Label6.Text = ("Correct");
            }
            else
            {
                Label6.Text = ("Incorrect");
            }
            if (dividingNumber + 7 == txtBoxAnswer7)
            {
                Label7.Text = ("Correct");
            }
            else
            {
                Label7.Text = ("Incorrect");
            }
            if (dividingNumber + 8 == txtBoxAnswer8)
            {
                Label8.Text = ("Correct");
            }
            else
            {
                Label8.Text = ("Incorrect");
            }
            if (dividingNumber + 9 == txtBoxAnswer9)
            {
                Label9.Text = ("Correct");
            }
            else
            {
                Label9.Text = ("Incorrect");
            }
            if (dividingNumber + 10 == txtBoxAnswer10)
            {
                Label10.Text = ("Correct");
            }
            else
            {
                Label10.Text = ("Incorrect");
            }
            if (dividingNumber + 11 == txtBoxAnswer11)
            {
                Label11.Text = ("Correct");
            }
            else
            {
                Label11.Text = ("Incorrect");
            }
            if (dividingNumber + 12 == txtBoxAnswer12)
            {
                Label12.Text = ("Correct");
            }
            else
            {
                Label12.Text = ("Incorrect");
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
            if (dividingNumber - 4 == txtBoxAnswer4)
            {
                Label4.Text = ("Correct");
            }
            else
            {
                Label4.Text = ("Incorrect");
            }
            if (dividingNumber - 5 == txtBoxAnswer5)
            {
                Label5.Text = ("Correct");
            }
            else
            {
                Label5.Text = ("Incorrect");
            }
            if (dividingNumber - 6 == txtBoxAnswer6)
            {
                Label6.Text = ("Correct");
            }
            else
            {
                Label6.Text = ("Incorrect");
            }
            if (dividingNumber - 7 == txtBoxAnswer7)
            {
                Label7.Text = ("Correct");
            }
            else
            {
                Label7.Text = ("Incorrect");
            }
            if (dividingNumber - 8 == txtBoxAnswer8)
            {
                Label8.Text = ("Correct");
            }
            else
            {
                Label8.Text = ("Incorrect");
            }
            if (dividingNumber - 9 == txtBoxAnswer9)
            {
                Label9.Text = ("Correct");
            }
            else
            {
                Label9.Text = ("Incorrect");
            }
            if (dividingNumber - 10 == txtBoxAnswer10)
            {
                Label10.Text = ("Correct");
            }
            else
            {
                Label10.Text = ("Incorrect");
            }
            if (dividingNumber - 11 == txtBoxAnswer11)
            {
                Label11.Text = ("Correct");
            }
            else
            {
                Label11.Text = ("Incorrect");
            }
            if (dividingNumber - 12 == txtBoxAnswer12)
            {
                Label12.Text = ("Correct");
            }
            else
            {
                Label12.Text = ("Incorrect");
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
            if (dividingNumber * 4 == txtBoxAnswer4)
            {
                Label4.Text = ("Correct");
            }
            else
            {
                Label4.Text = ("Incorrect");
            }
            if (dividingNumber * 5 == txtBoxAnswer5)
            {
                Label5.Text = ("Correct");
            }
            else
            {
                Label5.Text = ("Incorrect");
            }
            if (dividingNumber * 6 == txtBoxAnswer6)
            {
                Label6.Text = ("Correct");
            }
            else
            {
                Label6.Text = ("Incorrect");
            }
            if (dividingNumber * 7 == txtBoxAnswer7)
            {
                Label7.Text = ("Correct");
            }
            else
            {
                Label7.Text = ("Incorrect");
            }
            if (dividingNumber * 8 == txtBoxAnswer8)
            {
                Label8.Text = ("Correct");
            }
            else
            {
                Label8.Text = ("Incorrect");
            }
            if (dividingNumber * 9 == txtBoxAnswer9)
            {
                Label9.Text = ("Correct");
            }
            else
            {
                Label9.Text = ("Incorrect");
            }
            if (dividingNumber * 10 == txtBoxAnswer10)
            {
                Label10.Text = ("Correct");
            }
            else
            {
                Label10.Text = ("Incorrect");
            }
            if (dividingNumber * 11 == txtBoxAnswer11)
            {
                Label11.Text = ("Correct");
            }
            else
            {
                Label11.Text = ("Incorrect");
            }
            if (dividingNumber * 12 == txtBoxAnswer12)
            {
                Label12.Text = ("Correct");
            }
            else
            {
                Label12.Text = ("Incorrect");
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
            if (dividingNumber * 4 / dividingNumber == txtBoxAnswer4)
            {
                Label4.Text = ("Correct");
            }
            else
            {
                Label4.Text = ("Incorrect");
            }
            if (dividingNumber * 5 / dividingNumber == txtBoxAnswer5)
            {
                Label5.Text = ("Correct");
            }
            else
            {
                Label5.Text = ("Incorrect");
            }
            if (dividingNumber * 6 / dividingNumber == txtBoxAnswer6)
            {
                Label6.Text = ("Correct");
            }
            else
            {
                Label6.Text = ("Incorrect");
            }
            if (dividingNumber * 7 / dividingNumber == txtBoxAnswer7)
            {
                Label7.Text = ("Correct");
            }
            else
            {
                Label7.Text = ("Incorrect");
            }
            if (dividingNumber * 8 / dividingNumber == txtBoxAnswer8)
            {
                Label8.Text = ("Correct");
            }
            else
            {
                Label8.Text = ("Incorrect");
            }
            if (dividingNumber * 9 / dividingNumber == txtBoxAnswer9)
            {
                Label9.Text = ("Correct");
            }
            else
            {
                Label9.Text = ("Incorrect");
            }
            if (dividingNumber * 10 / dividingNumber == txtBoxAnswer10)
            {
                Label10.Text = ("Correct");
            }
            else
            {
                Label10.Text = ("Incorrect");
            }
            if (dividingNumber * 11 / dividingNumber == txtBoxAnswer11)
            {
                Label11.Text = ("Correct");
            }
            else
            {
                Label11.Text = ("Incorrect");
            }
            if (dividingNumber * 12 / dividingNumber == txtBoxAnswer12)
            {
                Label12.Text = ("Correct");
            }
            else
            {
                Label12.Text = ("Incorrect");
            }
        }
            if (Label1.Text == "Correct" )
        {
            counter = counter + 1;
            qAnswer1 = "Correct";
        }
        else
        {
            qAnswer1 = "Incorrect";
        }
        if (Label2.Text == "Correct")
        {
            counter = counter + 1;
            qAnswer2 = "Correct";
        }
        else
        {
            qAnswer2 = "Incorrect";
        }
        if (Label3.Text == "Correct")
        {
            counter = counter + 1;
            qAnswer3 = "Correct";
        }
        else
        {
            qAnswer3 = "Incorrect";
        }
        if (Label4.Text == "Correct")
        {
            counter = counter + 1;
            qAnswer4 = "Correct";
        }
        else
        {
            qAnswer4 = "Incorrect";
        }
        if (Label5.Text == "Correct")
        {
            counter = counter + 1;
            qAnswer5 = "Correct";
        }
        else
        {
            qAnswer5 = "Incorrect";
        }
        if (Label6.Text == "Correct")
        {
            counter = counter + 1;
            qAnswer6 = "Correct";
        }
        else
        {
            qAnswer6 = "Incorrect";
        }
        if (Label7.Text == "Correct")
        {
            counter = counter + 1;
            qAnswer7 = "Correct";
        }
        else
        {
            qAnswer7 = "Incorrect";
        }
        if (Label8.Text == "Correct")
        {
            counter = counter + 1;
            qAnswer8 = "Correct";
        }
        else
        {
            qAnswer8 = "Incorrect";
        }
        if (Label9.Text == "Correct")
        {
            counter = counter + 1;
            qAnswer9 = "Correct";
        }
        else
        {
            qAnswer9 = "Incorrect";
        }
        if (Label10.Text == "Correct")
        {
            counter = counter + 1;
            qAnswer10 = "Correct";
        }
        else
        {
            qAnswer10 = "Incorrect";
        }
        if (Label11.Text == "Correct")
        {
            counter = counter + 1;
            qAnswer11 = "Correct";
        }
        else
        {
            qAnswer11 = "Incorrect";
        }
        if (Label12.Text == "Correct")
        {
            counter = counter + 1;
            qAnswer12 = "Correct";
        }
        else
        {
            qAnswer12 = "Incorrect";
        }

        lblCounter.Text = counter + "/12";
        strTimeTaken = lblTimeTaken.Text;


        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "insert into tablesScores(UserId, Score, Operation, OperatorNumber, TimeTaken, " +"Date , Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, Q10, Q11, Q12) values ("+ User.Identity.GetUserId() +" ,"+ counter +", "+ strMode +", "+ dividingNumber +", NULL , GETDATE(),'"+ qAnswer1 + ",'" + qAnswer2 + "','" + qAnswer3 + "','" + qAnswer4 + "','" + qAnswer5 + "','" + qAnswer6 + "','" + qAnswer7 + "','" + qAnswer8 + "','" + qAnswer9 + "','" + qAnswer10 + "','" + qAnswer11 + "','" + qAnswer12 + "');";
        cmd.ExecuteNonQuery();
        con.Close();
    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void TextBox3_TextChanged(object sender, EventArgs e)
    {

    }
}