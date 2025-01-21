<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Inwordpayment.aspx.vb" Inherits="Insu.Inwordpayment"%>
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
		<DIV style="Z-INDEX: 101; LEFT: 8px; WIDTH: 10px; POSITION: absolute; TOP: 8px; HEIGHT: 10px"
			ms_positioning="text2D">
			<FORM id="Form1" method="post" runat="server">
				<asp:panel id="Panel1" style="Z-INDEX: 101; LEFT: -8px; POSITION: absolute; TOP: -8px" runat="server"
					BorderColor="Transparent" ForeColor="White" Font-Bold="True" BackColor="Desktop" Enabled="False"
					HorizontalAlign="Left" Height="32px" Width="1009px">
<asp:calendar id="Calendar2" style="Z-INDEX: 101; LEFT: 384px; POSITION: absolute; TOP: 280px"
						runat="server" Width="174px" Height="136px" BackColor="White" ForeColor="Black"
						BorderColor="White" Font-Names="Verdana" BorderWidth="1px" NextPrevFormat="FullMonth"
						Visible="False" Font-Size="9pt">
						<TodayDayStyle BackColor="#CCCCCC"></TodayDayStyle>
						<NextPrevStyle Font-Size="8pt" Font-Bold="True" ForeColor="#333333" VerticalAlign="Bottom"></NextPrevStyle>
						<DayHeaderStyle Font-Size="8pt" Font-Bold="True"></DayHeaderStyle>
						<SelectedDayStyle ForeColor="White" BackColor="#333399"></SelectedDayStyle>
						<TitleStyle Font-Size="12pt" Font-Bold="True" BorderWidth="4px" ForeColor="#333399" BorderColor="Black"
							BackColor="White"></TitleStyle>
						<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
					</asp:calendar>
<asp:calendar id="Calendar3" style="Z-INDEX: 998; LEFT: 624px; POSITION: absolute; TOP: 224px"
						runat="server" Width="160px" Height="144px" BackColor="White" ForeColor="Black"
						BorderColor="White" Font-Names="Verdana" BorderWidth="1px" NextPrevFormat="FullMonth"
						Visible="False" Font-Size="9pt">
						<TodayDayStyle BackColor="#CCCCCC"></TodayDayStyle>
						<NextPrevStyle Font-Size="8pt" Font-Bold="True" ForeColor="#333333" VerticalAlign="Bottom"></NextPrevStyle>
						<DayHeaderStyle Font-Size="8pt" Font-Bold="True"></DayHeaderStyle>
						<SelectedDayStyle ForeColor="White" BackColor="#333399"></SelectedDayStyle>
						<TitleStyle Font-Size="12pt" Font-Bold="True" BorderWidth="4px" ForeColor="#333399" BorderColor="Black"
							BackColor="White"></TitleStyle>
						<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
					</asp:calendar>
<asp:imagebutton id="Imagebutton3" style="Z-INDEX: 114; LEFT: 592px; POSITION: absolute; TOP: 224px"
						runat="server" Width="24px" Height="24px" ImageUrl="file:///\\sgcsser\C\Inetpub\wwwroot\Insu\iCO\Cal1.jpg"></asp:imagebutton>
<asp:label id="Label23" style="Z-INDEX: 113; LEFT: 504px; POSITION: absolute; TOP: 224px" runat="server"
						Width="4px" Height="16px" Font-Bold="True">:</asp:label>
<asp:label id="Label21" style="Z-INDEX: 107; LEFT: 504px; POSITION: absolute; TOP: 184px" runat="server"
						Width="4px" Height="24px" Font-Bold="True">:</asp:label>
<asp:label id="Label20" style="Z-INDEX: 106; LEFT: 424px; POSITION: absolute; TOP: 184px" runat="server"
						Width="70px" Height="24px" BackColor="White" Font-Bold="True" ForeColor="Navy">Chq No</asp:label>
<asp:label id="Label19" style="Z-INDEX: 104; LEFT: 256px; POSITION: absolute; TOP: 184px" runat="server"
						Width="8px" Height="24px" Font-Bold="True">:</asp:label>
<asp:label id="Label18" style="Z-INDEX: 105; LEFT: 256px; POSITION: absolute; TOP: 184px" runat="server"
						Width="8px" Height="24px" Font-Bold="True">:</asp:label>
