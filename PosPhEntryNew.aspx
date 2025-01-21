<%@ Page Language="vb" AutoEventWireup="false" Codebehind="PosPhEntryNew.aspx.vb" Inherits="Insu.PosPhEntryNew" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>DataEntry1</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="#f0f8ff" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:panel id="Panel2" style="Z-INDEX: 106; LEFT: 24px; POSITION: absolute; TOP: -8px" runat="server"
				BackColor="Navy" Width="944px" Height="8px"></asp:panel><asp:panel id="Panel3" style="Z-INDEX: 103; LEFT: -8px; POSITION: absolute; TOP: 0px" runat="server"
				Width="32px" Height="524px" BackColor="Navy">
				<asp:label id="Label3" style="Z-INDEX: 101; LEFT: 56px; POSITION: absolute; TOP: 80px" runat="server"
					Height="24px" Width="104px" BackColor="Lavender" Font-Bold="True">Category</asp:label>
				<asp:dropdownlist id="LstCat" style="Z-INDEX: 107; LEFT: 168px; POSITION: absolute; TOP: 80px" runat="server"
					Height="16px" Width="304px" AutoPostBack="True"></asp:dropdownlist>
				<asp:textbox id="TxtYr" style="Z-INDEX: 117; LEFT: 480px; POSITION: absolute; TOP: 80px" runat="server"
					Height="24px" Width="56px" Visible="False"></asp:textbox>
				<asp:textbox id="TxtMt" style="Z-INDEX: 106; LEFT: 544px; POSITION: absolute; TOP: 80px" runat="server"
					Height="24px" Width="32px" Visible="False"></asp:textbox>
				<asp:imagebutton id="ImageButton3" style="Z-INDEX: 118; LEFT: 200px; POSITION: absolute; TOP: 488px"
					runat="server" Height="24px" Width="80px" ImageUrl="iCO\print.jpg"></asp:imagebutton>
				<asp:TextBox id="TxtVal2" style="Z-INDEX: 119; LEFT: 520px; POSITION: absolute; TOP: 496px" runat="server"
					Width="80px"></asp:TextBox>
				<asp:TextBox id="TxtVal3" style="Z-INDEX: 120; LEFT: 608px; POSITION: absolute; TOP: 496px" runat="server"
					Width="80px"></asp:TextBox>
			</asp:panel><asp:panel id="Panel7" style="Z-INDEX: 102; LEFT: 24px; POSITION: absolute; TOP: 32px" runat="server"
				BackColor="Navy" Width="944px" Height="16px"></asp:panel>
			<DIV style="Z-INDEX: 107; LEFT: 16px; WIDTH: 944px; POSITION: absolute; TOP: 8px; HEIGHT: 24px"
				align="left" ms_positioning="FlowLayout"><FONT face="Tahoma"><FONT size="5"><FONT size="4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
							Entry&nbsp;Physical Stock</FONT></FONT></FONT></DIV>
			<div id="Layer1" style="Z-INDEX: 101; LEFT: 32px; OVERFLOW: scroll; WIDTH: 784px; POSITION: relative; TOP: 152px; HEIGHT: 304px"><asp:datagrid id="DataGrid1" runat="server" BackColor="White" Width="776px" Height="60px" BorderColor="#E7E7FF"
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
						<asp:BoundColumn Visible="False" DataField="Raw_Rtn" HeaderText="Physical Stock">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="Raw_Dmg" HeaderText="Physical Stock">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:TemplateColumn HeaderText="Material Code">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Raw_ItmCode" runat="server" Height="16px" Width="50px">Label</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Description">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Raw_des" runat="server" Height="16px" Width="250px">Label</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Sales Price">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Itm_Pri" runat="server" Width="50px" BackColor="White"></asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Operninig Stock">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Raw_OpStk" runat="server" Width="50px" BackColor="White"></asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Stock on Hand">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Raw_Soh" runat="server" Width="50px" BackColor="White"></asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Physical Stock">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:TextBox id="Raw_PhStock" runat="server" Width="50px" BackColor="White"></asp:TextBox>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="T1">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:TextBox id="Raw_Rec" runat="server" Width="50px" BackColor="White"></asp:TextBox>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="T2">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:TextBox id="Raw_Rtn" runat="server" Width="50px" BackColor="White"></asp:TextBox>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="T3">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:TextBox id="Raw_Dmg" runat="server" Width="50px" BackColor="White"></asp:TextBox>
							</ItemTemplate>
						</asp:TemplateColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages"></PagerStyle>
				</asp:datagrid></div>
			<asp:panel id="Panel4" style="Z-INDEX: 109; LEFT: 0px; POSITION: absolute; TOP: 526px" runat="server"
				BackColor="Navy" Width="968px" Height="43px"></asp:panel><asp:label id="Label7" style="Z-INDEX: 104; LEFT: -32000px; POSITION: absolute; TOP: -32000px"
				runat="server" Width="88px" Height="16px">Label</asp:label><asp:button id="BtnUpdate" style="Z-INDEX: 105; LEFT: 48px; POSITION: absolute; TOP: 488px"
				runat="server" Width="80px" Text="Update"></asp:button><asp:panel id="Panel1" style="Z-INDEX: 108; LEFT: 832px; POSITION: absolute; TOP: 48px" runat="server"
				BackColor="Navy" Width="136px" Height="523px" BackImageUrl="Menu/DSINEW1.JPG"></asp:panel>
			<asp:TextBox id="TxtQty3" style="Z-INDEX: 110; LEFT: 624px; POSITION: absolute; TOP: 472px" runat="server"
				Width="56px"></asp:TextBox>
			<asp:TextBox id="TxtQty2" style="Z-INDEX: 111; LEFT: 536px; POSITION: absolute; TOP: 472px" runat="server"
				Width="56px"></asp:TextBox>
			<asp:TextBox id="TxtQty1" style="Z-INDEX: 112; LEFT: 448px; POSITION: absolute; TOP: 472px" runat="server"
				Width="56px"></asp:TextBox>
			<asp:Label id="Label1" style="Z-INDEX: 113; LEFT: 344px; POSITION: absolute; TOP: 472px" runat="server"
				Height="16px" Width="32px">Qty</asp:Label>
			<asp:Label id="Label4" style="Z-INDEX: 114; LEFT: 344px; POSITION: absolute; TOP: 504px" runat="server"
				Height="16px" Width="64px">Value</asp:Label>
			<asp:TextBox id="TxtVal1" style="Z-INDEX: 115; LEFT: 424px; POSITION: absolute; TOP: 496px" runat="server"
				Width="80px"></asp:TextBox></form>
	</body>
</HTML>
