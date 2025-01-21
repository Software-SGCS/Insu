<%@ Page Language="vb" AutoEventWireup="false" Codebehind="EntryVehSold.aspx.vb" Inherits="Insu.EntryVehSold" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Entry2</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body leftMargin="0" MS_POSITIONING="GridLayout">
		<DIV style="Z-INDEX: 101; LEFT: 8px; WIDTH: 105px; POSITION: absolute; TOP: 8px; HEIGHT: 384px"
			ms_positioning="FlowLayout">
			<FORM id="Form1" method="post" runat="server">
				<asp:panel id="Panel1" style="Z-INDEX: 101; LEFT: -8px; POSITION: absolute; TOP: -8px" runat="server"
					BorderColor="Transparent" ForeColor="White" Font-Bold="True" BackColor="Desktop" Enabled="False"
					HorizontalAlign="Left" Height="32px" Width="944px">Vehicle Detail</asp:panel>
				<asp:dropdownlist id="Lsttyp" style="Z-INDEX: 132; LEFT: 248px; POSITION: absolute; TOP: 112px" tabIndex="3"
					runat="server" Height="16px" Width="218px" AutoPostBack="True"></asp:dropdownlist><asp:panel id="Panel5" style="Z-INDEX: 131; LEFT: -8px; POSITION: absolute; TOP: 168px" runat="server"
					BackColor="Desktop" Height="176px" Width="112px" BackImageUrl="Menu/Audit.gif"></asp:panel><asp:label id="Label10" style="Z-INDEX: 114; LEFT: 248px; POSITION: absolute; TOP: 248px" runat="server"
					Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="Label9" style="Z-INDEX: 113; LEFT: 248px; POSITION: absolute; TOP: 184px" runat="server"
					Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="Label8" style="Z-INDEX: 112; LEFT: 224px; POSITION: absolute; TOP: 112px" runat="server"
					Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="Label7" style="Z-INDEX: 111; LEFT: 224px; POSITION: absolute; TOP: 72px" runat="server"
					Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:panel id="Panel3" style="Z-INDEX: 102; LEFT: -8px; POSITION: absolute; TOP: 136px" runat="server"
					Font-Bold="True" BackColor="Desktop" Height="32px" Width="947px">Payment Detail</asp:panel>
				<asp:panel id="Panel4" style="Z-INDEX: 103; LEFT: -16px; POSITION: absolute; TOP: 344px" runat="server"
					BackColor="Desktop" Height="40px" Width="956px"></asp:panel><asp:label id="Label1" style="Z-INDEX: 105; LEFT: 120px; POSITION: absolute; TOP: 48px" runat="server"
					Font-Bold="True" Height="12px" Width="88px" Font-Size="Smaller">Vehicle No</asp:label><asp:label id="Label2" style="Z-INDEX: 106; LEFT: 120px; POSITION: absolute; TOP: 112px" runat="server"
					Font-Bold="True" Height="24px" Width="88px" Font-Size="Smaller">Vehicle Type</asp:label><asp:label id="Label3" style="Z-INDEX: 107; LEFT: 120px; POSITION: absolute; TOP: 80px" runat="server"
					Font-Bold="True" Height="24px" Width="104px">Company Code</asp:label><asp:label id="Label5" style="Z-INDEX: 109; LEFT: 128px; POSITION: absolute; TOP: 248px" runat="server"
					Font-Bold="True" Height="15px" Width="120px"> Refundable Amt</asp:label><asp:label id="Label6" style="Z-INDEX: 110; LEFT: 224px; POSITION: absolute; TOP: 40px" runat="server"
					Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:textbox id="TxtId" style="Z-INDEX: 116; LEFT: 248px; POSITION: absolute; TOP: 40px" tabIndex="2"
					runat="server" Width="134px"></asp:textbox><asp:dropdownlist id="LstCom" style="Z-INDEX: 118; LEFT: 248px; POSITION: absolute; TOP: 80px" tabIndex="2"
					runat="server" Height="16px" Width="336px" AutoPostBack="True"></asp:dropdownlist><asp:dropdownlist id="LstId" style="Z-INDEX: 122; LEFT: 248px; POSITION: absolute; TOP: 40px" tabIndex="1"
					runat="server" Height="16px" Width="136px" AutoPostBack="True"></asp:dropdownlist><asp:button id="BtnDel" style="Z-INDEX: 123; LEFT: 416px; POSITION: absolute; TOP: 312px" tabIndex="11"
					runat="server" Font-Bold="True" Width="64px" Visible="False" Text="Delete"></asp:button><asp:panel id="Panel2" style="Z-INDEX: 130; LEFT: -8px; POSITION: absolute; TOP: 24px" runat="server"
					BackColor="Desktop" Height="112px" Width="112px" BackImageUrl="Menu/v2.jpg"></asp:panel><asp:label id="LbLMsg" style="Z-INDEX: 141; LEFT: 484px; POSITION: absolute; TOP: 112px" runat="server"
					Height="16px" Width="324px"></asp:label><asp:button id="BtnApp" style="Z-INDEX: 150; LEFT: 400px; POSITION: absolute; TOP: 256px" tabIndex="10"
					runat="server" Font-Bold="True" Width="66px" Text="Submit"></asp:button><asp:button id="BtnAdd" style="Z-INDEX: 102; LEFT: 152px; POSITION: absolute; TOP: 312px" tabIndex="7"
					runat="server" Font-Bold="True" Width="64px" Visible="False" Text="Add"></asp:button><asp:button id="BtnEdit" style="Z-INDEX: 103; LEFT: 248px; POSITION: absolute; TOP: 312px" tabIndex="8"
					runat="server" Font-Bold="True" Width="64px" Visible="False" Text="Edit"></asp:button><asp:button id="BtnCle" style="Z-INDEX: 104; LEFT: 336px; POSITION: absolute; TOP: 312px" tabIndex="9"
					runat="server" Font-Bold="True" Height="24px" Width="72px" Visible="False" Text="Clear"></asp:button><asp:textbox id="TxtTotAmt" style="Z-INDEX: 105; LEFT: 272px; POSITION: absolute; TOP: 216px"
					tabIndex="4" runat="server" Height="24px" Width="112px" ReadOnly="True"></asp:textbox><asp:label id="Label4" style="Z-INDEX: 106; LEFT: 128px; POSITION: absolute; TOP: 216px" runat="server"
					Font-Bold="True" Height="24px" Width="118px">Total Chq Amt</asp:label><asp:label id="Label12" style="Z-INDEX: 107; LEFT: 128px; POSITION: absolute; TOP: 184px" runat="server"
					Font-Bold="True" Height="24px" Width="112px">Sold Date</asp:label><asp:textbox id="TxtSldDt" style="Z-INDEX: 108; LEFT: 272px; POSITION: absolute; TOP: 184px"
					tabIndex="5" runat="server" Height="26px" Width="88px"></asp:textbox><asp:label id="Label16" style="Z-INDEX: 109; LEFT: 248px; POSITION: absolute; TOP: 216px" runat="server"
					Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:textbox id="TxtRefAmt" style="Z-INDEX: 110; LEFT: 272px; POSITION: absolute; TOP: 248px"
					runat="server" Height="24px" Width="112px" ReadOnly="True"></asp:textbox><asp:label id="Label11" style="Z-INDEX: 104; LEFT: 392px; POSITION: absolute; TOP: 184px" runat="server"
					Height="27px" Width="88px">No of Days</asp:label><asp:textbox id="Txtfdt" style="Z-INDEX: 102; LEFT: 472px; POSITION: absolute; TOP: 40px" runat="server"
					Width="82px"></asp:textbox><asp:label id="Label13" style="Z-INDEX: 103; LEFT: 416px; POSITION: absolute; TOP: 40px" runat="server"
					Height="24px" Width="40px">From</asp:label><asp:textbox id="TxtTdt" style="Z-INDEX: 104; LEFT: 600px; POSITION: absolute; TOP: 40px" runat="server"
					Width="82px"></asp:textbox><asp:label id="Label14" style="Z-INDEX: 105; LEFT: 560px; POSITION: absolute; TOP: 40px" runat="server"
					Height="24px" Width="28px">To</asp:label><asp:textbox id="Txtdays" style="Z-INDEX: 106; LEFT: 744px; POSITION: absolute; TOP: 40px" runat="server"
					Width="48px"></asp:textbox><asp:label id="Label15" style="Z-INDEX: 107; LEFT: 688px; POSITION: absolute; TOP: 40px" runat="server"
					Height="16px" Width="37px">Days</asp:label><asp:textbox id="TxtNo" style="Z-INDEX: 103; LEFT: 488px; POSITION: absolute; TOP: 184px" runat="server"
					Height="24px" Width="38px"></asp:textbox>asp:label id="Label17" 
				style="Z-INDEX: 109; LEFT: 136px; POSITION: absolute; TOP: 288px" 
				runat="server" Font-Bold="True" Height="15px" Width="120px"&gt; Refundable Amt
				<asp:textbox id="TxtbalAmt" style="Z-INDEX: 110; LEFT: 272px; POSITION: absolute; TOP: 280px"
					runat="server" Height="24px" Width="112px" ReadOnly="True"></asp:textbox>&lt;
				<asp:label id="Label17" style="Z-INDEX: 102; LEFT: 128px; POSITION: absolute; TOP: 288px" runat="server"
					Font-Bold="True" Height="15px" Width="129px">Balance Amt</asp:label>
				<asp:TextBox id="TxtTotAmt1" style="Z-INDEX: 103; LEFT: 448px; POSITION: absolute; TOP: 224px"
					runat="server" Width="96px" Visible="False"></asp:TextBox></FORM>
		</DIV>
		<asp:label id="Label18" style="Z-INDEX: 102; LEFT: 256px; POSITION: absolute; TOP: 288px" runat="server"
			Font-Bold="True" Height="16px" Width="16px">:</asp:label>
		<asp:Label id="L1" style="Z-INDEX: 103; LEFT: 536px; POSITION: absolute; TOP: 368px" runat="server"
			Width="72px" Height="16px">Label</asp:Label>
	</body>
</HTML>
