//Configure the no confict with Jquery.
var $j = jQuery.noConflict();

//Start Common Event Handlers
var pageRequestManager = Sys.WebForms.PageRequestManager.getInstance();

pageRequestManager.add_beginRequest(commonBeginRequestHandler);
pageRequestManager.add_endRequest(commonEndRequestHandler);
pageRequestManager.add_pageLoaded(commonPageLoadedHandler);

//Fires every page load an every callback start
function commonPageLoadedHandler(sender, args) {

    // Prevent accidental navigation away
    $j(':input', document.aspnetForm).change(function (e) { setConfirmUnload(true); });
    $j(':input', document.aspnetForm).keydown(function (e) { setConfirmUnload(true); });

    //Set maxlength of all the textarea (call plugin)
    $j("textarea[maxlength]").maxlength();

    //Call the jquery tooltip plugin
    $j("a, input, img").tooltip({
        track: true,
        delay: 0,
        showURL: false,
        showBody: " - ",
        fade: 250
    });
}

//Fires every page load an every callback start
function commonBeginRequestHandler(sender, args) {
    var mensajeLoad = $j('#loadingBox');
    if (mensajeLoad == null)
        return;
        
    $j.blockUI({ message: $j('#loadingBox'),
        overlayCSS: { backgroundColor: '#000', opacity: 0.1, cursor: 'default' },
        centerY: 0,
        css: { 
            top: '90%',
            left: '90%',
            width:'100px',
            border: 'none',
            backgroundColor: '#000',
            '-webkit-border-radius': '10px',
            '-moz-border-radius': '10px',
            opacity: .6,
            color: '#fff'
        }
    });
}

//Fires every page load an every callback end
function commonEndRequestHandler(sender, args) {
    $j.unblockUI();
}


var confirmUnload = false;
var isSearchingPage = false;
var disableConfirmUnload = true;

function setConfirmUnload(on) {
    confirmUnload = on;
    //window.onbeforeunload = (on) ? unloadMessage : null;
}

function unloadMessage() {
    if (!disableConfirmUnload) {
        var prm = Sys.WebForms.PageRequestManager.getInstance();
        if (!prm._processingRequest) {
            // return unloadMessageText;
        }
    }
}

function isAtLeastOneRowSelected(gridViewId) {
    if ($j('input[id*=' + gridViewId + '][type=checkbox]:checked').length > 0) {
        return true;
    }
    return false;
}

function isAtLeastOneRowRadioSelected(gridViewId) {
    if ($j('input[id*=' + gridViewId + '][type=radio]:checked').length > 0) {
        return true;
    }
    return false;
}


function selectAllCheckBoxes(checkControl, gridViewId) {
    var checked_status = checkControl.checked;
    $j('input[id*=' + gridViewId + '][type=checkbox]').each(function () {
        this.checked = checked_status;
    });
    return true;
}

function isOnlyOneRowSelected(gridViewId) {
    if ($j('input[id*=' + gridViewId + '][type=checkbox]:checked').length == 1) {
        return true;
    }
    return false;
}

function datePickerSelectionChanged() {
    setConfirmUnload(true);
}

pageRequestManager.add_pageLoaded(fixComboWidth);

function fixComboWidth() {
//    $j("select").each(dropDownIEWidthFix);
};

function ValidateDateFormat(sender, args) {
    try {
            if (args.Value == "dd/mm/yyyy") {
                args.IsValid = true;
            }
            else {
                var fecha = args.Value.split("/");
                var dia;
                var mes;
                var ano;
            
                dia = fecha[0];
                mes = fecha[1];
                ano = fecha[2];
         
                var estado = true;
                if (dia.length == 1) {
                    dia = "0" + dia;
                }
                if (mes.length == 1) {
                    mes = "0" + mes;
                }
                if ((dia.length == 2) && (mes.length == 2) && (ano.length == 4)) {

                    mes = parseInt(mes, 10);
                    dia = parseInt(dia, 10);

                    switch (mes) {
                        case 1:
                            dmax = 31;
                            break;
                        case 2:
                            if (ano % 4 == 0) {
                                dmax = 29;
                            }
                            else {
                                dmax = 28;
                            }
                            break;
                        case 3:
                            dmax = 31;
                            break;
                        case 4:
                            dmax = 30;
                            break;
                        case 5:
                            dmax = 31;
                            break;
                        case 6:
                            dmax = 30;
                            break;
                        case 7:
                            dmax = 31;
                            break;
                        case 8:
                            dmax = 31;
                            break;
                        case 9:
                            dmax = 30;
                            break;
                        case 10:
                            dmax = 31;
                            break;
                        case 11:
                            dmax = 30;
                            break;
                        case 12:
                            dmax = 31;
                            break;
                    }
                    dmax != "" ? dmax : dmax = -1;
                    if ((dia >= 1) && (dia <= dmax) && (mes >= 1) && (mes <= 12)) {

                        for (var i = 0; i < fecha[0].length; i++) {
                            diaC = fecha[0].charAt(i).charCodeAt(0);
                            (!((diaC > 47) && (diaC < 58))) ? estado = false : '';
                            mesC = fecha[1].charAt(i).charCodeAt(0);
                            (!((mesC > 47) && (mesC < 58))) ? estado = false : '';
                        }
                   
                        for (var i = 0; i < fecha[2].length; i++) {
                            anoC = fecha[2].charAt(i).charCodeAt(0);
                            (!((anoC > 47) && (anoC < 58))) ? estado = false : '';
                        }
                    }
                    else {
                        estado = false;
                    }

                }
                else {
                    estado = false;
                }

            args.IsValid = estado;
        }
    }
    catch (err) {
        args.IsValid = false;
    }
}

