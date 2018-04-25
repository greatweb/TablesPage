<%@ Page Language="C#" AutoEventWireup="true" CodeFile="leaderboard.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link height="10" href="hand.png" rel="shortcut icon" width="20" />
    <title>Clicker</title>
    
   
    <link href="CSS/StyleSheet1.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav>
                <ul>
                    <li><a href="ClickerPage.aspx">Home</a></li>
                    <li><a href="TablesMenu.aspx">Tables</a></li>
                    <li><a href="Account/Login.aspx">Login</a></li>
                </ul>
                <br />
                <br />
                <br />
            </nav>
        </div>
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" Width="935px">
        </asp:GridView>
    </form>
    </body>
</html>

