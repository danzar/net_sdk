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
        public AriaBillingComplete() : this ("https://secure.unstable.dev.ariasystems.net/api/ws/api_ws_class_dispatcher.php")
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
            return "application/Json";
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
            url += "&acct_no=" + request.acct_no;
            url += "&promo_code=" + request.promo_code;
            url += "&parent_plan_no=" + request.parent_plan_no;
            RestUtilities.addParameterValuesFromArray(ref url, request.supp_field_names);
            RestUtilities.addParameterValuesFromArray(ref url, request.supp_field_values);
            url += "&include_all_rate_schedules=" + request.include_all_rate_schedules;
            url += "&include_plan_hierarchy=" + request.include_plan_hierarchy;
            
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

        public get_client_itemsResponse get_client_items(get_client_itemsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_client_items");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&filter_currency_cd=" + request.filter_currency_cd;
            url += "&return_no_cost_items=" + request.return_no_cost_items;
            url += "&filter_item_no=" + request.filter_item_no;
            
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

        public get_client_items_allResponse get_client_items_all(get_client_items_allRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_client_items_all");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&filter_currency_cd=" + request.filter_currency_cd;
            url += "&return_no_cost_items=" + request.return_no_cost_items;
            url += "&filter_item_no=" + request.filter_item_no;
            
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
            get_client_items_allResponse myDeserializedObj = json.Deserialize(reader, typeof(get_client_items_allResponse)) as get_client_items_allResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_client_item_pricesResponse get_client_item_prices(get_client_item_pricesRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_client_item_prices");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&filter_item_no=" + request.filter_item_no;
            url += "&filter_currency_cd=" + request.filter_currency_cd;
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
            get_client_item_pricesResponse myDeserializedObj = json.Deserialize(reader, typeof(get_client_item_pricesResponse)) as get_client_item_pricesResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_client_item_supp_fieldsResponse get_client_item_supp_fields(get_client_item_supp_fieldsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_client_item_supp_fields");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&filter_item_no=" + request.filter_item_no;
            
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
            get_client_item_supp_fieldsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_client_item_supp_fieldsResponse)) as get_client_item_supp_fieldsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_client_item_classesResponse get_client_item_classes(get_client_item_classesRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_client_item_classes");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&filter_item_no=" + request.filter_item_no;
            
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
            get_client_item_classesResponse myDeserializedObj = json.Deserialize(reader, typeof(get_client_item_classesResponse)) as get_client_item_classesResponse;
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
            get_rate_schedules_for_planResponse myDeserializedObj = json.Deserialize(reader, typeof(get_rate_schedules_for_planResponse)) as get_rate_schedules_for_planResponse;
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

        public get_client_items_basicResponse get_client_items_basic(get_client_items_basicRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_client_items_basic");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&filter_currency_cd=" + request.filter_currency_cd;
            url += "&return_no_cost_items=" + request.return_no_cost_items;
            url += "&filter_item_no=" + request.filter_item_no;
            
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
            get_client_items_basicResponse myDeserializedObj = json.Deserialize(reader, typeof(get_client_items_basicResponse)) as get_client_items_basicResponse;
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
            RestUtilities.addParameterValuesFromArray(ref url, request.in_reg_uss_params);
            url += "&override_timeout_minutes=" + request.override_timeout_minutes;
            
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

        public delete_reg_uss_paramsResponse delete_reg_uss_params(delete_reg_uss_paramsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("delete_reg_uss_params");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&session_id=" + request.session_id;
            RestUtilities.addParameterValuesFromArray(ref url, request.param_names);
            
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
            delete_reg_uss_paramsResponse myDeserializedObj = json.Deserialize(reader, typeof(delete_reg_uss_paramsResponse)) as delete_reg_uss_paramsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public replace_reg_uss_paramsResponse replace_reg_uss_params(replace_reg_uss_paramsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("replace_reg_uss_params");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&session_id=" + request.session_id;
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
            replace_reg_uss_paramsResponse myDeserializedObj = json.Deserialize(reader, typeof(replace_reg_uss_paramsResponse)) as replace_reg_uss_paramsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public clear_reg_uss_paramsResponse clear_reg_uss_params(clear_reg_uss_paramsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("clear_reg_uss_params");

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
            clear_reg_uss_paramsResponse myDeserializedObj = json.Deserialize(reader, typeof(clear_reg_uss_paramsResponse)) as clear_reg_uss_paramsResponse;
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
            url += "&set_description=" + request.set_description;
            url += "&set_type_no=" + request.set_type_no;
            
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

        public delete_reg_uss_config_paramsResponse delete_reg_uss_config_params(delete_reg_uss_config_paramsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("delete_reg_uss_config_params");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&set_name=" + request.set_name;
            RestUtilities.addParameterValuesFromArray(ref url, request.param_names);
            
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
            delete_reg_uss_config_paramsResponse myDeserializedObj = json.Deserialize(reader, typeof(delete_reg_uss_config_paramsResponse)) as delete_reg_uss_config_paramsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public replace_reg_uss_config_paramsResponse replace_reg_uss_config_params(replace_reg_uss_config_paramsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("replace_reg_uss_config_params");

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
            replace_reg_uss_config_paramsResponse myDeserializedObj = json.Deserialize(reader, typeof(replace_reg_uss_config_paramsResponse)) as replace_reg_uss_config_paramsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public clear_reg_uss_config_paramsResponse clear_reg_uss_config_params(clear_reg_uss_config_paramsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("clear_reg_uss_config_params");

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
            clear_reg_uss_config_paramsResponse myDeserializedObj = json.Deserialize(reader, typeof(clear_reg_uss_config_paramsResponse)) as clear_reg_uss_config_paramsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public update_inventory_item_stockResponse update_inventory_item_stock(update_inventory_item_stockRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("update_inventory_item_stock");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            RestUtilities.addParameterValuesFromArray(ref url, request.inventory_item_stock);
            
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
            update_inventory_item_stockResponse myDeserializedObj = json.Deserialize(reader, typeof(update_inventory_item_stockResponse)) as update_inventory_item_stockResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_client_currenciesResponse get_client_currencies(get_client_currenciesRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_client_currencies");

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
            get_client_currenciesResponse myDeserializedObj = json.Deserialize(reader, typeof(get_client_currenciesResponse)) as get_client_currenciesResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_client_item_imagesResponse get_client_item_images(get_client_item_imagesRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_client_item_images");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&item_no=" + request.item_no;
            
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
            get_client_item_imagesResponse myDeserializedObj = json.Deserialize(reader, typeof(get_client_item_imagesResponse)) as get_client_item_imagesResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_top_level_item_classResponse get_top_level_item_class(get_top_level_item_classRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_top_level_item_class");

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
            get_top_level_item_classResponse myDeserializedObj = json.Deserialize(reader, typeof(get_top_level_item_classResponse)) as get_top_level_item_classResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_parent_for_item_classResponse get_parent_for_item_class(get_parent_for_item_classRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_parent_for_item_class");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&filter_class_no=" + request.filter_class_no;
            
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
            get_parent_for_item_classResponse myDeserializedObj = json.Deserialize(reader, typeof(get_parent_for_item_classResponse)) as get_parent_for_item_classResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_child_for_item_classResponse get_child_for_item_class(get_child_for_item_classRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_child_for_item_class");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&filter_class_no=" + request.filter_class_no;
            
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
            get_child_for_item_classResponse myDeserializedObj = json.Deserialize(reader, typeof(get_child_for_item_classResponse)) as get_child_for_item_classResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_items_by_classResponse get_items_by_class(get_items_by_classRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_items_by_class");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&filter_class_no=" + request.filter_class_no;
            
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
            get_items_by_classResponse myDeserializedObj = json.Deserialize(reader, typeof(get_items_by_classResponse)) as get_items_by_classResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_master_plans_by_supp_fieldResponse get_master_plans_by_supp_field(get_master_plans_by_supp_fieldRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_master_plans_by_supp_field");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&field_val=" + request.field_val;
            url += "&field_no=" + request.field_no;
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
            get_master_plans_by_supp_fieldResponse myDeserializedObj = json.Deserialize(reader, typeof(get_master_plans_by_supp_fieldResponse)) as get_master_plans_by_supp_fieldResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_supp_plans_by_supp_fieldResponse get_supp_plans_by_supp_field(get_supp_plans_by_supp_fieldRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_supp_plans_by_supp_field");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&field_val=" + request.field_val;
            url += "&field_no=" + request.field_no;
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
            get_supp_plans_by_supp_fieldResponse myDeserializedObj = json.Deserialize(reader, typeof(get_supp_plans_by_supp_fieldResponse)) as get_supp_plans_by_supp_fieldResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_items_by_supp_fieldResponse get_items_by_supp_field(get_items_by_supp_fieldRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_items_by_supp_field");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&field_val=" + request.field_val;
            url += "&field_no=" + request.field_no;
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
            get_items_by_supp_fieldResponse myDeserializedObj = json.Deserialize(reader, typeof(get_items_by_supp_fieldResponse)) as get_items_by_supp_fieldResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_email_templatesResponse get_email_templates(get_email_templatesRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_email_templates");

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
            get_email_templatesResponse myDeserializedObj = json.Deserialize(reader, typeof(get_email_templatesResponse)) as get_email_templatesResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_virtual_datetimeResponse get_virtual_datetime(get_virtual_datetimeRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_virtual_datetime");

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
            get_virtual_datetimeResponse myDeserializedObj = json.Deserialize(reader, typeof(get_virtual_datetimeResponse)) as get_virtual_datetimeResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public advance_virtual_datetimeResponse advance_virtual_datetime(advance_virtual_datetimeRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("advance_virtual_datetime");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&offset_hours=" + request.offset_hours;
            
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
            advance_virtual_datetimeResponse myDeserializedObj = json.Deserialize(reader, typeof(advance_virtual_datetimeResponse)) as advance_virtual_datetimeResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_daily_batch_statusResponse get_daily_batch_status(get_daily_batch_statusRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_daily_batch_status");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&batch_date=" + request.batch_date;
            
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
            get_daily_batch_statusResponse myDeserializedObj = json.Deserialize(reader, typeof(get_daily_batch_statusResponse)) as get_daily_batch_statusResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public set_external_object_idResponse set_external_object_id(set_external_object_idRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("set_external_object_id");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&destination_id=" + request.destination_id;
            url += "&source_type_id=" + request.source_type_id;
            url += "&object_id=" + request.object_id;
            url += "&external_id=" + request.external_id;
            url += "&action_directive=" + request.action_directive;
            
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
            set_external_object_idResponse myDeserializedObj = json.Deserialize(reader, typeof(set_external_object_idResponse)) as set_external_object_idResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_coupon_detailsResponse get_coupon_details(get_coupon_detailsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_coupon_details");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&coupon_cd=" + request.coupon_cd;
            
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
            get_coupon_detailsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_coupon_detailsResponse)) as get_coupon_detailsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public delete_acct_couponResponse delete_acct_coupon(delete_acct_couponRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("delete_acct_coupon");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&coupon_cd=" + request.coupon_cd;
            
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
            delete_acct_couponResponse myDeserializedObj = json.Deserialize(reader, typeof(delete_acct_couponResponse)) as delete_acct_couponResponse;
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
            url += "&address3=" + request.address3;
            
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
            url += "&address3=" + request.address3;
            
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
            url += "&cc_expire_mm=" + request.cc_expire_mm;
            url += "&cc_expire_yyyy=" + request.cc_expire_yyyy;
            url += "&cc_number=" + request.cc_number;
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
            url += "&bill_address3=" + request.bill_address3;
            url += "&alt_client_acct_group_id=" + request.alt_client_acct_group_id;
            url += "&track_data1=" + request.track_data1;
            url += "&track_data2=" + request.track_data2;
            
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
            url += "&filter_statement_no=" + request.filter_statement_no;
            url += "&include_void_transactions=" + request.include_void_transactions;
            
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
            url += "&alt_client_acct_group_id=" + request.alt_client_acct_group_id;
            url += "&track_data1=" + request.track_data1;
            url += "&track_data2=" + request.track_data2;
            
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
            RestUtilities.addParameterValuesFromArray(ref url, request.plan_no_to_remove);
            url += "&remove_all_queued_plan_no=" + request.remove_all_queued_plan_no;
            
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
            url += "&include_void_transactions=" + request.include_void_transactions;
            
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
            url += "&address3=" + request.address3;
            
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
            url += "&usage_type_code=" + request.usage_type_code;
            
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
            url += "&offset_months=" + request.offset_months;
            url += "&auto_offset_months_option=" + request.auto_offset_months_option;
            url += "&alt_proration_start_date=" + request.alt_proration_start_date;
            url += "&alt_client_acct_group_id=" + request.alt_client_acct_group_id;
            RestUtilities.addParameterValuesFromArray(ref url, request.new_acct_custom_rates);
            url += "&effective_date=" + request.effective_date;
            url += "&offset_interval=" + request.offset_interval;
            url += "&contract_end_date=" + request.contract_end_date;
            
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
            url += "&alt_proration_start_date=" + request.alt_proration_start_date;
            url += "&effective_date=" + request.effective_date;
            url += "&offset_interval=" + request.offset_interval;
            url += "&invoice_unbilled_usage=" + request.invoice_unbilled_usage;
            
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
            RestUtilities.addParameterValuesFromArray(ref url, request.new_acct_custom_rates);
            url += "&effective_date=" + request.effective_date;
            url += "&offset_interval=" + request.offset_interval;
            
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
            url += "&offset_months=" + request.offset_months;
            url += "&auto_offset_months_option=" + request.auto_offset_months_option;
            url += "&alt_client_acct_group_id=" + request.alt_client_acct_group_id;
            RestUtilities.addParameterValuesFromArray(ref url, request.new_acct_custom_rates);
            url += "&effective_date=" + request.effective_date;
            url += "&offset_interval=" + request.offset_interval;
            url += "&invoice_unbilled_usage=" + request.invoice_unbilled_usage;
            
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
            url += "&client_acct_group_id=" + request.client_acct_group_id;
            
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
            url += "&client_acct_group_id=" + request.client_acct_group_id;
            
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
            url += "&client_acct_group_id=" + request.client_acct_group_id;
            
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

        public create_acct_completeResponse create_acct_complete(create_acct_completeRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("create_acct_complete");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&master_plan_no=" + request.master_plan_no;
            url += "&alt_start_date=" + request.alt_start_date;
            url += "&client_acct_id=" + request.client_acct_id;
            url += "&userid=" + request.userid;
            url += "&status_cd=" + request.status_cd;
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
            url += "&retroactive_start_date=" + request.retroactive_start_date;
            RestUtilities.addParameterValuesFromArray(ref url, request.coupon_codes);
            RestUtilities.addParameterValuesFromArray(ref url, request.new_acct_custom_rates);
            url += "&alt_msg_template_no=" + request.alt_msg_template_no;
            url += "&seq_func_group_no=" + request.seq_func_group_no;
            RestUtilities.addParameterValuesFromArray(ref url, request.new_acct_plan_contracts);
            url += "&address3=" + request.address3;
            url += "&bill_address3=" + request.bill_address3;
            RestUtilities.addParameterValuesFromArray(ref url, request.usage_accumulation_config);
            RestUtilities.addParameterValuesFromArray(ref url, request.enable_usage_pooling_plan_no);
            RestUtilities.addParameterValuesFromArray(ref url, request.client_func_acct_group_ids);
            RestUtilities.addParameterValuesFromArray(ref url, request.client_coll_acct_group_ids);
            url += "&track_data1=" + request.track_data1;
            url += "&track_data2=" + request.track_data2;
            url += "&do_write=" + request.do_write;
            url += "&tax_exemption_level=" + request.tax_exemption_level;
            url += "&cn_alt_msg_template_no=" + request.cn_alt_msg_template_no;
            
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

        public create_acct_hierarchyResponse create_acct_hierarchy(create_acct_hierarchyRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("create_acct_hierarchy");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&a1_master_plan_no=" + request.a1_master_plan_no;
            url += "&do_write=" + request.do_write;
            url += "&client_receipt_id=" + request.client_receipt_id;
            url += "&a1_alt_start_date=" + request.a1_alt_start_date;
            url += "&a1_client_acct_id=" + request.a1_client_acct_id;
            url += "&a1_userid=" + request.a1_userid;
            url += "&a1_status_cd=" + request.a1_status_cd;
            url += "&a1_master_plan_units=" + request.a1_master_plan_units;
            RestUtilities.addParameterValuesFromArray(ref url, request.a1_supp_plans);
            RestUtilities.addParameterValuesFromArray(ref url, request.a1_supp_plan_units);
            url += "&a1_notify_method=" + request.a1_notify_method;
            url += "&a1_promo_cd=" + request.a1_promo_cd;
            url += "&a1_password=" + request.a1_password;
            url += "&a1_secret_question=" + request.a1_secret_question;
            url += "&a1_secret_question_answer=" + request.a1_secret_question_answer;
            url += "&a1_first_name=" + request.a1_first_name;
            url += "&a1_mi=" + request.a1_mi;
            url += "&a1_last_name=" + request.a1_last_name;
            url += "&a1_company_name=" + request.a1_company_name;
            url += "&a1_address1=" + request.a1_address1;
            url += "&a1_address2=" + request.a1_address2;
            url += "&a1_city=" + request.a1_city;
            url += "&a1_locality=" + request.a1_locality;
            url += "&a1_state_prov=" + request.a1_state_prov;
            url += "&a1_country=" + request.a1_country;
            url += "&a1_postal_cd=" + request.a1_postal_cd;
            url += "&a1_phone=" + request.a1_phone;
            url += "&a1_phone_ext=" + request.a1_phone_ext;
            url += "&a1_cell_phone=" + request.a1_cell_phone;
            url += "&a1_work_phone=" + request.a1_work_phone;
            url += "&a1_work_phone_ext=" + request.a1_work_phone_ext;
            url += "&a1_email=" + request.a1_email;
            url += "&a1_birthdate=" + request.a1_birthdate;
            url += "&a1_bill_first_name=" + request.a1_bill_first_name;
            url += "&a1_bill_mi=" + request.a1_bill_mi;
            url += "&a1_bill_last_name=" + request.a1_bill_last_name;
            url += "&a1_bill_company_name=" + request.a1_bill_company_name;
            url += "&a1_bill_address1=" + request.a1_bill_address1;
            url += "&a1_bill_address2=" + request.a1_bill_address2;
            url += "&a1_bill_city=" + request.a1_bill_city;
            url += "&a1_bill_locality=" + request.a1_bill_locality;
            url += "&a1_bill_state_prov=" + request.a1_bill_state_prov;
            url += "&a1_bill_country=" + request.a1_bill_country;
            url += "&a1_bill_postal_cd=" + request.a1_bill_postal_cd;
            url += "&a1_bill_phone=" + request.a1_bill_phone;
            url += "&a1_bill_phone_ext=" + request.a1_bill_phone_ext;
            url += "&a1_bill_cell_phone=" + request.a1_bill_cell_phone;
            url += "&a1_bill_work_phone=" + request.a1_bill_work_phone;
            url += "&a1_bill_work_phone_ext=" + request.a1_bill_work_phone_ext;
            url += "&a1_bill_email=" + request.a1_bill_email;
            url += "&a1_pay_method=" + request.a1_pay_method;
            url += "&a1_cc_number=" + request.a1_cc_number;
            url += "&a1_cc_expire_mm=" + request.a1_cc_expire_mm;
            url += "&a1_cc_expire_yyyy=" + request.a1_cc_expire_yyyy;
            url += "&a1_bank_acct_no=" + request.a1_bank_acct_no;
            url += "&a1_bank_routing_no=" + request.a1_bank_routing_no;
            url += "&a1_resp_level_cd=" + request.a1_resp_level_cd;
            RestUtilities.addParameterValuesFromArray(ref url, request.a1_functional_acct_groups);
            RestUtilities.addParameterValuesFromArray(ref url, request.a1_collections_acct_groups);
            RestUtilities.addParameterValuesFromArray(ref url, request.a1_supp_field_names);
            RestUtilities.addParameterValuesFromArray(ref url, request.a1_supp_field_values);
            url += "&a1_test_acct_ind=" + request.a1_test_acct_ind;
            url += "&a1_status_until_alt_start=" + request.a1_status_until_alt_start;
            url += "&a1_balance_forward=" + request.a1_balance_forward;
            url += "&a1_alt_bill_day=" + request.a1_alt_bill_day;
            url += "&a1_do_full_invoicing=" + request.a1_do_full_invoicing;
            url += "&a1_do_prorated_invoicing=" + request.a1_do_prorated_invoicing;
            url += "&a1_master_plan_alt_rate_sched_no=" + request.a1_master_plan_alt_rate_sched_no;
            RestUtilities.addParameterValuesFromArray(ref url, request.a1_supp_plan_alt_rate_sched_no);
            url += "&a1_currency_cd=" + request.a1_currency_cd;
            url += "&a1_cvv=" + request.a1_cvv;
            url += "&a1_taxpayer_id=" + request.a1_taxpayer_id;
            url += "&a1_bill_agreement_id=" + request.a1_bill_agreement_id;
            url += "&a1_retroactive_start_date=" + request.a1_retroactive_start_date;
            RestUtilities.addParameterValuesFromArray(ref url, request.a1_coupon_codes);
            RestUtilities.addParameterValuesFromArray(ref url, request.a1_new_acct_custom_rates);
            url += "&a1_alt_msg_template_no=" + request.a1_alt_msg_template_no;
            url += "&a1_seq_func_group_no=" + request.a1_seq_func_group_no;
            RestUtilities.addParameterValuesFromArray(ref url, request.a1_new_acct_plan_contracts);
            url += "&a1_address3=" + request.a1_address3;
            url += "&a1_bill_address3=" + request.a1_bill_address3;
            RestUtilities.addParameterValuesFromArray(ref url, request.a1_usage_accumulation_config);
            RestUtilities.addParameterValuesFromArray(ref url, request.a1_enable_usage_pooling_plan_no);
            RestUtilities.addParameterValuesFromArray(ref url, request.a1_client_func_acct_group_ids);
            RestUtilities.addParameterValuesFromArray(ref url, request.a1_client_coll_acct_group_ids);
            url += "&a1_track_data1=" + request.a1_track_data1;
            url += "&a1_track_data2=" + request.a1_track_data2;
            url += "&a1_tax_exemption_level=" + request.a1_tax_exemption_level;
            url += "&a1_cn_alt_msg_template_no=" + request.a1_cn_alt_msg_template_no;
            url += "&a2_alt_start_date=" + request.a2_alt_start_date;
            url += "&a2_client_acct_id=" + request.a2_client_acct_id;
            url += "&a2_userid=" + request.a2_userid;
            url += "&a2_status_cd=" + request.a2_status_cd;
            url += "&a2_master_plan_no=" + request.a2_master_plan_no;
            url += "&a2_master_plan_units=" + request.a2_master_plan_units;
            RestUtilities.addParameterValuesFromArray(ref url, request.a2_supp_plans);
            RestUtilities.addParameterValuesFromArray(ref url, request.a2_supp_plan_units);
            url += "&a2_notify_method=" + request.a2_notify_method;
            url += "&a2_promo_cd=" + request.a2_promo_cd;
            url += "&a2_password=" + request.a2_password;
            url += "&a2_secret_question=" + request.a2_secret_question;
            url += "&a2_secret_question_answer=" + request.a2_secret_question_answer;
            url += "&a2_first_name=" + request.a2_first_name;
            url += "&a2_mi=" + request.a2_mi;
            url += "&a2_last_name=" + request.a2_last_name;
            url += "&a2_company_name=" + request.a2_company_name;
            url += "&a2_address1=" + request.a2_address1;
            url += "&a2_address2=" + request.a2_address2;
            url += "&a2_city=" + request.a2_city;
            url += "&a2_locality=" + request.a2_locality;
            url += "&a2_state_prov=" + request.a2_state_prov;
            url += "&a2_country=" + request.a2_country;
            url += "&a2_postal_cd=" + request.a2_postal_cd;
            url += "&a2_phone=" + request.a2_phone;
            url += "&a2_phone_ext=" + request.a2_phone_ext;
            url += "&a2_cell_phone=" + request.a2_cell_phone;
            url += "&a2_work_phone=" + request.a2_work_phone;
            url += "&a2_work_phone_ext=" + request.a2_work_phone_ext;
            url += "&a2_email=" + request.a2_email;
            url += "&a2_birthdate=" + request.a2_birthdate;
            url += "&a2_bill_first_name=" + request.a2_bill_first_name;
            url += "&a2_bill_mi=" + request.a2_bill_mi;
            url += "&a2_bill_last_name=" + request.a2_bill_last_name;
            url += "&a2_bill_company_name=" + request.a2_bill_company_name;
            url += "&a2_bill_address1=" + request.a2_bill_address1;
            url += "&a2_bill_address2=" + request.a2_bill_address2;
            url += "&a2_bill_city=" + request.a2_bill_city;
            url += "&a2_bill_locality=" + request.a2_bill_locality;
            url += "&a2_bill_state_prov=" + request.a2_bill_state_prov;
            url += "&a2_bill_country=" + request.a2_bill_country;
            url += "&a2_bill_postal_cd=" + request.a2_bill_postal_cd;
            url += "&a2_bill_phone=" + request.a2_bill_phone;
            url += "&a2_bill_phone_ext=" + request.a2_bill_phone_ext;
            url += "&a2_bill_cell_phone=" + request.a2_bill_cell_phone;
            url += "&a2_bill_work_phone=" + request.a2_bill_work_phone;
            url += "&a2_bill_work_phone_ext=" + request.a2_bill_work_phone_ext;
            url += "&a2_bill_email=" + request.a2_bill_email;
            url += "&a2_pay_method=" + request.a2_pay_method;
            url += "&a2_cc_number=" + request.a2_cc_number;
            url += "&a2_cc_expire_mm=" + request.a2_cc_expire_mm;
            url += "&a2_cc_expire_yyyy=" + request.a2_cc_expire_yyyy;
            url += "&a2_bank_acct_no=" + request.a2_bank_acct_no;
            url += "&a2_bank_routing_no=" + request.a2_bank_routing_no;
            url += "&a2_resp_level_cd=" + request.a2_resp_level_cd;
            RestUtilities.addParameterValuesFromArray(ref url, request.a2_functional_acct_groups);
            RestUtilities.addParameterValuesFromArray(ref url, request.a2_collections_acct_groups);
            RestUtilities.addParameterValuesFromArray(ref url, request.a2_supp_field_names);
            RestUtilities.addParameterValuesFromArray(ref url, request.a2_supp_field_values);
            url += "&a2_test_acct_ind=" + request.a2_test_acct_ind;
            url += "&a2_status_until_alt_start=" + request.a2_status_until_alt_start;
            url += "&a2_balance_forward=" + request.a2_balance_forward;
            url += "&a2_alt_bill_day=" + request.a2_alt_bill_day;
            url += "&a2_do_full_invoicing=" + request.a2_do_full_invoicing;
            url += "&a2_do_prorated_invoicing=" + request.a2_do_prorated_invoicing;
            url += "&a2_master_plan_alt_rate_sched_no=" + request.a2_master_plan_alt_rate_sched_no;
            RestUtilities.addParameterValuesFromArray(ref url, request.a2_supp_plan_alt_rate_sched_no);
            url += "&a2_currency_cd=" + request.a2_currency_cd;
            url += "&a2_cvv=" + request.a2_cvv;
            url += "&a2_taxpayer_id=" + request.a2_taxpayer_id;
            url += "&a2_bill_agreement_id=" + request.a2_bill_agreement_id;
            url += "&a2_retroactive_start_date=" + request.a2_retroactive_start_date;
            RestUtilities.addParameterValuesFromArray(ref url, request.a2_coupon_codes);
            RestUtilities.addParameterValuesFromArray(ref url, request.a2_new_acct_custom_rates);
            url += "&a2_alt_msg_template_no=" + request.a2_alt_msg_template_no;
            url += "&a2_seq_func_group_no=" + request.a2_seq_func_group_no;
            RestUtilities.addParameterValuesFromArray(ref url, request.a2_new_acct_plan_contracts);
            url += "&a2_address3=" + request.a2_address3;
            url += "&a2_bill_address3=" + request.a2_bill_address3;
            RestUtilities.addParameterValuesFromArray(ref url, request.a2_usage_accumulation_config);
            RestUtilities.addParameterValuesFromArray(ref url, request.a2_enable_usage_pooling_plan_no);
            RestUtilities.addParameterValuesFromArray(ref url, request.a2_client_func_acct_group_ids);
            RestUtilities.addParameterValuesFromArray(ref url, request.a2_client_coll_acct_group_ids);
            url += "&a2_track_data1=" + request.a2_track_data1;
            url += "&a2_track_data2=" + request.a2_track_data2;
            url += "&a2_tax_exemption_level=" + request.a2_tax_exemption_level;
            url += "&a2_cn_alt_msg_template_no=" + request.a2_cn_alt_msg_template_no;
            url += "&a3_alt_start_date=" + request.a3_alt_start_date;
            url += "&a3_client_acct_id=" + request.a3_client_acct_id;
            url += "&a3_userid=" + request.a3_userid;
            url += "&a3_status_cd=" + request.a3_status_cd;
            url += "&a3_master_plan_no=" + request.a3_master_plan_no;
            url += "&a3_master_plan_units=" + request.a3_master_plan_units;
            RestUtilities.addParameterValuesFromArray(ref url, request.a3_supp_plans);
            RestUtilities.addParameterValuesFromArray(ref url, request.a3_supp_plan_units);
            url += "&a3_notify_method=" + request.a3_notify_method;
            url += "&a3_promo_cd=" + request.a3_promo_cd;
            url += "&a3_password=" + request.a3_password;
            url += "&a3_secret_question=" + request.a3_secret_question;
            url += "&a3_secret_question_answer=" + request.a3_secret_question_answer;
            url += "&a3_first_name=" + request.a3_first_name;
            url += "&a3_mi=" + request.a3_mi;
            url += "&a3_last_name=" + request.a3_last_name;
            url += "&a3_company_name=" + request.a3_company_name;
            url += "&a3_address1=" + request.a3_address1;
            url += "&a3_address2=" + request.a3_address2;
            url += "&a3_city=" + request.a3_city;
            url += "&a3_locality=" + request.a3_locality;
            url += "&a3_state_prov=" + request.a3_state_prov;
            url += "&a3_country=" + request.a3_country;
            url += "&a3_postal_cd=" + request.a3_postal_cd;
            url += "&a3_phone=" + request.a3_phone;
            url += "&a3_phone_ext=" + request.a3_phone_ext;
            url += "&a3_cell_phone=" + request.a3_cell_phone;
            url += "&a3_work_phone=" + request.a3_work_phone;
            url += "&a3_work_phone_ext=" + request.a3_work_phone_ext;
            url += "&a3_email=" + request.a3_email;
            url += "&a3_birthdate=" + request.a3_birthdate;
            url += "&a3_bill_first_name=" + request.a3_bill_first_name;
            url += "&a3_bill_mi=" + request.a3_bill_mi;
            url += "&a3_bill_last_name=" + request.a3_bill_last_name;
            url += "&a3_bill_company_name=" + request.a3_bill_company_name;
            url += "&a3_bill_address1=" + request.a3_bill_address1;
            url += "&a3_bill_address2=" + request.a3_bill_address2;
            url += "&a3_bill_city=" + request.a3_bill_city;
            url += "&a3_bill_locality=" + request.a3_bill_locality;
            url += "&a3_bill_state_prov=" + request.a3_bill_state_prov;
            url += "&a3_bill_country=" + request.a3_bill_country;
            url += "&a3_bill_postal_cd=" + request.a3_bill_postal_cd;
            url += "&a3_bill_phone=" + request.a3_bill_phone;
            url += "&a3_bill_phone_ext=" + request.a3_bill_phone_ext;
            url += "&a3_bill_cell_phone=" + request.a3_bill_cell_phone;
            url += "&a3_bill_work_phone=" + request.a3_bill_work_phone;
            url += "&a3_bill_work_phone_ext=" + request.a3_bill_work_phone_ext;
            url += "&a3_bill_email=" + request.a3_bill_email;
            url += "&a3_pay_method=" + request.a3_pay_method;
            url += "&a3_cc_number=" + request.a3_cc_number;
            url += "&a3_cc_expire_mm=" + request.a3_cc_expire_mm;
            url += "&a3_cc_expire_yyyy=" + request.a3_cc_expire_yyyy;
            url += "&a3_bank_acct_no=" + request.a3_bank_acct_no;
            url += "&a3_bank_routing_no=" + request.a3_bank_routing_no;
            url += "&a3_resp_level_cd=" + request.a3_resp_level_cd;
            RestUtilities.addParameterValuesFromArray(ref url, request.a3_functional_acct_groups);
            RestUtilities.addParameterValuesFromArray(ref url, request.a3_collections_acct_groups);
            RestUtilities.addParameterValuesFromArray(ref url, request.a3_supp_field_names);
            RestUtilities.addParameterValuesFromArray(ref url, request.a3_supp_field_values);
            url += "&a3_test_acct_ind=" + request.a3_test_acct_ind;
            url += "&a3_status_until_alt_start=" + request.a3_status_until_alt_start;
            url += "&a3_balance_forward=" + request.a3_balance_forward;
            url += "&a3_alt_bill_day=" + request.a3_alt_bill_day;
            url += "&a3_do_full_invoicing=" + request.a3_do_full_invoicing;
            url += "&a3_do_prorated_invoicing=" + request.a3_do_prorated_invoicing;
            url += "&a3_master_plan_alt_rate_sched_no=" + request.a3_master_plan_alt_rate_sched_no;
            RestUtilities.addParameterValuesFromArray(ref url, request.a3_supp_plan_alt_rate_sched_no);
            url += "&a3_currency_cd=" + request.a3_currency_cd;
            url += "&a3_cvv=" + request.a3_cvv;
            url += "&a3_taxpayer_id=" + request.a3_taxpayer_id;
            url += "&a3_bill_agreement_id=" + request.a3_bill_agreement_id;
            url += "&a3_retroactive_start_date=" + request.a3_retroactive_start_date;
            RestUtilities.addParameterValuesFromArray(ref url, request.a3_coupon_codes);
            RestUtilities.addParameterValuesFromArray(ref url, request.a3_new_acct_custom_rates);
            url += "&a3_alt_msg_template_no=" + request.a3_alt_msg_template_no;
            url += "&a3_seq_func_group_no=" + request.a3_seq_func_group_no;
            RestUtilities.addParameterValuesFromArray(ref url, request.a3_new_acct_plan_contracts);
            url += "&a3_address3=" + request.a3_address3;
            url += "&a3_bill_address3=" + request.a3_bill_address3;
            RestUtilities.addParameterValuesFromArray(ref url, request.a3_usage_accumulation_config);
            RestUtilities.addParameterValuesFromArray(ref url, request.a3_enable_usage_pooling_plan_no);
            RestUtilities.addParameterValuesFromArray(ref url, request.a3_client_func_acct_group_ids);
            RestUtilities.addParameterValuesFromArray(ref url, request.a3_client_coll_acct_group_ids);
            url += "&a3_track_data1=" + request.a3_track_data1;
            url += "&a3_track_data2=" + request.a3_track_data2;
            url += "&a3_tax_exemption_level=" + request.a3_tax_exemption_level;
            url += "&a3_cn_alt_msg_template_no=" + request.a3_cn_alt_msg_template_no;
            url += "&a4_alt_start_date=" + request.a4_alt_start_date;
            url += "&a4_client_acct_id=" + request.a4_client_acct_id;
            url += "&a4_userid=" + request.a4_userid;
            url += "&a4_status_cd=" + request.a4_status_cd;
            url += "&a4_master_plan_no=" + request.a4_master_plan_no;
            url += "&a4_master_plan_units=" + request.a4_master_plan_units;
            RestUtilities.addParameterValuesFromArray(ref url, request.a4_supp_plans);
            RestUtilities.addParameterValuesFromArray(ref url, request.a4_supp_plan_units);
            url += "&a4_notify_method=" + request.a4_notify_method;
            url += "&a4_promo_cd=" + request.a4_promo_cd;
            url += "&a4_password=" + request.a4_password;
            url += "&a4_secret_question=" + request.a4_secret_question;
            url += "&a4_secret_question_answer=" + request.a4_secret_question_answer;
            url += "&a4_first_name=" + request.a4_first_name;
            url += "&a4_mi=" + request.a4_mi;
            url += "&a4_last_name=" + request.a4_last_name;
            url += "&a4_company_name=" + request.a4_company_name;
            url += "&a4_address1=" + request.a4_address1;
            url += "&a4_address2=" + request.a4_address2;
            url += "&a4_city=" + request.a4_city;
            url += "&a4_locality=" + request.a4_locality;
            url += "&a4_state_prov=" + request.a4_state_prov;
            url += "&a4_country=" + request.a4_country;
            url += "&a4_postal_cd=" + request.a4_postal_cd;
            url += "&a4_phone=" + request.a4_phone;
            url += "&a4_phone_ext=" + request.a4_phone_ext;
            url += "&a4_cell_phone=" + request.a4_cell_phone;
            url += "&a4_work_phone=" + request.a4_work_phone;
            url += "&a4_work_phone_ext=" + request.a4_work_phone_ext;
            url += "&a4_email=" + request.a4_email;
            url += "&a4_birthdate=" + request.a4_birthdate;
            url += "&a4_bill_first_name=" + request.a4_bill_first_name;
            url += "&a4_bill_mi=" + request.a4_bill_mi;
            url += "&a4_bill_last_name=" + request.a4_bill_last_name;
            url += "&a4_bill_company_name=" + request.a4_bill_company_name;
            url += "&a4_bill_address1=" + request.a4_bill_address1;
            url += "&a4_bill_address2=" + request.a4_bill_address2;
            url += "&a4_bill_city=" + request.a4_bill_city;
            url += "&a4_bill_locality=" + request.a4_bill_locality;
            url += "&a4_bill_state_prov=" + request.a4_bill_state_prov;
            url += "&a4_bill_country=" + request.a4_bill_country;
            url += "&a4_bill_postal_cd=" + request.a4_bill_postal_cd;
            url += "&a4_bill_phone=" + request.a4_bill_phone;
            url += "&a4_bill_phone_ext=" + request.a4_bill_phone_ext;
            url += "&a4_bill_cell_phone=" + request.a4_bill_cell_phone;
            url += "&a4_bill_work_phone=" + request.a4_bill_work_phone;
            url += "&a4_bill_work_phone_ext=" + request.a4_bill_work_phone_ext;
            url += "&a4_bill_email=" + request.a4_bill_email;
            url += "&a4_pay_method=" + request.a4_pay_method;
            url += "&a4_cc_number=" + request.a4_cc_number;
            url += "&a4_cc_expire_mm=" + request.a4_cc_expire_mm;
            url += "&a4_cc_expire_yyyy=" + request.a4_cc_expire_yyyy;
            url += "&a4_bank_acct_no=" + request.a4_bank_acct_no;
            url += "&a4_bank_routing_no=" + request.a4_bank_routing_no;
            url += "&a4_resp_level_cd=" + request.a4_resp_level_cd;
            RestUtilities.addParameterValuesFromArray(ref url, request.a4_functional_acct_groups);
            RestUtilities.addParameterValuesFromArray(ref url, request.a4_collections_acct_groups);
            RestUtilities.addParameterValuesFromArray(ref url, request.a4_supp_field_names);
            RestUtilities.addParameterValuesFromArray(ref url, request.a4_supp_field_values);
            url += "&a4_test_acct_ind=" + request.a4_test_acct_ind;
            url += "&a4_status_until_alt_start=" + request.a4_status_until_alt_start;
            url += "&a4_balance_forward=" + request.a4_balance_forward;
            url += "&a4_alt_bill_day=" + request.a4_alt_bill_day;
            url += "&a4_do_full_invoicing=" + request.a4_do_full_invoicing;
            url += "&a4_do_prorated_invoicing=" + request.a4_do_prorated_invoicing;
            url += "&a4_master_plan_alt_rate_sched_no=" + request.a4_master_plan_alt_rate_sched_no;
            RestUtilities.addParameterValuesFromArray(ref url, request.a4_supp_plan_alt_rate_sched_no);
            url += "&a4_currency_cd=" + request.a4_currency_cd;
            url += "&a4_cvv=" + request.a4_cvv;
            url += "&a4_taxpayer_id=" + request.a4_taxpayer_id;
            url += "&a4_bill_agreement_id=" + request.a4_bill_agreement_id;
            url += "&a4_retroactive_start_date=" + request.a4_retroactive_start_date;
            RestUtilities.addParameterValuesFromArray(ref url, request.a4_coupon_codes);
            RestUtilities.addParameterValuesFromArray(ref url, request.a4_new_acct_custom_rates);
            url += "&a4_alt_msg_template_no=" + request.a4_alt_msg_template_no;
            url += "&a4_seq_func_group_no=" + request.a4_seq_func_group_no;
            RestUtilities.addParameterValuesFromArray(ref url, request.a4_new_acct_plan_contracts);
            url += "&a4_address3=" + request.a4_address3;
            url += "&a4_bill_address3=" + request.a4_bill_address3;
            RestUtilities.addParameterValuesFromArray(ref url, request.a4_usage_accumulation_config);
            RestUtilities.addParameterValuesFromArray(ref url, request.a4_enable_usage_pooling_plan_no);
            RestUtilities.addParameterValuesFromArray(ref url, request.a4_client_func_acct_group_ids);
            RestUtilities.addParameterValuesFromArray(ref url, request.a4_client_coll_acct_group_ids);
            url += "&a4_track_data1=" + request.a4_track_data1;
            url += "&a4_track_data2=" + request.a4_track_data2;
            url += "&a4_tax_exemption_level=" + request.a4_tax_exemption_level;
            url += "&a4_cn_alt_msg_template_no=" + request.a4_cn_alt_msg_template_no;
            url += "&a5_alt_start_date=" + request.a5_alt_start_date;
            url += "&a5_client_acct_id=" + request.a5_client_acct_id;
            url += "&a5_userid=" + request.a5_userid;
            url += "&a5_status_cd=" + request.a5_status_cd;
            url += "&a5_master_plan_no=" + request.a5_master_plan_no;
            url += "&a5_master_plan_units=" + request.a5_master_plan_units;
            RestUtilities.addParameterValuesFromArray(ref url, request.a5_supp_plans);
            RestUtilities.addParameterValuesFromArray(ref url, request.a5_supp_plan_units);
            url += "&a5_notify_method=" + request.a5_notify_method;
            url += "&a5_promo_cd=" + request.a5_promo_cd;
            url += "&a5_password=" + request.a5_password;
            url += "&a5_secret_question=" + request.a5_secret_question;
            url += "&a5_secret_question_answer=" + request.a5_secret_question_answer;
            url += "&a5_first_name=" + request.a5_first_name;
            url += "&a5_mi=" + request.a5_mi;
            url += "&a5_last_name=" + request.a5_last_name;
            url += "&a5_company_name=" + request.a5_company_name;
            url += "&a5_address1=" + request.a5_address1;
            url += "&a5_address2=" + request.a5_address2;
            url += "&a5_city=" + request.a5_city;
            url += "&a5_locality=" + request.a5_locality;
            url += "&a5_state_prov=" + request.a5_state_prov;
            url += "&a5_country=" + request.a5_country;
            url += "&a5_postal_cd=" + request.a5_postal_cd;
            url += "&a5_phone=" + request.a5_phone;
            url += "&a5_phone_ext=" + request.a5_phone_ext;
            url += "&a5_cell_phone=" + request.a5_cell_phone;
            url += "&a5_work_phone=" + request.a5_work_phone;
            url += "&a5_work_phone_ext=" + request.a5_work_phone_ext;
            url += "&a5_email=" + request.a5_email;
            url += "&a5_birthdate=" + request.a5_birthdate;
            url += "&a5_bill_first_name=" + request.a5_bill_first_name;
            url += "&a5_bill_mi=" + request.a5_bill_mi;
            url += "&a5_bill_last_name=" + request.a5_bill_last_name;
            url += "&a5_bill_company_name=" + request.a5_bill_company_name;
            url += "&a5_bill_address1=" + request.a5_bill_address1;
            url += "&a5_bill_address2=" + request.a5_bill_address2;
            url += "&a5_bill_city=" + request.a5_bill_city;
            url += "&a5_bill_locality=" + request.a5_bill_locality;
            url += "&a5_bill_state_prov=" + request.a5_bill_state_prov;
            url += "&a5_bill_country=" + request.a5_bill_country;
            url += "&a5_bill_postal_cd=" + request.a5_bill_postal_cd;
            url += "&a5_bill_phone=" + request.a5_bill_phone;
            url += "&a5_bill_phone_ext=" + request.a5_bill_phone_ext;
            url += "&a5_bill_cell_phone=" + request.a5_bill_cell_phone;
            url += "&a5_bill_work_phone=" + request.a5_bill_work_phone;
            url += "&a5_bill_work_phone_ext=" + request.a5_bill_work_phone_ext;
            url += "&a5_bill_email=" + request.a5_bill_email;
            url += "&a5_pay_method=" + request.a5_pay_method;
            url += "&a5_cc_number=" + request.a5_cc_number;
            url += "&a5_cc_expire_mm=" + request.a5_cc_expire_mm;
            url += "&a5_cc_expire_yyyy=" + request.a5_cc_expire_yyyy;
            url += "&a5_bank_acct_no=" + request.a5_bank_acct_no;
            url += "&a5_bank_routing_no=" + request.a5_bank_routing_no;
            url += "&a5_resp_level_cd=" + request.a5_resp_level_cd;
            RestUtilities.addParameterValuesFromArray(ref url, request.a5_functional_acct_groups);
            RestUtilities.addParameterValuesFromArray(ref url, request.a5_collections_acct_groups);
            RestUtilities.addParameterValuesFromArray(ref url, request.a5_supp_field_names);
            RestUtilities.addParameterValuesFromArray(ref url, request.a5_supp_field_values);
            url += "&a5_test_acct_ind=" + request.a5_test_acct_ind;
            url += "&a5_status_until_alt_start=" + request.a5_status_until_alt_start;
            url += "&a5_balance_forward=" + request.a5_balance_forward;
            url += "&a5_alt_bill_day=" + request.a5_alt_bill_day;
            url += "&a5_do_full_invoicing=" + request.a5_do_full_invoicing;
            url += "&a5_do_prorated_invoicing=" + request.a5_do_prorated_invoicing;
            url += "&a5_master_plan_alt_rate_sched_no=" + request.a5_master_plan_alt_rate_sched_no;
            RestUtilities.addParameterValuesFromArray(ref url, request.a5_supp_plan_alt_rate_sched_no);
            url += "&a5_currency_cd=" + request.a5_currency_cd;
            url += "&a5_cvv=" + request.a5_cvv;
            url += "&a5_taxpayer_id=" + request.a5_taxpayer_id;
            url += "&a5_bill_agreement_id=" + request.a5_bill_agreement_id;
            url += "&a5_retroactive_start_date=" + request.a5_retroactive_start_date;
            RestUtilities.addParameterValuesFromArray(ref url, request.a5_coupon_codes);
            RestUtilities.addParameterValuesFromArray(ref url, request.a5_new_acct_custom_rates);
            url += "&a5_alt_msg_template_no=" + request.a5_alt_msg_template_no;
            url += "&a5_seq_func_group_no=" + request.a5_seq_func_group_no;
            RestUtilities.addParameterValuesFromArray(ref url, request.a5_new_acct_plan_contracts);
            url += "&a5_address3=" + request.a5_address3;
            url += "&a5_bill_address3=" + request.a5_bill_address3;
            RestUtilities.addParameterValuesFromArray(ref url, request.a5_usage_accumulation_config);
            RestUtilities.addParameterValuesFromArray(ref url, request.a5_enable_usage_pooling_plan_no);
            RestUtilities.addParameterValuesFromArray(ref url, request.a5_client_func_acct_group_ids);
            RestUtilities.addParameterValuesFromArray(ref url, request.a5_client_coll_acct_group_ids);
            url += "&a5_track_data1=" + request.a5_track_data1;
            url += "&a5_track_data2=" + request.a5_track_data2;
            url += "&a5_tax_exemption_level=" + request.a5_tax_exemption_level;
            url += "&a5_cn_alt_msg_template_no=" + request.a5_cn_alt_msg_template_no;
            
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
            create_acct_hierarchyResponse myDeserializedObj = json.Deserialize(reader, typeof(create_acct_hierarchyResponse)) as create_acct_hierarchyResponse;
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
            url += "&end_date=" + request.end_date;
            
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
            url += "&end_date=" + request.end_date;
            
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
            url += "&close_status=" + request.close_status;
            
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
            url += "&specified_usage_type_code=" + request.specified_usage_type_code;
            RestUtilities.addParameterValuesFromArray(ref url, request.usage_qualifier_1);
            RestUtilities.addParameterValuesFromArray(ref url, request.usage_qualifier_2);
            RestUtilities.addParameterValuesFromArray(ref url, request.usage_qualifier_3);
            RestUtilities.addParameterValuesFromArray(ref url, request.usage_qualifier_4);
            
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

        public get_acct_messageResponse get_acct_message(get_acct_messageRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_message");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&message_id=" + request.message_id;
            url += "&acct_no=" + request.acct_no;
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

        public get_acct_message_sizeResponse get_acct_message_size(get_acct_message_sizeRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_message_size");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&message_id=" + request.message_id;
            url += "&acct_no=" + request.acct_no;
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
            url += "&auto_cancel_supp_plans=" + request.auto_cancel_supp_plans;
            url += "&offset_months=" + request.offset_months;
            url += "&alt_proration_start_date=" + request.alt_proration_start_date;
            url += "&alt_client_acct_group_id=" + request.alt_client_acct_group_id;
            RestUtilities.addParameterValuesFromArray(ref url, request.new_acct_custom_rates);
            url += "&effective_date=" + request.effective_date;
            url += "&offset_interval=" + request.offset_interval;
            url += "&invoice_unbilled_usage=" + request.invoice_unbilled_usage;
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
            update_master_planResponse myDeserializedObj = json.Deserialize(reader, typeof(update_master_planResponse)) as update_master_planResponse;
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
            url += "&auto_cancel_supp_plans=" + request.auto_cancel_supp_plans;
            url += "&offset_months=" + request.offset_months;
            url += "&alt_proration_start_date=" + request.alt_proration_start_date;
            url += "&alt_msg_template_no=" + request.alt_msg_template_no;
            url += "&seq_func_group_no=" + request.seq_func_group_no;
            url += "&address3=" + request.address3;
            url += "&bill_address3=" + request.bill_address3;
            RestUtilities.addParameterValuesFromArray(ref url, request.usage_accumulation_config);
            RestUtilities.addParameterValuesFromArray(ref url, request.enable_usage_pooling_plan_no);
            RestUtilities.addParameterValuesFromArray(ref url, request.disable_usage_pooling_plan_no);
            url += "&alt_client_acct_group_id=" + request.alt_client_acct_group_id;
            url += "&track_data1=" + request.track_data1;
            url += "&track_data2=" + request.track_data2;
            url += "&offset_interval=" + request.offset_interval;
            url += "&tax_exemption_level=" + request.tax_exemption_level;
            url += "&cn_alt_msg_template_no=" + request.cn_alt_msg_template_no;
            url += "&promo_cd=" + request.promo_cd;
            url += "&invoice_unbilled_usage=" + request.invoice_unbilled_usage;
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
            update_acct_completeResponse myDeserializedObj = json.Deserialize(reader, typeof(update_acct_completeResponse)) as update_acct_completeResponse;
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
            url += "&resource_threshold_level=" + request.resource_threshold_level;
            url += "&resource_balance=" + request.resource_balance;
            url += "&resource_name=" + request.resource_name;
            url += "&resource_units_label=" + request.resource_units_label;
            
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

        public get_recurring_credit_infoResponse get_recurring_credit_info(get_recurring_credit_infoRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_recurring_credit_info");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&filter_credit_no=" + request.filter_credit_no;
            
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
            get_recurring_credit_infoResponse myDeserializedObj = json.Deserialize(reader, typeof(get_recurring_credit_infoResponse)) as get_recurring_credit_infoResponse;
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

        public get_acct_statement_historyResponse get_acct_statement_history(get_acct_statement_historyRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_statement_history");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&user_id=" + request.user_id;
            url += "&start_date=" + request.start_date;
            url += "&end_date=" + request.end_date;
            
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
            get_acct_statement_historyResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_statement_historyResponse)) as get_acct_statement_historyResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_acct_invoice_historyResponse get_acct_invoice_history(get_acct_invoice_historyRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_invoice_history");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&user_id=" + request.user_id;
            url += "&start_bill_date=" + request.start_bill_date;
            url += "&end_bill_date=" + request.end_bill_date;
            url += "&include_voided=" + request.include_voided;
            
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
            get_acct_invoice_historyResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_invoice_historyResponse)) as get_acct_invoice_historyResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_statement_contentResponse get_statement_content(get_statement_contentRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_statement_content");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&statement_no=" + request.statement_no;
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
            get_statement_contentResponse myDeserializedObj = json.Deserialize(reader, typeof(get_statement_contentResponse)) as get_statement_contentResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_statement_content_sizeResponse get_statement_content_size(get_statement_content_sizeRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_statement_content_size");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&statement_no=" + request.statement_no;
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
            get_statement_content_sizeResponse myDeserializedObj = json.Deserialize(reader, typeof(get_statement_content_sizeResponse)) as get_statement_content_sizeResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_acct_has_ordered_skuResponse get_acct_has_ordered_sku(get_acct_has_ordered_skuRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_has_ordered_sku");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&sku=" + request.sku;
            
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
            get_acct_has_ordered_skuResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_has_ordered_skuResponse)) as get_acct_has_ordered_skuResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_userid_has_ordered_skuResponse get_userid_has_ordered_sku(get_userid_has_ordered_skuRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_userid_has_ordered_sku");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&user_id=" + request.user_id;
            url += "&sku=" + request.sku;
            
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
            get_userid_has_ordered_skuResponse myDeserializedObj = json.Deserialize(reader, typeof(get_userid_has_ordered_skuResponse)) as get_userid_has_ordered_skuResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public assign_supp_plan_multiResponse assign_supp_plan_multi(assign_supp_plan_multiRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("assign_supp_plan_multi");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            RestUtilities.addParameterValuesFromArray(ref url, request.supp_plans_to_assign);
            url += "&assignment_directive=" + request.assignment_directive;
            url += "&do_write=" + request.do_write;
            url += "&comments=" + request.comments;
            url += "&client_receipt_id=" + request.client_receipt_id;
            url += "&alt_proration_start_date=" + request.alt_proration_start_date;
            RestUtilities.addParameterValuesFromArray(ref url, request.coupon_codes);
            url += "&effective_date=" + request.effective_date;
            
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
            assign_supp_plan_multiResponse myDeserializedObj = json.Deserialize(reader, typeof(assign_supp_plan_multiResponse)) as assign_supp_plan_multiResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_acct_payment_methodsResponse get_acct_payment_methods(get_acct_payment_methodsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_payment_methods");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&filter_seq_no=" + request.filter_seq_no;
            
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
            get_acct_payment_methodsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_payment_methodsResponse)) as get_acct_payment_methodsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public gen_statementResponse gen_statement(gen_statementRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("gen_statement");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&send_email=" + request.send_email;
            
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
            gen_statementResponse myDeserializedObj = json.Deserialize(reader, typeof(gen_statementResponse)) as gen_statementResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public cancel_unconsumed_creditResponse cancel_unconsumed_credit(cancel_unconsumed_creditRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("cancel_unconsumed_credit");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&coupon_cd=" + request.coupon_cd;
            
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
            cancel_unconsumed_creditResponse myDeserializedObj = json.Deserialize(reader, typeof(cancel_unconsumed_creditResponse)) as cancel_unconsumed_creditResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public cancel_unapplied_svce_creditsResponse cancel_unapplied_svce_credits(cancel_unapplied_svce_creditsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("cancel_unapplied_svce_credits");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            RestUtilities.addParameterValuesFromArray(ref url, request.credit_ids);
            
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
            cancel_unapplied_svce_creditsResponse myDeserializedObj = json.Deserialize(reader, typeof(cancel_unapplied_svce_creditsResponse)) as cancel_unapplied_svce_creditsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_acct_balanceResponse get_acct_balance(get_acct_balanceRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_balance");

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
            get_acct_balanceResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_balanceResponse)) as get_acct_balanceResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_unbilled_usage_summaryResponse get_unbilled_usage_summary(get_unbilled_usage_summaryRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_unbilled_usage_summary");

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
            get_unbilled_usage_summaryResponse myDeserializedObj = json.Deserialize(reader, typeof(get_unbilled_usage_summaryResponse)) as get_unbilled_usage_summaryResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public set_acct_usg_mtd_thresholdResponse set_acct_usg_mtd_threshold(set_acct_usg_mtd_thresholdRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("set_acct_usg_mtd_threshold");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&amount=" + request.amount;
            
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
            set_acct_usg_mtd_thresholdResponse myDeserializedObj = json.Deserialize(reader, typeof(set_acct_usg_mtd_thresholdResponse)) as set_acct_usg_mtd_thresholdResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public set_acct_usg_ptd_thresholdResponse set_acct_usg_ptd_threshold(set_acct_usg_ptd_thresholdRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("set_acct_usg_ptd_threshold");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&amount=" + request.amount;
            
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
            set_acct_usg_ptd_thresholdResponse myDeserializedObj = json.Deserialize(reader, typeof(set_acct_usg_ptd_thresholdResponse)) as set_acct_usg_ptd_thresholdResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public set_client_usg_mtd_thresholdResponse set_client_usg_mtd_threshold(set_client_usg_mtd_thresholdRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("set_client_usg_mtd_threshold");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&amount=" + request.amount;
            
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
            set_client_usg_mtd_thresholdResponse myDeserializedObj = json.Deserialize(reader, typeof(set_client_usg_mtd_thresholdResponse)) as set_client_usg_mtd_thresholdResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public set_client_usg_ptd_thresholdResponse set_client_usg_ptd_threshold(set_client_usg_ptd_thresholdRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("set_client_usg_ptd_threshold");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&amount=" + request.amount;
            
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
            set_client_usg_ptd_thresholdResponse myDeserializedObj = json.Deserialize(reader, typeof(set_client_usg_ptd_thresholdResponse)) as set_client_usg_ptd_thresholdResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public reset_usg_mtd_balResponse reset_usg_mtd_bal(reset_usg_mtd_balRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("reset_usg_mtd_bal");

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
            reset_usg_mtd_balResponse myDeserializedObj = json.Deserialize(reader, typeof(reset_usg_mtd_balResponse)) as reset_usg_mtd_balResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public reset_usg_ptd_balResponse reset_usg_ptd_bal(reset_usg_ptd_balRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("reset_usg_ptd_bal");

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
            reset_usg_ptd_balResponse myDeserializedObj = json.Deserialize(reader, typeof(reset_usg_ptd_balResponse)) as reset_usg_ptd_balResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_acct_multiplan_contractResponse get_acct_multiplan_contract(get_acct_multiplan_contractRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_multiplan_contract");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&contract_no=" + request.contract_no;
            
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
            get_acct_multiplan_contractResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_multiplan_contractResponse)) as get_acct_multiplan_contractResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public create_acct_multiplan_contractResponse create_acct_multiplan_contract(create_acct_multiplan_contractRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("create_acct_multiplan_contract");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            RestUtilities.addParameterValuesFromArray(ref url, request.plan_no);
            url += "&type_no=" + request.type_no;
            url += "&length_months=" + request.length_months;
            url += "&create_comments=" + request.create_comments;
            url += "&start_date=" + request.start_date;
            url += "&do_auto_discard=" + request.do_auto_discard;
            url += "&end_date=" + request.end_date;
            
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
            create_acct_multiplan_contractResponse myDeserializedObj = json.Deserialize(reader, typeof(create_acct_multiplan_contractResponse)) as create_acct_multiplan_contractResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public modify_acct_multiplan_contractResponse modify_acct_multiplan_contract(modify_acct_multiplan_contractRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("modify_acct_multiplan_contract");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&contract_no=" + request.contract_no;
            url += "&type_no=" + request.type_no;
            url += "&length_months=" + request.length_months;
            url += "&start_date=" + request.start_date;
            url += "&update_comments=" + request.update_comments;
            url += "&modify_directive=" + request.modify_directive;
            RestUtilities.addParameterValuesFromArray(ref url, request.plans_input);
            url += "&end_date=" + request.end_date;
            
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
            modify_acct_multiplan_contractResponse myDeserializedObj = json.Deserialize(reader, typeof(modify_acct_multiplan_contractResponse)) as modify_acct_multiplan_contractResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public cancel_acct_multiplan_contractResponse cancel_acct_multiplan_contract(cancel_acct_multiplan_contractRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("cancel_acct_multiplan_contract");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&contract_no=" + request.contract_no;
            url += "&update_comments=" + request.update_comments;
            url += "&close_status=" + request.close_status;
            
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
            cancel_acct_multiplan_contractResponse myDeserializedObj = json.Deserialize(reader, typeof(cancel_acct_multiplan_contractResponse)) as cancel_acct_multiplan_contractResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_acct_universal_contractResponse get_acct_universal_contract(get_acct_universal_contractRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_universal_contract");

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
            get_acct_universal_contractResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_universal_contractResponse)) as get_acct_universal_contractResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public create_acct_universal_contractResponse create_acct_universal_contract(create_acct_universal_contractRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("create_acct_universal_contract");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&type_no=" + request.type_no;
            url += "&length_months=" + request.length_months;
            url += "&create_comments=" + request.create_comments;
            url += "&start_date=" + request.start_date;
            url += "&end_date=" + request.end_date;
            
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
            create_acct_universal_contractResponse myDeserializedObj = json.Deserialize(reader, typeof(create_acct_universal_contractResponse)) as create_acct_universal_contractResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public modify_acct_universal_contractResponse modify_acct_universal_contract(modify_acct_universal_contractRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("modify_acct_universal_contract");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&contract_no=" + request.contract_no;
            url += "&type_no=" + request.type_no;
            url += "&length_months=" + request.length_months;
            url += "&start_date=" + request.start_date;
            url += "&update_comments=" + request.update_comments;
            url += "&end_date=" + request.end_date;
            
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
            modify_acct_universal_contractResponse myDeserializedObj = json.Deserialize(reader, typeof(modify_acct_universal_contractResponse)) as modify_acct_universal_contractResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public cancel_acct_universal_contractResponse cancel_acct_universal_contract(cancel_acct_universal_contractRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("cancel_acct_universal_contract");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&update_comments=" + request.update_comments;
            url += "&close_status=" + request.close_status;
            
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
            cancel_acct_universal_contractResponse myDeserializedObj = json.Deserialize(reader, typeof(cancel_acct_universal_contractResponse)) as cancel_acct_universal_contractResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_all_acct_active_contractsResponse get_all_acct_active_contracts(get_all_acct_active_contractsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_all_acct_active_contracts");

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
            get_all_acct_active_contractsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_all_acct_active_contractsResponse)) as get_all_acct_active_contractsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_acct_hierarchy_detailsResponse get_acct_hierarchy_details(get_acct_hierarchy_detailsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_hierarchy_details");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&hierarchy_filter=" + request.hierarchy_filter;
            url += "&include_current_acct=" + request.include_current_acct;
            
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
            get_acct_hierarchy_detailsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_hierarchy_detailsResponse)) as get_acct_hierarchy_detailsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_all_acct_contractsResponse get_all_acct_contracts(get_all_acct_contractsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_all_acct_contracts");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&filter_status_code=" + request.filter_status_code;
            
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
            get_all_acct_contractsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_all_acct_contractsResponse)) as get_all_acct_contractsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public set_acct_notify_overrideResponse set_acct_notify_override(set_acct_notify_overrideRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("set_acct_notify_override");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&template_class=" + request.template_class;
            url += "&acct_no=" + request.acct_no;
            url += "&acct_user_id=" + request.acct_user_id;
            url += "&client_acct_id=" + request.client_acct_id;
            url += "&override_template_no=" + request.override_template_no;
            url += "&behavioral_option=" + request.behavioral_option;
            url += "&override_template_option=" + request.override_template_option;
            
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
            set_acct_notify_overrideResponse myDeserializedObj = json.Deserialize(reader, typeof(set_acct_notify_overrideResponse)) as set_acct_notify_overrideResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public set_acct_notify_tmplt_grpResponse set_acct_notify_tmplt_grp(set_acct_notify_tmplt_grpRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("set_acct_notify_tmplt_grp");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&notification_template_group_id=" + request.notification_template_group_id;
            url += "&acct_no=" + request.acct_no;
            url += "&acct_user_id=" + request.acct_user_id;
            url += "&client_acct_id=" + request.client_acct_id;
            
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
            set_acct_notify_tmplt_grpResponse myDeserializedObj = json.Deserialize(reader, typeof(set_acct_notify_tmplt_grpResponse)) as set_acct_notify_tmplt_grpResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_acct_notification_detailsResponse get_acct_notification_details(get_acct_notification_detailsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_notification_details");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&acct_user_id=" + request.acct_user_id;
            url += "&client_acct_id=" + request.client_acct_id;
            
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
            get_acct_notification_detailsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_notification_detailsResponse)) as get_acct_notification_detailsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_acct_creditsResponse get_acct_credits(get_acct_creditsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_credits");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&limit_records=" + request.limit_records;
            
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
            get_acct_creditsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_creditsResponse)) as get_acct_creditsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_acct_credit_detailsResponse get_acct_credit_details(get_acct_credit_detailsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_credit_details");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&credit_no=" + request.credit_no;
            
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
            get_acct_credit_detailsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_credit_detailsResponse)) as get_acct_credit_detailsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_credit_reason_codesResponse get_credit_reason_codes(get_credit_reason_codesRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_credit_reason_codes");

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
            get_credit_reason_codesResponse myDeserializedObj = json.Deserialize(reader, typeof(get_credit_reason_codesResponse)) as get_credit_reason_codesResponse;
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

        public get_acct_service_outage_creditResponse get_acct_service_outage_credit(get_acct_service_outage_creditRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_service_outage_credit");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&outage_start_date=" + request.outage_start_date;
            url += "&outage_end_date=" + request.outage_end_date;
            url += "&outage_start_time=" + request.outage_start_time;
            url += "&outage_end_time=" + request.outage_end_time;
            RestUtilities.addParameterValuesFromArray(ref url, request.plans_to_get_outage);
            url += "&adjust_percent=" + request.adjust_percent;
            
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
            get_acct_service_outage_creditResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_service_outage_creditResponse)) as get_acct_service_outage_creditResponse;
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
            url += "&reason_code=" + request.reason_code;
            url += "&comments=" + request.comments;
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
            url += "&bill_immediately=" + request.bill_immediately;
            RestUtilities.addParameterValuesFromArray(ref url, request.order_line_items);
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
            url += "&bill_address3=" + request.bill_address3;
            url += "&do_write=" + request.do_write;
            url += "&coupon_cd=" + request.coupon_cd;
            url += "&alt_client_acct_group_id=" + request.alt_client_acct_group_id;
            url += "&track_data1=" + request.track_data1;
            url += "&track_data2=" + request.track_data2;
            url += "&alt_inv_template_no=" + request.alt_inv_template_no;
            
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
            url += "&bill_address3=" + request.bill_address3;
            url += "&alt_client_acct_group_id=" + request.alt_client_acct_group_id;
            url += "&track_data1=" + request.track_data1;
            url += "&track_data2=" + request.track_data2;
            url += "&force_balance_scope=" + request.force_balance_scope;
            
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
            url += "&bill_address3=" + request.bill_address3;
            url += "&alt_client_acct_group_id=" + request.alt_client_acct_group_id;
            url += "&track_data1=" + request.track_data1;
            url += "&track_data2=" + request.track_data2;
            url += "&payment_application_method=" + request.payment_application_method;
            
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
            url += "&payment_amount=" + request.payment_amount;
            url += "&reference_code=" + request.reference_code;
            url += "&comments=" + request.comments;
            url += "&client_receipt_id=" + request.client_receipt_id;
            RestUtilities.addParameterValuesFromArray(ref url, request.specific_charge_transaction_id);
            url += "&external_destination_id=" + request.external_destination_id;
            url += "&external_id=" + request.external_id;
            
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
            url += "&payment_amount=" + request.payment_amount;
            url += "&reference_code=" + request.reference_code;
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
            url += "&credit_reason_code=" + request.credit_reason_code;
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
            apply_service_creditResponse myDeserializedObj = json.Deserialize(reader, typeof(apply_service_creditResponse)) as apply_service_creditResponse;
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
            url += "&credit_reason_code=" + request.credit_reason_code;
            url += "&comments=" + request.comments;
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
            apply_cash_creditResponse myDeserializedObj = json.Deserialize(reader, typeof(apply_cash_creditResponse)) as apply_cash_creditResponse;
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
            url += "&billing_interval_units=" + request.billing_interval_units;
            url += "&times_to_bill=" + request.times_to_bill;
            url += "&billing_interval_type=" + request.billing_interval_type;
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

        public move_paymentResponse move_payment(move_paymentRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("move_payment");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&account_no=" + request.account_no;
            url += "&payment_id=" + request.payment_id;
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
            move_paymentResponse myDeserializedObj = json.Deserialize(reader, typeof(move_paymentResponse)) as move_paymentResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public bulk_record_usageResponse bulk_record_usage(bulk_record_usageRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("bulk_record_usage");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            RestUtilities.addParameterValuesFromArray(ref url, request.usage_records);
            
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
            bulk_record_usageResponse myDeserializedObj = json.Deserialize(reader, typeof(bulk_record_usageResponse)) as bulk_record_usageResponse;
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
            url += "&usage_units=" + request.usage_units;
            url += "&acct_no=" + request.acct_no;
            url += "&userid=" + request.userid;
            url += "&usage_type=" + request.usage_type;
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
            url += "&parent_usage_rec_no=" + request.parent_usage_rec_no;
            url += "&usage_type_code=" + request.usage_type_code;
            url += "&client_record_id=" + request.client_record_id;
            url += "&caller_id=" + request.caller_id;
            
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
            url += "&limit_records=" + request.limit_records;
            url += "&details_flag=" + request.details_flag;
            
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
            url += "&address3=" + request.address3;
            
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
            url += "&alt_bill_day=" + request.alt_bill_day;
            
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

        public get_acct_preview_statementResponse get_acct_preview_statement(get_acct_preview_statementRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_preview_statement");

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
            get_acct_preview_statementResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_preview_statementResponse)) as get_acct_preview_statementResponse;
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
            url += "&bill_address3=" + request.bill_address3;
            url += "&track_data1=" + request.track_data1;
            url += "&track_data2=" + request.track_data2;
            
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

        public get_refund_detailsResponse get_refund_details(get_refund_detailsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_refund_details");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&include_voided=" + request.include_voided;
            url += "&aria_event_no=" + request.aria_event_no;
            
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
            get_refund_detailsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_refund_detailsResponse)) as get_refund_detailsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public create_order_with_plansResponse create_order_with_plans(create_order_with_plansRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("create_order_with_plans");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            RestUtilities.addParameterValuesFromArray(ref url, request.order_line_items);
            RestUtilities.addParameterValuesFromArray(ref url, request.cart_supp_plans);
            url += "&client_order_id=" + request.client_order_id;
            url += "&coupon_code=" + request.coupon_code;
            url += "&comments=" + request.comments;
            url += "&do_write=" + request.do_write;
            url += "&client_receipt_id=" + request.client_receipt_id;
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
            url += "&bill_address3=" + request.bill_address3;
            url += "&track_data1=" + request.track_data1;
            url += "&track_data2=" + request.track_data2;
            url += "&alt_inv_template_no=" + request.alt_inv_template_no;
            
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
            create_order_with_plansResponse myDeserializedObj = json.Deserialize(reader, typeof(create_order_with_plansResponse)) as create_order_with_plansResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_refundable_paymentsResponse get_refundable_payments(get_refundable_paymentsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_refundable_payments");

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
            get_refundable_paymentsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_refundable_paymentsResponse)) as get_refundable_paymentsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_reversible_invs_by_paymentResponse get_reversible_invs_by_payment(get_reversible_invs_by_paymentRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_reversible_invs_by_payment");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&payment_transaction_id=" + request.payment_transaction_id;
            
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
            get_reversible_invs_by_paymentResponse myDeserializedObj = json.Deserialize(reader, typeof(get_reversible_invs_by_paymentResponse)) as get_reversible_invs_by_paymentResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public issue_refund_to_acctResponse issue_refund_to_acct(issue_refund_to_acctRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("issue_refund_to_acct");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&payment_transaction_id=" + request.payment_transaction_id;
            url += "&reason_code=" + request.reason_code;
            url += "&total_refund_amount=" + request.total_refund_amount;
            url += "&refund_check_number=" + request.refund_check_number;
            url += "&comments=" + request.comments;
            url += "&do_write=" + request.do_write;
            url += "&auto_calc_refund=" + request.auto_calc_refund;
            RestUtilities.addParameterValuesFromArray(ref url, request.invoices_to_reverse);
            
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
            issue_refund_to_acctResponse myDeserializedObj = json.Deserialize(reader, typeof(issue_refund_to_acctResponse)) as issue_refund_to_acctResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_writeoff_detailsResponse get_writeoff_details(get_writeoff_detailsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_writeoff_details");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&aria_event_no=" + request.aria_event_no;
            
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
            get_writeoff_detailsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_writeoff_detailsResponse)) as get_writeoff_detailsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_aria_xml_statementResponse get_aria_xml_statement(get_aria_xml_statementRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_aria_xml_statement");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&xml_statement_no=" + request.xml_statement_no;
            
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
            get_aria_xml_statementResponse myDeserializedObj = json.Deserialize(reader, typeof(get_aria_xml_statementResponse)) as get_aria_xml_statementResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_acct_payment_historyResponse get_acct_payment_history(get_acct_payment_historyRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_payment_history");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&start_date=" + request.start_date;
            url += "&end_date=" + request.end_date;
            url += "&limit_records=" + request.limit_records;
            url += "&details_flag=" + request.details_flag;
            
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
            get_acct_payment_historyResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_payment_historyResponse)) as get_acct_payment_historyResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_payment_application_dtlsResponse get_payment_application_dtls(get_payment_application_dtlsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_payment_application_dtls");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
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
            get_payment_application_dtlsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_payment_application_dtlsResponse)) as get_payment_application_dtlsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_extended_transaction_infoResponse get_extended_transaction_info(get_extended_transaction_infoRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_extended_transaction_info");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
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
            get_extended_transaction_infoResponse myDeserializedObj = json.Deserialize(reader, typeof(get_extended_transaction_infoResponse)) as get_extended_transaction_infoResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public discard_usageResponse discard_usage(discard_usageRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("discard_usage");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            RestUtilities.addParameterValuesFromArray(ref url, request.usage_record_nos);
            RestUtilities.addParameterValuesFromArray(ref url, request.client_record_ids);
            url += "&exclusion_reason_cd=" + request.exclusion_reason_cd;
            url += "&exclusion_comment=" + request.exclusion_comment;
            
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
            discard_usageResponse myDeserializedObj = json.Deserialize(reader, typeof(discard_usageResponse)) as discard_usageResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public create_writeoff_or_disputeResponse create_writeoff_or_dispute(create_writeoff_or_disputeRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("create_writeoff_or_dispute");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&invoice_no=" + request.invoice_no;
            url += "&amount=" + request.amount;
            url += "&reason_code=" + request.reason_code;
            url += "&comments=" + request.comments;
            url += "&do_dispute=" + request.do_dispute;
            
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
            create_writeoff_or_disputeResponse myDeserializedObj = json.Deserialize(reader, typeof(create_writeoff_or_disputeResponse)) as create_writeoff_or_disputeResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_acct_writeoff_or_disputesResponse get_acct_writeoff_or_disputes(get_acct_writeoff_or_disputesRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_writeoff_or_disputes");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&dispute_or_writeoff_flag=" + request.dispute_or_writeoff_flag;
            url += "&details_flag=" + request.details_flag;
            
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
            get_acct_writeoff_or_disputesResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_writeoff_or_disputesResponse)) as get_acct_writeoff_or_disputesResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_invoices_to_writeoff_or_disputeResponse get_invoices_to_writeoff_or_dispute(get_invoices_to_writeoff_or_disputeRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_invoices_to_writeoff_or_dispute");

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
            get_invoices_to_writeoff_or_disputeResponse myDeserializedObj = json.Deserialize(reader, typeof(get_invoices_to_writeoff_or_disputeResponse)) as get_invoices_to_writeoff_or_disputeResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public settle_dispute_holdResponse settle_dispute_hold(settle_dispute_holdRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("settle_dispute_hold");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&acct_no=" + request.acct_no;
            url += "&dispute_no=" + request.dispute_no;
            url += "&settlement_action=" + request.settlement_action;
            
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
            settle_dispute_holdResponse myDeserializedObj = json.Deserialize(reader, typeof(settle_dispute_holdResponse)) as settle_dispute_holdResponse;
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
            set_sessionResponse myDeserializedObj = json.Deserialize(reader, typeof(set_sessionResponse)) as set_sessionResponse;
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

        #endregion Api Calls
    }
}