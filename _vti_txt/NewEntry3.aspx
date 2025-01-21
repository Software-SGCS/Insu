<%@ Page Language="vb" AutoEventWireup="false" Codebehind="NewEntry3.aspx.vb" Inherits="Insu.NewEntry3" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>NewEntry1</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="VBScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="#f0f8ff" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:dropdownlist id="LstCat" style="Z-INDEX: 101; LEFT: 160px; POSITION: absolute; TOP: 72px" runat="server"
				Width="416px" Height="24px" AutoPostBack="True"></asp:dropdownlist><asp:panel id="Panel11" style="Z-INDEX: 110; LEFT: 8px; POSITION: absolute; TOP: 562px" runat="server"
				Width="1056px" Height="57px" BackColor="Navy"></asp:panel><asp:panel id="Panel10" style="Z-INDEX: 109; LEFT: 920px; POSITION: absolute; TOP: 64px" runat="server"
				Width="144px" Height="536px" BackColor="Navy"></asp:panel><asp:panel id="Panel9" style="Z-INDEX: 108; LEFT: 8px; POSITION: absolute; TOP: 0px" runat="server"
				Width="1056px" Height="16px" BackColor="Navy"></asp:panel><asp:label id="Company" style="Z-INDEX: 102; LEFT: 8px; POSITION: absolute; TOP: 72px" runat="server"
				Width="104px" Height="24px">Company</asp:label>
			<DIV id="Layer1" style="Z-INDEX: 103; LEFT: 0px; OVERFLOW: scroll; WIDTH: 784px; POSITION: relative; TOP: 112px; HEIGHT: 376px"><asp:datagrid id="DataGrid1" runat="server" Width="776px" Height="60px" BackColor="White" BorderColor="#E7E7FF"
					BorderWidth="1px" AutoGenerateColumns="False" BorderStyle="None" CellPadding="3" GridLines="Horizontal" ShowFooter="True" Font-Size="Small">
					<SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
					<AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
					<ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
					<HeaderStyle Font-Size="X-Small" Font-Names="Tahoma" Font-Bold="True" Wrap="False" ForeColor="#F7F7F7"
						BackColor="#4A3C8C"></HeaderStyle>
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
								<asp:Label id="Raw_des" runat="server" Width="30px" Height="16px">Label</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Name">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Itm_Pri" runat="server" Width="200px">Label</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Old EpfNo">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Raw_OpStk" runat="server" Width="30px">Label</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn Visible="False" HeaderText="Cheque No">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:TextBox id="Raw_Rec" runat="server" Width="66px" BackColor="White"></asp:TextBox>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Active">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:TextBox id="Raw_PhStock" runat="server" Width="26px" BackColor="White"></asp:TextBox>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn Visible="True" HeaderText="Delete">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:TextBox id="Raw_Soh" runat="server" Width="26px" BackColor="White"></asp:TextBox>
							</ItemTemplate>
						</asp:TemplateColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages"></PagerStyle>
				</asp:datagrid></DIV>
			<asp:button id="ButSub" style="Z-INDEX: 104; LEFT: 16px; POSITION: absolute; TOP: 512px" runat="server"
				Width="80px" Text="Update"></asp:button><asp:panel id="Panel6" style="Z-INDEX: 106; LEFT: 8px; POSITION: absolute; TOP: 16px" runat="server"
				Width="976px" Height="24px">&nbsp;<FONT face="Tahoma" size="4"><STRONG>Employees-DDF</STRONG></FONT></asp:panel>
			<asp:panel id="Panel8" style="Z-INDEX: 107; LEFT: 8px; POSITION: absolute; TOP: 48px" runat="server"
				Width="1056px" Height="16px" BackColor="Navy"></asp:panel><asp:label id="L1" style="Z-INDEX: 115; LEFT: 800px; POSITION: absolute; TOP: 520px" runat="server"
				Width="104px" Height="24px"></asp:label></form>
	</body>
</HTML>
