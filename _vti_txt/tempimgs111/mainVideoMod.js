// Kenny's FSCommand

function runJSCommand(args)
{
	eval(args);
}

if (navigator.appName && 
	navigator.appName.indexOf("Microsoft") != -1 && 
	navigator.userAgent.indexOf("Windows") != -1 &&
	navigator.userAgent.indexOf("Windows 3.1") == -1) 
{
	document.write('<SCRIPT LANGUAGE=VBScript\> \n');
	document.write('on error resume next \n');
	document.write('Sub pipeline_FSCommand(ByVal command, ByVal args)\n');
	document.write(' call runJSCommand(args)\n');
	document.write('end sub\n');
	document.write('<\/SCRIPT\> \n');
} 

var VBS_Result = false;

function CNN_FlashDetect() { }

CNN_FlashDetect.prototype.maxVersionToDetect = 8;
CNN_FlashDetect.prototype.minVersionToDetect = 3;

CNN_FlashDetect.prototype.hasPlugin = Boolean( Boolean(navigator.mimeTypes) &&
		navigator.mimeTypes.length &&
		Boolean(navigator.mimeTypes["application/x-shockwave-flash"]) &&
		navigator.mimeTypes["application/x-shockwave-flash"].enabledPlugin );

CNN_FlashDetect.prototype.hasActiveX = Boolean( Boolean(window.ActiveXObject) &&
		typeof ActiveXObject != "undefined" );

CNN_FlashDetect.prototype.hasWinIE = Boolean( Boolean(navigator.userAgent) &&
		( navigator.userAgent.indexOf( "MSIE" ) != -1 ) &&
		Boolean(navigator.appVersion) &&
		( navigator.appVersion.indexOf( "Win" ) != -1 ) );

CNN_FlashDetect.prototype.getVersion = function () {
	var versionNum = 0;
	var i = 0;

	if ( this.hasPlugin ) {
		if ( Boolean(navigator.plugins) && navigator.plugins.length && Boolean(navigator.plugins["Shockwave Flash"]) ) {
			var words = navigator.plugins["Shockwave Flash"].description.split( " " );
			for ( i = 0; i < words.length; ++i ) {
				if ( isNaN( parseInt( words[i] ) ) )
					continue;
				versionNum = parseInt( words[i] );
			}
		}
	} else if ( this.hasActiveX ) {
		var activeXObject = false;
		for ( i = this.maxVersionToDetect; i >= this.minVersionToDetect && !activeXObject; versionNum = ( activeXObject ? i : versionNum ), i-- ) {
			try {
				activeXObject = new ActiveXObject( "ShockwaveFlash.ShockwaveFlash." + i );
			} catch( e ) {
				// do nothing
			}
		}
	} else if ( this.hasWinIE ) {
		VBS_Result = false;
		for ( i = this.maxVersionToDetect; i >= this.minVersionToDetect && !VBS_Result; versionNum = ( VBS_Result ? i : versionNum ), i-- ) {
			execScript( 'on error resume next: VBS_Result = IsObject( CreateObject( "ShockwaveFlash.ShockwaveFlash.' + i + '" ) )', 'VBScript' );
		}
	}

	return ( versionNum );
}

CNN_FlashDetect.prototype.detectVersion = function ( num ) {
	var isVersionSupported = false;
	if ( ! isNaN( num ) ) {
		isVersionSupported = ( this.getVersion() >= parseInt( num ) );
	}
	return ( isVersionSupported );
}


function CNN_FlashObject( p_name, p_src, p_width, p_height, p_parameters, p_flashVars ) {
	this.m_name			= p_name;
	this.m_src			= p_src;
	this.m_width		= p_width;
	this.m_height		= p_height;
	this.m_flashVars	= p_flashVars;

// constructor
	if ( Boolean(p_parameters) )
	{
		this.setParams( p_parameters );
	}
}

