<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Qutation.aspx.vb" Inherits="Insu.Qutation"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Qutation</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<DIV style="Z-INDEX: 101; LEFT: 8px; WIDTH: 10px; POSITION: absolute; TOP: 8px; HEIGHT: 10px"
				ms_positioning="text2D">
				<asp:label id="Label1" style="Z-INDEX: 149; LEFT: 120px; POSITION: absolute; TOP: 40px" runat="server"
					Width="104px" Height="24px" Font-Bold="True">Quation No</asp:label>
				<asp:label id="Label2" style="Z-INDEX: 150; LEFT: 120px; POSITION: absolute; TOP: 112px" runat="server"
					Width="104px" Height="24px" Font-Bold="True">Quation Date</asp:label>
		</form>
		<FORM id="Form2" method="post" runat="server">
			<asp:panel id="Panel1" style="Z-INDEX: 100; LEFT: 8px; POSITION: absolute; TOP: 8px" runat="server"
				Width="802px" Height="24px" HorizontalAlign="Left" Enabled="False" BackColor="CornflowerBlue"
				Font-Bold="True" ForeColor="White" BorderColor="Transparent">Vehicle Detail</asp:panel>
			<asp:label id="Label19" style="Z-INDEX: 138; LEFT: 536px; POSITION: absolute; TOP: 280px" runat="server"
				Width="16px" Height="16px" Font-Bold="True">:</asp:label>
			<asp:textbox id="TxtTpay" style="Z-INDEX: 136; LEFT: 552px; POSITION: absolute; TOP: 272px" tabIndex="6"
				runat="server" Width="120px" Height="24px" AutoPostBack="True" ReadOnly="True"></asp:textbox>
			<asp:panel id="Panel5" style="Z-INDEX: 129; LEFT: 8px; POSITION: absolute; TOP: 168px" runat="server"
				Width="104px" Height="214px" BackColor="SkyBlue"></asp:panel>
			<asp:label id="Label14" style="Z-INDEX: 125; LEFT: 536px; POSITION: absolute; TOP: 216px" runat="server"
				Width="16px" Height="16px" Font-Bold="True">:</asp:label>
			<asp:label id="Label13" style="Z-INDEX: 124; LEFT: 536px; POSITION: absolute; TOP: 248px" runat="server"
				Width="16px" Height="16px" Font-Bold="True">:</asp:label>
			<asp:label id="Label8" style="Z-INDEX: 110; LEFT: 224px; POSITION: absolute; TOP: 112px" runat="server"
				Width="16px" Height="16px" Font-Bold="True">:</asp:label>
			<asp:label id="Label7" style="Z-INDEX: 109; LEFT: 224px; POSITION: absolute; TOP: 72px" runat="server"
				Width="16px" Height="16px" Font-Bold="True">:</asp:label>
			<asp:panel id="Panel3" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 144px" runat="server"
				Width="802px" Height="24px" BackColor="SkyBlue" Font-Bold="True">Payment Detail</asp:panel>
			<asp:panel id="Panel4" style="Z-INDEX: 102; LEFT: -16px; POSITION: absolute; TOP: 344px" runat="server"
				Width="812px" Height="40px" BackColor="CornflowerBlue"></asp:panel>
			<asp:button id="BtnCle" style="Z-INDEX: 103; LEFT: 264px; POSITION: absolute; TOP: 352px" tabIndex="9"
				runat="server" Width="72px" Height="24px" Font-Bold="True" Text="Clear"></asp:button>
			<asp:label id="Label3" style="Z-INDEX: 104; LEFT: 120px; POSITION: absolute; TOP: 80px" runat="server"
				Width="104px" Height="24px" Font-Bold="True">Company Code</asp:label>
			<asp:label id="Label6" style="Z-INDEX: 108; LEFT: 224px; POSITION: absolute; TOP: 40px" runat="server"
				Width="16px" Height="16px" Font-Bold="True">:</asp:label>
			<asp:button id="BtnEdit" style="Z-INDEX: 113; LEFT: 192px; POSITION: absolute; TOP: 352px" tabIndex="8"
				runat="server" Width="64px" Font-Bold="True" Text="Edit"></asp:button>
			<asp:textbox id="TxtId" style="Z-INDEX: 114; LEFT: 248px; POSITION: absolute; TOP: 40px" tabIndex="2"
				runat="server" Width="134px"></asp:textbox>
			<asp:dropdownlist id="LstCom" style="Z-INDEX: 116; LEFT: 248px; POSITION: absolute; TOP: 80px" tabIndex="2"
				runat="server" Width="336px" Height="16px" AutoPostBack="True"></asp:dropdownlist>
			<asp:textbox id="Txttr" style="Z-INDEX: 119; LEFT: 552px; POSITION: absolute; TOP: 240px" tabIndex="8"
				runat="server" Width="118px" Height="30px" AutoPostBack="True" ReadOnly="True"></asp:textbox>
			<asp:button id="BtnDel" style="Z-INDEX: 121; LEFT: 416px; POSITION: absolute; TOP: 352px" tabIndex="11"
				runat="server" Width="64px" Font-Bold="True" Text="Delete"></asp:button>
			<asp:panel id="Panel2" style="Z-INDEX: 128; LEFT: 8px; POSITION: absolute; TOP: 32px" runat="server"
				Width="104px" Height="112px" BackColor="CornflowerBlue"></asp:panel>
			<asp:textbox id="Txtbpay" style="Z-INDEX: 131; LEFT: 552px; POSITION: absolute; TOP: 208px" tabIndex="7"
				runat="server" Width="118px" Height="24px" AutoPostBack="True" ReadOnly="True"></asp:textbox>
			<asp:button id="BtnAdd" style="Z-INDEX: 133; LEFT: 120px; POSITION: absolute; TOP: 352px" tabIndex="7"
				runat="server" Width="64px" Font-Bold="True" Text="Add"></asp:button>
			<asp:label id="LbLMsg" style="Z-INDEX: 139; LEFT: 484px; POSITION: absolute; TOP: 120px" runat="server"
				Width="324px" Height="24px"></asp:label>
			<asp:imagebutton id="Img1" style="Z-INDEX: 140; LEFT: 16px; POSITION: absolute; TOP: 48px" runat="server"
				Width="89px" Height="72px"></asp:imagebutton>
			<asp:imagebutton id="Img2" style="Z-INDEX: 141; LEFT: 16px; POSITION: absolute; TOP: 208px" runat="server"
				Width="89px" Height="74px"></asp:imagebutton>
			<asp:button id="BtnApp" style="Z-INDEX: 148; LEFT: 344px; POSITION: absolute; TOP: 352px" tabIndex="10"
				runat="server" Width="66px" Font-Bold="True" Text="Apply"></asp:button></FORM>
		<FORM id="Form3" method="post" runat="server">
			</DIV>
			<asp:TextBox id="TxtQdt" style="Z-INDEX: 102; LEFT: 256px; POSITION: absolute; TOP: 120px" runat="server"
				Width="108px"></asp:TextBox></FORM>
	</body>
</HTML>
