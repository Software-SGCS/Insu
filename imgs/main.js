var agt		= navigator.userAgent.toLowerCase();
var versInt	= parseInt(navigator.appVersion);
var is_aol	= (agt.indexOf("aol") != -1);
var cnnDomainArray = location.hostname.split( '.' );
var EditionDomain = ( cnnDomainArray.length > 1 ) ? '.' + cnnDomainArray[cnnDomainArray.length-2] + '.' + cnnDomainArray[cnnDomainArray.length-1] : '';
var cnnSiteWideCurrDate = new Date();



function CNN_goTo( url ) {
	window.location.href = url;
}

//dhtml menus
var cnnDocumentOnClickFunc = '';
		var cnnCurrDisplayBBinDhtmlMenuId = '';
		var cnnCurrDisplayBBinDhtmlStatus = 'hidden';
		function cnnCloseBBinDhtmlMenu()
		{
			cnnFlipDisplayIdNode(cnnCurrDisplayBBinDhtmlMenuId);
			cnnCurrDisplayBBinDhtmlStatus = 'visible';
		}
		function cnnFlipDisplayIdNode(id,position)
		{
			var nodeToMod= document.getElementById(id);
			if(nodeToMod && nodeToMod.style)
			{
				var currDisplayValue = '';
				if((cnnCurrDisplayBBinDhtmlStatus=='visible') && (id==cnnCurrDisplayBBinDhtmlMenuId))
				{
					document.onclick=cnnDocumentOnClickFunc;
					cnnDocumentOnClickFunc='';
					nodeToMod.style.visibility='hidden';
					cnnCurrDisplayBBinDhtmlStatus = 'hidden';
				}
				else
				{
					if(position) { nodeToMod.style.left = position;}
					nodeToMod.style.visibility='visible';
					cnnCurrDisplayBBinDhtmlStatus = 'visible';
					cnnDocumentOnClickFunc = document.onclick;
					cnnCurrDisplayBBinDhtmlMenuId = id;
					document.onclick = cnnCloseBBinDhtmlMenu;
				}
			}
		}
		
//navbar
function cnnSetHoverClass(obj, className, direction)
		{
			if(obj)
			{
				if(direction)
				{
					if(obj.className=='') {obj.className = className;}
				}
				else
				{
					if(obj.className==className) { obj.className = '';}
				}
			}
		}


// this function is used to redirect the search form if necessary
function validate( theFormValidate ) { return CNN_validateSearchForm( theFormValidate ); }
function CNN_validateSearchForm( theForm )
{
	var site = 'cnn';
	var queryString = '';
	
	if ( theForm.sites )
	{
		if ( theForm.sites.options ) {		//	"sites" should be a select
			site = theForm.sites.options[theForm.sites.selectedIndex].value;
		} else {
			if ( theForm.sites.length )
			{
				for ( i = 0; i < theForm.sites.length; i++ )
				{
					if ( theForm.sites[i].checked ) {
						site = theForm.sites[i].value;
					}
				}
			}
			else
			{
				site = theForm.sites.value;
			}
		}
	}
	
	if ( theForm.qt ) {
		queryString = theForm.qt.value;
	} else {
		if ( theForm.QueryText ) {
			queryString = theForm.QueryText.value;
		} else {
			if ( theForm.query ) {
				queryString = theForm.query.value;
			}
		}
	}
	
	if ( !queryString ) {
		return false;
	}
	
	switch ( site.toLowerCase() ) {
		case "web":
		case "google":
			theForm.action = ( location.hostname.indexOf( 'edition' ) != -1 ) ? "http://websearch.edition.cnn.com/websearch/search" : "http://websearch.cnn.com/websearch/search";
			theForm.query.value = queryString;
			return true;
		
		case "internet":
		case "cnnasiaweb":
		case "cnneuropeweb":
			theForm.action = "http://search.netscape.com/nscp_results.adp";
			theForm.query.value = queryString;
			return true;
		
		case "cnn":
			theForm.action = "http://search.cnn.com/cnn/search";
			theForm.query.value = queryString;
			return true;
			
		case "edition":
			theForm.action = "http://search.edition.cnn.com/pages/search/basic.jsp";
			return true;	
		
		case "cnnasia":
			theForm.action = "http://search.cnn.com/asia/search";
			theForm.query.value = queryString;
			theForm.source.value = 'cnn';
			return true;
		
		case "cnneurope":
		case "cnneuropeir":
		case "cnneuropeit":
		case "cnneuropenl":
		case "cnneuropeswz":
		case "cnneuropeuk":
			theForm.action = "http://search.cnn.com/europe/search";
			theForm.query.value = queryString;
			theForm.source.value = 'cnn';
			return true;
		
		case "cnnsi":
			theForm.action = "http://search.si.cnn.com/si/search";
			theForm.query.value = queryString;
			theForm.source.value = 'si';
			return true;
		
		case "cnnfn":
		case "cnnmoney":
			theForm.action = "http://search.money.cnn.com/money/search";
			theForm.query.value = queryString;
			theForm.source.value = 'money';
			return true;
		
		case "time":
			theForm.action = "http://www.pathfinder.com/time/daily/searchresults/1,2645,,00.html";
			theForm.keyword.value = queryString;
			theForm.col.value = 'time';
			return true;
		
		case "cnnfyi":
			theForm.action = "http://websearch.cnn.com/search/snsearch";
			theForm.source.value = 'fyi';
			return true;
		
		case "cnnlaw":
		default:
			return true;						//	unsupported site?
	}
}









function email()
{
	address=document.emailform.emailinput.value;
	location='http://www.cnn.com/EMAIL/index.html?'+address;
}

function splitWindow(s) 
{
	window.name="_mainWindow";
	var w=127;h=153;
	var v=navigator.appVersion.substring(0,1);
	if (navigator.appName=="Netscape")
	{
		if ((v==3)||(v==4)) {w=127,h=168;} 
		else {w=132,h=179;}
	} 
	else {w=112,h=137;}
	if (!s) s="*itn/ord";
	else if (s.indexOf("*,")!=-1) 
	s = s.substring(0,s.indexOf("*"))+"*itn/ord"+s.substring(s.indexOf(","));
	var f="http://cnn.com/event.ng/Type=click&RunID=17006&ProfileID=749&AdID=11567&GroupID=313&FamilyID=2433&TagValues=4.8.435.487.1098&Redirect=http:%2F%2Fwww.itn.net%2Fcgi%2Fget%3Fjava%2FFlightTicker%2FsplitWindow.html&Stamp="+s;
	var win=window.open(f,"ticker","status=0,scrollbars=0,resizable=0,width="+w+",height="+h);
}

