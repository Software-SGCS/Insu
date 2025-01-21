<%@ Page Language="vb" AutoEventWireup="false" Codebehind="DeathDonationEntry1.aspx.vb" Inherits="Insu.DeathDonationEntry1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Outword</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="#ffffcc" leftMargin="0" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:textbox id="TxtPdt" style="Z-INDEX: 121; LEFT: 664px; POSITION: absolute; TOP: 456px" runat="server"
				Width="118px" ReadOnly="True"></asp:textbox><asp:dropdownlist id="LstReNAM" style="Z-INDEX: 118; LEFT: 256px; POSITION: absolute; TOP: 136px"
				tabIndex="1" runat="server" Width="360px" Height="40px" AutoPostBack="True"></asp:dropdownlist><asp:label id="Label7" style="Z-INDEX: 116; LEFT: 468px; POSITION: absolute; TOP: 456px" runat="server"
				Width="181px" Height="16px">Total Amount</asp:label><asp:label id="Label5" style="Z-INDEX: 115; LEFT: 384px; POSITION: absolute; TOP: 168px" runat="server"
				Width="72px" Height="16px">Amount</asp:label><asp:label id="Label4" style="Z-INDEX: 114; LEFT: 584px; POSITION: absolute; TOP: 168px" runat="server"
				Width="42px" Height="16px">Date </asp:label><asp:label id="Label3" style="Z-INDEX: 113; LEFT: 120px; POSITION: absolute; TOP: 168px" runat="server"
				Width="96px" Height="16px">Treatment Type</asp:label><asp:label id="Label1" style="Z-INDEX: 112; LEFT: 120px; POSITION: absolute; TOP: 136px" runat="server"
				Width="96px" Height="16px">Relation Name</asp:label><asp:panel id="Panel6" style="Z-INDEX: 111; LEFT: 800px; POSITION: absolute; TOP: 64px" runat="server"
				Width="64px" Height="494px" BackColor="Desktop" BackImageUrl="http://sgcsser\Insu\Menu\bann1.jpg"></asp:panel><asp:panel id="Panel1" style="Z-INDEX: 102; LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server"
				Width="864px" Height="64px" BackColor="Desktop" BackImageUrl="Menu/banner.jpg" Font-Bold="True" HorizontalAlign="Left" Enabled="False" ForeColor="White" BorderColor="Transparent"><FONT style="BACKGROUND-COLOR: #000066">
					<asp:panel id="Panel3" style="Z-INDEX: 102; LEFT: 0px; POSITION: absolute; TOP: 64px" runat="server"
						Width="112px" Height="152px" BackImageUrl="Menu/bann2.jpg" BackColor="Desktop"></asp:panel>Death
					<DIV id="Layer1" style="Z-INDEX: 100; LEFT: 120px; OVERFLOW: scroll; WIDTH: 664px; POSITION: absolute; TOP: 232px; HEIGHT: 222px"
						DESIGNTIMEDRAGDROP="38">
						<asp:datagrid id="MyDataGrid" runat="server" Width="698px" Height="208px" BackColor="White" BorderColor="MidnightBlue"
							DESIGNTIMEDRAGDROP="171" cellpadding="3" Headerstyle-BackColor="#8080C0" Headerstyle-Font-Name="Tahoma"
							Headerstyle-Font-Size="12" Headerstyle-Font-Bold="True" Font-Name="Tahoma" Font-Size="12pt"
							AutogenerateColumns="False" OnEditcommand="MyDataGrid_EditCommand" OnCancelcommand="MyDataGrid_Cancel"
							OnUpdateCommand="MyDataGrid_UpdateCommand" OnDeleteCommand="MyDataGrid_DeleteCommand" DataKeyField="id"
							Font-Names="Tahoma" BorderStyle="None" BorderWidth="1px">
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
										<asp:LinkButton id="lblDelete" runat="server" Text="<img border=0 src=images/delete.jpg alt=delete>"
											CommandName="Delete"></asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn DataField="Emp_Nam" HeaderText="Relation Name">
									<HeaderStyle Width="4in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="Emp_Tretyp" HeaderText="Treatment Type">
									<HeaderStyle Width="1.5in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="Emp_Amt" HeaderText="Payment">
									<HeaderStyle Width="1.5in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="Emp_AppDt" HeaderText="Apply Datet">
									<HeaderStyle Width="1.5in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
						</asp:datagrid></DIV>
					Donation Data Entry</FONT></asp:panel>
			<asp:panel id="Panel2" style="Z-INDEX: 103; LEFT: 0px; POSITION: absolute; TOP: 211px" runat="server"
				Width="112px" Height="347px" BackColor="Desktop" BackImageUrl="Menu/bann1.jpg"></asp:panel><asp:button id="BtnEdit" style="Z-INDEX: 104; LEFT: 184px; POSITION: absolute; TOP: 456px" tabIndex="8"
				runat="server" Width="64px" Font-Bold="True" Text="Edit"></asp:button><asp:button id="BtnSave" style="Z-INDEX: 122; LEFT: 392px; POSITION: absolute; TOP: 456px" tabIndex="11"
				runat="server" Width="64px" Font-Bold="True" Text="Save"></asp:button><asp:dropdownlist id="LstEmpNo" style="Z-INDEX: 107; LEFT: 256px; POSITION: absolute; TOP: 64px" tabIndex="1"
				runat="server" Width="440px" Height="24px" AutoPostBack="True"></asp:dropdownlist><asp:label id="Invoice" style="Z-INDEX: 108; LEFT: 120px; POSITION: absolute; TOP: 64px" runat="server"
				Width="104px" Height="24px">Emp No</asp:label><asp:label id="Label2" style="Z-INDEX: 109; LEFT: 120px; POSITION: absolute; TOP: 104px" runat="server"
				Width="96px" Height="16px">Company</asp:label><asp:button id="BtnCle" style="Z-INDEX: 105; LEFT: 248px; POSITION: absolute; TOP: 456px" tabIndex="9"
				runat="server" Width="72px" Height="24px" Font-Bold="True" Text="Clear"></asp:button><asp:button id="BtnAdd" style="Z-INDEX: 101; LEFT: 120px; POSITION: absolute; TOP: 456px" tabIndex="7"
				runat="server" Width="64px" Font-Bold="True" Text="Add"></asp:button><asp:textbox id="TxtEmpNo" style="Z-INDEX: 110; LEFT: 256px; POSITION: absolute; TOP: 64px" runat="server"
				Width="110px" Height="24px" AutoPostBack="True"></asp:textbox><asp:button id="BtnDel" style="Z-INDEX: 106; LEFT: 320px; POSITION: absolute; TOP: 456px" tabIndex="11"
				runat="server" Width="64px" Font-Bold="True" Text="Delete"></asp:button><asp:button id="BttIns" style="Z-INDEX: 117; LEFT: 688px; POSITION: absolute; TOP: 208px" runat="server"
				Width="104px" Text="Insert"></asp:button><asp:textbox id="TxtPay" style="Z-INDEX: 119; LEFT: 464px; POSITION: absolute; TOP: 168px" runat="server"
				Width="105px"></asp:textbox><asp:textbox id="Txtappdt" style="Z-INDEX: 120; LEFT: 640px; POSITION: absolute; TOP: 168px"
				runat="server" Width="98px"></asp:textbox><asp:textbox id="LstCom" style="Z-INDEX: 123; LEFT: 256px; POSITION: absolute; TOP: 104px" runat="server"
				Width="442px" ReadOnly="True"></asp:textbox><asp:dropdownlist id="Lsttyp" style="Z-INDEX: 124; LEFT: 256px; POSITION: absolute; TOP: 168px" runat="server"
				Width="112px" Height="32px"></asp:dropdownlist><asp:textbox id="Txtflag" style="Z-INDEX: 125; LEFT: 672px; POSITION: absolute; TOP: 136px" runat="server"
				Width="96px"></asp:textbox></form>
	</body>
</HTML>
