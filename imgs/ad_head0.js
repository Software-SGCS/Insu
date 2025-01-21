function CNN_getCookies() {
	var hash = new Array;
	if ( document.cookie ) {
		var cookies = document.cookie.split( '; ' );
		for ( var i = 0; i < cookies.length; i++ ) {
			var namevaluePairs = cookies[i].split( '=' );
			hash[namevaluePairs[0]] = unescape( namevaluePairs[1] ) || null;
		}
	}
	return hash;
}

function CNN_parseCookieData( cookieDataString ) {
	var cookieValues = new Object();
	var separatePairs = cookieDataString.split( '&' );
	for ( var i = 0; i < separatePairs.length; i++  ) {
		var separateValues = separatePairs[i].split( ':' );
		cookieValues[separateValues[0]] = separateValues[1] || null;
	}
	return cookieValues;
}

// default values
var adHeadOffset = 0;
var adHeadClass = "us.low";

var allCookies = CNN_getCookies();
var adHeadCookie = allCookies[ "Target" ] || null;
var isClassAndOffsetValid = false;
var alreadySwappedTargetImage = false;
var alreadySwappedCookieCrumb = false;

if ( adHeadCookie ) {	// got milk?
	var adHeadHash = CNN_parseCookieData( adHeadCookie );
	//alert("o=" +  adHeadHash[ "o" ] + "\nclass=" + adHeadHash[ "class"]);
	if ( adHeadHash[ "o" ] && adHeadHash[ "class" ] ) {
		var validClassesAndOffsets = [ 'us.low', 0, 'us.high', 1, 'intl', 2, 'intl', 3, 'us.edu', 0, 'us.gov', 0, 'us.mil', 0, 'us.org', 0 ];
		for ( var i = 0; i < validClassesAndOffsets.length; i+=2 ) {
			if ( validClassesAndOffsets[i] == adHeadHash[ "class" ] && validClassesAndOffsets[i+1] == adHeadHash[ "o" ] ) {
				isClassAndOffsetValid = true;
				break;
			}
		}
	}
	if ( isClassAndOffsetValid ) {
		adHeadOffset = adHeadHash[ "o" ];
		adHeadClass = adHeadHash[ "class" ];
	}
}

document.adoffset = adHeadOffset;

//alert( "GLOBAL\nalreadySwappedTargetImage=" + alreadySwappedTargetImage + "\nisClassAndOffsetValid=" + isClassAndOffsetValid );

function getAdHeadCookie( imageRef ) {
	//alert( "isClassAndOffsetValid=" + isClassAndOffsetValid + "\nadHeadOffset=" + adHeadOffset + "\nadHeadClass=" + adHeadClass);
	var newSrc = "http://cnn.dyn.cnn.com/1.gif?" + new Date().getTime();
	if ( !alreadySwappedTargetImage && !isClassAndOffsetValid && WM_browserAcceptsCookies() ) {
		//alert( "getAdHeadCookie\nalreadySwappedTargetImage=" + alreadySwappedTargetImage + "\nisClassAndOffsetValid=" + isClassAndOffsetValid );
		imageRef.src = newSrc;
		alreadySwappedTargetImage = true;
	}
}

var alreadySwappedDETargetImage = false;
var cnnDEadDEonCookie = false;
	
function getDEAdHeadCookie( imageRef ) {
	if (typeof(WM_readCookie) != "undefined") {
		cnnDEadDEonCookie = WM_readCookie( 'adDEon' );
	}
	var newSrc = "http://gdyn.cnn.com/1.1/1.gif?" + new Date().getTime();
	if ( !alreadySwappedDETargetImage && !cnnDEadDEonCookie) {
		imageRef.src = newSrc;
		alreadySwappedDETargetImage = true;
	}
}
