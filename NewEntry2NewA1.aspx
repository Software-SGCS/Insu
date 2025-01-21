<%@ Page Language="vb" AutoEventWireup="false" Codebehind="NewEntry2NewA1.aspx.vb" Inherits="Insu.NewEntry2NewA1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>NewEntry1</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="VBScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="#3399cc" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:dropdownlist id="LstCat" style="Z-INDEX: 101; LEFT: 256px; POSITION: absolute; TOP: 72px" runat="server"
				AutoPostBack="True" Height="24px" Width="416px"></asp:dropdownlist><asp:panel id="Panel11" style="Z-INDEX: 110; LEFT: 8px; POSITION: absolute; TOP: 562px" runat="server"
				Height="57px" Width="1056px" BackColor="Navy"></asp:panel><asp:panel id="Panel10" style="Z-INDEX: 109; LEFT: 920px; POSITION: absolute; TOP: 64px" runat="server"
				Height="536px" Width="144px" BackColor="Navy"></asp:panel><asp:panel id="Panel9" style="Z-INDEX: 108; LEFT: 8px; POSITION: absolute; TOP: 0px" runat="server"
				Height="16px" Width="1056px" BackColor="Navy"></asp:panel><asp:panel id="Panel5" style="Z-INDEX: 105; LEFT: 8px; POSITION: absolute; TOP: 16px" runat="server"
				Height="589px" Width="96px" BackColor="Navy"></asp:panel><asp:label id="Company" style="Z-INDEX: 102; LEFT: 136px; POSITION: absolute; TOP: 72px" runat="server"
				Height="24px" Width="104px">Company</asp:label>
			<DIV id="Layer1" style="Z-INDEX: 103; LEFT: 120px; OVERFLOW: scroll; WIDTH: 784px; POSITION: relative; TOP: 104px; HEIGHT: 376px"><asp:datagrid id="DataGrid1" runat="server" Height="60px" Width="776px" BackColor="LightGoldenrodYellow"
					Font-Size="Small" ShowFooter="True" GridLines="None" CellPadding="2" AutoGenerateColumns="False" BorderWidth="1px" BorderColor="Tan" ForeColor="Black">
					<SelectedItemStyle ForeColor="GhostWhite" BackColor="DarkSlateBlue"></SelectedItemStyle>
					<AlternatingItemStyle BackColor="PaleGoldenrod"></AlternatingItemStyle>
					<HeaderStyle Font-Size="X-Small" Font-Names="Tahoma" Font-Bold="True" Wrap="False" BackColor="Tan"></HeaderStyle>
					<FooterStyle BackColor="Tan"></FooterStyle>
					<Columns>
						<asp:BoundColumn Visible="False" DataField="Raw_ItmCode" HeaderText="Material Code">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="Raw_Des" HeaderText="Description">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="Itm_Pri" HeaderText="Sales Price">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="Raw_OpStk" HeaderText="Operning Stock">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="Raw_Soh" HeaderText="Stock On Hand">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="Raw_PhStock" HeaderText="Physical Stock">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="Raw_Rec" HeaderText="Stock On Hand">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:TemplateColumn Visible="False" HeaderText="Submit Date">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Raw_ItmCode" runat="server" Height="16px" Width="50px">Label</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Employee #">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Raw_des" runat="server" Height="16px" Width="50px">Label</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Name">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Itm_Pri" runat="server" Width="250px">Label</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Old EpfNo">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Raw_OpStk" runat="server" Width="50px">Label</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn Visible="False" HeaderText="Cheque No">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:TextBox id="Raw_Soh" runat="server" Width="66px" BackColor="White"></asp:TextBox>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Active">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:TextBox id="Raw_PhStock" runat="server" Width="66px" BackColor="White"></asp:TextBox>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn Visible="False" HeaderText="Claims Amount">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:TextBox id="Raw_Rec" runat="server" Width="74px" BackColor="White"></asp:TextBox>
							</ItemTemplate>
						</asp:TemplateColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Center" ForeColor="DarkSlateBlue" BackColor="PaleGoldenrod"></PagerStyle>
				</asp:datagrid></DIV>
			<asp:button id="ButSub" style="Z-INDEX: 104; LEFT: 128px; POSITION: absolute; TOP: 520px" runat="server"
				Width="80px" Text="Update"></asp:button><asp:panel id="Panel6" style="Z-INDEX: 106; LEFT: 112px; POSITION: absolute; TOP: 16px" runat="server"
				Height="24px" Width="952px">&nbsp;<STRONG><FONT face="Tahoma" size="5">Employees-Health</FONT></STRONG></asp:panel>
			<asp:panel id="Panel8" style="Z-INDEX: 107; LEFT: 8px; POSITION: absolute; TOP: 48px" runat="server"
				Height="16px" Width="1056px" BackColor="Navy"></asp:panel>
			<asp:Label id="L1" style="Z-INDEX: 115; LEFT: 800px; POSITION: absolute; TOP: 520px" runat="server"
				Height="24px" Width="104px"></asp:Label></form>
	</body>
</HTML>