function cutLabels() {
    $j("span[id*=Label]").each(function () {
        if (this.innerHTML.indexOf("&shy;") == -1) {
            var chars = this.innerHTML.split("");
            this.innerHTML = chars.join("&shy;");
        }
    })
}

//Manejo por javascript de los mensajes de la aplicación.
var ModalPopupMessageType = { "Success": 0, "Info": 1, "Warning": 2, "Error": 3, "Question": 4, "Block": 5 , "ConfirmExit": 6};

function showModalMessage(message, messageType) {

    //doPostBack = typeof (doPostBack) != 'undefined' ? doPostBack : false;

    $j("#" + modalMessageTextLabelID).html(message);

    switch (messageType) {
        case ModalPopupMessageType.Success:
            $j("#" + modalMessageImageID).attr('src', rootIconsPath + "yes.png");
            break;
        case ModalPopupMessageType.Info:
            $j("#" + modalMessageImageID).attr('src', rootIconsPath + "warning.png");
            break;
        case ModalPopupMessageType.Warning:
            $j("#" + modalMessageImageID).attr('src', rootIconsPath + "warning.png");
            break;
        case ModalPopupMessageType.Error:
            $j("#" + modalMessageImageID).attr('src', rootIconsPath + "no.png");
            break;
        case ModalPopupMessageType.Question:
            $j("#" + modalMessageImageID).attr('src', rootIconsPath + "warning.png");
            break;
        case ModalPopupMessageType.Block:
            $j("#" + modalMessageImageID).attr('src', rootIconsPath + "no.png");
            break;
        case ModalPopupMessageType.ConfirmExit:
            $j("#" + modalMessageImageID).attr('src', rootIconsPath + "yes.png");
            break;
    }
}

pageRequestManager.add_pageLoaded(setMenuItemStyle);

function setMenuItemStyle() {
    
    //if it's already fixed, return
    if ($j("tr[id*=customMenu] > td > table").hasClass("dynamicMenuTable")) return;

    // Fix children    
    $j("tr[id*=customMenu] > td > table").addClass("dynamicMenuTable");
    $j("tr[id*=customMenu] > td > table > tbody > tr > td").addClass("dynamicMenuItem");

    // put arrow and remove postback in intermeditate children
    $j(".dynamicMenuItem > a[href^=javascript]").parent().after("<td class='dynamicMenuItem'><IMG alt='' width='7px' align='right' valign='middle' src='/Content/Images/Menu/arrow_r.gif'></td>");
    $j(".dynamicMenuItem > a[href^=javascript]").attr("href", "javascript:void(0)");

    //Fix headers
    $j("td[id*=customMenu] > table > tbody > tr > td > a[href^=javascript]").attr("href", "javascript:void(0)");
    
    $j("table[id$=customMenu]").show();
}

function removeFromList(obj) {
    var id = $j("#" + obj.id).prev().val();
    var currentItemString = $j("#" + obj.id).parents("div:first").next().val();
    var currentItemList = JSON.parse(currentItemString);
    var newItemList = new Array();
    for (var i = 0; i < currentItemList.length; i++) {
        if (currentItemList[i].Value != id) {
            newItemList.push(currentItemList[i]);
        }
    }

    $j("#" + obj.id).parents("div:first").next().val(JSON.stringify(newItemList));
    $j("#" + obj.id).parents("tr:first").remove();
}

function validateAdvanceListItems(sender, args) {
    var advanceListItem = JSON.parse(args.Value);
    args.IsValid = advanceListItem.length > 0;
}