//this is for the dropdowns on the pages like TRAVEL


function napVector (vectorChoice) {
	   location.href = document.nap.vector.options[document.nap.vector.selectedIndex].value;
	   }
function ipVector (vectorChoice) {
	   location.href = document.ip.vector.options[document.ip.vector.selectedIndex].value;
	   }


function CNN_setOptionsFromArray( selectOptions, array ) {
//	selectOptions = options reference -	document.forms['{formname}'].{selectname}.options
//								   or -	document.{formname}.{selectname}.options
//	array = Array - { 'text', 'value', 'text', 'value', ... }
	var length = selectOptions.length;
	var i = 0;
	if ( new Option() ) {
		length = 2;								//	start at the top
		for ( i = 0; i < array.length; i+=2 ) {
			selectOptions[length++] = new Option( array[i], array[i+1], false );
		}
	} else if ( document.createElement( "OPTION" ) ) {
		if ( selectOptions.length > 1 ) {
			for ( i = 2; i < selectOptions.length; i++ ) {
				selectOptions.remove( 2 );		//	strip off options because we add them later
			}
		}
		for ( i = 0; i < array.length; i+=2 ) {
			var newOption = document.createElement( "OPTION" );
			newOption.text = array[i];
			newOption.value = array[i+1];
			selectOptions.add( newOption );
		}
	}
}

// _________________________________________________________________________
// The following code was added to launch the 'change editions' popup.
// It checks first if it's able to set a cookie before launching the window.
function launchEditionPopup() {
	if ( ! WM_browserAcceptsCookies() ) {
		alert( "In order to set your default edition you must accept cookies." );
	} else {
		CNN_openPopup( EditionURL, 'defaultpopup', 'scrollbars=auto,width=' + EdPopWidth + ',height=' + EdPopHeight );
	}
}

function clickEdLink() {
	if ( document.cookie && ( document.cookie.indexOf( 'SelectedEdition' ) == -1 ) && ( location.pathname.substr( -4 ) != '.jsp' ) ) {
		launchEditionPopup();
	}
}

// Extend life of edition cookie
var editionCookie = WM_readCookie( 'SelectedEdition' );
if ( editionCookie == 'edition' ) {
	document.cookie = 'SelectedEdition=' + escape(editionCookie) + ';expires=' + new Date( '1/1/2037' ).toGMTString() + ';path=/;domain=' + EditionDomain;
}


// _____________________________________________________________ WebMonkey code
/*
WM_setCookie(), WM_readCookie(), WM_killCookie()
A set of functions that eases the pain of using cookies.

Source: Webmonkey Code Library
(http://www.hotwired.com/webmonkey/javascript/code_library/)

Author: Nadav Savio
*/

// This next little bit of code tests whether the user accepts cookies.
function WM_browserAcceptsCookies() {
	var WM_acceptsCookies = false;
	if ( document.cookie == '' ) {
		document.cookie = 'WM_acceptsCookies=yes'; // Try to set a cookie.
		if ( document.cookie.indexOf( 'WM_acceptsCookies=yes' ) != -1 ) {
			WM_acceptsCookies = true;
		} // If it succeeds, set variable
	} else { // there was already a cookie
		WM_acceptsCookies = true;
	}
	
	return ( WM_acceptsCookies );
}

function WM_setCookie( name, value, hours, path, domain, secure ) {
	if ( WM_browserAcceptsCookies() ) { // Don't waste your time if the browser doesn't accept cookies.
		var numHours = 0;
		var not_NN2 = ( navigator && navigator.appName
					&& (navigator.appName == 'Netscape')
					&& navigator.appVersion
					&& (parseInt(navigator.appVersion) == 2) ) ? false : true;

		if ( hours && not_NN2 ) { // NN2 cannot handle Dates, so skip this part
			if ( (typeof(hours) == 'string') && Date.parse(hours) ) { // already a Date string
				numHours = hours;
			} else if ( typeof(hours) == 'number' ) { // calculate Date from number of hours
				numHours = ( new Date((new Date()).getTime() + hours*3600000) ).toGMTString();
			}
		}
		
		document.cookie = name + '=' + escape(value) + ((numHours)?(';expires=' + numHours):'') + ((path)?';path=' + path:'') + ((domain)?';domain=' + domain:'') + ((secure && (secure == true))?'; secure':''); // Set the cookie, adding any parameters that were specified.
	}
} // WM_setCookie

function WM_readCookie( name ) {
	if ( document.cookie == '' ) { // there's no cookie, so go no further
	    return false;
	} else { // there is a cookie
	    var firstChar, lastChar;
		var theBigCookie = document.cookie;
		firstChar = theBigCookie.indexOf(name);	// find the start of 'name'
		var NN2Hack = firstChar + name.length;
		if ( (firstChar != -1) && (theBigCookie.charAt(NN2Hack) == '=') ) { // if you found the cookie
			firstChar += name.length + 1; // skip 'name' and '='
			lastChar = theBigCookie.indexOf(';', firstChar); // Find the end of the value string (i.e. the next ';').
			if (lastChar == -1) lastChar = theBigCookie.length;
			return unescape( theBigCookie.substring(firstChar, lastChar) );
		} else { // If there was no cookie of that name, return false.
			return false;
		}
	}	
} // WM_readCookie

function WM_killCookie( name, path, domain ) {
	var theValue = WM_readCookie( name ); // We need the value to kill the cookie
	if ( theValue ) {
		document.cookie = name + '=' + theValue + '; expires=Fri, 13-Apr-1970 00:00:00 GMT' + ((path)?';path=' + path:'') + ((domain)?';domain=' + domain:''); // set an already-expired cookie
	}
} // WM_killCookie


// ______________________________________________________________________ Apple
// Copyright � 2000 by Apple Computer, Inc., All Rights Reserved.

// initialize global variables
var detectableWithVB = false;
var pluginFound = false;


function canDetectPlugins() {
	if ( detectableWithVB || (navigator.plugins && navigator.plugins.length > 0) ) {
		return true;
	}
	return false;
}

function detectFlash() {
	pluginFound = detectPlugin( 'Shockwave', 'Flash' );
	// if not found, try to detect with VisualBasic
	if ( !pluginFound && detectableWithVB ) {
		pluginFound = detectActiveXControl( 'ShockwaveFlash.ShockwaveFlash.1' );
	}
	return pluginFound;
}

function detectDirector() {
	pluginFound = detectPlugin( 'Shockwave', 'Director' );
	// if not found, try to detect with VisualBasic
	if ( !pluginFound && detectableWithVB ) {
		pluginFound = detectActiveXControl( 'SWCtl.SWCtl.1' );
	}
	return pluginFound;
}

