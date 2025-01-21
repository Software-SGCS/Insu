<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Outword.aspx.vb" Inherits="Insu.Outword"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Outword</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body leftMargin="0" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<div id="Layer1" style="Z-INDEX: 125; LEFT: 120px; OVERFLOW: scroll; WIDTH: 544px; POSITION: absolute; TOP: 200px; HEIGHT: 111px"><asp:datagrid id="MyDataGrid" runat="server" Height="10px" PageSize="3" BorderWidth="1px" BorderStyle="None"
					Font-Names="Calibri" DataKeyField="id" OnDeleteCommand="MyDataGrid_DeleteCommand" Width="518px" OnUpdateCommand="MyDataGrid_UpdateCommand" OnCancelcommand="MyDataGrid_Cancel" OnEditcommand="MyDataGrid_EditCommand" AutogenerateColumns="False"
					BorderColor="#CC9966" Font-Size="12pt" Font-Name="Calibri" BackColor="White" Headerstyle-Font-Bold="True" Headerstyle-Font-Size="10" Headerstyle-Font-Name="Calibri" Headerstyle-BackColor="#8080C0" cellpadding="0">
					<SelectedItemStyle Font-Size="Smaller" Font-Bold="True" ForeColor="#663399" BackColor="#FFCC66"></SelectedItemStyle>
					<EditItemStyle Font-Size="Smaller"></EditItemStyle>
					<AlternatingItemStyle Font-Size="Smaller"></AlternatingItemStyle>
					<ItemStyle Font-Size="Smaller" ForeColor="#330099" BackColor="White"></ItemStyle>
					<HeaderStyle Font-Size="10pt" Font-Names="Calibri" Font-Bold="True" ForeColor="#FFFFCC" BackColor="#990000"></HeaderStyle>
					<FooterStyle ForeColor="#330099" BackColor="#FFFFCC"></FooterStyle>
					<Columns>
						<asp:TemplateColumn>
							<ItemTemplate>
								<asp:LinkButton id="lbtnEdit" runat="server" Text="<img border=0 src=http://sgcsser\Insu\images\dtg_edit.gif alt=edit>"
									CommandName="Edit">
									<img border="0" src="images\dtg_edit.gif" alt="edit"></asp:LinkButton>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:LinkButton id="lbtnUpdate" runat="server" Text="<img  border=0 src=http://sgcsser\Insu\images\dtg_update.gif alt=save/update>"
									CommandName="Update">
									<img border="0" src="images\dtg_update.gif" alt="save/update"></asp:LinkButton>
								<asp:LinkButton id="lbtnCancel" runat="server" Text="<img border=0 src=http://sgcsser\Insu\images\dtg_cancel.gif alt=cancel>"
									CommandName="Cancel">
									<img border="0" src="images\dtg_cancel.gif" alt="cancel"></asp:LinkButton>
							</EditItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn>
							<ItemTemplate>
								<asp:LinkButton id="lblDelete" runat="server" Text="<img border=0 src=http://sgcsser\Insu\images\delete.jpg alt=delete>"
									CommandName="Delete">
									<img border="0" src="images\delete.jpg" alt="delete"></asp:LinkButton>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:BoundColumn DataField="Inv_itmNo" ReadOnly="True" HeaderText="Item No">
							<HeaderStyle Width="0.75in"></HeaderStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Inv_des" ReadOnly="True" HeaderText="Description              ">
							<HeaderStyle Width="2in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Invpr" ReadOnly="True" HeaderText="Rates">
							<HeaderStyle Width="0.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="InvQty" HeaderText="Qty">
							<HeaderStyle Width="0.25in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Invval" ReadOnly="True" HeaderText="Amount">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle Font-Bold="True" HorizontalAlign="Right" ForeColor="Black" VerticalAlign="Middle"></ItemStyle>
						</asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Center" ForeColor="#330099" BackColor="#FFFFCC"></PagerStyle>
				</asp:datagrid></div>
			<DIV id="Div1" style="Z-INDEX: 126; LEFT: 120px; OVERFLOW: scroll; WIDTH: 544px; POSITION: absolute; TOP: 360px; HEIGHT: 120px"><asp:datagrid id="MyDatagrid1" runat="server" Height="12px" BorderWidth="1px" BorderStyle="None"
					Font-Names="Calibri" DataKeyField="id" OnDeleteCommand="MyDataGrid_DeleteCommand" Width="510px" OnUpdateCommand="MyDataGrid_UpdateCommand" OnCancelcommand="MyDataGrid_Cancel" OnEditcommand="MyDataGrid_EditCommand"
					AutogenerateColumns="False" BorderColor="#CC9966" Font-Size="12pt" Font-Name="Calibri" BackColor="White" Headerstyle-Font-Bold="True" Headerstyle-Font-Size="10" Headerstyle-Font-Name="Calibri" Headerstyle-BackColor="#8080C0"
					cellpadding="0">
					<SelectedItemStyle Font-Size="Smaller" Font-Bold="True" ForeColor="#663399" BackColor="#FFCC66"></SelectedItemStyle>
					<EditItemStyle Font-Size="Smaller"></EditItemStyle>
					<AlternatingItemStyle Font-Size="Smaller"></AlternatingItemStyle>
					<ItemStyle Font-Size="Smaller" ForeColor="#330099" BackColor="White"></ItemStyle>
					<HeaderStyle Font-Size="10pt" Font-Names="Calibri" Font-Bold="True" ForeColor="#FFFFCC" BackColor="#990000"></HeaderStyle>
					<FooterStyle ForeColor="#330099" BackColor="#FFFFCC"></FooterStyle>
					<Columns>
						<asp:BoundColumn DataField="Inv_itmNo" ReadOnly="True" HeaderText="Item No">
							<HeaderStyle Width="0.75in"></HeaderStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Inv_des" ReadOnly="True" HeaderText="Description">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="InvQty" HeaderText="Qty">
							<HeaderStyle Width="0.25in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="EntryNo" HeaderText="Entry No">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="EntDt" HeaderText="Entry Date">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Center" ForeColor="#330099" BackColor="#FFFFCC"></PagerStyle>
				</asp:datagrid></DIV>
			<DIV id="Div3" style="Z-INDEX: 151; LEFT: 120px; OVERFLOW: scroll; WIDTH: 544px; POSITION: absolute; TOP: 504px; HEIGHT: 120px"><asp:datagrid id="Datagrid2" runat="server" Height="12px" BorderWidth="1px" BorderStyle="None"
					Font-Names="Calibri" DataKeyField="id" OnDeleteCommand="MyDataGrid_DeleteCommand" Width="510px" OnUpdateCommand="MyDataGrid_UpdateCommand" OnCancelcommand="MyDataGrid_Cancel" OnEditcommand="MyDataGrid_EditCommand"
					AutogenerateColumns="False" BorderColor="#CC9966" Font-Size="12pt" Font-Name="Calibri" BackColor="White" Headerstyle-Font-Bold="True" Headerstyle-Font-Size="10" Headerstyle-Font-Name="Calibri" Headerstyle-BackColor="#8080C0"
					cellpadding="0">
					<SelectedItemStyle Font-Size="Smaller" Font-Bold="True" ForeColor="#663399" BackColor="#FFCC66"></SelectedItemStyle>
					<EditItemStyle Font-Size="Smaller"></EditItemStyle>
					<AlternatingItemStyle Font-Size="Smaller"></AlternatingItemStyle>
					<ItemStyle Font-Size="Smaller" ForeColor="#330099" BackColor="White"></ItemStyle>
					<HeaderStyle Font-Size="10pt" Font-Names="Calibri" Font-Bold="True" ForeColor="#FFFFCC" BackColor="#990000"></HeaderStyle>
					<FooterStyle ForeColor="#330099" BackColor="#FFFFCC"></FooterStyle>
					<Columns>
						<asp:BoundColumn DataField="Inv_itmNo" ReadOnly="True" HeaderText="Item No">
							<HeaderStyle Width="0.75in"></HeaderStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Inv_des" ReadOnly="True" HeaderText="Description">
							<HeaderStyle Width="1.5in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="InvQty" HeaderText="Qty">
							<HeaderStyle Width="0.25in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="EntryNo" HeaderText="Entry No">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="EntDt" HeaderText="Entry Date">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Center" ForeColor="#330099" BackColor="#FFFFCC"></PagerStyle>
				</asp:datagrid></DIV>
			<asp:label id="Label12" style="Z-INDEX: 137; LEFT: 896px; POSITION: absolute; TOP: 440px" runat="server"
				Height="24px" Width="56px" Visible="False">Percentage</asp:label><asp:dropdownlist id="LstFlag2" style="Z-INDEX: 135; LEFT: 824px; POSITION: absolute; TOP: 392px"
				tabIndex="2" runat="server" Height="16px" Width="56px" Visible="False" AutoPostBack="True"></asp:dropdownlist><asp:label id="Label11" style="Z-INDEX: 134; LEFT: 712px; POSITION: absolute; TOP: 424px" runat="server"
				Height="24px" Width="104px" Visible="False">Price Adjestment</asp:label><asp:dropdownlist id="LstVat" style="Z-INDEX: 133; LEFT: 840px; POSITION: absolute; TOP: 448px" tabIndex="2"
				runat="server" Height="16px" Width="56px" Visible="False" AutoPostBack="True"></asp:dropdownlist><asp:dropdownlist id="LstCode" style="Z-INDEX: 132; LEFT: 896px; POSITION: absolute; TOP: 400px" tabIndex="2"
				runat="server" Height="16px" Width="176px" Visible="False"></asp:dropdownlist><asp:label id="Label9" style="Z-INDEX: 131; LEFT: 712px; POSITION: absolute; TOP: 456px" runat="server"
				Height="24px" Width="64px" Visible="False">Create By</asp:label><asp:button id="BtnSubmit" style="Z-INDEX: 128; LEFT: 616px; POSITION: absolute; TOP: 176px"
				tabIndex="7" runat="server" Font-Names="Calibri" Width="40px" Font-Size="X-Small" Font-Bold="True" Text="Go"></asp:button><asp:label id="Label8" style="Z-INDEX: 124; LEFT: 512px; POSITION: absolute; TOP: 176px" runat="server"
				Height="17px" Font-Names="Calibri" Width="40px" Font-Size="X-Small" EnableViewState="False">Qty</asp:label><asp:label id="Label6" style="Z-INDEX: 119; LEFT: 536px; POSITION: absolute; TOP: 120px" runat="server"
				Height="16px" Font-Names="Calibri" Width="140px" Font-Size="X-Small" BackColor="Desktop" ForeColor="White">Brand</asp:label><asp:label id="Label5" style="Z-INDEX: 118; LEFT: 384px; POSITION: absolute; TOP: 120px" runat="server"
				Height="16px" Font-Names="Calibri" Width="142px" Font-Size="X-Small" BackColor="Desktop" ForeColor="White">Country</asp:label><asp:panel id="Panel5" style="Z-INDEX: 101; LEFT: 0px; POSITION: absolute; TOP: 152px" runat="server"
				Height="492px" Width="104px" BackColor="Desktop" BackImageUrl="Menu/Audit.gif"></asp:panel><asp:panel id="Panel1" style="Z-INDEX: 102; LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server"
				Height="32px" Width="879px" BorderColor="Transparent" BackColor="Desktop" Font-Bold="True" ForeColor="White" HorizontalAlign="Left" Enabled="False">INVOICE</asp:panel>
			<asp:panel id="Panel2" style="Z-INDEX: 103; LEFT: 0px; POSITION: absolute; TOP: 32px" runat="server"
				Height="120px" Width="104px" BackColor="Desktop" BackImageUrl="Menu/AssetI.gif"></asp:panel><asp:panel id="Panel3" style="Z-INDEX: 104; LEFT: 0px; POSITION: absolute; TOP: 112px" runat="server"
				Height="34px" Width="880px" BackColor="Desktop" Font-Bold="True" ForeColor="White">Payment 
