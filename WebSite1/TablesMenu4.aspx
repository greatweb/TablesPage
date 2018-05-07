<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="Site.master" CodeFile="TablesMenu4.aspx.cs" Inherits="Default5" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <asp:PlaceHolder runat="server">
        <link href="CSS/CoolCSS.css" rel="stylesheet" />
        </asp:PlaceHolder>

        <div>
            <nav style="width: 468px">
                <br />
                <br />
                <ul>
                    <li><a href="ClickerPage.aspx">Home</a></li>
                    <li><a href="TablesMenu4.aspx">Tables</a></li>
                    <li><a href="Account/Login.aspx">Login</a></li>
                </ul>
                <br />
            </nav>
        </div>

        <br />
        <div class="RadioButtonClass">
        <asp:RadioButtonList ID="rbTables" runat="server" Height="50px" Width="863px" Style="font-size: xx-small;" Font-Size="XX-Large" EnableTheming="True" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList3_SelectedIndexChanged" RepeatDirection="Horizontal">
            <asp:ListItem Value="A" Selected="True">Addition</asp:ListItem>
            <asp:ListItem Value="S">Subtraction</asp:ListItem>
            <asp:ListItem Value="M">Multiplication</asp:ListItem>
            <asp:ListItem Value="D">Division</asp:ListItem>
        </asp:RadioButtonList>
        </div>

        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />

        <asp:Button ID="btn1TimesTables" runat="server" Height="100px" Text=" + 1 Tables" Width="200px" OnClick="btn1TimesTables_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn2TimesTables" runat="server" Height="100px" Text="+ 2 Tables" Width="200px" OnClick="btn2TimesTables_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn3TimesTables" runat="server" Height="100px" Text="+ 3 Tables" Width="200px" OnClick="btn3TimesTables_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn4TimesTables" runat="server" Height="100px" Text="+ 4 Tables" Width="200px" OnClick="btn4TimesTables_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Button ID="btn5TimesTables" runat="server" Height="100px" Text="+ 5 Times Tables" Width="200px" OnClick="btn5TimesTables_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn6TimesTables" runat="server" Height="100px" Text="+ 6 Tables" Width="200px" OnClick="btn6TimesTables_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn7TimesTables" runat="server" Height="100px" Text="+ 7 Tables" Width="200px" OnClick="btn7TimesTables_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn8TimesTables" runat="server" Height="100px" Text="+ 8 Tables" Width="200px" OnClick="btn8TimesTables_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Button ID="btn9TimesTables" runat="server" Height="100px" Text="+ 9 Times Tables" Width="200px" OnClick="btn9TimesTables_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn10TimesTables" runat="server" Height="100px" Text="+ 10 Tables" Width="200px" OnClick="btn10TimesTables_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn11TimesTables" runat="server" Height="100px" Text="+ 11 Tables" Width="200px" OnClick="btn11TimesTables_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn12TimesTables" runat="server" Height="100px" Text="+ 12 Tables" Width="200px" OnClick="btn12TimesTables_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        &nbsp;&nbsp;
        <br />
        &nbsp;<asp:Button ID="Button13" runat="server" Text="Results" OnClick="Button13_Click" />
</asp:Content>