function detectQuickTime() {
	pluginFound = detectPlugin( 'QuickTime' );
	// if not found, try to detect with VisualBasic
	if ( !pluginFound && detectableWithVB ) {
		pluginFound = detectQuickTimeActiveXControl();
	}
	return pluginFound;
}

function detectReal() {
	pluginFound = detectPlugin( 'RealPlayer' );
	// if not found, try to detect with VisualBasic
	if ( !pluginFound && detectableWithVB ) {
		pluginFound = ( detectActiveXControl('rmocx.RealPlayer G2 Control') ||
			detectActiveXControl('RealPlayer.RealPlayer(tm) ActiveX Control (32-bit)') ||
			detectActiveXControl('RealVideo.RealVideo(tm) ActiveX Control (32-bit)')
		);
	}
	return pluginFound;
}

function detectRealOne() {
	pluginFound = detectPlugin( 'RealOne Player Version Plugin' ) || detectPlugin( 'RealPlayer Version Plugin' );
	// if not found, try to detect with VisualBasic
	if ( !pluginFound && detectableWithVB ) {
		pluginFound = detectRealOneActiveXControl();
	}
	return pluginFound;
}

function detectWindowsMedia() {
	pluginFound = detectPlugin( 'Windows Media' );
	// if not found, try to detect with VisualBasic
//	if ( !pluginFound && detectableWithVB ) {
//		pluginFound = detectActiveXControl( 'MediaPlayer.MediaPlayer.1' );
//	}
	if ( !pluginFound && detectWMPSupport() ) {
		pluginFound = true;
	}
	return pluginFound;
}

function detectWMPSupport(){

    var wmp64 = "MediaPlayer.MediaPlayer.1";
    var wmp7 = "WMPlayer.OCX.7";
    if((window.ActiveXObject && navigator.userAgent.indexOf('Windows') != -1) || window.GeckoActiveXObject)
    {
        if(createActiveXObject(wmp7)){ 
            return true;

        }else{
            if(createActiveXObject(wmp64)){
                return true;
            }else{
                return false;
            }
        }
    }else{ 
        return false;
    }
}

function createActiveXObject(id){
  var error;
  var control = null;

  try{
    if (window.ActiveXObject){
      control = new ActiveXObject(id);
    }else if (window.GeckoActiveXObject){
      control = new GeckoActiveXObject(id);
    }
  }
  catch (error){;}
  return control;
}

function detectPlugin() {
	// allow for multiple checks in a single pass
	var daPlugins = arguments;
	// consider pluginFound to be false until proven true
	var pluginFound = false;
	// if plugins array is there and not fake
	if ( navigator.plugins && navigator.plugins.length > 0 ) {
		var pluginsArrayLength = navigator.plugins.length;
		// for each plugin...
		for ( var pluginsArrayCounter = 0; pluginsArrayCounter < pluginsArrayLength; pluginsArrayCounter++ ) {
			// loop through all desired names and check each against the current plugin name
			var numFound = 0;
			for ( var namesCounter = 0; namesCounter < daPlugins.length; namesCounter++ ) {
				// if desired plugin name is found in either plugin name or description
				if ( (navigator.plugins[pluginsArrayCounter].name.indexOf(daPlugins[namesCounter]) >= 0) ||
					(navigator.plugins[pluginsArrayCounter].description.indexOf(daPlugins[namesCounter]) >= 0) ) {
					// this name was found
					numFound++;
				}
			}
			// now that we have checked all the required names against this one plugin,
			// if the number we found matches the total number provided then we were successful
			if ( numFound == daPlugins.length ) {
				pluginFound = true;
				// if we've found the plugin, we can stop looking through at the rest of the plugins
				break;
			}
		}
	}
	return pluginFound;
} // detectPlugin


// Here we write out the VBScript block for MSIE Windows
if ( (navigator.userAgent.indexOf('MSIE') != -1) && (navigator.userAgent.indexOf('Win') != -1) ) {
	document.writeln( '<script language="VBscript">' );

	document.writeln( '\'do a one-time test for a version of VBScript that can handle this code' );
	document.writeln( 'detectableWithVB = False' );
	document.writeln( 'If ScriptEngineMajorVersion >= 2 then' );
	document.writeln( '  detectableWithVB = True' );
	document.writeln( 'End If' );

	document.writeln( '\'this next function will detect most plugins' );
	document.writeln( 'Function detectActiveXControl( activeXControlName )' );
	document.writeln( '  on error resume next' );
	document.writeln( '  detectActiveXControl = False' );
	document.writeln( '  If detectableWithVB Then' );
	document.writeln( '     detectActiveXControl = IsObject( CreateObject( activeXControlName ) )' );
	document.writeln( '  End If' );
	document.writeln( 'End Function' );

	document.writeln( '\'and the following function handles QuickTime' );
	document.writeln( 'Function detectQuickTimeActiveXControl()' );
	document.writeln( '  on error resume next' );
	document.writeln( '  detectQuickTimeActiveXControl = False' );
	document.writeln( '  If detectableWithVB Then' );
	document.writeln( '    detectQuickTimeActiveXControl = False' );
	document.writeln( '    hasQuickTimeChecker = false' );
	document.writeln( '    Set hasQuickTimeChecker = CreateObject( "QuickTimeCheckObject.QuickTimeCheck.1" )' );
	document.writeln( '    If IsObject( hasQuickTimeChecker ) Then' );
	document.writeln( '      If hasQuickTimeChecker.IsQuickTimeAvailable( 0 ) Then ' );
	document.writeln( '        detectQuickTimeActiveXControl = True' );
	document.writeln( '      End If' );
	document.writeln( '    End If' );
	document.writeln( '  End If' );
	document.writeln( 'End Function' );

	document.writeln( '\'and the following function handles RealOne' );
	document.writeln( 'Function detectRealOneActiveXControl()' );
	document.writeln( '  on error resume next' );
	document.writeln( '  detectRealOneActiveXControl = False' );
	document.writeln( '  If detectableWithVB Then' );
	document.writeln( '    detectRealOneActiveXControl = False' );
	document.writeln( '    hasRealOneVersionPlugin = false' );
	document.writeln( '    Set hasRealOneVersionPlugin = CreateObject( "IERPCtl.IERPCtl.1" )' );
	document.writeln( '    If IsObject( hasRealOneVersionPlugin ) Then' );
	document.writeln( '      If hasRealOneVersionPlugin.RealPlayerVersion Then ' );
	document.writeln( '        detectRealOneActiveXControl = True' );
	document.writeln( '      End If' );
	document.writeln( '    End If' );
	document.writeln( '  End If' );
	document.writeln( 'End Function' );

	document.writeln( '<\/scr' + 'ipt>' );
}

