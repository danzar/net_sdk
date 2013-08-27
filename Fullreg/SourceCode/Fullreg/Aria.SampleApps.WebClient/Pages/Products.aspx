<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products.aspx.cs" MasterPageFile="~/Shared/Site.Master"
    Inherits="ARIA.Pages.Products" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div id="content" class="signup">
        <div class="pg_box">
            <div class="box_top">
            </div>
            <div class="box_content">
                <div class="pg_title">
                    <h2>
                        <asp:label id="selectproductsLabel" runat="server"></asp:label>
                    </h2>
                </div>
                <fieldset>
                    <div id="prod_info" class="sec_title">
                        <h3>
                            <asp:label id="checkproductsLabel" runat="server"></asp:label>
                        </h3>
                        <div class="prodTable">
                            <asp:gridview cssclass="products" id="productsGridView" width="600" runat="server"
                                showheader="false" autogeneratecolumns="false" gridlines="None">
                                <Columns>
                                    <asp:TemplateField ItemStyle-Width="65%">
                                        <ItemTemplate>
                                            <asp:Label ID="nameLabel" runat="server" Text='<%# Eval("Name") %>' Font-Bold="True"></asp:Label>
                                            <asp:HiddenField ID="prodIdHiddenField" runat="server" Value='<%# Eval("ClientSku") %>' />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                    <asp:TemplateField ItemStyle-Width="35%" ItemStyle-Wrap="False" ItemStyle-HorizontalAlign="Right">
                                        <ItemTemplate>
                                            <asp:Label ID="unitsLabel" runat="server" Text="How Many? "></asp:Label>
                                            <asp:TextBox ID="unitsTexBox" runat="server" Rows="4" Columns="4"> </asp:TextBox>
                                            <ajaxToolkit:FilteredTextBoxExtender ID="unitsTexBoxFilteredTextBoxExtender" runat="server"
                                                TargetControlID="unitsTexBox" FilterType="Numbers" />
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:gridview>
                        </div>
                    </div>
                    <fieldset>
                        <dl>
                            <dt></dt>
                            <dd class="buttons">
                                <asp:button id="backButton" runat="server" cssclass="btn_prefer" text="Back" onclick="BackButton_Click" />
                            </dd>
                            <dd class="buttons">
                                <asp:button id="nextButton" runat="server" cssclass="btn_prefer" text="Next" onclick="NextButton_Click" />
                            </dd>
                        </dl>
                    </fieldset>
                </fieldset>
            </div>
            <div class="box_bottom">
            </div>
        </div>
    </div>
</asp:Content>
