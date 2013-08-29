<%@ control language="C#" autoeventwireup="true" inherits="StateProvinceControl, App_Web_l13gvg31" %>

  <asp:DropDownList ID="ddlUSStates" runat="server" CssClass="fullwidth">
    <asp:ListItem Value="AL" Text="Alabama"/>
    <asp:ListItem Value="AK" Text="Alaska"/>
    <asp:ListItem Value="AZ" Text="Arizona"/>
    <asp:ListItem Value="AR" Text="Arkansas"/>
    <asp:ListItem Value="CA" Text="California"/>
    <asp:ListItem Value="CO" Text="Colorado"/>
    <asp:ListItem Value="CT" Text="Connecticut"/>
    <asp:ListItem Value="DE" Text="Delaware"/>
    <asp:ListItem Value="DC" Text="District of Columbia"/>
    <asp:ListItem Value="FL" Text="Florida"/>
    <asp:ListItem Value="GA" Text="Georgia"/>
    <asp:ListItem Value="HI" Text="Hawaii"/>
    <asp:ListItem Value="ID" Text="Idaho"/>
    <asp:ListItem Value="IL" Text="Illinois"/>
    <asp:ListItem Value="IN" Text="Indiana"/>
    <asp:ListItem Value="IA" Text="Iowa"/>
    <asp:ListItem Value="KS" Text="Kansas"/>
    <asp:ListItem Value="KY" Text="Kentucky"/>
    <asp:ListItem Value="LA" Text="Louisiana"/>
    <asp:ListItem Value="ME" Text="Maine"/>
    <asp:ListItem Value="MD" Text="Maryland"/>
    <asp:ListItem Value="MA" Text="Massachusetts"/>
    <asp:ListItem Value="MI" Text="Michigan"/>
    <asp:ListItem Value="MN" Text="Minnesota"/>
    <asp:ListItem Value="MS" Text="Mississippi"/>
    <asp:ListItem Value="MO" Text="Missouri"/>
    <asp:ListItem Value="MT" Text="Montana"/>
    <asp:ListItem Value="NE" Text="Nebraska"/>
    <asp:ListItem Value="NV" Text="Nevada"/>
    <asp:ListItem Value="NH" Text="New Hampshire"/>
    <asp:ListItem Value="NJ" Text="New Jersey"/>
    <asp:ListItem Value="NM" Text="New Mexico"/>
    <asp:ListItem Value="NY" Text="New York"/>
    <asp:ListItem Value="NC" Text="North Carolina"/>
    <asp:ListItem Value="ND" Text="North Dakota"/>
    <asp:ListItem Value="OH" Text="Ohio"/>
    <asp:ListItem Value="OK" Text="Oklahoma"/>
    <asp:ListItem Value="OR" Text="Oregon"/>
    <asp:ListItem Value="PA" Text="Pennsylvania"/>
    <asp:ListItem Value="RI" Text="Rhode Island"/>
    <asp:ListItem Value="SC" Text="South Carolina"/>
    <asp:ListItem Value="SD" Text="South Dakota"/>
    <asp:ListItem Value="TN" Text="Tennessee"/>
    <asp:ListItem Value="TX" Text="Texas"/>
    <asp:ListItem Value="UT" Text="Utah"/>
    <asp:ListItem Value="VA" Text="Virginia"/>
    <asp:ListItem Value="WA" Text="Washington"/>
    <asp:ListItem Value="WV" Text="West Virginia"/>
    <asp:ListItem Value="WI" Text="Wisconsin"/>
    <asp:ListItem Value="WY" Text="Wyoming"/>
    <asp:ListItem Value="VT" Text="Vermont"/>
  </asp:DropDownList>
  <asp:DropDownList ID="ddlCAStates" runat="server" CssClass="fullwidth">
    <asp:ListItem Value="QC" Text="Quebec"/>
    <asp:ListItem Value="AB" Text="Alberta"/>
    <asp:ListItem Value="ON" Text="Ontario"/>
    <asp:ListItem Value="MB" Text="Manitoba"/>
    <asp:ListItem Value="NS" Text="Nova Scotia"/>
    <asp:ListItem Value="SK" Text="Saskatchewan"/>
    <asp:ListItem Value="NF" Text="Newfoundland and Labrador"/>
    <asp:ListItem Value="NB" Text="New Brunswick"/>
    <asp:ListItem Value="BC" Text="British Columbia"/>
    <asp:ListItem Value="PE" Text="Prince Edward Island"/>
    <asp:ListItem Value="NT" Text="Northwest Territories"/>
  </asp:DropDownList>
  <input id="txtLocality" runat="server" type="text" name="state" class="fullwidth" />
  <asp:RequiredFieldValidator ID="rfvLocality" runat="server"
                    ControlToValidate="txtLocality"
                    Display="Dynamic"
                    ErrorMessage="required"
                    ValidationGroup="EDIT_ACCOUNT" SetFocusOnError="true"/>