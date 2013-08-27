<%@ Page Language="C#" AutoEventWireup="true" CodeFile="USS.aspx.cs" Inherits="Aria.USS" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<%@ Register TagPrefix="uc" TagName="State" Src="~/StateProvinceControl.ascx" %>

<html>
<head id="ussHead" runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<title>Review and Edit</title>
<script type="text/javascript" src="<%= ResolveUrl("~/_includes/js/basic.js")%>" ></script>
<script type="text/javascript" src="<%= ResolveUrl("~/_includes/js/form.js")%>" ></script>
<script type="text/javascript" src="<%= ResolveUrl("~/_includes/js/country.js")%>" ></script>
<script type="text/javascript" src="<%= ResolveUrl("~/_includes/js/validation.js")%>" ></script>

<script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/prototype/1.6.0.2/prototype.js"></script>
<link rel="stylesheet" type="text/css" runat="server" href="~/App_Themes/main.css"/>
<link rel="stylesheet" type="text/css" runat="server" href="~/App_Themes/layout.css"/>
<link rel="stylesheet" type="text/css" runat="server" href="~/App_Themes/uss.css"/>

</head>

<body>
<form id="frmAccountInfo" runat="server">
  <div id="a_header" class="clearfix">
    <div class="right"> <a href='<%= ResolveUrl("~/Logout.aspx") %>'>Sign out</a>&nbsp; </div>
    <div class="right">

      <div class="user_defined_field realm_name" title="You are logged in"> Logged in: <asp:Literal ID="litWelcomeFullName" runat="server" /> </div>
    </div>
  </div>
  <div class="logo2"></div>
  <div id="content" class="manage">
    <div class="PgTitle">
      
    </div>
    <h1 style="margin-left: 125px;"><span class="sec_name">My Account Profile</span> </h1>

    <div id="main">
      <div id="container">
      <p><font color="red">
         </font>
       </p>
        <div id="mainmenu">
          <ul id="tabs">
            <li> <a id="tab1_tab" href="#tab1" onclick="hide21('divChangesMessage');">Account Information</a> </li>
            <li> <a id="tab2_tab" href="#tab2" onclick="hide21('divChangesMessage');">Plan & Order Information</a> </li>
            <li> <a id="tab3_tab" href="#tab3" onclick="hide21('divChangesMessage');">Pay Method</a> </li>
            <li> <a id="tab5_tab" href="#tab5" onclick="hide21('divChangesMessage');">Transaction History</a> </li>
           
          </ul>
          <div class="PgOneColumn_Container clearfix">
            
            <input type="hidden" name="section" id="section" value="account"/>
            <div class="PgOneColumn_Content">
              <div id="divChangesMessage" runat="server" class="msgFeedback" >
                <asp:Literal ID="litChangesMessage" runat="server" Text=" Your changes have been saved. " />
              </div>
            </div>
            <div class="panel" id="tab1">
              <div class="Portlet_Container info_section">
                <div class="Portlet_Content">

                  <div id="info_section_company"  class="info_section_container clearfix" style="width:48%; float:left">
                    <div id="info_section_display_company" class="info_section_display">
                      
                      <div style="width:100%; float:left">
                        <div class="info_item">
                          <div class="info_label">Name</div>
                          <div class="info_data">
                            <asp:Literal ID="litFullName" runat="server" />
                          </div>
                        </div>
                        <div class="info_item">

                          <div class="info_label">User ID </div>
                          <div class="info_data"><asp:Literal ID="litUserId" runat="server" /><br/>
                          </div>
                        </div>
                        
                        <div class="info_item">
                          <div class="info_label">Security Question</div>
                          <div class="info_data"><asp:Literal ID="litSecretQuestion" runat="server"></asp:Literal></div>
                        </div>
                        <div class="info_item">
                          <div class="info_label">Your Answer</div>

                          <div class="info_data"><asp:Literal ID="litYourAnswer" runat="server" /></div>
                        </div>
                        <div class="info_item">
                          <div class="info_label">Address</div>
                          <div class="info_data"><asp:Literal ID="litAddress" runat="server" />
                          </div>
                        </div>
                       
                        <div class="info_item">
                          <div class="info_label">Phone Number</div>

                          <div class="info_data"><asp:Literal ID="litPhone" runat="server" /></div>
                        </div>
                        <div class="info_item">
                          <div class="info_label">E-mail Address</div>
                          <div class="info_data"><asp:Literal ID="litEmail" runat="server" /></div>
                        </div>
                      </div>

                    </div>
                  </div>
                  <div id="info_section_editor_company" class="info_section_editor" style="width:48%; float:left">
                    <table border="0" cellspacing="2" cellpadding="5">
                      <tr>
                        <td width="21%">Name</td>
                        <td align="left" width="45%">
                        <input id="txtFirstName" runat="server" name="first_name" type="text" class="fullwidth"/>
                        <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" 
                                  ControlToValidate="txtFirstName"
                                  Display="Dynamic" 
                                  ErrorMessage="required"
                                  ValidationGroup="EDIT_ACCOUNT" SetFocusOnError="true"/>
                        <asp:RegularExpressionValidator ID="revFirstName" runat="server"
                                                        ControlToValidate="txtFirstName"
                                                        Display="Dynamic"
                                                        ErrorMessage="Accepts only alphanumeric characters and spaces"
                                                        ValidationExpression="^[0-9a-zA-Z\s-]{1,}$"
                                                        ValidationGroup="EDIT_ACCOUNT" SetFocusOnError="true"/>     
                        <input id="txtLastName" runat="server" name="last_name" type="text" class="fullwidth"/>
                        <asp:RequiredFieldValidator ID="rfvLastName" runat="server" 
                                  ControlToValidate="txtLastName"
                                  Display="Dynamic" 
                                  ErrorMessage="required"
                                  ValidationGroup="EDIT_ACCOUNT" SetFocusOnError="true"/>
                        <asp:RegularExpressionValidator ID="revLastName" runat="server"
                                                        ControlToValidate="txtLastName"
                                                        Display="Dynamic"
                                                        ErrorMessage="Accepts only alphanumeric characters and spaces"
                                                        ValidationExpression="^[0-9a-zA-Z\s-]{1,}$"
                                                        ValidationGroup="EDIT_ACCOUNT" SetFocusOnError="true"/>
                        </td>
                      </tr>

                      <tr>
                        <td>User ID </td>
                        <td align="left">
                        <input id="txtUserId" runat="server" type="text" class="fullwidth ghost" disabled="disabled" name="user_id" />
                        </td>
                      </tr>
                      <tr>
                        <td>Password</td>
                        <td align="left" id="pass4" style="display:none">
                        <a href="#" onclick="show21('pass0'); hide21('pass1'); hide21('pass2'); hide21('pass3');  hide21('pass4'); emptyField('txtCurrentPassword');emptyField('txtPassword');emptyField('txtRetypePassword');"> Cancel Change</a></td>

                        <td id="pass0"><a href="#" onclick="hide21('pass0'); show21('pass1'); show21('pass2'); show21('pass3');  show21('pass4');"> Change Password</a></td>
                      </tr>
                      <tr id="pass1" style="display:none">
                        <td>Current Password</td>
                        <td align="left">
                        
                        <input type="password" class="fullwidth ghost" id="txtCurrentPassword" runat="server" name="current_password" value="" onfocus="startField(this)"  />
                        <asp:RequiredFieldValidator ID="rfvCurrentPassword" runat="server" 
                                  ControlToValidate="txtCurrentPassword"
                                  Display="Dynamic" 
                                  ErrorMessage="required"
                                  ValidationGroup="EDIT_PASSWORD" SetFocusOnError="true"/>
                        <asp:CustomValidator ID="cvCurrentPassword" runat="server" 
                                  ControlToValidate="txtCurrentPassword"
                                  Display="Dynamic" 
                                  ErrorMessage="does not match existing"
                                  ValidationGroup="EDIT_PASSWORD" SetFocusOnError="true" 
                                  OnServerValidate="currentPassword_ServerValidate"/>
                        </td>
                      </tr>
                      <tr id="pass2" style="display:none">

                        <td>New Password</td>
                        <td align="left">
                        <input type="password" class="fullwidth ghost" id="txtPassword" runat="server" name="password"  value="" onfocus="startField(this)" />
                        <asp:RequiredFieldValidator ID="rfvPassword" runat="server"
                                          ControlToValidate="txtPassword"
                                          Display="Dynamic"
                                          ErrorMessage="required"
                                          ValidationGroup="EDIT_PASSWORD" SetFocusOnError="true"/>
                        <asp:RegularExpressionValidator ID="revPassword" runat="server" 
                                              ControlToValidate="txtPassword" 
                                              Display="Dynamic"  
                                              ErrorMessage="Accepts only 6-50 alphanumeric characters, and can include +-_!^@#%&*()."
                                              ValidationExpression="^[a-zA-Z0-9+-_!^@#%&*()\.]{6,50}$" 
                                              ValidationGroup="EDIT_PASSWORD" SetFocusOnError="true" />
                        </td>
                      </tr>
                      <tr id="pass3" style="display:none">
                        <td>Re-enter Password</td>
                        <td align="left">
                        <input type="password" class="fullwidth ghost"  id="txtRetypePassword"  runat="server" name="re_password"  value="" onfocus="startField(this)"/>
                        <asp:RequiredFieldValidator ID="rfvRetypePassword" runat="server"
                                          ControlToValidate="txtRetypePassword"
                                          Display="Dynamic"
                                          ErrorMessage="required"
                                          ValidationGroup="EDIT_PASSWORD" SetFocusOnError="true"/>
                        <asp:CompareValidator ID="cmpRetypePassword" runat="server"
                                              ControlToCompare="txtPassword"
                                              ControlToValidate="txtReTypePassword"
                                              Display="Dynamic"
                                              ErrorMessage="Passwords don\'t match"
                                              ValidationGroup="EDIT_PASSWORD" SetFocusOnError="true"/>
                        </td>
                      </tr>
                      
                      <tr>
                        <td valign="top">Street address</td>
                        <td align="left">
                        <input id="txtAddress1" runat="server" name="street1" type="text" class="fullwidth" />
                        <asp:RequiredFieldValidator ID="rfvAddress1" runat="server"
                                          ControlToValidate="txtAddress1"
                                          Display="Dynamic"
                                          ErrorMessage="required"
                                          ValidationGroup="EDIT_ACCOUNT" SetFocusOnError="true"/>
                        <asp:RegularExpressionValidator ID="revAddress1" runat="server" 
                                              ControlToValidate="txtAddress1" 
                                              Display="Dynamic"  
                                              ErrorMessage="Must be between 5 and 50 alphanumeric characters, period, dash, comma, apostrophe and space"
                                              ValidationExpression="^[a-zA-Z0-9-\.,'\s-]{5,50}$" 
                                              ValidationGroup="EDIT_ACCOUNT" SetFocusOnError="true" />
                          <br>
                          <input id="txtAddress2" runat="server" name="street2" type="text" class="fullwidth" />
                          <asp:RegularExpressionValidator ID="revAddress2" runat="server" 
                                              ControlToValidate="txtAddress2" 
                                              Display="Dynamic"  
                                              ErrorMessage="Must be between 5 and 50 alphanumeric characters, period, dash, comma, apostrophe and space"
                                              ValidationExpression="^[a-zA-Z0-9-\.,'\s-]{5,50}$" 
                                              ValidationGroup="EDIT_ACCOUNT" SetFocusOnError="true" />
                        </td>
                      </tr>
                      <tr>

                        <td>City/Town</td>
                        <td align="left">
                        <input id="txtCity" runat="server" name="city" type="text"  class="fullwidth" />
                        <asp:RequiredFieldValidator ID="rfvCity" runat="server"
                                          ControlToValidate="txtCity"
                                          Display="Dynamic"
                                          ErrorMessage="required"
                                          ValidationGroup="EDIT_ACCOUNT" SetFocusOnError="true"/>
                        <asp:RegularExpressionValidator ID="revCity" runat="server" 
                                              ControlToValidate="txtCity" 
                                              Display="Dynamic"  
                                              ErrorMessage="Invalid characters"
                                              ValidationExpression="^[a-zA-Z\.\s-]{2,}$" 
                                              ValidationGroup="EDIT_ACCOUNT" SetFocusOnError="true" />
                        </td>
                      </tr>
                      <tr>
                        <td><asp:Literal id="litLocalityTitle" runat="server" /></td>
                        <td align="left">
                        <uc:State id="ucState" runat="server" ValidationGroup="EDIT_ACCOUNT" />
                      </td>

                      </tr>
                      <tr>
                        <td valign="top">Zip code</td>
                        <td align="left">
                        <input id="txtZipCode" runat="server" name="zip_code" type="text" class="fullwidth" onkeypress = "return numbersonly(event)" />
                        <asp:RequiredFieldValidator ID="rfvZipCode" runat="server" ControlToValidate="txtZipCode" Display="Dynamic" >*<BR /> required<BR />&nbsp;</asp:RequiredFieldValidator>
                        </td>
                      </tr>
                      <tr>
                        <td>Country </td>
                        <td align="left">
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
                        </td>
                      </tr> 
                      <tr>
                        <td>Phone number</td>
                        <td align="left"><input id="txtPhone" runat="server" name="phone" type="text" class="fullwidth" />
                        <asp:RegularExpressionValidator ID="revUSCAPhone" runat="server" 
                                              ControlToValidate="txtPhone" 
                                              Display="Dynamic"  
                                              ErrorMessage="US/CA phone number must be 10-20 digits"
                                              ValidationExpression="^\(?^[0-9]{3}\)?[-. ]?[0-9]{3}[-. ]?[0-9]{4}$" 
                                              ValidationGroup="EDIT_ACCOUNT" SetFocusOnError="true" />
                         <asp:RegularExpressionValidator ID="revIntlPhone" runat="server" 
                                              ControlToValidate="txtPhone" 
                                              Display="Dynamic"  
                                              ErrorMessage="Intl phone number must be 3-20 digits"
                                              ValidationExpression="^\+?[0-9A-Za-z]{3,20}$" 
                                              ValidationGroup="EDIT_ACCOUNT" SetFocusOnError="true" />
                        </td>

                      </tr>
                      <tr>
                        <td>E-mail Address</td>
                        <td align="left"><input id="txtEmail" runat="server" name="email" type="text" class="fullwidth" onBlur="checkEmail(this,'err_email')" value="<?php echo $result['alt_email']?>"/>
                        <asp:RequiredFieldValidator ID="rfvEmail" runat="server"
                                          ControlToValidate="txtEmail"
                                          Display="Dynamic"
                                          ErrorMessage="required"
                                          ValidationGroup="EDIT_ACCOUNT" SetFocusOnError="true"/>
                        <asp:RegularExpressionValidator ID="revEmail" runat="server" 
                                              ControlToValidate="txtEmail" 
                                              Display="Dynamic"  
                                              ErrorMessage="Invalid format"
                                              ValidationExpression="^\s*\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*\s*$" 
                                              ValidationGroup="EDIT_ACCOUNT" SetFocusOnError="true" />
                        </td>
                      </tr>
                    </table>
                  </div>
                

                </div>
                
              </div>
              <div align="right" style="padding-right:40%; padding-bottom: 35px; padding-top:25px; clear:both">
                <div style="float:right">
                  <button style="display:" type="button" onclick="javascript:openEditor('company'); show21('info_section_submit_link_company');hide21('divChangesMessage');" class="info_section_edit_link" id="info_section_edit_link_company"> Edit </button>
                </div>
                <div style="float:right">
                  <asp:Button ID="info_section_submit_link_company" runat="server" ValidationGroup="EDIT_ACCOUNT" OnClick="btnSubmitAcct_Click" style="display:none" CssClass="info_section_edit_link" Text=" Submit " />
                </div>
                <div style="float:right">
                  <button style="display:none" type="button" id="info_section_edit_link1_company" class="info_section_edit_link1" onclick="javascript:closeEditor('company');show21('pass0'); hide21('pass1'); hide21('pass2'); hide21('pass3');  hide21('pass4'); emptyField('txtCurrentPassword');emptyField('txtPassword');emptyField('txtRetypePassword'); ">Cancel </button>

                </div>
              </div>
            </div>
          
          <div class="panel" id="tab2">
            <div class="Portlet_Container info_section">
            <%--<form id="frmPlanInfo" runat="server">--%>
            <input type="hidden" name="section" id="section" value="plan">
          
              <div class="Portlet_Content">
                <div id="info_section_product"  class="info_section_container clearfix">
                  <div id="info_section_display_product" class="info_section_display">
                    <div class="info_item">

                      <div class="info_label">Plan Name&nbsp; </div>
                      <div class="info_data"><asp:Literal ID="litPlanName" runat="server" /></div>
                    </div>
                  </div>
                  <div id="info_section_editor_product" class="info_section_editor">
                    <table border="0" cellspacing="0" cellpadding="5">
                      
                      <tr>

                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                      </tr>
                      <tr>
                        <td>Plan Name</td>
                        <td align="left">
                          <asp:DropDownList ID="ddlAllPlans" runat="server" DataValueField="plan_no" DataTextField="plan_name" />
                        </td>
                      </tr>              
                      <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                      </tr>
                      </table>
                  </div>
                </div>
              </div>
              <div align="right" style="padding-right:40%; padding-bottom: 25px">
                <div style="float:right">
                  <button type="button" onclick="javascript:openEditor('product'); show21('info_section_edit_link1_product');hide21('divChangesMessage');" class="info_section_edit_link" id="info_section_edit_link_product"> Edit </button>
                </div>
                <div style="float:right">
                  <asp:Button ID="info_section_submit_link_product" runat="server" ValidationGroup="EDIT_PLAN" OnClick="btnSubmitPlan_Click" style="display:none" CssClass="info_section_edit_link" Text=" Submit " />
                  <%--<button style="display:none" type="submit"  class="info_section_edit_link" id="info_section_submit_link_product"> Submit </button>--%>
                </div>
                <div style="float:right">
                  <button style="display:none" type="button" id="info_section_edit_link1_product" class="info_section_edit_link1" onclick="javascript:closeEditor('product'); ">Cancel </button>
                </div>
              </div>
            </div>
          </div>
          <div class="panel" id="tab3">
            <div class="Portlet_Container info_section">
            <input type="hidden" name="section" id="section" value="billing">
                <div class="Portlet_Content">
                <div id="info_section_billing"  class="info_section_container clearfix">
                  <div id="info_section_display_billing" class="info_section_display">
                    <div id="divCCPayMethod" runat="server">
                      <div class="info_item">
                        <div class="info_label"><asp:Literal ID="litCCPayMethodName" runat="server" /></div>
                        <div class="info_data"> xxxx-xxxx-xxxx-<asp:Literal ID="litCCSuffix" runat="server" /><br/>
                          Expires on <asp:Literal ID="litExpiresOn" runat="server" /><br/>
                          <asp:Literal ID="litBillingFullName" runat="server" /><br/>
                      </div>
                      </div>
                      <div class="info_item">
                        <div class="info_label">Billing Address</div>
                        <div class="info_data">
                          <asp:Literal ID="litBillingAddress" runat="server" />
                        </div>
                      </div>
                    </div>
                    <div id="divACHPayMethod" runat="server">
                        <table>
                        <tbody >
                        <tr>
                          <td><asp:Literal ID="litACHPayMethodName" runat="server" /></td>
                          <td></td>
                        </tr>
                        
                        <tr>
                          <td>Routing Number</td>
                          <td><asp:Literal ID="litRoutingNumber" runat="server" /></td>
                        </tr>

                        <tr>
                          <td>Bank Number</td>
                          <td>Ends with <asp:Literal ID="litBankNumber" runat="server" /></td>
                        </tr>
                      </tbody>
                      </table>
                    </div>
                    <div id="divOtherPayMethod" runat="server">
                      <div class="info_item">
                        <div class="info_label"><asp:Literal ID="litOtherPayMethodName" runat="server" /></div>
                      </div>
                    </div>
                    
                  </div>
                  <div id="info_section_editor_billing" class="info_section_editor">
                
                       <table border="0" cellspacing="5" cellpadding="5" width="50%">
                      <tr>
                        <td width="30%" style="white-space:nowrap">Payment Option </td>

                        <td align="left" valign="top">
                        <asp:DropDownList ID="ddlPayTypes" runat="server" OnSelectedIndexChanged="ddlPayTypes_SelectedIndexChanged" AutoPostBack="true">
                          <asp:ListItem Value="1" Text="Credit Card" />
                          <asp:ListItem Value="2" Text="ACH" />
                          <asp:ListItem Value="5" Text="Net Terms 10" />
                          <asp:ListItem Value="4" Text="Net Terms 30" />
                          <asp:ListItem Value="7" Text="Net Terms 60" />
                        </asp:DropDownList>
                        </td>
                      </tr>
                      <tbody id="Ccard" runat="server" style="display: ">
                        <tr>
                          <td width="20%"></td>
                          <td align="left" valign="top"><img src='<%= ResolveUrl("~/App_Themes/images/creditcard_mc.gif") %>' alt="MasterCard"/><img src='<%= ResolveUrl("~/App_Themes/images/creditcard_visa.gif") %>' alt="Visa"/>
                          <img src='<%= ResolveUrl("~/App_Themes/images/creditcard_amex.gif") %>' alt="Amex"/><img src='<%= ResolveUrl("~/App_Themes/images/creditcard_discover.gif") %>' alt="Discover"/></td>

                        </tr>
                        <tr>
                          <td width="20%">Credit Card </td>
                          <td align="left" valign="top">
                          <input type="text" class="fullwidth ghost" id="txtCCNumber" runat="server" name="cc_no"/>
                          <asp:RangeValidator ID="rvCCNumber" runat="server"
                                              ControlToValidate="txtCCNumber"
                                              Display="Dynamic" 
                                              Type="Double"
                                              ErrorMessage="Credit card numbers must be numeric" 
                                              ValidationGroup="EDIT_PAYMENT_CC" 
                                              SetFocusOnError="true" 
                                              MinimumValue="0" MaximumValue="10000000000000000" />
                          <asp:RequiredFieldValidator ID="rfvCCNumber" runat="server"
                                          ControlToValidate="txtCCNumber"
                                          Display="Dynamic"
                                          ErrorMessage="required"
                                          ValidationGroup="EDIT_PAYMENT_CC" SetFocusOnError="true"/>
                          <asp:CustomValidator ID="cvCCNumber" runat="server"
                                                ControlToValidate="txtCCNumber"
                                                Display="Dynamic"
                                                ErrorMessage="Unidentified card number. Please re-enter"
                                                SetFocusOnError="true"
                                                ValidationGroup="EDIT_PAYMENT_CC"
                                                OnServerValidate="ccNumber_ServerValidate" />
                        </td>
                        </tr>
                        <tbody id="cc_details">
                        <tr>
                          <td>Expiration Date</td>
                          <td align="left">
                            <asp:DropDownList ID="ddlMonth" runat="server">
                              <asp:ListItem Value="1" Text="January" />
                              <asp:ListItem Value="2" Text="February" />
                              <asp:ListItem Value="3" Text="March" />
                              <asp:ListItem Value="4" Text="April" />
                              <asp:ListItem Value="5" Text="May" />
                              <asp:ListItem Value="6" Text="June" />
                              <asp:ListItem Value="7" Text="July" />
                              <asp:ListItem Value="8" Text="August" />
                              <asp:ListItem Value="9" Text="September" />
                              <asp:ListItem Value="10" Text="October" />
                              <asp:ListItem Value="11" Text="November" />
                              <asp:ListItem Value="12" Text="December" />
                            </asp:DropDownList>
                            <asp:DropDownList ID="ddlYear" runat="server">
                              <asp:ListItem Value="2010" Text="2010" />
                              <asp:ListItem Value="2011" Text="2011" />
                              <asp:ListItem Value="2012" Text="2012" />
                              <asp:ListItem Value="2013" Text="2013" />
                              <asp:ListItem Value="2014" Text="2014" />
                              <asp:ListItem Value="2015" Text="2015" />
                              <asp:ListItem Value="2016" Text="2016" />
                              <asp:ListItem Value="2017" Text="2017" />
                              <asp:ListItem Value="2018" Text="2018" />
                              <asp:ListItem Value="2019" Text="2019" />
                            </asp:DropDownList>
                            <asp:CustomValidator ID="cvYear" runat="server"
                                                ControlToValidate="ddlYear"
                                                Display="Dynamic"
                                                ErrorMessage="Credit card has expired"
                                                SetFocusOnError="true"
                                                ValidationGroup="EDIT_PAYMENT_CC"
                                                OnServerValidate="ccYear_ServerValidate" />
                          </td>

                        </tr>
                        
                        <tr>
                          <td>Name on Card</td>

                          <td align="left">
                           <input id="txtBillingFirstName" runat="server" name="bill_firstname" type="text" class="halfwidth ghost" onfocus="startField(this)" />
                            <asp:RequiredFieldValidator ID="rfvBillingFirstName" runat="server" 
                                  ControlToValidate="txtBillingFirstName"
                                  Display="Dynamic" 
                                  ErrorMessage="required"
                                  ValidationGroup="EDIT_PAYMENT_CC" SetFocusOnError="true"/>
                            <asp:RegularExpressionValidator ID="revBillingFirstName" runat="server"
                                                            ControlToValidate="txtBillingFirstName"
                                                            Display="Dynamic"
                                                            ErrorMessage="Accepts only alphanumeric characters and spaces"
                                                            ValidationExpression="^[0-9a-zA-Z\s-]{1,}$"
                                                            ValidationGroup="EDIT_PAYMENT_CC" SetFocusOnError="true"/>  
                            <input id="txtBillingLastName" runat="server" name="bill_lastname" type="text" class="halfwidth ghost" onfocus="startField(this)" />
                            <asp:RequiredFieldValidator ID="rfvBillingLastName" runat="server" 
                                  ControlToValidate="txtBillingLastName"
                                  Display="Dynamic" 
                                  ErrorMessage="required"
                                  ValidationGroup="EDIT_PAYMENT_CC" SetFocusOnError="true"/>
                            <asp:RegularExpressionValidator ID="revBillingLastName" runat="server"
                                                            ControlToValidate="txtBillingLastName"
                                                            Display="Dynamic"
                                                            ErrorMessage="Accepts only alphanumeric characters and spaces"
                                                            ValidationExpression="^[0-9a-zA-Z\s-]{1,}$"
                                                            ValidationGroup="EDIT_PAYMENT_CC" SetFocusOnError="true"/>
                            </td>
                        </tr>
                        <tr>
                          <td colspan="2"> 
                          <asp:CheckBox id="chkUseResidence" runat="server" AutoPostBack="true" OnCheckedChanged="chkUseResidence_CheckedChanged" />
                            My billing address is the same as my company address</td>
                        </tr>
                        <tr>

                          <td valign="top">Billing Address</td>
                          <td align="left"><input id="txtBillingAddress1" runat="server" name="bill_address1" type="text" class="fullwidth" />
                        <asp:RequiredFieldValidator ID="rfvBillingAddress1" runat="server"
                                          ControlToValidate="txtBillingAddress1"
                                          Display="Dynamic"
                                          ErrorMessage="required"
                                          ValidationGroup="EDIT_PAYMENT_CC" SetFocusOnError="true"/>
                        <asp:RegularExpressionValidator ID="revBillingAddress1" runat="server" 
                                              ControlToValidate="txtBillingAddress1" 
                                              Display="Dynamic"  
                                              ErrorMessage="Must be between 5 and 50 alphanumeric characters, period, dash, comma, apostrophe and space"
                                              ValidationExpression="^[a-zA-Z0-9-\.,'\s-]{5,50}$" 
                                              ValidationGroup="EDIT_PAYMENT_CC" SetFocusOnError="true" /><br/>

                        <input  id="txtBillingAddress2" runat="server" name="bill_address2" type="text" class="fullwidth" />
                      <asp:RegularExpressionValidator ID="revBillingAddress2" runat="server" 
                                              ControlToValidate="txtBillingAddress2" 
                                              Display="Dynamic"  
                                              ErrorMessage="Must be between 5 and 50 alphanumeric characters, period, dash, comma, apostrophe and space"
                                              ValidationExpression="^[a-zA-Z0-9-\.,'\s-]{5,50}$" 
                                              ValidationGroup="EDIT_PAYMENT_CC" SetFocusOnError="true" />
                      </td>
                        </tr>
                        <tr>
                          <td>City/Town</td>
                          <td align="left">
                          <input id="txtBillingCity" runat="server" name="bill_city" type="text" class="fullwidth"/>
                            <asp:RequiredFieldValidator ID="rfvBillingCity" runat="server"
                                          ControlToValidate="txtBillingCity"
                                          Display="Dynamic"
                                          ErrorMessage="required"
                                          ValidationGroup="EDIT_PAYMENT_CC" SetFocusOnError="true"/>
                        <asp:RegularExpressionValidator ID="revBillingCity" runat="server" 
                                              ControlToValidate="txtBillingCity" 
                                              Display="Dynamic"  
                                              ErrorMessage="Invalid characters"
                                              ValidationExpression="^[a-zA-Z\.\s-]{2,}$" 
                                              ValidationGroup="EDIT_PAYMENT_CC" SetFocusOnError="true" />
                          </td>

                        </tr>
                        <tr>
                          <td width="30%">Country</td>
                          <td align="left"><asp:DropDownList ID="ddlBillingCountry" runat="server" CssClass="fullwidth" AutoPostBack="true" OnSelectedIndexChanged="ddlBillingCountry_SelectedIndexChanged">
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
                        </td>

                        </tr>
                        <tr>
                          <td><asp:Literal ID="litBillingLocalityLabel" runat="server">State</asp:Literal> </td>
                          <td align="left">
                          
                        <uc:State id="ucBillingState" runat="server" ValidationGroup="EDIT_PAYMENT_CC" />
                          </td>
                        </tr>
                        <tr>
                          <td>Zip Code</td>
                            <td align="left">
                            <input id="txtBillingZipCode" runat="server" name="bill_zip" maxlength="5" type="text" class="fullwidth" onkeypress = "return numbersonly(event)" />
                           <%--<input id="bill_zip" name="bill_zip" type="text"  maxlength="5" onblur = "checkZipcode(this,'err_bill_zip')" onkeypress = "return numbersonly(event)" class="fullwidth"/>--%>
                            <span id="err_bill_zip" style="color: red;"> </span>
                      </td>
                        </tr>
                        </tbody>
                      </tbody>
                      <tbody id="ACH" runat="server" style="display: ">
                        <tr>
                          <td>Routing Number</td>
                          <td><input type="text" class="fullwidth" id="txtRoutingNumber" runat="server" name="routing_no"/>
                          <asp:RequiredFieldValidator ID="rfvRoutingNumber" runat="server" ValidationGroup="EDIT_PAYMENT_ACH" ControlToValidate="txtRoutingNumber" Display="Dynamic">*<br />required</asp:RequiredFieldValidator>
          <script language="JavaScript">
            function validateRoutingNumber(oSrc, args) {
              args.IsValid = (args.Value.length == 9);
            }
         </script>
                  <asp:CustomValidator ID="cvRoutingNumber" runat="server" ControlToValidate="txtRoutingNumber" ValidationGroup="EDIT_PAYMENT_ACH" ClientValidationFunction="validateRoutingNumber" Display="Dynamic">*<br />Must be 9 digits long<br />&nbsp;</asp:CustomValidator>
