<%@ page language="C#" autoeventwireup="true" inherits="AddAccountPlanInfo, App_Web_or1ni4yr" %>
<%@ Register TagPrefix="uc" TagName="LoginNavigation" Src="~/LoginNavigationControl.ascx" %>
<%--
<?php
include_once( '../../UssReg.php' );
session_start();
$regObject = $_SESSION['reg'];
include_once( '../../autoloader.php' );
$aria = new AriaBillingComplete( 
    Array( 
        'client_no' => $config['client_no'],
        'auth_key' => $config['auth_key'],
        'debug' => false,
        'url' => $config['api_url']
    ) );

        $result = $aria->get_client_plans_all(  );
       
if( $_SERVER['REQUEST_METHOD'] == 'POST' )
{
    include_once( '../../UssReg.php' );
    $regObject->setValue( $_POST );
    $regObject->validateParams( 'plan' );
    if( isset ( $regObject->error_code['plan'] ) && $regObject->error_code['plan'] == 0 )
    {
        $_SESSION['reg'] = $regObject;
        header( "Location: ./paymentInfo.php");
    }
    
}    
?>--%>
<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en" lang="en" dir="ltr">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>Confirm and enter your Payment Information</title>
<script type="text/javascript" src="../scripts/reg.js"></script>

</head>
<link type="text/css" href="App_Themes/main.css" rel="stylesheet"/>
<link type="text/css" href="App_Themes/layout.css" rel="stylesheet"/>
<body>
<div id="a_header" class="clearfix">
  <div class="right"> <a href="Login.aspx">Sign in&nbsp;</a></div>
</div>
<div class="logo2"> 
<img width="93" height="50" src="App_Themes/images/aria_logo.gif"/>
</div><div id="content" class="signup">
  <div class="pg_title">
    <h1>Plan Information</h1>
  </div>
  <div style="width: 1024px">

  <uc:LoginNavigation ID="lgnNav" runat="server" />
  <div class="pg_box">
    <div class="box_top"> </div>

    <div class="box_content">
      <div class="PgTwoColumn_Container clearfix">
        <div class="PgTwoColumn_Content">
          <form id="Form1" runat="server">
             <div class="sec_title" id="PI1">
          <h2>4.Plan Information</h2>
        </div>
        <p class="subtext"> * Denotes required fields. </p>
        <p><font color="red">
       </font></p>
        <fieldset>
          <dt>* Plan</dt>
          <dd>

            <select id="ddlPlans" runat="server" datatextfield="plan_name" datavaluefield="plan_no" style="width: 450px;" width="450" name="plan_no">
              
             
            </select>
            <asp:RequiredFieldValidator ID="rfvPlans" runat="server" Display="Dynamic" ControlToValidate="ddlPlans">*<br />required</asp:RequiredFieldValidator>
          </dd>
        </fieldset>
         <div class="Section_Container">
           
              <div class="Section_Content">
                
        <fieldset>
          <dl>
            <dt></dt>
            <dd>
              <input id="btnSubmit" runat="server" style="float: right;" type="button" class="btn_prefer" value="Continue"
							OnServerClick="btnSubmit_ServerClick" causesvalidation="true">
            </dd>
          </dl>

        </fieldset>
      </form>
    </div>
   
  </div>
        </div>

      </div>
    </div>
    <div class="box_bottom"> </div>
  </div>
<div id="a_footer"> &copy; 2010 Aria Systems Inc. All rights reserved.</div>

</body>
</html>
