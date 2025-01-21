<%@ Page Language="vb" AutoEventWireup="false" Codebehind="InsuApprovalM.aspx.vb" Inherits="Insu.InsuApprovalM" %>
<HTML>
	<HEAD>
		<title>DataGrid with a DropDownListBox</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<BODY topMargin="45" MS_POSITIONING="GridLayout">
		<FORM id="Form1" runat="server">
			<div id="Layer1" style="Z-INDEX: 115; LEFT: 136px; OVERFLOW: scroll; WIDTH: 754px; POSITION: absolute; TOP: 104px; HEIGHT: 336px"><asp:datagrid id="dtgCustomers" style="Z-INDEX: 101; LEFT: 0px; POSITION: absolute; TOP: 0px; Design_Time_Lock: True"
					runat="server" BorderStyle="Double" PageSize="5" GridLines="Horizontal" OnDeleteCommand="MyDataGrid_DeleteCommand" Width="12px" Height="12px" OnUpdateCommand="dtgCustomers_Update" OnEditCommand="dtgCustomers_Edit" OnCancelCommand="dtgCustomers_Cancel"
					ItemStyle-Font-Size="12px" ItemStyle-Font-Name="verdana" ItemStyle-BackColor="Gainsboro" HeaderStyle-ForeColor="White" HeaderStyle-Font-Size="12px" HeaderStyle-Font-Name="Verdana" HeaderStyle-Font-Bold="True" HeaderStyle-BackColor="IndianRed"
					AutoGenerateColumns="False" Design_Time_Lock="True" BackColor="White" BorderColor="#336666" BorderWidth="3px" CellPadding="4">
					<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#339966"></SelectedItemStyle>
					<ItemStyle Font-Size="12px" Font-Names="verdana" ForeColor="#333333" BackColor="White"></ItemStyle>
					<HeaderStyle Font-Size="12px" Font-Names="Verdana" Font-Bold="True" ForeColor="White" BackColor="#336666"></HeaderStyle>
					<FooterStyle ForeColor="#333333" BackColor="White"></FooterStyle>
					<Columns>
						<asp:TemplateColumn HeaderText="Vehicle No">
							<ItemTemplate>
								<asp:Label id=lblNo Width="90px" Text='<%# DataBinder.Eval(Container.DataItem, "Veh_No") %>' Runat="server">
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
								<asp:Label id=lblTyp Width="90px" Runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Veh_Typ") %>'>
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
						<asp:TemplateColumn HeaderText="Total Chq Payment">
							<ItemTemplate>
								<asp:Label id="Label1" Text='<%# DataBinder.Eval(Container.DataItem, "Veh_TotChqpay") %>' Runat="server">
								</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Certificate">
							<ItemTemplate>
								<asp:LinkButton id="lblDelete" runat="server" Text="<img border=0 src=Ico\print.jpg alt=delete>"
									CommandName="Delete">
									<img border="0" src="Ico\app.jpg" alt="approve"></asp:LinkButton>
							</ItemTemplate>
						</asp:TemplateColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Center" ForeColor="White" BackColor="#336666" Mode="NumericPages"></PagerStyle>
				</asp:datagrid></div>
			<asp:panel id="Panel9" style="Z-INDEX: 119; LEFT: 896px; POSITION: absolute; TOP: 0px" runat="server"
				Width="40px" Height="472px" BackColor="Desktop"></asp:panel><asp:radiobutton id="Radiobutton2" style="Z-INDEX: 118; LEFT: 608px; POSITION: absolute; TOP: 72px"
				runat="server" Width="160px" Height="24px" BackColor="RoyalBlue" GroupName="Radiobtn" AutoPostBack="True" ForeColor="White" Text="Certificate No  Range"></asp:radiobutton><asp:radiobutton id="Radiobutton1" style="Z-INDEX: 117; LEFT: 496px; POSITION: absolute; TOP: 72px"
				runat="server" Width="112px" Height="24px" BackColor="RoyalBlue" GroupName="Radiobtn" AutoPostBack="True" ForeColor="White" Text="Date Range"></asp:radiobutton><asp:label id="Label8" style="Z-INDEX: 116; LEFT: 312px; POSITION: absolute; TOP: 72px" runat="server"
				Width="184px" Height="24px" BackColor="RoyalBlue" ForeColor="White">Preview Insurence Certificate</asp:label><asp:panel id="Panel7" style="Z-INDEX: 109; LEFT: 0px; POSITION: absolute; TOP: 160px" runat="server"
				Width="120px" Height="272px" BackColor="Desktop" BackImageUrl="Menu/audit.gif"></asp:panel><asp:panel id="Panel6" style="Z-INDEX: 108; LEFT: 0px; POSITION: absolute; TOP: 32px" runat="server"
				Width="120px" Height="128px" BackColor="Desktop" BackImageUrl="Menu/AssetI.gif"></asp:panel><asp:panel id="Panel5" style="Z-INDEX: 107; LEFT: 120px; POSITION: absolute; TOP: 72px" runat="server"
				Width="768px" Height="24px" BackColor="Desktop">For&nbsp;Approvel</asp:panel>
			<asp:panel id="Panel4" style="Z-INDEX: 106; LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server"
				Width="896px" Height="32px" BackColor="Desktop">
