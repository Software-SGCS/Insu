<%@ Page Language="vb" AutoEventWireup="false" Codebehind="DeathDonation2.aspx.vb" Inherits="Insu.DeathDonation2" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Outword</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="antiquewhite" leftMargin="0" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:textbox id="TxtChqNo" style="Z-INDEX: 123; LEFT: 736px; POSITION: absolute; TOP: 176px"
				tabIndex="8" runat="server" Width="88px" Visible="False"></asp:textbox><asp:textbox id="TxtPdt" style="Z-INDEX: 122; LEFT: 488px; POSITION: absolute; TOP: 200px" tabIndex="10"
				runat="server" Width="88px" Visible="False"></asp:textbox><asp:dropdownlist id="LstReltyp" style="Z-INDEX: 118; LEFT: 208px; POSITION: absolute; TOP: 504px"
				tabIndex="6" runat="server" Width="120px" Height="40px" Visible="False"></asp:dropdownlist><asp:label id="Label7" style="Z-INDEX: 116; LEFT: 720px; POSITION: absolute; TOP: 208px" runat="server"
				Width="72px" Height="16px" Visible="False">Cheque No</asp:label><asp:label id="Label6" style="Z-INDEX: 115; LEFT: 392px; POSITION: absolute; TOP: 200px" runat="server"
				Width="88px" Height="16px" Visible="False">Payment Date</asp:label><asp:label id="Label5" style="Z-INDEX: 114; LEFT: 120px; POSITION: absolute; TOP: 184px" runat="server"
				Width="72px" Height="16px" Visible="False">Amount</asp:label><asp:label id="Label4" style="Z-INDEX: 113; LEFT: 120px; POSITION: absolute; TOP: 200px" runat="server"
				Width="96px" Height="16px" Visible="False">Date of Death</asp:label><asp:label id="Label3" style="Z-INDEX: 112; LEFT: 104px; POSITION: absolute; TOP: 504px" runat="server"
				Width="96px" Height="16px" Visible="False">Relation Type</asp:label><asp:label id="Label1" style="Z-INDEX: 111; LEFT: 120px; POSITION: absolute; TOP: 168px" runat="server"
				Width="96px" Height="16px">Relation Name</asp:label><asp:panel id="Panel6" style="Z-INDEX: 110; LEFT: 848px; POSITION: absolute; TOP: 64px" runat="server"
				Width="82px" Height="456px" BackImageUrl="Menu/bann1.jpg" BackColor="Desktop"></asp:panel><asp:panel id="Panel1" style="Z-INDEX: 101; LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server"
				Width="932px" Height="64px" BackImageUrl="Menu/banner.jpg" BackColor="Desktop" BorderColor="Transparent" ForeColor="White" Enabled="False" HorizontalAlign="Left" Font-Bold="True"><FONT style="BACKGROUND-COLOR: #000066">
					<asp:panel id="Panel3" style="Z-INDEX: 128; LEFT: 0px; POSITION: absolute; TOP: 64px" runat="server"
						Width="112px" Height="456px" BackColor="Desktop" BackImageUrl="Menu/bann2.jpg"></asp:panel>Death
					<DIV id="Layer1" style="Z-INDEX: 127; LEFT: 120px; OVERFLOW: scroll; WIDTH: 724px; POSITION: absolute; TOP: 232px; HEIGHT: 222px">
						<asp:datagrid id="MyDataGrid" runat="server" Width="708px" BackColor="White" BorderColor="MidnightBlue"
							BorderWidth="1px" BorderStyle="None" Font-Names="Tahoma" DataKeyField="id" OnDeleteCommand="MyDataGrid_DeleteCommand"
							OnUpdateCommand="MyDataGrid_UpdateCommand" OnCancelcommand="MyDataGrid_Cancel" OnEditcommand="MyDataGrid_EditCommand"
							AutogenerateColumns="False" Font-Size="12pt" Font-Name="Tahoma" Headerstyle-Font-Bold="True"
							Headerstyle-Font-Size="12" Headerstyle-Font-Name="Tahoma" Headerstyle-BackColor="#8080C0"
							cellpadding="3">
							<SelectedItemStyle Font-Size="Smaller" Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
							<EditItemStyle Font-Size="Smaller"></EditItemStyle>
							<AlternatingItemStyle Font-Size="Smaller"></AlternatingItemStyle>
							<ItemStyle Font-Size="Smaller" ForeColor="#000066"></ItemStyle>
							<HeaderStyle Font-Size="12pt" Font-Names="Arial" Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
							<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
							<Columns>
								<asp:TemplateColumn>
									<ItemTemplate>
										<asp:LinkButton id="lbtnEdit" runat="server" Text="<img border=0 src=images/dtg_edit.gif alt=edit>"
											CommandName="Edit"></asp:LinkButton>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:LinkButton id="lbtnUpdate" runat="server" Text="<img  border=0 src=images/dtg_update.gif alt=save/update>"
											CommandName="Update"></asp:LinkButton>
										<asp:LinkButton id="lbtnCancel" runat="server" Text="<img border=0 src=images/dtg_cancel.gif alt=cancel>"
											CommandName="Cancel"></asp:LinkButton>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<ItemTemplate>
										<asp:LinkButton id="lblDelete" runat="server" Text="<img border=0 src=images\delete.jpg alt=delete>"
											CommandName="Delete"></asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn DataField="Emp_Nam" HeaderText="Relation Name">
									<HeaderStyle Width="4in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="Emp_Reltype" HeaderText="Relation Type">
									<HeaderStyle Width="1.5in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="Emp_Dob" HeaderText="Date of Death">
									<HeaderStyle Width="1.5in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="Emp_DeathAmt" HeaderText="Payment">
									<HeaderStyle Width="1.5in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="Emp_PayDt" HeaderText="Payment Date">
									<HeaderStyle Width="1.5in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="Emp_ChqNo" HeaderText="Chque No">
									<HeaderStyle Width="1in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
						</asp:datagrid></DIV>
					Donation Data Entry</FONT></asp:panel><asp:button id="BtnEdit" style="Z-INDEX: 103; LEFT: 216px; POSITION: absolute; TOP: 456px" tabIndex="8"
				runat="server" Width="64px" Enabled="False" Font-Bold="True" Text="Edit" Visible="False"></asp:button><asp:button id="BtnSave" style="Z-INDEX: 124; LEFT: 456px; POSITION: absolute; TOP: 456px" tabIndex="11"
				runat="server" Width="64px" Enabled="False" Font-Bold="True" Text="Save" Visible="False"></asp:button><asp:dropdownlist id="LstEmpNo" style="Z-INDEX: 106; LEFT: 472px; POSITION: absolute; TOP: 72px" tabIndex="1"
				runat="server" Width="90px" Height="24px" AutoPostBack="True" Visible="False"></asp:dropdownlist><asp:label id="Invoice" style="Z-INDEX: 107; LEFT: 120px; POSITION: absolute; TOP: 104px" runat="server"
				Width="104px" Height="24px">Emp No</asp:label><asp:label id="Label2" style="Z-INDEX: 108; LEFT: 120px; POSITION: absolute; TOP: 72px" runat="server"
				Width="64px" Height="16px">Company</asp:label><asp:button id="BtnCle" style="Z-INDEX: 104; LEFT: 288px; POSITION: absolute; TOP: 456px" tabIndex="9"
				runat="server" Width="72px" Height="24px" Enabled="False" Font-Bold="True" Text="Clear" Visible="False"></asp:button><asp:button id="BtnAdd" style="Z-INDEX: 100; LEFT: 144px; POSITION: absolute; TOP: 456px" tabIndex="7"
				runat="server" Width="64px" Enabled="False" Font-Bold="True" Text="Add" Visible="False"></asp:button><asp:textbox id="TxtEmpNo" style="Z-INDEX: 109; LEFT: 256px; POSITION: absolute; TOP: 104px"
				tabIndex="1" runat="server" Width="74px" Height="24px" AutoPostBack="True"></asp:textbox><asp:button id="BtnDel" style="Z-INDEX: 105; LEFT: 376px; POSITION: absolute; TOP: 456px" tabIndex="11"
				runat="server" Width="64px" Enabled="False" Font-Bold="True" Text="Delete" Visible="False"></asp:button><asp:button id="BttIns" style="Z-INDEX: 117; LEFT: 608px; POSITION: absolute; TOP: 208px" tabIndex="11"
				runat="server" Width="80px" Text="Insert" Visible="False"></asp:button><asp:textbox id="TxtRNam" style="Z-INDEX: 119; LEFT: 768px; POSITION: absolute; TOP: 136px" tabIndex="5"
				runat="server" Width="20px" Visible="False"></asp:textbox><asp:textbox id="TxtPay" style="Z-INDEX: 120; LEFT: 256px; POSITION: absolute; TOP: 184px" tabIndex="7"
				runat="server" Width="104px" Visible="False"></asp:textbox><asp:textbox id="TxtDoD" style="Z-INDEX: 121; LEFT: 256px; POSITION: absolute; TOP: 200px" tabIndex="9"
				runat="server" Width="88px" Visible="False"></asp:textbox><asp:textbox id="LstCom" style="Z-INDEX: 125; LEFT: 712px; POSITION: absolute; TOP: 72px" runat="server"
				Width="90px" ReadOnly="True" Visible="False"></asp:textbox><asp:dropdownlist id="LstCom1" style="Z-INDEX: 126; LEFT: 256px; POSITION: absolute; TOP: 72px" tabIndex="2"
				runat="server" Width="372px" Height="24px" AutoPostBack="True"></asp:dropdownlist><asp:label id="Label8" style="Z-INDEX: 128; LEFT: 120px; POSITION: absolute; TOP: 136px" runat="server"
				Width="114px" Height="16px">Employee Name</asp:label><asp:textbox id="TxtEmpNam" style="Z-INDEX: 129; LEFT: 256px; POSITION: absolute; TOP: 136px"
				tabIndex="3" runat="server" Width="342px"></asp:textbox><asp:label id="Label9" style="Z-INDEX: 130; LEFT: 360px; POSITION: absolute; TOP: 112px" runat="server"
				Width="38px" Height="16px">Id No</asp:label><asp:textbox id="TxtIdNo" style="Z-INDEX: 131; LEFT: 432px; POSITION: absolute; TOP: 104px" tabIndex="4"
				runat="server" Width="142px"></asp:textbox><asp:label id="L1" style="Z-INDEX: 132; LEFT: 568px; POSITION: absolute; TOP: 464px" runat="server"
				Width="208px" Height="16px"></asp:label>
			<asp:DropDownList id="LstRNam" style="Z-INDEX: 133; LEFT: 256px; POSITION: absolute; TOP: 168px" runat="server"
				Width="344px" Height="24px" AutoPostBack="True"></asp:DropDownList>
			<asp:TextBox id="TxtSeqNo" style="Z-INDEX: 134; LEFT: 720px; POSITION: absolute; TOP: 136px"
				runat="server" Width="32px" Visible="False"></asp:TextBox>
			<asp:TextBox id="TxtReltyp" style="Z-INDEX: 135; LEFT: 608px; POSITION: absolute; TOP: 176px"
				runat="server" Width="80px" Height="26px" Visible="False"></asp:TextBox></form>
	</body>
</HTML>
