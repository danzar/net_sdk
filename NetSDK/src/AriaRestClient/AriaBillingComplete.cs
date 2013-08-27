using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Aria.SDK.AriaServices.AriaWebServices.AriaComplete;

namespace Aria.SDK.AriaServices.AriaWebServices
{
    public class AriaBillingComplete : IDisposable
    {
        #region attributes
        public string URL;
        #endregion attributes

        #region Constructor
        /*Creates a new AriaBillingComplete with no parms*/
        public AriaBillingComplete()
            : this("https://secure.future.stage.ariasystems.net/api/ws/api_ws_class_dispatcher.php")
        {
        }
        /*Creates a new AriaBillingComplete with URL parm*/
        public AriaBillingComplete(String URL)
        {
            if (URL == null)
            {
                return;
            }
            setURL(URL);
        }
        #endregion

        #region Disposable
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
        #endregion Disposable

        #region gets
        private static string getMethod()
        {
            return "POST";
        }

        private static string getContentType()
        {
            return "application/json";
        }

        public string getURL()
        {
            return URL;
        }
        #endregion gets

        #region sets
        public void setURL(string url)
        {
            URL = url;
        }
        #endregion sets

        #region General methods
        protected string buildUrl(string restCallMethod)
        {
            return getURL() + "?output_format=json&rest_call=" + restCallMethod;
        }
        #endregion General methods