// ________________________________________________________________ LaunchVideo


function LaunchVideo( videoPath ) {
	var videoDate = "";
	var cnnVideoDatePathRegExp = /(\d{4})\/(\d{2})\/(\d{2})/;
	var cnnVideoDatePathArray = cnnVideoDatePathRegExp.exec( videoPath );
	
	if ( cnnVideoDatePathArray )
	{
		var originalDate = new Date( parseInt( cnnVideoDatePathArray[1] ), parseInt( cnnVideoDatePathArray[2] ) - 1, parseInt( cnnVideoDatePathArray[3] ) );
		var expireDate = new Date( originalDate.getTime() + ( 7 * 24 * 60 * 60 * 1000 ) );
		var expireYear = new String( expireDate.getFullYear() );
		var expireMonth = new String( expireDate.getMonth() + 1 );
		var expireDay = new String( expireDate.getDate() );
		
		if ( expireMonth.length < 2 ) {
			expireMonth = '0' + expireMonth;
		}
		
		if ( expireDay.length < 2 ) {
			expireDay = '0' + expireDay;
		}
		
		videoDate = expireYear + '/' + expireMonth + '/' + expireDay;
	}
	
	cnnVideo( 'play', '/video' + videoPath.substring( 0, ( videoPath.length - 1 ) ), videoDate );
}

// _____________________________________________________ Netscape Hat

var NS_HAT_COOKIE_NAME = "nsHat";
var NS_HAT_COOKIE_HOURS = '';
var NS_HAT_COOKIE_PATH = "/";
var NS_HAT_COOKIE_DOMAIN = EditionDomain;

if ( !WM_readCookie( NS_HAT_COOKIE_NAME ) && document.referrer && WM_browserAcceptsCookies() )
{
	var referrerMatchArray = document.referrer.toLowerCase().match( "^[^:]+[:/]+([^@]+@)?([^:/]+)[:/]" );
	if ( referrerMatchArray && referrerMatchArray.length > 2 )
	{
		var referrerHostname = referrerMatchArray[2];
		if ( referrerHostname.match( "channels.netscape.com$" ) || referrerHostname.match( "cnn.netscape.cnn.com$" ) )
		{
			WM_setCookie( NS_HAT_COOKIE_NAME, "netscape", '', NS_HAT_COOKIE_PATH, NS_HAT_COOKIE_DOMAIN, '' );
		}
		else
		{
			WM_setCookie( NS_HAT_COOKIE_NAME, "cnn", '', NS_HAT_COOKIE_PATH, NS_HAT_COOKIE_DOMAIN, '' );
		}
	}
}

	
function displayHat()
{
	var imageDir = ( arguments.length > 0 ) ? ( '/' + arguments[0] + '/' ) : '/white/';
	var referrerHost = WM_readCookie( NS_HAT_COOKIE_NAME );
	switch ( referrerHost )
	{
		case "netscape":
			document.write( '<a href="/linkto/netscape_ref.html" target="new"><img src="http://i.a.cnn.net/cnn/.element/img/1.3/nshat' + imageDir + 'ns.logo.gif" width="77" height="18" hspace="0" vspace="0" border="0" style="padding-left:5px;"><\/a><a href="/linkto/netscape_ref.html" target="new"><img src="http://i.a.cnn.net/cnn/.element/img/1.3/nshat' + imageDir + 'ns.home.gif" width="61" height="18" hspace="0" vspace="0" border="0"><\/a><a href="/linkto/netscape_news.html" target="new"><img src="http://i.a.cnn.net/cnn/.element/img/1.3/nshat' + imageDir + 'ns.news.gif" width="61" height="18" hspace="0" vspace="0" border="0"><\/a><a href="/linkto/netscape_sports.html" target="new"><img src="http://i.a.cnn.net/cnn/.element/img/1.3/nshat' + imageDir + 'ns.sports.gif" width="61" height="18" hspace="0" vspace="0" border="0"><\/a><a href="/linkto/netscape_money.html" target="new"><img src="http://i.a.cnn.net/cnn/.element/img/1.3/nshat' + imageDir + 'ns.money.gif" width="61" height="18" hspace="0" vspace="0" border="0"><\/a>' );
			break;
		default:
			document.write( '<a href="/linkto/netscape.html" target="new"><img src="http://i.a.cnn.net/cnn/.element/img/1.3/nshat' + imageDir + 'ns.logo.standalone.gif" width="77" height="18" hspace="0" vspace="0" border="0" class="cnnCeilImg"><\/a>' );
			break;
	}
}


// _____________________________________________________ Member services welcome
function CNN_returnUserName(cnnCookieName) {
	var CNN_userName = WM_readCookie(cnnCookieName);
		if (CNN_userName) {
			if (location.hostname.indexOf('edition.') > -1) {
				document.write('Welcome, '+CNN_userName+ ': <a href="http://audience.cnn.com/services/intl/memberservices/regwall/member_profile.jsp?source=intl">Member Center</a> | <a href="http://audience.cnn.com/services/intl/memberservices/member_logout.jsp?source=intl">Sign Out</a>');			
			} else {
				document.write('Welcome, '+CNN_userName+ ': <a href="http://audience.cnn.com/services/cnn/memberservices/regwall/member_profile.jsp?source=cnn">Member Center</a> | <a href="http://audience.cnn.com/services/cnn/memberservices/member_logout.jsp?source=cnn">Sign Out</a>');
			}
		} else {
			if (location.hostname.indexOf('edition.') > -1) {
				document.write('Member Center: <a href="http://audience.cnn.com/services/intl/memberservices/regwall/member_profile.jsp?source=intl">Sign In</a> | <a href="http://audience.cnn.com/services/intl/memberservices/member_register.jsp?pid=&source=intl&url=http%3A%2F%2Faudience.cnn.com%2Fservices%2Fintl%2Fmemberservices%2Fregwall%2Fmember_profile.jsp%3Fsource%3Dintl">Register</a>');			
			} else {
				document.write('Member Center: <a href="http://audience.cnn.com/services/cnn/memberservices/regwall/member_profile.jsp?source=cnn">Sign In</a> | <a href="http://audience.cnn.com/services/cnn/memberservices/member_register.jsp?pid=&source=cnn&url=http%3A%2F%2Faudience.cnn.com%2Fservices%2Fcnn%2Fmemberservices%2Fregwall%2Fmember_profile.jsp%3Fsource%3Dcnn">Register</a>');
			}
		}
}

// _____________________________________________________ Pipeline

