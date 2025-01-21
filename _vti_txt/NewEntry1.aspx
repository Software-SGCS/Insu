<%@ Page Language="vb" AutoEventWireup="false" Codebehind="NewEntry1.aspx.vb" Inherits="Insu.NewEntry1" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>NewEntry1</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="VBScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="#f0f8ff" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:dropdownlist id="LstCat" style="Z-INDEX: 100; LEFT: 256px; POSITION: absolute; TOP: 72px" runat="server"
				Width="416px" Height="24px" AutoPostBack="True"></asp:dropdownlist>
			<asp:TextBox id="TxtOldEmpNo4" style="Z-INDEX: 147; LEFT: 816px; POSITION: absolute; TOP: 288px"
				runat="server" Width="64px" Visible="False"></asp:TextBox>
			<asp:TextBox id="TxtOldEmpNo3" style="Z-INDEX: 146; LEFT: 816px; POSITION: absolute; TOP: 264px"
				runat="server" Width="64px" Visible="False"></asp:TextBox>
			<asp:TextBox id="TxtOldEmpNo2" style="Z-INDEX: 145; LEFT: 816px; POSITION: absolute; TOP: 240px"
				runat="server" Width="64px" Visible="False"></asp:TextBox><asp:label id="Label18" style="Z-INDEX: 139; LEFT: 488px; POSITION: absolute; TOP: 104px" runat="server"
				Width="88px" Height="24px">Cheque Amt</asp:label><asp:textbox id="TxtOldEmpNo" style="Z-INDEX: 126; LEFT: 792px; POSITION: absolute; TOP: 72px"
				runat="server" Width="56px" Visible="False"></asp:textbox><asp:textbox id="TxtTEmpNo" style="Z-INDEX: 125; LEFT: 696px; POSITION: absolute; TOP: 72px"
				runat="server" Width="80px" Visible="False"></asp:textbox><asp:label id="Label11" style="Z-INDEX: 124; LEFT: 680px; POSITION: absolute; TOP: 104px" runat="server"
				Width="62px" Height="24px">Acc Year</asp:label><asp:textbox id="TxtYr1" style="Z-INDEX: 123; LEFT: 752px; POSITION: absolute; TOP: 104px" runat="server"
				Width="56px" AutoPostBack="True"></asp:textbox><asp:textbox id="Txtappdt" style="Z-INDEX: 122; LEFT: 648px; POSITION: absolute; TOP: 168px"
				runat="server" Width="88px" ReadOnly="True" Enabled="False"></asp:textbox><asp:textbox id="TxtPay" style="Z-INDEX: 121; LEFT: 472px; POSITION: absolute; TOP: 168px" runat="server"
				Width="88px" ReadOnly="True" Enabled="False"></asp:textbox><asp:label id="Label9" style="Z-INDEX: 120; LEFT: 136px; POSITION: absolute; TOP: 168px" runat="server"
				Width="104px" Height="24px">Treatment Type</asp:label><asp:textbox id="TxtEmpNo" style="Z-INDEX: 116; LEFT: 256px; POSITION: absolute; TOP: 136px"
				runat="server" Width="72px" AutoPostBack="True"></asp:textbox>
			<DIV id="Div1" style="Z-INDEX: 115; LEFT: 128px; OVERFLOW: scroll; WIDTH: 680px; POSITION: absolute; TOP: 208px; HEIGHT: 176px"><asp:datagrid id="Datagrid2" runat="server" Width="656px" Height="12px" BackColor="White" BorderColor="#E7E7FF"
					BorderWidth="1px" BorderStyle="None" GridLines="Horizontal" Font-Size="12pt" Font-Names="Tahoma" DataKeyField="id" OnDeleteCommand="DataGrid2_DeleteCommand" OnUpdateCommand="DataGrid2_UpdateCommand" OnCancelcommand="DataGrid2_Cancel"
					OnEditcommand="DataGrid2_EditCommand" AutogenerateColumns="False" Font-Name="Tahoma" Headerstyle-Font-Bold="True" Headerstyle-Font-Size="12" Headerstyle-Font-Name="Tahoma" Headerstyle-BackColor="#8080C0" cellpadding="3">
					<SelectedItemStyle Font-Size="Smaller" Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
					<EditItemStyle Font-Size="Smaller"></EditItemStyle>
					<AlternatingItemStyle Font-Size="Smaller"></AlternatingItemStyle>
					<ItemStyle Font-Size="Smaller" ForeColor="#000066"></ItemStyle>
					<HeaderStyle Font-Size="12pt" Font-Names="Arial" Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
					<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
					<Columns>
						<asp:TemplateColumn>
							<ItemTemplate>
								<asp:LinkButton id="lbtnEdit" runat="server" Text="<img border=0 src=images\dtg_edit.gif alt=edit>"
									CommandName="Edit"></asp:LinkButton>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:LinkButton id="lbtnUpdate" runat="server" Text="<img  border=0 src=images\dtg_update.gif alt=save/update>"
									CommandName="Update"></asp:LinkButton>
								<asp:LinkButton id="lbtnCancel" runat="server" Text="<img border=0 src=images\dtg_cancel.gif alt=cancel>"
									CommandName="Cancel"></asp:LinkButton>
							</EditItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn>
							<ItemTemplate>
								<asp:LinkButton id="lblDelete" runat="server" Text="<img border=0 src=images\delete.jpg alt=delete>"
									CommandName="Delete"></asp:LinkButton>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:BoundColumn DataField="Emp_Chqno" HeaderText="Cheque No">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Emp_Cno" HeaderText="Claim No">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Emp_Typ" HeaderText="Treatment Type">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Emp_DecAmt" ReadOnly="True" HeaderText="Submit Amt">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Emp_PayDt" ReadOnly="True" HeaderText="Submit Date">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Emp_Amt" ReadOnly="True" HeaderText="Rec Claims">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Emp_RecDt" HeaderText="Recieved Date">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
				</asp:datagrid></DIV>
			<asp:panel id="Panel11" style="Z-INDEX: 109; LEFT: 8px; POSITION: absolute; TOP: 562px" runat="server"
				Width="1056px" Height="57px" BackColor="Navy"></asp:panel><asp:panel id="Panel10" style="Z-INDEX: 108; LEFT: 920px; POSITION: absolute; TOP: 64px" runat="server"
				Width="144px" Height="536px" BackColor="Navy"></asp:panel><asp:panel id="Panel9" style="Z-INDEX: 107; LEFT: 8px; POSITION: absolute; TOP: 0px" runat="server"
				Width="1056px" Height="16px" BackColor="Navy"></asp:panel><asp:panel id="Panel5" style="Z-INDEX: 104; LEFT: 8px; POSITION: absolute; TOP: 16px" runat="server"
				Width="96px" Height="589px" BackColor="Navy"></asp:panel><asp:label id="Company" style="Z-INDEX: 101; LEFT: 136px; POSITION: absolute; TOP: 72px" runat="server"
				Width="104px" Height="24px">Company</asp:label>
			<div id="Layer1" style="Z-INDEX: 102; LEFT: 120px; OVERFLOW: scroll; WIDTH: 678px; POSITION: relative; TOP: 392px; HEIGHT: 115px"><asp:datagrid id="DataGrid1" runat="server" Width="656px" Height="12px" BackColor="White" BorderColor="#E7E7FF"
					BorderWidth="1px" BorderStyle="None" GridLines="Horizontal" Font-Size="Small" AutoGenerateColumns="False" CellPadding="3" ShowFooter="True">
					<SelectedItemStyle Font-Bold="True" ForeColor="#F7F7F7" BackColor="#738A9C"></SelectedItemStyle>
					<AlternatingItemStyle BackColor="#F7F7F7"></AlternatingItemStyle>
					<ItemStyle ForeColor="#4A3C8C" BackColor="#E7E7FF"></ItemStyle>
					<HeaderStyle Font-Size="X-Small" Font-Names="Tahoma" Font-Bold="True" Wrap="False" ForeColor="#F7F7F7"
						BackColor="#4A3C8C"></HeaderStyle>
					<Columns>
						<asp:BoundColumn Visible="False" DataField="Raw_ItmCode" HeaderText="Material Code">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma" HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="Raw_Des" HeaderText="Description">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="Itm_Pri" HeaderText="Sales Price">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="Raw_OpStk" HeaderText="Operning Stock">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="Raw_Soh" HeaderText="Stock On Hand">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="Raw_PhStock" HeaderText="Physical Stock">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn Visible="False" DataField="Raw_Rec" HeaderText="Stock On Hand">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:TemplateColumn HeaderText="Submit Date">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Raw_ItmCode" runat="server" Height="16px" Width="50px">Label</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Employee ID">
							<HeaderStyle Width="0.5in"></HeaderStyle>
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma" HorizontalAlign="Right"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Raw_des" runat="server" Height="16px" Width="50px">Label</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Name">
							<HeaderStyle Width="2in"></HeaderStyle>
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Itm_Pri" runat="server" Width="250px">Label</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:BoundColumn DataField="Raw_Rtn" HeaderText="Remarks">
							<HeaderStyle Width="2in"></HeaderStyle>
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
						</asp:BoundColumn>
						<asp:TemplateColumn HeaderText="Submit Amount">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma" HorizontalAlign="Right"></ItemStyle>
							<ItemTemplate>
								<asp:Label id="Raw_OpStk" runat="server" Width="50px">Label</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn Visible="False" HeaderText="Cheque No">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:TextBox id="Raw_Soh" runat="server" Width="66px" BackColor="White"></asp:TextBox>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn Visible="False" HeaderText="Claims No">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma"></ItemStyle>
							<ItemTemplate>
								<asp:TextBox id="Raw_PhStock" runat="server" Width="66px" BackColor="White"></asp:TextBox>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="Claims Amount">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma" HorizontalAlign="Right"></ItemStyle>
							<ItemTemplate>
								<asp:TextBox id="Raw_Rec" runat="server" Width="74px" BackColor="White"></asp:TextBox>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn HeaderText="New Remarks">
							<ItemStyle Font-Size="X-Small" Font-Names="Tahoma" HorizontalAlign="Right"></ItemStyle>
							<ItemTemplate>
								<asp:TextBox id="Raw_Rtn" runat="server" Width="150px" BackColor="White"></asp:TextBox>
							</ItemTemplate>
						</asp:TemplateColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Right" ForeColor="#4A3C8C" BackColor="#E7E7FF" Mode="NumericPages"></PagerStyle>
				</asp:datagrid></div>
			<asp:textbox id="TxtChqAmt" style="Z-INDEX: 140; LEFT: 584px; POSITION: absolute; TOP: 104px"
				runat="server" Width="86px" AutoPostBack="True"></asp:textbox><asp:panel id="Panel6" style="Z-INDEX: 105; LEFT: 112px; POSITION: absolute; TOP: 16px" runat="server"
				Width="952px" Height="24px">&nbsp;<FONT face="Tahoma" size="5"><STRONG>Entry&nbsp;Claims 
						Recieved</STRONG></FONT></asp:panel>
			<asp:panel id="Panel8" style="Z-INDEX: 106; LEFT: 8px; POSITION: absolute; TOP: 48px" runat="server"
				Width="1056px" Height="16px" BackColor="Navy"></asp:panel><asp:textbox id="TxtCno" style="Z-INDEX: 110; LEFT: 416px; POSITION: absolute; TOP: 104px" runat="server"
				Width="64px"></asp:textbox><asp:textbox id="TxtChqNo" style="Z-INDEX: 112; LEFT: 256px; POSITION: absolute; TOP: 104px"
				runat="server" Width="72px" AutoPostBack="True"></asp:textbox><asp:label id="Label5" style="Z-INDEX: 111; LEFT: 136px; POSITION: absolute; TOP: 104px" runat="server"
				Width="88px" Height="24px">Cheque No</asp:label><asp:label id="Label6" style="Z-INDEX: 113; LEFT: 336px; POSITION: absolute; TOP: 104px" runat="server"
				Width="72px" Height="24px">Claim No</asp:label><asp:label id="Label8" style="Z-INDEX: 117; LEFT: 136px; POSITION: absolute; TOP: 136px" runat="server"
				Width="88px" Height="24px">EmpNo</asp:label><asp:textbox id="TxtNam" style="Z-INDEX: 118; LEFT: 344px; POSITION: absolute; TOP: 136px" runat="server"
				Width="280px" Height="24px"></asp:textbox><asp:dropdownlist id="Lsttyp" style="Z-INDEX: 119; LEFT: 256px; POSITION: absolute; TOP: 168px" runat="server"
				Width="128px" Height="24px" Enabled="False"></asp:dropdownlist><asp:button id="ButSub" style="Z-INDEX: 103; LEFT: 128px; POSITION: absolute; TOP: 528px" runat="server"
				Width="80px" Text="Update"></asp:button><asp:button id="Button2" style="Z-INDEX: 127; LEFT: 768px; POSITION: absolute; TOP: 168px" runat="server"
				Width="56px" Height="24px" Visible="False" Enabled="False" Text="Insert"></asp:button><asp:label id="Label10" style="Z-INDEX: 128; LEFT: 400px; POSITION: absolute; TOP: 168px" runat="server"
				Width="64px" Height="24px">Value</asp:label><asp:label id="Label12" style="Z-INDEX: 129; LEFT: 576px; POSITION: absolute; TOP: 168px" runat="server"
				Width="64px" Height="24px">Date</asp:label><asp:label id="Label13" style="Z-INDEX: 130; LEFT: 648px; POSITION: absolute; TOP: 192px" runat="server"
				Width="48px" Height="16px" Font-Size="XX-Small">DD/MM/YYYY</asp:label><asp:textbox id="TxtBal1" style="Z-INDEX: 131; LEFT: 256px; POSITION: absolute; TOP: 384px" runat="server"
				Width="72px" Height="24px"></asp:textbox><asp:textbox id="TxtOutTot" style="Z-INDEX: 132; LEFT: 440px; POSITION: absolute; TOP: 384px"
				runat="server" Width="80px"></asp:textbox><asp:textbox id="TxtInTot" style="Z-INDEX: 133; LEFT: 648px; POSITION: absolute; TOP: 384px"
				runat="server" Width="72px"></asp:textbox><asp:label id="Label14" style="Z-INDEX: 134; LEFT: 136px; POSITION: absolute; TOP: 384px" runat="server"
				Width="112px" Height="8px">OutDoor Balance</asp:label><asp:label id="Label15" style="Z-INDEX: 135; LEFT: 328px; POSITION: absolute; TOP: 384px" runat="server"
				Width="104px" Height="16px">OutDoor Total</asp:label><asp:label id="Label16" style="Z-INDEX: 136; LEFT: 528px; POSITION: absolute; TOP: 384px" runat="server"
				Width="112px" Height="16px">Indoor Total</asp:label><asp:label id="Label17" style="Z-INDEX: 138; LEFT: 584px; POSITION: absolute; TOP: 528px" runat="server"
				Width="104px" Height="24px">Pending Total</asp:label><asp:textbox id="TxtPeTot" style="Z-INDEX: 137; LEFT: 696px; POSITION: absolute; TOP: 528px"
				runat="server" Width="88px"></asp:textbox><asp:label id="L1" style="Z-INDEX: 114; LEFT: 304px; POSITION: absolute; TOP: 528px" runat="server"
				Height="24px" Width="104px"></asp:label>
			<asp:Label id="Label19" style="Z-INDEX: 141; LEFT: 640px; POSITION: absolute; TOP: 136px" runat="server"
				Height="24px" Width="88px">Chq Bal Amt</asp:Label>
			<asp:TextBox id="Txtbal" style="Z-INDEX: 142; LEFT: 744px; POSITION: absolute; TOP: 136px" runat="server"
				Height="24px" Width="96px" ReadOnly="True" ForeColor="Red" Font-Bold="True" Font-Size="Larger"></asp:TextBox>
			<asp:TextBox id="TxtOldEmpNo1" style="Z-INDEX: 143; LEFT: 816px; POSITION: absolute; TOP: 216px"
				runat="server" Width="64px" Visible="False"></asp:TextBox></form>
	</body>
</HTML>
