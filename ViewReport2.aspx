<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ViewReport2.aspx.vb" Inherits="Insu.ViewReport2"%>
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
		<DIV style="Z-INDEX: 104; LEFT: 0px; WIDTH: 811px; POSITION: absolute; TOP: 0px; HEIGHT: 40px"
			ms_positioning="FlowLayout">
			<FORM id="Form1" runat="server">
				<div id="Layer1" style="Z-INDEX: 119; LEFT: 50px; OVERFLOW: scroll; WIDTH: 734px; POSITION: absolute; TOP: 130px; HEIGHT: 250px"><asp:datagrid id="dtgCustomers" style="Design_Time_Lock: True" runat="server" GridLines="Horizontal"
						CellPadding="4" BorderStyle="Double" BorderColor="#336666" BorderWidth="3px" BackColor="White" Design_Time_Lock="True" AutoGenerateColumns="False" HeaderStyle-BackColor="IndianRed" HeaderStyle-Font-Bold="True" HeaderStyle-Font-Name="Verdana"
						HeaderStyle-Font-Size="12px" HeaderStyle-ForeColor="White" ItemStyle-BackColor="Gainsboro" ItemStyle-Font-Name="verdana" ItemStyle-Font-Size="12px" OnCancelCommand="dtgCustomers_Cancel" OnEditCommand="dtgCustomers_Edit"
						OnUpdateCommand="dtgCustomers_Update" Height="30px" Width="710px" OnDeleteCommand="MyDataGrid_DeleteCommand">
						<FooterStyle ForeColor="#333333" BackColor="White"></FooterStyle>
						<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#339966"></SelectedItemStyle>
						<ItemStyle Font-Size="12px" Font-Names="verdana" ForeColor="#333333" BackColor="White"></ItemStyle>
						<HeaderStyle Font-Size="12px" Font-Names="Verdana" Font-Bold="True" ForeColor="White" BackColor="#336666"></HeaderStyle>
						<Columns>
							<asp:TemplateColumn HeaderText="Invoice No">
								<ItemTemplate>
									<asp:Label id=lblInvNo Text='<%# DataBinder.Eval(Container.DataItem, "Inv_No") %>' Runat="server">
									</asp:Label>
								</ItemTemplate>
							</asp:TemplateColumn>
							<asp:TemplateColumn HeaderText="Company">
								<ItemTemplate>
									<asp:Label id=lblInvCom Runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Inv_Com") %>'>
									</asp:Label>
								</ItemTemplate>
							</asp:TemplateColumn>
							<asp:TemplateColumn HeaderText="Invoice Date">
								<ItemTemplate>
									<asp:Label id=lblInvDt Runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "InvDt") %>'>
									</asp:Label>
								</ItemTemplate>
							</asp:TemplateColumn>
							<asp:TemplateColumn HeaderText="Perchase No">
								<ItemTemplate>
									<asp:Label id=lblInvPono Width="12px" Text='<%# DataBinder.Eval(Container.DataItem, "Inv_Pono") %>' Runat="server">
									</asp:Label>
								</ItemTemplate>
							</asp:TemplateColumn>
							<asp:TemplateColumn HeaderText="Total Value">
								<HeaderStyle Width="0.9in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Right"></ItemStyle>
								<ItemTemplate>
									<asp:Label id=lblInvTotVal Width="59px" Text='<%# DataBinder.Eval(Container.DataItem, "Invtotval") %>' Runat="server">
									</asp:Label>
								</ItemTemplate>
							</asp:TemplateColumn>
							<asp:TemplateColumn HeaderText="Total Qty">
								<HeaderStyle Width="0.75in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Right"></ItemStyle>
								<ItemTemplate>
									<asp:Label id=lblTotQty Text='<%# DataBinder.Eval(Container.DataItem, "Invtotqty") %>' Runat="server">
									</asp:Label>
								</ItemTemplate>
							</asp:TemplateColumn>
							<asp:TemplateColumn>
								<ItemTemplate>
									<asp:LinkButton id="lblDelete" runat="server" Text="<img border=0 src=http://192.168.12.207\Insu\images\add1.jpg alt=delete>"
										CommandName="Delete">
										<img border="0" src="http://192.168.12.133\fleet\images\add1.jpg" alt="delete"></asp:LinkButton>
								</ItemTemplate>
							</asp:TemplateColumn>
						</Columns>
						<PagerStyle HorizontalAlign="Center" ForeColor="White" BackColor="#336666" Mode="NumericPages"></PagerStyle>
					</asp:datagrid></div>
				<asp:panel id="Panel7" style="Z-INDEX: 114; LEFT: 0px; POSITION: absolute; TOP: 160px" runat="server"
					BackColor="ForestGreen" Height="256px" Width="48px"></asp:panel><asp:panel id="Panel6" style="Z-INDEX: 113; LEFT: 0px; POSITION: absolute; TOP: 24px" runat="server"
					BackColor="ForestGreen" Height="136px" Width="48px"></asp:panel><asp:label id="Label8" style="Z-INDEX: 102; LEFT: 56px; POSITION: absolute; TOP: 88px" runat="server"
					Height="24px" Width="108px">From Invoice No</asp:label>
				<asp:panel id="Panel5" style="Z-INDEX: 103; LEFT: 48px; POSITION: absolute; TOP: 112px" runat="server"
					BackColor="ForestGreen" Height="24px" Width="808px"></asp:panel>
				<asp:label id="Label10" style="Z-INDEX: 107; LEFT: 352px; POSITION: absolute; TOP: 88px" runat="server"
					Height="24px" Width="100px">To Invoice No</asp:label><asp:label id="Label6" style="Z-INDEX: 104; LEFT: 288px; POSITION: absolute; TOP: 40px" runat="server"
					Height="24px" Width="80px" Visible="False">Pass Word</asp:label><asp:textbox id="TxtUser1" style="Z-INDEX: 101; LEFT: 168px; POSITION: absolute; TOP: 40px" runat="server"
					Height="26px" Width="96px" Visible="False"></asp:textbox><asp:label id="Label5" style="Z-INDEX: 102; LEFT: 64px; POSITION: absolute; TOP: 40px" runat="server"
					Height="16px" Width="104px" Visible="False">User Code</asp:label><asp:textbox id="TxtNam" style="Z-INDEX: 106; LEFT: 144px; POSITION: absolute; TOP: 40px" runat="server"
					Height="24px" Width="418px"></asp:textbox><asp:label id="Label7" style="Z-INDEX: 108; LEFT: 56px; POSITION: absolute; TOP: 40px" runat="server"
					Height="24px" Width="96px">Name</asp:label><asp:textbox id="Txtss" style="Z-INDEX: 115; LEFT: 632px; POSITION: absolute; TOP: 40px" runat="server"
					Height="26px" Width="56px" Visible="False"></asp:textbox><asp:textbox id="TxtMail" style="Z-INDEX: 116; LEFT: 624px; POSITION: absolute; TOP: 40px" runat="server"
					Width="136px" Visible="False"></asp:textbox><asp:textbox id="TxtPwd1" style="Z-INDEX: 117; LEFT: 408px; POSITION: absolute; TOP: 40px" runat="server"
					Height="26px" Width="96px" Visible="False" TextMode="Password"></asp:textbox><asp:button id="Button3" style="Z-INDEX: 118; LEFT: 304px; POSITION: absolute; TOP: 40px" runat="server"
					Width="74px" Visible="False" Text="Submit"></asp:button><asp:dropdownlist id="LstFInvNo" style="Z-INDEX: 104; LEFT: 208px; POSITION: absolute; TOP: 88px"
					runat="server" Height="48px" Width="112px" AutoPostBack="True"></asp:dropdownlist><asp:dropdownlist id="LstTInvNo" style="Z-INDEX: 105; LEFT: 496px; POSITION: absolute; TOP: 88px"
					runat="server" Width="112px" AutoPostBack="True"></asp:dropdownlist>
				<asp:panel id="Panel4" runat="server" Width="888px" Height="32px" BackColor="SeaGreen">Administrator 
Page&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Approved 
Invoice </asp:panel></FORM>
		</DIV>
		<asp:panel id="Panel10" style="Z-INDEX: 103; LEFT: 806px; POSITION: absolute; TOP: 8px" runat="server"
			BackColor="ForestGreen" Height="416px" Width="84px"></asp:panel><asp:panel id="Panel9" style="Z-INDEX: 102; LEFT: 0px; POSITION: absolute; TOP: 392px" runat="server"
			BackColor="ForestGreen" Height="32px" Width="880px"></asp:panel>
	</body>
</HTML>
