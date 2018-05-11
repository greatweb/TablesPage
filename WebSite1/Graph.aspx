<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="Site.master" CodeFile="Graph.aspx.cs" Inherits="Default4" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <asp:PlaceHolder runat="server">
    <link href="CSS/CoolCSS.css" rel="stylesheet" />
    </asp:PlaceHolder>

        <%--Start Of 3D Chart--%>
    <div style="width: 724px; float:right">
    <asp:Label ID="Info" Class="InfoClass" runat="server" Text=""></asp:Label>
        </div>
                <asp:Chart ID="ScoreAndSession" runat="server" Width="1135px" Height="483px" OnLoad="ScoreAndSession_Load" Palette="Fire" ValidateRequestMode="Disabled"> 
   <Series> 
      <asp:Series Palette="Berry" ChartArea="MainChartArea" ToolTip="You scored (#VALY/12) in #VALX " YValuesPerPoint="3" Name="Series1"></asp:Series> 
   </Series> 
    
   <ChartAreas> 
      <asp:ChartArea Name="MainChartArea"> 
          <AxisY Interval="1" Title="Score">
          </AxisY>
          <AxisX Title="Session">
          </AxisX>
<Area3DStyle Enable3D="True"></Area3DStyle>
      </asp:ChartArea> 
   </ChartAreas> 
</asp:Chart>
        <%--End Of 3D Chart--%>
    &nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:MaximGameConnectionString %>" SelectCommand="SELECT [Score], [TablesScoreID] FROM [tablesScore2]"></asp:SqlDataSource>      
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MaximGameConnectionString %>" SelectCommand="SELECT [Score], [DateAndTime] FROM [tablesScore2]"></asp:SqlDataSource>

    </asp:Content>