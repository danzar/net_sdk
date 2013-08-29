
// Show & Hide /////////////////////////////////////////

function showItem(id) {
  if (document.getElementById(id) != null) {
    document.getElementById(id).style.display = "block";
  }
}
function hideItem(id) {
  if (document.getElementById(id) != null) {
    document.getElementById(id).style.display = "none";
  }
}

function showString(id, str) {
	document.getElementById(id).innerHTML = str;
}
function clearString(id) {
	document.getElementById(id).innerHTML = "";
}

// Transition /////////////////////////////////

function goTo(url) {
	window.location=url;
}

function goToAfterDelay(url, delay) {
	t = setTimeout("goTo('"+url+"')",delay);
}

function confirmAndGo(msg,url) {
	if( confirm(msg) )
		goTo(url);
}


// Pop-up //////////////////////////////////////////

function popup(url, w, h) {
	window.open(url,"_blank",
		"toolbar=no, location=no, directories=no, status=no, menubar=no, scrollbars=yes, resizable=yes, copyhistory=yes, width="+w+", height="+h);
	
}


// Window system mimicing ////////////////////////////
var z = 10; 

function bringToFocus(e) {
	z++;
	e.style.zIndex = z;
}

function openWindow(id) {
	showItem(id);
	showItem('taskbar_'+id);
	bringToFocus(document.getElementById(id));			
}
function closeWindow(id) {
	hideItem(id);
	hideItem('taskbar_'+id);			
}
function minimizeWindow(id) {
	hideItem(id);
}

function openHelp(url) {
	showItem('qb_help');
	if(url!='') {
		document.getElementById('qb_help_content').src=url;
	}
	else {
		document.getElementById('qb_help_content').src='h_notfound.html';			
	}
}						

function showToolTip() {
 	var myTimer=setTimeout("showItem('sync_tooltip')", 500);
	onMouseOver="showToolTip();"
	onMouseOut="clearTimeout(myTimer);"
}



// Cookie //////////////////////////////////////

function setCookie(c_name, value, expiredays)
{
	var exdate=new Date();
	exdate.setDate(exdate.getDate() + expiredays);
	document.cookie = c_name + "=" + escape(value) 
		+ ((expiredays==null)? "" : "; expires="+exdate.toGMTString());
}

function getCookie(c_name)
{
	if (document.cookie.length > 0) {
		c_start = document.cookie.indexOf(c_name + "=");
		
		if (c_start != -1) { 
			c_start = c_start + c_name.length+1 ;
			c_end = document.cookie.indexOf(";",c_start);
			
			if (c_end==-1) {
				c_end = document.cookie.length;
			}
			
			return unescape(document.cookie.substring(c_start,c_end));
		} 
	}
	return "";
}

function checkCookie()
{
	bi=getCookie('bi');
	
	if (bi!=null && bi!="") {
		alert('yes bi is set');
	}
	else {
		alert('no bi is not set');
	}
}

