<%@ Page Language="vb" AutoEventWireup="false" Codebehind="ViewReport1.aspx.vb" Inherits="Insu.ViewReport1"%>
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
		<DIV style="Z-INDEX: 101; LEFT: 0px; WIDTH: 811px; POSITION: absolute; TOP: 8px; HEIGHT: 32px"
			ms_positioning="FlowLayout">
			<FORM id="Form1" runat="server">
				<div id="Layer1" style="Z-INDEX: 118; LEFT: 50px; OVERFLOW: scroll; WIDTH: 734px; POSITION: absolute; TOP: 130px; HEIGHT: 250px"><asp:datagrid id="dtgCustomers" style="Z-INDEX: 101; LEFT: 1px; POSITION: absolute; TOP: 2px; Design_Time_Lock: True"
						runat="server" GridLines="Horizontal" CellPadding="4" BorderStyle="Double" BorderColor="#336666" BorderWidth="3px" BackColor="White" Design_Time_Lock="True" AutoGenerateColumns="False" HeaderStyle-BackColor="IndianRed"
						HeaderStyle-Font-Bold="True" HeaderStyle-Font-Name="Verdana" HeaderStyle-Font-Size="12px" HeaderStyle-ForeColor="White" ItemStyle-BackColor="Gainsboro" ItemStyle-Font-Name="verdana" ItemStyle-Font-Size="12px" OnCancelCommand="dtgCustomers_Cancel"
						OnEditCommand="dtgCustomers_Edit" OnUpdateCommand="dtgCustomers_Update" Height="30px" Width="710px" OnDeleteCommand="MyDataGrid_DeleteCommand">
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
									<asp:LinkButton id="lblDelete" runat="server" Text="<img border=0 src=images\add1.jpg alt=delete>"
										CommandName="Delete">
										<img border="0" src="images\add1.jpg" alt="delete"></asp:LinkButton>
								</ItemTemplate>
							</asp:TemplateColumn>
						</Columns>
						<PagerStyle HorizontalAlign="Center" ForeColor="White" BackColor="#336666" Mode="NumericPages"></PagerStyle>
					</asp:datagrid></div>
				<asp:panel id="Panel7" style="Z-INDEX: 113; LEFT: -24px; POSITION: absolute; TOP: 160px" runat="server"
					BackColor="ForestGreen" Height="256px" Width="48px"></asp:panel><asp:panel id="Panel6" style="Z-INDEX: 112; LEFT: -24px; POSITION: absolute; TOP: 24px" runat="server"
					BackColor="ForestGreen" Height="136px" Width="48px"></asp:panel>
				<asp:imagebutton id="ImgBtt1" style="Z-INDEX: 110; LEFT: 232px; POSITION: absolute; TOP: 80px" runat="server"
					Height="24px" Width="24px" ImageUrl="iCO\Cal1.jpg"></asp:imagebutton>
				<asp:label id="Label8" style="Z-INDEX: 102; LEFT: 56px; POSITION: absolute; TOP: 88px" runat="server"
					Height="24px" Width="80px">From Date</asp:label><asp:panel id="Panel5" style="Z-INDEX: 104; LEFT: 16px; POSITION: absolute; TOP: 112px" runat="server"
					BackColor="ForestGreen" Height="24px" Width="808px"></asp:panel>
				<asp:textbox id="Txttdt" style="Z-INDEX: 109; LEFT: 440px; POSITION: absolute; TOP: 80px" runat="server"
					Height="26px" Width="88px"></asp:textbox><asp:label id="Label10" style="Z-INDEX: 107; LEFT: 352px; POSITION: absolute; TOP: 80px" runat="server"
					Height="24px" Width="80px">To Date</asp:label>
				<asp:calendar id="Calendar2" style="Z-INDEX: 120; LEFT: 568px; POSITION: absolute; TOP: 80px"
					runat="server" BorderColor="White" BorderWidth="1px" BackColor="White" Height="184px" Width="176px"
					NextPrevFormat="FullMonth" ForeColor="Black" Font-Size="9pt" Font-Names="Verdana">
					<TodayDayStyle BackColor="#CCCCCC"></TodayDayStyle>
					<NextPrevStyle Font-Size="8pt" Font-Bold="True" ForeColor="#333333" VerticalAlign="Bottom"></NextPrevStyle>
					<DayHeaderStyle Font-Size="8pt" Font-Bold="True"></DayHeaderStyle>
					<SelectedDayStyle ForeColor="White" BackColor="#333399"></SelectedDayStyle>
					<TitleStyle Font-Size="12pt" Font-Bold="True" BorderWidth="4px" ForeColor="#333399" BorderColor="Black"
						BackColor="White"></TitleStyle>
					<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
				</asp:calendar>
				<asp:calendar id="Calendar1" style="Z-INDEX: 119; LEFT: 256px; POSITION: absolute; TOP: 80px"
					runat="server" BorderColor="White" BorderWidth="1px" BackColor="White" Height="184px" Width="180px"
					NextPrevFormat="FullMonth" ForeColor="Black" Font-Size="9pt" Font-Names="Verdana" Visible="False">
					<TodayDayStyle BackColor="#CCCCCC"></TodayDayStyle>
					<NextPrevStyle Font-Size="8pt" Font-Bold="True" ForeColor="#333333" VerticalAlign="Bottom"></NextPrevStyle>
					<DayHeaderStyle Font-Size="8pt" Font-Bold="True"></DayHeaderStyle>
					<SelectedDayStyle ForeColor="White" BackColor="#333399"></SelectedDayStyle>
					<TitleStyle Font-Size="12pt" Font-Bold="True" BorderWidth="4px" ForeColor="#333399" BorderColor="Black"
						BackColor="White"></TitleStyle>
					<OtherMonthDayStyle ForeColor="#999999"></OtherMonthDayStyle>
				</asp:calendar>
				<asp:textbox id="TxtFdt" style="Z-INDEX: 100; LEFT: 144px; POSITION: absolute; TOP: 80px" runat="server"
					Height="26px" Width="88px"></asp:textbox>
				<asp:label id="Label6" style="Z-INDEX: 105; LEFT: 288px; POSITION: absolute; TOP: 40px" runat="server"
					Height="24px" Width="80px" Visible="False">Pass Word</asp:label><asp:textbox id="TxtUser1" style="Z-INDEX: 101; LEFT: 168px; POSITION: absolute; TOP: 40px" runat="server"
					Height="26px" Width="96px" Visible="False"></asp:textbox><asp:label id="Label5" style="Z-INDEX: 103; LEFT: 64px; POSITION: absolute; TOP: 40px" runat="server"
					Height="16px" Width="104px" Visible="False">User Code</asp:label><asp:textbox id="TxtNam" style="Z-INDEX: 106; LEFT: 144px; POSITION: absolute; TOP: 40px" runat="server"
					Height="24px" Width="418px"></asp:textbox><asp:label id="Label7" style="Z-INDEX: 108; LEFT: 56px; POSITION: absolute; TOP: 40px" runat="server"
					Height="24px" Width="96px">Name</asp:label><asp:textbox id="Txtss" style="Z-INDEX: 114; LEFT: 632px; POSITION: absolute; TOP: 40px" runat="server"
					Height="26px" Width="56px" Visible="False"></asp:textbox><asp:textbox id="TxtMail" style="Z-INDEX: 115; LEFT: 624px; POSITION: absolute; TOP: 40px" runat="server"
					Width="136px" Visible="False"></asp:textbox><asp:textbox id="TxtPwd1" style="Z-INDEX: 116; LEFT: 408px; POSITION: absolute; TOP: 40px" runat="server"
					Height="26px" Width="96px" Visible="False" TextMode="Password"></asp:textbox><asp:button id="Button3" style="Z-INDEX: 117; LEFT: 304px; POSITION: absolute; TOP: 40px" runat="server"
					Width="74px" Visible="False" Text="Submit"></asp:button>
				<asp:imagebutton id="Imgbtt2" style="Z-INDEX: 110; LEFT: 528px; POSITION: absolute; TOP: 80px" runat="server"
					Width="24px" Height="24px" ImageUrl="iCO\Cal1.jpg"></asp:imagebutton>
			</FORM>
		</DIV>
		<asp:panel id="Panel10" style="Z-INDEX: 103; LEFT: 824px; POSITION: absolute; TOP: 8px" runat="server"
			BackColor="ForestGreen" Height="416px" Width="84px"></asp:panel><asp:panel id="Panel9" style="Z-INDEX: 102; LEFT: 0px; POSITION: absolute; TOP: 400px" runat="server"
			BackColor="ForestGreen" Height="24px" Width="856px"></asp:panel>
		<asp:panel id="Panel4" style="Z-INDEX: 104; LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server"
			Width="904px" Height="40px" BackColor="SeaGreen">
Administrator 
Page&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Approved 

Invoice </asp:panel>
	</body>
</HTML>
