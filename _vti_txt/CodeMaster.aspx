<%@ Page Language="vb" AutoEventWireup="false" Codebehind="CodeMaster.aspx.vb" Inherits="Insu.CodeMaster" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Code_Master</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout" leftmargin="0">
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label1" style="Z-INDEX: 113; LEFT: 144px; POSITION: absolute; TOP: 104px" runat="server"
				Height="16px" Width="106px"> Item Code</asp:label>
			<asp:panel id="Panel3" style="Z-INDEX: 128; LEFT: 8px; POSITION: absolute; TOP: 344px" runat="server"
				Width="882px" Height="48px" BackColor="Desktop"></asp:panel>
			<asp:label id="Label8" style="Z-INDEX: 127; LEFT: 144px; POSITION: absolute; TOP: 240px" runat="server"
				Width="144px" Height="24px">Discount(%)</asp:label><asp:label id="Label7" style="Z-INDEX: 124; LEFT: 16px; POSITION: absolute; TOP: 16px" runat="server"
				Height="32px" Width="248px" Font-Size="Larger" Font-Bold="True" BackColor="Desktop" ForeColor="White">Code Master File</asp:label><asp:textbox id="TxtQty" style="Z-INDEX: 123; LEFT: 296px; POSITION: absolute; TOP: 272px" tabIndex="1"
				runat="server" Height="30px" Width="130px" BackColor="White"></asp:textbox><asp:label id="Label6" style="Z-INDEX: 122; LEFT: 144px; POSITION: absolute; TOP: 280px" runat="server"
				Height="24px" Width="144px">Stock Qty</asp:label><asp:textbox id="TxtSPri" style="Z-INDEX: 121; LEFT: 296px; POSITION: absolute; TOP: 200px" tabIndex="1"
				runat="server" Height="26px" Width="130px" BackColor="White"></asp:textbox><asp:label id="Label5" style="Z-INDEX: 120; LEFT: 144px; POSITION: absolute; TOP: 208px" runat="server"
				Height="16px" Width="144px">Sales Price (Rs)</asp:label><asp:textbox id="TxtCpri" style="Z-INDEX: 107; LEFT: 296px; POSITION: absolute; TOP: 168px" tabIndex="1"
				runat="server" Height="26px" Width="130px" BackColor="White"></asp:textbox><asp:button id="BtnRefres" style="Z-INDEX: 119; LEFT: 592px; POSITION: absolute; TOP: 320px"
				tabIndex="35" runat="server" Height="28px" Width="76px" Text="Refres"></asp:button><asp:button id="BtnDel" style="Z-INDEX: 116; LEFT: 488px; POSITION: absolute; TOP: 320px" tabIndex="35"
				runat="server" Height="28px" Width="76px" Text="Delete"></asp:button><asp:dropdownlist id="LstCatNo" style="Z-INDEX: 114; LEFT: 296px; POSITION: absolute; TOP: 64px" tabIndex="2"
				runat="server" Height="24px" Width="126px" AutoPostBack="True" Visible="False"></asp:dropdownlist><asp:dropdownlist id="LstItmNo" style="Z-INDEX: 108; LEFT: 296px; POSITION: absolute; TOP: 104px"
				tabIndex="2" runat="server" Height="24px" Width="390px" AutoPostBack="True"></asp:dropdownlist><asp:textbox id="TxtItmNo" style="Z-INDEX: 110; LEFT: 296px; POSITION: absolute; TOP: 104px"
				runat="server" Height="24px" Width="72px"></asp:textbox><asp:label id="Label2" style="Z-INDEX: 102; LEFT: 144px; POSITION: absolute; TOP: 64px" runat="server"
				Height="24px" Width="106px" Visible="False">Category Code</asp:label><asp:textbox id="TxtDepNo" style="Z-INDEX: 111; LEFT: 296px; POSITION: absolute; TOP: 64px" runat="server"
				Width="126px" Visible="False"></asp:textbox><asp:button id="Btnser" style="Z-INDEX: 100; LEFT: 736px; POSITION: absolute; TOP: 104px" tabIndex="36"
				runat="server" Height="24px" Width="72px" Text="SERCH"></asp:button><asp:label id="Label3" style="Z-INDEX: 103; LEFT: 144px; POSITION: absolute; TOP: 136px" runat="server"
				Height="16px" Width="128px">Item Description</asp:label><asp:textbox id="TxtDes" style="Z-INDEX: 105; LEFT: 296px; POSITION: absolute; TOP: 136px" tabIndex="1"
				runat="server" Height="26px" Width="315px" BackColor="White" AutoPostBack="True"></asp:textbox><asp:label id="Label4" style="Z-INDEX: 104; LEFT: 144px; POSITION: absolute; TOP: 168px" runat="server"
				Height="24px" Width="144px">Cost Price (Rs)</asp:label><asp:textbox id="TxtDis" style="Z-INDEX: 106; LEFT: 296px; POSITION: absolute; TOP: 232px" tabIndex="1"
				runat="server" Height="26px" Width="68px" BackColor="White"></asp:textbox><asp:button id="BTNADD" style="Z-INDEX: 101; LEFT: 376px; POSITION: absolute; TOP: 320px" tabIndex="35"
				runat="server" Height="28px" Width="76px" Text="Update"></asp:button><asp:button id="BtnaddItm" style="Z-INDEX: 109; LEFT: 144px; POSITION: absolute; TOP: 320px"
				tabIndex="35" runat="server" Height="28px" Width="84px" Text="Add Item"></asp:button><asp:button id="BtnEdit" style="Z-INDEX: 112; LEFT: 256px; POSITION: absolute; TOP: 320px" tabIndex="35"
				runat="server" Height="28px" Width="84px" Text="Edit Item"></asp:button><asp:panel id="Panel1" style="Z-INDEX: 117; LEFT: 8px; POSITION: absolute; TOP: 8px" runat="server"
				Height="40px" Width="880px" BackColor="Desktop"></asp:panel><asp:panel id="Panel2" style="Z-INDEX: 118; LEFT: 8px; POSITION: absolute; TOP: 48px" runat="server"
				Height="304px" Width="120px" BackColor="Desktop" BackImageUrl="Menu/Audit.gif"></asp:panel></form>
	</body>
</HTML>
