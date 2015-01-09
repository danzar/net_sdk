
using System;
using NUnit.Framework;
using System.Configuration;
using Aria.SDK.AriaServices.AriaWebServices;
using Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools;

namespace Aria.SDK.AriaServices.AriaRestServices.Test
{
  [TestFixture]
  public class AriaAdminToolsTest
  {
    private const string ARIA_CLIENT_NUMBER = "aria-client-number";
    private const string ARIA_AUTHORIZATION_KEY = "aria-authorization-key";
    private const string ARIA_DISPATCHER_URL = "aria-admin-tools-dispatcher-url";
    private const string VALID_ACCOUNT_NUMBER = "valid-account-number";
    private const string VALID_ACCOUNT_USERID = "valid-account-userid";
    private const string VALID_ACCOUNT_PASSWORD = "valid-account-password";
    private const string VALID_PLAN_NUMBER = "valid-plan-number";
    private const string VALID_PLAN_SERVICE_NUMBER = "valid-plan-service-number";
    private const string VALID_SUPPLEMENTAL_PLAN_NUMBER = "valid-supplemental-plan-number";
    private const string VALID_PROMO_CODE = "valid-promo-code";
    private const string VALID_SUPPLEMENTAL_FIELD_NAME = "valid-supplemental-field-name";
    public static AriaBillingAdminTools mService;

