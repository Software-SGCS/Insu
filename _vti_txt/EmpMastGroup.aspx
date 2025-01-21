<%@ Page Language="vb" AutoEventWireup="false" Codebehind="EmpMastGroup.aspx.vb" Inherits="Insu.EmpMastGroup"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>WebForm3</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="#ffffff" MS_POSITIONING="GridLayout" leftmargin="0">
		<form id="Form1" method="post" runat="server">
			<asp:panel id="Panel1" style="Z-INDEX: 101; LEFT: -8px; POSITION: absolute; TOP: 48px" runat="server"
				HorizontalAlign="Center" ForeColor="#004000" BackColor="Desktop" Height="344px" Width="112px"
				BackImageUrl="Menu/Audit.gif">&nbsp;</asp:panel>
			<asp:panel id="Panel3" style="Z-INDEX: 118; LEFT: 0px; POSITION: absolute; TOP: 392px" runat="server"
				Width="956px" Height="48px" BackColor="Desktop"></asp:panel><asp:button id="Button2" style="Z-INDEX: 117; LEFT: 560px; POSITION: absolute; TOP: 248px" tabIndex="35"
				runat="server" Height="28px" Width="94px" Text="Refresh"></asp:button><asp:button id="BtnEdit" style="Z-INDEX: 116; LEFT: 424px; POSITION: absolute; TOP: 248px" tabIndex="35"
				runat="server" Height="28px" Width="94px" Text="Edit Item"></asp:button><asp:button id="BtnaddItm" style="Z-INDEX: 113; LEFT: 280px; POSITION: absolute; TOP: 248px"
				tabIndex="35" runat="server" Height="28px" Width="94px" Text="Add Item"></asp:button><asp:dropdownlist id="LstCom" style="Z-INDEX: 112; LEFT: 328px; POSITION: absolute; TOP: 144px" tabIndex="2"
				runat="server" Height="24px" Width="422px"></asp:dropdownlist><asp:dropdownlist id="LstEmpNo" style="Z-INDEX: 111; LEFT: 328px; POSITION: absolute; TOP: 104px"
				tabIndex="2" runat="server" Height="24px" Width="76px" AutoPostBack="True"></asp:dropdownlist><asp:textbox id="TxtIdNo" style="Z-INDEX: 110; LEFT: 328px; POSITION: absolute; TOP: 208px" tabIndex="1"
				runat="server" BackColor="White" Height="26px" Width="322px"></asp:textbox><asp:textbox id="TxtNam" style="Z-INDEX: 109; LEFT: 328px; POSITION: absolute; TOP: 176px" tabIndex="1"
				runat="server" BackColor="White" Height="26px" Width="322px"></asp:textbox><asp:button id="BTNADD" style="Z-INDEX: 104; LEFT: 144px; POSITION: absolute; TOP: 248px" tabIndex="35"
				runat="server" Height="28px" Width="94px" Text="Save"></asp:button><asp:button id="Btnser" style="Z-INDEX: 103; LEFT: 792px; POSITION: absolute; TOP: 144px" tabIndex="36"
				runat="server" Height="20px" Width="62px" Text="SERCH"></asp:button><asp:panel id="Panel2" style="Z-INDEX: 102; LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server"
				BackColor="Desktop" Height="48px" Width="956px">
<asp:panel id="Panel4" style="Z-INDEX: 118; LEFT: 0px; POSITION: absolute; TOP: 240px" runat="server"
					Width="956px" Height="48px" BackColor="Desktop"></asp:panel>Employee Master 
File-Group</asp:panel>
			<asp:label id="Label1" style="Z-INDEX: 105; LEFT: 144px; POSITION: absolute; TOP: 112px" runat="server"
				Height="16px" Width="144px">Emp No</asp:label><asp:label id="Label2" style="Z-INDEX: 106; LEFT: 144px; POSITION: absolute; TOP: 144px" runat="server"
				Height="24px" Width="144px"> Company</asp:label><asp:label id="Label3" style="Z-INDEX: 107; LEFT: 144px; POSITION: absolute; TOP: 176px" runat="server"
				Height="8px" Width="144px">Employee Name</asp:label><asp:label id="Label4" style="Z-INDEX: 108; LEFT: 144px; POSITION: absolute; TOP: 208px" runat="server"
				Height="24px" Width="144px">Id No</asp:label><asp:textbox id="TxtEmpno" style="Z-INDEX: 114; LEFT: 328px; POSITION: absolute; TOP: 104px"
				runat="server" Width="62px"></asp:textbox><asp:textbox id="TxtCom" style="Z-INDEX: 115; LEFT: 336px; POSITION: absolute; TOP: 144px" runat="server"
				Width="76px"></asp:textbox></form>
	</body>
</HTML>
