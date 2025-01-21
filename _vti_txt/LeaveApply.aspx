<%@ Page Language="vb" AutoEventWireup="false" Codebehind="LeaveApply.aspx.vb" Inherits="Insu.LeaveApply" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>LeaveApply</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:panel id="Panel1" style="Z-INDEX: 150; LEFT: 8px; POSITION: absolute; TOP: 8px" runat="server"
				Font-Bold="True" BackColor="SkyBlue" Height="24px" Width="796px">Applicant</asp:panel>&nbsp;
			<asp:label id="Label29" style="Z-INDEX: 149; LEFT: 680px; POSITION: absolute; TOP: 144px" runat="server"
				Height="16px" Width="8px">:</asp:label><asp:label id="Label14" style="Z-INDEX: 148; LEFT: 472px; POSITION: absolute; TOP: 144px" runat="server"
				Height="16px" Width="8px">:</asp:label><asp:label id="Label12" style="Z-INDEX: 147; LEFT: 208px; POSITION: absolute; TOP: 144px" runat="server"
				Height="16px" Width="8px">:</asp:label><asp:label id="Label8" style="Z-INDEX: 140; LEFT: 408px; POSITION: absolute; TOP: 64px" runat="server"
				Height="16px" Width="8px">:</asp:label><asp:label id="Label7" style="Z-INDEX: 139; LEFT: 208px; POSITION: absolute; TOP: 96px" runat="server"
				Height="16px" Width="8px">:</asp:label><asp:label id="Label6" style="Z-INDEX: 138; LEFT: 208px; POSITION: absolute; TOP: 64px" runat="server"
				Height="16px" Width="8px">:</asp:label><asp:label id="Label28" style="Z-INDEX: 128; LEFT: 664px; POSITION: absolute; TOP: 272px" runat="server"
				Height="16px" Width="8px">:</asp:label><asp:label id="Label26" style="Z-INDEX: 125; LEFT: 208px; POSITION: absolute; TOP: 336px" runat="server"
				Height="16px" Width="8px">:</asp:label><asp:label id="Label25" style="Z-INDEX: 122; LEFT: 416px; POSITION: absolute; TOP: 272px" runat="server"
				Height="16px" Width="8px">:</asp:label><asp:label id="Label24" style="Z-INDEX: 121; LEFT: 208px; POSITION: absolute; TOP: 304px" runat="server"
				Height="16px" Width="8px">:</asp:label><asp:label id="Label23" style="Z-INDEX: 120; LEFT: 208px; POSITION: absolute; TOP: 272px" runat="server"
				Height="16px" Width="8px">:</asp:label><asp:label id="Label22" style="Z-INDEX: 119; LEFT: 208px; POSITION: absolute; TOP: 240px" runat="server"
				Height="16px" Width="8px">:</asp:label><asp:label id="Label16" style="Z-INDEX: 110; LEFT: 208px; POSITION: absolute; TOP: 208px" runat="server"
				Height="16px" Width="8px">:</asp:label><asp:panel id="Panel8" style="Z-INDEX: 107; LEFT: 8px; POSITION: absolute; TOP: 208px" runat="server"
				BackColor="CornflowerBlue" Height="170px" Width="104px"></asp:panel><asp:panel id="Panel7" style="Z-INDEX: 106; LEFT: 8px; POSITION: absolute; TOP: 184px" runat="server"
				Font-Bold="True" BackColor="SkyBlue" Height="24px" Width="796px">Details of Event</asp:panel>
			<asp:panel id="Panel2" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 32px" runat="server"
				BackColor="CornflowerBlue" Height="88px" Width="104px"></asp:panel><asp:panel id="Panel3" style="Z-INDEX: 102; LEFT: 8px; POSITION: absolute; TOP: 120px" runat="server"
				Font-Bold="True" BackColor="SkyBlue" Height="24px" Width="796px">Annual Leave Info</asp:panel>
			<asp:panel id="Panel5" style="Z-INDEX: 103; LEFT: 8px; POSITION: absolute; TOP: 144px" runat="server"
				BackColor="CornflowerBlue" Height="40px" Width="104px"></asp:panel><asp:panel id="Panel4" style="Z-INDEX: 104; LEFT: 8px; POSITION: absolute; TOP: 376px" runat="server"
				BackColor="CornflowerBlue" Height="56px" Width="806px">
				<P>&nbsp;</P>
				<P>&nbsp;</P>
			</asp:panel><asp:panel id="Pan1" style="Z-INDEX: 105; LEFT: 112px; POSITION: absolute; TOP: 32px" runat="server"
				BackColor="LemonChiffon" Height="32px" Width="692px">
				<asp:Label id="Label1" runat="server" Width="80px" Height="16px">User Code</asp:Label>
				<asp:TextBox id="TxtUser" tabIndex="1" runat="server" Width="96px" Height="24px"></asp:TextBox>
				<asp:Label id="Label2" runat="server" Width="104px" Height="24px">PassWord</asp:Label>
				<asp:TextBox id="TxtPwd" tabIndex="2" runat="server" Width="96px" TextMode="Password"></asp:TextBox>
				<asp:Button id="Button1" tabIndex="3" runat="server" Width="72px" Text="Apply"></asp:Button>
				<asp:TextBox id="TxtId" style="Z-INDEX: 101; LEFT: 112px; POSITION: absolute; TOP: 32px" runat="server"
					Width="80px" Font-Bold="True" ForeColor="#0000C0" BorderColor="Gainsboro" ReadOnly="True"></asp:TextBox>
			</asp:panel><asp:textbox id="TxtApDt" style="Z-INDEX: 108; LEFT: 224px; POSITION: absolute; TOP: 208px" runat="server"
				Width="118px"></asp:textbox><asp:label id="Label15" style="Z-INDEX: 109; LEFT: 112px; POSITION: absolute; TOP: 208px" runat="server"
				Height="24px" Width="86px">Date of Apply</asp:label><asp:dropdownlist id="LstLvTyp" style="Z-INDEX: 111; LEFT: 224px; POSITION: absolute; TOP: 240px"
				runat="server" Height="24px" Width="166px"></asp:dropdownlist><asp:textbox id="Txtfdt" style="Z-INDEX: 112; LEFT: 224px; POSITION: absolute; TOP: 272px" runat="server"
				Width="92px"></asp:textbox><asp:textbox id="TxtTdt" style="Z-INDEX: 113; LEFT: 432px; POSITION: absolute; TOP: 272px" runat="server"
				Width="92px"></asp:textbox><asp:textbox id="TxtRes" style="Z-INDEX: 114; LEFT: 224px; POSITION: absolute; TOP: 304px" runat="server"
				Height="24px" Width="464px"></asp:textbox><asp:label id="Label17" style="Z-INDEX: 115; LEFT: 112px; POSITION: absolute; TOP: 240px" runat="server"
				Height="24px" Width="88px">Leave Type</asp:label><asp:label id="Label18" style="Z-INDEX: 116; LEFT: 112px; POSITION: absolute; TOP: 270px" runat="server"
				Height="10px" Width="88px">Leave From</asp:label><asp:label id="Label19" style="Z-INDEX: 117; LEFT: 360px; POSITION: absolute; TOP: 272px" runat="server"
				Height="24px" Width="40px">Until</asp:label><asp:label id="Label20" style="Z-INDEX: 118; LEFT: 112px; POSITION: absolute; TOP: 304px" runat="server"
				Height="24px" Width="88px">Leave Reason</asp:label><asp:dropdownlist id="LstSub" style="Z-INDEX: 123; LEFT: 224px; POSITION: absolute; TOP: 336px" runat="server"
				Height="32px" Width="192px"></asp:dropdownlist><asp:label id="Label21" style="Z-INDEX: 124; LEFT: 112px; POSITION: absolute; TOP: 336px" runat="server"
				Height="24px" Width="88px">Substitute</asp:label><asp:textbox id="TxtNoLv" style="Z-INDEX: 126; LEFT: 688px; POSITION: absolute; TOP: 272px" runat="server"
				Width="64px"></asp:textbox><asp:label id="Label27" style="Z-INDEX: 127; LEFT: 568px; POSITION: absolute; TOP: 272px" runat="server"
				Height="24px" Width="88px">No of Leave</asp:label><asp:button id="BtnApp" style="Z-INDEX: 129; LEFT: 432px; POSITION: absolute; TOP: 384px" tabIndex="10"
				runat="server" Font-Bold="True" Width="66px" Text="Apply"></asp:button><asp:button id="BtnDel" style="Z-INDEX: 130; LEFT: 360px; POSITION: absolute; TOP: 384px" tabIndex="11"
				runat="server" Font-Bold="True" Width="64px" Text="Delete"></asp:button><asp:button id="BtnCle" style="Z-INDEX: 131; LEFT: 280px; POSITION: absolute; TOP: 384px" tabIndex="9"
				runat="server" Font-Bold="True" Height="24px" Width="72px" Text="Clear"></asp:button><asp:button id="BtnEdit" style="Z-INDEX: 132; LEFT: 208px; POSITION: absolute; TOP: 384px" tabIndex="8"
				runat="server" Font-Bold="True" Width="64px" Text="Find"></asp:button><asp:label id="Label3" style="Z-INDEX: 133; LEFT: 112px; POSITION: absolute; TOP: 64px" runat="server"
				Font-Bold="True" Height="16px" Width="68px" ForeColor="#0000C0">ID</asp:label><asp:label id="Label5" style="Z-INDEX: 134; LEFT: 112px; POSITION: absolute; TOP: 96px" runat="server"
				Font-Bold="True" Height="16px" Width="84px" ForeColor="#0000C0">Company</asp:label><asp:label id="Label4" style="Z-INDEX: 135; LEFT: 312px; POSITION: absolute; TOP: 64px" runat="server"
				Font-Bold="True" Height="11px" Width="81px" ForeColor="#0000C0">Name</asp:label><asp:textbox id="TxtNam" style="Z-INDEX: 136; LEFT: 424px; POSITION: absolute; TOP: 64px" runat="server"
				Font-Bold="True" BackColor="WhiteSmoke" Height="24px" Width="328px" BorderColor="Gainsboro" ForeColor="#0000C0"></asp:textbox><asp:textbox id="TxtCom" style="Z-INDEX: 137; LEFT: 224px; POSITION: absolute; TOP: 96px" runat="server"
				Font-Bold="True" BackColor="WhiteSmoke" Height="24px" Width="326px" BorderColor="Gainsboro" ForeColor="#0000C0"></asp:textbox><asp:textbox id="TxtToLv" style="Z-INDEX: 141; LEFT: 224px; POSITION: absolute; TOP: 144px" runat="server"
				BackColor="Linen" Height="26px" Width="72px" BorderColor="Gainsboro" ForeColor="#0000C0"></asp:textbox><asp:label id="Label10" style="Z-INDEX: 142; LEFT: 384px; POSITION: absolute; TOP: 144px" runat="server"
				Height="24px" Width="68px">Taken</asp:label><asp:textbox id="TxtTaLv" style="Z-INDEX: 143; LEFT: 496px; POSITION: absolute; TOP: 144px" runat="server"
				BackColor="Linen" Height="24px" Width="62px" BorderColor="Gainsboro" ForeColor="#0000C0"></asp:textbox><asp:label id="Label11" style="Z-INDEX: 144; LEFT: 600px; POSITION: absolute; TOP: 144px" runat="server"
				Height="24px" Width="68px">Balance</asp:label><asp:textbox id="TxtBl" style="Z-INDEX: 145; LEFT: 696px; POSITION: absolute; TOP: 144px" runat="server"
				BackColor="Linen" Width="68px" BorderColor="Gainsboro" ForeColor="#0000C0"></asp:textbox><asp:label id="Label9" style="Z-INDEX: 146; LEFT: 112px; POSITION: absolute; TOP: 144px" runat="server"
				Height="8px" Width="88px">Total</asp:label>
			<asp:TextBox id="TxtCom1" style="Z-INDEX: 151; LEFT: 600px; POSITION: absolute; TOP: 96px" runat="server"
				Width="56px" Visible="False"></asp:TextBox></form>
	</body>
</HTML>
