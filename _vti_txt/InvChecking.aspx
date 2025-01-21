<%@ Page Language="vb" AutoEventWireup="false" Codebehind="InvChecking.aspx.vb" Inherits="Insu.InvChecking"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>InvChecking</title>
		<meta name="GENERATOR" content="Microsoft Visual Studio .NET 7.1">
		<meta name="CODE_LANGUAGE" content="Visual Basic .NET 7.1">
		<meta name="vs_defaultClientScript" content="JavaScript">
		<meta name="vs_targetSchema" content="http://schemas.microsoft.com/intellisense/ie5">
	</HEAD>
	<body MS_POSITIONING="GridLayout">
		<DIV style="LEFT: 8px; WIDTH: 10px; POSITION: absolute; TOP: 8px; HEIGHT: 10px" ms_positioning="text2D">
			<FORM id="Form1" runat="server">
				<asp:datagrid id="dtgCustomers" style="Z-INDEX: 101; LEFT: 56px; POSITION: absolute; TOP: 168px; Design_Time_Lock: True"
					runat="server" Width="710px" Height="30px" OnUpdateCommand="dtgCustomers_Update" OnEditCommand="dtgCustomers_Edit"
					OnCancelCommand="dtgCustomers_Cancel" ItemStyle-Font-Size="12px" ItemStyle-Font-Name="verdana"
					ItemStyle-BackColor="Gainsboro" HeaderStyle-ForeColor="White" HeaderStyle-Font-Size="12px"
					HeaderStyle-Font-Name="Verdana" HeaderStyle-Font-Bold="True" HeaderStyle-BackColor="IndianRed"
					AutoGenerateColumns="False" Design_Time_Lock="True">
					<ItemStyle Font-Size="12px" Font-Names="verdana" BackColor="Gainsboro"></ItemStyle>
					<HeaderStyle Font-Size="12px" Font-Names="Verdana" Font-Bold="True" ForeColor="White" BackColor="IndianRed"></HeaderStyle>
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
								<asp:Label id=lblInvTotVal Width="12px" Text='<%# DataBinder.Eval(Container.DataItem, "Inv_totval") %>' Runat="server">
								</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Total Qty">
							<HeaderStyle Width="0.75in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
							<ItemTemplate>
								<asp:Label id=lblTotQty Text='<%# DataBinder.Eval(Container.DataItem, "Inv_totqty") %>' Runat="server">
								</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:EditCommandColumn ButtonType="LinkButton" UpdateText="Update" HeaderText="To Approve" CancelText="Cancel"
							EditText="To Approve">
							<ItemStyle Width="100px"></ItemStyle>
						</asp:EditCommandColumn>
						<asp:TemplateColumn HeaderText="Approve ">
							<ItemTemplate>
								<asp:Label id=lblfg Runat="server" Text='<%# DataBinder.Eval(Container.DataItem, "Inv_flag1") %>'>
								</asp:Label>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:DropDownList id=ddlCountry runat="server" DataValueField="Flag" DataTextField="Flag" OnPreRender="SetDropDownIndex" DataSource="<%# BindTheCountry() %>">
								</asp:DropDownList>
							</EditItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Invoice">
							<ItemTemplate>
								<asp:LinkButton id="lblDelete" runat="server" Text="<img border=0 src=http://sgcsser\Insu\images\add1.jpg alt=delete>"
									CommandName="Delete">
									<img border="0" src="http://192.168.12.133\fleet\images\add1.jpg" alt="delete"></asp:LinkButton>
							</ItemTemplate>
						</asp:TemplateColumn>
					</Columns>
				</asp:datagrid>
				<asp:panel id="Panel7" style="Z-INDEX: 110; LEFT: 8px; POSITION: absolute; TOP: 160px" runat="server"
					Width="40px" Height="216px" BackColor="LightSkyBlue"></asp:panel><asp:panel id="Panel6" style="Z-INDEX: 109; LEFT: 8px; POSITION: absolute; TOP: 24px" runat="server"
					Width="40px" Height="136px" BackColor="LightSkyBlue"></asp:panel><asp:panel id="Panel5" style="Z-INDEX: 108; LEFT: 48px; POSITION: absolute; TOP: 72px" runat="server"
					Width="767px" Height="43px" BackColor="LightSkyBlue"></asp:panel>
				<asp:panel id="Panel4" style="Z-INDEX: 107; LEFT: 8px; POSITION: absolute; TOP: 8px" runat="server"
					Width="804px" Height="24px" BackColor="LightSkyBlue">Administrator 
Page&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Invoice 
&nbsp;Approval</asp:panel>
				<asp:label id="Label6" style="Z-INDEX: 104; LEFT: 288px; POSITION: absolute; TOP: 40px" runat="server"
					Width="80px" Height="24px" Visible="False">Pass Word</asp:label><asp:textbox id="TxtUser1" style="Z-INDEX: 102; LEFT: 168px; POSITION: absolute; TOP: 40px" runat="server"
					Width="96px" Height="26px" Visible="False"></asp:textbox><asp:label id="Label5" style="Z-INDEX: 103; LEFT: 64px; POSITION: absolute; TOP: 40px" runat="server"
					Width="104px" Height="16px" Visible="False">User Code</asp:label><asp:textbox id="TxtNam" style="Z-INDEX: 105; LEFT: 168px; POSITION: absolute; TOP: 40px" runat="server"
					Width="418px" Height="24px"></asp:textbox><asp:label id="Label7" style="Z-INDEX: 106; LEFT: 56px; POSITION: absolute; TOP: 40px" runat="server"
					Width="96px" Height="24px">Name</asp:label><asp:panel id="Panel8" style="Z-INDEX: 111; LEFT: 8px; POSITION: absolute; TOP: 376px" runat="server"
					Width="804px" Height="16px" BackColor="LightSkyBlue"></asp:panel><asp:textbox id="Txtss" style="Z-INDEX: 112; LEFT: 632px; POSITION: absolute; TOP: 40px" runat="server"
					Width="56px" Height="26px" Visible="False"></asp:textbox><asp:textbox id="TxtMail" style="Z-INDEX: 113; LEFT: 624px; POSITION: absolute; TOP: 40px" runat="server"
					Width="136px" Visible="False"></asp:textbox><asp:textbox id="TxtPwd1" style="Z-INDEX: 114; LEFT: 408px; POSITION: absolute; TOP: 40px" runat="server"
					Width="96px" Height="26px" Visible="False" TextMode="Password"></asp:textbox><asp:button id="Button3" style="Z-INDEX: 115; LEFT: 304px; POSITION: absolute; TOP: 40px" runat="server"
					Width="74px" Visible="False" Text="Submit"></asp:button></FORM>
		</DIV>
		<asp:panel id="Panel1" style="Z-INDEX: 110; LEFT: 784px; POSITION: absolute; TOP: 16px" runat="server"
			Height="384px" Width="40px" BackColor="LightSkyBlue"></asp:panel></FORM>
		<DIV></DIV>
	</body>
</HTML>
