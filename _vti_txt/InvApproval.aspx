<%@ Page Language="vb" AutoEventWireup="false" Codebehind="InvApproval.aspx.vb" Inherits="Insu.InvApproval" %>
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
	<body leftMargin="0" MS_POSITIONING="GridLayout">
		<DIV style="Z-INDEX: 108; LEFT: 0px; WIDTH: 10px; POSITION: absolute; TOP: 8px; HEIGHT: 10px"
			ms_positioning="text2D">
			<FORM id="Form1" runat="server">
				<div id="Layer1" style="Z-INDEX: 128; LEFT: 50px; OVERFLOW: scroll; WIDTH: 750px; POSITION: absolute; TOP: 130px; HEIGHT: 250px"><asp:datagrid id="dtgCustomers" style="Z-INDEX: 101; LEFT: 1px; POSITION: absolute; TOP: 2px; Design_Time_Lock: True"
						runat="server" CellPadding="3" BorderWidth="1px" BorderStyle="None" BorderColor="#CCCCCC" BackColor="White" Design_Time_Lock="True" AutoGenerateColumns="False" HeaderStyle-BackColor="IndianRed" HeaderStyle-Font-Bold="True"
						HeaderStyle-Font-Name="Verdana" HeaderStyle-Font-Size="12px" HeaderStyle-ForeColor="White" ItemStyle-BackColor="Gainsboro" ItemStyle-Font-Name="verdana" ItemStyle-Font-Size="12px" OnCancelCommand="dtgCustomers_Cancel"
						OnEditCommand="dtgCustomers_Edit" OnUpdateCommand="dtgCustomers_Update" Height="30px" Width="710px" OnDeleteCommand="MyDataGrid_DeleteCommand">
						<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
						<ItemStyle Font-Size="12px" Font-Names="verdana" ForeColor="#000066" BackColor="Gainsboro"></ItemStyle>
						<HeaderStyle Font-Size="12px" Font-Names="Verdana" Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
						<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
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
								<ItemTemplate>
									<asp:Label id=lblInvTotVal Width="12px" Text='<%# DataBinder.Eval(Container.DataItem, "Inv_totval") %>' Runat="server">
									</asp:Label>
								</ItemTemplate>
							</asp:TemplateColumn>
							<asp:TemplateColumn HeaderText="Total Qty">
								<HeaderStyle Width="0.75in"></HeaderStyle>
								<ItemTemplate>
									<asp:Label id=lblTotQty Text='<%# DataBinder.Eval(Container.DataItem, "Inv_totqty") %>' Runat="server">
									</asp:Label>
								</ItemTemplate>
							</asp:TemplateColumn>
							<asp:TemplateColumn>
								<ItemTemplate>
									<asp:LinkButton id="lblDelete" runat="server" Text="<img border=0 src=Ico\print.jpg alt=delete>"
										CommandName="Delete">
										<img border="0" src="Ico\print.jpg" alt="delete"></asp:LinkButton>
								</ItemTemplate>
							</asp:TemplateColumn>
						</Columns>
						<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
					</asp:datagrid></div>
				<asp:panel id="Panel7" style="Z-INDEX: 110; LEFT: -8px; POSITION: absolute; TOP: 160px" runat="server"
					BackColor="Desktop" Height="256px" Width="56px"></asp:panel><asp:panel id="Panel6" style="Z-INDEX: 109; LEFT: -8px; POSITION: absolute; TOP: 24px" runat="server"
					BackColor="Desktop" Height="136px" Width="56px"></asp:panel><asp:panel id="Panel4" style="Z-INDEX: 107; LEFT: -8px; POSITION: absolute; TOP: -8px" runat="server"
					BackColor="Desktop" Height="40px" Width="872px">Administrator 
