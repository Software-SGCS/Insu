<%@ Page Language="vb" AutoEventWireup="false" Codebehind="EntryEmployeeMaster.aspx.vb" Inherits="Insu.EntryEmployeeMaster" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Outword</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="#ffffff" leftMargin="0" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:textbox id="TxtRelAge" style="Z-INDEX: 118; LEFT: 664px; POSITION: absolute; TOP: 224px"
				tabIndex="8" runat="server" Font-Size="X-Small" Width="58px"></asp:textbox><asp:dropdownlist id="LstReltyp" style="Z-INDEX: 114; LEFT: 256px; POSITION: absolute; TOP: 224px"
				tabIndex="6" runat="server" Font-Size="X-Small" Width="120px" Height="40px"></asp:dropdownlist><asp:label id="Label7" style="Z-INDEX: 112; LEFT: 584px; POSITION: absolute; TOP: 224px" runat="server"
				Width="82px" Height="16px"> Age</asp:label><asp:label id="Label5" style="Z-INDEX: 111; LEFT: 392px; POSITION: absolute; TOP: 224px" runat="server"
				Width="72px" Height="16px">Id No</asp:label><asp:label id="Label4" style="Z-INDEX: 110; LEFT: 120px; POSITION: absolute; TOP: 256px" runat="server"
				Width="96px" Height="16px"> Death(Y/N)</asp:label><asp:label id="Label3" style="Z-INDEX: 109; LEFT: 120px; POSITION: absolute; TOP: 224px" runat="server"
				Width="96px" Height="16px">Relation Type</asp:label><asp:label id="Label1" style="Z-INDEX: 108; LEFT: 120px; POSITION: absolute; TOP: 192px" runat="server"
				Width="96px" Height="16px">Relation Name</asp:label><asp:panel id="Panel1" style="Z-INDEX: 102; LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server"
				Width="932px" Height="64px" Font-Bold="True" HorizontalAlign="Left" Enabled="False" ForeColor="White" BorderColor="Transparent" BackImageUrl="Menu/banner.jpg"
				BackColor="Desktop"><FONT style="BACKGROUND-COLOR: #000066">
					<asp:panel id="Panel3" style="Z-INDEX: 101; LEFT: 0px; POSITION: absolute; TOP: 64px" runat="server"
						Width="112px" Height="560px" BackImageUrl="Menu/EmpMaster4.jpg" BackColor="Desktop"></asp:panel>
					<asp:Label id="Label13" style="Z-INDEX: 102; LEFT: 464px; POSITION: absolute; TOP: 176px" runat="server"
						Font-Size="XX-Small" Width="72px" Height="16px" ForeColor="Black" BorderColor="Transparent"
						BackColor="White">DD/MM/YYYY</asp:Label>Death Donation Data Entry</FONT></asp:panel>
			<asp:panel id="Panel2" style="Z-INDEX: 103; LEFT: 0px; POSITION: absolute; TOP: 589px" runat="server"
				Width="932px" Height="89px" BackImageUrl="Menu/EmpMaster3.jpg" BackColor="Desktop"></asp:panel><asp:button id="BtnEdit" style="Z-INDEX: 104; LEFT: 80px; POSITION: absolute; TOP: 584px" tabIndex="8"
				runat="server" Width="64px" Font-Bold="True" Enabled="False" Visible="False" Text="Edit"></asp:button><asp:button id="BtnSave" style="Z-INDEX: 119; LEFT: 320px; POSITION: absolute; TOP: 584px" tabIndex="11"
				runat="server" Width="64px" Font-Bold="True" Enabled="False" Visible="False" Text="Save"></asp:button><asp:dropdownlist id="LstEmpNo" style="Z-INDEX: 107; LEFT: 472px; POSITION: absolute; TOP: 72px" tabIndex="1"
				runat="server" Width="90px" Height="24px" AutoPostBack="True"></asp:dropdownlist><asp:button id="BtnCle" style="Z-INDEX: 105; LEFT: 152px; POSITION: absolute; TOP: 584px" tabIndex="9"
				runat="server" Width="72px" Height="24px" Font-Bold="True" Enabled="False" Visible="False" Text="Clear"></asp:button><asp:button id="BtnAdd" style="Z-INDEX: 101; LEFT: 8px; POSITION: absolute; TOP: 512px" tabIndex="7"
				runat="server" Width="64px" Font-Bold="True" Enabled="False" Visible="False" Text="Add"></asp:button><asp:button id="BtnDel" style="Z-INDEX: 106; LEFT: 240px; POSITION: absolute; TOP: 584px" tabIndex="11"
				runat="server" Width="64px" Font-Bold="True" Enabled="False" Visible="False" Text="Delete"></asp:button><asp:button id="BttIns" style="Z-INDEX: 113; LEFT: 328px; POSITION: absolute; TOP: 256px" tabIndex="11"
				runat="server" Width="66px" Text="Insert"></asp:button><asp:textbox id="TxtRNam" style="Z-INDEX: 115; LEFT: 256px; POSITION: absolute; TOP: 192px" tabIndex="5"
				runat="server" Font-Size="X-Small" Width="426px"></asp:textbox><asp:textbox id="TxtRelId" style="Z-INDEX: 116; LEFT: 464px; POSITION: absolute; TOP: 224px"
				tabIndex="7" runat="server" Font-Size="X-Small" Width="112px"></asp:textbox><asp:textbox id="Txtfg" style="Z-INDEX: 117; LEFT: 256px; POSITION: absolute; TOP: 256px" tabIndex="9"
				runat="server" Font-Size="X-Small" Width="26px"></asp:textbox><asp:textbox id="LstCom" style="Z-INDEX: 120; LEFT: 608px; POSITION: absolute; TOP: 72px" runat="server"
				Width="90px" ReadOnly="True"></asp:textbox><asp:textbox id="TxtEmpNam" style="Z-INDEX: 121; LEFT: 256px; POSITION: absolute; TOP: 104px"
				tabIndex="3" runat="server" Font-Size="X-Small" Width="342px"></asp:textbox><asp:label id="Label9" style="Z-INDEX: 122; LEFT: 608px; POSITION: absolute; TOP: 104px" runat="server"
				Width="38px" Height="16px">Id No</asp:label><asp:dropdownlist id="LstCom1" style="Z-INDEX: 123; LEFT: 400px; POSITION: absolute; TOP: 72px" tabIndex="2"
				runat="server" Width="372px" Height="24px" AutoPostBack="True"></asp:dropdownlist><asp:textbox id="TxtDoA" style="Z-INDEX: 124; LEFT: 256px; POSITION: absolute; TOP: 152px" tabIndex="10"
				runat="server" Font-Size="X-Small" Width="72px"></asp:textbox><asp:textbox id="TxtEmpAdd" style="Z-INDEX: 125; LEFT: 256px; POSITION: absolute; TOP: 128px"
				runat="server" Font-Size="X-Small" Width="515px"></asp:textbox><asp:textbox id="TxtEmpNo" style="Z-INDEX: 126; LEFT: 256px; POSITION: absolute; TOP: 72px" tabIndex="1"
				runat="server" Width="74px" Height="24px" AutoPostBack="True"></asp:textbox><asp:textbox id="TxtIdNo" style="Z-INDEX: 127; LEFT: 660px; POSITION: absolute; TOP: 104px" tabIndex="4"
				runat="server" Font-Size="X-Small" Width="107px"></asp:textbox><asp:label id="Label8" style="Z-INDEX: 128; LEFT: 120px; POSITION: absolute; TOP: 104px" runat="server"
				Width="114px" Height="16px">Employee Name</asp:label><asp:label id="Invoice" style="Z-INDEX: 129; LEFT: 120px; POSITION: absolute; TOP: 72px" runat="server"
				Width="104px" Height="24px">Emp No</asp:label><asp:label id="Label2" style="Z-INDEX: 130; LEFT: 336px; POSITION: absolute; TOP: 72px" runat="server"
				Width="64px" Height="24px">Company</asp:label><asp:label id="Label11" style="Z-INDEX: 131; LEFT: 120px; POSITION: absolute; TOP: 152px" runat="server"
				Width="129px" Height="24px">Date of Appointment</asp:label><asp:label id="Label10" style="Z-INDEX: 132; LEFT: 120px; POSITION: absolute; TOP: 128px" runat="server"
				Width="112px" Height="24px">Address</asp:label><asp:label id="L1" style="Z-INDEX: 133; LEFT: 712px; POSITION: absolute; TOP: 256px" runat="server"
				Font-Size="X-Small" Width="128px" Height="24px"></asp:label><asp:label id="Label6" style="Z-INDEX: 134; LEFT: 256px; POSITION: absolute; TOP: 176px" runat="server"
				Font-Size="XX-Small" Width="72px" Height="16px">DD/MM/YYYY</asp:label><asp:label id="Label12" style="Z-INDEX: 135; LEFT: 352px; POSITION: absolute; TOP: 152px" runat="server"
				Width="88px" Height="24px">Date of Birth</asp:label><asp:label id="Label14" style="Z-INDEX: 136; LEFT: 560px; POSITION: absolute; TOP: 152px" runat="server"
				Width="80px" Height="24px">Old Epf No</asp:label><asp:textbox id="TxtOldNo" style="Z-INDEX: 137; LEFT: 656px; POSITION: absolute; TOP: 152px"
				tabIndex="10" runat="server" Font-Size="X-Small" Width="56px"></asp:textbox><asp:textbox id="TxtDob" style="Z-INDEX: 138; LEFT: 464px; POSITION: absolute; TOP: 152px" runat="server"
				Font-Size="X-Small" Width="72px"></asp:textbox>
			<DIV id="Layer1" style="Z-INDEX: 100; LEFT: 120px; OVERFLOW: scroll; WIDTH: 736px; POSITION: absolute; TOP: 288px; HEIGHT: 236px"><asp:datagrid id="MyDataGrid" runat="server" Font-Size="Small" Width="712px" Height="10px" ForeColor="Black"
					BorderColor="#DEDFDE" BackColor="White" GridLines="Vertical" cellpadding="4" Headerstyle-BackColor="#8080C0" Headerstyle-Font-Name="Tahoma" Headerstyle-Font-Size="12" Headerstyle-Font-Bold="True" Font-Name="Tahoma" AutogenerateColumns="False"
					OnEditcommand="MyDataGrid_EditCommand" OnCancelcommand="MyDataGrid_Cancel" OnUpdateCommand="MyDataGrid_UpdateCommand" OnDeleteCommand="MyDataGrid_DeleteCommand" Font-Names="Tahoma" BorderStyle="None" BorderWidth="1px">
					<SelectedItemStyle Font-Bold="True" ForeColor="White" BackColor="#CE5D5A"></SelectedItemStyle>
					<AlternatingItemStyle BackColor="White"></AlternatingItemStyle>
					<ItemStyle Font-Size="Smaller" BackColor="#F7F7DE"></ItemStyle>
					<HeaderStyle Font-Size="10pt" Font-Bold="True" ForeColor="White" BackColor="#6B696B"></HeaderStyle>
					<FooterStyle BackColor="#CCCC99"></FooterStyle>
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
							<HeaderStyle Width="3in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Rel_Type" HeaderText="Relation Type">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Rel_Age" HeaderText="Age ">
							<HeaderStyle Width="0.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Ent_Date" HeaderText="Ent Date">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Dea_Flag" HeaderText="Death">
							<HeaderStyle Width="0.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Rel_Idno" HeaderText="Nic No">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Right" ForeColor="Black" BackColor="#F7F7DE" Mode="NumericPages"></PagerStyle>
				</asp:datagrid></DIV>
			<asp:panel id="Panel5" style="Z-INDEX: 139; LEFT: 848px; POSITION: absolute; TOP: 64px" runat="server"
				Width="82px" Height="528px" BackImageUrl="Menu/EmpMaster4.jpg" BackColor="Desktop"></asp:panel><asp:label id="Label15" style="Z-INDEX: 140; LEFT: 416px; POSITION: absolute; TOP: 256px" runat="server"
				Width="112px" Height="16px">Last Inactive Date</asp:label><asp:label id="Label16" style="Z-INDEX: 141; LEFT: 552px; POSITION: absolute; TOP: 256px" runat="server"
				Font-Size="X-Small" Width="112px" Height="16px" ForeColor="Red"></asp:label></form>
	</body>
</HTML>
