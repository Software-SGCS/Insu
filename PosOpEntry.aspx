<%@ Page Language="vb" AutoEventWireup="false" Codebehind="PosOpEntry.aspx.vb" Inherits="Insu.PosOpEntry" %>
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
			<asp:panel id="Panel2" style="Z-INDEX: 106; LEFT: 16px; POSITION: absolute; TOP: -8px" runat="server"
				Height="8px" Width="944px" BackColor="Navy"></asp:panel><asp:panel id="Panel3" style="Z-INDEX: 103; LEFT: -8px; POSITION: absolute; TOP: 0px" runat="server"
				Height="524px" Width="24px" BackColor="Navy">
				<asp:dropdownlist id="LstCat" style="Z-INDEX: 101; LEFT: 160px; POSITION: absolute; TOP: 80px" runat="server"
					Width="320px" Height="16px" AutoPostBack="True"></asp:dropdownlist>
				<asp:textbox id="TxtYr" style="Z-INDEX: 102; LEFT: 488px; POSITION: absolute; TOP: 80px" runat="server"
					Width="56px" Height="24px" Visible="False"></asp:textbox>
				<asp:textbox id="TxtMt" style="Z-INDEX: 100; LEFT: 568px; POSITION: absolute; TOP: 80px" runat="server"
					Width="32px" Height="24px" Visible="False"></asp:textbox>
				<asp:label id="Label3" style="Z-INDEX: 104; LEFT: 32px; POSITION: absolute; TOP: 80px" runat="server"
					BackColor="GhostWhite" Width="104px" Height="24px" Font-Bold="True">Category</asp:label>
				<asp:imagebutton id="ImageButton3" style="Z-INDEX: 105; LEFT: 296px; POSITION: absolute; TOP: 480px"
					runat="server" Width="56px" Height="32px" ImageUrl="iCO\print.jpg"></asp:imagebutton>
			</asp:panel><asp:panel id="Panel7" style="Z-INDEX: 102; LEFT: 16px; POSITION: absolute; TOP: 40px" runat="server"
				Height="8px" Width="944px" BackColor="Navy"></asp:panel>
			<DIV style="Z-INDEX: 107; LEFT: 16px; WIDTH: 944px; POSITION: absolute; TOP: 16px; HEIGHT: 30px"
				align="left" ms_positioning="FlowLayout"><FONT face="Tahoma"><FONT size="5"><FONT size="4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
							Entry Opernning Stock</FONT></FONT></FONT></DIV>
			<div id="Layer1" style="Z-INDEX: 101; LEFT: 16px; OVERFLOW: scroll; WIDTH: 792px; POSITION: relative; TOP: 152px; HEIGHT: 304px"><asp:datagrid id="DataGrid1" runat="server" Height="144px" Width="712px" BackColor="White" ShowFooter="True"
					GridLines="Horizontal" CellPadding="3" BorderStyle="None" AutoGenerateColumns="False" BorderWidth="1px" BorderColor="#E7E7FF">
					<SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
					<AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
					<ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
					<HeaderStyle Font-Bold="True" Wrap="False" ForeColor="#F7F7F7" BackColor="#4A3C8C"></HeaderStyle>
					<Columns>
						<asp:BoundColumn Visible="true" DataField="Emp_Paydt" HeaderText="Payment Date">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="true" DataField="Emp_No" HeaderText="Employee #">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="true" DataField="Emp_Nam" HeaderText="Name">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="true" DataField="Emp_DecAmt" HeaderText="Dec Amount">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="true" DataField="Emp_Amt" HeaderText="Recieved">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:TemplateColumn Visible="true" HeaderText="Payment Date">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Emp_Paydt" runat="server" Width="50px" BackColor="White"></asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn Visible="true" HeaderText="Employee #">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma" HorizontalAlign="Right"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Emp_No" runat="server" Width="50px" BackColor="White"></asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn Visible="true" HeaderText="Name">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Emp_Nam" runat="server" Width="50px" BackColor="White"></asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Material Code">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Emp_DecAmt" runat="server" Height="16px" Width="40px">Label</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Recieved">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:TextBox id="Emp_Amt" runat="server" BackColor="White" Width="122px"></asp:TextBox>
							</ItemTemplate>
						</asp:TemplateColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages"></PagerStyle>
				</asp:datagrid></div>
			<asp:panel id="Panel4" style="Z-INDEX: 109; LEFT: 0px; POSITION: absolute; TOP: 526px" runat="server"
				Height="43px" Width="841px" BackColor="Navy"></asp:panel><asp:label id="Label7" style="Z-INDEX: 104; LEFT: -32000px; POSITION: absolute; TOP: -32000px"
				runat="server" Height="16px" Width="88px">Label</asp:label><asp:button id="BtnUpdate" style="Z-INDEX: 105; LEFT: 24px; POSITION: absolute; TOP: 488px"
				runat="server" Width="80px" Text="Update"></asp:button><asp:panel id="Panel1" style="Z-INDEX: 108; LEFT: 824px; POSITION: absolute; TOP: 64px" runat="server"
				Height="507px" Width="136px" BackColor="Navy" BackImageUrl="Menu/DSINEW1.JPG"></asp:panel><asp:textbox id="TxtQty" style="Z-INDEX: 110; LEFT: 456px; POSITION: absolute; TOP: 488px" runat="server"
				Width="72px"></asp:textbox><asp:textbox id="TxtVal" style="Z-INDEX: 111; LEFT: 632px; POSITION: absolute; TOP: 488px" runat="server"
				Width="120px"></asp:textbox><asp:label id="Label1" style="Z-INDEX: 112; LEFT: 368px; POSITION: absolute; TOP: 488px" runat="server"
				Height="24px" Width="72px">Total Qty</asp:label><asp:label id="Label4" style="Z-INDEX: 113; LEFT: 544px; POSITION: absolute; TOP: 488px" runat="server"
				Height="24px" Width="80px">Value(Rs.)</asp:label>
			<asp:Button id="Button1" style="Z-INDEX: 114; LEFT: 136px; POSITION: absolute; TOP: 488px" runat="server"
				Width="104px" Text="All Cat"></asp:Button></form>
	</body>
</HTML>
