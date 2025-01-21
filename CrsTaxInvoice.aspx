<%@ Page Language="vb" AutoEventWireup="false" Codebehind="CrsTaxInvoice.aspx.vb" Inherits="Insu.CrsTaxInvoice"%>
<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
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
			<asp:label id="Label1" style="Z-INDEX: 102; LEFT: 32px; POSITION: absolute; TOP: 80px" runat="server"
				Width="80px" Height="24px">Invoice No</asp:label><asp:button id="Button6" style="Z-INDEX: 109; LEFT: 472px; POSITION: absolute; TOP: 120px" runat="server"
				Width="184px" Height="24px" Text="Tax Invoice-Acc Copy Without Discount"></asp:button><asp:button id="Button4" style="Z-INDEX: 107; LEFT: 304px; POSITION: absolute; TOP: 160px" runat="server"
				Width="136px" Height="24px" Text="Tax Invoice-File Copy"></asp:button><asp:button id="Button3" style="Z-INDEX: 106; LEFT: 304px; POSITION: absolute; TOP: 120px" runat="server"
				Width="136px" Height="24px" Text="Tax Invoice-Acc Copy"></asp:button><asp:button id="Button2" style="Z-INDEX: 104; LEFT: 136px; POSITION: absolute; TOP: 208px" runat="server"
				Width="96px" Height="24px" Text="Print" Visible="False"></asp:button><asp:button id="Button1" style="Z-INDEX: 103; LEFT: 304px; POSITION: absolute; TOP: 80px" runat="server"
				Width="136px" Height="24px" Text="Tax Invoice"></asp:button><asp:dropdownlist id="LstId" style="Z-INDEX: 101; LEFT: 136px; POSITION: absolute; TOP: 80px" runat="server"
				Width="144px" Height="24px"></asp:dropdownlist><cr:crystalreportviewer id="CrystalReportViewer2" style="Z-INDEX: 105; LEFT: -336px; POSITION: absolute; TOP: 96px"
				runat="server" Width="350px" Height="50px" Visible="False" DisplayToolbar="False"></cr:crystalreportviewer>
			<asp:Button id="Button5" style="Z-INDEX: 108; LEFT: 472px; POSITION: absolute; TOP: 80px" runat="server"
				Width="184px" Height="24px" Text="Tax Invoice-Without Discount"></asp:Button>
			<asp:Button id="Button7" style="Z-INDEX: 110; LEFT: 472px; POSITION: absolute; TOP: 160px" runat="server"
				Width="184px" Text="Tax Invoice-File Copy Without Discount"></asp:Button></FORM>
	</body>
</HTML>
