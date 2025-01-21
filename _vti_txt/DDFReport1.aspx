<%@ Page Language="vb" AutoEventWireup="false" Codebehind="DDFReport1.aspx.vb" Inherits="Insu.DDFReport1" %>
<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>HealthReport1</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:button id="Button1" style="Z-INDEX: 103; LEFT: 152px; POSITION: absolute; TOP: 128px" runat="server"
				Height="24px" Width="144px" Text="Employee List1" Visible="False"></asp:button>
			<DIV id="Layer1" style="Z-INDEX: 112; LEFT: 8px; OVERFLOW: scroll; WIDTH: 906px; POSITION: absolute; TOP: 136px; HEIGHT: 514px"
				align="left"><CR:CRYSTALREPORTVIEWER id="CrystalReportViewer1" style="Z-INDEX: 101; LEFT: -350px; POSITION: absolute; TOP: 0px"
					runat="server" Height="50px" Width="350px" DisplayToolbar="False" SeparatePages="False"></CR:CRYSTALREPORTVIEWER><cr:crystalreportviewer id="CrystalReportViewer2" runat="server" Height="50px" Width="350px" Visible="False"
					DisplayToolbar="False" SeparatePages="False" DisplayGroupTree="False"></cr:crystalreportviewer></DIV>
			<asp:imagebutton id="ImageButton1" style="Z-INDEX: 111; LEFT: 624px; POSITION: absolute; TOP: 64px"
				runat="server" Height="24px" Width="80px" ImageUrl="Menu\print.jpg"></asp:imagebutton><asp:button id="Button5" style="Z-INDEX: 108; LEFT: 392px; POSITION: absolute; TOP: 56px" runat="server"
				Height="24px" Width="210px" Text="Selected Employee List2-DeActive" Visible="False"></asp:button><asp:button id="Button4" style="Z-INDEX: 107; LEFT: 16px; POSITION: absolute; TOP: 104px" runat="server"
				Height="24px" Width="200px" Text="Selected Employee List2-Active"></asp:button><asp:panel id="Panel2" style="Z-INDEX: 105; LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server"
				Height="48px" Width="1030px" BackImageUrl="Menu/banner.jpg"></asp:panel><asp:panel id="Panel1" style="Z-INDEX: 104; LEFT: 920px; POSITION: absolute; TOP: 40px" runat="server"
				Height="669px" Width="124px" BackImageUrl="Menu/EMPMASTER4.jpg"></asp:panel><asp:button id="Button2" style="Z-INDEX: 101; LEFT: 392px; POSITION: absolute; TOP: 72px" runat="server"
				Height="24px" Width="184px" Text="All Employee List2-Active" Visible="False"></asp:button><asp:button id="Button3" style="Z-INDEX: 102; LEFT: 536px; POSITION: absolute; TOP: 96px" runat="server"
				Height="24px" Width="210px" Text="All Employee List2-DeActive" Visible="False"></asp:button><asp:dropdownlist id="LstCom" style="Z-INDEX: 106; LEFT: 8px; POSITION: absolute; TOP: 64px" runat="server"
				Height="32px" Width="392px"></asp:dropdownlist><asp:label id="L1" style="Z-INDEX: 109; LEFT: 768px; POSITION: absolute; TOP: 96px" runat="server"
				Height="16px" Width="144px"></asp:label><asp:button id="Button6" style="Z-INDEX: 110; LEFT: 168px; POSITION: absolute; TOP: 184px" runat="server"
				Width="152px" Text="Button" Visible="False"></asp:button><asp:button id="Button7" style="Z-INDEX: 113; LEFT: 256px; POSITION: absolute; TOP: 104px" runat="server"
				Height="24px" Width="200px" Text="All company Employee List2-Active"></asp:button><asp:textbox id="TxtFg" style="Z-INDEX: 114; LEFT: 480px; POSITION: absolute; TOP: 104px" runat="server"
				Height="24px" Width="40px" Visible="False"></asp:textbox><asp:imagebutton id="ImageButton2" style="Z-INDEX: 115; LEFT: 768px; POSITION: absolute; TOP: 64px"
				runat="server" Height="24px" Width="78px" ImageUrl="iCO\xls.jpg"></asp:imagebutton></form>
	</body>
</HTML>
