<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ConfirmAccountInformation.aspx.cs"
    Inherits="ARIA.Pages.ConfirmAccountInformation" MasterPageFile="~/Shared/Site.Master" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div id="content" class="signup" style="position: relative; top: 0">
        <div class="pg_box">
            <div class="box_top">
            </div>
            <div class="box_content">
                <div class="section_header">
                    <asp:Label ID="reviewacctinformationLabel" runat="server"></asp:Label>
                </div>
                <div class="instructions">
                    <asp:Label ID="instructionsreviewacctinfoLabel" runat="server"></asp:Label>
                </div>
                <br />
                <div id="infoItemDiv" runat="server" class="info_item">
                    <div class="info_label">
                        [
                        <asp:LinkButton ID="invoiceeditAccountLinkButton" runat="server" OnClick="EditAccount"></asp:LinkButton>
                        ]
                    </div>
                    <div class="info_data">
                        &nbsp;</div>
                </div>
                <div class="info_item">
                    <div class="info_label">
                        <asp:Label ID="invoiceaccountcompanyLabel" runat="server"></asp:Label>
                    </div>
                    <div class="info_data">
                        <asp:Label ID="companyLabel" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="info_item">
                    <div class="info_label">
                        <asp:Label ID="invoiceaccountnameLabel" runat="server"></asp:Label>
                    </div>
                    <div class="info_data">
                        <asp:Label ID="nameLabel" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="info_item">
                    <div class="info_label">
                        <asp:Label ID="invoiceaccountuseridLabel" runat="server"></asp:Label>
                    </div>
                    <div class="info_data">
                        <asp:Label ID="userIdLabel" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="info_item">
                    <div class="info_label">
                        <asp:Label ID="passwordLabel" runat="server"></asp:Label>
                    </div>
                    <div class="info_data">
                        *******</div>
                </div>
                <div class="info_item">
                    <div class="info_label">
                        <asp:Label ID="securityquestionLabel" runat="server"></asp:Label>
                    </div>
                    <div class="info_data">
                        <asp:Label ID="securityQuestionLabel2" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="info_item">
                    <div class="info_label">
                        <asp:Label ID="securityanswerLabel" runat="server"></asp:Label>
                    </div>
                    <div class="info_data">
                        <asp:Label ID="securityanswer2Label" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="info_item">
                    <div class="info_label">
                        <asp:Label ID="invoiceaccountaddressLabel" runat="server"></asp:Label></div>
                    <div class="info_data">
                        <asp:Label ID="addressLabel" runat="server"></asp:Label><br>
                        <asp:Label ID="address2Label" runat="server"></asp:Label><br>
                        <asp:Label ID="cityLabel" runat="server"></asp:Label>,&nbsp;
                        <asp:Label ID="stateProvinceLocalityLabel" runat="server"></asp:Label>&nbsp;
                        <asp:Label ID="zipCodeLabel" runat="server"></asp:Label><br />
                        <asp:Label ID="countryLabel" runat="server"></asp:Label><br />
                    </div>
                </div>
                <div class="info_item">
                    <div class="info_label">
                        <asp:Label ID="invoiceaccountphoneLabel" runat="server"></asp:Label>
                    </div>
                    <div class="info_data">
                        <asp:Label ID="phoneLabel" runat="server"></asp:Label>
                    </div>
                </div>
                <div class="info_item">
                    <div class="info_label">
                        <asp:Label ID="invoiceaccountemailLabel" runat="server"></asp:Label></div>
                    <div class="info_data">
                        <asp:Label ID="emailLabel" runat="server"></asp:Label></div>
                </div>
                <div class="info_item">
                    <div class="info_label">
                        &nbsp;</div>
                    <div class="info_data">
                        &nbsp;</div>
                </div>
                <div class="button_container">
                    <asp:Button ID="createAccountButton" runat="server" CssClass="btn_prefer" Text="Next"
                        OnClick="CreateAccountButton_Click" />
                </div>
                <br>
                <br>
                <!-- content ends here -->
            </div>
            <div class="box_bottom">
            </div>
        </div>
    </div>
</asp:Content>
