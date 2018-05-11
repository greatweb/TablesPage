using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnGetStarted_Click(object sender, EventArgs e)
    {
        if (User.Identity.GetUserId() == null)
        {
            Response.Redirect("/Account/Login.aspx");
        }
        else
        {
            Response.Redirect("TablesMenu4.aspx");
        }
    }
}