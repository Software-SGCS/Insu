<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Download.aspx.vb" Inherits="Insu.Download"%>
<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Download</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:button id="Button1" style="Z-INDEX: 101; LEFT: 368px; POSITION: absolute; TOP: 192px" runat="server"
				Text="Button" Width="200px" Height="40px"></asp:button><INPUT id="fileUpload" style="Z-INDEX: 104; LEFT: 192px; WIDTH: 393px; POSITION: absolute; TOP: 56px; HEIGHT: 22px"
				type="file" size="46" name="File1" runat="server">
			<asp:textbox id="txtMyFile" style="Z-INDEX: 102; LEFT: 632px; POSITION: absolute; TOP: 240px"
				runat="server" Width="120px"></asp:textbox><asp:label id="lblStatus" style="Z-INDEX: 103; LEFT: 312px; POSITION: absolute; TOP: 464px"
				runat="server" Width="504px" Height="32px"></asp:label><asp:dropdownlist id="DropDownList1" style="Z-INDEX: 105; LEFT: 256px; POSITION: absolute; TOP: 328px"
				runat="server" Width="168px" Height="32px" AutoPostBack="True"></asp:dropdownlist><cr:crystalreportviewer id="CrystalReportViewer1" style="Z-INDEX: 106; LEFT: 136px; POSITION: absolute; TOP: 376px"
				runat="server" Width="350px" Height="50px" Visible="False"></cr:crystalreportviewer></form>
	</body>
</HTML>
