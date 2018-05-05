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
        <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource2" Height="425px" Width="436px" BorderlineWidth="30">
            <series>
                <asp:Series ChartType="Line" Name="Series1" XValueMember="TablesScoreID" YValueMembers="Score" ToolTip="Value of X: #VALX Value of Y #VALY" YValuesPerPoint="4">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
                <asp:Chart ID="chtSalesPerDOW" runat="server" Width="1000px" Height="350px"> 
   <Series> 
      <asp:Series Palette="EarthTones" ChartArea="MainChartArea" ToolTip="You scored (#VALY/12) in #VALX " YValuesPerPoint="2"></asp:Series> 
   </Series> 
    
   <ChartAreas> 
      <asp:ChartArea Name="MainChartArea" Area3DStyle-Enable3D="true"> 
<Area3DStyle Enable3D="True"></Area3DStyle>
      </asp:ChartArea> 
   </ChartAreas> 
</asp:Chart>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:MaximGameConnectionString %>" SelectCommand="SELECT [Score], [TablesScoreID] FROM [tablesScore2]"></asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:MaximGameConnectionString %>" SelectCommand="SELECT [Score], [DateAndTime] FROM [tablesScore2]"></asp:SqlDataSource>
    </form>
</body>
</html>
