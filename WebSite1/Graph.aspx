<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Graph.aspx.cs" Inherits="Default4" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>

        <%--Start Of 3D Chart--%>
                <asp:Chart ID="ScoreAndSession" runat="server" Width="1000px" Height="350px" OnLoad="ScoreAndSession_Load"> 
   <Series> 
      <asp:Series Palette="EarthTones" ChartArea="MainChartArea" ToolTip="You scored (#VALY/12) in #VALX " YValuesPerPoint="2"></asp:Series> 
   </Series> 
    
   <ChartAreas> 
      <asp:ChartArea Name="MainChartArea" Area3DStyle-Enable3D="true"> 
<Area3DStyle Enable3D="True"></Area3DStyle>
      </asp:ChartArea> 
   </ChartAreas> 
</asp:Chart>
        <%--End Of 3D Chart--%>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:MaximGameConnectionString %>" SelectCommand="SELECT [Score], [TablesScoreID] FROM [tablesScore2]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MaximGameConnectionString %>" SelectCommand="SELECT [Score], [DateAndTime] FROM [tablesScore2]"></asp:SqlDataSource>
    </form>
</body>
</html>
