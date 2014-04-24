
using System;
using NUnit.Framework;
using System.Configuration;
using Aria.SDK.AriaServices.AriaWebServices;
using Aria.SDK.AriaServices.AriaWebServices.AriaComplete;

namespace Aria.SDK.AriaServices.AriaRestServices.Test
{
  public class AriaCompleteTest
  {
    private const string ARIA_CLIENT_NUMBER = "aria-client-number";
    private const string ARIA_AUTHORIZATION_KEY = "aria-authorization-key";
    private const string ARIA_DISPATCHER_URL = "aria-dispatcher-url";
    private const string VALID_ACCOUNT_NUMBER = "valid-account-number";
    private const string VALID_ACCOUNT_USERID = "valid-account-userid";
    private const string VALID_ACCOUNT_PASSWORD = "valid-account-password";
    private const string VALID_PLAN_NUMBER = "valid-plan-number";
    private const string VALID_PLAN_SERVICE_NUMBER = "valid-plan-service-number";
    private const string VALID_SUPPLEMENTAL_PLAN_NUMBER = "valid-supplemental-plan-number";
    private const string VALID_PROMO_CODE = "valid-promo-code";
    private const string VALID_SUPPLEMENTAL_FIELD_NAME = "valid-supplemental-field-name";
    public static AriaBillingComplete mService;

