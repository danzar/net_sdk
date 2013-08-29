<%@ page language="C#" autoeventwireup="true" inherits="ForgotPassword, App_Web_l13gvg31" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
  <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
	<title>Lost Password</title>
	<link id="Link1" rel="stylesheet" type="text/css" runat="server" href="~/App_Themes/main.css"/>
  <link id="Link2" rel="stylesheet" type="text/css" runat="server" href="~/App_Themes/layout.css"/>
</head>
<body>
    <div id="a_header" class="clearfix">&nbsp;</div>

	<div class="logo2"></div>

	<form id="newPassword" runat="server">

	<div id="content" class="signup">

		<div class="loginHead">
			<h1>Create a new password</h1>
		</div>

		<div id="loginBox">

			<div id="loginTitle" class="title">
				Create a new password
			</div>
      <div id="divLoginError" runat="server" class="errormsg" visible="false">
	      <asp:Literal ID="litErrors" runat="server" />
      </div>
			<div id="loginUserID">
				<span class='fieldLabel'>User ID</span>
				<input tabindex="1" class="text_field" type="text" name="userID" id="txtUserId" runat="server" maxlength="30" value="" />
        <asp:RequiredFieldValidator ID="rfvUserId" runat="server" ControlToValidate="txtUserId" Display="Dynamic" >*<BR /> required<BR />&nbsp;</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="revUserId" runat="server" ControlToValidate="txtUserId" Display="Dynamic" ValidationExpression="^[a-zA-Z0-9_@.-]{1,}$">*<br />Accepts only alphanumeric characters, and can include _-@.<br />&nbsp;</asp:RegularExpressionValidator>				
			</div>

			<div id="loginPwd">

				<span class='fieldLabel'>Secret Question</span>
              <select tabindex="2" id="ddlSecrectQuestion" runat="server" name="secret_question" class="fullwidth">
                <option value="">- Choose a question -</option>
                <option value="1" >What was the name of your first pet?</option>
                <option value="2" >What was the name of your childhood best friend?</option>
                <option value="3" >What was your childhood hero?</option>
                <option value="4" >What was the name of your elementary school?</option>
                <option value="5" >What was your high school mascot?</option>
              </select>
              <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddlSecrectQuestion" Display="Dynamic" >*<BR /> required<BR />&nbsp;</asp:RequiredFieldValidator>
			</div>

			<div id="loginPwd">
				<span class='fieldLabel'>Secret question answer</span>
        <input tabindex="3" id="txtSecretAnswer" runat="server" name="secret_answer"  type="text" class="fullwidth" value="" maxlength="30"/>
				<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtSecretAnswer" Display="Dynamic" >*<BR /> required<BR />&nbsp;</asp:RequiredFieldValidator>
			</div>

			<div id="loginPwd">
				<span class='fieldLabel'>New password</span>
				<input tabindex="4" class="text_field" type="password" name="newPassword" id="txtPassword" runat="server" maxlength="30" value=""/>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPassword" Display="Dynamic" >*<BR /> required<BR />&nbsp;</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtPassword" Display="Dynamic" ValidationExpression="^[a-zA-Z0-9+-_!^@#%&*()\.]{8,50}$">*<br />Accepts only 8-50 alphanumeric characters, and can include +-_!^@#%&*().<br />&nbsp;</asp:RegularExpressionValidator>
			</div>

			<div id="loginPwd">

				<span class='fieldLabel'>Re-enter new password</span>
				<input tabindex="5" class="text_field" type="password" name="newPassword2" id="txtPasswordConfirmation" runat="server" maxlength="30" value=""/>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPasswordConfirmation" Display="Dynamic" >*<BR /> required<BR />&nbsp;</asp:RequiredFieldValidator>
        <asp:CompareValidator ID="cmpPassword" runat="server" ControlToValidate="txtPasswordConfirmation" ControlToCompare="txtPassword" Display="Dynamic">* <br />passwords don't match<br />&nbsp;</asp:CompareValidator>
			</div>

			<div id="loginSubmit">
        <asp:Button tabindex="6" ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" CausesValidation="true" CssClass="button" Text="Submit" />
			</div>

		</div>
	</div>

	</form>

</div>
</body>
</html>