function cnnDetectCNNPipeLine() {
	
	if( detectPlugin( 'CNN Pipeline') ) { return 1;}
    
	if((window.ActiveXObject && navigator.userAgent.indexOf('Windows') != -1) || window.GeckoActiveXObject) {
       	if(createActiveXObject('PipelineLauncherX.PipelineLauncherCom.1') || createActiveXObject('CNNPipelineLauncherX.PipelineLauncherCom.1')){ return 2;}
	}
	
	return 0;

}

var CNN_Player_Pref;
var CNN_Stream_Name;
var CNN_req_Premium_Auth;
var cnnHasCNNPL = cnnDetectCNNPipeLine();
var CNN_FreePassDate = new Date(2006,10,6);
var CNN_FreePassURL = '/linkto/pipeline/preview.html';

		
if(!document.getElementById('cnnPipelineLauncher')) {

	if(cnnHasCNNPL==2) {
		document.write('<OBJECT ID="cnnPipelineLauncher" height="0" width="0" CLASSID="CLSID:BB815F16-1FF7-4DF1-87EE-68381DC3FDC2"></OBJECT>');
	}
	else if(cnnHasCNNPL == 1) {
	
		document.write('<embed type="application/x-vnd-cnn-pipeline" width="0" id="cnnPipelineLauncher" height="0" hidden="true">');
		if(document.getElementById) { var cnnFFTest = document.getElementById('cnnPipelineLauncher');}

	}

}

function cnnLaunchFreePlayer(mode, arg, expiration) {

	var playerURL    = '/video/player/player.html';
	var detectURL    = '/video/player/detect.exclude.html';
	var predetectURL = '/video/player/predetect.exclude.html';
	var noplugURL    = '/video/player/pages/detection/noplugin.html';
	var expireURL    = '/video/player/player.html';
	var openURL      = detectURL;
	var cnnVideoArgs = '';
	var dl_arg = '';
	var dl_mode = '';
	
	var usePipeLinePlayer = cnnDetectCNNPipeLine();

	if (detectWindowsMedia()) {
		var cnnPassedDetection = new String( WM_readCookie( 'cnnVidPlug' ) ).toLowerCase();
		if ( cnnPassedDetection == "activex" || cnnPassedDetection == "native" ) {
			openURL = playerURL;
		}
	}
	else {
		openURL = noplugURL;
	}

	switch ( mode )	{

		case 'play':

			var cnnExpireDate = new Date( new Date().getTime() - 24*60*60*1000 );
			var dateStringRegExp = /^(\d{4})\/(\d{2})\/(\d{2})$/;
			var dateStringArray = dateStringRegExp.exec( expiration );
						
			if ( dateStringArray && expiration)
			{
				cnnExpireDate = new Date( dateStringArray[1], dateStringArray[2] - 1, dateStringArray[3] );
			} else {
				cnnExpireDate = cnnSiteWideCurrDate;
			}
					
			if ( cnnExpireDate.getTime() < cnnSiteWideCurrDate.getTime() )
			{
				if ( cnnPassedDetection == "activex" || cnnPassedDetection == "native" )
				{
						openURL = expireURL;
				}
				else {
						openURL = detectURL;
				}				
				cnnVideoArgs = 'url=/video/player/static/404'
				CNN_req_Premium_Auth = true;

			}
			else
			{
				cnnVideoArgs = 'url=' + arg;
			}
			dl_mode = 'vod';
			dl_arg = '&video=' + arg;
			break;
		
		case 'browse':
			cnnVideoArgs = 'section=' + arg;
			break;
			
		case 'live':
			cnnVideoArgs = 'url=/video/player/static/404'
			CNN_req_Premium_Auth = true;
			dl_mode = 'live';
			dl_arg = '&stream=' + arg;
			break;

		default:
			cnnVideoArgs = 'section=/ALL';
			break;
			
	}
	
	if(((window.location.hostname.indexOf('search.cnn.com')>-1)||(window.location.hostname.indexOf('audience.cnn.com')>-1)) && (openURL.indexOf('http://')==-1) ) {
		openURL='http://www.cnn.com'+openURL;
	}	
	
	if(CNN_req_Premium_Auth) {
		
		top.location.href = "/pr/pipeline/download.html?mode=" + dl_mode + dl_arg;
		
	}
	else { 
	
		CNN_openPopup( openURL+'?'+cnnVideoArgs, 'CNNVideoPlayer', 'scrollbars=no,resizable=no,width=770,height=570' );
		
	}

}

function cnnLaunchWebPlayer(mode, arg, expiration) {
	var cnnFreePreview = (cnnSiteWideCurrDate.getTime() == CNN_FreePassDate.getTime() && !WM_readCookie('CNN_Player_Pref')) ? true : false;
	var wp_height = (cnnFreePreview) ? '646' : '604';
	var playerURL = (cnnFreePreview) ? CNN_FreePassURL : '/pr/video/portable/player.html';
	if(!WM_readCookie('oneaday') && (WM_readCookie('CNN_Player_Pref') != 'web_based')) {
		playerURL = '/video/portable/promoplayer.html';
		wp_height = '646';
	}	

	var openURL      = playerURL;
	var cnnVideoArgs = '';

	switch ( mode )	{

		case 'play':
			cnnVideoArgs = 'mode=vod&video=' + arg;
			break;
		
		case 'browse':
			cnnVideoArgs = 'mode=browse&section=' + arg + '&sectionDir=' + arg.toLowerCase();
			break;
			
		case 'live':
			cnnVideoArgs = 'mode=live&stream=' + arg;
			break;

		default:
			cnnVideoArgs = 'section=/ALL';
			break;
			
	}

	cnnVideoArgs += '&source=pop/';
	
	CNN_openPopup( openURL+'?'+cnnVideoArgs, 'CNNWebPlayer', 'scrollbars=no,resizable=no,width=804,height='+wp_height);

}

function cnnLaunchPipelineApp(mode, arg, expiration) {
	
	var pipelineLaunchObj = document.getElementById('cnnPipelineLauncher');
	var launchFree = false;
	
	if(!pipelineLaunchObj) { launchFree = true; }
	if(pipelineLaunchObj && pipelineLaunchObj.CanLaunch("web")!=true) {
		launchFree = true;
	}
	
	if(launchFree) {
		
		cnnLaunchFreePlayer(mode, arg, expiration);
	
	}
	else {
	
		if(WM_readCookie('CNN_Stream_Name')) {
			CNN_Stream_Name = WM_readCookie('CNN_Stream_Name');
		}
		else {
			CNN_Stream_Name = '';
		}
		
		switch ( mode )	{
			
			case 'play':
				var cmd = '<commands><command name="playVOD">http://premium.cnn.com/pr'+arg+'/video.ws.asx</command></commands>';
				pipelineLaunchObj.Launch(cmd,'');
				break;
		
			case 'browse':
				pipelineLaunchObj.Launch('<commands><command name="changeMode">MaxMode</command><command name="changeTab">BrowseVideo</command><command name="playLive">pipeline_1</command></commands>','');
				break;
			
			case 'live':
				pipelineLaunchObj.Launch('<commands><command name="changeMode">MaxMode</command><command name="playLive">pipeline_' + arg + CNN_Stream_Name + '</command></commands>','');
				break;

			default:
				pipelineLaunchObj.Launch('<commands><command name="changeMode">MaxMode</command><command name="changeTab">BrowseVideo</command><command name="playLive">pipeline_1</command></commands>','');
				break;
		
		}

	}
	
}

