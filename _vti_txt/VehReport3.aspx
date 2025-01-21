<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="VehReport3.aspx.vb" Inherits="Insu.VehReport3" %>
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
			<asp:label id="CompanyCode" style="Z-INDEX: 102; LEFT: 32px; POSITION: absolute; TOP: 24px"
				runat="server" Width="105px" Height="24px">Company Code</asp:label>
			<DIV id="Layer1" style="Z-INDEX: 122; LEFT: 32px; OVERFLOW: scroll; WIDTH: 954px; POSITION: absolute; TOP: 112px; HEIGHT: 1184px"><CR:CRYSTALREPORTVIEWER id="CRYSTALREPORTVIEWER2" runat="server" Width="350px" Height="50px" Visible="False"
					DisplayToolbar="False" DisplayGroupTree="False" SeparatePages="False" EnableDrillDown="False"></CR:CRYSTALREPORTVIEWER></DIV>
			<asp:calendar id="Calendar1" style="Z-INDEX: 113; LEFT: 368px; POSITION: absolute; TOP: 48px"
				runat="server" Width="152px" Height="128px" CellPadding="1" DayNameFormat="FirstLetter" BackColor="White"
				Visible="False" Font-Names="Verdana" BorderWidth="1px" Font-Size="8pt" BorderColor="#3366CC"
				ForeColor="#003399">
				<TodayDayStyle ForeColor="White" BackColor="#99CCCC"></TodayDayStyle>
				<SelectorStyle ForeColor="#336666" BackColor="#99CCCC"></SelectorStyle>
				<NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF"></NextPrevStyle>
				<DayHeaderStyle Height="1px" ForeColor="#336666" BackColor="#99CCCC"></DayHeaderStyle>
				<SelectedDayStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedDayStyle>
				<TitleStyle Font-Size="10pt" Font-Bold="True" Height="25px" BorderWidth="1px" ForeColor="#CCCCFF"
					BorderStyle="Solid" BorderColor="#3366CC" BackColor="#003399"></TitleStyle>
				<WeekendDayStyle BackColor="#CCCCFF"></WeekendDayStyle>
				<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
			</asp:calendar><asp:imagebutton id="ImgBtn2" style="Z-INDEX: 111; LEFT: 560px; POSITION: absolute; TOP: 48px" runat="server"
				Width="24px" Height="24px" ImageUrl="file:///C:\Inetpub\wwwroot\Insu\iCO\Cal1.jpg"></asp:imagebutton><asp:textbox id="TxtTdt" style="Z-INDEX: 110; LEFT: 496px; POSITION: absolute; TOP: 48px" tabIndex="3"
				runat="server" Width="64px" Height="24px" Font-Size="XX-Small"></asp:textbox><asp:label id="Label1" style="Z-INDEX: 109; LEFT: 432px; POSITION: absolute; TOP: 48px" runat="server"
				Width="56px" Height="24px" Font-Bold="True">To Date</asp:label><asp:imagebutton id="ImgBtn1" style="Z-INDEX: 108; LEFT: 248px; POSITION: absolute; TOP: 48px" runat="server"
				Width="24px" Height="24px" ImageUrl="file:///C:\Inetpub\wwwroot\Insu\iCO\Cal1.jpg"></asp:imagebutton><asp:calendar id="Calendar2" style="Z-INDEX: 107; LEFT: 584px; POSITION: absolute; TOP: 48px"
				runat="server" Width="152px" Height="120px" CellPadding="1" DayNameFormat="FirstLetter" BackColor="White" Visible="False" Font-Names="Verdana" BorderWidth="1px" Font-Size="8pt" BorderColor="#3366CC"
				ForeColor="#003399">
				<TodayDayStyle ForeColor="White" BackColor="#99CCCC"></TodayDayStyle>
				<SelectorStyle ForeColor="#336666" BackColor="#99CCCC"></SelectorStyle>
				<NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF"></NextPrevStyle>
				<DayHeaderStyle Height="1px" ForeColor="#336666" BackColor="#99CCCC"></DayHeaderStyle>
				<SelectedDayStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedDayStyle>
				<TitleStyle Font-Size="10pt" Font-Bold="True" Height="25px" BorderWidth="1px" ForeColor="#CCCCFF"
					BorderStyle="Solid" BorderColor="#3366CC" BackColor="#003399"></TitleStyle>
				<WeekendDayStyle BackColor="#CCCCFF"></WeekendDayStyle>
				<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
			</asp:calendar><asp:textbox id="TxtFDt" style="Z-INDEX: 105; LEFT: 176px; POSITION: absolute; TOP: 48px" tabIndex="2"
				runat="server" Width="72px" Height="24px" Font-Size="XX-Small"></asp:textbox><asp:label id="Label12" style="Z-INDEX: 106; LEFT: 32px; POSITION: absolute; TOP: 56px" runat="server"
				Width="112px" Height="24px" Font-Bold="True">From Date</asp:label><asp:button id="ImgBtn3" style="Z-INDEX: 103; LEFT: 216px; POSITION: absolute; TOP: 88px" tabIndex="6"
				runat="server" Width="136px" Height="24px" Text="Selected "></asp:button><asp:dropdownlist id="LstCom" style="Z-INDEX: 101; LEFT: 176px; POSITION: absolute; TOP: 24px" runat="server"
				Width="320px" Height="32px"></asp:dropdownlist><asp:button id="Butt1" style="Z-INDEX: 112; LEFT: 32px; POSITION: absolute; TOP: 88px" runat="server"
				Width="168px" Font-Size="X-Small" Text="Selected Date &amp; Company"></asp:button><asp:label id="L1" style="Z-INDEX: 121; LEFT: 24px; POSITION: absolute; TOP: 600px" runat="server"
				Width="264px" Height="24px" Visible="False">Label</asp:label></FORM>
	</body>
</HTML>
