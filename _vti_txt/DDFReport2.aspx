<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="DDFReport2.aspx.vb" Inherits="Insu.DDFReport2" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>HealthReport1</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:imagebutton id="ImageButton1" style="Z-INDEX: 104; LEFT: 824px; POSITION: absolute; TOP: 80px"
				runat="server" Height="24px" Width="80px" ImageUrl="Menu\print.jpg" Visible="False"></asp:imagebutton>
			<asp:button id="Button11" style="Z-INDEX: 129; LEFT: 504px; POSITION: absolute; TOP: 168px"
				runat="server" Width="96px" Height="24px" Text="Report 1-Pdf"></asp:button>
			<asp:button id="Button13" style="Z-INDEX: 128; LEFT: 432px; POSITION: absolute; TOP: 360px"
				runat="server" Width="144px" Height="24px" Text="Premium Report2 -PDF"></asp:button>
			<asp:button id="Button12" style="Z-INDEX: 127; LEFT: 272px; POSITION: absolute; TOP: 360px"
				runat="server" Width="144px" Height="24px" Text="Premium Report2 -XLS"></asp:button>
			<asp:button id="Button10" style="Z-INDEX: 126; LEFT: 272px; POSITION: absolute; TOP: 328px"
				runat="server" Width="144px" Height="24px" Text="Premium Report1 -XLS"></asp:button>
			<asp:button id="Button9" style="Z-INDEX: 125; LEFT: 432px; POSITION: absolute; TOP: 328px" runat="server"
				Width="144px" Height="24px" Text="Premium Report1 -PDF"></asp:button>
			<asp:label id="Label4" style="Z-INDEX: 124; LEFT: 136px; POSITION: absolute; TOP: 328px" runat="server"
				Width="56px" Height="24px">Year</asp:label>
			<asp:textbox id="Txtyr" style="Z-INDEX: 123; LEFT: 208px; POSITION: absolute; TOP: 328px" runat="server"
				Width="48px"></asp:textbox><asp:button id="Button8" style="Z-INDEX: 122; LEFT: 368px; POSITION: absolute; TOP: 288px" runat="server"
				Height="24px" Width="96px" Text="Summery-Email"></asp:button><asp:button id="Button7" style="Z-INDEX: 120; LEFT: 240px; POSITION: absolute; TOP: 288px" runat="server"
				Height="24px" Width="96px" Text="Summery-Pdf"></asp:button><asp:button id="Button6" style="Z-INDEX: 119; LEFT: 128px; POSITION: absolute; TOP: 288px" runat="server"
				Height="24px" Width="104px" Text="Summery-Excell"></asp:button><asp:button id="Button5" style="Z-INDEX: 118; LEFT: 240px; POSITION: absolute; TOP: 240px" runat="server"
				Width="96px" Text="Report 3-Pdf"></asp:button><asp:button id="Button4" style="Z-INDEX: 117; LEFT: 128px; POSITION: absolute; TOP: 240px" runat="server"
				Height="24px" Width="104px" Text="Report 3-Excell"></asp:button><asp:button id="Button2" style="Z-INDEX: 115; LEFT: 128px; POSITION: absolute; TOP: 200px" runat="server"
				Height="24px" Width="104px" Text="Report 2-Excell"></asp:button><asp:button id="Button1" style="Z-INDEX: 113; LEFT: 240px; POSITION: absolute; TOP: 160px" runat="server"
				Height="24px" Width="96px" Text="Report 1-Pdf"></asp:button><asp:textbox id="TxtTdt" style="Z-INDEX: 112; LEFT: 528px; POSITION: absolute; TOP: 80px" runat="server"
				Width="80px"></asp:textbox><asp:imagebutton id="Imagebutton2" style="Z-INDEX: 111; LEFT: 608px; POSITION: absolute; TOP: 80px"
				runat="server" Height="24px" Width="24px" ImageUrl="iCO\Cal1.jpg"></asp:imagebutton><asp:calendar id="Calendar2" style="Z-INDEX: 109; LEFT: 632px; POSITION: absolute; TOP: 80px"
				runat="server" Height="109px" Width="152px" BorderWidth="1px" BackColor="White" ForeColor="#003399" Font-Size="8pt" Font-Names="Verdana" BorderColor="#3366CC" DayNameFormat="FirstLetter"
				CellPadding="1">
				<TodayDayStyle ForeColor="White" BackColor="#99CCCC"></TodayDayStyle>
				<SelectorStyle ForeColor="#336666" BackColor="#99CCCC"></SelectorStyle>
				<NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF"></NextPrevStyle>
				<DayHeaderStyle Height="1px" ForeColor="#336666" BackColor="#99CCCC"></DayHeaderStyle>
				<SelectedDayStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedDayStyle>
				<TitleStyle Font-Size="10pt" Font-Bold="True" Height="25px" BorderWidth="1px" ForeColor="#CCCCFF"
					BorderStyle="Solid" BorderColor="#3366CC" BackColor="#003399"></TitleStyle>
				<WeekendDayStyle BackColor="#CCCCFF"></WeekendDayStyle>
				<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
			</asp:calendar><asp:imagebutton id="btt1" style="Z-INDEX: 110; LEFT: 304px; POSITION: absolute; TOP: 80px" runat="server"
				Height="24px" Width="24px" ImageUrl="iCO\Cal1.jpg"></asp:imagebutton><asp:calendar id="Calendar1" style="Z-INDEX: 108; LEFT: 336px; POSITION: absolute; TOP: 80px"
				runat="server" Height="104px" Width="152px" BorderWidth="1px" BackColor="White" ForeColor="#003399" Font-Size="8pt" Font-Names="Verdana" BorderColor="#3366CC" DayNameFormat="FirstLetter"
				CellPadding="1">
				<TodayDayStyle ForeColor="White" BackColor="#99CCCC"></TodayDayStyle>
				<SelectorStyle ForeColor="#336666" BackColor="#99CCCC"></SelectorStyle>
				<NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF"></NextPrevStyle>
				<DayHeaderStyle Height="1px" ForeColor="#336666" BackColor="#99CCCC"></DayHeaderStyle>
				<SelectedDayStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedDayStyle>
				<TitleStyle Font-Size="10pt" Font-Bold="True" Height="25px" BorderWidth="1px" ForeColor="#CCCCFF"
					BorderStyle="Solid" BorderColor="#3366CC" BackColor="#003399"></TitleStyle>
				<WeekendDayStyle BackColor="#CCCCFF"></WeekendDayStyle>
				<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
			</asp:calendar><asp:label id="Label3" style="Z-INDEX: 106; LEFT: 456px; POSITION: absolute; TOP: 80px" runat="server"
				Height="24px" Width="72px">To Date</asp:label><asp:panel id="Panel2" style="Z-INDEX: 102; LEFT: 8px; POSITION: absolute; TOP: 8px" runat="server"
				Height="48px" Width="1030px" BackImageUrl="Menu/banner.jpg"></asp:panel><asp:panel id="Panel1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 56px" runat="server"
				Height="610px" Width="104px" BackImageUrl="Menu/EMPMASTER4.jpg"></asp:panel><asp:button id="Report1" style="Z-INDEX: 100; LEFT: 128px; POSITION: absolute; TOP: 160px" runat="server"
				Height="24px" Width="104px" Text="Report 1-Excell"></asp:button><CR:CRYSTALREPORTVIEWER id="CRYSTALREPORTVIEWER2" style="Z-INDEX: 103; LEFT: -232px; POSITION: absolute; TOP: 88px"
				runat="server" Height="50px" Width="350px" Visible="False" DisplayToolbar="False" SeparatePages="False"></CR:CRYSTALREPORTVIEWER><asp:label id="Label2" style="Z-INDEX: 105; LEFT: 144px; POSITION: absolute; TOP: 80px" runat="server"
				Height="24px" Width="72px">From Date</asp:label><asp:textbox id="TxtFdt" style="Z-INDEX: 107; LEFT: 224px; POSITION: absolute; TOP: 80px" runat="server"
				Width="80px"></asp:textbox><asp:button id="Button3" style="Z-INDEX: 116; LEFT: 240px; POSITION: absolute; TOP: 200px" runat="server"
				Width="96px" Text="Report 2-Pdf"></asp:button><asp:label id="L1" style="Z-INDEX: 121; LEFT: 128px; POSITION: absolute; TOP: 560px" runat="server"
				Width="72px" Visible="False">Label</asp:label></form>
	</body>
</HTML>
