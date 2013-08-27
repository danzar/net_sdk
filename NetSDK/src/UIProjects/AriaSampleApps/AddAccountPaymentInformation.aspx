<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AddAccountPaymentInformation.aspx.cs" Inherits="AddAccountPaymentInformation" %>
<%@ Register TagPrefix="uc" TagName="State" Src="~/StateProvinceControl.ascx" %>
<%@ Register TagPrefix="uc" TagName="LoginNavigation" Src="~/LoginNavigationControl.ascx" %>

<%--<?php 
include_once( '../../UssReg.php' );
session_start();
$regObject = $_SESSION['reg'];
if( $_SERVER['REQUEST_METHOD'] == 'POST' )
{
    include_once( '../../UssReg.php' );
    $regObject->setValue( $_POST );
    $regObject->validateParams( 'payment' );
    if( isset ( $regObject->error_code['payment'] ) && $regObject->error_code['payment'] == 0 )
    {
        $_SESSION['reg'] = $regObject;
        header( "Location: ./preview.php");
    }
    
}
else
{
    if ( isset( $regObject ) )
    {
        $addressString = $regObject->getValue('street1').'|'.
                         $regObject->getValue('street2').'|'.
                         $regObject->getValue('city').'|'.
                         $regObject->getValue('country').'|'.
                         $regObject->getValue('state').'|'.
                         $regObject->getValue('zip_code');
    
    
    }
}
?>--%>
<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en" lang="en" dir="ltr">
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>Confirm and enter your Payment Information</title>

<script type="text/javascript" src="_includes/js/country.js"></script>
<script type="text/javascript" src="_includes/js/validation.js"></script>
<script type="text/javascript" src="_includes/js/reg.js"></script>
<script type="text/javascript" src="_includes/js/uss.js"></script>
  
</head>
<link type="text/css" href="App_Themes/main.css" rel="stylesheet"/>
<link type="text/css" href="App_Themes/layout.css" rel="stylesheet"/>
<body>
<script type="text/javascript">
  function MyValidatorEnable(element, enabled) {
    ValidatorEnable(element, enabled);
    element.isvalid = true;
    ValidatorUpdateDisplay(element);
  }
  function setACHValidators(enabled)
  {
    MyValidatorEnable(document.getElementById('<%=rfvRoutingNumber.ClientID %>'), enabled);
    MyValidatorEnable(document.getElementById('<%=cvRoutingNumber.ClientID %>'), enabled);
    MyValidatorEnable(document.getElementById('<%=rfvAccountNumber.ClientID %>'), enabled);
    MyValidatorEnable(document.getElementById('<%=cvAccountNumber.ClientID %>'), enabled);
  }
  function setCCValidators(enabled)
  {

    MyValidatorEnable(document.getElementById('<%=rfvCCNumber.ClientID %>'), enabled);
    MyValidatorEnable(document.getElementById('<%=cvCCNumber.ClientID %>'), enabled);
    MyValidatorEnable(document.getElementById('<%=rfvCVV.ClientID %>'), enabled);
    MyValidatorEnable(document.getElementById('<%=cvCVV.ClientID %>'), enabled);
    MyValidatorEnable(document.getElementById('<%=rfvFirstName.ClientID %>'), enabled);
    MyValidatorEnable(document.getElementById('<%=revFirstName.ClientID %>'), enabled);
    MyValidatorEnable(document.getElementById('<%=rfvLastName.ClientID %>'), enabled);
    MyValidatorEnable(document.getElementById('<%=revLastName.ClientID %>'), enabled);
    MyValidatorEnable(document.getElementById('<%=rfvBillAddress1.ClientID %>'), enabled);
    MyValidatorEnable(document.getElementById('<%=revBillAddress1.ClientID %>'), enabled);
    MyValidatorEnable(document.getElementById('<%=rfvBillCity.ClientID %>'), enabled);
    MyValidatorEnable(document.getElementById('<%=revBillCity.ClientID %>'), enabled);
    MyValidatorEnable(document.getElementById('<%=rfvCountry.ClientID %>'), enabled);
    MyValidatorEnable(document.getElementById('<%=rfvBillZip.ClientID %>'), enabled);
    MyValidatorEnable(document.getElementById('<%=rfvCCNumber.ClientID %>'), enabled);

    if (enabled) {
      if (document.getElementById('<%=ddlCountry.ClientID %>').value == "US") {
        MyValidatorEnable(document.getElementById('<%=revUSZip.ClientID %>'), enabled);

      }
      else if (document.getElementById('<%=ddlCountry.ClientID %>').value == "CA") {
        MyValidatorEnable(document.getElementById('<%=revCAZip.ClientID %>'), enabled);

      }
      else {
        MyValidatorEnable(document.getElementById('<%=revOtherZip.ClientID %>'), enabled);
      }
    }
    else {
      MyValidatorEnable(document.getElementById('<%=revUSZip.ClientID %>'), enabled);
      MyValidatorEnable(document.getElementById('<%=revCAZip.ClientID %>'), enabled);
      MyValidatorEnable(document.getElementById('<%=revOtherZip.ClientID %>'), enabled);
    }
  }
