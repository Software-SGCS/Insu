<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ChequePrint.aspx.vb" Inherits="Insu.ChequePrint" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>CrsCertificate</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body leftMargin="0" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:dropdownlist id="LstId" style="Z-INDEX: 102; LEFT: 136px; POSITION: absolute; TOP: 64px" runat="server"
				Width="592px" Height="24px"></asp:dropdownlist><asp:button id="Button1" style="Z-INDEX: 101; LEFT: 584px; POSITION: absolute; TOP: 128px" runat="server"
				Width="144px" Height="32px" Text="View Report"></asp:button><CR:CRYSTALREPORTVIEWER id="CrystalReportViewer1" style="Z-INDEX: 104; LEFT: 472px; POSITION: absolute; TOP: 224px"
				runat="server" Width="350px" Height="50px" DisplayGroupTree="False" Visible="False" DisplayToolbar="False"></CR:CRYSTALREPORTVIEWER><asp:label id="Label1" style="Z-INDEX: 105; LEFT: 40px; POSITION: absolute; TOP: 64px" runat="server"
				Width="88px" Height="24px">Copany Code</asp:label><asp:label id="Label2" style="Z-INDEX: 107; LEFT: 48px; POSITION: absolute; TOP: 136px" runat="server"
				Width="96px" Height="16px">Amount(Rs.)</asp:label><asp:textbox id="TxtAmt" style="Z-INDEX: 108; LEFT: 136px; POSITION: absolute; TOP: 128px" runat="server"
				Width="160px" Height="24px"></asp:textbox><asp:label id="Label3" style="Z-INDEX: 109; LEFT: 304px; POSITION: absolute; TOP: 136px" runat="server"
				Width="96px" Height="24px">Deposit Date</asp:label><asp:textbox id="Txtdt" style="Z-INDEX: 110; LEFT: 416px; POSITION: absolute; TOP: 128px" runat="server"
				Width="120px" Height="32px"></asp:textbox></form>
	</body>
</HTML>
