<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Index.aspx.vb" Inherits="CRM.Index" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>CRM</title>
		<LINK href="favicon.ico" rel="SHORTCUT ICON">
		<meta name="description" content="DsiCRM - Commercial Open Source Customer Relationship Management" />
		<meta name="keywords" content="Commercial Open Source Customer Relationship Management,CRM,SFA" />
		<meta name="Generator" content="Colombo - Copyright 2006 - 2006 D Samson & sons Ltd.  All rights reserved." />
		<meta name="robots" content="index, follow" />

		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		
		<LINK href="StylesLog.css" type="text/css" rel="stylesheet">
	</HEAD>
	<body class="BODY_SCR" bgColor="#000000" MS_POSITIONING="GridLayout">
		<form id="Form1" method="post" runat="server">
			<table height="425" cellSpacing="0" cellPadding="0" width="760" align="center" border="0">
				<tr>
					<td>
						<table borderColor="#cc3300" cellSpacing="0" cellPadding="0" width="760" align="center"
							background="http://intranet/CRM/image/bod.jpg" border="0">
							<tr> <!--HEADER-->
								<td align="center">
									<table height="75" cellSpacing="0" cellPadding="0" width="760" background="http://intranet/CRM/image/hd5.gif"
										border="0">
										<tr>
											<td borderColor="#33ff33">&nbsp;</td>
										</tr>
									</table>
								</td>
							</tr>
							<tr> <!--BODY-->
								<td align="center">
									<table borderColor="#00ff33" height="325" cellSpacing="0" cellPadding="0" width="760" border="0">
										<tr>
											<td>
												<table cellSpacing="0" cellPadding="0" width="760" border="0">
													<tr>
														<td></td>
														<td width="745">
															<table borderColor="#ff66cc" height="325" cellSpacing="0" cellPadding="0" width="745" border="0">
																<tr>
																	<td>
																		<table cellSpacing="0" cellPadding="0" width="745" border="0">
																			<tr>
																				<td vAlign="top" align="left" width="126" rowSpan="2"><IMG height="330" src="http://intranet/CRM/image/Index_LeftImage.jpg" width="126" border="0"></td>
																				<td>
																					<table height="310" cellSpacing="0" cellPadding="0" width="465" border="0">
																						<TR>
																							<td align="center" width="465"><IMG height="170" src="http://intranet/CRM/image/home1.gif" width="400"></td>
																						</TR>
																					</table>
																				</td>
																				<td width="153">
																					<table height="330" cellSpacing="0" cellPadding="0" width="153" border="0">
																						<tr height="170">
																							<td>
																								<table cellSpacing="0" cellPadding="0" width="153" border="0">
																									<tr>
																										<td><IMG src="http://intranet/CRM/image/sub02.gif" width="153"></td>
																									</tr>
																									<tr height="128">
																										<td>
																											<table borderColor="#579ecb" height="127" cellSpacing="0" cellPadding="0" width="149" border="0">
																												<tr>
																													<td><IMG height="127" src="http://intranet/CRM/image/Team.jpg" width="149"></td>
																												</tr>
																											</table>
																										</td>
																									</tr>
																								</table>
																							</td>
																						</tr>
																						<tr height="155">
																							<td>
																								<table cellSpacing="0" cellPadding="0" width="153" border="0">
																									<tr>
																										<td><IMG src="http://intranet/CRM/image/topbl.gif"></td>
																									</tr>
																									<tr height="108">
																										<td>
																											<table height="107" cellSpacing="0" cellPadding="0" width="153" background="http://intranet/CRM/image/logbody.jpg"
																												border="0"> <!--bordercolor="#579ECB"-->
																												<tr>
																													<td><font face="Tahoma, Verdana" size="-2"><label>&nbsp;&nbsp;&nbsp;&nbsp;User ID</label>&nbsp;&nbsp;&nbsp;
																															<asp:textbox id="txtID" runat="server" Width="62px" height="15" maxlength="10" CssClass="txtbtn"
																																tabIndex="1"></asp:textbox><br>
																															<br>
																															<label>&nbsp;&nbsp;&nbsp;&nbsp;Password</label></font>&nbsp;<font face="Tahoma, Verdana" size="-2"><asp:textbox id="txtpwd" runat="server" Width="62px" height="15" maxlength="10" CssClass="txtbtn"
																																TextMode="Password" type="password" tabIndex="2"></asp:textbox>
																														</font>
																														<br>
																														<br>
																														&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:button id="Btnlog" runat="server" CssClass="buttonstyle" tabIndex="3"></asp:button>
																													</td>
																												</tr>
																											</table>
																										</td>
																									</tr>
																									<tr> <!--<img src="../../../Inetpub/wwwroot/sr/http://intranet/CRM/image/logbody.jpg" width="153" height="107">-->
																										<td><IMG src="http://intranet/CRM/image/belbl.gif"></td>
																									</tr>
																								</table>
																							</td>
																						</tr>
																					</table>
																				</td>
																			</tr>
																		</table>
																	</td>
																</tr>
															</table>
														</td>
														<td width="5">
															<table borderColor="#ffccff" height="330" cellSpacing="0" cellPadding="0" width="5" background="http://intranet/CRM/image/left01.gif"
																border="0">
																<tr>
																	<td width="27">&nbsp;</td>
																</tr>
															</table>
														</td>
													</tr>
												</table>
											</td>
										</tr>
									</table>
								</td>
							</tr>
							<tr> <!--FOTTER-->
								<td align="center">
									<table height="10" cellSpacing="0" cellPadding="0" width="760" background="http://intranet/CRM/image/footer.gif"
										border="0">
										<tr>
											<td borderColor="#00ff00" width="760">&nbsp;</td>
										</tr>
									</table>
								</td>
							</tr>
						</table>
					</td>
				</tr>
			</table>
		</form>
	</body>
</HTML>
