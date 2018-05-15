<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="Site.master" CodeFile="ClickerPage.aspx.cs" Inherits="ClickerPage" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
        <asp:PlaceHolder runat="server">
    <link href="CSS/StyleSheet1.css" rel="stylesheet" />
            </asp:PlaceHolder>

    <div id="div1">
        <asp:TextBox ID="scoreForm" type="hidden" name="score" value="0" runat="server"></asp:TextBox>
            &nbsp;<br />
        &nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox1"  runat="server" placeholder="Name" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
-&nbsp;<br/>
            &nbsp;<br/>
            
        
             &nbsp;<asp:Button ID="Button1" runat="server"   style="margin-left: 15px" Text="Submit Your Score" Width="167px" OnClick="Button1_Click" />

</div>
        <input onclick="window.location.href='leaderboard.aspx'" style="height: 41px; width: 217px; margin-top: 0px;" type="button" value="Leaderboard" /><asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MaximGameConnectionString %>" OnSelecting="SqlDataSource1_Selecting" SelectCommand="SELECT * FROM [Leaderboard]"></asp:SqlDataSource>

         
    <h3>Your Score Is</h3>
    <label for="score" id="score">0</label>
    <h2 id="demo"></h2>
    <button type="button" id="btn" onclick="addScore()">Click Me!</button>

    <button type="button" id="btn2" onclick="initialise()">Reset!</button>

        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
             

    <script> 

        var score = 0;

        function initialise() {


            document.getElementById("score").innerHTML = 0;

            score = 0;

            clearInterval(x);

            document.getElementById("btn").disabled = false;

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
                    document.getElementById("demo").innerHTML = "Game Over";
                    document.getElementById("btn").disabled = true;
                    document.getElementById("btn2").disabled = false;
                    document.getElementById("btn2").style.visibility = 'visible';
                    document.getElementById("btn").disabled = true;
                    document.getElementById("div1").style.visibility = 'visible';


                }
            }, 10);
            if (distance = 10) {
                document.getElementById("btn2").disabled = true;
                document.getElementById("btn2").style.visibility = 'hidden';
                document.getElementById("div1").style.visibility = 'hidden';

            }


        }


        function addScore() {
            score++;
            document.getElementById("score").innerHTML = score;
            document.getElementById("scoreForm").value = score;



        }
        var score = 0;

    </script>

    <script>

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
                document.getElementById("demo").innerHTML = "Game Over";
                document.getElementById("btn").disabled = true;
                document.getElementById("btn2").disabled = false;
                document.getElementById("btn2").style.visibility = 'visible';
                document.getElementById("btn").style.visibility = 'false';
                document.getElementById("div1").style.visibility = 'visible';

            }
        }, 10);
        if (distance = 10) {
            document.getElementById("btn2").disabled = false;
            document.getElementById("btn2").style.visibility = 'hidden';
            document.getElementById("div1").style.visibility = 'hidden';


        }

    </script>
               <style type="text/css">
                   .modalBackground {
    background-color: black;
    filter: alpha(opacity = 90);
    opacity: 0.8;
    left: -15px;
    width: 100%;
    height: 100%;
    min-height: 100vh;
    min-width: 100vw;
}

.modalPopup {
    background-color: white;
    border-width: 3px;
    border-style: solid;
    border-color: black;
    padding-top: 10px;
    padding-left: 10px;
    width: 300px;
    height: 140px;
    
}</style>
    <p>
        &nbsp;</p>
</asp:Content>
