<%@ Page Language="vb" AutoEventWireup="false" Codebehind="AccidentForm1.aspx.vb" Inherits="Insu.AccidentForm1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Accident Form1</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:panel id="Panel1" style="Z-INDEX: 100; LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server"
				Width="920px" Height="32px" HorizontalAlign="Left" Enabled="False" BackColor="Desktop"
				Font-Bold="True" ForeColor="White" BorderColor="Transparent">Vehicle Detail</asp:panel><asp:panel id="Panel5" style="Z-INDEX: 117; LEFT: 0px; POSITION: absolute; TOP: 144px" runat="server"
				Width="112px" Height="360px" BackColor="Desktop" BackImageUrl="Menu/Audit.gif"></asp:panel><asp:label id="Label9" style="Z-INDEX: 108; LEFT: 552px; POSITION: absolute; TOP: 232px" runat="server"
				Width="16px" Height="16px" Font-Bold="True">:</asp:label><asp:label id="Label8" style="Z-INDEX: 107; LEFT: 232px; POSITION: absolute; TOP: 160px" runat="server"
				Width="16px" Height="16px" Font-Bold="True">:</asp:label>
			<asp:panel id="Panel4" style="Z-INDEX: 101; LEFT: 0px; POSITION: absolute; TOP: 496px" runat="server"
				Width="920px" Height="40px" BackColor="Desktop"></asp:panel><asp:button id="BtnCle" style="Z-INDEX: 102; LEFT: 264px; POSITION: absolute; TOP: 504px" tabIndex="9"
				runat="server" Width="72px" Height="24px" Font-Bold="True" Text="Clear"></asp:button><asp:label id="Label1" style="Z-INDEX: 103; LEFT: 128px; POSITION: absolute; TOP: 72px" tabIndex="101"
				runat="server" Width="88px" Height="12px" Font-Bold="True" Font-Size="X-Small">Vehicle No</asp:label><asp:label id="Label2" style="Z-INDEX: 104; LEFT: 440px; POSITION: absolute; TOP: 72px" tabIndex="104"
				runat="server" Width="88px" Height="24px" Font-Bold="True" Font-Size="Smaller">Vehicle Type</asp:label><asp:label id="Label4" style="Z-INDEX: 105; LEFT: 424px; POSITION: absolute; TOP: 224px" tabIndex="106"
				runat="server" Width="118px" Height="24px" Font-Bold="True">Accident Date</asp:label><asp:label id="Label6" style="Z-INDEX: 106; LEFT: 232px; POSITION: absolute; TOP: 72px" runat="server"
				Width="16px" Height="16px" Font-Bold="True">:</asp:label><asp:button id="BtnEdit" style="Z-INDEX: 109; LEFT: 192px; POSITION: absolute; TOP: 504px" tabIndex="8"
				runat="server" Width="64px" Font-Bold="True" Text="Edit" Visible="False"></asp:button><asp:textbox id="TxtAcidt" style="Z-INDEX: 110; LEFT: 568px; POSITION: absolute; TOP: 224px"
				tabIndex="6" runat="server" Width="88px" Height="24px"></asp:textbox><asp:dropdownlist id="LstId" style="Z-INDEX: 111; LEFT: 248px; POSITION: absolute; TOP: 72px" tabIndex="2"
				runat="server" Width="176px" Height="16px" Font-Size="X-Small" AutoPostBack="True"></asp:dropdownlist><asp:button id="BtnDel" style="Z-INDEX: 112; LEFT: 416px; POSITION: absolute; TOP: 504px" tabIndex="11"
				runat="server" Width="64px" Font-Bold="True" Text="Delete"></asp:button><asp:textbox id="TxtEstval1" style="Z-INDEX: 113; LEFT: 272px; POSITION: absolute; TOP: 248px"
				tabIndex="7" runat="server" Width="112px" Height="26px"></asp:textbox><asp:label id="Label12" style="Z-INDEX: 114; LEFT: 128px; POSITION: absolute; TOP: 256px" tabIndex="107"
				runat="server" Width="120px" Height="24px" Font-Bold="True"> Estimate Value 1</asp:label><asp:panel id="Panel2" style="Z-INDEX: 116; LEFT: 0px; POSITION: absolute; TOP: 32px" runat="server"
				Width="112px" Height="112px" BackColor="Desktop" BackImageUrl="Menu/v2.jpg"></asp:panel><asp:button id="BtnAdd" style="Z-INDEX: 118; LEFT: 120px; POSITION: absolute; TOP: 504px" tabIndex="7"
				runat="server" Width="64px" Font-Bold="True" Text="Add" Visible="False"></asp:button><asp:label id="LbLMsg" style="Z-INDEX: 119; LEFT: 232px; POSITION: absolute; TOP: 544px" runat="server"
				Width="474px" Height="16px"></asp:label><asp:button id="BtnApp" style="Z-INDEX: 120; LEFT: 344px; POSITION: absolute; TOP: 504px" tabIndex="10"
				runat="server" Width="66px" Font-Bold="True" Text="Apply"></asp:button><asp:textbox id="TxtAppVal1" style="Z-INDEX: 121; LEFT: 272px; POSITION: absolute; TOP: 304px"
				tabIndex="11" runat="server" Width="112px" Height="24px" AutoPostBack="True"></asp:textbox><asp:label id="Label13" style="Z-INDEX: 122; LEFT: 128px; POSITION: absolute; TOP: 312px" tabIndex="111"
				runat="server" Width="120px" Height="15px" Font-Bold="True"> Approved Value 1</asp:label><asp:label id="Label11" style="Z-INDEX: 123; LEFT: 552px; POSITION: absolute; TOP: 280px" runat="server"
				Width="16px" Height="16px" Font-Bold="True">:</asp:label><asp:textbox id="Lsttyp" style="Z-INDEX: 124; LEFT: 560px; POSITION: absolute; TOP: 72px" tabIndex="4"
				runat="server" Width="120px" Height="20px" Font-Size="X-Small"></asp:textbox><asp:imagebutton id="ImgBtn1" style="Z-INDEX: 126; LEFT: 656px; POSITION: absolute; TOP: 224px" runat="server"
				Width="24px" Height="24px" ImageUrl="iCO\Cal1.jpg"></asp:imagebutton><asp:label id="Label14" style="Z-INDEX: 125; LEFT: 128px; POSITION: absolute; TOP: 232px" tabIndex="105"
				runat="server" Width="112px" Height="16px" Font-Bold="True">Claim No</asp:label><asp:textbox id="TxtVehClNo" style="Z-INDEX: 127; LEFT: 272px; POSITION: absolute; TOP: 224px"
				tabIndex="5" runat="server" Width="114px" Height="24px" AutoPostBack="True"></asp:textbox><asp:calendar id="Calendar1" style="Z-INDEX: 128; LEFT: 680px; POSITION: absolute; TOP: 216px"
				runat="server" Width="152px" Height="120px" BackColor="White" ForeColor="#003399" BorderColor="#3366CC" Font-Size="8pt" CellPadding="1" DayNameFormat="FirstLetter" BorderWidth="1px" Font-Names="Verdana">
				<TodayDayStyle ForeColor="White" BackColor="#99CCCC"></TodayDayStyle>
				<SelectorStyle ForeColor="#336666" BackColor="#99CCCC"></SelectorStyle>
				<NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF"></NextPrevStyle>
				<DayHeaderStyle Height="1px" ForeColor="#336666" BackColor="#99CCCC"></DayHeaderStyle>
				<SelectedDayStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedDayStyle>
				<TitleStyle Font-Size="10pt" Font-Bold="True" Height="25px" BorderWidth="1px" ForeColor="#CCCCFF"
					BorderStyle="Solid" BorderColor="#3366CC" BackColor="#003399"></TitleStyle>
				<WeekendDayStyle BackColor="#CCCCFF"></WeekendDayStyle>
				<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
			</asp:calendar><asp:label id="L1" style="Z-INDEX: 129; LEFT: 0px; POSITION: absolute; TOP: 544px" runat="server"
				Width="160px" Height="24px"></asp:label><asp:dropdownlist id="LstCom1" style="Z-INDEX: 130; LEFT: 248px; POSITION: absolute; TOP: 40px" tabIndex="1"
				runat="server" Width="328px" Height="24px" AutoPostBack="True"></asp:dropdownlist><asp:label id="Label15" style="Z-INDEX: 131; LEFT: 128px; POSITION: absolute; TOP: 40px" tabIndex="100"
				runat="server" Width="64px" Height="16px" Font-Bold="True" Font-Size="X-Small">Company</asp:label><asp:label id="Label17" style="Z-INDEX: 132; LEFT: 232px; POSITION: absolute; TOP: 40px" runat="server"
				Width="16px" Height="16px" Font-Bold="True">:</asp:label><asp:label id="Label18" style="Z-INDEX: 133; LEFT: 424px; POSITION: absolute; TOP: 280px" tabIndex="110"
				runat="server" Width="104px" Height="16px" Font-Bold="True">Police Report</asp:label><asp:label id="Label19" style="Z-INDEX: 134; LEFT: 128px; POSITION: absolute; TOP: 288px" tabIndex="108"
				runat="server" Width="120px" Height="16px" Font-Bold="True">Damage Imagers</asp:label><asp:dropdownlist id="DmgFg" style="Z-INDEX: 135; LEFT: 272px; POSITION: absolute; TOP: 280px" tabIndex="9"
				runat="server" Width="112px" Height="16px" AutoPostBack="True"></asp:dropdownlist><asp:label id="Label20" style="Z-INDEX: 136; LEFT: 128px; POSITION: absolute; TOP: 368px" tabIndex="126"
				runat="server" Width="128px" Height="40px" Font-Bold="True" Font-Size="X-Small">Pending Payment</asp:label><asp:dropdownlist id="PlcFg" style="Z-INDEX: 138; LEFT: 568px; POSITION: absolute; TOP: 280px" tabIndex="10"
				runat="server" Width="136px" Height="16px" AutoPostBack="True"></asp:dropdownlist>
			<DIV id="Div2" style="Z-INDEX: 139; LEFT: 128px; OVERFLOW: scroll; WIDTH: 792px; POSITION: absolute; TOP: 384px; HEIGHT: 112px"
				noWrap><asp:datagrid id="Datagrid2" tabIndex="125" runat="server" Width="768px" Height="12px" BackColor="LightGoldenrodYellow"
					ForeColor="Black" BorderColor="Tan" Font-Size="Small" BorderWidth="1px" Font-Names="Tahoma" cellpadding="2"
					Headerstyle-BackColor="#8080C0" Headerstyle-Font-Name="Tahoma" Headerstyle-Font-Size="12" Headerstyle-Font-Bold="True"
					Font-Name="Tahoma" AutogenerateColumns="False" DataKeyField="id" GridLines="None">
					<SelectedItemStyle Font-Size="Smaller" ForeColor="GhostWhite" BackColor="DarkSlateBlue"></SelectedItemStyle>
					<EditItemStyle Font-Size="Smaller"></EditItemStyle>
					<AlternatingItemStyle Font-Size="Smaller" BackColor="PaleGoldenrod"></AlternatingItemStyle>
					<ItemStyle Font-Size="Smaller"></ItemStyle>
					<HeaderStyle Font-Size="X-Small" Font-Names="Arial" Font-Bold="True" BackColor="Tan"></HeaderStyle>
					<FooterStyle BackColor="Tan"></FooterStyle>
					<Columns>
						<asp:BoundColumn DataField="Acc_Date" HeaderText="Acc Date">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Claim_No" HeaderText="Claim No">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Ext_Amt1" HeaderText="Est Val1">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Ext_Amt2" HeaderText="Est Val2">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="App_Amt1" HeaderText="App Val1">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="App_Amt2" HeaderText="App Val2">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="App_Amt2" HeaderText="App Val2">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Final_Amt" HeaderText="Final Amt">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Fin_Svg" HeaderText="Salvage">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="RepPer" HeaderText="Repl(%)">
							<HeaderStyle Width="0.5in"></HeaderStyle>
							<ItemStyle Font-Bold="True" HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Remakes" HeaderText="Remarks">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Center" ForeColor="DarkSlateBlue" BackColor="PaleGoldenrod"></PagerStyle>
				</asp:datagrid></DIV>
			<DIV id="Div1" style="Z-INDEX: 140; LEFT: 128px; OVERFLOW: scroll; WIDTH: 792px; POSITION: absolute; TOP: 120px; HEIGHT: 104px"
				noWrap><asp:datagrid id="Datagrid1" tabIndex="120" runat="server" Width="760px" Height="12px" BackColor="White"
					BorderColor="#CCCCCC" Font-Size="Small" BorderWidth="1px" Font-Names="Tahoma" cellpadding="3" Headerstyle-BackColor="#8080C0"
					Headerstyle-Font-Name="Tahoma" Headerstyle-Font-Size="12" Headerstyle-Font-Bold="True" Font-Name="Tahoma"
					AutogenerateColumns="False" DataKeyField="id" BorderStyle="None">
					<SelectedItemStyle Font-Size="Smaller" Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
					<EditItemStyle Font-Size="Smaller"></EditItemStyle>
					<AlternatingItemStyle Font-Size="Smaller"></AlternatingItemStyle>
					<ItemStyle Font-Size="Smaller" ForeColor="#000066"></ItemStyle>
					<HeaderStyle Font-Size="X-Small" Font-Names="Arial" Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
					<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
					<Columns>
						<asp:BoundColumn DataField="Acc_Date" HeaderText="Acc Date">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Claim_No" HeaderText="Claim No">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Ext_Amt1" HeaderText="Est Val1">
							<HeaderStyle Width="2.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Ext_Amt2" HeaderText="Est Val2">
							<HeaderStyle Width="2.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="App_Amt1" HeaderText="App Val1">
							<HeaderStyle Width="2.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="App_Amt2" HeaderText="App Val2">
							<HeaderStyle Width="2.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Final_Amt" HeaderText="Final Amount">
							<HeaderStyle Width="2.5in"></HeaderStyle>
							<ItemStyle Font-Bold="True" HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="RepPer" HeaderText="Repl(%)">
							<HeaderStyle Width="0.5in"></HeaderStyle>
							<ItemStyle Font-Bold="True" HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Chq_No" HeaderText="Cheque No">
							<HeaderStyle Width="2.5in"></HeaderStyle>
							<ItemStyle Font-Bold="True" HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
				</asp:datagrid></DIV>
			<asp:label id="Label5" style="Z-INDEX: 141; LEFT: 256px; POSITION: absolute; TOP: 280px" runat="server"
				Width="16px" Height="16px" Font-Bold="True">:</asp:label><asp:label id="Label10" style="Z-INDEX: 142; LEFT: 256px; POSITION: absolute; TOP: 312px" runat="server"
				Width="16px" Height="16px" Font-Bold="True">:</asp:label><asp:label id="Label22" style="Z-INDEX: 143; LEFT: 424px; POSITION: absolute; TOP: 256px" tabIndex="113"
				runat="server" Width="64px" Height="24px" Font-Bold="True">Value 2</asp:label><asp:textbox id="TxtEstval2" style="Z-INDEX: 144; LEFT: 568px; POSITION: absolute; TOP: 248px"
				tabIndex="8" runat="server" Width="88px" Height="26px" Wrap="False"></asp:textbox><asp:label id="Label23" style="Z-INDEX: 145; LEFT: 424px; POSITION: absolute; TOP: 304px" tabIndex="112"
				runat="server" Width="64px" Height="24px" Font-Bold="True">Value 2</asp:label><asp:textbox id="TxtAppVal2" style="Z-INDEX: 146; LEFT: 568px; POSITION: absolute; TOP: 304px"
				tabIndex="12" runat="server" Width="88px" Height="24px" Wrap="False"></asp:textbox><asp:label id="Label21" style="Z-INDEX: 137; LEFT: 128px; POSITION: absolute; TOP: 104px" tabIndex="127"
				runat="server" Width="192px" Height="16px" Font-Bold="True" Font-Size="X-Small">Accident Payment History</asp:label><asp:label id="Label3" style="Z-INDEX: 147; LEFT: 552px; POSITION: absolute; TOP: 256px" runat="server"
				Width="16px" Height="16px" Font-Bold="True">:</asp:label><asp:label id="Label16" style="Z-INDEX: 115; LEFT: 256px; POSITION: absolute; TOP: 232px" runat="server"
				Width="16px" Height="16px" Font-Bold="True">:</asp:label><asp:label id="Label7" style="Z-INDEX: 148; LEFT: 256px; POSITION: absolute; TOP: 256px" runat="server"
				Width="16px" Height="16px" Font-Bold="True">:</asp:label><asp:label id="Label24" style="Z-INDEX: 149; LEFT: 552px; POSITION: absolute; TOP: 312px" runat="server"
				Width="16px" Height="16px" Font-Bold="True">:</asp:label><asp:label id="Label25" style="Z-INDEX: 150; LEFT: 128px; POSITION: absolute; TOP: 336px" tabIndex="111"
				runat="server" Width="120px" Height="15px" Font-Bold="True">Remarks</asp:label><asp:textbox id="txtRem" style="Z-INDEX: 151; LEFT: 272px; POSITION: absolute; TOP: 336px" tabIndex="13"
				runat="server" Width="384px" Height="40px" AutoPostBack="True" TextMode="MultiLine"></asp:textbox>
			<asp:label id="Label26" style="Z-INDEX: 152; LEFT: 664px; POSITION: absolute; TOP: 304px" tabIndex="112"
				runat="server" Font-Bold="True" Height="24px" Width="64px">Replacement </asp:label>
			<asp:textbox id="txtRep" style="Z-INDEX: 154; LEFT: 760px; POSITION: absolute; TOP: 304px" tabIndex="5"
				runat="server" Height="24px" Width="32px" AutoPostBack="True"></asp:textbox>
			<asp:label id="Label27" style="Z-INDEX: 155; LEFT: 792px; POSITION: absolute; TOP: 304px" tabIndex="112"
				runat="server" Font-Bold="True" Height="24px" Width="16px">%</asp:label></form>
	</body>
</HTML>
