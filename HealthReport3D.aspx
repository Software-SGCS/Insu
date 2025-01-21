<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="HealthReport3D.aspx.vb" Inherits="Insu.HealthReport3D" %>
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
			<asp:button id="Button1" style="Z-INDEX: 102; LEFT: 520px; POSITION: absolute; TOP: 368px" runat="server"
				Visible="False" Text="Employee List1" Width="144px" Height="24px"></asp:button><asp:button id="Button2" style="Z-INDEX: 130; LEFT: 360px; POSITION: absolute; TOP: 248px" runat="server"
				Text="New Report1" Width="184px" Height="24px"></asp:button><asp:panel id="Panel3" style="Z-INDEX: 129; LEFT: 8px; POSITION: absolute; TOP: 688px" runat="server"
				Width="1052px" Height="72px" BackImageUrl="Menu/EMPMASTER4.jpg"></asp:panel><asp:dropdownlist id="DropDownList1" style="Z-INDEX: 125; LEFT: 280px; POSITION: absolute; TOP: 152px"
				runat="server" Width="176px" Height="32px" AutoPostBack="True"></asp:dropdownlist><asp:button id="Button9" style="Z-INDEX: 124; LEFT: 536px; POSITION: absolute; TOP: 272px" runat="server"
				Visible="False" Text="Recieved Claims Create Text File" Width="210px" Height="24px"></asp:button>
			<DIV id="Layer1" style="Z-INDEX: 121; LEFT: 160px; OVERFLOW: scroll; WIDTH: 954px; POSITION: absolute; TOP: 336px; HEIGHT: 688px"><CR:CRYSTALREPORTVIEWER id="CrystalReportViewer2" runat="server" Visible="False" Width="350px" Height="50px"
					DisplayGroupTree="False" SeparatePages="False" EnableDrillDown="False" DisplayToolbar="False"></CR:CRYSTALREPORTVIEWER></DIV>
			<asp:button id="Button7" style="Z-INDEX: 119; LEFT: 152px; POSITION: absolute; TOP: 240px" runat="server"
				Text="New Dependers" Width="184px" Height="24px"></asp:button><asp:imagebutton id="BTT2" style="Z-INDEX: 112; LEFT: 520px; POSITION: absolute; TOP: 104px" runat="server"
				Width="24px" Height="24px" ImageUrl="iCO\Cal1.jpg"></asp:imagebutton><asp:textbox id="TxtTdt" style="Z-INDEX: 111; LEFT: 440px; POSITION: absolute; TOP: 104px" runat="server"
				Width="80px" Height="24px"></asp:textbox><asp:imagebutton id="btt1" style="Z-INDEX: 110; LEFT: 320px; POSITION: absolute; TOP: 104px" runat="server"
				Width="24px" Height="24px" ImageUrl="iCO\Cal1.jpg"></asp:imagebutton><asp:button id="Button5" style="Z-INDEX: 107; LEFT: 360px; POSITION: absolute; TOP: 176px" runat="server"
				Visible="False" Text="Pending Claims" Width="210px" Height="24px"></asp:button><asp:button id="Button4" style="Z-INDEX: 106; LEFT: 352px; POSITION: absolute; TOP: 360px" runat="server"
				Visible="False" Text="Submit Claims" Width="184px" Height="24px"></asp:button><asp:panel id="Panel2" style="Z-INDEX: 104; LEFT: 8px; POSITION: absolute; TOP: 8px" runat="server"
				Width="1022px" Height="48px" BackImageUrl="Menu/banner.jpg"></asp:panel><asp:panel id="Panel1" style="Z-INDEX: 103; LEFT: 8px; POSITION: absolute; TOP: 56px" runat="server"
				Width="112px" Height="633px" BackImageUrl="Menu/EMPMASTER4.jpg"></asp:panel><asp:button id="Button3" style="Z-INDEX: 101; LEFT: 360px; POSITION: absolute; TOP: 216px" runat="server"
				Visible="False" Text="Recieved Claims" Width="210px" Height="24px"></asp:button><asp:dropdownlist id="LstCom" style="Z-INDEX: 105; LEFT: 144px; POSITION: absolute; TOP: 64px" runat="server"
				Width="401px" Height="32px"></asp:dropdownlist><asp:label id="L1" style="Z-INDEX: 108; LEFT: 936px; POSITION: absolute; TOP: 32px" runat="server"
				Width="93px" Height="16px"></asp:label><asp:textbox id="TxtFdt" style="Z-INDEX: 109; LEFT: 240px; POSITION: absolute; TOP: 104px" runat="server"
				Width="80px" Height="24px"></asp:textbox><asp:label id="aa" style="Z-INDEX: 113; LEFT: 152px; POSITION: absolute; TOP: 104px" runat="server"
				Width="80px" Height="16px">From Date</asp:label><asp:label id="BB" style="Z-INDEX: 114; LEFT: 360px; POSITION: absolute; TOP: 104px" runat="server"
				Width="72px" Height="24px">To Date</asp:label><asp:calendar id="Calendar1" style="Z-INDEX: 115; LEFT: 344px; POSITION: absolute; TOP: 104px"
				runat="server" Width="160px" Height="88px" CellPadding="1" DayNameFormat="FirstLetter" BorderColor="#3366CC" Font-Names="Verdana" Font-Size="8pt"
				ForeColor="#003399" BackColor="White" BorderWidth="1px">
				<TodayDayStyle ForeColor="White" BackColor="#99CCCC"></TodayDayStyle>
				<SelectorStyle ForeColor="#336666" BackColor="#99CCCC"></SelectorStyle>
				<NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF"></NextPrevStyle>
				<DayHeaderStyle Height="1px" ForeColor="#336666" BackColor="#99CCCC"></DayHeaderStyle>
				<SelectedDayStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedDayStyle>
				<TitleStyle Font-Size="10pt" Font-Bold="True" Height="25px" BorderWidth="1px" ForeColor="#CCCCFF"
					BorderStyle="Solid" BorderColor="#3366CC" BackColor="#003399"></TitleStyle>
				<WeekendDayStyle BackColor="#CCCCFF"></WeekendDayStyle>
				<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
			</asp:calendar><asp:calendar id="Calendar2" style="Z-INDEX: 116; LEFT: 544px; POSITION: absolute; TOP: 104px"
				runat="server" Width="152px" Height="112px" CellPadding="1" DayNameFormat="FirstLetter" BorderColor="#3366CC"
				Font-Names="Verdana" Font-Size="8pt" ForeColor="#003399" BackColor="White" BorderWidth="1px">
				<TodayDayStyle ForeColor="White" BackColor="#99CCCC"></TodayDayStyle>
				<SelectorStyle ForeColor="#336666" BackColor="#99CCCC"></SelectorStyle>
				<NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF"></NextPrevStyle>
				<DayHeaderStyle Height="1px" ForeColor="#336666" BackColor="#99CCCC"></DayHeaderStyle>
				<SelectedDayStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedDayStyle>
				<TitleStyle Font-Size="10pt" Font-Bold="True" Height="25px" BorderWidth="1px" ForeColor="#CCCCFF"
					BorderStyle="Solid" BorderColor="#3366CC" BackColor="#003399"></TitleStyle>
				<WeekendDayStyle BackColor="#CCCCFF"></WeekendDayStyle>
				<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
			</asp:calendar><asp:button id="Button6" style="Z-INDEX: 118; LEFT: 152px; POSITION: absolute; TOP: 200px" runat="server"
				Text="New Employees" Width="184px" Height="24px"></asp:button><asp:button id="Button8" style="Z-INDEX: 120; LEFT: 152px; POSITION: absolute; TOP: 288px" runat="server"
				Text="Left Employees" Width="184px"></asp:button><asp:imagebutton id="ImageButton1" style="Z-INDEX: 122; LEFT: 576px; POSITION: absolute; TOP: 64px"
				runat="server" Width="80px" Height="24px" ImageUrl="Menu\print.jpg"></asp:imagebutton><asp:textbox id="TxtFlg" style="Z-INDEX: 123; LEFT: 808px; POSITION: absolute; TOP: 96px" runat="server"
				Visible="False" Width="66px"></asp:textbox><asp:label id="Label2" style="Z-INDEX: 126; LEFT: 152px; POSITION: absolute; TOP: 152px" runat="server"
				Width="120px" Height="16px">File Format</asp:label><asp:button id="Button10" style="Z-INDEX: 127; LEFT: 464px; POSITION: absolute; TOP: 152px"
				runat="server" Visible="False" Text="Create File" Width="80px" Height="24px"></asp:button><asp:imagebutton id="ImageButton2" style="Z-INDEX: 128; LEFT: 664px; POSITION: absolute; TOP: 64px"
				runat="server" Width="78px" Height="24px" ImageUrl="iCO\xls.jpg"></asp:imagebutton></form>
	</body>
</HTML>
