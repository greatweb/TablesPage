﻿using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ClickerPage : System.Web.UI.Page
{
    SqlConnection con = new SqlConnection(@"Data Source=IESURFACEPRO2A\SQLEXPRESS;Initial Catalog=MaximGame;Integrated Security=True");
    protected void Page_Load(object sender, EventArgs e)
    { 

    }
    protected void btnSubmit_Click(object sender, EventArgs e)
    {//Submit Button Code
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "insert into leaderboard values ('" + User.Identity.GetUserName() + "','" + scoreForm.Text + "')";
        cmd.ExecuteNonQuery();
        con.Close();
    }
    

    protected void SqlDataSource1_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {//Useless
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "insert into leaderboard values ('" + User.Identity.GetUserName() + "','" + scoreForm.Text + "')";
        cmd.ExecuteNonQuery();
        con.Close();

    }

    protected void Button1_Click1(object sender, EventArgs e)
    {//Working
        con.Open();
        SqlCommand cmd = con.CreateCommand();
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "insert into leaderboard values ('" + User.Identity.GetUserName() + "','" + scoreForm.Text + "')";
        cmd.ExecuteNonQuery();
        con.Close();
    }

    protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
    {
    }

    protected void Button1_Click2(object sender, EventArgs e)
    {

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }
}