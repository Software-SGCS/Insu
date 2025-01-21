<%@ Page Language="vb" AutoEventWireup="false" Codebehind="PayApprovalnewM.aspx.vb" Inherits="Insu.PayApprovalnewM" %>
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
			<div id="Layer1" style="Z-INDEX: 116; LEFT: 120px; OVERFLOW: scroll; WIDTH: 750px; POSITION: absolute; TOP: 96px; HEIGHT: 284px"><asp:datagrid id="dtgCustomers" style="Z-INDEX: 101; LEFT: 0px; POSITION: absolute; TOP: 0px; Design_Time_Lock: True"
					runat="server" GridLines="Horizontal" OnDeleteCommand="MyDataGrid_DeleteCommand" Width="710px" Height="30px" OnUpdateCommand="dtgCustomers_Update" OnEditCommand="dtgCustomers_Edit" OnCancelCommand="dtgCustomers_Cancel"
					ItemStyle-Font-Size="12px" ItemStyle-Font-Name="verdana" ItemStyle-BackColor="Gainsboro" HeaderStyle-ForeColor="White" HeaderStyle-Font-Size="12px" HeaderStyle-Font-Name="Verdana" HeaderStyle-Font-Bold="True" HeaderStyle-BackColor="IndianRed"
					AutoGenerateColumns="False" Design_Time_Lock="True" BackColor="White" BorderColor="#336666" BorderStyle="Double" BorderWidth="3px" CellPadding="4">
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
						<asp:TemplateColumn HeaderText="Total Chq Pay">
							<ItemTemplate>
								<asp:Label id="Label1" Text='<%# DataBinder.Eval(Container.DataItem, "Veh_TotChqPay") %>' Runat="server">
								</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Payment Notice">
							<ItemTemplate>
								<asp:LinkButton id="lblDelete" runat="server" Text="<img border=0 src=http://192.168.12.165\Insu\images\add1.jpg alt=delete>"
									CommandName="Delete">
									<img border="0" src="=images\add1.jpg" alt="delete"></asp:LinkButton>
							</ItemTemplate>
						</asp:TemplateColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
				</asp:datagrid></div>
			<asp:button id="BttApp" style="Z-INDEX: 117; LEFT: 120px; POSITION: absolute; TOP: 384px" runat="server"
				Width="160px" Height="32px" Text="Approval All"></asp:button><asp:panel id="Panel7" style="Z-INDEX: 109; LEFT: 8px; POSITION: absolute; TOP: 160px" runat="server"
				Width="112px" Height="256px" BackColor="Desktop" BackImageUrl="Menu/audit.gif"></asp:panel><asp:panel id="Panel6" style="Z-INDEX: 108; LEFT: 8px; POSITION: absolute; TOP: 32px" runat="server"
				Width="112px" Height="128px" BackColor="Desktop" BackImageUrl="Menu/AssetI.gif"></asp:panel><asp:panel id="Panel5" style="Z-INDEX: 107; LEFT: 120px; POSITION: absolute; TOP: 72px" runat="server"
				Width="750px" Height="24px" BackColor="Desktop">For&nbsp;Approvel</asp:panel>
			<asp:panel id="Panel4" style="Z-INDEX: 106; LEFT: 8px; POSITION: absolute; TOP: 8px" runat="server"
				Width="862px" Height="24px" BackColor="Desktop">Administrator 
Page&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
Insurence&nbsp;Payment Note&nbsp;Approval</asp:panel><asp:label id="Label6" style="Z-INDEX: 103; LEFT: 288px; POSITION: absolute; TOP: 40px" runat="server"
				Width="80px" Height="24px" Visible="False">Pass Word</asp:label><asp:textbox id="TxtUser1" style="Z-INDEX: 101; LEFT: 248px; POSITION: absolute; TOP: 40px" runat="server"
				Width="96px" Height="26px" Visible="False"></asp:textbox><asp:label id="Label5" style="Z-INDEX: 102; LEFT: 128px; POSITION: absolute; TOP: 40px" runat="server"
				Width="112px" Height="8px" Visible="False">User Code</asp:label><asp:textbox id="TxtNam" style="Z-INDEX: 104; LEFT: 312px; POSITION: absolute; TOP: 40px" runat="server"
				Width="418px" Height="24px" Visible="False"></asp:textbox><asp:label id="Label7" style="Z-INDEX: 105; LEFT: 128px; POSITION: absolute; TOP: 40px" runat="server"
				Width="96px" Height="24px">Name</asp:label><asp:panel id="Panel8" style="Z-INDEX: 110; LEFT: 8px; POSITION: absolute; TOP: 416px" runat="server"
				Width="862px" Height="45px" BackColor="Desktop"></asp:panel><asp:textbox id="Txtss" style="Z-INDEX: 111; LEFT: 632px; POSITION: absolute; TOP: 40px" runat="server"
				Width="56px" Height="26px" Visible="False"></asp:textbox><asp:textbox id="TxtMail" style="Z-INDEX: 112; LEFT: 720px; POSITION: absolute; TOP: 40px" runat="server"
				Width="136px" Visible="False"></asp:textbox>
			<asp:textbox id="TxtPwd1" style="Z-INDEX: 113; LEFT: 408px; POSITION: absolute; TOP: 40px" runat="server"
				Width="96px" Height="26px" Visible="False" TextMode="Password"></asp:textbox><asp:button id="Button3" style="Z-INDEX: 114; LEFT: 304px; POSITION: absolute; TOP: 40px" runat="server"
				Width="74px" Text="Submit" Visible="False"></asp:button><asp:textbox id="Txtvehno" style="Z-INDEX: 115; LEFT: 776px; POSITION: absolute; TOP: 40px" runat="server"
				Width="120px" Visible="False" Enabled="False"></asp:textbox><asp:label id="L1" style="Z-INDEX: 118; LEFT: 440px; POSITION: absolute; TOP: 432px" runat="server"
				Width="88px" Height="16px">Label</asp:label></FORM>
	</BODY>
</HTML>
