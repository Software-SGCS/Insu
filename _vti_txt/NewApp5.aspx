<%@ Page Language="vb" AutoEventWireup="false" Codebehind="NewApp5.aspx.vb" Inherits="Insu.NewApp5"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>NewApp5</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body leftMargin="0" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<div id="Layer1" style="Z-INDEX: 124; LEFT: 120px; OVERFLOW: scroll; WIDTH: 598px; POSITION: absolute; TOP: 232px; HEIGHT: 162px"><asp:datagrid id="MyDataGrid" runat="server" cellpadding="3" Headerstyle-BackColor="#8080C0" Headerstyle-Font-Name="Tahoma"
					Headerstyle-Font-Size="12" Headerstyle-Font-Bold="True" BackColor="White" Font-Name="Tahoma" Font-Size="12pt" BorderColor="MidnightBlue" AutogenerateColumns="False" OnEditcommand="MyDataGrid_EditCommand" OnCancelcommand="MyDataGrid_Cancel"
					OnUpdateCommand="MyDataGrid_UpdateCommand" Width="534px" OnDeleteCommand="MyDataGrid_DeleteCommand" DataKeyField="id" Font-Names="Tahoma" BorderStyle="None" BorderWidth="1px">
					<SelectedItemStyle Font-Size="Smaller" Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
					<EditItemStyle Font-Size="Smaller"></EditItemStyle>
					<AlternatingItemStyle Font-Size="Smaller"></AlternatingItemStyle>
					<ItemStyle Font-Size="Smaller" ForeColor="#000066"></ItemStyle>
					<HeaderStyle Font-Size="12pt" Font-Names="Arial" Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
					<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
					<Columns>
						<asp:TemplateColumn>
							<ItemTemplate>
								<asp:LinkButton id="lbtnEdit" runat="server" Text="<img border=0 src=http://sgcsser\Insu\images\dtg_edit.gif alt=edit>"
									CommandName="Edit"></asp:LinkButton>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:LinkButton id="lbtnUpdate" runat="server" Text="<img  border=0 src=http://sgcsser\Insu\images\dtg_update.gif alt=save/update>"
									CommandName="Update"></asp:LinkButton>
								<asp:LinkButton id="lbtnCancel" runat="server" Text="<img border=0 src=http://sgcsser\Insu\images\dtg_cancel.gif alt=cancel>"
									CommandName="Cancel"></asp:LinkButton>
							</EditItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn>
							<ItemTemplate>
								<asp:LinkButton id="lblDelete" runat="server" Text="<img border=0 src=http://sgcsser\Insu\images\delete.jpg alt=delete>"
									CommandName="Delete"></asp:LinkButton>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:BoundColumn DataField="Inv_itmNo" ReadOnly="True" HeaderText="Item No">
							<HeaderStyle Width="1in"></HeaderStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Inv_des" ReadOnly="True" HeaderText="Description              ">
							<HeaderStyle Width="4in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Invpr" ReadOnly="True" HeaderText="Rates">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="InvQty" HeaderText="Qty">
							<HeaderStyle Width="0.75in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Invval" ReadOnly="True" HeaderText="Amount">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle Font-Bold="True" HorizontalAlign="Right" ForeColor="Black" VerticalAlign="Middle"></ItemStyle>
						</asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
				</asp:datagrid></div>
			<asp:label id="Label12" style="Z-INDEX: 138; LEFT: 640px; POSITION: absolute; TOP: 400px" runat="server"
				Width="56px" Height="24px">Percentage</asp:label><asp:dropdownlist id="LstFlag2" style="Z-INDEX: 136; LEFT: 584px; POSITION: absolute; TOP: 400px"
				tabIndex="2" runat="server" Width="56px" Height="16px" AutoPostBack="True"></asp:dropdownlist><asp:label id="Label11" style="Z-INDEX: 135; LEFT: 472px; POSITION: absolute; TOP: 400px" runat="server"
				Width="104px" Height="24px">Price Adjestment</asp:label><asp:label id="Label10" style="Z-INDEX: 134; LEFT: 368px; POSITION: absolute; TOP: 400px" runat="server"
				Width="40px" Height="24px">Vat</asp:label><asp:dropdownlist id="LstVat" style="Z-INDEX: 132; LEFT: 408px; POSITION: absolute; TOP: 400px" tabIndex="2"
				runat="server" Width="56px" Height="16px" AutoPostBack="True"></asp:dropdownlist><asp:dropdownlist id="LstCode" style="Z-INDEX: 131; LEFT: 184px; POSITION: absolute; TOP: 400px" tabIndex="2"
				runat="server" Width="176px" Height="16px"></asp:dropdownlist><asp:label id="Label9" style="Z-INDEX: 130; LEFT: 112px; POSITION: absolute; TOP: 400px" runat="server"
				Width="64px" Height="24px">Create By</asp:label><asp:button id="Button1" style="Z-INDEX: 129; LEFT: 672px; POSITION: absolute; TOP: 448px" tabIndex="9"
				runat="server" Width="64px" Height="22px" Text="Invoice" Font-Bold="True" Visible="False"></asp:button><asp:button id="BtnSubmit" style="Z-INDEX: 126; LEFT: 696px; POSITION: absolute; TOP: 208px"
				tabIndex="7" runat="server" Width="64px" Text="Go" Font-Bold="True"></asp:button><asp:label id="Label8" style="Z-INDEX: 123; LEFT: 560px; POSITION: absolute; TOP: 208px" runat="server"
				Width="40px" Height="17px" EnableViewState="False">Qty</asp:label><asp:label id="Label6" style="Z-INDEX: 118; LEFT: 424px; POSITION: absolute; TOP: 152px" runat="server"
				BackColor="Desktop" Width="140px" Height="16px" ForeColor="White">Brand</asp:label><asp:label id="Label5" style="Z-INDEX: 117; LEFT: 256px; POSITION: absolute; TOP: 152px" runat="server"
				BackColor="Desktop" Width="142px" Height="16px" ForeColor="White">Country</asp:label><asp:panel id="Panel5" style="Z-INDEX: 100; LEFT: 0px; POSITION: absolute; TOP: 152px" runat="server"
				BackColor="Desktop" Width="104px" Height="354px" BackImageUrl="Menu/AssetI.gif"></asp:panel><asp:panel id="Panel1" style="Z-INDEX: 101; LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server"
				BackColor="Desktop" BorderColor="Transparent" Width="879px" Height="32px" Font-Bold="True" ForeColor="White" Enabled="False" HorizontalAlign="Left">
