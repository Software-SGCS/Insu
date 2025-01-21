<%@ Page Language="vb" AutoEventWireup="false" Codebehind="HthEmployeeMaster1.aspx.vb" Inherits="Insu.HthEmployeeMaster1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Outword</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="#cccccc" leftMargin="0" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:textbox id="Txtchd" style="Z-INDEX: 116; LEFT: 416px; POSITION: absolute; TOP: 216px" tabIndex="8"
				runat="server" Width="48px"></asp:textbox><asp:dropdownlist id="LstReltyp" style="Z-INDEX: 113; LEFT: 256px; POSITION: absolute; TOP: 288px"
				tabIndex="6" runat="server" Width="120px" Height="40px"></asp:dropdownlist><asp:label id="Label7" style="Z-INDEX: 111; LEFT: 336px; POSITION: absolute; TOP: 216px" runat="server"
				Width="72px" Height="16px"> No of Child</asp:label><asp:label id="Label5" style="Z-INDEX: 110; LEFT: 376px; POSITION: absolute; TOP: 288px" runat="server"
				Width="48px" Height="16px">Id No</asp:label><asp:label id="Label3" style="Z-INDEX: 109; LEFT: 120px; POSITION: absolute; TOP: 288px" runat="server"
				Width="96px" Height="16px">Relation Type</asp:label><asp:label id="Label1" style="Z-INDEX: 108; LEFT: 120px; POSITION: absolute; TOP: 256px" runat="server"
				Width="96px" Height="16px">Relation Name</asp:label><asp:panel id="Panel6" style="Z-INDEX: 107; LEFT: 888px; POSITION: absolute; TOP: 64px" runat="server"
				Width="46px" Height="494px" BackColor="Desktop"></asp:panel><asp:panel id="Panel1" style="Z-INDEX: 101; LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server"
				Width="932px" Height="64px" BackColor="Desktop" Font-Bold="True" HorizontalAlign="Left" Enabled="False" ForeColor="White" BorderColor="Transparent" BackImageUrl="Menu/banner.jpg"><FONT style="BACKGROUND-COLOR: #000066">
					<asp:panel id="Panel3" style="Z-INDEX: 101; LEFT: 0px; POSITION: absolute; TOP: 64px" runat="server"
						Width="112px" Height="544px" BackColor="Desktop" BackImageUrl="Menu/EmpMaster4.jpg"></asp:panel>
					<DIV id="Layer1" style="Z-INDEX: 102; LEFT: 120px; OVERFLOW: scroll; WIDTH: 768px; POSITION: absolute; TOP: 328px; HEIGHT: 214px">
						<asp:datagrid id="MyDataGrid" runat="server" Width="712px" Height="12px" BackColor="White" BorderColor="Brown"
							ForeColor="#80FF80" cellpadding="3" Headerstyle-BackColor="#8080C0" Headerstyle-Font-Name="Tahoma"
							Headerstyle-Font-Size="12" Headerstyle-Font-Bold="True" Font-Name="Tahoma" Font-Size="12pt"
							AutogenerateColumns="False" OnEditcommand="MyDataGrid_EditCommand" OnCancelcommand="MyDataGrid_Cancel"
							OnUpdateCommand="MyDataGrid_UpdateCommand" OnDeleteCommand="MyDataGrid_DeleteCommand" DataKeyField="id"
							Font-Names="Tahoma" BorderStyle="None" BorderWidth="1px">
							<SelectedItemStyle Font-Size="Smaller" Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
							<EditItemStyle Font-Size="Smaller"></EditItemStyle>
							<AlternatingItemStyle Font-Size="Smaller"></AlternatingItemStyle>
							<ItemStyle Font-Size="Smaller" ForeColor="#000066"></ItemStyle>
							<HeaderStyle Font-Size="12pt" Font-Names="Arial" Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
							<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
							<Columns>
								<asp:TemplateColumn>
									<ItemTemplate>
										<asp:LinkButton id="lbtnEdit" runat="server" Text="<img border=0 src=images/dtg_edit.gif alt=edit>"
											CommandName="Edit"></asp:LinkButton>
									</ItemTemplate>
									<EditItemTemplate>
										<asp:LinkButton id="lbtnUpdate" runat="server" Text="<img  border=0 src=images/dtg_update.gif alt=save/update>"
											CommandName="Update"></asp:LinkButton>
										<asp:LinkButton id="lbtnCancel" runat="server" Text="<img border=0 src=images/dtg_cancel.gif alt=cancel>"
											CommandName="Cancel"></asp:LinkButton>
									</EditItemTemplate>
								</asp:TemplateColumn>
								<asp:TemplateColumn>
									<ItemTemplate>
										<asp:LinkButton id="lblDelete" runat="server" Text="<img border=0 src=images/delete.jpg alt=delete>"
											CommandName="Delete"></asp:LinkButton>
									</ItemTemplate>
								</asp:TemplateColumn>
								<asp:BoundColumn DataField="Rel_Nam" HeaderText="Relation Name">
									<HeaderStyle Width="4in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="Rel_Type" HeaderText="Relation Type">
									<HeaderStyle Width="1.5in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="Rel_Dob" HeaderText="Date of Birth ">
									<HeaderStyle Width="1.5in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="Rel_Idno" HeaderText="Nic No">
									<HeaderStyle Width="1.5in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
						</asp:datagrid></DIV>
					Health Master &nbsp;Data Entry</FONT></asp:panel>
			<asp:panel id="Panel2" style="Z-INDEX: 102; LEFT: 0px; POSITION: absolute; TOP: 608px" runat="server"
				Width="932px" Height="70px" BackColor="Desktop" BackImageUrl="Menu/EmpMaster3.jpg"></asp:panel><asp:button id="BtnEdit" style="Z-INDEX: 103; LEFT: 80px; POSITION: absolute; TOP: 584px" tabIndex="8"
				runat="server" Width="64px" Font-Bold="True" Enabled="False" Visible="False" Text="Edit"></asp:button><asp:button id="BtnSave" style="Z-INDEX: 117; LEFT: 320px; POSITION: absolute; TOP: 584px" tabIndex="11"
				runat="server" Width="64px" Font-Bold="True" Enabled="False" Visible="False" Text="Save"></asp:button><asp:dropdownlist id="LstEmpNo" style="Z-INDEX: 106; LEFT: 336px; POSITION: absolute; TOP: 112px"
				tabIndex="1" runat="server" Width="344px" Height="24px" AutoPostBack="True"></asp:dropdownlist><asp:button id="BtnCle" style="Z-INDEX: 104; LEFT: 152px; POSITION: absolute; TOP: 584px" tabIndex="9"
				runat="server" Width="72px" Height="24px" Font-Bold="True" Enabled="False" Visible="False" Text="Clear"></asp:button><asp:button id="BtnAdd" style="Z-INDEX: 100; LEFT: 8px; POSITION: absolute; TOP: 512px" tabIndex="7"
				runat="server" Width="64px" Font-Bold="True" Enabled="False" Visible="False" Text="Add"></asp:button><asp:button id="BtnDel" style="Z-INDEX: 105; LEFT: 240px; POSITION: absolute; TOP: 584px" tabIndex="11"
				runat="server" Width="64px" Font-Bold="True" Enabled="False" Visible="False" Text="Delete"></asp:button><asp:button id="BttIns" style="Z-INDEX: 112; LEFT: 768px; POSITION: absolute; TOP: 288px" tabIndex="11"
				runat="server" Width="66px" Text="Insert"></asp:button><asp:textbox id="TxtRNam" style="Z-INDEX: 114; LEFT: 256px; POSITION: absolute; TOP: 256px" tabIndex="5"
				runat="server" Width="344px"></asp:textbox><asp:textbox id="TxtRelId" style="Z-INDEX: 115; LEFT: 416px; POSITION: absolute; TOP: 288px"
				tabIndex="7" runat="server" Width="120px"></asp:textbox><asp:textbox id="LstCom" style="Z-INDEX: 118; LEFT: 712px; POSITION: absolute; TOP: 112px" runat="server"
				Width="90px" ReadOnly="True"></asp:textbox><asp:textbox id="TxtEmpNam" style="Z-INDEX: 119; LEFT: 256px; POSITION: absolute; TOP: 152px"
				tabIndex="3" runat="server" Width="342px"></asp:textbox><asp:label id="Label9" style="Z-INDEX: 120; LEFT: 608px; POSITION: absolute; TOP: 152px" runat="server"
				Width="38px" Height="16px">Id No</asp:label><asp:dropdownlist id="LstCom1" style="Z-INDEX: 121; LEFT: 256px; POSITION: absolute; TOP: 72px" tabIndex="2"
				runat="server" Width="416px" Height="24px" AutoPostBack="True"></asp:dropdownlist><asp:textbox id="TxtDoA" style="Z-INDEX: 122; LEFT: 256px; POSITION: absolute; TOP: 216px" tabIndex="10"
				runat="server" Width="80px"></asp:textbox><asp:textbox id="TxtEmpAdd" style="Z-INDEX: 123; LEFT: 256px; POSITION: absolute; TOP: 184px"
				runat="server" Width="515px"></asp:textbox><asp:textbox id="TxtEmpNo" style="Z-INDEX: 124; LEFT: 256px; POSITION: absolute; TOP: 112px"
				tabIndex="1" runat="server" Width="74px" Height="24px" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtIdNo" style="Z-INDEX: 125; LEFT: 660px; POSITION: absolute; TOP: 152px" tabIndex="4"
				runat="server" Width="107px"></asp:textbox><asp:label id="Label8" style="Z-INDEX: 126; LEFT: 120px; POSITION: absolute; TOP: 152px" runat="server"
				Width="114px" Height="16px">Employee Name</asp:label><asp:label id="Invoice" style="Z-INDEX: 127; LEFT: 120px; POSITION: absolute; TOP: 120px" runat="server"
				Width="104px" Height="24px">Emp No</asp:label><asp:label id="Label2" style="Z-INDEX: 128; LEFT: 120px; POSITION: absolute; TOP: 72px" runat="server"
				Width="64px" Height="24px">Company</asp:label><asp:label id="Label11" style="Z-INDEX: 129; LEFT: 120px; POSITION: absolute; TOP: 224px" runat="server"
				Width="129px" Height="24px">Date of Birth</asp:label><asp:label id="Label10" style="Z-INDEX: 130; LEFT: 120px; POSITION: absolute; TOP: 184px" runat="server"
				Width="112px" Height="24px">Address</asp:label><asp:label id="Label13" style="Z-INDEX: 131; LEFT: 472px; POSITION: absolute; TOP: 216px" runat="server"
				Width="80px" Height="24px">Active(Y/N)</asp:label><asp:textbox id="Txtfg" style="Z-INDEX: 132; LEFT: 560px; POSITION: absolute; TOP: 216px" runat="server"
				Width="24px" Height="24px" ReadOnly="True"></asp:textbox><asp:textbox id="TxtOldepfno" style="Z-INDEX: 133; LEFT: 696px; POSITION: absolute; TOP: 208px"
				runat="server" Width="48px" Height="26px"></asp:textbox><asp:label id="Label6" style="Z-INDEX: 135; LEFT: 600px; POSITION: absolute; TOP: 216px" runat="server"
				Width="88px" Height="24px">Old Epf No'S</asp:label><asp:textbox id="Txtrelage" style="Z-INDEX: 136; LEFT: 656px; POSITION: absolute; TOP: 288px"
				runat="server" Width="96px" Height="24px"></asp:textbox><asp:label id="Label12" style="Z-INDEX: 137; LEFT: 544px; POSITION: absolute; TOP: 280px" runat="server"
				Width="96px" Height="24px" BackColor="White">Date Of Birth</asp:label><asp:label id="L1" style="Z-INDEX: 138; LEFT: 128px; POSITION: absolute; TOP: 560px" runat="server"
				Width="88px" Height="24px">Label</asp:label><asp:label id="Label4" style="Z-INDEX: 139; LEFT: 544px; POSITION: absolute; TOP: 304px" runat="server"
				Width="96px" Height="3px" BackColor="White" Font-Size="Smaller">DD/MM/YYYY</asp:label><asp:textbox id="TxtOldepfno1" style="Z-INDEX: 140; LEFT: 752px; POSITION: absolute; TOP: 208px"
				runat="server" Width="48px" Height="26px"></asp:textbox><asp:textbox id="TxtOldepfno2" style="Z-INDEX: 141; LEFT: 808px; POSITION: absolute; TOP: 208px"
				runat="server" Width="48px" Height="26px"></asp:textbox><asp:textbox id="TxtOldepfno3" style="Z-INDEX: 142; LEFT: 696px; POSITION: absolute; TOP: 240px"
				runat="server" Width="48px" Height="26px"></asp:textbox><asp:textbox id="TxtOldepfno4" style="Z-INDEX: 143; LEFT: 752px; POSITION: absolute; TOP: 240px"
				runat="server" Width="48px" Height="26px"></asp:textbox></form>
	</body>
</HTML>
