/*
** New Aria Country/State/Province/Locality jsvascript handler
** Copyright Aria Systems, LLC
** 1400 North Providence Road, Suite 210,
** Media, PA, 19063 U.S.A
** All rights reserved
**
** Changelog:
** 2008-06-30 David Morfin - Imported from old JS
** 2008-06-30 David Morfin - Updated functionality
** 2008-07-01 David Morfin - Rewrote functions to use new interface
** 2008-07-01 David Morfin - Documented usage of new interface
** 2008-07-01 David Morfin - Fix existing state code, update usage
** 2008-07-07 David Morfin - Update to change country field to select as needed
**
** Usage: 
** During onload or at any point after the country field is created, run:
**  populateCountry(document.formname.nameOfCountryField, 'the default value');
**  countryChanged(document.formname.nameOfStateField, document.formname.nameOfCountryField);
** Then on the field's onChange event handler, run this:
**  countryChanged(this.form.nameOfStateField, this);
** These functions also expect the labels to be formatted via CSS, including
** support for a span.required class that marks the "*" with the right color.
**
*/

// State table
// 
// To edit the list, just delete a line or add a line. Order is important.
// The order displayed here is the order it appears on the drop down.
// 
var state = '|\
US:AL:Alabama|\
US:AK:Alaska|\
US:AS:American Samoa|\
US:AZ:Arizona|\
US:AR:Arkansas|\
US:CA:California|\
US:CZ:Canal Zone|\
US:CO:Colorado|\
US:CT:Connecticut|\
US:DE:Delaware|\
US:DC:District of Columbia|\
US:FL:Florida|\
US:GA:Georgia|\
US:GU:Guam|\
US:HI:Hawaii|\
US:ID:Idaho|\
US:IL:Illinois|\
US:IN:Indiana|\
US:IA:Iowa|\
US:KS:Kansas|\
US:KY:Kentucky|\
US:LA:Louisiana|\
US:ME:Maine|\
US:MD:Maryland|\
US:MA:Massachusetts|\
US:MI:Michigan|\
US:MN:Minnesota|\
US:MS:Mississippi|\
US:MO:Missouri|\
US:MT:Montana|\
US:NE:Nebraska|\
US:NV:Nevada|\
US:NH:New Hampshire|\
US:NJ:New Jersey|\
US:NM:New Mexico|\
US:NY:New York|\
US:NC:North Carolina|\
US:ND:North Dakota|\
US:OH:Ohio|\
US:OK:Oklahoma|\
US:OR:Oregon|\
US:PA:Pennsylvania|\
US:PR:Puerto Rico|\
US:RI:Rhode Island|\
US:SC:South Carolina|\
US:SD:South Dakota|\
US:TN:Tennessee|\
US:TX:Texas|\
US:VI:U.S. Virgin Islands|\
US:UT:Utah|\
US:VT:Vermont|\
US:VA:Virginia|\
US:WA:Washington|\
US:WV:West Virginia|\
US:WI:Wisconsin|\
US:WY:Wyoming|\
CA:AB:Alberta|\
CA:BC:British Columbia|\
CA:MB:Manitoba|\
CA:NB:New Brunswick|\
CA:NF:Newfoundland|\
CA:NT:Northwest Territories|\
CA:NS:Nova Scotia|\
CA:ON:Ontario|\
CA:PE:Prince Edward Island|\
CA:QC:Quebec|\
CA:SK:Saskatchewan|\
CA:YT:Yukon Territory|\
';

