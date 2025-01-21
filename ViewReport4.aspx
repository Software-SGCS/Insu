<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ViewReport4.aspx.vb" Inherits="Insu.ViewReport4" %>
<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>InvApproval</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<DIV style="Z-INDEX: 100; LEFT: 0px; WIDTH: 811px; POSITION: absolute; TOP: 8px; HEIGHT: 32px"
			ms_positioning="FlowLayout">
			<FORM id="Form1" runat="server">
				<div id="Layer1" style="Z-INDEX: 119; LEFT: 50px; OVERFLOW: scroll; WIDTH: 734px; POSITION: absolute; TOP: 130px; HEIGHT: 250px"><asp:datagrid id="dtgCustomers" style="Z-INDEX: 101; LEFT: 1px; POSITION: absolute; TOP: 2px; Design_Time_Lock: True"
						runat="server" OnDeleteCommand="MyDataGrid_DeleteCommand" Width="710px" Height="30px" OnUpdateCommand="dtgCustomers_Update" OnEditCommand="dtgCustomers_Edit" OnCancelCommand="dtgCustomers_Cancel" ItemStyle-Font-Size="12px"
						ItemStyle-Font-Name="verdana" ItemStyle-BackColor="Gainsboro" HeaderStyle-ForeColor="White" HeaderStyle-Font-Size="12px" HeaderStyle-Font-Name="Verdana" HeaderStyle-Font-Bold="True" HeaderStyle-BackColor="IndianRed"
						AutoGenerateColumns="False" Design_Time_Lock="True" BackColor="White" BorderWidth="3px" BorderColor="#336666" BorderStyle="Double" CellPadding="4" GridLines="Horizontal">
						<FooterStyle ForeColor="#333333" BackColor="White"></FooterStyle>
						<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#339966"></SelectedItemStyle>
						<ItemStyle Font-Size="12px" Font-Names="verdana" ForeColor="#333333" BackColor="White"></ItemStyle>
						<HeaderStyle Font-Size="12px" Font-Names="Verdana" Font-Bold="True" ForeColor="White" BackColor="#336666"></HeaderStyle>
						<Columns>
							<asp:TemplateColumn HeaderText="Vehicle No">
								<ItemTemplate>
									<asp:Label id=lblNo Text='<%# DataBinder.Eval(Container.DataItem, "Veh_No") %>' Runat="server">
									</asp:Label>
								</ItemTemplate>
							</asp:TemplateColumn>
							<asp:TemplateColumn HeaderText="Company">
								<ItemTemplate>
									<asp:Label id=lblCom Runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Veh_Com") %>'>
									</asp:Label>
								</ItemTemplate>
							</asp:TemplateColumn>
							<asp:TemplateColumn HeaderText="Vehicle Type">
								<ItemTemplate>
									<asp:Label id=lblTyp Runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Veh_Typ") %>'>
									</asp:Label>
								</ItemTemplate>
							</asp:TemplateColumn>
							<asp:TemplateColumn HeaderText="From Date">
								<ItemTemplate>
									<asp:Label id=lblEFdt Width="12px" Text='<%# DataBinder.Eval(Container.DataItem, "Veh_Efdt") %>' Runat="server">
									</asp:Label>
								</ItemTemplate>
							</asp:TemplateColumn>
							<asp:TemplateColumn HeaderText="To Date">
								<ItemTemplate>
									<asp:Label id=lblEXdt Width="12px" Text='<%# DataBinder.Eval(Container.DataItem, "Veh_Exdt") %>' Runat="server">
									</asp:Label>
								</ItemTemplate>
							</asp:TemplateColumn>
							<asp:TemplateColumn HeaderText="Total Pre">
								<ItemTemplate>
									<asp:Label id=lblTpay Text='<%# DataBinder.Eval(Container.DataItem, "Veh_Tpay") %>' Runat="server">
									</asp:Label>
								</ItemTemplate>
							</asp:TemplateColumn>
							<asp:TemplateColumn HeaderText="Payment Notice">
								<ItemTemplate>
									<asp:LinkButton id="LinkButton1" runat="server" Text="<img border=0 src=http://192.168.12.207\Insu\images\add1.jpg alt=delete>"
										CommandName="Delete">
										<img border="0" src="http://192.168.12.133\fleet\images\add1.jpg" alt="delete"></asp:LinkButton>
								</ItemTemplate>
							</asp:TemplateColumn>
						</Columns>
						<PagerStyle HorizontalAlign="Center" ForeColor="White" BackColor="#336666" Mode="NumericPages"></PagerStyle>
					</asp:datagrid></div>
				<asp:panel id="Panel7" style="Z-INDEX: 114; LEFT: 0px; POSITION: absolute; TOP: 160px" runat="server"
					Width="48px" Height="264px" BackColor="ForestGreen"></asp:panel><asp:panel id="Panel6" style="Z-INDEX: 113; LEFT: 0px; POSITION: absolute; TOP: 32px" runat="server"
					Width="48px" Height="128px" BackColor="ForestGreen"></asp:panel><asp:panel id="Panel5" style="Z-INDEX: 103; LEFT: 32px; POSITION: absolute; TOP: 112px" runat="server"
					Width="824px" Height="24px" BackColor="ForestGreen"></asp:panel><asp:label id="Label6" style="Z-INDEX: 104; LEFT: 288px; POSITION: absolute; TOP: 40px" runat="server"
					Width="80px" Height="24px" Visible="False">Pass Word</asp:label><asp:textbox id="TxtUser1" style="Z-INDEX: 101; LEFT: 168px; POSITION: absolute; TOP: 40px" runat="server"
					Width="96px" Height="26px" Visible="False"></asp:textbox><asp:label id="Label5" style="Z-INDEX: 102; LEFT: 64px; POSITION: absolute; TOP: 40px" runat="server"
					Width="104px" Height="16px" Visible="False">User Code</asp:label><asp:textbox id="TxtNam" style="Z-INDEX: 106; LEFT: 144px; POSITION: absolute; TOP: 40px" runat="server"
					Width="418px" Height="24px"></asp:textbox><asp:label id="Label7" style="Z-INDEX: 108; LEFT: 56px; POSITION: absolute; TOP: 40px" runat="server"
					Width="96px" Height="24px">Name</asp:label><asp:textbox id="Txtss" style="Z-INDEX: 115; LEFT: 632px; POSITION: absolute; TOP: 40px" runat="server"
					Width="56px" Height="26px" Visible="False"></asp:textbox><asp:textbox id="TxtMail" style="Z-INDEX: 116; LEFT: 624px; POSITION: absolute; TOP: 40px" runat="server"
					Width="136px" Visible="False"></asp:textbox><asp:textbox id="TxtPwd1" style="Z-INDEX: 117; LEFT: 408px; POSITION: absolute; TOP: 40px" runat="server"
					Width="96px" Height="26px" Visible="False" TextMode="Password"></asp:textbox><asp:button id="Button3" style="Z-INDEX: 118; LEFT: 304px; POSITION: absolute; TOP: 40px" runat="server"
					Width="74px" Visible="False" Text="Submit"></asp:button>
				<asp:dropdownlist id="LstTInvNo" style="Z-INDEX: 107; LEFT: 416px; POSITION: absolute; TOP: 80px"
					runat="server" Width="88px" AutoPostBack="True"></asp:dropdownlist>
				<asp:dropdownlist id="LstFInvNo" style="Z-INDEX: 106; LEFT: 192px; POSITION: absolute; TOP: 80px"
					runat="server" Height="48px" Width="96px" AutoPostBack="True"></asp:dropdownlist>
				<asp:label id="Label8" style="Z-INDEX: 105; LEFT: 56px; POSITION: absolute; TOP: 80px" runat="server"
					Height="24px" Width="136px">From Certificate No</asp:label>
				<asp:label id="Label10" style="Z-INDEX: 101; LEFT: 304px; POSITION: absolute; TOP: 80px" runat="server"
					Height="24px" Width="112px">To Certificate  No</asp:label>
				<asp:panel id="Panel10" style="Z-INDEX: 103; LEFT: 806px; POSITION: absolute; TOP: 0px" runat="server"
					Width="84px" Height="424px" BackColor="ForestGreen"></asp:panel><asp:panel id="Panel9" style="Z-INDEX: 102; LEFT: 24px; POSITION: absolute; TOP: 400px" runat="server"
					Width="856px" Height="24px" BackColor="ForestGreen"></asp:panel>
				<asp:panel id="Panel4" runat="server" BackColor="SeaGreen" Height="32px" Width="890px">Administrator 
Page&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Approved 
Invoice </asp:panel>
			</FORM>
		</DIV>
	</body>
</HTML>
