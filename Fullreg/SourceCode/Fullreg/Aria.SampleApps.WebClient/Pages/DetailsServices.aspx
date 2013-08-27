<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailsServices.aspx.cs"
    Inherits="ARIA.Pages.DetailsServices" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class='pricing_breakdown_wrapper'>
        <div class="services_included">
            <asp:Label ID="planpricing_includedservicesLabel" runat="server"></asp:Label>
        </div>
        <asp:ListView ID="planServicesListView" runat="server">
            <LayoutTemplate>
                <asp:PlaceHolder ID="itemPlaceHolder" runat="server" />
            </LayoutTemplate>
            <ItemTemplate>
                <div class="service_wrapper">
                    <div class="planpricing_plan_desc">
                        <span class="service_type">
                            <asp:Literal ID="serviceDescLabel" runat="server" Text='<%# Eval("Description") %>'></asp:Literal>
                        </span>
                    </div>
                    <span class="currency_symbol">
                        <asp:Literal ID="currencySymbolLabel" runat="server" Text='<%# Eval("CurrencySymbol") %>'>
                        </asp:Literal>
                    </span><span class="plan_price">
                        <asp:Literal ID="planPriceLabel" runat="server" Text='<%# Eval("Price") %>'>
                        </asp:Literal>
                    </span><span class="currency_text">
                        <asp:Literal ID="currencyTextLabel" runat="server" Text='<%# Eval("CurrencyCd") %>'>
                        </asp:Literal>
                    </span><span class="plan_interval">
                        <asp:Literal ID="planIntervalLabel" runat="server" Text='<%# Eval("IntervalName") %>'>
                        </asp:Literal>
                    </span>
                </div>
            </ItemTemplate>
            <EmptyDataTemplate>
                <div>
                    No services found
                </div>
            </EmptyDataTemplate>
        </asp:ListView>
    </div>
    </form>
</body>
</html>
