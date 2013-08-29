<%@ page language="C#" autoeventwireup="true" inherits="AddAccountReview, App_Web_or1ni4yr" %>
<%@ Register TagPrefix="uc" TagName="LoginNavigation" Src="~/LoginNavigationControl.ascx" %>
<%@ Import Namespace="Aria"%>

<html>
<head>
<meta http-equiv="Content-Type" content="text/html; charset=utf-8">
<title>Confirm and enter your Payment Information</title>

<link type="text/css" href="App_Themes/main.css" rel="stylesheet"/>
<link type="text/css" href="App_Themes/layout.css" rel="stylesheet"/>

</head>
<body>
<div id="a_header" class="clearfix">
  <div class="right"> <a href="Login.aspx">Sign in&nbsp;</a></div>

</div>
<div class="logo2">
<img width="93" height="50" src="App_Themes/images/aria_logo.gif"/>
</div>
<div id="content" class="signup">
  <div class="pg_title">
    <h1>Preview Information</h1>
  </div>

  <div style="width: 1024px">
  <uc:LoginNavigation ID="lgnNav" runat="server" />
  <div class="pg_box">

    <div class="box_top"> </div>
    <div class="box_content">
      <div class="PgTwoColumn_Container clearfix">
        <div class="PgTwoColumn_Content">
          <form id="previewForm" runat="server">
            <div class="Section_Header">
              <h2> Account Information <span class="subtext help">(<a href="AddAccountInfo.aspx">Edit</a> )</span> </h2>

            </div>
            <table cellspadding="0" cellspacing="0" border="0" class="review_subscription">
              <tr>
                <td width="35%"><strong>First Name</strong></td>
                <td><%=SessionSupport.NewAccount.first_name %></td>
              </tr>
              <tr>
                <td width="35%"><strong>Last Name</strong></td>

                <td><%=SessionSupport.NewAccount.last_name %></td>
              </tr>
              <tr>
                <td width="35%"><strong>User ID</strong></td>
                <td><%=SessionSupport.NewAccount.userid %></td>
              </tr>
            </table>

            <div class="Section_Header">
              <h2> Address Information <span class="subtext help">(<a href="AddAccountInfo.aspx">Edit </a>)</span> </h2>
            </div>
            <table cellspadding="0" cellspacing="0" border="0" class="review_subscription">
              <tr>
                <td width="35%"><strong>Street address</strong></td>

                <td><%=SessionSupport.NewAccount.address1 + ' ' + SessionSupport.NewAccount.address2 %></td>
              </tr>
              <tr>
                <td width="35%"><strong>City/Town</strong></td>
                <td><%=SessionSupport.NewAccount.city %></td>
              </tr>
              <tr>

                <td width="35%"><strong>Country </strong></td>
                <td><%=SessionSupport.NewAccount.country %></td>
              </tr>
              <tr>
                <td width="35%"><strong>State</strong></td>
                <td><%=SessionSupport.NewAccount.state_prov %></td>
              </tr>

              <tr>
                <td width="35%"><strong>Zip Code </strong></td>
                <td><%=SessionSupport.NewAccount.postal_cd %></td>
              </tr>
            </table>
            <div class="Section_Header">
              <h2> Contact Information <span class="subtext help">(<a href="AddAccountInfo.aspx">Edit </a>)</span> </h2>

            </div>
            <table cellspadding="0" cellspacing="0" border="0" class="review_subscription">
              <tr>
                <td width="35%"><strong>Phone Number</strong></td>
                <td><%=SessionSupport.NewAccount.phone %></td>
              </tr>
              <tr>
                <td width="35%"><strong>E-mail Address</strong></td>

                <td><%=SessionSupport.NewAccount.email %></td>
              </tr>
            </table>
            
            <div class="Section_Content">
              <div class="Section_Header">
                <h2> Plan Information <span class="subtext help">(<a href="AddAccountPlanInfo.aspx">Edit </a>)</span> </h2>

              </div>
              <div class="Section_Content">
                <table cellspadding="0" cellspacing="0" border="0" class="review_subscription">
              
              <tr>
                <td width="35%"><strong>Plan Name</strong></td>

                <td><%=SessionSupport.NewAccountPlan.plan_name%></td>
              </tr>
            </table>
                <div class="Section_Header">
              <h2>Default Payment Method <span class="subtext help">(<a href="AddAccountPaymentInformation.aspx">Edit </a>)</span> </h2>
            </div>
            
            
            <table cellspadding="0" cellspacing="0" border="0" class="review_subscription">
                <tr>
                <td width="35%"><strong>Payment Option</strong></td>
                <td><asp:Literal ID="litPaymentMethod" runat="server" /></td>
              </tr>
           </table>
           <div id="divCreditCardInfo" runat="server" Visible="false">
           <table cellspadding="0" cellspacing="0" border="0" class="review_subscription">
              
              <tr>
                <td width="35%"><strong>Card Number</strong></td>
                <td><%=SessionSupport.NewAccount.cc_number %></td>
              </tr>
              <tr>
                <td width="35%"><strong>Expiration Date</strong></td>

                <td> <%=SessionSupport.NewAccount.cc_expire_mm + "," + SessionSupport.NewAccount.cc_expire_yyyy %></td>
              </tr>
              <tr>
                <td width="35%"><strong>Card Name</strong></td>
                <td> <%=SessionSupport.NewAccount.bill_first_name + " " + SessionSupport.NewAccount.bill_last_name %></td>
              </tr>

              <tr>
                <td width="35%"><strong>Street address</strong></td>
                <td><%=SessionSupport.NewAccount.bill_address1 + " " + SessionSupport.NewAccount.bill_address2 %></td>
              </tr>
              <tr>
                <td width="35%"><strong>City/Town</strong></td>
                <td><%=SessionSupport.NewAccount.bill_city %></td>

              </tr>
              <tr>
                <td width="35%"><strong>Country </strong></td>
                <td><%=SessionSupport.NewAccount.bill_country %></td>
              </tr>
              <tr>
                <td width="35%"><strong>State</strong></td>

                <td><%=SessionSupport.NewAccount.bill_state_prov %></td>
              </tr>
              <tr>
                <td width="35%"><strong>Zip Code </strong></td>
                <td><%=SessionSupport.NewAccount.bill_postal_cd %></td>
              </tr>
            </table>
            </div>
            <div id= "divACHInfo" runat="server" Visible="false">
              <table cellspadding="0" cellspacing="0" border="0" class="review_subscription">
              <tr>
                    <td width="35%"><strong>Routing Number</strong></td>
                    <td><%=SessionSupport.NewAccount.bank_routing_no %></td>
                </tr>
                <tr>
                    <td width="35%"><strong>Account Number</strong></td>
                    <td><%=SessionSupport.NewAccount.bank_acct_no %></td>
                </tr>
              
              </table>
            </div>
            
            </div>
            </div>
            <fieldset>
                  <dl>
                    <dt></dt>
                    <dd>
                      <input id="btnSave" runat="server" style="float: right;" type="submit" class="btn_prefer" value="Submit"
												OnServerClick="btnSave_ServerClick" />
                      <input id="btnCancel" runat="server" style="float: right;" type="button" class="btn_prefer" value="Cancel"
												OnServerClick="btnCancel_ServerClick" />
                    </dd>

                  </dl>
                </fieldset>
          </form>
        </div>
      </div>
    </div>
    <div class="box_bottom"> </div>
  </div>

  </div>
</div>
<div id="a_footer"> &copy; 2010 Aria Systems Inc. All rights reserved.</div>

</body>
</html>

