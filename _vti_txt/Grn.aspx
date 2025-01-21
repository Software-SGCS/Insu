<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Grn.aspx.vb" Inherits="Insu.Grn"%>
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
		<DIV style="Z-INDEX: 100; LEFT: 8px; WIDTH: 10px; POSITION: absolute; TOP: 8px; HEIGHT: 10px"
			ms_positioning="text2D">
			<FORM id="Form1" method="post" runat="server">
				<asp:panel id="Panel1" style="Z-INDEX: 101; LEFT: -8px; POSITION: absolute; TOP: -8px" runat="server"
					Width="1009px" Height="32px" HorizontalAlign="Left" Enabled="False" BackColor="Desktop"
					Font-Bold="True" ForeColor="White" BorderColor="Transparent">
<asp:calendar id="Calendar2" style="Z-INDEX: 998; LEFT: 512px; POSITION: absolute; TOP: 280px"
						runat="server" BorderColor="White" ForeColor="Black" BackColor="White"
						Height="136px" Width="174px" Font-Size="9pt" Visible="False" NextPrevFormat="FullMonth"
						BorderWidth="1px" Font-Names="Verdana">
						<TodayDayStyle BackColor="#CCCCCC"></TodayDayStyle>
						<NextPrevStyle Font-Size="8pt" Font-Bold="True" ForeColor="#333333" VerticalAlign="Bottom"></NextPrevStyle>
						<DayHeaderStyle Font-Size="8pt" Font-Bold="True"></DayHeaderStyle>
						<SelectedDayStyle ForeColor="White" BackColor="#333399"></SelectedDayStyle>
						<TitleStyle Font-Size="12pt" Font-Bold="True" BorderWidth="4px" ForeColor="#333399" BorderColor="Black"
							BackColor="White"></TitleStyle>
						<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
					</asp:calendar>
<asp:label id="Label18" style="Z-INDEX: 1000; LEFT: 328px; POSITION: absolute; TOP: 184px"
						runat="server" ForeColor="#404040" Font-Bold="True" BackColor="White"
						Height="16px" Width="16px">:</asp:label>
<asp:label id="Label17" style="Z-INDEX: 999; LEFT: 128px; POSITION: absolute; TOP: 184px" runat="server"
						BorderColor="#404040" ForeColor="#C00000" Font-Bold="True" BackColor="White"
						Height="24px" Width="112px">Grn No</asp:label>Vehicle 
