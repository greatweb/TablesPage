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
  
    }

    protected void ScoreAndSession_Load(object sender, EventArgs e)
    {
        //con.Open();
        //SqlCommand cmd = con.CreateCommand();
        //cmd.CommandType = CommandType.Text;
        //cmd.CommandText = "select top 5 * from tablesScore2 order by DateAndTime desc";
        //cmd.ExecuteNonQuery();
        //con.Close();


        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "select top 5 * from tablesScore2 order by DateAndTime desc";
        List<string> Scores = new List<string>();


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

        Convert.ToInt32(Scores[0]);
        Convert.ToInt32(Scores[1]);
        Convert.ToInt32(Scores[2]);
        Convert.ToInt32(Scores[3]);
        Convert.ToInt32(Scores[4]);

        int scoreCounter = 0;

        string[] Sessions = { "Session 1", "Session 2", "Session 3", "Session 4", "Session 5" };
        foreach (string DOW in Sessions)
        {
            //Decimal totalSalesForDOW = Scores.Next(1, 5);
            int testScore = Convert.ToInt32(Scores[scoreCounter]);
            ScoreAndSession.Series[0].Points.AddXY(DOW, testScore);
            scoreCounter = scoreCounter + 1;
        }
    }
}