<%@ Page Language="vb" AutoEventWireup="false" Codebehind="HltMaster.aspx.vb" Inherits="Insu.HltMaster"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>WebForm3</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="#ffffff" leftMargin="0" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:panel id="Panel1" style="Z-INDEX: 101; LEFT: -8px; POSITION: absolute; TOP: 48px" runat="server"
				Width="128px" Height="383px" BackColor="Desktop" ForeColor="#004000" HorizontalAlign="Center"
				BackImageUrl="Menu/Audit.gif">&nbsp;</asp:panel><asp:button id="Button2" style="Z-INDEX: 117; LEFT: 560px; POSITION: absolute; TOP: 328px" tabIndex="35"
				runat="server" Width="94px" Height="28px" Text="Refresh"></asp:button><asp:button id="BtnEdit" style="Z-INDEX: 116; LEFT: 424px; POSITION: absolute; TOP: 328px" tabIndex="35"
				runat="server" Width="94px" Height="28px" Text="Edit Item"></asp:button><asp:button id="BtnaddItm" style="Z-INDEX: 113; LEFT: 280px; POSITION: absolute; TOP: 328px"
				tabIndex="35" runat="server" Width="94px" Height="28px" Text="Add Item"></asp:button><asp:dropdownlist id="LstCom" style="Z-INDEX: 112; LEFT: 328px; POSITION: absolute; TOP: 88px" tabIndex="2"
				runat="server" Width="326px" Height="24px" AutoPostBack="True"></asp:dropdownlist><asp:dropdownlist id="LstEmpNo" style="Z-INDEX: 111; LEFT: 328px; POSITION: absolute; TOP: 128px"
				tabIndex="2" runat="server" Width="76px" Height="24px" AutoPostBack="True"></asp:dropdownlist><asp:textbox id="TxtIdNo" style="Z-INDEX: 110; LEFT: 328px; POSITION: absolute; TOP: 200px" tabIndex="1"
				runat="server" Width="136px" Height="26px" BackColor="White"></asp:textbox><asp:textbox id="TxtNam" style="Z-INDEX: 109; LEFT: 328px; POSITION: absolute; TOP: 160px" tabIndex="1"
				runat="server" Width="322px" Height="26px" BackColor="White"></asp:textbox><asp:button id="BTNADD" style="Z-INDEX: 104; LEFT: 144px; POSITION: absolute; TOP: 328px" tabIndex="35"
				runat="server" Width="94px" Height="28px" Text="Save"></asp:button><asp:button id="Btnser" style="Z-INDEX: 103; LEFT: 664px; POSITION: absolute; TOP: 88px" tabIndex="36"
				runat="server" Width="54px" Height="20px" Text="SERCH"></asp:button><asp:panel id="Panel2" style="Z-INDEX: 102; LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server"
				Width="956px" Height="48px" BackColor="Desktop"> 
<asp:panel id="Panel4" style="Z-INDEX: 118; LEFT: 0px; POSITION: absolute; TOP: 384px" runat="server"
					BackColor="Desktop" Height="48px" Width="956px"></asp:panel>
<asp:label id="Label8" style="Z-INDEX: 120; LEFT: 544px; POSITION: absolute; TOP: 288px" runat="server"
					BackColor="White" Height="24px" Width="86px">Old Epfno</asp:label>Employee 
Master File-Group</asp:panel>
			<asp:label id="Label1" style="Z-INDEX: 105; LEFT: 144px; POSITION: absolute; TOP: 128px" runat="server"
				Width="144px" Height="16px">Emp No</asp:label><asp:label id="Label2" style="Z-INDEX: 106; LEFT: 144px; POSITION: absolute; TOP: 88px" runat="server"
				Width="144px" Height="24px"> Company</asp:label><asp:label id="Label3" style="Z-INDEX: 107; LEFT: 144px; POSITION: absolute; TOP: 168px" runat="server"
				Width="144px" Height="8px">Employee Name</asp:label><asp:label id="Label4" style="Z-INDEX: 108; LEFT: 144px; POSITION: absolute; TOP: 200px" runat="server"
				Width="144px" Height="24px">Id No</asp:label><asp:textbox id="TxtEmpno" style="Z-INDEX: 114; LEFT: 336px; POSITION: absolute; TOP: 128px"
				runat="server" Width="62px"></asp:textbox><asp:textbox id="TxtCom" style="Z-INDEX: 115; LEFT: 328px; POSITION: absolute; TOP: 88px" runat="server"
				Width="76px" AutoPostBack="True"></asp:textbox><asp:textbox id="Txtdob" style="Z-INDEX: 118; LEFT: 328px; POSITION: absolute; TOP: 240px" runat="server"
				Width="80px" Height="24px"></asp:textbox><asp:label id="Label5" style="Z-INDEX: 119; LEFT: 144px; POSITION: absolute; TOP: 240px" runat="server"
				Width="152px" Height="32px">Date of Birth</asp:label><asp:label id="Label6" style="Z-INDEX: 120; LEFT: 144px; POSITION: absolute; TOP: 288px" runat="server"
				Width="169px" Height="24px">No of Childs</asp:label><asp:textbox id="TxtCld" style="Z-INDEX: 121; LEFT: 328px; POSITION: absolute; TOP: 288px" runat="server"
				Width="48px" Height="24px"></asp:textbox><asp:textbox id="TxtAct" style="Z-INDEX: 122; LEFT: 512px; POSITION: absolute; TOP: 288px" runat="server"
				Width="24px" Height="24px"></asp:textbox><asp:label id="Label7" style="Z-INDEX: 123; LEFT: 400px; POSITION: absolute; TOP: 288px" runat="server"
				Width="89px" Height="24px">Active(Y/N)</asp:label><asp:textbox id="TxtOldepfno" style="Z-INDEX: 124; LEFT: 648px; POSITION: absolute; TOP: 288px"
				runat="server" Width="58px" Height="26px"></asp:textbox></form>
	</body>
</HTML>
