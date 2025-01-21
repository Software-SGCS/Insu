<%@ Page Language="vb" AutoEventWireup="false" Codebehind="VehReport1.aspx.vb" Inherits="Insu.VehReport1" %>
<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
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
			<asp:label id="CompanyCode" style="Z-INDEX: 101; LEFT: 32px; POSITION: absolute; TOP: 56px"
				runat="server" Width="105px" Height="24px">Company Code</asp:label>
			<asp:button id="Button1" style="Z-INDEX: 120; LEFT: 400px; POSITION: absolute; TOP: 328px" runat="server"
				Width="88px" Text="Pending  List"></asp:button><asp:textbox id="TxtRTDt" style="Z-INDEX: 115; LEFT: 176px; POSITION: absolute; TOP: 224px" tabIndex="5"
				runat="server" Width="88px" Height="24px"></asp:textbox><asp:textbox id="TxtRFDt" style="Z-INDEX: 114; LEFT: 176px; POSITION: absolute; TOP: 176px" tabIndex="4"
				runat="server" Width="88px" Height="24px"></asp:textbox><asp:label id="Label3" style="Z-INDEX: 113; LEFT: 40px; POSITION: absolute; TOP: 232px" runat="server"
				Width="112px" Height="16px" Font-Bold="True">To Date</asp:label><asp:label id="Label2" style="Z-INDEX: 112; LEFT: 40px; POSITION: absolute; TOP: 184px" runat="server"
				Width="112px" Height="24px" Font-Bold="True">Refund From Date</asp:label><asp:imagebutton id="ImgBtn2" style="Z-INDEX: 111; LEFT: 264px; POSITION: absolute; TOP: 120px" runat="server"
				Width="24px" Height="24px" ImageUrl="file:///C:\Inetpub\wwwroot\Insu\iCO\Cal1.jpg"></asp:imagebutton><asp:textbox id="TxtTdt" style="Z-INDEX: 110; LEFT: 176px; POSITION: absolute; TOP: 120px" tabIndex="3"
				runat="server" Width="88px" Height="24px"></asp:textbox><asp:label id="Label1" style="Z-INDEX: 109; LEFT: 32px; POSITION: absolute; TOP: 128px" runat="server"
				Width="112px" Height="24px" Font-Bold="True">To Date</asp:label><asp:imagebutton id="ImgBtn1" style="Z-INDEX: 108; LEFT: 264px; POSITION: absolute; TOP: 88px" runat="server"
				Width="24px" Height="24px" ImageUrl="file:///C:\Inetpub\wwwroot\Insu\iCO\Cal1.jpg"></asp:imagebutton><asp:calendar id="Calendar2" style="Z-INDEX: 106; LEFT: 296px; POSITION: absolute; TOP: 128px"
				runat="server" Width="185px" Height="184px" ForeColor="Black" BorderColor="White" Font-Size="9pt" NextPrevFormat="FullMonth" BorderWidth="1px" Font-Names="Verdana" Visible="False" BackColor="White">
				<TodayDayStyle BackColor="#CCCCCC"></TodayDayStyle>
				<NextPrevStyle Font-Size="8pt" Font-Bold="True" ForeColor="#333333" VerticalAlign="Bottom"></NextPrevStyle>
				<DayHeaderStyle Font-Size="8pt" Font-Bold="True"></DayHeaderStyle>
				<SelectedDayStyle ForeColor="White" BackColor="#333399"></SelectedDayStyle>
				<TitleStyle Font-Size="12pt" Font-Bold="True" BorderWidth="4px" ForeColor="#333399" BorderColor="Black"
					BackColor="White"></TitleStyle>
				<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
			</asp:calendar><asp:textbox id="TxtFDt" style="Z-INDEX: 104; LEFT: 176px; POSITION: absolute; TOP: 88px" tabIndex="2"
				runat="server" Width="88px" Height="24px"></asp:textbox><asp:label id="Label12" style="Z-INDEX: 105; LEFT: 32px; POSITION: absolute; TOP: 96px" runat="server"
				Width="112px" Height="24px" Font-Bold="True">From Date</asp:label><asp:calendar id="Calendar1" style="Z-INDEX: 107; LEFT: 296px; POSITION: absolute; TOP: 96px"
				runat="server" Width="185px" Height="184px" ForeColor="Black" BorderColor="White" Font-Size="9pt" NextPrevFormat="FullMonth" BorderWidth="1px" Font-Names="Verdana"
				Visible="False" BackColor="White">
				<TodayDayStyle BackColor="#CCCCCC"></TodayDayStyle>
				<NextPrevStyle Font-Size="8pt" Font-Bold="True" ForeColor="#333333" VerticalAlign="Bottom"></NextPrevStyle>
				<DayHeaderStyle Font-Size="8pt" Font-Bold="True"></DayHeaderStyle>
				<SelectedDayStyle ForeColor="White" BackColor="#333399"></SelectedDayStyle>
				<TitleStyle Font-Size="12pt" Font-Bold="True" BorderWidth="4px" ForeColor="#333399" BorderColor="Black"
					BackColor="White"></TitleStyle>
				<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
			</asp:calendar><asp:button id="ImgBtn3" style="Z-INDEX: 102; LEFT: 32px; POSITION: absolute; TOP: 328px" tabIndex="6"
				runat="server" Width="96px" Height="24px" Text="View Lettter"></asp:button><asp:dropdownlist id="LstCom" style="Z-INDEX: 100; LEFT: 176px; POSITION: absolute; TOP: 56px" runat="server"
				Width="320px" Height="32px"></asp:dropdownlist><cr:crystalreportviewer id="CrystalReportViewer2" style="Z-INDEX: 103; LEFT: -296px; POSITION: absolute; TOP: 96px"
				runat="server" Width="350px" Height="50px" Visible="False" HasRefreshButton="True" DisplayToolbar="False"></cr:crystalreportviewer><asp:button id="Butt2" style="Z-INDEX: 116; LEFT: 256px; POSITION: absolute; TOP: 328px" runat="server"
				Width="96px" Height="24px" Text="Refund List"></asp:button><asp:button id="Butt1" style="Z-INDEX: 118; LEFT: 144px; POSITION: absolute; TOP: 328px" runat="server"
				Width="88px" Text="Detail List"></asp:button>
			<asp:Label id="L1" style="Z-INDEX: 119; LEFT: 40px; POSITION: absolute; TOP: 432px" runat="server"
				Height="24px" Width="72px" Visible="False">Label</asp:Label></FORM>
	</body>
</HTML>