<asp:label id="Label3" style="Z-INDEX: 101; LEFT: 56px; POSITION: absolute; TOP: 80px" runat="server"
					Width="104px" Height="24px" BackColor="Lavender" Font-Bold="True">Company</asp:label>Administrator 
Page&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Insurence 
Certificate Approval</asp:panel><asp:label id="Label6" style="Z-INDEX: 103; LEFT: 408px; POSITION: absolute; TOP: 40px" runat="server"
				Width="80px" Height="24px" Visible="False">Pass Word</asp:label><asp:textbox id="TxtUser1" style="Z-INDEX: 100; LEFT: 320px; POSITION: absolute; TOP: 40px" runat="server"
				Width="96px" Height="26px" Visible="False"></asp:textbox><asp:label id="Label5" style="Z-INDEX: 101; LEFT: 128px; POSITION: absolute; TOP: 40px" runat="server"
				Width="104px" Height="16px">Company</asp:label><asp:textbox id="TxtNam" style="Z-INDEX: 104; LEFT: 536px; POSITION: absolute; TOP: 40px" runat="server"
				Width="418px" Height="24px" Visible="False"></asp:textbox><asp:label id="Label7" style="Z-INDEX: 105; LEFT: 776px; POSITION: absolute; TOP: 104px" runat="server"
				Width="96px" Height="24px" Visible="False">Name</asp:label><asp:panel id="Panel8" style="Z-INDEX: 110; LEFT: 0px; POSITION: absolute; TOP: 432px" runat="server"
				Width="896px" Height="40px" BackColor="Desktop"></asp:panel><asp:textbox id="Txtss" style="Z-INDEX: 111; LEFT: 704px; POSITION: absolute; TOP: 40px" runat="server"
				Width="56px" Height="26px" Visible="False"></asp:textbox><asp:textbox id="TxtMail" style="Z-INDEX: 112; LEFT: 712px; POSITION: absolute; TOP: 40px" runat="server"
				Width="136px" Visible="False"></asp:textbox>
			<asp:textbox id="TxtPwd1" style="Z-INDEX: 113; LEFT: 776px; POSITION: absolute; TOP: 40px" runat="server"
				Width="96px" Height="26px" Visible="False" TextMode="Password"></asp:textbox><asp:button id="Button3" style="Z-INDEX: 114; LEFT: 464px; POSITION: absolute; TOP: 40px" runat="server"
				Width="74px" Text="Submit" Visible="False"></asp:button><asp:button id="BttApp" style="Z-INDEX: 120; LEFT: 128px; POSITION: absolute; TOP: 440px" runat="server"
				Width="160px" Height="32px" Text="Approval All"></asp:button><asp:label id="L1" style="Z-INDEX: 121; LEFT: 496px; POSITION: absolute; TOP: 416px" runat="server"
				Width="104px" Height="16px">Label</asp:label>
			<asp:dropdownlist id="LstCat" style="Z-INDEX: 122; LEFT: 224px; POSITION: absolute; TOP: 40px" runat="server"
				Width="458px" Height="16px" AutoPostBack="True"></asp:dropdownlist></FORM>
	</BODY>
</HTML>
