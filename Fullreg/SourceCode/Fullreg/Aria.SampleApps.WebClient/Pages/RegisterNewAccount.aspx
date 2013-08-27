<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterNewAccount.aspx.cs"
    Inherits="ARIA.Pages.RegisterNewAccount" EnableEventValidation="true" MasterPageFile="~/Shared/Site.Master" %>

<%@ Register Src="~/Pages/UserControls/PlanInfoUserControl.ascx" TagName="PlanInfoUserControl"
    TagPrefix="uc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div id="content" class="signup">
        <div class="pg_title h1Aria">
            <asp:Label ID="registernewacctLabel" runat="server"></asp:Label>
        </div>
        <div class="pg_box">
            <div class="box_top">
            </div>
            <div class="box_content">
                <p>
                    <asp:Label ID="ifyoualreadyhaveacctLabel" runat="server"></asp:Label>
                    <a href="NULL">
                        <asp:Label ID="signinhereLabel" runat="server"></asp:Label></a>
                </p>
                <p class="subtext">
                    <asp:Label ID="allfieldsarerequiredLabel" runat="server"></asp:Label>
                </p>
                <fieldset>
                    <div id="accountInfoDiv" class="sec_title">
                        <h2>
                            <asp:Label ID="accountinformationLabel" runat="server"></asp:Label>
                        </h2>
                    </div>
                    <dl>
                        <dt>&nbsp;&nbsp;<asp:Label ID="firstnameLabel" runat="server"></asp:Label>&nbsp;&nbsp;</dt>
                        <dd>
                            <asp:TextBox ID="firstnameTexBox" runat="server" CssClass="fullwidth"></asp:TextBox>
                        </dd>
                        <dt>&nbsp;&nbsp;<asp:Label ID="lastnameLabel" runat="server"></asp:Label>&nbsp;&nbsp;</dt>
                        <dd>
                            <asp:TextBox ID="lastnameTextBox" runat="server" CssClass="fullwidth"></asp:TextBox>
                        </dd>
                        <dt><span class="asterisk">* </span>&nbsp;&nbsp;<asp:Label ID="acctcompanynameLabel"
                            runat="server"></asp:Label>&nbsp;&nbsp;</dt>
                        <dd>
                            <asp:TextBox ID="acctcompanynameTextBox" runat="server" CssClass="fullwidth"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="acctcompanynameTextBoxRequiredFieldValidator" SetFocusOnError="true"
                                ValidationGroup="NextButton" runat="server" ControlToValidate="acctcompanynameTextBox"
                                Display="Dynamic">
                            </asp:RequiredFieldValidator>
                        </dd>
                        <dt><span class="asterisk">* </span>&nbsp;&nbsp;<asp:Label ID="passwordLabel" runat="server"></asp:Label>&nbsp;&nbsp;</dt>
                        <dd>
                            <asp:TextBox ID="passwordTextBox" runat="server" CssClass="fullwidth" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="passwordTextBoxRequiredFieldValidator" SetFocusOnError="true"
                                ValidationGroup="NextButton" runat="server" ControlToValidate="passwordTextBox"
                                Display="Dynamic">
                            </asp:RequiredFieldValidator>
                        </dd>
                        <dt><span class="asterisk">* </span>&nbsp;&nbsp;<asp:Label ID="reenterpasswordLabel"
                            runat="server"></asp:Label>&nbsp;&nbsp;</dt>
                        <dd>
                            <asp:TextBox ID="reenterpasswordTextBox" runat="server" CssClass="fullwidth" TextMode="Password"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="reenterpasswordTextBoxRequiredFieldValidator" SetFocusOnError="true"
                                ValidationGroup="NextButton" runat="server" ControlToValidate="reenterpasswordTextBox"
                                Display="Dynamic">
                            </asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="passwordCompareValidator" runat="server" ControlToValidate="reenterpasswordTextBox"
                                ControlToCompare="passwordTextBox" Operator="Equal" ValidationGroup="NextButton"></asp:CompareValidator>
                        </dd>
                        <dt><span class="asterisk">* </span>&nbsp;&nbsp;<asp:Label ID="securityquestionLabel"
                            runat="server"></asp:Label>&nbsp;&nbsp;</dt>
                        <dd>
                            <asp:DropDownList ID="securityquestiondropDown" runat="server" CssClass="fullwidth">
                            </asp:DropDownList>
                            <asp:RequiredFieldValidator ID="securityquestiondropDownRequiredFieldValidator" SetFocusOnError="true"
                                runat="server" ValidationGroup="NextButton" ControlToValidate="securityquestiondropDown"
                                Display="Dynamic" InitialValue="-1">
                            </asp:RequiredFieldValidator>
                        </dd>
                        <dt><span class="asterisk">* </span>&nbsp;&nbsp;<asp:Label ID="youranswerLabel" runat="server"></asp:Label>&nbsp;&nbsp;</dt>
                        <dd>
                            <asp:TextBox ID="youranswerTextBox" runat="server" CssClass="fullwidth"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="youranswerTextBoxRequiredFieldValidator" SetFocusOnError="true"
                                ValidationGroup="NextButton" runat="server" ControlToValidate="youranswerTextBox"
                                Display="Dynamic">
                            </asp:RequiredFieldValidator>
                        </dd>
                        <dt><span class="asterisk">* </span>&nbsp;&nbsp;<asp:Label ID="useridLabel" runat="server"></asp:Label>&nbsp;&nbsp;</dt>
                        <dd>
                            <asp:UpdatePanel ID="userIdUpdatePanel" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:TextBox ID="useridTextBox" runat="server" CssClass="fullwidth" MaxLength="50"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="useridTextBoxRequiredFieldValidator" SetFocusOnError="true"
                                        ValidationGroup="NextButton" runat="server" ControlToValidate="useridTextBox"
                                        Display="Dynamic">
                                    </asp:RequiredFieldValidator>
                                    <asp:CustomValidator ID="userIdCustomValidator" SetFocusOnError="true" runat="server"
                                        ControlToValidate="useridTextBox" ValidationGroup="NextButton">
                                    </asp:CustomValidator>
                                    <asp:RegularExpressionValidator ID="useridTextBoxRegularExpressionValidator" runat="server"
                                        ControlToValidate="useridTextBox" ValidationExpression=".{4}.*" Display="Dynamic"
                                        ValidationGroup="NextButton"></asp:RegularExpressionValidator>
                                    <p class="subtext">
                                        <asp:Label ID="canbeemailaddressLabel" runat="server"></asp:Label>
                                    </p>
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </dd>
                    </dl>
                </fieldset>
                <asp:UpdatePanel ID="addresInfoUpdatePanel" runat="server" UpdateMode="Conditional">
                    <ContentTemplate>
                        <fieldset>
                            <div id="adressInfoDiv" class="sec_title">
                                <h2>
                                    <asp:Label ID="addressLabel" runat="server"></asp:Label></h2>
                            </div>
                            <dl>
                                <dt><span class="asterisk">* </span>&nbsp;&nbsp;<asp:Label ID="streetaddressLabel"
                                    runat="server"></asp:Label>&nbsp;&nbsp;</dt>
                                <dd>
                                    <asp:TextBox ID="streetaddressTextBox" runat="server" CssClass="fullwidth"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="streetaddressTextBoxRequiredFieldValidator" SetFocusOnError="true"
                                        ValidationGroup="NextButton" runat="server" ControlToValidate="streetaddressTextBox"
                                        Display="Dynamic">
                                    </asp:RequiredFieldValidator>
                                </dd>
                                <dt></dt>
                                <dd>
                                    <asp:TextBox ID="streetaddressTextBox2" runat="server" CssClass="fullwidth"></asp:TextBox>
                                </dd>
                                <dt><span class="asterisk">* </span>&nbsp;&nbsp;<asp:Label ID="citytownLabel" runat="server"></asp:Label>&nbsp;&nbsp;</dt>
                                <dd>
                                    <asp:TextBox ID="citytownTextBox" runat="server" CssClass="fullwidth"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="citytownTextBoxRequiredFieldValidator" SetFocusOnError="true"
                                        ValidationGroup="NextButton" runat="server" ControlToValidate="citytownTextBox"
                                        Display="Dynamic">
                                    </asp:RequiredFieldValidator>
                                </dd>
                                <dt><span class="asterisk">* </span>&nbsp;&nbsp;<asp:Label ID="acctcountryLabel"
                                    runat="server"></asp:Label>&nbsp;&nbsp;</dt>
                                <dd>
                                    <asp:DropDownList ID="acctcountryDropDownList" runat="server" OnChange="LoadStatesProvinces(this);"
                                        CssClass="fullwidth">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="acctcountryDropDownListRequiredFieldValidator" SetFocusOnError="true"
                                        runat="server" ValidationGroup="NextButton" ControlToValidate="acctcountryDropDownList"
                                        Display="Dynamic" InitialValue="-1">
                                    </asp:RequiredFieldValidator>
                                </dd>
                                <dt><span class="asterisk">* &nbsp;&nbsp;</span>
                                    <asp:Label ID="localityLabel" runat="server"></asp:Label>
                                    <asp:Label ID="proviceLabel" runat="server" Style="display: none;"></asp:Label>
                                    <asp:Label ID="stateLabel" runat="server" Style="display: none;"></asp:Label>
                                    &nbsp;&nbsp;</dt>
                                <dd>
                                    <asp:TextBox ID="stateprovincelocalityTextBox" runat="server" CssClass="fullwidth"></asp:TextBox>
                                    <asp:DropDownList ID="statesProvincesDropDownList" runat="server" CssClass="fullwidth"
                                        Style="display: none;">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="stateprovincelocalityTextBoxRequiredFieldValidator"
                                        SetFocusOnError="true" ValidationGroup="NextButton" runat="server" ControlToValidate="stateprovincelocalityTextBox"
                                        Display="Dynamic">
                                    </asp:RequiredFieldValidator>
                                    <asp:RequiredFieldValidator ID="statesProvincesDropDownListRequiredFieldValidator"
                                        SetFocusOnError="true" runat="server" ValidationGroup="NextButton" Enabled="false"
                                        ControlToValidate="statesProvincesDropDownList" Display="Dynamic" InitialValue="-1">
                                    </asp:RequiredFieldValidator>
                                </dd>
                                <dt><span class="asterisk">* </span>&nbsp;&nbsp;<asp:Label ID="zipcodeLabel" runat="server"></asp:Label>&nbsp;&nbsp;</dt>
                                <dd>
                                    <asp:TextBox ID="zipcodeTextBox" runat="server" CssClass="fullwidth"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="zipcodeTextBoxRequiredFieldValidator" SetFocusOnError="true"
                                        ValidationGroup="NextButton" runat="server" ControlToValidate="zipcodeTextBox"
                                        Display="Dynamic">
                                    </asp:RequiredFieldValidator>
                                </dd>
                            </dl>
                        </fieldset>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <fieldset>
                    <div id="contactInfoDiv" class="sec_title">
                        <h2>
                            <asp:Label ID="contactinformationLabel" runat="server"></asp:Label></h2>
                    </div>
                    <dl>
                        <dt><span class="asterisk">* </span>&nbsp;&nbsp;<asp:Label ID="phonenumberLabel"
                            runat="server"></asp:Label>&nbsp;&nbsp;</dt>
                        <dd>
                            <asp:TextBox ID="phonenumberTextBox" runat="server" CssClass="fullwidth"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="phonenumberTextBoxRequiredFieldValidator" SetFocusOnError="true"
                                ValidationGroup="NextButton" runat="server" ControlToValidate="phonenumberTextBox"
                                Display="Dynamic">
                            </asp:RequiredFieldValidator>
                        </dd>
                        <dt><span class="asterisk">* </span>&nbsp;&nbsp;<asp:Label ID="emailaddressLabel"
                            runat="server"></asp:Label>&nbsp;&nbsp;</dt>
                        <dd>
                            <asp:TextBox ID="emailaddressTextBox" runat="server" CssClass="fullwidth"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="emailaddressTextBoxRequiredFieldValidator" SetFocusOnError="true"
                                ValidationGroup="NextButton" runat="server" ControlToValidate="emailaddressTextBox"
                                Display="Dynamic">
                            </asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="emailaddressTextBoxRegularExressionValidator"
                                ValidationGroup="NextButton" ControlToValidate="emailaddressTextBox" ValidationExpression="^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"
                                runat="server" />
                        </dd>
                        <dt><span class="asterisk">* </span>&nbsp;&nbsp;<asp:Label ID="confirmemailLabel"
                            runat="server"></asp:Label>&nbsp;&nbsp;</dt>
                        <dd>
                            <asp:TextBox ID="confirmemailTextBox" runat="server" CssClass="fullwidth"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="confirmemailTextBoxRequiredFieldValidator" SetFocusOnError="true"
                                ValidationGroup="NextButton" runat="server" ControlToValidate="confirmemailTextBox"
                                Display="Dynamic">
                            </asp:RequiredFieldValidator>
                            <asp:CompareValidator ID="emailCompareValidator" runat="server" ControlToValidate="confirmemailTextBox"
                                ValidationGroup="NextButton" ControlToCompare="emailaddressTextBox" Operator="Equal"></asp:CompareValidator>
                        </dd>
                    </dl>
                </fieldset>
                <uc1:PlanInfoUserControl ID="planInfoUserControl" runat="server" />
                <fieldset>
                    <dl>
                        <dt></dt>
                        <dd class="button">
                            <asp:UpdatePanel ID="nextButtonUpdatePanel" runat="server" UpdateMode="Conditional">
                                <ContentTemplate>
                                    <asp:Button ID="nextButton" ValidationGroup="NextButton" CssClass="btn_prefer" runat="server"
                                        OnClick="NextButton_Click" />
                                </ContentTemplate>
                            </asp:UpdatePanel>
                        </dd>
                    </dl>
                </fieldset>
            </div>
            <div class="box_bottom">
            </div>
        </div>
    </div>
</asp:Content>
