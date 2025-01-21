<%@ Page Language="vb" AutoEventWireup="false" Codebehind="DDFEntry.aspx.vb" Inherits="Insu.DDFEntry" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Outword</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="#ffffff" leftMargin="0" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:textbox id="TxtChqNo" style="Z-INDEX: 114; LEFT: 544px; POSITION: absolute; TOP: 112px"
				tabIndex="8" runat="server" Width="104px" Height="24px"></asp:textbox><asp:textbox id="TxtPdt" style="Z-INDEX: 113; LEFT: 336px; POSITION: absolute; TOP: 152px" tabIndex="10"
				runat="server" Width="88px" AutoPostBack="True"></asp:textbox><asp:label id="Label7" style="Z-INDEX: 110; LEFT: 456px; POSITION: absolute; TOP: 112px" runat="server"
				Width="72px" Height="16px">Cheque No</asp:label><asp:label id="Label6" style="Z-INDEX: 109; LEFT: 224px; POSITION: absolute; TOP: 152px" runat="server"
				Width="88px" Height="16px">Diposite Date</asp:label><asp:label id="Label5" style="Z-INDEX: 108; LEFT: 224px; POSITION: absolute; TOP: 112px" runat="server"
				Width="72px" Height="16px">Amount</asp:label><asp:panel id="Panel1" style="Z-INDEX: 102; LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server"
				Width="952px" Height="72px" Font-Bold="True" HorizontalAlign="Left" Enabled="False" ForeColor="White" BorderColor="Transparent" BackColor="Desktop"
				BackImageUrl="Menu/banner.jpg"><FONT style="BACKGROUND-COLOR: #000066">Death
					<DIV id="Layer1" style="Z-INDEX: 118; LEFT: 232px; OVERFLOW: scroll; WIDTH: 704px; POSITION: absolute; TOP: 224px; HEIGHT: 280px"
						noWrap>
						<asp:datagrid id="MyDataGrid" runat="server" Width="0px" BackColor="White" BorderColor="CornflowerBlue"
							cellpadding="3" Headerstyle-BackColor="#8080C0" Headerstyle-Font-Name="Tahoma" Headerstyle-Font-Size="12"
							Headerstyle-Font-Bold="True" Font-Name="Tahoma" Font-Size="12pt" AutogenerateColumns="False"
							OnEditcommand="MyDataGrid_EditCommand" OnCancelcommand="MyDataGrid_Cancel" OnUpdateCommand="MyDataGrid_UpdateCommand"
							OnDeleteCommand="MyDataGrid_DeleteCommand" DataKeyField="id" Font-Names="Tahoma" BorderStyle="None"
							BorderWidth="1px">
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
								<asp:BoundColumn DataField="RecDate" HeaderText="Received Date">
									<HeaderStyle Width="4in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="ChqNo" HeaderText="Cheque No">
									<HeaderStyle Width="1.5in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="RecAmt" HeaderText="Received Amount">
									<HeaderStyle Width="1.5in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="Mth" HeaderText="Month">
									<HeaderStyle Width="1.5in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="Yr" HeaderText="Year">
									<HeaderStyle Width="1.5in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Center" ForeColor="Black" BackColor="#999999" Mode="NumericPages"></PagerStyle>
						</asp:datagrid></DIV>
					Donation Data Entry</FONT></asp:panel>
			<asp:button id="BtnEdit" style="Z-INDEX: 103; LEFT: 296px; POSITION: absolute; TOP: 568px" tabIndex="8"
				runat="server" Width="64px" Enabled="False" Font-Bold="True" Text="Edit" Visible="False"></asp:button><asp:button id="BtnSave" style="Z-INDEX: 115; LEFT: 536px; POSITION: absolute; TOP: 568px" tabIndex="11"
				runat="server" Width="64px" Font-Bold="True" Enabled="False" Visible="False" Text="Save"></asp:button><asp:dropdownlist id="LstEmpNo" style="Z-INDEX: 106; LEFT: 672px; POSITION: absolute; TOP: 120px"
				tabIndex="1" runat="server" Width="90px" Height="24px" AutoPostBack="True" Visible="False"></asp:dropdownlist><asp:label id="Label2" style="Z-INDEX: 107; LEFT: 224px; POSITION: absolute; TOP: 80px" runat="server"
				Width="64px" Height="16px">Company</asp:label><asp:button id="BtnCle" style="Z-INDEX: 104; LEFT: 368px; POSITION: absolute; TOP: 568px" tabIndex="9"
				runat="server" Width="72px" Height="24px" Font-Bold="True" Enabled="False" Visible="False" Text="Clear"></asp:button><asp:button id="BtnAdd" style="Z-INDEX: 101; LEFT: 224px; POSITION: absolute; TOP: 568px" tabIndex="7"
				runat="server" Width="64px" Font-Bold="True" Enabled="False" Visible="False" Text="Add"></asp:button><asp:button id="BtnDel" style="Z-INDEX: 105; LEFT: 456px; POSITION: absolute; TOP: 568px" tabIndex="11"
				runat="server" Width="64px" Font-Bold="True" Enabled="False" Visible="False" Text="Delete"></asp:button><asp:button id="BttIns" style="Z-INDEX: 111; LEFT: 632px; POSITION: absolute; TOP: 184px" tabIndex="999"
				runat="server" Width="74px" Text="Insert"></asp:button><asp:textbox id="TxtPay" style="Z-INDEX: 112; LEFT: 336px; POSITION: absolute; TOP: 112px" tabIndex="7"
				runat="server" Width="112px"></asp:textbox><asp:dropdownlist id="LstCom1" style="Z-INDEX: 116; LEFT: 336px; POSITION: absolute; TOP: 80px" tabIndex="2"
				runat="server" Width="368px" Height="24px" AutoPostBack="True"></asp:dropdownlist><asp:label id="Label1" style="Z-INDEX: 117; LEFT: 544px; POSITION: absolute; TOP: 520px" runat="server"
				Width="90px" Height="24px">Total Amount</asp:label><asp:textbox id="TxtTotAmt" style="Z-INDEX: 118; LEFT: 656px; POSITION: absolute; TOP: 520px"
				runat="server" Width="120px" Height="24px"></asp:textbox>
			<asp:panel id="Panel5" style="Z-INDEX: 120; LEFT: 8px; POSITION: absolute; TOP: 560px" runat="server"
				Width="1016px" Height="54px" BackColor="Desktop"></asp:panel><asp:textbox id="TxtMth" style="Z-INDEX: 122; LEFT: 336px; POSITION: absolute; TOP: 184px" runat="server"
				Width="152px"></asp:textbox><asp:label id="Label3" style="Z-INDEX: 123; LEFT: 224px; POSITION: absolute; TOP: 184px" runat="server"
				Width="88px" Height="24px">Month</asp:label><asp:textbox id="TxtYr" style="Z-INDEX: 124; LEFT: 488px; POSITION: absolute; TOP: 184px" runat="server"
				Width="56px" Height="24px"></asp:textbox>
			<DIV></DIV>
		</form>
		<DIV></DIV>
		<DIV>
			<asp:panel id="Panel3" style="Z-INDEX: 121; LEFT: 952px; POSITION: absolute; TOP: 0px" runat="server"
				Height="564px" Width="74px" BackColor="CornflowerBlue"></asp:panel>
			<asp:Label id="L1" style="Z-INDEX: 125; LEFT: 320px; POSITION: absolute; TOP: 528px" runat="server"
				Height="24px" Width="104px"></asp:Label><asp:panel id="Panel2" runat="server" Width="180px" Height="496px" BackColor="CornflowerBlue"
				BackImageUrl="Menu/AssetI.gif"></asp:panel></DIV>
	</body>
</HTML>