Page&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Invoice 
&nbsp;Approval</asp:panel>
				<asp:label id="Label6" style="Z-INDEX: 104; LEFT: 288px; POSITION: absolute; TOP: 40px" runat="server"
					Height="24px" Width="80px" Visible="False">Pass Word</asp:label><asp:textbox id="TxtUser1" style="Z-INDEX: 102; LEFT: 168px; POSITION: absolute; TOP: 40px" runat="server"
					Height="26px" Width="96px" Visible="False"></asp:textbox><asp:label id="Label5" style="Z-INDEX: 103; LEFT: 64px; POSITION: absolute; TOP: 40px" runat="server"
					Height="16px" Width="104px" Visible="False">User Code</asp:label><asp:textbox id="TxtNam" style="Z-INDEX: 105; LEFT: 168px; POSITION: absolute; TOP: 40px" runat="server"
					Height="24px" Width="418px"></asp:textbox><asp:label id="Label7" style="Z-INDEX: 106; LEFT: 56px; POSITION: absolute; TOP: 40px" runat="server"
					Height="24px" Width="96px">Name</asp:label><asp:panel id="Panel8" runat="server" BackColor="LightSkyBlue" Height="32px" Width="864px"></asp:panel><asp:textbox id="Txtss" style="Z-INDEX: 112; LEFT: 632px; POSITION: absolute; TOP: 40px" runat="server"
					Height="26px" Width="56px" Visible="False"></asp:textbox><asp:textbox id="TxtMail" style="Z-INDEX: 113; LEFT: 624px; POSITION: absolute; TOP: 40px" runat="server"
					Width="136px" Visible="False"></asp:textbox><asp:textbox id="TxtPwd1" style="Z-INDEX: 114; LEFT: 408px; POSITION: absolute; TOP: 40px" runat="server"
					Height="26px" Width="96px" Visible="False" TextMode="Password"></asp:textbox><asp:button id="Button3" style="Z-INDEX: 115; LEFT: 304px; POSITION: absolute; TOP: 40px" runat="server"
					Width="74px" Visible="False" Text="Submit"></asp:button><asp:panel id="Panel10" style="Z-INDEX: 103; LEFT: 816px; POSITION: absolute; TOP: 0px" runat="server"
					BackColor="Desktop" Height="422px" Width="48px"></asp:panel><asp:panel id="Panel9" style="Z-INDEX: 102; LEFT: 48px; POSITION: absolute; TOP: 384px" runat="server"
					BackColor="Desktop" Height="38px" Width="800px"></asp:panel><asp:panel id="Panel11" style="Z-INDEX: 104; LEFT: -8px; POSITION: absolute; TOP: 416px" runat="server"
					BackColor="Desktop" Height="48px" Width="874px"></asp:panel><asp:label id="Label8" style="Z-INDEX: 102; LEFT: 48px; POSITION: absolute; TOP: 104px" runat="server"
					BackColor="RoyalBlue" Height="24px" Width="120px" ForeColor="White">Preview Invoice</asp:label><asp:radiobutton id="RadBt1" style="Z-INDEX: 112; LEFT: 168px; POSITION: absolute; TOP: 104px" runat="server"
					BackColor="RoyalBlue" Height="24px" Width="112px" Text="Date Range" ForeColor="White" GroupName="Radiobtn" AutoPostBack="True"></asp:radiobutton><asp:radiobutton id="RadBt2" style="Z-INDEX: 113; LEFT: 280px; POSITION: absolute; TOP: 104px" runat="server"
					BackColor="RoyalBlue" Height="24px" Width="120px" Text="Invoice Range" ForeColor="White" GroupName="Radiobtn" AutoPostBack="True"></asp:radiobutton></FORM>
		</DIV>
		<asp:panel id="Panel5" style="Z-INDEX: 109; LEFT: 48px; POSITION: absolute; TOP: 88px" runat="server"
			BackColor="Desktop" Height="24px" Width="804px">For&nbsp;Approvel</asp:panel>
	</body>
</HTML>
