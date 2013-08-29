
function getLabelForId( id ) 
{
      var label, all_labels = document.getElementsByTagName('label');

      for( var i = 0; label = all_labels[i]; i++ ) 
      {
         if( label.htmlFor == id ) 
         {
            return label;
         }
      }
      return false;
}

function updateAddress(val) { 
      var label = getLabelForId('cc_state');

          if(document.getElementById('is_same_addr').checked == true)
          {
            document.getElementById('cc_country').value = document.getElementById('country').value;
            document.getElementById('cc_state').value = document.getElementById('state').value;
            document.getElementById('cc_city').value = document.getElementById('city').value;
            //document.getElementById('fld_ccompany_name').value = document.getElementById('company_name').value;
            document.getElementById('cc_addr1').value = document.getElementById('str_address1').value;
            document.getElementById('cc_addr2').value = document.getElementById('str_address2').value;
            document.getElementById('cc_zipcode').value = document.getElementById('zipcode').value;
            if( document.getElementById('country').value == 'US' )
            {
                label.innerHTML = 'State: ';
            }
            else
            {
                label.innerHTML = 'Locality: ';
            }

		}
        else
        {
  			document.getElementById('cc_country').value = "";
			document.getElementById('cc_state').value = "";
			document.getElementById('cc_city').value = "";
			document.getElementById('cc_addr1').value = "";
			document.getElementById('cc_addr2').value = "";
			document.getElementById('cc_zipcode').value = "";
		}
}


function finishField(e, str,msgfield) {
		if(e.value.length == 0) {
			e.value = str;
			e.className = temp_class;
			e.type = "text";
			document.getElementById(msgfield).innerHTML= "*<BR>required<BR>";
		}else{
		   	document.getElementById(msgfield).innerHTML= "";
		}
}

function checkName(e,msgfield)
{
   var reg_name = /^[0-9a-zA-Z\s-]{1,}$/;
   if(e.value.length>0){
		document.getElementById(msgfield).innerHTML = '' ;
		if(!reg_name.test(e.value)){
		
		  document.getElementById(msgfield).innerHTML= '*<BR>Accepts only alphanumeric characters and spaces<BR>&nbsp;' ;
		  e.value="";
		}		  
		  
   }else{
        document.getElementById(msgfield).innerHTML= '*<BR>required<BR>&nbsp;' ;
   }
}

