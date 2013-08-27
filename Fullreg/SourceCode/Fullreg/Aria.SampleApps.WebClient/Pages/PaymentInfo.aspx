<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PaymentInfo.aspx.cs" MasterPageFile="~/Shared/Site.Master"
    Inherits="ARIA.Pages.PaymentInfo" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div id="content" class="signup">
        <div class="pg_box">
            <div class="box_top">
            </div>
            <div class="box_content">
                <div class="pg_title">
                    <h2>
                        <asp:Label ID="confirmandenterbankinginfoLabel" runat="server"></asp:Label>
                    </h2>
                </div>
                <fieldset class="paymethodfieldset">
                    <dl>
                        <asp:CustomValidator ID="servermustselectpaymethodCustomValidator" SetFocusOnError="true"
                            runat="server" />
                        <div class="Section_Header">
                            <h2>
                                <asp:RadioButton ID="payByCreditCardRadioButton" runat="server" AutoPostBack="true"
                                    OnCheckedChanged="PayByCreditCardRadioButtonCheckedChange" />
                                <asp:Label ID="pbccLabel" runat="server"></asp:Label></h2>
                        </div>
                        <dt></dt>
                        <dd>
                            <img src="../App_Themes/Default/images/creditcard_mc.gif">
                            <img src="../App_Themes/Default/images/creditcard_visa.gif">
                            <img src="../App_Themes/Default/images/creditcard_amex.gif">
                            <img src="../App_Themes/Default/images/creditcard_discover.gif">
                        </dd>
                        <dt>
                            <asp:Label ID="ccnumLabel" runat="server"></asp:Label></dt>
                        <dd>
                            <asp:TextBox ID="cardNumberTextBox" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="cardNumberTextBoxRequiredFieldValidator" SetFocusOnError="true"
                                ValidationGroup="NextButton" runat="server" ControlToValidate="cardNumberTextBox"
                                Display="Dynamic">
                            </asp:RequiredFieldValidator>
                            <ajaxToolkit:FilteredTextBoxExtender ID="cardNumberTextBoxFilteredTextBoxExtender"
                                runat="server" TargetControlID="cardNumberTextBox" FilterType="Numbers" />
                            <asp:CustomValidator ID="serverlengthofccnumberCustomValidator" SetFocusOnError="true"
                                runat="server">
                            </asp:CustomValidator>
                        </dd>
                        <dt>
                            <asp:Label ID="expdateLabel" runat="server">
                            </asp:Label>
                        </dt>
                        <dd>
                            <table cellpadding="0" cellspacing="0">
                                <tr>
                                    <td>
                                        <asp:DropDownList ID="monthDropDown" runat="server">
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="monthDropDownRequiredFieldValidator" SetFocusOnError="true"
                                            runat="server" ValidationGroup="NextButton" ControlToValidate="monthDropDown"
                                            Display="Dynamic" InitialValue="-1">
                                        </asp:RequiredFieldValidator>
                                    </td>
                                    <td width="20">
                                        &nbsp;
                                    </td>
                                    <td>
                                        <asp:DropDownList ID="yearDropDown" runat="server">
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="yearDropDownRequiredFieldValidator" SetFocusOnError="true"
                                            runat="server" ValidationGroup="NextButton" ControlToValidate="yearDropDown"
                                            Display="Dynamic" InitialValue="-1">
                                        </asp:RequiredFieldValidator>
                                        <asp:CustomValidator ID="serverccexpiredCustomValidator" SetFocusOnError="true" runat="server">
                                        </asp:CustomValidator>
                                    </td>
                                </tr>
                            </table>
                        </dd>
                        <dt>
                            <asp:Label ID="cvvLabel" runat="server"></asp:Label></dt>
                        <dd>
                            <asp:TextBox ID="securityCodeTextBox" Columns="5" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="securityCodeTextBoxRequiredFieldValidator" SetFocusOnError="true"
                                ValidationGroup="NextButton" runat="server" ControlToValidate="securityCodeTextBox"
                                Display="Dynamic">
                            </asp:RequiredFieldValidator>
                            <asp:CustomValidator ID="servercvvhowmanydigitsCustomValidator" SetFocusOnError="true"
                                runat="server">
                            </asp:CustomValidator>
                            <asp:LinkButton ID="whatisthisLinkButton" CssClass="help" OnClientClick="javascript:showpopUp()"
                                runat="server"></asp:LinkButton>
                            <asp:CustomValidator ID="serverinvalidccnumberCustomValidator" SetFocusOnError="true"
                                runat="server" ControlToValidate="securityCodeTextBox" ClientValidationFunction="ValidateSecurityCodeLenght">
                            </asp:CustomValidator>
                        </dd>
                    </dl>
                </fieldset>
                <fieldset class="paymethodfieldset">
                    <dl id="payMethodACH" class="paymethodACH">
                        <div class="Section_Header">
                            <h2>
                                <asp:RadioButton ID="payByAchRadioButton" runat="server" AutoPostBack="true" OnCheckedChanged="PayByAchRadioButtonCheckedChange" />
                                <asp:Label ID="paybyachLabel" runat="server"></asp:Label></h2>
                        </div>
                        <dt>
                            <asp:Label ID="achroutingnumLabel" runat="server"></asp:Label></dt>
                        <dd>
                            <asp:TextBox ID="routingNumberTextBox" runat="server" MaxLength="9"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="routingNumberTextBoxRequiredFieldValidator" SetFocusOnError="true"
                                ValidationGroup="NextButton" runat="server" ControlToValidate="routingNumberTextBox"
                                Display="Dynamic">
                            </asp:RequiredFieldValidator>
                            <ajaxToolkit:FilteredTextBoxExtender ID="routingNumberTextBoxFilteredTextBoxExtender"
                                runat="server" TargetControlID="routingNumberTextBox" FilterType="Numbers" />
                            <asp:CustomValidator ID="routingNumberTextBoxCustomValidator" SetFocusOnError="true"
                                runat="server" ControlToValidate="routingNumberTextBox" ClientValidationFunction="ValidateRoutingNumberLenght">
                            </asp:CustomValidator>
                        </dd>
                        <dt>
                            <asp:Label ID="achacctnumLabel" runat="server"></asp:Label></dt>
                        <dd>
                            <asp:TextBox ID="accNumberTextBox" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="accNumberTextBoxRequiredFieldValidator" SetFocusOnError="true"
                                ValidationGroup="NextButton" runat="server" ControlToValidate="accNumberTextBox"
                                Display="Dynamic">
                            </asp:RequiredFieldValidator>
                            <ajaxToolkit:FilteredTextBoxExtender ID="accNumberTextBoxFilteredTextBoxExtender"
                                runat="server" TargetControlID="accNumberTextBox" FilterType="Numbers" />
                            <asp:CustomValidator ID="accNumberTextBoxCustomValidator" SetFocusOnError="true"
                                runat="server" ControlToValidate="accNumberTextBox" ClientValidationFunction="ValidateBankAccountNumberLenght">
                            </asp:CustomValidator>
                        </dd>
                    </dl>
                </fieldset>
                <h2>
                    <asp:Label ID="payusingnettermsLabel" runat="server"></asp:Label>
                </h2>
                <fieldset class="paymethodfieldset">
                    <asp:ListView ID="netTermsListView" runat="server">
                        <LayoutTemplate>
                            <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
                        </LayoutTemplate>
                        <ItemTemplate>
                            <dl class="paymethod2">
                                <dt>
                                    <div class="Section_Header">
                                        <h3>
                                            <asp:HiddenField ID="netTermHiddenField" runat="server" Value='<%# Eval("key") %>' />
                                            <asp:RadioButton ID="netTermRadioButton" runat="server" AutoPostBack="true" OnCheckedChanged="NetTermRaddioButtonCheckedCanged" />
                                            <asp:Label ID="netTermLabel" Text='<%# Eval("value") %>' runat="server">
                                            </asp:Label>
                                        </h3>
                                    </div>
                                </dt>
                            </dl>
                        </ItemTemplate>
                    </asp:ListView>
                </fieldset>
                <fieldset>
                    <dl>
                        <dt></dt>
                        <dd class="buttons">
                            <asp:Button ID="nextButton" runat="server" CssClass="btn_prefer" ValidationGroup="NextButton"
                                OnClick="NextButton_Click" />
                        </dd>
                    </dl>
                </fieldset>
            </div>
            <div class="box_bottom">
            </div>
        </div>
    </div>
</asp:Content>
