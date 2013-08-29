<%@ page language="C#" autoeventwireup="true" inherits="AddAccountInfo, App_Web_or1ni4yr" %>
<%@ Register TagPrefix="uc" TagName="State" Src="~/StateProvinceControl.ascx" %>
<%@ Register TagPrefix="uc" TagName="LoginNavigation" Src="~/LoginNavigationControl.ascx" %>

<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>Account Registration</title>
<script type="text/javascript" src="_includes/js/country.js"></script>
<script type="text/javascript" src="_includes/js/validation.js"></script>
<script type="text/javascript" src="_includes/js/reg.js"></script>
<link type="text/css" href="App_Themes/main.css" rel="stylesheet"/>
<link type="text/css" href="App_Themes/layout.css" rel="stylesheet"/>
</head>
<body>
<div id="a_header" class="clearfix">

  <div class="right"> <a href="Login.aspx">Sign in&nbsp;</a></div>
  <br />
  <br />
</div>
<div class="logo2">
<img width="93" height="50" src="App_Themes/images/aria_logo.gif"/>
</div>
<div id="content" class="signup">
  <div class="pg_title">
    <h1>Register for a New  Account</h1>
  </div>
<div style="width: 1024px">
  <uc:LoginNavigation ID="lgnNav" runat="server" />
  <div class="pg_box">
    <div class="box_top"> </div>
    <div class="box_content">
      <p class="subtext"> * Denotes required fields. </p>
     <p><font color="red">
         <ul>
            <asp:Repeater ID="rptErrors" runat="server">
              <ItemTemplate>
                <li><%#Container.DataItem %></li>
              </ItemTemplate>
            </asp:Repeater>
         </ul>

                 
                 
             
      </font> </p>
      <form id="create_account" runat="server">
        <fieldset>
          <div class="sec_title" id="AI">
            <h2>1. Account Information</h2>
          </div>
          <dl>
            <dt> * First Name</dt>
            <dd>
              <input tabindex="1" id="txtFirstName" runat="server" type="text" name = "first_name" class="fullwidth ghost" 
              onfocus="startField(this)" />
              <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ControlToValidate="txtFirstName" Display="Dynamic" >*<BR /> required<BR />&nbsp;</asp:RequiredFieldValidator>
              <asp:RegularExpressionValidator ID="revFirstName" runat="server" ControlToValidate="txtFirstName" Display="Dynamic" ValidationExpression="^[0-9a-zA-Z\s-]{1,}$">*<br />Accepts only alphanumeric characters and spaces<br />&nbsp;</asp:RegularExpressionValidator>
            </dd>
            <dt>* Last Name</dt>
            <dd>
              <input tabindex="2" id="txtLastName" runat="server" name="last_name" type="text" class="fullwidth ghost" 
              onfocus="startField(this)" />
            
              <asp:RequiredFieldValidator ID="rfvLastName" runat="server" ControlToValidate="txtLastName" Display="Dynamic" >*<BR /> required<BR />&nbsp;</asp:RequiredFieldValidator>
              <asp:RegularExpressionValidator ID="revLastName" runat="server" ControlToValidate="txtLastName" Display="Dynamic" ValidationExpression="^[0-9a-zA-Z\s-]{1,}$">*<br />Accepts only alphanumeric characters and spaces<br />&nbsp;</asp:RegularExpressionValidator>
            </dd>
            <dt>* User ID</dt>
            <dd>
              <input tabindex="3" id="txtUserId" runat="server" name="user_id" type="text" class="fullwidth" />
            
              <asp:RequiredFieldValidator ID="rfvUserId" runat="server" ControlToValidate="txtUserId" Display="Dynamic" >*<BR /> required<BR />&nbsp;</asp:RequiredFieldValidator>
              <asp:RegularExpressionValidator ID="revUserId" runat="server" ControlToValidate="txtUserId" Display="Dynamic" ValidationExpression="^[a-zA-Z0-9_@.-]{1,}$">*<br />Accepts only alphanumeric characters, and can include _-@.<br />&nbsp;</asp:RegularExpressionValidator>
            </dd>
            <dt>* Create a Password</dt>
            <dd>
              <input tabindex="3" id="txtPassword" runat="server" name="password" type="password" class="fullwidth ghost" />
              <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPassword" Display="Dynamic" >*<BR /> required<BR />&nbsp;</asp:RequiredFieldValidator>
              <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtPassword" Display="Dynamic" ValidationExpression="^[a-zA-Z0-9+-_!^@#%&*()\.]{8,50}$">*<br />Accepts only 8-50 alphanumeric characters, and can include +-_!^@#%&*().<br />&nbsp;</asp:RegularExpressionValidator>
             
            </dd>

            <dt>* Re-enter Password</dt>
            <dd>
              <input tabindex="4" id="txtPasswordConfirmation" runat="server" name="re_password" type="password" class="fullwidth ghost" />
              <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPasswordConfirmation" Display="Dynamic" >*<BR /> required<BR />&nbsp;</asp:RequiredFieldValidator>
              <asp:CompareValidator ID="cmpPassword" runat="server" ControlToValidate="txtPasswordConfirmation" ControlToCompare="txtPassword" Display="Dynamic">* <br />passwords don't match<br />&nbsp;</asp:CompareValidator>
            </dd>
            <dt>* Security Question</dt>
            <dd>
              <select tabindex="5" id="ddlSecrectQuestion" runat="server" name="secret_question" class="fullwidth">
                <option value="">- Choose a question -</option>
                <option value="1" >What was the name of your first pet?</option>
                <option value="2" >What was the name of your childhood best friend?</option>
                <option value="3" >What was your childhood hero?</option>
                <option value="4" >What was the name of your elementary school?</option>
                <option value="5" >What was your high school mascot?</option>
              </select>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddlSecrectQuestion" Display="Dynamic" >*<BR /> required<BR />&nbsp;</asp:RequiredFieldValidator>
            
            </dd>
            <dt>* Your Answer</dt>
            <dd>
              <input tabindex="6" id="txtSecretAnswer" runat="server" name="secret_answer"  type="text" class="fullwidth" value=""/>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtSecretAnswer" Display="Dynamic" >*<BR /> required<BR />&nbsp;</asp:RequiredFieldValidator>
            </dd>
          </dl>
        </fieldset>
        <div class="sec_title" id="Ainfo">

          <h2>2. Address</h2>
        </div>
        <fieldset>
          <dl>
            <dt>* Street Address</dt>
            <dd>
              <input tabindex="20" id="txtStreet1"  runat="server" name="street1" type="text"  class="fullwidth" />
              <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtStreet1" Display="Dynamic" >*<BR /> required<BR />&nbsp;</asp:RequiredFieldValidator>
              <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtStreet1" Display="Dynamic" ValidationExpression="^[a-zA-Z0-9-\.,'\s-]{5,50}$">* <br />Must be between 5 and 50 alphanumeric characters, period, dash, comma, apostrophe and space<br /> &nbsp; </asp:RegularExpressionValidator>
            <br />

              <input tabindex="21" id="txtStreet2" runat="server" name="street2" type="text"  class="fullwidth" />
            
              <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="txtStreet1" Display="Dynamic" ValidationExpression="^[a-zA-Z0-9-\.,'\s-]{5,50}$">* <br />Must be between 5 and 50 alphanumeric characters, period, dash, comma, apostrophe and space<br /> &nbsp; </asp:RegularExpressionValidator>
            </dd>
            <dt>* City/Town</dt>
            <dd>
              <input tabindex="22" id="txtCity" runat="server" name="city" type="text"  class="fullwidth" />
            
              <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtCity" Display="Dynamic" >*<BR /> required<BR />&nbsp;</asp:RequiredFieldValidator>
              <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="txtCity" Display="Dynamic" ValidationExpression="^[a-zA-Z\.\s-]{2,}$">* <br />Invalid characters<br /> &nbsp; </asp:RegularExpressionValidator>
            </dd>
            <dt>* Country</dt>
            <dd>
                      <asp:DropDownList ID="ddlCountry" runat="server" CssClass="fullwidth" AutoPostBack="true" OnSelectedIndexChanged="ddlCountry_SelectedIndexChanged" TabIndex="23">
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
            <dt><label for="state"><asp:Literal id="litState" runat="server" >State</asp:Literal>: </label></dt>
            <dd>
              <uc:State id="ucState" runat="server" ValidationGroup="EDIT_ACCOUNT" TabIndex="24" />
            </dd>
          
            <dt>* Zip Code</dt>
            <dd>
              <input tabindex="25" id="txtZipCode" runat="server" name="zip_code" type="text" maxlength="5"  class="fullwidth" 
              onkeypress = "return numbersonly(event)" />
              <asp:RequiredFieldValidator ID="rfvZipCode" runat="server" ControlToValidate="txtZipCode" Display="Dynamic" >*<BR /> required<BR />&nbsp;</asp:RequiredFieldValidator>
             </dd>
          </dl>
        </fieldset>

        <div class="sec_title" id="CI">
          <h2>3. Contact Information</h2>
        </div>
        <fieldset>
          <dl>
          <dt>* Phone Number</dt>
          <dd>
            <input tabindex="40" id="txtPhone"  runat="server" name="phone" type="text"  class="fullwidth"  onkeypress = "return numbersonly(event,'phone')"  />
              <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtPhone" Display="Dynamic" >*<BR /> required<BR />&nbsp;</asp:RequiredFieldValidator>
              <asp:RegularExpressionValidator ID="revUSCAPhone" runat="server" 
                                              ControlToValidate="txtPhone" 
                                              Display="Dynamic"  
                                              ErrorMessage="US/CA phone number must be 10-20 digits"
                                              ValidationExpression="^\(?^[0-9]{3}\)?[-. ]?[0-9]{3}[-. ]?[0-9]{4}$" 
                                              SetFocusOnError="true" />
              <asp:RegularExpressionValidator ID="revIntlPhone" runat="server" 
                                              ControlToValidate="txtPhone" 
                                              Display="Dynamic"  
                                              ErrorMessage="Intl phone number must be 3-20 digits"
                                              ValidationExpression="^\+?[0-9A-Za-z]{3,20}$" 
                                              SetFocusOnError="true" />
            </dd>

          <dt>* E-mail Address</dt>
          <dd>
            <input tabindex="41" id="txtEmail" runat="server" name="email" type="text"  class="fullwidth"  />
          
              <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtEmail" Display="Dynamic" >*<BR /> required<BR />&nbsp;</asp:RequiredFieldValidator>
              <asp:RegularExpressionValidator ID="RegularExpressionValidator5" runat="server" ControlToValidate="txtEmail" Display="Dynamic" ValidationExpression="^([\w-]+(?:\.[\w-]+)*)@((?:[\w-]+\.)*\w[\w-]{0,66})\.([a-z]{2,6}(?:\.[a-z]{2})?)$">*<br />Invalid format<br /> &nbsp; </asp:RegularExpressionValidator>
            </dd>
          <dt>* Confirm Email</dt>
          <dd>
            <input tabindex="42" id="txtEmailConfirm"  runat="server" name="re_email" type="text"  class="fullwidth"  />
            <asp:RequiredFieldValidator ID="RequiredFieldValidator9" runat="server" ControlToValidate="txtEmailConfirm" Display="Dynamic" >*<BR /> required<BR />&nbsp;</asp:RequiredFieldValidator>
            <asp:CompareValidator ID="cmpEmail" runat="server" ControlToCompare="txtEmail" ControlToValidate="txtEmailConfirm" Display="Dynamic">* <br />Email and Confirm Email do not match<br /> &nbsp; </asp:CompareValidator>
            </dd>

          </dl>
        </fieldset>
        
        <div class="Section_Container">
           
              <div class="Section_Content">
                
        <fieldset>
          <dl>
            <dt></dt>
            <dd>
              <input id="btnSubmit" style="float: right;" type="button" class="btn_prefer" value="Continue" runat="server" tabindex="50"
							 onserverclick="btnSubmit_onserverclick" causesvalidation="true">
            </dd>
          </dl>

        </fieldset>
      </form>
    </div>
   
  </div>
</div>
 <div class="box_bottom"> </div>


</div>
<div id="a_footer"> &copy; 2010 Aria Systems Inc. All rights reserved.</div>
</body>

</html>