// Country data table
//
// To edit the list, just delete a line or add a line. Order is important.
// The order displayed here is the order it appears on the drop down.
//
var country = '\
US:United States|\
AF:Afghanistan|\
AL:Albania|\
DZ:Algeria|\
AS:American Samoa|\
AD:Andorra|\
AO:Angola|\
AI:Anguilla|\
AQ:Antarctica|\
AG:Antigua and Barbuda|\
AR:Argentina|\
AM:Armenia|\
AW:Aruba|\
AU:Australia|\
AT:Austria|\
AZ:Azerbaijan|\
BS:Bahamas|\
BH:Bahrain|\
BD:Bangladesh|\
BB:Barbados|\
BY:Belarus|\
BE:Belgium|\
BZ:Belize|\
BJ:Benin|\
BM:Bermuda|\
BT:Bhutan|\
BO:Bolivia|\
BA:Bosnia and Herzegovina|\
BW:Botswana|\
BV:Bouvet Island|\
BR:Brazil|\
IO:British Indian Ocean Territory|\
BN:Brunei Darussalam|\
BG:Bulgaria|\
BF:Burkina Faso|\
BI:Burundi|\
KH:Cambodia|\
CM:Cameroon|\
CA:Canada|\
CV:Cape Verde|\
KY:Cayman Islands|\
CF:Central African Republic|\
TD:Chad|\
CL:Chile|\
CN:China|\
CX:Christmas Island|\
CC:Cocos (Keeling) Islands|\
CO:Colombia|\
KM:Comoros|\
CG:Congo|\
CD:Congo, The Democratic Republic of The|\
CK:Cook Islands|\
CR:Costa Rica|\
HR:Croatia|\
CY:Cyprus|\
CZ:Czech Republic|\
DK:Denmark|\
DJ:Djibouti|\
DM:Dominica|\
DO:Dominican Republic|\
TP:East Timor|\
EC:Ecuador|\
EG:Egypt|\
SV:El Salvador|\
GQ:Equatorial Guinea|\
ER:Eritrea|\
EE:Estonia|\
ET:Ethiopia|\
FK:Falkland Islands (Malvinas)|\
FO:Faroe Islands|\
FJ:Fiji|\
FI:Finland|\
FR:France|\
GF:French Guiana|\
PF:French Polynesia|\
TF:French Southern Territories|\
GA:Gabon|\
GM:Gambia|\
GE:Georgia|\
DE:Germany|\
GH:Ghana|\
GI:Gibraltar|\
GR:Greece|\
GL:Greenland|\
GD:Grenada|\
GP:Guadeloupe|\
GU:Guam|\
GT:Guatemala|\
GN:Guinea|\
GW:Guinea-bissau|\
GY:Guyana|\
HT:Haiti|\
HM:Heard Island and Mcdonald Islands|\
VA:Holy See (Vatican City State)|\
HN:Honduras|\
HK:Hong Kong|\
HU:Hungary|\
IS:Iceland|\
IN:India|\
ID:Indonesia|\
IQ:Iraq|\
IE:Ireland|\
IL:Israel|\
IT:Italy|\
CI:Ivory Coast|\
JM:Jamaica|\
JP:Japan|\
JO:Jordan|\
KZ:Kazakstan|\
KE:Kenya|\
KI:Kiribati|\
KR:Korea, Republic Of|\
KW:Kuwait|\
KG:Kyrgyzstan|\
LA:Lao Peoples Democratic Republic|\
LV:Latvia|\
LB:Lebanon|\
LS:Lesotho|\
LR:Liberia|\
LY:Libyan Arab Jamahiriya|\
LI:Liechtenstein|\
LT:Lithuania|\
LU:Luxembourg|\
MO:Macau|\
MK:Macedonia|\
MG:Madagascar|\
MW:Malawi|\
MY:Malaysia|\
MV:Maldives|\
ML:Mali|\
MT:Malta|\
MH:Marshall Islands|\
MQ:Martinique|\
MR:Mauritania|\
MU:Mauritius|\
YT:Mayotte|\
MX:Mexico|\
FM:Micronesia, Federated States Of|\
MD:Moldova, Republic Of|\
MC:Monaco|\
MN:Mongolia|\
MS:Montserrat|\
MA:Morocco|\
MZ:Mozambique|\
MM:Myanmar|\
NA:Namibia|\
NR:Nauru|\
NP:Nepal|\
NL:Netherlands|\
AN:Netherlands Antilles|\
NC:New Caledonia|\
NZ:New Zealand|\
NI:Nicaragua|\
NE:Niger|\
NG:Nigeria|\
NU:Niue|\
NF:Norfolk Island|\
MP:Northern Mariana Islands|\
NO:Norway|\
OM:Oman|\
PK:Pakistan|\
PW:Palau|\
PS:Palestinian Territory, Occupied|\
PA:Panama|\
PG:Papua New Guinea|\
PY:Paraguay|\
PE:Peru|\
PH:Philippines|\
PN:Pitcairn|\
PL:Poland|\
PT:Portugal|\
QA:Qatar|\
RE:Reunion|\
RO:Romania|\
RU:Russian Federation|\
RW:Rwanda|\
GS:S. Georgia and S. Sandwich Islands|\
SH:Saint Helena|\
KN:Saint Kitts and Nevis|\
LC:Saint Lucia|\
PM:Saint Pierre and Miquelon|\
VC:Saint Vincent and the Grenadines|\
WS:Samoa|\
SM:San Marino|\
ST:Sao Tome and Principe|\
SA:Saudi Arabia|\
SN:Senegal|\
SC:Seychelles|\
SL:Sierra Leone|\
SG:Singapore|\
SK:Slovakia|\
SI:Slovenia|\
SB:Solomon Islands|\
SO:Somalia|\
ZA:South Africa|\
ES:Spain|\
LK:Sri Lanka|\
SR:Suriname|\
SJ:Svalbard and Jan Mayen|\
SZ:Swaziland|\
SE:Sweden|\
CH:Switzerland|\
TW:Taiwan, Province of China|\
TJ:Tajikistan|\
TZ:Tanzania, United Republic Of|\
TH:Thailand|\
TG:Togo|\
TK:Tokelau|\
TO:Tonga|\
TT:Trinidad and Tobago|\
TN:Tunisia|\
TR:Turkey|\
TM:Turkmenistan|\
TC:Turks and Caicos Islands|\
TV:Tuvalu|\
UG:Uganda|\
UA:Ukraine|\
AE:United Arab Emirates|\
GB:United Kingdom|\
US:United States|\
UY:Uruguay|\
UZ:Uzbekistan|\
VU:Vanuatu|\
VE:Venezuela|\
VN:Vietnam|\
VG:Virgin Islands, British|\
VI:Virgin Islands, U.S.|\
WF:Wallis and Futuna|\
EH:Western Sahara|\
YE:Yemen|\
YU:Yugoslavia|\
ZM:Zambia|\
ZW:Zimbabwe|\
';

