<%@ Page Language="vb" AutoEventWireup="false" Codebehind="EmpMast.aspx.vb" Inherits="Insu.EmpMast" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>EmpMast</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body leftMargin="0" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:panel id="Panel1" style="Z-INDEX: 101; LEFT: -8px; POSITION: absolute; TOP: 0px" runat="server"
				BorderColor="Transparent" ForeColor="White" Font-Bold="True" BackColor="Desktop" Enabled="False"
				HorizontalAlign="Left" Height="32px" Width="928px">&nbsp; Vehicle Detail</asp:panel>
			<asp:textbox id="TxtTotChqPay" style="Z-INDEX: 151; LEFT: 576px; POSITION: absolute; TOP: 304px"
				tabIndex="6" runat="server" Height="24px" Width="128px" AutoPostBack="True" ReadOnly="True"></asp:textbox><asp:label id="Label25" style="Z-INDEX: 150; LEFT: 560px; POSITION: absolute; TOP: 304px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:textbox id="Textbox1" style="Z-INDEX: 137; LEFT: 576px; POSITION: absolute; TOP: 272px"
				tabIndex="6" runat="server" Height="24px" Width="120px" AutoPostBack="True" ReadOnly="True"></asp:textbox><asp:label id="Label24" style="Z-INDEX: 149; LEFT: 400px; POSITION: absolute; TOP: 312px" runat="server"
				Font-Bold="True" Height="2px" Width="152px">Total Cheque Payment</asp:label><asp:label id="Label23" style="Z-INDEX: 147; LEFT: 248px; POSITION: absolute; TOP: 312px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:textbox id="TxtDed" style="Z-INDEX: 146; LEFT: 264px; POSITION: absolute; TOP: 304px" tabIndex="6"
				runat="server" Height="24px" Width="128px" AutoPostBack="True"></asp:textbox><asp:label id="Label22" style="Z-INDEX: 145; LEFT: 120px; POSITION: absolute; TOP: 312px" runat="server"
				Font-Bold="True" Height="15px" Width="102px">Deduction</asp:label><asp:label id="Label21" style="Z-INDEX: 144; LEFT: 248px; POSITION: absolute; TOP: 280px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="Label19" style="Z-INDEX: 140; LEFT: 560px; POSITION: absolute; TOP: 280px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="Label18" style="Z-INDEX: 139; LEFT: 400px; POSITION: absolute; TOP: 280px" runat="server"
				Font-Bold="True" Height="2px" Width="108px">Total Payment</asp:label><asp:textbox id="TxtTpay" style="Z-INDEX: 138; LEFT: 576px; POSITION: absolute; TOP: 272px" tabIndex="6"
				runat="server" Height="24px" Width="128px" AutoPostBack="True" ReadOnly="True"></asp:textbox><asp:textbox id="TxtPPre" style="Z-INDEX: 136; LEFT: 264px; POSITION: absolute; TOP: 272px" tabIndex="6"
				runat="server" Height="24px" Width="128px" AutoPostBack="True"></asp:textbox><asp:label id="Label17" style="Z-INDEX: 135; LEFT: 120px; POSITION: absolute; TOP: 280px" runat="server"
				Font-Bold="True" Height="15px" Width="126px">3rd Party Pre</asp:label><asp:dropdownlist id="Lsttyp" style="Z-INDEX: 132; LEFT: 248px; POSITION: absolute; TOP: 112px" tabIndex="3"
				runat="server" Height="16px" Width="162px" AutoPostBack="True"></asp:dropdownlist><asp:panel id="Panel5" style="Z-INDEX: 131; LEFT: 0px; POSITION: absolute; TOP: 168px" runat="server"
				BackColor="Desktop" Height="176px" Width="112px" BackImageUrl="Menu/Audit.gif"></asp:panel><asp:label id="Label16" style="Z-INDEX: 129; LEFT: 248px; POSITION: absolute; TOP: 224px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="Label14" style="Z-INDEX: 127; LEFT: 560px; POSITION: absolute; TOP: 216px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="Label13" style="Z-INDEX: 126; LEFT: 560px; POSITION: absolute; TOP: 248px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="Label10" style="Z-INDEX: 114; LEFT: 248px; POSITION: absolute; TOP: 248px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="Label9" style="Z-INDEX: 113; LEFT: 248px; POSITION: absolute; TOP: 184px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="Label8" style="Z-INDEX: 112; LEFT: 224px; POSITION: absolute; TOP: 112px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="Label7" style="Z-INDEX: 111; LEFT: 224px; POSITION: absolute; TOP: 72px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:panel id="Panel3" style="Z-INDEX: 102; LEFT: 0px; POSITION: absolute; TOP: 144px" runat="server"
				Font-Bold="True" BackColor="Desktop" Height="24px" Width="919px">Payment Detail</asp:panel>
			<asp:panel id="Panel4" style="Z-INDEX: 103; LEFT: -80px; POSITION: absolute; TOP: 376px" runat="server"
				BackColor="Desktop" Height="40px" Width="1000px"></asp:panel><asp:button id="BtnCle" style="Z-INDEX: 104; LEFT: 264px; POSITION: absolute; TOP: 352px" tabIndex="9"
				runat="server" Font-Bold="True" Height="24px" Width="72px" Text="Clear"></asp:button><asp:label id="Label1" style="Z-INDEX: 105; LEFT: 120px; POSITION: absolute; TOP: 48px" runat="server"
				Font-Bold="True" Height="12px" Width="88px" Font-Size="Smaller">Vehicle No</asp:label><asp:label id="Label2" style="Z-INDEX: 106; LEFT: 120px; POSITION: absolute; TOP: 112px" runat="server"
				Font-Bold="True" Height="24px" Width="88px" Font-Size="Smaller">Vehicle Type</asp:label><asp:label id="Label3" style="Z-INDEX: 107; LEFT: 120px; POSITION: absolute; TOP: 80px" runat="server"
				Font-Bold="True" Height="24px" Width="104px" Font-Size="Small">Company Code</asp:label><asp:label id="Label4" style="Z-INDEX: 108; LEFT: 120px; POSITION: absolute; TOP: 184px" runat="server"
				Font-Bold="True" Height="24px" Width="118px">Payment Period</asp:label><asp:label id="Label5" style="Z-INDEX: 109; LEFT: 120px; POSITION: absolute; TOP: 248px" runat="server"
				Font-Bold="True" Height="15px" Width="105px"> R.C.C</asp:label><asp:label id="Label6" style="Z-INDEX: 110; LEFT: 224px; POSITION: absolute; TOP: 40px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:button id="BtnEdit" style="Z-INDEX: 115; LEFT: 192px; POSITION: absolute; TOP: 352px" tabIndex="8"
				runat="server" Font-Bold="True" Width="64px" Text="Edit"></asp:button><asp:textbox id="TxtId" style="Z-INDEX: 116; LEFT: 248px; POSITION: absolute; TOP: 40px" tabIndex="2"
				runat="server" Width="134px"></asp:textbox><asp:textbox id="Txtpayfdt" style="Z-INDEX: 117; LEFT: 264px; POSITION: absolute; TOP: 176px"
				tabIndex="4" runat="server" Height="24px" Width="82px"></asp:textbox><asp:dropdownlist id="LstCom" style="Z-INDEX: 118; LEFT: 248px; POSITION: absolute; TOP: 80px" tabIndex="2"
				runat="server" Height="16px" Width="336px" AutoPostBack="True"></asp:dropdownlist><asp:textbox id="Txtrcc" style="Z-INDEX: 119; LEFT: 264px; POSITION: absolute; TOP: 240px" tabIndex="6"
				runat="server" Height="30px" Width="128px" AutoPostBack="True" ReadOnly="True"></asp:textbox><asp:label id="Label11" style="Z-INDEX: 120; LEFT: 400px; POSITION: absolute; TOP: 248px" runat="server"
				Font-Bold="True" Height="2px" Width="96px">T.R</asp:label><asp:textbox id="Txttr" style="Z-INDEX: 121; LEFT: 576px; POSITION: absolute; TOP: 240px" tabIndex="8"
				runat="server" Height="24px" Width="128px" AutoPostBack="True"></asp:textbox><asp:dropdownlist id="LstId" style="Z-INDEX: 122; LEFT: 248px; POSITION: absolute; TOP: 40px" tabIndex="1"
				runat="server" Height="16px" Width="136px" AutoPostBack="True"></asp:dropdownlist><asp:button id="BtnDel" style="Z-INDEX: 123; LEFT: 416px; POSITION: absolute; TOP: 352px" tabIndex="11"
				runat="server" Font-Bold="True" Width="64px" Text="Delete"></asp:button><asp:textbox id="Txtval" style="Z-INDEX: 124; LEFT: 264px; POSITION: absolute; TOP: 208px" tabIndex="5"
				runat="server" Height="26px" Width="128px"></asp:textbox><asp:label id="Label12" style="Z-INDEX: 125; LEFT: 120px; POSITION: absolute; TOP: 216px" runat="server"
				Font-Bold="True" Height="24px" Width="80px">Value</asp:label><asp:label id="Label15" style="Z-INDEX: 128; LEFT: 400px; POSITION: absolute; TOP: 216px" runat="server"
				Font-Bold="True" Height="24px" Width="122px">Basic Payment</asp:label><asp:panel id="Panel2" style="Z-INDEX: 130; LEFT: 0px; POSITION: absolute; TOP: 32px" runat="server"
				BackColor="Desktop" Height="112px" Width="112px" BackImageUrl="Menu/V2.jpg"></asp:panel><asp:textbox id="Txtbpay" style="Z-INDEX: 133; LEFT: 576px; POSITION: absolute; TOP: 208px" tabIndex="7"
				runat="server" Height="24px" Width="128px" AutoPostBack="True"></asp:textbox><asp:button id="BtnAdd" style="Z-INDEX: 134; LEFT: 120px; POSITION: absolute; TOP: 352px" tabIndex="7"
				runat="server" Font-Bold="True" Width="64px" Text="Add"></asp:button><asp:label id="LbLMsg" style="Z-INDEX: 141; LEFT: 408px; POSITION: absolute; TOP: 40px" runat="server"
				Height="24px" Width="324px"></asp:label><asp:label id="Lbldys" style="Z-INDEX: 142; LEFT: 552px; POSITION: absolute; TOP: 176px" runat="server"
				Height="24px" Width="82px"></asp:label><asp:label id="Label20" style="Z-INDEX: 143; LEFT: 648px; POSITION: absolute; TOP: 176px" runat="server"
				Height="24px" Width="48px">Days</asp:label><asp:button id="BtnApp" style="Z-INDEX: 148; LEFT: 344px; POSITION: absolute; TOP: 352px" tabIndex="10"
				runat="server" Font-Bold="True" Width="66px" Text="Apply"></asp:button><asp:textbox id="TxtPer" style="Z-INDEX: 152; LEFT: 576px; POSITION: absolute; TOP: 112px" runat="server"
				Height="24px" Width="62px"></asp:textbox><asp:label id="Label26" style="Z-INDEX: 153; LEFT: 416px; POSITION: absolute; TOP: 112px" runat="server"
				Height="24px" Width="152px">No Claim Bonus Per(%)</asp:label><asp:textbox id="TxtpayTdt" style="Z-INDEX: 154; LEFT: 368px; POSITION: absolute; TOP: 176px"
				tabIndex="4" runat="server" Height="24px" Width="82px"></asp:textbox><asp:label id="L1" style="Z-INDEX: 155; LEFT: 528px; POSITION: absolute; TOP: 352px" runat="server"
				Height="24px" Width="120px">Label</asp:label></form>
	</body>
</HTML>