function checkCompany(e,msgfield)
{
   var reg_name =  /^[a-zA-Z0-9-\.,'\s-]{5,50}$/;
   if(e.value.length>0){
		document.getElementById(msgfield).innerHTML = '' ;
		if(!reg_name.test(e.value)){
		  document.getElementById(msgfield).innerHTML= '*<BR>Accepts only 5-50 alphanumeric characters, period, dash, comma, apostrophe and space<BR>&nbsp;' ;
		  e.value="";
		}		  
		  
   }
}

function checkPassword(e,msgfield)
{
   var reg_name =  /^[a-zA-Z0-9+-_!^@#%&*()\.]{6,50}$/;
   
   if(e.value.length>0){
		
		document.getElementById(msgfield).innerHTML= '' ;
		if(!reg_name.test(e.value)){
			  document.getElementById(msgfield).innerHTML= '*<BR>Accepts only 6-50 alphanumeric characters, and can include +-_!^@#%&*().<BR>&nbsp;' ;
			  e.value="";
		}		  
		  
   }else{
        document.getElementById(msgfield).innerHTML= '*<BR> required<BR>&nbsp;' ;
   }
}

function checkConfirmPassword(e,msgfield)
{
    if(e.value.length>0){
		
		document.getElementById(msgfield).innerHTML= '' ;
		
		if( e.value != document.getElementById('password').value){
		   document.getElementById(msgfield).innerHTML= '* <BR>passwords don\'t match<BR>&nbsp;' ;
		   e.value="";
		}		  
		  
   }else{
        document.getElementById(msgfield).innerHTML= '* <BR>required<BR>&nbsp;' ;
   }
}


function checkStreetAddress(e,msgfield)
{
   // old:var reg_name = /^[a-zA-Z0-9\s]{2,50}$/;
   var reg_name =  /^[a-zA-Z0-9-\.,'\s-]{5,50}$/;

   if(e.value.length>0){
	document.getElementById(msgfield).innerHTML= '' ;
	if(!reg_name.test(e.value)){
	  document.getElementById(msgfield).innerHTML= '* <BR>Must be between 5 and 50 alphanumeric characters, period, dash, comma, apostrophe and space<BR> &nbsp; ' ;
	  e.value=""
	}		  
   		  
   }else{
   //if((e.value.length==0) &&  document.getElementById('fld_addr1').value.length==0 ){
		
        document.getElementById(msgfield).innerHTML= '*<BR> required<BR> &nbsp; ' ;
   }
}

function checkStreetAddress2(e,msgfield)
{
   // old:var reg_name = /^[a-zA-Z0-9\s]{2,50}$/;
   var reg_name =  /^[a-zA-Z0-9-\.,'\s-]{5,50}$/;

   if(e.value.length>0){
	document.getElementById(msgfield).innerHTML= '' ;
	if(!reg_name.test(e.value)){
	  document.getElementById(msgfield).innerHTML= '* <BR>Must be between 5 and 50 alphanumeric characters, period, dash, comma, apostrophe and space<BR> &nbsp; ' ;
	  e.value=""
	}		  	  
   }
}


function checkCCStreetAddress(e,msgfield)
{
   var reg_name =  /^[a-zA-Z0-9-\.,'\s-]{5,50}$/;

   if(e.value.length>0){
	document.getElementById(msgfield).innerHTML= '' ;
	if(!reg_name.test(e.value)){
	  document.getElementById(msgfield).innerHTML= '* <BR>Must be between 5 and 50 alphanumeric characters, period, dash, comma, apostrophe and space<BR> &nbsp; ' ;
	  e.value=""
	}		  
   		  
   }else{
   //if((e.value.length==0) &&  document.getElementById('fld_addr1').value.length==0 ){
		
        document.getElementById(msgfield).innerHTML= '*<BR> required<BR> &nbsp; ' ;
   }
}

function checkCCStreetAddress2(e,msgfield)
{
   var reg_name =  /^[a-zA-Z0-9-\.,'\s-]{5,50}$/;

   if(e.value.length>0){
	document.getElementById(msgfield).innerHTML= '' ;
	if(!reg_name.test(e.value)){
	  document.getElementById(msgfield).innerHTML= '* <BR>Must be between 5 and 50 alphanumeric characters, period, dash, comma, apostrophe and space<BR> &nbsp; ' ;
	  e.value=""
	}		  
   		  
   }
}


function checkCity(e,msgfield)
{
   var reg_name = /^[a-zA-Z\.\s-]{2,}$/;
   if(e.value.length>0){
		document.getElementById(msgfield).innerHTML= '' ;
		if(!reg_name.test(e.value)){
		  document.getElementById(msgfield).innerHTML= '* <BR>Invalid characters<BR> &nbsp; ' ;
		  e.value=""
		}		  
		  
   }else{
        document.getElementById(msgfield).innerHTML= '* <BR>required<BR> &nbsp; ' ;
   }
}

function checkState(e,msgfield)
{
   var reg_name = /^[a-zA-Z]{2}$/;

   if(e.value != ""){
	
		document.getElementById(msgfield).innerHTML= '' ;
		
		if(!reg_name.test(e.value)){
		  document.getElementById(msgfield).innerHTML= '*<BR> ISO State code<BR> &nbsp; ' ;
		  e.value="";
		}		  
		  
   }else{
   
        document.getElementById(msgfield).innerHTML= '*<BR> required<BR> &nbsp; ' ;
   }
}

function checkState(e,cntr,msgfield)
{
   var reg_name = /^[a-zA-Z]{2}$/;

   if(e.value != ""){
	
		document.getElementById(msgfield).innerHTML= '' ;
		
		if(!reg_name.test(e.value)){
		  document.getElementById(msgfield).innerHTML= '*<BR> ISO State code<BR> &nbsp; ' ;
		  e.value="";
		}		  
		  
   }else if((cntr=="US")||(cntr==IL)){
   
        document.getElementById(msgfield).innerHTML= '*<BR> required<BR> &nbsp; ' ;
   }
}


function checkCountry(e,msgfield)
{
   var reg_name = /^[a-zA-Z]{2}$/;
   
   if(e.value!=""){
   
		document.getElementById(msgfield).innerHTML= '' ;
	
    	if(!reg_name.test(e.value)){
		  document.getElementById(msgfield).innerHTML= '*<BR> ISO Country code<BR> &nbsp; ' ;
		  e.value="";
		}		  
		  
   }else{
   
        document.getElementById(msgfield).innerHTML= '* <BR>required<BR> &nbsp; ' ;
   }
}

function checkZipcode(e,msgfield)
{
      var reg_nameUS = /^[0-9]{5}([- ]?[0-9]{4})?$/;
      var reg_nameCA = /^[A-Za-z][0-9][A-Za-z][\s ]?[0-9][A-Za-z][0-9]$/;
      //var reg_nameOther = /^([A-Z]?[a-z]?[0-9A-Za-z][- ]?){5,15}$/;
      var reg_nameOther = /^([A-Z0-9]{5,15})$/;
   
      if(e.value.length==0) {		    
      	document.getElementById(msgfield).innerHTML= '&nbsp;&nbsp;Required&nbsp; ' ;
      }
      else if(document.getElementById('billing_country').value == "US"){
      
      	if(!reg_nameUS.test(e.value)){
   	  document.getElementById(msgfield).innerHTML= 'US zip code must have between 5 and 10 numeric digits&nbsp; ' ;
   	  e.value="";
   	}
      }
      
      else if(document.getElementById('billing_country').value == "CA"){
         
         	if(!reg_nameCA.test(e.value)){
      	  document.getElementById(msgfield).innerHTML= 'Canadian postal code must have the following format: A0A 0A0&nbsp; ' ;
      	  e.value="";
      	}
      }
      
      else if(document.getElementById('billing_country').value != "CA" && document.getElementById('billing_country').value != "US"){
   	   
   	if(!reg_nameOther.test(e.value)){
         	  document.getElementById(msgfield).innerHTML= 'Zip/postal code must have between 5 and 15 alphanumeric digits&nbsp; ' ;
         	  e.value="";
         	}
   	}
}

function checkAcctZipcode(e,msgfield)
{
      var reg_nameUS = /^[0-9]{5}([- ]?[0-9]{4})?$/;
      var reg_nameCA = /^[A-Za-z][0-9][A-Za-z][\s ]?[0-9][A-Za-z][0-9]$/;
      //var reg_nameOther = /^([A-Z]?[a-z]?[0-9A-Za-z][- ]?){5,15}$/;
      var reg_nameOther = /^([A-Z0-9]{5,15})$/;
   
      if(e.value.length==0) {		    
      	document.getElementById(msgfield).innerHTML= '&nbsp;&nbsp;Required&nbsp; ' ;
      }
      else if(document.getElementById('country').value == "US"){
      
      	if(!reg_nameUS.test(e.value)){
   	  document.getElementById(msgfield).innerHTML= '<br>US zip code must have between 5 and 10 numeric digits&nbsp; ' ;
   	  e.value="";
   	}
      }
      
      else if(document.getElementById('country').value == "CA"){
         
         	if(!reg_nameCA.test(e.value)){
      	  document.getElementById(msgfield).innerHTML= '<br>Canadian postal code must have the following format: A0A 0A0&nbsp; ' ;
      	  e.value="";
      	}
      }
      
      else if(document.getElementById('country').value != "CA" && document.getElementById('country').value != "US"){
   	   
   	if(!reg_nameOther.test(e.value)){
         	  document.getElementById(msgfield).innerHTML= '<br>Zip/postal code must have between 5 and 15 alphanumeric digits&nbsp; ' ;
         	  e.value="";
         	}
   	}
}


function checkPhone(e,cntr,msgfield)
{
   var reg_nameUS = /^\(?^[0-9]{3}\)?[-. ]?[0-9]{3}[-. ]?[0-9]{4}$/;
   var reg_nameIntl = /^\+?[0-9A-Za-z]{3,20}$/;
   //var reg_name = /^((\+\d{1,3}(-| )?\(?\d\)?(-| )?\d{1,5})|(\(?\d{2,6}\)?))(-| )?(\d{3,4})(-| )?(\d{4})(( x| ext)\d{1,5}){0,1}$/;
   //var reg_name = /^\+[0-9]{1,3}\.[0-9]+\.[0-9]+$/;
   
   if(e.value.length>0){
		document.getElementById(msgfield).innerHTML= '' ;
		
		if(((cntr=="US")||(cntr=="CA"))&&(!reg_nameUS.test(e.value))){
		  document.getElementById(msgfield).innerHTML= '<br>* US/CA phone number must be 10-20 digits<BR> &nbsp; ' ;
		  e.value="";
		}
		else if(((cntr!="US")&&(cntr!="CA"))&&(!reg_nameIntl.test(e.value))){
		  document.getElementById(msgfield).innerHTML= '<br>* Intl phone number must be 3-20 digits<BR> &nbsp; ' ;
		  e.value="";
		}
		  
   }else{
    
        document.getElementById(msgfield).innerHTML= '<br>* required<BR> &nbsp; ' ;
   }
}


function checkEmail(e,msgfield)
{
   var reg_name = /^([\w-]+(?:\.[\w-]+)*)@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$/i ;
   //alert(e.value.length);
   if(e.value.length>0){
		document.getElementById(msgfield).innerHTML= '' ;
		if(!reg_name.test(e.value)){
		  document.getElementById(msgfield).innerHTML= '*<BR>Invalid format<BR> &nbsp; ' ;
		  
		}		  
		  
   }else{
   
        document.getElementById(msgfield).innerHTML= '* <BR>required<BR> &nbsp; ' ;
   }
}

function checkConfirmEmail(e,msgfield)
{
    
   if(e.value.length>0){
		
		  document.getElementById(msgfield).innerHTML= '' ;
		if( e.value != document.getElementById('emailid').value ){
		  document.getElementById(msgfield).innerHTML= '* <BR>Email and Confirm Email do not match<BR> &nbsp; ' ;
		}		  
		  
   }else{
   
        document.getElementById(msgfield).innerHTML= '* <BR>required<BR> &nbsp; ' ;
   }
}


function checkPlan(e,msgfield)
{
   var reg_name = /^[0-9]{1,}$/;
 
   if(e.value.length > 0){
 
	document.getElementById(msgfield).innerHTML= '' ;
		if(isNaN(e.value)){
		  document.getElementById(msgfield).innerHTML= '* <BR>Invalid Plan <BR> &nbsp; ' ;
		}		  
		  
   }else{
   
        document.getElementById(msgfield).innerHTML= '* <BR>required<BR> &nbsp; ' ;
   }
}


function checkSecurityQuestion(e,msgfield)
{
    if(e.value.length > 0){
        
		document.getElementById(msgfield).innerHTML= '' ;
    }else{
   
        document.getElementById(msgfield).innerHTML= '* <BR>required<BR> &nbsp; ' ;
   }
}

function checkSecurityAnswer(e,msgfield)
{
    if(e.value.length > 0){
        
		document.getElementById(msgfield).innerHTML= '' ;
		
		
    }else{
   
        document.getElementById(msgfield).innerHTML= '* <BR>required<BR> &nbsp; ' ;
   }
}


function checkCCNumber(e,msgfield)
{
    
   if(e.value.length == 15 || e.value.length == 16 )
   {
   
		document.getElementById(msgfield).innerHTML= '' ;
		
		if( isNaN(e.value))
		{
			 
			document.getElementById(msgfield).innerHTML= '* <BR>Must be 15 or 16 digits long.<BR> &nbsp; ' ;
            return false;
		}
        else
        {
			
			var startswith = e.value.substr(0,1);
		
			if(e.value.length == 16 && !(startswith == 4 || startswith == 5 || startswith == 6))
			{
				document.getElementById(msgfield).innerHTML= '* <BR>Invalid Credit Card Number<BR> &nbsp; ' ; // Discover, etc etc
                return false;
			}		  
            
			if(e.value.length == 15 && !(startswith == 3))
			{
				document.getElementById(msgfield).innerHTML= '* <BR>Invalid Credit Card Number.<BR> &nbsp; ' ; // Amex
                return false;
			}
            return true;
		}
		  
   }else{
   
        document.getElementById(msgfield).innerHTML= '* <BR>Invalid card number<BR> &nbsp; ' ;
        return false;
   }
}

function checkCVV(e,msgfield)
{
    
   if(e.value.length>0){
     
	 document.getElementById(msgfield).innerHTML= '' ;
	 
	 if( e.value.length < 3 || e.value.length > 4  || isNaN(e.value)){
		
 		  document.getElementById(msgfield).innerHTML= '* <BR>CVV code must be 3 or 4 digits<BR> &nbsp; ' ;
 		}  
   }else{
   
        document.getElementById(msgfield).innerHTML= '* <BR>required<BR> &nbsp; ' ;
   }
}

function checkCCExpMonth(e,msgfield)
{
    document.getElementById(msgfield).innerHTML= '' ;
   if(e.value.length>0)
   {
		 if( e.value > 12 || isNaN(e.value))  {
		 
		   document.getElementById(msgfield).innerHTML= '* <BR>Must be MM format<BR> &nbsp; ' ;
		 }		  
		  
   }else{
   
        document.getElementById(msgfield).innerHTML= '* <BR>required<BR> &nbsp; ' ;
   }
}

function checkCCExpYear(e,msgfield)
{
		
	if(e.value.length>0){
	   document.getElementById(msgfield).innerHTML= '' ;
	   if( isNaN( e.value ) || e.value.length != 4)  
	   {
			document.getElementById(msgfield).innerHTML= '* <BR>Must be YYYY format<BR> &nbsp; ' ;
		}	 
		  
   }else{
   
        document.getElementById(msgfield).innerHTML= '* <BR>required<BR> &nbsp; ' ;
   }
}

function checkRoutingNo( e, msgfield )
{
    if(e.value.length>0){
	   document.getElementById(msgfield).innerHTML= '' ;
	   if( e.value.length < 9 || e.value.length > 9  || isNaN(e.value))
	 {
			document.getElementById(msgfield).innerHTML= '* <BR>Must be 9 digit long.<BR> &nbsp; ' ;
		}	 
		  
   }else{
   
        document.getElementById(msgfield).innerHTML= '* <BR>required<BR> &nbsp; ' ;
   }
}

function checkAccountNo( e, msgfield )
{
    if(e.value.length>0){
	   document.getElementById(msgfield).innerHTML= '' ;
	   if( e.value.length < 5 || e.value.length > 19  || isNaN(e.value))
	 {
			document.getElementById(msgfield).innerHTML= '* <BR>Must be between 5 and 19 digit long.<BR> &nbsp; ' ;
		}	 
		  
   }else{
   
        document.getElementById(msgfield).innerHTML= '* <BR>required<BR> &nbsp; ' ;
   }
}

function numbersonly( e ,field) 
{
      var key;
      var keychar;

      if (window.event)
        key = window.event.keyCode;
      else if (e)
        key = e.which;
      else
        return true;
      keychar = String.fromCharCode(key);

      // control keys
      if ((key==null) || (key==0) || (key==8) || (key==9) || (key==13) || (key==27) )
        return true;
    else if ( ( ("0123456789-()").indexOf(keychar) > -1 && field == 'phone') )
        return true;
    else if (( ( ("0123456789").indexOf(keychar) > -1)))
        return true;
      // decimal point jump
      //else if (dec && (keychar == ".")) {
        //myfield.form.elements[dec].focus();

        //return true;
      //} 
      else
        return false;
}
