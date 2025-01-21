<%@ Page Language="vb" AutoEventWireup="false" Codebehind="EmpAdminMaster.aspx.vb" Inherits="Insu.EmpAdminMaster" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Code_Master</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body leftMargin="0" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:label id="Label1" style="Z-INDEX: 113; LEFT: 144px; POSITION: absolute; TOP: 88px" runat="server"
				Font-Names="Calibri" Font-Size="X-Small" Height="20px" Width="106px"> Employee</asp:label>
			<DIV id="Layer1" style="Z-INDEX: 123; LEFT: 144px; OVERFLOW: scroll; WIDTH: 736px; POSITION: absolute; TOP: 240px; HEIGHT: 236px"><asp:datagrid id="MyDataGrid" runat="server" Font-Names="Calibri" Font-Size="Small" Height="8px"
					Width="712px" BorderColor="#DEDFDE" BorderWidth="1px" BorderStyle="None" OnDeleteCommand="MyDataGrid_DeleteCommand" OnUpdateCommand="MyDataGrid_UpdateCommand" OnCancelcommand="MyDataGrid_Cancel" OnEditcommand="MyDataGrid_EditCommand"
					AutogenerateColumns="False" Font-Name="Calibri" Headerstyle-Font-Bold="True" Headerstyle-Font-Size="10" Headerstyle-Font-Name="Calibri" Headerstyle-BackColor="#8080C0" cellpadding="1" GridLines="Vertical" ForeColor="Black"
					BackColor="White">
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
						<asp:BoundColumn DataField="EmpNo" HeaderText="Emp #">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="EmpNam" HeaderText="Employee Name">
							<HeaderStyle Width="3in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="EmpEmail" HeaderText="Email ">
							<HeaderStyle Width="2.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="EmpContact" HeaderText="Contact No">
							<HeaderStyle Width="1.2in"></HeaderStyle>
							<ItemStyle HorizontalAlign="left"></ItemStyle>
						</asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Right" ForeColor="Black" BackColor="#F7F7DE" Mode="NumericPages"></PagerStyle>
				</asp:datagrid></DIV>
			<asp:panel id="Panel3" style="Z-INDEX: 122; LEFT: 8px; POSITION: absolute; TOP: 520px" runat="server"
				Height="48px" Width="882px" BackColor="Desktop"></asp:panel><asp:label id="Label7" style="Z-INDEX: 121; LEFT: 16px; POSITION: absolute; TOP: 16px" runat="server"
				Font-Size="Larger" Height="32px" Width="248px" ForeColor="White" BackColor="Desktop" Font-Bold="True"> Employee</asp:label><asp:textbox id="TxtContact" style="Z-INDEX: 120; LEFT: 296px; POSITION: absolute; TOP: 176px"
				tabIndex="1" runat="server" Font-Names="Calibri" Font-Size="X-Small" Height="20px" Width="128px" BackColor="White"></asp:textbox><asp:label id="Label5" style="Z-INDEX: 119; LEFT: 144px; POSITION: absolute; TOP: 176px" runat="server"
				Font-Names="Calibri" Font-Size="X-Small" Height="20px" Width="144px"> Contact No</asp:label><asp:textbox id="TxtEmail" style="Z-INDEX: 107; LEFT: 296px; POSITION: absolute; TOP: 144px"
				tabIndex="1" runat="server" Font-Names="Calibri" Font-Size="X-Small" Height="20px" Width="312px" BackColor="White"></asp:textbox><asp:button id="BtnRefres" style="Z-INDEX: 118; LEFT: 592px; POSITION: absolute; TOP: 208px"
				tabIndex="35" runat="server" Font-Names="Calibri" Font-Size="X-Small" Height="20px" Width="76px" BackColor="#FFC0C0" Text="Refresh"></asp:button><asp:button id="BtnDel" style="Z-INDEX: 115; LEFT: 488px; POSITION: absolute; TOP: 208px" tabIndex="35"
				runat="server" Font-Names="Calibri" Font-Size="X-Small" Height="20px" Width="76px" BackColor="#FFC0C0" Text="Delete"></asp:button><asp:dropdownlist id="LstCatNo" style="Z-INDEX: 114; LEFT: 296px; POSITION: absolute; TOP: 64px" tabIndex="2"
				runat="server" Font-Names="Calibri" Font-Size="X-Small" Height="20px" Width="126px" AutoPostBack="True"></asp:dropdownlist><asp:dropdownlist id="LstItmNo" style="Z-INDEX: 108; LEFT: 296px; POSITION: absolute; TOP: 88px" tabIndex="2"
				runat="server" Font-Names="Calibri" Font-Size="X-Small" Height="16px" Width="376px" AutoPostBack="True"></asp:dropdownlist><asp:textbox id="TxtEmpNo" style="Z-INDEX: 110; LEFT: 296px; POSITION: absolute; TOP: 88px" runat="server"
				Font-Names="Calibri" Font-Size="X-Small" Height="20px" Width="40px"></asp:textbox><asp:label id="Label2" style="Z-INDEX: 103; LEFT: 144px; POSITION: absolute; TOP: 64px" runat="server"
				Font-Names="Calibri" Font-Size="X-Small" Height="20px" Width="106px"> Department</asp:label><asp:textbox id="TxtDepNo" style="Z-INDEX: 111; LEFT: 296px; POSITION: absolute; TOP: 64px" runat="server"
				Width="120px" Visible="False"></asp:textbox><asp:button id="Btnser" style="Z-INDEX: 101; LEFT: 680px; POSITION: absolute; TOP: 88px" tabIndex="36"
				runat="server" Font-Names="Calibri" Font-Size="X-Small" Height="24px" Width="56px" Text="SERCH"></asp:button><asp:label id="Label3" style="Z-INDEX: 104; LEFT: 144px; POSITION: absolute; TOP: 112px" runat="server"
				Font-Names="Calibri" Font-Size="X-Small" Height="20px" Width="128px">Name</asp:label><asp:textbox id="TxtNam" style="Z-INDEX: 106; LEFT: 296px; POSITION: absolute; TOP: 112px" tabIndex="1"
				runat="server" Font-Names="Calibri" Font-Size="X-Small" Height="20px" Width="376px" BackColor="White" AutoPostBack="True"></asp:textbox><asp:label id="Label4" style="Z-INDEX: 105; LEFT: 144px; POSITION: absolute; TOP: 144px" runat="server"
				Font-Names="Calibri" Font-Size="X-Small" Height="20px" Width="144px"> Email</asp:label><asp:button id="BTNADD" style="Z-INDEX: 102; LEFT: 376px; POSITION: absolute; TOP: 208px" tabIndex="35"
				runat="server" Font-Names="Calibri" Font-Size="X-Small" Height="20px" Width="76px" BackColor="#FFC0C0" Text="Update"></asp:button><asp:button id="BtnaddItm" style="Z-INDEX: 109; LEFT: 144px; POSITION: absolute; TOP: 208px"
				tabIndex="35" runat="server" Font-Names="Calibri" Font-Size="X-Small" Height="20px" Width="84px" BackColor="#FFC0C0" Text="Add Item"></asp:button><asp:button id="BtnEdit" style="Z-INDEX: 112; LEFT: 256px; POSITION: absolute; TOP: 208px" tabIndex="35"
				runat="server" Font-Names="Calibri" Font-Size="X-Small" Height="20px" Width="84px" BackColor="#FFC0C0" Text="Edit Item"></asp:button><asp:panel id="Panel1" style="Z-INDEX: 116; LEFT: 8px; POSITION: absolute; TOP: 8px" runat="server"
				Height="40px" Width="880px" BackColor="Desktop"></asp:panel><asp:panel id="Panel2" style="Z-INDEX: 117; LEFT: 8px; POSITION: absolute; TOP: 48px" runat="server"
				Height="466px" Width="120px" BackColor="Desktop" BackImageUrl="Menu/Audit.gif"></asp:panel>
			<asp:TextBox id="TxtCat" style="Z-INDEX: 124; LEFT: 448px; POSITION: absolute; TOP: 64px" runat="server"
				Width="40px" Visible="False"></asp:TextBox></form>
	</body>
</HTML>
