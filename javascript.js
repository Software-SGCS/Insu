function on(obj){obj.style.backgroundColor='bcd5e2';} function off(obj){obj.style.backgroundColor='#ABCADB';}
function on_g(obj){obj.style.backgroundColor='94bd60';} function off_g(obj){obj.style.backgroundColor='#79AC38';}
function on_blue_lt(obj){obj.style.backgroundColor='#E9F1F5';} function off_blue_lt(obj){obj.style.backgroundColor='#F8F8F3';}
function on_blue_dk(obj){obj.style.backgroundColor='#D3E3EB';} function off_blue_dk(obj){obj.style.backgroundColor='#F8F8F3';}
function on_orange(obj){obj.style.backgroundColor='#EDC385';} function off_orange(obj){obj.style.backgroundColor='#E8B466';}

function MM_preloadImages() { //v3.0
  var d=document; if(d.images){ if(!d.MM_p) d.MM_p=new Array();
    var i,j=d.MM_p.length,a=MM_preloadImages.arguments; for(i=0; i<a.length; i++)
    if (a[i].indexOf("#")!=0){ d.MM_p[j]=new Image; d.MM_p[j++].src=a[i];}}
}

function MM_swapImgRestore() { //v3.0
  var i,x,a=document.MM_sr; for(i=0;a&&i<a.length&&(x=a[i])&&x.oSrc;i++) x.src=x.oSrc;
}

function MM_findObj(n, d) { //v4.01
  var p,i,x;  if(!d) d=document; if((p=n.indexOf("?"))>0&&parent.frames.length) {
    d=parent.frames[n.substring(p+1)].document; n=n.substring(0,p);}
  if(!(x=d[n])&&d.all) x=d.all[n]; for (i=0;!x&&i<d.forms.length;i++) x=d.forms[i][n];
  for(i=0;!x&&d.layers&&i<d.layers.length;i++) x=MM_findObj(n,d.layers[i].document);
  if(!x && d.getElementById) x=d.getElementById(n); return x;
}

function MM_swapImage() { //v3.0
  var i,j=0,x,a=MM_swapImage.arguments; document.MM_sr=new Array; for(i=0;i<(a.length-2);i+=3)
   if ((x=MM_findObj(a[i]))!=null){document.MM_sr[j++]=x; if(!x.oSrc) x.oSrc=x.src; x.src=a[i+2];}
}

function MM_openBrWindow(theURL,winName,features) { //v2.0
window.open(theURL,winName,features);
}


function initScrollLayer() {
  // arguments: id of layer containing scrolling layers (clipped layer), id of layer to scroll, 
  // if horizontal scrolling, id of element containing scrolling content (table?)
  var wndo = new dw_scrollObj('wn', 'lyr1', 't1');
  
  // pass id's of any wndo's that scroll inside tables
  // i.e., if you have 3 (with id's wn1, wn2, wn3): dw_scrollObj.GeckoTableBugFix('wn1', 'wn2', 'wn3');
  dw_scrollObj.GeckoTableBugFix('wn'); 
}

//specify interval between slide (in mili seconds)
var slidespeed=3000

//specify images
var slideimages=new Array("/images/photoalbum/team/1.jpg","/images/photoalbum/team/2.jpg","/images/photoalbum/team/3.jpg","/images/photoalbum/team/4.jpg","/images/photoalbum/team/5.jpg","/images/photoalbum/team/6.jpg","/images/photoalbum/team/7.jpg")

//specify corresponding links
var slidelinks=new Array("/images/photoalbum/team/1.jpg","/images/photoalbum/team/2.jpg","/images/photoalbum/team/3.jpg","/images/photoalbum/team/4.jpg","/images/photoalbum/team/5.jpg","/images/photoalbum/team/6.jpg","/images/photoalbum/team/7.jpg")

var newwindow=0 //open links in new window? 1=yes, 0=no

var imageholder2=new Array()
var ie=document.all
for (i=0;i<slideimages.length;i++){
imageholder2[i]=new Image()
imageholder2[i].src=slideimages[i]
}

//-->