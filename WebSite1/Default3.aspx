<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default3.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tables</title>
</head>
<body>
    <style>
        body{
            background-color:blue;
        }
    </style>

    <form id="form1" runat="server">
        <div>
            <h2 id="demo" style="float:right; width: 162px; height: 78px;"></h2>
        </div>
        <table>
            <tr>
                <td>
                    <asp:Label ID="lblNo1A" runat="server" Text="lblNo1A | " onkeydown="if(event.keyCode==13) {event.keyCode=9;}"/></td>
                <td>
                    <asp:Label ID="lbl1Op" runat="server" Text="lbl1Op | " /></td>
                <td>
                    <asp:Label ID="lblNo1B" runat="server" Text="lblNo1A | " /></td>
                <td>
                <asp:TextBox ID="txtAns1" runat="server" /></td>
                <td>
                    <asp:Image ID="imgAnswer1" runat="server" Height="40px" Width="40px" />
                    <asp:Label ID="Label1" visible="false" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblNo2A" runat="server" Text="lblNo1A | " /></td>
                <td>
                    <asp:Label ID="lbl2Op" runat="server" Text="lbl1Op | " /></td>
                <td>
                    <asp:Label ID="lblNo2B" runat="server" Text="lblNo1A | " /></td>
                <td>
                <asp:TextBox ID="txtAns2" runat="server"/></td>
                <td>
                    <asp:Image ID="imgAnswer2" runat="server" Height="40px" Width="40px" />
                    <asp:Label ID="Label2" visible="false" runat="server" Text=""></asp:Label>
                    
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblNo3A" runat="server" Text="lblNo1A | " /></td>
                <td>
                    <asp:Label ID="lbl3Op" runat="server" Text="lbl1Op | " /></td>
                <td>
                    <asp:Label ID="lblNo3B" runat="server" Text="lblNo1A | " /></td>
                <td>
                <asp:TextBox ID="txtAns3" runat="server"/></td>
                <td>
                    <asp:Image ID="imgAnswer3" runat="server" Height="40px" Width="40px" />
                    <asp:Label ID="Label3" visible="false" runat="server" Text=""></asp:Label>
                    
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblNo4A" runat="server" Text="lblNo1A | " /></td>
                <td>
                    <asp:Label ID="lbl4Op" runat="server" Text="lbl1Op | " /></td>
                <td>
                    <asp:Label ID="lblNo4B" runat="server" Text="lblNo1A | " /></td>
                <td>
                <asp:TextBox ID="txtAns4" runat="server"/></td>
                <td>
                    <asp:Image ID="imgAnswer4" runat="server" Height="40px" Width="40px" />
                    <asp:Label ID="Label4" visible="false" runat="server" Text=""></asp:Label>
                </td>
                
            </tr>

        </table>
                    <asp:Image ID="GoldMedal" runat="server" style="float:right" Width="100px" Height="100px" />

        <table>
            <tr>
                <td>
                    <asp:Label ID="lblNo5A" runat="server" Text="lblNo1A | " /></td>
                <td>
                    <asp:Label ID="lbl5Op" runat="server" Text="lbl1Op | " /></td>
                <td>
                    <asp:Label ID="lblNo5B" runat="server" Text="lblNo1A | " /></td>
                <td>
                <asp:TextBox ID="txtAns5" runat="server"/></td>
                <td>
                    <asp:Image ID="imgAnswer5" runat="server" Height="40px" Width="40px" />
                    <asp:Label ID="Label5" visible="false" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblNo6A" runat="server" Text="lblNo1A | " /></td>
                <td>
                    <asp:Label ID="lbl6Op" runat="server" Text="lbl1Op | " /></td>
                <td>
                    <asp:Label ID="lblNo6B" runat="server" Text="lblNo1A | " /></td>
                <td>
                <asp:TextBox ID="txtAns6" runat="server"/></td>
                <td>
                    <asp:Image ID="imgAnswer6" runat="server" Height="40px" Width="40px" />
                    <asp:Label ID="Label6" visible="false" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblNo7A" runat="server" Text="lblNo1A | " /></td>
                <td>
                    <asp:Label ID="lbl7Op" runat="server" Text="lbl1Op | " /></td>
                <td>
                    <asp:Label ID="lblNo7B" runat="server" Text="lblNo1A | " /></td>
                <td>
                <asp:TextBox ID="txtAns7" runat="server"/></td>
                <td>
                    <asp:Image ID="imgAnswer7" runat="server" Height="40px" Width="40px" />
                    <asp:Label ID="Label7" visible="false" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblNo8A" runat="server" Text="lblNo1A | " /></td>
                <td>
                    <asp:Label ID="lbl8Op" runat="server" Text="lbl1Op | " /></td>
                <td>
                    <asp:Label ID="lblNo8B" runat="server" Text="lblNo1A | " /></td>
                <td>
                <asp:TextBox ID="txtAns8" runat="server"/></td>
                <td>
                    <asp:Image ID="imgAnswer8" runat="server" Height="40px" Width="40px" />
                    <asp:Label ID="Label8" visible="false" runat="server" Text=""></asp:Label>
                
                </td>
            </tr>

        </table>
        <asp:Image ID="SilverMedal" runat="server" Style="float:right" Width="100px" Height="100px" />
        <table>
            <tr>
                <td>
                    <asp:Label ID="lblNo9A" runat="server" Text="lblNo1A | " /></td>
                <td>
                    <asp:Label ID="lbl9Op" runat="server" Text="lbl1Op | " /></td>
                <td>
                    <asp:Label ID="lblNo9B" runat="server" Text="lblNo1A | " /></td>
                <td>
                <asp:TextBox ID="txtAns9" runat="server"/></td>
                <td>
                    <asp:Image ID="imgAnswer9" runat="server" Height="40px" Width="40px" />
                    <asp:Label ID="Label9" visible="false" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblNo10A" runat="server" Text="lblNo1A | " /></td>
                <td>
                    <asp:Label ID="lbl10Op" runat="server" Text="lbl1Op | " /></td>
                <td>
                    <asp:Label ID="lblNo10B" runat="server" Text="lblNo1A | " /></td>
                <td>
                <asp:TextBox ID="txtAns10" runat="server"/></td>
                <td>
                    <asp:Image ID="imgAnswer10" runat="server" Height="40px" Width="40px" />
                    <asp:Label ID="Label10" visible="false" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblNo11A" runat="server" Text="lblNo1A | " /></td>
                <td>
                    <asp:Label ID="lbl11Op" runat="server" Text="lbl1Op | " /></td>
                <td>
                    <asp:Label ID="lblNo11B" runat="server" Text="lblNo1A | " /></td>
                <td>
                <asp:TextBox ID="txtAns11" runat="server"/></td>
                <td>
                    <asp:Image ID="imgAnswer11" runat="server" Height="40px" Width="40px" />
                    <asp:Label ID="Label11" visible="false" runat="server" Text=""></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblNo12A" runat="server" Text="lblNo1A | " /></td>
                <td>
                    <asp:Label ID="lbl12Op" runat="server" Text="lbl1Op | " /></td>
                <td>
                    <asp:Label ID="lblNo12B" runat="server" Text="lblNo1A | " /></td>
                <td>
                <asp:TextBox ID="txtAns12" runat="server"/></td>
                <td>
                    <asp:Image ID="imgAnswer12" runat="server" Height="40px" Width="40px" />
                    <asp:Label ID="Label12" visible="false" runat="server" Text=""></asp:Label>
                </td>
            </tr>

        </table>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Height="145px" Text="Button" Width="220px" OnClick="Button1_Click" />
    &nbsp;
        <script>
            function initialise() {

            clearInterval(x);

            var Timer = new Date(); Timer.setSeconds(Timer.getSeconds() + 30);



            var x = setInterval(function () {


                var now = new Date().getTime();


                var distance = Timer - now;


                var days = Math.floor(distance / (1000 * 60 * 60 * 24));
                var hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
                var minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
                var seconds = Math.floor((distance % (1000 * 60)) / 1000);
                var mseconds = Math.floor((distance % (1000)));


                document.getElementById('demo').innerHTML = seconds + 's' + mseconds + 'ms';

                document.getElementById('lblTimeTaken').innerHTML = seconds + '.' + mseconds ;

        </script>
        
    </form>
</body>
</html>
