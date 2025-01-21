<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="PopView1.aspx.vb" Inherits="Insu.PopView1"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>PopView1</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<DIV id="Layer1" style="Z-INDEX: 102; LEFT: 64px; OVERFLOW: scroll; WIDTH: 800px; POSITION: absolute; TOP: 50px; HEIGHT: 750px">
				<CR:CRYSTALREPORTVIEWER id="CrystalReportViewer1" style="Z-INDEX: 101; LEFT: -350px; POSITION: absolute; TOP: 0px"
					runat="server" Height="50px" Width="350px" DisplayToolbar="False" SeparatePages="False"></CR:CRYSTALREPORTVIEWER></DIV>
		</form>
		</FORM>
	</body>
</HTML>
