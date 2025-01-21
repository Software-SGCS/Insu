<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="HealthReport3.aspx.vb" Inherits="Insu.HealthReport3" %>
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
			<asp:button id="Button1" style="Z-INDEX: 102; LEFT: 152px; POSITION: absolute; TOP: 344px" runat="server"
				Height="24px" Width="144px" Text="Employee List1" Visible="False"></asp:button>
			<asp:label id="Label3" style="Z-INDEX: 131; LEFT: 696px; POSITION: absolute; TOP: 104px" runat="server"
				Width="90px" Height="16px">Account Year</asp:label>
			<asp:panel id="Panel3" style="Z-INDEX: 129; LEFT: 8px; POSITION: absolute; TOP: 688px" runat="server"
				Width="1052px" Height="72px" BackImageUrl="Menu/EMPMASTER4.jpg"></asp:panel><asp:dropdownlist id="DropDownList1" style="Z-INDEX: 125; LEFT: 280px; POSITION: absolute; TOP: 152px"
				runat="server" Height="32px" Width="176px" AutoPostBack="True"></asp:dropdownlist><asp:button id="Button9" style="Z-INDEX: 124; LEFT: 360px; POSITION: absolute; TOP: 256px" runat="server"
				Height="24px" Width="210px" Text="Recieved Claims Create Text File"></asp:button>
			<DIV id="Layer1" style="Z-INDEX: 121; LEFT: 136px; OVERFLOW: scroll; WIDTH: 954px; POSITION: absolute; TOP: 376px; HEIGHT: 536px"><CR:CRYSTALREPORTVIEWER id="CrystalReportViewer2" runat="server" Height="50px" Width="350px" Visible="False"
					DisplayToolbar="False" EnableDrillDown="False" SeparatePages="False" DisplayGroupTree="False"></CR:CRYSTALREPORTVIEWER></DIV>
			<asp:button id="Button7" style="Z-INDEX: 119; LEFT: 152px; POSITION: absolute; TOP: 272px" runat="server"
				Height="24px" Width="184px" Text="New Dependers"></asp:button><asp:imagebutton id="BTT2" style="Z-INDEX: 112; LEFT: 520px; POSITION: absolute; TOP: 104px" runat="server"
				Height="24px" Width="24px" ImageUrl="iCO\Cal1.jpg"></asp:imagebutton><asp:textbox id="TxtTdt" style="Z-INDEX: 111; LEFT: 440px; POSITION: absolute; TOP: 104px" runat="server"
				Height="24px" Width="80px"></asp:textbox><asp:imagebutton id="btt1" style="Z-INDEX: 110; LEFT: 320px; POSITION: absolute; TOP: 104px" runat="server"
				Height="24px" Width="24px" ImageUrl="iCO\Cal1.jpg"></asp:imagebutton><asp:button id="Button5" style="Z-INDEX: 107; LEFT: 360px; POSITION: absolute; TOP: 176px" runat="server"
				Height="24px" Width="210px" Text="Pending Claims"></asp:button><asp:button id="Button4" style="Z-INDEX: 106; LEFT: 152px; POSITION: absolute; TOP: 176px" runat="server"
				Height="24px" Width="184px" Text="Submit Claims"></asp:button><asp:panel id="Panel2" style="Z-INDEX: 104; LEFT: 8px; POSITION: absolute; TOP: 8px" runat="server"
				Height="48px" Width="1022px" BackImageUrl="Menu/banner.jpg"></asp:panel><asp:panel id="Panel1" style="Z-INDEX: 103; LEFT: 8px; POSITION: absolute; TOP: 56px" runat="server"
				Height="633px" Width="112px" BackImageUrl="Menu/EMPMASTER4.jpg"></asp:panel><asp:button id="Button2" style="Z-INDEX: 100; LEFT: 176px; POSITION: absolute; TOP: 256px" runat="server"
				Height="24px" Width="184px" Text="All Employee List2-Active" Visible="False"></asp:button><asp:button id="Button3" style="Z-INDEX: 101; LEFT: 360px; POSITION: absolute; TOP: 216px" runat="server"
				Height="24px" Width="210px" Text="Recieved Claims"></asp:button><asp:dropdownlist id="LstCom" style="Z-INDEX: 105; LEFT: 144px; POSITION: absolute; TOP: 64px" runat="server"
				Height="32px" Width="401px"></asp:dropdownlist><asp:label id="L1" style="Z-INDEX: 108; LEFT: 936px; POSITION: absolute; TOP: 32px" runat="server"
				Height="16px" Width="93px"></asp:label><asp:textbox id="TxtFdt" style="Z-INDEX: 109; LEFT: 240px; POSITION: absolute; TOP: 104px" runat="server"
				Height="24px" Width="80px"></asp:textbox><asp:label id="aa" style="Z-INDEX: 114; LEFT: 152px; POSITION: absolute; TOP: 104px" runat="server"
				Height="16px" Width="80px">From Date</asp:label><asp:label id="BB" style="Z-INDEX: 115; LEFT: 360px; POSITION: absolute; TOP: 104px" runat="server"
				Height="24px" Width="72px">To Date</asp:label><asp:calendar id="Calendar1" style="Z-INDEX: 116; LEFT: 696px; POSITION: absolute; TOP: 328px"
				runat="server" Height="157px" Width="152px" BorderWidth="1px" BackColor="White" ForeColor="#003399" Font-Size="8pt" Font-Names="Verdana" BorderColor="#3366CC"
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
			</asp:calendar><asp:calendar id="Calendar2" style="Z-INDEX: 117; LEFT: 656px; POSITION: absolute; TOP: 152px"
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
			</asp:calendar><asp:button id="Button6" style="Z-INDEX: 118; LEFT: 152px; POSITION: absolute; TOP: 224px" runat="server"
				Height="24px" Width="184px" Text="New Employees"></asp:button><asp:button id="Button8" style="Z-INDEX: 120; LEFT: 152px; POSITION: absolute; TOP: 320px" runat="server"
				Width="184px" Text="Left Employees"></asp:button><asp:imagebutton id="ImageButton1" style="Z-INDEX: 122; LEFT: 576px; POSITION: absolute; TOP: 64px"
				runat="server" Height="24px" Width="80px" ImageUrl="Menu\print.jpg"></asp:imagebutton><asp:textbox id="TxtFlg" style="Z-INDEX: 123; LEFT: 800px; POSITION: absolute; TOP: 72px" runat="server"
				Width="66px" Visible="False"></asp:textbox><asp:label id="Label2" style="Z-INDEX: 126; LEFT: 152px; POSITION: absolute; TOP: 152px" runat="server"
				Height="16px" Width="120px">File Format</asp:label><asp:button id="Button10" style="Z-INDEX: 127; LEFT: 464px; POSITION: absolute; TOP: 152px"
				runat="server" Height="24px" Width="80px" Text="Create File"></asp:button>
			<asp:ImageButton id="ImageButton2" style="Z-INDEX: 128; LEFT: 664px; POSITION: absolute; TOP: 64px"
				runat="server" Width="78px" Height="24px" ImageUrl="iCO\xls.jpg"></asp:ImageButton>
			<asp:TextBox id="TxtAccYr" style="Z-INDEX: 130; LEFT: 792px; POSITION: absolute; TOP: 104px"
				runat="server" Width="68px"></asp:TextBox></form>
	</body>
</HTML>