</script>
<div id="a_header" class="clearfix">
  <div class="right"> 
  <div class="right"> <a href="Login.aspx">Sign in&nbsp;</a></div></div>
</div>
<div class="logo2">
<img width="93" height="50" src="App_Themes/images/aria_logo.gif"/>
</div>
<div id="content" class="signup">
  <div class="pg_title">
    <h1>Payment Information</h1>
  </div>
  <div style="width: 1024px">

  <uc:LoginNavigation ID="lgnNav" runat="server" />
  <div class="pg_box">
    <div class="box_top"> </div>

    <div class="box_content">
      <div class="PgTwoColumn_Container clearfix">
        <div class="PgTwoColumn_Content">
          <form runat="server">
            <div class="Section_Container">
            <div class="Section_Header">
                <h2>Select a payment  option</h2>
              </div> 
              <p class="subtext"> * Denotes required fields. </p>
      
              <fieldset>
                <dt>Payment Options</dt>
                <dd>
                  <select id="ddlPaymentType" runat="server" name="pay_type"  class="fullwidth">

                    <option value=""  onclick="hide21('Ccard'); hide21('ACH'); setACHValidators(false);setCCValidators(false);" >Select One</option>
                    <option value="1" onclick="show21('Ccard'); hide21('ACH'); setACHValidators(false);setCCValidators(true);" >Credit Card</option>
                    <option value="2" onclick="hide21('Ccard'); show21('ACH'); setACHValidators(true);setCCValidators(false);" >ACH</option>
                    <option value="5" onclick="hide21('Ccard'); hide21('ACH'); setACHValidators(false);setCCValidators(false);" >Net Terms 10</option>
                    <option value="4" onclick="hide21('Ccard'); hide21('ACH'); setACHValidators(false);setCCValidators(false);" >Net Terms 30</option>
                    <option value="7" onclick="hide21('Ccard'); hide21('ACH'); setACHValidators(false);setCCValidators(false);" >Net Terms 60</option>
                  </select>
                  <asp:RequiredFieldValidator ID="rfvPaymentType" runat="server" ControlToValidate="ddlPaymentType" Display="Dynamic">*<br />required</asp:RequiredFieldValidator>
                </dd>
              </fieldset>
              <div class="Section_Content">
                <fieldset>
                  
                  <div id="ACH" style="display:none">
                    <h2>ACH</h2>
                    <dl>
                      <dt>* Routing Number</dt>
                      <dd>
                        <input type="text" id="txtRoutingNumber" runat="server" name="routing_no" autocomplete="off" maxlength="9" class="fullwidth" onblur="checkRoutingNo(this,'err_routing_no')" onkeypress = "return numbersonly(event)" />
                  <asp:RequiredFieldValidator ID="rfvRoutingNumber" runat="server" ControlToValidate="txtRoutingNumber" Display="Dynamic">*<br />required</asp:RequiredFieldValidator>
          <SCRIPT LANGUAGE="JavaScript">
            function validateRoutingNumber(oSrc, args) {
              args.IsValid = (args.Value.length == 9);
            }
         </SCRIPT>
                  <asp:CustomValidator ID="cvRoutingNumber" runat="server" ControlToValidate="txtRoutingNumber" ClientValidationFunction="validateRoutingNumber" Display="Dynamic">*<br />Must be 9 digits long<br />&nbsp;</asp:CustomValidator>

                      </dd>
                      <dt>* Account Number</dt>
                      <dd>
                        <input type="text" class="fullwidth" id="txtAccountNumber" runat="server" autocomplete="off" maxlength="19" onkeypress = "return numbersonly(event)" name="bank_acc_no"  />
                  <asp:RequiredFieldValidator ID="rfvAccountNumber" runat="server" ControlToValidate="txtAccountNumber" Display="Dynamic">*<br />required</asp:RequiredFieldValidator>
          <SCRIPT LANGUAGE="JavaScript">
            function validateAccountNumber(oSrc, args) {
              args.IsValid = (args.Value.length > 4) && (args.Value.length < 20);
            }
         </SCRIPT>
                  <asp:CustomValidator ID="cvAccountNumber" runat="server" ControlToValidate="txtAccountNumber" ClientValidationFunction="validateAccountNumber" Display="Dynamic">*<br />Must be between 5 and 19 digit long.<br />&nbsp;</asp:CustomValidator>
          
                      </dd>
                    </dl>
                  </div>

                  <div id="Ccard" style="display:none">
                    <dl>
                      <dt></dt>
                      <dd> <img src="App_Themes/images/creditcard_mc.gif"> <img src="App_Themes/images/creditcard_visa.gif"> <img src="App_Themes/images/creditcard_amex.gif"> <img src="App_Themes/images/creditcard_discover.gif"> </dd>
                      <dt>* Credit Card Number</dt>
                      <dd>

                        <input type="text" name="cc_no" id="txtCCNumber" runat="server" autocomplete="off" onkeypress = "return numbersonly(event)" class="fullwidth" onBlur="checkCCNumber(this,'err_cc_no')" maxlength="16" />
                      
                  <asp:RequiredFieldValidator ID="rfvCCNumber" runat="server" ControlToValidate="txtCCNumber" Display="Dynamic">*<br />required</asp:RequiredFieldValidator>
          <SCRIPT LANGUAGE="JavaScript">
            function validateCCNumber(oSrc, args) {
            args.IsValid = true;
            if(args.Value.length == 15 || args.Value.length == 16 )
             {


               if (isNaN(args.Value)) {
                 args.IsValid = false;
               } else {

                 var startswith = args.Value.substr(0, 1);

                 if (args.Value.length == 16 && !(startswith == 4 || startswith == 5 || startswith == 6)) {
                   args.IsValid = false;
                 }
                 else if (args.Value.length == 15 && !(startswith == 3)) {
                   args.IsValid = false;
                 }
                 else if (startswith != 3 || startswith != 4 || startswith != 5 || startswith !== 6) {
                 args.isValid = true;
                 }
               }
          		  
             }else{
             
			          args.IsValid = false;
             }
          }
            
         </SCRIPT>
                  <asp:CustomValidator ID="cvCCNumber" runat="server" ControlToValidate="txtCCNumber" ClientValidationFunction="validateCCNumber" Display="Dynamic">*<br />Invalid Credit Card Number<br />&nbsp;</asp:CustomValidator>
                      </dd>
                      <dt>* Expiration Date</dt>
                      <dd>
                        <select id="ddlExpMonth" runat="server" name="exp_month">
                          <option value="1" >1 - January</option>
                          <option value="2" >2 - February</option>
                          <option value="3" >3 - March</option>
                          <option value="4" >4 - April</option>
                          <option value="5" >5 - May</option>
                          <option value="6" >6 - June</option>
                          <option value="7" >7 - July</option>
                          <option value="8" >8 - August</option>
                          <option value="9" >9 - September</option>
                          <option value="10" >10 - October</option>
                          <option value="11" >11 - November</option>
                          <option value="12" >12 - December</option>
                        </select>
                        <select id="ddlExpirationYear" runat="server" name="exp_year" onChange="checkCCExpYear(this,'err_exp_year');">
                        </select>
                        <span id="err_exp_year" style="color: red;"> </span>
                      </dd>
                      <dt>* CVV</dt>
                      <dd>
                        <input type="text" size="5" name="cvv" id="txtCVV" runat="server" autocomplete="off" onkeypress = "return numbersonly(event)" maxlength="4" />
                        <asp:RequiredFieldValidator ID="rfvCVV" runat="server" ControlToValidate="txtCVV" Display="Dynamic">*<br />required</asp:RequiredFieldValidator>
          <SCRIPT LANGUAGE="JavaScript">
            function validateCVVNumber(oSrc, args) {
              args.IsValid = (args.Value.length == 3) || (args.Value.length ==4);
            }
         </SCRIPT>
                  <asp:CustomValidator ID="cvCVV" runat="server" ControlToValidate="txtCVV" ClientValidationFunction="validateCVVNumber" Display="Dynamic">* <BR />CVV code must be 3 or 4 digits<BR> &nbsp; </asp:CustomValidator>
          
                      </dd>
                      <dt>* Name on Card</dt>
                      <dd>
                        <input id="txtBillFirstName" runat="server" name="bill_firstname" type="text" class="halfwidth ghost" 
                                onFocus="startField(this)" />
                        
              <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ControlToValidate="txtBillFirstName" Display="Dynamic" >*<BR /> required<BR />&nbsp;</asp:RequiredFieldValidator>
              <asp:RegularExpressionValidator ID="revFirstName" runat="server" ControlToValidate="txtBillFirstName" Display="Dynamic" ValidationExpression="^[0-9a-zA-Z\s-]{1,}$">*<br />Accepts only alphanumeric characters and spaces<br />&nbsp;</asp:RegularExpressionValidator>
                        <input id="txtBillLastName" runat="server" name="bill_lastname" type="text" class="halfwidth ghost" 
							    onFocus="startField(this)" />
                      
              <asp:RequiredFieldValidator ID="rfvLastName" runat="server" ControlToValidate="txtBillLastName" Display="Dynamic" >*<BR /> required<BR />&nbsp;</asp:RequiredFieldValidator>
              <asp:RegularExpressionValidator ID="revLastName" runat="server" ControlToValidate="txtBillLastName" Display="Dynamic" ValidationExpression="^[0-9a-zA-Z\s-]{1,}$">*<br />Accepts only alphanumeric characters and spaces<br />&nbsp;</asp:RegularExpressionValidator>
              </dd>
                      <dt>&nbsp;</dt>

                      <dd> <br/>
                        <asp:CheckBox ID="chkBillingSameAsShipping" runat="server" OnCheckedChanged="chkBillingSameAsShipping_CheckedChanged" AutoPostBack="true"  />
                        My billing address is the same as my Mailing address </dd>
                      <dt>Billing Address</dt>
                      <dd>
                        <input id="txtBillAddress1" runat="server" name="bill_address1" type="text" class="fullwidth" />
                        
              <asp:RequiredFieldValidator ID="rfvBillAddress1" runat="server" ControlToValidate="txtBillAddress1" Display="Dynamic" >*<BR /> required<BR />&nbsp;</asp:RequiredFieldValidator>
              <asp:RegularExpressionValidator ID="revBillAddress1" runat="server" ControlToValidate="txtBillAddress1" Display="Dynamic" ValidationExpression="^[a-zA-Z0-9-\.,'\s-]{5,50}$">* <br />Must be between 5 and 50 alphanumeric characters, period, dash, comma, apostrophe and space<br /> &nbsp; </asp:RegularExpressionValidator><br />

                        <input  id="txtBillAddress2" runat="server" name="bill_address2" type="text" class="fullwidth" />
                      
                    <asp:RegularExpressionValidator ID="revBillAddress2" runat="server" ControlToValidate="txtBillAddress2" Display="Dynamic" ValidationExpression="^[a-zA-Z0-9-\.,'\s-]{5,50}$">* <br />Must be between 5 and 50 alphanumeric characters, period, dash, comma, apostrophe and space<br /> &nbsp; </asp:RegularExpressionValidator><br /></dd>
                      <dt>* City/Town</dt>
                      <dd>
                        <input id="txtBillCity" runat="server" name="bill_city" type="text"  onblur="checkCity(this,'err_bill_city');" class="fullwidth" />
      
              <asp:RequiredFieldValidator ID="rfvBillCity" runat="server" ControlToValidate="txtBillCity" Display="Dynamic" >*<BR /> required<BR />&nbsp;</asp:RequiredFieldValidator>
              <asp:RegularExpressionValidator ID="revBillCity" runat="server" ControlToValidate="txtBillCity" Display="Dynamic" ValidationExpression="^[a-zA-Z\.\s-]{2,}$">* <br />Invalid characters<br /> &nbsp; </asp:RegularExpressionValidator>
                      </dd>
                      <dt>* Country</dt>
                        <dd>

                      <asp:DropDownList ID="ddlCountry" runat="server" CssClass="fullwidth" AutoPostBack="true" OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged">
                      <asp:ListItem Value="AF" Text="Afghanistan"/>
                      <asp:ListItem Value="US" Text="United States" />
                      <asp:ListItem Value="AL" Text="Albania"/>
                      <asp:ListItem Value="DZ" Text="Algeria"/>
                      <asp:ListItem Value="AS" Text="American Samoa"/>
                      <asp:ListItem Value="AD" Text="Andorra"/>
                      <asp:ListItem Value="AO" Text="Angola"/>
                      <asp:ListItem Value="AI" Text="Anguilla"/>
                      <asp:ListItem Value="AQ" Text="Antarctica"/>
                      <asp:ListItem Value="AG" Text="Antigua and Barbuda"/>
                      <asp:ListItem Value="AR" Text="Argentina"/>
                      <asp:ListItem Value="AM" Text="Armenia"/>
                      <asp:ListItem Value="AW" Text="Aruba"/>
                      <asp:ListItem Value="AU" Text="Australia"/>
                      <asp:ListItem Value="AT" Text="Austria"/>
                      <asp:ListItem Value="AZ" Text="Azerbaijan"/>
                      <asp:ListItem Value="BH" Text="Bahrain"/>
                      <asp:ListItem Value="BD" Text="Bangladesh"/>
                      <asp:ListItem Value="BB" Text="Barbados"/>
                      <asp:ListItem Value="BY" Text="Belarus"/>
                      <asp:ListItem Value="BE" Text="Belgium"/>
                      <asp:ListItem Value="BZ" Text="Belize"/>
                      <asp:ListItem Value="BJ" Text="Benin"/>
                      <asp:ListItem Value="BM" Text="Bermuda"/>
                      <asp:ListItem Value="BT" Text="Bhutan"/>
                      <asp:ListItem Value="BO" Text="Bolivia"/>
                      <asp:ListItem Value="BA" Text="Bosnia Herzegowina"/>
                      <asp:ListItem Value="BW" Text="Botswana"/>
                      <asp:ListItem Value="BV" Text="Bouvet Island"/>
                      <asp:ListItem Value="BR" Text="Brazil"/>
                      <asp:ListItem Value="IO" Text="British Indian Ocean Territory"/>
                      <asp:ListItem Value="VG" Text="British Virgin Islands"/>
                      <asp:ListItem Value="BN" Text="Brunei Darussalam"/>
                      <asp:ListItem Value="BG" Text="Bulgaria"/>
                      <asp:ListItem Value="BF" Text="Burkina Faso"/>
                      <asp:ListItem Value="MM" Text="Burma"/>
                      <asp:ListItem Value="BI" Text="Burundi"/>
                      <asp:ListItem Value="KH" Text="Cambodia"/>
                      <asp:ListItem Value="CM" Text="Cameroon"/>
                      <asp:ListItem Value="CA" Text="Canada"/>
                      <asp:ListItem Value="CV" Text="Cape Verde"/>
                      <asp:ListItem Value="KY" Text="Cayman Islands"/>
                      <asp:ListItem Value="CF" Text="Central African Republic"/>
                      <asp:ListItem Value="TD" Text="Chad"/>
                      <asp:ListItem Value="CL" Text="Chile"/>
                      <asp:ListItem Value="CN" Text="China"/>
                      <asp:ListItem Value="CX" Text="Christmas Island"/>
                      <asp:ListItem Value="CC" Text="Cocos (Keeling) Islands"/>
                      <asp:ListItem Value="CO" Text="Colombia"/>
                      <asp:ListItem Value="KM" Text="Comoros"/>
                      <asp:ListItem Value="CD" Text="Congo (Democratic Republic)"/>
                      <asp:ListItem Value="CG" Text="Congo (Republic)"/>
                      <asp:ListItem Value="CK" Text="Cook Islands"/>
                      <asp:ListItem Value="CR" Text="Costa Rica"/>
                      <asp:ListItem Value="CI" Text="Cote d'Ivoire"/>
                      <asp:ListItem Value="HR" Text="Croatia"/>
                      <asp:ListItem Value="CU" Text="Cuba"/>
                      <asp:ListItem Value="CY" Text="Cyprus"/>
                      <asp:ListItem Value="CZ" Text="Czech Republic"/>
                      <asp:ListItem Value="DK" Text="Denmark"/>
                      <asp:ListItem Value="DJ" Text="Djibouti"/>
                      <asp:ListItem Value="DM" Text="Dominica"/>
                      <asp:ListItem Value="DO" Text="Dominican Republic"/>
                      <asp:ListItem Value="TL" Text="East Timor"/>
                      <asp:ListItem Value="EC" Text="Ecuador"/>
                      <asp:ListItem Value="EG" Text="Egypt"/>
                      <asp:ListItem Value="SV" Text="El Salvador"/>
                      <asp:ListItem Value="GQ" Text="Equatorial Guinea"/>
                      <asp:ListItem Value="ER" Text="Eritrea"/>
                      <asp:ListItem Value="EE" Text="Estonia"/>
                      <asp:ListItem Value="ET" Text="Ethiopia"/>
                      <asp:ListItem Value="FK" Text="Falklands"/>
                      <asp:ListItem Value="FO" Text="Faroe Islands"/>
                      <asp:ListItem Value="FJ" Text="Fiji"/>
                      <asp:ListItem Value="FI" Text="Finland"/>
                      <asp:ListItem Value="FR" Text="France"/>
                      <asp:ListItem Value="GF" Text="French Guiana"/>
                      <asp:ListItem Value="PF" Text="French Polynesia"/>
                      <asp:ListItem Value="TF" Text="French Southern Territories"/>
                      <asp:ListItem Value="GA" Text="Gabon"/>
                      <asp:ListItem Value="GE" Text="Georgia"/>
                      <asp:ListItem Value="DE" Text="Germany"/>
                      <asp:ListItem Value="GH" Text="Ghana"/>
                      <asp:ListItem Value="GI" Text="Gibraltar"/>
                      <asp:ListItem Value="GR" Text="Greece"/>
                      <asp:ListItem Value="GL" Text="Greenland"/>
                      <asp:ListItem Value="GD" Text="Grenada"/>
                      <asp:ListItem Value="GP" Text="Guadeloupe"/>
                      <asp:ListItem Value="GU" Text="Guam"/>
                      <asp:ListItem Value="GT" Text="Guatemala"/>
                      <asp:ListItem Value="GN" Text="Guinea"/>
                      <asp:ListItem Value="GW" Text="Guinea-Bissau"/>
                      <asp:ListItem Value="GY" Text="Guyana"/>
                      <asp:ListItem Value="HT" Text="Haiti"/>
                      <asp:ListItem Value="HM" Text="Heard and McDonald Islands"/>
                      <asp:ListItem Value="VA" Text="Holy See (Vatican City)"/>
                      <asp:ListItem Value="HN" Text="Honduras"/>
                      <asp:ListItem Value="HK" Text="Hong Kong (SAR)"/>
                      <asp:ListItem Value="HU" Text="Hungary"/>
                      <asp:ListItem Value="IS" Text="Iceland"/>
                      <asp:ListItem Value="IN" Text="India"/>
                      <asp:ListItem Value="ID" Text="Indonesia"/>
                      <asp:ListItem Value="IR" Text="Iran"/>
                      <asp:ListItem Value="IQ" Text="Iraq"/>
                      <asp:ListItem Value="IE" Text="Ireland"/>
                      <asp:ListItem Value="IL" Text="Israel"/>
                      <asp:ListItem Value="IT" Text="Italy"/>
                      <asp:ListItem Value="JM" Text="Jamaica"/>
                      <asp:ListItem Value="JP" Text="Japan"/>
                      <asp:ListItem Value="JO" Text="Jordan"/>
                      <asp:ListItem Value="KZ" Text="Kazakhstan"/>
                      <asp:ListItem Value="KE" Text="Kenya"/>
                      <asp:ListItem Value="KI" Text="Kiribati"/>
                      <asp:ListItem Value="KP" Text="Korea, North"/>
                      <asp:ListItem Value="KR" Text="Korea, South"/>
                      <asp:ListItem Value="KW" Text="Kuwait"/>
                      <asp:ListItem Value="KG" Text="Kyrgyzstan"/>
                      <asp:ListItem Value="LA" Text="Laos"/>
                      <asp:ListItem Value="LV" Text="Latvia"/>
                      <asp:ListItem Value="LB" Text="Lebanon"/>
                      <asp:ListItem Value="LS" Text="Lesotho"/>
                      <asp:ListItem Value="LR" Text="Liberia"/>
                      <asp:ListItem Value="LY" Text="Libya"/>
                      <asp:ListItem Value="LI" Text="Liechtenstein"/>
                      <asp:ListItem Value="LT" Text="Lithuania"/>
                      <asp:ListItem Value="LU" Text="Luxembourg"/>
                      <asp:ListItem Value="MO" Text="Macao"/>
                      <asp:ListItem Value="MK" Text="Macedonia, FYR"/>
                      <asp:ListItem Value="MG" Text="Madagascar"/>
                      <asp:ListItem Value="MW" Text="Malawi"/>
                      <asp:ListItem Value="MY" Text="Malaysia"/>
                      <asp:ListItem Value="MV" Text="Maldives"/>
                      <asp:ListItem Value="ML" Text="Mali"/>
                      <asp:ListItem Value="MT" Text="Malta"/>
                      <asp:ListItem Value="MH" Text="Marshall Islands"/>
                      <asp:ListItem Value="MQ" Text="Martinique"/>
                      <asp:ListItem Value="MR" Text="Mauritania"/>
                      <asp:ListItem Value="MU" Text="Mauritius"/>
                      <asp:ListItem Value="YT" Text="Mayotte"/>
                      <asp:ListItem Value="MX" Text="Mexico"/>
                      <asp:ListItem Value="FM" Text="Micronesia"/>
                      <asp:ListItem Value="MD" Text="Moldova"/>
                      <asp:ListItem Value="MC" Text="Monaco"/>
                      <asp:ListItem Value="MN" Text="Mongolia"/>
                      <asp:ListItem Value="MS" Text="Montserrat"/>
                      <asp:ListItem Value="MA" Text="Morocco"/>
                      <asp:ListItem Value="MZ" Text="Mozambique"/>
                      <asp:ListItem Value="NA" Text="Namibia"/>
                      <asp:ListItem Value="NR" Text="Nauru"/>
                      <asp:ListItem Value="NP" Text="Nepal"/>
                      <asp:ListItem Value="NL" Text="Netherlands"/>
                      <asp:ListItem Value="AN" Text="Netherlands Antilles"/>
                      <asp:ListItem Value="NC" Text="New Caledonia"/>
                      <asp:ListItem Value="NZ" Text="New Zealand"/>
                      <asp:ListItem Value="NI" Text="Nicaragua"/>
                      <asp:ListItem Value="NE" Text="Niger"/>
                      <asp:ListItem Value="NG" Text="Nigeria"/>
                      <asp:ListItem Value="NU" Text="Niue"/>
                      <asp:ListItem Value="NF" Text="Norfolk Island"/>
                      <asp:ListItem Value="MP" Text="Northern Mariana Islands"/>
                      <asp:ListItem Value="NO" Text="Norway"/>
                      <asp:ListItem Value="OM" Text="Oman"/>
                      <asp:ListItem Value="PK" Text="Pakistan"/>
                      <asp:ListItem Value="PW" Text="Palau"/>
                      <asp:ListItem Value="PS" Text="Palestinian Territory"/>
                      <asp:ListItem Value="PA" Text="Panama"/>
                      <asp:ListItem Value="PG" Text="Papua New Guinea"/>
                      <asp:ListItem Value="PY" Text="Paraguay"/>
                      <asp:ListItem Value="PE" Text="Peru"/>
                      <asp:ListItem Value="PH" Text="Philippines"/>
                      <asp:ListItem Value="PN" Text="Pitcairn Islands"/>
                      <asp:ListItem Value="PL" Text="Poland"/>
                      <asp:ListItem Value="PT" Text="Portugal"/>
                      <asp:ListItem Value="PR" Text="Puerto Rico"/>
                      <asp:ListItem Value="QA" Text="Qatar"/>
                      <asp:ListItem Value="RO" Text="Romania"/>
                      <asp:ListItem Value="RE" Text="RTunion"/>
                      <asp:ListItem Value="RU" Text="Russia"/>
                      <asp:ListItem Value="RW" Text="Rwanda"/>
                      <asp:ListItem Value="SH" Text="Saint Helena"/>
                      <asp:ListItem Value="KN" Text="Saint Kitts and Nevis"/>
                      <asp:ListItem Value="LC" Text="Saint Lucia"/>
                      <asp:ListItem Value="PM" Text="Saint Pierre and Miquelon"/>
                      <asp:ListItem Value="VC" Text="Saint Vincent/Grenadines"/>
                      <asp:ListItem Value="WS" Text="Samoa"/>
                      <asp:ListItem Value="SM" Text="San Marino"/>
                      <asp:ListItem Value="SA" Text="Saudi Arabia"/>
                      <asp:ListItem Value="SN" Text="Senegal"/>
                      <asp:ListItem Value="SC" Text="Seychelles"/>
                      <asp:ListItem Value="SL" Text="Sierra Leone"/>
                      <asp:ListItem Value="SG" Text="Singapore"/>
                      <asp:ListItem Value="SK" Text="Slovakia"/>
                      <asp:ListItem Value="SI" Text="Slovenia"/>
                      <asp:ListItem Value="SB" Text="Solomon Islands"/>
                      <asp:ListItem Value="SO" Text="Somalia"/>
                      <asp:ListItem Value="ZA" Text="South Africa"/>
                      <asp:ListItem Value="GS" Text="South Georgia/South Sandwich"/>
                      <asp:ListItem Value="ES" Text="Spain"/>
                      <asp:ListItem Value="ST" Text="Spo TomT and Prfncipe"/>
                      <asp:ListItem Value="LK" Text="Sri Lanka"/>
                      <asp:ListItem Value="SD" Text="Sudan"/>
                      <asp:ListItem Value="SR" Text="Suriname"/>
                      <asp:ListItem Value="SJ" Text="Svalbard"/>
                      <asp:ListItem Value="SZ" Text="Swaziland"/>
                      <asp:ListItem Value="SE" Text="Sweden"/>
                      <asp:ListItem Value="CH" Text="Switzerland"/>
                      <asp:ListItem Value="SY" Text="Syria"/>
                      <asp:ListItem Value="TW" Text="Taiwan"/>
                      <asp:ListItem Value="TJ" Text="Tajikistan"/>
                      <asp:ListItem Value="TZ" Text="Tanzania"/>
                      <asp:ListItem Value="TH" Text="Thailand"/>
                      <asp:ListItem Value="BS" Text="The Bahamas"/>
                      <asp:ListItem Value="GM" Text="The Gambia"/>
                      <asp:ListItem Value="TG" Text="Togo"/>
                      <asp:ListItem Value="TK" Text="Tokelau"/>
                      <asp:ListItem Value="TO" Text="Tonga"/>
                      <asp:ListItem Value="TT" Text="Trinidad and Tobago"/>
                      <asp:ListItem Value="TN" Text="Tunisia"/>
                      <asp:ListItem Value="TR" Text="Turkey"/>
                      <asp:ListItem Value="TM" Text="Turkmenistan"/>
                      <asp:ListItem Value="TC" Text="Turks and Caicos"/>
                      <asp:ListItem Value="TV" Text="Tuvalu"/>
                      <asp:ListItem Value="UG" Text="Uganda"/>
                      <asp:ListItem Value="UA" Text="Ukraine"/>
                      <asp:ListItem Value="AE" Text="United Arab Emirates"/>
                      <asp:ListItem Value="GB" Text="United Kingdom"/>
                      <asp:ListItem Value="UM" Text="United States Minor Outlying"/>
                      <asp:ListItem Value="UY" Text="Uruguay"/>
                      <asp:ListItem Value="UZ" Text="Uzbekistan"/>
                      <asp:ListItem Value="VU" Text="Vanuatu"/>
                      <asp:ListItem Value="VE" Text="Venezuela"/>
                      <asp:ListItem Value="VN" Text="Vietnam"/>
                      <asp:ListItem Value="VI" Text="Virgin Islands"/>
                      <asp:ListItem Value="WF" Text="Wallis and Futuna"/>
                      <asp:ListItem Value="EH" Text="Western Sahara"/>
                      <asp:ListItem Value="YE" Text="Yemen"/>
                      <asp:ListItem Value="YU" Text="Yugoslavia"/>
                      <asp:ListItem Value="ZM" Text="Zambia"/>
                      <asp:ListItem Value="ZW" Text="Zimbabwe"/>
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="rfvCountry" runat="server"
                                          ControlToValidate="ddlCountry"
                                          Display="Dynamic"
                                          ErrorMessage="required"
                                          InitialValue=""
                                          ValidationGroup="EDIT_ACCOUNT" SetFocusOnError="true"/>
                        </dd>
                        <dt><label for="bill_state"><asp:Literal id="litState" runat="server" >State</asp:Literal>: </label></dt>
                        <dd>                            
                            <uc:State id="ucState" runat="server" ValidationGroup="EDIT_ACCOUNT" />
                      <dt>* Zip Code</dt>
                      <dd>
                        <input id="txtBillZip" runat="server" name="bill_zip" type="text"  maxlength="15" class="fullwidth" />
                        
                        <asp:RequiredFieldValidator ID="rfvBillZip" runat="server"
                                          ControlToValidate="txtBillZip"
                                          Display="Dynamic"
                                          ErrorMessage="required"
                                          InitialValue=""
                                          ValidationGroup="EDIT_ACCOUNT" SetFocusOnError="true"/>
              <asp:RegularExpressionValidator ID="revUSZip" runat="server" ControlToValidate="txtBillZip" Display="Dynamic" ValidationExpression="^[0-9]{5}([- ]?[0-9]{4})?$">* <br />US zip code must have between 5 and 10 numeric digits&nbsp; </asp:RegularExpressionValidator>
              <asp:RegularExpressionValidator ID="revCAZip" runat="server" ControlToValidate="txtBillZip" Display="Dynamic" Enabled="false" ValidationExpression="^[A-Za-z][0-9][A-Za-z][\s ]?[0-9][A-Za-z][0-9]$">* <br />Canadian postal code must have the following format: A0A 0A0&nbsp; </asp:RegularExpressionValidator>
              <asp:RegularExpressionValidator ID="revOtherZip" runat="server" ControlToValidate="txtBillZip" Display="Dynamic" Enabled="false" ValidationExpression="^[0-9]{5}([- ]?[0-9]{4})?$">* <br />Zip/postal code must have between 5 and 15 alphanumeric digits&nbsp; </asp:RegularExpressionValidator>
                      </dd>
                    </dl>
                  </div>

                </fieldset>

        
        <fieldset>
          <dl>
            <dt></dt>
            <dd>
              <input id="btnSubmit"  runat="server" style="float: right;" type="button" class="btn_prefer" value="Continue"
							 onserverclick="btnSubmit_ServerClick">
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
  </div>
</div>
<div id="a_footer"> &copy; 2010 Aria Systems Inc. All rights reserved.</div>

</body>
</html>
