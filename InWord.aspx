<%@ Page Language="vb" AutoEventWireup="false" Codebehind="InWord.aspx.vb" Inherits="Insu.Inword"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>InWord</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout" leftmargin="0">
		<DIV style="Z-INDEX: 101; LEFT: 8px; WIDTH: 10px; POSITION: absolute; TOP: 8px; HEIGHT: 10px"
			ms_positioning="text2D">
			<FORM id="Form1" method="post" runat="server">
				<DIV id="Layer1" style="Z-INDEX: 128; LEFT: 120px; OVERFLOW: scroll; WIDTH: 600px; POSITION: absolute; TOP: 232px; HEIGHT: 176px"><asp:datagrid id="MyDataGrid" runat="server" cellpadding="3" Headerstyle-BackColor="#8080C0" Headerstyle-Font-Name="Tahoma"
						Headerstyle-Font-Size="12" Headerstyle-Font-Bold="True" BackColor="White" Font-Name="Tahoma" Font-Size="Small" BorderColor="#CCCCCC" AutogenerateColumns="False" OnEditcommand="MyDataGrid_EditCommand" OnCancelcommand="MyDataGrid_Cancel"
						OnUpdateCommand="MyDataGrid_UpdateCommand" Width="534px" OnDeleteCommand="MyDataGrid_DeleteCommand" DataKeyField="id" Font-Names="Calibri" BorderStyle="None" BorderWidth="1px">
						<SelectedItemStyle Font-Size="Smaller" Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
						<EditItemStyle Font-Size="Smaller"></EditItemStyle>
						<AlternatingItemStyle Font-Size="Smaller"></AlternatingItemStyle>
						<ItemStyle Font-Size="Smaller" ForeColor="#000066"></ItemStyle>
						<HeaderStyle Font-Size="12pt" Font-Names="Arial" Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
						<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
						<Columns>
							<asp:TemplateColumn>
								<ItemTemplate>
									<asp:LinkButton id="lbtnEdit" runat="server" Text="<img border=0 src=http://sgcsser\Insu\images\dtg_edit.gif alt=edit>"
										CommandName="Edit"></asp:LinkButton>
								</ItemTemplate>
								<EditItemTemplate>
									<asp:LinkButton id="lbtnUpdate" runat="server" Text="<img  border=0 src=http://sgcsser\Insu\images\dtg_update.gif alt=save/update>"
										CommandName="Update"></asp:LinkButton>
									<asp:LinkButton id="lbtnCancel" runat="server" Text="<img border=0 src=http://sgcsser\Insu\images\dtg_cancel.gif alt=cancel>"
										CommandName="Cancel"></asp:LinkButton>
								</EditItemTemplate>
							</asp:TemplateColumn>
							<asp:TemplateColumn>
								<ItemTemplate>
									<asp:LinkButton id="lblDelete" runat="server" Text="<img border=0 src=http://sgcsser\Insu\images\delete.jpg alt=delete>"
										CommandName="Delete"></asp:LinkButton>
								</ItemTemplate>
							</asp:TemplateColumn>
							<asp:BoundColumn DataField="Inv_itmNo" ReadOnly="True" HeaderText="Item No">
								<HeaderStyle Width="1in"></HeaderStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="Inv_des" ReadOnly="True" HeaderText="Description              ">
								<HeaderStyle Width="4in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Left"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="Invpr" ReadOnly="True" HeaderText="Rates">
								<HeaderStyle Width="1in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Right"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="InvQty" HeaderText="Qty">
								<HeaderStyle Width="0.75in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Right"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="Invval" ReadOnly="True" HeaderText="Amount">
								<HeaderStyle Width="1in"></HeaderStyle>
								<ItemStyle Font-Bold="True" HorizontalAlign="Right" ForeColor="Black" VerticalAlign="Middle"></ItemStyle>
							</asp:BoundColumn>
						</Columns>
						<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
					</asp:datagrid></DIV>
				<asp:button id="Button1" style="Z-INDEX: 133; LEFT: 464px; POSITION: absolute; TOP: 416px" tabIndex="9"
					runat="server" Width="72px" Height="24px" Text="Invoice" Font-Bold="True"></asp:button><asp:button id="BtnSubmit" style="Z-INDEX: 130; LEFT: 696px; POSITION: absolute; TOP: 208px"
					tabIndex="7" runat="server" Width="64px" Text="Go" Font-Bold="True" Font-Names="Calibri" Font-Size="X-Small"></asp:button><asp:label id="Label8" style="Z-INDEX: 127; LEFT: 568px; POSITION: absolute; TOP: 208px" runat="server"
					Width="40px" Height="17px" EnableViewState="False" Font-Names="Calibri" Font-Size="X-Small">Qty</asp:label>
				<asp:label id="Label6" style="Z-INDEX: 122; LEFT: 760px; POSITION: absolute; TOP: 144px" runat="server"
					Font-Names="Calibri" Width="140px" Font-Size="X-Small" BackColor="Desktop" Font-Bold="True"
					Height="16px" ForeColor="White">Brand</asp:label><asp:label id="Label5" style="Z-INDEX: 121; LEFT: 600px; POSITION: absolute; TOP: 144px" runat="server"
					Width="142px" Height="16px" BackColor="Desktop" ForeColor="White" Font-Names="Calibri" Font-Size="X-Small" Font-Bold="True">Country</asp:label>
				<asp:panel id="Panel5" style="Z-INDEX: 101; LEFT: -8px; POSITION: absolute; TOP: 152px" runat="server"
					Width="104px" BackColor="Desktop" Height="288px" BackImageUrl="Menu/Audit.gif"></asp:panel><asp:panel id="Panel1" style="Z-INDEX: 103; LEFT: -8px; POSITION: absolute; TOP: -8px" runat="server"
					BackColor="Desktop" BorderColor="Transparent" Width="924px" Height="40px" Font-Bold="True" ForeColor="White" Enabled="False" HorizontalAlign="Left">
                INWORD</asp:panel>
				<asp:panel id="Panel2" style="Z-INDEX: 104; LEFT: -8px; POSITION: absolute; TOP: 32px" runat="server"
					BackColor="Desktop" Width="104px" Height="120px" BackImageUrl="Menu/Audit.gif"></asp:panel><asp:panel id="Panel3" style="Z-INDEX: 106; LEFT: -8px; POSITION: absolute; TOP: 144px" runat="server"
					BackColor="Desktop" Width="920px" Height="24px" Font-Bold="True" ForeColor="White" Font-Names="Calibri" Font-Size="X-Small">Payment Detail</asp:panel>
				<asp:button id="BtnEdit" style="Z-INDEX: 107; LEFT: 200px; POSITION: absolute; TOP: 416px" tabIndex="8"
					runat="server" Width="64px" Font-Bold="True" Text="Edit"></asp:button><asp:textbox id="TxtInvDt" style="Z-INDEX: 111; LEFT: 256px; POSITION: absolute; TOP: 112px"
					tabIndex="3" runat="server" Width="80px" Height="20px" Font-Names="Calibri" Font-Size="X-Small"></asp:textbox><asp:label id="Label1" style="Z-INDEX: 112; LEFT: 120px; POSITION: absolute; TOP: 112px" runat="server"
					Width="104px" Height="16px" Font-Names="Calibri" Font-Size="X-Small">Invoice Date</asp:label><asp:dropdownlist id="Lstcom" style="Z-INDEX: 113; LEFT: 256px; POSITION: absolute; TOP: 80px" tabIndex="2"
					runat="server" Width="346px" Height="16px" Font-Names="Calibri" Font-Size="X-Small"></asp:dropdownlist><asp:dropdownlist id="LstInvNo" style="Z-INDEX: 114; LEFT: 256px; POSITION: absolute; TOP: 48px" tabIndex="1"
					runat="server" Width="124px" Height="40px" AutoPostBack="True"></asp:dropdownlist><asp:label id="Invoice" style="Z-INDEX: 115; LEFT: 120px; POSITION: absolute; TOP: 48px" runat="server"
					Width="104px" Height="24px" Font-Names="Calibri" Font-Size="X-Small">Invoice No</asp:label><asp:label id="Label2" style="Z-INDEX: 116; LEFT: 120px; POSITION: absolute; TOP: 80px" runat="server"
					Width="96px" Height="24px" Font-Names="Calibri" Font-Size="X-Small">Company</asp:label><asp:textbox id="TxtPoNo" style="Z-INDEX: 117; LEFT: 560px; POSITION: absolute; TOP: 112px" tabIndex="4"
					runat="server" Width="136px" Height="20px" Font-Names="Calibri" Font-Size="X-Small"></asp:textbox><asp:label id="Label3" style="Z-INDEX: 118; LEFT: 416px; POSITION: absolute; TOP: 112px" runat="server"
					Width="128px" Height="24px" Font-Names="Calibri" Font-Size="X-Small">Purchase Order NO</asp:label><asp:dropdownlist id="LstTyp" style="Z-INDEX: 119; LEFT: 120px; POSITION: absolute; TOP: 176px" runat="server"
					Width="416px" Height="24px" AutoPostBack="True" Font-Names="Calibri" Font-Size="X-Small"></asp:dropdownlist><asp:label id="Label4" style="Z-INDEX: 120; LEFT: 120px; POSITION: absolute; TOP: 144px" runat="server"
					Width="108px" Height="16px" BackColor="Desktop" ForeColor="White" Font-Names="Calibri" Font-Size="X-Small" Font-Bold="True">Type</asp:label><asp:dropdownlist id="LstItmNo" style="Z-INDEX: 125; LEFT: 216px; POSITION: absolute; TOP: 208px"
					runat="server" Width="344px" Height="31px" AutoPostBack="True" Font-Names="Calibri" Font-Size="X-Small"></asp:dropdownlist><asp:label id="Label7" style="Z-INDEX: 126; LEFT: 120px; POSITION: absolute; TOP: 208px" runat="server"
					Width="72px" Height="17px" Font-Names="Calibri" Font-Size="X-Small">Item No</asp:label><asp:textbox id="TxtQty" style="Z-INDEX: 129; LEFT: 608px; POSITION: absolute; TOP: 208px" runat="server"
					Width="72px" Font-Names="Calibri" Font-Size="X-Small"></asp:textbox>
				<asp:button id="BtnCle" style="Z-INDEX: 109; LEFT: 280px; POSITION: absolute; TOP: 416px" tabIndex="9"
					runat="server" Width="72px" Height="24px" Text="Clear" Font-Bold="True"></asp:button><asp:textbox id="TxtInvNo" style="Z-INDEX: 131; LEFT: 256px; POSITION: absolute; TOP: 48px" runat="server"
					Width="112px" Height="20px" Font-Names="Calibri" Font-Size="X-Small"></asp:textbox><asp:button id="BtnDel" style="Z-INDEX: 110; LEFT: 376px; POSITION: absolute; TOP: 416px" tabIndex="11"
					runat="server" Width="64px" Text="Delete" Font-Bold="True"></asp:button><asp:button id="BtnSave" style="Z-INDEX: 132; LEFT: 560px; POSITION: absolute; TOP: 416px; Design_Time_Lock: True"
					tabIndex="11" runat="server" Width="64px" Text="Save" Font-Bold="True" Design_Time_Lock="True"></asp:button>
				<asp:Button id="BtnAdd" style="Z-INDEX: 102; LEFT: 120px; POSITION: absolute; TOP: 416px" runat="server"
					Width="72px" Text="Add" Font-Bold="True"></asp:Button>
			</FORM>
		</DIV>
		<asp:panel id="Panel6" style="Z-INDEX: 104; LEFT: -8px; POSITION: absolute; TOP: 448px" runat="server"
			Width="938px" BorderColor="Transparent" BackColor="Desktop" Font-Bold="True" Height="48px"
			HorizontalAlign="Left" Enabled="False" ForeColor="White"></asp:panel><asp:dropdownlist id="LstBrnd" style="Z-INDEX: 124; LEFT: 792px; POSITION: absolute; TOP: 184px" runat="server"
			Width="140px" Height="24px" Font-Names="Calibri" Font-Size="X-Small" Enabled="False" Visible="False"></asp:dropdownlist><asp:dropdownlist id="LstCntry" style="Z-INDEX: 125; LEFT: 608px; POSITION: absolute; TOP: 184px"
			runat="server" Width="144px" Height="24px" Font-Names="Calibri" Font-Size="X-Small" Enabled="False" Visible="False"></asp:dropdownlist>
	</body>
</HTML>
