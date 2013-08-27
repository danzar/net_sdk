<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PlanInfoUserControl.ascx.cs"
    Inherits="ARIA.Pages.UserControls.PlanInfoUserControl" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<style type="text/css">
    .jsAction:hover
    {
        cursor: pointer;
        text-decoration: underline;
    }
</style>
<asp:UpdatePanel ID="planUpdatePanel" runat="server" UpdateMode="Conditional" OnLoad="RegisterScript">
    <ContentTemplate>
        <fieldset>
            <div id="accountInfoDiv" class="sec_title">
                <h2>
                    <asp:Label ID="selectplaninformationLabel" runat="server"></asp:Label></h2>
            </div>
            <dl>
                <dt>&nbsp;&nbsp;<asp:Label ID="selectcurrencyLabel" runat="server"></asp:Label>&nbsp;&nbsp;</dt>
                <dd>
                    <asp:DropDownList ID="selectcurrencyLabelDropDownList" runat="server" CssClass="currency_dropdown"
                        AutoPostBack="true" OnSelectedIndexChanged="LoadPlansByCurrencyCd">
                    </asp:DropDownList>
                    <br>
                    <br>
                </dd>
                <dt>&nbsp;&nbsp;<asp:Label ID="ifyouhavecuponcodeLabel" runat="server"></asp:Label>&nbsp;&nbsp;</dt>
                <dd>
                    <asp:TextBox ID="ifyouhavecuponcodeTextBox" runat="server" CssClass="fullwidth"></asp:TextBox>
                    <br>
                    <br>
                </dd>
                <dt>&nbsp;&nbsp;<asp:Label ID="ifyouhavepromocodeLabel" runat="server"></asp:Label>&nbsp;&nbsp;</dt>
                <dd>
                    <asp:TextBox ID="ifyouhavepromocodeLabelTexBox" runat="server" CssClass="fullwidth"></asp:TextBox>
                    <br>
                    <br>
                </dd>
            </dl>
        </fieldset>
        <div id="wrapperExternal" runat="server" visible="true">
            <div id="wrapper">
                <div id="slider">
                    <img id="scrollButtonLeft" class="scrollButtons left" src="../../App_Themes/Default/images/scroll_left.png">
                    <div style="overflow: hidden" class="scroll">
                        <div style="width: 702px" id="scrollContainer" class="scrollContainer">
                            <div style="position: relative; float: left" id="sites" class="panel">
                                <div class="roundedcornr_box_898814">
                                    <div class="roundedcornr_top_898814">
                                        <div>
                                        </div>
                                    </div>
                                    <div class="roundedcornr_content_898814">
                                        <p>
                                            <span class="planRadio">&nbsp;</span>
                                            <div class="planHeader">
                                                &nbsp;</div>
                                            <div class="planDesc">
                                                <asp:Label ID="loadingpleasewaitLabel" runat="server"></asp:Label>
                                                <br>
                                                <br>
                                                <br>
                                                <br>
                                                <br>
                                                <div align="center">
                                                    <img alt="Waiting_animation" src="../App_Themes/Default/images/loading-rotate.gif"></div>
                                            </div>
                                            <p>
                                            </p>
                                    </div>
                                    <div class="roundedcornr_bottom_898814">
                                        <div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div style="position: relative; float: left" id="sites" class="panel">
                                <div class="roundedcornr_box_898814">
                                    <div class="roundedcornr_top_898814">
                                        <div>
                                        </div>
                                    </div>
                                    <div class="roundedcornr_content_898814">
                                        <p>
                                            <span class="planRadio">&nbsp;</span>
                                            <div class="planHeader">
                                                &nbsp;</div>
                                            <div class="planDesc">
                                                <asp:Label ID="loadingpleasewaitLabel2" runat="server"></asp:Label>
                                                <br>
                                                <br>
                                                <br>
                                                <br>
                                                <br>
                                                <div align="center">
                                                    <img alt="Waiting_animation" src="../App_Themes/Default/images/loading-rotate.gif"></div>
                                            </div>
                                            <p>
                                            </p>
                                    </div>
                                    <div class="roundedcornr_bottom_898814">
                                        <div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                            <div style="position: relative; float: left" id="sites" class="panel">
                                <div class="roundedcornr_box_898814">
                                    <div class="roundedcornr_top_898814">
                                        <div>
                                        </div>
                                    </div>
                                    <div class="roundedcornr_content_898814">
                                        <p>
                                            <span class="planRadio">&nbsp;</span>
                                            <div class="planHeader">
                                                &nbsp;</div>
                                            <div class="planDesc">
                                                 <asp:Label ID="loadingpleasewaitLabel3" runat="server"></asp:Label>
                                                <br>
                                                <br>
                                                <br>
                                                <br>
                                                <br>
                                                <div align="center">
                                                    <img alt="Waiting_animation" src="../App_Themes/Default/images/loading-rotate.gif"></div>
                                            </div>
                                            <p>
                                            </p>
                                    </div>
                                    <div class="roundedcornr_bottom_898814">
                                        <div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                    <img id="scrollButtonRight" class="scrollButtons right" src="../App_Themes/Default/images/scroll_right.png">
                    <div id="shade">
                    </div>
                </div>
            </div>
        </div>
        <asp:ListView ID="plansListView" runat="server" OnDataBound="PlansListViewOnDataBound">
            <LayoutTemplate>
                <div id="wrapper">
                    <div id="slider">
                        <img id="scrollButtonLeft" class="scrollButtons left" src="../../App_Themes/Default/images/scroll_left.png">
                        <div class="scroll" style="overflow: hidden;">
                            <div id="scrollContainer" class="scrollContainer" style="width: 99999px;">
                                <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
                            </div>
                        </div>
                        <img id="scrollButtonRight" class="scrollButtons right" src="../../App_Themes/Default/images/scroll_right.png">
                        <div id="shade">
                        </div>
                    </div>
                </div>
            </LayoutTemplate>
            <ItemTemplate>
                <div id="sites" class="panel" style="float: left; position: relative;">
                    <div class="roundedcornr_box_898814">
                        <div class="roundedcornr_top_898814">
                            <div>
                            </div>
                        </div>
                        <div class="roundedcornr_content_898814">
                            <p>
                                <span class="planRadio">
                                    <asp:Literal ID="planNoRadioButton" runat="server" Text='<%# BuildRadioButton((bool)Eval("MasterPlan"), (long)Eval("Id")) %>'>
                                    </asp:Literal>
                                    <asp:Literal ID="planNoHiddenField" runat="server" Visible="false" Text='<%# Eval("Id") %>'>
                                    </asp:Literal>
                                </span>
                            </p>
                            <div class="planHeader">
                                <%# Eval("Name") %>
                            </div>
                            <div class="planDesc">
                                <%# Eval("Description") %>
                            </div>
                            <div class="priceInfo">
                                <div class="planQuantity">
                                    <asp:Literal ID="unitsLabel" runat="server"></asp:Literal>
                                    <input id="planUnitsTexBox" class="master_plan_input" type="text" runat="server"
                                        onkeyup="NumberValidator(this);" value='<%# Eval("Units") %>' size="4" style='z-index: 0' />
                                </div>
                                <div>
                                    <div class="display_price">
                                        <span class="currency_symbol">
                                            <%# Eval("CurrencySymbol") %>
                                        </span><span class="plan_price">
                                            <%# Eval("Price") %>
                                        </span><span class="currency_text">
                                            <%# Eval("CurrencyCd") %>
                                        </span><span class="plan_interval">
                                            <%# Eval("IntervalName") %>
                                        </span>
                                    </div>
                                    <div class="breakdownlink">
                                        <a class="basic" rel="./DetailsServices.aspx?planId=<%# Eval("Id") %>" href="#" title=""
                                            style="" onmouseover="javascript:setTooltip('a.basic');">
                                            <asp:Literal ID="planPricingDetailsLabel" runat="server"></asp:Literal>
                                        </a>
                                    </div>
                                </div>
                            </div>
                            <p>
                            </p>
                        </div>
                        <div class="roundedcornr_bottom_898814">
                            <div>
                            </div>
                        </div>
                    </div>
                </div>
            </ItemTemplate>
            <EmptyDataTemplate>
                <div>
                    No plans found</div>
            </EmptyDataTemplate>
        </asp:ListView>
        <asp:Button ID="btnLoad" runat="server" Text="Load" OnClick="LoadPlansData" Style="display: none;" />
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="btnLoad" EventName="Click" />
    </Triggers>
