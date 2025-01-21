<%@ Page Language="vb" AutoEventWireup="false" Codebehind="PettyCashReport1.aspx.vb" Inherits="Insu.PettyCashReport1" %>
<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
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
			<asp:calendar id="Calendar3" style="Z-INDEX: 122; LEFT: 256px; POSITION: absolute; TOP: 48px"
				runat="server" Font-Size="10pt" Font-Names="Times New Roman" Width="272px" Height="139px"
				NextPrevFormat="FullMonth" TitleFormat="Month" DayNameFormat="FirstLetter" BorderColor="Black"
				ForeColor="Black" BackColor="White">
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
			</asp:calendar><asp:imagebutton id="Imagebutton3" style="Z-INDEX: 121; LEFT: 224px; POSITION: absolute; TOP: 48px"
				runat="server" Width="24px" Height="20px" ImageUrl="iCO\Cal1.jpg"></asp:imagebutton><asp:textbox id="TxtSDate" style="Z-INDEX: 120; LEFT: 136px; POSITION: absolute; TOP: 48px" runat="server"
				Font-Size="X-Small" Font-Names="Calibri" Width="80px" Height="20px" AutoPostBack="True"></asp:textbox>
			<DIV id="Layer1" style="Z-INDEX: 118; LEFT: 208px; OVERFLOW: scroll; WIDTH: 890px; POSITION: absolute; TOP: 72px; HEIGHT: 536px"><CR:CRYSTALREPORTVIEWER id="CRYSTALREPORTVIEWER1" runat="server" Width="350px" Visible="False" DisplayToolbar="False"
					DisplayGroupTree="False" EnableDrillDown="False" SeparatePages="False" Height="50px"></CR:CRYSTALREPORTVIEWER></DIV>
			<asp:button id="Button5" style="Z-INDEX: 116; LEFT: 16px; POSITION: absolute; TOP: 48px" runat="server"
				Font-Size="X-Small" Font-Names="Calibri" Text="Sign Off Report" Width="104px"></asp:button><asp:imagebutton id="btt1" style="Z-INDEX: 112; LEFT: 704px; POSITION: absolute; TOP: 48px" runat="server"
				Width="24px" Height="20px" ImageUrl="iCO\Cal1.jpg" Visible="False"></asp:imagebutton><asp:imagebutton id="BTT2" style="Z-INDEX: 106; LEFT: 832px; POSITION: absolute; TOP: 48px" runat="server"
				Width="24px" Height="20px" ImageUrl="iCO\Cal1.jpg" Visible="False"></asp:imagebutton><asp:textbox id="TxtFdt" style="Z-INDEX: 111; LEFT: 624px; POSITION: absolute; TOP: 48px" runat="server"
				Font-Size="X-Small" Font-Names="Calibri" Width="80px" Height="20px" AutoPostBack="True" Visible="False"></asp:textbox><asp:calendar id="Calendar1" style="Z-INDEX: 108; LEFT: 16px; POSITION: absolute; TOP: 376px"
				runat="server" Font-Size="10pt" Font-Names="Times New Roman" Width="128px" Height="91px" NextPrevFormat="FullMonth" TitleFormat="Month" DayNameFormat="FirstLetter" BorderColor="Black" ForeColor="Black" BackColor="White">
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
			</asp:calendar><asp:textbox id="TxtTdt" style="Z-INDEX: 105; LEFT: 752px; POSITION: absolute; TOP: 48px" runat="server"
				Font-Names="Calibri" Width="80px" Height="20px" AutoPostBack="True" Visible="False"></asp:textbox><asp:calendar id="Calendar2" style="Z-INDEX: 110; LEFT: 16px; POSITION: absolute; TOP: 376px"
				runat="server" Font-Size="10pt" Font-Names="Times New Roman" Width="152px" Height="139px" NextPrevFormat="FullMonth" TitleFormat="Month" DayNameFormat="FirstLetter" BorderColor="Black" ForeColor="Black"
				BackColor="White">
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
				runat="server" Width="78px" Height="24px" ImageUrl="iCO\xls.jpg"></asp:imagebutton><asp:textbox id="TxtPage" style="Z-INDEX: 104; LEFT: 32px; POSITION: absolute; TOP: 80px" runat="server"
				Width="64px" Visible="False"></asp:textbox></form>
	</body>
</HTML>
