<%@ Page Language="vb" AutoEventWireup="false" Codebehind="LOgFile.aspx.vb" Inherits="POS.LOgFile"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>LOgFile</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout" bgColor="#ffe6ee">
		<form id="Form1" method="post" runat="server">
			<asp:panel id="Panel1" style="Z-INDEX: 101; LEFT: 0px; POSITION: absolute; TOP: -8px" runat="server"
				BackColor="RosyBrown" Height="80px" Width="756px" ForeColor="RosyBrown">
<asp:TextBox id="txtLOC" style="Z-INDEX: 101; LEFT: 144px; POSITION: absolute; TOP: 96px" runat="server"
					Width="72px"></asp:TextBox>
<asp:ImageButton id="Cal2" style="Z-INDEX: 126; LEFT: 408px; POSITION: absolute; TOP: 152px" runat="server"
					ImageUrl="http://localhost/POS/iCO/Cal4.jpg"></asp:ImageButton>
<asp:DataGrid id="DataGrid1" style="Z-INDEX: 103; LEFT: 24px; POSITION: absolute; TOP: 192px"
					runat="server" BackColor="White" Font-Size="X-Small" BorderColor="#E7E7FF"
					BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
					<SelectedItemStyle Font-Size="X-Small" Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
					<EditItemStyle Font-Size="X-Small"></EditItemStyle>
					<AlternatingItemStyle Font-Size="X-Small" BackColor="#F7F7F7"></AlternatingItemStyle>
					<ItemStyle Font-Size="X-Small" ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
					<HeaderStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
					<FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
					<PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages"></PagerStyle>
				</asp:DataGrid>
<asp:Button id="Button1" style="Z-INDEX: 102; LEFT: 448px; POSITION: absolute; TOP: 152px" runat="server"
					Text="Submit"></asp:Button>Panel</asp:panel>
			<asp:calendar id="Calendar2" style="Z-INDEX: 112; LEFT: 256px; POSITION: absolute; TOP: 168px"
				runat="server" BackColor="#E7E7FF" Height="154px" Width="120px" Visible="False">
				<DayStyle Font-Size="Smaller"></DayStyle>
				<DayHeaderStyle Font-Size="Smaller"></DayHeaderStyle>
				<WeekendDayStyle Font-Size="Smaller"></WeekendDayStyle>
			</asp:calendar><asp:calendar id="Calendar1" style="Z-INDEX: 111; LEFT: 72px; POSITION: absolute; TOP: 168px"
				runat="server" BackColor="#E7E7FF" Height="154px" Width="120px" Visible="False">
				<DayStyle Font-Size="Smaller"></DayStyle>
				<DayHeaderStyle Font-Size="Smaller"></DayHeaderStyle>
				<WeekendDayStyle Font-Size="Smaller"></WeekendDayStyle>
			</asp:calendar><asp:label id="Label4" style="Z-INDEX: 105; LEFT: 48px; POSITION: absolute; TOP: 144px" runat="server"
				Height="24px" Width="72px" ForeColor="Blue" Font-Size="X-Small">From Date</asp:label><asp:label id="Label5" style="Z-INDEX: 106; LEFT: 264px; POSITION: absolute; TOP: 144px" runat="server"
				Height="24px" Width="56px" ForeColor="Blue" Font-Size="X-Small">To Date</asp:label><asp:textbox id="TXTTDATE" style="Z-INDEX: 104; LEFT: 336px; POSITION: absolute; TOP: 144px"
				runat="server" Width="72px"></asp:textbox><asp:label id="Label9" style="Z-INDEX: 108; LEFT: 336px; POSITION: absolute; TOP: 128px" runat="server"
				Height="16px" Width="64px" ForeColor="Maroon" Font-Size="XX-Small"> DD/MM/YYYY</asp:label><asp:textbox id="TXTFDATE" style="Z-INDEX: 103; LEFT: 144px; POSITION: absolute; TOP: 144px"
				runat="server" Width="80px"></asp:textbox><asp:label id="Label8" style="Z-INDEX: 107; LEFT: 160px; POSITION: absolute; TOP: 128px" runat="server"
				Height="16px" Width="64px" ForeColor="Maroon" Font-Size="XX-Small"> DD/MM/YYYY</asp:label><asp:panel id="Panel2" style="Z-INDEX: 102; LEFT: 16px; POSITION: absolute; TOP: 80px" runat="server"
				Visible="False">Panel</asp:panel>
			<asp:label id="Label2" style="Z-INDEX: 113; LEFT: 344px; POSITION: absolute; TOP: 24px" runat="server"
				BackColor="RosyBrown" Height="16px" Width="136px" ForeColor="Blue" Font-Size="Medium" Font-Names="Tahoma"
				Font-Bold="True">Log File</asp:label><asp:imagebutton id="Image2" style="Z-INDEX: 114; LEFT: 600px; POSITION: absolute; TOP: 16px" runat="server"
				Height="32px" Width="58px"></asp:imagebutton><asp:imagebutton id="Image1" style="Z-INDEX: 115; LEFT: 680px; POSITION: absolute; TOP: 16px" runat="server"
				Height="40px" Width="40px"></asp:imagebutton><asp:label id="Label1" style="Z-INDEX: 116; LEFT: 48px; POSITION: absolute; TOP: 88px" runat="server"
				ForeColor="Blue" Font-Size="X-Small">User Code</asp:label>
			<asp:ImageButton id="Cal1" style="Z-INDEX: 127; LEFT: 224px; POSITION: absolute; TOP: 144px" runat="server"
				ImageUrl="http://localhost/POS/iCO/Cal4.jpg"></asp:ImageButton></form>
	</body>
</HTML>
