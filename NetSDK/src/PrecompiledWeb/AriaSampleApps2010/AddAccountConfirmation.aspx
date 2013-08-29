<%@ page language="C#" autoeventwireup="true" inherits="AddAccountConfirmation, App_Web_l13gvg31" %>
<%@ Import Namespace="Aria" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
<link type="text/css" href="App_Themes/main.css" rel="stylesheet"/>
<link type="text/css" href="App_Themes/layout.css" rel="stylesheet"/>

<style> 
.signup .pg_box {
float:left;
margin:10px auto 10px 110px;
width:780px;
}
	</style>
</head>
	

<body>
<div id="a_header" class="clearfix">	
    
  <div class="right"> <a href="Login.aspx">Sign in&nbsp;</a></div><br /><br />
</div>

	<div class="logo2">
<img width="93" height="50" src="App_Themes/images/aria_logo.gif"/>
</div>
<div id="content" class="signup">
	<div class="pg_title">
		<div class="subtext help" style="float:right;">
			<a href="javascript:window.print();">Print this page</a>

		</div>
		<h1 style="margin-right: 4em;">Congratulations <%=NewAccount.first_name + " " + NewAccount.last_name %>!</h1>
	</div>
	
	<div class="pg_box">
		<div class="box_top"> </div>
		<div class="box_content">
			 <p><font color="red">
         <ul>
            <asp:Repeater ID="rptErrors" runat="server">
              <ItemTemplate>
                <li><%#Container.DataItem %></li>
              </ItemTemplate>
            </asp:Repeater>
         </ul>

                 
                 
             
      </font> </p>
				
		  <div align="right">
		    <p><a href="Login.aspx">Sign in &raquo;</a></p></div>

			<div class="Section_Container SubscriptionReceipt_Container">
				
				<div class="SubscriptionReceipt_Header">
					
					<h2>Receipt</h2>
				</div>

				<div class="SubscriptionReceipt_Content clearfix">			
					
						<div class="Section_Container">	
							<div class="Section_Header">
              <h2> Account Information  </h2>

            </div>
            <table cellspadding="0" cellspacing="0" border="0" class="review_subscription">
              <tr>
                <td width="35%"><strong>First Name</strong></td>
                <td><%=NewAccount.first_name %></td>
              </tr>
              <tr>
                <td width="35%"><strong>Last Name</strong></td>

                <td><%=NewAccount.last_name %></td>
              </tr>
              <tr>
                <td width="35%"><strong>User ID</strong></td>
                <td><%=NewAccount.userid %></td>
              </tr>
            </table>

            <div class="Section_Header">
              <h2> Address Information  </h2>
            </div>
            <table cellspadding="0" cellspacing="0" border="0" class="review_subscription">
              <tr>
                <td width="35%"><strong>Street address</strong></td>

                <td><%=NewAccount.address1 + ' ' + NewAccount.address2 %></td>
              </tr>
              <tr>
                <td width="35%"><strong>City/Town</strong></td>
                <td><%=NewAccount.city %></td>
              </tr>
              <tr>

                <td width="35%"><strong>Country </strong></td>
                <td><%=NewAccount.country %></td>
              </tr>
              <tr>
                <td width="35%"><strong>State</strong></td>
                <td><%=NewAccount.state_prov %></td>
              </tr>

              <tr>
                <td width="35%"><strong>Zip Code </strong></td>
                <td><%=NewAccount.postal_cd %></td>
              </tr>
            </table>
             <div class="Section_Header">
              <h2> Plan Information  </h2>
            </div>

             <table cellspadding="0" cellspacing="0" border="0" class="review_subscription">
              
              <tr>
                <td width="35%"><strong>Plan Name</strong></td>
                <td><%=NewAccountPlan.plan_name%></td>
              </tr>
            </table> 
              </div>
			 </div></div>
		      
	</div>	
<div class="box_bottom"> </div>
</div>

<div id="a_footer"> &copy; 2010 Aria Inc. All rights reserved.</div>
</body>
</html>