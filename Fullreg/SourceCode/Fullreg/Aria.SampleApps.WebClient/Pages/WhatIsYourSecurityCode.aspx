<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WhatIsYourSecurityCode.aspx.cs"
    Inherits="ARIA.Pages.WhatIsYourSecurityCode" %>

<html xmlns="http://www.w3.org/1999/xhtml" xml:lang="en" lang="en" dir="ltr">
<head>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8">
    <title></title>
</head>
<body>
    <p align="center">
        <br>
        <asp:Label ID="whereiscvvLabel" runat="server"></asp:Label>
        <br>
        <br>
        <asp:Label ID="whatiscvvLabel" runat="server"></asp:Label>
        <br>
        <br>
        <table cellpadding="2" cellspacing="2">
            <tr>
                <td>
                    <img src="../App_Themes/Default/images/cc_visa.jpg" border="0">
                </td>
                <td>
                    <img src="../App_Themes/Default/images/cc_amex.jpg" border="0">
                </td>
                <td>
                    <img src="../App_Themes/Default/images/cc_discover.jpg" border="0">
                </td>
            </tr>
        </table>
    </p>
</body>
</html>
