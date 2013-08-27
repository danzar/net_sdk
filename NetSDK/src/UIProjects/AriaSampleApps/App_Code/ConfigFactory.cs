using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace Aria
{
  /// <summary>
  /// This Class is intended to read values from the config files app settings section.
  /// </summary>
  public static class ConfigFactory
  {
    #region Attributes

    private const string ARIA_CLIENT_NUMBER = "aria-client-number";
    private const string ARIA_AUTHORIZATION_KEY = "aria-authorization-key";
    
    #endregion

    #region Methods

    ///------------------------------------------------------------------
    /// <summary>
    /// Gets the Aria Authorization key
    /// </summary>
    /// 
    /// <returns>The value of the aria-authorization-key from the config file.</returns>
    /// <remarks></remarks>
    ///------------------------------------------------------------------
    public static string GetAriaAuthorizationKey()
    {
      if (string.IsNullOrEmpty(ConfigurationManager.AppSettings[ARIA_AUTHORIZATION_KEY]))
      {
        throw new NotSupportedException("You must set the aria-authorization-key config value in order to use this application.");
      }

      return ConfigurationManager.AppSettings[ARIA_AUTHORIZATION_KEY];
    }

    ///------------------------------------------------------------------
    /// <summary>
    /// Gets the Aria client number
    /// </summary>
    /// 
    /// <returns>The value of the aria-client-number from the config file.</returns>
    /// <remarks></remarks>
    ///------------------------------------------------------------------
    public static long GetAriaClientNumber()
    {
      long length;

      if(!long.TryParse(ConfigurationManager.AppSettings[ARIA_CLIENT_NUMBER],
                    out length))
      {
        throw new NotSupportedException("You must set the aria-client-number config value in order to use this application.");
      }

      return length;
    }

    #endregion
  }
}