</td>
                          
                        </tr>

                        <tr>
                          <td>Bank Number</td>
                          <td><input type="text" class="fullwidth" id="txtBankAccountNumber" runat="server" name="bank_acc_no"/>
                          <asp:RequiredFieldValidator ID="rfvAccountNumber" runat="server" ValidationGroup="EDIT_PAYMENT_ACH" ControlToValidate="txtBankAccountNumber" Display="Dynamic">*<br />required</asp:RequiredFieldValidator>
          <script language="JavaScript">
            function validateAccountNumber(oSrc, args) {
              args.IsValid = (args.Value.length > 4) && (args.Value.length < 20);
            }
         </script>
                  <asp:CustomValidator ID="cvAccountNumber" runat="server" ValidationGroup="EDIT_PAYMENT_ACH" ControlToValidate="txtBankAccountNumber" ClientValidationFunction="validateAccountNumber" Display="Dynamic">*<br />Must be between 5 and 19 digit long.<br />&nbsp;</asp:CustomValidator>
          </td>
                          
                        </tr>
                      </tbody>
                      
                    </table>
                  </div>
                </div>

              </div>
              <div align="right" style="padding-right:40%; padding-bottom: 25px">
                <div style="float:right">
                  <button type="button" onclick="javascript:openEditor('billing'); show21('info_section_edit_link1_billing');hide21('divChangesMessage');" class="info_section_edit_link" id="info_section_edit_link_billing"> Edit </button>
                </div>
                 <div style="float:right">
                  <asp:Button ID="info_section_submit_link_billing" runat="server" OnClick="btnSubmitBilling_Click" style="display:none" CssClass="info_section_edit_link" Text=" Submit " />
                </div>
                
                <div style="float:right">
                  <button style="display:none" type="button" id="info_section_edit_link1_billing" class="info_section_edit_link1" onclick="javascript:closeEditor('billing'); ">Cancel </button>

                </div>
              </div>
              <%--</form>--%>
            </div>
          </div>
        
          <div class="panel" id="tab5">
            <table width="99%" border="1" cellspacing="1" cellpadding="1">
              <tr>
                <td>
                  <asp:GridView ID="gvTransactions" runat="server" EmptyDataText="You have no recent transactions" AutoGenerateColumns="false">
                    <Columns>
                      <asp:TemplateField HeaderText="Transaction Number">
                        <ItemTemplate>
                          <%#Eval("transaction_id") %>
                        </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderText="Description">
                        <ItemTemplate>
                          <%#Eval("transaction_desc") %>
                        </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderText="Amount">
                        <ItemTemplate>
                          <%#((double)Eval("transaction_amount")).ToString("c")%>
                        </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderText="Applied Amount">
                        <ItemTemplate>
                          <%#((double)Eval("transaction_applied_amount")).ToString("c")%>
                        </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderText="Create Date">
                        <ItemTemplate>
                          <%# Eval("transaction_create_date") %>
                        </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderText="Void Date">
                        <ItemTemplate>
                          &nbsp;
                        </ItemTemplate>
                      </asp:TemplateField>
                      <asp:TemplateField HeaderText="Statement Number">
                        <ItemTemplate>
                          <%#Eval("statement_no") %>
                        </ItemTemplate>
                      </asp:TemplateField>
                    </Columns>
                  </asp:GridView>
                </td>
              </tr>
            </table>

          </div>
          
        </div>
 <script type="text/javascript" src="<%= ResolveUrl("~/_includes/js/uss.js")%>" ></script>

      </div>
    </div>
  </div>
 
  </div>
  
  <div id="a_footer"> &copy; 2010 Aria Systems Inc. All rights reserved.</div>
  </form>
</body>
</html>

