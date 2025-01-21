<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="HealthReport2.aspx.vb" Inherits="Insu.HealthReport2"%>
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
			<asp:button id="Button1" style="Z-INDEX: 103; LEFT: 168px; POSITION: absolute; TOP: 440px" runat="server"
				Visible="False" Height="24px" Width="144px" Text="Claim Details"></asp:button>
			<DIV id="Layer1" style="Z-INDEX: 122; LEFT: 120px; OVERFLOW: scroll; WIDTH: 824px; POSITION: absolute; TOP: 168px; HEIGHT: 536px"><CR:CRYSTALREPORTVIEWER id="CRYSTALREPORTVIEWER2" runat="server" Width="350px" Height="50px" Visible="False"
					DisplayToolbar="False" SeparatePages="False" DisplayGroupTree="False"></CR:CRYSTALREPORTVIEWER></DIV>
			<asp:textbox id="TxtAccYr" style="Z-INDEX: 121; LEFT: 312px; POSITION: absolute; TOP: 144px"
				tabIndex="4" runat="server" Width="56px" Height="24px"></asp:textbox>
			<asp:label id="Label4" style="Z-INDEX: 120; LEFT: 208px; POSITION: absolute; TOP: 152px" runat="server"
				Width="88px" Height="16px">Account Year</asp:label>
			<asp:ImageButton id="ImageButton2" style="Z-INDEX: 119; LEFT: 848px; POSITION: absolute; TOP: 80px"
				runat="server" Width="78px" Height="24px" ImageUrl="iCO\xls.jpg"></asp:ImageButton><asp:imagebutton id="ImageButton1" style="Z-INDEX: 118; LEFT: 728px; POSITION: absolute; TOP: 80px"
				runat="server" Height="24px" Width="80px" ImageUrl="Menu\print.jpg"></asp:imagebutton><asp:dropdownlist id="LstMt1" style="Z-INDEX: 117; LEFT: 464px; POSITION: absolute; TOP: 112px" runat="server"
				Height="32px" Width="184px"></asp:dropdownlist><asp:label id="Label3" style="Z-INDEX: 116; LEFT: 376px; POSITION: absolute; TOP: 120px" runat="server"
				Height="24px" Width="72px">Month</asp:label><asp:textbox id="TxtYr1" style="Z-INDEX: 115; LEFT: 296px; POSITION: absolute; TOP: 112px" tabIndex="4"
				runat="server" Height="24px" Width="64px"></asp:textbox><asp:label id="Label2" style="Z-INDEX: 114; LEFT: 208px; POSITION: absolute; TOP: 120px" runat="server"
				Height="16px" Width="80px">To Year</asp:label><asp:label id="Lb2" style="Z-INDEX: 112; LEFT: 208px; POSITION: absolute; TOP: 88px" runat="server"
				Height="16px" Width="80px">From Year</asp:label><asp:textbox id="TxtYr" style="Z-INDEX: 111; LEFT: 296px; POSITION: absolute; TOP: 80px" tabIndex="4"
				runat="server" Height="24px" Width="64px"></asp:textbox><asp:label id="lb1" style="Z-INDEX: 110; LEFT: 376px; POSITION: absolute; TOP: 88px" runat="server"
				Height="24px" Width="72px">Month</asp:label><asp:dropdownlist id="LstMt" style="Z-INDEX: 109; LEFT: 464px; POSITION: absolute; TOP: 80px" runat="server"
				Height="32px" Width="184px"></asp:dropdownlist><asp:button id="Button5" style="Z-INDEX: 108; LEFT: 504px; POSITION: absolute; TOP: 448px" runat="server"
				Visible="False" Height="24px" Width="210px" Text="Selected Employee List2-DeActive"></asp:button><asp:button id="Button4" style="Z-INDEX: 107; LEFT: 320px; POSITION: absolute; TOP: 448px" runat="server"
				Visible="False" Height="24px" Width="184px" Text="Selected Employee List2-Active"></asp:button><asp:panel id="Panel2" style="Z-INDEX: 106; LEFT: 8px; POSITION: absolute; TOP: 8px" runat="server"
				Height="48px" Width="1030px" BackImageUrl="Menu/banner.jpg"></asp:panel><asp:panel id="Panel1" style="Z-INDEX: 104; LEFT: 8px; POSITION: absolute; TOP: 56px" runat="server"
				Height="610px" Width="104px" BackImageUrl="Menu/EMPMASTER4.jpg"></asp:panel><asp:button id="Button2" style="Z-INDEX: 101; LEFT: 464px; POSITION: absolute; TOP: 152px" runat="server"
				Height="24px" Width="184px" Text="Claim List Summery"></asp:button><asp:button id="Button3" style="Z-INDEX: 102; LEFT: 600px; POSITION: absolute; TOP: 416px" runat="server"
				Visible="False" Height="24px" Width="210px" Text="All Employee List2-DeActive"></asp:button><asp:dropdownlist id="LstCom" style="Z-INDEX: 105; LEFT: 176px; POSITION: absolute; TOP: 504px" runat="server"
				Visible="False" Height="32px" Width="392px"></asp:dropdownlist></form>
	</body>
</HTML>
