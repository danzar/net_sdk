var $j = jQuery.noConflict();

//Start Common Event Handlers
var pageRequestManager = Sys.WebForms.PageRequestManager.getInstance();

pageRequestManager.add_beginRequest(commonBeginRequestHandler);
pageRequestManager.add_endRequest(commonEndRequestHandler);

//Fires every page load an every callback start
function commonBeginRequestHandler(sender, args) {

    var mensajeLoad = $j('#loadingBox');
    if (mensajeLoad == null)
        return;

    $j.blockUI.defaults.css = {};
    $j.blockUI({ message: $j('#loadingBox'),
        showOverlay: false,
        centerY: 0,
        css: {
            top: '90%',
            left: '90%',
            width: '70px',
            border: 'none',
            '-webkit-border-radius': '10px',
            '-moz-border-radius': '10px',
            color: '#fff'
        }
    });
}

//Fires every page load an every callback end
function commonEndRequestHandler(sender, args) {
    $j.unblockUI();
}

function ValidateRoutingNumberLenght(source, arguments) {
    if (arguments.Value.length == 9) {
        arguments.IsValid = true;
    } else {
        arguments.IsValid = false;
    }
}

function ValidateBankAccountNumberLenght(source, arguments) {
    if (arguments.Value.length == 19) {
        arguments.IsValid = true;
    } else {
        arguments.IsValid = false;
    }
}

function ValidateSecurityCodeLenght(source, arguments) {
    if (arguments.Value.length > 2 && arguments.Value.length < 5) {
        arguments.IsValid = true;
    } else {
        arguments.IsValid = false;
    }
}

function showpopUp() {
    myWin = open("WhatIsYourSecurityCode.aspx", "displayWindow", "top=40,left=50,width=500,height=200,toolbar,scroll=auto");
}

function NumberValidator(srcControl) {    

    str = srcControl.value;
    str += '';
    var rgx = /^\d|\.|-$/;
    var out = '';

    for (var i = 0; i < str.length; i++) {
        if (rgx.test(str.charAt(i))) {
            if (!((str.charAt(i) == '.' && out.indexOf('.') != -1) ||
             (str.charAt(i) == '-' && out.length != 0))) {
                out += str.charAt(i);
            }
        }
    }

    srcControl.value = out;
}

function AddOption(selectbox, text, value) {
    var optn = document.createElement("OPTION");
    optn.text = text;
    optn.value = value;
    selectbox.options.add(optn);
}

function LoadStatesProvinces(countryDropDown) {

    var statesProvinciesDropDown = document.getElementById('ctl00_MainContent_statesProvincesDropDownList');
    var localityTextBox = document.getElementById('ctl00_MainContent_stateprovincelocalityTextBox');
    var localityLabel = document.getElementById('ctl00_MainContent_localityLabel');
    var provinceLabel = document.getElementById('ctl00_MainContent_proviceLabel');
    var stateLabel = document.getElementById('ctl00_MainContent_stateLabel');
    var localityTextBoxValidator = document.getElementById('ctl00_MainContent_stateprovincelocalityTextBoxRequiredFieldValidator');
    var statesProvinciesDropDownValidator = document.getElementById('ctl00_MainContent_statesProvincesDropDownListRequiredFieldValidator');    
    var country = countryDropDown.value;

    localityTextBox.style.display = 'none';
    localityLabel.style.display = 'none';
    statesProvinciesDropDown.style.display = 'none';
    provinceLabel.style.display = 'none';
    stateLabel.style.display = 'none';
    ValidatorEnable(localityTextBoxValidator, false);
    ValidatorEnable(statesProvinciesDropDownValidator, false); 

    if (country == "CA" || country == "US") {

        statesProvinciesDropDown.style.display = 'inline';
        ValidatorEnable(statesProvinciesDropDownValidator, true); 

        if (country == "CA") {
            var list = canadianProvinces;
            provinceLabel.style.display = 'inline';
        }
        else if (country == "US") {
            var list = usStates;
            stateLabel.style.display = 'inline';  
        }

        statesProvinciesDropDown.options.length = 0;
        AddOption(statesProvinciesDropDown, 'Select', '-1');

        for (var i = 0; i < list.length; ++i) {
            var key = list[i].substr(list[i].lastIndexOf(':') - list[i].indexOf(':') - 1);
            var value = list[i].substr(list[i].lastIndexOf(':') + 1, list[i].length - list[i].lastIndexOf(':'));
            AddOption(statesProvinciesDropDown, value, key);
        }
    }
    else {
        localityTextBox.style.display = 'inline';
        localityLabel.style.display = 'inline';
        ValidatorEnable(localityTextBoxValidator, true);
    }
}
