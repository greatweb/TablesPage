<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Welcome To The Tables Website</h1>
        <p class="lead">Use This Website To Learn Your Tables And Track Your Progress. To Get Started Login Or Create An Account</p>
        <%--<p><a href="TablesMenu4.aspx" class="btn btn-primary btn-lg">Get Started &raquo;</a></p>--%>
        <asp:Button ID="btnGetStarted" runat="server" Class="btn btn-primary btn-lg" Text="Get Started" OnClick="btnGetStarted_Click" />
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>
                Start By Logging In Or Signing Up For An Account</p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
            <p>
                &nbsp;</p>
        </div>
        <div class="col-md-4">
            <h2>Results</h2>
            <p>
                You Can See Your Results By Clicking On The Results Button Under The Other Buttons In The Tables Menu And Selecting The Tables You Want To View Your Results</p>
            <p>
                <a class="btn btn-default" href="GraphMenu.aspx">Results &raquo;</a>
            </p>
        </div>
    </div>
</asp:Content>
