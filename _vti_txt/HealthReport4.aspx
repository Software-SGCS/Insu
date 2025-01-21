<%@ Page Language="vb" AutoEventWireup="false" Codebehind="HealthReport4.aspx.vb" Inherits="Insu.HealthReport4" %>
<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
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
			<asp:button id="Button1" style="Z-INDEX: 102; LEFT: 152px; POSITION: absolute; TOP: 392px" runat="server"
				Height="24px" Width="144px" Text="Employee List1" Visible="False"></asp:button><asp:label id="Label3" style="Z-INDEX: 140; LEFT: 152px; POSITION: absolute; TOP: 432px" runat="server"
				Height="16px" Width="96px">Renewal Date</asp:label><asp:imagebutton id="Imgbtt5" style="Z-INDEX: 139; LEFT: 320px; POSITION: absolute; TOP: 432px" runat="server"
				Height="24px" Width="24px" ImageUrl="iCO\Cal1.jpg"></asp:imagebutton><asp:calendar id="Calendar3" style="Z-INDEX: 115; LEFT: 344px; POSITION: absolute; TOP: 432px"
				runat="server" Height="96px" Width="152px" BorderWidth="1px" BackColor="White" ForeColor="#003399" Font-Size="8pt" Font-Names="Verdana" BorderColor="#3366CC" DayNameFormat="FirstLetter"
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
			</asp:calendar><asp:textbox id="TxtRdt" style="Z-INDEX: 138; LEFT: 248px; POSITION: absolute; TOP: 432px" runat="server"
				Height="24px" Width="72px"></asp:textbox><asp:button id="Button15" style="Z-INDEX: 135; LEFT: 536px; POSITION: absolute; TOP: 352px"
				runat="server" Width="144px" Text="Not Payble-Indoor"></asp:button><asp:button id="Button14" style="Z-INDEX: 134; LEFT: 352px; POSITION: absolute; TOP: 352px"
				runat="server" Width="144px" Text="Not Payble-Outdoor"></asp:button><asp:button id="Button13" style="Z-INDEX: 133; LEFT: 152px; POSITION: absolute; TOP: 352px"
				runat="server" Width="184px" Text="Not Payble"></asp:button><asp:button id="Button12" style="Z-INDEX: 132; LEFT: 152px; POSITION: absolute; TOP: 312px"
				runat="server" Width="184px" Text="Summery"></asp:button><asp:imagebutton id="Imagebutton3" style="Z-INDEX: 131; LEFT: 816px; POSITION: absolute; TOP: 64px"
				runat="server" Height="24px" Width="80px" ImageUrl="Menu\Images11.jpg"></asp:imagebutton><asp:button id="Button11" style="Z-INDEX: 130; LEFT: 152px; POSITION: absolute; TOP: 160px"
				runat="server" Height="24px" Width="184px" Text="Epfno Changers"></asp:button><asp:panel id="Panel3" style="Z-INDEX: 129; LEFT: 8px; POSITION: absolute; TOP: 688px" runat="server"
				Height="72px" Width="1052px" BackImageUrl="Menu/EMPMASTER4.jpg">
				<asp:Label id="QWQW" style="Z-INDEX: 101; LEFT: 672px; POSITION: absolute; TOP: 0px" runat="server"
					Width="32px" Height="24px">Label</asp:Label>
			</asp:panel><asp:dropdownlist id="DropDownList1" style="Z-INDEX: 125; LEFT: 280px; POSITION: absolute; TOP: 152px"
				runat="server" Height="32px" Width="176px" AutoPostBack="True"></asp:dropdownlist><asp:button id="Button9" style="Z-INDEX: 124; LEFT: 416px; POSITION: absolute; TOP: 256px" runat="server"
				Height="24px" Width="210px" Text="Recieved Claims Create Text File" Visible="False"></asp:button>
			<DIV id="Layer1" style="Z-INDEX: 121; LEFT: 120px; OVERFLOW: scroll; WIDTH: 928px; POSITION: absolute; TOP: 352px; HEIGHT: 325px"><CR:CRYSTALREPORTVIEWER id="CrystalReportViewer2" runat="server" Height="50px" Width="350px" Visible="False"
					DisplayToolbar="False" EnableDrillDown="False" SeparatePages="False" DisplayGroupTree="False"></CR:CRYSTALREPORTVIEWER></DIV>
			<asp:button id="Button7" style="Z-INDEX: 119; LEFT: 152px; POSITION: absolute; TOP: 208px" runat="server"
				Height="24px" Width="184px" Text="New Dependers"></asp:button><asp:imagebutton id="BTT2" style="Z-INDEX: 112; LEFT: 528px; POSITION: absolute; TOP: 72px" runat="server"
				Height="24px" Width="24px" ImageUrl="iCO\Cal1.jpg"></asp:imagebutton><asp:textbox id="TxtTdt" style="Z-INDEX: 111; LEFT: 440px; POSITION: absolute; TOP: 72px" runat="server"
				Height="24px" Width="88px"></asp:textbox><asp:imagebutton id="btt1" style="Z-INDEX: 110; LEFT: 320px; POSITION: absolute; TOP: 72px" runat="server"
				Height="24px" Width="24px" ImageUrl="iCO\Cal1.jpg"></asp:imagebutton><asp:button id="Button5" style="Z-INDEX: 107; LEFT: 416px; POSITION: absolute; TOP: 296px" runat="server"
				Height="24px" Width="210px" Text="Pending Claims" Visible="False"></asp:button><asp:button id="Button4" style="Z-INDEX: 106; LEFT: 416px; POSITION: absolute; TOP: 328px" runat="server"
				Height="24px" Width="184px" Text="Submit Claims" Visible="False"></asp:button><asp:panel id="Panel2" style="Z-INDEX: 104; LEFT: 8px; POSITION: absolute; TOP: 0px" runat="server"
				Height="48px" Width="1022px" BackImageUrl="Menu/banner.jpg"></asp:panel><asp:panel id="Panel1" style="Z-INDEX: 103; LEFT: 8px; POSITION: absolute; TOP: 48px" runat="server"
				Height="641px" Width="112px" BackImageUrl="Menu/EMPMASTER4.jpg"></asp:panel><asp:button id="Button2" style="Z-INDEX: 100; LEFT: 416px; POSITION: absolute; TOP: 208px" runat="server"
				Height="24px" Width="184px" Text="All Employee List2-Active" Visible="False"></asp:button><asp:button id="Button3" style="Z-INDEX: 101; LEFT: 416px; POSITION: absolute; TOP: 392px" runat="server"
				Height="24px" Width="210px" Text="Recieved Claims" Visible="False"></asp:button><asp:dropdownlist id="LstCom" style="Z-INDEX: 105; LEFT: 152px; POSITION: absolute; TOP: 48px" runat="server"
				Height="32px" Width="408px" Visible="False"></asp:dropdownlist><asp:label id="L1" style="Z-INDEX: 108; LEFT: 936px; POSITION: absolute; TOP: 32px" runat="server"
				Height="16px" Width="93px"></asp:label><asp:textbox id="TxtFdt" style="Z-INDEX: 109; LEFT: 240px; POSITION: absolute; TOP: 72px" runat="server"
				Height="24px" Width="80px"></asp:textbox><asp:label id="aa" style="Z-INDEX: 113; LEFT: 152px; POSITION: absolute; TOP: 72px" runat="server"
				Height="16px" Width="80px">From Date</asp:label><asp:label id="BB" style="Z-INDEX: 114; LEFT: 360px; POSITION: absolute; TOP: 64px" runat="server"
				Height="24px" Width="72px">To Date</asp:label><asp:calendar id="Calendar1" style="Z-INDEX: 116; LEFT: 344px; POSITION: absolute; TOP: 72px"
				runat="server" Height="96px" Width="152px" BorderWidth="1px" BackColor="White" ForeColor="#003399" Font-Size="8pt" Font-Names="Verdana" BorderColor="#3366CC"
				DayNameFormat="FirstLetter" CellPadding="1">
				<TodayDayStyle ForeColor="White" BackColor="#99CCCC"></TodayDayStyle>
				<SelectorStyle ForeColor="#336666" BackColor="#99CCCC"></SelectorStyle>
				<NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF"></NextPrevStyle>
				<DayHeaderStyle Height="1px" ForeColor="#336666" BackColor="#99CCCC"></DayHeaderStyle>
				<SelectedDayStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedDayStyle>
				<TitleStyle Font-Size="10pt" Font-Bold="True" Height="25px" BorderWidth="1px" ForeColor="#CCCCFF"
					BorderStyle="Solid" BorderColor="#3366CC" BackColor="#003399"></TitleStyle>
				<WeekendDayStyle BackColor="#CCCCFF"></WeekendDayStyle>
				<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
			</asp:calendar><asp:calendar id="Calendar2" style="Z-INDEX: 117; LEFT: 552px; POSITION: absolute; TOP: 72px"
				runat="server" Height="104px" Width="160px" BorderWidth="1px" BackColor="White" ForeColor="#003399" Font-Size="8pt"
				Font-Names="Verdana" BorderColor="#3366CC" DayNameFormat="FirstLetter" CellPadding="1">
				<TodayDayStyle ForeColor="White" BackColor="#99CCCC"></TodayDayStyle>
				<SelectorStyle ForeColor="#336666" BackColor="#99CCCC"></SelectorStyle>
				<NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF"></NextPrevStyle>
				<DayHeaderStyle Height="1px" ForeColor="#336666" BackColor="#99CCCC"></DayHeaderStyle>
				<SelectedDayStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedDayStyle>
				<TitleStyle Font-Size="10pt" Font-Bold="True" Height="25px" BorderWidth="1px" ForeColor="#CCCCFF"
					BorderStyle="Solid" BorderColor="#3366CC" BackColor="#003399"></TitleStyle>
				<WeekendDayStyle BackColor="#CCCCFF"></WeekendDayStyle>
				<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
			</asp:calendar><asp:button id="Button6" style="Z-INDEX: 118; LEFT: 152px; POSITION: absolute; TOP: 112px" runat="server"
				Height="24px" Width="184px" Text="New Employees"></asp:button><asp:button id="Button8" style="Z-INDEX: 120; LEFT: 152px; POSITION: absolute; TOP: 264px" runat="server"
				Width="184px" Text="Left Employees"></asp:button><asp:imagebutton id="ImageButton1" style="Z-INDEX: 122; LEFT: 632px; POSITION: absolute; TOP: 64px"
				runat="server" Height="24px" Width="80px" ImageUrl="Menu\print.jpg"></asp:imagebutton><asp:textbox id="TxtFlg" style="Z-INDEX: 123; LEFT: 808px; POSITION: absolute; TOP: 96px" runat="server"
				Width="66px" Visible="False"></asp:textbox><asp:label id="Label2" style="Z-INDEX: 126; LEFT: 152px; POSITION: absolute; TOP: 152px" runat="server"
				Height="16px" Width="120px">File Format</asp:label><asp:button id="Button10" style="Z-INDEX: 127; LEFT: 496px; POSITION: absolute; TOP: 352px"
				runat="server" Height="24px" Width="80px" Text="Create File" Visible="False"></asp:button><asp:imagebutton id="ImageButton2" style="Z-INDEX: 128; LEFT: 728px; POSITION: absolute; TOP: 64px"
				runat="server" Height="24px" Width="78px" ImageUrl="iCO\xls.jpg"></asp:imagebutton><asp:imagebutton id="Imagebutton4" style="Z-INDEX: 136; LEFT: 520px; POSITION: absolute; TOP: 440px"
				runat="server" Height="24px" Width="80px" ImageUrl="Menu\Images11.jpg"></asp:imagebutton></form>
	</body>
</HTML>