// Declare member properties
CNN_FlashObject.prototype.m_name = '';
CNN_FlashObject.prototype.m_src = '';
CNN_FlashObject.prototype.m_width = '100%';
CNN_FlashObject.prototype.m_height = '100%';
CNN_FlashObject.prototype.m_flashVars = '';

CNN_FlashObject.prototype.m_params = {
	menu:		"false",
	quality:	"high",
	wmode:		"transparent"
};

CNN_FlashObject.prototype.setParam = function ( p_name, p_value ) {
	this.m_params[ p_name.toLowerCase() ] = p_value;
}

CNN_FlashObject.prototype.setParams = function ( p_paramHash ) {
	if ( typeof p_paramHash == "object" ) {
		for ( var param in p_paramHash ) {
			if ( p_paramHash[param] ) {
				this.setParam( param, p_paramHash[param] );
			}
		}
	}
}

CNN_FlashObject.prototype.getParam = function ( p_name ) {
	return ( this.m_params[ p_name.toLowerCase() ] );
}

CNN_FlashObject.prototype.getParams = function () {
	return ( this.m_params );
}

CNN_FlashObject.prototype.getFlashVarsString = function () {
	var flashVarsString = '';

	if ( typeof this.m_flashVars == "string" ) {
		flashVarsString = this.m_flashVars;
	} else if ( typeof this.m_flashVars == "object" ) {
		for ( var flashVar in this.m_flashVars ) {
			if ( flashVarsString != '' ) {
				flashVarsString += "&amp;";
			}
			flashVarsString += flashVar + "=" + escape( this.m_flashVars[flashVar] );
		}
	}

	return ( flashVarsString );
}

CNN_FlashObject.prototype.getAttributeString = function ( p_attr, p_value ) {
	return ( Boolean(p_value) ? ' ' + p_attr + '="' + p_value + '"' : '' );
}

CNN_FlashObject.prototype.getParamTag = function ( p_name, p_value ) {
	return ( Boolean(p_value) ? '<param name="' + p_name + '" value="' + p_value + '">' : '' );
}

CNN_FlashObject.prototype.getHtml = function () {
	var htmlString = '';
	var eachParam = '';
	var flashUrl = 'http://www.macromedia.com/go/getflashplayer';

// open object
	htmlString += '<object type="application/x-shockwave-flash" \
					classid="clsid:D27CDB6E-AE6D-11cf-96B8-444553540000"';
	htmlString += this.getAttributeString( 'pluginspage', flashUrl );
	htmlString += this.getAttributeString( 'id', this.m_name );
	htmlString += this.getAttributeString( 'data', this.m_src );
	htmlString += this.getAttributeString( 'width', this.m_width );
	htmlString += this.getAttributeString( 'height', this.m_height );
	htmlString += this.getAttributeString( 'flashVars', this.getFlashVarsString() );
	htmlString += '>';
	htmlString += this.getParamTag( 'movie', this.m_src );
	for ( eachParam in this.getParams() ) {
		htmlString += this.getParamTag( eachParam, this.getParam( eachParam ) );
	}
	htmlString += this.getParamTag( 'flashVars', this.getFlashVarsString() );

// open embed
	htmlString += '<embed type="application/x-shockwave-flash"';
	htmlString += this.getAttributeString( 'pluginspage', flashUrl );
	htmlString += this.getAttributeString( 'name', this.m_name );
	htmlString += this.getAttributeString( 'src', this.m_src );
	htmlString += this.getAttributeString( 'width', this.m_width );
	htmlString += this.getAttributeString( 'height', this.m_height );
	for ( eachParam in this.getParams() ) {
		htmlString += this.getAttributeString( eachParam, this.getParam( eachParam ) );
	}
	htmlString += this.getAttributeString( 'flashVars', this.getFlashVarsString() );
	htmlString += '>';

// close embed
	htmlString += '<\/embed>';

// close object
	htmlString += '<\/object>';

	return ( htmlString );
}

CNN_FlashObject.prototype.writeHtml = function () {
	document.write( this.getHtml() );
}
