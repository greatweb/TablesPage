using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Default4 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        Random randomizer = new Random();


        string[] Sessions = { "Session 1", "Session 2", "Session 3", "Session 4", "Session 5", "Session 6", "Session 7", "Session 8", "Session 9", "Session 10" };
        foreach (string DOW in Sessions)
        {
            Decimal totalSalesForDOW = randomizer.Next(1, 12);
            chtSalesPerDOW.Series[0].Points.AddXY(DOW, totalSalesForDOW);
        }
    }
}