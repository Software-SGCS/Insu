<%@ Page Language="vb" AutoEventWireup="false" Codebehind="NewApp5.aspx.vb" Inherits="Insu.NewApp5"%>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>NewApp5</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body leftMargin="0" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:dropdownlist id="LstFlag2" style="Z-INDEX: 117; LEFT: 896px; POSITION: absolute; TOP: 80px" tabIndex="2"
				runat="server" AutoPostBack="True" Height="16px" Width="88px" Visible="False"></asp:dropdownlist><asp:dropdownlist id="LstVat" style="Z-INDEX: 116; LEFT: 896px; POSITION: absolute; TOP: 16px" tabIndex="2"
				runat="server" AutoPostBack="True" Height="16px" Width="88px" Visible="False"></asp:dropdownlist><asp:panel id="Panel5" style="Z-INDEX: 101; LEFT: 0px; POSITION: absolute; TOP: 152px" runat="server"
				Height="367px" Width="104px" BackColor="Desktop" BackImageUrl="Menu/AssetI.gif"></asp:panel><asp:panel id="Panel1" style="Z-INDEX: 102; LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server"
				Height="32px" Width="904px" BackColor="Desktop" ForeColor="White" HorizontalAlign="Left" Enabled="False" Font-Bold="True" BorderColor="Transparent">
				<P class="MsoNormal">
					<asp:dropdownlist id="Dropdownlist1" style="Z-INDEX: 102; LEFT: 240px; POSITION: absolute; TOP: 80px"
						tabIndex="2" runat="server" Width="144px" Height="16px"></asp:dropdownlist></P>
				<P class="MsoNormal">
					<asp:dropdownlist id="Dropdownlist2" style="Z-INDEX: 101; LEFT: 568px; POSITION: absolute; TOP: 40px"
						runat="server" Width="144px" Height="24px" AutoPostBack="True"></asp:dropdownlist>Quotation</P>
			</asp:panel><asp:panel id="Panel2" style="Z-INDEX: 103; LEFT: 0px; POSITION: absolute; TOP: 32px" runat="server"
				Height="120px" Width="104px" BackColor="Desktop" BackImageUrl="Menu/Audit.gif"></asp:panel><asp:label id="Label1" style="Z-INDEX: 105; LEFT: 112px; POSITION: absolute; TOP: 192px" runat="server"
				Height="16px" Width="104px">Engine Capacity</asp:label><asp:dropdownlist id="LstFulTyp" style="Z-INDEX: 106; LEFT: 240px; POSITION: absolute; TOP: 160px"
				tabIndex="2" runat="server" AutoPostBack="True" Height="16px" Width="144px"></asp:dropdownlist><asp:dropdownlist id="LstVehTyp" style="Z-INDEX: 107; LEFT: 240px; POSITION: absolute; TOP: 40px"
				tabIndex="1" runat="server" AutoPostBack="True" Height="40px" Width="144px"></asp:dropdownlist><asp:label id="Invoice" style="Z-INDEX: 108; LEFT: 112px; POSITION: absolute; TOP: 40px" runat="server"
				Height="24px" Width="104px">Vehicle Type</asp:label><asp:label id="Label2" style="Z-INDEX: 109; LEFT: 112px; POSITION: absolute; TOP: 160px" runat="server"
				Height="24px" Width="96px">Fuel Type</asp:label><asp:dropdownlist id="LstETyp" style="Z-INDEX: 110; LEFT: 240px; POSITION: absolute; TOP: 192px" runat="server"
				AutoPostBack="True" Height="24px" Width="144px"></asp:dropdownlist><asp:dropdownlist id="LstYtyp" style="Z-INDEX: 111; LEFT: 568px; POSITION: absolute; TOP: 112px" runat="server"
				AutoPostBack="True" Height="24px" Width="144px"></asp:dropdownlist><asp:dropdownlist id="LstPtyp" style="Z-INDEX: 112; LEFT: 568px; POSITION: absolute; TOP: 40px" runat="server"
				AutoPostBack="True" Height="24px" Width="144px"></asp:dropdownlist><asp:dropdownlist id="LstItmNo" style="Z-INDEX: 113; LEFT: 896px; POSITION: absolute; TOP: 120px"
				runat="server" AutoPostBack="True" Height="31px" Width="88px" Visible="False"></asp:dropdownlist><asp:label id="Label7" style="Z-INDEX: 114; LEFT: 424px; POSITION: absolute; TOP: 112px" runat="server"
				Height="17px" Width="128px">Year of Manufacture</asp:label><asp:textbox id="TxtSumIns" style="Z-INDEX: 115; LEFT: 240px; POSITION: absolute; TOP: 224px"
				runat="server" AutoPostBack="True" Width="144px"></asp:textbox><asp:dropdownlist id="LstTT" style="Z-INDEX: 118; LEFT: 896px; POSITION: absolute; TOP: 48px" tabIndex="2"
				runat="server" AutoPostBack="True" Height="16px" Width="88px" Visible="False"></asp:dropdownlist><asp:dropdownlist id="LstBTyp" style="Z-INDEX: 119; LEFT: 568px; POSITION: absolute; TOP: 144px" tabIndex="2"
				runat="server" AutoPostBack="True" Height="16px" Width="144px"></asp:dropdownlist><asp:label id="Label3" style="Z-INDEX: 120; LEFT: 424px; POSITION: absolute; TOP: 40px" runat="server"
				Height="17px" Width="128px">Purpose Of Vehicle</asp:label><asp:label id="Label9" style="Z-INDEX: 121; LEFT: 424px; POSITION: absolute; TOP: 144px" runat="server"
				Height="17px" Width="128px">Last Year Bonus</asp:label><asp:label id="Label10" style="Z-INDEX: 122; LEFT: 112px; POSITION: absolute; TOP: 224px" runat="server"
				Height="16px" Width="112px">Sum of Insured</asp:label><asp:dropdownlist id="LstBdtp" style="Z-INDEX: 123; LEFT: 240px; POSITION: absolute; TOP: 80px" tabIndex="2"
				runat="server" AutoPostBack="True" Height="16px" Width="144px"></asp:dropdownlist><asp:label id="Label11" style="Z-INDEX: 124; LEFT: 112px; POSITION: absolute; TOP: 80px" runat="server"
				Height="24px" Width="96px">Brand</asp:label><asp:label id="Label12" style="Z-INDEX: 125; LEFT: 112px; POSITION: absolute; TOP: 120px" runat="server"
				Height="24px" Width="96px">Model</asp:label><asp:dropdownlist id="LstMdTyp" style="Z-INDEX: 126; LEFT: 240px; POSITION: absolute; TOP: 120px"
				tabIndex="2" runat="server" AutoPostBack="True" Height="16px" Width="144px"></asp:dropdownlist>
			<DIV id="Layer1" style="Z-INDEX: 127; LEFT: 112px; OVERFLOW: scroll; WIDTH: 786px; POSITION: absolute; TOP: 256px; HEIGHT: 252px"><asp:datagrid id="MyDataGrid" runat="server" Height="12px" Width="760px" BackColor="White" BorderColor="#CCCCCC"
					cellpadding="3" Headerstyle-BackColor="#8080C0" Headerstyle-Font-Name="Tahoma" Headerstyle-Font-Size="12" Headerstyle-Font-Bold="True" Font-Name="Tahoma" Font-Size="Small" AutogenerateColumns="False" BorderWidth="1px"
					Font-Names="Tahoma" PageSize="100">
					<SelectedItemStyle Font-Size="Smaller" Font-Bold="True" HorizontalAlign="Right" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
					<EditItemStyle Font-Size="Smaller"></EditItemStyle>
					<AlternatingItemStyle Font-Size="Smaller"></AlternatingItemStyle>
					<ItemStyle Font-Size="X-Small" HorizontalAlign="Right" ForeColor="#000066"></ItemStyle>
					<HeaderStyle Font-Size="12pt" Font-Names="Arial" Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
					<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
					<Columns>
						<asp:TemplateColumn Visible="False">
							<ItemTemplate>
								<asp:LinkButton id="lbtnEdit" runat="server" CommandName="Edit" Text="<img border=0 src=http://sgcsser\Insu\images\dtg_edit.gif alt=edit>"></asp:LinkButton>
							</ItemTemplate>
							<EditItemTemplate>
								<asp:LinkButton id="lbtnUpdate" runat="server" CommandName="Update" Text="<img  border=0 src=http://sgcsser\Insu\images\dtg_update.gif alt=save/update>"></asp:LinkButton>
								<asp:LinkButton id="lbtnCancel" runat="server" CommandName="Cancel" Text="<img border=0 src=http://sgcsser\Insu\images\dtg_cancel.gif alt=cancel>"></asp:LinkButton>
							</EditItemTemplate>
						</asp:TemplateColumn>
						<asp:TemplateColumn Visible="False">
							<ItemTemplate>
								<asp:LinkButton id="lblDelete" runat="server" Text="<img border=0 src=http://sgcsser\Insu\images\delete.jpg alt=delete>"
									CommandName="Delete"></asp:LinkButton>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:BoundColumn DataField="Veh_des" ReadOnly="True" HeaderText="Description">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Left"></ItemStyle>
						</asp:BoundColumn>
						<asp:TemplateColumn HeaderText="S L I C">
							<ItemTemplate>
								<asp:Label id=Label5 runat="server" Width="128px" Text='<%# DataBinder.Eval(Container, "DataItem.Veh_Rate1") %>'>
								</asp:Label>
							</ItemTemplate>
						</asp:TemplateColumn>
						<asp:BoundColumn DataField="Veh_Rate2" ReadOnly="True" HeaderText="Cooparative">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Veh_Rate3" HeaderText="Allianz">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Veh_Rate4" ReadOnly="True" HeaderText="H N B ">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle Font-Bold="True" HorizontalAlign="Right" ForeColor="Black" VerticalAlign="Middle"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Veh_Rate5" HeaderText="Ceylinco">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle HorizontalAlign="Right"></ItemStyle>
						</asp:BoundColumn>
						<asp:BoundColumn DataField="Veh_Rate6" ReadOnly="True" HeaderText="Fair First">
							<HeaderStyle Width="1in"></HeaderStyle>
							<ItemStyle Font-Bold="True" HorizontalAlign="Right" ForeColor="Black" VerticalAlign="Middle"></ItemStyle>
						</asp:BoundColumn>
					</Columns>
					<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
				</asp:datagrid></DIV>
			<asp:button id="Button1" style="Z-INDEX: 128; LEFT: 416px; POSITION: absolute; TOP: 224px" runat="server"
				Width="56px" Text="Go"></asp:button>
			<asp:label id="Label4" style="Z-INDEX: 129; LEFT: 424px; POSITION: absolute; TOP: 72px" runat="server"
				Height="17px" Width="128px">Financial Interest</asp:label>
			<asp:dropdownlist id="LstFtyp" style="Z-INDEX: 130; LEFT: 568px; POSITION: absolute; TOP: 72px" runat="server"
				AutoPostBack="True" Height="24px" Width="144px"></asp:dropdownlist>
			<asp:CheckBox id="CheckBox1" style="Z-INDEX: 131; LEFT: 424px; POSITION: absolute; TOP: 184px"
				runat="server" Width="80px" Text="T.P.P.D"></asp:CheckBox>
			<asp:CheckBox id="CheckBox2" style="Z-INDEX: 132; LEFT: 544px; POSITION: absolute; TOP: 184px"
				runat="server" Width="80px" Text="P.A.B"></asp:CheckBox>
			<asp:CheckBox id="CheckBox3" style="Z-INDEX: 133; LEFT: 664px; POSITION: absolute; TOP: 184px"
				runat="server" Width="80px" Text="Towing"></asp:CheckBox></form>
	</body>
</HTML>
