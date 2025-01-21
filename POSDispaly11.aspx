<%@ Page Language="vb" AutoEventWireup="false" Codebehind="POSDispaly11.aspx.vb" Inherits="Insu.PosDispaly11_aspx" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Dispaly1</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="#f0f8ff" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:Panel id="Panel1" style="Z-INDEX: 103; LEFT: 0px; POSITION: absolute; TOP: 528px" runat="server"
				BackImageUrl="Sch\restorent-3.GIF" Height="80px" Width="816px"></asp:Panel>
			<asp:panel id="Panel4" style="Z-INDEX: 105; LEFT: 640px; POSITION: absolute; TOP: 0px" runat="server"
				Width="376px" Height="602px" BackImageUrl="Menu/DSINEW1.JPG" DESIGNTIMEDRAGDROP="8"></asp:panel>
			<asp:Panel id="Panel9" style="Z-INDEX: 101; LEFT: 368px; POSITION: absolute; TOP: 320px" runat="server"
				Height="80px" Width="192px" BorderStyle="Outset" Visible="False">
				<FONT face="verdana" size="2"><STRONG><FONT color="#000099">Vision .:&nbsp;<BR>
						</FONT></STRONG>
					<BR>
					<BR>
					<STRONG><FONT color="#000099">Mission .:&nbsp;<BR>
						</FONT></STRONG></FONT>
			</asp:Panel>
			<asp:textbox id="TxtSec" style="Z-INDEX: 100; LEFT: 24px; POSITION: absolute; TOP: 184px" runat="server"
				BackColor="AliceBlue" Height="24px" Width="512px" BorderStyle="None" Font-Names="lucida calligraphy,large"
				Font-Size="Medium"></asp:textbox>
			<asp:Panel id="Panel13" style="Z-INDEX: 102; LEFT: 112px; POSITION: absolute; TOP: 392px" runat="server"
				Height="38px" Width="240px" BorderStyle="Outset" Visible="False">
				<FONT face="verdana,arial,helvetica,sans-serif" size="2"><STRONG><FONT color="#000099">Latest 
							News.</FONT></STRONG></FONT></asp:Panel>
			<asp:TextBox id="Txtmsg1" style="Z-INDEX: 104; LEFT: 0px; POSITION: absolute; TOP: 472px" runat="server"
				Width="417px" Height="24px" Visible="False"></asp:TextBox>
			<asp:Panel id="Panel3" style="Z-INDEX: 107; LEFT: -24px; POSITION: absolute; TOP: -8px" runat="server"
				Width="648px" Height="136px" BackImageUrl="Menu\Title-2.gif">
				<asp:panel id="Panel5" runat="server" Width="136px" Height="608px" BackImageUrl="Menu/EmpMaster4.jpg"
					BackColor="Desktop"></asp:panel>
			</asp:Panel>
			<asp:TextBox id="Txtmsg" style="Z-INDEX: 108; LEFT: 320px; POSITION: absolute; TOP: 432px" runat="server"
				Width="200px" Height="56px" BackColor="Azure" Visible="False" TextMode="MultiLine"></asp:TextBox>
			<asp:Label id="Label8" style="Z-INDEX: 109; LEFT: 248px; POSITION: absolute; TOP: 232px" runat="server"
				Width="168px" Height="16px" BorderStyle="None" Font-Size="Medium" Font-Names="Lucida Calligraphy">Sorry.............!</asp:Label>
			<asp:Label id="Label1" style="Z-INDEX: 110; LEFT: 288px; POSITION: absolute; TOP: 280px" runat="server"
				Width="200px" Height="16px" BorderStyle="None" Font-Size="Medium" Font-Names="Lucida Calligraphy">No Permission</asp:Label>
		</form>
	</body>
</HTML>
