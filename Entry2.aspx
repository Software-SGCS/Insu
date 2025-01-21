<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Entry2.aspx.vb" Inherits="Insu.Entry2" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Entry2</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout" leftmargin="0">
		<DIV style="Z-INDEX: 101; LEFT: 8px; WIDTH: 10px; POSITION: absolute; TOP: 8px; HEIGHT: 10px"
			ms_positioning="text2D">
			<FORM id="Form1" method="post" runat="server">
				<asp:panel id="Panel1" style="Z-INDEX: 101; LEFT: -8px; POSITION: absolute; TOP: -8px" runat="server"
					BorderColor="Transparent" ForeColor="White" Font-Bold="True" BackColor="Desktop" Enabled="False"
					HorizontalAlign="Left" Height="32px" Width="944px">Vehicle Detail</asp:panel>
				<asp:dropdownlist id="Lsttyp" style="Z-INDEX: 132; LEFT: 248px; POSITION: absolute; TOP: 112px" tabIndex="3"
					runat="server" Height="16px" Width="218px" AutoPostBack="True"></asp:dropdownlist><asp:panel id="Panel5" style="Z-INDEX: 131; LEFT: -8px; POSITION: absolute; TOP: 168px" runat="server"
					BackColor="Desktop" Height="176px" Width="104px" BackImageUrl="Menu/Audit.gif"></asp:panel><asp:label id="Label16" style="Z-INDEX: 129; LEFT: 248px; POSITION: absolute; TOP: 224px" runat="server"
					Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="Label10" style="Z-INDEX: 114; LEFT: 248px; POSITION: absolute; TOP: 248px" runat="server"
					Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="Label9" style="Z-INDEX: 113; LEFT: 248px; POSITION: absolute; TOP: 184px" runat="server"
					Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="Label8" style="Z-INDEX: 112; LEFT: 224px; POSITION: absolute; TOP: 112px" runat="server"
					Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="Label7" style="Z-INDEX: 111; LEFT: 224px; POSITION: absolute; TOP: 72px" runat="server"
					Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:panel id="Panel3" style="Z-INDEX: 102; LEFT: -8px; POSITION: absolute; TOP: 136px" runat="server"
					Font-Bold="True" BackColor="Desktop" Height="32px" Width="947px">Payment Detail</asp:panel>
				<asp:panel id="Panel4" style="Z-INDEX: 103; LEFT: -16px; POSITION: absolute; TOP: 344px" runat="server"
					BackColor="Desktop" Height="40px" Width="951px">
					<asp:button id="BtnDel" tabIndex="11" runat="server" Width="64px" Enabled="False" Font-Bold="True"
						Text="Delete"></asp:button>
				</asp:panel>
				<asp:label id="Label2" style="Z-INDEX: 106; LEFT: 120px; POSITION: absolute; TOP: 112px" runat="server"
					Width="88px" Height="24px" Font-Bold="True" Font-Size="Smaller">Vehicle Type</asp:label>
				<asp:label id="Label3" style="Z-INDEX: 107; LEFT: 120px; POSITION: absolute; TOP: 32px" runat="server"
					Width="104px" Height="24px" Font-Bold="True">Company Code</asp:label>
				<asp:label id="Label4" style="Z-INDEX: 108; LEFT: 120px; POSITION: absolute; TOP: 184px" runat="server"
					Width="118px" Height="24px" Font-Bold="True">Cheque No</asp:label>
				<asp:label id="Label5" style="Z-INDEX: 109; LEFT: 120px; POSITION: absolute; TOP: 248px" runat="server"
					Width="105px" Height="15px" Font-Bold="True"> Certificate No</asp:label>
				<asp:textbox id="TxtChqNo" style="Z-INDEX: 117; LEFT: 264px; POSITION: absolute; TOP: 176px"
					tabIndex="4" runat="server" Width="124px" Height="24px"></asp:textbox>
				<asp:dropdownlist id="LstCom" style="Z-INDEX: 118; LEFT: 248px; POSITION: absolute; TOP: 32px" tabIndex="2"
					runat="server" Width="336px" Height="16px" AutoPostBack="True"></asp:dropdownlist>
				<asp:textbox id="TxtCerNo" style="Z-INDEX: 119; LEFT: 264px; POSITION: absolute; TOP: 240px; Design_Time_Lock: True"
					tabIndex="6" runat="server" Width="124px" Height="30px" AutoPostBack="True" Design_Time_Lock="True"></asp:textbox>
				<asp:textbox id="TxtRecDt" style="Z-INDEX: 124; LEFT: 264px; POSITION: absolute; TOP: 208px"
					tabIndex="5" runat="server" Width="124px" Height="26px"></asp:textbox>
				<asp:label id="Label12" style="Z-INDEX: 125; LEFT: 120px; POSITION: absolute; TOP: 216px" runat="server"
					Width="112px" Height="24px" Font-Bold="True">Received Date</asp:label>
				<asp:panel id="Panel2" style="Z-INDEX: 130; LEFT: -8px; POSITION: absolute; TOP: 24px" runat="server"
					Width="104px" Height="112px" BackColor="Desktop" BackImageUrl="Menu/V2.jpg"></asp:panel>
				<asp:label id="LbLMsg" style="Z-INDEX: 141; LEFT: 484px; POSITION: absolute; TOP: 112px" runat="server"
					Width="324px" Height="16px"></asp:label>
				<asp:button id="BtnAdd" style="Z-INDEX: 135; LEFT: 152px; POSITION: absolute; TOP: 312px" tabIndex="7"
					runat="server" Width="64px" Font-Bold="True" Text="Add" Visible="False"></asp:button>
				<asp:button id="BtnEdit" style="Z-INDEX: 136; LEFT: 248px; POSITION: absolute; TOP: 312px" tabIndex="8"
					runat="server" Width="64px" Font-Bold="True" Text="Edit" Visible="False"></asp:button>
				<asp:button id="BtnCle" style="Z-INDEX: 137; LEFT: 336px; POSITION: absolute; TOP: 312px" tabIndex="9"
					runat="server" Width="72px" Height="24px" Font-Bold="True" Text="Clear" Visible="False"></asp:button>
				<asp:button id="BtnApp" style="Z-INDEX: 150; LEFT: 432px; POSITION: absolute; TOP: 312px" tabIndex="10"
					runat="server" Width="66px" Font-Bold="True" Text="Apply"></asp:button>
				<asp:Label id="L1" style="Z-INDEX: 102; LEFT: 560px; POSITION: absolute; TOP: 360px" runat="server"
					Width="96px" Height="24px">Label</asp:Label><asp:label id="Label1" style="Z-INDEX: 123; LEFT: 120px; POSITION: absolute; TOP: 80px" runat="server"
					Font-Bold="True" Height="12px" Width="88px" Font-Size="Smaller">Vehicle No</asp:label>
				<asp:dropdownlist id="LstId" style="Z-INDEX: 124; LEFT: 248px; POSITION: absolute; TOP: 72px" tabIndex="1"
					runat="server" Width="136px" Height="16px" AutoPostBack="True"></asp:dropdownlist>
				<asp:textbox id="TxtId" style="Z-INDEX: 125; LEFT: 248px; POSITION: absolute; TOP: 72px" tabIndex="2"
					runat="server" Width="128px" ReadOnly="True"></asp:textbox>
				<asp:label id="Label6" style="Z-INDEX: 126; LEFT: 232px; POSITION: absolute; TOP: 40px" runat="server"
					Width="16px" Height="16px" Font-Bold="True">:</asp:label>
			</FORM>
		</DIV>
	</body>
</HTML>
