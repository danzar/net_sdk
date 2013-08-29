<%@ page language="C#" autoeventwireup="true" inherits="Aria.Login, App_Web_l13gvg31" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
  <title>Login</title>
  <link id="Link1" rel="stylesheet" type="text/css" runat="server" href="~/App_Themes/main.css"/>
  <link id="Link2" rel="stylesheet" type="text/css" runat="server" href="~/App_Themes/layout.css"/>
</head>
<body>
  <div id="a_header" class="clearfix">&nbsp;</div>
  <div class="logo2"></div>
  <div id="content" class="signup">
    <div class="pg_title">
    </div>

    <div class="loginHead"><h1>Sign In to Your Account</h1></div>
    <div id="loginBox">
      <form id="loginForm" runat="server">
        <div id="loginTitle" class="title">
	        Sign into your  Account
        </div>
        <div id="divLoginError" runat="server" class="errormsg" visible="false">
	        <asp:Literal ID="litErrors" runat="server" />
        </div>
        <div id="loginUserID">
	        <span class="fieldLabel">User ID</span> &nbsp;
	          <asp:RequiredFieldValidator ID="rfvUserid" runat="server" 
                                  ControlToValidate="txtUserId"
                                  Display="Dynamic" 
                                  CssClass="errormsg"
                                  ErrorMessage="required"
                                  ValidationGroup="LOGIN" SetFocusOnError="true"/><br />
	        <input id="txtUserId" runat="server" type="text" class="text_field" />
        </div>
        <div id="loginPwd">
	        <span class="fieldLabel">Password</span>  &nbsp;
	        <asp:RequiredFieldValidator ID="rfvPassword" runat="server" 
                                  ControlToValidate="txtPassword"
                                  Display="Dynamic" 
                                  CssClass="errormsg"
                                  ErrorMessage="required"
                                  ValidationGroup="LOGIN" SetFocusOnError="true" /><br />
	        <input id="txtPassword" runat="server" type="password" class="text_field" /> 
        </div>

        <div id="loginRemember">
	        <input type="checkbox" name="remember" id="chkRememberMe" runat="server" /> 
	        Remember me on this computer
        </div>
        <div id="loginSubmit">
          <asp:Button ID="btnLogin" runat="server" OnClick="btnLogin_Click" ValidationGroup="LOGIN" CausesValidation="true" CssClass="button" Text="Sign In" />
	        <span id="pls_wait" style="margin-left: 5px; display: none;"><img src='<%= ResolveUrl("~/_includes/images/wait_icon2.gif") %>' alt="" /></span>
        </div><dd></dd>
        <div id="loginHelp">Did you forget your  <a href='<%= ResolveUrl("~/ForgotPassword.aspx") %>'>Password</a>?</div>
      </form>
    </div>
    <div class="donot">
    Don't have an account? <br />
    <a href='<%= ResolveUrl("~/AddAccountInfo.aspx") %>'>Sign up now</a>
    </div>		
  </div>
</body>
</html>