<asp:dropdownlist id="Dropdownlist1" style="Z-INDEX: 133; LEFT: 408px; POSITION: absolute; TOP: 400px"
					tabIndex="2" runat="server" Width="56px" Height="16px" AutoPostBack="True"></asp:dropdownlist>INVOICE</asp:panel>
			<asp:panel id="Panel2" style="Z-INDEX: 102; LEFT: 0px; POSITION: absolute; TOP: 32px" runat="server"
				BackColor="Desktop" Width="104px" Height="120px" BackImageUrl="Menu/Audit.gif"></asp:panel><asp:panel id="Panel3" style="Z-INDEX: 103; LEFT: 0px; POSITION: absolute; TOP: 152px" runat="server"
				BackColor="Desktop" Width="880px" Height="34px" Font-Bold="True" ForeColor="White">Payment Detail</asp:panel>
			<asp:button id="BtnEdit" style="Z-INDEX: 104; LEFT: 400px; POSITION: absolute; TOP: 480px" tabIndex="8"
				runat="server" Width="64px" Height="22px" Text="Edit" Font-Bold="True" Visible="False"></asp:button><asp:textbox id="TxtInvDt" style="Z-INDEX: 107; LEFT: 240px; POSITION: absolute; TOP: 104px"
				tabIndex="3" runat="server" Width="88px" Height="26px"></asp:textbox><asp:label id="Label1" style="Z-INDEX: 108; LEFT: 112px; POSITION: absolute; TOP: 112px" runat="server"
				Width="104px" Height="16px">Invoice Date</asp:label><asp:dropdownlist id="Lstcom" style="Z-INDEX: 109; LEFT: 240px; POSITION: absolute; TOP: 72px" tabIndex="2"
				runat="server" Width="346px" Height="16px"></asp:dropdownlist><asp:dropdownlist id="LstInvNo" style="Z-INDEX: 110; LEFT: 400px; POSITION: absolute; TOP: 40px" tabIndex="1"
				runat="server" Width="124px" Height="40px" AutoPostBack="True" Visible="False"></asp:dropdownlist><asp:label id="Invoice" style="Z-INDEX: 111; LEFT: 112px; POSITION: absolute; TOP: 48px" runat="server"
				Width="104px" Height="24px">Invoice No</asp:label><asp:label id="Label2" style="Z-INDEX: 112; LEFT: 112px; POSITION: absolute; TOP: 80px" runat="server"
				Width="96px" Height="24px">Company</asp:label><asp:textbox id="TxtPoNo" style="Z-INDEX: 113; LEFT: 544px; POSITION: absolute; TOP: 104px" tabIndex="4"
				runat="server" Width="136px" Height="24px"></asp:textbox><asp:label id="Label3" style="Z-INDEX: 114; LEFT: 392px; POSITION: absolute; TOP: 112px" runat="server"
				Width="128px" Height="24px">Purchase Order NO</asp:label><asp:dropdownlist id="LstTyp" style="Z-INDEX: 115; LEFT: 120px; POSITION: absolute; TOP: 184px" runat="server"
				Width="112px" Height="24px" AutoPostBack="True"></asp:dropdownlist><asp:label id="Label4" style="Z-INDEX: 116; LEFT: 120px; POSITION: absolute; TOP: 152px" runat="server"
				BackColor="Desktop" Width="108px" Height="12px" ForeColor="White">Type</asp:label><asp:dropdownlist id="LstCntry" style="Z-INDEX: 119; LEFT: 256px; POSITION: absolute; TOP: 184px"
				runat="server" Width="144px" Height="24px" AutoPostBack="True"></asp:dropdownlist><asp:dropdownlist id="LstBrnd" style="Z-INDEX: 120; LEFT: 424px; POSITION: absolute; TOP: 184px" runat="server"
				Width="140px" Height="24px" AutoPostBack="True"></asp:dropdownlist><asp:dropdownlist id="LstItmNo" style="Z-INDEX: 121; LEFT: 216px; POSITION: absolute; TOP: 208px"
				runat="server" Width="344px" Height="31px" AutoPostBack="True"></asp:dropdownlist><asp:label id="Label7" style="Z-INDEX: 122; LEFT: 120px; POSITION: absolute; TOP: 208px" runat="server"
				Width="72px" Height="17px">Item No</asp:label><asp:textbox id="TxtQty" style="Z-INDEX: 125; LEFT: 608px; POSITION: absolute; TOP: 208px" runat="server"
				Width="72px"></asp:textbox>
			<asp:button id="BtnCle" style="Z-INDEX: 105; LEFT: 216px; POSITION: absolute; TOP: 480px" tabIndex="9"
				runat="server" Width="64px" Height="22px" Font-Bold="True" Text="Clear" Visible="False"></asp:button><asp:textbox id="TxtInvNo" style="Z-INDEX: 127; LEFT: 240px; POSITION: absolute; TOP: 40px" runat="server"
				Width="124px" Height="18px"></asp:textbox><asp:button id="BtnDel" style="Z-INDEX: 106; LEFT: 312px; POSITION: absolute; TOP: 480px" tabIndex="11"
				runat="server" Width="64px" Height="22px" Text="Delete" Font-Bold="True" Visible="False"></asp:button><asp:button id="BtnSave" style="Z-INDEX: 128; LEFT: 560px; POSITION: absolute; TOP: 448px; Design_Time_Lock: True"
				tabIndex="11" runat="server" Width="64px" Height="22px" Text="Save" Font-Bold="True" Design_Time_Lock="True"></asp:button><asp:textbox id="TxtPer" style="Z-INDEX: 137; LEFT: 720px; POSITION: absolute; TOP: 400px" runat="server"
				Width="52px"></asp:textbox><asp:button id="BtnAdd" style="Z-INDEX: 139; LEFT: 112px; POSITION: absolute; TOP: 480px" runat="server"
				Width="64px" Height="22px" Text="Add" Font-Bold="True" Visible="False"></asp:button><asp:imagebutton id="ImgBt" style="Z-INDEX: 140; LEFT: 328px; POSITION: absolute; TOP: 104px" runat="server"
				Width="32px" Height="24px" ImageUrl="file:///\\sgcsser\C\Inetpub\wwwroot\Insu\iCO\Cal1.jpg"></asp:imagebutton><asp:calendar id="Calendar1" style="Z-INDEX: 141; LEFT: 360px; POSITION: absolute; TOP: 104px"
				tabIndex="1000" runat="server" BackColor="White" Font-Size="9pt" BorderColor="White" Width="180px" Font-Names="Verdana" BorderWidth="1px" Height="184px" ForeColor="Black" NextPrevFormat="FullMonth" Visible="False"
				CellPadding="1">
				<TodayDayStyle BackColor="#CCCCCC"></TodayDayStyle>
				<NextPrevStyle Font-Size="8pt" Font-Bold="True" ForeColor="#333333" VerticalAlign="Bottom"></NextPrevStyle>
				<DayHeaderStyle Font-Size="8pt" Font-Bold="True"></DayHeaderStyle>
				<SelectedDayStyle ForeColor="White" BackColor="#333399"></SelectedDayStyle>
				<TitleStyle Font-Size="12pt" Font-Bold="True" BorderWidth="4px" ForeColor="#333399" BorderColor="Black"
					BackColor="White"></TitleStyle>
				<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
			</asp:calendar>
			<asp:panel id="Panel6" style="Z-INDEX: 142; LEFT: 0px; POSITION: absolute; TOP: 504px" runat="server"
				Width="874px" BackColor="Desktop" Height="43px" Font-Bold="True"></asp:panel>
			<asp:label id="Label13" style="Z-INDEX: 143; LEFT: 368px; POSITION: absolute; TOP: 440px" runat="server"
				Width="40px" Height="24px">TT</asp:label>
			<asp:dropdownlist id="LstTT" style="Z-INDEX: 144; LEFT: 408px; POSITION: absolute; TOP: 432px" tabIndex="2"
				runat="server" Width="56px" Height="16px" AutoPostBack="True"></asp:dropdownlist></form>
	</body>
</HTML>
