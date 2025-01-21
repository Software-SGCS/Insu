<%@ Page CodeBehind="SgcsVeh1.aspx.vb" Language="vb" AutoEventWireup="false" Inherits="Insu.SgcsVeh1" %>
<DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML> 
	<HEAD>
		<title>Menu</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
		<LINK href="imgs/common.css" type="text/css" rel="stylesheet">
		<SCRIPT language="JavaScript" src="imgs/main.js" type="text/javascript"></SCRIPT>
		<SCRIPT src="imgs/ad_head0.js" type="text/javascript"></SCRIPT>
		<SCRIPT src="imgs/cnn_adspaces.js" type="text/javascript"></SCRIPT>
		<script language="javascript">
		
		function loadConsumer(a,b)
			{
			document.getElementById("IFF").src=a
			document.getElementById("IFF").height=b
			
			}
		</script>
		<script language="JavaScript">

function autoResize(id){
    var newheight;
    var newwidth;

    if(document.getElementById){
        newheight=document.getElementById(id).contentWindow.document.body.scrollHeight;
       // newwidth=document.getElementById(id).contentWindow.document.body.scrollWidth;
		}

		//document.getElementById(id).height= (newheight) + "px";
		document.getElementById(id).height= (newheight) + "px";
    //document.getElementById(id).width= (newwidth) + "px";
		}

		</script>
	</HEAD>		
		<body MS_POSITIONING="GridLayout">
		<table cellSpacing="0" cellPadding="0" width="100%" border="0">
			<tr>
				<td colSpan="2">
					<table cellSpacing="0" cellPadding="0" width="100%" border="0">
						<tr>
							<td>
								<TABLE id="cnnCeil" cellSpacing="0" cellPadding="0" width="100%" border="0">
									<TBODY>
										<TR>
											<TD vAlign="bottom" width="218" rowSpan="2"><A href="http://edition.cnn.com/"><IMG height="45" hspace="0" src="imgs11/logo.cnn.com.gif" width="218" border="0"></A></TD>
											<TD align="right" width="658" colSpan="2" height="18">&nbsp;</TD>
										</TR>
										<TR height="27">
											<TD class="cnnCeilW">
												<SCRIPT language="javascript" type="text/javascript">
		if (typeof(CNN_returnUserName) != "undefined") {
			CNN_returnUserName('firstName');
		} else {
			document.write('Member Center: <a href="http://audience.cnn.com/services/intl/memberservices/regwall/member_profile.jsp?source=intl">Sign In<\/a> | <a href="http://audience.cnn.com/services/cnn/memberservices/member_register.jsp?pid=&source=cnn&url=http%3A%2F%2Faudience.cnn.com%2Fservices%2Fintl%2Fmemberservices%2Fregwall%2Fmember_profile.jsp%3Fsource%3Dintl">Register<\/a>');
		}
												</SCRIPT>
												<NOSCRIPT>
													Member Center: <A href="http://audience.cnn.com/services/intl/memberservices/regwall/member_profile.jsp?source=intl">
														Sign In</A> | <A href="http://audience.cnn.com/services/cnn/memberservices/member_register.jsp?pid=&amp;source=cnn&amp;url=http%3A%2F%2Faudience.cnn.com%2Fservices%2Fintl%2Fmemberservices%2Fregwall%2Fmember_profile.jsp%3Fsource%3Dintl">
														Register</A>
												</NOSCRIPT>
											</TD>
											<TD class="cnnCeilW" align="right"></TD>
										</TR>
									</TBODY>
								</TABLE>
							</td>
						</tr>
						<tr>
							<td background="imgs11/vert.divider.gif" height="29">&nbsp;</td>
						</tr>
					</table>
				</td>
			</tr>
			<tr>
				<td vAlign="top" width="16%">
					<TABLE id="cnnCeil3" cellSpacing="0" cellPadding="0" width="154" border="0">
						<tr>
							<td width="1">
							<TD id="cnnNavBar" width="153"><!-- navbar-->
								<UL id="IntlNav">
									<LI class="current" style="WIDTH: 159px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')">SGCS Vehicle</A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('EmpMast.aspx?uid=<%=request.Querystring("uid") %>','800')">New Vehicles</A>
										</DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Entry2.aspx?uid=<%=request.Querystring("uid") %>','800')">PaymentNotice</A>
										</DIV>
									</LI>
                                                                        </LI>
										<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('EntryVehSold.aspx?uid=<%=request.Querystring("uid") %>','800')">Vehicle Refund </A>
										</DIV>
									</LI>			
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('PayApprovalNewM.aspx?uid=<%=request.Querystring("uid") %>','800')">PayNotice App </A>
										</DIV>
									</LI>
									<LI>
										<DIV><A href="javascript:loadConsumer('InsuApprovalM.aspx?uid=<%=request.Querystring("uid") %>','800')">Certificate App</A></DIV>
									</LI>
									<LI>
										<DIV><A href="javascript:loadConsumer('AccidentForm1.aspx?uid=<%=request.Querystring("uid") %>','800')">Accident Payment</A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									
									<LI>
										<DIV><A href="javascript:loadConsumer('AccidentFinal.aspx?uid=<%=request.Querystring("uid") %>','800')">Accident Final</A></DIV>
									</LI>
									<LI>
										<DIV><A href="javascript:loadConsumer('AccidentFl.aspx?uid=<%=request.Querystring("uid") %>','800')">Inquery</A></DIV>
									</LI>
									
									
									
									<LI class="current" style="WIDTH: 159px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')">Report</A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('CrsCertificate.aspx?uid=<%=request.Querystring("uid") %>','800')">Certificate  </A>
										</DIV>
									</LI>
								     <LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('crs.aspx?uid=<%=request.Querystring("uid") %>','800')">PayNotice </A>
										</DIV>
									</LI>
																		
								     <LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('VehReport1.aspx?uid=<%=request.Querystring("uid") %>','800')">PayNotice Detail</A>
										</DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('VehReport2.aspx?uid=<%=request.Querystring("uid") %>','800')">Certificate Detail</A>
										</DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('VehReport3.aspx?uid=<%=request.Querystring("uid") %>','800')">New Report</A>
										</DIV>
									</LI>
									
									
									<LI class="current" style="WIDTH: 159px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')">View</A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('ViewReport3.aspx?uid=<%=request.Querystring("uid") %>','800')">Certificate 1 </A>
										</DIV>
									</LI>
								     <LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('ViewReport4.aspx?uid=<%=request.Querystring("uid") %>','800')">Certificate 2 </A>
										</DIV>
									</LI>
									 <LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('ViewReport4.aspx?uid=<%=request.Querystring("uid") %>','800')">Certificate 2 </A>
										</DIV>
									</LI>
									
									<LI class="current" style="WIDTH: 159px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')">Print</A></DIV>
									</LI>
									
									<LI>
										<DIV><A href="javascript:loadConsumer('NewApp5.aspx?uid=<%=request.Querystring("uid") %>','800')">Vehicle Quatation</A></DIV>
									</LI>
									
									
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('ChequePrint.aspx','800')">Cheque Print</A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('ChequePrint1.aspx','800')">Cheque Print 1</A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>								
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('EmpMastNew.aspx?uid=<%=request.Querystring("uid") %>','800')">Entry Quotation </A>
										</DIV>
									</LI>
									
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('CrsNew1.aspx','800')">Rep Quotation</A></DIV>
									</LI>
								    
								    
								    <LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('VehReport1New.aspx?uid=<%=request.Querystring("uid") %>','800')">Quotaion Detail</A>
										</DIV>
									</LI>
									
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
															
									
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									 
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									 
									
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									
									
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
								    <LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									<LI style="WIDTH: 154px; HEIGHT: 0%">
										<DIV><A href="javascript:loadConsumer('Dispaly1.aspx','800')"></A></DIV>
									</LI>
									
								</UL>
							</TD>
						</tr>
					</TABLE>
				</td>
				<td vAlign="top" width="84%"><iframe id="IFF" style="WIDTH: 149.73%" name="IFF" hspace="5" vspace="0" src="Dispaly1.aspx"
						frameBorder="0" width="100%" scrolling="no" height="600"></iframe>
				</td>
			</tr>
			<tr>
				<td>&nbsp;</td>
				<td>&nbsp;</td>
			</tr>
		</TABLE>
	</body>
</HTML>
