<%@ Page Language="C#" AutoEventWireup="true" CodeFile="TablesPage.aspx.cs" Inherits="Default3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="CSS/StyleSheet1.css" rel="stylesheet" />
    <title>Tables</title>
    <style type="text/css">
        #err {
            width: 227px;
            margin-bottom: 3px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <nav>
                <ul>
                    <li><a href="ClickerPage.aspx">Home</a></li>
                    <li><a href="TablesMenu.aspx">Tables</a></li>
                </ul>
            </nav>
        </div>

        <br />
        <h2 id="demo" style="float:right; color: black;"></h2>

        <br />
        <br />

        <div class="tables">


            <asp:Label ID="Label1x1" runat="server" Text="1 x 1 ="></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <h5 id="err"></h5>
        <div id="div2" style="font-size: 18px; width: 500px; float: right; height: 314px; margin-top: 0px;">
            <asp:Label ID="Label1x7" runat="server" Text="1 x 7 ="></asp:Label>
            <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            <p>
                <asp:Label ID="Label1x8" runat="server" Text="1 x 8 ="></asp:Label>
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
            </p>
            <asp:Label ID="Label1x9" runat="server" Text="1 x 9 ="></asp:Label>

            <asp:TextBox ID="TextBox12" runat="server"></asp:TextBox>

            <p>
                <asp:Label ID="Label1x10" runat="server" Text="1 x 10 ="></asp:Label>
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            </p>
            <p>
                <asp:Label ID="Label1x11" runat="server" Text="1 x 11 ="></asp:Label>
                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
            </p>

            <p>
                <asp:Label ID="Label1x12" runat="server" Text="1 x 12 = "></asp:Label>
                <asp:TextBox ID="TextBox11" runat="server"></asp:TextBox>
            </p>
        </div>
            <p>
                <asp:Label ID="Label1x2" runat="server" Text="1 x 2 ="></asp:Label>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </p>
            <asp:Label ID="Label1x3" runat="server" Text="1 x 3 ="></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <p>
                <asp:Label ID="Label1x4" runat="server" Text="1 x 4 ="></asp:Label>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </p>
            <asp:Label ID="Label1x5" runat="server" Text="1 x 5 ="></asp:Label>
            <asp:TextBox ID="TextBox1x5" runat="server"></asp:TextBox>

            <p>
                <asp:Label ID="Label1x6" runat="server" Text="1 x 6 ="></asp:Label>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </p>
        </div>


        <button type="button" id="button2" runat="server" onclick="check()" class="buttonTables">Confirm</button>
         &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <button type="button" id="button1" onclick="initialise()" class="buttonTables">Start</button>

    </form>
    <script>
        function check() {
            var a = document.getElementById("textbox1");
            if (a.value == "1") {
                document.getElementById('err').innerHTML = 'correct';
            }
            else {
                document.getElementById('err').innerHTML = 'wrong';
            }
        }
        function initialise() {

            clearInterval(x);

            document.getElementById("button1").disabled = false;

            var Timer = new Date(); Timer.setSeconds(Timer.getSeconds() + 10);



            var x = setInterval(function () {


                var now = new Date().getTime();


                var distance = Timer - now;


                var days = Math.floor(distance / (1000 * 60 * 60 * 24));
                var hours = Math.floor((distance % (1000 * 60 * 60 * 24)) / (1000 * 60 * 60));
                var minutes = Math.floor((distance % (1000 * 60 * 60)) / (1000 * 60));
                var seconds = Math.floor((distance % (1000 * 60)) / 1000);
                var mseconds = Math.floor((distance % (1000)));


                document.getElementById("demo").innerHTML = seconds + "s " + mseconds + "ms";


                if (distance < 0) {
                    clearInterval(x);
                    document.getElementById("demo").innerHTML = "Time Up";
                    document.getElementById("button1").disabled = false;
                    document.getElementById("TextBox1").disabled = true;
                    document.getElementById("TextBox2").disabled = true;
                    document.getElementById("TextBox3").disabled = true;
                    document.getElementById("TextBox4").disabled = true;
                    document.getElementById("TextBox1x5").disabled = true;
                    document.getElementById("TextBox6").disabled = true;
                    document.getElementById("TextBox7").disabled = true;
                    document.getElementById("TextBox8").disabled = true;
                    document.getElementById("TextBox9").disabled = true;
                    document.getElementById("TextBox10").disabled = true;
                    document.getElementById("TextBox11").disabled = true;
                    document.getElementById("TextBox12").disabled = true;
                }
            }, 10);
            if (distance = 10) {
                document.getElementById("button1").disabled = true;
                document.getElementById("TextBox1").disabled = false;
                document.getElementById("TextBox2").disabled = false;
                document.getElementById("TextBox3").disabled = false;
                document.getElementById("TextBox4").disabled = false;
                document.getElementById("TextBox1x5").disabled = false;
                document.getElementById("TextBox6").disabled = false;
                document.getElementById("TextBox7").disabled = false;
                document.getElementById("TextBox8").disabled = false;
                document.getElementById("TextBox9").disabled = false;
                document.getElementById("TextBox10").disabled = false;
                document.getElementById("TextBox11").disabled = false;
                document.getElementById("TextBox12").disabled = false;
            }


        }

    </script>
</body>
</html>
