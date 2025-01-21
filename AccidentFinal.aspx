<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<%@ Page Language="vb" AutoEventWireup="false" Codebehind="AccidentFinal.aspx.vb" Inherits="Insu.AccidentFinal" %>
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
			<asp:panel id="Panel1" style="Z-INDEX: 101; LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server"
				BorderColor="Transparent" ForeColor="White" Font-Bold="True" BackColor="Desktop" Enabled="False"
				HorizontalAlign="Left" Height="32px" Width="920px">Vehicle Detail</asp:panel><asp:panel id="Panel5" style="Z-INDEX: 118; LEFT: 0px; POSITION: absolute; TOP: 144px" runat="server"
				BackColor="Desktop" Height="428px" Width="112px" BackImageUrl="Menu/Audit.gif"></asp:panel><asp:label id="Label9" style="Z-INDEX: 109; LEFT: 552px; POSITION: absolute; TOP: 208px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="Label8" style="Z-INDEX: 108; LEFT: 256px; POSITION: absolute; TOP: 288px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label>
			<asp:panel id="Panel4" style="Z-INDEX: 102; LEFT: 0px; POSITION: absolute; TOP: 568px" runat="server"
				BackColor="Desktop" Height="40px" Width="920px">
				<asp:label id="LbLMsg" runat="server" Width="474px" Height="16px"></asp:label>
			</asp:panel><asp:button id="BtnCle" style="Z-INDEX: 103; LEFT: 272px; POSITION: absolute; TOP: 576px" tabIndex="9"
				runat="server" Font-Bold="True" Height="24px" Width="72px" Text="Clear"></asp:button><asp:label id="Label1" style="Z-INDEX: 104; LEFT: 128px; POSITION: absolute; TOP: 56px" tabIndex="101"
				runat="server" Font-Bold="True" Height="12px" Width="88px" Font-Size="X-Small">Vehicle No</asp:label><asp:label id="Label2" style="Z-INDEX: 105; LEFT: 440px; POSITION: absolute; TOP: 56px" tabIndex="104"
				runat="server" Font-Bold="True" Height="24px" Width="88px" Font-Size="Smaller">Vehicle Type</asp:label><asp:label id="Label4" style="Z-INDEX: 106; LEFT: 424px; POSITION: absolute; TOP: 200px" tabIndex="106"
				runat="server" Font-Bold="True" Height="24px" Width="118px">Accident Date</asp:label><asp:label id="Label6" style="Z-INDEX: 107; LEFT: 232px; POSITION: absolute; TOP: 72px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:button id="BtnEdit" style="Z-INDEX: 110; LEFT: 200px; POSITION: absolute; TOP: 576px" tabIndex="8"
				runat="server" Font-Bold="True" Width="64px" Text="Edit" Visible="False"></asp:button><asp:textbox id="TxtAcidt" style="Z-INDEX: 111; LEFT: 568px; POSITION: absolute; TOP: 200px"
				tabIndex="6" runat="server" Height="24px" Width="80px" ReadOnly="True"></asp:textbox><asp:dropdownlist id="LstId" style="Z-INDEX: 112; LEFT: 248px; POSITION: absolute; TOP: 56px" tabIndex="2"
				runat="server" Height="16px" Width="176px" Font-Size="X-Small" AutoPostBack="True"></asp:dropdownlist><asp:button id="BtnDel" style="Z-INDEX: 113; LEFT: 424px; POSITION: absolute; TOP: 576px" tabIndex="11"
				runat="server" Font-Bold="True" Width="64px" Text="Delete"></asp:button><asp:textbox id="TxtEstval1" style="Z-INDEX: 114; LEFT: 568px; POSITION: absolute; TOP: 224px"
				tabIndex="7" runat="server" Enabled="False" Height="26px" Width="96px" ReadOnly="True"></asp:textbox><asp:label id="Label12" style="Z-INDEX: 115; LEFT: 424px; POSITION: absolute; TOP: 232px" tabIndex="107"
				runat="server" Font-Bold="True" Height="24px" Width="120px"> Estimate Value 1</asp:label><asp:panel id="Panel2" style="Z-INDEX: 117; LEFT: 0px; POSITION: absolute; TOP: 32px" runat="server"
				BackColor="Desktop" Height="112px" Width="112px" BackImageUrl="Menu/v2.jpg"></asp:panel><asp:button id="BtnAdd" style="Z-INDEX: 119; LEFT: 128px; POSITION: absolute; TOP: 576px" tabIndex="7"
				runat="server" Font-Bold="True" Width="64px" Text="Add" Visible="False"></asp:button><asp:button id="BtnApp" style="Z-INDEX: 121; LEFT: 424px; POSITION: absolute; TOP: 392px" tabIndex="10"
				runat="server" Font-Bold="True" Width="66px" Text="Apply"></asp:button><asp:textbox id="TxtAppVal1" style="Z-INDEX: 122; LEFT: 568px; POSITION: absolute; TOP: 280px"
				tabIndex="11" runat="server" Height="24px" Width="96px" AutoPostBack="True" ReadOnly="True"></asp:textbox><asp:label id="Label13" style="Z-INDEX: 123; LEFT: 424px; POSITION: absolute; TOP: 288px" tabIndex="111"
				runat="server" Font-Bold="True" Height="15px" Width="120px"> Approved Value 1</asp:label><asp:label id="Label11" style="Z-INDEX: 124; LEFT: 552px; POSITION: absolute; TOP: 256px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:textbox id="Lsttyp" style="Z-INDEX: 125; LEFT: 528px; POSITION: absolute; TOP: 56px" tabIndex="4"
				runat="server" Height="20px" Width="120px" Font-Size="X-Small"></asp:textbox>
			<asp:label id="Label14" style="Z-INDEX: 126; LEFT: 128px; POSITION: absolute; TOP: 208px" tabIndex="105"
				runat="server" Width="112px" Height="16px" Font-Bold="True">Claim No</asp:label>
			<asp:textbox id="TxtVehClNo" style="Z-INDEX: 128; LEFT: 272px; POSITION: absolute; TOP: 200px"
				tabIndex="5" runat="server" Width="114px" Height="24px" AutoPostBack="True"></asp:textbox><asp:calendar id="Calendar1" style="Z-INDEX: 129; LEFT: 672px; POSITION: absolute; TOP: 200px"
				runat="server" BorderColor="#3366CC" ForeColor="#003399" BackColor="White" Height="120px" Width="152px" Font-Size="8pt" Font-Names="Verdana" BorderWidth="1px" DayNameFormat="FirstLetter"
				CellPadding="1">
				<TodayDayStyle ForeColor="White" BackColor="#99CCCC"></TodayDayStyle>
				<SelectorStyle ForeColor="#336666" BackColor="#99CCCC"></SelectorStyle>
				<NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF"></NextPrevStyle>
				<DayHeaderStyle Height="1px" ForeColor="#336666" BackColor="#99CCCC"></DayHeaderStyle>
				<SelectedDayStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedDayStyle>
				<TitleStyle Font-Size="10pt" Font-Bold="True" Height="25px" BorderWidth="1px" ForeColor="#CCCCFF"
					BorderStyle="Solid" BorderColor="#3366CC" BackColor="#003399"></TitleStyle>
				<WeekendDayStyle BackColor="#CCCCFF"></WeekendDayStyle>
				<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
			</asp:calendar><asp:label id="L1" style="Z-INDEX: 130; LEFT: 0px; POSITION: absolute; TOP: 608px" runat="server"
				Height="24px" Width="160px"></asp:label><asp:dropdownlist id="LstCom1" style="Z-INDEX: 131; LEFT: 248px; POSITION: absolute; TOP: 32px" tabIndex="1"
				runat="server" Height="24px" Width="328px" AutoPostBack="True"></asp:dropdownlist><asp:label id="Label15" style="Z-INDEX: 132; LEFT: 128px; POSITION: absolute; TOP: 32px" tabIndex="100"
				runat="server" Font-Bold="True" Height="16px" Width="64px" Font-Size="X-Small">Company</asp:label><asp:label id="Label17" style="Z-INDEX: 133; LEFT: 232px; POSITION: absolute; TOP: 40px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="Label18" style="Z-INDEX: 134; LEFT: 424px; POSITION: absolute; TOP: 256px" tabIndex="110"
				runat="server" Font-Bold="True" Height="16px" Width="104px">Police Report</asp:label><asp:label id="Label19" style="Z-INDEX: 135; LEFT: 672px; POSITION: absolute; TOP: 256px" tabIndex="108"
				runat="server" Font-Bold="True" Height="16px" Width="120px">Damage Imagers</asp:label><asp:label id="Label20" style="Z-INDEX: 136; LEFT: 128px; POSITION: absolute; TOP: 428px" tabIndex="126"
				runat="server" Font-Bold="True" Height="20px" Width="172px" Font-Size="X-Small">Pending Payment</asp:label>
			<DIV id="Div2" style="Z-INDEX: 138; LEFT: 128px; OVERFLOW: scroll; WIDTH: 786px; POSITION: absolute; TOP: 424px; HEIGHT: 132px"
				noWrap>
				<asp:datagrid id="Datagrid2" tabIndex="125" runat="server" Width="736px" Height="12px" BackColor="LightGoldenrodYellow"
					ForeColor="Black" BorderColor="Tan" Font-Size="Small" BorderWidth="1px" Font-Names="Tahoma"
					cellpadding="2" Headerstyle-BackColor="#8080C0" Headerstyle-Font-Name="Tahoma" Headerstyle-Font-Size="12"
					Headerstyle-Font-Bold="True" Font-Name="Tahoma" AutogenerateColumns="False" DataKeyField="id"
					GridLines="None">
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
						<asp:BoundColumn DataField="Final_Amt" HeaderText="Final Amt">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Final_Img" HeaderText="Final Img">
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
			<DIV id="Div1" style="Z-INDEX: 139; LEFT: 128px; OVERFLOW: scroll; WIDTH: 762px; POSITION: absolute; TOP: 96px; HEIGHT: 104px"
				noWrap><asp:datagrid id="Datagrid1" tabIndex="120" runat="server" BorderColor="#CCCCCC" BackColor="White"
					Height="8px" Width="720px" Font-Size="Small" Font-Names="Tahoma" BorderWidth="1px" DataKeyField="id"
					AutogenerateColumns="False" Font-Name="Tahoma" Headerstyle-Font-Bold="True" Headerstyle-Font-Size="12"
					Headerstyle-Font-Name="Tahoma" Headerstyle-BackColor="#8080C0" cellpadding="3" BorderStyle="None">
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
			<asp:label id="Label5" style="Z-INDEX: 140; LEFT: 824px; POSITION: absolute; TOP: 256px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="Label10" style="Z-INDEX: 141; LEFT: 552px; POSITION: absolute; TOP: 288px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="Label22" style="Z-INDEX: 142; LEFT: 672px; POSITION: absolute; TOP: 232px" tabIndex="113"
				runat="server" Font-Bold="True" Height="24px" Width="64px">Value 2</asp:label><asp:textbox id="TxtEstval2" style="Z-INDEX: 143; LEFT: 744px; POSITION: absolute; TOP: 232px"
				tabIndex="8" runat="server" Height="20px" Width="88px" Wrap="False" ReadOnly="True"></asp:textbox><asp:label id="Label23" style="Z-INDEX: 144; LEFT: 672px; POSITION: absolute; TOP: 288px" tabIndex="112"
				runat="server" Font-Bold="True" Height="24px" Width="64px">Value 2</asp:label><asp:textbox id="TxtAppVal2" style="Z-INDEX: 145; LEFT: 744px; POSITION: absolute; TOP: 280px"
				tabIndex="12" runat="server" Height="24px" Width="88px" Wrap="False" ReadOnly="True"></asp:textbox><asp:label id="Label21" style="Z-INDEX: 137; LEFT: 128px; POSITION: absolute; TOP: 80px" tabIndex="127"
				runat="server" Font-Bold="True" Height="16px" Width="192px" Font-Size="X-Small">Accident Payment History</asp:label><asp:label id="Label3" style="Z-INDEX: 146; LEFT: 736px; POSITION: absolute; TOP: 232px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="Label16" style="Z-INDEX: 116; LEFT: 256px; POSITION: absolute; TOP: 208px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="Label7" style="Z-INDEX: 147; LEFT: 552px; POSITION: absolute; TOP: 232px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="Label24" style="Z-INDEX: 148; LEFT: 736px; POSITION: absolute; TOP: 288px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label><asp:label id="Label25" style="Z-INDEX: 149; LEFT: 424px; POSITION: absolute; TOP: 344px" tabIndex="111"
				runat="server" Font-Bold="True" Height="15px" Width="120px">Remarks</asp:label><asp:textbox id="txtRem" style="Z-INDEX: 150; LEFT: 568px; POSITION: absolute; TOP: 344px" tabIndex="13"
				runat="server" Height="40px" Width="351px" AutoPostBack="True" TextMode="MultiLine"></asp:textbox><asp:textbox id="TxtFinalAmt" style="Z-INDEX: 151; LEFT: 272px; POSITION: absolute; TOP: 280px"
				tabIndex="7" runat="server" Height="24px" Width="112px"></asp:textbox><asp:label id="Label26" style="Z-INDEX: 152; LEFT: 128px; POSITION: absolute; TOP: 280px" tabIndex="105"
				runat="server" Font-Bold="True" Height="16px" Width="112px">Final Amount</asp:label>
			<asp:textbox id="TxtChqNo" style="Z-INDEX: 153; LEFT: 272px; POSITION: absolute; TOP: 344px"
				tabIndex="7" runat="server" Height="24px" Width="112px"></asp:textbox>
			<asp:label id="Label27" style="Z-INDEX: 154; LEFT: 128px; POSITION: absolute; TOP: 344px" tabIndex="105"
				runat="server" Font-Bold="True" Height="16px" Width="112px">Cheque No</asp:label>
			<asp:label id="Label29" style="Z-INDEX: 155; LEFT: 128px; POSITION: absolute; TOP: 232px" tabIndex="105"
				runat="server" Font-Bold="True" Height="16px" Width="128px">Salvage</asp:label>
			<asp:label id="Label28" style="Z-INDEX: 156; LEFT: 128px; POSITION: absolute; TOP: 256px" tabIndex="105"
				runat="server" Font-Bold="True" Height="16px" Width="128px">Final Image</asp:label>
			<asp:label id="Label30" style="Z-INDEX: 157; LEFT: 256px; POSITION: absolute; TOP: 232px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label>
			<asp:label id="Label31" style="Z-INDEX: 158; LEFT: 256px; POSITION: absolute; TOP: 256px" runat="server"
				Font-Bold="True" Height="16px" Width="16px">:</asp:label>
			<asp:dropdownlist id="Svgfg" style="Z-INDEX: 159; LEFT: 272px; POSITION: absolute; TOP: 224px" tabIndex="2"
				runat="server" Height="16px" Width="112px" Font-Size="X-Small" AutoPostBack="True"></asp:dropdownlist>
			<asp:dropdownlist id="Flfg" style="Z-INDEX: 160; LEFT: 272px; POSITION: absolute; TOP: 248px" tabIndex="2"
				runat="server" Height="16px" Width="112px" Font-Size="X-Small" AutoPostBack="True"></asp:dropdownlist>
			<asp:label id="Label32" style="Z-INDEX: 161; LEFT: 128px; POSITION: absolute; TOP: 376px" tabIndex="105"
				runat="server" Font-Bold="True" Height="16px" Width="128px">Process Complete</asp:label>
			<asp:dropdownlist id="Cfg" style="Z-INDEX: 162; LEFT: 272px; POSITION: absolute; TOP: 376px" tabIndex="2"
				runat="server" Height="16px" Width="112px" Font-Size="X-Small" AutoPostBack="True"></asp:dropdownlist>
			<asp:textbox id="Txtpfg" style="Z-INDEX: 163; LEFT: 568px; POSITION: absolute; TOP: 248px" tabIndex="8"
				runat="server" Height="20px" Width="32px" Wrap="False" ReadOnly="True"></asp:textbox>
			<asp:textbox id="Txtdfg" style="Z-INDEX: 164; LEFT: 800px; POSITION: absolute; TOP: 256px" tabIndex="8"
				runat="server" Height="20px" Width="32px" Wrap="False" ReadOnly="True"></asp:textbox>
			<asp:label id="Label33" style="Z-INDEX: 165; LEFT: 256px; POSITION: absolute; TOP: 352px" runat="server"
				Width="16px" Height="16px" Font-Bold="True">:</asp:label>
			<asp:label id="Label34" style="Z-INDEX: 166; LEFT: 552px; POSITION: absolute; TOP: 312px" runat="server"
				Width="16px" Height="16px" Font-Bold="True">:</asp:label>
			<asp:label id="Label35" style="Z-INDEX: 167; LEFT: 592px; POSITION: absolute; TOP: 32px" tabIndex="101"
				runat="server" Width="120px" Height="12px" Font-Bold="True" Font-Size="X-Small">Commencement Date</asp:label>
			<asp:textbox id="TxtSdt" style="Z-INDEX: 168; LEFT: 728px; POSITION: absolute; TOP: 32px" tabIndex="4"
				runat="server" Width="96px" Height="20px" Font-Size="X-Small"></asp:textbox>
			<asp:label id="Label36" style="Z-INDEX: 169; LEFT: 656px; POSITION: absolute; TOP: 64px" tabIndex="101"
				runat="server" Width="88px" Height="12px" Font-Bold="True" Font-Size="X-Small">Total Premium</asp:label>
			<asp:textbox id="TxtToTPre" style="Z-INDEX: 170; LEFT: 752px; POSITION: absolute; TOP: 56px"
				tabIndex="4" runat="server" Width="114px" Height="20px" Font-Size="X-Small"></asp:textbox>
			<asp:label id="Label37" style="Z-INDEX: 171; LEFT: 552px; POSITION: absolute; TOP: 344px" runat="server"
				Width="16px" Height="16px" Font-Bold="True">:</asp:label>
			<asp:label id="Label38" style="Z-INDEX: 172; LEFT: 128px; POSITION: absolute; TOP: 312px" tabIndex="105"
				runat="server" Width="112px" Height="16px" Font-Bold="True">Payment Date</asp:label>
			<asp:textbox id="TxtPaydt" style="Z-INDEX: 173; LEFT: 272px; POSITION: absolute; TOP: 312px"
				tabIndex="7" runat="server" Width="80px" Height="24px"></asp:textbox>
			<asp:imagebutton id="ImgBtn2" style="Z-INDEX: 174; LEFT: 352px; POSITION: absolute; TOP: 312px" runat="server"
				Width="24px" Height="24px" ImageUrl="iCO\Cal1.jpg"></asp:imagebutton>
			<asp:calendar id="Calendar2" style="Z-INDEX: 175; LEFT: 376px; POSITION: absolute; TOP: 312px"
				runat="server" Width="160px" Height="96px" BackColor="White" ForeColor="#003399" BorderColor="#3366CC"
				Font-Size="8pt" CellPadding="1" DayNameFormat="FirstLetter" BorderWidth="1px" Font-Names="Verdana">
				<TodayDayStyle ForeColor="White" BackColor="#99CCCC"></TodayDayStyle>
				<SelectorStyle ForeColor="#336666" BackColor="#99CCCC"></SelectorStyle>
				<NextPrevStyle Font-Size="8pt" ForeColor="#CCCCFF"></NextPrevStyle>
				<DayHeaderStyle Height="1px" ForeColor="#336666" BackColor="#99CCCC"></DayHeaderStyle>
				<SelectedDayStyle Font-Bold="True" ForeColor="#CCFF99" BackColor="#009999"></SelectedDayStyle>
				<TitleStyle Font-Size="10pt" Font-Bold="True" Height="25px" BorderWidth="1px" ForeColor="#CCCCFF"
					BorderStyle="Solid" BorderColor="#3366CC" BackColor="#003399"></TitleStyle>
				<WeekendDayStyle BackColor="#CCCCFF"></WeekendDayStyle>
				<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
			</asp:calendar>
			<asp:label id="Label39" style="Z-INDEX: 176; LEFT: 256px; POSITION: absolute; TOP: 312px" runat="server"
				Width="16px" Height="16px" Font-Bold="True">:</asp:label>
			<asp:label id="Label40" style="Z-INDEX: 177; LEFT: 424px; POSITION: absolute; TOP: 320px" tabIndex="111"
				runat="server" Width="120px" Height="24px" BackColor="#80FFFF" Font-Bold="True" ForeColor="Blue"
				BorderColor="Yellow">Cost Amount</asp:label>
			<asp:textbox id="TxtCstAmt" style="Z-INDEX: 178; LEFT: 568px; POSITION: absolute; TOP: 320px"
				tabIndex="11" runat="server" Width="96px" Height="24px" BackColor="Yellow" Font-Bold="True"
				ForeColor="Black" AutoPostBack="True"></asp:textbox>
			<asp:Button id="Button1" style="Z-INDEX: 179; LEFT: 696px; POSITION: absolute; TOP: 392px" runat="server"
				Width="156px" Height="24px" Text="Payment Detail"></asp:Button>
			<CR:CrystalReportViewer id="CrystalReportViewer1" style="Z-INDEX: 180; LEFT: 888px; POSITION: absolute; TOP: 336px"
				runat="server" Visible="False" Width="350px" Height="50px"></CR:CrystalReportViewer>
			<asp:imagebutton id="ImgBtn1" style="Z-INDEX: 127; LEFT: 648px; POSITION: absolute; TOP: 200px" runat="server"
				Width="24px" Height="24px" ImageUrl="iCO\Cal1.jpg"></asp:imagebutton></form>
	</body>
</HTML>
