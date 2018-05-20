using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


public partial class TablesPage : System.Web.UI.Page
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
    int MyNumber = 0;
    int answer1 = 0;
    int answer2 = 0;
    int answer3 = 0;
    int answer4 = 0;
    int answer5 = 0;
    int answer6 = 0;
    int answer7 = 0;
    int answer8 = 0;
    int answer9 = 0;
    int answer10 = 0;
    int answer11 = 0;
    int answer12 = 0;
    int ListItem1 = 0;
    int ListItem2 = 0;
    int ListItem3 = 0;
    int ListItem4 = 0;
    int ListItem5 = 0;
    int ListItem6 = 0;
    int ListItem7 = 0;
    int ListItem8 = 0;
    int ListItem9 = 0;
    int ListItem10 = 0;
    int ListItem11 = 0;
    int ListItem12 = 0;
    decimal timeTaken2 = 0;
    int dividingNumber = 0;
    int ifSymbol = 0;



    SqlConnection con = new SqlConnection(@"Data Source=IESURFACEPRO2A\SQLEXPRESS;Initial Catalog=MaximGame;Integrated Security=True");

    public List<int> randomList = new List<int>();

    protected void Page_Load(object sender, EventArgs e)
    {
        Random randomizer = new Random();
        String strMode = Request.QueryString["mode"];
        String strNumber = Request.QueryString["number"];
        if (strMode == null)
        {
            strMode = "M";
            strNumber = "1";
        }

        int dividingNumber = 0;

        dividingNumber = Convert.ToInt32(strNumber);


        if (!IsPostBack)
        {
            imgAnswer1.Visible = false;
            imgAnswer2.Visible = false;
            imgAnswer3.Visible = false;
            imgAnswer4.Visible = false;
            imgAnswer5.Visible = false;
            imgAnswer6.Visible = false;
            imgAnswer7.Visible = false;
            imgAnswer8.Visible = false;
            imgAnswer9.Visible = false;
            imgAnswer10.Visible = false;
            imgAnswer11.Visible = false;
            imgAnswer12.Visible = false;
            GoldMedal.Visible = false;
            SilverMedal.Visible = false;
            over12.Visible = false;

            while (randomList.Count < 12)
            {
                //If Mode is subtraction
                if (strMode == "S")
                {
                    MyNumber = randomizer.Next(dividingNumber, dividingNumber + 12);
                    if (!randomList.Contains(MyNumber))
                    {
                        randomList.Add(MyNumber);
                    }
                }
                //If Mode is Division
                else if (strMode == "D")
                {
                    MyNumber = randomizer.Next(1, 13) * dividingNumber;
                    if (!randomList.Contains(MyNumber))
                    {
                        randomList.Add(MyNumber);
                    }
                }
                //If Mode is Anything else  (i.e. Add or Multiply)
                else
                {
                    MyNumber = randomizer.Next(1, 13);
                    if (!randomList.Contains(MyNumber))
                    {
                        randomList.Add(MyNumber);
                    }
                }


            }
            {


                lblNo1A.Text = randomList[0].ToString();
                lblNo2A.Text = randomList[1].ToString();
                lblNo3A.Text = randomList[2].ToString();
                lblNo4A.Text = randomList[3].ToString();
                lblNo5A.Text = randomList[4].ToString();
                lblNo6A.Text = randomList[5].ToString();
                lblNo7A.Text = randomList[6].ToString();
                lblNo8A.Text = randomList[7].ToString();
                lblNo9A.Text = randomList[8].ToString();
                lblNo10A.Text = randomList[9].ToString();
                lblNo11A.Text = randomList[10].ToString();
                lblNo12A.Text = randomList[11].ToString();

                lblNo1B.Text = strNumber;
                lblNo2B.Text = strNumber;
                lblNo3B.Text = strNumber;
                lblNo4B.Text = strNumber;
                lblNo5B.Text = strNumber;
                lblNo6B.Text = strNumber;
                lblNo7B.Text = strNumber;
                lblNo8B.Text = strNumber;
                lblNo9B.Text = strNumber;
                lblNo10B.Text = strNumber;
                lblNo11B.Text = strNumber;
                lblNo12B.Text = strNumber;

                if (lblNo1A.Text != "10"|| lblNo1A.Text != "11" || lblNo1A.Text != "12")
                {

                }


                if (strMode == "A")
                {
                    lbl1Op.Text = "+";
                    lbl2Op.Text = "+";
                    lbl3Op.Text = "+";
                    lbl4Op.Text = "+";
                    lbl5Op.Text = "+";
                    lbl6Op.Text = "+";
                    lbl7Op.Text = "+";
                    lbl8Op.Text = "+";
                    lbl9Op.Text = "+";
                    lbl10Op.Text = "+";
                    lbl11Op.Text = "+";
                    lbl12Op.Text = "+";
                    //Label1x1.Text = strNumber + " + 1 =";
                    //Label1x2.Text = strNumber + " + 2 =";
                    //Label1x3.Text = strNumber + " + 3 =";
                    //Label1x4.Text = strNumber + " + 4 =";
                    //Label1x5.Text = strNumber + " + 5 =";
                    //Label1x6.Text = strNumber + " + 6 =";
                    //Label1x7.Text = strNumber + " + 7 =";
                    //Label1x8.Text = strNumber + " + 8 =";
                    //Label1x9.Text = strNumber + " + 9 =";
                    //Label1x10.Text = strNumber + " + 10 =";
                    //Label1x11.Text = strNumber + " + 11 =";
                    //Label1x12.Text = strNumber + " + 12 =";
                }
                if (strMode == "S")
                {
                    lbl1Op.Text = "-";
                    lbl2Op.Text = "-";
                    lbl3Op.Text = "-";
                    lbl4Op.Text = "-";
                    lbl5Op.Text = "-";
                    lbl6Op.Text = "-";
                    lbl7Op.Text = "-";
                    lbl8Op.Text = "-";
                    lbl9Op.Text = "-";
                    lbl10Op.Text = "-";
                    lbl11Op.Text = "-";
                    lbl12Op.Text = "-";
                    //Label1x1.Text = strNumber + " - 1 =";
                    //Label1x2.Text = strNumber + " - 2 =";
                    //Label1x3.Text = strNumber + " - 3 =";
                    //Label1x4.Text = strNumber + " - 4 =";
                    //Label1x5.Text = strNumber + " - 5 =";
                    //Label1x6.Text = strNumber + " - 6 =";
                    //Label1x7.Text = strNumber + " - 7 =";
                    //Label1x8.Text = strNumber + " - 8 =";
                    //Label1x9.Text = strNumber + " - 9 =";
                    //Label1x10.Text = strNumber + " - 10 =";
                    //Label1x11.Text = strNumber + " - 11 =";
                    //Label1x12.Text = strNumber + " - 12 =";
                }
                if (strMode == "D")
                {
                    lbl1Op.Text = "÷";
                    lbl2Op.Text = "÷";
                    lbl3Op.Text = "÷";
                    lbl4Op.Text = "÷";
                    lbl5Op.Text = "÷";
                    lbl6Op.Text = "÷";
                    lbl7Op.Text = "÷";
                    lbl8Op.Text = "÷";
                    lbl9Op.Text = "÷";
                    lbl10Op.Text = "÷";
                    lbl11Op.Text = "÷";
                    lbl12Op.Text = "÷";
                    //dividingNumber = Convert.ToInt32(strNumber);
                    //Label1x1.Text = dividingNumber * 1 + " ÷ " + strNumber + "=";
                    //Label1x2.Text = dividingNumber * 2 + " ÷ " + strNumber + " =";
                    //Label1x3.Text = dividingNumber * 3 + " ÷ " + strNumber + " =";
                    //Label1x4.Text = dividingNumber * 4 + " ÷ " + strNumber + " =";
                    //Label1x5.Text = dividingNumber * 5 + " ÷ " + strNumber + " =";
                    //Label1x6.Text = dividingNumber * 6 + " ÷ " + strNumber + " =";
                    //Label1x7.Text = dividingNumber * 7 + " ÷ " + strNumber + " =";
                    //Label1x8.Text = dividingNumber * 8 + " ÷ " + strNumber + " =";
                    //Label1x9.Text = dividingNumber * 9 + " ÷ " + strNumber + " =";
                    //Label1x10.Text = dividingNumber * 10 + " ÷ " + strNumber + " =";
                    //Label1x11.Text = dividingNumber * 11 + " ÷ " + strNumber + " =";
                    //Label1x12.Text = dividingNumber * 12 + " ÷ " + strNumber + " =";
                }
                if (strMode == "M")
                {
                    lbl1Op.Text = "×";
                    lbl2Op.Text = "×";
                    lbl3Op.Text = "×";
                    lbl4Op.Text = "×";
                    lbl5Op.Text = "×";
                    lbl6Op.Text = "×";
                    lbl7Op.Text = "×";
                    lbl8Op.Text = "×";
                    lbl9Op.Text = "×";
                    lbl10Op.Text = "×";
                    lbl11Op.Text = "×";
                    lbl12Op.Text = "×";
                    //Label1x1.Text = strNumber + " ×  1 =";
                    //Label1x2.Text = strNumber + " ×  2 =";
                    //Label1x3.Text = strNumber + " ×  3 =";
                    //Label1x4.Text = strNumber + " ×  4 =";
                    //Label1x5.Text = strNumber + " ×  5 =";
                    //Label1x6.Text = strNumber + " ×  6 =";
                    //Label1x7.Text = strNumber + " ×  7 =";
                    //Label1x8.Text = strNumber + " ×  8 =";
                    //Label1x9.Text = strNumber + " ×  9 =";
                    //Label1x10.Text = strNumber + " ×  10 =";
                    //Label1x11.Text = strNumber + " ×  11 =";
                    //Label1x12.Text = strNumber + " ×  12 =";
                }
            }








            if (strMode == "A")
            {
                lbl1Op.Text = "+";
                lbl2Op.Text = "+";
                lbl3Op.Text = "+";
                lbl4Op.Text = "+";
                lbl5Op.Text = "+";
                lbl6Op.Text = "+";
                lbl7Op.Text = "+";
                lbl8Op.Text = "+";
                lbl9Op.Text = "+";
                lbl10Op.Text = "+";
                lbl11Op.Text = "+";
                lbl12Op.Text = "+";
                //Label1x1.Text = strNumber + " + 1 =";
                //Label1x2.Text = strNumber + " + 2 =";
                //Label1x3.Text = strNumber + " + 3 =";
                //Label1x4.Text = strNumber + " + 4 =";
                //Label1x5.Text = strNumber + " + 5 =";
                //Label1x6.Text = strNumber + " + 6 =";
                //Label1x7.Text = strNumber + " + 7 =";
                //Label1x8.Text = strNumber + " + 8 =";
                //Label1x9.Text = strNumber + " + 9 =";
                //Label1x10.Text = strNumber + " + 10 =";
                //Label1x11.Text = strNumber + " + 11 =";
                //Label1x12.Text = strNumber + " + 12 =";
            }
            if (strMode == "S")
            {
                lbl1Op.Text = "-";
                lbl2Op.Text = "-";
                lbl3Op.Text = "-";
                lbl4Op.Text = "-";
                lbl5Op.Text = "-";
                lbl6Op.Text = "-";
                lbl7Op.Text = "-";
                lbl8Op.Text = "-";
                lbl9Op.Text = "-";
                lbl10Op.Text = "-";
                lbl11Op.Text = "-";
                lbl12Op.Text = "-";
                //Label1x1.Text = strNumber + " - 1 =";
                //Label1x2.Text = strNumber + " - 2 =";
                //Label1x3.Text = strNumber + " - 3 =";
                //Label1x4.Text = strNumber + " - 4 =";
                //Label1x5.Text = strNumber + " - 5 =";
                //Label1x6.Text = strNumber + " - 6 =";
                //Label1x7.Text = strNumber + " - 7 =";
                //Label1x8.Text = strNumber + " - 8 =";
                //Label1x9.Text = strNumber + " - 9 =";
                //Label1x10.Text = strNumber + " - 10 =";
                //Label1x11.Text = strNumber + " - 11 =";
                //Label1x12.Text = strNumber + " - 12 =";
            }
            if (strMode == "D")
            {
                lbl1Op.Text = "÷";
                lbl2Op.Text = "÷";
                lbl3Op.Text = "÷";
                lbl4Op.Text = "÷";
                lbl5Op.Text = "÷";
                lbl6Op.Text = "÷";
                lbl7Op.Text = "÷";
                lbl8Op.Text = "÷";
                lbl9Op.Text = "÷";
                lbl10Op.Text = "÷";
                lbl11Op.Text = "÷";
                lbl12Op.Text = "÷";
                //dividingNumber = Convert.ToInt32(strNumber);
                //Label1x1.Text = dividingNumber * 1 + " ÷ " + strNumber + "=";
                //Label1x2.Text = dividingNumber * 2 + " ÷ " + strNumber + " =";
                //Label1x3.Text = dividingNumber * 3 + " ÷ " + strNumber + " =";
                //Label1x4.Text = dividingNumber * 4 + " ÷ " + strNumber + " =";
                //Label1x5.Text = dividingNumber * 5 + " ÷ " + strNumber + " =";
                //Label1x6.Text = dividingNumber * 6 + " ÷ " + strNumber + " =";
                //Label1x7.Text = dividingNumber * 7 + " ÷ " + strNumber + " =";
                //Label1x8.Text = dividingNumber * 8 + " ÷ " + strNumber + " =";
                //Label1x9.Text = dividingNumber * 9 + " ÷ " + strNumber + " =";
                //Label1x10.Text = dividingNumber * 10 + " ÷ " + strNumber + " =";
                //Label1x11.Text = dividingNumber * 11 + " ÷ " + strNumber + " =";
                //Label1x12.Text = dividingNumber * 12 + " ÷ " + strNumber + " =";
            }
            if (strMode == "M")
            {
                lbl1Op.Text = "×";
                lbl2Op.Text = "×";
                lbl3Op.Text = "×";
                lbl4Op.Text = "×";
                lbl5Op.Text = "×";
                lbl6Op.Text = "×";
                lbl7Op.Text = "×";
                lbl8Op.Text = "×";
                lbl9Op.Text = "×";
                lbl10Op.Text = "×";
                lbl11Op.Text = "×";
                lbl12Op.Text = "×";
                //Label1x1.Text = strNumber + " ×  1 =";
                //Label1x2.Text = strNumber + " ×  2 =";
                //Label1x3.Text = strNumber + " ×  3 =";
                //Label1x4.Text = strNumber + " ×  4 =";
                //Label1x5.Text = strNumber + " ×  5 =";
                //Label1x6.Text = strNumber + " ×  6 =";
                //Label1x7.Text = strNumber + " ×  7 =";
                //Label1x8.Text = strNumber + " ×  8 =";
                //Label1x9.Text = strNumber + " ×  9 =";
                //Label1x10.Text = strNumber + " ×  10 =";
                //Label1x11.Text = strNumber + " ×  11 =";
                //Label1x12.Text = strNumber + " ×  12 =";
            }

        }

        if(IsPostBack)
        {
            imgAnswer1.Visible = true;
            imgAnswer2.Visible = true;
            imgAnswer3.Visible = true;
            imgAnswer4.Visible = true;
            imgAnswer5.Visible = true;
            imgAnswer6.Visible = true;
            imgAnswer7.Visible = true;
            imgAnswer8.Visible = true;
            imgAnswer9.Visible = true;
            imgAnswer10.Visible = true;
            imgAnswer11.Visible = true;
            imgAnswer12.Visible = true;
        }

        //void Multiply()
        //{
        //}

        ////protected void Button2_Click(object sender, EventArgs e)
        ////{
        ////    String strMode = Request.QueryString["mode"];
        ////    String strNumber = Request.QueryString["number"];


        ////    Convert.ToInt32(strNumber);



        ////    dividingNumber = Convert.ToInt32(strNumber);
        ////    txtBoxAnswer = Convert.ToInt32(TextBox1.Text);
        ////    txtBoxAnswer2 = Convert.ToInt32(TextBox2.Text);
        ////    txtBoxAnswer3 = Convert.ToInt32(TextBox3.Text);
        ////    txtBoxAnswer4 = Convert.ToInt32(TextBox4.Text);
        ////    txtBoxAnswer5 = Convert.ToInt32(TextBox5.Text);
        ////    txtBoxAnswer6 = Convert.ToInt32(TextBox6.Text);
        ////    txtBoxAnswer7 = Convert.ToInt32(TextBox7.Text);
        ////    txtBoxAnswer8 = Convert.ToInt32(TextBox8.Text);
        ////    txtBoxAnswer9 = Convert.ToInt32(TextBox12.Text);
        ////    txtBoxAnswer10 = Convert.ToInt32(TextBox9.Text);
        ////    txtBoxAnswer11 = Convert.ToInt32(TextBox10.Text);
        ////    txtBoxAnswer12 = Convert.ToInt32(TextBox11.Text);



        ////    if (strMode == "A")
        ////    {

        ////        if (dividingNumber + 1 == txtBoxAnswer)
        ////        {
        ////            Label1.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label1.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber + 2 == txtBoxAnswer2)
        ////        {
        ////            Label2.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label2.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber + 3 == txtBoxAnswer3)
        ////        {
        ////            Label3.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label3.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber + 4 == txtBoxAnswer4)
        ////        {
        ////            Label4.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label4.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber + 5 == txtBoxAnswer5)
        ////        {
        ////            Label5.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label5.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber + 6 == txtBoxAnswer6)
        ////        {
        ////            Label6.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label6.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber + 7 == txtBoxAnswer7)
        ////        {
        ////            Label7.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label7.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber + 8 == txtBoxAnswer8)
        ////        {
        ////            Label8.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label8.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber + 9 == txtBoxAnswer9)
        ////        {
        ////            Label9.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label9.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber + 10 == txtBoxAnswer10)
        ////        {
        ////            Label10.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label10.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber + 11 == txtBoxAnswer11)
        ////        {
        ////            Label11.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label11.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber + 12 == txtBoxAnswer12)
        ////        {
        ////            Label12.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label12.Text = ("Incorrect");
        ////        }
        ////    }

        ////    if (strMode == "S")
        ////    {
        ////        dividingNumber = Convert.ToInt32(strNumber);
        ////        if (dividingNumber - 1 == txtBoxAnswer)
        ////        {
        ////            Label1.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label1.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber - 2 == txtBoxAnswer2)
        ////        {
        ////            Label2.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label2.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber - 3 == txtBoxAnswer)
        ////        {
        ////            Label3.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label3.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber - 4 == txtBoxAnswer4)
        ////        {
        ////            Label4.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label4.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber - 5 == txtBoxAnswer5)
        ////        {
        ////            Label5.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label5.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber - 6 == txtBoxAnswer6)
        ////        {
        ////            Label6.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label6.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber - 7 == txtBoxAnswer7)
        ////        {
        ////            Label7.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label7.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber - 8 == txtBoxAnswer8)
        ////        {
        ////            Label8.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label8.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber - 9 == txtBoxAnswer9)
        ////        {
        ////            Label9.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label9.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber - 10 == txtBoxAnswer10)
        ////        {
        ////            Label10.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label10.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber - 11 == txtBoxAnswer11)
        ////        {
        ////            Label11.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label11.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber - 12 == txtBoxAnswer12)
        ////        {
        ////            Label12.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label12.Text = ("Incorrect");
        ////        }
        ////    }

        ////    if (strMode == "M")
        ////    {
        ////        dividingNumber = Convert.ToInt32(strNumber);
        ////        if (dividingNumber * 1 == txtBoxAnswer)
        ////        {
        ////            Label1.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label1.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber * 2 == txtBoxAnswer2)
        ////        {
        ////            Label2.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label2.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber * 3 == txtBoxAnswer)
        ////        {
        ////            Label3.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label3.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber * 4 == txtBoxAnswer4)
        ////        {
        ////            Label4.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label4.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber * 5 == txtBoxAnswer5)
        ////        {
        ////            Label5.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label5.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber * 6 == txtBoxAnswer6)
        ////        {
        ////            Label6.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label6.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber * 7 == txtBoxAnswer7)
        ////        {
        ////            Label7.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label7.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber * 8 == txtBoxAnswer8)
        ////        {
        ////            Label8.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label8.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber * 9 == txtBoxAnswer9)
        ////        {
        ////            Label9.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label9.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber * 10 == txtBoxAnswer10)
        ////        {
        ////            Label10.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label10.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber * 11 == txtBoxAnswer11)
        ////        {
        ////            Label11.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label11.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber * 12 == txtBoxAnswer12)
        ////        {
        ////            Label12.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label12.Text = ("Incorrect");
        ////        }
        ////    }

        ////    if (strMode == "D")
        ////    {
        ////        dividingNumber = Convert.ToInt32(strNumber);
        ////        if (dividingNumber * 1 / dividingNumber == txtBoxAnswer)
        ////        {
        ////            Label1.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label1.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber * 2 / dividingNumber == txtBoxAnswer2)
        ////        {
        ////            Label2.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label2.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber * 3 / dividingNumber == txtBoxAnswer3)
        ////        {
        ////            Label3.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label3.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber * 4 / dividingNumber == txtBoxAnswer4)
        ////        {
        ////            Label4.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label4.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber * 5 / dividingNumber == txtBoxAnswer5)
        ////        {
        ////            Label5.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label5.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber * 6 / dividingNumber == txtBoxAnswer6)
        ////        {
        ////            Label6.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label6.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber * 7 / dividingNumber == txtBoxAnswer7)
        ////        {
        ////            Label7.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label7.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber * 8 / dividingNumber == txtBoxAnswer8)
        ////        {
        ////            Label8.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label8.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber * 9 / dividingNumber == txtBoxAnswer9)
        ////        {
        ////            Label9.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label9.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber * 10 / dividingNumber == txtBoxAnswer10)
        ////        {
        ////            Label10.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label10.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber * 11 / dividingNumber == txtBoxAnswer11)
        ////        {
        ////            Label11.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label11.Text = ("Incorrect");
        ////        }
        ////        if (dividingNumber * 12 / dividingNumber == txtBoxAnswer12)
        ////        {
        ////            Label12.Text = ("Correct");
        ////        }
        ////        else
        ////        {
        ////            Label12.Text = ("Incorrect");
        ////        }
        ////    }
        ////    if (Label1.Text == "Correct")
        ////    {
        ////        counter = counter + 1;
        ////        qAnswer1 = "Correct";
        ////    }
        ////    else
        ////    {
        ////        qAnswer1 = "Incorrect";
        ////    }
        ////    if (Label2.Text == "Correct")
        ////    {
        ////        counter = counter + 1;
        ////        qAnswer2 = "Correct";
        ////    }
        ////    else
        ////    {
        ////        qAnswer2 = "Incorrect";
        ////    }
        ////    if (Label3.Text == "Correct")
        ////    {
        ////        counter = counter + 1;
        ////        qAnswer3 = "Correct";
        ////    }
        ////    else
        ////    {
        ////        qAnswer3 = "Incorrect";
        ////    }
        ////    if (Label4.Text == "Correct")
        ////    {
        ////        counter = counter + 1;
        ////        qAnswer4 = "Correct";
        ////    }
        ////    else
        ////    {
        ////        qAnswer4 = "Incorrect";
        ////    }
        ////    if (Label5.Text == "Correct")
        ////    {
        ////        counter = counter + 1;
        ////        qAnswer5 = "Correct";
        ////    }
        ////    else
        ////    {
        ////        qAnswer5 = "Incorrect";
        ////    }
        ////    if (Label6.Text == "Correct")
        ////    {
        ////        counter = counter + 1;
        ////        qAnswer6 = "Correct";
        ////    }
        ////    else
        ////    {
        ////        qAnswer6 = "Incorrect";
        ////    }
        ////    if (Label7.Text == "Correct")
        ////    {
        ////        counter = counter + 1;
        ////        qAnswer7 = "Correct";
        ////    }
        ////    else
        ////    {
        ////        qAnswer7 = "Incorrect";
        ////    }
        ////    if (Label8.Text == "Correct")
        ////    {
        ////        counter = counter + 1;
        ////        qAnswer8 = "Correct";
        ////    }
        ////    else
        ////    {
        ////        qAnswer8 = "Incorrect";
        ////    }
        ////    if (Label9.Text == "Correct")
        ////    {
        ////        counter = counter + 1;
        ////        qAnswer9 = "Correct";
        ////    }
        ////    else
        ////    {
        ////        qAnswer9 = "Incorrect";
        ////    }
        ////    if (Label10.Text == "Correct")
        ////    {
        ////        counter = counter + 1;
        ////        qAnswer10 = "Correct";
        ////    }
        ////    else
        ////    {
        ////        qAnswer10 = "Incorrect";
        ////    }
        ////    if (Label11.Text == "Correct")
        ////    {
        ////        counter = counter + 1;
        ////        qAnswer11 = "Correct";
        ////    }
        ////    else
        ////    {
        ////        qAnswer11 = "Incorrect";
        ////    }
        ////    if (Label12.Text == "Correct")
        ////    {
        ////        counter = counter + 1;
        ////        qAnswer12 = "Correct";
        ////    }
        ////    else
        ////    {
        ////        qAnswer12 = "Incorrect";
        ////    }

        ////    lblCounter.Text = counter + "/12";
        ////    strTimeTaken = lblTimeTaken.Text;


        ////    con.Open();
        ////    SqlCommand cmd = con.CreateCommand();
        ////    cmd.CommandType = CommandType.Text;
        ////    cmd.CommandText = "insert into tablesScores(UserId, Score, Operation, OperatorNumber, TimeTaken, " + "Date , Q1, Q2, Q3, Q4, Q5, Q6, Q7, Q8, Q9, Q10, Q11, Q12) values (" + User.Identity.GetUserId() + " ," + counter + ", " + strMode + ", " + dividingNumber + ", NULL , GETDATE(),'" + qAnswer1 + ",'" + qAnswer2 + "','" + qAnswer3 + "','" + qAnswer4 + "','" + qAnswer5 + "','" + qAnswer6 + "','" + qAnswer7 + "','" + qAnswer8 + "','" + qAnswer9 + "','" + qAnswer10 + "','" + qAnswer11 + "','" + qAnswer12 + "');";
        ////    cmd.ExecuteNonQuery();
        ////    con.Close();
        ////}



    }


    protected void Button1_Click(object sender, EventArgs e)
    {
        var isNumeric1 = int.TryParse(txtAns1.Text, out int answer1);
        var isNumeric2 = int.TryParse(txtAns2.Text, out int answer2);
        var isNumeric3 = int.TryParse(txtAns3.Text, out int answer3);
        var isNumeric4 = int.TryParse(txtAns4.Text, out int answer4);
        var isNumeric5 = int.TryParse(txtAns5.Text, out int answer5);
        var isNumeric6 = int.TryParse(txtAns6.Text, out int answer6);
        var isNumeric7 = int.TryParse(txtAns7.Text, out int answer7);
        var isNumeric8 = int.TryParse(txtAns8.Text, out int answer8);
        var isNumeric9 = int.TryParse(txtAns9.Text, out int answer9);
        var isNumeric10 = int.TryParse(txtAns10.Text, out int answer10);
        var isNumeric11 = int.TryParse(txtAns11.Text, out int answer11);
        var isNumeric12 = int.TryParse(txtAns12.Text, out int answer12);


        String strMode = Request.QueryString["mode"];
        String strNumber = Request.QueryString["number"];
        dividingNumber = Convert.ToInt32(strNumber);

        //answer1 = Convert.ToInt32(txtAns1.Text);
        //answer2 = Convert.ToInt32(txtAns2.Text);
        //answer3 = Convert.ToInt32(txtAns3.Text);
        //answer4 = Convert.ToInt32(txtAns4.Text);
        //answer5 = Convert.ToInt32(txtAns5.Text);
        //answer6 = Convert.ToInt32(txtAns6.Text);
        //answer7 = Convert.ToInt32(txtAns7.Text);
        //answer8 = Convert.ToInt32(txtAns8.Text);
        //answer9 = Convert.ToInt32(txtAns9.Text);
        //answer10 = Convert.ToInt32(txtAns10.Text);
        //answer11 = Convert.ToInt32(txtAns11.Text);
        //answer12 = Convert.ToInt32(txtAns12.Text);

        ListItem1 = Convert.ToInt32(lblNo1A.Text);
        ListItem2 = Convert.ToInt32(lblNo2A.Text);
        ListItem3 = Convert.ToInt32(lblNo3A.Text);
        ListItem4 = Convert.ToInt32(lblNo4A.Text);
        ListItem5 = Convert.ToInt32(lblNo5A.Text);
        ListItem6 = Convert.ToInt32(lblNo6A.Text);
        ListItem7 = Convert.ToInt32(lblNo7A.Text);
        ListItem8 = Convert.ToInt32(lblNo8A.Text);
        ListItem9 = Convert.ToInt32(lblNo9A.Text);
        ListItem10 = Convert.ToInt32(lblNo10A.Text);
        ListItem11 = Convert.ToInt32(lblNo11A.Text);
        ListItem12 = Convert.ToInt32(lblNo12A.Text);
        { 
        if (txtAns1.Text == null || txtAns2.Text == null || txtAns3.Text == null || txtAns4.Text == null || txtAns5.Text == null || txtAns6.Text == null || txtAns7.Text == null || txtAns8.Text == null || txtAns9.Text == null || txtAns10.Text == null || txtAns11.Text == null || txtAns12.Text == null)
        {
            if (txtAns1.Text == null)
            {
                imgAnswer1.ImageUrl = "/Image/IncorrectMascot.png";
            }
            if (txtAns2.Text == null)
            {
                imgAnswer1.ImageUrl = "/Image/IncorrectMascot.png";
            }
            if (txtAns3.Text == null)
            {
                imgAnswer1.ImageUrl = "/Image/IncorrectMascot.png";
            }
            if (txtAns4.Text == null)
            {
                imgAnswer1.ImageUrl = "/Image/IncorrectMascot.png";
            }
            if (txtAns5.Text == null)
            {
                imgAnswer1.ImageUrl = "/Image/IncorrectMascot.png";
            }
            if (txtAns6.Text == null)
            {
                imgAnswer1.ImageUrl = "/Image/IncorrectMascot.png";
            }
            if (txtAns7.Text == null)
            {
                imgAnswer1.ImageUrl = "/Image/IncorrectMascot.png";
            }
            if (txtAns8.Text == null)
            {
                imgAnswer1.ImageUrl = "/Image/IncorrectMascot.png";
            }
            if (txtAns9.Text == null)
            {
                imgAnswer1.ImageUrl = "/Image/IncorrectMascot.png";
            }
            if (txtAns10.Text == null)
            {
                imgAnswer1.ImageUrl = "/Image/IncorrectMascot.png";
            }
            if (txtAns11.Text == null)
            {
                imgAnswer1.ImageUrl = "/Image/IncorrectMascot.png";
            }
            if (txtAns12.Text == null)
            {
                imgAnswer1.ImageUrl = "/Image/IncorrectMascot.png";
            }
            else
            {
                if (isNumeric1 == false || isNumeric2 == false || isNumeric3 == false || isNumeric4 == false || isNumeric5 == false || isNumeric6 == false || isNumeric7 == false || isNumeric8 == false || isNumeric9 == false || isNumeric10 == false || isNumeric11 == false || isNumeric12 == false)
                {
                    if (isNumeric1 == false)
                    {
                        imgAnswer1.ImageUrl = "/Image/IncorrectMascot.png";
                    }
                    if (isNumeric2 == false)
                    {
                        imgAnswer1.ImageUrl = "/Image/IncorrectMascot.png";
                    }
                    if (isNumeric3 == false)
                    {
                        imgAnswer1.ImageUrl = "/Image/IncorrectMascot.png";
                    }
                    if (isNumeric4 == false)
                    {
                        imgAnswer1.ImageUrl = "/Image/IncorrectMascot.png";
                    }
                    if (isNumeric5 == false)
                    {
                        imgAnswer1.ImageUrl = "/Image/IncorrectMascot.png";
                    }
                    if (isNumeric6 == false)
                    {
                        imgAnswer1.ImageUrl = "/Image/IncorrectMascot.png";
                    }
                    if (isNumeric7 == false)
                    {
                        imgAnswer1.ImageUrl = "/Image/IncorrectMascot.png";
                    }
                    if (isNumeric8 == false)
                    {
                        imgAnswer1.ImageUrl = "/Image/IncorrectMascot.png";
                    }
                    if (isNumeric9 == false)
                    {
                        imgAnswer1.ImageUrl = "/Image/IncorrectMascot.png";
                    }
                    if (isNumeric10 == false)
                    {
                        imgAnswer1.ImageUrl = "/Image/IncorrectMascot.png";
                    }
                    if (isNumeric11 == false)
                    {
                        imgAnswer1.ImageUrl = "/Image/IncorrectMascot.png";
                    }
                    if (isNumeric12 == false)
                    {
                        imgAnswer1.ImageUrl = "/Image/IncorrectMascot.png";
                    }
                }
            }
        }

        else
        {
            if (strMode == "A")
            {
                if (answer1 == ListItem1 + dividingNumber)
                {
                    imgAnswer1.Visible = true;
                    Label1.Text = "Correct";
                    imgAnswer1.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label1.Text = "Incorrect";
                    imgAnswer1.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer2 == ListItem2 + dividingNumber)
                {
                    Label2.Text = "Correct";
                    imgAnswer2.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label2.Text = "Incorrect";
                    imgAnswer2.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer3 == ListItem3 + dividingNumber)
                {
                    Label3.Text = "Correct";
                    imgAnswer3.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label3.Text = "Incorrect";
                    imgAnswer3.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer4 == ListItem4 + dividingNumber)
                {
                    Label4.Text = "Correct";
                    imgAnswer4.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label4.Text = "Incorrect";
                    imgAnswer4.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer5 == ListItem5 + dividingNumber)
                {
                    Label5.Text = "Correct";
                    imgAnswer5.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label5.Text = "Incorrect";
                    imgAnswer5.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer6 == ListItem6 + dividingNumber)
                {
                    Label6.Text = "Correct";
                    imgAnswer6.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label6.Text = "Incorrect";
                    imgAnswer6.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer7 == ListItem7 + dividingNumber)
                {
                    Label7.Text = "Correct";
                    imgAnswer7.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label7.Text = "Incorrect";
                    imgAnswer7.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer8 == ListItem8 + dividingNumber)
                {
                    Label8.Text = "Correct";
                    imgAnswer8.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label8.Text = "Incorrect";
                    imgAnswer8.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer9 == ListItem9 + dividingNumber)
                {
                    Label9.Text = "Correct";
                    imgAnswer9.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label9.Text = "Incorrect";
                    imgAnswer9.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer10 == ListItem10 + dividingNumber)
                {
                    Label10.Text = "Correct";
                    imgAnswer10.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label10.Text = "Incorrect";
                    imgAnswer10.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer11 == ListItem11 + dividingNumber)
                {
                    Label11.Text = "Correct";
                    imgAnswer11.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label11.Text = "Incorrect";
                    imgAnswer11.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer12 == ListItem12 + dividingNumber)
                {
                    Label12.Text = "Correct";
                    imgAnswer12.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label12.Text = "Incorrect";
                    imgAnswer12.ImageUrl = "/Image/IncorrectMascot.png";
                }
            }
            if (strMode == "S")
            {
                if (answer1 == ListItem1 - dividingNumber)
                {
                    Label1.Text = "Correct";
                    imgAnswer1.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label1.Text = "Incorrect";
                    imgAnswer1.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer2 == ListItem2 - dividingNumber)
                {
                    Label2.Text = "Correct";
                    imgAnswer2.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label2.Text = "Incorrect";
                    imgAnswer2.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer3 == ListItem3 - dividingNumber)
                {
                    Label3.Text = "Correct";
                    imgAnswer3.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label3.Text = "Incorrect";
                    imgAnswer3.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer4 == ListItem4 - dividingNumber)
                {
                    Label4.Text = "Correct";
                    imgAnswer4.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label4.Text = "Incorrect";
                    imgAnswer4.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer5 == ListItem5 - dividingNumber)
                {
                    Label5.Text = "Correct";
                    imgAnswer5.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label5.Text = "Incorrect";
                    imgAnswer5.ImageUrl = "/Image/IncorrectMascot.png";
                    counter = counter + 1;
                }
                if (answer6 == ListItem6 - dividingNumber)
                {
                    Label6.Text = "Correct";
                    imgAnswer6.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label6.Text = "Incorrect";
                    imgAnswer6.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer7 == ListItem7 - dividingNumber)
                {
                    Label7.Text = "Correct";
                    imgAnswer7.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label7.Text = "Incorrect";
                    imgAnswer7.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer8 == ListItem8 - dividingNumber)
                {
                    Label8.Text = "Correct";
                    imgAnswer8.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label8.Text = "Incorrect";
                    imgAnswer8.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer9 == ListItem9 - dividingNumber)
                {
                    Label9.Text = "Correct";
                    imgAnswer9.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label9.Text = "Incorrect";
                    imgAnswer9.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer10 == ListItem10 - dividingNumber)
                {
                    Label10.Text = "Correct";
                    imgAnswer10.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label10.Text = "Incorrect";
                    imgAnswer10.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer11 == ListItem11 - dividingNumber)
                {
                    Label11.Text = "Correct";
                    imgAnswer11.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label11.Text = "Incorrect";
                    imgAnswer11.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer12 == ListItem12 - dividingNumber)
                {
                    Label12.Text = "Correct";
                    imgAnswer12.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label12.Text = "Incorrect";
                    imgAnswer12.ImageUrl = "/Image/IncorrectMascot.png";
                }
            }
            if (strMode == "M")
            {
                if (answer1 == ListItem1 * dividingNumber)
                {
                    Label1.Text = "Correct";
                    imgAnswer1.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label1.Text = "Incorrect";
                    imgAnswer1.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer2 == ListItem2 * dividingNumber)
                {
                    Label2.Text = "Correct";
                    imgAnswer2.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label2.Text = "Incorrect";
                    imgAnswer2.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer3 == ListItem3 * dividingNumber)
                {
                    Label3.Text = "Correct";
                    imgAnswer3.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label3.Text = "Incorrect";
                    imgAnswer3.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer4 == ListItem4 * dividingNumber)
                {
                    Label4.Text = "Correct";
                    imgAnswer4.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label4.Text = "Incorrect";
                    imgAnswer4.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer5 == ListItem5 * dividingNumber)
                {
                    Label5.Text = "Correct";
                    imgAnswer5.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label5.Text = "Incorrect";
                    imgAnswer5.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer6 == ListItem6 * dividingNumber)
                {
                    Label6.Text = "Correct";
                    imgAnswer6.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label6.Text = "Incorrect";
                    imgAnswer6.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer7 == ListItem7 * dividingNumber)
                {
                    Label7.Text = "Correct";
                    imgAnswer7.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label7.Text = "Incorrect";
                    imgAnswer7.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer8 == ListItem8 * dividingNumber)
                {
                    Label8.Text = "Correct";
                    imgAnswer8.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label8.Text = "Incorrect";
                    imgAnswer8.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer9 == ListItem9 * dividingNumber)
                {
                    Label9.Text = "Correct";
                    imgAnswer9.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label9.Text = "Incorrect";
                    imgAnswer9.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer10 == ListItem10 * dividingNumber)
                {
                    Label10.Text = "Correct";
                    imgAnswer10.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label10.Text = "Incorrect";
                    imgAnswer10.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer11 == ListItem11 * dividingNumber)
                {
                    Label11.Text = "Correct";
                    imgAnswer11.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label11.Text = "Incorrect";
                    imgAnswer11.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer12 == ListItem12 * dividingNumber)
                {
                    Label12.Text = "Correct";
                    imgAnswer12.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label12.Text = "Incorrect";
                    imgAnswer12.ImageUrl = "/Image/IncorrectMascot.png";
                }
            }
            if (strMode == "D")
            {
                if (answer1 == ListItem1 / dividingNumber)
                {
                    Label1.Text = "Correct";
                    imgAnswer1.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label1.Text = "Incorrect";
                    imgAnswer1.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer2 == ListItem2 / dividingNumber)
                {
                    Label2.Text = "Correct";
                    imgAnswer2.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label2.Text = "Incorrect";
                    imgAnswer2.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer3 == ListItem3 / dividingNumber)
                {
                    Label3.Text = "Correct";
                    imgAnswer3.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label3.Text = "Incorrect";
                    imgAnswer3.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer4 == ListItem4 / dividingNumber)
                {
                    Label4.Text = "Correct";
                    imgAnswer4.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label4.Text = "Incorrect";
                    imgAnswer4.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer5 == ListItem5 / dividingNumber)
                {
                    Label5.Text = "Correct";
                    imgAnswer5.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label5.Text = "Incorrect";
                    imgAnswer5.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer6 == ListItem6 / dividingNumber)
                {
                    Label6.Text = "Correct";
                    imgAnswer6.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label6.Text = "Incorrect";
                    imgAnswer6.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer7 == ListItem7 / dividingNumber)
                {
                    Label7.Text = "Correct";
                    imgAnswer7.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label7.Text = "Incorrect";
                    imgAnswer7.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer8 == ListItem8 / dividingNumber)
                {
                    Label8.Text = "Correct";
                    imgAnswer8.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label8.Text = "Incorrect";
                    imgAnswer8.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer9 == ListItem9 / dividingNumber)
                {
                    Label9.Text = "Correct";
                    imgAnswer9.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label9.Text = "Incorrect";
                    imgAnswer9.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer10 == ListItem10 / dividingNumber)
                {
                    Label10.Text = "Correct";
                    imgAnswer10.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label10.Text = "Incorrect";
                    imgAnswer10.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer11 == ListItem11 / dividingNumber)
                {
                    Label11.Text = "Correct";
                    imgAnswer11.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label11.Text = "Incorrect";
                    imgAnswer11.ImageUrl = "/Image/IncorrectMascot.png";
                }
                if (answer12 == ListItem12 / dividingNumber)
                {
                    Label12.Text = "Correct";
                    imgAnswer12.ImageUrl = "/Image/CorrectMascot.png";
                    counter = counter + 1;
                }
                else
                {
                    Label12.Text = "Incorrect";
                    imgAnswer12.ImageUrl = "/Image/IncorrectMascot.png";
                }
            }
        }
        }

        txtAns1.ReadOnly = true;
        txtAns2.ReadOnly = true;
        txtAns3.ReadOnly = true;
        txtAns4.ReadOnly = true;
        txtAns5.ReadOnly = true;
        txtAns6.ReadOnly = true;
        txtAns7.ReadOnly = true;
        txtAns8.ReadOnly = true;
        txtAns9.ReadOnly = true;
        txtAns10.ReadOnly = true;
        txtAns11.ReadOnly = true;
        txtAns12.ReadOnly = true;

        //timeTaken2 = Convert.ToDecimal(lblTimer.Text);

        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "insert into tablesScore2 ( UserID, TimeTaken, DateAndTime, Score, Operator, OperandNumber) values ('" + User.Identity.GetUserId() + "', 4.875, GETDATE(), " + counter + ", '" + strMode + "'," + strNumber + ")";
        cmd.ExecuteNonQuery();
        con.Close();

        if (counter == 12)
        {
            GoldMedal.Visible = true;
            GoldMedal.ImageUrl = "/Image/CDPicture.png";
            over12.Visible = true;
            over12.ImageUrl = "http://localhost:55365/Image/12over12.png";
        }
        if (counter == 11)
        {
            SilverMedal.Visible = true;
            SilverMedal.ImageUrl = "/Image/SilverStar.png";
            over12.Visible = true;
            over12.ImageUrl = "http://localhost:55365/Image/11over12.png";
        }
        if (counter == 10)
        {
            over12.Visible = true;
            over12.ImageUrl = "http://localhost:55365/Image/10over12.png";
        }
        if (counter == 9)
        {
            over12.Visible = true;
            over12.ImageUrl = "http://localhost:55365/Image/9over12.png";
        }
        if (counter == 8)
        {
            over12.Visible = true;
            over12.ImageUrl = "http://localhost:55365/Image/8over12.png";
        }
        if (counter == 7)
        {
            over12.Visible = true;
            over12.ImageUrl = "http://localhost:55365/Image/7over12.png";
        }
        if (counter == 6)
        {
            over12.Visible = true;
            over12.ImageUrl = "http://localhost:55365/Image/6over12.png";
        }
        if (counter == 5)
        {
            over12.Visible = true;
            over12.ImageUrl = "http://localhost:55365/Image/5over12.png";
        }
        if (counter == 4)
        {
            over12.Visible = true;
            over12.ImageUrl = "http://localhost:55365/Image/4over12.png";
        }
        if (counter == 3)
        {
            over12.Visible = true;
            over12.ImageUrl = "http://localhost:55365/Image/3over12.png";
        }
        if (counter == 2)
        {
            over12.Visible = true;
            over12.ImageUrl = "http://localhost:55365/Image/2over12.png";
        }
        if (counter == 1)
        {
            over12.Visible = true;
            over12.ImageUrl = "http://localhost:55365/Image/1over12.png";
        }
        if (counter == 0)
        {
            over12.Visible = true;
            over12.ImageUrl = "http://localhost:55365/Image/0over12.png";
        }


        btnConfirm.Enabled = false;
    }

    protected void txtAns8_TextChanged(object sender, EventArgs e)
    {

    }

    protected void btnRestart_Click(object sender, EventArgs e)
    {
        Random randomizer = new Random();
        String strMode = Request.QueryString["mode"];
        String strNumber = Request.QueryString["number"];

        txtAns1.Text = "";
        txtAns2.Text = "";
        txtAns3.Text = "";
        txtAns4.Text = "";
        txtAns5.Text = "";
        txtAns6.Text = "";
        txtAns7.Text = "";
        txtAns8.Text = "";
        txtAns9.Text = "";
        txtAns10.Text = "";
        txtAns11.Text = "";
        txtAns12.Text = "";

        imgAnswer1.ImageUrl = "";
        imgAnswer2.ImageUrl = "";
        imgAnswer3.ImageUrl = "";
        imgAnswer4.ImageUrl = "";
        imgAnswer5.ImageUrl = "";
        imgAnswer6.ImageUrl = "";
        imgAnswer7.ImageUrl = "";
        imgAnswer8.ImageUrl = "";
        imgAnswer9.ImageUrl = "";
        imgAnswer10.ImageUrl = "";
        imgAnswer11.ImageUrl = "";
        imgAnswer12.ImageUrl = "";
        over12.ImageUrl = "";

        GoldMedal.ImageUrl = "";
        SilverMedal.ImageUrl = "";

        btnConfirm.Enabled = true;

        imgAnswer1.Visible = false;
        imgAnswer2.Visible = false;
        imgAnswer3.Visible = false;
        imgAnswer4.Visible = false;
        imgAnswer5.Visible = false;
        imgAnswer6.Visible = false;
        imgAnswer7.Visible = false;
        imgAnswer8.Visible = false;
        imgAnswer9.Visible = false;
        imgAnswer10.Visible = false;
        imgAnswer11.Visible = false;
        imgAnswer12.Visible = false;
        over12.Visible = false;

        GoldMedal.Visible = false;
        SilverMedal.Visible = false;

        txtAns1.ReadOnly = false;
        txtAns2.ReadOnly = false;
        txtAns3.ReadOnly = false;
        txtAns4.ReadOnly = false;
        txtAns5.ReadOnly = false;
        txtAns6.ReadOnly = false;
        txtAns7.ReadOnly = false;
        txtAns8.ReadOnly = false;
        txtAns9.ReadOnly = false;
        txtAns10.ReadOnly = false;
        txtAns11.ReadOnly = false;
        txtAns12.ReadOnly = false;

        while (randomList.Count < 12)
        {
            //If Mode is subtraction
            if (strMode == "S")
            {
                MyNumber = randomizer.Next(dividingNumber, dividingNumber + 12);
                if (!randomList.Contains(MyNumber))
                {
                    randomList.Add(MyNumber);
                }
            }
            //If Mode is Division
            else if (strMode == "D")
            {
                MyNumber = randomizer.Next(1, 13) * dividingNumber;
                if (!randomList.Contains(MyNumber))
                {
                    randomList.Add(MyNumber);
                }
            }
            //If Mode is Anything else  (i.e. Add or Multiply)
            else
            {
                MyNumber = randomizer.Next(1, 13);
                if (!randomList.Contains(MyNumber))
                {
                    randomList.Add(MyNumber);
                }
            }


        }
        {
            lblNo1A.Text = randomList[0].ToString();
            lblNo2A.Text = randomList[1].ToString();
            lblNo3A.Text = randomList[2].ToString();
            lblNo4A.Text = randomList[3].ToString();
            lblNo5A.Text = randomList[4].ToString();
            lblNo6A.Text = randomList[5].ToString();
            lblNo7A.Text = randomList[6].ToString();
            lblNo8A.Text = randomList[7].ToString();
            lblNo9A.Text = randomList[8].ToString();
            lblNo10A.Text = randomList[9].ToString();
            lblNo11A.Text = randomList[10].ToString();
            lblNo12A.Text = randomList[11].ToString();

            lblNo1B.Text = strNumber;
            lblNo2B.Text = strNumber;
            lblNo3B.Text = strNumber;
            lblNo4B.Text = strNumber;
            lblNo5B.Text = strNumber;
            lblNo6B.Text = strNumber;
            lblNo7B.Text = strNumber;
            lblNo8B.Text = strNumber;
            lblNo9B.Text = strNumber;
            lblNo10B.Text = strNumber;
            lblNo11B.Text = strNumber;
            lblNo12B.Text = strNumber;

            if (strMode == "A")
            {
                lbl1Op.Text = "+";
                lbl2Op.Text = "+";
                lbl3Op.Text = "+";
                lbl4Op.Text = "+";
                lbl5Op.Text = "+";
                lbl6Op.Text = "+";
                lbl7Op.Text = "+";
                lbl8Op.Text = "+";
                lbl9Op.Text = "+";
                lbl10Op.Text = "+";
                lbl11Op.Text = "+";
                lbl12Op.Text = "+";
            }
            if (strMode == "S")
            {
                lbl1Op.Text = "-";
                lbl2Op.Text = "-";
                lbl3Op.Text = "-";
                lbl4Op.Text = "-";
                lbl5Op.Text = "-";
                lbl6Op.Text = "-";
                lbl7Op.Text = "-";
                lbl8Op.Text = "-";
                lbl9Op.Text = "-";
                lbl10Op.Text = "-";
                lbl11Op.Text = "-";
                lbl12Op.Text = "-";
            }
            if (strMode == "D")
            {
                lbl1Op.Text = "÷";
                lbl2Op.Text = "÷";
                lbl3Op.Text = "÷";
                lbl4Op.Text = "÷";
                lbl5Op.Text = "÷";
                lbl6Op.Text = "÷";
                lbl7Op.Text = "÷";
                lbl8Op.Text = "÷";
                lbl9Op.Text = "÷";
                lbl10Op.Text = "÷";
                lbl11Op.Text = "÷";
                lbl12Op.Text = "÷";
            }
            if (strMode == "M")
            {
                lbl1Op.Text = "×";
                lbl2Op.Text = "×";
                lbl3Op.Text = "×";
                lbl4Op.Text = "×";
                lbl5Op.Text = "×";
                lbl6Op.Text = "×";
                lbl7Op.Text = "×";
                lbl8Op.Text = "×";
                lbl9Op.Text = "×";
                lbl10Op.Text = "×";
                lbl11Op.Text = "×";
                lbl12Op.Text = "×";

                
            }
        }
    }
}
