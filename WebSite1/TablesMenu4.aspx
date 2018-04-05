<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TablesMenu4.aspx.cs" Inherits="Default5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav style="width: 468px">
                <br />
                <br />
                <ul>
                    <li><a href="ClickerPage.aspx">Home</a></li>
                    <li><a href="TablesMenu4.aspx">Tables</a></li>
                </ul>
                <br />
            </nav>
        </div>

        <br />
        <asp:RadioButtonList ID="rbTables" runat="server" Height="50px" Width="863px" Style="font-size: xx-small;" Font-Size="XX-Large" EnableTheming="True" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList3_SelectedIndexChanged" RepeatDirection="Horizontal">
            <asp:ListItem Value="A">Addition</asp:ListItem>
            <asp:ListItem Value="S">Subtraction</asp:ListItem>
            <asp:ListItem Value="M">Multiplication</asp:ListItem>
            <asp:ListItem Value="D">Division</asp:ListItem>
        </asp:RadioButtonList>
        
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />

        <input type="button" value="1 Times Tables" onclick="window.location.href = 'TablesPage.aspx'" style="height: 100px; width: 200px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn2TimesTables" runat="server" Height="100px" Text="2 Times Tables" Width="200px" OnClick="btn2TimesTables_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" Height="100px" Text="3 Times Tables" Width="200px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button4" runat="server" Height="100px" Text="4 Times Tables" Width="200px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Button ID="Button5" runat="server" Height="100px" Text="5 Times Tables" Width="200px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button6" runat="server" Height="100px" Text="6 Times Tables" Width="200px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button7" runat="server" Height="100px" Text="7 Times Tables" Width="200px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button8" runat="server" Height="100px" Text="8 Times Tables" Width="200px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        <asp:Button ID="Button9" runat="server" Height="100px" Text="9 Times Tables" Width="200px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button10" runat="server" Height="100px" Text="10 Times Tables" Width="200px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button11" runat="server" Height="100px" Text="11 Times Tables" Width="200px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button12" runat="server" Height="100px" Text="12 Times Tables" Width="200px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        &nbsp;&nbsp;
        <br />
        &nbsp;<asp:Button ID="Button13" runat="server" Text="Results" />

    </form>
</body>
</html>
