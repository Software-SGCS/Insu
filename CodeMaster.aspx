<%@ Page Language="vb" AutoEventWireup="false" Codebehind="CodeMaster.aspx.vb" Inherits="Insu.CodeMaster" %>
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
			<asp:label id="Label1" style="Z-INDEX: 114; LEFT: 144px; POSITION: absolute; TOP: 88px" runat="server"
				Width="106px" Height="20px" Font-Size="X-Small" Font-Names="Calibri"> Item Code</asp:label>
			<DIV id="Layer1" style="Z-INDEX: 127; LEFT: 144px; OVERFLOW: scroll; WIDTH: 736px; POSITION: absolute; TOP: 280px; HEIGHT: 236px"><asp:datagrid id="MyDataGrid" runat="server" Width="712px" Height="8px" BackColor="White" ForeColor="Black"
					Font-Size="Small" Font-Names="Calibri" GridLines="Vertical" cellpadding="1" Headerstyle-BackColor="#8080C0" Headerstyle-Font-Name="Calibri" Headerstyle-Font-Size="10" Headerstyle-Font-Bold="True" Font-Name="Calibri"
					AutogenerateColumns="False" OnEditcommand="MyDataGrid_EditCommand" OnCancelcommand="MyDataGrid_Cancel" OnUpdateCommand="MyDataGrid_UpdateCommand" OnDeleteCommand="MyDataGrid_DeleteCommand" BorderStyle="None" BorderWidth="1px"
					BorderColor="#DEDFDE">
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
						<asp:BoundColumn DataField="ItmNo" HeaderText="Item #">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="ItmDes" HeaderText="Description">
							<HeaderStyle Width="3in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="CatNo" HeaderText="Category ">
							<HeaderStyle Width="0.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Spri" HeaderText="Sale Price">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Cpri" HeaderText="Cost Price">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="stk" HeaderText="Stock">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Right" ForeColor="Black" BackColor="#F7F7DE" Mode="NumericPages"></PagerStyle>
				</asp:datagrid></DIV>
			<asp:panel id="Panel3" style="Z-INDEX: 126; LEFT: 8px; POSITION: absolute; TOP: 520px" runat="server"
				Width="882px" Height="48px" BackColor="Desktop"></asp:panel><asp:label id="Label8" style="Z-INDEX: 125; LEFT: 144px; POSITION: absolute; TOP: 200px" runat="server"
				Width="144px" Height="20px" Font-Size="X-Small" Font-Names="Calibri">Discount(%)</asp:label><asp:label id="Label7" style="Z-INDEX: 124; LEFT: 16px; POSITION: absolute; TOP: 16px" runat="server"
				Width="248px" Height="32px" BackColor="Desktop" ForeColor="White" Font-Bold="True" Font-Size="Larger">Code Master File</asp:label><asp:textbox id="TxtQty" style="Z-INDEX: 123; LEFT: 296px; POSITION: absolute; TOP: 216px" tabIndex="1"
				runat="server" Width="40px" Height="20px" BackColor="White" Font-Size="X-Small" Font-Names="Calibri"></asp:textbox><asp:label id="Label6" style="Z-INDEX: 122; LEFT: 144px; POSITION: absolute; TOP: 224px" runat="server"
				Width="120px" Height="20px" Font-Size="X-Small" Font-Names="Calibri">Stock Qty</asp:label><asp:textbox id="TxtSPri" style="Z-INDEX: 121; LEFT: 296px; POSITION: absolute; TOP: 168px" tabIndex="1"
				runat="server" Width="96px" Height="20px" BackColor="White" Font-Size="X-Small" Font-Names="Calibri"></asp:textbox><asp:label id="Label5" style="Z-INDEX: 120; LEFT: 144px; POSITION: absolute; TOP: 176px" runat="server"
				Width="144px" Height="20px" Font-Size="X-Small" Font-Names="Calibri">Sales Price (Rs)</asp:label><asp:textbox id="TxtCpri" style="Z-INDEX: 108; LEFT: 296px; POSITION: absolute; TOP: 144px" tabIndex="1"
				runat="server" Width="96px" Height="20px" BackColor="White" Font-Size="X-Small" Font-Names="Calibri"></asp:textbox><asp:button id="BtnRefres" style="Z-INDEX: 119; LEFT: 592px; POSITION: absolute; TOP: 248px"
				tabIndex="35" runat="server" Width="76px" Height="20px" BackColor="#FFC0C0" Font-Size="X-Small" Text="Refresh" Font-Names="Calibri"></asp:button><asp:button id="BtnDel" style="Z-INDEX: 116; LEFT: 488px; POSITION: absolute; TOP: 248px" tabIndex="35"
				runat="server" Width="76px" Height="20px" BackColor="#FFC0C0" Font-Size="X-Small" Text="Delete" Font-Names="Calibri"></asp:button><asp:dropdownlist id="LstCatNo" style="Z-INDEX: 115; LEFT: 296px; POSITION: absolute; TOP: 64px" tabIndex="2"
				runat="server" Width="126px" Height="20px" Font-Size="X-Small" AutoPostBack="True" Font-Names="Calibri"></asp:dropdownlist><asp:dropdownlist id="LstItmNo" style="Z-INDEX: 109; LEFT: 296px; POSITION: absolute; TOP: 88px" tabIndex="2"
				runat="server" Width="376px" Height="16px" AutoPostBack="True" Font-Names="Calibri" Font-Size="X-Small"></asp:dropdownlist><asp:textbox id="TxtItmNo" style="Z-INDEX: 111; LEFT: 296px; POSITION: absolute; TOP: 88px" runat="server"
				Width="80px" Height="20px" Font-Size="X-Small" Font-Names="Calibri"></asp:textbox><asp:label id="Label2" style="Z-INDEX: 103; LEFT: 144px; POSITION: absolute; TOP: 64px" runat="server"
				Width="106px" Height="20px" Font-Size="X-Small" Font-Names="Calibri">Category Code</asp:label><asp:textbox id="TxtDepNo" style="Z-INDEX: 112; LEFT: 296px; POSITION: absolute; TOP: 64px" runat="server"
				Width="126px" Visible="False"></asp:textbox><asp:button id="Btnser" style="Z-INDEX: 101; LEFT: 680px; POSITION: absolute; TOP: 88px" tabIndex="36"
				runat="server" Width="56px" Height="24px" Font-Size="X-Small" Text="SERCH" Font-Names="Calibri"></asp:button><asp:label id="Label3" style="Z-INDEX: 104; LEFT: 144px; POSITION: absolute; TOP: 112px" runat="server"
				Width="128px" Height="20px" Font-Size="X-Small" Font-Names="Calibri">Item Description</asp:label><asp:textbox id="TxtDes" style="Z-INDEX: 106; LEFT: 296px; POSITION: absolute; TOP: 112px" tabIndex="1"
				runat="server" Width="315px" Height="20px" BackColor="White" Font-Size="X-Small" AutoPostBack="True" Font-Names="Calibri"></asp:textbox><asp:label id="Label4" style="Z-INDEX: 105; LEFT: 144px; POSITION: absolute; TOP: 144px" runat="server"
				Width="144px" Height="20px" Font-Size="X-Small" Font-Names="Calibri">Cost Price (Rs)</asp:label><asp:textbox id="TxtDis" style="Z-INDEX: 107; LEFT: 296px; POSITION: absolute; TOP: 192px" tabIndex="1"
				runat="server" Width="24px" Height="20px" BackColor="White" Font-Size="X-Small" Font-Names="Calibri"></asp:textbox><asp:button id="BTNADD" style="Z-INDEX: 102; LEFT: 376px; POSITION: absolute; TOP: 248px" tabIndex="35"
				runat="server" Width="76px" Height="20px" BackColor="#FFC0C0" Font-Size="X-Small" Text="Update" Font-Names="Calibri"></asp:button><asp:button id="BtnaddItm" style="Z-INDEX: 110; LEFT: 144px; POSITION: absolute; TOP: 248px"
				tabIndex="35" runat="server" Width="84px" Height="20px" BackColor="#FFC0C0" Font-Size="X-Small" Text="Add Item" Font-Names="Calibri"></asp:button><asp:button id="BtnEdit" style="Z-INDEX: 113; LEFT: 256px; POSITION: absolute; TOP: 248px" tabIndex="35"
				runat="server" Width="84px" Height="20px" BackColor="#FFC0C0" Font-Size="X-Small" Text="Edit Item" Font-Names="Calibri"></asp:button><asp:panel id="Panel1" style="Z-INDEX: 117; LEFT: 8px; POSITION: absolute; TOP: 8px" runat="server"
				Width="880px" Height="40px" BackColor="Desktop"></asp:panel><asp:panel id="Panel2" style="Z-INDEX: 118; LEFT: 8px; POSITION: absolute; TOP: 48px" runat="server"
				Width="120px" Height="466px" BackColor="Desktop" BackImageUrl="Menu/Audit.gif"></asp:panel></form>
	</body>
</HTML>