        #region Api Calls
        public subscribe_eventResponse subscribe_event(subscribe_eventRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("subscribe_event");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&event_id=" + request.event_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            subscribe_eventResponse myDeserializedObj = json.Deserialize(reader, typeof(subscribe_eventResponse)) as subscribe_eventResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_supp_field_valuesResponse get_supp_field_values(get_supp_field_valuesRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_supp_field_values");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&field_name=" + request.field_name;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_supp_field_valuesResponse myDeserializedObj = json.Deserialize(reader, typeof(get_supp_field_valuesResponse)) as get_supp_field_valuesResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public gen_invoiceResponse gen_invoice(gen_invoiceRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("gen_invoice");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&force_pending=" + request.force_pending;
            url += "&client_receipt_id=" + request.client_receipt_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            gen_invoiceResponse myDeserializedObj = json.Deserialize(reader, typeof(gen_invoiceResponse)) as gen_invoiceResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public set_service_planResponse set_service_plan(set_service_planRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("set_service_plan");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_no=" + request.account_no;
            url += "&plan_no=" + request.plan_no;
            url += "&client_receipt_id=" + request.client_receipt_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            set_service_planResponse myDeserializedObj = json.Deserialize(reader, typeof(set_service_planResponse)) as set_service_planResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_queued_service_plansResponse get_queued_service_plans(get_queued_service_plansRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_queued_service_plans");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_number=" + request.account_number;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_queued_service_plansResponse myDeserializedObj = json.Deserialize(reader, typeof(get_queued_service_plansResponse)) as get_queued_service_plansResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public adjust_billing_datesResponse adjust_billing_dates(adjust_billing_datesRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("adjust_billing_dates");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&action_directive=" + request.action_directive;
            url += "&adjustment_days=" + request.adjustment_days;
            url += "&comments=" + request.comments;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            adjust_billing_datesResponse myDeserializedObj = json.Deserialize(reader, typeof(adjust_billing_datesResponse)) as adjust_billing_datesResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public assign_functional_acct_groupResponse assign_functional_acct_group(assign_functional_acct_groupRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("assign_functional_acct_group");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&group_no=" + request.group_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            assign_functional_acct_groupResponse myDeserializedObj = json.Deserialize(reader, typeof(assign_functional_acct_groupResponse)) as assign_functional_acct_groupResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_supp_plans_by_promo_code_allResponse get_supp_plans_by_promo_code_all(get_supp_plans_by_promo_code_allRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_supp_plans_by_promo_code_all");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&promo_code=" + request.promo_code;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_supp_plans_by_promo_code_allResponse myDeserializedObj = json.Deserialize(reader, typeof(get_supp_plans_by_promo_code_allResponse)) as get_supp_plans_by_promo_code_allResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_standing_orderResponse get_standing_order(get_standing_orderRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_standing_order");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&my_standing_order=" + request.my_standing_order;
            url += "&my_client_order_id=" + request.my_client_order_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_standing_orderResponse myDeserializedObj = json.Deserialize(reader, typeof(get_standing_orderResponse)) as get_standing_orderResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_all_client_receipt_idsResponse get_all_client_receipt_ids(get_all_client_receipt_idsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_all_client_receipt_ids");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&start_date_range=" + request.start_date_range;
            url += "&end_date_range=" + request.end_date_range;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_all_client_receipt_idsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_all_client_receipt_idsResponse)) as get_all_client_receipt_idsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_inv_no_from_bal_xferResponse get_inv_no_from_bal_xfer(get_inv_no_from_bal_xferRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_inv_no_from_bal_xfer");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&transaction_id=" + request.transaction_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_inv_no_from_bal_xferResponse myDeserializedObj = json.Deserialize(reader, typeof(get_inv_no_from_bal_xferResponse)) as get_inv_no_from_bal_xferResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_acct_groups_by_clientResponse get_acct_groups_by_client(get_acct_groups_by_clientRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_groups_by_client");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_acct_groups_by_clientResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_groups_by_clientResponse)) as get_acct_groups_by_clientResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_orderResponse get_order(get_orderRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_order");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&my_order_no=" + request.my_order_no;
            url += "&my_client_order_id=" + request.my_client_order_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_orderResponse myDeserializedObj = json.Deserialize(reader, typeof(get_orderResponse)) as get_orderResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public update_acct_supp_fieldsResponse update_acct_supp_fields(update_acct_supp_fieldsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("update_acct_supp_fields");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_no=" + request.account_no;
            url += "&field_name=" + request.field_name;
            url += "&value_text=" + request.value_text;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            update_acct_supp_fieldsResponse myDeserializedObj = json.Deserialize(reader, typeof(update_acct_supp_fieldsResponse)) as update_acct_supp_fieldsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_order_itemsResponse get_order_items(get_order_itemsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_order_items");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&order_no=" + request.order_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_order_itemsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_order_itemsResponse)) as get_order_itemsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public set_prov_engineResponse set_prov_engine(set_prov_engineRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("set_prov_engine");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&on_off_indicator=" + request.on_off_indicator;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            set_prov_engineResponse myDeserializedObj = json.Deserialize(reader, typeof(set_prov_engineResponse)) as set_prov_engineResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public cancel_queued_service_planResponse cancel_queued_service_plan(cancel_queued_service_planRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("cancel_queued_service_plan");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_number=" + request.account_number;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            cancel_queued_service_planResponse myDeserializedObj = json.Deserialize(reader, typeof(cancel_queued_service_planResponse)) as cancel_queued_service_planResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_avail_child_plans_for_acct_allResponse get_avail_child_plans_for_acct_all(get_avail_child_plans_for_acct_allRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_avail_child_plans_for_acct_all");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_avail_child_plans_for_acct_allResponse myDeserializedObj = json.Deserialize(reader, typeof(get_avail_child_plans_for_acct_allResponse)) as get_avail_child_plans_for_acct_allResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public apply_service_creditResponse apply_service_credit(apply_service_creditRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("apply_service_credit");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_no=" + request.account_no;
            url += "&credit_amount=" + request.credit_amount;
            url += "&comments=" + request.comments;
            url += "&credit_reason_code=" + request.credit_reason_code;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            apply_service_creditResponse myDeserializedObj = json.Deserialize(reader, typeof(apply_service_creditResponse)) as apply_service_creditResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_statement_for_invoiceResponse get_statement_for_invoice(get_statement_for_invoiceRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_statement_for_invoice");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&invoice_no=" + request.invoice_no;
            url += "&do_encoding=" + request.do_encoding;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_statement_for_invoiceResponse myDeserializedObj = json.Deserialize(reader, typeof(get_statement_for_invoiceResponse)) as get_statement_for_invoiceResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public apply_cash_creditResponse apply_cash_credit(apply_cash_creditRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("apply_cash_credit");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_no=" + request.account_no;
            url += "&credit_amount=" + request.credit_amount;
            url += "&comments=" + request.comments;
            url += "&credit_reason_code=" + request.credit_reason_code;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            apply_cash_creditResponse myDeserializedObj = json.Deserialize(reader, typeof(apply_cash_creditResponse)) as apply_cash_creditResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_web_replacement_valsResponse get_web_replacement_vals(get_web_replacement_valsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_web_replacement_vals");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            RestUtilities.addParameterValuesFromArray(ref url, request.web_vals_in);

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_web_replacement_valsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_web_replacement_valsResponse)) as get_web_replacement_valsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public activate_supp_planResponse activate_supp_plan(activate_supp_planRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("activate_supp_plan");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_no=" + request.account_no;
            url += "&supp_plan_no=" + request.supp_plan_no;
            url += "&status_cd=" + request.status_cd;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            activate_supp_planResponse myDeserializedObj = json.Deserialize(reader, typeof(activate_supp_planResponse)) as activate_supp_planResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_acct_status_historyResponse get_acct_status_history(get_acct_status_historyRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_status_history");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_number=" + request.account_number;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_acct_status_historyResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_status_historyResponse)) as get_acct_status_historyResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public assign_collections_acct_groupResponse assign_collections_acct_group(assign_collections_acct_groupRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("assign_collections_acct_group");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&group_no=" + request.group_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            assign_collections_acct_groupResponse myDeserializedObj = json.Deserialize(reader, typeof(assign_collections_acct_groupResponse)) as assign_collections_acct_groupResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public settle_account_balanceResponse settle_account_balance(settle_account_balanceRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("settle_account_balance");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_no=" + request.account_no;
            url += "&alt_pay_method=" + request.alt_pay_method;
            url += "&cc_number=" + request.cc_number;
            url += "&cc_expire_mm=" + request.cc_expire_mm;
            url += "&cc_expire_yyyy=" + request.cc_expire_yyyy;
            url += "&bank_routing_num=" + request.bank_routing_num;
            url += "&bank_acct_num=" + request.bank_acct_num;
            url += "&bill_company_name=" + request.bill_company_name;
            url += "&bill_first_name=" + request.bill_first_name;
            url += "&bill_middle_initial=" + request.bill_middle_initial;
            url += "&bill_last_name=" + request.bill_last_name;
            url += "&bill_address1=" + request.bill_address1;
            url += "&bill_address2=" + request.bill_address2;
            url += "&bill_city=" + request.bill_city;
            url += "&bill_locality=" + request.bill_locality;
            url += "&bill_state_prov=" + request.bill_state_prov;
            url += "&bill_zip=" + request.bill_zip;
            url += "&bill_country=" + request.bill_country;
            url += "&bill_email=" + request.bill_email;
            url += "&bill_phone=" + request.bill_phone;
            url += "&bill_phone_extension=" + request.bill_phone_extension;
            url += "&bill_cell_phone=" + request.bill_cell_phone;
            url += "&bill_work_phone=" + request.bill_work_phone;
            url += "&bill_work_phone_extension=" + request.bill_work_phone_extension;
            url += "&cvv=" + request.cvv;
            url += "&bank_acct_type=" + request.bank_acct_type;
            url += "&bill_drivers_license_no=" + request.bill_drivers_license_no;
            url += "&bill_drivers_license_state=" + request.bill_drivers_license_state;
            url += "&bill_taxpayer_id=" + request.bill_taxpayer_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            settle_account_balanceResponse myDeserializedObj = json.Deserialize(reader, typeof(settle_account_balanceResponse)) as settle_account_balanceResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public set_pay_method_net_termsResponse set_pay_method_net_terms(set_pay_method_net_termsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("set_pay_method_net_terms");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_no=" + request.account_no;
            url += "&pay_method=" + request.pay_method;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            set_pay_method_net_termsResponse myDeserializedObj = json.Deserialize(reader, typeof(set_pay_method_net_termsResponse)) as set_pay_method_net_termsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public pre_calc_invoiceResponse pre_calc_invoice(pre_calc_invoiceRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("pre_calc_invoice");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&log_id=" + request.log_id;
            url += "&first_name=" + request.first_name;
            url += "&mi=" + request.mi;
            url += "&last_name=" + request.last_name;
            url += "&address1=" + request.address1;
            url += "&address2=" + request.address2;
            url += "&city=" + request.city;
            url += "&state_prov_code=" + request.state_prov_code;
            url += "&zip_code=" + request.zip_code;
            url += "&country_code=" + request.country_code;
            url += "&currency_code=" + request.currency_code;
            RestUtilities.addParameterValuesFromArray(ref url, request.pre_calc_plan);
            RestUtilities.addParameterValuesFromArray(ref url, request.pre_calc_sku);
            url += "&tax_exempt_cd=" + request.tax_exempt_cd;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            pre_calc_invoiceResponse myDeserializedObj = json.Deserialize(reader, typeof(pre_calc_invoiceResponse)) as pre_calc_invoiceResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_client_countriesResponse get_client_countries(get_client_countriesRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_client_countries");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_client_countriesResponse myDeserializedObj = json.Deserialize(reader, typeof(get_client_countriesResponse)) as get_client_countriesResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public create_accountResponse create_account(create_accountRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("create_account");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&plan_no=" + request.plan_no;
            url += "&userid=" + request.userid;
            url += "&password=" + request.password;
            url += "&status_cd=" + request.status_cd;
            url += "&promo_cd=" + request.promo_cd;
            url += "&alt_rate_schedule_no=" + request.alt_rate_schedule_no;
            url += "&client_receipt_id=" + request.client_receipt_id;
            url += "&currency_cd=" + request.currency_cd;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            create_accountResponse myDeserializedObj = json.Deserialize(reader, typeof(create_accountResponse)) as create_accountResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public gen_random_stringResponse gen_random_string(gen_random_stringRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("gen_random_string");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&rand_type=" + request.rand_type;
            url += "&rand_length=" + request.rand_length;
            url += "&rand_case=" + request.rand_case;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            gen_random_stringResponse myDeserializedObj = json.Deserialize(reader, typeof(gen_random_stringResponse)) as gen_random_stringResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public client_has_event_classResponse client_has_event_class(client_has_event_classRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("client_has_event_class");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&class_no=" + request.class_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            client_has_event_classResponse myDeserializedObj = json.Deserialize(reader, typeof(client_has_event_classResponse)) as client_has_event_classResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public remove_pay_methodResponse remove_pay_method(remove_pay_methodRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("remove_pay_method");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            remove_pay_methodResponse myDeserializedObj = json.Deserialize(reader, typeof(remove_pay_methodResponse)) as remove_pay_methodResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public transfer_account_balanceResponse transfer_account_balance(transfer_account_balanceRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("transfer_account_balance");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&source_account_no=" + request.source_account_no;
            url += "&target_account_no=" + request.target_account_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            transfer_account_balanceResponse myDeserializedObj = json.Deserialize(reader, typeof(transfer_account_balanceResponse)) as transfer_account_balanceResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public kill_sessionResponse kill_session(kill_sessionRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("kill_session");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&session_id=" + request.session_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            kill_sessionResponse myDeserializedObj = json.Deserialize(reader, typeof(kill_sessionResponse)) as kill_sessionResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public unsubscribe_event_classResponse unsubscribe_event_class(unsubscribe_event_classRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("unsubscribe_event_class");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&class_no=" + request.class_no;
            url += "&do_write=" + request.do_write;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            unsubscribe_event_classResponse myDeserializedObj = json.Deserialize(reader, typeof(unsubscribe_event_classResponse)) as unsubscribe_event_classResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public record_standing_usageResponse record_standing_usage(record_standing_usageRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("record_standing_usage");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&usage_type=" + request.usage_type;
            url += "&usage_units=" + request.usage_units;
            url += "&next_usage_date=" + request.next_usage_date;
            url += "&alt_desc=" + request.alt_desc;
            url += "&plan_no=" + request.plan_no;
            url += "&first_usage_date=" + request.first_usage_date;
            url += "&recurring_ind=" + request.recurring_ind;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            record_standing_usageResponse myDeserializedObj = json.Deserialize(reader, typeof(record_standing_usageResponse)) as record_standing_usageResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_current_system_versionResponse get_current_system_version(get_current_system_versionRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_current_system_version");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_current_system_versionResponse myDeserializedObj = json.Deserialize(reader, typeof(get_current_system_versionResponse)) as get_current_system_versionResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_accts_with_existing_pay_methodResponse get_accts_with_existing_pay_method(get_accts_with_existing_pay_methodRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_accts_with_existing_pay_method");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&pay_method=" + request.pay_method;
            url += "&form_payment_acct_id=" + request.form_payment_acct_id;
            url += "&bank_routing_num=" + request.bank_routing_num;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_accts_with_existing_pay_methodResponse myDeserializedObj = json.Deserialize(reader, typeof(get_accts_with_existing_pay_methodResponse)) as get_accts_with_existing_pay_methodResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_statement_for_inv_sizeResponse get_statement_for_inv_size(get_statement_for_inv_sizeRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_statement_for_inv_size");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&invoice_no=" + request.invoice_no;
            url += "&do_encoding=" + request.do_encoding;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_statement_for_inv_sizeResponse myDeserializedObj = json.Deserialize(reader, typeof(get_statement_for_inv_sizeResponse)) as get_statement_for_inv_sizeResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public record_usageResponse record_usage(record_usageRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("record_usage");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&userid=" + request.userid;
            url += "&usage_type=" + request.usage_type;
            url += "&usage_units=" + request.usage_units;
            url += "&usage_date=" + request.usage_date;
            url += "&billable_units=" + request.billable_units;
            url += "&amt=" + request.amt;
            url += "&rate=" + request.rate;
            url += "&telco_from=" + request.telco_from;
            url += "&telco_to=" + request.telco_to;
            url += "&comments=" + request.comments;
            url += "&exclude_from_billing=" + request.exclude_from_billing;
            url += "&exclusion_comments=" + request.exclusion_comments;
            url += "&qualifier_1=" + request.qualifier_1;
            url += "&qualifier_2=" + request.qualifier_2;
            url += "&qualifier_3=" + request.qualifier_3;
            url += "&qualifier_4=" + request.qualifier_4;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            record_usageResponse myDeserializedObj = json.Deserialize(reader, typeof(record_usageResponse)) as record_usageResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public update_payment_methodResponse update_payment_method(update_payment_methodRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("update_payment_method");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_number=" + request.account_number;
            url += "&first_name=" + request.first_name;
            url += "&last_name=" + request.last_name;
            url += "&middle_initial=" + request.middle_initial;
            url += "&company_name=" + request.company_name;
            url += "&address1=" + request.address1;
            url += "&address2=" + request.address2;
            url += "&city=" + request.city;
            url += "&locality=" + request.locality;
            url += "&state=" + request.state;
            url += "&country=" + request.country;
            url += "&zip=" + request.zip;
            url += "&intl_phone=" + request.intl_phone;
            url += "&phone_npa=" + request.phone_npa;
            url += "&phone_nxx=" + request.phone_nxx;
            url += "&phone_suffix=" + request.phone_suffix;
            url += "&phone_extension=" + request.phone_extension;
            url += "&email=" + request.email;
            url += "&pay_method=" + request.pay_method;
            url += "&cc_number=" + request.cc_number;
            url += "&cc_expire_mm=" + request.cc_expire_mm;
            url += "&cc_expire_yyyy=" + request.cc_expire_yyyy;
            url += "&bank_routing_num=" + request.bank_routing_num;
            url += "&bank_acct_num=" + request.bank_acct_num;
            url += "&do_collect=" + request.do_collect;
            url += "&change_status_after_coll=" + request.change_status_after_coll;
            url += "&reset_dates_after_status=" + request.reset_dates_after_status;
            url += "&client_receipt_id=" + request.client_receipt_id;
            url += "&bank_acct_type=" + request.bank_acct_type;
            url += "&bill_drivers_license_no=" + request.bill_drivers_license_no;
            url += "&bill_drivers_license_state=" + request.bill_drivers_license_state;
            url += "&bill_taxpayer_id=" + request.bill_taxpayer_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            update_payment_methodResponse myDeserializedObj = json.Deserialize(reader, typeof(update_payment_methodResponse)) as update_payment_methodResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_country_from_ipResponse get_country_from_ip(get_country_from_ipRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_country_from_ip");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&ip_address=" + request.ip_address;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_country_from_ipResponse myDeserializedObj = json.Deserialize(reader, typeof(get_country_from_ipResponse)) as get_country_from_ipResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public keep_aliveResponse keep_alive(keep_aliveRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("keep_alive");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&session_id=" + request.session_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            keep_aliveResponse myDeserializedObj = json.Deserialize(reader, typeof(keep_aliveResponse)) as keep_aliveResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_unapplied_service_creditsResponse get_unapplied_service_credits(get_unapplied_service_creditsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_unapplied_service_credits");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_unapplied_service_creditsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_unapplied_service_creditsResponse)) as get_unapplied_service_creditsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_avail_child_plans_for_planResponse get_avail_child_plans_for_plan(get_avail_child_plans_for_planRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_avail_child_plans_for_plan");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&in_plan_no=" + request.in_plan_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_avail_child_plans_for_planResponse myDeserializedObj = json.Deserialize(reader, typeof(get_avail_child_plans_for_planResponse)) as get_avail_child_plans_for_planResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public authenticate_callerResponse authenticate_caller(authenticate_callerRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("authenticate_caller");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            authenticate_callerResponse myDeserializedObj = json.Deserialize(reader, typeof(authenticate_callerResponse)) as authenticate_callerResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public init_paypal_bill_agreementResponse init_paypal_bill_agreement(init_paypal_bill_agreementRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("init_paypal_bill_agreement");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            init_paypal_bill_agreementResponse myDeserializedObj = json.Deserialize(reader, typeof(init_paypal_bill_agreementResponse)) as init_paypal_bill_agreementResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_reg_uss_paramsResponse get_reg_uss_params(get_reg_uss_paramsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_reg_uss_params");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&session_id=" + request.session_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_reg_uss_paramsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_reg_uss_paramsResponse)) as get_reg_uss_paramsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_client_plansResponse get_client_plans(get_client_plansRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_client_plans");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_client_plansResponse myDeserializedObj = json.Deserialize(reader, typeof(get_client_plansResponse)) as get_client_plansResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public cancel_supp_planResponse cancel_supp_plan(cancel_supp_planRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("cancel_supp_plan");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&supp_plan_no=" + request.supp_plan_no;
            url += "&assignment_directive=" + request.assignment_directive;
            url += "&comments=" + request.comments;
            url += "&do_write=" + request.do_write;
            url += "&client_receipt_id=" + request.client_receipt_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            cancel_supp_planResponse myDeserializedObj = json.Deserialize(reader, typeof(cancel_supp_planResponse)) as cancel_supp_planResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public unsubscribe_eventsResponse unsubscribe_events(unsubscribe_eventsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("unsubscribe_events");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            RestUtilities.addParameterValuesFromArray(ref url, request.event_list);

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            unsubscribe_eventsResponse myDeserializedObj = json.Deserialize(reader, typeof(unsubscribe_eventsResponse)) as unsubscribe_eventsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public modify_acct_plan_contractResponse modify_acct_plan_contract(modify_acct_plan_contractRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("modify_acct_plan_contract");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&contract_no=" + request.contract_no;
            url += "&type_no=" + request.type_no;
            url += "&alt_recur_fee=" + request.alt_recur_fee;
            url += "&length_months=" + request.length_months;
            url += "&cancel_fee=" + request.cancel_fee;
            url += "&start_date=" + request.start_date;
            url += "&update_comments=" + request.update_comments;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            modify_acct_plan_contractResponse myDeserializedObj = json.Deserialize(reader, typeof(modify_acct_plan_contractResponse)) as modify_acct_plan_contractResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_acct_groups_by_acctResponse get_acct_groups_by_acct(get_acct_groups_by_acctRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_groups_by_acct");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&user_id=" + request.user_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_acct_groups_by_acctResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_groups_by_acctResponse)) as get_acct_groups_by_acctResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_acct_supp_fieldsResponse get_acct_supp_fields(get_acct_supp_fieldsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_supp_fields");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_acct_supp_fieldsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_supp_fieldsResponse)) as get_acct_supp_fieldsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public userid_is_availableResponse userid_is_available(userid_is_availableRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("userid_is_available");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&user_id=" + request.user_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            userid_is_availableResponse myDeserializedObj = json.Deserialize(reader, typeof(userid_is_availableResponse)) as userid_is_availableResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public set_pay_method_ccResponse set_pay_method_cc(set_pay_method_ccRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("set_pay_method_cc");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_no=" + request.account_no;
            url += "&cc_number=" + request.cc_number;
            url += "&cc_expire_mm=" + request.cc_expire_mm;
            url += "&cc_expire_yyyy=" + request.cc_expire_yyyy;
            url += "&do_collect=" + request.do_collect;
            url += "&change_status_after_coll=" + request.change_status_after_coll;
            url += "&reset_dates_after_status=" + request.reset_dates_after_status;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            set_pay_method_ccResponse myDeserializedObj = json.Deserialize(reader, typeof(set_pay_method_ccResponse)) as set_pay_method_ccResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public modify_acct_supp_fieldsResponse modify_acct_supp_fields(modify_acct_supp_fieldsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("modify_acct_supp_fields");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            RestUtilities.addParameterValuesFromArray(ref url, request.acct_supp_fields);

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            modify_acct_supp_fieldsResponse myDeserializedObj = json.Deserialize(reader, typeof(modify_acct_supp_fieldsResponse)) as modify_acct_supp_fieldsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public userid_existsResponse userid_exists(userid_existsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("userid_exists");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&user_id=" + request.user_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            userid_existsResponse myDeserializedObj = json.Deserialize(reader, typeof(userid_existsResponse)) as userid_existsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_all_acct_receipt_idsResponse get_all_acct_receipt_ids(get_all_acct_receipt_idsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_all_acct_receipt_ids");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&start_date_range=" + request.start_date_range;
            url += "&end_date_range=" + request.end_date_range;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_all_acct_receipt_idsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_all_acct_receipt_idsResponse)) as get_all_acct_receipt_idsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_standing_order_histResponse get_standing_order_hist(get_standing_order_histRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_standing_order_hist");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&standing_order_no=" + request.standing_order_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_standing_order_histResponse myDeserializedObj = json.Deserialize(reader, typeof(get_standing_order_histResponse)) as get_standing_order_histResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_client_plan_servicesResponse get_client_plan_services(get_client_plan_servicesRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_client_plan_services");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&plan_no=" + request.plan_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_client_plan_servicesResponse myDeserializedObj = json.Deserialize(reader, typeof(get_client_plan_servicesResponse)) as get_client_plan_servicesResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public update_master_planResponse update_master_plan(update_master_planRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("update_master_plan");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&master_plan_no=" + request.master_plan_no;
            url += "&alt_rate_schedule_no=" + request.alt_rate_schedule_no;
            url += "&num_plan_units=" + request.num_plan_units;
            url += "&assignment_directive=" + request.assignment_directive;
            url += "&do_write=" + request.do_write;
            url += "&client_receipt_id=" + request.client_receipt_id;
            url += "&force_currency_change=" + request.force_currency_change;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            update_master_planResponse myDeserializedObj = json.Deserialize(reader, typeof(update_master_planResponse)) as update_master_planResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_plans_by_promo_code_allResponse get_plans_by_promo_code_all(get_plans_by_promo_code_allRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_plans_by_promo_code_all");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&promo_code=" + request.promo_code;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_plans_by_promo_code_allResponse myDeserializedObj = json.Deserialize(reader, typeof(get_plans_by_promo_code_allResponse)) as get_plans_by_promo_code_allResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_available_plansResponse get_available_plans(get_available_plansRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_available_plans");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_available_plansResponse myDeserializedObj = json.Deserialize(reader, typeof(get_available_plansResponse)) as get_available_plansResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_plans_by_promo_codeResponse get_plans_by_promo_code(get_plans_by_promo_codeRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_plans_by_promo_code");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&promo_code=" + request.promo_code;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_plans_by_promo_codeResponse myDeserializedObj = json.Deserialize(reader, typeof(get_plans_by_promo_codeResponse)) as get_plans_by_promo_codeResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public create_acct_completeResponse create_acct_complete(create_acct_completeRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("create_acct_complete");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&alt_start_date=" + request.alt_start_date;
            url += "&client_acct_id=" + request.client_acct_id;
            url += "&userid=" + request.userid;
            url += "&status_cd=" + request.status_cd;
            url += "&master_plan_no=" + request.master_plan_no;
            url += "&master_plan_units=" + request.master_plan_units;
            RestUtilities.addParameterValuesFromArray(ref url, request.supp_plans);
            RestUtilities.addParameterValuesFromArray(ref url, request.supp_plan_units);
            url += "&notify_method=" + request.notify_method;
            url += "&promo_cd=" + request.promo_cd;
            url += "&password=" + request.password;
            url += "&secret_question=" + request.secret_question;
            url += "&secret_question_answer=" + request.secret_question_answer;
            url += "&first_name=" + request.first_name;
            url += "&mi=" + request.mi;
            url += "&last_name=" + request.last_name;
            url += "&company_name=" + request.company_name;
            url += "&address1=" + request.address1;
            url += "&address2=" + request.address2;
            url += "&city=" + request.city;
            url += "&locality=" + request.locality;
            url += "&state_prov=" + request.state_prov;
            url += "&country=" + request.country;
            url += "&postal_cd=" + request.postal_cd;
            url += "&phone=" + request.phone;
            url += "&phone_ext=" + request.phone_ext;
            url += "&cell_phone=" + request.cell_phone;
            url += "&work_phone=" + request.work_phone;
            url += "&work_phone_ext=" + request.work_phone_ext;
            url += "&email=" + request.email;
            url += "&birthdate=" + request.birthdate;
            url += "&bill_first_name=" + request.bill_first_name;
            url += "&bill_mi=" + request.bill_mi;
            url += "&bill_last_name=" + request.bill_last_name;
            url += "&bill_company_name=" + request.bill_company_name;
            url += "&bill_address1=" + request.bill_address1;
            url += "&bill_address2=" + request.bill_address2;
            url += "&bill_city=" + request.bill_city;
            url += "&bill_locality=" + request.bill_locality;
            url += "&bill_state_prov=" + request.bill_state_prov;
            url += "&bill_country=" + request.bill_country;
            url += "&bill_postal_cd=" + request.bill_postal_cd;
            url += "&bill_phone=" + request.bill_phone;
            url += "&bill_phone_ext=" + request.bill_phone_ext;
            url += "&bill_cell_phone=" + request.bill_cell_phone;
            url += "&bill_work_phone=" + request.bill_work_phone;
            url += "&bill_work_phone_ext=" + request.bill_work_phone_ext;
            url += "&bill_email=" + request.bill_email;
            url += "&pay_method=" + request.pay_method;
            url += "&cc_number=" + request.cc_number;
            url += "&cc_expire_mm=" + request.cc_expire_mm;
            url += "&cc_expire_yyyy=" + request.cc_expire_yyyy;
            url += "&bank_acct_no=" + request.bank_acct_no;
            url += "&bank_routing_no=" + request.bank_routing_no;
            url += "&resp_level_cd=" + request.resp_level_cd;
            url += "&senior_acct_no=" + request.senior_acct_no;
            RestUtilities.addParameterValuesFromArray(ref url, request.functional_acct_groups);
            RestUtilities.addParameterValuesFromArray(ref url, request.collections_acct_groups);
            RestUtilities.addParameterValuesFromArray(ref url, request.supp_field_names);
            RestUtilities.addParameterValuesFromArray(ref url, request.supp_field_values);
            url += "&test_acct_ind=" + request.test_acct_ind;
            url += "&status_until_alt_start=" + request.status_until_alt_start;
            url += "&balance_forward=" + request.balance_forward;
            url += "&alt_bill_day=" + request.alt_bill_day;
            url += "&do_full_invoicing=" + request.do_full_invoicing;
            url += "&do_prorated_invoicing=" + request.do_prorated_invoicing;
            url += "&master_plan_alt_rate_sched_no=" + request.master_plan_alt_rate_sched_no;
            RestUtilities.addParameterValuesFromArray(ref url, request.supp_plan_alt_rate_sched_no);
            url += "&client_receipt_id=" + request.client_receipt_id;
            url += "&currency_cd=" + request.currency_cd;
            url += "&cvv=" + request.cvv;
            url += "&taxpayer_id=" + request.taxpayer_id;
            url += "&bill_agreement_id=" + request.bill_agreement_id;
            url += "&bank_acct_type=" + request.bank_acct_type;
            url += "&bill_drivers_license_no=" + request.bill_drivers_license_no;
            url += "&bill_drivers_license_state=" + request.bill_drivers_license_state;
            url += "&bill_taxpayer_id=" + request.bill_taxpayer_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            create_acct_completeResponse myDeserializedObj = json.Deserialize(reader, typeof(create_acct_completeResponse)) as create_acct_completeResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public collect_from_accountResponse collect_from_account(collect_from_accountRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("collect_from_account");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_no=" + request.account_no;
            url += "&amount_to_collect=" + request.amount_to_collect;
            url += "&bill_seq=" + request.bill_seq;
            url += "&client_receipt_id=" + request.client_receipt_id;
            RestUtilities.addParameterValuesFromArray(ref url, request.specific_charge_transaction_id);
            url += "&alt_pay_method=" + request.alt_pay_method;
            url += "&cc_number=" + request.cc_number;
            url += "&cc_expire_mm=" + request.cc_expire_mm;
            url += "&cc_expire_yyyy=" + request.cc_expire_yyyy;
            url += "&bank_routing_num=" + request.bank_routing_num;
            url += "&bank_acct_num=" + request.bank_acct_num;
            url += "&bill_company_name=" + request.bill_company_name;
            url += "&bill_first_name=" + request.bill_first_name;
            url += "&bill_middle_initial=" + request.bill_middle_initial;
            url += "&bill_last_name=" + request.bill_last_name;
            url += "&bill_address1=" + request.bill_address1;
            url += "&bill_address2=" + request.bill_address2;
            url += "&bill_city=" + request.bill_city;
            url += "&bill_locality=" + request.bill_locality;
            url += "&bill_state_prov=" + request.bill_state_prov;
            url += "&bill_zip=" + request.bill_zip;
            url += "&bill_country=" + request.bill_country;
            url += "&bill_email=" + request.bill_email;
            url += "&bill_phone=" + request.bill_phone;
            url += "&bill_phone_extension=" + request.bill_phone_extension;
            url += "&bill_cell_phone=" + request.bill_cell_phone;
            url += "&bill_work_phone=" + request.bill_work_phone;
            url += "&bill_work_phone_extension=" + request.bill_work_phone_extension;
            url += "&cvv=" + request.cvv;
            url += "&bank_acct_type=" + request.bank_acct_type;
            url += "&bill_drivers_license_no=" + request.bill_drivers_license_no;
            url += "&bill_drivers_license_state=" + request.bill_drivers_license_state;
            url += "&bill_taxpayer_id=" + request.bill_taxpayer_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            collect_from_accountResponse myDeserializedObj = json.Deserialize(reader, typeof(collect_from_accountResponse)) as collect_from_accountResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public set_pay_method_bank_draftResponse set_pay_method_bank_draft(set_pay_method_bank_draftRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("set_pay_method_bank_draft");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_no=" + request.account_no;
            url += "&bank_routing_num=" + request.bank_routing_num;
            url += "&bank_acct_num=" + request.bank_acct_num;
            url += "&do_collect=" + request.do_collect;
            url += "&change_status_after_coll=" + request.change_status_after_coll;
            url += "&reset_dates_after_status=" + request.reset_dates_after_status;
            url += "&bank_acct_type=" + request.bank_acct_type;
            url += "&bill_drivers_license_no=" + request.bill_drivers_license_no;
            url += "&bill_drivers_license_state=" + request.bill_drivers_license_state;
            url += "&bill_taxpayer_id=" + request.bill_taxpayer_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            set_pay_method_bank_draftResponse myDeserializedObj = json.Deserialize(reader, typeof(set_pay_method_bank_draftResponse)) as set_pay_method_bank_draftResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public disable_all_standing_usageResponse disable_all_standing_usage(disable_all_standing_usageRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("disable_all_standing_usage");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&comments=" + request.comments;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            disable_all_standing_usageResponse myDeserializedObj = json.Deserialize(reader, typeof(disable_all_standing_usageResponse)) as disable_all_standing_usageResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public set_session_authResponse set_session_auth(set_session_authRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("set_session_auth");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&user_id=" + request.user_id;
            url += "&password=" + request.password;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            set_session_authResponse myDeserializedObj = json.Deserialize(reader, typeof(set_session_authResponse)) as set_session_authResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_acct_message_sizeResponse get_acct_message_size(get_acct_message_sizeRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_message_size");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&message_id=" + request.message_id;
            url += "&do_encoding=" + request.do_encoding;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_acct_message_sizeResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_message_sizeResponse)) as get_acct_message_sizeResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public update_acct_notify_methodResponse update_acct_notify_method(update_acct_notify_methodRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("update_acct_notify_method");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_no=" + request.account_no;
            url += "&notify_method=" + request.notify_method;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            update_acct_notify_methodResponse myDeserializedObj = json.Deserialize(reader, typeof(update_acct_notify_methodResponse)) as update_acct_notify_methodResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_acct_plan_contractResponse get_acct_plan_contract(get_acct_plan_contractRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_plan_contract");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&plan_no=" + request.plan_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_acct_plan_contractResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_plan_contractResponse)) as get_acct_plan_contractResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public remove_acct_from_groupResponse remove_acct_from_group(remove_acct_from_groupRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("remove_acct_from_group");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&group_no=" + request.group_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            remove_acct_from_groupResponse myDeserializedObj = json.Deserialize(reader, typeof(remove_acct_from_groupResponse)) as remove_acct_from_groupResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public set_sessionResponse set_session(set_sessionRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("set_session");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&user_id=" + request.user_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            set_sessionResponse myDeserializedObj = json.Deserialize(reader, typeof(set_sessionResponse)) as set_sessionResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public create_orderResponse create_order(create_orderRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("create_order");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_no=" + request.account_no;
            RestUtilities.addParameterValuesFromArray(ref url, request.order_line_items);
            url += "&bill_immediately=" + request.bill_immediately;
            url += "&bill_seq=" + request.bill_seq;
            url += "&client_order_id=" + request.client_order_id;
            url += "&client_receipt_id=" + request.client_receipt_id;
            url += "&alt_pay_method=" + request.alt_pay_method;
            url += "&cc_number=" + request.cc_number;
            url += "&cc_expire_mm=" + request.cc_expire_mm;
            url += "&cc_expire_yyyy=" + request.cc_expire_yyyy;
            url += "&bank_routing_num=" + request.bank_routing_num;
            url += "&bank_acct_num=" + request.bank_acct_num;
            url += "&bill_company_name=" + request.bill_company_name;
            url += "&bill_first_name=" + request.bill_first_name;
            url += "&bill_middle_initial=" + request.bill_middle_initial;
            url += "&bill_last_name=" + request.bill_last_name;
            url += "&bill_address1=" + request.bill_address1;
            url += "&bill_address2=" + request.bill_address2;
            url += "&bill_city=" + request.bill_city;
            url += "&bill_locality=" + request.bill_locality;
            url += "&bill_state_prov=" + request.bill_state_prov;
            url += "&bill_zip=" + request.bill_zip;
            url += "&bill_country=" + request.bill_country;
            url += "&bill_email=" + request.bill_email;
            url += "&bill_phone=" + request.bill_phone;
            url += "&bill_phone_extension=" + request.bill_phone_extension;
            url += "&bill_cell_phone=" + request.bill_cell_phone;
            url += "&bill_work_phone=" + request.bill_work_phone;
            url += "&bill_work_phone_extension=" + request.bill_work_phone_extension;
            url += "&cvv=" + request.cvv;
            url += "&bank_acct_type=" + request.bank_acct_type;
            url += "&bill_drivers_license_no=" + request.bill_drivers_license_no;
            url += "&bill_drivers_license_state=" + request.bill_drivers_license_state;
            url += "&bill_taxpayer_id=" + request.bill_taxpayer_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            create_orderResponse myDeserializedObj = json.Deserialize(reader, typeof(create_orderResponse)) as create_orderResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_standing_order_itemsResponse get_standing_order_items(get_standing_order_itemsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_standing_order_items");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&standing_order_no=" + request.standing_order_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_standing_order_itemsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_standing_order_itemsResponse)) as get_standing_order_itemsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_acct_messageResponse get_acct_message(get_acct_messageRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_message");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&message_id=" + request.message_id;
            url += "&do_encoding=" + request.do_encoding;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_acct_messageResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_messageResponse)) as get_acct_messageResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_avail_child_plans_for_acctResponse get_avail_child_plans_for_acct(get_avail_child_plans_for_acctRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_avail_child_plans_for_acct");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_avail_child_plans_for_acctResponse myDeserializedObj = json.Deserialize(reader, typeof(get_avail_child_plans_for_acctResponse)) as get_avail_child_plans_for_acctResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_acct_plansResponse get_acct_plans(get_acct_plansRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_plans");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_acct_plansResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_plansResponse)) as get_acct_plansResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_payments_on_invoiceResponse get_payments_on_invoice(get_payments_on_invoiceRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_payments_on_invoice");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&src_transaction_id=" + request.src_transaction_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_payments_on_invoiceResponse myDeserializedObj = json.Deserialize(reader, typeof(get_payments_on_invoiceResponse)) as get_payments_on_invoiceResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_user_id_from_acct_noResponse get_user_id_from_acct_no(get_user_id_from_acct_noRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_user_id_from_acct_no");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_user_id_from_acct_noResponse myDeserializedObj = json.Deserialize(reader, typeof(get_user_id_from_acct_noResponse)) as get_user_id_from_acct_noResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_client_plans_basicResponse get_client_plans_basic(get_client_plans_basicRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_client_plans_basic");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&plan_no=" + request.plan_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_client_plans_basicResponse myDeserializedObj = json.Deserialize(reader, typeof(get_client_plans_basicResponse)) as get_client_plans_basicResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_pending_invoice_noResponse get_pending_invoice_no(get_pending_invoice_noRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_pending_invoice_no");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_pending_invoice_noResponse myDeserializedObj = json.Deserialize(reader, typeof(get_pending_invoice_noResponse)) as get_pending_invoice_noResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public cancel_orderResponse cancel_order(cancel_orderRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("cancel_order");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&order_no=" + request.order_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            cancel_orderResponse myDeserializedObj = json.Deserialize(reader, typeof(cancel_orderResponse)) as cancel_orderResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_acct_notify_methodResponse get_acct_notify_method(get_acct_notify_methodRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_notify_method");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_no=" + request.account_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_acct_notify_methodResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_notify_methodResponse)) as get_acct_notify_methodResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_available_plans_allResponse get_available_plans_all(get_available_plans_allRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_available_plans_all");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_available_plans_allResponse myDeserializedObj = json.Deserialize(reader, typeof(get_available_plans_allResponse)) as get_available_plans_allResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public set_service_plan_numberResponse set_service_plan_number(set_service_plan_numberRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("set_service_plan_number");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_no=" + request.account_no;
            url += "&plan_no=" + request.plan_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            set_service_plan_numberResponse myDeserializedObj = json.Deserialize(reader, typeof(set_service_plan_numberResponse)) as set_service_plan_numberResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public save_paypal_bill_agreementResponse save_paypal_bill_agreement(save_paypal_bill_agreementRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("save_paypal_bill_agreement");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&token=" + request.token;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            save_paypal_bill_agreementResponse myDeserializedObj = json.Deserialize(reader, typeof(save_paypal_bill_agreementResponse)) as save_paypal_bill_agreementResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_acct_no_from_user_idResponse get_acct_no_from_user_id(get_acct_no_from_user_idRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_no_from_user_id");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&user_id=" + request.user_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_acct_no_from_user_idResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_no_from_user_idResponse)) as get_acct_no_from_user_idResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public create_advanced_service_creditResponse create_advanced_service_credit(create_advanced_service_creditRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("create_advanced_service_credit");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&amount=" + request.amount;
            url += "&reason_code=" + request.reason_code;
            url += "&comments=" + request.comments;
            url += "&eligible_plan_no=" + request.eligible_plan_no;
            url += "&eligible_service_no=" + request.eligible_service_no;
            url += "&alt_service_no_to_apply=" + request.alt_service_no_to_apply;
            url += "&frequency_no=" + request.frequency_no;
            url += "&frequency_interval_months=" + request.frequency_interval_months;
            url += "&initial_credit_date=" + request.initial_credit_date;
            url += "&percent_amount=" + request.percent_amount;
            url += "&percent_eval_plan_no=" + request.percent_eval_plan_no;
            url += "&percent_eval_service_no=" + request.percent_eval_service_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            create_advanced_service_creditResponse myDeserializedObj = json.Deserialize(reader, typeof(create_advanced_service_creditResponse)) as create_advanced_service_creditResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public set_reg_uss_config_paramsResponse set_reg_uss_config_params(set_reg_uss_config_paramsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("set_reg_uss_config_params");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&set_name=" + request.set_name;
            RestUtilities.addParameterValuesFromArray(ref url, request.in_reg_uss_config_params);

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            set_reg_uss_config_paramsResponse myDeserializedObj = json.Deserialize(reader, typeof(set_reg_uss_config_paramsResponse)) as set_reg_uss_config_paramsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public set_reg_uss_paramsResponse set_reg_uss_params(set_reg_uss_paramsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("set_reg_uss_params");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&session_id=" + request.session_id;
            url += "&override_timeout_minutes=" + request.override_timeout_minutes;
            RestUtilities.addParameterValuesFromArray(ref url, request.in_reg_uss_params);

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            set_reg_uss_paramsResponse myDeserializedObj = json.Deserialize(reader, typeof(set_reg_uss_paramsResponse)) as set_reg_uss_paramsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_family_trans_historyResponse get_family_trans_history(get_family_trans_historyRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_family_trans_history");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&parent_acct_no=" + request.parent_acct_no;
            url += "&do_multi_level=" + request.do_multi_level;
            url += "&trans_type=" + request.trans_type;
            url += "&start_date=" + request.start_date;
            url += "&end_date=" + request.end_date;
            url += "&record_limit=" + request.record_limit;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_family_trans_historyResponse myDeserializedObj = json.Deserialize(reader, typeof(get_family_trans_historyResponse)) as get_family_trans_historyResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public void_transactionResponse void_transaction(void_transactionRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("void_transaction");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_no=" + request.account_no;
            url += "&transaction_id=" + request.transaction_id;
            url += "&comments=" + request.comments;
            url += "&reason_code=" + request.reason_code;
            url += "&client_receipt_id=" + request.client_receipt_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            void_transactionResponse myDeserializedObj = json.Deserialize(reader, typeof(void_transactionResponse)) as void_transactionResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public update_acct_contactResponse update_acct_contact(update_acct_contactRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("update_acct_contact");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_no=" + request.account_no;
            url += "&first_name=" + request.first_name;
            url += "&last_name=" + request.last_name;
            url += "&mi=" + request.mi;
            url += "&company_name=" + request.company_name;
            url += "&address1=" + request.address1;
            url += "&address2=" + request.address2;
            url += "&city=" + request.city;
            url += "&locality=" + request.locality;
            url += "&state_prov=" + request.state_prov;
            url += "&country=" + request.country;
            url += "&postal_code=" + request.postal_code;
            url += "&intl_phone=" + request.intl_phone;
            url += "&alt_email=" + request.alt_email;
            url += "&birthdate=" + request.birthdate;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            update_acct_contactResponse myDeserializedObj = json.Deserialize(reader, typeof(update_acct_contactResponse)) as update_acct_contactResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public update_acct_billing_contactResponse update_acct_billing_contact(update_acct_billing_contactRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("update_acct_billing_contact");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_no=" + request.account_no;
            url += "&first_name=" + request.first_name;
            url += "&last_name=" + request.last_name;
            url += "&middle_initial=" + request.middle_initial;
            url += "&company_name=" + request.company_name;
            url += "&address1=" + request.address1;
            url += "&address2=" + request.address2;
            url += "&city=" + request.city;
            url += "&locality=" + request.locality;
            url += "&state=" + request.state;
            url += "&country=" + request.country;
            url += "&zip=" + request.zip;
            url += "&intl_phone=" + request.intl_phone;
            url += "&email=" + request.email;
            url += "&do_collect=" + request.do_collect;
            url += "&change_status_after_coll=" + request.change_status_after_coll;
            url += "&reset_dates_after_status=" + request.reset_dates_after_status;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            update_acct_billing_contactResponse myDeserializedObj = json.Deserialize(reader, typeof(update_acct_billing_contactResponse)) as update_acct_billing_contactResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public create_acct_plan_contractResponse create_acct_plan_contract(create_acct_plan_contractRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("create_acct_plan_contract");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&plan_no=" + request.plan_no;
            url += "&type_no=" + request.type_no;
            url += "&alt_recur_fee=" + request.alt_recur_fee;
            url += "&length_months=" + request.length_months;
            url += "&cancel_fee=" + request.cancel_fee;
            url += "&create_comments=" + request.create_comments;
            url += "&start_date=" + request.start_date;
            url += "&do_auto_discard=" + request.do_auto_discard;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            create_acct_plan_contractResponse myDeserializedObj = json.Deserialize(reader, typeof(create_acct_plan_contractResponse)) as create_acct_plan_contractResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public send_acct_emailResponse send_acct_email(send_acct_emailRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("send_acct_email");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&user_id=" + request.user_id;
            url += "&template_class=" + request.template_class;
            url += "&template_no=" + request.template_no;
            url += "&client_receipt_id=" + request.client_receipt_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            send_acct_emailResponse myDeserializedObj = json.Deserialize(reader, typeof(send_acct_emailResponse)) as send_acct_emailResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public record_out_going_paymentResponse record_out_going_payment(record_out_going_paymentRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("record_out_going_payment");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_no=" + request.account_no;
            url += "&reference_code=" + request.reference_code;
            url += "&payment_amount=" + request.payment_amount;
            url += "&comments=" + request.comments;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            record_out_going_paymentResponse myDeserializedObj = json.Deserialize(reader, typeof(record_out_going_paymentResponse)) as record_out_going_paymentResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public send_arc_threshold_emailResponse send_arc_threshold_email(send_arc_threshold_emailRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("send_arc_threshold_email");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&resource_name=" + request.resource_name;
            url += "&resource_units_label=" + request.resource_units_label;
            url += "&resource_threshold_level=" + request.resource_threshold_level;
            url += "&resource_balance=" + request.resource_balance;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            send_arc_threshold_emailResponse myDeserializedObj = json.Deserialize(reader, typeof(send_arc_threshold_emailResponse)) as send_arc_threshold_emailResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public toggle_test_accountResponse toggle_test_account(toggle_test_accountRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("toggle_test_account");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_no=" + request.account_no;
            url += "&test_acct_ind=" + request.test_acct_ind;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            toggle_test_accountResponse myDeserializedObj = json.Deserialize(reader, typeof(toggle_test_accountResponse)) as toggle_test_accountResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_usage_historyResponse get_usage_history(get_usage_historyRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_usage_history");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&specified_usage_type_no=" + request.specified_usage_type_no;
            url += "&date_range_start=" + request.date_range_start;
            url += "&date_range_end=" + request.date_range_end;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_usage_historyResponse myDeserializedObj = json.Deserialize(reader, typeof(get_usage_historyResponse)) as get_usage_historyResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public reinstate_transactionResponse reinstate_transaction(reinstate_transactionRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("reinstate_transaction");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_no=" + request.account_no;
            url += "&transaction_id=" + request.transaction_id;
            url += "&comments=" + request.comments;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            reinstate_transactionResponse myDeserializedObj = json.Deserialize(reader, typeof(reinstate_transactionResponse)) as reinstate_transactionResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public assign_custom_acct_ratesResponse assign_custom_acct_rates(assign_custom_acct_ratesRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("assign_custom_acct_rates");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&plan_no=" + request.plan_no;
            url += "&service_no=" + request.service_no;
            RestUtilities.addParameterValuesFromArray(ref url, request.custom_acct_rates);

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            assign_custom_acct_ratesResponse myDeserializedObj = json.Deserialize(reader, typeof(assign_custom_acct_ratesResponse)) as assign_custom_acct_ratesResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_acct_plans_allResponse get_acct_plans_all(get_acct_plans_allRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_plans_all");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_acct_plans_allResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_plans_allResponse)) as get_acct_plans_allResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_auf_statusResponse get_auf_status(get_auf_statusRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_auf_status");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&file_name=" + request.file_name;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_auf_statusResponse myDeserializedObj = json.Deserialize(reader, typeof(get_auf_statusResponse)) as get_auf_statusResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public manage_pending_invoiceResponse manage_pending_invoice(manage_pending_invoiceRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("manage_pending_invoice");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&invoice_no=" + request.invoice_no;
            url += "&acct_no=" + request.acct_no;
            url += "&action_directive=" + request.action_directive;
            url += "&bill_seq=" + request.bill_seq;
            url += "&alt_pay_method=" + request.alt_pay_method;
            url += "&cc_number=" + request.cc_number;
            url += "&cc_expire_mm=" + request.cc_expire_mm;
            url += "&cc_expire_yyyy=" + request.cc_expire_yyyy;
            url += "&bank_routing_num=" + request.bank_routing_num;
            url += "&bank_acct_num=" + request.bank_acct_num;
            url += "&bill_company_name=" + request.bill_company_name;
            url += "&bill_first_name=" + request.bill_first_name;
            url += "&bill_middle_initial=" + request.bill_middle_initial;
            url += "&bill_last_name=" + request.bill_last_name;
            url += "&bill_address1=" + request.bill_address1;
            url += "&bill_address2=" + request.bill_address2;
            url += "&bill_city=" + request.bill_city;
            url += "&bill_locality=" + request.bill_locality;
            url += "&bill_state_prov=" + request.bill_state_prov;
            url += "&bill_zip=" + request.bill_zip;
            url += "&bill_country=" + request.bill_country;
            url += "&bill_email=" + request.bill_email;
            url += "&bill_phone=" + request.bill_phone;
            url += "&bill_phone_extension=" + request.bill_phone_extension;
            url += "&bill_cell_phone=" + request.bill_cell_phone;
            url += "&bill_work_phone=" + request.bill_work_phone;
            url += "&bill_work_phone_extension=" + request.bill_work_phone_extension;
            url += "&cvv=" + request.cvv;
            url += "&alt_collect_on_approve=" + request.alt_collect_on_approve;
            url += "&alt_send_statement_on_approve=" + request.alt_send_statement_on_approve;
            url += "&cancel_orders_on_discard=" + request.cancel_orders_on_discard;
            url += "&bank_acct_type=" + request.bank_acct_type;
            url += "&bill_drivers_license_no=" + request.bill_drivers_license_no;
            url += "&bill_drivers_license_state=" + request.bill_drivers_license_state;
            url += "&bill_taxpayer_id=" + request.bill_taxpayer_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            manage_pending_invoiceResponse myDeserializedObj = json.Deserialize(reader, typeof(manage_pending_invoiceResponse)) as manage_pending_invoiceResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public set_payment_responsibilityResponse set_payment_responsibility(set_payment_responsibilityRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("set_payment_responsibility");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_no=" + request.account_no;
            url += "&resp_level_cd=" + request.resp_level_cd;
            url += "&senior_account_no=" + request.senior_account_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            set_payment_responsibilityResponse myDeserializedObj = json.Deserialize(reader, typeof(set_payment_responsibilityResponse)) as set_payment_responsibilityResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public disable_standing_usageResponse disable_standing_usage(disable_standing_usageRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("disable_standing_usage");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&standing_usage_rec_no=" + request.standing_usage_rec_no;
            url += "&comments=" + request.comments;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            disable_standing_usageResponse myDeserializedObj = json.Deserialize(reader, typeof(disable_standing_usageResponse)) as disable_standing_usageResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_reg_uss_config_paramsResponse get_reg_uss_config_params(get_reg_uss_config_paramsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_reg_uss_config_params");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&set_name=" + request.set_name;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_reg_uss_config_paramsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_reg_uss_config_paramsResponse)) as get_reg_uss_config_paramsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_payment_methodsResponse get_payment_methods(get_payment_methodsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_payment_methods");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_no=" + request.account_no;
            url += "&seq_no=" + request.seq_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_payment_methodsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_payment_methodsResponse)) as get_payment_methodsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public update_existing_billing_infoResponse update_existing_billing_info(update_existing_billing_infoRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("update_existing_billing_info");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&seq_no=" + request.seq_no;
            url += "&address1=" + request.address1;
            url += "&address2=" + request.address2;
            url += "&city=" + request.city;
            url += "&state=" + request.state;
            url += "&zip=" + request.zip;
            url += "&country=" + request.country;
            url += "&cc_expire_mm=" + request.cc_expire_mm;
            url += "&cc_expire_yyyy=" + request.cc_expire_yyyy;
            url += "&phone_npa=" + request.phone_npa;
            url += "&phone_nxx=" + request.phone_nxx;
            url += "&phone_suffix=" + request.phone_suffix;
            url += "&phone_ext=" + request.phone_ext;
            url += "&phone_country_cd=" + request.phone_country_cd;
            url += "&intl_phone=" + request.intl_phone;
            url += "&email=" + request.email;
            url += "&locality=" + request.locality;
            url += "&cell_phone_npa=" + request.cell_phone_npa;
            url += "&cell_phone_nxx=" + request.cell_phone_nxx;
            url += "&cell_phone_suffix=" + request.cell_phone_suffix;
            url += "&work_phone_npa=" + request.work_phone_npa;
            url += "&work_phone_nxx=" + request.work_phone_nxx;
            url += "&work_phone_suffix=" + request.work_phone_suffix;
            url += "&work_phone_ext=" + request.work_phone_ext;
            url += "&do_collect=" + request.do_collect;
            url += "&change_status_after_coll=" + request.change_status_after_coll;
            url += "&reset_dates_after_status=" + request.reset_dates_after_status;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            update_existing_billing_infoResponse myDeserializedObj = json.Deserialize(reader, typeof(update_existing_billing_infoResponse)) as update_existing_billing_infoResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_invoice_detailsResponse get_invoice_details(get_invoice_detailsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_invoice_details");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&src_transaction_id=" + request.src_transaction_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_invoice_detailsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_invoice_detailsResponse)) as get_invoice_detailsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_acct_details_allResponse get_acct_details_all(get_acct_details_allRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_details_all");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_acct_details_allResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_details_allResponse)) as get_acct_details_allResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_client_plans_allResponse get_client_plans_all(get_client_plans_allRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_client_plans_all");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&plan_no=" + request.plan_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_client_plans_allResponse myDeserializedObj = json.Deserialize(reader, typeof(get_client_plans_allResponse)) as get_client_plans_allResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public subscribe_event_classResponse subscribe_event_class(subscribe_event_classRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("subscribe_event_class");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&class_no=" + request.class_no;
            url += "&do_write=" + request.do_write;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            subscribe_event_classResponse myDeserializedObj = json.Deserialize(reader, typeof(subscribe_event_classResponse)) as subscribe_event_classResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public update_acct_credentialsResponse update_acct_credentials(update_acct_credentialsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("update_acct_credentials");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_no=" + request.account_no;
            url += "&password=" + request.password;
            url += "&secret_question_answer=" + request.secret_question_answer;
            url += "&secret_question=" + request.secret_question;
            url += "&pin=" + request.pin;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            update_acct_credentialsResponse myDeserializedObj = json.Deserialize(reader, typeof(update_acct_credentialsResponse)) as update_acct_credentialsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public record_standing_orderResponse record_standing_order(record_standing_orderRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("record_standing_order");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_no=" + request.account_no;
            url += "&billing_interval_type=" + request.billing_interval_type;
            url += "&billing_interval_units=" + request.billing_interval_units;
            url += "&times_to_bill=" + request.times_to_bill;
            url += "&first_bill_date=" + request.first_bill_date;
            RestUtilities.addParameterValuesFromArray(ref url, request.standing_order);
            url += "&client_order_id=" + request.client_order_id;
            url += "&client_receipt_id=" + request.client_receipt_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            record_standing_orderResponse myDeserializedObj = json.Deserialize(reader, typeof(record_standing_orderResponse)) as record_standing_orderResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_acct_supp_plan_historyResponse get_acct_supp_plan_history(get_acct_supp_plan_historyRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_supp_plan_history");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&plan_no=" + request.plan_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_acct_supp_plan_historyResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_supp_plan_historyResponse)) as get_acct_supp_plan_historyResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_client_plan_service_ratesResponse get_client_plan_service_rates(get_client_plan_service_ratesRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_client_plan_service_rates");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&plan_no=" + request.plan_no;
            url += "&service_no=" + request.service_no;
            url += "&alt_rate_schedule_no=" + request.alt_rate_schedule_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_client_plan_service_ratesResponse myDeserializedObj = json.Deserialize(reader, typeof(get_client_plan_service_ratesResponse)) as get_client_plan_service_ratesResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public set_service_plan_immediatelyResponse set_service_plan_immediately(set_service_plan_immediatelyRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("set_service_plan_immediately");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_no=" + request.account_no;
            url += "&plan_no=" + request.plan_no;
            url += "&client_receipt_id=" + request.client_receipt_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            set_service_plan_immediatelyResponse myDeserializedObj = json.Deserialize(reader, typeof(set_service_plan_immediatelyResponse)) as set_service_plan_immediatelyResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public validate_sessionResponse validate_session(validate_sessionRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("validate_session");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&session_id=" + request.session_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            validate_sessionResponse myDeserializedObj = json.Deserialize(reader, typeof(validate_sessionResponse)) as validate_sessionResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public cancel_standing_orderResponse cancel_standing_order(cancel_standing_orderRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("cancel_standing_order");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&standing_order_no=" + request.standing_order_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            cancel_standing_orderResponse myDeserializedObj = json.Deserialize(reader, typeof(cancel_standing_orderResponse)) as cancel_standing_orderResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public write_acct_commentResponse write_acct_comment(write_acct_commentRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("write_acct_comment");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&comment=" + request.comment;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            write_acct_commentResponse myDeserializedObj = json.Deserialize(reader, typeof(write_acct_commentResponse)) as write_acct_commentResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_acct_commentsResponse get_acct_comments(get_acct_commentsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_comments");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&date_range_start=" + request.date_range_start;
            url += "&date_range_end=" + request.date_range_end;
            url += "&do_url_encoding=" + request.do_url_encoding;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_acct_commentsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_commentsResponse)) as get_acct_commentsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public validate_payment_informationResponse validate_payment_information(validate_payment_informationRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("validate_payment_information");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_no=" + request.account_no;
            url += "&CVV=" + request.CVV;
            url += "&seq_no=" + request.seq_no;
            url += "&inTrackingNumber=" + request.inTrackingNumber;
            url += "&inAuthValue=" + request.inAuthValue;
            url += "&alt_pay_method=" + request.alt_pay_method;
            url += "&cc_number=" + request.cc_number;
            url += "&cc_expire_mm=" + request.cc_expire_mm;
            url += "&cc_expire_yyyy=" + request.cc_expire_yyyy;
            url += "&bill_company_name=" + request.bill_company_name;
            url += "&bill_first_name=" + request.bill_first_name;
            url += "&bill_middle_initial=" + request.bill_middle_initial;
            url += "&bill_last_name=" + request.bill_last_name;
            url += "&bill_address1=" + request.bill_address1;
            url += "&bill_address2=" + request.bill_address2;
            url += "&bill_city=" + request.bill_city;
            url += "&bill_locality=" + request.bill_locality;
            url += "&bill_state_prov=" + request.bill_state_prov;
            url += "&bill_zip=" + request.bill_zip;
            url += "&bill_country=" + request.bill_country;
            url += "&bill_email=" + request.bill_email;
            url += "&bill_phone=" + request.bill_phone;
            url += "&bill_phone_extension=" + request.bill_phone_extension;
            url += "&bill_cell_phone=" + request.bill_cell_phone;
            url += "&bill_work_phone=" + request.bill_work_phone;
            url += "&bill_work_phone_extension=" + request.bill_work_phone_extension;
            url += "&currency_cd=" + request.currency_cd;
            url += "&acct_group_no=" + request.acct_group_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            validate_payment_informationResponse myDeserializedObj = json.Deserialize(reader, typeof(validate_payment_informationResponse)) as validate_payment_informationResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public close_acct_installationResponse close_acct_installation(close_acct_installationRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("close_acct_installation");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&install_complete_ind=" + request.install_complete_ind;
            url += "&comments=" + request.comments;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            close_acct_installationResponse myDeserializedObj = json.Deserialize(reader, typeof(close_acct_installationResponse)) as close_acct_installationResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_supp_plans_by_promo_codeResponse get_supp_plans_by_promo_code(get_supp_plans_by_promo_codeRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_supp_plans_by_promo_code");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&promo_code=" + request.promo_code;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_supp_plans_by_promo_codeResponse myDeserializedObj = json.Deserialize(reader, typeof(get_supp_plans_by_promo_codeResponse)) as get_supp_plans_by_promo_codeResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_child_acctsResponse get_child_accts(get_child_acctsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_child_accts");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&parent_acct_no=" + request.parent_acct_no;
            url += "&do_multi_level=" + request.do_multi_level;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_child_acctsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_child_acctsResponse)) as get_child_acctsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_acct_trans_historyResponse get_acct_trans_history(get_acct_trans_historyRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_trans_history");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_no=" + request.account_no;
            url += "&transaction_type=" + request.transaction_type;
            url += "&start_date=" + request.start_date;
            url += "&end_date=" + request.end_date;
            url += "&record_limit=" + request.record_limit;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_acct_trans_historyResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_trans_historyResponse)) as get_acct_trans_historyResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public authorize_electronic_paymentResponse authorize_electronic_payment(authorize_electronic_paymentRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("authorize_electronic_payment");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_number=" + request.account_number;
            url += "&amount=" + request.amount;
            url += "&payment_source=" + request.payment_source;
            url += "&CVV=" + request.CVV;
            url += "&bill_seq=" + request.bill_seq;
            url += "&inTrackingNumber=" + request.inTrackingNumber;
            url += "&inAuthValue=" + request.inAuthValue;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            authorize_electronic_paymentResponse myDeserializedObj = json.Deserialize(reader, typeof(authorize_electronic_paymentResponse)) as authorize_electronic_paymentResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_rate_schedules_for_planResponse get_rate_schedules_for_plan(get_rate_schedules_for_planRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_rate_schedules_for_plan");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&plan_no=" + request.plan_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_rate_schedules_for_planResponse myDeserializedObj = json.Deserialize(reader, typeof(get_rate_schedules_for_planResponse)) as get_rate_schedules_for_planResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public update_acct_statusResponse update_acct_status(update_acct_statusRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("update_acct_status");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_no=" + request.account_no;
            url += "&status_cd=" + request.status_cd;
            url += "&queue_days=" + request.queue_days;
            url += "&queue_date=" + request.queue_date;
            url += "&force_bill_date_reset=" + request.force_bill_date_reset;
            url += "&comments=" + request.comments;
            url += "&client_receipt_id=" + request.client_receipt_id;
            url += "&alt_do_dunning=" + request.alt_do_dunning;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            update_acct_statusResponse myDeserializedObj = json.Deserialize(reader, typeof(update_acct_statusResponse)) as update_acct_statusResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public set_acct_tax_exempt_statusResponse set_acct_tax_exempt_status(set_acct_tax_exempt_statusRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("set_acct_tax_exempt_status");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&exemption_level=" + request.exemption_level;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            set_acct_tax_exempt_statusResponse myDeserializedObj = json.Deserialize(reader, typeof(set_acct_tax_exempt_statusResponse)) as set_acct_tax_exempt_statusResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_client_itemsResponse get_client_items(get_client_itemsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_client_items");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&in_currency_cd=" + request.in_currency_cd;
            url += "&return_no_cost_items=" + request.return_no_cost_items;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_client_itemsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_client_itemsResponse)) as get_client_itemsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public unsubscribe_eventResponse unsubscribe_event(unsubscribe_eventRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("unsubscribe_event");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&event_id=" + request.event_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            unsubscribe_eventResponse myDeserializedObj = json.Deserialize(reader, typeof(unsubscribe_eventResponse)) as unsubscribe_eventResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public modify_supp_planResponse modify_supp_plan(modify_supp_planRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("modify_supp_plan");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&supp_plan_no=" + request.supp_plan_no;
            url += "&alt_rate_schedule_no=" + request.alt_rate_schedule_no;
            url += "&num_plan_units=" + request.num_plan_units;
            url += "&coupon_code=" + request.coupon_code;
            url += "&assignment_directive=" + request.assignment_directive;
            url += "&comments=" + request.comments;
            url += "&do_write=" + request.do_write;
            url += "&client_receipt_id=" + request.client_receipt_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            modify_supp_planResponse myDeserializedObj = json.Deserialize(reader, typeof(modify_supp_planResponse)) as modify_supp_planResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public replace_supp_planResponse replace_supp_plan(replace_supp_planRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("replace_supp_plan");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&existing_supp_plan_no=" + request.existing_supp_plan_no;
            url += "&new_supp_plan_no=" + request.new_supp_plan_no;
            url += "&alt_rate_schedule_no=" + request.alt_rate_schedule_no;
            url += "&num_plan_units=" + request.num_plan_units;
            url += "&coupon_code=" + request.coupon_code;
            url += "&assignment_directive=" + request.assignment_directive;
            url += "&comments=" + request.comments;
            url += "&do_write=" + request.do_write;
            url += "&client_receipt_id=" + request.client_receipt_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            replace_supp_planResponse myDeserializedObj = json.Deserialize(reader, typeof(replace_supp_planResponse)) as replace_supp_planResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public record_external_paymentResponse record_external_payment(record_external_paymentRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("record_external_payment");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_no=" + request.account_no;
            url += "&reference_code=" + request.reference_code;
            url += "&payment_amount=" + request.payment_amount;
            url += "&comments=" + request.comments;
            url += "&client_receipt_id=" + request.client_receipt_id;
            RestUtilities.addParameterValuesFromArray(ref url, request.specific_charge_transaction_id);

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            record_external_paymentResponse myDeserializedObj = json.Deserialize(reader, typeof(record_external_paymentResponse)) as record_external_paymentResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public ban_acctResponse ban_acct(ban_acctRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("ban_acct");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_no=" + request.account_no;
            url += "&userid=" + request.userid;
            url += "&days_to_restore=" + request.days_to_restore;
            url += "&date_to_restore=" + request.date_to_restore;
            url += "&reason_cd=" + request.reason_cd;
            url += "&comments=" + request.comments;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            ban_acctResponse myDeserializedObj = json.Deserialize(reader, typeof(ban_acctResponse)) as ban_acctResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public assign_supp_planResponse assign_supp_plan(assign_supp_planRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("assign_supp_plan");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&supp_plan_no=" + request.supp_plan_no;
            url += "&alt_rate_schedule_no=" + request.alt_rate_schedule_no;
            url += "&num_plan_units=" + request.num_plan_units;
            url += "&coupon_code=" + request.coupon_code;
            url += "&assignment_directive=" + request.assignment_directive;
            url += "&comments=" + request.comments;
            url += "&do_write=" + request.do_write;
            url += "&client_receipt_id=" + request.client_receipt_id;
            url += "&contract_type_no=" + request.contract_type_no;
            url += "&contract_alt_recur_fee=" + request.contract_alt_recur_fee;
            url += "&contract_length_months=" + request.contract_length_months;
            url += "&contract_cancel_fee=" + request.contract_cancel_fee;
            url += "&contract_comments=" + request.contract_comments;
            url += "&contract_start_date=" + request.contract_start_date;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            assign_supp_planResponse myDeserializedObj = json.Deserialize(reader, typeof(assign_supp_planResponse)) as assign_supp_planResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public cancel_acct_plan_contractResponse cancel_acct_plan_contract(cancel_acct_plan_contractRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("cancel_acct_plan_contract");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&contract_no=" + request.contract_no;
            url += "&update_comments=" + request.update_comments;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            cancel_acct_plan_contractResponse myDeserializedObj = json.Deserialize(reader, typeof(cancel_acct_plan_contractResponse)) as cancel_acct_plan_contractResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public remove_custom_acct_ratesResponse remove_custom_acct_rates(remove_custom_acct_ratesRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("remove_custom_acct_rates");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&plan_no=" + request.plan_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            remove_custom_acct_ratesResponse myDeserializedObj = json.Deserialize(reader, typeof(remove_custom_acct_ratesResponse)) as remove_custom_acct_ratesResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public apply_coupon_to_acctResponse apply_coupon_to_acct(apply_coupon_to_acctRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("apply_coupon_to_acct");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&coupon_code=" + request.coupon_code;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            apply_coupon_to_acctResponse myDeserializedObj = json.Deserialize(reader, typeof(apply_coupon_to_acctResponse)) as apply_coupon_to_acctResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_avail_child_plans_for_plan_allResponse get_avail_child_plans_for_plan_all(get_avail_child_plans_for_plan_allRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_avail_child_plans_for_plan_all");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&in_plan_no=" + request.in_plan_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_avail_child_plans_for_plan_allResponse myDeserializedObj = json.Deserialize(reader, typeof(get_avail_child_plans_for_plan_allResponse)) as get_avail_child_plans_for_plan_allResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public subscribe_eventsResponse subscribe_events(subscribe_eventsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("subscribe_events");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            RestUtilities.addParameterValuesFromArray(ref url, request.event_list);

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            subscribe_eventsResponse myDeserializedObj = json.Deserialize(reader, typeof(subscribe_eventsResponse)) as subscribe_eventsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_acct_plan_historyResponse get_acct_plan_history(get_acct_plan_historyRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_plan_history");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_number=" + request.account_number;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_acct_plan_historyResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_plan_historyResponse)) as get_acct_plan_historyResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_acct_tax_exempt_statusResponse get_acct_tax_exempt_status(get_acct_tax_exempt_statusRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_tax_exempt_status");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_acct_tax_exempt_statusResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_tax_exempt_statusResponse)) as get_acct_tax_exempt_statusResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public disable_standing_usage_by_planResponse disable_standing_usage_by_plan(disable_standing_usage_by_planRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("disable_standing_usage_by_plan");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&plan_no=" + request.plan_no;
            url += "&comments=" + request.comments;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            disable_standing_usage_by_planResponse myDeserializedObj = json.Deserialize(reader, typeof(disable_standing_usage_by_planResponse)) as disable_standing_usage_by_planResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_standing_usageResponse get_standing_usage(get_standing_usageRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_standing_usage");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_standing_usageResponse myDeserializedObj = json.Deserialize(reader, typeof(get_standing_usageResponse)) as get_standing_usageResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public update_acct_completeResponse update_acct_complete(update_acct_completeRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("update_acct_complete");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&first_name=" + request.first_name;
            url += "&last_name=" + request.last_name;
            url += "&middle_initial=" + request.middle_initial;
            url += "&company_name=" + request.company_name;
            url += "&address1=" + request.address1;
            url += "&address2=" + request.address2;
            url += "&city=" + request.city;
            url += "&locality=" + request.locality;
            url += "&state_prov=" + request.state_prov;
            url += "&country=" + request.country;
            url += "&postal_cd=" + request.postal_cd;
            url += "&phone=" + request.phone;
            url += "&phone_ext=" + request.phone_ext;
            url += "&cell_phone=" + request.cell_phone;
            url += "&work_phone=" + request.work_phone;
            url += "&work_phone_ext=" + request.work_phone_ext;
            url += "&email=" + request.email;
            url += "&birthdate=" + request.birthdate;
            url += "&bill_first_name=" + request.bill_first_name;
            url += "&bill_last_name=" + request.bill_last_name;
            url += "&bill_middle_initial=" + request.bill_middle_initial;
            url += "&bill_company_name=" + request.bill_company_name;
            url += "&bill_address1=" + request.bill_address1;
            url += "&bill_address2=" + request.bill_address2;
            url += "&bill_city=" + request.bill_city;
            url += "&bill_locality=" + request.bill_locality;
            url += "&bill_state_prov=" + request.bill_state_prov;
            url += "&bill_country=" + request.bill_country;
            url += "&bill_postal_cd=" + request.bill_postal_cd;
            url += "&bill_phone=" + request.bill_phone;
            url += "&bill_phone_ext=" + request.bill_phone_ext;
            url += "&bill_cell_phone=" + request.bill_cell_phone;
            url += "&bill_work_phone=" + request.bill_work_phone;
            url += "&bill_work_phone_ext=" + request.bill_work_phone_ext;
            url += "&bill_email=" + request.bill_email;
            url += "&pay_method=" + request.pay_method;
            url += "&cc_number=" + request.cc_number;
            url += "&cc_expire_mm=" + request.cc_expire_mm;
            url += "&cc_expire_yyyy=" + request.cc_expire_yyyy;
            url += "&bank_routing_num=" + request.bank_routing_num;
            url += "&bank_acct_num=" + request.bank_acct_num;
            url += "&master_plan_no=" + request.master_plan_no;
            url += "&master_plan_alt_rate_sched_no=" + request.master_plan_alt_rate_sched_no;
            url += "&master_plan_units=" + request.master_plan_units;
            url += "&master_plan_assign_directive=" + request.master_plan_assign_directive;
            RestUtilities.addParameterValuesFromArray(ref url, request.update_acct_supp_field);
            RestUtilities.addParameterValuesFromArray(ref url, request.update_acct_func_group);
            RestUtilities.addParameterValuesFromArray(ref url, request.update_acct_coll_group);
            url += "&status_cd=" + request.status_cd;
            url += "&notify_method=" + request.notify_method;
            url += "&password=" + request.password;
            url += "&secret_question=" + request.secret_question;
            url += "&secret_question_answer=" + request.secret_question_answer;
            url += "&pin=" + request.pin;
            url += "&test_acct_ind=" + request.test_acct_ind;
            url += "&resp_level_cd=" + request.resp_level_cd;
            url += "&senior_acct_no=" + request.senior_acct_no;
            url += "&client_acct_id=" + request.client_acct_id;
            url += "&do_collect=" + request.do_collect;
            url += "&change_status_after_coll=" + request.change_status_after_coll;
            url += "&reset_dates_after_status=" + request.reset_dates_after_status;
            url += "&client_receipt_id=" + request.client_receipt_id;
            url += "&alt_do_dunning=" + request.alt_do_dunning;
            url += "&force_currency_change=" + request.force_currency_change;
            url += "&cvv=" + request.cvv;
            url += "&taxpayer_id=" + request.taxpayer_id;
            url += "&bill_agreement_id=" + request.bill_agreement_id;
            url += "&bank_acct_type=" + request.bank_acct_type;
            url += "&bill_drivers_license_no=" + request.bill_drivers_license_no;
            url += "&bill_drivers_license_state=" + request.bill_drivers_license_state;
            url += "&bill_taxpayer_id=" + request.bill_taxpayer_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            update_acct_completeResponse myDeserializedObj = json.Deserialize(reader, typeof(update_acct_completeResponse)) as update_acct_completeResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_payment_applicationsResponse get_payment_applications(get_payment_applicationsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_payment_applications");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&src_transaction_id=" + request.src_transaction_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_payment_applicationsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_payment_applicationsResponse)) as get_payment_applicationsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_all_actions_by_receipt_idResponse get_all_actions_by_receipt_id(get_all_actions_by_receipt_idRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_all_actions_by_receipt_id");
            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&client_receipt_id=" + request.client_receipt_id;

            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                ObjectCreationHandling = ObjectCreationHandling.Replace,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ReferenceLoopHandling = ReferenceLoopHandling.Ignore
            };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_all_actions_by_receipt_idResponse myDeserializedObj = json.Deserialize(reader, typeof(get_all_actions_by_receipt_idResponse)) as get_all_actions_by_receipt_idResponse;
            reader.Close();
            return myDeserializedObj;
        }

        #endregion Api Calls
    }
}