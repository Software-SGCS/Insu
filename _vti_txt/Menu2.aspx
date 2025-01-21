<%@ Page Language="vb" AutoEventWireup="false" Codebehind="Menu2.aspx.vb" Inherits="Insu.Menu2" %>
<!DOCTYPE HTML PUBLIC "-//W3C//DTD HTML 4.0 Transitional//EN">
<HTML>
	<HEAD>
		<title>Menu</title>
		<meta content="Microsoft Visual Studio .NET 7.1" name="GENERATOR">
		<meta content="Visual Basic .NET 7.1" name="CODE_LANGUAGE">
		<meta content="JavaScript" name="vs_defaultClientScript">
		<meta content="http://schemas.microsoft.com/intellisense/ie5" name="vs_targetSchema">
		<meta http-equiv="Content-Type" content="text/html; charset=iso-8859-1">
		<LINK href="imgs/common.css" type="text/css" rel="stylesheet">
		<SCRIPT language="JavaScript1.2" src="imgs/main.js" type="text/javascript"></SCRIPT>
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
		<table width="100%" border="0" cellspacing="0" cellpadding="0">
			<tr>
				<td colspan="2">
					<table width="100%" border="0" cellspacing="0" cellpadding="0">
						<tr>
							<td>
								<TABLE id="cnnCeil" cellSpacing="0" cellPadding="0" width="100%" border="0">
									<TBODY>
										<TR>
											<TD vAlign="bottom" width="218" rowSpan="2"><A href="http://edition.cnn.com/"><IMG height="45" hspace="0" src="imgs/logo.cnn.com.gif" width="218" border="0"></A></TD>
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
							<td background="imgs/vert.divider.gif" height="29">&nbsp;</td>
						</tr>
					</table>
				</td>
			</tr>
			<tr>
				<td width="16%" valign="top">
					<table width="154" border="0" cellspacing="0" cellpadding="0">
						<tr>
							<td width="1">
							<TD width="153" id="cnnNavBar"><!-- navbar-->
								<UL id="IntlNav">
									<LI class="current" style="WIDTH: 159px; HEIGHT: 0%">
										<DIV style="WIDTH: 150px; HEIGHT: 16px"><A href="javascript:loadConsumer('InsuDept.aspx','800')">Home</A></DIV>
									</LI>
																
									
								
									<LI>
										<DIV><A href="javascript:loadConsumer('CodeMaster.aspx','800')">Sale Code Mast</A></DIV>
									</LI>
									<LI>
										<DIV><A href="javascript:loadConsumer('WebForm3.aspx','800')">Sale &amp; SysMast</A></DIV>
									</LI>
									<LI>
										<DIV><A href="javascript:loadConsumer('OutWord.aspx','800')">Sale OutWord</A></DIV>
									</LI>
									<LI>
										<DIV><A href="javascript:loadConsumer('InWord.aspx','800')">Sale InWord</A></DIV>
									</LI>
									<LI>
										<DIV><A href="javascript:loadConsumer('InvoicePayment.aspx','800')">Invoice Payment</A></DIV>
									</LI>
									<LI>
										<DIV><A href="javascript:loadConsumer('InvCheck.aspx','800')">Invoice Check</A></DIV>
									</LI>
									
									<LI class="current">
										<DIV><A href="javascript:loadConsumer('CrsTaxInvoice.aspx','800')">Pint Invoice</A></DIV>
									</LI>
									
									<LI class="current">
										<DIV><A href="javascript:loadConsumer('ViewReport1.aspx','800')">Invoice View 1</A></DIV>
									</LI>
									<LI class="current">
										<DIV><A href="javascript:loadConsumer('ViewReport2.aspx','800')">Invoice View 2</A></DIV>
									</LI>
									<LI>
										<DIV><A href="javascript:loadConsumer('frmEview.aspx','800')">I-Reports</A></DIV>
									</LI>
								</UL>
								<DIV class="cnnNavHeader"><IMG height="18" hspace="0" src="imgs/nav.hdr.only.on.gif" width="150" border="0"></DIV>
								<DIV class="cnnNavBot">
									<DIV><IMG height="1" hspace="0" src="CNN_com International_files/gray.top.gif" width="126"
											border="0"></DIV>
									<DIV onmouseover="cnnSetHoverClass(this,'cnnHover',1)" onmouseout="cnnSetHoverClass(this,'cnnHover',0)"><A href="javascript:loadConsumer('DeathDonationEntry1.aspx','800')">Death 
											Donation</A></DIV>
									<DIV class="cnnDiv"></DIV>
									<DIV onmouseover="cnnSetHoverClass(this,'cnnHover',1)" onmouseout="cnnSetHoverClass(this,'cnnHover',0)"><A href="javascript:loadConsumer('DeathDonationEntry1.aspx','800')">Helth 
											On</A></DIV>
									<DIV class="cnnDiv"></DIV>
									<DIV onmouseover="cnnSetHoverClass(this,'cnnHover',1)" onmouseout="cnnSetHoverClass(this,'cnnHover',0)"><A href="javascript:loadConsumer('EntryVehSold.aspx','800')">Entry 
											Vehicle Refund </A>
									</DIV>
									<DIV class="cnnDiv"></DIV>
									<DIV onmouseover="cnnSetHoverClass(this,'cnnHover',1)" onmouseout="cnnSetHoverClass(this,'cnnHover',0)"><A href="javascript:loadConsumer('VehReport1.aspx','800')">Payment 
											Notice Detail Report </A>
									</DIV>
									<DIV class="cnnDiv"></DIV>
									<DIV onmouseover="cnnSetHoverClass(this,'cnnHover',1)" onmouseout="cnnSetHoverClass(this,'cnnHover',0)"><A href="javascript:loadConsumer('AccidentForm1.aspx','800')">Vehicle 
											Accident Payment </A>
									</DIV>
									<DIV class="cnnDiv"></DIV>
									<DIV onmouseover="cnnSetHoverClass(this,'cnnHover',1)" onmouseout="cnnSetHoverClass(this,'cnnHover',0)"><A href="javascript:loadConsumer('frmEview.aspx','800')">Blank
										</A>
									</DIV>
									<DIV class="cnnDiv"></DIV>
									<DIV onmouseover="cnnSetHoverClass(this,'cnnHover',1)" onmouseout="cnnSetHoverClass(this,'cnnHover',0)"><A href="javascript:loadConsumer('frmEview.aspx','800')">Blank
										</A>
									</DIV>
									<DIV class="cnnDiv"></DIV>
									<DIV onmouseover="cnnSetHoverClass(this,'cnnHover',1)" onmouseout="cnnSetHoverClass(this,'cnnHover',0)"><A href="javascript:loadConsumer('frmEview.aspx','800')">Blank
										</A>
									</DIV>
									<DIV class="cnnDiv"></DIV>
									<DIV onmouseover="cnnSetHoverClass(this,'cnnHover',1)" onmouseout="cnnSetHoverClass(this,'cnnHover',0)"><A href="javascript:loadConsumer('frmEview.aspx','800')">Blank</A></DIV>
									<DIV class="cnnDiv"></DIV>
									<DIV onmouseover="cnnSetHoverClass(this,'cnnHover',1)" onmouseout="cnnSetHoverClass(this,'cnnHover',0)"><A href="javascript:loadConsumer('frmEview.aspx','800')">Blank</A></DIV>
									<DIV class="cnnDiv"></DIV>
									<DIV onMouseOver="cnnSetHoverClass(this,'cnnHover',1)" onmouseout="cnnSetHoverClass(this,'cnnHover',0)"><A href="javascript:loadConsumer('frmEview.aspx','800')">The 
											Scene</A></DIV>
									<DIV class="cnnDiv"></DIV>
									<DIV onMouseOver="cnnSetHoverClass(this,'cnnHover',1)" onmouseout="cnnSetHoverClass(this,'cnnHover',0)"><A href="javascript:loadConsumer('frmEview.aspx','800')">Talk 
											Asia</A></DIV>
									<DIV class="cnnDiv"></DIV>
									<DIV class="cnnDivEmpty"></DIV>
									<DIV class="cnnDiv"></DIV>
									<DIV class="cnnDivEmpty"></DIV>
									<DIV><IMG height="1" hspace="0" src="imgs/gray.bot.gif" width="126" border="0"></DIV>
								</DIV>
							</TD>
						</tr>
					</table>
				</td>
				<td width="84%" valign="top"><iframe id="IFF" style="WIDTH: 149.73%" name="IFF" hspace="5" vspace="0" src="InsuDept.aspx"
						frameBorder="0" width="100%" scrolling="no" onload="autoResize('IFF');" height="600"></iframe>
				</td>
			</tr>
			<tr>
				<td>&nbsp;</td>
				<td>&nbsp;</td>
			</tr>
		</table>
	</body>
</HTML>
