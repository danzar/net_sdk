<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Receipt.aspx.cs" Inherits="ARIA.Pages.Receipt"
    MasterPageFile="~/Shared/Site.Master" %>

<%@ Register Src="~/Pages/UserControls/PlanInfoUserControl.ascx" TagName="PlanInfoUserControl"
    TagPrefix="uc1" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div id="content" class="signup">
        <div class="pg_title">
            <div class="subtext help" style="float: right;">
                <a href="javascript:window.print();">
                    <asp:Label ID="printthispageLabel" runat="server"> </asp:Label></a>
            </div>
            <h1 style="margin-right: 4em;">
                <asp:Label ID="congratulationsLabel" runat="server"> </asp:Label></h1>
        </div>
        <div class="pg_box">
            <div class="box_top">
            </div>
            <div class="box_content">
                <p>
                    <asp:Label ID="successfulsignupLabel" runat="server"></asp:Label>
                    <br>
                    <asp:Label ID="successfulsignupreceiveemailLabel" runat="server"></asp:Label>
                </p>
                <div class="Section_Container SubscriptionReceipt_Container">
                    <div class="SubscriptionReceipt_Header">
                        <h2 style="float: left;">
                            <asp:Label ID="receiptLabel" runat="server"></asp:Label></h2>
                        <br>
                    </div>
                    <div class="SubscriptionReceipt_Content clearfix">
                        <div class="Section_Container">
                            <div class="Section_Header">
                                <h3>
                                    <asp:Label ID="yourserviceLabel" runat="server"></asp:Label></h3>
                            </div>
                            <p>
                                <br style="clear: both">
                            </p>
                            <table cellpadding="0" cellspacing="0" border="0" class="review_invoice">
                                <tr>
                                    <td>
                                        <asp:label id="invoicemasterplanLabel" runat="server"></asp:label>
                                    </td>
                                    <td>
                                        <asp:label id="masterPlanDescLabel" runat="server"></asp:label>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:label id="invoicesupplementalplansLabel" runat="server"></asp:label>
                                    </td>
                                    <td>
                                        <asp:listview id="suppPlansListView" runat="server">
                                            <LayoutTemplate>
                                                <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
                                            </LayoutTemplate>
                                            <ItemTemplate>
                                                <asp:Label ID="suppPlanLabel" runat="server" Text='<%# Eval("Description").ToString() + " (Units: " + Eval("Price").ToString() + ")"  %>'>
                                                </asp:Label><br>
                                            </ItemTemplate>
                                        </asp:listview>
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
                                    <asp:label id="invoiceblurbLabel" runat="server"></asp:label>
                                </h2>
                            </div>
                            <br style="clear: both" />
                            <table cellpadding="0" cellspacing="0" border="0" class="review_invoice" width="80%">
                                <tr>
                                    <td class='itemHeader' colspan='4'>
                                        <b>
                                            <asp:label id="invoicemasterplanLabel2" runat="server"></asp:label>
                                        </b>
                                        <asp:label id="masterPlanSummaryNameLabel" runat="server"></asp:label>
                                    </td>
                                </tr>
                                <tr>
                                    <td class="header">
                                        <strong>
                                            <asp:label id="invoicedescriptionLabel" runat="server"></asp:label>
                                        </strong>
                                    </td>
                                    <td class="header">
                                        <strong>
                                            <asp:label id="invoiceunitsLabel" runat="server"></asp:label>
                                        </strong>
                                    </td>
                                    <td class="header">
                                        <strong>
                                            <asp:label id="invoicerateperunitLabel" runat="server"></asp:label>
                                        </strong>
                                    </td>
                                    <td class="header">
                                        <strong>
                                            <asp:label id="invoiceamountLabel" runat="server"></asp:label>
                                        </strong>
                                    </td>
                                </tr>
                                <tr>
                                    <td>
                                        <asp:label id="masterPlanSummaryDescriptionLabel" runat="server"></asp:label>
                                    </td>
                                    <td>
                                        <asp:label id="masterPlanSummaryUnitsLabel" runat="server"></asp:label>
                                    </td>
                                    <td>
                                        <asp:label id="masterPlanSummaryPriceLabel" runat="server"></asp:label>
                                    </td>
                                    <td>
                                        <asp:label id="masterPlanSummaryAmountLabel" runat="server"></asp:label>
                                    </td>
                                </tr>
                                <asp:listview id="suppPlansSummaryListView" runat="server">
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
                                                <asp:Label ID="suppPlanSummaryAmountLabel" Text='<%# (long)Eval("Units")*(double)Eval("Price") %>'
                                                    runat="server"></asp:Label>
                                            </td>
                                        </tr>
                                    </ItemTemplate>
                                </asp:listview>
                                <tr>
                                    <td class='total_row' colspan='3'>
                                        <asp:label id="invoicetotalLabel" runat="server"></asp:label>
                                        &nbsp;
                                    </td>
                                    <td class='total_row' style='text-align: left'>
                                        <asp:label id="totalLabel" runat="server"></asp:label>
                                    </td>
                                </tr>
                            </table>
                        </div>
                    </div>
                </div>
            </div>
            <div class="box_bottom">
            </div>
        </div>
    </div>
</asp:Content>
