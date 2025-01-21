<%@ Page Language="vb" AutoEventWireup="false" Codebehind="PosEntrySupply.aspx.vb" Inherits="Insu.PosEntrySupply" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Outword</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="#f0f8ff" leftMargin="0" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:panel id="Panel3" style="Z-INDEX: 121; LEFT: -8px; POSITION: absolute; TOP: 0px" runat="server"
				Height="650px" Width="24px" BackColor="Navy">
				<asp:panel id="Panel8" style="Z-INDEX: 117; LEFT: 24px; POSITION: absolute; TOP: 440px" runat="server"
					BackColor="Navy" Width="952px" Height="46px">Panel 
<asp:panel id="Panel5" runat="server" Width="890px" Height="62px">Panel</asp:panel></asp:panel>
			</asp:panel><asp:label id="Label3" style="Z-INDEX: 105; LEFT: 32px; POSITION: absolute; TOP: 248px" runat="server"
				Height="11px" Width="120px" Visible="False" Font-Names="Calibri" Font-Size="X-Small">Credit Limit(Days)</asp:label>
			<DIV id="Layer1" style="Z-INDEX: 101; LEFT: 24px; OVERFLOW: scroll; WIDTH: 728px; POSITION: absolute; TOP: 280px; HEIGHT: 166px"><asp:datagrid id="MyDataGrid" runat="server" Height="12px" Width="760px" BackColor="White" cellpadding="3"
					Headerstyle-BackColor="#8080C0" Headerstyle-Font-Name="Tahoma" Headerstyle-Font-Size="12" Headerstyle-Font-Bold="True" Font-Name="Tahoma" Font-Size="12pt" AutogenerateColumns="False" OnEditcommand="MyDataGrid_EditCommand"
					OnCancelcommand="MyDataGrid_Cancel" OnUpdateCommand="MyDataGrid_UpdateCommand" OnDeleteCommand="MyDataGrid_DeleteCommand" DataKeyField="id" Font-Names="Calibri" BorderStyle="None" BorderWidth="1px" GridLines="Horizontal"
					Font-Bold="True" BorderColor="#E7E7FF">
					<SelectedItemStyle Font-Size="Smaller" Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
					<EditItemStyle Font-Size="Smaller"></EditItemStyle>
					<AlternatingItemStyle Font-Size="Smaller" BackColor="#F7F7F7"></AlternatingItemStyle>
					<ItemStyle Font-Size="X-Small" Font-Names="Calibri" ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
					<HeaderStyle Font-Size="10pt" Font-Names="Tahoma" Font-Bold="True" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
					<FooterStyle ForeColor="#4A3C8C" BackColor="#B5C7DE"></FooterStyle>
					<Columns>
						<asp:TemplateColumn Visible="False">
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
						<asp:BoundColumn DataField="Com_No" HeaderText="Code">
							<HeaderStyle Width="0.8in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Com_Nam" HeaderText="Supply Name">
							<HeaderStyle Width="3.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Com_Add1" HeaderText="Supply Address">
							<HeaderStyle Width="2in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Com_Email" HeaderText="E_Mail   ">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
				</asp:datagrid></DIV>
			<asp:button id="BtnEdit" style="Z-INDEX: 102; LEFT: 80px; POSITION: absolute; TOP: 584px" tabIndex="8"
				runat="server" Width="64px" Font-Bold="True" Text="Edit" Visible="False" Enabled="False"></asp:button><asp:button id="BtnSave" style="Z-INDEX: 106; LEFT: 320px; POSITION: absolute; TOP: 584px" tabIndex="11"
				runat="server" Width="64px" Font-Bold="True" Text="Save" Visible="False" Enabled="False"></asp:button><asp:button id="BtnCle" style="Z-INDEX: 103; LEFT: 152px; POSITION: absolute; TOP: 584px" tabIndex="9"
				runat="server" Height="24px" Width="72px" Font-Bold="True" Text="Clear" Visible="False" Enabled="False"></asp:button><asp:button id="BtnAdd" style="Z-INDEX: 100; LEFT: 8px; POSITION: absolute; TOP: 584px" tabIndex="7"
				runat="server" Width="64px" Font-Bold="True" Text="Add" Visible="False" Enabled="False"></asp:button><asp:button id="BtnDel" style="Z-INDEX: 104; LEFT: 240px; POSITION: absolute; TOP: 584px" tabIndex="11"
				runat="server" Width="64px" Font-Bold="True" Text="Delete" Visible="False" Enabled="False"></asp:button><asp:textbox id="TxtTelno" style="Z-INDEX: 107; LEFT: 448px; POSITION: absolute; TOP: 248px"
				runat="server" Width="256px" Visible="False" Font-Names="Calibri"></asp:textbox><asp:textbox id="TxtComNam" style="Z-INDEX: 108; LEFT: 432px; POSITION: absolute; TOP: 88px"
				tabIndex="3" runat="server" Width="288px" Font-Names="Calibri"></asp:textbox><asp:label id="Label9" style="Z-INDEX: 109; LEFT: 376px; POSITION: absolute; TOP: 208px" runat="server"
				Height="16px" Width="58px" Font-Names="Calibri" Font-Size="X-Small">E_mail</asp:label><asp:textbox id="TxtComPer" style="Z-INDEX: 110; LEFT: 168px; POSITION: absolute; TOP: 168px"
				tabIndex="10" runat="server" Width="248px" Font-Names="Calibri"></asp:textbox><asp:textbox id="TxtComAdd" style="Z-INDEX: 111; LEFT: 168px; POSITION: absolute; TOP: 128px"
				runat="server" Width="392px" Font-Names="Calibri"></asp:textbox><asp:textbox id="TxtComNo" style="Z-INDEX: 112; LEFT: 168px; POSITION: absolute; TOP: 88px" tabIndex="1"
				runat="server" Height="20px" Width="56px" AutoPostBack="True" Font-Names="Calibri"></asp:textbox><asp:textbox id="Txtemail" style="Z-INDEX: 113; LEFT: 448px; POSITION: absolute; TOP: 208px"
				tabIndex="4" runat="server" Width="256px" Font-Names="Calibri"></asp:textbox><asp:label id="Label8" style="Z-INDEX: 114; LEFT: 312px; POSITION: absolute; TOP: 88px" runat="server"
				Height="16px" Width="114px" Font-Names="Calibri" Font-Size="X-Small">Suppliers Name</asp:label><asp:label id="Invoice" style="Z-INDEX: 115; LEFT: 32px; POSITION: absolute; TOP: 88px" runat="server"
				Height="24px" Width="104px" Font-Names="Calibri" Font-Size="X-Small">Company Code</asp:label><asp:label id="Label11" style="Z-INDEX: 116; LEFT: 32px; POSITION: absolute; TOP: 168px" runat="server"
				Height="24px" Width="129px" Font-Names="Calibri" Font-Size="X-Small"> Contact Person</asp:label><asp:label id="Label10" style="Z-INDEX: 117; LEFT: 32px; POSITION: absolute; TOP: 136px" runat="server"
				Height="24px" Width="112px" Font-Names="Calibri" Font-Size="X-Small">Address</asp:label><asp:button id="Button1" style="Z-INDEX: 118; LEFT: 248px; POSITION: absolute; TOP: 88px" runat="server"
				Height="24px" Width="48px" Text="Search" Font-Names="Calibri"></asp:button><asp:button id="BttIns1" style="Z-INDEX: 119; LEFT: 720px; POSITION: absolute; TOP: 248px" runat="server"
				Height="24px" Width="56px" Text="Insert" Font-Names="Calibri" Font-Size="X-Small"></asp:button>
			<DIV style="Z-INDEX: 120; LEFT: 16px; WIDTH: 944px; POSITION: absolute; TOP: -32px; HEIGHT: 71px"
				align="left" ms_positioning="FlowLayout"><FONT face="Tahoma"><FONT size="5"><FONT size="4"><asp:panel id="Panel2" runat="server" Height="40px" Width="952px" BackColor="Navy">Panel</asp:panel>
							&nbsp;New&nbsp;Suppliers</FONT>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</FONT></FONT></DIV>
			<asp:panel id="Panel6" style="Z-INDEX: 123; LEFT: 784px; POSITION: absolute; TOP: 56px" runat="server"
				Height="384px" Width="184px" BackColor="Navy" BackImageUrl="Menu/DSINEW1.JPG">l 
