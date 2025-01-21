<%@ Page Language="vb" AutoEventWireup="false" Codebehind="TopTen1.aspx.vb" Inherits="POS.TopTen1"%>
<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>TopTen</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body MS_POSITIONING="GridLayout" bgColor="linen">
		<form id="Form1" method="post" runat="server">
			<asp:button id="Button1" style="Z-INDEX: 100; LEFT: 224px; POSITION: absolute; TOP: 312px" runat="server"
				Text="Submit" Visible="False" BackColor="#004000" ForeColor="White"></asp:button>
			<asp:button id="Button2" style="Z-INDEX: 101; LEFT: 224px; POSITION: absolute; TOP: 312px" runat="server"
				Text="Submit" Visible="False" BackColor="#804040" ForeColor="White"></asp:button>
			<asp:Label id="Label10" style="Z-INDEX: 135; LEFT: 272px; POSITION: absolute; TOP: 16px" runat="server"
				Width="273px" ForeColor="#004000" Font-Size="X-Large" BackColor="Tan" Font-Bold="True">Best Selling Item</asp:Label>
			<asp:Calendar id="Calendar6" style="Z-INDEX: 134; LEFT: 208px; POSITION: absolute; TOP: 248px"
				runat="server" Font-Size="XX-Small" BackColor="LavenderBlush" Visible="False"></asp:Calendar>
			<asp:Calendar id="Calendar5" style="Z-INDEX: 133; LEFT: 32px; POSITION: absolute; TOP: 248px"
				runat="server" Font-Size="XX-Small" BackColor="LavenderBlush" Visible="False"></asp:Calendar>
			<asp:Calendar id="Calendar4" style="Z-INDEX: 132; LEFT: 208px; POSITION: absolute; TOP: 272px"
				runat="server" Font-Size="XX-Small" BackColor="LavenderBlush" Visible="False"></asp:Calendar>
			<asp:Calendar id="Calendar3" style="Z-INDEX: 131; LEFT: 32px; POSITION: absolute; TOP: 272px"
				runat="server" Font-Size="XX-Small" BackColor="LavenderBlush" Visible="False"></asp:Calendar>
			<asp:Calendar id="Calendar2" style="Z-INDEX: 130; LEFT: 208px; POSITION: absolute; TOP: 296px"
				runat="server" Font-Size="XX-Small" BackColor="LavenderBlush" Visible="False"></asp:Calendar>
			<asp:Calendar id="Calendar1" style="Z-INDEX: 129; LEFT: 40px; POSITION: absolute; TOP: 296px"
				runat="server" Font-Size="XX-Small" BackColor="LavenderBlush" Visible="False"></asp:Calendar>
			<asp:Label id="Label7" style="Z-INDEX: 128; LEFT: 216px; POSITION: absolute; TOP: 152px" runat="server">To Cat</asp:Label>
			<asp:Label id="Label6" style="Z-INDEX: 127; LEFT: 16px; POSITION: absolute; TOP: 152px" runat="server">From Cat</asp:Label>
			<asp:Label id="Label3" style="Z-INDEX: 126; LEFT: 16px; POSITION: absolute; TOP: 120px" runat="server">Top number</asp:Label>
			<asp:Label id="Label2" style="Z-INDEX: 125; LEFT: 216px; POSITION: absolute; TOP: 184px" runat="server">To Location</asp:Label>
			<asp:Label id="Label1" style="Z-INDEX: 124; LEFT: 16px; POSITION: absolute; TOP: 184px" runat="server">From Location</asp:Label><asp:textbox id="txtTdate2" style="Z-INDEX: 123; LEFT: 296px; POSITION: absolute; TOP: 272px"
				runat="server" Width="70px"></asp:textbox><asp:textbox id="txtFdate2" style="Z-INDEX: 122; LEFT: 112px; POSITION: absolute; TOP: 272px"
				runat="server" Width="70px"></asp:textbox><asp:textbox id="txtTdate1" style="Z-INDEX: 121; LEFT: 296px; POSITION: absolute; TOP: 248px"
				runat="server" Width="70px"></asp:textbox><asp:textbox id="txtFdate1" style="Z-INDEX: 120; LEFT: 112px; POSITION: absolute; TOP: 248px"
				runat="server" Width="70px"></asp:textbox><asp:textbox id="txtNOM" style="Z-INDEX: 119; LEFT: 112px; POSITION: absolute; TOP: 120px" runat="server"
				Width="32px">30</asp:textbox><asp:textbox id="txtTLOC" style="Z-INDEX: 118; LEFT: 296px; POSITION: absolute; TOP: 184px" runat="server"
				Width="48px"></asp:textbox><asp:textbox id="txtFdate3" style="Z-INDEX: 117; LEFT: 112px; POSITION: absolute; TOP: 296px"
				runat="server" Width="72px"></asp:textbox><asp:textbox id="txtTdate3" style="Z-INDEX: 116; LEFT: 296px; POSITION: absolute; TOP: 296px"
				runat="server" Width="72px"></asp:textbox><asp:textbox id="txtFCat" style="Z-INDEX: 115; LEFT: 112px; POSITION: absolute; TOP: 152px" runat="server"
				Width="32px"></asp:textbox><asp:radiobutton id="RadioButton2" style="Z-INDEX: 114; LEFT: 184px; POSITION: absolute; TOP: 88px"
				runat="server" Text="Slow Moving" GroupName="A" ForeColor="Blue" Font-Bold="True" AutoPostBack="True"></asp:radiobutton><asp:radiobutton id="RadioButton1" style="Z-INDEX: 113; LEFT: 16px; POSITION: absolute; TOP: 88px"
				runat="server" Text="Best Selling" GroupName="A" ForeColor="Blue" Font-Bold="True" AutoPostBack="True"></asp:radiobutton><asp:textbox id="TXTFDATE" style="Z-INDEX: 112; LEFT: 112px; POSITION: absolute; TOP: 224px"
				runat="server" Width="70px"></asp:textbox><asp:label id="Label4" style="Z-INDEX: 106; LEFT: 16px; POSITION: absolute; TOP: 224px" runat="server"
				Height="24px" Width="72px" ForeColor="Black" Font-Size="X-Small">From Date</asp:label><asp:label id="Label5" style="Z-INDEX: 107; LEFT: 216px; POSITION: absolute; TOP: 224px" runat="server"
				Height="24px" Width="56px" ForeColor="Black" Font-Size="X-Small">To Date</asp:label><asp:textbox id="TXTTDATE" style="Z-INDEX: 105; LEFT: 296px; POSITION: absolute; TOP: 224px"
				runat="server" Width="70px"></asp:textbox><asp:label id="Label9" style="Z-INDEX: 109; LEFT: 304px; POSITION: absolute; TOP: 208px" runat="server"
				Height="16px" Width="64px" ForeColor="Maroon" Font-Size="XX-Small"> DD/MM/YYYY</asp:label><asp:label id="Label8" style="Z-INDEX: 108; LEFT: 120px; POSITION: absolute; TOP: 208px" runat="server"
				Height="16px" Width="64px" ForeColor="Maroon" Font-Size="XX-Small"> DD/MM/YYYY</asp:label><asp:imagebutton id="Image2" style="Z-INDEX: 111; LEFT: 592px; POSITION: absolute; TOP: 24px" runat="server"
				Height="32px" Width="50px"></asp:imagebutton>
			<asp:imagebutton id="Image1" style="Z-INDEX: 110; LEFT: 664px; POSITION: absolute; TOP: 24px" runat="server"
				Height="32px" Width="29px"></asp:imagebutton>
			<asp:Panel id="Panel3" style="Z-INDEX: 104; LEFT: 760px; POSITION: absolute; TOP: 128px" runat="server"
				Visible="False">Panel</asp:Panel>
			<asp:Panel id="Panel2" style="Z-INDEX: 103; LEFT: 0px; POSITION: absolute; TOP: 0px" runat="server"
				Height="72px" Width="784px" BackColor="Tan" ForeColor="Tan">