Detail</asp:panel>
			<asp:button id="BtnEdit" style="Z-INDEX: 105; LEFT: 280px; POSITION: absolute; TOP: 312px" tabIndex="8"
				runat="server" Height="22px" Width="64px" Font-Bold="True" Text="View"></asp:button><asp:textbox id="TxtInvDt" style="Z-INDEX: 108; LEFT: 240px; POSITION: absolute; TOP: 88px" tabIndex="3"
				runat="server" Height="20px" Font-Names="Calibri" Width="88px" Font-Size="X-Small"></asp:textbox><asp:label id="Label1" style="Z-INDEX: 109; LEFT: 120px; POSITION: absolute; TOP: 88px" runat="server"
				Height="16px" Font-Names="Calibri" Width="104px" Font-Size="X-Small">Entry Date</asp:label><asp:dropdownlist id="Lstcom" style="Z-INDEX: 110; LEFT: 240px; POSITION: absolute; TOP: 64px" tabIndex="2"
				runat="server" Height="16px" Font-Names="Calibri" Width="376px" Font-Size="X-Small" AutoPostBack="True"></asp:dropdownlist><asp:dropdownlist id="LstInvNo" style="Z-INDEX: 111; LEFT: 240px; POSITION: absolute; TOP: 40px" tabIndex="1"
				runat="server" Height="40px" Font-Names="Calibri" Width="104px" Font-Size="X-Small" Visible="False" AutoPostBack="True"></asp:dropdownlist><asp:label id="Invoice" style="Z-INDEX: 112; LEFT: 120px; POSITION: absolute; TOP: 40px" runat="server"
				Height="16px" Font-Names="Calibri" Width="104px" Font-Size="X-Small">Entry No</asp:label><asp:label id="Label2" style="Z-INDEX: 113; LEFT: 120px; POSITION: absolute; TOP: 64px" runat="server"
				Height="24px" Font-Names="Calibri" Width="96px" Font-Size="X-Small">Employee</asp:label><asp:textbox id="TxtPoNo" style="Z-INDEX: 114; LEFT: 688px; POSITION: absolute; TOP: 360px" tabIndex="4"
				runat="server" Height="24px" Font-Names="Calibri" Width="136px" Font-Size="X-Small" Visible="False"></asp:textbox><asp:label id="Label3" style="Z-INDEX: 115; LEFT: 736px; POSITION: absolute; TOP: 88px" runat="server"
				Height="24px" Width="128px" Visible="False">Purchase Order NO</asp:label><asp:dropdownlist id="LstTyp" style="Z-INDEX: 116; LEFT: 120px; POSITION: absolute; TOP: 152px" runat="server"
				Height="24px" Font-Names="Calibri" Width="256px" Font-Size="X-Small" AutoPostBack="True"></asp:dropdownlist><asp:label id="Label4" style="Z-INDEX: 117; LEFT: 120px; POSITION: absolute; TOP: 120px" runat="server"
				Height="12px" Font-Names="Calibri" Width="108px" Font-Size="X-Small" BackColor="Desktop" ForeColor="White">Type</asp:label><asp:dropdownlist id="LstCntry" style="Z-INDEX: 120; LEFT: 384px; POSITION: absolute; TOP: 152px"
				runat="server" Height="24px" Font-Names="Calibri" Width="144px" Font-Size="X-Small" Visible="False" Enabled="False"></asp:dropdownlist><asp:dropdownlist id="LstBrnd" style="Z-INDEX: 121; LEFT: 536px; POSITION: absolute; TOP: 152px" runat="server"
				Height="24px" Font-Names="Calibri" Width="140px" Font-Size="X-Small" Visible="False" Enabled="False"></asp:dropdownlist><asp:dropdownlist id="LstItmNo" style="Z-INDEX: 122; LEFT: 216px; POSITION: absolute; TOP: 176px"
				runat="server" Height="31px" Font-Names="Calibri" Width="296px" Font-Size="X-Small" AutoPostBack="True"></asp:dropdownlist><asp:label id="Label7" style="Z-INDEX: 123; LEFT: 120px; POSITION: absolute; TOP: 176px" runat="server"
				Height="17px" Font-Names="Calibri" Width="72px" Font-Size="X-Small">Item No</asp:label><asp:textbox id="TxtQty" style="Z-INDEX: 127; LEFT: 560px; POSITION: absolute; TOP: 176px" runat="server"
				Font-Names="Calibri" Width="40px" Font-Size="X-Small"></asp:textbox><asp:button id="BtnCle" style="Z-INDEX: 106; LEFT: 200px; POSITION: absolute; TOP: 312px" tabIndex="9"
				runat="server" Height="22px" Width="64px" Font-Bold="True" Text="Clear"></asp:button><asp:textbox id="TxtInvNo" style="Z-INDEX: 129; LEFT: 240px; POSITION: absolute; TOP: 40px" runat="server"
				Height="18px" Font-Names="Calibri" Width="104px" Font-Size="X-Small"></asp:textbox><asp:button id="BtnDel" style="Z-INDEX: 107; LEFT: 360px; POSITION: absolute; TOP: 312px" tabIndex="11"
				runat="server" Height="22px" Width="64px" Font-Bold="True" Text="Delete"></asp:button><asp:textbox id="TxtPer" style="Z-INDEX: 136; LEFT: 736px; POSITION: absolute; TOP: 392px" runat="server"
				Width="52px" Visible="False"></asp:textbox><asp:imagebutton id="ImgBt" style="Z-INDEX: 140; LEFT: 328px; POSITION: absolute; TOP: 88px" runat="server"
				Height="20px" Width="32px" ImageUrl="menu\Cal1.jpg"></asp:imagebutton><asp:label id="Label13" style="Z-INDEX: 141; LEFT: 648px; POSITION: absolute; TOP: 40px" runat="server"
				Height="24px" Font-Names="Calibri" Width="88px" Font-Size="X-Small">Last Entry No</asp:label><asp:textbox id="TxtLInvNo" style="Z-INDEX: 142; LEFT: 816px; POSITION: absolute; TOP: 40px"
				runat="server" Font-Names="Calibri" Width="65px" Font-Size="X-Small" BackColor="#FFE0C0" ReadOnly="True"></asp:textbox><asp:panel id="Panel6" style="Z-INDEX: 143; LEFT: 0px; POSITION: absolute; TOP: 336px" runat="server"
				Height="16px" Width="880px" BackColor="Desktop" Font-Bold="True"></asp:panel><asp:label id="Label14" style="Z-INDEX: 144; LEFT: 704px; POSITION: absolute; TOP: 480px" runat="server"
				Height="24px" Width="40px" Visible="False">T.T</asp:label><asp:dropdownlist id="LstTT" style="Z-INDEX: 145; LEFT: 776px; POSITION: absolute; TOP: 456px" tabIndex="2"
				runat="server" Height="16px" Width="56px" Visible="False" AutoPostBack="True"></asp:dropdownlist><asp:label id="Label15" style="Z-INDEX: 146; LEFT: 704px; POSITION: absolute; TOP: 504px" runat="server"
				Height="24px" Width="128px" Visible="False">Special Vat Invoice</asp:label><asp:dropdownlist id="Lstvat1" style="Z-INDEX: 147; LEFT: 856px; POSITION: absolute; TOP: 504px" tabIndex="2"
				runat="server" Height="16px" Width="56px" Visible="False" AutoPostBack="True"></asp:dropdownlist><asp:calendar id="Calendar1" style="Z-INDEX: 148; LEFT: 680px; POSITION: absolute; TOP: 152px"
				runat="server" Height="160px" Font-Names="Calibri" Width="192px" Font-Size="X-Small"></asp:calendar><asp:button id="BtnAdd" style="Z-INDEX: 138; LEFT: 120px; POSITION: absolute; TOP: 312px" runat="server"
				Height="22px" Width="64px" Font-Bold="True" Text="Add"></asp:button><asp:button id="BtnSave" style="Z-INDEX: 139; LEFT: 440px; POSITION: absolute; TOP: 312px" runat="server"
				Height="22px" Width="64px" Font-Bold="True" Text="Save"></asp:button><asp:button id="Button1" style="Z-INDEX: 130; LEFT: 520px; POSITION: absolute; TOP: 312px" tabIndex="9"
				runat="server" Height="22px" Width="64px" Font-Bold="True" Text="Invoice" Visible="False"></asp:button><asp:label id="Label16" style="Z-INDEX: 149; LEFT: 120px; POSITION: absolute; TOP: 336px" runat="server"
				Height="12px" Font-Names="Calibri" Width="136px" Font-Size="X-Small" BackColor="Desktop" ForeColor="White">Last item Transaction</asp:label><asp:panel id="Panel7" style="Z-INDEX: 150; LEFT: 0px; POSITION: absolute; TOP: 480px" runat="server"
				Height="16px" Width="880px" BackColor="Desktop" Font-Bold="True"></asp:panel><asp:label id="Label10" style="Z-INDEX: 152; LEFT: 120px; POSITION: absolute; TOP: 480px" runat="server"
				Height="12px" Font-Names="Calibri" Width="160px" Font-Size="X-Small" BackColor="Desktop" ForeColor="White">Employee All Transaction</asp:label><asp:panel id="Panel8" style="Z-INDEX: 153; LEFT: 0px; POSITION: absolute; TOP: 624px" runat="server"
				Height="16px" Width="880px" BackColor="Desktop" Font-Bold="True" DESIGNTIMEDRAGDROP="671"></asp:panel><asp:label id="Label17" style="Z-INDEX: 154; LEFT: 648px; POSITION: absolute; TOP: 64px" runat="server"
				Height="16px" Font-Names="Calibri" Width="88px" Font-Size="X-Small">Department</asp:label><asp:dropdownlist id="Deplist" style="Z-INDEX: 155; LEFT: 736px; POSITION: absolute; TOP: 64px" tabIndex="2"
				runat="server" Height="16px" Font-Names="Calibri" Width="146px" Font-Size="X-Small" AutoPostBack="True"></asp:dropdownlist>
			<asp:label id="Label18" style="Z-INDEX: 156; LEFT: 352px; POSITION: absolute; TOP: 40px" runat="server"
				Font-Size="X-Small" Width="104px" Font-Names="Calibri" Height="16px">Search Employee</asp:label>
			<asp:TextBox id="txtEmpNo" style="Z-INDEX: 157; LEFT: 464px; POSITION: absolute; TOP: 40px" runat="server"
				Font-Size="X-Small" Width="48px" Font-Names="Calibri" Height="18px"></asp:TextBox>
			<asp:button id="BttEmpNo" style="Z-INDEX: 158; LEFT: 512px; POSITION: absolute; TOP: 40px" tabIndex="7"
				runat="server" Font-Size="X-Small" Width="48px" Font-Names="Calibri" Text="Go" Font-Bold="True"
				Height="18px"></asp:button>
			<asp:TextBox id="TxtEpfNo" style="Z-INDEX: 159; LEFT: 416px; POSITION: absolute; TOP: 88px" runat="server"
				Width="48px" Visible="False"></asp:TextBox>
			<asp:TextBox id="TxtDepNo" style="Z-INDEX: 160; LEFT: 544px; POSITION: absolute; TOP: 88px" runat="server"
				Width="48px" Height="16px" Visible="False"></asp:TextBox></form>
	</body>
</HTML>
