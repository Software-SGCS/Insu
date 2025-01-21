var cnnad_tileID = cnnad_getID();
var cnnad_enabled = true;
function cnnad_getID() {
	return (new Date().getTime());
}

function cnnad_renderAd(cnnad_url) {
// this function is deprecated in failsafe ads solution. -sg
	if(cnnad_enabled == true) {
		document.write("<script type=\"text/javascript\"");
		document.write(" src=\""+cnnad_url+"&tile="+cnnad_tileID+"&page.allowcompete=yes\"></scr");
		document.write("ipt>");
	}
}

function cnnad_createAd(adId,cnnad_url,cnnad_height,cnnad_width) {
	document.write('<iframe hspace="0" vspace="0" marginHeight="0" marginWidth="0" src="' + cnnad_url + '&tile=' + cnnad_tileID + '&page.allowcompete=yes&domId=' + adId + '" border="0" frameBorder="0" height="0" width="0" scrolling="no"  id="'+adId+'" style="position: absolute; visibility: hidden;" ></iframe>');
}

function cnnad_writeAd(cnnad_callid,cnnad_url) {
        if(cnnad_enabled == true) {
                document.write("<script id=\"" + cnnad_callid + "\" type=\"text/javascript\" onload=\"cnnSendData();\"");
                document.write(" src=\""+cnnad_url+"&tile="+cnnad_tileID+"\"></scr");
                document.write("ipt>");
        }
}

function cnnad_showAd(cnnad_id) {
	if (document.getElementById(cnnad_id))
	{
		document.getElementById(cnnad_id).style.position = 'relative';
		document.getElementById(cnnad_id).style.visibility = 'visible';
	} else 
	{
		//alert("Error displaying ad component: " + cnnad_id);	
		// just do not display the ad. -sg
	}
}


function cnnad_setAdSize(docId,height,width) {
        if (document.getElementById(docId)) {
                document.getElementById(docId).height = height;
                document.getElementById(docId).width = width;
        }
}

