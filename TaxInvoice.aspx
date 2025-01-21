<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="CrsTaxInvoice.aspx.vb" Inherits="Insu.CrsTaxInvoice"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>CrsTaxInvoice</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<FORM id="Form1" method="post" runat="server">
			<asp:label id="Label1" style="Z-INDEX: 101; LEFT: 112px; POSITION: absolute; TOP: 80px" runat="server"
				Height="24px" Width="80px">Invoice No</asp:label><asp:button id="Button4" style="Z-INDEX: 107; LEFT: 384px; POSITION: absolute; TOP: 160px" runat="server"
				Height="24px" Width="144px" Text="Tax Invoice-File Copy"></asp:button><asp:button id="Button3" style="Z-INDEX: 106; LEFT: 384px; POSITION: absolute; TOP: 120px" runat="server"
				Height="24px" Width="144px" Text="Tax Invoice-Acc Copy"></asp:button><asp:button id="Button2" style="Z-INDEX: 104; LEFT: 576px; POSITION: absolute; TOP: 80px" runat="server"
				Height="24px" Width="96px" Text="Print" Visible="False"></asp:button><asp:button id="Button1" style="Z-INDEX: 102; LEFT: 384px; POSITION: absolute; TOP: 80px" runat="server"
				Height="24px" Width="144px" Text="Tax Invoice"></asp:button><asp:dropdownlist id="LstId" style="Z-INDEX: 100; LEFT: 216px; POSITION: absolute; TOP: 80px" runat="server"
				Height="24px" Width="144px"></asp:dropdownlist><cr:crystalreportviewer id="CrystalReportViewer2" style="Z-INDEX: 105; LEFT: -336px; POSITION: absolute; TOP: 96px"
				runat="server" Height="50px" Width="350px" Visible="False" DisplayToolbar="False"></cr:crystalreportviewer></FORM>
	</body>
</HTML>
