<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Upload3.aspx.vb" Inherits="Insu.Upload3" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>UploadSale</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
	</HEAD>
	<body bgColor="aliceblue" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<asp:panel id="Panel3" style="Z-INDEX: 109; LEFT: -8px; POSITION: absolute; TOP: 0px" runat="server"
				BackImageUrl="Menu/EmpMaster4.jpg" Width="120px" Height="734px">
				<asp:panel id="Panel1" style="Z-INDEX: 107; LEFT: 120px; POSITION: absolute; TOP: 560px" runat="server"
					Height="16px" Width="871px" BackColor="Navy"></asp:panel>
				<asp:panel id="Panel4" style="Z-INDEX: 108; LEFT: 904px; POSITION: absolute; TOP: 8px" runat="server"
					Height="670px" Width="97px" BackColor="Navy">Panel</asp:panel>
			</asp:panel>
			<DIV style="Z-INDEX: 110; LEFT: 112px; WIDTH: 880px; POSITION: absolute; TOP: 16px; HEIGHT: 32px"
				align="left" ms_positioning="FlowLayout"><FONT face="Tahoma"><FONT size="5"><FONT size="4">Upload 
							Data Entry</FONT></FONT></FONT></DIV>
			<asp:panel id="Panel7" style="Z-INDEX: 102; LEFT: 112px; POSITION: absolute; TOP: 48px" runat="server"
				Width="879px" Height="24px" BackColor="Navy"></asp:panel>&nbsp; <INPUT id="fileUpload" style="Z-INDEX: 104; LEFT: 368px; WIDTH: 393px; POSITION: absolute; TOP: 112px; HEIGHT: 22px"
				type="file" name="File1" runat="server" size="46"><asp:label id="Label1" style="Z-INDEX: 101; LEFT: 120px; POSITION: absolute; TOP: 88px" runat="server"
				Width="384px" Height="24px" BackColor="AliceBlue" Font-Names="Tahoma" Font-Bold="True" Font-Size="11pt" ForeColor="#000040"> Upload Employee Data to Server</asp:label><asp:label id="Label2" style="Z-INDEX: 103; LEFT: 120px; POSITION: absolute; TOP: 120px" runat="server"
				Width="320px" Font-Names="Tahoma" Font-Size="X-Small"> Select the Text file to upload the Server </asp:label><asp:label id="Label3" style="Z-INDEX: 105; LEFT: 360px; POSITION: absolute; TOP: 568px" runat="server"
				Width="472px" Height="14px" Font-Names="Book Antiqua" Font-Size="Medium" ForeColor="Red"></asp:label><asp:button id="Button2" style="Z-INDEX: 106; LEFT: 120px; POSITION: absolute; TOP: 472px" runat="server"
				Font-Bold="True" Text="View  "></asp:button><asp:label id="Label6" style="Z-INDEX: 107; LEFT: 120px; POSITION: absolute; TOP: 144px" runat="server"
				Width="296px" Font-Bold="True" ForeColor="#000040"></asp:label>
			<asp:requiredfieldvalidator id="RequiredFieldValidator1" style="Z-INDEX: 108; LEFT: 120px; POSITION: absolute; TOP: 568px"
				runat="server" Width="184px" ErrorMessage="Can't Be Null" ControlToValidate="fileUpload" Enabled="False"></asp:requiredfieldvalidator><asp:panel id="Panel2" style="Z-INDEX: 111; LEFT: 112px; POSITION: absolute; TOP: 0px" runat="server"
				Width="880px" Height="14px" BackColor="Navy">P 
<asp:button id="Button3" style="Z-INDEX: 125; LEFT: 88px; POSITION: absolute; TOP: 472px" runat="server"
					Width="56px" Font-Bold="True" Text="Upload "></asp:button>
