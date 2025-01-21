<%@ Page Language="vb" AutoEventWireup="false" Codebehind="PayApproval.aspx.vb" Inherits="Insu.PayApproval" %>
<HTML>
	<HEAD>
		<title>DataGrid with a DropDownListBox</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<BODY topMargin="45" MS_POSITIONING="GridLayout">
		<form id="Form1" runat="server">
			<div id="Layer1" style="Z-INDEX: 128; LEFT: 56px; OVERFLOW: scroll; WIDTH: 750px; POSITION: absolute; TOP: 96px; HEIGHT: 284px">
				<asp:datagrid id="dtgCustomers" style="Z-INDEX: 101; LEFT: 0px; POSITION: absolute; TOP: 0px; Design_Time_Lock: True"
					runat="server" OnDeleteCommand="MyDataGrid_DeleteCommand" Width="710px" Height="30px" OnUpdateCommand="dtgCustomers_Update"
					OnEditCommand="dtgCustomers_Edit" OnCancelCommand="dtgCustomers_Cancel" ItemStyle-Font-Size="12px"
					ItemStyle-Font-Name="verdana" ItemStyle-BackColor="Gainsboro" HeaderStyle-ForeColor="White"
					HeaderStyle-Font-Size="12px" HeaderStyle-Font-Name="Verdana" HeaderStyle-Font-Bold="True"
					HeaderStyle-BackColor="IndianRed" AutoGenerateColumns="False" Design_Time_Lock="True" BackColor="White"
					BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3">
					<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
					<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
					<ItemStyle Font-Size="12px" Font-Names="verdana" ForeColor="#000066" BackColor="Gainsboro"></ItemStyle>
					<HeaderStyle Font-Size="12px" Font-Names="Verdana" Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
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
						<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="Update" HeaderText="To Approve" CancelText="Cancel"
							EditText="To Approve">
							<ItemStyle Width="100px"></ItemStyle>
						</asp:EditCommandColumn>
						<asp:TemplateColumn HeaderText="Approve ">
							<ItemTemplate>
								<asp:Label id=lblfg Text='<%# DataBinder.Eval(Container.DataItem, "ALLOW2") %>' Runat="server">
								</asp:Label>
							</ItemTemplate>
							<EditItemTemplate>
								Total Value :
								<asp:Label id=lblVal runat="server" Visible="True" Text='<%# DataBinder.Eval(Container.DataItem, "Veh_val") %>'>
								</asp:Label>Rcc :
								<asp:Label id=lblRcc Visible="True" Text='<%# DataBinder.Eval(Container.DataItem, "Veh_Rcc") %>' Runat="server">
								</asp:Label>Tr :
								<asp:Label id=lblTr Visible="True" Text='<%# DataBinder.Eval(Container.DataItem, "Veh_Tr") %>' Runat="server">
								</asp:Label>
								<asp:DropDownList id=ddlCountry runat="server" DataValueField="Flag" DataTextField="Flag" OnPreRender="SetDropDownIndex" DataSource="<%# BindTheCountry() %>">
								</asp:DropDownList>
							</EditItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Payment Notice">
							<ItemTemplate>
								<asp:LinkButton id="lblDelete" runat="server" Text="<img border=0 src=http://192.168.12.207\Insu\images\add1.jpg alt=delete>"
									CommandName="Delete">
									<img border="0" src="http://192.168.12.133\fleet\images\add1.jpg" alt="delete"></asp:LinkButton>
							</ItemTemplate>
						</asp:TemplateColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
				</asp:datagrid>
			</div>
			<asp:panel id="Panel7" style="Z-INDEX: 110; LEFT: 8px; POSITION: absolute; TOP: 160px" runat="server"
				Width="40px" Height="199px" BackColor="Desktop"></asp:panel><asp:panel id="Panel6" style="Z-INDEX: 109; LEFT: 8px; POSITION: absolute; TOP: 24px" runat="server"
				Width="40px" Height="136px" BackColor="Desktop"></asp:panel><asp:panel id="Panel5" style="Z-INDEX: 108; LEFT: 48px; POSITION: absolute; TOP: 72px" runat="server"
				Width="764px" Height="24px" BackColor="Desktop">For&nbsp;Approvel</asp:panel>
			<asp:panel id="Panel4" style="Z-INDEX: 107; LEFT: 8px; POSITION: absolute; TOP: 8px" runat="server"
				Width="804px" Height="24px" BackColor="Desktop">Administrator 
Page&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
Insurence&nbsp;Payment Note&nbsp;Approval</asp:panel><asp:label id="Label6" style="Z-INDEX: 104; LEFT: 288px; POSITION: absolute; TOP: 40px" runat="server"
				Width="80px" Height="24px" Visible="False">Pass Word</asp:label><asp:textbox id="TxtUser1" style="Z-INDEX: 102; LEFT: 168px; POSITION: absolute; TOP: 40px" runat="server"
				Width="96px" Height="26px" Visible="False"></asp:textbox><asp:label id="Label5" style="Z-INDEX: 103; LEFT: 64px; POSITION: absolute; TOP: 40px" runat="server"
				Width="104px" Height="16px" Visible="False">User Code</asp:label><asp:textbox id="TxtNam" style="Z-INDEX: 105; LEFT: 168px; POSITION: absolute; TOP: 40px" runat="server"
				Width="418px" Height="24px"></asp:textbox><asp:label id="Label7" style="Z-INDEX: 106; LEFT: 56px; POSITION: absolute; TOP: 40px" runat="server"
				Width="96px" Height="24px">Name</asp:label><asp:panel id="Panel8" style="Z-INDEX: 111; LEFT: 8px; POSITION: absolute; TOP: 360px" runat="server"
				Width="802px" Height="32px" BackColor="Desktop"></asp:panel><asp:textbox id="Txtss" style="Z-INDEX: 112; LEFT: 632px; POSITION: absolute; TOP: 40px" runat="server"
				Width="56px" Height="26px" Visible="False"></asp:textbox><asp:textbox id="TxtMail" style="Z-INDEX: 113; LEFT: 624px; POSITION: absolute; TOP: 40px" runat="server"
				Width="136px" Visible="False"></asp:textbox>
			<asp:textbox id="TxtPwd1" style="Z-INDEX: 114; LEFT: 408px; POSITION: absolute; TOP: 40px" runat="server"
				Width="96px" Height="26px" Visible="False" TextMode="Password"></asp:textbox><asp:button id="Button3" style="Z-INDEX: 115; LEFT: 304px; POSITION: absolute; TOP: 40px" runat="server"
				Width="74px" Visible="False" Text="Submit"></asp:button>
			<asp:TextBox id="Txtvehno" style="Z-INDEX: 116; LEFT: 776px; POSITION: absolute; TOP: 40px" runat="server"
				Width="120px" Enabled="False" Visible="False"></asp:TextBox></form>
	</BODY>
</HTML>