    [TestFixtureSetUp]
    public void setUp()
    {
        //mService = new AriaBillingAdminTools(ConfigurationManager.AppSettings[ARIA_DISPATCHER_URL]);
        mService = new AriaBillingAdminTools();
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
    public void get_promo_plan_sets()
    {
       get_promo_plan_setsRequest request = new get_promo_plan_setsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey
            };

        var response = mService.get_promo_plan_sets(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_promo_plan_set_details()
    {
       get_promo_plan_set_detailsRequest request = new get_promo_plan_set_detailsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            promo_plan_set_no = 1,
            client_plan_type_id = ""
            };

        var response = mService.get_promo_plan_set_details(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void create_promo_plan_set()
    {
       create_promo_plan_setRequest request = new create_promo_plan_setRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            promo_plan_set_name = "",
            promo_plan_set_desc = "",
            client_plan_type_id = "",
            plan_no = PlanNumber.ToString(),
            client_plan_id = ""
            };

        var response = mService.create_promo_plan_set(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void update_promo_plan_set()
    {
       update_promo_plan_setRequest request = new update_promo_plan_setRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            promo_plan_set_no = 1,
            promo_plan_set_name = "",
            promo_plan_set_desc = "",
            client_plan_type_id = "",
            plan_no = PlanNumber.ToString(),
            client_plan_id = ""
            };

        var response = mService.update_promo_plan_set(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void list_promo_sets()
    {
       list_promo_setsRequest request = new list_promo_setsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey
            };

        var response = mService.list_promo_sets(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_company_profile()
    {
       get_company_profileRequest request = new get_company_profileRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey
            };

        var response = mService.get_company_profile(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void set_company_profile()
    {
       set_company_profileRequest request = new set_company_profileRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            domain = "",
            address1 = "",
            address2 = "",
            city = "",
            locality = "",
            state_prov = "",
            country = "",
            postal_code = "",
            phone = "",
            contact = "",
            contact_address1 = "",
            contact_address2 = "",
            contact_city = "",
            contact_state = "",
            contact_zip = "",
            contact_phone = "",
            contact_email = "",
            billing_contact = "",
            billing_address1 = "",
            billing_address2 = "",
            billing_city = "",
            billing_state = "",
            billing_zip = "",
            billing_phone = "",
            billing_email = "",
            contact_country = "",
            contact_locality = "",
            billing_country = "",
            billing_locality = ""
            };

        var response = mService.set_company_profile(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_inventory_items()
    {
       get_inventory_itemsRequest request = new get_inventory_itemsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey
            };

        var response = mService.get_inventory_items(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_inventory_item_details()
    {
       get_inventory_item_detailsRequest request = new get_inventory_item_detailsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            item_no = 1,
            client_item_id = "",
            currency_cd = ""
            };

        var response = mService.get_inventory_item_details(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void create_inventory_item()
    {
       create_inventory_itemRequest request = new create_inventory_itemRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            item_type = 1,
            item_name = "",
            item_desc = "",
            service = new[]{new service_row()},
            client_sku = "",
            currency_cd = "",
            item_price = "",
            client_item_id = "",
            active_ind = 1,
            invoice_advancement_months = 1,
            plan_no = PlanNumber,
            client_plan_id = "",
            tax_inclusive_ind = true,
            modify_price_ind = "",
            subunit_qty = 1,
            subunit_label = "",
            days_to_expiry = 1,
            resource_type_no = "",
            resource_units = "",
            stock_level_track = 1,
            stock_level_adjust = 1,
            image = new[]{new image_row()},
            parent_class = new[]{new parent_class_row()},
            supplemental_obj_field = new[]{new supplemental_obj_field_row()}
            };

        var response = mService.create_inventory_item(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void update_inventory_item()
    {
       update_inventory_itemRequest request = new update_inventory_itemRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            item_no = "",
            item_name = "",
            item_desc = "",
            client_item_id = "",
            service_no = ServiceNumber,
            client_service_id = "",
            currency_cd = "",
            item_price = "",
            active_ind = 1,
            invoice_advancement_months = 1,
            plan_no = PlanNumber,
            client_plan_id = "",
            modify_price_ind = "",
            subunit_qty = 1,
            subunit_label = "",
            days_to_expiry = 1,
            resource_type_no = "",
            resource_units = "",
            stock_level_track = 1,
            stock_level_adjust = 1,
            image = new[]{new image_row()},
            parent_class = new[]{new parent_class_row()},
            supplemental_obj_field = new[]{new supplemental_obj_field_row()}
            };

        var response = mService.update_inventory_item(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void create_item_class()
    {
       create_item_classRequest request = new create_item_classRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            class_name = "",
            class_desc = "",
            active_ind = 1,
            client_inventory_class_id = "",
            parent_class = new[]{new parent_class_row()}
            };

        var response = mService.create_item_class(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void edit_item_class()
    {
       edit_item_classRequest request = new edit_item_classRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            class_no = "",
            class_name = "",
            client_inventory_class_id = "",
            class_desc = "",
            active_ind = 1,
            parent_class = new[]{new parent_class_row()}
            };

        var response = mService.edit_item_class(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_service_types()
    {
       get_service_typesRequest request = new get_service_typesRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey
            };

        var response = mService.get_service_types(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_services()
    {
       get_servicesRequest request = new get_servicesRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey
            };

        var response = mService.get_services(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_service_details()
    {
       get_service_detailsRequest request = new get_service_detailsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            service_no = ServiceNumber,
            client_service_id = ""
            };

        var response = mService.get_service_details(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_plan_service_details()
    {
       get_plan_service_detailsRequest request = new get_plan_service_detailsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            service_no = ServiceNumber,
            client_service_id = "",
            plan_no = PlanNumber,
            client_plan_id = ""
            };

        var response = mService.get_plan_service_details(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void create_service()
    {
       create_serviceRequest request = new create_serviceRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            service_name = "",
            service_type = "",
            gl_cd = "",
            taxable_ind = "",
            tax_group = "",
            usage_type = "",
            client_service_id = "",
            supplemental_obj_field = new[]{new supplemental_obj_field_row()}
            };

        var response = mService.create_service(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void update_service()
    {
       update_serviceRequest request = new update_serviceRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            service_no = ServiceNumber,
            service_name = "",
            service_type = "",
            client_service_id = "",
            gl_cd = "",
            taxable_ind = "",
            tax_group = "",
            usage_type = ""
            };

        var response = mService.update_service(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_supp_fields()
    {
       get_supp_fieldsRequest request = new get_supp_fieldsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey
            };

        var response = mService.get_supp_fields(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_supp_field_details()
    {
       get_supp_field_detailsRequest request = new get_supp_field_detailsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            field_name = SupplementalFieldName
            };

        var response = mService.get_supp_field_details(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void create_supp_field()
    {
       create_supp_fieldRequest request = new create_supp_fieldRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            field_name = SupplementalFieldName,
            field_order = 1,
            presentation_mode = "",
            field_desc = "",
            required_ind = 1,
            hidden_ind = 1,
            sel_ind = 1,
            min_no_sel = 1,
            max_no_sel = 1,
            display_text = "",
            option_value = "",
            option_value_order = 1
            };

        var response = mService.create_supp_field(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void update_supp_field()
    {
       update_supp_fieldRequest request = new update_supp_fieldRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            field_name = SupplementalFieldName,
            field_desc = "",
            field_order = 1,
            required_ind = 1,
            hidden_ind = 1,
            sel_ind = 1,
            presentation_mode = "",
            min_no_sel = 1,
            max_no_sel = 1,
            display_text = "",
            option_value = "",
            option_value_order = 1
            };

        var response = mService.update_supp_field(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_coupons()
    {
       get_couponsRequest request = new get_couponsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey
            };

        var response = mService.get_coupons(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_coupon_details()
    {
       get_coupon_detailsRequest request = new get_coupon_detailsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            coupon_cd = ""
            };

        var response = mService.get_coupon_details(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void create_coupon()
    {
       create_couponRequest request = new create_couponRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            coupon_cd = "",
            status_ind = 1,
            start_date = DateTime.Now.AddYears(15).ToShortDateString(),
            end_date = "",
            coupon_desc = "",
            coupon_msg = "",
            no_of_uses = 1,
            template = new[]{new template_row()},
            existing_template = new[]{new existing_template_row()},
            existing_template_id = new[]{new existing_template_id_row()},
            discount_rule = new[]{new discount_rule_row()},
            existing_discount_rule = new[]{new existing_discount_rule_row()},
            existing_discount_rule_id = new[]{new existing_discount_rule_id_row()},
            discount_bundle = new[]{new discount_bundle_row()},
            existing_discount_bundle = new[]{new existing_discount_bundle_row()},
            existing_discount_bundle_id = new[]{new existing_discount_bundle_id_row()}
            };

        var response = mService.create_coupon(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void update_coupon()
    {
       update_couponRequest request = new update_couponRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            coupon_cd = "",
            status_ind = 1,
            start_date = DateTime.Now.AddYears(15).ToShortDateString(),
            end_date = "",
            coupon_desc = "",
            coupon_msg = "",
            no_of_uses = 1,
            template = new[]{new template_row()},
            existing_template = new[]{new existing_template_row()},
            existing_template_id = new[]{new existing_template_id_row()},
            discount_rule = new[]{new discount_rule_row()},
            existing_discount_rule = new[]{new existing_discount_rule_row()},
            existing_discount_rule_id = new[]{new existing_discount_rule_id_row()},
            discount_bundle = new[]{new discount_bundle_row()},
            existing_discount_bundle = new[]{new existing_discount_bundle_row()},
            existing_discount_bundle_id = new[]{new existing_discount_bundle_id_row()}
            };

        var response = mService.update_coupon(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void delete_coupons()
    {
       delete_couponsRequest request = new delete_couponsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            coupon_nos = new[]{new coupon_nos_row()}
            };

        var response = mService.delete_coupons(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_recurring_credit_templates()
    {
       get_recurring_credit_templatesRequest request = new get_recurring_credit_templatesRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey
            };

        var response = mService.get_recurring_credit_templates(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_recurring_credit_template_details()
    {
       get_recurring_credit_template_detailsRequest request = new get_recurring_credit_template_detailsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            credit_template_no = 1,
            client_credit_template_id = ""
            };

        var response = mService.get_recurring_credit_template_details(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void create_credit_template()
    {
       create_credit_templateRequest request = new create_credit_templateRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            credit_template_name = "",
            discount_type = 1,
            discount_amt = 1,
            no_of_credits = 1,
            credit_interval_months = 1,
            eligible_plan_no = 1,
            eligible_client_plan_id = "",
            eligible_service_no = 1,
            eligible_client_service_id = "",
            eligible_service_types = new[]{new eligible_service_types_row()},
            percentage_plan_no = 1,
            percentage_client_plan_id = "",
            percentage_service_no = 1,
            percentage_client_service_id = "",
            alt_service_no = 1,
            alt_client_service_id = "",
            client_credit_template_id = "",
            coupon = new[]{new coupon_row()},
            existing_coupon = new[]{new existing_coupon_row()}
            };

        var response = mService.create_credit_template(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void update_credit_template()
    {
       update_credit_templateRequest request = new update_credit_templateRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            credit_template_no = "",
            credit_template_name = "",
            discount_type = 1,
            discount_amt = 1,
            no_of_credits = 1,
            credit_interval_months = 1,
            client_credit_template_id = "",
            eligible_plan_no = 1,
            eligible_client_plan_id = "",
            eligible_service_no = 1,
            eligible_client_service_id = "",
            eligible_service_types = new[]{new eligible_service_types_row()},
            percentage_plan_no = 1,
            percentage_client_plan_id = "",
            percentage_service_no = 1,
            percentage_client_service_id = "",
            alt_service_no = 1,
            alt_client_service_id = "",
            coupon = new[]{new coupon_row()},
            existing_coupon = new[]{new existing_coupon_row()}
            };

        var response = mService.update_credit_template(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void delete_templates()
    {
       delete_templatesRequest request = new delete_templatesRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            template_nos = new[]{new template_nos_row()}
            };

        var response = mService.delete_templates(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void create_discount_rule()
    {
       create_discount_ruleRequest request = new create_discount_ruleRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            label = "",
            rule_id = "",
            description = "",
            ext_description = "",
            flat_percent_ind = 1,
            amount = 1,
            currency = "",
            duration_type_ind = "",
            inline_offset_ind = "",
            service_code_to_use = 1,
            scope_no = 1,
            max_applicable_months = 1,
            max_applications_per_acct = 1,
            alt_service_no_2_apply = 1,
            alt_service_id_2_apply = "",
            applicable_trans_scope = "",
            plan_no = new[]{new plan_no_row()},
            client_plan_id = new[]{new client_plan_id_row()},
            service_no = new[]{new service_no_row()},
            client_service_id = new[]{new client_service_id_row()},
            item_no = new[]{new item_no_row()},
            client_item_id = new[]{new client_item_id_row()},
            use_all_or_nth_subs_rule = ""
            };

        var response = mService.create_discount_rule(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void create_discount_bundle()
    {
       create_discount_bundleRequest request = new create_discount_bundleRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            bundle_name = "",
            bundle_id = "",
            bundle_description = "",
            allow_overlap_ind = "",
            rules = new[]{new rules_row()},
            rule_ids = new[]{new rule_ids_row()}
            };

        var response = mService.create_discount_bundle(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_discount_bundles()
    {
       get_discount_bundlesRequest request = new get_discount_bundlesRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey
            };

        var response = mService.get_discount_bundles(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_discount_bundle_details()
    {
       get_discount_bundle_detailsRequest request = new get_discount_bundle_detailsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            bundle_no = 1,
            bundle_id = ""
            };

        var response = mService.get_discount_bundle_details(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_discount_rules()
    {
       get_discount_rulesRequest request = new get_discount_rulesRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey
            };

        var response = mService.get_discount_rules(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_discount_rule_details()
    {
       get_discount_rule_detailsRequest request = new get_discount_rule_detailsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            rule_no = 1,
            client_rule_id = ""
            };

        var response = mService.get_discount_rule_details(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void delete_rules()
    {
       delete_rulesRequest request = new delete_rulesRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            rule_nos = new[]{new rule_nos_row()}
            };

        var response = mService.delete_rules(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void delete_bundles()
    {
       delete_bundlesRequest request = new delete_bundlesRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            bundle_nos = new[]{new bundle_nos_row()}
            };

        var response = mService.delete_bundles(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_plans()
    {
       get_plansRequest request = new get_plansRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey
            };

        var response = mService.get_plans(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_plan_details()
    {
       get_plan_detailsRequest request = new get_plan_detailsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            plan_no = PlanNumber,
            client_plan_id = ""
            };

        var response = mService.get_plan_details(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void create_new_plan()
    {
       create_new_planRequest request = new create_new_planRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            plan_name = "",
            plan_description = "",
            plan_type = "",
            currency = "",
            billing_interval = "",
            client_plan_id = "",
            plan_group = new[]{new plan_group_row()},
            plan_group_id = new[]{new plan_group_id_row()},
            usage_billing_interval = "",
            active = 1,
            rollover_months = "",
            rollover_plan_no = 1,
            rollover_client_plan_id = "",
            initial_free_months = 1,
            acct_status_cd = 1,
            rollover_status_days = 1,
            rollover_status_cd = 1,
            dunning_plan_no = 1,
            dunning_client_plan_id = "",
            template_no = 1,
            client_email_template_id = "",
            apply_cancellation = "",
            plan_cancel_min_month = 1,
            apply_minimum_fee = "",
            how_to_apply_minimum_fee = "",
            schedule = new[]{new schedule_row()},
            service = new[]{new service_row()},
            resource = new[]{new resource_row()},
            arc_service_no = 1,
            parent_plans = new[]{new parent_plans_row()},
            parent_client_plan_ids = new[]{new parent_client_plan_ids_row()},
            exclusion_plans = new[]{new exclusion_plans_row()},
            supplemental_obj_field = new[]{new supplemental_obj_field_row()},
            template_ind = true,
            child_plans = new[]{new child_plans_row()},
            notification_template_group_no = "",
            credit_note_template_no = "",
            surcharge_no = new[]{new surcharge_no_row()},
            client_surcharge_id = new[]{new client_surcharge_id_row()}
            };

        var response = mService.create_new_plan(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void edit_plan()
    {
       edit_planRequest request = new edit_planRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            plan_no = PlanNumber.ToString(),
            plan_name = "",
            client_plan_id = "",
            plan_type = 1,
            billing_interval = "",
            currency = "",
            plan_description = "",
            plan_group = new[]{new plan_group_row()},
            plan_group_id = new[]{new plan_group_id_row()},
            active = 1,
            usage_billing_interval = "",
            template_no = 1,
            client_email_template_id = "",
            rollover_months = "",
            rollover_plan_no = 1,
            rollover_client_plan_id = "",
            dunning_plan_no = 1,
            dunning_client_plan_id = "",
            initial_free_months = 1,
            acct_status_cd = 1,
            rollover_status_days = 1,
            rollover_status_cd = 1,
            allow_child_accts = 1,
            apply_cancellation = "",
            plan_cancel_min_month = 1,
            apply_minimum_fee = "",
            how_to_apply_minimum_fee = 1,
            schedule = new[]{new schedule_row()},
            service = new[]{new service_row()},
            resource = new[]{new resource_row()},
            arc_service_no = 1,
            parent_plans = new[]{new parent_plans_row()},
            parent_client_plan_ids = new[]{new parent_client_plan_ids_row()},
            exclusion_plans = new[]{new exclusion_plans_row()},
            supplemental_obj_field = new[]{new supplemental_obj_field_row()},
            child_plans = new[]{new child_plans_row()},
            notification_template_group_no = "",
            credit_note_template_no = "",
            surcharge_no = new[]{new surcharge_no_row()},
            client_surcharge_id = new[]{new client_surcharge_id_row()}
            };

        var response = mService.edit_plan(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void delete_plans()
    {
       delete_plansRequest request = new delete_plansRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            plan_nos = new[]{new plan_nos_row()}
            };

        var response = mService.delete_plans(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void copy_plan()
    {
       copy_planRequest request = new copy_planRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            plan_no = PlanNumber,
            client_plan_id = "",
            plan_name = "",
            new_client_plan_id = ""
            };

        var response = mService.copy_plan(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void update_master_plan()
    {
       update_master_planRequest request = new update_master_planRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey
            };

        var response = mService.update_master_plan(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void update_supplemental_plan()
    {
       update_supplemental_planRequest request = new update_supplemental_planRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey
            };

        var response = mService.update_supplemental_plan(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_promotions()
    {
       get_promotionsRequest request = new get_promotionsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey
            };

        var response = mService.get_promotions(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_promotion_details()
    {
       get_promotion_detailsRequest request = new get_promotion_detailsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            promo_cd = ""
            };

        var response = mService.get_promotion_details(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void create_promotion()
    {
       create_promotionRequest request = new create_promotionRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            promo_cd = "",
            promo_desc = "",
            promo_plan_set_no = 1,
            no_of_uses = "",
            start_date = DateTime.Now.AddYears(15).ToShortDateString(),
            exp_date = ""
            };

        var response = mService.create_promotion(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void update_promotion()
    {
       update_promotionRequest request = new update_promotionRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            promo_cd = "",
            promo_desc = "",
            promo_plan_set_no = 1,
            no_of_uses = "",
            start_date = DateTime.Now.AddYears(15).ToShortDateString(),
            exp_date = ""
            };

        var response = mService.update_promotion(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_usage_types()
    {
       get_usage_typesRequest request = new get_usage_typesRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey
            };

        var response = mService.get_usage_types(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_usage_type_details()
    {
       get_usage_type_detailsRequest request = new get_usage_type_detailsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            usage_type_no = 1
            };

        var response = mService.get_usage_type_details(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_usage_unit_types()
    {
       get_usage_unit_typesRequest request = new get_usage_unit_typesRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey
            };

        var response = mService.get_usage_unit_types(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void create_usage_type()
    {
       create_usage_typeRequest request = new create_usage_typeRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            usage_type_name = "",
            usage_type_desc = "",
            usage_unit_type_no = 1,
            usage_type_code = "",
            usage_type_display_string = ""
            };

        var response = mService.create_usage_type(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void update_usage_type()
    {
       update_usage_typeRequest request = new update_usage_typeRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            usage_type_no = 1,
            usage_type_name = "",
            usage_type_desc = "",
            usage_unit_type_no = 1,
            usage_type_code = "",
            usage_type_display_string = ""
            };

        var response = mService.update_usage_type(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void create_supp_obj_field()
    {
       create_supp_obj_fieldRequest request = new create_supp_obj_fieldRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            field_name = SupplementalFieldName,
            description = "",
            min_no_sel = "",
            max_no_sel = 1,
            datatype = "",
            form_input_type = "",
            use_allowed_vals_ind = "",
            option_value = "",
            option_value_order = ""
            };

        var response = mService.create_supp_obj_field(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void update_supp_obj_field()
    {
       update_supp_obj_fieldRequest request = new update_supp_obj_fieldRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            field_no = 1,
            field_name = SupplementalFieldName,
            description = "",
            min_no_sel = "",
            max_no_sel = 1,
            datatype = "",
            form_input_type = "",
            use_allowed_vals_ind = "",
            option_value = "",
            option_value_order = ""
            };

        var response = mService.update_supp_obj_field(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_supp_obj_fields()
    {
       get_supp_obj_fieldsRequest request = new get_supp_obj_fieldsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            field_no = 1
            };

        var response = mService.get_supp_obj_fields(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_plan_groups()
    {
       get_plan_groupsRequest request = new get_plan_groupsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey
            };

        var response = mService.get_plan_groups(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_plan_group_details()
    {
       get_plan_group_detailsRequest request = new get_plan_group_detailsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            group_no = 1,
            client_plan_change_group_id = ""
            };

        var response = mService.get_plan_group_details(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void create_plan_group()
    {
       create_plan_groupRequest request = new create_plan_groupRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            group_name = "",
            group_desc = "",
            group_usage = "",
            client_plan_change_group_id = "",
            group_plans = "",
            group_plan_ids = ""
            };

        var response = mService.create_plan_group(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void update_plan_group()
    {
       update_plan_groupRequest request = new update_plan_groupRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            group_no = 1,
            group_name = "",
            group_desc = "",
            group_usage = "",
            client_plan_change_group_id = "",
            group_plans = "",
            group_plan_ids = ""
            };

        var response = mService.update_plan_group(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void delete_plan_group()
    {
       delete_plan_groupRequest request = new delete_plan_groupRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            group_list = ""
            };

        var response = mService.delete_plan_group(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void list_coa()
    {
       list_coaRequest request = new list_coaRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey
            };

        var response = mService.list_coa(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void add_coa()
    {
       add_coaRequest request = new add_coaRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            coa_code = "",
            coa_description = ""
            };

        var response = mService.add_coa(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_coa()
    {
       get_coaRequest request = new get_coaRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            coa_id = 1
            };

        var response = mService.get_coa(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void edit_coa()
    {
       edit_coaRequest request = new edit_coaRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            coa_id = 1,
            coa_code = "",
            coa_description = ""
            };

        var response = mService.edit_coa(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_surcharges()
    {
       get_surchargesRequest request = new get_surchargesRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey
            };

        var response = mService.get_surcharges(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void get_surcharge_details()
    {
       get_surcharge_detailsRequest request = new get_surcharge_detailsRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            surcharge_no = 1,
            client_surcharge_id = ""
            };

        var response = mService.get_surcharge_details(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void create_surcharge()
    {
       create_surchargeRequest request = new create_surchargeRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            surcharge_name = "",
            description = "",
            ext_description = "",
            currency_cd = "",
            surcharge_type_cd = "",
            inline_offset_ind = "",
            apply_b4_or_after_discount_cd = "",
            scope_no = 1,
            surcharge_tier = new[]{new surcharge_tier_row()},
            client_surcharge_id = "",
            apply_to_zero_invoice_ind = 1,
            tax_group = 1,
            gl_cd = "",
            ar_gl_cd = "",
            plan_no = new[]{new plan_no_row()},
            client_plan_id = new[]{new client_plan_id_row()},
            service_no = new[]{new service_no_row()},
            client_service_id = new[]{new client_service_id_row()},
            item_no = new[]{new item_no_row()},
            client_item_id = new[]{new client_item_id_row()}
            };

        var response = mService.create_surcharge(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void edit_surcharge()
    {
       edit_surchargeRequest request = new edit_surchargeRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            surcharge_no = "",
            surcharge_name = "",
            client_surcharge_id = "",
            description = "",
            ext_description = "",
            currency_cd = "",
            scope_no = 1,
            surcharge_tier = new[]{new surcharge_tier_row()},
            apply_to_zero_invoice_ind = 1,
            plan_no = new[]{new plan_no_row()},
            client_plan_id = new[]{new client_plan_id_row()},
            service_no = new[]{new service_no_row()},
            client_service_id = new[]{new client_service_id_row()},
            item_no = new[]{new item_no_row()},
            client_item_id = new[]{new client_item_id_row()}
            };

        var response = mService.edit_surcharge(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void delete_surcharge()
    {
       delete_surchargeRequest request = new delete_surchargeRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            surcharge_no = new[]{new surcharge_no_row()},
            client_surcharge_id = new[]{new client_surcharge_id_row()}
            };

        var response = mService.delete_surcharge(request);
        Assert.IsNotNull(response);
    }

    [Test]
    public void validate_admin_session()
    {
       validate_admin_sessionRequest request = new validate_admin_sessionRequest
            {
            client_no = ClientNumber,
            auth_key = AuthorizationKey,
            session_id = ""
            };

        var response = mService.validate_admin_session(request);
        Assert.IsNotNull(response);
    }

        #endregion Api Calls TEST
    }
}
