
using System;
using NUnit.Framework;
using System.Configuration;
using Aria.SDK.AriaServices.AriaWebServices;
using Aria.SDK.AriaServices.AriaWebServices.AriaObjectQuery;

namespace Aria.SDK.AriaServices.AriaRestServices.Test
{
  [TestFixture]
  public class AriaObjectQueryTest
  {
    private const string ARIA_CLIENT_NUMBER = "aria-client-number";
    private const string ARIA_AUTHORIZATION_KEY = "aria-authorization-key";
    private const string ARIA_DISPATCHER_URL = "aria-object-query-dispatcher-url";
    private const string VALID_ACCOUNT_NUMBER = "valid-account-number";
    private const string VALID_ACCOUNT_USERID = "valid-account-userid";
    private const string VALID_ACCOUNT_PASSWORD = "valid-account-password";
    private const string VALID_PLAN_NUMBER = "valid-plan-number";
    private const string VALID_PLAN_SERVICE_NUMBER = "valid-plan-service-number";
    private const string VALID_SUPPLEMENTAL_PLAN_NUMBER = "valid-supplemental-plan-number";
    private const string VALID_PROMO_CODE = "valid-promo-code";
    private const string VALID_SUPPLEMENTAL_FIELD_NAME = "valid-supplemental-field-name";
    public static AriaBillingObjectQuery mService;

    [TestFixtureSetUp]
    public void setUp()
    {
        //mService = new AriaBillingObjectQuery(ConfigurationManager.AppSettings[ARIA_DISPATCHER_URL]);
        mService = new AriaBillingObjectQuery();
    }

    public long AccountNumber
    {
      get
      {
        return long.Parse(ConfigurationManager.AppSettings[VALID_ACCOUNT_NUMBER]);
      }
    }

    public long ClientNumber
    {
      get
      {
        return long.Parse(ConfigurationManager.AppSettings[ARIA_CLIENT_NUMBER]);
      }
    }

    public int ServiceNumber
    {
      get
      {
        return int.Parse(ConfigurationManager.AppSettings[VALID_PLAN_SERVICE_NUMBER]);
      }
    }

    public int PlanNumber
    {
      get
      {
        return int.Parse(ConfigurationManager.AppSettings[VALID_PLAN_NUMBER]);
      }
    }

    public string AuthorizationKey
    {
      get
      {
        return ConfigurationManager.AppSettings[ARIA_AUTHORIZATION_KEY];
      }
    }

    public string UserId
    {
      get
      {
        return ConfigurationManager.AppSettings[VALID_ACCOUNT_USERID];
      }
    }

    public string Password
    {
      get
      {
        return ConfigurationManager.AppSettings[VALID_ACCOUNT_PASSWORD];
      }
    }

    public long SupplementalPlanNumber
    {
      get
      {
        return long.Parse(ConfigurationManager.AppSettings[VALID_SUPPLEMENTAL_PLAN_NUMBER]);
      }
    }

    public string PromoCode
    {
      get
      {
        return ConfigurationManager.AppSettings[VALID_PROMO_CODE];
      }
    }

    public string SupplementalFieldName
    {
      get
      {
        return ConfigurationManager.AppSettings[VALID_SUPPLEMENTAL_FIELD_NAME];
      }
    }

    #region Api Calls TEST
    [Test]
    public void get_account_details()
    {
       get_account_detailsRequest request = new get_account_detailsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            query_string = "",
            limit = 1,
            offset = 1
            };

        var response = mService.get_account_details(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_account_status_history()
    {
       get_account_status_historyRequest request = new get_account_status_historyRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            query_string = "",
            limit = 1,
            offset = 1
            };

        var response = mService.get_account_status_history(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_account_plan_history()
    {
       get_account_plan_historyRequest request = new get_account_plan_historyRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            query_string = "",
            limit = 1,
            offset = 1
            };

        var response = mService.get_account_plan_history(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_payment_details()
    {
       get_payment_detailsRequest request = new get_payment_detailsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            query_string = "",
            limit = 1,
            offset = 1
            };

        var response = mService.get_payment_details(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_order_details()
    {
       get_order_detailsRequest request = new get_order_detailsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            query_string = "",
            limit = 1,
            offset = 1
            };

        var response = mService.get_order_details(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_invoice_information()
    {
       get_invoice_informationRequest request = new get_invoice_informationRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            query_string = "",
            limit = 1,
            offset = 1
            };

        var response = mService.get_invoice_information(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_transaction_information()
    {
       get_transaction_informationRequest request = new get_transaction_informationRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            query_string = "",
            limit = 1,
            offset = 1
            };

        var response = mService.get_transaction_information(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_refund_information()
    {
       get_refund_informationRequest request = new get_refund_informationRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            query_string = "",
            limit = 1,
            offset = 1
            };

        var response = mService.get_refund_information(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_coupon_history()
    {
       get_coupon_historyRequest request = new get_coupon_historyRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            query_string = "",
            limit = 1,
            offset = 1
            };

        var response = mService.get_coupon_history(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void list_transaction_types()
    {
       list_transaction_typesRequest request = new list_transaction_typesRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            limit = 1,
            offset = 1,
            query_string = ""
            };

        var response = mService.list_transaction_types(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void list_payment_methods()
    {
       list_payment_methodsRequest request = new list_payment_methodsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            limit = 1,
            offset = 1,
            query_string = ""
            };

        var response = mService.list_payment_methods(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void list_payment_processors()
    {
       list_payment_processorsRequest request = new list_payment_processorsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            limit = 1,
            offset = 1,
            query_string = ""
            };

        var response = mService.list_payment_processors(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_all_invoice_information()
    {
       get_all_invoice_informationRequest request = new get_all_invoice_informationRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            query_string = "",
            limit = 1,
            offset = 1
            };

        var response = mService.get_all_invoice_information(request);
        Assert.IsNotNull(response);
    }

        #endregion Api Calls TEST
    }
}
