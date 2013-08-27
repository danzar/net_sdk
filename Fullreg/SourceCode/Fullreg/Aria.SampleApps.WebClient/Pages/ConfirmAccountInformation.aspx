<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfirmAccountInformation.aspx.cs"
    Inherits="ARIA.Pages.ConfirmAccountInformation" MasterPageFile="~/Shared/Site.Master" %>

<%@ Register Src="~/Pages/UserControls/PlanInfoUserControl.ascx" TagName="PlanInfoUserControl"
    TagPrefix="uc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div id="content" class="signup">
        <div class="pg_title">
            <asp:Label ID="acctinfoandinvoiceLabel" runat="server"></asp:Label>
        </div>
        <div class="pg_box">
            <div class="box_top">
            </div>
            <div class="box_content">
                <div class="accountDataBlurb" id="accountBlurb">
                    <h2 style="float: left;">
                        <asp:Label ID="invoiceaccountheaderLabel" runat="server"></asp:Label>
                    </h2>
                    <span class="subtext help">(&nbsp;
                        <asp:LinkButton ID="invoiceeditAccountLinkButton" runat="server" OnClick="EditAccount"></asp:LinkButton>
                        &nbsp;)</span>
                </div>
                <br style="clear: both" />
                <table cellpadding="0" cellspacing="0" border="0" class="review_subscription">
                    <tr>
                        <td>
                            <asp:Label ID="invoiceaccountnameLabel" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="nameLabel" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="invoiceaccountcompanyLabel" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="companyLabel" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="invoiceaccountaddressLabel" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="addressLabel" runat="server"></asp:Label><br>
                            <asp:Label ID="address2Label" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="invoiceaccountcityLabel" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="cityLabel" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="invoiceaccountstateLabel" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="stateLabel" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="invoiceaccountcountryLabel" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="countryLabel" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="invoiceaccountzipLabel" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="zipCodeLabel" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="invoiceaccountphoneLabel" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="phoneLabel" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="invoiceaccountemailLabel" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="emailLabel" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="invoiceaccountuseridLabel" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="userIdLabel" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr class="blankLine">
                        <td class="blankLine">
                            &nbsp;
                        </td>
                        <td class="blankLine">
                            &nbsp;
                        </td>
                    </tr>
                </table>
                <div class="accountDataBlurb" id="Div1">
                    <h2 style="float: left;">
                        <asp:Label ID="invoicebillingheaderLabel" runat="server"></asp:Label>
                    </h2>
                    <span class="subtext help">(&nbsp;
                        <asp:LinkButton ID="invoiceeditBillingInfoLinkButton" OnClick="EditBillingInformation"
                            runat="server"></asp:LinkButton>
                        &nbsp;)</span>
                </div>
                <br style="clear: both" />
                <table cellpadding="0" cellspacing="0" border="0" class="review_subscription">
                    <tr>
                        <td>
                            <asp:Label ID="invoicebillingnameLabel" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="billingNameLabel" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="invoicebillingcompanyLabel" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="billingCompanyLabel" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="invoicebillingaddressLabel" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="billingAddressLabel" runat="server"></asp:Label><br>
                            <asp:Label ID="billingAddress2Label" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="invoicebillingcityLabel" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="billingCityLabel" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="invoicebillingstateLabel" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="billintStateLabel" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="invoicebillingcountryLabel" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="billingCountryLabel" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="invoicebillingzipLabel" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="billingZipCodeLabel" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="invoicebillingphoneLabel" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="billingPhoneLabel" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="invoicebillingemailLabel" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="billingEmailLabel" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr class="blankLine">
                        <td class="blankLine">
                            &nbsp;
                        </td>
                        <td class="blankLine">
                            &nbsp;
                        </td>
                    </tr>
                </table>
                <div class="accountDataBlurb" id="Div2">
                    <h2 style="float: left;">
                        <asp:Label ID="invoiceplanheaderLabel" runat="server"></asp:Label>
                    </h2>
                    <span class="subtext help">(&nbsp;
                        <asp:LinkButton ID="invoiceeditPlanLinkButton" OnClick="EditAccount" runat="server"></asp:LinkButton>
                        &nbsp;)</span>
                </div>
                <br style="clear: both" />
                <table cellpadding="0" cellspacing="0" border="0" class="review_subscription">
                    <tr>
                        <td>
                            <asp:Label ID="invoicemasterplanLabel" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="masterPlanDescLabel" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="invoicesupplementalplansLabel" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:ListView ID="suppPlansListView" runat="server">
                                <LayoutTemplate>
                                    <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
                                </LayoutTemplate>
                                <ItemTemplate>
                                    <asp:Label ID="suppPlanLabel" runat="server" Text='<%# Eval("Description").ToString() + " (Units: " + Eval("Price").ToString() + ")"  %>'>
                                    </asp:Label><br>
                                </ItemTemplate>
                            </asp:ListView>
                        </td>
                    </tr>
                    <tr class="blankLine">
                        <td class="blankLine">
                            &nbsp;
                        </td>
                        <td class="blankLine">
                            &nbsp;
                        </td>
                    </tr>
                </table>
                <div class="accountDataBlurb" id="Div3">
                    <h2 style="float: left;">
                        <asp:Label ID="invoiceblurbLabel" runat="server"></asp:Label>
                    </h2>
                    <span class="subtext help">(&nbsp;
                        <asp:LinkButton ID="invoiceeditSumaryOfChargesLinkButton" OnClick="EditAccount" runat="server"></asp:LinkButton>
                        &nbsp;)</span>
                </div>
                <br style="clear: both" />
                <table cellpadding="0" cellspacing="0" border="0" class="review_invoice" width="80%">
                    <tr>
                        <td class='itemHeader' colspan='4'>
                            <b>
                                <asp:Label ID="invoicemasterplanLabel2" runat="server"></asp:Label>
                            </b>
                            <asp:Label ID="masterPlanSummaryNameLabel" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td class="header">
                            <strong>
                                <asp:Label ID="invoicedescriptionLabel" runat="server"></asp:Label></strong>
                        </td>
                        <td class="header">
                            <strong>
                                <asp:Label ID="invoiceunitsLabel" runat="server"></asp:Label>
                            </strong>
                        </td>
                        <td class="header">
                            <strong>
                                <asp:Label ID="invoicerateperunitLabel" runat="server"></asp:Label></strong>
                        </td>
                        <td class="header">
                            <strong>
                                <asp:Label ID="invoiceamountLabel" runat="server"></asp:Label></strong>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="masterPlanSummaryDescriptionLabel" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="masterPlanSummaryUnitsLabel" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="masterPlanSummaryPriceLabel" runat="server"></asp:Label>
                        </td>
                        <td>
                            <asp:Label ID="masterPlanSummaryAmountLabel" runat="server"></asp:Label>
                        </td>
                    </tr>
                    <asp:ListView ID="suppPlansSummaryListView" runat="server">
                        <LayoutTemplate>
                            <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
                        </LayoutTemplate>
                        <ItemTemplate>
                            <tr class='blankLine'>
                                <td class='blankLine' colspan='4'>
                                    &nbsp;
                                </td>
                            </tr>
                            <tr>
                                <td class='itemHeader' colspan='4'>
                                    <b>
                                        <asp:Label ID="invoicesupplementalplanLabel" Text="Supplemental Plan" runat="server"></asp:Label>
                                    </b>
                                    <asp:Label ID="suppPlanSummaryNameLabel" Text='<%# Eval("Name") %>' runat="server"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="suppPlanSummaryDescriptionLabel" Text='<%# Eval("Description") %>'
                                        runat="server">
                                    </asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="suppPlanSummaryUnitsLabel" Text='<%# Eval("Units") %>' runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="suppPlanSummaryPriceLabel" Text='<%# Eval("Price") %>' runat="server"></asp:Label>
                                </td>
                                <td>
                                    <asp:Label ID="suppPlanSummaryAmountLabel" Text='<%# (long)Eval("Units") * (double)Eval("Price") %>'
                                        runat="server"></asp:Label>
                                </td>
                            </tr>
                        </ItemTemplate>
                    </asp:ListView>
                    <tr>
                        <td class='total_row' colspan='3'>
                            <asp:Label ID="invoicetotalLabel" runat="server"></asp:Label>
                            &nbsp;
                        </td>
                        <td class='total_row' style='text-align: left'>
                            <asp:Label ID="totalLabel" runat="server"></asp:Label>
                        </td>
                    </tr>
                </table>
                <fieldset>
                    <dl>
                        <dt></dt>
                        <dd class="buttons">
                            <asp:Button ID="cancelButton" runat="server" CssClass="btn_prefer" Text="Cancel"
                                OnClick="CancelButton_Click" />
                        </dd>
                        <dd class="buttons">
                            <asp:Button ID="nextButton" runat="server" CssClass="btn_prefer" Text="Next" OnClick="NextButton_Click" />
                        </dd>
                    </dl>
                </fieldset>
            </div>
            <div class="box_bottom">
            </div>
        </div>
    </div>
</asp:Content>
