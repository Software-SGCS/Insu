<%@ Page Language="vb" AutoEventWireup="false" Codebehind="PopTopTen.aspx.vb" Inherits="Insu.PopTopTen" %>
<%@ Register TagPrefix="cr" Namespace="CrystalDecisions.Web" Assembly="CrystalDecisions.Web, Version=9.1.5000.0, Culture=neutral, PublicKeyToken=692fbea5521e1304" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<asp:Literal id="Literal1" runat="server"></asp:Literal>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<LINK href="css/StylesLog.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body MS_POSITIONING="GridLayout" topmargin="0" leftmargin="0">
		<form id="Form1" method="post" runat="server">
			<table cellSpacing="0" cellPadding="0" width="1000" align="center" border="0">
				<tr>
					<td background="images/headerYL.gif" height="54" tppabs="http://intranet.dsisamson.com/POS/images/headerYL.gif">
						&nbsp;</td>
				</tr>
				<tr>
					<td background="images/kubrickbgYL.gif" tppabs="http://intranet.dsisamson.com/POS/images/kubrickbgYL.gif">
						<!--Above Background Fist table-->
						<table cellSpacing="0" cellPadding="0" width="1000" align="center" border="0">
							<tr>
								<td background="images/dot-h.gif" bgColor="#e6e6e6" colSpan="3" tppabs="http://intranet.dsisamson.com/POS/images/dot-.gif"></td>
							</tr>
							<tr>
								<td></td>
								<td></td>
								<td></td>
							</tr>
							<tr align="center" height="600">
								<td width="17">&nbsp;</td>
								<td align="left" width="961"> <!--SGrid-->
									<div id="div-datagrid" style="Z-INDEX: 101; LEFT: 15px; WIDTH: 940px; TOP: 0px; HEIGHT: 600px">
										<cr:CrystalReportViewer id="CrystalReportViewer1" style="Z-INDEX: 102; LEFT: -375px; POSITION: absolute; TOP: 0px"
											runat="server" Height="50px" Width="350px" DisplayToolbar="False" SeparatePages="False"></cr:CrystalReportViewer></div>
									<!--SGrid table--></td>
								<td width="22">&nbsp;&nbsp;</td>
							</tr>
							<tr>
								<td background="images/dot-h.gif" bgColor="#e6e6e6" colSpan="3" tppabs="http://intranet.dsisamson.com/POS/images/dot-h.gif"></td>
							</tr>
							<tr>
								<td colSpan="2">
									<table width="68%" border="0" cellspacing="0" cellpadding="0">
										<tr>
											<td width="30">&nbsp;</td>
											<td>
												<!--Navigater Table-->
												<table width="68%" background="http://TIME/POS/images/listViewBg.gif" border="0" cellspacing="0"
													cellpadding="0" height="20">
													<tr height="20">
														<td height="20">&nbsp;Select Export Format</td>
														<td style="WIDTH: 14px"><asp:DropDownList id="DropDownList1" runat="server" Width="137px" Height="14px"></asp:DropDownList></td>
														<td><asp:Button id="Button1" runat="server" CssClass="Btn_Export" Text="Export"></asp:Button></td>
													</tr>
												</table>
												<!--Navigater Table--></td>
										</tr>
									</table>
								</td>
								<td></td>
							</tr>
							<tr>
								<td background="images/dot-h.gif" bgColor="#e6e6e6" colSpan="3" tppabs="http://intranet.dsisamson.com/POS/images/dot-h.gif"></td>
							</tr>
						</table>
						<!--Above Background Fist table--></td>
				</tr>
				<tr height="54">
					<td background="images/footerYL.gif" tppabs="http://intranet.dsisamson.com/POS/images/footerYL.gif">&nbsp;</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
