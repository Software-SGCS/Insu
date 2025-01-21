<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="CrsCertificate.aspx.vb" Inherits="Insu.CrsCertificate" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>CrsCertificate</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout" leftmargin="0">
		<form id="Form1" method="post" runat="server">
			<asp:DropDownList id="LstId" style="Z-INDEX: 102; LEFT: 224px; POSITION: absolute; TOP: 64px" runat="server"
				Width="144px" Height="24px"></asp:DropDownList>
			<asp:panel id="Panel4" style="Z-INDEX: 106; LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server"
				Height="48px" Width="1628px" BackColor="Desktop">
<asp:panel id="Panel7" style="Z-INDEX: 109; LEFT: 0px; POSITION: absolute; TOP: 40px" runat="server"
					Height="1254px" Width="24px" BackColor="Desktop"></asp:panel>Print&nbsp;Page&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
Insurance Certificate</asp:panel>
			<DIV id="Layer1" style="Z-INDEX: 103; LEFT: 24px; OVERFLOW: scroll; WIDTH: 1602px; POSITION: absolute; TOP: 168px; HEIGHT: 1126px">
				<CR:CRYSTALREPORTVIEWER id="CRYSTALREPORTVIEWER2" style="Z-INDEX: 101; LEFT: -375px; POSITION: absolute; TOP: 0px"
					runat="server" DisplayToolbar="False" Width="350px" Height="50px" SeparatePages="False"></CR:CRYSTALREPORTVIEWER></DIV>
			<asp:button id="Button1" style="Z-INDEX: 101; LEFT: 432px; POSITION: absolute; TOP: 64px" runat="server"
				Width="144px" Height="24px" Text="View Report"></asp:button>
			<CR:CrystalReportViewer id="CrystalReportViewer1" runat="server" Height="50px" Width="350px" style="Z-INDEX: 104; LEFT: 16px; POSITION: absolute; TOP: 104px"
				DisplayToolbar="False" DisplayGroupTree="False" Visible="False"></CR:CrystalReportViewer>
			<asp:Label id="Label1" style="Z-INDEX: 105; LEFT: 40px; POSITION: absolute; TOP: 64px" runat="server"
				Height="24px" Width="152px">Vehicle No</asp:Label>
			<asp:Label id="L1" style="Z-INDEX: 107; LEFT: 664px; POSITION: absolute; TOP: 72px" runat="server"
				Height="24px" Width="120px" Visible="False"></asp:Label>
		</form>
	</body>
</HTML>
