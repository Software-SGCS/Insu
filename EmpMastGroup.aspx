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
				Width="956px" Height="48px" BackColor="Desktop"></asp:panel><asp:button id="Button2" style="Z-INDEX: 117; LEFT: 384px; POSITION: absolute; TOP: 184px" tabIndex="35"
				runat="server" Height="20px" Width="56px" Text="Refresh" BackColor="#FFC0C0" Font-Names="Calibri" Font-Size="X-Small"></asp:button><asp:button id="BtnEdit" style="Z-INDEX: 116; LEFT: 304px; POSITION: absolute; TOP: 184px" tabIndex="35"
				runat="server" Height="20px" Width="56px" Text="Edit Item" BackColor="#FFC0C0" Font-Names="Calibri" Font-Size="X-Small"></asp:button>
			<asp:button id="BtnaddItm" style="Z-INDEX: 113; LEFT: 224px; POSITION: absolute; TOP: 184px"
				tabIndex="35" runat="server" Width="56px" Height="20px" BackColor="#FFC0C0" Text="Add Item"
				Font-Names="Calibri" Font-Size="X-Small"></asp:button><asp:dropdownlist id="LstCom" style="Z-INDEX: 112; LEFT: 328px; POSITION: absolute; TOP: 88px" tabIndex="2"
				runat="server" Height="18px" Width="422px" Font-Names="Calibri" Font-Size="X-Small"></asp:dropdownlist><asp:dropdownlist id="LstEmpNo" style="Z-INDEX: 111; LEFT: 328px; POSITION: absolute; TOP: 48px" tabIndex="2"
				runat="server" Height="18px" Width="76px" AutoPostBack="True" Font-Names="Calibri" Font-Size="X-Small"></asp:dropdownlist><asp:textbox id="TxtIdNo" style="Z-INDEX: 110; LEFT: 328px; POSITION: absolute; TOP: 152px" tabIndex="1"
				runat="server" BackColor="White" Height="18px" Width="322px" Font-Names="Calibri" Font-Size="X-Small"></asp:textbox><asp:textbox id="TxtNam" style="Z-INDEX: 109; LEFT: 328px; POSITION: absolute; TOP: 120px" tabIndex="1"
				runat="server" BackColor="White" Height="18px" Width="322px" Font-Names="Calibri" Font-Size="X-Small"></asp:textbox><asp:button id="BTNADD" style="Z-INDEX: 104; LEFT: 144px; POSITION: absolute; TOP: 184px" tabIndex="35"
				runat="server" Height="20px" Width="56px" Text="Save" BackColor="#FFC0C0" Font-Names="Calibri" Font-Size="X-Small"></asp:button><asp:button id="Btnser" style="Z-INDEX: 103; LEFT: 792px; POSITION: absolute; TOP: 88px" tabIndex="36"
				runat="server" Height="18px" Width="62px" Text="SERCH" Font-Names="Calibri" Font-Size="X-Small"></asp:button><asp:panel id="Panel2" style="Z-INDEX: 102; LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server"
				BackColor="Desktop" Height="48px" Width="956px">
<asp:panel id="Panel4" style="Z-INDEX: 118; LEFT: 0px; POSITION: absolute; TOP: 176px" runat="server"
					Width="956px" Height="32px" BackColor="Desktop"></asp:panel>Employee Master 
File-Group</asp:panel>
			<asp:label id="Label1" style="Z-INDEX: 105; LEFT: 144px; POSITION: absolute; TOP: 56px" runat="server"
				Height="16px" Width="144px" Font-Names="Calibri" Font-Size="X-Small">Emp No</asp:label><asp:label id="Label2" style="Z-INDEX: 106; LEFT: 144px; POSITION: absolute; TOP: 88px" runat="server"
				Height="24px" Width="144px" Font-Names="Calibri" Font-Size="X-Small"> Company</asp:label><asp:label id="Label3" style="Z-INDEX: 107; LEFT: 144px; POSITION: absolute; TOP: 120px" runat="server"
				Height="8px" Width="144px" Font-Names="Calibri" Font-Size="X-Small">Employee Name</asp:label><asp:label id="Label4" style="Z-INDEX: 108; LEFT: 144px; POSITION: absolute; TOP: 152px" runat="server"
				Height="24px" Width="144px" Font-Names="Calibri" Font-Size="X-Small">Id No</asp:label><asp:textbox id="TxtEmpno" style="Z-INDEX: 114; LEFT: 416px; POSITION: absolute; TOP: 48px" runat="server"
				Width="62px" Height="18px" Font-Names="Calibri" Font-Size="X-Small"></asp:textbox><asp:textbox id="TxtCom" style="Z-INDEX: 115; LEFT: 336px; POSITION: absolute; TOP: 88px" runat="server"
				Width="76px" Font-Names="Calibri" Font-Size="X-Small"></asp:textbox></form>
	</body>
</HTML>