function trimString( input ) {
	if(! input) return '';
	return input.replace( /(^\s+|\s+$)/g, '' );
}

function getLabelForId( id ) {
  var label, all_labels = document.getElementsByTagName('label');
  for( var i = 0; label = all_labels[i]; i++ ) {
    if( label.htmlFor == id ) {
      return label;
    }
  }
  return false;
}


function populateCountry( countryObj, selectValue ) {
    if(countryObj.tagName.toUpperCase() == 'INPUT') {
		var oldid = countryObj.id;
		var oldname = countryObj.name;
		var oldonchange = countryObj.onchange;
		var parentObj = countryObj.parentNode;
		var oldvalue = trimString(countryObj.value);
		if(oldvalue != '') {
			selectValue = oldvalue;
		}
		parentObj.removeChild(countryObj);
		countryObj = document.createElement('select');
		countryObj.setAttribute('name', oldname);
		countryObj.setAttribute('id', oldid);
        
		countryObj.onchange = oldonchange;
		parentObj.appendChild(countryObj);
	} 
	if( countryObj.length <= 1 ) {
		countryObj.options[0] = new Option('Select Country', '');
		countryObj.selectedIndex = 0;
	}
	var optionArr;
	var countryArr = country.split('|');
	for( var i=0; i<=countryArr.length; i++ ) {
		optionArr = trimString(countryArr[i]).split(':');
		if(optionArr[0] === undefined) continue;
		if(optionArr[1] === undefined) continue;
		countryObj.options[i+1] = new Option(optionArr[1], optionArr[0]);
		if(selectValue == optionArr[0]) {
			countryObj.selectedIndex = i+1;
		}
	}
	// wish we could call this directly, but no go.  
	// instead, call countryChanged after calling this function
	//countryObj.onChange();
}

function countryChanged( stateObj, countryObj, selectValue ) {
    
    var label = getLabelForId(stateObj.id);
	var oldid = stateObj.id;
	var oldname = stateObj.name;
	var oldvalue = stateObj.value;
    if( selectValue != '' || selectValue != null)
        oldvalue = selectValue;
	var parentObj = stateObj.parentNode;
	parentObj.removeChild(stateObj);
	if( countryObj.value == 'US' ) {
		label.innerHTML = 'State: ';
	} else if ( countryObj.value == 'CA' ) {
		label.innerHTML = 'Province: ';
	} else {
		label.innerHTML = ' Locality';
	}
	
//	if(! stateObj) {
		stateObj = document.createElement('select');
		stateObj.setAttribute('name', oldname);
		stateObj.setAttribute('id', oldid);
		parentObj.appendChild(stateObj);
		stateObj.options[0] = new Option('Select','');
		stateObj.selectedIndex = 0;
//	}
	var optionArr;
	var stateArr = state.split('|');
	var optionCount = 1;
	for( var i=1; i<=stateArr.length; i++ ) {
		optionArr = trimString(stateArr[i]).split(':');
		if(optionArr[0] === undefined) continue;
		if(optionArr[1] === undefined) continue;
		if(optionArr[2] === undefined) continue;
		if(optionArr[0] === countryObj.value) {
			stateObj.options[optionCount] = new Option(optionArr[2], optionArr[1]);
			if(optionArr[1] == oldvalue) {
				stateObj.selectedIndex = optionCount;
			}
		optionCount++;
		}
	}
    
	if( stateObj.length <= 1 ) {
		parentObj.removeChild(stateObj);
		stateObj = document.createElement('input');
		stateObj.setAttribute('name', oldname);
		stateObj.setAttribute('id', oldid);
        stateObj.type ="text";
         if (window.ActiveXObject)
			stateObj.setAttribute("className", "fullwidth");
		else
			stateObj.setAttribute("class", "fullwidth");
       parentObj.appendChild(stateObj);
		stateObj.value = oldvalue;
	}
	return true;
}