function cnnLaunchPreviewWebPlayer(mode, arg, expiration)
{
        var launchFreePlayer = true;
        if(cnnSiteWideCurrDate.toUTCString() == CNN_FreePassDate.toUTCString())
        {
               if(mode=='live') {launchFreePlayer = false;}
               else if(mode=='play')
                {
                        var cnnExpireDate = new Date( new Date().getTime() - 24*60*60*1000 );
                       var dateStringRegExp = /^(\d{4})\/(\d{2})\/(\d{2})$/;
                       var dateStringArray = dateStringRegExp.exec( expiration );                
                       if ( dateStringArray && expiration)
                       {
                              cnnExpireDate = new Date( dateStringArray[1], dateStringArray[2] - 1, dateStringArray[3] );

                              if ( cnnExpireDate.getTime() < cnnSiteWideCurrDate.getTime() )
                              {
                                      launchFreePlayer = false;
                              }
                       }                      
               }
        }
        return launchFreePlayer;
}

function cnnValVidModExp(mode, arg, expiration)
{
        var launchFreePlayer = true;
        
		if(mode=='live') { launchFreePlayer = false;}
        else if(mode=='play')
        {
                var cnnExpireDate = new Date( new Date().getTime() - 24*60*60*1000 );
                var dateStringRegExp = /^(\d{4})\/(\d{2})\/(\d{2})$/;
                var dateStringArray = dateStringRegExp.exec( expiration );                
                if ( dateStringArray && expiration)
                {
                     cnnExpireDate = new Date( dateStringArray[1], dateStringArray[2] - 1, dateStringArray[3] );

                     if ( cnnExpireDate.getTime() < cnnSiteWideCurrDate.getTime() )
                     {
                          launchFreePlayer = false;
                     }
                
				}                      
         }
		
		return launchFreePlayer;
}


function cnnVideo(mode, arg, expiration) {
	var pipelineLauncher = document.getElementById( "cnnPipelineLauncher" );
	var CNN_convertArg = (mode == 'browse' && arg == '/mostwatched') ? true : false;
	var CNN_PipelineArg = (CNN_convertArg) ? '/ALL' : arg; 


	var usePipeLinePlayer = cnnDetectCNNPipeLine();
 	CNN_Player_Pref = WM_readCookie('CNN_Player_Pref');
 
	if(usePipeLinePlayer) {
 
		if (pipelineLauncher && (typeof(pipelineLauncher.CanLaunch) != "undefined") && pipelineLauncher.CanLaunch("web")) {
			CNN_Player_Pref = 'app_based';
		}
 	
	}
 
	if (CNN_Player_Pref == 'app_based') {
		cnnLaunchPipelineApp(mode, CNN_PipelineArg, expiration); 
	}
	else {
		
		if (CNN_Player_Pref == 'web_based') {
			cnnLaunchWebPlayer(mode, CNN_PipelineArg, expiration);
		}
		else {
			
			if(!WM_readCookie('oneaday') && !cnnValVidModExp(mode, arg, expiration)) {
				cnnLaunchWebPlayer(mode,  CNN_PipelineArg, expiration);
			}
			else if ( !cnnLaunchPreviewWebPlayer(mode, arg, expiration)) { 
				cnnLaunchWebPlayer(mode,  CNN_PipelineArg, expiration);
			}
			else {
				cnnLaunchFreePlayer(mode, arg, expiration); 
			}
		
		}
		
 	 }
	 
}

// _________________________________________________________________________
// select your edition popup
var EditionURL = '/virtual/editions/europe/2000/roof/change.pop/frameset.exclude.html';  // URL for editions popup HTML
var EdPopWidth = 300;	// Width of popup window
var EdPopHeight = 300;	// Height for popup window

var CNN_Url_Params = {};

function CNN_get_Vars () {

		var vals = location.search.substring(1, location.search.length).split("&");
		var val;
		var i = vals.length;
		
		while(i--) {

			val = vals[i].split("=");
			CNN_Url_Params[val[0]] = val[1];

		}
			
}

CNN_get_Vars();

if ( document.cookie && ( document.cookie.indexOf( 'SelectedEdition' ) == -1 ) && ( location.pathname.substr( -4 ) != '.jsp' ) && (CNN_Url_Params['ref'] != "google") ) {
	CNN_openPopup( EditionURL, "AdInterstitial", "scrollbars=auto,width="+EdPopWidth+",height="+EdPopHeight );
}

// _____________________________________________________ Tabbes video box

function showTab(tabId, tabNo)
{
	var tabCollection = document.getElementById(tabId);
	tabCollection.className='cnnTab'+tabNo+'Visible';
}

// _____________________________________________________ Tabbed Market box on Intl
var cnnIntlMarketsBoxArray = new Array();
cnnIntlMarketsBoxArray[1] = 'cnnAsiaMarketsBox';
cnnIntlMarketsBoxArray[2] = 'cnnEuropeMarketsBox';
cnnIntlMarketsBoxArray[3] = 'cnnUSAMarketsBox';
	
var cnnIntlMarketsTabArray = new Array();
cnnIntlMarketsTabArray[1] = 'cnnIntlMarketsBoxAsiaTab';
cnnIntlMarketsTabArray[2] = 'cnnIntlMarketsBoxEuropeTab';
cnnIntlMarketsTabArray[3] = 'cnnIntlMarketsBoxUSATab';
	
