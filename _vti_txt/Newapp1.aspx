<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Newapp1.aspx.vb" Inherits="Insu.NewApp1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>NewApp1</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<FORM id="Form1" method="post" runat="server">
			<asp:label id="Label1" style="Z-INDEX: 102; LEFT: 296px; POSITION: absolute; TOP: 656px" runat="server"
				Width="80px" Height="24px" Visible="False">Invoice No</asp:label><asp:image id="Image7" style="Z-INDEX: 115; LEFT: 0px; POSITION: absolute; TOP: 576px" runat="server"
				Width="152px" Height="90px" ImageUrl="Menu/Vehicle11.gif"></asp:image><asp:image id="Image6" style="Z-INDEX: 113; LEFT: 0px; POSITION: absolute; TOP: 520px" runat="server"
				Width="152px" Height="58px" ImageUrl="Menu/vehicle1.gif"></asp:image><asp:image id="Image4" style="Z-INDEX: 111; LEFT: 0px; POSITION: absolute; TOP: 184px" runat="server"
				Width="152px" Height="128px" ImageUrl="Menu/AssetI.gif"></asp:image><asp:image id="Image2" style="Z-INDEX: 109; LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server"
				Width="176px" Height="56px" ImageUrl="imgs/logo.cnn.com.gif"></asp:image><asp:button id="Button4" style="Z-INDEX: 107; LEFT: 640px; POSITION: absolute; TOP: 656px" runat="server"
				Width="144px" Height="24px" Visible="False" Text="Tax Invoice-File Copy"></asp:button><asp:button id="Button3" style="Z-INDEX: 106; LEFT: 0px; POSITION: absolute; TOP: 480px" runat="server"
				Width="152px" Height="42px" Text="Not Approve" ForeColor="Black" BackColor="Desktop"></asp:button><asp:button id="Button2" style="Z-INDEX: 105; LEFT: 816px; POSITION: absolute; TOP: 656px" runat="server"
				Width="96px" Height="24px" Visible="False" Text="Print"></asp:button><asp:button id="Button1" style="Z-INDEX: 104; LEFT: 0px; POSITION: absolute; TOP: 440px" runat="server"
				Width="152px" Height="42px" Text="Approve" ForeColor="Black" BackColor="Desktop"></asp:button><asp:dropdownlist id="LstId" style="Z-INDEX: 101; LEFT: 400px; POSITION: absolute; TOP: 656px" runat="server"
				Width="144px" Height="24px" Visible="False"></asp:dropdownlist>
			<DIV id="Layer1" style="Z-INDEX: 103; LEFT: 152px; OVERFLOW: scroll; WIDTH: 862px; POSITION: absolute; TOP: 56px; HEIGHT: 610px"><CR:CRYSTALREPORTVIEWER id="CrystalReportViewer2" style="Z-INDEX: 110; LEFT: -336px; POSITION: absolute; TOP: 0px"
					runat="server" Width="350px" Height="50px" Visible="False" SeparatePages="False" DisplayToolbar="False"></CR:CRYSTALREPORTVIEWER><asp:textbox id="TxtInvNo" runat="server" Width="104px" Height="26px" Visible="False"></asp:textbox></DIV>
			<asp:image id="Image1" style="Z-INDEX: 108; LEFT: 176px; POSITION: absolute; TOP: 0px" runat="server"
				Width="799px" Height="56px" ImageUrl="Menu/BANNER.jpg"></asp:image><asp:image id="Image3" style="Z-INDEX: 110; LEFT: 0px; POSITION: absolute; TOP: 56px" runat="server"
				Width="152px" Height="128px" ImageUrl="Menu/Audit.gif"></asp:image><asp:image id="Image5" style="Z-INDEX: 112; LEFT: -8px; POSITION: absolute; TOP: 312px" runat="server"
				Width="160px" Height="128px" ImageUrl="Menu/vehicle1.jpg"></asp:image><asp:panel id="Panel1" style="Z-INDEX: 114; LEFT: 1012px; POSITION: absolute; TOP: -8px" runat="server"
				Width="52px" Height="674px" BackColor="Desktop"></asp:panel></FORM>
	</body>
</HTML>