<asp:Panel id="Panel7" style="Z-INDEX: 101; LEFT: -912px; POSITION: absolute; TOP: -16px" runat="server"
					BackColor="Navy" Width="1096px" Height="8px"></asp:Panel></asp:panel><asp:textbox id="TxtVat" style="Z-INDEX: 125; LEFT: 168px; POSITION: absolute; TOP: 208px" tabIndex="10"
				runat="server" Width="176px" Font-Names="Calibri"></asp:textbox><asp:textbox id="TxtCrd" style="Z-INDEX: 126; LEFT: 168px; POSITION: absolute; TOP: 248px" tabIndex="4"
				runat="server" Width="32px" Visible="False" Font-Names="Calibri"></asp:textbox><asp:label id="Label1" style="Z-INDEX: 127; LEFT: 32px; POSITION: absolute; TOP: 208px" runat="server"
				Height="24px" Width="128px" Font-Names="Calibri" Font-Size="X-Small">Vat Registration No</asp:label><asp:label id="Label2" style="Z-INDEX: 128; LEFT: 376px; POSITION: absolute; TOP: 248px" runat="server"
				Height="16px" Width="58px" Visible="False" Font-Names="Calibri" Font-Size="X-Small">TelNos</asp:label></form>
	</body>
</HTML>
