<%@ Control Language="C#" AutoEventWireup="true" CodeFile="LoginNavigationControl.ascx.cs" Inherits="LoginNavigationControl" %>

  <div id="stepBar">
    <div class="roundedcornr_box_151200">
      <div class="roundedcornr_top_151200"><div></div></div>
      <div class="roundedcornr_content_151200">
<table width="100%" class="stepTable" cellpadding="0" cellspacing="0">
  <tr>
    <th>1</th>
    <td>Account Information <span id="spEditAccount" runat="server" visible="false" class="subtext stepEdit">(<a href="AddAccountInfo.aspx">Edit </a>)</span></td>

   
    <td>
        <img id="imgAccountInformation" runat="server" src="App_Themes/images/noaccept.png" alt="" width="16" height="16" />
    </td>
  </tr>
  <tr>
    <th>2</th>
    <td>Plan Information <span id="spPlanInformation" runat="server" visible="false" class="subtext stepEdit">(<a href="AddAccountPlanInfo.aspx">Edit </a>)</span></td>
    
    <td>
        <img id="imgPlanInformation" runat="server" src="App_Themes/images/noaccept.png" alt="" width="16" height="16" />
    </td>

  </tr>
  <tr>
   <th>3</th>
    <td>Payment Information <span id="spPaymentInformation" runat="server" visible="false" class="subtext stepEdit">(<a href="AddAccountPaymentInformation.aspx">Edit </a>)</span></td>
   
    <td>
        <img id="imgPaymentInformation" runat="server" src="App_Themes/images/noaccept.png" alt="" width="16" height="16" />
    </td>
  </tr>

  <tr>
    <th>4</th>
    <td>Preview</td>
    
    <td>
        <img id="imgPreview" runat="server" src="App_Themes/images/noaccept.png" alt="" width="16" height="16" />
    </td>
  </tr>
  <tr>
  <th style="border-bottom:none">5</th>

    <td style="border-bottom:none">Confirmation</td>
    <td>
        <img id="imgConfirmation" runat="server" src="App_Themes/images/noaccept.png" alt="" width="16" height="16" />
    </td>
  </tr>
</table>
      </div>
      <div class="roundedcornr_bottom_151200"><div></div></div>
  </div>
  </div>