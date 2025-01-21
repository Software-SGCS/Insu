<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Email1.aspx.vb" Inherits="Insu.Email1"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Email1</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Panel id="Panel1" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 8px" runat="server"
				Width="584px" Height="48px" BackColor="Desktop">Panel</asp:Panel>
			<asp:Label id="Label4" style="Z-INDEX: 109; LEFT: 64px; POSITION: absolute; TOP: 232px" runat="server"
				Width="153px" Height="24px">Total Value</asp:Label>
			<asp:TextBox id="TxtVal" style="Z-INDEX: 107; LEFT: 240px; POSITION: absolute; TOP: 224px" runat="server"
				Width="180px" Height="32px"></asp:TextBox>
			<asp:Panel id="Panel2" style="Z-INDEX: 102; LEFT: 8px; POSITION: absolute; TOP: 56px" runat="server"
				Width="40px" Height="520px" BackColor="Desktop">Panel</asp:Panel>
			<asp:Label id="Label1" style="Z-INDEX: 103; LEFT: 64px; POSITION: absolute; TOP: 80px" runat="server"
				Width="144px" Height="24px">Invoice No</asp:Label>
			<asp:Label id="Label2" style="Z-INDEX: 104; LEFT: 64px; POSITION: absolute; TOP: 128px" runat="server"
				Width="144px" Height="24px">Company</asp:Label>
			<asp:Label id="Label3" style="Z-INDEX: 105; LEFT: 64px; POSITION: absolute; TOP: 184px" runat="server"
				Width="144px" Height="24px">Total Qty</asp:Label>
			<asp:TextBox id="TxtNam" style="Z-INDEX: 106; LEFT: 240px; POSITION: absolute; TOP: 120px" runat="server"
				Width="357px" Height="32px"></asp:TextBox>
			<asp:TextBox id="TxtQty" style="Z-INDEX: 108; LEFT: 240px; POSITION: absolute; TOP: 176px" runat="server"
				Width="140px" Height="32px"></asp:TextBox>
			<asp:ImageButton id="ImgBttn" style="Z-INDEX: 110; LEFT: 480px; POSITION: absolute; TOP: 216px" runat="server"
				Width="40px" Height="32px"></asp:ImageButton><INPUT style="Z-INDEX: 111; LEFT: 240px; WIDTH: 168px; POSITION: absolute; TOP: 72px; HEIGHT: 32px"
				type="text" size="22">
		</form>
	</body>
</HTML>
