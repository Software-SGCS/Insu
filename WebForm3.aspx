<%@ Page Language="vb" AutoEventWireup="false" Codebehind="WebForm3.aspx.vb" Inherits="Insu.WebForm3" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>WebForm3</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="#ffffff" MS_POSITIONING="GridLayout" leftmargin="0">
		<form id="Form1" method="post" runat="server">
			<asp:panel id="Panel1" style="Z-INDEX: 100; LEFT: -8px; POSITION: absolute; TOP: 48px" runat="server"
				HorizontalAlign="Center" ForeColor="#004000" BackColor="Desktop" Height="448px" Width="112px"
				BackImageUrl="Menu/Audit.gif">&nbsp;</asp:panel>
			<asp:panel id="Panel3" style="Z-INDEX: 118; LEFT: 0px; POSITION: absolute; TOP: 496px" runat="server"
				Width="936px" Height="48px" BackColor="Desktop"></asp:panel><asp:button id="Button2" style="Z-INDEX: 117; LEFT: 368px; POSITION: absolute; TOP: 184px" tabIndex="35"
				runat="server" Height="28px" Width="64px" Text="Refresh" BackColor="#FFC0C0" Font-Names="Calibri" Font-Size="X-Small"></asp:button><asp:button id="BtnEdit" style="Z-INDEX: 115; LEFT: 224px; POSITION: absolute; TOP: 184px" tabIndex="35"
				runat="server" Height="28px" Width="64px" Text="Edit Item" BackColor="#FFC0C0" Font-Names="Calibri" Font-Size="X-Small"></asp:button><asp:button id="BtnaddItm" style="Z-INDEX: 112; LEFT: 144px; POSITION: absolute; TOP: 184px"
				tabIndex="35" runat="server" Height="28px" Width="72px" Text="Add Item" BackColor="#FFC0C0" Font-Names="Calibri" Font-Size="X-Small"></asp:button><asp:dropdownlist id="LstSysRno" style="Z-INDEX: 111; LEFT: 328px; POSITION: absolute; TOP: 96px"
				tabIndex="2" runat="server" Height="24px" Width="76px"></asp:dropdownlist><asp:dropdownlist id="LstSysRtp" style="Z-INDEX: 110; LEFT: 328px; POSITION: absolute; TOP: 72px"
				tabIndex="2" runat="server" Height="24px" Width="76px" AutoPostBack="True"></asp:dropdownlist><asp:textbox id="Txtdes2" style="Z-INDEX: 109; LEFT: 328px; POSITION: absolute; TOP: 144px" tabIndex="1"
				runat="server" BackColor="White" Height="24px" Width="322px" Font-Names="Calibri" Font-Size="X-Small"></asp:textbox><asp:textbox id="Txtdes1" style="Z-INDEX: 108; LEFT: 328px; POSITION: absolute; TOP: 120px" tabIndex="1"
				runat="server" BackColor="White" Height="24px" Width="322px" Font-Names="Calibri" Font-Size="X-Small"></asp:textbox><asp:button id="BTNADD" style="Z-INDEX: 103; LEFT: 296px; POSITION: absolute; TOP: 184px" tabIndex="35"
				runat="server" Height="28px" Width="64px" Text="Save" BackColor="#FFC0C0" Font-Names="Calibri" Font-Size="X-Small"></asp:button><asp:button id="Btnser" style="Z-INDEX: 102; LEFT: 416px; POSITION: absolute; TOP: 96px" tabIndex="36"
				runat="server" Height="20px" Width="48px" Text="SERCH" BackColor="#FFC0C0" Font-Names="Calibri" Font-Size="X-Small"></asp:button><asp:panel id="Panel2" style="Z-INDEX: 101; LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server"
				BackColor="Desktop" Height="48px" Width="956px">Sys Mast</asp:panel>
			<asp:label id="Label1" style="Z-INDEX: 104; LEFT: 144px; POSITION: absolute; TOP: 72px" runat="server"
				Height="16px" Width="144px" Font-Names="Calibri" Font-Size="X-Small">Record Type</asp:label><asp:label id="Label2" style="Z-INDEX: 105; LEFT: 144px; POSITION: absolute; TOP: 96px" runat="server"
				Height="24px" Width="144px" Font-Names="Calibri" Font-Size="X-Small">Record No</asp:label><asp:label id="Label3" style="Z-INDEX: 106; LEFT: 144px; POSITION: absolute; TOP: 128px" runat="server"
				Height="8px" Width="144px" Font-Names="Calibri" Font-Size="X-Small">Description 1</asp:label><asp:label id="Label4" style="Z-INDEX: 107; LEFT: 144px; POSITION: absolute; TOP: 152px" runat="server"
				Height="24px" Width="152px" Font-Names="Calibri" Font-Size="X-Small">Description 2</asp:label><asp:textbox id="Txtrtp" style="Z-INDEX: 113; LEFT: 328px; POSITION: absolute; TOP: 72px" runat="server"
				Width="70px" Font-Names="Calibri" Font-Size="X-Small"></asp:textbox><asp:textbox id="TxtRno" style="Z-INDEX: 114; LEFT: 328px; POSITION: absolute; TOP: 96px" runat="server"
				Width="76px" Font-Names="Calibri" Font-Size="X-Small"></asp:textbox>
			<asp:panel id="Panel4" style="Z-INDEX: 127; LEFT: -8px; POSITION: absolute; TOP: 536px" runat="server"
				Width="944px" Height="48px" BackColor="Desktop"></asp:panel>
			<DIV id="Layer1" style="Z-INDEX: 128; LEFT: 144px; OVERFLOW: scroll; WIDTH: 736px; POSITION: absolute; TOP: 224px; HEIGHT: 236px">
				<asp:datagrid id="MyDataGrid" runat="server" Width="712px" Height="8px" BackColor="White" ForeColor="Black"
					Font-Names="Calibri" Font-Size="Small" BorderColor="#DEDFDE" BorderWidth="1px" BorderStyle="None"
					OnDeleteCommand="MyDataGrid_DeleteCommand" OnUpdateCommand="MyDataGrid_UpdateCommand" OnCancelcommand="MyDataGrid_Cancel"
					OnEditcommand="MyDataGrid_EditCommand" AutogenerateColumns="False" Font-Name="Calibri" Headerstyle-Font-Bold="True"
					Headerstyle-Font-Size="10" Headerstyle-Font-Name="Calibri" Headerstyle-BackColor="#8080C0"
					cellpadding="1" GridLines="Vertical">
					<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#CE5D5A"></SelectedItemStyle>
					<AlternatingItemStyle BackColor="White"></AlternatingItemStyle>
					<ItemStyle Font-Size="Smaller" BackColor="#F7F7DE"></ItemStyle>
					<HeaderStyle Font-Size="10pt" Font-Names="Calibri" ForeColor="White" BackColor="#6B696B"></HeaderStyle>
					<FooterStyle BackColor="#CCCC99"></FooterStyle>
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
						<asp:BoundColumn Visible="False" DataField="Id" HeaderText="ID">
							<HeaderStyle Width="3in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Sys_Rtp" HeaderText="Record Type">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Sys_Rno" HeaderText="Record #">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Sys_Des1" HeaderText="Description 1 ">
							<HeaderStyle Width="2.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Sys_Des2" HeaderText="Description 2">
							<HeaderStyle Width="2.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Right" ForeColor="Black" BackColor="#F7F7DE" Mode="NumericPages"></PagerStyle>
				</asp:datagrid></DIV>
		</form>
	</body>
</HTML>
