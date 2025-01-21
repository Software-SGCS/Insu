<%@ Page Language="vb" AutoEventWireup="false" Codebehind="InvoicePayment.aspx.vb" Inherits="Insu.InvoicePayment"%>
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
					HorizontalAlign="Left" Height="32px" Width="1009px">Vehicle 
Detail</asp:panel><asp:panel id="Panel5" style="Z-INDEX: 131; LEFT: -8px; POSITION: absolute; TOP: 168px" runat="server"
					BackColor="Desktop" Height="200px" Width="104px" BackImageUrl="Menu/Audit.gif"></asp:panel><asp:label id="Label9" style="Z-INDEX: 113; LEFT: 248px; POSITION: absolute; TOP: 184px" runat="server"
					Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="Label8" style="Z-INDEX: 112; LEFT: 248px; POSITION: absolute; TOP: 112px" runat="server"
					Font-Bold="True" Height="16px" Width="9px">:</asp:label><asp:label id="Label7" style="Z-INDEX: 111; LEFT: 248px; POSITION: absolute; TOP: 72px" runat="server"
					Font-Bold="True" Height="16px" Width="9px">:</asp:label><asp:panel id="Panel3" style="Z-INDEX: 102; LEFT: -8px; POSITION: absolute; TOP: 144px" runat="server"
					Font-Bold="True" BackColor="Desktop" Height="24px" Width="1009px">Payment Detail</asp:panel><asp:label id="Label1" style="Z-INDEX: 105; LEFT: 120px; POSITION: absolute; TOP: 48px" runat="server"
					Font-Bold="True" Height="24px" Width="88px" Font-Size="Smaller">Invoice No</asp:label><asp:label id="Label2" style="Z-INDEX: 106; LEFT: 120px; POSITION: absolute; TOP: 112px" runat="server"
					Font-Bold="True" Height="24px" Width="88px" Font-Size="Smaller"> Total Amt</asp:label><asp:label id="Label3" style="Z-INDEX: 107; LEFT: 120px; POSITION: absolute; TOP: 80px" runat="server"
					Font-Bold="True" Height="24px" Width="104px">Company Code</asp:label><asp:label id="Label4" style="Z-INDEX: 108; LEFT: 120px; POSITION: absolute; TOP: 184px" runat="server"
					Font-Bold="True" Height="24px" Width="118px">Cheque No</asp:label><asp:label id="Label6" style="Z-INDEX: 110; LEFT: 248px; POSITION: absolute; TOP: 40px" runat="server"
					Font-Bold="True" Height="16px" Width="9px">:</asp:label><asp:textbox id="TxtId" style="Z-INDEX: 116; LEFT: 264px; POSITION: absolute; TOP: 40px" tabIndex="2"
					runat="server" Width="119px"></asp:textbox>
				<asp:textbox id="TxtChqNo" style="Z-INDEX: 117; LEFT: 264px; POSITION: absolute; TOP: 176px"
					tabIndex="4" runat="server" Height="24px" Width="124px"></asp:textbox><asp:dropdownlist id="LstCom" style="Z-INDEX: 118; LEFT: 264px; POSITION: absolute; TOP: 80px" tabIndex="2"
					runat="server" Height="16px" Width="321px" AutoPostBack="True"></asp:dropdownlist><asp:dropdownlist id="LstId" style="Z-INDEX: 122; LEFT: 264px; POSITION: absolute; TOP: 40px" tabIndex="1"
					runat="server" Height="16px" Width="121px" AutoPostBack="True"></asp:dropdownlist><asp:textbox id="TxtRecDt" style="Z-INDEX: 124; LEFT: 264px; POSITION: absolute; TOP: 208px"
					tabIndex="5" runat="server" Height="26px" Width="124px"></asp:textbox><asp:label id="Label12" style="Z-INDEX: 125; LEFT: 120px; POSITION: absolute; TOP: 216px" runat="server"
					Font-Bold="True" Height="24px" Width="112px">Received Date</asp:label><asp:panel id="Panel2" style="Z-INDEX: 130; LEFT: -8px; POSITION: absolute; TOP: 24px" runat="server"
					BackColor="Desktop" Height="120px" Width="104px" BackImageUrl="Menu/Audit.gif"></asp:panel><asp:label id="Label11" style="Z-INDEX: 108; LEFT: 120px; POSITION: absolute; TOP: 256px" runat="server"
					Font-Bold="True" Height="24px" Width="120px">Remarks</asp:label><asp:button id="BtnAdd" style="Z-INDEX: 102; LEFT: 152px; POSITION: absolute; TOP: 312px" tabIndex="7"
					runat="server" Font-Bold="True" Width="64px" Text="Add" Visible="False"></asp:button><asp:button id="BtnEdit" style="Z-INDEX: 103; LEFT: 248px; POSITION: absolute; TOP: 312px" tabIndex="8"
					runat="server" Font-Bold="True" Width="64px" Text="Edit" Visible="False"></asp:button><asp:button id="BtnCle" style="Z-INDEX: 104; LEFT: 336px; POSITION: absolute; TOP: 312px" tabIndex="9"
					runat="server" Font-Bold="True" Height="24px" Width="72px" Text="Clear" Visible="False"></asp:button><asp:textbox id="TxtRmks" style="Z-INDEX: 106; LEFT: 264px; POSITION: absolute; TOP: 248px" runat="server"
					Height="32px" Width="535px"></asp:textbox><asp:label id="Label13" style="Z-INDEX: 103; LEFT: 248px; POSITION: absolute; TOP: 256px" runat="server"
					Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="Label16" style="Z-INDEX: 102; LEFT: 248px; POSITION: absolute; TOP: 216px" runat="server"
					Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="LbLMsg" style="Z-INDEX: 104; LEFT: 456px; POSITION: absolute; TOP: 48px" runat="server"
					Height="16px" Width="324px"></asp:label><asp:textbox id="Txtvat" style="Z-INDEX: 105; LEFT: 676px; POSITION: absolute; TOP: 112px" runat="server"
					Width="130px"></asp:textbox><asp:label id="Vat" style="Z-INDEX: 106; LEFT: 616px; POSITION: absolute; TOP: 112px" runat="server"
					Height="24px" Width="54px">Vat & t.t</asp:label><asp:textbox id="TxtDis" style="Z-INDEX: 107; LEFT: 480px; POSITION: absolute; TOP: 112px" runat="server"
					Width="126px"></asp:textbox><asp:dropdownlist id="Lsttyp" style="Z-INDEX: 108; LEFT: 264px; POSITION: absolute; TOP: 112px" tabIndex="3"
					runat="server" Height="24px" Width="116px" Visible="False"></asp:dropdownlist><asp:label id="Label15" style="Z-INDEX: 109; LEFT: 416px; POSITION: absolute; TOP: 112px" runat="server"
					Height="24px" Width="80px">Discount</asp:label><asp:textbox id="TxtNetAmt" style="Z-INDEX: 102; LEFT: 544px; POSITION: absolute; TOP: 168px"
					runat="server" Height="26px" Width="132px"></asp:textbox><asp:label id="Label14" style="Z-INDEX: 102; LEFT: 424px; POSITION: absolute; TOP: 176px" runat="server"
					Height="24px" Width="98px">Net Amount</asp:label><asp:textbox id="TxtVAL" style="Z-INDEX: 103; LEFT: 264px; POSITION: absolute; TOP: 112px" runat="server"
					Width="128px"></asp:textbox>
				<asp:calendar id="Calendar1" style="Z-INDEX: 998; LEFT: 416px; POSITION: absolute; TOP: 208px"
					runat="server" BorderColor="White" ForeColor="Black" BackColor="White" Height="170px" Width="298px"
					Font-Size="9pt" Visible="False" Font-Names="Verdana" BorderWidth="1px" NextPrevFormat="FullMonth">
					<TodayDayStyle BackColor="#CCCCCC"></TodayDayStyle>
					<NextPrevStyle Font-Size="8pt" Font-Bold="True" ForeColor="#333333" VerticalAlign="Bottom"></NextPrevStyle>
					<DayHeaderStyle Font-Size="8pt" Font-Bold="True"></DayHeaderStyle>
					<SelectedDayStyle ForeColor="White" BackColor="#333399"></SelectedDayStyle>
					<TitleStyle Font-Size="12pt" Font-Bold="True" BorderWidth="4px" ForeColor="#333399" BorderColor="Black"
						BackColor="White"></TitleStyle>
					<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
				</asp:calendar>
				<asp:imagebutton id="ImgBtt1" style="Z-INDEX: 111; LEFT: 10px; POSITION: absolute; TOP: 216px" runat="server"
					Height="18px" Width="24px" ImageUrl="file:///d:\Inetpub\wwwroot\sgcsser\iCO\Cal3.jpg"></asp:imagebutton>
				<asp:label id="Label17" style="Z-INDEX: 102; LEFT: 536px; POSITION: absolute; TOP: 184px" runat="server"
					Font-Bold="True" Height="16px" Width="16px">:</asp:label>
				<asp:panel id="Panel4" style="Z-INDEX: 103; LEFT: -8px; POSITION: absolute; TOP: 368px" runat="server"
					Width="1006px" Height="40px" BackColor="Desktop"></asp:panel>
				<asp:button id="BtnApp" style="Z-INDEX: 104; LEFT: 152px; POSITION: absolute; TOP: 376px" tabIndex="10"
					runat="server" Width="66px" Font-Bold="True" Text="Apply"></asp:button>
				<asp:button id="BtnDel" style="Z-INDEX: 105; LEFT: 248px; POSITION: absolute; TOP: 376px" tabIndex="11"
					runat="server" Width="64px" Font-Bold="True" Text="Delete"></asp:button>
				<asp:ImageButton id="ImageButton1" style="Z-INDEX: 102; LEFT: 392px; POSITION: absolute; TOP: 208px"
					runat="server" Width="24px" Height="24px" ImageUrl="iCO\Cal1.jpg"></asp:ImageButton>
				<asp:ImageButton id="ImgBtt" style="Z-INDEX: 102; LEFT: 712px; POSITION: absolute; TOP: 176px" runat="server"
					Width="124px" Height="32px" ImageUrl="Menu/view1.jpg"></asp:ImageButton>
			</FORM>
		</DIV>
	</body>
</HTML>
