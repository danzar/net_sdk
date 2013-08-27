// Ghost Text in Empty Field /////////////////////////////////

var temp_class = "";

function startField(e) {
	if(e.className.match("ghost")) {
		temp_class = e.className;
		e.className = e.className.replace(/ghost/g, "");			
		e.value = "";
	}
}

function finishField(e, str) {
	if(e.value.length == 0) {
		e.className = temp_class;
		e.type = 'text';
		e.value = str;
	}
}	
