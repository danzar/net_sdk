<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BillingInformation.aspx.cs"
    MasterPageFile="~/Shared/Site.Master" Inherits="ARIA.Pages.BillingInformation" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div id="content" class="signup">
        <div class="pg_box">
            <div class="box_top">
            </div>
            <div class="box_content">
                <div class="pg_title">
                    <h2>
                        <asp:Label ID="billinginformationLabel" runat="server"></asp:Label>
                    </h2>
                </div>
                <asp:UpdatePanel ID="billingInformationUpdatePanel" runat="server" UpdateMode="Always">
                    <ContentTemplate>
                        <fieldset>
                            <dl>
                                <dt></dt>
                                <dd>
                                    <br class="blankLine">
                                    <asp:CheckBox ID="billingaddressissameasmailingaddressCheckBox" runat="server" OnCheckedChanged="SameAsMailingAddressCheckBox_CheckedChanged"
                                        AutoPostBack="true" />
                                    <asp:Label ID="billingaddressissameasmailingaddressLabel" runat="server"></asp:Label>
                                </dd>
                                <dt>&nbsp;&nbsp;<asp:Label ID="billingnameLabel" runat="server"></asp:Label>&nbsp;&nbsp;</dt>
                                <dd>
                                    <asp:TextBox ID="billingnamTexBox" runat="server" CssClass="halfwidth"></asp:TextBox>
                                    <asp:TextBox ID="billingnamTextBox2" runat="server" CssClass="halfwidth"></asp:TextBox>
                                </dd>
                                <dt><span class="asterisk">* </span>&nbsp;&nbsp;<asp:Label ID="countrybillingpageLabel"
                                    runat="server"></asp:Label>&nbsp;&nbsp;</dt>
                                <dd>
                                    <asp:DropDownList ID="countrybillingpageDropDownList" runat="server" CssClass="fullwidth">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="acountrybillingpageDropDownListRequiredFieldValidator"
                                        SetFocusOnError="true" runat="server" ValidationGroup="NextButton" ControlToValidate="countrybillingpageDropDownList"
                                        Display="Dynamic" InitialValue="-1" >
                                    </asp:RequiredFieldValidator>
                                </dd>
                                <dt><span class="asterisk">* </span>&nbsp;&nbsp;<asp:Label ID="billingaddressLabel"
                                    runat="server"></asp:Label>&nbsp;&nbsp;</dt>
                                <dd>
                                    <asp:TextBox ID="billingaddressTextBox" runat="server" CssClass="fullwidth"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="billingaddressTextBoxRequiredFieldValidator" SetFocusOnError="true"
                                        ValidationGroup="NextButton" runat="server" ControlToValidate="billingaddressTextBox"
                                        Display="Dynamic">
                                    </asp:RequiredFieldValidator>
                                </dd>
                                <dt></dt>
                                <dd>
                                    <asp:TextBox ID="billingaddressTextBox2" runat="server" CssClass="fullwidth"></asp:TextBox>
                                </dd>
                                <dt><span class="asterisk">* </span>&nbsp;&nbsp;<asp:Label ID="citytownbillingpageLabel"
                                    runat="server"></asp:Label>&nbsp;&nbsp;</dt>
                                <dd>
                                    <asp:TextBox ID="citytownbillingpageTextBox" runat="server" CssClass="fullwidth"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="citytownbillingpageTextBoxRequiredFieldValidator"
                                        SetFocusOnError="true" ValidationGroup="NextButton" runat="server" ControlToValidate="citytownbillingpageTextBox"
                                         Display="Dynamic">
                                    </asp:RequiredFieldValidator>
                                </dd>
                                <dt><span class="asterisk">* </span>&nbsp;&nbsp;<asp:Label ID="billlocalityLabel"
                                    runat="server"></asp:Label>&nbsp;&nbsp;</dt>
                                <dd>
                                    <asp:TextBox ID="billlocalityTextBox" runat="server" CssClass="fullwidth"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="billlocalityTextBoxRequiredFieldValidator" SetFocusOnError="true"
                                        ValidationGroup="NextButton" runat="server" ControlToValidate="billlocalityTextBox"
                                        Display="Dynamic">
                                    </asp:RequiredFieldValidator>
                                </dd>
                                <dt><span class="asterisk">* </span>&nbsp;&nbsp;<asp:Label ID="zipcodebillingpageLabel"
                                    runat="server"></asp:Label>&nbsp;&nbsp;</dt>
                                <dd>
                                    <asp:TextBox ID="zipcodebillingpageTextBox" runat="server" CssClass="fullwidth"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="zipcodebillingpageTextBoxRequiredFieldValidator"
                                        SetFocusOnError="true" ValidationGroup="NextButton" runat="server" ControlToValidate="zipcodebillingpageTextBox"
                                        Display="Dynamic">
                                    </asp:RequiredFieldValidator>
                                </dd>
                                <dt><span class="asterisk">* </span>&nbsp;&nbsp;<asp:Label ID="phonenumberbillingpageLabel"
                                    runat="server"></asp:Label>&nbsp;&nbsp;</dt>
                                <dd>
                                    <asp:TextBox ID="phonenumberbillingpageTextBox" runat="server" CssClass="fullwidth"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="phonenumberTextBoxRequiredFieldValidator" SetFocusOnError="true"
                                        ValidationGroup="NextButton" runat="server" ControlToValidate="phonenumberbillingpageTextBox"
                                         Display="Dynamic">
                                    </asp:RequiredFieldValidator>
                                </dd>
                                <dt><span class="asterisk">* </span>&nbsp;&nbsp;<asp:Label ID="billingcompanynameLabel"
                                    runat="server"></asp:Label>&nbsp;&nbsp;</dt>
                                <dd>
                                    <asp:TextBox ID="billingcompanynameTextBox" runat="server" CssClass="fullwidth"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="billingcompanynameTextBoxRequiredFieldValidator"
                                        SetFocusOnError="true" ValidationGroup="NextButton" runat="server" ControlToValidate="billingcompanynameTextBox"
                                        Display="Dynamic">
                                    </asp:RequiredFieldValidator>
                                </dd>
                                <dt><span class="asterisk">* </span>&nbsp;&nbsp;<asp:Label ID="invoicebillingemailLabel"
                                    runat="server"></asp:Label>&nbsp;&nbsp;</dt>
                                <dd>
                                    <asp:TextBox ID="invoicebillingemailTextBox" runat="server" CssClass="fullwidth"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="invoicebillingemailTextBoxRequiredFieldValidator"
                                        SetFocusOnError="true" ValidationGroup="NextButton" runat="server" ControlToValidate="invoicebillingemailTextBox"
                                         Display="Dynamic">
                                    </asp:RequiredFieldValidator>
                                </dd>
                            </dl>
                        </fieldset>
                    </ContentTemplate>
                </asp:UpdatePanel>
                <fieldset>
                    <dl>
                        <dt></dt>
                        <dd class="buttons">
                            <asp:Button ID="backButton" runat="server" CssClass="btn_prefer" Text="Back" OnClick="BackButton_Click" />
                        </dd>
                        <dd class="buttons">
                            <asp:Button ID="nextButton" runat="server" CssClass="btn_prefer" Text="Next" OnClick="NextButton_Click"
                                ValidationGroup="NextButton" />
                        </dd>
                    </dl>
                </fieldset>
            </div>
            <div class="box_bottom">
            </div>
        </div>
    </div>
</asp:Content>
