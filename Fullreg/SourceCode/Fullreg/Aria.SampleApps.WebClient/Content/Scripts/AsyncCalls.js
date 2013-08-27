
function TimerLoadPlans() {            
    setTimeout("LoadPlans()", 1000);            
}

function LoadPlans() {
    document.getElementById('ctl00_MainContent_planInfoUserControl_btnLoad').click();
    //document.getElementById('<%= btnLoad.ClientID %>').click();
}

function LoadSuppPlansAndPlanServices(msg) {    
    var context = new Object();
    context.msg = msg;
    //Registered from code behind as:function CallServer(arg, context)
    CallServer(context.msg, context);
}

function CallbackOnSucceeded(result, context) {
    //alert("Successfull Callback: " + result);
    //document.getElementById('<%= LoadSuppPlansAndServicesButton.ClientID %>').click();    
    document.getElementById('ctl00_MainContent_planInfoUserControl_LoadSuppPlansAndServicesButton').click();    
}

function CallbackOnFailed(result, context) {
    //alert("Callback Error: " + result);
}