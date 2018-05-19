<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeFile="leaderboard.aspx.cs" Inherits="Default3" %>


<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <asp:PlaceHolder runat="server">
    <link height="10" href="hand.png" rel="shortcut icon" width="20" />
    <title>Clicker</title>
    
   
    <link href="CSS/StyleSheet1.css" rel="stylesheet" type="text/css" />
</asp:PlaceHolder>
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
</asp:Content>
