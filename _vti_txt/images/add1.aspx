<%@ Page Language="vb" AutoEventWireup="false" Codebehind="WebForm3.aspx.vb" Inherits="Fleet.WebForm3"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>WebForm3</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="white" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:panel id="Panel1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 88px" runat="server"
				Width="174px" Height="732px" BackColor="LightSeaGreen" ForeColor="#004000" HorizontalAlign="Center">Panel 
<asp:imagebutton id="Image1" runat="server" Width="150px" Height="120px"></asp:imagebutton>
<asp:imagebutton id="Image2" runat="server" Width="150px" Height="120px"></asp:imagebutton>
<asp:imagebutton id="Image3" runat="server" Width="150px" Height="120px"></asp:imagebutton></asp:panel><asp:label id="MSG" style="Z-INDEX: 118; LEFT: 224px; POSITION: absolute; TOP: 320px" runat="server"
				Width="264px" ForeColor="Red" Font-Bold="True"></asp:label><asp:imagebutton id="ImageButton1" style="Z-INDEX: 117; LEFT: 776px; POSITION: absolute; TOP: 24px"
				runat="server" Width="44px" Height="48px" ImageUrl="file:///D:\Inetpub\wwwroot\Fleet\iCO\Home1.jpg"></asp:imagebutton><asp:button id="BtnEdit" style="Z-INDEX: 116; LEFT: 416px; POSITION: absolute; TOP: 248px" tabIndex="35"
				runat="server" Width="94px" Height="28px" Text="Edit Item"></asp:button><asp:button id="BtnaddItm" style="Z-INDEX: 113; LEFT: 312px; POSITION: absolute; TOP: 248px"
				tabIndex="35" runat="server" Width="94px" Height="28px" Text="Add Item"></asp:button><asp:dropdownlist id="LstSysRno" style="Z-INDEX: 112; LEFT: 376px; POSITION: absolute; TOP: 144px"
				tabIndex="2" runat="server" Width="76px" Height="24px"></asp:dropdownlist><asp:dropdownlist id="LstSysRtp" style="Z-INDEX: 111; LEFT: 376px; POSITION: absolute; TOP: 104px"
				tabIndex="2" runat="server" Width="72px" Height="24px" AutoPostBack="True"></asp:dropdownlist><asp:textbox id="Txtdes2" style="Z-INDEX: 110; LEFT: 376px; POSITION: absolute; TOP: 208px" tabIndex="1"
				runat="server" Width="322px" Height="26px" BackColor="#80FF80"></asp:textbox><asp:textbox id="Txtdes1" style="Z-INDEX: 109; LEFT: 376px; POSITION: absolute; TOP: 176px" tabIndex="1"
				runat="server" Width="322px" Height="26px" BackColor="#80FF80"></asp:textbox><asp:button id="BTNADD" style="Z-INDEX: 104; LEFT: 200px; POSITION: absolute; TOP: 248px" tabIndex="35"
				runat="server" Width="94px" Height="28px" Text="Save"></asp:button><asp:button id="Btnser" style="Z-INDEX: 103; LEFT: 464px; POSITION: absolute; TOP: 144px" tabIndex="36"
				runat="server" Width="62px" Height="20px" Text="SERCH"></asp:button><asp:panel id="Panel2" style="Z-INDEX: 102; LEFT: 8px; POSITION: absolute; TOP: 8px" runat="server"
				Width="830px" Height="80px" BackColor="Teal">Panel</asp:panel>
			<asp:label id="Label1" style="Z-INDEX: 105; LEFT: 200px; POSITION: absolute; TOP: 112px" runat="server"
				Width="144px" Height="16px">Record Type</asp:label><asp:label id="Label2" style="Z-INDEX: 106; LEFT: 200px; POSITION: absolute; TOP: 144px" runat="server"
				Width="144px" Height="24px">Record No</asp:label><asp:label id="Label3" style="Z-INDEX: 107; LEFT: 200px; POSITION: absolute; TOP: 176px" runat="server"
				Width="144px" Height="8px">Description 1</asp:label><asp:label id="Label4" style="Z-INDEX: 108; LEFT: 200px; POSITION: absolute; TOP: 208px" runat="server"
				Width="152px" Height="24px">Description 2</asp:label><asp:textbox id="Txtrtp" style="Z-INDEX: 114; LEFT: 376px; POSITION: absolute; TOP: 104px" runat="server"
				Width="40px"></asp:textbox><asp:textbox id="TxtRno" style="Z-INDEX: 115; LEFT: 376px; POSITION: absolute; TOP: 144px" runat="server"
				Width="48px" Height="19px"></asp:textbox></form>
	</body>
</HTML>
