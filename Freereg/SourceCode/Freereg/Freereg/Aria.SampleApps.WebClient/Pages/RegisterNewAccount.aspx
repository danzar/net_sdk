<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterNewAccount.aspx.cs"
    Inherits="ARIA.Pages.RegisterNewAccount" EnableEventValidation="true" MasterPageFile="~/Shared/Site.Master" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div id="content" class="signup" style="position: relative; top: 0">
        <div class="pg_box">
            <div class="box_top">
            </div>
            <div class="box_content">
                <!-- content starts here -->
                <div class="section_header">
                    <asp:Label ID="registernewacctLabel" runat="server"></asp:Label>
                </div>
                <p>
                    <asp:Label ID="ifyoualreadyhaveacctLabel" runat="server"></asp:Label>
                    <a href="NULL">
                        <asp:Label ID="signinhereLabel" runat="server"></asp:Label>
                    </a>
                </p>
                <p class="subtext">
                    <asp:Label ID="allfieldsarerequiredLabel" runat="server"></asp:Label>
                </p>
                <div class="section_header">
                    <asp:Label ID="accountholderLabel" runat="server"></asp:Label>
                </div>
                <div class="info_item">
                    <div class="info_form_label">
                        <span class="asterisk"></span>
                        <label class="form_label" for="first_name">
                            <asp:Label ID="firstnameLabel" runat="server"></asp:Label>
                        </label>
                    </div>
                    <div class="info_field">
                        <asp:TextBox ID="firstnameTexBox" runat="server" CssClass="fullwidth"></asp:TextBox>
                    </div>
                </div>
                <div class="info_item">
                    <div class="info_form_label">
                        <span class="asterisk"></span>
                        <label class="form_label" for="last_name">
                            <asp:Label ID="lastnameLabel" runat="server"></asp:Label>
                        </label>
                    </div>
                    <div class="info_field">
                        <asp:TextBox ID="lastnameTextBox" runat="server" CssClass="fullwidth"></asp:TextBox>
                    </div>
                </div>
                <div class="info_item">
                    <div class="info_form_label">
                        <span class="asterisk">* </span>
                        <label class="form_label" for="company_name">
                            <asp:Label ID="acctcompanynameLabel" runat="server"></asp:Label>
                        </label>
                    </div>
                    <div class="info_field">
                        <asp:TextBox ID="acctcompanynameTextBox" runat="server" CssClass="fullwidth"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="acctcompanynameTextBoxRequiredFieldValidator" SetFocusOnError="true"
                            ValidationGroup="NextButton" runat="server" ControlToValidate="acctcompanynameTextBox"
                            ErrorMessage="Requiered" Display="Dynamic">
                        </asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="section_header">
                    <asp:Label ID="accountcredentialsLabel" runat="server"></asp:Label>
                </div>
                <div class="info_item">
                    <div class="info_form_label">
                        <span class="asterisk">* </span>
                        <label class="form_label" for="userid">
                            <asp:Label ID="useridLabel" runat="server"></asp:Label></label>
                    </div>
                    <div class="info_field">
                        <asp:TextBox ID="useridTextBox" runat="server" CssClass="fullwidth" MaxLength="50"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="useridTextBoxRequiredFieldValidator" SetFocusOnError="true"
                            ValidationGroup="NextButton" runat="server" ControlToValidate="useridTextBox"
                            ErrorMessage="Requiered" Display="Dynamic">
                        </asp:RequiredFieldValidator>
                        <asp:CustomValidator ID="userIdCustomValidator" SetFocusOnError="true" runat="server"
                            ControlToValidate="useridTextBox" ValidationGroup="NextButton">
                        </asp:CustomValidator>
                        <asp:RegularExpressionValidator ID="useridTextBoxRegularExpressionValidator" runat="server"
                            ControlToValidate="useridTextBox" ValidationExpression=".{4}.*" Display="Dynamic"
                            ValidationGroup="NextButton"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="info_item">
                    <div class="info_form_label">
                        <span class="asterisk">* </span>
                        <label class="form_label" for="password">
                            <asp:Label ID="passwordLabel" runat="server"></asp:Label>
                        </label>
                    </div>
                    <div class="info_field">
                        <asp:TextBox ID="passwordTextBox" runat="server" CssClass="fullwidth" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="passwordTextBoxRequiredFieldValidator" SetFocusOnError="true"
                            ValidationGroup="NextButton" runat="server" ControlToValidate="passwordTextBox"
                            ErrorMessage="Requiered" Display="Dynamic">
                        </asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="info_item">
                    <div class="info_form_label">
                        <span class="asterisk">* </span>
                        <label class="form_label" for="confirm_password">
                            <asp:Label ID="reenterpasswordLabel" runat="server"></asp:Label>
                        </label>
                    </div>
                    <div class="info_field">
                        <asp:TextBox ID="reenterpasswordTextBox" runat="server" CssClass="fullwidth" TextMode="Password"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="reenterpasswordTextBoxRequiredFieldValidator" SetFocusOnError="true"
                            ValidationGroup="NextButton" runat="server" ControlToValidate="reenterpasswordTextBox"
                            ErrorMessage="Requiered" Display="Dynamic">
                        </asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="passwordCompareValidator" runat="server" ControlToValidate="reenterpasswordTextBox"
                            ControlToCompare="passwordTextBox" Operator="Equal" ErrorMessage="Passwords must be equal"
                            ValidationGroup="NextButton"></asp:CompareValidator>
                    </div>
                </div>
                <div>
                    &nbsp;</div>
                <div class="info_item">
                    <div class="info_form_label">
                        <span class="asterisk">* </span>
                        <label class="form_label" for="secret_question">
                            <asp:Label ID="securityquestionLabel" runat="server"></asp:Label>
                        </label>
                    </div>
                    <div class="info_field">
                        <asp:DropDownList ID="securityquestiondropDown" runat="server" CssClass="fullwidth">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="securityquestiondropDownRequiredFieldValidator" SetFocusOnError="true"
                            runat="server" ValidationGroup="NextButton" ControlToValidate="securityquestiondropDown"
                            Display="Dynamic" InitialValue="-1" ErrorMessage="Requiered">
                        </asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="info_item">
                    <div class="info_form_label">
                        <span class="asterisk">* </span>
                        <label class="form_label" for="secret_question_answer">
                            <asp:Label ID="youranswerLabel" runat="server"></asp:Label>
                        </label>
                    </div>
                    <div class="info_field">
                        <asp:TextBox ID="youranswerTextBox" runat="server" CssClass="fullwidth"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="youranswerTextBoxRequiredFieldValidator" SetFocusOnError="true"
                            ValidationGroup="NextButton" runat="server" ControlToValidate="youranswerTextBox"
                            ErrorMessage="Requiered" Display="Dynamic">
                        </asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="section_header">
                    <span class="asterisk"></span>
                    <asp:Label ID="addressLabel" runat="server"></asp:Label>
                </div>
                <div class="info_item">
                    <div class="info_countrystate_label">
                        <span class="asterisk">* </span>
                        <label class="form_label" for="country">
                            <asp:Label ID="acctcountryLabel" runat="server"></asp:Label>
                        </label>
                    </div>
                    <div class="info_field">
                        <asp:DropDownList ID="acctcountryDropDownList" runat="server" OnChange="LoadStatesProvinces(this);"
                            CssClass="fullwidth">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="acctcountryDropDownListRequiredFieldValidator" SetFocusOnError="true"
                            runat="server" ValidationGroup="NextButton" ControlToValidate="acctcountryDropDownList"
                            Display="Dynamic" InitialValue="-1" ErrorMessage="Requiered">
                        </asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="info_item">
                    <div class="info_form_label">
                        <span class="asterisk">* </span>
                        <label class="form_label" for="address1">
                            <asp:Label ID="streetaddressLabel" runat="server"></asp:Label>
                        </label>
                    </div>
                    <div class="info_field">
                        <asp:TextBox ID="streetaddressTextBox" runat="server" CssClass="fullwidth"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="streetaddressTextBoxRequiredFieldValidator" SetFocusOnError="true"
                            ValidationGroup="NextButton" runat="server" ControlToValidate="streetaddressTextBox"
                            ErrorMessage="Requiered" Display="Dynamic">
                        </asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="info_item">
                    <div class="info_form_label">
                        &nbsp;</div>
                    <div class="info_field">
                        <asp:TextBox ID="streetaddressTextBox2" runat="server" CssClass="fullwidth"></asp:TextBox>
                    </div>
                </div>
                <div class="info_item">
                    <div class="info_form_label">
                        <span class="asterisk">* </span>
                        <label class="form_label" for="city">
                            <asp:Label ID="citytownLabel" runat="server"></asp:Label>
                        </label>
                    </div>
                    <div class="info_field">
                        <asp:TextBox ID="citytownTextBox" runat="server" CssClass="fullwidth"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="citytownTextBoxRequiredFieldValidator" SetFocusOnError="true"
                            ValidationGroup="NextButton" runat="server" ControlToValidate="citytownTextBox"
                            ErrorMessage="Requiered" Display="Dynamic">
                        </asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="info_item">
                    <div class="info_countrystate_label">
                        <label class="form_label" for="state_prov">
                            <span class="asterisk">* </span><span class="form_label">
                                <asp:Label ID="localityLabel" runat="server"></asp:Label>
                                <asp:Label ID="proviceLabel" runat="server" Style="display: none;"></asp:Label>
                                <asp:Label ID="stateLabel" runat="server" Style="display: none;"></asp:Label>
                            </span>
                        </label>
                    </div>
                    <div class="info_field">
                        <asp:TextBox ID="stateprovincelocalityTextBox" runat="server" CssClass="fullwidth"></asp:TextBox>
                        <asp:DropDownList ID="statesProvincesDropDownList" runat="server" CssClass="fullwidth"
                            Style="display: none;">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator ID="stateprovincelocalityTextBoxRequiredFieldValidator"
                            SetFocusOnError="true" ValidationGroup="NextButton" runat="server" ControlToValidate="stateprovincelocalityTextBox"
                            ErrorMessage="Requiered" Display="Dynamic">
                        </asp:RequiredFieldValidator>
                        <asp:RequiredFieldValidator ID="statesProvincesDropDownListRequiredFieldValidator"
                            SetFocusOnError="true" runat="server" ValidationGroup="NextButton" Enabled="false"
                            ControlToValidate="statesProvincesDropDownList" Display="Dynamic" InitialValue="-1"
                            ErrorMessage="Requiered">
                        </asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="info_item">
                    <div class="info_form_label">
                        <span class="asterisk">* </span>
                        <label class="form_label" for="postal_cd">
                            <asp:Label ID="zipcodeLabel" runat="server"></asp:Label>
                        </label>
                    </div>
                    <div class="info_field">
                        <asp:TextBox ID="zipcodeTextBox" runat="server" CssClass="fullwidth"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="zipcodeTextBoxRequiredFieldValidator" SetFocusOnError="true"
                            ValidationGroup="NextButton" runat="server" ControlToValidate="zipcodeTextBox"
                            ErrorMessage="Requiered" Display="Dynamic">
                        </asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="section_header">
                    <asp:Label ID="contactinformationLabel" runat="server"></asp:Label>
                </div>
                <div class="info_item">
                    <div class="info_form_label">
                        <span class="asterisk">* </span>
                        <label class="form_label" for="phone">
                            <asp:Label ID="phonenumberLabel" runat="server"></asp:Label>
                        </label>
                    </div>
                    <div class="info_field">
                        <asp:TextBox ID="phonenumberTextBox" runat="server" CssClass="fullwidth"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="phonenumberTextBoxRequiredFieldValidator" SetFocusOnError="true"
                            ValidationGroup="NextButton" runat="server" ControlToValidate="phonenumberTextBox"
                            ErrorMessage="Requiered" Display="Dynamic">
                        </asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="info_item">
                    <div class="info_form_label">
                        <span class="asterisk">* </span>
                        <label class="form_label" for="email">
                            <asp:Label ID="emailaddressLabel" runat="server"></asp:Label>
                        </label>
                    </div>
                    <div class="info_field">
                        <asp:TextBox ID="emailaddressTextBox" runat="server" CssClass="fullwidth"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="emailaddressTextBoxRequiredFieldValidator" SetFocusOnError="true"
                            ValidationGroup="NextButton" runat="server" ControlToValidate="emailaddressTextBox"
                            ErrorMessage="Requiered" Display="Dynamic">
                        </asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="emailaddressTextBoxRegularExressionValidator"
                            runat="server" ValidationExpression="^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
                            ValidationGroup="NextButton" ControlToValidate="emailaddressTextBox" />
                    </div>
                </div>
                <div class="button_container">
                    <asp:Button ID="nextButton" ValidationGroup="NextButton" CssClass="btn_prefer" runat="server"
                        OnClick="NextButton_Click" />
                </div>
                <!-- content ends here -->
            </div>
            <div class="box_bottom">
            </div>
        </div>
    </div>
</asp:Content>
