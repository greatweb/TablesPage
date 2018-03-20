using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default3 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        SqlConnection con = new SqlConnection(@"Data Source=IESURFACEPRO2A\SQLEXPRESS;Initial Catalog=MaximGame;Integrated Security=True;");

        con.Open();
        SqlCommand cmd = new SqlCommand("select Name, Score from leaderboard order by score DESC", con);
        SqlDataReader rdr = cmd.ExecuteReader();
        GridView1.DataSource = rdr;
        GridView1.DataBind();
        con.Close();
    }

    protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
    {

    }
}