<DIV id="Layer1" style="Z-INDEX: 124; LEFT: 8px; OVERFLOW: scroll; WIDTH: 772px; POSITION: absolute; TOP: 168px; HEIGHT: 296px">
					<asp:datagrid id="MyDataGrid" runat="server" Height="60px" Width="748px" BackColor="White" Font-Size="12pt"
						Font-Names="Tahoma" BorderWidth="1px" BorderStyle="None" DataKeyField="id" OnDeleteCommand="MyDataGrid_DeleteCommand"
						OnUpdateCommand="MyDataGrid_UpdateCommand" OnCancelcommand="MyDataGrid_Cancel" OnEditcommand="MyDataGrid_EditCommand"
						AutogenerateColumns="False" BorderColor="MidnightBlue" Font-Name="Tahoma" Headerstyle-Font-Bold="True"
						Headerstyle-Font-Size="12" Headerstyle-Font-Name="Tahoma" Headerstyle-BackColor="#8080C0"
						cellpadding="3">
						<FooterStyle ForeColor="#000066" BackColor="White"></FooterStyle>
						<SelectedItemStyle Font-Size="Smaller" Font-Bold="True" ForeColor="White" BackColor="#669999"></SelectedItemStyle>
						<EditItemStyle Font-Size="Smaller"></EditItemStyle>
						<AlternatingItemStyle Font-Size="Smaller"></AlternatingItemStyle>
						<ItemStyle Font-Size="Smaller" ForeColor="#000066"></ItemStyle>
						<HeaderStyle Font-Size="12pt" Font-Names="Arial" Font-Bold="True" ForeColor="White" BackColor="#006699"></HeaderStyle>
						<Columns>
							<asp:BoundColumn DataField="Com_Code" ReadOnly="True" HeaderText="Com Code">
								<HeaderStyle Width="0.4in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Left"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="Emp_No" ReadOnly="True" HeaderText="Emp No ">
								<HeaderStyle Width="0.4in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Left"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="Emp_Nam" ReadOnly="True" HeaderText="Employee Name">
								<HeaderStyle Width="2.5in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Left"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="Emp_Dob" ReadOnly="True" HeaderText="Date of Birth">
								<HeaderStyle Width="08in"></HeaderStyle>
								<ItemStyle HorizontalAlign="left"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="Emp_Nic" ReadOnly="True" HeaderText="Nic No">
								<HeaderStyle Width="0.8in"></HeaderStyle>
								<ItemStyle HorizontalAlign="left"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="Emp_Nocld" ReadOnly="True" HeaderText="No of child">
								<HeaderStyle Width="0.5in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Right"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="Emp_OldNo" ReadOnly="True" HeaderText="Old EmpNo">
								<HeaderStyle Width="0.5in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Right"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="Emp_RNam" ReadOnly="True" HeaderText="Relation Name">
								<HeaderStyle Width="2.0in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Left"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="Emp_Rtyp" ReadOnly="True" HeaderText="Type">
								<HeaderStyle Width="0.8in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Left"></ItemStyle>
							</asp:BoundColumn>
							<asp:BoundColumn DataField="Emp_RDob" ReadOnly="True" HeaderText="Date of Birth">
								<HeaderStyle Width="0.8in"></HeaderStyle>
								<ItemStyle HorizontalAlign="Right"></ItemStyle>
							</asp:BoundColumn>
						</Columns>
						<PagerStyle HorizontalAlign="Left" ForeColor="#000066" BackColor="White" Mode="NumericPages"></PagerStyle>
					</asp:datagrid></DIV>anel</asp:panel>
			<asp:panel id="Panel5" style="Z-INDEX: 112; LEFT: 112px; POSITION: absolute; TOP: 576px" runat="server"
				Height="102px" Width="786px" BackImageUrl="Menu/EMPMASTER1.jpg"></asp:panel>
			<asp:TextBox id="TxtSt" style="Z-INDEX: 113; LEFT: 288px; POSITION: absolute; TOP: 464px" runat="server"
				Height="96px" Width="600px" TextMode="MultiLine"></asp:TextBox></form>
	</body>
</HTML>