Detail</asp:panel><asp:panel id="Panel5" style="Z-INDEX: 131; LEFT: -8px; POSITION: absolute; TOP: 168px" runat="server"
					Width="104px" Height="232px" BackColor="Desktop" BackImageUrl="Menu/Audit.gif"></asp:panel><asp:label id="Label8" style="Z-INDEX: 112; LEFT: 248px; POSITION: absolute; TOP: 112px" runat="server"
					Width="9px" Height="16px" Font-Bold="True">:</asp:label><asp:label id="Label7" style="Z-INDEX: 111; LEFT: 248px; POSITION: absolute; TOP: 72px" runat="server"
					Width="9px" Height="16px" Font-Bold="True">:</asp:label><asp:panel id="Panel3" style="Z-INDEX: 102; LEFT: -8px; POSITION: absolute; TOP: 144px" runat="server"
					Width="1009px" Height="24px" BackColor="Desktop" Font-Bold="True"> Detail</asp:panel><asp:label id="Label1" style="Z-INDEX: 105; LEFT: 120px; POSITION: absolute; TOP: 48px" runat="server"
					Width="88px" Height="24px" Font-Bold="True" Font-Size="Smaller">Invoice No</asp:label><asp:label id="Label2" style="Z-INDEX: 106; LEFT: 120px; POSITION: absolute; TOP: 112px" runat="server"
					Width="88px" Height="24px" Font-Bold="True" Font-Size="Smaller"> Total Amt</asp:label><asp:label id="Label3" style="Z-INDEX: 107; LEFT: 120px; POSITION: absolute; TOP: 80px" runat="server"
					Width="104px" Height="24px" Font-Bold="True">Company Code</asp:label><asp:label id="Label4" style="Z-INDEX: 108; LEFT: 120px; POSITION: absolute; TOP: 264px" runat="server"
					Width="176px" Height="24px" Font-Bold="True">Date of Rec. Bill Date</asp:label><asp:label id="Label6" style="Z-INDEX: 110; LEFT: 248px; POSITION: absolute; TOP: 40px" runat="server"
					Width="9px" Height="16px" Font-Bold="True">:</asp:label><asp:textbox id="TxtId" style="Z-INDEX: 116; LEFT: 264px; POSITION: absolute; TOP: 40px" tabIndex="2"
					runat="server" Width="119px"></asp:textbox>
				<asp:textbox id="TxtBilDt" style="Z-INDEX: 117; LEFT: 344px; POSITION: absolute; TOP: 264px"
					tabIndex="4" runat="server" Width="80px" Height="24px"></asp:textbox><asp:dropdownlist id="LstCom" style="Z-INDEX: 118; LEFT: 264px; POSITION: absolute; TOP: 80px" tabIndex="2"
					runat="server" Width="321px" Height="16px" Enabled="False" AutoPostBack="True"></asp:dropdownlist><asp:dropdownlist id="LstId" style="Z-INDEX: 122; LEFT: 264px; POSITION: absolute; TOP: 40px" tabIndex="1"
					runat="server" Width="121px" Height="16px" AutoPostBack="True"></asp:dropdownlist><asp:textbox id="TxtRecDt" style="Z-INDEX: 124; LEFT: 344px; POSITION: absolute; TOP: 224px"
					tabIndex="5" runat="server" Width="80px" Height="26px"></asp:textbox><asp:label id="Label12" style="Z-INDEX: 125; LEFT: 120px; POSITION: absolute; TOP: 224px" runat="server"
					Width="160px" Height="24px" Font-Bold="True">Goods Received Date</asp:label><asp:panel id="Panel2" style="Z-INDEX: 130; LEFT: -8px; POSITION: absolute; TOP: 24px" runat="server"
					Width="104px" Height="120px" BackColor="Desktop" BackImageUrl="Menu/Audit.gif"></asp:panel><asp:button id="BtnAdd" style="Z-INDEX: 102; LEFT: 152px; POSITION: absolute; TOP: 352px" tabIndex="7"
					runat="server" Width="64px" Font-Bold="True" Visible="False" Text="Add"></asp:button><asp:button id="BtnEdit" style="Z-INDEX: 103; LEFT: 248px; POSITION: absolute; TOP: 352px" tabIndex="8"
					runat="server" Width="64px" Font-Bold="True" Visible="False" Text="Edit"></asp:button><asp:button id="BtnCle" style="Z-INDEX: 104; LEFT: 336px; POSITION: absolute; TOP: 352px" tabIndex="9"
					runat="server" Width="72px" Height="24px" Font-Bold="True" Visible="False" Text="Clear"></asp:button><asp:label id="Label13" runat="server" Width="16px" Height="16px" Font-Bold="True">:</asp:label><asp:label id="LbLMsg" style="Z-INDEX: 104; LEFT: 456px; POSITION: absolute; TOP: 48px" runat="server"
					Width="324px" Height="16px"></asp:label><asp:textbox id="Txtpono" style="Z-INDEX: 107; LEFT: 480px; POSITION: absolute; TOP: 112px" runat="server"
					Width="90px" ReadOnly="True"></asp:textbox><asp:dropdownlist id="Lsttyp" style="Z-INDEX: 108; LEFT: 264px; POSITION: absolute; TOP: 112px" tabIndex="3"
					runat="server" Width="98px" Height="24px" Visible="False"></asp:dropdownlist><asp:label id="Label15" style="Z-INDEX: 109; LEFT: 416px; POSITION: absolute; TOP: 112px" runat="server"
					Width="80px" Height="24px">Po No</asp:label><asp:textbox id="TxtPaydt" style="Z-INDEX: 102; LEFT: 344px; POSITION: absolute; TOP: 312px"
					runat="server" Width="80px" Height="24px" ReadOnly="True"></asp:textbox><asp:label id="Label14" style="Z-INDEX: 102; LEFT: 120px; POSITION: absolute; TOP: 312px" runat="server"
					Width="176px" Height="24px" Font-Bold="True">Payment date</asp:label><asp:textbox id="TxtVAL" style="Z-INDEX: 103; LEFT: 264px; POSITION: absolute; TOP: 112px" runat="server"
					Width="128px" ReadOnly="True"></asp:textbox><asp:calendar id="Calendar1" style="Z-INDEX: 998; LEFT: 504px; POSITION: absolute; TOP: 224px"
					runat="server" Width="178px" Height="171px" BackColor="White" ForeColor="Black" BorderColor="White" Font-Names="Verdana" BorderWidth="1px"
					NextPrevFormat="FullMonth" Visible="False" Font-Size="9pt">
					<TodayDayStyle BackColor="#CCCCCC"></TodayDayStyle>
					<NextPrevStyle Font-Size="8pt" Font-Bold="True" ForeColor="#333333" VerticalAlign="Bottom"></NextPrevStyle>
					<DayHeaderStyle Font-Size="8pt" Font-Bold="True"></DayHeaderStyle>
					<SelectedDayStyle ForeColor="White" BackColor="#333399"></SelectedDayStyle>
					<TitleStyle Font-Size="12pt" Font-Bold="True" BorderWidth="4px" ForeColor="#333399" BorderColor="Black"
						BackColor="White"></TitleStyle>
					<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
				</asp:calendar><asp:imagebutton id="ImgBtt1" style="Z-INDEX: 111; LEFT: 10px; POSITION: absolute; TOP: 216px" runat="server"
					Width="24px" Height="18px" ImageUrl="file:///d:\Inetpub\wwwroot\sgcsser\iCO\Cal3.jpg"></asp:imagebutton><asp:panel id="Panel4" style="Z-INDEX: 103; LEFT: -8px; POSITION: absolute; TOP: 400px" runat="server"
					Width="1006px" Height="40px" BackColor="Desktop" BackImageUrl="http://sgcsser\Insu\Menu\aaa.gif"></asp:panel><asp:button id="BtnApp" style="Z-INDEX: 104; LEFT: 152px; POSITION: absolute; TOP: 376px" tabIndex="10"
					runat="server" Width="66px" Font-Bold="True" Text="Apply"></asp:button><asp:button id="BtnDel" style="Z-INDEX: 105; LEFT: 248px; POSITION: absolute; TOP: 376px" tabIndex="11"
					runat="server" Width="64px" Font-Bold="True" Text="Delete"></asp:button><asp:imagebutton id="ImageButton1" style="Z-INDEX: 102; LEFT: 472px; POSITION: absolute; TOP: 224px"
					runat="server" Width="24px" Height="24px" ImageUrl="iCO\Cal1.jpg"></asp:imagebutton><asp:textbox id="TxtCrdLmt" style="Z-INDEX: 103; LEFT: 632px; POSITION: absolute; TOP: 88px"
					runat="server" Width="56px" Visible="False"></asp:textbox><asp:imagebutton id="Imagebutton2" style="Z-INDEX: 104; LEFT: 472px; POSITION: absolute; TOP: 264px"
					runat="server" Width="24px" Height="24px" ImageUrl="iCO\Cal1.jpg"></asp:imagebutton><asp:textbox id="TxtGrnNo" style="Z-INDEX: 105; LEFT: 344px; POSITION: absolute; TOP: 176px"
					runat="server" Width="128px" Height="24px"></asp:textbox></FORM>
		</DIV>
		<asp:label id="Label11" style="Z-INDEX: 101; LEFT: 328px; POSITION: absolute; TOP: 320px" runat="server"
			Width="8px" Height="24px" Font-Bold="True">:</asp:label><asp:label id="Label9" style="Z-INDEX: 103; LEFT: 328px; POSITION: absolute; TOP: 232px" runat="server"
			Width="16px" Height="16px" Font-Bold="True">:</asp:label><asp:label id="Label16" style="Z-INDEX: 104; LEFT: 328px; POSITION: absolute; TOP: 272px" runat="server"
			Width="16px" Height="16px" Font-Bold="True">:</asp:label>
	</body>
</HTML>