</asp:UpdatePanel>
<asp:UpdatePanel ID="suppPlansUpdatePanel" runat="server" UpdateMode="Conditional">
    <ContentTemplate>
        <asp:TextBox ID="plansValidator" runat="server" Style="display: none;" />
        <asp:RequiredFieldValidator ID="plansRequiredFieldValidator" SetFocusOnError="true"
            ValidationGroup="NextButton" runat="server" ControlToValidate="plansValidator"
            Display="Dynamic">
        </asp:RequiredFieldValidator>
        <h3>
            &nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="choosesupplementalplanLabel" runat="server"></asp:Label>
        </h3>
        <div class="prodTable" style="width: 710px">
            <div id="newPlans" style="width: 710px">
                <asp:Button ID="LoadSuppPlansAndServicesButton" runat="server" OnClick="LoadSuppPlansAndServices"
                    Style="display: none;" />
                <asp:GridView CssClass="products" ID="suppPlansGridView" Width="690" runat="server"
                    ShowHeader="false" AutoGenerateColumns="false" GridLines="None" OnRowDataBound="SuppPlansGridViewOnRowDataBound">
                    <Columns>
                        <asp:TemplateField ItemStyle-Width="30%">
                            <ItemTemplate>
                                <asp:Label ID="nameLabel" runat="server" Text='<%# Eval("Name") %>' Font-Bold="True"></asp:Label>
                                <asp:HiddenField ID="suppPlanIdHiddenField" runat="server" Value='<%# Eval("Id") %>' />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField ItemStyle-Width="30%">
                            <ItemTemplate>
                                <asp:Label ID="descLabel" runat="server" Text='<%# Eval("Description") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField ItemStyle-Width="20%">
                            <ItemTemplate>
                                <asp:Label ID="currencySymbolLabel" runat="server" Text='<%# Eval("CurrencySymbol") %>'> 
                                </asp:Label>
                                <asp:Label ID="planPriceLabel" runat="server" Text='<%# Eval("Price") %>'>
                                </asp:Label>&nbsp;
                                <asp:Label ID="currencyTextLabel" runat="server" Text='<%# Eval("CurrencyCd") %>'>
                                </asp:Label>&nbsp;
                                <asp:Label ID="planIntervalLabel" runat="server" Text='<%# Eval("IntervalName") %>'>
                                </asp:Label>&nbsp;
                                <br>
                                <a class="basic" rel="./DetailsServices.aspx?planId=<%# Eval("Id") %>" href="#" title=""
                                    style="" onmouseover="javascript:setTooltip('a.basic');">
                                    <asp:Literal ID="priceDetailLinkButton" runat="server"></asp:Literal>
                                </a>
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField ItemStyle-Width="20%" ItemStyle-Wrap="False" ItemStyle-HorizontalAlign="Right">
                            <ItemTemplate>
                                <asp:Label ID="unitsLabel" runat="server"></asp:Label>
                                <asp:TextBox ID="unitsTexBox" runat="server" Rows="4" Columns="4" Text='<%# Eval("Units") %>'> </asp:TextBox>
                                <ajaxToolkit:FilteredTextBoxExtender ID="unitsTexBoxFilteredTextBoxExtender" runat="server"
                                    TargetControlID="unitsTexBox" FilterType="Numbers" />
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
