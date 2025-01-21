<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Approval1.aspx.vb" Inherits="Insu.LeaveApproval" %>
<HTML>
	<HEAD>
		<title>DataGrid with a DropDownListBox</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<BODY MS_POSITIONING="GridLayout">
		<form id="Form1" runat="server">
			<asp:datagrid id="dtgCustomers" style="Z-INDEX: 101; LEFT: 56px; POSITION: absolute; TOP: 168px; Design_Time_Lock: True"
				runat="server" Width="710px" Height="30px" OnUpdateCommand="dtgCustomers_Update" OnEditCommand="dtgCustomers_Edit"
				OnCancelCommand="dtgCustomers_Cancel" ItemStyle-Font-Size="12px" ItemStyle-Font-Name="verdana"
				ItemStyle-BackColor="Gainsboro" HeaderStyle-ForeColor="White" HeaderStyle-Font-Size="12px"
				HeaderStyle-Font-Name="Verdana" HeaderStyle-Font-Bold="True" HeaderStyle-BackColor="IndianRed"
				AutoGenerateColumns="False" Design_Time_Lock="True">
				<ItemStyle Font-Size="12px" Font-Names="verdana" BackColor="Gainsboro"></ItemStyle>
				<HeaderStyle Font-Size="12px" Font-Names="Verdana" Font-Bold="True" ForeColor="White" BackColor="IndianRed"></HeaderStyle>
				<Columns>
					<asp:TemplateColumn HeaderText="Id">
						<ItemTemplate>
							<asp:Label id=lblId Text='<%# DataBinder.Eval(Container.DataItem, "Emp_No") %>' Runat="server">
							</asp:Label>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="Name">
						<ItemTemplate>
							<asp:Label id=lblName Runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Emp_Name") %>'>
							</asp:Label>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="Company">
						<ItemTemplate>
							<asp:Label id=lblCom Runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Emp_com") %>'>
							</asp:Label>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="Designation">
						<ItemTemplate>
							<asp:Label id=lblDes Runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Emp_Des") %>'>
							</asp:Label>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="Apply Date">
						<ItemTemplate>
							<asp:Label id=lblApdt Runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Trn_Apdt") %>'>
							</asp:Label>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="From Date">
						<ItemTemplate>
							<asp:Label id=lblFdt Runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Trn_Fdt") %>'>
							</asp:Label>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="To Date">
						<ItemTemplate>
							<asp:Label id=lblTdt Runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Trn_Tdt") %>'>
							</asp:Label>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:TemplateColumn HeaderText="No Of Date">
						<ItemTemplate>
							<asp:Label id=lblNolv Runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Trn_Nolv") %>'>
							</asp:Label>
						</ItemTemplate>
					</asp:TemplateColumn>
					<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="Update" HeaderText="To Approve" CancelText="Cancel"
						EditText="To Approve">
						<ItemStyle Width="100px"></ItemStyle>
					</asp:EditCommandColumn>
					<asp:TemplateColumn HeaderText="Approve ">
						<ItemTemplate>
							<asp:Label id=lblfg Runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Trn_fg") %>'>
							</asp:Label>
						</ItemTemplate>
						<EditItemTemplate>
							Total Leave :
							<asp:Label id=lblToLv runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Emp_ToLv") %>' Visible="True">
							</asp:Label>
							Taken :
							<asp:Label id=lblTaLv Runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Emp_Talv") %>' Visible="True">
							</asp:Label>
							Balance :
							<asp:Label id=lblbaLv Runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Emp_balv") %>' Visible="True">
							</asp:Label>
							<asp:DropDownList id=ddlCountry runat="server" DataValueField="Flag" DataTextField="Flag" OnPreRender="SetDropDownIndex" DataSource="<%# BindTheCountry() %>">
							</asp:DropDownList>
						</EditItemTemplate>
					</asp:TemplateColumn>
				</Columns>
			</asp:datagrid><asp:panel id="Panel7" style="Z-INDEX: 112; LEFT: 8px; POSITION: absolute; TOP: 160px" runat="server"
				Width="40px" Height="199px" BackColor="LightSkyBlue"></asp:panel><asp:panel id="Panel6" style="Z-INDEX: 111; LEFT: 8px; POSITION: absolute; TOP: 32px" runat="server"
				Width="40px" Height="104px" BackColor="LightSkyBlue"></asp:panel><asp:panel id="Panel5" style="Z-INDEX: 110; LEFT: 8px; POSITION: absolute; TOP: 136px" runat="server"
				Width="804px" Height="24px" BackColor="LightSkyBlue">For Leave Approvel</asp:panel>
			<asp:panel id="Panel4" style="Z-INDEX: 109; LEFT: 8px; POSITION: absolute; TOP: 8px" runat="server"
				Width="804px" Height="24px" BackColor="LightSkyBlue">Administrator Page</asp:panel>
			<asp:textbox id="TxtPwd1" style="Z-INDEX: 105; LEFT: 392px; POSITION: absolute; TOP: 64px" runat="server"
				Width="96px" Height="26px" TextMode="Password"></asp:textbox><asp:label id="Label6" style="Z-INDEX: 104; LEFT: 288px; POSITION: absolute; TOP: 64px" runat="server"
				Width="80px" Height="24px">Pass Word</asp:label><asp:textbox id="TxtUser1" style="Z-INDEX: 102; LEFT: 168px; POSITION: absolute; TOP: 64px" runat="server"
				Width="96px" Height="26px"></asp:textbox><asp:label id="Label5" style="Z-INDEX: 103; LEFT: 56px; POSITION: absolute; TOP: 64px" runat="server"
				Width="80px" Height="24px">User Code</asp:label><asp:button id="Button3" style="Z-INDEX: 106; LEFT: 520px; POSITION: absolute; TOP: 64px" runat="server"
				Width="74px" Text="Submit"></asp:button><asp:textbox id="TxtNam" style="Z-INDEX: 107; LEFT: 168px; POSITION: absolute; TOP: 104px" runat="server"
				Width="418px" Height="24px"></asp:textbox><asp:label id="Label7" style="Z-INDEX: 108; LEFT: 56px; POSITION: absolute; TOP: 104px" runat="server"
				Width="96px" Height="24px">Name</asp:label><asp:panel id="Panel8" style="Z-INDEX: 113; LEFT: 8px; POSITION: absolute; TOP: 360px" runat="server"
				Width="802px" Height="32px" BackColor="LightSkyBlue"></asp:panel><asp:textbox id="Txtss" style="Z-INDEX: 114; LEFT: 608px; POSITION: absolute; TOP: 104px" runat="server"
				Width="56px" Height="26px"></asp:textbox><asp:textbox id="TxtMail" style="Z-INDEX: 115; LEFT: 624px; POSITION: absolute; TOP: 64px" runat="server"
				Width="136px"></asp:textbox></form>
	</BODY>
</HTML>
