using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default4 : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=IESURFACEPRO2A\SQLEXPRESS;Initial Catalog=MaximGame;Integrated Security=True");

    protected void Page_Load(object sender, EventArgs e)
    {
        String strMode = Request.QueryString["mode"];
        String strNumber = Request.QueryString["number"];

        if (strMode == "M")
            {
                Info.Text = strNumber + " × Tables";
            }
            if (strMode == "A")
            {
                Info.Text = strNumber + "+ Tables";
            }
            if (strMode == "S")
            {
                Info.Text = strNumber + " - Tables";
            }
            if (strMode == "D")
            {
                Info.Text = strNumber + " ÷ Tables";
            }
    }

    protected void ScoreAndSession_Load(object sender, EventArgs e)
    {
        //con.Open();
        //SqlCommand cmd = con.CreateCommand();
        //cmd.CommandType = CommandType.Text;
        //cmd.CommandText = "select top 5 * from tablesScore2 order by DateAndTime desc";
        //cmd.ExecuteNonQuery();
        //con.Close();
        String strMode = Request.QueryString["mode"];
        String strNumber = Request.QueryString["number"];

        if (strMode == null)
        {
            strMode = "M";
            strNumber = "1";
        }

        string UserId = User.Identity.GetUserId();

        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        List<string> Scores = new List<string>();
        cmd.CommandText = "select top 5 * from tablesScore2 where Operator = '" + strMode + "' and OperandNumber = '" + strNumber + "' and UserID = '"+ UserId +"' order by DateAndTime desc";


        using (SqlDataReader reader = cmd.ExecuteReader())
        {
            while (reader.Read())
            {
                Scores.Add(reader["Score"].ToString());
                //Console.WriteLine(reader["Username"].ToString());
                //Console.WriteLine(reader["Item"].ToString());
                //Console.WriteLine(reader["Amount"].ToString());
                //Console.WriteLine(reader["Complete"].ToString());
            }
        }
        con.Close();
        if (Scores.Count > 0) { Convert.ToDecimal(Scores[0]); } else { Scores.Add("0"); }
        if (Scores.Count > 1) { Convert.ToDecimal(Scores[1]); } else { Scores.Add("0"); }
        if (Scores.Count > 2) { Convert.ToDecimal(Scores[2]); } else { Scores.Add("0"); }
        if (Scores.Count > 3) { Convert.ToDecimal(Scores[3]); } else { Scores.Add("0"); }
        if (Scores.Count > 4) { Convert.ToDecimal(Scores[4]); } else { Scores.Add("0"); }
        //    {
        //    if (Scores[0] != null) { Convert.ToDecimal(Scores[0]); } else { Scores[0] = "0"; }
        //    if (Scores[1] != null) { Convert.ToDecimal(Scores[1]); } else { Scores[1] = "0"; }
        //    if (Scores[2] != null) { Convert.ToDecimal(Scores[2]); } else { Scores[2] = "0"; }
        //    if (Scores[3] != null) { Convert.ToDecimal(Scores[3]); } else { Scores[3] = "0"; }
        //}

        int scoreCounter = 0;

        ScoreAndSession.ChartAreas[0].AxisY.Minimum = -0.00000000000000001;
        ScoreAndSession.ChartAreas[0].AxisY.Maximum = 12;

        string[] Sessions = { "Session 1", "Session 2", "Session 3", "Session 4", "Session 5" };
        foreach (string DOW in Sessions)
        {

            //Decimal totalSalesForDOW = Scores.Next(1, 5);
            decimal testScore = Convert.ToDecimal(Scores[scoreCounter]);

            //if ()
            //{

            //}
            if (testScore == 0)
            {
                testScore = 0.0001M;  
            }
            ScoreAndSession.Series[0].Points.AddXY(DOW, testScore);
            if (testScore == 0.0001M)
            {
                ScoreAndSession.Series[0].Points[ScoreAndSession.Series[0].Points.Count - 1].ToolTip = "You scored (0/12) in #VALX ";
            }
            scoreCounter = scoreCounter + 1;

        }
        
    }
    
}