    [TestFixtureSetUp]
    public void setUp()
    {
        mService = new AriaBillingComplete(ConfigurationManager.AppSettings[ARIA_DISPATCHER_URL]);
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

    public long ServiceNumber
    {
      get
      {
        return long.Parse(ConfigurationManager.AppSettings[VALID_PLAN_SERVICE_NUMBER]);
      }
    }

    public long PlanNumber
    {
      get
      {
        return long.Parse(ConfigurationManager.AppSettings[VALID_PLAN_NUMBER]);
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
    public void get_client_plans_all()
    {
       get_client_plans_allRequest request = new get_client_plans_allRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            plan_no = PlanNumber,
            acct_no = 1,
            promo_code = PromoCode,
            parent_plan_no = 1,
            supp_field_names = new[]{new supp_field_names_row()},
            supp_field_values = new[]{new supp_field_values_row()},
            include_all_rate_schedules = "",
            include_plan_hierarchy = ""
            };

        var response = mService.get_client_plans_all(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void set_prov_engine()
    {
       set_prov_engineRequest request = new set_prov_engineRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            on_off_indicator = ""
            };

        var response = mService.set_prov_engine(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_auf_status()
    {
       get_auf_statusRequest request = new get_auf_statusRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            file_name = ""
            };

        var response = mService.get_auf_status(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_country_from_ip()
    {
       get_country_from_ipRequest request = new get_country_from_ipRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            ip_address = ""
            };

        var response = mService.get_country_from_ip(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_client_items()
    {
       get_client_itemsRequest request = new get_client_itemsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            filter_currency_cd = "",
            return_no_cost_items = "",
            filter_item_no = 1
            };

        var response = mService.get_client_items(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_client_items_all()
    {
       get_client_items_allRequest request = new get_client_items_allRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            filter_currency_cd = "",
            return_no_cost_items = "",
            filter_item_no = 1,
            include_inactive_items = ""
            };

        var response = mService.get_client_items_all(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_client_item_prices()
    {
       get_client_item_pricesRequest request = new get_client_item_pricesRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            filter_item_no = 1,
            filter_currency_cd = "",
            return_no_cost_items = ""
            };

        var response = mService.get_client_item_prices(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_client_item_supp_fields()
    {
       get_client_item_supp_fieldsRequest request = new get_client_item_supp_fieldsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            filter_item_no = 1
            };

        var response = mService.get_client_item_supp_fields(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_client_item_classes()
    {
       get_client_item_classesRequest request = new get_client_item_classesRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            filter_item_no = 1
            };

        var response = mService.get_client_item_classes(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_web_replacement_vals()
    {
       get_web_replacement_valsRequest request = new get_web_replacement_valsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            web_vals_in = new[]{new web_vals_in_row()}
            };

        var response = mService.get_web_replacement_vals(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_client_plans_basic()
    {
       get_client_plans_basicRequest request = new get_client_plans_basicRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            plan_no = PlanNumber
            };

        var response = mService.get_client_plans_basic(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_client_plan_services()
    {
       get_client_plan_servicesRequest request = new get_client_plan_servicesRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            plan_no = PlanNumber
            };

        var response = mService.get_client_plan_services(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_client_plan_service_rates()
    {
       get_client_plan_service_ratesRequest request = new get_client_plan_service_ratesRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            plan_no = PlanNumber,
            service_no = ServiceNumber,
            alt_rate_schedule_no = 1
            };

        var response = mService.get_client_plan_service_rates(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_client_countries()
    {
       get_client_countriesRequest request = new get_client_countriesRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey
            };

        var response = mService.get_client_countries(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void subscribe_event_class()
    {
       subscribe_event_classRequest request = new subscribe_event_classRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            class_no = 1,
            do_write = ""
            };

        var response = mService.subscribe_event_class(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void unsubscribe_event_class()
    {
       unsubscribe_event_classRequest request = new unsubscribe_event_classRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            class_no = 1,
            do_write = ""
            };

        var response = mService.unsubscribe_event_class(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void subscribe_event()
    {
       subscribe_eventRequest request = new subscribe_eventRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            event_id = 1
            };

        var response = mService.subscribe_event(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void unsubscribe_event()
    {
       unsubscribe_eventRequest request = new unsubscribe_eventRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            event_id = 1
            };

        var response = mService.unsubscribe_event(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void subscribe_events()
    {
       subscribe_eventsRequest request = new subscribe_eventsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            event_list = new[]{new event_list_row()}
            };

        var response = mService.subscribe_events(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void unsubscribe_events()
    {
       unsubscribe_eventsRequest request = new unsubscribe_eventsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            event_list = new[]{new event_list_row()}
            };

        var response = mService.unsubscribe_events(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void client_has_event_class()
    {
       client_has_event_classRequest request = new client_has_event_classRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            class_no = 1
            };

        var response = mService.client_has_event_class(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void gen_random_string()
    {
       gen_random_stringRequest request = new gen_random_stringRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            rand_type = "",
            rand_length = 1,
            rand_case = ""
            };

        var response = mService.gen_random_string(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_rate_schedules_for_plan()
    {
       get_rate_schedules_for_planRequest request = new get_rate_schedules_for_planRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            plan_no = PlanNumber,
            currency_cd = ""
            };

        var response = mService.get_rate_schedules_for_plan(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_current_system_version()
    {
       get_current_system_versionRequest request = new get_current_system_versionRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey
            };

        var response = mService.get_current_system_version(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_all_client_receipt_ids()
    {
       get_all_client_receipt_idsRequest request = new get_all_client_receipt_idsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            start_date_range = DateTime.Now.AddMonths(-1).ToShortDateString(),
            end_date_range = ""
            };

        var response = mService.get_all_client_receipt_ids(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_client_items_basic()
    {
       get_client_items_basicRequest request = new get_client_items_basicRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            filter_currency_cd = "",
            return_no_cost_items = "",
            filter_item_no = 1,
            include_inactive_items = ""
            };

        var response = mService.get_client_items_basic(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_reg_uss_params()
    {
       get_reg_uss_paramsRequest request = new get_reg_uss_paramsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            session_id = ""
            };

        var response = mService.get_reg_uss_params(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void set_reg_uss_params()
    {
       set_reg_uss_paramsRequest request = new set_reg_uss_paramsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            session_id = "",
            in_reg_uss_params = new[]{new in_reg_uss_params_row()},
            override_timeout_minutes = 1
            };

        var response = mService.set_reg_uss_params(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void delete_reg_uss_params()
    {
       delete_reg_uss_paramsRequest request = new delete_reg_uss_paramsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            session_id = "",
            param_names = new[]{new param_names_row()}
            };

        var response = mService.delete_reg_uss_params(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void replace_reg_uss_params()
    {
       replace_reg_uss_paramsRequest request = new replace_reg_uss_paramsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            session_id = "",
            in_reg_uss_params = new[]{new in_reg_uss_params_row()}
            };

        var response = mService.replace_reg_uss_params(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void clear_reg_uss_params()
    {
       clear_reg_uss_paramsRequest request = new clear_reg_uss_paramsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            session_id = ""
            };

        var response = mService.clear_reg_uss_params(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_reg_uss_config_params()
    {
       get_reg_uss_config_paramsRequest request = new get_reg_uss_config_paramsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            set_name = ""
            };

        var response = mService.get_reg_uss_config_params(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void set_reg_uss_config_params()
    {
       set_reg_uss_config_paramsRequest request = new set_reg_uss_config_paramsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            set_name = "",
            in_reg_uss_config_params = new[]{new in_reg_uss_config_params_row()},
            set_description = "",
            set_type_no = 1
            };

        var response = mService.set_reg_uss_config_params(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void delete_reg_uss_config_params()
    {
       delete_reg_uss_config_paramsRequest request = new delete_reg_uss_config_paramsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            set_name = "",
            param_names = new[]{new param_names_row()}
            };

        var response = mService.delete_reg_uss_config_params(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void replace_reg_uss_config_params()
    {
       replace_reg_uss_config_paramsRequest request = new replace_reg_uss_config_paramsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            set_name = "",
            in_reg_uss_config_params = new[]{new in_reg_uss_config_params_row()}
            };

        var response = mService.replace_reg_uss_config_params(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void clear_reg_uss_config_params()
    {
       clear_reg_uss_config_paramsRequest request = new clear_reg_uss_config_paramsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            set_name = ""
            };

        var response = mService.clear_reg_uss_config_params(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void update_inventory_item_stock()
    {
       update_inventory_item_stockRequest request = new update_inventory_item_stockRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            inventory_item_stock = new[]{new inventory_item_stock_row()}
            };

        var response = mService.update_inventory_item_stock(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_client_currencies()
    {
       get_client_currenciesRequest request = new get_client_currenciesRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey
            };

        var response = mService.get_client_currencies(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_client_item_images()
    {
       get_client_item_imagesRequest request = new get_client_item_imagesRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            item_no = 1
            };

        var response = mService.get_client_item_images(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_top_level_item_class()
    {
       get_top_level_item_classRequest request = new get_top_level_item_classRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey
            };

        var response = mService.get_top_level_item_class(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_parent_for_item_class()
    {
       get_parent_for_item_classRequest request = new get_parent_for_item_classRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            filter_class_no = 1
            };

        var response = mService.get_parent_for_item_class(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_child_for_item_class()
    {
       get_child_for_item_classRequest request = new get_child_for_item_classRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            filter_class_no = 1
            };

        var response = mService.get_child_for_item_class(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_items_by_class()
    {
       get_items_by_classRequest request = new get_items_by_classRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            filter_class_no = 1
            };

        var response = mService.get_items_by_class(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_master_plans_by_supp_field()
    {
       get_master_plans_by_supp_fieldRequest request = new get_master_plans_by_supp_fieldRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            field_val = "",
            field_no = 1,
            field_name = SupplementalFieldName
            };

        var response = mService.get_master_plans_by_supp_field(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_supp_plans_by_supp_field()
    {
       get_supp_plans_by_supp_fieldRequest request = new get_supp_plans_by_supp_fieldRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            field_val = "",
            field_no = 1,
            field_name = SupplementalFieldName
            };

        var response = mService.get_supp_plans_by_supp_field(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_items_by_supp_field()
    {
       get_items_by_supp_fieldRequest request = new get_items_by_supp_fieldRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            field_val = "",
            field_no = 1,
            field_name = SupplementalFieldName
            };

        var response = mService.get_items_by_supp_field(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_email_templates()
    {
       get_email_templatesRequest request = new get_email_templatesRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey
            };

        var response = mService.get_email_templates(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_virtual_datetime()
    {
       get_virtual_datetimeRequest request = new get_virtual_datetimeRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey
            };

        var response = mService.get_virtual_datetime(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void advance_virtual_datetime()
    {
       advance_virtual_datetimeRequest request = new advance_virtual_datetimeRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            offset_hours = 1
            };

        var response = mService.advance_virtual_datetime(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_daily_batch_status()
    {
       get_daily_batch_statusRequest request = new get_daily_batch_statusRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            batch_date = ""
            };

        var response = mService.get_daily_batch_status(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void set_external_object_id()
    {
       set_external_object_idRequest request = new set_external_object_idRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            destination_id = 1,
            source_type_id = 1,
            object_id = 1,
            external_id = "",
            action_directive = 1
            };

        var response = mService.set_external_object_id(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_coupon_details()
    {
       get_coupon_detailsRequest request = new get_coupon_detailsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            coupon_cd = ""
            };

        var response = mService.get_coupon_details(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void delete_acct_coupon()
    {
       delete_acct_couponRequest request = new delete_acct_couponRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            coupon_cd = ""
            };

        var response = mService.delete_acct_coupon(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void update_acct_contact()
    {
       update_acct_contactRequest request = new update_acct_contactRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_no = AccountNumber,
            first_name = "",
            last_name = "",
            mi = "",
            company_name = "",
            address1 = "",
            address2 = "",
            city = "",
            locality = "",
            state_prov = "",
            country = "",
            postal_code = "",
            intl_phone = "",
            alt_email = "",
            birthdate = "",
            address3 = ""
            };

        var response = mService.update_acct_contact(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void update_acct_credentials()
    {
       update_acct_credentialsRequest request = new update_acct_credentialsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_no = AccountNumber,
            password = Password,
            secret_question_answer = "",
            secret_question = "",
            pin = ""
            };

        var response = mService.update_acct_credentials(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void update_acct_status()
    {
       update_acct_statusRequest request = new update_acct_statusRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_no = AccountNumber,
            status_cd = 1,
            queue_days = 1,
            queue_date = "",
            force_bill_date_reset = 1,
            comments = "",
            client_receipt_id = Guid.NewGuid().ToString(),
            alt_do_dunning = ""
            };

        var response = mService.update_acct_status(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void update_acct_supp_fields()
    {
       update_acct_supp_fieldsRequest request = new update_acct_supp_fieldsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_no = AccountNumber,
            field_name = SupplementalFieldName,
            value_text = ""
            };

        var response = mService.update_acct_supp_fields(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void update_acct_billing_contact()
    {
       update_acct_billing_contactRequest request = new update_acct_billing_contactRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_no = AccountNumber,
            first_name = "",
            last_name = "",
            middle_initial = "",
            company_name = "",
            address1 = "",
            address2 = "",
            city = "",
            locality = "",
            state = "",
            country = "",
            zip = "",
            intl_phone = "",
            email = "",
            do_collect = "",
            change_status_after_coll = "",
            reset_dates_after_status = "y",
            address3 = "",
            client_receipt_id = Guid.NewGuid().ToString()
            };

        var response = mService.update_acct_billing_contact(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void update_acct_notify_method()
    {
       update_acct_notify_methodRequest request = new update_acct_notify_methodRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_no = AccountNumber,
            notify_method = 1
            };

        var response = mService.update_acct_notify_method(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_notify_method()
    {
       get_acct_notify_methodRequest request = new get_acct_notify_methodRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_no = AccountNumber
            };

        var response = mService.get_acct_notify_method(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void set_pay_method_bank_draft()
    {
       set_pay_method_bank_draftRequest request = new set_pay_method_bank_draftRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_no = AccountNumber,
            bank_routing_num = "",
            bank_acct_num = "",
            do_collect = "",
            change_status_after_coll = "",
            reset_dates_after_status = "y",
            client_receipt_id = Guid.NewGuid().ToString()
            };

        var response = mService.set_pay_method_bank_draft(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void set_pay_method_cc()
    {
       set_pay_method_ccRequest request = new set_pay_method_ccRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_no = AccountNumber,
            cc_expire_mm = DateTime.Now.Month,
            cc_expire_yyyy = DateTime.Now.Year,
            cc_number = "4111111111111111",
            do_collect = "",
            change_status_after_coll = "",
            reset_dates_after_status = "y",
            client_receipt_id = Guid.NewGuid().ToString()
            };

        var response = mService.set_pay_method_cc(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void set_pay_method_net_terms()
    {
       set_pay_method_net_termsRequest request = new set_pay_method_net_termsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_no = AccountNumber,
            pay_method = "5"
            };

        var response = mService.set_pay_method_net_terms(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void set_payment_responsibility()
    {
       set_payment_responsibilityRequest request = new set_payment_responsibilityRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_no = AccountNumber,
            resp_level_cd = 1,
            senior_account_no = AccountNumber
            };

        var response = mService.set_payment_responsibility(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void set_service_plan_immediately()
    {
       set_service_plan_immediatelyRequest request = new set_service_plan_immediatelyRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_no = AccountNumber,
            plan_no = PlanNumber,
            client_receipt_id = Guid.NewGuid().ToString()
            };

        var response = mService.set_service_plan_immediately(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void toggle_test_account()
    {
       toggle_test_accountRequest request = new toggle_test_accountRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_no = AccountNumber,
            test_acct_ind = 1
            };

        var response = mService.toggle_test_account(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void validate_payment_information()
    {
       validate_payment_informationRequest request = new validate_payment_informationRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_no = AccountNumber,
            CVV = 111,
            seq_no = 1,
            inTrackingNumber = "",
            inAuthValue = "",
            alt_pay_method = 1,
            cc_number = "4111111111111111",
            cc_expire_mm = DateTime.Now.Month,
            cc_expire_yyyy = DateTime.Now.Year,
            bill_company_name = "",
            bill_first_name = "",
            bill_middle_initial = "",
            bill_last_name = "",
            bill_address1 = "",
            bill_address2 = "",
            bill_city = "",
            bill_locality = "",
            bill_state_prov = "",
            bill_zip = "",
            bill_country = "",
            bill_email = "",
            bill_phone = "",
            bill_phone_extension = "",
            bill_cell_phone = "",
            bill_work_phone = "",
            bill_work_phone_extension = "",
            currency_cd = "",
            acct_group_no = 1,
            bill_address3 = "",
            alt_client_acct_group_id = "",
            track_data1 = "",
            track_data2 = ""
            };

        var response = mService.validate_payment_information(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void ban_acct()
    {
       ban_acctRequest request = new ban_acctRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_no = AccountNumber,
            userid = UserId,
            days_to_restore = 1,
            date_to_restore = "",
            reason_cd = 1,
            comments = ""
            };

        var response = mService.ban_acct(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_trans_history()
    {
       get_acct_trans_historyRequest request = new get_acct_trans_historyRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_no = AccountNumber,
            transaction_type = 1,
            start_date = DateTime.Now.AddYears(15).ToShortDateString(),
            end_date = "",
            record_limit = 1,
            filter_statement_no = 1,
            include_void_transactions = ""
            };

        var response = mService.get_acct_trans_history(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void update_payment_method()
    {
       update_payment_methodRequest request = new update_payment_methodRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_number = 1,
            first_name = "",
            last_name = "",
            middle_initial = "",
            company_name = "",
            address1 = "",
            address2 = "",
            city = "",
            locality = "",
            state = "",
            country = "",
            zip = "",
            intl_phone = "",
            phone_npa = "",
            phone_nxx = "",
            phone_suffix = "",
            phone_extension = "",
            email = "",
            pay_method = "5",
            cc_number = "4111111111111111",
            cc_expire_mm = DateTime.Now.Month,
            cc_expire_yyyy = DateTime.Now.Year,
            bank_routing_num = "",
            bank_acct_num = "",
            do_collect = "",
            change_status_after_coll = "",
            reset_dates_after_status = "y",
            client_receipt_id = Guid.NewGuid().ToString()
            };

        var response = mService.update_payment_method(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void authorize_electronic_payment()
    {
       authorize_electronic_paymentRequest request = new authorize_electronic_paymentRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_number = 1,
            amount = 1,
            payment_source = 1,
            CVV = 111,
            bill_seq = 1,
            inTrackingNumber = "",
            inAuthValue = "",
            alt_client_acct_group_id = "",
            track_data1 = "",
            track_data2 = "",
            alt_pay_method = 1,
            cc_number = "4111111111111111",
            cc_expire_mm = DateTime.Now.Month,
            cc_expire_yyyy = DateTime.Now.Year,
            bank_routing_num = "",
            bank_acct_num = "",
            bill_company_name = "",
            bill_first_name = "",
            bill_middle_initial = "",
            bill_last_name = "",
            bill_address1 = "",
            bill_address2 = "",
            bill_address3 = "",
            bill_city = "",
            bill_locality = "",
            bill_state_prov = "",
            bill_zip = "",
            bill_country = "",
            bill_email = "",
            bill_phone = "",
            bill_phone_extension = "",
            bill_cell_phone = "",
            bill_work_phone = "",
            bill_work_phone_extension = "",
            record_cc_on_auth_failure = ""
            };

        var response = mService.authorize_electronic_payment(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_queued_service_plans()
    {
       get_queued_service_plansRequest request = new get_queued_service_plansRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_number = 1
            };

        var response = mService.get_queued_service_plans(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void cancel_queued_service_plan()
    {
       cancel_queued_service_planRequest request = new cancel_queued_service_planRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_number = 1,
            plan_no_to_remove = new[]{new plan_no_to_remove_row()},
            remove_all_queued_plan_no = "",
            remove_terminate_pending = ""
            };

        var response = mService.cancel_queued_service_plan(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_status_history()
    {
       get_acct_status_historyRequest request = new get_acct_status_historyRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_number = 1
            };

        var response = mService.get_acct_status_history(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_plan_history()
    {
       get_acct_plan_historyRequest request = new get_acct_plan_historyRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_number = 1
            };

        var response = mService.get_acct_plan_history(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_supp_plan_history()
    {
       get_acct_supp_plan_historyRequest request = new get_acct_supp_plan_historyRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            plan_no = PlanNumber
            };

        var response = mService.get_acct_supp_plan_history(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_available_plans()
    {
       get_available_plansRequest request = new get_available_plansRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1
            };

        var response = mService.get_available_plans(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_available_plans_all()
    {
       get_available_plans_allRequest request = new get_available_plans_allRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1
            };

        var response = mService.get_available_plans_all(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_plans_by_promo_code()
    {
       get_plans_by_promo_codeRequest request = new get_plans_by_promo_codeRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            promo_code = PromoCode
            };

        var response = mService.get_plans_by_promo_code(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_plans_by_promo_code_all()
    {
       get_plans_by_promo_code_allRequest request = new get_plans_by_promo_code_allRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            promo_code = PromoCode
            };

        var response = mService.get_plans_by_promo_code_all(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_details_all()
    {
       get_acct_details_allRequest request = new get_acct_details_allRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1
            };

        var response = mService.get_acct_details_all(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_child_accts()
    {
       get_child_acctsRequest request = new get_child_acctsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            parent_acct_no = 1,
            do_multi_level = ""
            };

        var response = mService.get_child_accts(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_family_trans_history()
    {
       get_family_trans_historyRequest request = new get_family_trans_historyRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            parent_acct_no = 1,
            do_multi_level = "",
            trans_type = 1,
            start_date = DateTime.Now.AddYears(15).ToShortDateString(),
            end_date = "",
            record_limit = 1,
            include_void_transactions = ""
            };

        var response = mService.get_family_trans_history(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void update_existing_billing_info()
    {
       update_existing_billing_infoRequest request = new update_existing_billing_infoRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            seq_no = 1,
            address1 = "",
            address2 = "",
            city = "",
            state = "",
            zip = "",
            country = "",
            cc_expire_mm = DateTime.Now.Month,
            cc_expire_yyyy = DateTime.Now.Year,
            phone_npa = 1,
            phone_nxx = 1,
            phone_suffix = "",
            phone_ext = "",
            phone_country_cd = "",
            intl_phone = "",
            email = "",
            locality = "",
            cell_phone_npa = 1,
            cell_phone_nxx = 1,
            cell_phone_suffix = "",
            work_phone_npa = 1,
            work_phone_nxx = 1,
            work_phone_suffix = "",
            work_phone_ext = "",
            do_collect = "",
            change_status_after_coll = "",
            reset_dates_after_status = "y",
            address3 = "",
            client_receipt_id = Guid.NewGuid().ToString()
            };

        var response = mService.update_existing_billing_info(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void send_acct_email()
    {
       send_acct_emailRequest request = new send_acct_emailRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            user_id = "",
            template_class = "",
            template_no = 1,
            client_receipt_id = Guid.NewGuid().ToString()
            };

        var response = mService.send_acct_email(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void userid_exists()
    {
       userid_existsRequest request = new userid_existsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            user_id = ""
            };

        var response = mService.userid_exists(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void userid_is_available()
    {
       userid_is_availableRequest request = new userid_is_availableRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            user_id = ""
            };

        var response = mService.userid_is_available(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_standing_usage()
    {
       get_standing_usageRequest request = new get_standing_usageRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1
            };

        var response = mService.get_standing_usage(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void record_standing_usage()
    {
       record_standing_usageRequest request = new record_standing_usageRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            usage_type = 1,
            usage_units = 1,
            next_usage_date = "",
            alt_desc = "",
            plan_no = PlanNumber,
            first_usage_date = DateTime.Now.ToShortDateString(),
            recurring_ind = "",
            usage_type_code = ""
            };

        var response = mService.record_standing_usage(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void disable_standing_usage()
    {
       disable_standing_usageRequest request = new disable_standing_usageRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            standing_usage_rec_no = 1,
            comments = ""
            };

        var response = mService.disable_standing_usage(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void disable_standing_usage_by_plan()
    {
       disable_standing_usage_by_planRequest request = new disable_standing_usage_by_planRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            plan_no = PlanNumber,
            comments = ""
            };

        var response = mService.disable_standing_usage_by_plan(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void disable_all_standing_usage()
    {
       disable_all_standing_usageRequest request = new disable_all_standing_usageRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            comments = ""
            };

        var response = mService.disable_all_standing_usage(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_plans()
    {
       get_acct_plansRequest request = new get_acct_plansRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1
            };

        var response = mService.get_acct_plans(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_plans_all()
    {
       get_acct_plans_allRequest request = new get_acct_plans_allRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1
            };

        var response = mService.get_acct_plans_all(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_supp_fields()
    {
       get_acct_supp_fieldsRequest request = new get_acct_supp_fieldsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1
            };

        var response = mService.get_acct_supp_fields(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_supp_field_values()
    {
       get_supp_field_valuesRequest request = new get_supp_field_valuesRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            field_name = SupplementalFieldName
            };

        var response = mService.get_supp_field_values(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_supp_plans_by_promo_code()
    {
       get_supp_plans_by_promo_codeRequest request = new get_supp_plans_by_promo_codeRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            promo_code = PromoCode
            };

        var response = mService.get_supp_plans_by_promo_code(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_supp_plans_by_promo_code_all()
    {
       get_supp_plans_by_promo_code_allRequest request = new get_supp_plans_by_promo_code_allRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            promo_code = PromoCode
            };

        var response = mService.get_supp_plans_by_promo_code_all(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void assign_supp_plan()
    {
       assign_supp_planRequest request = new assign_supp_planRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            supp_plan_no = SupplementalPlanNumber,
            alt_rate_schedule_no = 1,
            num_plan_units = 1,
            coupon_code = "",
            assignment_directive = 1,
            comments = "",
            do_write = "",
            client_receipt_id = Guid.NewGuid().ToString(),
            contract_type_no = 1,
            contract_alt_recur_fee = 1,
            contract_length_months = 1,
            contract_cancel_fee = 1,
            contract_comments = "",
            contract_start_date = "",
            offset_months = 1,
            auto_offset_months_option = 1,
            alt_proration_start_date = "",
            alt_client_acct_group_id = "",
            new_acct_custom_rates = new[]{new new_acct_custom_rates_row()},
            effective_date = "",
            offset_interval = 1,
            contract_end_date = ""
            };

        var response = mService.assign_supp_plan(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void cancel_supp_plan()
    {
       cancel_supp_planRequest request = new cancel_supp_planRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            supp_plan_no = SupplementalPlanNumber,
            assignment_directive = 1,
            comments = "",
            do_write = "",
            client_receipt_id = Guid.NewGuid().ToString(),
            alt_proration_start_date = "",
            effective_date = "",
            offset_interval = 1,
            invoice_unbilled_usage = ""
            };

        var response = mService.cancel_supp_plan(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void modify_supp_plan()
    {
       modify_supp_planRequest request = new modify_supp_planRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            supp_plan_no = SupplementalPlanNumber,
            alt_rate_schedule_no = 1,
            num_plan_units = 1,
            coupon_code = "",
            assignment_directive = 1,
            comments = "",
            do_write = "",
            client_receipt_id = Guid.NewGuid().ToString(),
            new_acct_custom_rates = new[]{new new_acct_custom_rates_row()},
            effective_date = "",
            offset_interval = 1
            };

        var response = mService.modify_supp_plan(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void replace_supp_plan()
    {
       replace_supp_planRequest request = new replace_supp_planRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            existing_supp_plan_no = 1,
            new_supp_plan_no = 1,
            alt_rate_schedule_no = 1,
            num_plan_units = 1,
            coupon_code = "",
            assignment_directive = 1,
            comments = "",
            do_write = "",
            client_receipt_id = Guid.NewGuid().ToString(),
            offset_months = 1,
            auto_offset_months_option = 1,
            alt_client_acct_group_id = "",
            new_acct_custom_rates = new[]{new new_acct_custom_rates_row()},
            effective_date = "",
            offset_interval = 1,
            invoice_unbilled_usage = ""
            };

        var response = mService.replace_supp_plan(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_avail_child_plans_for_plan()
    {
       get_avail_child_plans_for_planRequest request = new get_avail_child_plans_for_planRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            in_plan_no = 1
            };

        var response = mService.get_avail_child_plans_for_plan(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_avail_child_plans_for_plan_all()
    {
       get_avail_child_plans_for_plan_allRequest request = new get_avail_child_plans_for_plan_allRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            in_plan_no = 1
            };

        var response = mService.get_avail_child_plans_for_plan_all(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_avail_child_plans_for_acct()
    {
       get_avail_child_plans_for_acctRequest request = new get_avail_child_plans_for_acctRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1
            };

        var response = mService.get_avail_child_plans_for_acct(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_avail_child_plans_for_acct_all()
    {
       get_avail_child_plans_for_acct_allRequest request = new get_avail_child_plans_for_acct_allRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1
            };

        var response = mService.get_avail_child_plans_for_acct_all(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_groups_by_client()
    {
       get_acct_groups_by_clientRequest request = new get_acct_groups_by_clientRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey
            };

        var response = mService.get_acct_groups_by_client(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_groups_by_acct()
    {
       get_acct_groups_by_acctRequest request = new get_acct_groups_by_acctRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            user_id = ""
            };

        var response = mService.get_acct_groups_by_acct(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void assign_functional_acct_group()
    {
       assign_functional_acct_groupRequest request = new assign_functional_acct_groupRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            group_no = 1,
            client_acct_group_id = ""
            };

        var response = mService.assign_functional_acct_group(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void assign_collections_acct_group()
    {
       assign_collections_acct_groupRequest request = new assign_collections_acct_groupRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            group_no = 1,
            client_acct_group_id = ""
            };

        var response = mService.assign_collections_acct_group(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void remove_acct_from_group()
    {
       remove_acct_from_groupRequest request = new remove_acct_from_groupRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            group_no = 1,
            client_acct_group_id = ""
            };

        var response = mService.remove_acct_from_group(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void create_acct_complete()
    {
       create_acct_completeRequest request = new create_acct_completeRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            master_plan_no = 1,
            alt_start_date = "",
            client_acct_id = "",
            userid = UserId,
            status_cd = 1,
            master_plan_units = 1,
            supp_plans = new[]{new supp_plans_row()},
            supp_plan_units = new[]{new supp_plan_units_row()},
            notify_method = 1,
            promo_cd = "",
            password = Password,
            secret_question = "",
            secret_question_answer = "",
            first_name = "",
            mi = "",
            last_name = "",
            company_name = "",
            address1 = "",
            address2 = "",
            city = "",
            locality = "",
            state_prov = "",
            country = "",
            postal_cd = "",
            phone = "",
            phone_ext = "",
            cell_phone = "",
            work_phone = "",
            work_phone_ext = "",
            email = "",
            birthdate = "",
            bill_first_name = "",
            bill_mi = "",
            bill_last_name = "",
            bill_company_name = "",
            bill_address1 = "",
            bill_address2 = "",
            bill_city = "",
            bill_locality = "",
            bill_state_prov = "",
            bill_country = "",
            bill_postal_cd = "",
            bill_phone = "",
            bill_phone_ext = "",
            bill_cell_phone = "",
            bill_work_phone = "",
            bill_work_phone_ext = "",
            bill_email = "",
            pay_method = "5",
            cc_number = "4111111111111111",
            cc_expire_mm = DateTime.Now.Month,
            cc_expire_yyyy = DateTime.Now.Year,
            bank_acct_no = "",
            bank_routing_no = "",
            resp_level_cd = 1,
            senior_acct_no = 1,
            functional_acct_groups = new[]{new functional_acct_groups_row()},
            collections_acct_groups = new[]{new collections_acct_groups_row()},
            supp_field_names = new[]{new supp_field_names_row()},
            supp_field_values = new[]{new supp_field_values_row()},
            test_acct_ind = 1,
            status_until_alt_start = 1,
            balance_forward = 1,
            alt_bill_day = 1,
            do_full_invoicing = "",
            do_prorated_invoicing = "",
            master_plan_alt_rate_sched_no = 1,
            supp_plan_alt_rate_sched_no = new[]{new supp_plan_alt_rate_sched_no_row()},
            client_receipt_id = Guid.NewGuid().ToString(),
            currency_cd = "",
            cvv = "",
            taxpayer_id = "",
            bill_agreement_id = "",
            retroactive_start_date = "",
            coupon_codes = new[]{new coupon_codes_row()},
            new_acct_custom_rates = new[]{new new_acct_custom_rates_row()},
            alt_msg_template_no = 1,
            seq_func_group_no = 1,
            new_acct_plan_contracts = new[]{new new_acct_plan_contracts_row()},
            address3 = "",
            bill_address3 = "",
            usage_accumulation_config = new[]{new usage_accumulation_config_row()},
            enable_usage_pooling_plan_no = new[]{new enable_usage_pooling_plan_no_row()},
            client_func_acct_group_ids = new[]{new client_func_acct_group_ids_row()},
            client_coll_acct_group_ids = new[]{new client_coll_acct_group_ids_row()},
            track_data1 = "",
            track_data2 = "",
            do_write = "",
            tax_exemption_level = 1,
            cn_alt_msg_template_no = 1
            };

        var response = mService.create_acct_complete(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void create_acct_hierarchy()
    {
       create_acct_hierarchyRequest request = new create_acct_hierarchyRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            a1_master_plan_no = 1,
            do_write = "",
            client_receipt_id = Guid.NewGuid().ToString(),
            a1_alt_start_date = "",
            a1_client_acct_id = "",
            a1_userid = "",
            a1_status_cd = 1,
            a1_master_plan_units = 1,
            a1_supp_plans = new[]{new a1_supp_plans_row()},
            a1_supp_plan_units = new[]{new a1_supp_plan_units_row()},
            a1_notify_method = 1,
            a1_promo_cd = "",
            a1_password = "",
            a1_secret_question = "",
            a1_secret_question_answer = "",
            a1_first_name = "",
            a1_mi = "",
            a1_last_name = "",
            a1_company_name = "",
            a1_address1 = "",
            a1_address2 = "",
            a1_city = "",
            a1_locality = "",
            a1_state_prov = "",
            a1_country = "",
            a1_postal_cd = "",
            a1_phone = "",
            a1_phone_ext = "",
            a1_cell_phone = "",
            a1_work_phone = "",
            a1_work_phone_ext = "",
            a1_email = "",
            a1_birthdate = "",
            a1_bill_first_name = "",
            a1_bill_mi = "",
            a1_bill_last_name = "",
            a1_bill_company_name = "",
            a1_bill_address1 = "",
            a1_bill_address2 = "",
            a1_bill_city = "",
            a1_bill_locality = "",
            a1_bill_state_prov = "",
            a1_bill_country = "",
            a1_bill_postal_cd = "",
            a1_bill_phone = "",
            a1_bill_phone_ext = "",
            a1_bill_cell_phone = "",
            a1_bill_work_phone = "",
            a1_bill_work_phone_ext = "",
            a1_bill_email = "",
            a1_pay_method = 1,
            a1_cc_number = "",
            a1_cc_expire_mm = 1,
            a1_cc_expire_yyyy = 1,
            a1_bank_acct_no = "",
            a1_bank_routing_no = "",
            a1_resp_level_cd = 1,
            a1_functional_acct_groups = new[]{new a1_functional_acct_groups_row()},
            a1_collections_acct_groups = new[]{new a1_collections_acct_groups_row()},
            a1_supp_field_names = new[]{new a1_supp_field_names_row()},
            a1_supp_field_values = new[]{new a1_supp_field_values_row()},
            a1_test_acct_ind = 1,
            a1_status_until_alt_start = 1,
            a1_balance_forward = 1,
            a1_alt_bill_day = 1,
            a1_do_full_invoicing = "",
            a1_do_prorated_invoicing = "",
            a1_master_plan_alt_rate_sched_no = 1,
            a1_supp_plan_alt_rate_sched_no = new[]{new a1_supp_plan_alt_rate_sched_no_row()},
            a1_currency_cd = "",
            a1_cvv = "",
            a1_taxpayer_id = "",
            a1_bill_agreement_id = "",
            a1_retroactive_start_date = "",
            a1_coupon_codes = new[]{new a1_coupon_codes_row()},
            a1_new_acct_custom_rates = new[]{new a1_new_acct_custom_rates_row()},
            a1_alt_msg_template_no = 1,
            a1_seq_func_group_no = 1,
            a1_new_acct_plan_contracts = new[]{new a1_new_acct_plan_contracts_row()},
            a1_address3 = "",
            a1_bill_address3 = "",
            a1_usage_accumulation_config = new[]{new a1_usage_accumulation_config_row()},
            a1_enable_usage_pooling_plan_no = new[]{new a1_enable_usage_pooling_plan_no_row()},
            a1_client_func_acct_group_ids = new[]{new a1_client_func_acct_group_ids_row()},
            a1_client_coll_acct_group_ids = new[]{new a1_client_coll_acct_group_ids_row()},
            a1_track_data1 = "",
            a1_track_data2 = "",
            a1_tax_exemption_level = 1,
            a1_cn_alt_msg_template_no = 1,
            a2_alt_start_date = "",
            a2_client_acct_id = "",
            a2_userid = "",
            a2_status_cd = 1,
            a2_master_plan_no = 1,
            a2_master_plan_units = 1,
            a2_supp_plans = new[]{new a2_supp_plans_row()},
            a2_supp_plan_units = new[]{new a2_supp_plan_units_row()},
            a2_notify_method = 1,
            a2_promo_cd = "",
            a2_password = "",
            a2_secret_question = "",
            a2_secret_question_answer = "",
            a2_first_name = "",
            a2_mi = "",
            a2_last_name = "",
            a2_company_name = "",
            a2_address1 = "",
            a2_address2 = "",
            a2_city = "",
            a2_locality = "",
            a2_state_prov = "",
            a2_country = "",
            a2_postal_cd = "",
            a2_phone = "",
            a2_phone_ext = "",
            a2_cell_phone = "",
            a2_work_phone = "",
            a2_work_phone_ext = "",
            a2_email = "",
            a2_birthdate = "",
            a2_bill_first_name = "",
            a2_bill_mi = "",
            a2_bill_last_name = "",
            a2_bill_company_name = "",
            a2_bill_address1 = "",
            a2_bill_address2 = "",
            a2_bill_city = "",
            a2_bill_locality = "",
            a2_bill_state_prov = "",
            a2_bill_country = "",
            a2_bill_postal_cd = "",
            a2_bill_phone = "",
            a2_bill_phone_ext = "",
            a2_bill_cell_phone = "",
            a2_bill_work_phone = "",
            a2_bill_work_phone_ext = "",
            a2_bill_email = "",
            a2_pay_method = 1,
            a2_cc_number = "",
            a2_cc_expire_mm = 1,
            a2_cc_expire_yyyy = 1,
            a2_bank_acct_no = "",
            a2_bank_routing_no = "",
            a2_resp_level_cd = 1,
            a2_functional_acct_groups = new[]{new a2_functional_acct_groups_row()},
            a2_collections_acct_groups = new[]{new a2_collections_acct_groups_row()},
            a2_supp_field_names = new[]{new a2_supp_field_names_row()},
            a2_supp_field_values = new[]{new a2_supp_field_values_row()},
            a2_test_acct_ind = 1,
            a2_status_until_alt_start = 1,
            a2_balance_forward = 1,
            a2_alt_bill_day = 1,
            a2_do_full_invoicing = "",
            a2_do_prorated_invoicing = "",
            a2_master_plan_alt_rate_sched_no = 1,
            a2_supp_plan_alt_rate_sched_no = new[]{new a2_supp_plan_alt_rate_sched_no_row()},
            a2_currency_cd = "",
            a2_cvv = "",
            a2_taxpayer_id = "",
            a2_bill_agreement_id = "",
            a2_retroactive_start_date = "",
            a2_coupon_codes = new[]{new a2_coupon_codes_row()},
            a2_new_acct_custom_rates = new[]{new a2_new_acct_custom_rates_row()},
            a2_alt_msg_template_no = 1,
            a2_seq_func_group_no = 1,
            a2_new_acct_plan_contracts = new[]{new a2_new_acct_plan_contracts_row()},
            a2_address3 = "",
            a2_bill_address3 = "",
            a2_usage_accumulation_config = new[]{new a2_usage_accumulation_config_row()},
            a2_enable_usage_pooling_plan_no = new[]{new a2_enable_usage_pooling_plan_no_row()},
            a2_client_func_acct_group_ids = new[]{new a2_client_func_acct_group_ids_row()},
            a2_client_coll_acct_group_ids = new[]{new a2_client_coll_acct_group_ids_row()},
            a2_track_data1 = "",
            a2_track_data2 = "",
            a2_tax_exemption_level = 1,
            a2_cn_alt_msg_template_no = 1,
            a3_alt_start_date = "",
            a3_client_acct_id = "",
            a3_userid = "",
            a3_status_cd = 1,
            a3_master_plan_no = 1,
            a3_master_plan_units = 1,
            a3_supp_plans = new[]{new a3_supp_plans_row()},
            a3_supp_plan_units = new[]{new a3_supp_plan_units_row()},
            a3_notify_method = 1,
            a3_promo_cd = "",
            a3_password = "",
            a3_secret_question = "",
            a3_secret_question_answer = "",
            a3_first_name = "",
            a3_mi = "",
            a3_last_name = "",
            a3_company_name = "",
            a3_address1 = "",
            a3_address2 = "",
            a3_city = "",
            a3_locality = "",
            a3_state_prov = "",
            a3_country = "",
            a3_postal_cd = "",
            a3_phone = "",
            a3_phone_ext = "",
            a3_cell_phone = "",
            a3_work_phone = "",
            a3_work_phone_ext = "",
            a3_email = "",
            a3_birthdate = "",
            a3_bill_first_name = "",
            a3_bill_mi = "",
            a3_bill_last_name = "",
            a3_bill_company_name = "",
            a3_bill_address1 = "",
            a3_bill_address2 = "",
            a3_bill_city = "",
            a3_bill_locality = "",
            a3_bill_state_prov = "",
            a3_bill_country = "",
            a3_bill_postal_cd = "",
            a3_bill_phone = "",
            a3_bill_phone_ext = "",
            a3_bill_cell_phone = "",
            a3_bill_work_phone = "",
            a3_bill_work_phone_ext = "",
            a3_bill_email = "",
            a3_pay_method = 1,
            a3_cc_number = "",
            a3_cc_expire_mm = 1,
            a3_cc_expire_yyyy = 1,
            a3_bank_acct_no = "",
            a3_bank_routing_no = "",
            a3_resp_level_cd = 1,
            a3_functional_acct_groups = new[]{new a3_functional_acct_groups_row()},
            a3_collections_acct_groups = new[]{new a3_collections_acct_groups_row()},
            a3_supp_field_names = new[]{new a3_supp_field_names_row()},
            a3_supp_field_values = new[]{new a3_supp_field_values_row()},
            a3_test_acct_ind = 1,
            a3_status_until_alt_start = 1,
            a3_balance_forward = 1,
            a3_alt_bill_day = 1,
            a3_do_full_invoicing = "",
            a3_do_prorated_invoicing = "",
            a3_master_plan_alt_rate_sched_no = 1,
            a3_supp_plan_alt_rate_sched_no = new[]{new a3_supp_plan_alt_rate_sched_no_row()},
            a3_currency_cd = "",
            a3_cvv = "",
            a3_taxpayer_id = "",
            a3_bill_agreement_id = "",
            a3_retroactive_start_date = "",
            a3_coupon_codes = new[]{new a3_coupon_codes_row()},
            a3_new_acct_custom_rates = new[]{new a3_new_acct_custom_rates_row()},
            a3_alt_msg_template_no = 1,
            a3_seq_func_group_no = 1,
            a3_new_acct_plan_contracts = new[]{new a3_new_acct_plan_contracts_row()},
            a3_address3 = "",
            a3_bill_address3 = "",
            a3_usage_accumulation_config = new[]{new a3_usage_accumulation_config_row()},
            a3_enable_usage_pooling_plan_no = new[]{new a3_enable_usage_pooling_plan_no_row()},
            a3_client_func_acct_group_ids = new[]{new a3_client_func_acct_group_ids_row()},
            a3_client_coll_acct_group_ids = new[]{new a3_client_coll_acct_group_ids_row()},
            a3_track_data1 = "",
            a3_track_data2 = "",
            a3_tax_exemption_level = 1,
            a3_cn_alt_msg_template_no = 1,
            a4_alt_start_date = "",
            a4_client_acct_id = "",
            a4_userid = "",
            a4_status_cd = 1,
            a4_master_plan_no = 1,
            a4_master_plan_units = 1,
            a4_supp_plans = new[]{new a4_supp_plans_row()},
            a4_supp_plan_units = new[]{new a4_supp_plan_units_row()},
            a4_notify_method = 1,
            a4_promo_cd = "",
            a4_password = "",
            a4_secret_question = "",
            a4_secret_question_answer = "",
            a4_first_name = "",
            a4_mi = "",
            a4_last_name = "",
            a4_company_name = "",
            a4_address1 = "",
            a4_address2 = "",
            a4_city = "",
            a4_locality = "",
            a4_state_prov = "",
            a4_country = "",
            a4_postal_cd = "",
            a4_phone = "",
            a4_phone_ext = "",
            a4_cell_phone = "",
            a4_work_phone = "",
            a4_work_phone_ext = "",
            a4_email = "",
            a4_birthdate = "",
            a4_bill_first_name = "",
            a4_bill_mi = "",
            a4_bill_last_name = "",
            a4_bill_company_name = "",
            a4_bill_address1 = "",
            a4_bill_address2 = "",
            a4_bill_city = "",
            a4_bill_locality = "",
            a4_bill_state_prov = "",
            a4_bill_country = "",
            a4_bill_postal_cd = "",
            a4_bill_phone = "",
            a4_bill_phone_ext = "",
            a4_bill_cell_phone = "",
            a4_bill_work_phone = "",
            a4_bill_work_phone_ext = "",
            a4_bill_email = "",
            a4_pay_method = 1,
            a4_cc_number = "",
            a4_cc_expire_mm = 1,
            a4_cc_expire_yyyy = 1,
            a4_bank_acct_no = "",
            a4_bank_routing_no = "",
            a4_resp_level_cd = 1,
            a4_functional_acct_groups = new[]{new a4_functional_acct_groups_row()},
            a4_collections_acct_groups = new[]{new a4_collections_acct_groups_row()},
            a4_supp_field_names = new[]{new a4_supp_field_names_row()},
            a4_supp_field_values = new[]{new a4_supp_field_values_row()},
            a4_test_acct_ind = 1,
            a4_status_until_alt_start = 1,
            a4_balance_forward = 1,
            a4_alt_bill_day = 1,
            a4_do_full_invoicing = "",
            a4_do_prorated_invoicing = "",
            a4_master_plan_alt_rate_sched_no = 1,
            a4_supp_plan_alt_rate_sched_no = new[]{new a4_supp_plan_alt_rate_sched_no_row()},
            a4_currency_cd = "",
            a4_cvv = "",
            a4_taxpayer_id = "",
            a4_bill_agreement_id = "",
            a4_retroactive_start_date = "",
            a4_coupon_codes = new[]{new a4_coupon_codes_row()},
            a4_new_acct_custom_rates = new[]{new a4_new_acct_custom_rates_row()},
            a4_alt_msg_template_no = 1,
            a4_seq_func_group_no = 1,
            a4_new_acct_plan_contracts = new[]{new a4_new_acct_plan_contracts_row()},
            a4_address3 = "",
            a4_bill_address3 = "",
            a4_usage_accumulation_config = new[]{new a4_usage_accumulation_config_row()},
            a4_enable_usage_pooling_plan_no = new[]{new a4_enable_usage_pooling_plan_no_row()},
            a4_client_func_acct_group_ids = new[]{new a4_client_func_acct_group_ids_row()},
            a4_client_coll_acct_group_ids = new[]{new a4_client_coll_acct_group_ids_row()},
            a4_track_data1 = "",
            a4_track_data2 = "",
            a4_tax_exemption_level = 1,
            a4_cn_alt_msg_template_no = 1,
            a5_alt_start_date = "",
            a5_client_acct_id = "",
            a5_userid = "",
            a5_status_cd = 1,
            a5_master_plan_no = 1,
            a5_master_plan_units = 1,
            a5_supp_plans = new[]{new a5_supp_plans_row()},
            a5_supp_plan_units = new[]{new a5_supp_plan_units_row()},
            a5_notify_method = 1,
            a5_promo_cd = "",
            a5_password = "",
            a5_secret_question = "",
            a5_secret_question_answer = "",
            a5_first_name = "",
            a5_mi = "",
            a5_last_name = "",
            a5_company_name = "",
            a5_address1 = "",
            a5_address2 = "",
            a5_city = "",
            a5_locality = "",
            a5_state_prov = "",
            a5_country = "",
            a5_postal_cd = "",
            a5_phone = "",
            a5_phone_ext = "",
            a5_cell_phone = "",
            a5_work_phone = "",
            a5_work_phone_ext = "",
            a5_email = "",
            a5_birthdate = "",
            a5_bill_first_name = "",
            a5_bill_mi = "",
            a5_bill_last_name = "",
            a5_bill_company_name = "",
            a5_bill_address1 = "",
            a5_bill_address2 = "",
            a5_bill_city = "",
            a5_bill_locality = "",
            a5_bill_state_prov = "",
            a5_bill_country = "",
            a5_bill_postal_cd = "",
            a5_bill_phone = "",
            a5_bill_phone_ext = "",
            a5_bill_cell_phone = "",
            a5_bill_work_phone = "",
            a5_bill_work_phone_ext = "",
            a5_bill_email = "",
            a5_pay_method = 1,
            a5_cc_number = "",
            a5_cc_expire_mm = 1,
            a5_cc_expire_yyyy = 1,
            a5_bank_acct_no = "",
            a5_bank_routing_no = "",
            a5_resp_level_cd = 1,
            a5_functional_acct_groups = new[]{new a5_functional_acct_groups_row()},
            a5_collections_acct_groups = new[]{new a5_collections_acct_groups_row()},
            a5_supp_field_names = new[]{new a5_supp_field_names_row()},
            a5_supp_field_values = new[]{new a5_supp_field_values_row()},
            a5_test_acct_ind = 1,
            a5_status_until_alt_start = 1,
            a5_balance_forward = 1,
            a5_alt_bill_day = 1,
            a5_do_full_invoicing = "",
            a5_do_prorated_invoicing = "",
            a5_master_plan_alt_rate_sched_no = 1,
            a5_supp_plan_alt_rate_sched_no = new[]{new a5_supp_plan_alt_rate_sched_no_row()},
            a5_currency_cd = "",
            a5_cvv = "",
            a5_taxpayer_id = "",
            a5_bill_agreement_id = "",
            a5_retroactive_start_date = "",
            a5_coupon_codes = new[]{new a5_coupon_codes_row()},
            a5_new_acct_custom_rates = new[]{new a5_new_acct_custom_rates_row()},
            a5_alt_msg_template_no = 1,
            a5_seq_func_group_no = 1,
            a5_new_acct_plan_contracts = new[]{new a5_new_acct_plan_contracts_row()},
            a5_address3 = "",
            a5_bill_address3 = "",
            a5_usage_accumulation_config = new[]{new a5_usage_accumulation_config_row()},
            a5_enable_usage_pooling_plan_no = new[]{new a5_enable_usage_pooling_plan_no_row()},
            a5_client_func_acct_group_ids = new[]{new a5_client_func_acct_group_ids_row()},
            a5_client_coll_acct_group_ids = new[]{new a5_client_coll_acct_group_ids_row()},
            a5_track_data1 = "",
            a5_track_data2 = "",
            a5_tax_exemption_level = 1,
            a5_cn_alt_msg_template_no = 1
            };

        var response = mService.create_acct_hierarchy(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void apply_coupon_to_acct()
    {
       apply_coupon_to_acctRequest request = new apply_coupon_to_acctRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            coupon_code = ""
            };

        var response = mService.apply_coupon_to_acct(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void create_advanced_service_credit()
    {
       create_advanced_service_creditRequest request = new create_advanced_service_creditRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            amount = 1,
            reason_code = 1,
            comments = "",
            eligible_plan_no = 1,
            eligible_service_no = 1,
            alt_service_no_to_apply = 1,
            frequency_no = 1,
            frequency_interval_months = 1,
            initial_credit_date = DateTime.Now.ToShortDateString(),
            percent_amount = 1,
            percent_eval_plan_no = 1,
            percent_eval_service_no = 1
            };

        var response = mService.create_advanced_service_credit(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_no_from_user_id()
    {
       get_acct_no_from_user_idRequest request = new get_acct_no_from_user_idRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            user_id = ""
            };

        var response = mService.get_acct_no_from_user_id(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_user_id_from_acct_no()
    {
       get_user_id_from_acct_noRequest request = new get_user_id_from_acct_noRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1
            };

        var response = mService.get_user_id_from_acct_no(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_plan_contract()
    {
       get_acct_plan_contractRequest request = new get_acct_plan_contractRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            plan_no = PlanNumber
            };

        var response = mService.get_acct_plan_contract(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void create_acct_plan_contract()
    {
       create_acct_plan_contractRequest request = new create_acct_plan_contractRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            plan_no = PlanNumber,
            type_no = 1,
            alt_recur_fee = 1,
            length_months = 1,
            cancel_fee = 1,
            create_comments = "",
            start_date = DateTime.Now.AddYears(15).ToShortDateString(),
            do_auto_discard = "",
            end_date = ""
            };

        var response = mService.create_acct_plan_contract(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void modify_acct_plan_contract()
    {
       modify_acct_plan_contractRequest request = new modify_acct_plan_contractRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            contract_no = 1,
            type_no = 1,
            alt_recur_fee = 1,
            length_months = 1,
            cancel_fee = 1,
            start_date = DateTime.Now.AddYears(15).ToShortDateString(),
            update_comments = "",
            end_date = ""
            };

        var response = mService.modify_acct_plan_contract(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void cancel_acct_plan_contract()
    {
       cancel_acct_plan_contractRequest request = new cancel_acct_plan_contractRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            contract_no = 1,
            update_comments = "",
            close_status = 1
            };

        var response = mService.cancel_acct_plan_contract(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_usage_history()
    {
       get_usage_historyRequest request = new get_usage_historyRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            date_range_start = DateTime.Now.AddMonths(-1).ToShortDateString(),
            specified_usage_type_no = 1,
            date_range_end = "",
            specified_usage_type_code = "",
            usage_qualifier_1 = new[]{new usage_qualifier_1_row()},
            usage_qualifier_2 = new[]{new usage_qualifier_2_row()},
            usage_qualifier_3 = new[]{new usage_qualifier_3_row()},
            usage_qualifier_4 = new[]{new usage_qualifier_4_row()}
            };

        var response = mService.get_usage_history(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_message()
    {
       get_acct_messageRequest request = new get_acct_messageRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            message_id = 1,
            acct_no = 1,
            do_encoding = ""
            };

        var response = mService.get_acct_message(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_message_size()
    {
       get_acct_message_sizeRequest request = new get_acct_message_sizeRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            message_id = 1,
            acct_no = 1,
            do_encoding = ""
            };

        var response = mService.get_acct_message_size(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void update_master_plan()
    {
       update_master_planRequest request = new update_master_planRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            master_plan_no = 1,
            alt_rate_schedule_no = 1,
            num_plan_units = 1,
            assignment_directive = 1,
            do_write = "",
            client_receipt_id = Guid.NewGuid().ToString(),
            force_currency_change = "",
            auto_cancel_supp_plans = "",
            offset_months = 1,
            alt_proration_start_date = "",
            alt_client_acct_group_id = "",
            new_acct_custom_rates = new[]{new new_acct_custom_rates_row()},
            effective_date = "",
            offset_interval = 1,
            invoice_unbilled_usage = "",
            coupon_code = ""
            };

        var response = mService.update_master_plan(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void update_acct_complete()
    {
       update_acct_completeRequest request = new update_acct_completeRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            first_name = "",
            last_name = "",
            middle_initial = "",
            company_name = "",
            address1 = "",
            address2 = "",
            city = "",
            locality = "",
            state_prov = "",
            country = "",
            postal_cd = "",
            phone = "",
            phone_ext = "",
            cell_phone = "",
            work_phone = "",
            work_phone_ext = "",
            email = "",
            birthdate = "",
            bill_first_name = "",
            bill_last_name = "",
            bill_middle_initial = "",
            bill_company_name = "",
            bill_address1 = "",
            bill_address2 = "",
            bill_city = "",
            bill_locality = "",
            bill_state_prov = "",
            bill_country = "",
            bill_postal_cd = "",
            bill_phone = "",
            bill_phone_ext = "",
            bill_cell_phone = "",
            bill_work_phone = "",
            bill_work_phone_ext = "",
            bill_email = "",
            pay_method = "5",
            cc_number = "4111111111111111",
            cc_expire_mm = DateTime.Now.Month,
            cc_expire_yyyy = DateTime.Now.Year,
            bank_routing_num = "",
            bank_acct_num = "",
            master_plan_no = 1,
            master_plan_alt_rate_sched_no = 1,
            master_plan_units = 1,
            master_plan_assign_directive = 1,
            update_acct_supp_field = new[]{new update_acct_supp_field_row()},
            update_acct_func_group = new[]{new update_acct_func_group_row()},
            update_acct_coll_group = new[]{new update_acct_coll_group_row()},
            status_cd = 1,
            notify_method = 1,
            password = Password,
            secret_question = "",
            secret_question_answer = "",
            pin = "",
            test_acct_ind = 1,
            resp_level_cd = 1,
            senior_acct_no = 1,
            client_acct_id = "",
            do_collect = "",
            change_status_after_coll = "",
            reset_dates_after_status = "y",
            client_receipt_id = Guid.NewGuid().ToString(),
            alt_do_dunning = "",
            force_currency_change = "",
            cvv = "",
            taxpayer_id = "",
            bill_agreement_id = "",
            auto_cancel_supp_plans = "",
            offset_months = 1,
            alt_proration_start_date = "",
            alt_msg_template_no = 1,
            seq_func_group_no = 1,
            address3 = "",
            bill_address3 = "",
            usage_accumulation_config = new[]{new usage_accumulation_config_row()},
            enable_usage_pooling_plan_no = new[]{new enable_usage_pooling_plan_no_row()},
            disable_usage_pooling_plan_no = new[]{new disable_usage_pooling_plan_no_row()},
            alt_client_acct_group_id = "",
            track_data1 = "",
            track_data2 = "",
            offset_interval = 1,
            tax_exemption_level = 1,
            cn_alt_msg_template_no = 1,
            promo_cd = "",
            invoice_unbilled_usage = "",
            coupon_code = ""
            };

        var response = mService.update_acct_complete(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_all_acct_receipt_ids()
    {
       get_all_acct_receipt_idsRequest request = new get_all_acct_receipt_idsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            start_date_range = DateTime.Now.AddMonths(-1).ToShortDateString(),
            end_date_range = ""
            };

        var response = mService.get_all_acct_receipt_ids(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void send_arc_threshold_email()
    {
       send_arc_threshold_emailRequest request = new send_arc_threshold_emailRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            resource_threshold_level = 1,
            resource_balance = 1,
            resource_name = "",
            resource_units_label = ""
            };

        var response = mService.send_arc_threshold_email(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void set_acct_tax_exempt_status()
    {
       set_acct_tax_exempt_statusRequest request = new set_acct_tax_exempt_statusRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            exemption_level = 1
            };

        var response = mService.set_acct_tax_exempt_status(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_tax_exempt_status()
    {
       get_acct_tax_exempt_statusRequest request = new get_acct_tax_exempt_statusRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1
            };

        var response = mService.get_acct_tax_exempt_status(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void close_acct_installation()
    {
       close_acct_installationRequest request = new close_acct_installationRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            install_complete_ind = "",
            comments = ""
            };

        var response = mService.close_acct_installation(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_unapplied_service_credits()
    {
       get_unapplied_service_creditsRequest request = new get_unapplied_service_creditsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1
            };

        var response = mService.get_unapplied_service_credits(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_recurring_credit_info()
    {
       get_recurring_credit_infoRequest request = new get_recurring_credit_infoRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            filter_credit_no = 1
            };

        var response = mService.get_recurring_credit_info(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_pending_invoice_no()
    {
       get_pending_invoice_noRequest request = new get_pending_invoice_noRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1
            };

        var response = mService.get_pending_invoice_no(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void remove_pay_method()
    {
       remove_pay_methodRequest request = new remove_pay_methodRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1
            };

        var response = mService.remove_pay_method(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void assign_custom_acct_rates()
    {
       assign_custom_acct_ratesRequest request = new assign_custom_acct_ratesRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            plan_no = PlanNumber,
            service_no = ServiceNumber,
            custom_acct_rates = new[]{new custom_acct_rates_row()}
            };

        var response = mService.assign_custom_acct_rates(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_accts_with_existing_pay_method()
    {
       get_accts_with_existing_pay_methodRequest request = new get_accts_with_existing_pay_methodRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            pay_method = "5",
            form_payment_acct_id = "",
            bank_routing_num = ""
            };

        var response = mService.get_accts_with_existing_pay_method(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void adjust_billing_dates()
    {
       adjust_billing_datesRequest request = new adjust_billing_datesRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            action_directive = 1,
            adjustment_days = 1,
            comments = ""
            };

        var response = mService.adjust_billing_dates(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void write_acct_comment()
    {
       write_acct_commentRequest request = new write_acct_commentRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            comment = ""
            };

        var response = mService.write_acct_comment(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_comments()
    {
       get_acct_commentsRequest request = new get_acct_commentsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            date_range_start = DateTime.Now.AddMonths(-1).ToShortDateString(),
            date_range_end = "",
            do_url_encoding = ""
            };

        var response = mService.get_acct_comments(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void modify_acct_supp_fields()
    {
       modify_acct_supp_fieldsRequest request = new modify_acct_supp_fieldsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            acct_supp_fields = new[]{new acct_supp_fields_row()}
            };

        var response = mService.modify_acct_supp_fields(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void remove_custom_acct_rates()
    {
       remove_custom_acct_ratesRequest request = new remove_custom_acct_ratesRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            plan_no = PlanNumber
            };

        var response = mService.remove_custom_acct_rates(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_statement_history()
    {
       get_acct_statement_historyRequest request = new get_acct_statement_historyRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            user_id = "",
            start_date = DateTime.Now.AddYears(15).ToShortDateString(),
            end_date = ""
            };

        var response = mService.get_acct_statement_history(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_invoice_history()
    {
       get_acct_invoice_historyRequest request = new get_acct_invoice_historyRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            user_id = "",
            start_bill_date = "",
            end_bill_date = "",
            include_voided = ""
            };

        var response = mService.get_acct_invoice_history(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_statement_content()
    {
       get_statement_contentRequest request = new get_statement_contentRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            statement_no = 1,
            do_encoding = ""
            };

        var response = mService.get_statement_content(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_statement_content_size()
    {
       get_statement_content_sizeRequest request = new get_statement_content_sizeRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            statement_no = 1,
            do_encoding = ""
            };

        var response = mService.get_statement_content_size(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_has_ordered_sku()
    {
       get_acct_has_ordered_skuRequest request = new get_acct_has_ordered_skuRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            sku = ""
            };

        var response = mService.get_acct_has_ordered_sku(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_userid_has_ordered_sku()
    {
       get_userid_has_ordered_skuRequest request = new get_userid_has_ordered_skuRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            user_id = "",
            sku = ""
            };

        var response = mService.get_userid_has_ordered_sku(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void assign_supp_plan_multi()
    {
       assign_supp_plan_multiRequest request = new assign_supp_plan_multiRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            supp_plans_to_assign = new[]{new supp_plans_to_assign_row()},
            assignment_directive = 1,
            do_write = "",
            comments = "",
            client_receipt_id = Guid.NewGuid().ToString(),
            alt_proration_start_date = "",
            coupon_codes = new[]{new coupon_codes_row()},
            effective_date = ""
            };

        var response = mService.assign_supp_plan_multi(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_payment_methods()
    {
       get_acct_payment_methodsRequest request = new get_acct_payment_methodsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            filter_seq_no = 1
            };

        var response = mService.get_acct_payment_methods(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void gen_statement()
    {
       gen_statementRequest request = new gen_statementRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            send_email = ""
            };

        var response = mService.gen_statement(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void cancel_unconsumed_credit()
    {
       cancel_unconsumed_creditRequest request = new cancel_unconsumed_creditRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            coupon_cd = ""
            };

        var response = mService.cancel_unconsumed_credit(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void cancel_unapplied_svce_credits()
    {
       cancel_unapplied_svce_creditsRequest request = new cancel_unapplied_svce_creditsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            credit_ids = new[]{new credit_ids_row()}
            };

        var response = mService.cancel_unapplied_svce_credits(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_balance()
    {
       get_acct_balanceRequest request = new get_acct_balanceRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1
            };

        var response = mService.get_acct_balance(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_unbilled_usage_summary()
    {
       get_unbilled_usage_summaryRequest request = new get_unbilled_usage_summaryRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1
            };

        var response = mService.get_unbilled_usage_summary(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void set_acct_usg_mtd_threshold()
    {
       set_acct_usg_mtd_thresholdRequest request = new set_acct_usg_mtd_thresholdRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            amount = 1
            };

        var response = mService.set_acct_usg_mtd_threshold(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void set_acct_usg_ptd_threshold()
    {
       set_acct_usg_ptd_thresholdRequest request = new set_acct_usg_ptd_thresholdRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            amount = 1
            };

        var response = mService.set_acct_usg_ptd_threshold(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void set_client_usg_mtd_threshold()
    {
       set_client_usg_mtd_thresholdRequest request = new set_client_usg_mtd_thresholdRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            amount = 1
            };

        var response = mService.set_client_usg_mtd_threshold(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void set_client_usg_ptd_threshold()
    {
       set_client_usg_ptd_thresholdRequest request = new set_client_usg_ptd_thresholdRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            amount = 1
            };

        var response = mService.set_client_usg_ptd_threshold(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void reset_usg_mtd_bal()
    {
       reset_usg_mtd_balRequest request = new reset_usg_mtd_balRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1
            };

        var response = mService.reset_usg_mtd_bal(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void reset_usg_ptd_bal()
    {
       reset_usg_ptd_balRequest request = new reset_usg_ptd_balRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1
            };

        var response = mService.reset_usg_ptd_bal(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_multiplan_contract()
    {
       get_acct_multiplan_contractRequest request = new get_acct_multiplan_contractRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            contract_no = 1
            };

        var response = mService.get_acct_multiplan_contract(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void create_acct_multiplan_contract()
    {
       create_acct_multiplan_contractRequest request = new create_acct_multiplan_contractRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            plan_no = new[]{new plan_no_row()},
            type_no = 1,
            length_months = 1,
            create_comments = "",
            start_date = DateTime.Now.AddYears(15).ToShortDateString(),
            do_auto_discard = "",
            end_date = ""
            };

        var response = mService.create_acct_multiplan_contract(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void modify_acct_multiplan_contract()
    {
       modify_acct_multiplan_contractRequest request = new modify_acct_multiplan_contractRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            contract_no = 1,
            type_no = 1,
            length_months = 1,
            start_date = DateTime.Now.AddYears(15).ToShortDateString(),
            update_comments = "",
            modify_directive = 1,
            plans_input = new[]{new plans_input_row()},
            end_date = ""
            };

        var response = mService.modify_acct_multiplan_contract(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void cancel_acct_multiplan_contract()
    {
       cancel_acct_multiplan_contractRequest request = new cancel_acct_multiplan_contractRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            contract_no = 1,
            update_comments = "",
            close_status = 1
            };

        var response = mService.cancel_acct_multiplan_contract(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_universal_contract()
    {
       get_acct_universal_contractRequest request = new get_acct_universal_contractRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1
            };

        var response = mService.get_acct_universal_contract(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void create_acct_universal_contract()
    {
       create_acct_universal_contractRequest request = new create_acct_universal_contractRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            type_no = 1,
            length_months = 1,
            create_comments = "",
            start_date = DateTime.Now.AddYears(15).ToShortDateString(),
            end_date = ""
            };

        var response = mService.create_acct_universal_contract(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void modify_acct_universal_contract()
    {
       modify_acct_universal_contractRequest request = new modify_acct_universal_contractRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            contract_no = 1,
            type_no = 1,
            length_months = 1,
            start_date = DateTime.Now.AddYears(15).ToShortDateString(),
            update_comments = "",
            end_date = ""
            };

        var response = mService.modify_acct_universal_contract(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void cancel_acct_universal_contract()
    {
       cancel_acct_universal_contractRequest request = new cancel_acct_universal_contractRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            update_comments = "",
            close_status = 1
            };

        var response = mService.cancel_acct_universal_contract(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_all_acct_active_contracts()
    {
       get_all_acct_active_contractsRequest request = new get_all_acct_active_contractsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1
            };

        var response = mService.get_all_acct_active_contracts(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_hierarchy_details()
    {
       get_acct_hierarchy_detailsRequest request = new get_acct_hierarchy_detailsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            hierarchy_filter = 1,
            include_current_acct = 1
            };

        var response = mService.get_acct_hierarchy_details(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_all_acct_contracts()
    {
       get_all_acct_contractsRequest request = new get_all_acct_contractsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            filter_status_code = 1
            };

        var response = mService.get_all_acct_contracts(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void set_acct_notify_override()
    {
       set_acct_notify_overrideRequest request = new set_acct_notify_overrideRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            template_class = "",
            acct_no = 1,
            acct_user_id = "",
            client_acct_id = "",
            override_template_no = 1,
            behavioral_option = 1,
            override_template_option = 1
            };

        var response = mService.set_acct_notify_override(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void set_acct_notify_tmplt_grp()
    {
       set_acct_notify_tmplt_grpRequest request = new set_acct_notify_tmplt_grpRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            notification_template_group_id = "",
            acct_no = 1,
            acct_user_id = "",
            client_acct_id = ""
            };

        var response = mService.set_acct_notify_tmplt_grp(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_notification_details()
    {
       get_acct_notification_detailsRequest request = new get_acct_notification_detailsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            acct_user_id = "",
            client_acct_id = ""
            };

        var response = mService.get_acct_notification_details(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_credits()
    {
       get_acct_creditsRequest request = new get_acct_creditsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            limit_records = 1
            };

        var response = mService.get_acct_credits(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_credit_details()
    {
       get_acct_credit_detailsRequest request = new get_acct_credit_detailsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            credit_no = 1
            };

        var response = mService.get_acct_credit_details(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_credit_reason_codes()
    {
       get_credit_reason_codesRequest request = new get_credit_reason_codesRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey
            };

        var response = mService.get_credit_reason_codes(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void save_paypal_bill_agreement()
    {
       save_paypal_bill_agreementRequest request = new save_paypal_bill_agreementRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            token = ""
            };

        var response = mService.save_paypal_bill_agreement(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void init_paypal_bill_agreement()
    {
       init_paypal_bill_agreementRequest request = new init_paypal_bill_agreementRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1
            };

        var response = mService.init_paypal_bill_agreement(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_service_outage_credit()
    {
       get_acct_service_outage_creditRequest request = new get_acct_service_outage_creditRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            outage_start_date = "",
            outage_end_date = "",
            outage_start_time = "",
            outage_end_time = "",
            plans_to_get_outage = new[]{new plans_to_get_outage_row()},
            adjust_percent = 1
            };

        var response = mService.get_acct_service_outage_credit(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_usage_summary_by_type()
    {
       get_usage_summary_by_typeRequest request = new get_usage_summary_by_typeRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            user_id = "",
            usage_type_filter = 1,
            date_filter_start_date = "",
            date_filter_start_time = "",
            date_filter_end_date = "",
            date_filter_end_time = "",
            billed_filter = 1,
            billing_period_flag = 1,
            usage_qualifier_1 = new[]{new usage_qualifier_1_row()},
            usage_qualifier_2 = new[]{new usage_qualifier_2_row()},
            usage_qualifier_3 = new[]{new usage_qualifier_3_row()},
            usage_qualifier_4 = new[]{new usage_qualifier_4_row()}
            };

        var response = mService.get_usage_summary_by_type(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_inv_no_from_bal_xfer()
    {
       get_inv_no_from_bal_xferRequest request = new get_inv_no_from_bal_xferRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            transaction_id = 1
            };

        var response = mService.get_inv_no_from_bal_xfer(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void void_transaction()
    {
       void_transactionRequest request = new void_transactionRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_no = AccountNumber,
            transaction_id = 1,
            reason_code = 1,
            comments = "",
            client_receipt_id = Guid.NewGuid().ToString()
            };

        var response = mService.void_transaction(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void reinstate_transaction()
    {
       reinstate_transactionRequest request = new reinstate_transactionRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_no = AccountNumber,
            transaction_id = 1,
            comments = ""
            };

        var response = mService.reinstate_transaction(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void transfer_account_balance()
    {
       transfer_account_balanceRequest request = new transfer_account_balanceRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            source_account_no = 1,
            target_account_no = 1,
            client_receipt_id = Guid.NewGuid().ToString()
            };

        var response = mService.transfer_account_balance(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void create_order()
    {
       create_orderRequest request = new create_orderRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_no = AccountNumber,
            bill_immediately = 1,
            order_line_items = new[]{new order_line_items_row()},
            bill_seq = 1,
            client_order_id = Guid.NewGuid().ToString(),
            client_receipt_id = Guid.NewGuid().ToString(),
            alt_pay_method = 1,
            cc_number = "4111111111111111",
            cc_expire_mm = DateTime.Now.Month,
            cc_expire_yyyy = DateTime.Now.Year,
            bank_routing_num = "",
            bank_acct_num = "",
            bill_company_name = "",
            bill_first_name = "",
            bill_middle_initial = "",
            bill_last_name = "",
            bill_address1 = "",
            bill_address2 = "",
            bill_city = "",
            bill_locality = "",
            bill_state_prov = "",
            bill_zip = "",
            bill_country = "",
            bill_email = "",
            bill_phone = "",
            bill_phone_extension = "",
            bill_cell_phone = "",
            bill_work_phone = "",
            bill_work_phone_extension = "",
            cvv = "",
            bill_address3 = "",
            do_write = "",
            coupon_cd = "",
            alt_client_acct_group_id = "",
            track_data1 = "",
            track_data2 = "",
            alt_inv_template_no = 1
            };

        var response = mService.create_order(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void settle_account_balance()
    {
       settle_account_balanceRequest request = new settle_account_balanceRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_no = AccountNumber,
            alt_pay_method = 1,
            cc_number = "4111111111111111",
            cc_expire_mm = DateTime.Now.Month,
            cc_expire_yyyy = DateTime.Now.Year,
            bank_routing_num = "",
            bank_acct_num = "",
            bill_company_name = "",
            bill_first_name = "",
            bill_middle_initial = "",
            bill_last_name = "",
            bill_address1 = "",
            bill_address2 = "",
            bill_city = "",
            bill_locality = "",
            bill_state_prov = "",
            bill_zip = "",
            bill_country = "",
            bill_email = "",
            bill_phone = "",
            bill_phone_extension = "",
            bill_cell_phone = "",
            bill_work_phone = "",
            bill_work_phone_extension = "",
            cvv = "",
            bill_address3 = "",
            alt_client_acct_group_id = "",
            track_data1 = "",
            track_data2 = "",
            force_balance_scope = "",
            client_receipt_id = Guid.NewGuid().ToString()
            };

        var response = mService.settle_account_balance(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void collect_from_account()
    {
       collect_from_accountRequest request = new collect_from_accountRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_no = AccountNumber,
            amount_to_collect = 1,
            bill_seq = 1,
            client_receipt_id = Guid.NewGuid().ToString(),
            specific_charge_transaction_id = new[]{new specific_charge_transaction_id_row()},
            alt_pay_method = 1,
            cc_number = "4111111111111111",
            cc_expire_mm = DateTime.Now.Month,
            cc_expire_yyyy = DateTime.Now.Year,
            bank_routing_num = "",
            bank_acct_num = "",
            bill_company_name = "",
            bill_first_name = "",
            bill_middle_initial = "",
            bill_last_name = "",
            bill_address1 = "",
            bill_address2 = "",
            bill_city = "",
            bill_locality = "",
            bill_state_prov = "",
            bill_zip = "",
            bill_country = "",
            bill_email = "",
            bill_phone = "",
            bill_phone_extension = "",
            bill_cell_phone = "",
            bill_work_phone = "",
            bill_work_phone_extension = "",
            cvv = "",
            bill_address3 = "",
            alt_client_acct_group_id = "",
            track_data1 = "",
            track_data2 = "",
            payment_application_method = 1
            };

        var response = mService.collect_from_account(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void record_external_payment()
    {
       record_external_paymentRequest request = new record_external_paymentRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_no = AccountNumber,
            payment_amount = 1,
            reference_code = Guid.NewGuid().ToString(),
            comments = "",
            client_receipt_id = Guid.NewGuid().ToString(),
            specific_charge_transaction_id = new[]{new specific_charge_transaction_id_row()},
            external_destination_id = 1,
            external_id = ""
            };

        var response = mService.record_external_payment(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void record_out_going_payment()
    {
       record_out_going_paymentRequest request = new record_out_going_paymentRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_no = AccountNumber,
            payment_amount = 1,
            reference_code = Guid.NewGuid().ToString(),
            comments = ""
            };

        var response = mService.record_out_going_payment(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void apply_service_credit()
    {
       apply_service_creditRequest request = new apply_service_creditRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_no = AccountNumber,
            credit_amount = 1,
            credit_reason_code = 1,
            comments = ""
            };

        var response = mService.apply_service_credit(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void apply_cash_credit()
    {
       apply_cash_creditRequest request = new apply_cash_creditRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_no = AccountNumber,
            credit_amount = 1,
            credit_reason_code = 1,
            comments = "",
            specific_charge_transaction_id = new[]{new specific_charge_transaction_id_row()},
            client_receipt_id = Guid.NewGuid().ToString()
            };

        var response = mService.apply_cash_credit(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void record_standing_order()
    {
       record_standing_orderRequest request = new record_standing_orderRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_no = AccountNumber,
            billing_interval_units = 1,
            times_to_bill = 1,
            billing_interval_type = "",
            first_bill_date = DateTime.Now.AddYears(15).ToShortDateString(),
            standing_order = new[]{new standing_order_row()},
            client_order_id = Guid.NewGuid().ToString(),
            client_receipt_id = Guid.NewGuid().ToString()
            };

        var response = mService.record_standing_order(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void cancel_standing_order()
    {
       cancel_standing_orderRequest request = new cancel_standing_orderRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            standing_order_no = 1
            };

        var response = mService.cancel_standing_order(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void move_payment()
    {
       move_paymentRequest request = new move_paymentRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            account_no = AccountNumber,
            payment_id = 1,
            specific_charge_transaction_id = new[]{new specific_charge_transaction_id_row()}
            };

        var response = mService.move_payment(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void bulk_record_usage()
    {
       bulk_record_usageRequest request = new bulk_record_usageRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            usage_records = new[]{new usage_records_row()}
            };

        var response = mService.bulk_record_usage(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void record_usage()
    {
       record_usageRequest request = new record_usageRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            usage_units = 1,
            acct_no = 1,
            userid = UserId,
            usage_type = 1,
            usage_date = "",
            billable_units = 1,
            amt = 1,
            rate = 1,
            telco_from = "",
            telco_to = "",
            comments = "",
            exclude_from_billing = "",
            exclusion_comments = "",
            qualifier_1 = "",
            qualifier_2 = "",
            qualifier_3 = "",
            qualifier_4 = "",
            parent_usage_rec_no = 1,
            usage_type_code = "",
            client_record_id = "",
            caller_id = ""
            };

        var response = mService.record_usage(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_order()
    {
       get_orderRequest request = new get_orderRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            my_order_no = 1,
            my_client_order_id = "",
            limit_records = 1,
            details_flag = 1
            };

        var response = mService.get_order(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_standing_order()
    {
       get_standing_orderRequest request = new get_standing_orderRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            my_standing_order = 1,
            my_client_order_id = ""
            };

        var response = mService.get_standing_order(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_standing_order_items()
    {
       get_standing_order_itemsRequest request = new get_standing_order_itemsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            standing_order_no = 1
            };

        var response = mService.get_standing_order_items(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_standing_order_hist()
    {
       get_standing_order_histRequest request = new get_standing_order_histRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            standing_order_no = 1
            };

        var response = mService.get_standing_order_hist(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void pre_calc_invoice()
    {
       pre_calc_invoiceRequest request = new pre_calc_invoiceRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            log_id = "",
            first_name = "",
            mi = "",
            last_name = "",
            address1 = "",
            address2 = "",
            city = "",
            state_prov_code = "",
            zip_code = "",
            country_code = "",
            currency_code = "",
            pre_calc_plan = new[]{new pre_calc_plan_row()},
            pre_calc_sku = new[]{new pre_calc_sku_row()},
            tax_exempt_cd = 1,
            address3 = ""
            };

        var response = mService.pre_calc_invoice(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_order_items()
    {
       get_order_itemsRequest request = new get_order_itemsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            order_no = 1
            };

        var response = mService.get_order_items(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void gen_invoice()
    {
       gen_invoiceRequest request = new gen_invoiceRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            force_pending = "",
            client_receipt_id = Guid.NewGuid().ToString(),
            alt_bill_day = 1
            };

        var response = mService.gen_invoice(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_preview_statement()
    {
       get_acct_preview_statementRequest request = new get_acct_preview_statementRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1
            };

        var response = mService.get_acct_preview_statement(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_statement_for_invoice()
    {
       get_statement_for_invoiceRequest request = new get_statement_for_invoiceRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            invoice_no = 1,
            do_encoding = ""
            };

        var response = mService.get_statement_for_invoice(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_statement_for_inv_size()
    {
       get_statement_for_inv_sizeRequest request = new get_statement_for_inv_sizeRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            invoice_no = 1,
            do_encoding = ""
            };

        var response = mService.get_statement_for_inv_size(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_invoice_details()
    {
       get_invoice_detailsRequest request = new get_invoice_detailsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            src_transaction_id = 1
            };

        var response = mService.get_invoice_details(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_payments_on_invoice()
    {
       get_payments_on_invoiceRequest request = new get_payments_on_invoiceRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            src_transaction_id = 1
            };

        var response = mService.get_payments_on_invoice(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_payment_applications()
    {
       get_payment_applicationsRequest request = new get_payment_applicationsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            src_transaction_id = 1
            };

        var response = mService.get_payment_applications(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_all_actions_by_receipt_id()
    {
       get_all_actions_by_receipt_idRequest request = new get_all_actions_by_receipt_idRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            client_receipt_id = Guid.NewGuid().ToString()
            };

        var response = mService.get_all_actions_by_receipt_id(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void manage_pending_invoice()
    {
       manage_pending_invoiceRequest request = new manage_pending_invoiceRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            invoice_no = 1,
            acct_no = 1,
            action_directive = 1,
            bill_seq = 1,
            alt_pay_method = 1,
            cc_number = "4111111111111111",
            cc_expire_mm = DateTime.Now.Month,
            cc_expire_yyyy = DateTime.Now.Year,
            bank_routing_num = "",
            bank_acct_num = "",
            bill_company_name = "",
            bill_first_name = "",
            bill_middle_initial = "",
            bill_last_name = "",
            bill_address1 = "",
            bill_address2 = "",
            bill_city = "",
            bill_locality = "",
            bill_state_prov = "",
            bill_zip = "",
            bill_country = "",
            bill_email = "",
            bill_phone = "",
            bill_phone_extension = "",
            bill_cell_phone = "",
            bill_work_phone = "",
            bill_work_phone_extension = "",
            cvv = "",
            alt_collect_on_approve = "",
            alt_send_statement_on_approve = "",
            cancel_orders_on_discard = "",
            bill_address3 = "",
            track_data1 = "",
            track_data2 = "",
            client_receipt_id = Guid.NewGuid().ToString()
            };

        var response = mService.manage_pending_invoice(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void cancel_order()
    {
       cancel_orderRequest request = new cancel_orderRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            order_no = 1
            };

        var response = mService.cancel_order(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_refund_details()
    {
       get_refund_detailsRequest request = new get_refund_detailsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            include_voided = "",
            aria_event_no = 1
            };

        var response = mService.get_refund_details(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void create_order_with_plans()
    {
       create_order_with_plansRequest request = new create_order_with_plansRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            order_line_items = new[]{new order_line_items_row()},
            cart_supp_plans = new[]{new cart_supp_plans_row()},
            client_order_id = Guid.NewGuid().ToString(),
            coupon_code = "",
            comments = "",
            do_write = "",
            client_receipt_id = Guid.NewGuid().ToString(),
            bill_seq = 1,
            alt_pay_method = 1,
            cc_number = "4111111111111111",
            cc_expire_mm = DateTime.Now.Month,
            cc_expire_yyyy = DateTime.Now.Year,
            bank_routing_num = "",
            bank_acct_num = "",
            bill_company_name = "",
            bill_first_name = "",
            bill_middle_initial = "",
            bill_last_name = "",
            bill_address1 = "",
            bill_address2 = "",
            bill_city = "",
            bill_locality = "",
            bill_state_prov = "",
            bill_zip = "",
            bill_country = "",
            bill_email = "",
            bill_phone = "",
            bill_phone_extension = "",
            bill_cell_phone = "",
            bill_work_phone = "",
            bill_work_phone_extension = "",
            cvv = "",
            bill_address3 = "",
            track_data1 = "",
            track_data2 = "",
            alt_inv_template_no = 1
            };

        var response = mService.create_order_with_plans(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_refundable_payments()
    {
       get_refundable_paymentsRequest request = new get_refundable_paymentsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1
            };

        var response = mService.get_refundable_payments(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_reversible_invs_by_payment()
    {
       get_reversible_invs_by_paymentRequest request = new get_reversible_invs_by_paymentRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            payment_transaction_id = 1
            };

        var response = mService.get_reversible_invs_by_payment(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void issue_refund_to_acct()
    {
       issue_refund_to_acctRequest request = new issue_refund_to_acctRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            payment_transaction_id = 1,
            reason_code = 1,
            total_refund_amount = 1,
            refund_check_number = "",
            comments = "",
            do_write = "",
            auto_calc_refund = "",
            invoices_to_reverse = new[]{new invoices_to_reverse_row()},
            client_receipt_id = Guid.NewGuid().ToString()
            };

        var response = mService.issue_refund_to_acct(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void update_refund_check_no()
    {
       update_refund_check_noRequest request = new update_refund_check_noRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            transaction_id = 1,
            refund_check_number = 1,
            acct_no = 1,
            acct_user_id = "",
            client_acct_id = ""
            };

        var response = mService.update_refund_check_no(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_writeoff_details()
    {
       get_writeoff_detailsRequest request = new get_writeoff_detailsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            aria_event_no = 1
            };

        var response = mService.get_writeoff_details(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_aria_xml_statement()
    {
       get_aria_xml_statementRequest request = new get_aria_xml_statementRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            xml_statement_no = 1
            };

        var response = mService.get_aria_xml_statement(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_payment_history()
    {
       get_acct_payment_historyRequest request = new get_acct_payment_historyRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            start_date = DateTime.Now.AddYears(15).ToShortDateString(),
            end_date = "",
            limit_records = 1,
            details_flag = 1
            };

        var response = mService.get_acct_payment_history(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_payment_application_dtls()
    {
       get_payment_application_dtlsRequest request = new get_payment_application_dtlsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            transaction_id = 1
            };

        var response = mService.get_payment_application_dtls(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_extended_transaction_info()
    {
       get_extended_transaction_infoRequest request = new get_extended_transaction_infoRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            transaction_id = 1
            };

        var response = mService.get_extended_transaction_info(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void discard_usage()
    {
       discard_usageRequest request = new discard_usageRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            usage_record_nos = new[]{new usage_record_nos_row()},
            client_record_ids = new[]{new client_record_ids_row()},
            exclusion_reason_cd = 1,
            exclusion_comment = ""
            };

        var response = mService.discard_usage(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void create_writeoff_or_dispute()
    {
       create_writeoff_or_disputeRequest request = new create_writeoff_or_disputeRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            invoice_no = 1,
            amount = 1,
            reason_code = 1,
            comments = "",
            do_dispute = 1,
            client_receipt_id = Guid.NewGuid().ToString()
            };

        var response = mService.create_writeoff_or_dispute(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_acct_writeoff_or_disputes()
    {
       get_acct_writeoff_or_disputesRequest request = new get_acct_writeoff_or_disputesRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            dispute_or_writeoff_flag = 1,
            details_flag = 1
            };

        var response = mService.get_acct_writeoff_or_disputes(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_invoices_to_writeoff_or_dispute()
    {
       get_invoices_to_writeoff_or_disputeRequest request = new get_invoices_to_writeoff_or_disputeRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1
            };

        var response = mService.get_invoices_to_writeoff_or_dispute(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void settle_dispute_hold()
    {
       settle_dispute_holdRequest request = new settle_dispute_holdRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            acct_no = 1,
            dispute_no = 1,
            settlement_action = 1,
            comments = "",
            client_receipt_id = Guid.NewGuid().ToString()
            };

        var response = mService.settle_dispute_hold(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void set_session_auth()
    {
       set_session_authRequest request = new set_session_authRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            user_id = "",
            password = Password
            };

        var response = mService.set_session_auth(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void set_session()
    {
       set_sessionRequest request = new set_sessionRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            user_id = "",
            acct_no = 1
            };

        var response = mService.set_session(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void validate_session()
    {
       validate_sessionRequest request = new validate_sessionRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            session_id = ""
            };

        var response = mService.validate_session(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void keep_alive()
    {
       keep_aliveRequest request = new keep_aliveRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            session_id = ""
            };

        var response = mService.keep_alive(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void kill_session()
    {
       kill_sessionRequest request = new kill_sessionRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            session_id = ""
            };

        var response = mService.kill_session(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void authenticate_caller()
    {
       authenticate_callerRequest request = new authenticate_callerRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey
            };

        var response = mService.authenticate_caller(request);
        Assert.IsNotNull(response);
    }

    #endregion Api Calls TEST
    }
}