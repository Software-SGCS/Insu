<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="AdminReport1.aspx.vb" Inherits="Insu.AdminReport1"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>AdminReport1</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:button id="Button1" style="Z-INDEX: 100; LEFT: 16px; POSITION: absolute; TOP: 16px" runat="server"
				Width="104px" Text="Employee List" Font-Names="Calibri" Font-Size="X-Small"></asp:button>
			<asp:button id="Button7" style="Z-INDEX: 119; LEFT: 16px; POSITION: absolute; TOP: 80px" runat="server"
				Font-Size="X-Small" Font-Names="Calibri" Text="View Grn" Width="104px"></asp:button>
			<DIV id="Layer1" style="Z-INDEX: 118; LEFT: 208px; OVERFLOW: scroll; WIDTH: 954px; POSITION: absolute; TOP: 8px; HEIGHT: 536px">
				<CR:CRYSTALREPORTVIEWER id="CRYSTALREPORTVIEWER1" runat="server" Width="350px" Height="50px" SeparatePages="False"
					EnableDrillDown="False" DisplayGroupTree="False" DisplayToolbar="False" Visible="False"></CR:CRYSTALREPORTVIEWER></DIV>
			<asp:button id="Button6" style="Z-INDEX: 117; LEFT: 16px; POSITION: absolute; TOP: 296px" runat="server"
				Width="160px" Text="Summery-Employees"></asp:button><asp:button id="Button5" style="Z-INDEX: 116; LEFT: 16px; POSITION: absolute; TOP: 48px" runat="server"
				Width="104px" Text="Item Stock" Font-Names="Calibri" Font-Size="X-Small"></asp:button><asp:button id="Button4" style="Z-INDEX: 114; LEFT: 16px; POSITION: absolute; TOP: 264px" runat="server"
				Width="160px" Text="View Entries -Summery"></asp:button><asp:label id="Label1" style="Z-INDEX: 113; LEFT: 16px; POSITION: absolute; TOP: 160px" runat="server"
				Width="56px" Font-Names="Calibri" Font-Size="X-Small" Height="16px">To Date</asp:label><asp:button id="Button3" style="Z-INDEX: 112; LEFT: 16px; POSITION: absolute; TOP: 232px" runat="server"
				Width="160px" Text="View Entries -Depatment"></asp:button><asp:imagebutton id="btt1" style="Z-INDEX: 111; LEFT: 160px; POSITION: absolute; TOP: 136px" runat="server"
				Width="24px" Height="20px" ImageUrl="iCO\Cal1.jpg"></asp:imagebutton><asp:imagebutton id="BTT2" style="Z-INDEX: 106; LEFT: 160px; POSITION: absolute; TOP: 168px" runat="server"
				Width="24px" Height="20px" ImageUrl="iCO\Cal1.jpg"></asp:imagebutton><asp:textbox id="TxtFdt" style="Z-INDEX: 110; LEFT: 80px; POSITION: absolute; TOP: 136px" runat="server"
				Width="80px" Font-Names="Calibri" Font-Size="X-Small" Height="20px" AutoPostBack="True"></asp:textbox><asp:label id="aa" style="Z-INDEX: 107; LEFT: 16px; POSITION: absolute; TOP: 136px" runat="server"
				Width="80px" Font-Names="Calibri" Font-Size="X-Small" Height="16px">From Date</asp:label><asp:calendar id="Calendar1" style="Z-INDEX: 108; LEFT: 16px; POSITION: absolute; TOP: 376px"
				runat="server" Width="128px" Font-Names="Times New Roman" Font-Size="10pt" Height="91px" BackColor="White" ForeColor="Black" BorderColor="Black" DayNameFormat="FirstLetter" TitleFormat="Month"
				NextPrevFormat="FullMonth">
				<TodayDayStyle BackColor="#CCCC99"></TodayDayStyle>
				<SelectorStyle Font-Size="8pt" Font-Names="Verdana" Font-Bold="True" ForeColor="#333333" Width="1%"
					BackColor="#CCCCCC"></SelectorStyle>
				<DayStyle Width="14%"></DayStyle>
				<NextPrevStyle Font-Size="8pt" ForeColor="White"></NextPrevStyle>
				<DayHeaderStyle Font-Size="7pt" Font-Names="Verdana" Font-Bold="True" Height="10px" ForeColor="#333333"
					BackColor="#CCCCCC"></DayHeaderStyle>
				<SelectedDayStyle ForeColor="White" BackColor="#CC3333"></SelectedDayStyle>
				<TitleStyle Font-Size="13pt" Font-Bold="True" Height="14pt" ForeColor="White" BackColor="Black"></TitleStyle>
				<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
			</asp:calendar><asp:textbox id="TxtTdt" style="Z-INDEX: 105; LEFT: 80px; POSITION: absolute; TOP: 168px" runat="server"
				Width="80px" Font-Names="Calibri" Height="20px" AutoPostBack="True"></asp:textbox><asp:calendar id="Calendar2" style="Z-INDEX: 109; LEFT: 16px; POSITION: absolute; TOP: 376px"
				runat="server" Width="152px" Font-Names="Times New Roman" Font-Size="10pt" Height="139px" BackColor="White" ForeColor="Black" BorderColor="Black" DayNameFormat="FirstLetter" TitleFormat="Month"
				NextPrevFormat="FullMonth">
				<TodayDayStyle BackColor="#CCCC99"></TodayDayStyle>
				<SelectorStyle Font-Size="8pt" Font-Names="Verdana" Font-Bold="True" ForeColor="#333333" Width="1%"
					BackColor="#CCCCCC"></SelectorStyle>
				<DayStyle Width="14%"></DayStyle>
				<NextPrevStyle Font-Size="8pt" ForeColor="White"></NextPrevStyle>
				<DayHeaderStyle Font-Size="7pt" Font-Names="Verdana" Font-Bold="True" Height="10px" ForeColor="#333333"
					BackColor="#CCCCCC"></DayHeaderStyle>
				<SelectedDayStyle ForeColor="White" BackColor="#CC3333"></SelectedDayStyle>
				<TitleStyle Font-Size="13pt" Font-Bold="True" Height="14pt" ForeColor="White" BackColor="Black"></TitleStyle>
				<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
			</asp:calendar><asp:imagebutton id="ImageButton1" style="Z-INDEX: 103; LEFT: 16px; POSITION: absolute; TOP: 344px"
				runat="server" Width="80px" Height="24px" ImageUrl="Menu\print.jpg"></asp:imagebutton><asp:imagebutton id="ImageButton2" style="Z-INDEX: 102; LEFT: 96px; POSITION: absolute; TOP: 344px"
				runat="server" Width="78px" Height="24px" ImageUrl="iCO\xls.jpg"></asp:imagebutton><asp:button id="Button2" style="Z-INDEX: 101; LEFT: 16px; POSITION: absolute; TOP: 200px" runat="server"
				Width="160px" Text="View Entries"></asp:button><asp:textbox id="TxtPage" style="Z-INDEX: 104; LEFT: 144px; POSITION: absolute; TOP: 16px" runat="server"
				Width="64px" Visible="False"></asp:textbox></form>
	</body>
</HTML>
