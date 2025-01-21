<%@ Page Language="vb" AutoEventWireup="false" Codebehind="PettyCashReq.aspx.vb" Inherits="Insu.PettyCashReq" %>
<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
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
			<asp:dropdownlist id="LstCat" style="Z-INDEX: 101; LEFT: 232px; POSITION: absolute; TOP: 72px" runat="server"
				Width="312px" Height="24px" AutoPostBack="True" Font-Names="Calibri"></asp:dropdownlist><asp:label id="BalImp" style="Z-INDEX: 118; LEFT: 640px; POSITION: absolute; TOP: 104px" runat="server"
				Width="104px" Height="24px" Font-Names="Calibri" Font-Size="X-Small"></asp:label><asp:label id="PayAmt" style="Z-INDEX: 117; LEFT: 416px; POSITION: absolute; TOP: 104px" runat="server"
				Width="88px" Height="24px" Font-Names="Calibri" Font-Size="X-Small"></asp:label><asp:label id="Label10" style="Z-INDEX: 115; LEFT: 528px; POSITION: absolute; TOP: 104px" runat="server"
				Width="104px" Height="24px" Font-Names="Calibri" Font-Size="X-Small">Balance Imprest</asp:label><asp:label id="Label9" style="Z-INDEX: 114; LEFT: 352px; POSITION: absolute; TOP: 104px" runat="server"
				Width="56px" Height="24px" Font-Names="Calibri" Font-Size="X-Small">Payment</asp:label><asp:label id="ImpAmt" style="Z-INDEX: 113; LEFT: 232px; POSITION: absolute; TOP: 104px" runat="server"
				Width="104px" Height="24px" Font-Names="Calibri" Font-Size="X-Small"></asp:label><asp:label id="Label8" style="Z-INDEX: 112; LEFT: 176px; POSITION: absolute; TOP: 104px" runat="server"
				Width="56px" Height="24px" Font-Names="Calibri" Font-Size="X-Small">Imprest</asp:label><asp:panel id="Panel12" style="Z-INDEX: 111; LEFT: 968px; POSITION: absolute; TOP: 64px" runat="server"
				Width="160px" Height="560px" BackColor="Navy"></asp:panel>
			<DIV id="Layer1" style="Z-INDEX: 103; LEFT: 168px; OVERFLOW: scroll; WIDTH: 784px; POSITION: relative; TOP: 144px; HEIGHT: 280px"><asp:datagrid id="DataGrid1" runat="server" Width="776px" Height="60px" BackColor="White" BorderColor="#CC9966"
					BorderWidth="1px" AutoGenerateColumns="False" BorderStyle="None" CellPadding="4" ShowFooter="True" Font-Size="X-Small">
					<SelectedItemStyle Font-Bold="True" ForeColor="#663399" BackColor="#FFCC66"></SelectedItemStyle>
					<ItemStyle ForeColor="#330099" BackColor="White"></ItemStyle>
					<HeaderStyle Font-Size="X-Small" Font-Names="Tahoma" Font-Bold="True" Wrap="False" ForeColor="#FFFFCC"
						BackColor="#990000"></HeaderStyle>
					<FooterStyle ForeColor="#330099" BackColor="#FFFFCC"></FooterStyle>
					<Columns>
						<asp:BoundColumn DataField="In_Date" HeaderText="Voucher Date">
							<HeaderStyle Font-Size="X-Small" Font-Names="Calibri"></HeaderStyle>
							<ItemStyle Font-Size="X-Small" Font-Names="Calibri" Width="100px"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="In_Vno" HeaderText="Payment Voucher">
							<HeaderStyle Font-Size="X-Small" Font-Names="Calibri"></HeaderStyle>
							<ItemStyle Font-Size="X-Small" Font-Names="Calibri" Width="100px"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="In_PayAmt" HeaderText="Payment Amount">
							<HeaderStyle Font-Size="X-Small" Font-Names="Calibri"></HeaderStyle>
							<ItemStyle Font-Size="X-Small" Font-Names="Calibri" HorizontalAlign="Right" Width="50px"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="In_Eno" HeaderText="Employee">
							<HeaderStyle Font-Size="X-Small" Font-Names="Calibri"></HeaderStyle>
							<ItemStyle Font-Size="X-Small" Font-Names="Calibri" Width="100px"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Emp_Nam" HeaderText="Employee Name">
							<HeaderStyle Font-Size="X-Small" Font-Names="Calibri"></HeaderStyle>
							<ItemStyle Font-Size="X-Small" Font-Names="Calibri" Width="150px"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Emp_Dep" HeaderText="Department">
							<HeaderStyle Font-Size="X-Small" Font-Names="Calibri"></HeaderStyle>
							<ItemStyle Font-Size="X-Small" Font-Names="Calibri" Width="150px"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Emp_Com" HeaderText="Company">
							<HeaderStyle Font-Size="X-Small" Font-Names="Calibri"></HeaderStyle>
							<ItemStyle Font-Size="X-Small" Font-Names="Calibri" Font-Bold="True" Width="150px"></ItemStyle>
						</asp:BoundColumn>
						<asp:TemplateColumn HeaderText="Select">
							<HeaderStyle Font-Size="X-Small" Font-Names="Calibri"></HeaderStyle>
							<ItemStyle Font-Size="X-Small" Font-Names="Calibri"></ItemStyle>
							<ItemTemplate>
								<asp:CheckBox id="myCheckbox" Runat="server" Width="100px"></asp:CheckBox>
							</ItemTemplate>
						</asp:TemplateColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Center" ForeColor="#330099" BackColor="#FFFFCC"></PagerStyle>
				</asp:datagrid></DIV>
			<asp:panel id="Panel11" style="Z-INDEX: 109; LEFT: 8px; POSITION: absolute; TOP: 562px" runat="server"
				Width="1056px" Height="61px" BackColor="Navy"></asp:panel><asp:panel id="Panel10" style="Z-INDEX: 108; LEFT: 8px; POSITION: absolute; TOP: 64px" runat="server"
				Width="160px" Height="504px" BackColor="Navy" BackImageUrl="Menu\AssetI.gif"></asp:panel><asp:panel id="Panel9" style="Z-INDEX: 107; LEFT: 8px; POSITION: absolute; TOP: 0px" runat="server"
				Width="1122px" Height="16px" BackColor="Navy"></asp:panel><asp:label id="Company" style="Z-INDEX: 102; LEFT: 176px; POSITION: absolute; TOP: 72px" runat="server"
				Width="56px" Height="24px" Font-Names="Calibri" Font-Size="X-Small">Company</asp:label><asp:button id="ButSub" style="Z-INDEX: 104; LEFT: 176px; POSITION: absolute; TOP: 448px" runat="server"
				Width="168px" Text="Create Payment Summery"></asp:button><asp:panel id="Panel6" style="Z-INDEX: 105; LEFT: 8px; POSITION: absolute; TOP: 24px" runat="server"
				Font-Names="Calibri" Height="24px" Width="1122px" Font-Size="Medium">&nbsp;<FONT face="Tahoma" size="4"><STRONG>Fund 
						Request Entry</STRONG></FONT></asp:panel>
			<asp:panel id="Panel8" style="Z-INDEX: 106; LEFT: 8px; POSITION: absolute; TOP: 48px" runat="server"
				Height="16px" Width="1122px" BackColor="Navy"></asp:panel><asp:label id="L1" style="Z-INDEX: 110; LEFT: 800px; POSITION: absolute; TOP: 456px" runat="server"
				Height="24px" Width="104px"></asp:label><CR:CRYSTALREPORTVIEWER id="CrystalReportViewer1" style="Z-INDEX: 116; LEFT: 840px; POSITION: absolute; TOP: 640px"
				runat="server" Height="50px" Width="350px"></CR:CRYSTALREPORTVIEWER>
			<asp:TextBox id="TxtInvDt" style="Z-INDEX: 119; LEFT: 688px; POSITION: absolute; TOP: 496px"
				runat="server" Height="24px" Width="72px" Visible="False"></asp:TextBox></form>
	</body>
</HTML>
