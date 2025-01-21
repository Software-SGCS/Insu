<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="CRS.aspx.vb" Inherits="Insu.CRS" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>CRS</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout" leftmargin="0">
		<form id="Form1" method="post" runat="server">
			<asp:button id="Button1" style="Z-INDEX: 101; LEFT: 376px; POSITION: absolute; TOP: 64px" runat="server"
				Text="View Report" Width="144px" Height="24px"></asp:button>
			<asp:panel id="Panel4" style="Z-INDEX: 106; LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server"
				Height="48px" Width="1620px" BackColor="Desktop">
<asp:panel id="Panel7" style="Z-INDEX: 109; LEFT: 0px; POSITION: absolute; TOP: 40px" runat="server"
					Height="1198px" Width="16px" BackColor="Desktop"></asp:panel>Print&nbsp;Page&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
Payment Notice</asp:panel>
			<asp:Label id="Label1" style="Z-INDEX: 105; LEFT: 56px; POSITION: absolute; TOP: 64px" runat="server"
				Height="24px" Width="136px">Vehicle No</asp:Label>
			<cr:crystalreportviewer id="CrystalReportViewer1" style="Z-INDEX: 104; LEFT: -336px; POSITION: absolute; TOP: 40px"
				runat="server" Height="50px" Width="350px" DisplayToolbar="False" Visible="False"></cr:crystalreportviewer>
			<DIV id="Layer1" style="Z-INDEX: 103; LEFT: 16px; OVERFLOW: scroll; WIDTH: 1602px; POSITION: absolute; TOP: 112px; HEIGHT: 1126px">
				<CR:CRYSTALREPORTVIEWER id="CRYSTALREPORTVIEWER2" style="Z-INDEX: 101; LEFT: -375px; POSITION: absolute; TOP: 0px"
					runat="server" Height="50px" Width="350px" DisplayToolbar="False" SeparatePages="False"></CR:CRYSTALREPORTVIEWER></DIV>
			<asp:DropDownList id="LstId" style="Z-INDEX: 102; LEFT: 200px; POSITION: absolute; TOP: 64px" runat="server"
				Height="24px" Width="136px"></asp:DropDownList>
			<asp:Label id="L1" style="Z-INDEX: 107; LEFT: 624px; POSITION: absolute; TOP: 64px" runat="server"
				Height="24px" Width="96px" Visible="False"></asp:Label></form>
	</body>
</HTML>
