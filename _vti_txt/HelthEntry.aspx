<%@ Page Language="vb" AutoEventWireup="false" Codebehind="HelthEntry.aspx.vb" Inherits="Insu.HelthEntry" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Outword</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="#f0f8ff" leftMargin="0" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:textbox id="TxtInTot" style="Z-INDEX: 119; LEFT: 584px; POSITION: absolute; TOP: 456px"
				runat="server" ReadOnly="True" Width="108px"></asp:textbox><asp:label id="Label5" style="Z-INDEX: 115; LEFT: 376px; POSITION: absolute; TOP: 168px" runat="server"
				Width="56px" Height="16px">Amount</asp:label><asp:label id="Label4" style="Z-INDEX: 114; LEFT: 544px; POSITION: absolute; TOP: 168px" runat="server"
				Width="32px" Height="16px">Date </asp:label><asp:label id="Label3" style="Z-INDEX: 113; LEFT: 120px; POSITION: absolute; TOP: 168px" runat="server"
				Width="96px" Height="16px">Treatment Type</asp:label><asp:label id="Label1" style="Z-INDEX: 112; LEFT: 120px; POSITION: absolute; TOP: 136px" runat="server"
				Width="96px" Height="16px"> Description</asp:label><asp:panel id="Panel6" style="Z-INDEX: 111; LEFT: 777px; POSITION: absolute; TOP: 64px" runat="server"
				Width="84px" Height="472px" BackColor="Desktop" BackImageUrl="Menu/bann1.jpg"></asp:panel><asp:panel id="Panel1" style="Z-INDEX: 102; LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server"
				Width="864px" Height="64px" BackColor="Desktop" BackImageUrl="Menu/banner.jpg" Font-Bold="True" HorizontalAlign="Left" Enabled="False" ForeColor="White" BorderColor="Transparent"><FONT style="BACKGROUND-COLOR: #000066">
					<asp:panel id="Panel3" style="Z-INDEX: 101; LEFT: 0px; POSITION: absolute; TOP: 64px" runat="server"
						Width="112px" Height="152px" BackImageUrl="Menu/bann2.jpg" BackColor="Desktop"></asp:panel>
					<asp:label id="Label7" style="Z-INDEX: 105; LEFT: 416px; POSITION: absolute; TOP: 456px" runat="server"
						Width="162px" Height="16px" BackColor="Navy" ForeColor="White">Total  -Indoor</asp:label>
					<asp:label id="Label6" style="Z-INDEX: 104; LEFT: 416px; POSITION: absolute; TOP: 488px" runat="server"
						Width="161px" Height="16px" BackColor="Navy" ForeColor="White">Total   -Outdoor</asp:label>
					<asp:TextBox id="TxtNam" style="Z-INDEX: 102; LEFT: 328px; POSITION: absolute; TOP: 104px" runat="server"
						Width="360px"></asp:TextBox>Death
					<DIV id="Layer1" style="Z-INDEX: 128; LEFT: 120px; OVERFLOW: scroll; WIDTH: 640px; POSITION: absolute; TOP: 232px; HEIGHT: 224px">
						<asp:datagrid id="MyDataGrid" runat="server" Width="616px" Height="12px" BackColor="White" BorderColor="#E7E7FF"
							GridLines="Horizontal" BorderWidth="1px" BorderStyle="None" Font-Names="Tahoma" DataKeyField="id"
							OnDeleteCommand="MyDataGrid_DeleteCommand" OnUpdateCommand="MyDataGrid_UpdateCommand" OnCancelcommand="MyDataGrid_Cancel"
							OnEditcommand="MyDataGrid_EditCommand" AutogenerateColumns="False" Font-Size="12pt" Font-Name="Tahoma"
							Headerstyle-Font-Bold="True" Headerstyle-Font-Size="12" Headerstyle-Font-Name="Tahoma" Headerstyle-BackColor="#8080C0"
							cellpadding="3">
							<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
							<SelectedItemStyle Font-Size="Smaller" Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
							<EditItemStyle Font-Size="Smaller"></EditItemStyle>
							<AlternatingItemStyle Font-Size="Smaller"></AlternatingItemStyle>
							<ItemStyle Font-Size="Smaller" ForeColor="#000066"></ItemStyle>
							<HeaderStyle Font-Size="12pt" Font-Names="Arial" Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
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
									<HeaderStyle Width="4in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="Emp_Cno" HeaderText="Claim No">
									<HeaderStyle Width="4in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="Emp_Typ" HeaderText="Treatment Type">
									<HeaderStyle Width="1.5in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="Emp_Amt" ReadOnly="True" HeaderText="Payment">
									<HeaderStyle Width="1.5in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Right"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="Emp_DecAmt" ReadOnly="True" HeaderText="Submit Amt">
									<HeaderStyle Width="1.5in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Right"></ItemStyle>
								</asp:BoundColumn>
								<asp:BoundColumn DataField="Emp_PayDt" HeaderText="Apply Date">
									<HeaderStyle Width="1.5in"></HeaderStyle>
									<ItemStyle HorizontalAlign="Left"></ItemStyle>
								</asp:BoundColumn>
							</Columns>
							<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
						</asp:datagrid></DIV>
					Donation Data Entry</FONT></asp:panel>
			<asp:panel id="Panel2" style="Z-INDEX: 103; LEFT: 0px; POSITION: absolute; TOP: 211px" runat="server"
				Width="112px" Height="321px" BackColor="Desktop" BackImageUrl="Menu\bann1.jpg"></asp:panel><asp:button id="BtnEdit" style="Z-INDEX: 104; LEFT: 168px; POSITION: absolute; TOP: 456px" tabIndex="8"
				runat="server" Width="16px" Font-Bold="True" Visible="False" Text="Edit"></asp:button><asp:button id="BtnSave" style="Z-INDEX: 120; LEFT: 112px; POSITION: absolute; TOP: 488px" tabIndex="11"
				runat="server" Width="64px" Font-Bold="True" Visible="False" Text="Save"></asp:button><asp:dropdownlist id="Lstcom" style="Z-INDEX: 107; LEFT: 256px; POSITION: absolute; TOP: 72px" tabIndex="1"
				runat="server" Width="440px" Height="24px" AutoPostBack="True"></asp:dropdownlist><asp:label id="Invoice" style="Z-INDEX: 108; LEFT: 120px; POSITION: absolute; TOP: 112px" runat="server"
				Width="104px" Height="24px">Emp No</asp:label><asp:label id="Label2" style="Z-INDEX: 109; LEFT: 120px; POSITION: absolute; TOP: 72px" runat="server"
				Width="96px" Height="16px">Company</asp:label><asp:button id="BtnCle" style="Z-INDEX: 105; LEFT: 176px; POSITION: absolute; TOP: 488px" tabIndex="9"
				runat="server" Width="16px" Height="24px" Font-Bold="True" Visible="False" Text="Clear"></asp:button><asp:button id="BtnAdd" style="Z-INDEX: 101; LEFT: 104px; POSITION: absolute; TOP: 456px" tabIndex="7"
				runat="server" Width="56px" Font-Bold="True" Visible="False" Text="Add"></asp:button><asp:textbox id="TxtEmpNo" style="Z-INDEX: 110; LEFT: 256px; POSITION: absolute; TOP: 104px"
				runat="server" Width="66px" Height="24px" AutoPostBack="True" DESIGNTIMEDRAGDROP="22"></asp:textbox><asp:button id="BtnDel" style="Z-INDEX: 106; LEFT: 120px; POSITION: absolute; TOP: 472px" tabIndex="11"
				runat="server" Width="64px" Font-Bold="True" Visible="False" Text="Delete"></asp:button><asp:button id="BttIns" style="Z-INDEX: 116; LEFT: 632px; POSITION: absolute; TOP: 208px" runat="server"
				Width="57px" Text="Insert"></asp:button><asp:textbox id="TxtPay" style="Z-INDEX: 117; LEFT: 440px; POSITION: absolute; TOP: 168px" runat="server"
				Width="88px"></asp:textbox><asp:textbox id="Txtappdt" style="Z-INDEX: 118; LEFT: 584px; POSITION: absolute; TOP: 168px"
				runat="server" Width="80px"></asp:textbox><asp:dropdownlist id="Lsttyp" style="Z-INDEX: 121; LEFT: 256px; POSITION: absolute; TOP: 168px" runat="server"
				Width="112px" Height="32px"></asp:dropdownlist><asp:textbox id="TxtDes" style="Z-INDEX: 122; LEFT: 256px; POSITION: absolute; TOP: 136px" runat="server"
				Width="436px"></asp:textbox><asp:textbox id="TxtOutTot" style="Z-INDEX: 123; LEFT: 584px; POSITION: absolute; TOP: 480px"
				runat="server" ReadOnly="True" Width="108px"></asp:textbox><asp:image id="Image1" style="Z-INDEX: 124; LEFT: 0px; POSITION: absolute; TOP: 512px" runat="server"
				Width="863px" Height="64px" ImageUrl="Menu/EmpMaster1.jpg"></asp:image><asp:label id="ChqNo" style="Z-INDEX: 125; LEFT: 120px; POSITION: absolute; TOP: 208px" runat="server"
				Width="96px" Height="24px">Cheque No</asp:label><asp:textbox id="TxtChqNo" style="Z-INDEX: 126; LEFT: 256px; POSITION: absolute; TOP: 200px"
				runat="server" Width="72px" Height="26px"></asp:textbox><asp:textbox id="TxtCNo" style="Z-INDEX: 127; LEFT: 408px; POSITION: absolute; TOP: 200px" runat="server"
				Width="80px"></asp:textbox><asp:label id="Label8" style="Z-INDEX: 128; LEFT: 336px; POSITION: absolute; TOP: 208px" runat="server"
				Width="64px" Height="16px">Claim No</asp:label><asp:label id="Label9" style="Z-INDEX: 129; LEFT: 128px; POSITION: absolute; TOP: 456px" runat="server"
				Width="144px" Height="24px"> Balance OutDoor</asp:label><asp:textbox id="TxtBal1" style="Z-INDEX: 130; LEFT: 288px; POSITION: absolute; TOP: 456px" runat="server"
				Width="80px"></asp:textbox><asp:label id="Label10" style="Z-INDEX: 131; LEFT: 496px; POSITION: absolute; TOP: 208px" runat="server"
				Width="48px" Height="11px">Acc Yr</asp:label><asp:textbox id="TxtYr" style="Z-INDEX: 132; LEFT: 552px; POSITION: absolute; TOP: 200px" runat="server"
				Width="48px" Height="24px"></asp:textbox><asp:label id="L1" style="Z-INDEX: 133; LEFT: 120px; POSITION: absolute; TOP: 488px" runat="server"
				Width="96px" Height="16px">Label</asp:label><asp:textbox id="TxtTEmpNo" style="Z-INDEX: 134; LEFT: 704px; POSITION: absolute; TOP: 168px"
				runat="server" Width="56px" Visible="False"></asp:textbox><asp:textbox id="TxtOldEmpNo" style="Z-INDEX: 135; LEFT: 704px; POSITION: absolute; TOP: 200px"
				runat="server" Width="64px" Visible="False"></asp:textbox></form>
	</body>
</HTML>
