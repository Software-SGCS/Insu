<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ItemLst.aspx.vb" Inherits="Insu.ItemLst"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>ItemLst</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<FORM id="Form1" method="post" runat="server">
			<asp:Label id="Label1" style="Z-INDEX: 103; LEFT: 8px; POSITION: absolute; TOP: 8px" runat="server"
				Width="136px" Height="24px">Item Type</asp:Label>
			<asp:button id="Button1" style="Z-INDEX: 101; LEFT: 352px; POSITION: absolute; TOP: 8px" runat="server"
				Width="144px" Height="24px" Text="View Report"></asp:button>
			<DIV id="Layer1" style="Z-INDEX: 102; LEFT: 16px; OVERFLOW: scroll; WIDTH: 760px; POSITION: absolute; TOP: 56px; HEIGHT: 1126px">
				<CR:CRYSTALREPORTVIEWER id="CRYSTALREPORTVIEWER2" style="Z-INDEX: 101; LEFT: -375px; POSITION: absolute; TOP: 0px"
					runat="server" Width="350px" Height="50px" DisplayToolbar="False" SeparatePages="False"></CR:CRYSTALREPORTVIEWER>
				<cr:CrystalReportViewer id="CrystalReportViewer1" runat="server" Height="50px" Width="350px"></cr:CrystalReportViewer></DIV>
			<asp:DropDownList id="LstId1" style="Z-INDEX: 104; LEFT: 184px; POSITION: absolute; TOP: 8px" runat="server"
				Width="152px" Height="32px"></asp:DropDownList></FORM>
	</body>
</HTML>
