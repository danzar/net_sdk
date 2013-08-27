using System;
using System.Web.UI;

public partial class StateProvinceControl : UserControl
{
  public string ValidationGroup
  {
    get
    {
      return rfvLocality.ValidationGroup;
    }
    set
    {
      rfvLocality.ValidationGroup = value;
    }
  }

  public string GetCurrentState()
  {
    string state;
    if(ddlUSStates.Visible)
    {
      state = ddlUSStates.SelectedValue;
    }
    else if(ddlCAStates.Visible)
    {
      state = ddlCAStates.SelectedValue;
    }
    else
    {

      state = txtLocality.Value;
    }
    return state;
  }

  public short TabIndex
  {
    set
    {
      ddlUSStates.TabIndex = value;
      ddlCAStates.TabIndex = value;
      txtLocality.Attributes["tabindex"] = value.ToString();
    }
  }

  protected void Page_Load(object sender,
                           EventArgs e)
  {
  }

  public string ShowStates(string selectedCountry,
                         string state)
  {
    string labelTitle;
    switch (selectedCountry)
    {
      case "US":
        ddlUSStates.Visible = true;
        ddlCAStates.Visible = false;
        txtLocality.Visible = false;
        rfvLocality.Enabled = false;
        if (!string.IsNullOrEmpty(state))
        {
          ddlUSStates.SelectedValue = state;
        }
        labelTitle = "State";
        break;
      case "CA":
        ddlUSStates.Visible = false;
        ddlCAStates.Visible = true;
        txtLocality.Visible = false;
        rfvLocality.Enabled = false;
        if (!string.IsNullOrEmpty(state))
        {
          ddlCAStates.SelectedValue = state;
        }
        labelTitle = "Province";
        break;
      default:
        ddlUSStates.Visible = false;
        ddlCAStates.Visible = false;
        if ((txtLocality.Visible) &&
            (!string.IsNullOrEmpty(state)))
        {
          txtLocality.Value = state;
          
        }
        txtLocality.Visible = true;
        rfvLocality.Enabled = true;
        labelTitle = "Locality";
        break;
    }

    return labelTitle;
  }
}