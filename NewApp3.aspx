<%@ Page Language="vb" AutoEventWireup="false" Codebehind="NewApp3.aspx.vb" Inherits="Insu.NewApp3" %>
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
	<body bgColor="#ffffff" MS_POSITIONING="GridLayout">
		<FORM id="Form1" method="post" runat="server">
			<asp:label id="Label1" style="Z-INDEX: 100; LEFT: 216px; POSITION: absolute; TOP: 80px" runat="server"
				Width="80px" Height="24px">TO PRINT</asp:label>
			<asp:button id="Button8" style="Z-INDEX: 115; LEFT: 768px; POSITION: absolute; TOP: 72px" runat="server"
				Height="24px" Width="144px" Text="Tax Invoice"></asp:button><asp:button id="Button7" style="Z-INDEX: 114; LEFT: 528px; POSITION: absolute; TOP: 152px" runat="server"
				Width="218px" Height="24px" Text="Tax Invoice-File Copy-Without Discount"></asp:button><asp:button id="Button6" style="Z-INDEX: 113; LEFT: 528px; POSITION: absolute; TOP: 112px" runat="server"
				Width="218px" Height="24px" Text="Tax Invoice-Acc Copy-Without Discount"></asp:button><asp:button id="Button5" style="Z-INDEX: 112; LEFT: 528px; POSITION: absolute; TOP: 72px" runat="server"
				Width="218px" Height="24px" Text="Tax Invoice-Without Discount"></asp:button><asp:button id="Button4" style="Z-INDEX: 106; LEFT: 352px; POSITION: absolute; TOP: 152px" runat="server"
				Width="144px" Height="24px" Text="Tax Invoice-File Copy"></asp:button><asp:button id="Button3" style="Z-INDEX: 105; LEFT: 352px; POSITION: absolute; TOP: 112px" runat="server"
				Width="144px" Height="24px" Text="Tax Invoice-Acc Copy"></asp:button><asp:button id="Button2" style="Z-INDEX: 103; LEFT: 216px; POSITION: absolute; TOP: 232px" runat="server"
				Width="96px" Height="24px" Text="Print" Visible="False"></asp:button><asp:button id="Button1" style="Z-INDEX: 102; LEFT: 352px; POSITION: absolute; TOP: 72px" runat="server"
				Width="144px" Height="24px" Text="Tax Invoice"></asp:button><cr:crystalreportviewer id="CrystalReportViewer2" style="Z-INDEX: 104; LEFT: -272px; POSITION: absolute; TOP: 56px"
				runat="server" Width="350px" Height="50px" Visible="False" DisplayToolbar="False" SeparatePages="False"></cr:crystalreportviewer><asp:textbox id="TxtId" style="Z-INDEX: 107; LEFT: 216px; POSITION: absolute; TOP: 160px" runat="server"
				Width="105px" Visible="False"></asp:textbox><asp:panel id="Panel1" style="Z-INDEX: 108; LEFT: 0px; POSITION: absolute; TOP: 8px; Design_Time_Lock: True"
				runat="server" Width="749px" Height="56px" BackImageUrl="Menu/BANNER.jpg" Design_Time_Lock="True"></asp:panel><asp:panel id="Panel2" style="Z-INDEX: 109; LEFT: 0px; POSITION: absolute; TOP: 64px" runat="server"
				Width="184px" Height="184px" BackImageUrl="Menu/Audit.gif"></asp:panel><asp:panel id="Panel3" style="Z-INDEX: 110; LEFT: 0px; POSITION: absolute; TOP: 248px" runat="server"
				Width="184px" Height="176px" BackImageUrl="Menu/BANN1.jpg"></asp:panel><asp:panel id="Panel4" style="Z-INDEX: 111; LEFT: 184px; POSITION: absolute; TOP: 344px" runat="server"
				Width="564px" Height="80px" BackImageUrl="Menu/BANN1.jpg"></asp:panel></FORM>
	</body>
</HTML>