<asp:Calendar id="Calendar8" style="Z-INDEX: 101; LEFT: 208px; POSITION: absolute; TOP: 320px"
					runat="server" BackColor="LavenderBlush" Visible="False" Font-Size="XX-Small"></asp:Calendar>Panel</asp:Panel>
			<asp:Panel id="Panel1" style="Z-INDEX: 102; LEFT: 0px; POSITION: absolute; TOP: 80px" runat="server"
				ForeColor="#FFE0C0" Width="490px" Height="310px" BorderColor="#C04000" BorderStyle="Double">Panel</asp:Panel>
			<asp:TextBox id="txtFLOC" style="Z-INDEX: 136; LEFT: 112px; POSITION: absolute; TOP: 184px" runat="server"
				Width="48px"></asp:TextBox>
			<asp:Calendar id="Calendar7" style="Z-INDEX: 137; LEFT: 40px; POSITION: absolute; TOP: 320px"
				runat="server" ForeColor="Black" Font-Size="XX-Small" BackColor="LavenderBlush" Visible="False"></asp:Calendar>
			<asp:TextBox id="txtTCAT" style="Z-INDEX: 138; LEFT: 296px; POSITION: absolute; TOP: 152px" runat="server"
				Width="32px"></asp:TextBox>
			<CR:CrystalReportViewer id="CrystalReportViewer1" style="Z-INDEX: 139; LEFT: -320px; POSITION: absolute; TOP: 384px"
				runat="server" Height="50px" Width="350px" Visible="False" SeparatePages="False" DisplayToolbar="False"></CR:CrystalReportViewer>
			<asp:ImageButton id="Cal2" style="Z-INDEX: 140; LEFT: 184px; POSITION: absolute; TOP: 224px" runat="server"
				ImageUrl="http://localhost/POS/iCO/Cal4.jpg"></asp:ImageButton>
			<asp:ImageButton id="Cal3" style="Z-INDEX: 141; LEFT: 368px; POSITION: absolute; TOP: 224px" runat="server"
				ImageUrl="http://localhost/POS/iCO/Cal4.jpg"></asp:ImageButton>
			<asp:ImageButton id="Cal4" style="Z-INDEX: 142; LEFT: 184px; POSITION: absolute; TOP: 248px" runat="server"
				ImageUrl="http://localhost/POS/iCO/Cal4.jpg"></asp:ImageButton>
			<asp:ImageButton id="ImageButton2" style="Z-INDEX: 143; LEFT: 368px; POSITION: absolute; TOP: 248px"
				runat="server" ImageUrl="http://localhost/POS/iCO/Cal4.jpg"></asp:ImageButton>
			<asp:ImageButton id="ImageButton3" style="Z-INDEX: 144; LEFT: 184px; POSITION: absolute; TOP: 272px"
				runat="server" ImageUrl="http://localhost/POS/iCO/Cal4.jpg"></asp:ImageButton>
			<asp:ImageButton id="ImageButton4" style="Z-INDEX: 145; LEFT: 368px; POSITION: absolute; TOP: 272px"
				runat="server" ImageUrl="http://localhost/POS/iCO/Cal4.jpg"></asp:ImageButton>
			<asp:ImageButton id="ImageButton5" style="Z-INDEX: 146; LEFT: 184px; POSITION: absolute; TOP: 296px"
				runat="server" ImageUrl="http://localhost/POS/iCO/Cal4.jpg"></asp:ImageButton>
			<asp:ImageButton id="ImageButton6" style="Z-INDEX: 147; LEFT: 368px; POSITION: absolute; TOP: 296px"
				runat="server" ImageUrl="http://localhost/POS/iCO/Cal4.jpg"></asp:ImageButton>
			<asp:comparevalidator id="CompareValidator1" style="Z-INDEX: 148; LEFT: 152px; POSITION: absolute; TOP: 152px"
				runat="server" Font-Size="XX-Small" Width="65px" Operator="LessThanEqual" ControlToValidate="txtFCat"
				ControlToCompare="txtTCAT" ErrorMessage="CompareValidator">Invalied Rang</asp:comparevalidator>
			<asp:comparevalidator id="Comparevalidator2" style="Z-INDEX: 149; LEFT: 168px; POSITION: absolute; TOP: 192px"
				runat="server" Font-Size="XX-Small" Width="65px" Operator="LessThanEqual" ControlToValidate="txtFLOC"
				ControlToCompare="txtTLOC" ErrorMessage="CompareValidator">Invalied Rang</asp:comparevalidator>
		</form>
	</body>
</HTML>
