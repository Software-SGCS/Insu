<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Newadd12.aspx.vb" Inherits="Insu.Newadd12"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>InvCheck</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout" leftmargin="0">
		<DIV style="Z-INDEX: 151; LEFT: 8px; WIDTH: 10px; POSITION: absolute; TOP: 8px; HEIGHT: 10px"
			ms_positioning="text2D">
			<FORM id="Form1" runat="server">
				<div id="Layer1" style="Z-INDEX: 118; LEFT: 120px; OVERFLOW: scroll; WIDTH: 750px; POSITION: absolute; TOP: 130px; HEIGHT: 250px"><asp:datagrid id="dtgCustomers" style="Z-INDEX: 101; LEFT: 1px; POSITION: absolute; TOP: 2px; Design_Time_Lock: True"
						runat="server" GridLines="Horizontal" CellPadding="4" BorderStyle="Double" BorderColor="#336666" BorderWidth="3px" BackColor="White" Design_Time_Lock="True" AutoGenerateColumns="False" HeaderStyle-BackColor="IndianRed"
						HeaderStyle-Font-Bold="True" HeaderStyle-Font-Name="Verdana" HeaderStyle-Font-Size="12px" HeaderStyle-ForeColor="White" ItemStyle-BackColor="Gainsboro" ItemStyle-Font-Name="verdana" ItemStyle-Font-Size="12px" OnCancelCommand="dtgCustomers_Cancel"
						OnEditCommand="dtgCustomers_Edit" OnUpdateCommand="dtgCustomers_Update" Height="30px" Width="710px" OnDeleteCommand="MyDataGrid_DeleteCommand">
						<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#339966"></SelectedItemStyle>
						<ItemStyle Font-Size="12px" Font-Names="verdana" ForeColor="#333333" BackColor="White"></ItemStyle>
						<HeaderStyle Font-Size="12px" Font-Names="Verdana" Font-Bold="True" ForeColor="White" BackColor="#336666"></HeaderStyle>
						<FooterStyle ForeColor="#333333" BackColor="White"></FooterStyle>
						<Columns>
							<asp:TemplateColumn HeaderText="Invoice No">
								<ItemTemplate>
									<asp:Label id=lblInvNo Text='<%# DataBinder.Eval(Container.DataItem, "InvNo") %>' Runat="server">
									</asp:Label>
								</ItemTemplate>
							</asp:TemplateColumn>
							<asp:TemplateColumn HeaderText="Company">
								<ItemTemplate>
									<asp:Label id=lblInvCom Runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "InvCom") %>'>
									</asp:Label>
								</ItemTemplate>
							</asp:TemplateColumn>
							<asp:TemplateColumn HeaderText="Name">
								<ItemTemplate>
									<asp:Label id="LblInvnam" Runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "ComNam") %>'>
									</asp:Label>
								</ItemTemplate>
							</asp:TemplateColumn>
							<asp:TemplateColumn HeaderText="Invoice Date">
								<ItemTemplate>
									<asp:Label id=lblInvDt Runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "InvDt") %>'>
									</asp:Label>
								</ItemTemplate>
							</asp:TemplateColumn>
							<asp:TemplateColumn HeaderText="Payment Date">
								<ItemTemplate>
									<asp:Label id="Label2" Runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "PayDt") %>'>
									</asp:Label>
								</ItemTemplate>
							</asp:TemplateColumn>
							<asp:TemplateColumn HeaderText="P.O. No     ">
								<ItemTemplate>
									<asp:Label id=lblInvPono Width="12px" Text='<%# DataBinder.Eval(Container.DataItem, "InvPono") %>' Runat="server">
									</asp:Label>
								</ItemTemplate>
							</asp:TemplateColumn>
							<asp:TemplateColumn HeaderText="Total Qty   ">
								<HeaderStyle Width="0.75in"></HeaderStyle>
								<ItemStyle HorizontalAlign="center"></ItemStyle>
								<ItemTemplate>
									<asp:Label id=lblTotQty Text='<%# DataBinder.Eval(Container.DataItem, "Invtotqty") %>' Runat="server">
									</asp:Label>
								</ItemTemplate>
							</asp:TemplateColumn>
							<asp:TemplateColumn HeaderText="Days">
								<HeaderStyle Width="0.75in"></HeaderStyle>
								<ItemStyle HorizontalAlign="center"></ItemStyle>
								<ItemTemplate>
									<asp:Label id="Label1" Text='<%# DataBinder.Eval(Container.DataItem, "InvDays") %>' Runat="server">
									</asp:Label>
								</ItemTemplate>
							</asp:TemplateColumn>
							<asp:TemplateColumn HeaderText="Invoice">
								<HeaderStyle Width="0.75in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Right"></ItemStyle>
								<ItemTemplate>
									<asp:LinkButton id="lblDelete" runat="server" Text="<img border=0 src=http://192.168.12.207\Insu\images\add1.jpg alt=delete>"
										CommandName="Delete">
										<img border="0" src="http://192.168.12.133\fleet\images\add1.jpg" alt="delete"></asp:LinkButton>
								</ItemTemplate>
							</asp:TemplateColumn>
						</Columns>
						<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
					</asp:datagrid></div>
				<asp:panel id="Panel6" style="Z-INDEX: 109; LEFT: -8px; POSITION: absolute; TOP: 24px" runat="server"
					BackColor="Desktop" Height="400px" Width="128px" BackImageUrl="http://sgcsser\Insu\Menu\Audit.gif"></asp:panel><asp:panel id="Panel5" runat="server" BackColor="Desktop" Height="24px" Width="767px"></asp:panel><asp:panel id="Panel4" style="Z-INDEX: 107; LEFT: -8px; POSITION: absolute; TOP: -8px" runat="server"
					BackColor="Desktop" Height="32px" Width="820px">
