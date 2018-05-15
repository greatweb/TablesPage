using System;
using System.Net.Mail;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Configuration;

public partial class Default7 : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        //MailMessage mail = new MailMessage("theirishlerachaun@gmail.com","maximredmond@gmail.com");
        //SmtpClient client = new SmtpClient();
        //client.Port = 25;
        //client.DeliveryMethod = SmtpDeliveryMethod.Network;
        //NetworkCredential loginInfo = new NetworkCredential(Convert.ToString(ConfigurationManager.AppSettings["maximredmond"]), Convert.ToString(ConfigurationManager.AppSettings["nnnnuuuu"])); // password for connection smtp if u dont have have then pass blank
        //client.Credentials = loginInfo;
        //client.UseDefaultCredentials = true;
        //client.EnableSsl = true;
        //client.Host = "smtp.gmail.com";
        //mail.Subject = "this is a test email.";
        //mail.Body = "this is my test email body";
        //client.Send(mail);
        var fromAddress = new MailAddress("maximredmond@gmail.com");
        var fromPassword = "nnnnuuuu";
        var toAddress = new MailAddress("theirishlerachaun@gmail.com");

        string subject = "Verification";
        string body = "Go To http://localhost:55365/Account/Login To Login";

        System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient
        {
            Host = "smtp.gmail.com",
            Port = 587,
            EnableSsl = true,
            DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential(fromAddress.Address, fromPassword)

        };

        using (var message = new MailMessage(fromAddress, toAddress)
        {
            Subject = subject,
            Body = body
        })


            smtp.Send(message);
        Label1.Text = "Email Sent !!";
    }
}