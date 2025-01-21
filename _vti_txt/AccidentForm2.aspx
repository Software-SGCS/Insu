<%@ Page Language="vb" AutoEventWireup="false" Codebehind="AccidentForm2.aspx.vb" Inherits="Insu.AccidentForm2" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Accident Form1</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:panel id="Panel1" style="Z-INDEX: 101; LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server"
				BorderColor="Transparent" ForeColor="White" Font-Bold="True" BackColor="Desktop" Enabled="False"
				HorizontalAlign="Left" Height="32px" Width="810px">Vehicle Detail</asp:panel><asp:panel id="Panel5" style="Z-INDEX: 124; LEFT: 0px; POSITION: absolute; TOP: 168px" runat="server"
				BackColor="Desktop" Height="176px" Width="112px" BackImageUrl="Menu/Audit.gif"></asp:panel><asp:label id="Label16" style="Z-INDEX: 122; LEFT: 248px; POSITION: absolute; TOP: 224px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="Label10" style="Z-INDEX: 114; LEFT: 248px; POSITION: absolute; TOP: 248px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="Label9" style="Z-INDEX: 113; LEFT: 248px; POSITION: absolute; TOP: 184px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="Label8" style="Z-INDEX: 112; LEFT: 224px; POSITION: absolute; TOP: 112px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="Label7" style="Z-INDEX: 111; LEFT: 224px; POSITION: absolute; TOP: 72px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:panel id="Panel3" style="Z-INDEX: 102; LEFT: 0px; POSITION: absolute; TOP: 144px" runat="server"
				Font-Bold="True" BackColor="Desktop" Height="24px" Width="810px">Payment Detail</asp:panel>
			<asp:panel id="Panel4" style="Z-INDEX: 103; LEFT: 0px; POSITION: absolute; TOP: 344px" runat="server"
				BackColor="Desktop" Height="40px" Width="811px"></asp:panel><asp:button id="BtnCle" style="Z-INDEX: 104; LEFT: 264px; POSITION: absolute; TOP: 352px" tabIndex="9"
				runat="server" Font-Bold="True" Height="24px" Width="72px" Text="Clear"></asp:button><asp:label id="Label1" style="Z-INDEX: 105; LEFT: 120px; POSITION: absolute; TOP: 48px" runat="server"
				Font-Bold="True" Height="12px" Width="88px" Font-Size="Smaller">Vehicle No</asp:label><asp:label id="Label2" style="Z-INDEX: 106; LEFT: 120px; POSITION: absolute; TOP: 112px" runat="server"
				Font-Bold="True" Height="24px" Width="88px" Font-Size="Smaller">Vehicle Type</asp:label><asp:label id="Label3" style="Z-INDEX: 107; LEFT: 120px; POSITION: absolute; TOP: 80px" runat="server"
				Font-Bold="True" Height="24px" Width="104px">Company Code</asp:label><asp:label id="Label4" style="Z-INDEX: 108; LEFT: 120px; POSITION: absolute; TOP: 184px" runat="server"
				Font-Bold="True" Height="24px" Width="118px">Accident Date</asp:label><asp:label id="Label5" style="Z-INDEX: 109; LEFT: 120px; POSITION: absolute; TOP: 248px" runat="server"
				Font-Bold="True" Height="15px" Width="120px"> Estimate Value 2</asp:label><asp:label id="Label6" style="Z-INDEX: 110; LEFT: 224px; POSITION: absolute; TOP: 40px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:button id="BtnEdit" style="Z-INDEX: 115; LEFT: 192px; POSITION: absolute; TOP: 352px" tabIndex="8"
				runat="server" Font-Bold="True" Width="64px" Text="Edit" Visible="False"></asp:button><asp:textbox id="TxtAcidt" style="Z-INDEX: 116; LEFT: 264px; POSITION: absolute; TOP: 176px"
				tabIndex="4" runat="server" Height="24px" Width="88px"></asp:textbox><asp:textbox id="TxtEstval2" style="Z-INDEX: 117; LEFT: 264px; POSITION: absolute; TOP: 240px"
				tabIndex="6" runat="server" Height="30px" Width="114px" AutoPostBack="True"></asp:textbox><asp:dropdownlist id="LstId" style="Z-INDEX: 118; LEFT: 248px; POSITION: absolute; TOP: 40px" tabIndex="1"
				runat="server" Height="16px" Width="176px" AutoPostBack="True"></asp:dropdownlist><asp:button id="BtnDel" style="Z-INDEX: 119; LEFT: 416px; POSITION: absolute; TOP: 352px" tabIndex="11"
				runat="server" Font-Bold="True" Width="64px" Text="Delete"></asp:button><asp:textbox id="TxtEstval1" style="Z-INDEX: 120; LEFT: 264px; POSITION: absolute; TOP: 208px"
				tabIndex="5" runat="server" Height="26px" Width="114px"></asp:textbox><asp:label id="Label12" style="Z-INDEX: 121; LEFT: 120px; POSITION: absolute; TOP: 216px" runat="server"
				Font-Bold="True" Height="24px" Width="120px">Estimate Value 1</asp:label><asp:panel id="Panel2" style="Z-INDEX: 123; LEFT: 0px; POSITION: absolute; TOP: 32px" runat="server"
				BackColor="Desktop" Height="112px" Width="112px" BackImageUrl="Menu/v2.jpg"></asp:panel><asp:button id="BtnAdd" style="Z-INDEX: 125; LEFT: 120px; POSITION: absolute; TOP: 352px" tabIndex="7"
				runat="server" Font-Bold="True" Width="64px" Text="Add" Visible="False"></asp:button><asp:label id="LbLMsg" style="Z-INDEX: 126; LEFT: 484px; POSITION: absolute; TOP: 112px" runat="server"
				Height="16px" Width="324px"></asp:label><asp:button id="BtnApp" style="Z-INDEX: 129; LEFT: 344px; POSITION: absolute; TOP: 352px" tabIndex="10"
				runat="server" Font-Bold="True" Width="66px" Text="Apply"></asp:button><asp:textbox id="TxtEstval3" style="Z-INDEX: 130; LEFT: 264px; POSITION: absolute; TOP: 272px"
				tabIndex="6" runat="server" Height="30px" Width="114px" AutoPostBack="True"></asp:textbox><asp:label id="Label13" style="Z-INDEX: 131; LEFT: 120px; POSITION: absolute; TOP: 280px" runat="server"
				Font-Bold="True" Height="15px" Width="120px">Estimate Value 3</asp:label><asp:label id="Label11" style="Z-INDEX: 132; LEFT: 248px; POSITION: absolute; TOP: 280px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:textbox id="LstCom" style="Z-INDEX: 133; LEFT: 248px; POSITION: absolute; TOP: 72px" runat="server"
				Height="24px" Width="462px"></asp:textbox><asp:textbox id="Lsttyp" style="Z-INDEX: 134; LEFT: 248px; POSITION: absolute; TOP: 104px" runat="server"
				Height="26px" Width="224px"></asp:textbox><asp:imagebutton id="ImgBtn1" style="Z-INDEX: 136; LEFT: 352px; POSITION: absolute; TOP: 176px" runat="server"
				Height="24px" Width="24px" ImageUrl="file:///\\sgcsser\C\Inetpub\wwwroot\Insu\iCO\Cal1.jpg"></asp:imagebutton><asp:label id="Label14" style="Z-INDEX: 135; LEFT: 120px; POSITION: absolute; TOP: 312px" runat="server"
				Font-Bold="True" Height="15px" Width="120px">Claim No</asp:label><asp:textbox id="TxtVehClNo" style="Z-INDEX: 137; LEFT: 264px; POSITION: absolute; TOP: 304px"
				tabIndex="6" runat="server" Height="30px" Width="114px" AutoPostBack="True"></asp:textbox><asp:calendar id="Calendar1" style="Z-INDEX: 138; LEFT: 376px; POSITION: absolute; TOP: 176px"
				runat="server" Height="168px" Width="182px"></asp:calendar></form>
	</body>
</HTML>