function cnnIntlSwitchMarkets(object) {	
	if (document.getElementById) {
		for (var i=1;i<=cnnIntlMarketsBoxArray.length-1;i++){
			if (object == i) { //show and set link to active state
				if (document.getElementById(cnnIntlMarketsBoxArray[i])) {
					document.getElementById(cnnIntlMarketsBoxArray[i]).style.display = 'block';
				}
				if(document.getElementById(cnnIntlMarketsTabArray[i])) {
					document.getElementById(cnnIntlMarketsTabArray[i]).className = "cnnIntlBixBoxCurrentSelection";
				}				
			} else { //hide and set link to non-active state
				if (document.getElementById(cnnIntlMarketsBoxArray[i])) {				
					document.getElementById(cnnIntlMarketsBoxArray[i]).style.display = 'none';
				}
				if(document.getElementById(cnnIntlMarketsTabArray[i])) {
					document.getElementById(cnnIntlMarketsTabArray[i]).className = "";
				}	
			}
		}	
	}
}

//Domestic main page show strip
function cnnShowImgSwap( strId, intSwap ) {
	// assumes 2 images: image.gif and image_over.gif
	var imgObj = document.getElementById( strId );
	var strTemp = imgObj.src;
	var intStrLength = strTemp.length;
	var intChop, strEnd; 
	
	if ( intSwap ) {
		if (strTemp.indexOf('_over.gif') == -1) {
			intChop = intStrLength - 4;	
			strEnd = '_over.gif';
		}
	} else {
		if (strTemp.indexOf('_over.gif') > -1) {	
			intChop = intStrLength - 9;	
			strEnd = '.gif';
		}
	}
	
	if (typeof(intChop) != "undefined") {
		strTemp = strTemp.substring( 0, intChop );
	}
	
	if (typeof(strEnd) != "undefined") {
		imgObj.src = strTemp + strEnd;
	}	
}

function cnnPreloadImages() {
	var myimages = new Array();
	for (i=0; i < cnnPreloadImages.arguments.length; i++){
		myimages[i]=new Image();
		myimages[i].src = cnnPreloadImages.arguments[i];
	}
}

/*__________________________________ restyling 2.0 */
function CNN_navHor( tableCellRef, hoverFlag, navStyle ) {
	if ( hoverFlag ) {
		switch ( navStyle ) {
			case 1:
				tableCellRef.style.backgroundColor = '#8ebae5';
				break;
			default:
				if ( document.getElementsByTagName ) {
					tableCellRef.getElementsByTagName( 'a' )[0].style.color = '#fff';
				}
		}
	} else {
		switch ( navStyle ) {
			case 1:
				tableCellRef.style.backgroundColor = '#37618d';
				break;
			default:
				if ( document.getElementsByTagName ) {
					tableCellRef.getElementsByTagName( 'a' )[0].style.color = '#fff';
				}
		}
	}
}

function cnnImgSwap( strId, intSwap ) {
	cnnShowImgSwap( strId, intSwap );
}

function cnn_checkPipeLineIconParent(id) {
if(id) {
	id.onload = function() {} //don't try it again
	if (id.parentNode && id.parentNode.parentNode && (id.parentNode.className == "cnnT1Bullets" || id.parentNode.parentNode.className == "cnnT1Bullets")) {
		id.src = "http://i.a.cnn.net/cnn/.element/img/1.5/main/icons/pipeline_ico_blu.gif";
	} else {
		id.src = "http://i.a.cnn.net/cnn/.element/img/1.5/main/icons/pipeline_ico_wht.gif";
	}
}
}	
	
function cnnInsertPipelineIcon() {
	var cnnPipelineIconId = (Math.round(Math.random()*(10000-1))+1);
	document.write('<img src="http://i.a.cnn.net/cnn/images/1.gif" width="40" height="10" border="0" hspace="3" alt="Live" class="cnnPipelineIcon" id="'+cnnPipelineIconId+'" onload="cnn_checkPipeLineIconParent(this)">');
}	

var PipelineButton = new Image();
	PipelineButton.src = "http://i.cnn.net/cnn/.element/img/1.5/ceiling/nav_pipeline_dkblue.gif";
var PipelineButtonOver = new Image();
	PipelineButtonOver.src = "http://i.cnn.net/cnn/.element/img/1.5/ceiling/nav_pipeline_ltblue.gif";

	
/* intl tab boxes */
function cnnIntlChangeTabBox(strBoxId, intWhichTab) {
	var boxObj = document.getElementById(strBoxId);
	var nestedDivs = boxObj.getElementsByTagName('div');
	var nestedImgs = boxObj.getElementsByTagName('img');
	var containerObj = boxObj.parentNode;
	var containerDivs = containerObj.getElementsByTagName('div');
	var boolLS;
	if(document.body.id == 'cnnMainPageLS') {
		boolLS = true;
	}
	else {
		boolLS = false;
	}
	
	for(i=0;i<containerDivs.length;i++) { // set containerDiv indexes
		if(containerDivs[i].id == "cnnTabContentOne") { var contentIndex1 = i; }
		if(containerDivs[i].id == "cnnTabContentTwo") { var contentIndex2 = i; }	
	}
	
	// swap background image sprite pos
	if(!boolLS) { // page is not in landscape, box is 371 (not 354px)
		if(intWhichTab == 1) {
			boxObj.style.backgroundPosition = "0 -28px";
		}
		else {
			boxObj.style.backgroundPosition = "0 -1";
		}
	}
	else {
		if(intWhichTab == 1) {
			boxObj.style.backgroundPosition = "0 -86px";
		}
		else {
			boxObj.style.backgroundPosition = "0 -59px";
		}
	}
	// change the active class & display/hide content
	switch(intWhichTab) {
		case 0: //user clicked on tab 1
			nestedDivs[0].className = "active";
			nestedDivs[1].className = "";

			containerDivs[contentIndex2].style.display = "none";
			containerDivs[contentIndex1].style.display = "block";			
			break;
		
		case 1: //user clicked on tab 2
			nestedDivs[0].className = "";
			nestedDivs[1].className = "active";

			containerDivs[contentIndex2].style.display = "block";
			containerDivs[contentIndex1].style.display = "none";			
			break;
	}

	// swap the image label
	for (i=0;i<nestedImgs.length;i++) {
		if(nestedImgs[i].id) {
			if (i == intWhichTab) {
				cnnImgSwap(nestedImgs[i].id,1);
			} else {
				cnnImgSwap(nestedImgs[i].id);
			}
		}
	}
	
	// append the onmouseover, onmouseout
	for(i=0;i<nestedImgs.length;i++) {
		var parentObj = nestedImgs[i].parentNode;
		if(intWhichTab != i) {
			parentObj.onmouseover = function() { cnnTabBoxDivMouseOver(this); }
			parentObj.onmouseout = function() { cnnTabBoxDivMouseOut(this); }
		}
		else {
			parentObj.onmouseout = function() {}
			parentObj.onmouseover = function() {}
		}
	}	
}