<asp:label id="Label17" style="Z-INDEX: 103; LEFT: 128px; POSITION: absolute; TOP: 184px" runat="server"
						Width="112px" Height="24px" BackColor="White" Font-Bold="True" ForeColor="#004000">Grn No</asp:label>Inword</asp:panel><asp:panel id="Panel5" style="Z-INDEX: 131; LEFT: -8px; POSITION: absolute; TOP: 168px" runat="server"
					BackColor="Desktop" Height="232px" Width="104px" BackImageUrl="Menu/Audit.gif"></asp:panel><asp:label id="Label9" style="Z-INDEX: 113; LEFT: 248px; POSITION: absolute; TOP: 232px" runat="server"
					Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="Label8" style="Z-INDEX: 112; LEFT: 248px; POSITION: absolute; TOP: 112px" runat="server"
					Font-Bold="True" Height="16px" Width="9px">:</asp:label><asp:label id="Label7" style="Z-INDEX: 111; LEFT: 248px; POSITION: absolute; TOP: 72px" runat="server"
					Font-Bold="True" Height="16px" Width="9px">:</asp:label><asp:panel id="Panel3" style="Z-INDEX: 102; LEFT: -8px; POSITION: absolute; TOP: 144px" runat="server"
					Font-Bold="True" BackColor="Desktop" Height="24px" Width="1009px"> Detail</asp:panel><asp:label id="Label1" style="Z-INDEX: 105; LEFT: 120px; POSITION: absolute; TOP: 48px" runat="server"
					Font-Bold="True" Height="24px" Width="88px" Font-Size="Smaller">Invoice No</asp:label><asp:label id="Label2" style="Z-INDEX: 106; LEFT: 120px; POSITION: absolute; TOP: 112px" runat="server"
					Font-Bold="True" Height="24px" Width="88px" Font-Size="Smaller"> Total Amt</asp:label><asp:label id="Label3" style="Z-INDEX: 107; LEFT: 120px; POSITION: absolute; TOP: 80px" runat="server"
					Font-Bold="True" Height="24px" Width="104px">Company Code</asp:label><asp:label id="Label4" style="Z-INDEX: 108; LEFT: 120px; POSITION: absolute; TOP: 272px" runat="server"
					Font-Bold="True" Height="24px" Width="104px">Date of Rec. Bill Date</asp:label><asp:label id="Label6" style="Z-INDEX: 110; LEFT: 248px; POSITION: absolute; TOP: 40px" runat="server"
					Font-Bold="True" Height="16px" Width="9px">:</asp:label><asp:textbox id="TxtId" style="Z-INDEX: 116; LEFT: 264px; POSITION: absolute; TOP: 40px" tabIndex="2"
					runat="server" Width="119px"></asp:textbox>
				<asp:textbox id="TxtBilDt" style="Z-INDEX: 117; LEFT: 264px; POSITION: absolute; TOP: 264px"
					tabIndex="4" runat="server" Height="24px" Width="80px" ReadOnly="True"></asp:textbox><asp:dropdownlist id="LstCom" style="Z-INDEX: 118; LEFT: 264px; POSITION: absolute; TOP: 80px" tabIndex="2"
					runat="server" Enabled="False" Height="16px" Width="321px" AutoPostBack="True"></asp:dropdownlist><asp:dropdownlist id="LstId" style="Z-INDEX: 122; LEFT: 264px; POSITION: absolute; TOP: 40px" tabIndex="1"
					runat="server" Height="16px" Width="121px" AutoPostBack="True"></asp:dropdownlist><asp:textbox id="TxtRecDt" style="Z-INDEX: 124; LEFT: 264px; POSITION: absolute; TOP: 224px"
					tabIndex="5" runat="server" Height="26px" Width="80px" ReadOnly="True"></asp:textbox><asp:label id="Label12" style="Z-INDEX: 125; LEFT: 120px; POSITION: absolute; TOP: 224px" runat="server"
					Font-Bold="True" Height="24px" Width="112px">Goods Received Date</asp:label><asp:panel id="Panel2" style="Z-INDEX: 130; LEFT: -8px; POSITION: absolute; TOP: 24px" runat="server"
					BackColor="Desktop" Height="120px" Width="104px" BackImageUrl="Menu/Audit.gif"></asp:panel><asp:button id="BtnAdd" style="Z-INDEX: 102; LEFT: 152px; POSITION: absolute; TOP: 352px" tabIndex="7"
					runat="server" Font-Bold="True" Width="64px" Visible="False" Text="Add"></asp:button><asp:button id="BtnEdit" style="Z-INDEX: 103; LEFT: 248px; POSITION: absolute; TOP: 352px" tabIndex="8"
					runat="server" Font-Bold="True" Width="64px" Visible="False" Text="Edit"></asp:button><asp:button id="BtnCle" style="Z-INDEX: 104; LEFT: 336px; POSITION: absolute; TOP: 352px" tabIndex="9"
					runat="server" Font-Bold="True" Height="24px" Width="72px" Visible="False" Text="Clear"></asp:button><asp:label id="Label13" runat="server" Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="Label16" style="Z-INDEX: 102; LEFT: 248px; POSITION: absolute; TOP: 264px" runat="server"
					Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="LbLMsg" style="Z-INDEX: 104; LEFT: 456px; POSITION: absolute; TOP: 48px" runat="server"
					Height="16px" Width="324px"></asp:label><asp:textbox id="Txtpono" style="Z-INDEX: 107; LEFT: 480px; POSITION: absolute; TOP: 112px" runat="server"
					Width="90px" ReadOnly="True"></asp:textbox><asp:dropdownlist id="Lsttyp" style="Z-INDEX: 108; LEFT: 264px; POSITION: absolute; TOP: 112px" tabIndex="3"
					runat="server" Height="24px" Width="98px" Visible="False"></asp:dropdownlist><asp:label id="Label15" style="Z-INDEX: 109; LEFT: 416px; POSITION: absolute; TOP: 112px" runat="server"
					Height="24px" Width="80px">Po No</asp:label><asp:label id="Label14" style="Z-INDEX: 102; LEFT: 120px; POSITION: absolute; TOP: 320px" runat="server"
					Font-Bold="True" Height="24px" Width="94px">Payment date</asp:label><asp:textbox id="TxtVAL" style="Z-INDEX: 103; LEFT: 264px; POSITION: absolute; TOP: 112px" runat="server"
					Width="128px" ReadOnly="True"></asp:textbox><asp:calendar id="Calendar1" style="Z-INDEX: 998; LEFT: 376px; POSITION: absolute; TOP: 224px"
					runat="server" BorderColor="White" ForeColor="Black" BackColor="White" Height="171px" Width="178px" Font-Size="9pt" Visible="False" NextPrevFormat="FullMonth"
					BorderWidth="1px" Font-Names="Verdana">
					<TodayDayStyle BackColor="#CCCCCC"></TodayDayStyle>
					<NextPrevStyle Font-Size="8pt" Font-Bold="True" ForeColor="#333333" VerticalAlign="Bottom"></NextPrevStyle>
					<DayHeaderStyle Font-Size="8pt" Font-Bold="True"></DayHeaderStyle>
					<SelectedDayStyle ForeColor="White" BackColor="#333399"></SelectedDayStyle>
					<TitleStyle Font-Size="12pt" Font-Bold="True" BorderWidth="4px" ForeColor="#333399" BorderColor="Black"
						BackColor="White"></TitleStyle>
					<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
				</asp:calendar><asp:imagebutton id="ImgBtt1" style="Z-INDEX: 111; LEFT: 10px; POSITION: absolute; TOP: 216px" runat="server"
					Height="18px" Width="24px" ImageUrl="file:///d:\Inetpub\wwwroot\sgcsser\iCO\Cal3.jpg"></asp:imagebutton><asp:panel id="Panel4" style="Z-INDEX: 103; LEFT: -8px; POSITION: absolute; TOP: 400px" runat="server"
					BackColor="Desktop" Height="40px" Width="1006px" BackImageUrl="http://sgcsser\Insu\Menu\aaa.gif"></asp:panel><asp:button id="BtnApp" style="Z-INDEX: 104; LEFT: 152px; POSITION: absolute; TOP: 376px" tabIndex="10"
					runat="server" Font-Bold="True" Width="66px" Text="Apply"></asp:button><asp:button id="BtnDel" style="Z-INDEX: 105; LEFT: 248px; POSITION: absolute; TOP: 376px" tabIndex="11"
					runat="server" Font-Bold="True" Width="64px" Text="Delete"></asp:button><asp:imagebutton id="ImageButton1" style="Z-INDEX: 102; LEFT: 344px; POSITION: absolute; TOP: 224px"
					runat="server" Height="24px" Width="24px" ImageUrl="file:///\\sgcsser\C\Inetpub\wwwroot\Insu\iCO\Cal1.jpg"></asp:imagebutton><asp:textbox id="TxtCrdLmt" style="Z-INDEX: 103; LEFT: 632px; POSITION: absolute; TOP: 88px"
					runat="server" Width="56px" Visible="False"></asp:textbox><asp:imagebutton id="Imagebutton2" style="Z-INDEX: 104; LEFT: 344px; POSITION: absolute; TOP: 264px"
					runat="server" Height="24px" Width="24px" ImageUrl="file:///\\sgcsser\C\Inetpub\wwwroot\Insu\iCO\Cal1.jpg"></asp:imagebutton><asp:textbox id="TxtGrnNo" style="Z-INDEX: 105; LEFT: 264px; POSITION: absolute; TOP: 176px"
					runat="server" Height="24px" Width="128px" ReadOnly="True"></asp:textbox><asp:label id="Label11" style="Z-INDEX: 102; LEFT: 248px; POSITION: absolute; TOP: 320px" runat="server"
					Font-Bold="True" Height="24px" Width="8px">:</asp:label><asp:textbox id="TxtPaydt" style="Z-INDEX: 103; LEFT: 264px; POSITION: absolute; TOP: 320px"
					runat="server" Height="24px" Width="80px" ReadOnly="True"></asp:textbox><asp:label id="Label22" style="Z-INDEX: 104; LEFT: 416px; POSITION: absolute; TOP: 216px" runat="server"
					Height="16px" Width="73px">Date</asp:label><asp:textbox id="Txtchqdt" style="Z-INDEX: 105; LEFT: 504px; POSITION: absolute; TOP: 216px"
					runat="server" Height="26px" Width="80px"></asp:textbox>
				<asp:TextBox id="TxtChqNo" style="Z-INDEX: 102; LEFT: 504px; POSITION: absolute; TOP: 176px"
					runat="server" Width="108px"></asp:TextBox></FORM>
		</DIV>
	</body>
</HTML>
