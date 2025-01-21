<%@ Page Language="vb" AutoEventWireup="false" Codebehind="PrettyCashInword.aspx.vb" Inherits="Insu.PrettyCashInword" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Outword</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body leftMargin="0" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<DIV id="Div1" style="Z-INDEX: 113; LEFT: 264px; OVERFLOW: scroll; WIDTH: 328px; POSITION: absolute; TOP: 56px; HEIGHT: 160px"><asp:datagrid id="MyDatagrid1" runat="server" Height="32px" BorderWidth="1px" BorderStyle="None"
					Font-Names="Calibri" DataKeyField="id" OnDeleteCommand="MyDataGrid_DeleteCommand" Width="312px" OnUpdateCommand="MyDataGrid_UpdateCommand" OnCancelcommand="MyDataGrid_Cancel" OnEditcommand="MyDataGrid_EditCommand"
					AutogenerateColumns="False" BorderColor="#CC9966" Font-Size="12pt" Font-Name="Calibri" BackColor="White" Headerstyle-Font-Bold="True" Headerstyle-Font-Size="10" Headerstyle-Font-Name="Calibri" Headerstyle-BackColor="#8080C0"
					cellpadding="0">
					<SelectedItemStyle Font-Size="Smaller" Font-Bold="True" ForeColor="#663399" BackColor="#FFCC66"></SelectedItemStyle>
					<EditItemStyle Font-Size="Smaller"></EditItemStyle>
					<AlternatingItemStyle Font-Size="Smaller"></AlternatingItemStyle>
					<ItemStyle Font-Size="Smaller" ForeColor="#330099" BackColor="White"></ItemStyle>
					<HeaderStyle Font-Size="10pt" Font-Names="Calibri" Font-Bold="True" ForeColor="#FFFFCC" BackColor="#990000"></HeaderStyle>
					<FooterStyle ForeColor="#330099" BackColor="#FFFFCC"></FooterStyle>
					<Columns>
						<asp:BoundColumn DataField="Imp_Com" ReadOnly="True" HeaderText="Company">
							<HeaderStyle Width="0.5in"></HeaderStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Imp_Amt" ReadOnly="True" HeaderText="Imprest">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Imp_Pay" HeaderText="Payment">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Center" ForeColor="#330099" BackColor="#FFFFCC"></PagerStyle>
				</asp:datagrid></DIV>
			<DIV id="Div3" style="Z-INDEX: 114; LEFT: 592px; OVERFLOW: scroll; WIDTH: 328px; POSITION: absolute; TOP: 56px; HEIGHT: 160px"><asp:datagrid id="Datagrid3" runat="server" Height="32px" BorderWidth="1px" BorderStyle="None"
					Font-Names="Calibri" DataKeyField="id" OnDeleteCommand="MyDataGrid_DeleteCommand" Width="312px" OnUpdateCommand="MyDataGrid_UpdateCommand" OnCancelcommand="MyDataGrid_Cancel" OnEditcommand="MyDataGrid_EditCommand"
					AutogenerateColumns="False" BorderColor="#CC9966" Font-Size="12pt" Font-Name="Calibri" BackColor="White" Headerstyle-Font-Bold="True" Headerstyle-Font-Size="10" Headerstyle-Font-Name="Calibri" Headerstyle-BackColor="#8080C0"
					cellpadding="0">
					<SelectedItemStyle Font-Size="Smaller" Font-Names="Calibri" Font-Bold="True" ForeColor="#663399" BackColor="#FFCC66"></SelectedItemStyle>
					<EditItemStyle Font-Size="Smaller" Font-Names="Calibri"></EditItemStyle>
					<AlternatingItemStyle Font-Size="12pt" Font-Names="Calibri"></AlternatingItemStyle>
					<ItemStyle Font-Size="12pt" Font-Names="Calibri" ForeColor="#330099" BackColor="White"></ItemStyle>
					<HeaderStyle Font-Size="10pt" Font-Names="Calibri" Font-Bold="True" ForeColor="#FFFFCC" BackColor="#990000"></HeaderStyle>
					<FooterStyle ForeColor="#330099" BackColor="#FFFFCC"></FooterStyle>
					<Columns>
						<asp:BoundColumn DataField="Raw_ItmCode" HeaderText="Voucher No">
							<ItemStyle Font-Size="Smaller" Font-Names="Calibri" Width="50px"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Raw_Des" HeaderText="Emp #">
							<ItemStyle Font-Size="Smaller" Font-Names="Calibri" Width="50px"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Mas_Bnkcode" HeaderText="Amount">
							<ItemStyle Font-Size="Smaller" Font-Names="Calibri" HorizontalAlign="Right" Width="50px"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Mas_InTrm" HeaderText="Date">
							<ItemStyle Font-Size="Smaller" Font-Names="Calibri" Width="70px"></ItemStyle>
						</asp:BoundColumn>
						<asp:TemplateColumn HeaderText="Select">
							<ItemTemplate>
								<asp:CheckBox id="myCheckbox" Runat="server" Width="50px"></asp:CheckBox>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:BoundColumn Visible="False" DataField="Mas_Amt" HeaderText="Amount">
							<ItemStyle Font-Size="Smaller" Font-Names="Calibri" Width="70px"></ItemStyle>
						</asp:BoundColumn>
					</Columns>
					<PagerStyle Font-Size="X-Small" Font-Names="Calibri" HorizontalAlign="Center" ForeColor="#330099"
						BackColor="#FFFFCC"></PagerStyle>
				</asp:datagrid></DIV>
			<asp:label id="Label12" style="Z-INDEX: 124; LEFT: 896px; POSITION: absolute; TOP: 832px" runat="server"
				Height="24px" Width="56px" Visible="False">Percentage</asp:label><asp:dropdownlist id="LstFlag2" style="Z-INDEX: 122; LEFT: 824px; POSITION: absolute; TOP: 744px"
				tabIndex="2" runat="server" Height="16px" Width="56px" Visible="False" AutoPostBack="True"></asp:dropdownlist><asp:label id="Label11" style="Z-INDEX: 121; LEFT: 712px; POSITION: absolute; TOP: 816px" runat="server"
				Height="24px" Width="104px" Visible="False">Price Adjestment</asp:label><asp:dropdownlist id="LstVat" style="Z-INDEX: 120; LEFT: 840px; POSITION: absolute; TOP: 800px" tabIndex="2"
				runat="server" Height="16px" Width="56px" Visible="False" AutoPostBack="True"></asp:dropdownlist><asp:dropdownlist id="LstCode" style="Z-INDEX: 119; LEFT: 896px; POSITION: absolute; TOP: 792px" tabIndex="2"
				runat="server" Height="16px" Width="176px" Visible="False"></asp:dropdownlist><asp:label id="Label9" style="Z-INDEX: 118; LEFT: 712px; POSITION: absolute; TOP: 848px" runat="server"
				Height="24px" Width="64px" Visible="False">Create By</asp:label><asp:button id="BtnSubmit" style="Z-INDEX: 115; LEFT: 824px; POSITION: absolute; TOP: 288px"
				tabIndex="7" runat="server" Font-Names="Calibri" Width="89px" Font-Size="X-Small" Font-Bold="True" Text="Apply"></asp:button><asp:label id="Label5" style="Z-INDEX: 111; LEFT: 264px; POSITION: absolute; TOP: 320px" runat="server"
				Height="16px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" BackColor="Desktop" ForeColor="White">5000/-</asp:label><asp:panel id="Panel5" style="Z-INDEX: 100; LEFT: 0px; POSITION: absolute; TOP: 152px" runat="server"
				Height="528px" Width="104px" BackColor="Desktop" BackImageUrl="Menu/Audit.gif"></asp:panel><asp:panel id="Panel1" style="Z-INDEX: 101; LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server"
				Height="32px" Width="920px" BorderColor="Transparent" BackColor="Desktop" Font-Bold="True" ForeColor="White" HorizontalAlign="Left" Enabled="False">
				<asp:textbox id="TxtExcAmt1" style="Z-INDEX: 212; LEFT: 1040px; POSITION: absolute; TOP: 480px"
					runat="server" Font-Names="Calibri" Width="88px" Font-Size="X-Small" BackColor="#FFE0C0"
					Visible="False" ReadOnly="True"></asp:textbox>
				<asp:label id="pnd" style="Z-INDEX: 235; LEFT: 592px; POSITION: absolute; TOP: 288px" runat="server"
					Height="17px" Font-Names="Calibri" Width="64px" Font-Size="Small" BackColor="White" Visible="False"
					Font-Bold="True" ForeColor="Navy">Pending</asp:label>
			</asp:panel><asp:panel id="Panel2" style="Z-INDEX: 102; LEFT: 0px; POSITION: absolute; TOP: 32px" runat="server"
				Height="120px" Width="104px" BackColor="Desktop" BackImageUrl="Menu/AssetI.gif"></asp:panel><asp:textbox id="TxtInvDt" style="Z-INDEX: 103; LEFT: 112px; POSITION: absolute; TOP: 88px" tabIndex="3"
				runat="server" Height="20px" Font-Names="Calibri" Width="80px" Font-Size="X-Small"></asp:textbox><asp:label id="Label1" style="Z-INDEX: 104; LEFT: 112px; POSITION: absolute; TOP: 72px" runat="server"
				Height="16px" Font-Names="Calibri" Width="104px" Font-Size="X-Small">Voucher Date</asp:label><asp:dropdownlist id="Lstcom" style="Z-INDEX: 105; LEFT: 680px; POSITION: absolute; TOP: 232px" tabIndex="2"
				runat="server" Height="16px" Font-Names="Calibri" Width="240px" Font-Size="X-Small" AutoPostBack="True"></asp:dropdownlist><asp:dropdownlist id="LstInvNo" style="Z-INDEX: 106; LEFT: 112px; POSITION: absolute; TOP: 184px"
				tabIndex="1" runat="server" Height="40px" Font-Names="Calibri" Width="80px" Font-Size="X-Small" Visible="False" AutoPostBack="True"></asp:dropdownlist><asp:label id="Invoice" style="Z-INDEX: 107; LEFT: 112px; POSITION: absolute; TOP: 160px" runat="server"
				Height="16px" Font-Names="Calibri" Width="104px" Font-Size="X-Small">Voucher No</asp:label><asp:label id="Label2" style="Z-INDEX: 108; LEFT: 592px; POSITION: absolute; TOP: 232px" runat="server"
				Height="24px" Font-Names="Calibri" Width="96px" Font-Size="X-Small">Employee</asp:label><asp:textbox id="TxtPoNo" style="Z-INDEX: 109; LEFT: 688px; POSITION: absolute; TOP: 752px" tabIndex="4"
				runat="server" Height="24px" Font-Names="Calibri" Width="136px" Font-Size="X-Small" Visible="False"></asp:textbox><asp:label id="Label3" style="Z-INDEX: 110; LEFT: 1040px; POSITION: absolute; TOP: 200px" runat="server"
				Height="24px" Width="128px" Visible="False">Purchase Order NO</asp:label><asp:label id="Label7" style="Z-INDEX: 112; LEFT: 112px; POSITION: absolute; TOP: 296px" runat="server"
				Height="17px" Font-Names="Calibri" Width="72px" Font-Size="X-Small">Description</asp:label><asp:textbox id="TxtInvNo" style="Z-INDEX: 116; LEFT: 112px; POSITION: absolute; TOP: 184px"
				runat="server" Height="20px" Font-Names="Calibri" Width="72px" Font-Size="X-Small"></asp:textbox><asp:textbox id="TxtPer" style="Z-INDEX: 123; LEFT: 736px; POSITION: absolute; TOP: 784px" runat="server"
				Width="52px" Visible="False"></asp:textbox><asp:label id="Label13" style="Z-INDEX: 127; LEFT: 112px; POSITION: absolute; TOP: 112px" runat="server"
				Height="24px" Font-Names="Calibri" Width="88px" Font-Size="X-Small">Last Voucher No</asp:label><asp:textbox id="TxtLInvNo" style="Z-INDEX: 128; LEFT: 112px; POSITION: absolute; TOP: 136px"
				runat="server" Font-Names="Calibri" Width="72px" Font-Size="X-Small" BackColor="#FFE0C0" ReadOnly="True"></asp:textbox><asp:dropdownlist id="LstTT" style="Z-INDEX: 129; LEFT: 776px; POSITION: absolute; TOP: 848px" tabIndex="2"
				runat="server" Height="16px" Width="56px" Visible="False" AutoPostBack="True"></asp:dropdownlist><asp:label id="Label15" style="Z-INDEX: 130; LEFT: 704px; POSITION: absolute; TOP: 896px" runat="server"
				Height="24px" Width="128px" Visible="False">Special Vat Invoice</asp:label><asp:dropdownlist id="Lstvat1" style="Z-INDEX: 131; LEFT: 856px; POSITION: absolute; TOP: 896px" tabIndex="2"
				runat="server" Height="16px" Width="56px" Visible="False" AutoPostBack="True"></asp:dropdownlist><asp:button id="BtnAdd" style="Z-INDEX: 125; LEFT: 112px; POSITION: absolute; TOP: 504px" runat="server"
				Height="22px" Width="64px" Font-Bold="True" Text="Add"></asp:button><asp:button id="BtnSave" style="Z-INDEX: 126; LEFT: 200px; POSITION: absolute; TOP: 504px" runat="server"
				Height="22px" Width="64px" Font-Bold="True" Text="Save"></asp:button><asp:button id="BttNext" style="Z-INDEX: 117; LEFT: 280px; POSITION: absolute; TOP: 504px" tabIndex="9"
				runat="server" Height="22px" Width="64px" Visible="False" Font-Bold="True" Text="Next"></asp:button><asp:label id="Label16" style="Z-INDEX: 132; LEFT: 104px; POSITION: absolute; TOP: 536px" runat="server"
				Height="12px" Font-Names="Calibri" Width="809px" Font-Size="X-Small" BackColor="Desktop" ForeColor="White"> Transaction</asp:label><asp:panel id="Panel7" style="Z-INDEX: 133; LEFT: 0px; POSITION: absolute; TOP: 672px" runat="server"
				Height="16px" Width="912px" BackColor="Desktop" Font-Bold="True"></asp:panel><asp:label id="Label10" style="Z-INDEX: 134; LEFT: 264px; POSITION: absolute; TOP: 40px" runat="server"
				Height="12px" Font-Names="Calibri" Width="328px" Font-Size="X-Small" BackColor="Desktop" ForeColor="White">Imprest</asp:label><asp:panel id="Panel8" style="Z-INDEX: 135; LEFT: 0px; POSITION: absolute; TOP: 760px" runat="server"
				Height="16px" Width="880px" BackColor="Desktop" Font-Bold="True"></asp:panel><asp:label id="Label17" style="Z-INDEX: 136; LEFT: 592px; POSITION: absolute; TOP: 256px" runat="server"
				Height="16px" Font-Names="Calibri" Width="72px" Font-Size="X-Small">Department</asp:label><asp:dropdownlist id="Deplist" style="Z-INDEX: 137; LEFT: 680px; POSITION: absolute; TOP: 256px" tabIndex="2"
				runat="server" Height="16px" Font-Names="Calibri" Width="240px" Font-Size="X-Small" AutoPostBack="True"></asp:dropdownlist><asp:label id="Label18" style="Z-INDEX: 138; LEFT: 112px; POSITION: absolute; TOP: 264px" runat="server"
				Height="16px" Font-Names="Calibri" Width="104px" Font-Size="X-Small">Search Employee</asp:label><asp:textbox id="txtEmpNo" style="Z-INDEX: 139; LEFT: 264px; POSITION: absolute; TOP: 264px"
				runat="server" Height="20px" Font-Names="Calibri" Width="48px" Font-Size="X-Small"></asp:textbox><asp:button id="BttEmpNo" style="Z-INDEX: 140; LEFT: 312px; POSITION: absolute; TOP: 264px"
				tabIndex="7" runat="server" Height="20px" Font-Names="Calibri" Width="48px" Font-Size="X-Small" Font-Bold="True" Text="Go"></asp:button><asp:textbox id="TxtEpfNo" style="Z-INDEX: 141; LEFT: 1040px; POSITION: absolute; TOP: 288px"
				runat="server" Width="48px" Visible="False"></asp:textbox><asp:textbox id="TxtDepNo" style="Z-INDEX: 142; LEFT: 1040px; POSITION: absolute; TOP: 264px"
				runat="server" Height="24px" Width="48px" Visible="False"></asp:textbox><asp:label id="Label19" style="Z-INDEX: 143; LEFT: 592px; POSITION: absolute; TOP: 40px" runat="server"
				Height="12px" Font-Names="Calibri" Width="328px" Font-Size="X-Small" BackColor="Desktop" ForeColor="White">Pending Vouchers</asp:label><asp:label id="Label20" style="Z-INDEX: 144; LEFT: 112px; POSITION: absolute; TOP: 216px" runat="server"
				Height="12px" Font-Names="Calibri" Width="808px" Font-Size="X-Small" BackColor="Desktop" ForeColor="White">Payment</asp:label><asp:textbox id="TxtDes" style="Z-INDEX: 145; LEFT: 264px; POSITION: absolute; TOP: 296px" tabIndex="3"
				runat="server" Height="20px" Font-Names="Calibri" Width="320px" Font-Size="X-Small"></asp:textbox><asp:label id="Label21" style="Z-INDEX: 146; LEFT: 312px; POSITION: absolute; TOP: 320px" runat="server"
				Height="16px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" BackColor="Desktop" ForeColor="White">2000/-</asp:label><asp:label id="Label22" style="Z-INDEX: 147; LEFT: 360px; POSITION: absolute; TOP: 320px" runat="server"
				Height="16px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" BackColor="Desktop" ForeColor="White">1000/-</asp:label><asp:label id="Label23" style="Z-INDEX: 148; LEFT: 408px; POSITION: absolute; TOP: 320px" runat="server"
				Height="16px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" BackColor="Desktop" ForeColor="White">500/-</asp:label><asp:label id="Label24" style="Z-INDEX: 149; LEFT: 456px; POSITION: absolute; TOP: 320px" runat="server"
				Height="16px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" BackColor="Desktop" ForeColor="White">100/-</asp:label><asp:label id="Label25" style="Z-INDEX: 150; LEFT: 504px; POSITION: absolute; TOP: 320px" runat="server"
				Height="16px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" BackColor="Desktop" ForeColor="White">50/-</asp:label><asp:label id="Label26" style="Z-INDEX: 151; LEFT: 552px; POSITION: absolute; TOP: 320px" runat="server"
				Height="16px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" BackColor="Desktop" ForeColor="White">20/-</asp:label><asp:label id="Label27" style="Z-INDEX: 152; LEFT: 600px; POSITION: absolute; TOP: 320px" runat="server"
				Height="16px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" BackColor="Desktop" ForeColor="White">10/-</asp:label><asp:label id="Label28" style="Z-INDEX: 153; LEFT: 648px; POSITION: absolute; TOP: 320px" runat="server"
				Height="16px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" BackColor="Desktop" ForeColor="White">5/-</asp:label><asp:label id="Label29" style="Z-INDEX: 154; LEFT: 696px; POSITION: absolute; TOP: 320px" runat="server"
				Height="16px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" BackColor="Desktop" ForeColor="White">2/-</asp:label><asp:label id="Label30" style="Z-INDEX: 155; LEFT: 744px; POSITION: absolute; TOP: 320px" runat="server"
				Height="16px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" BackColor="Desktop" ForeColor="White">1/-</asp:label><asp:textbox id="TxtQ1" style="Z-INDEX: 156; LEFT: 264px; POSITION: absolute; TOP: 416px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtQ2" style="Z-INDEX: 157; LEFT: 312px; POSITION: absolute; TOP: 416px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtQ3" style="Z-INDEX: 158; LEFT: 360px; POSITION: absolute; TOP: 416px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtQ4" style="Z-INDEX: 159; LEFT: 408px; POSITION: absolute; TOP: 416px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtQ5" style="Z-INDEX: 160; LEFT: 456px; POSITION: absolute; TOP: 416px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtQ6" style="Z-INDEX: 161; LEFT: 504px; POSITION: absolute; TOP: 416px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtQ7" style="Z-INDEX: 162; LEFT: 552px; POSITION: absolute; TOP: 416px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtQ8" style="Z-INDEX: 163; LEFT: 600px; POSITION: absolute; TOP: 416px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtQ9" style="Z-INDEX: 164; LEFT: 648px; POSITION: absolute; TOP: 416px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtQ10" style="Z-INDEX: 165; LEFT: 696px; POSITION: absolute; TOP: 416px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtQ11" style="Z-INDEX: 166; LEFT: 744px; POSITION: absolute; TOP: 416px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:label id="Label4" style="Z-INDEX: 167; LEFT: 112px; POSITION: absolute; TOP: 352px" runat="server"
				Height="17px" Font-Names="Calibri" Width="72px" Font-Size="X-Small">Cash In Box</asp:label><asp:label id="Label31" style="Z-INDEX: 168; LEFT: 112px; POSITION: absolute; TOP: 40px" runat="server"
				Height="16px" Font-Names="Calibri" Width="136px" Font-Size="X-Small" BackColor="Desktop" ForeColor="White">Payment Vouchers</asp:label><asp:label id="Label32" style="Z-INDEX: 169; LEFT: 824px; POSITION: absolute; TOP: 320px" runat="server"
				Height="16px" Font-Names="Calibri" Width="88px" Font-Size="X-Small" BackColor="Desktop" ForeColor="White">Amount(Rs)</asp:label><asp:button id="BtnEdit" style="Z-INDEX: 170; LEFT: 256px; POSITION: absolute; TOP: 784px" runat="server"
				Height="22px" Width="64px" Visible="False" Font-Bold="True" Text="Add"></asp:button><asp:textbox id="TxtAmt" style="Z-INDEX: 171; LEFT: 824px; POSITION: absolute; TOP: 416px" runat="server"
				Font-Names="Calibri" Width="88px" Font-Size="X-Small" BackColor="#FFE0C0" ReadOnly="True"></asp:textbox><asp:textbox id="TxtDepNam" style="Z-INDEX: 172; LEFT: 1040px; POSITION: absolute; TOP: 320px"
				runat="server" Width="48px" Visible="False"></asp:textbox><asp:textbox id="TxtCom" style="Z-INDEX: 173; LEFT: 1040px; POSITION: absolute; TOP: 344px" runat="server"
				Width="48px" Visible="False"></asp:textbox><asp:textbox id="TxtEmpNam" style="Z-INDEX: 174; LEFT: 1040px; POSITION: absolute; TOP: 240px"
				runat="server" Width="184px" Visible="False"></asp:textbox>
			<DIV id="Div2" style="Z-INDEX: 175; LEFT: 104px; OVERFLOW: scroll; WIDTH: 824px; POSITION: absolute; TOP: 552px; HEIGHT: 112px"><asp:datagrid id="Datagrid1" runat="server" Height="12px" BorderWidth="1px" BorderStyle="None"
					Font-Names="Calibri" DataKeyField="id" OnDeleteCommand="MyDataGrid_DeleteCommand" Width="726px" OnUpdateCommand="MyDataGrid_UpdateCommand" OnCancelcommand="MyDataGrid_Cancel" OnEditcommand="MyDataGrid_EditCommand"
					AutogenerateColumns="False" BorderColor="#CC9966" Font-Size="12pt" Font-Name="Calibri" BackColor="White" Headerstyle-Font-Bold="True" Headerstyle-Font-Size="10" Headerstyle-Font-Name="Calibri" Headerstyle-BackColor="#8080C0"
					cellpadding="0">
					<SelectedItemStyle Font-Size="Smaller" Font-Bold="True" ForeColor="#663399" BackColor="#FFCC66"></SelectedItemStyle>
					<EditItemStyle Font-Size="Smaller"></EditItemStyle>
					<AlternatingItemStyle Font-Size="Smaller"></AlternatingItemStyle>
					<ItemStyle Font-Size="Smaller" ForeColor="#330099" BackColor="White"></ItemStyle>
					<HeaderStyle Font-Size="10pt" Font-Names="Calibri" Font-Bold="True" ForeColor="#FFFFCC" BackColor="#990000"></HeaderStyle>
					<FooterStyle ForeColor="#330099" BackColor="#FFFFCC"></FooterStyle>
					<Columns>
						<asp:BoundColumn DataField="Out_Vno" ReadOnly="True" HeaderText="Vou #">
							<HeaderStyle Width="1.0in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Emp_no" ReadOnly="True" HeaderText="Emp #">
							<HeaderStyle Width="1.0in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Emp_Nam" HeaderText="Employee">
							<HeaderStyle Width="1.2in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Emp_Dep" HeaderText="Department">
							<HeaderStyle Width="1.0in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Emp_Com" HeaderText="Company">
							<HeaderStyle Width="0.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="In_PayAmt" HeaderText="Payment Amt">
							<HeaderStyle Width="1.0in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="In_PedAmt" HeaderText="Pending Amt">
							<HeaderStyle Width="1.0in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="In_ChgAmt" HeaderText="Change">
							<HeaderStyle Width="1.0in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="In_CashAmt" HeaderText="Cash Amt">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Center" ForeColor="#330099" BackColor="#FFFFCC"></PagerStyle>
				</asp:datagrid></DIV>
			<asp:label id="Label6" style="Z-INDEX: 176; LEFT: 112px; POSITION: absolute; TOP: 416px" runat="server"
				Height="17px" Font-Names="Calibri" Width="152px" Font-Size="X-Small" Font-Bold="True">Change From Customer</asp:label><asp:textbox id="Q1" style="Z-INDEX: 177; LEFT: 264px; POSITION: absolute; TOP: 344px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" BackColor="#80FF80" ReadOnly="True"></asp:textbox><asp:textbox id="Q2" style="Z-INDEX: 178; LEFT: 312px; POSITION: absolute; TOP: 344px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" BackColor="#80FF80" ReadOnly="True"></asp:textbox><asp:textbox id="Q3" style="Z-INDEX: 179; LEFT: 360px; POSITION: absolute; TOP: 344px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" BackColor="#80FF80" ReadOnly="True"></asp:textbox><asp:textbox id="Q4" style="Z-INDEX: 180; LEFT: 408px; POSITION: absolute; TOP: 344px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" BackColor="#80FF80" ReadOnly="True"></asp:textbox><asp:textbox id="Q5" style="Z-INDEX: 181; LEFT: 456px; POSITION: absolute; TOP: 344px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" BackColor="#80FF80" ReadOnly="True"></asp:textbox><asp:textbox id="Q6" style="Z-INDEX: 182; LEFT: 504px; POSITION: absolute; TOP: 344px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" BackColor="#80FF80" ReadOnly="True"></asp:textbox><asp:textbox id="Q7" style="Z-INDEX: 183; LEFT: 552px; POSITION: absolute; TOP: 344px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" BackColor="#80FF80" ReadOnly="True"></asp:textbox><asp:textbox id="Q8" style="Z-INDEX: 184; LEFT: 600px; POSITION: absolute; TOP: 344px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" BackColor="#80FF80" ReadOnly="True"></asp:textbox><asp:textbox id="Q9" style="Z-INDEX: 185; LEFT: 648px; POSITION: absolute; TOP: 344px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" BackColor="#80FF80" ReadOnly="True"></asp:textbox><asp:textbox id="Q10" style="Z-INDEX: 186; LEFT: 696px; POSITION: absolute; TOP: 344px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" BackColor="#80FF80" ReadOnly="True"></asp:textbox><asp:textbox id="Q11" style="Z-INDEX: 187; LEFT: 744px; POSITION: absolute; TOP: 344px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" BackColor="#80FF80" ReadOnly="True"></asp:textbox><asp:textbox id="TxtQVal" style="Z-INDEX: 188; LEFT: 824px; POSITION: absolute; TOP: 344px" runat="server"
				Font-Names="Calibri" Width="88px" Font-Size="X-Small" BackColor="#80FF80" ReadOnly="True"></asp:textbox><asp:textbox id="TxtAmt1" style="Z-INDEX: 189; LEFT: 1040px; POSITION: absolute; TOP: 384px"
				runat="server" Font-Names="Calibri" Width="88px" Font-Size="X-Small" BackColor="#FFE0C0" Visible="False" ReadOnly="True"></asp:textbox><asp:label id="Label8" style="Z-INDEX: 190; LEFT: 112px; POSITION: absolute; TOP: 232px" runat="server"
				Height="24px" Font-Names="Calibri" Width="96px" Font-Size="X-Small">Company</asp:label><asp:dropdownlist id="LstCom1" style="Z-INDEX: 191; LEFT: 264px; POSITION: absolute; TOP: 232px" tabIndex="2"
				runat="server" Height="16px" Font-Names="Calibri" Width="320px" Font-Size="X-Small" AutoPostBack="True"></asp:dropdownlist><asp:label id="LblMsg" style="Z-INDEX: 192; LEFT: 1048px; POSITION: absolute; TOP: 448px" runat="server"
				Height="24px" Width="128px" Visible="False">Label</asp:label><asp:textbox id="TxtPAmt" style="Z-INDEX: 193; LEFT: 824px; POSITION: absolute; TOP: 392px" runat="server"
				Font-Names="Calibri" Width="88px" Font-Size="X-Small" BackColor="#FFE0C0" ReadOnly="True"></asp:textbox><asp:textbox id="TxtPAmt1" style="Z-INDEX: 194; LEFT: 1040px; POSITION: absolute; TOP: 416px"
				runat="server" Font-Names="Calibri" Width="88px" Font-Size="X-Small" BackColor="#FFE0C0" Visible="False" ReadOnly="True" DESIGNTIMEDRAGDROP="2068"></asp:textbox><asp:textbox id="TxtPayAmt" style="Z-INDEX: 195; LEFT: 496px; POSITION: absolute; TOP: 264px"
				runat="server" Height="20px" Font-Names="Calibri" Width="89px" Font-Size="X-Small" ReadOnly="True"></asp:textbox><asp:textbox id="TxtPayAmt1" style="Z-INDEX: 196; LEFT: 824px; POSITION: absolute; TOP: 368px"
				runat="server" Font-Names="Calibri" Width="88px" Font-Size="X-Small" BackColor="#FFE0C0" ReadOnly="True"></asp:textbox><asp:label id="Label34" style="Z-INDEX: 197; LEFT: 368px; POSITION: absolute; TOP: 264px" runat="server"
				Height="16px" Font-Names="Calibri" Width="121px" Font-Size="X-Small">Payment Voucher Amt</asp:label><asp:label id="Label33" style="Z-INDEX: 198; LEFT: 664px; POSITION: absolute; TOP: 368px" runat="server"
				Height="16px" Font-Names="Calibri" Width="128px" Font-Size="X-Small">Payment Voucher Amt</asp:label><asp:label id="Label14" style="Z-INDEX: 199; LEFT: 664px; POSITION: absolute; TOP: 392px" runat="server"
				Height="16px" Font-Names="Calibri" Width="128px" Font-Size="X-Small">Pending Payment Amt</asp:label><asp:label id="Label35" style="Z-INDEX: 200; LEFT: 112px; POSITION: absolute; TOP: 472px" runat="server"
				Height="17px" Font-Names="Calibri" Width="136px" Font-Size="X-Small" Font-Bold="True">Excess Cash(In/Out)</asp:label><asp:textbox id="TxtP2" style="Z-INDEX: 201; LEFT: 312px; POSITION: absolute; TOP: 472px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtP3" style="Z-INDEX: 202; LEFT: 360px; POSITION: absolute; TOP: 472px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtP4" style="Z-INDEX: 203; LEFT: 408px; POSITION: absolute; TOP: 472px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtP5" style="Z-INDEX: 204; LEFT: 456px; POSITION: absolute; TOP: 472px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtP6" style="Z-INDEX: 205; LEFT: 504px; POSITION: absolute; TOP: 472px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtP7" style="Z-INDEX: 206; LEFT: 552px; POSITION: absolute; TOP: 472px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtP8" style="Z-INDEX: 207; LEFT: 600px; POSITION: absolute; TOP: 472px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtP9" style="Z-INDEX: 208; LEFT: 648px; POSITION: absolute; TOP: 472px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtP10" style="Z-INDEX: 209; LEFT: 696px; POSITION: absolute; TOP: 472px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtP11" style="Z-INDEX: 210; LEFT: 744px; POSITION: absolute; TOP: 472px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtExcAmt" style="Z-INDEX: 211; LEFT: 824px; POSITION: absolute; TOP: 472px"
				runat="server" Font-Names="Calibri" Width="88px" Font-Size="X-Small" BackColor="#FFE0C0" ReadOnly="True"></asp:textbox><asp:textbox id="TxtHScd" style="Z-INDEX: 212; LEFT: 1040px; POSITION: absolute; TOP: 528px"
				runat="server" Width="128px" Visible="False"></asp:textbox><asp:label id="L1" style="Z-INDEX: 213; LEFT: 736px; POSITION: absolute; TOP: 504px" runat="server"
				Height="17px" Font-Names="Calibri" Width="72px" Font-Size="X-Small">Excess Cash</asp:label><asp:label id="L2" style="Z-INDEX: 214; LEFT: 1056px; POSITION: absolute; TOP: 504px" runat="server"
				Height="17px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" Visible="False"></asp:label><asp:label id="L3" style="Z-INDEX: 215; LEFT: 824px; POSITION: absolute; TOP: 504px" runat="server"
				Height="17px" Font-Names="Calibri" Width="81px" Font-Size="X-Small" BackColor="White"></asp:label><asp:textbox id="TxtExcAmt11" style="Z-INDEX: 216; LEFT: 1040px; POSITION: absolute; TOP: 560px"
				runat="server" Font-Names="Calibri" Width="88px" Font-Size="X-Small" BackColor="#FFE0C0" Visible="False" ReadOnly="True"></asp:textbox><asp:textbox id="TxtP1" style="Z-INDEX: 217; LEFT: 264px; POSITION: absolute; TOP: 472px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True" ReadOnly="True"></asp:textbox><asp:textbox id="TxtR1" style="Z-INDEX: 218; LEFT: 264px; POSITION: absolute; TOP: 440px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtR2" style="Z-INDEX: 219; LEFT: 312px; POSITION: absolute; TOP: 440px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtR3" style="Z-INDEX: 220; LEFT: 360px; POSITION: absolute; TOP: 440px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtR4" style="Z-INDEX: 221; LEFT: 408px; POSITION: absolute; TOP: 440px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtR5" style="Z-INDEX: 222; LEFT: 456px; POSITION: absolute; TOP: 440px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtR6" style="Z-INDEX: 223; LEFT: 504px; POSITION: absolute; TOP: 440px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtR7" style="Z-INDEX: 224; LEFT: 552px; POSITION: absolute; TOP: 440px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtR8" style="Z-INDEX: 225; LEFT: 600px; POSITION: absolute; TOP: 440px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtR9" style="Z-INDEX: 226; LEFT: 648px; POSITION: absolute; TOP: 440px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtR10" style="Z-INDEX: 227; LEFT: 696px; POSITION: absolute; TOP: 440px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtR11" style="Z-INDEX: 228; LEFT: 744px; POSITION: absolute; TOP: 440px" runat="server"
				Height="20px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtRAmt" style="Z-INDEX: 229; LEFT: 824px; POSITION: absolute; TOP: 440px" runat="server"
				Font-Names="Calibri" Width="88px" Font-Size="X-Small" BackColor="#FFE0C0" ReadOnly="True"></asp:textbox><asp:label id="Label36" style="Z-INDEX: 230; LEFT: 112px; POSITION: absolute; TOP: 440px" runat="server"
				Height="17px" Font-Names="Calibri" Width="152px" Font-Size="X-Small" Font-Bold="True">Change From Cashier</asp:label><asp:textbox id="TxtRAmt1" style="Z-INDEX: 231; LEFT: 1040px; POSITION: absolute; TOP: 504px"
				runat="server" Font-Names="Calibri" Width="88px" Font-Size="X-Small" BackColor="#FFE0C0" Visible="False" ReadOnly="True"></asp:textbox><asp:label id="Labmsg" style="Z-INDEX: 232; LEFT: 360px; POSITION: absolute; TOP: 504px" runat="server"
				Height="24px" Font-Names="Calibri" Width="360px" Font-Size="X-Small" BackColor="Red" ForeColor="White"></asp:label><asp:checkbox id="CheckBox1" style="Z-INDEX: 233; LEFT: 656px; POSITION: absolute; TOP: 288px"
				runat="server" Height="24px" Font-Names="Calibri" Width="80px" AutoPostBack="True" Font-Bold="True" Text="Settle" ForeColor="#004040"></asp:checkbox><asp:checkbox id="CheckBox2" style="Z-INDEX: 234; LEFT: 728px; POSITION: absolute; TOP: 288px"
				runat="server" Height="24px" Font-Names="Calibri" Width="80px" Font-Size="Small" AutoPostBack="True" Font-Bold="True" Text="Continue" ForeColor="#004040"></asp:checkbox></form>
	</body>
</HTML>