function cnnTabBoxDivMouseOver(whichDiv) {
	if(whichDiv.childNodes[0]) {
		if(whichDiv.childNodes[0].nodeName.toLowerCase() == 'img') {
			var strSrc = whichDiv.childNodes[0].src;
			if (strSrc.indexOf('_over.gif') == -1) {
				intChop = strSrc.length - 4;	
				strEnd = '_over.gif';
			}
			if (typeof(intChop) != "undefined") {
				newSrc = strSrc.substring( 0, intChop );
			}
			if (typeof(strEnd) != "undefined") {
				whichDiv.childNodes[0].src = newSrc + strEnd;
			}
		}
	}
}

function cnnTabBoxDivMouseOut(whichDiv) {
	if(whichDiv.childNodes[0]) {
		if(whichDiv.childNodes[0].nodeName.toLowerCase() == 'img') {
			var strSrc = whichDiv.childNodes[0].src;
			if (strSrc.indexOf('_over.gif') > -1) {	
				intChop = strSrc.length - 9;	
				strEnd = '.gif';
			}
			if (typeof(intChop) != "undefined") {
				newSrc = strSrc.substring( 0, intChop );
			}
			if (typeof(strEnd) != "undefined") {
				whichDiv.childNodes[0].src = newSrc + strEnd;
			}
		}
	}
}

function cnnGetHiddenOffsetHeight(id) {
	/* finds the height of a layer set to display:none by setting a high
	   margin and setting back - note that this will reset a top 
	   margin if already set */
	document.getElementById(id).style.marginTop = -2000;
	document.getElementById(id).style.display = "block";
	height = document.getElementById(id).offsetHeight;
	document.getElementById(id).style.display = "none";
	document.getElementById(id).style.marginTop = 0;
	return height;
}

function cnnSetTabHeight(idOne, idTwo) {
	/* sets divs under cnn tabs to same height 
	   must be called onload or divs wont have height value yet */
	var heightTwo = cnnGetHiddenOffsetHeight(idTwo);
	if(heightTwo) {
		var offset = 4;		// pixels difference depending on which tab is being set
		var heightOne;		// height of T2 div
		var newHeight;		// tallest of the two divs
		var shortDivId;		// div that needs its height set
		
		heightOne = document.getElementById(idOne).offsetHeight;
		
		if(heightOne > heightTwo) {	// we're setting most popular tab to the height of the T2s
			newHeight = heightOne;
			shortDivId = idTwo;
		}
		else {						// we're setting T2s to the height of most popular
			newHeight = heightTwo;
			shortDivId = idOne;
			if ( (navigator.userAgent.indexOf('MSIE') != -1) && (navigator.userAgent.indexOf('Win') != -1) ) {
				offset = 4;
			}
			else { // non-ie browsers don't require an offset here
				offset = 0;
			}
		}
		
		if((newHeight)&&(shortDivId)) {
			// make the height change
			var intChange = newHeight + offset;
			document.getElementById(shortDivId).style.height = intChange + 'px';
		}
	}
}
/* end intl tab boxes */


//CSI functions
var cnnCSIs = new Array();
var cnnUseDelayedCSI = 0;
var localUserAgent = navigator.userAgent.toLowerCase();
if((localUserAgent.indexOf('msie')>-1) && (localUserAgent.indexOf('mac')>-1)){cnnUseDelayedCSI = 1;}

function cnnAddCSI(id,source,args,breakCache)
{
	if(!args) { args='';}
	breakCache = ( !breakCache && ( source.charAt( 0 ) == '/' ) ) ? false : true;
	if(cnnUseDelayedCSI)
	{
		var newCSI = new Object();
		newCSI.src = source;
		newCSI.id  = id;
		newCSI.args = args;
		newCSI.breakCache = breakCache;
		cnnCSIs[cnnCSIs.length]=newCSI;
	}
	else
	{
		var today = new Date();
		var currTime = today.getTime();
		var iframeArgs = ( breakCache ) ? '&time='+currTime : '';
		if(args)
		{
			iframeArgs=iframeArgs+'&'+args;
		}
		var iframeHtmlSrc='<iframe src="'+source+'?domId='+id+iframeArgs+'" name="iframe'+id+'" id="iframe'+id+'" width="0" height="0" align="right" style="visibility:hidden"></iframe>';
		document.write(iframeHtmlSrc);
	}
}

function cnnUpdateCSI(html, id)
{
	var htmlContainerObj = document.getElementById( id ) || document.all[ id ];
	if(htmlContainerObj)
	{
		htmlContainerObj.innerHTML = html;
	}
	//force a refresh of the content area
	var htmlContentArea = 0;//document.body;
	if(htmlContentArea)
	{
		var previousTopVal = htmlContentArea.style.top || '0px';
		htmlContentArea.style.top = '1px';
		htmlContentArea.style.top = previousTopVal;
	}
}

function cnnHandleCSIs()
{

	if(document.getElementById) { var cnnFFTest = document.getElementById('cnnPipelineLauncher'); }

	if(document.body && document.body.innerHTML && cnnUseDelayedCSI)
	{
		var iframeOwner = document.getElementById( 'csiIframe' ) || document.all[ 'csiIframe' ];
		var iframeHtmlSrc = '';
		
		for(var incCounter=0;incCounter<cnnCSIs.length;incCounter++)
		{
			var src = cnnCSIs[incCounter].src;
			var id = cnnCSIs[incCounter].id;
			var today = new Date();
			var breakCache = cnnCSIs[incCounter].breakCache;
			var currTime = today.getTime();
			var args = ( breakCache ) ? '&time='+currTime : '';
			if(cnnCSIs[incCounter].args)
			{
				args=args+'&'+cnnCSIs[incCounter].args;
			}
			
			iframeHtmlSrc+='<iframe src="'+src+'?domId='+id+args+'" name="iframe'+id+'" id="iframe'+id+'" width="0" height="0" align="right"></iframe>';
		}
		if(iframeOwner)
		{
			iframeOwner.innerHTML=iframeHtmlSrc;
		
		}
	}
}

var cnnEnableCL = true;
var cnnEnableSectionCL = true;
if(window.location.hostname.indexOf('cnnstudentnews.')>-1) { cnnEnableCL = false; }
if(location.hostname.indexOf('edition.')>-1 || location.port=='94') { cnnEnableCL = false; }
// End CSI functions

// end

var cnnDocDomain = '';
if(location.hostname.indexOf('cnn.com')>0) {cnnDocDomain='cnn.com';}
if(location.hostname.indexOf('turner.com')>0) {if(document.layers){cnnDocDomain='turner.com:'+location.port;}else{cnnDocDomain='turner.com';}}
if(cnnDocDomain) {document.domain = cnnDocDomain;}
// DO NOT PUT ANYTHING BENEATH THIS!