<asp:panel id="Panel2" style="Z-INDEX: 111; LEFT: 8px; POSITION: absolute; TOP: 400px" runat="server"
						Width="868px" Height="32px" BackColor="Desktop"></asp:panel>Administrator 
Page&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Invoice 
&nbsp;Approval</asp:panel>
				<asp:label id="Label6" style="Z-INDEX: 104; LEFT: 288px; POSITION: absolute; TOP: 40px" runat="server"
					Height="24px" Width="80px" Visible="False">Pass Word</asp:label><asp:textbox id="TxtUser1" style="Z-INDEX: 102; LEFT: 168px; POSITION: absolute; TOP: 40px" runat="server"
					Height="26px" Width="96px" Visible="False"></asp:textbox><asp:label id="Label5" style="Z-INDEX: 103; LEFT: 64px; POSITION: absolute; TOP: 40px" runat="server"
					Height="16px" Width="104px" Visible="False">User Code</asp:label><asp:textbox id="TxtNam" style="Z-INDEX: 105; LEFT: 248px; POSITION: absolute; TOP: 40px" runat="server"
					Height="24px" Width="418px"></asp:textbox><asp:label id="Label7" style="Z-INDEX: 106; LEFT: 120px; POSITION: absolute; TOP: 40px" runat="server"
					Height="24px" Width="96px">Name</asp:label><asp:panel id="Panel8" style="Z-INDEX: 111; LEFT: -8px; POSITION: absolute; TOP: 96px" runat="server"
					BackColor="Desktop" Height="32px" Width="844px"></asp:panel><asp:textbox id="Txtss" style="Z-INDEX: 112; LEFT: 632px; POSITION: absolute; TOP: 40px" runat="server"
					Height="26px" Width="56px" Visible="False"></asp:textbox><asp:textbox id="TxtMail" style="Z-INDEX: 113; LEFT: 624px; POSITION: absolute; TOP: 40px" runat="server"
					Width="136px" Visible="False"></asp:textbox><asp:textbox id="TxtPwd1" style="Z-INDEX: 114; LEFT: 408px; POSITION: absolute; TOP: 40px" runat="server"
					Height="26px" Width="96px" Visible="False" TextMode="Password"></asp:textbox><asp:button id="Button3" style="Z-INDEX: 115; LEFT: 304px; POSITION: absolute; TOP: 40px" runat="server"
					Width="74px" Visible="False" Text="Submit"></asp:button></FORM>
		</DIV>
		<asp:panel id="Panel1" style="Z-INDEX: 110; LEFT: 840px; POSITION: absolute; TOP: 0px" runat="server"
			BackColor="Desktop" Height="404px" Width="36px"></asp:panel>
	</body>
</HTML>
