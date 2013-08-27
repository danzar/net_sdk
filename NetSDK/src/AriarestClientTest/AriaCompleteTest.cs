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
            mService = new AriaBillingComplete("https://secure.future.stage.ariasystems.net/api/ws/api_ws_class_dispatcher.php");
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
        public void gen_invoice()
        {
            gen_invoiceRequest request = new gen_invoiceRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                acct_no = 1,
                force_pending = "",
                client_receipt_id = Guid.NewGuid().ToString()
            };

            var response = mService.gen_invoice(request);
            Assert.IsNotNull(response);
        }

        [Test]
        public void set_service_plan()
        {
            set_service_planRequest request = new set_service_planRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                account_no = AccountNumber,
                plan_no = PlanNumber,
                client_receipt_id = Guid.NewGuid().ToString()
            };

            var response = mService.set_service_plan(request);
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
        public void assign_functional_acct_group()
        {
            assign_functional_acct_groupRequest request = new assign_functional_acct_groupRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                acct_no = 1,
                group_no = 1
            };

            var response = mService.assign_functional_acct_group(request);
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
        public void get_order()
        {
            get_orderRequest request = new get_orderRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                acct_no = 1,
                my_order_no = 1,
                my_client_order_id = ""
            };

            var response = mService.get_order(request);
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
        public void cancel_queued_service_plan()
        {
            cancel_queued_service_planRequest request = new cancel_queued_service_planRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                account_number = 1
            };

            var response = mService.cancel_queued_service_plan(request);
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
        public void apply_service_credit()
        {
            apply_service_creditRequest request = new apply_service_creditRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                account_no = AccountNumber,
                credit_amount = 1,
                comments = "",
                credit_reason_code = 1
            };

            var response = mService.apply_service_credit(request);
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
        public void apply_cash_credit()
        {
            apply_cash_creditRequest request = new apply_cash_creditRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                account_no = AccountNumber,
                credit_amount = 1,
                comments = "",
                credit_reason_code = 1
            };

            var response = mService.apply_cash_credit(request);
            Assert.IsNotNull(response);
        }

        [Test]
        public void get_web_replacement_vals()
        {
            get_web_replacement_valsRequest request = new get_web_replacement_valsRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                web_vals_in = new[] { new web_vals_in_row() }
            };

            var response = mService.get_web_replacement_vals(request);
            Assert.IsNotNull(response);
        }

        [Test]
        public void activate_supp_plan()
        {
            activate_supp_planRequest request = new activate_supp_planRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                account_no = AccountNumber,
                supp_plan_no = SupplementalPlanNumber,
                status_cd = 1
            };

            var response = mService.activate_supp_plan(request);
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
        public void assign_collections_acct_group()
        {
            assign_collections_acct_groupRequest request = new assign_collections_acct_groupRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                acct_no = 1,
                group_no = 1
            };

            var response = mService.assign_collections_acct_group(request);
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
                cvv = "111",
                bank_acct_type = "",
                bill_drivers_license_no = "",
                bill_drivers_license_state = "",
                bill_taxpayer_id = ""
            };

            var response = mService.settle_account_balance(request);
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
                pay_method = 5
            };

            var response = mService.set_pay_method_net_terms(request);
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
                pre_calc_plan = new[] { new pre_calc_plan_row() },
                pre_calc_sku = new[] { new pre_calc_sku_row() },
                tax_exempt_cd = 1
            };

            var response = mService.pre_calc_invoice(request);
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
        public void create_account()
        {
            create_accountRequest request = new create_accountRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                plan_no = PlanNumber,
                userid = UserId,
                password = Password,
                status_cd = 1,
                promo_cd = "",
                alt_rate_schedule_no = 1,
                client_receipt_id = Guid.NewGuid().ToString(),
                currency_cd = ""
            };

            var response = mService.create_account(request);
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
        public void transfer_account_balance()
        {
            transfer_account_balanceRequest request = new transfer_account_balanceRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                source_account_no = AccountNumber,
                target_account_no = 1
            };

            var response = mService.transfer_account_balance(request);
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
                recurring_ind = ""
            };

            var response = mService.record_standing_usage(request);
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
        public void get_accts_with_existing_pay_method()
        {
            get_accts_with_existing_pay_methodRequest request = new get_accts_with_existing_pay_methodRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                pay_method = 5,
                form_payment_acct_id = "",
                bank_routing_num = ""
            };

            var response = mService.get_accts_with_existing_pay_method(request);
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
        public void record_usage()
        {
            record_usageRequest request = new record_usageRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                acct_no = 1,
                userid = UserId,
                usage_type = 1,
                usage_units = 1,
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
                qualifier_4 = ""
            };

            var response = mService.record_usage(request);
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
                client_receipt_id = Guid.NewGuid().ToString(),
                bank_acct_type = "",
                bill_drivers_license_no = "",
                bill_drivers_license_state = "",
                bill_taxpayer_id = ""
            };

            var response = mService.update_payment_method(request);
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
        public void get_client_plans()
        {
            get_client_plansRequest request = new get_client_plansRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey
            };

            var response = mService.get_client_plans(request);
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
                client_receipt_id = Guid.NewGuid().ToString()
            };

            var response = mService.cancel_supp_plan(request);
            Assert.IsNotNull(response);
        }

        [Test]
        public void unsubscribe_events()
        {
            unsubscribe_eventsRequest request = new unsubscribe_eventsRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                event_list = new[] { new event_list_row() }
            };

            var response = mService.unsubscribe_events(request);
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
                update_comments = ""
            };

            var response = mService.modify_acct_plan_contract(request);
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
        public void set_pay_method_cc()
        {
            set_pay_method_ccRequest request = new set_pay_method_ccRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                account_no = AccountNumber,
                cc_number = "4111111111111111",
                cc_expire_mm = DateTime.Now.Month,
                cc_expire_yyyy = DateTime.Now.Year,
                do_collect = "",
                change_status_after_coll = "",
                reset_dates_after_status = "y"
            };

            var response = mService.set_pay_method_cc(request);
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
                acct_supp_fields = new[] { new acct_supp_fields_row() }
            };

            var response = mService.modify_acct_supp_fields(request);
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
                force_currency_change = ""
            };

            var response = mService.update_master_plan(request);
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
        public void create_acct_complete()
        {
            create_acct_completeRequest request = new create_acct_completeRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                alt_start_date = "",
                client_acct_id = "",
                userid = UserId,
                status_cd = 1,
                master_plan_no = 1,
                master_plan_units = 1,
                supp_plans = new[] { new supp_plans_row() },
                supp_plan_units = new[] { new supp_plan_units_row() },
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
                pay_method = 5,
                cc_number = "4111111111111111",
                cc_expire_mm = DateTime.Now.Month,
                cc_expire_yyyy = DateTime.Now.Year,
                bank_acct_no = "",
                bank_routing_no = "",
                resp_level_cd = 1,
                senior_acct_no = 1,
                functional_acct_groups = new[] { new functional_acct_groups_row() },
                collections_acct_groups = new[] { new collections_acct_groups_row() },
                supp_field_names = new[] { new supp_field_names_row() },
                supp_field_values = new[] { new supp_field_values_row() },
                test_acct_ind = 1,
                status_until_alt_start = 1,
                balance_forward = 1,
                alt_bill_day = 1,
                do_full_invoicing = "",
                do_prorated_invoicing = "",
                master_plan_alt_rate_sched_no = 1,
                supp_plan_alt_rate_sched_no = new[] { new supp_plan_alt_rate_sched_no_row() },
                client_receipt_id = Guid.NewGuid().ToString(),
                currency_cd = "",
                cvv = "111",
                taxpayer_id = "",
                bill_agreement_id = "",
                bank_acct_type = "",
                bill_drivers_license_no = "",
                bill_drivers_license_state = "",
                bill_taxpayer_id = ""
            };

            var response = mService.create_acct_complete(request);
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
                specific_charge_transaction_id = new[] { new specific_charge_transaction_id_row() },
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
                cvv = "111",
                bank_acct_type = "",
                bill_drivers_license_no = "",
                bill_drivers_license_state = "",
                bill_taxpayer_id = ""
            };

            var response = mService.collect_from_account(request);
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
                bank_acct_type = "",
                bill_drivers_license_no = "",
                bill_drivers_license_state = "",
                bill_taxpayer_id = ""
            };

            var response = mService.set_pay_method_bank_draft(request);
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
        public void get_acct_message_size()
        {
            get_acct_message_sizeRequest request = new get_acct_message_sizeRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                acct_no = 1,
                message_id = 1,
                do_encoding = ""
            };

            var response = mService.get_acct_message_size(request);
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
        public void remove_acct_from_group()
        {
            remove_acct_from_groupRequest request = new remove_acct_from_groupRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                acct_no = 1,
                group_no = 1
            };

            var response = mService.remove_acct_from_group(request);
            Assert.IsNotNull(response);
        }

        [Test]
        public void set_session()
        {
            set_sessionRequest request = new set_sessionRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                user_id = ""
            };

            var response = mService.set_session(request);
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
                order_line_items = new[] { new order_line_items_row() },
                bill_immediately = 1,
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
                cvv = "111",
                bank_acct_type = "",
                bill_drivers_license_no = "",
                bill_drivers_license_state = "",
                bill_taxpayer_id = ""
            };

            var response = mService.create_order(request);
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
        public void get_acct_message()
        {
            get_acct_messageRequest request = new get_acct_messageRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                acct_no = 1,
                message_id = 1,
                do_encoding = ""
            };

            var response = mService.get_acct_message(request);
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
        public void set_service_plan_number()
        {
            set_service_plan_numberRequest request = new set_service_plan_numberRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                account_no = AccountNumber,
                plan_no = PlanNumber
            };

            var response = mService.set_service_plan_number(request);
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
        public void set_reg_uss_config_params()
        {
            set_reg_uss_config_paramsRequest request = new set_reg_uss_config_paramsRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                set_name = "",
                in_reg_uss_config_params = new[] { new in_reg_uss_config_params_row() }
            };

            var response = mService.set_reg_uss_config_params(request);
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
                override_timeout_minutes = 1,
                in_reg_uss_params = new[] { new in_reg_uss_params_row() }
            };

            var response = mService.set_reg_uss_params(request);
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
                record_limit = 1
            };

            var response = mService.get_family_trans_history(request);
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
                comments = "",
                reason_code = 1,
                client_receipt_id = Guid.NewGuid().ToString()
            };

            var response = mService.void_transaction(request);
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
                birthdate = ""
            };

            var response = mService.update_acct_contact(request);
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
                reset_dates_after_status = "y"
            };

            var response = mService.update_acct_billing_contact(request);
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
                do_auto_discard = ""
            };

            var response = mService.create_acct_plan_contract(request);
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
        public void record_out_going_payment()
        {
            record_out_going_paymentRequest request = new record_out_going_paymentRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                account_no = AccountNumber,
                reference_code = Guid.NewGuid().ToString(),
                payment_amount = 1,
                comments = ""
            };

            var response = mService.record_out_going_payment(request);
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
                resource_name = "",
                resource_units_label = "",
                resource_threshold_level = 1,
                resource_balance = 1
            };

            var response = mService.send_arc_threshold_email(request);
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
        public void get_usage_history()
        {
            get_usage_historyRequest request = new get_usage_historyRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                acct_no = 1,
                specified_usage_type_no = 1,
                date_range_start = DateTime.Now.AddMonths(-1).ToShortDateString(),
                date_range_end = ""
            };

            var response = mService.get_usage_history(request);
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
        public void assign_custom_acct_rates()
        {
            assign_custom_acct_ratesRequest request = new assign_custom_acct_ratesRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                acct_no = 1,
                plan_no = PlanNumber,
                service_no = ServiceNumber,
                custom_acct_rates = new[] { new custom_acct_rates_row() }
            };

            var response = mService.assign_custom_acct_rates(request);
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
                cvv = "111",
                alt_collect_on_approve = "",
                alt_send_statement_on_approve = "",
                cancel_orders_on_discard = "",
                bank_acct_type = "",
                bill_drivers_license_no = "",
                bill_drivers_license_state = "",
                bill_taxpayer_id = ""
            };

            var response = mService.manage_pending_invoice(request);
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
        public void get_payment_methods()
        {
            get_payment_methodsRequest request = new get_payment_methodsRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                account_no = AccountNumber,
                seq_no = 1
            };

            var response = mService.get_payment_methods(request);
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
                reset_dates_after_status = "y"
            };

            var response = mService.update_existing_billing_info(request);
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
        public void get_client_plans_all()
        {
            get_client_plans_allRequest request = new get_client_plans_allRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                plan_no = PlanNumber
            };

            var response = mService.get_client_plans_all(request);
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
        public void record_standing_order()
        {
            record_standing_orderRequest request = new record_standing_orderRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                account_no = AccountNumber,
                billing_interval_type = "",
                billing_interval_units = 1,
                times_to_bill = 1,
                first_bill_date = DateTime.Now.AddYears(15).ToShortDateString(),
                standing_order = new[] { new standing_order_row() },
                client_order_id = Guid.NewGuid().ToString(),
                client_receipt_id = Guid.NewGuid().ToString()
            };

            var response = mService.record_standing_order(request);
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
                acct_group_no = 1
            };

            var response = mService.validate_payment_information(request);
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
                record_limit = 1
            };

            var response = mService.get_acct_trans_history(request);
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
                CVV = "111",
                bill_seq = 1,
                inTrackingNumber = "",
                inAuthValue = ""
            };

            var response = mService.authorize_electronic_payment(request);
            Assert.IsNotNull(response);
        }

        [Test]
        public void get_rate_schedules_for_plan()
        {
            get_rate_schedules_for_planRequest request = new get_rate_schedules_for_planRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                plan_no = PlanNumber
            };

            var response = mService.get_rate_schedules_for_plan(request);
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
        public void get_client_items()
        {
            get_client_itemsRequest request = new get_client_itemsRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                in_currency_cd = "",
                return_no_cost_items = ""
            };

            var response = mService.get_client_items(request);
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
                client_receipt_id = Guid.NewGuid().ToString()
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
                client_receipt_id = Guid.NewGuid().ToString()
            };

            var response = mService.replace_supp_plan(request);
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
                reference_code = Guid.NewGuid().ToString(),
                payment_amount = 1,
                comments = "",
                client_receipt_id = Guid.NewGuid().ToString(),
                specific_charge_transaction_id = new[] { new specific_charge_transaction_id_row() }
            };

            var response = mService.record_external_payment(request);
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
                contract_start_date = ""
            };

            var response = mService.assign_supp_plan(request);
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
                update_comments = ""
            };

            var response = mService.cancel_acct_plan_contract(request);
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
        public void subscribe_events()
        {
            subscribe_eventsRequest request = new subscribe_eventsRequest
            {
                client_no = ClientNumber,
                auth_key = AuthorizationKey,
                event_list = new[] { new event_list_row() }
            };

            var response = mService.subscribe_events(request);
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
                pay_method = 5,
                cc_number = "4111111111111111",
                cc_expire_mm = DateTime.Now.Month,
                cc_expire_yyyy = DateTime.Now.Year,
                bank_routing_num = "",
                bank_acct_num = "",
                master_plan_no = 1,
                master_plan_alt_rate_sched_no = 1,
                master_plan_units = 1,
                master_plan_assign_directive = 1,
                update_acct_supp_field = new[] { new update_acct_supp_field_row() },
                update_acct_func_group = new[] { new update_acct_func_group_row() },
                update_acct_coll_group = new[] { new update_acct_coll_group_row() },
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
                cvv = "111",
                taxpayer_id = "",
                bill_agreement_id = "",
                bank_acct_type = "",
                bill_drivers_license_no = "",
                bill_drivers_license_state = "",
                bill_taxpayer_id = ""
            };

            var response = mService.update_acct_complete(request);
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

        #endregion Api Calls TEST
    }
}