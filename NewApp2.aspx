<%@ Page Language="vb" AutoEventWireup="false" Codebehind="NewApp2.aspx.vb" Inherits="Insu.NewApp2" %>
<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
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
				Width="80px" Height="24px" Visible="False">Invoice No</asp:label><asp:image id="Image6" style="Z-INDEX: 113; LEFT: 336px; POSITION: absolute; TOP: 664px" runat="server"
				Width="120px" Height="102px" ImageUrl="Menu/vehicle1.gif"></asp:image><asp:image id="Image4" style="Z-INDEX: 111; LEFT: 112px; POSITION: absolute; TOP: 664px" runat="server"
				Width="112px" Height="104px" ImageUrl="Menu/AssetI.gif"></asp:image><asp:image id="Image2" style="Z-INDEX: 109; LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server"
				Width="104px" Height="32px" ImageUrl="imgs/logo.cnn.com.gif"></asp:image><asp:button id="Button4" style="Z-INDEX: 107; LEFT: 640px; POSITION: absolute; TOP: 656px" runat="server"
				Width="144px" Height="24px" Visible="False" Text="Tax Invoice-File Copy"></asp:button><asp:button id="Button3" style="Z-INDEX: 106; LEFT: 456px; POSITION: absolute; TOP: 688px" runat="server"
				Width="116px" Height="24px" Text="Not Approve" ForeColor="Black" BackColor="Desktop"></asp:button><asp:button id="Button2" style="Z-INDEX: 105; LEFT: 816px; POSITION: absolute; TOP: 656px" runat="server"
				Width="96px" Height="24px" Visible="False" Text="Print"></asp:button><asp:button id="Button1" style="Z-INDEX: 104; LEFT: 456px; POSITION: absolute; TOP: 664px" runat="server"
				Width="116px" Height="24px" Text="Approve" ForeColor="Black" BackColor="Desktop"></asp:button><asp:dropdownlist id="LstId" style="Z-INDEX: 101; LEFT: 456px; POSITION: absolute; TOP: 752px" runat="server"
				Width="64px" Height="10px" Visible="False"></asp:dropdownlist>
			<DIV id="Layer1" style="Z-INDEX: 103; LEFT: 0px; OVERFLOW: scroll; WIDTH: 974px; POSITION: absolute; TOP: 32px; HEIGHT: 634px"><CR:CRYSTALREPORTVIEWER id="CrystalReportViewer2" style="Z-INDEX: 110; LEFT: -336px; POSITION: absolute; TOP: 0px"
					runat="server" Width="350px" Height="50px" Visible="False" SeparatePages="False" DisplayToolbar="False"></CR:CRYSTALREPORTVIEWER><asp:textbox id="TxtInvNo" runat="server" Width="104px" Height="26px" Visible="False"></asp:textbox></DIV>
			<asp:image id="Image1" style="Z-INDEX: 108; LEFT: 112px; POSITION: absolute; TOP: 0px" runat="server"
				Width="862px" Height="32px" ImageUrl="Menu/BANNER.jpg"></asp:image><asp:image id="Image3" style="Z-INDEX: 110; LEFT: 0px; POSITION: absolute; TOP: 664px" runat="server"
				Width="112px" Height="102px" ImageUrl="Menu/Audit.gif"></asp:image><asp:image id="Image5" style="Z-INDEX: 112; LEFT: 224px; POSITION: absolute; TOP: 664px" runat="server"
				Width="112px" Height="102px" ImageUrl="Menu/vehicle1.jpg"></asp:image><asp:panel id="Panel1" style="Z-INDEX: 114; LEFT: 970px; POSITION: absolute; TOP: -8px" runat="server"
				Width="94px" Height="674px" BackColor="Desktop"></asp:panel></FORM>
	</body>
</HTML>
