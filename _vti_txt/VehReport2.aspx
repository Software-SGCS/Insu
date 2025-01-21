<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="VehReport2.aspx.vb" Inherits="Insu.VehReport2" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Payment Notice List</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<FORM id="Form1" method="post" runat="server">
			<asp:label id="CompanyCode" style="Z-INDEX: 102; LEFT: 32px; POSITION: absolute; TOP: 56px"
				runat="server" Height="24px" Width="105px">Company Code</asp:label>
			<asp:calendar id="Calendar1" style="Z-INDEX: 113; LEFT: 296px; POSITION: absolute; TOP: 88px"
				runat="server" Width="185px" Height="184px" ForeColor="Black" BorderColor="White" Font-Size="9pt"
				NextPrevFormat="FullMonth" BorderWidth="1px" Font-Names="Verdana" Visible="False" BackColor="White">
				<TodayDayStyle BackColor="#CCCCCC"></TodayDayStyle>
				<NextPrevStyle Font-Size="8pt" Font-Bold="True" ForeColor="#333333" VerticalAlign="Bottom"></NextPrevStyle>
				<DayHeaderStyle Font-Size="8pt" Font-Bold="True"></DayHeaderStyle>
				<SelectedDayStyle ForeColor="White" BackColor="#333399"></SelectedDayStyle>
				<TitleStyle Font-Size="12pt" Font-Bold="True" BorderWidth="4px" ForeColor="#333399" BorderColor="Black"
					BackColor="White"></TitleStyle>
				<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
			</asp:calendar><asp:imagebutton id="ImgBtn2" style="Z-INDEX: 111; LEFT: 264px; POSITION: absolute; TOP: 120px" runat="server"
				Height="24px" Width="24px" ImageUrl="file:///C:\Inetpub\wwwroot\Insu\iCO\Cal1.jpg"></asp:imagebutton><asp:textbox id="TxtTdt" style="Z-INDEX: 110; LEFT: 176px; POSITION: absolute; TOP: 120px" tabIndex="3"
				runat="server" Height="24px" Width="88px"></asp:textbox><asp:label id="Label1" style="Z-INDEX: 109; LEFT: 32px; POSITION: absolute; TOP: 128px" runat="server"
				Height="24px" Width="112px" Font-Bold="True">To Date</asp:label><asp:imagebutton id="ImgBtn1" style="Z-INDEX: 108; LEFT: 264px; POSITION: absolute; TOP: 88px" runat="server"
				Height="24px" Width="24px" ImageUrl="file:///C:\Inetpub\wwwroot\Insu\iCO\Cal1.jpg"></asp:imagebutton><asp:calendar id="Calendar2" style="Z-INDEX: 107; LEFT: 296px; POSITION: absolute; TOP: 128px"
				runat="server" Height="184px" Width="185px" BackColor="White" Visible="False" Font-Names="Verdana" BorderWidth="1px" NextPrevFormat="FullMonth" Font-Size="9pt" BorderColor="White" ForeColor="Black">
				<TodayDayStyle BackColor="#CCCCCC"></TodayDayStyle>
				<NextPrevStyle Font-Size="8pt" Font-Bold="True" ForeColor="#333333" VerticalAlign="Bottom"></NextPrevStyle>
				<DayHeaderStyle Font-Size="8pt" Font-Bold="True"></DayHeaderStyle>
				<SelectedDayStyle ForeColor="White" BackColor="#333399"></SelectedDayStyle>
				<TitleStyle Font-Size="12pt" Font-Bold="True" BorderWidth="4px" ForeColor="#333399" BorderColor="Black"
					BackColor="White"></TitleStyle>
				<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
			</asp:calendar><asp:textbox id="TxtFDt" style="Z-INDEX: 105; LEFT: 176px; POSITION: absolute; TOP: 88px" tabIndex="2"
				runat="server" Height="24px" Width="88px"></asp:textbox><asp:label id="Label12" style="Z-INDEX: 106; LEFT: 32px; POSITION: absolute; TOP: 96px" runat="server"
				Height="24px" Width="112px" Font-Bold="True">From Date</asp:label><asp:button id="ImgBtn3" style="Z-INDEX: 103; LEFT: 40px; POSITION: absolute; TOP: 200px" tabIndex="6"
				runat="server" Height="24px" Width="96px" Text="View Lettter"></asp:button><asp:dropdownlist id="LstCom" style="Z-INDEX: 101; LEFT: 176px; POSITION: absolute; TOP: 56px" runat="server"
				Height="32px" Width="320px"></asp:dropdownlist><cr:crystalreportviewer id="CrystalReportViewer2" style="Z-INDEX: 104; LEFT: -336px; POSITION: absolute; TOP: 96px"
				runat="server" Height="50px" Width="350px" Visible="False" DisplayToolbar="False" HasRefreshButton="True"></cr:crystalreportviewer><asp:button id="Butt1" style="Z-INDEX: 112; LEFT: 160px; POSITION: absolute; TOP: 200px" runat="server"
				Width="88px" Text="Detail List"></asp:button>
			<asp:Label id="L1" style="Z-INDEX: 114; LEFT: 72px; POSITION: absolute; TOP: 392px" runat="server"
				Width="96px" Height="24px" Visible="False">Label</asp:Label></FORM>
	</body>
</HTML>
