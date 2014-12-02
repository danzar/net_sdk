using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Aria.SDK.AriaServices.AriaWebServices.AriaComplete;

namespace Aria.SDK.AriaServices.AriaWebServices
{
    public class AriaBillingComplete : AriaBillingBase
    {
        #region Constructor
        /*Creates a new AriaBillingComplete with no parms*/
        public AriaBillingComplete() : base ("https://secure.unstable.dev.ariasystems.net/api/ws/api_ws_class_dispatcher.php")
        {
        }
        /*Creates a new AriaBillingComplete with URL parm*/
        public AriaBillingComplete(String URL) : base (URL)
        {
        }
        #endregion Constructor

        #region Api Calls
        public get_client_plans_allResponse get_client_plans_all(get_client_plans_allRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_client_plans_all");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.plan_no)));
            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&promo_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.promo_code)));
            sPost += "&parent_plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.parent_plan_no)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.supp_field_names, "&supp_field_names");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.supp_field_values, "&supp_field_values");
            sPost += "&include_all_rate_schedules=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.include_all_rate_schedules)));
            sPost += "&include_plan_hierarchy=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.include_plan_hierarchy)));
            sPost += "&client_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_plan_id)));
            sPost += "&client_parent_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_parent_plan_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&on_off_indicator=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.on_off_indicator)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&file_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.file_name)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&ip_address=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.ip_address)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&filter_currency_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.filter_currency_cd)));
            sPost += "&return_no_cost_items=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.return_no_cost_items)));
            sPost += "&filter_item_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.filter_item_no)));
            sPost += "&client_filter_item_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_filter_item_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&filter_currency_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.filter_currency_cd)));
            sPost += "&return_no_cost_items=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.return_no_cost_items)));
            sPost += "&filter_item_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.filter_item_no)));
            sPost += "&include_inactive_items=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.include_inactive_items)));
            sPost += "&filter_client_item_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.filter_client_item_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&filter_currency_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.filter_currency_cd)));
            sPost += "&return_no_cost_items=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.return_no_cost_items)));
            sPost += "&filter_item_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.filter_item_no)));
            sPost += "&filter_client_item_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.filter_client_item_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&filter_item_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.filter_item_no)));
            sPost += "&filter_client_item_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.filter_client_item_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&filter_item_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.filter_item_no)));
            sPost += "&filter_client_item_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.filter_client_item_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            RestUtilities.addParameterValuesFromArray(ref sPost, request.web_vals_in, "&web_vals_in");
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.plan_no)));
            sPost += "&client_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_plan_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.plan_no)));
            sPost += "&client_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_plan_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.plan_no)));
            sPost += "&service_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.service_no)));
            sPost += "&alt_rate_schedule_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_rate_schedule_no)));
            sPost += "&client_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_plan_id)));
            sPost += "&client_service_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_service_id)));
            sPost += "&client_alt_rate_schedule_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_alt_rate_schedule_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&class_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.class_no)));
            sPost += "&do_write=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_write)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&class_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.class_no)));
            sPost += "&do_write=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_write)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&event_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.event_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&event_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.event_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            RestUtilities.addParameterValuesFromArray(ref sPost, request.event_list, "&event_list");
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            RestUtilities.addParameterValuesFromArray(ref sPost, request.event_list, "&event_list");
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&class_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.class_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&rand_type=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.rand_type)));
            sPost += "&rand_length=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.rand_length)));
            sPost += "&rand_case=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.rand_case)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.plan_no)));
            sPost += "&currency_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.currency_cd)));
            sPost += "&client_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_plan_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&start_date_range=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.start_date_range)));
            sPost += "&end_date_range=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.end_date_range)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&filter_currency_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.filter_currency_cd)));
            sPost += "&return_no_cost_items=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.return_no_cost_items)));
            sPost += "&filter_item_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.filter_item_no)));
            sPost += "&include_inactive_items=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.include_inactive_items)));
            sPost += "&filter_client_item_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.filter_client_item_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&session_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.session_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&session_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.session_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.in_reg_uss_params, "&in_reg_uss_params");
            sPost += "&override_timeout_minutes=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.override_timeout_minutes)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&session_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.session_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.param_names, "&param_names");
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&session_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.session_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.in_reg_uss_params, "&in_reg_uss_params");
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&session_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.session_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&set_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.set_name)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&set_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.set_name)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.in_reg_uss_config_params, "&in_reg_uss_config_params");
            sPost += "&set_description=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.set_description)));
            sPost += "&set_type_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.set_type_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&set_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.set_name)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.param_names, "&param_names");
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&set_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.set_name)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.in_reg_uss_config_params, "&in_reg_uss_config_params");
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&set_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.set_name)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            RestUtilities.addParameterValuesFromArray(ref sPost, request.inventory_item_stock, "&inventory_item_stock");
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&item_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.item_no)));
            sPost += "&client_item_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_item_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&filter_class_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.filter_class_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&filter_class_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.filter_class_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&filter_class_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.filter_class_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&field_val=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.field_val)));
            sPost += "&field_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.field_no)));
            sPost += "&field_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.field_name)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&field_val=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.field_val)));
            sPost += "&field_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.field_no)));
            sPost += "&field_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.field_name)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&field_val=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.field_val)));
            sPost += "&field_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.field_no)));
            sPost += "&field_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.field_name)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&offset_hours=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.offset_hours)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&batch_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.batch_date)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&destination_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.destination_id)));
            sPost += "&source_type_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.source_type_id)));
            sPost += "&object_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.object_id)));
            sPost += "&external_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.external_id)));
            sPost += "&action_directive=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.action_directive)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

        public get_acct_surchargesResponse get_acct_surcharges(get_acct_surchargesRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_surcharges");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&include_detail_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.include_detail_ind)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

            JsonSerializer json = new JsonSerializer
                          {
                              NullValueHandling = NullValueHandling.Ignore,
                              ObjectCreationHandling = ObjectCreationHandling.Replace,
                              MissingMemberHandling = MissingMemberHandling.Ignore,
                              ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                          };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_acct_surchargesResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_surchargesResponse)) as get_acct_surchargesResponse;
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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&coupon_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.coupon_cd)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&coupon_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.coupon_cd)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_no)));
            sPost += "&first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.first_name)));
            sPost += "&last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.last_name)));
            sPost += "&mi=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.mi)));
            sPost += "&company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.company_name)));
            sPost += "&address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.address1)));
            sPost += "&address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.address2)));
            sPost += "&city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.city)));
            sPost += "&locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.locality)));
            sPost += "&state_prov=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.state_prov)));
            sPost += "&country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.country)));
            sPost += "&postal_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.postal_code)));
            sPost += "&intl_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.intl_phone)));
            sPost += "&alt_email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_email)));
            sPost += "&birthdate=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.birthdate)));
            sPost += "&address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.address3)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_no)));
            sPost += "&password=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.password)));
            sPost += "&secret_question_answer=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.secret_question_answer)));
            sPost += "&secret_question=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.secret_question)));
            sPost += "&pin=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.pin)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_no)));
            sPost += "&status_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.status_cd)));
            sPost += "&queue_days=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.queue_days)));
            sPost += "&queue_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.queue_date)));
            sPost += "&force_bill_date_reset=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.force_bill_date_reset)));
            sPost += "&comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.comments)));
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            sPost += "&alt_do_dunning=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_do_dunning)));
            sPost += "&status_degrade_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.status_degrade_date)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_no)));
            sPost += "&field_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.field_name)));
            sPost += "&value_text=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.value_text)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_no)));
            sPost += "&first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.first_name)));
            sPost += "&last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.last_name)));
            sPost += "&middle_initial=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.middle_initial)));
            sPost += "&company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.company_name)));
            sPost += "&address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.address1)));
            sPost += "&address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.address2)));
            sPost += "&city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.city)));
            sPost += "&locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.locality)));
            sPost += "&state=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.state)));
            sPost += "&country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.country)));
            sPost += "&zip=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.zip)));
            sPost += "&intl_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.intl_phone)));
            sPost += "&email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.email)));
            sPost += "&do_collect=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_collect)));
            sPost += "&change_status_after_coll=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.change_status_after_coll)));
            sPost += "&reset_dates_after_status=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.reset_dates_after_status)));
            sPost += "&address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.address3)));
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_no)));
            sPost += "&notify_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.notify_method)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_no)));
            sPost += "&bank_routing_num=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_routing_num)));
            sPost += "&bank_acct_num=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_acct_num)));
            sPost += "&do_collect=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_collect)));
            sPost += "&change_status_after_coll=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.change_status_after_coll)));
            sPost += "&reset_dates_after_status=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.reset_dates_after_status)));
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_no)));
            sPost += "&cc_expire_mm=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_expire_mm)));
            sPost += "&cc_expire_yyyy=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_expire_yyyy)));
            sPost += "&cc_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_number)));
            sPost += "&do_collect=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_collect)));
            sPost += "&change_status_after_coll=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.change_status_after_coll)));
            sPost += "&reset_dates_after_status=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.reset_dates_after_status)));
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_no)));
            sPost += "&pay_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.pay_method)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_no)));
            sPost += "&resp_level_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.resp_level_cd)));
            sPost += "&senior_account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.senior_account_no)));
            sPost += "&senior_acct_user_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.senior_acct_user_id)));
            sPost += "&client_senior_acct_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_senior_acct_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_no)));
            sPost += "&plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.plan_no)));
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            sPost += "&client_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_plan_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_no)));
            sPost += "&test_acct_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.test_acct_ind)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_no)));
            sPost += "&CVV=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.CVV)));
            sPost += "&seq_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.seq_no)));
            sPost += "&inTrackingNumber=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.inTrackingNumber)));
            sPost += "&inAuthValue=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.inAuthValue)));
            sPost += "&alt_pay_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_pay_method)));
            sPost += "&cc_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_number)));
            sPost += "&cc_expire_mm=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_expire_mm)));
            sPost += "&cc_expire_yyyy=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_expire_yyyy)));
            sPost += "&bill_company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_company_name)));
            sPost += "&bill_first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_first_name)));
            sPost += "&bill_middle_initial=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_middle_initial)));
            sPost += "&bill_last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_last_name)));
            sPost += "&bill_address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_address1)));
            sPost += "&bill_address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_address2)));
            sPost += "&bill_city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_city)));
            sPost += "&bill_locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_locality)));
            sPost += "&bill_state_prov=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_state_prov)));
            sPost += "&bill_zip=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_zip)));
            sPost += "&bill_country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_country)));
            sPost += "&bill_email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_email)));
            sPost += "&bill_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_phone)));
            sPost += "&bill_phone_extension=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_phone_extension)));
            sPost += "&bill_cell_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_cell_phone)));
            sPost += "&bill_work_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_work_phone)));
            sPost += "&bill_work_phone_extension=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_work_phone_extension)));
            sPost += "&currency_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.currency_cd)));
            sPost += "&acct_group_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_group_no)));
            sPost += "&bill_address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_address3)));
            sPost += "&alt_client_acct_group_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_client_acct_group_id)));
            sPost += "&track_data1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.track_data1)));
            sPost += "&track_data2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.track_data2)));
            sPost += "&client_acct_group_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_acct_group_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_no)));
            sPost += "&userid=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.userid)));
            sPost += "&days_to_restore=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.days_to_restore)));
            sPost += "&date_to_restore=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.date_to_restore)));
            sPost += "&reason_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.reason_cd)));
            sPost += "&comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.comments)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_no)));
            sPost += "&transaction_type=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.transaction_type)));
            sPost += "&start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.start_date)));
            sPost += "&end_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.end_date)));
            sPost += "&record_limit=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.record_limit)));
            sPost += "&filter_statement_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.filter_statement_no)));
            sPost += "&include_void_transactions=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.include_void_transactions)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_number)));
            sPost += "&first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.first_name)));
            sPost += "&last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.last_name)));
            sPost += "&middle_initial=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.middle_initial)));
            sPost += "&company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.company_name)));
            sPost += "&address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.address1)));
            sPost += "&address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.address2)));
            sPost += "&city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.city)));
            sPost += "&locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.locality)));
            sPost += "&state=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.state)));
            sPost += "&country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.country)));
            sPost += "&zip=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.zip)));
            sPost += "&intl_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.intl_phone)));
            sPost += "&phone_npa=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.phone_npa)));
            sPost += "&phone_nxx=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.phone_nxx)));
            sPost += "&phone_suffix=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.phone_suffix)));
            sPost += "&phone_extension=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.phone_extension)));
            sPost += "&email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.email)));
            sPost += "&pay_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.pay_method)));
            sPost += "&cc_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_number)));
            sPost += "&cc_expire_mm=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_expire_mm)));
            sPost += "&cc_expire_yyyy=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_expire_yyyy)));
            sPost += "&bank_routing_num=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_routing_num)));
            sPost += "&bank_acct_num=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_acct_num)));
            sPost += "&do_collect=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_collect)));
            sPost += "&change_status_after_coll=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.change_status_after_coll)));
            sPost += "&reset_dates_after_status=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.reset_dates_after_status)));
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            sPost += "&iban=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.iban)));
            sPost += "&bank_check_digit=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_check_digit)));
            sPost += "&bank_swift_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_swift_cd)));
            sPost += "&bank_country_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_country_cd)));
            sPost += "&mandate_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.mandate_id)));
            sPost += "&bank_id_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_id_cd)));
            sPost += "&bank_branch_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_branch_cd)));
            sPost += "&primary_or_bkup_pay_method_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.primary_or_bkup_pay_method_ind)));
            sPost += "&ref_bkup_seq_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.ref_bkup_seq_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_number)));
            sPost += "&amount=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.amount)));
            sPost += "&payment_source=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.payment_source)));
            sPost += "&CVV=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.CVV)));
            sPost += "&bill_seq=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_seq)));
            sPost += "&inTrackingNumber=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.inTrackingNumber)));
            sPost += "&inAuthValue=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.inAuthValue)));
            sPost += "&alt_client_acct_group_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_client_acct_group_id)));
            sPost += "&track_data1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.track_data1)));
            sPost += "&track_data2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.track_data2)));
            sPost += "&alt_pay_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_pay_method)));
            sPost += "&cc_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_number)));
            sPost += "&cc_expire_mm=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_expire_mm)));
            sPost += "&cc_expire_yyyy=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_expire_yyyy)));
            sPost += "&bank_routing_num=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_routing_num)));
            sPost += "&bank_acct_num=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_acct_num)));
            sPost += "&bill_company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_company_name)));
            sPost += "&bill_first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_first_name)));
            sPost += "&bill_middle_initial=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_middle_initial)));
            sPost += "&bill_last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_last_name)));
            sPost += "&bill_address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_address1)));
            sPost += "&bill_address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_address2)));
            sPost += "&bill_address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_address3)));
            sPost += "&bill_city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_city)));
            sPost += "&bill_locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_locality)));
            sPost += "&bill_state_prov=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_state_prov)));
            sPost += "&bill_zip=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_zip)));
            sPost += "&bill_country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_country)));
            sPost += "&bill_email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_email)));
            sPost += "&bill_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_phone)));
            sPost += "&bill_phone_extension=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_phone_extension)));
            sPost += "&bill_cell_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_cell_phone)));
            sPost += "&bill_work_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_work_phone)));
            sPost += "&bill_work_phone_extension=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_work_phone_extension)));
            sPost += "&record_cc_on_auth_failure=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.record_cc_on_auth_failure)));
            sPost += "&iban=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.iban)));
            sPost += "&bank_check_digit=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_check_digit)));
            sPost += "&bank_swift_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_swift_cd)));
            sPost += "&bank_country_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_country_cd)));
            sPost += "&mandate_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.mandate_id)));
            sPost += "&bank_id_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_id_cd)));
            sPost += "&bank_branch_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_branch_cd)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_number)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_number)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.plan_no_to_remove, "&plan_no_to_remove");
            sPost += "&remove_all_queued_plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.remove_all_queued_plan_no)));
            sPost += "&remove_terminate_pending=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.remove_terminate_pending)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_number)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_number)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.plan_no)));
            sPost += "&client_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_plan_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&promo_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.promo_code)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&promo_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.promo_code)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&parent_acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.parent_acct_no)));
            sPost += "&do_multi_level=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_multi_level)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&parent_acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.parent_acct_no)));
            sPost += "&do_multi_level=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_multi_level)));
            sPost += "&trans_type=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.trans_type)));
            sPost += "&start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.start_date)));
            sPost += "&end_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.end_date)));
            sPost += "&record_limit=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.record_limit)));
            sPost += "&include_void_transactions=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.include_void_transactions)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&seq_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.seq_no)));
            sPost += "&address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.address1)));
            sPost += "&address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.address2)));
            sPost += "&city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.city)));
            sPost += "&state=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.state)));
            sPost += "&zip=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.zip)));
            sPost += "&country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.country)));
            sPost += "&cc_expire_mm=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_expire_mm)));
            sPost += "&cc_expire_yyyy=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_expire_yyyy)));
            sPost += "&phone_npa=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.phone_npa)));
            sPost += "&phone_nxx=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.phone_nxx)));
            sPost += "&phone_suffix=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.phone_suffix)));
            sPost += "&phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.phone_ext)));
            sPost += "&phone_country_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.phone_country_cd)));
            sPost += "&intl_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.intl_phone)));
            sPost += "&email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.email)));
            sPost += "&locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.locality)));
            sPost += "&cell_phone_npa=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cell_phone_npa)));
            sPost += "&cell_phone_nxx=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cell_phone_nxx)));
            sPost += "&cell_phone_suffix=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cell_phone_suffix)));
            sPost += "&work_phone_npa=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.work_phone_npa)));
            sPost += "&work_phone_nxx=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.work_phone_nxx)));
            sPost += "&work_phone_suffix=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.work_phone_suffix)));
            sPost += "&work_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.work_phone_ext)));
            sPost += "&do_collect=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_collect)));
            sPost += "&change_status_after_coll=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.change_status_after_coll)));
            sPost += "&reset_dates_after_status=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.reset_dates_after_status)));
            sPost += "&address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.address3)));
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&user_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.user_id)));
            sPost += "&template_class=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.template_class)));
            sPost += "&template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.template_no)));
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            sPost += "&client_template_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_template_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&user_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.user_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&user_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.user_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&usage_type=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.usage_type)));
            sPost += "&usage_units=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.usage_units)));
            sPost += "&next_usage_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.next_usage_date)));
            sPost += "&alt_desc=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_desc)));
            sPost += "&plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.plan_no)));
            sPost += "&first_usage_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.first_usage_date)));
            sPost += "&recurring_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.recurring_ind)));
            sPost += "&usage_type_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.usage_type_code)));
            sPost += "&client_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_plan_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&standing_usage_rec_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.standing_usage_rec_no)));
            sPost += "&comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.comments)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.plan_no)));
            sPost += "&comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.comments)));
            sPost += "&client_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_plan_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.comments)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&field_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.field_name)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&promo_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.promo_code)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&promo_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.promo_code)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&supp_plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.supp_plan_no)));
            sPost += "&alt_rate_schedule_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_rate_schedule_no)));
            sPost += "&num_plan_units=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.num_plan_units)));
            sPost += "&coupon_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.coupon_code)));
            sPost += "&assignment_directive=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.assignment_directive)));
            sPost += "&comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.comments)));
            sPost += "&do_write=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_write)));
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            sPost += "&contract_type_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.contract_type_no)));
            sPost += "&contract_alt_recur_fee=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.contract_alt_recur_fee)));
            sPost += "&contract_length_months=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.contract_length_months)));
            sPost += "&contract_cancel_fee=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.contract_cancel_fee)));
            sPost += "&contract_comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.contract_comments)));
            sPost += "&contract_start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.contract_start_date)));
            sPost += "&offset_months=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.offset_months)));
            sPost += "&auto_offset_months_option=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auto_offset_months_option)));
            sPost += "&alt_proration_start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_proration_start_date)));
            sPost += "&alt_client_acct_group_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_client_acct_group_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.new_acct_custom_rates, "&new_acct_custom_rates");
            sPost += "&effective_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.effective_date)));
            sPost += "&offset_interval=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.offset_interval)));
            sPost += "&contract_end_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.contract_end_date)));
            sPost += "&sync_mstr_bill_dates_override=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.sync_mstr_bill_dates_override)));
            sPost += "&client_supp_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_supp_plan_id)));
            sPost += "&client_alt_rate_schedule_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_alt_rate_schedule_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.surcharge_no, "&surcharge_no");
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&supp_plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.supp_plan_no)));
            sPost += "&assignment_directive=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.assignment_directive)));
            sPost += "&comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.comments)));
            sPost += "&do_write=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_write)));
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            sPost += "&alt_proration_start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_proration_start_date)));
            sPost += "&effective_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.effective_date)));
            sPost += "&offset_interval=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.offset_interval)));
            sPost += "&invoice_unbilled_usage=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.invoice_unbilled_usage)));
            sPost += "&client_supp_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_supp_plan_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&supp_plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.supp_plan_no)));
            sPost += "&alt_rate_schedule_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_rate_schedule_no)));
            sPost += "&num_plan_units=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.num_plan_units)));
            sPost += "&coupon_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.coupon_code)));
            sPost += "&assignment_directive=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.assignment_directive)));
            sPost += "&comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.comments)));
            sPost += "&do_write=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_write)));
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.new_acct_custom_rates, "&new_acct_custom_rates");
            sPost += "&effective_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.effective_date)));
            sPost += "&offset_interval=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.offset_interval)));
            sPost += "&client_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_plan_id)));
            sPost += "&client_alt_rate_schedule_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_alt_rate_schedule_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.surcharge_no, "&surcharge_no");
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&existing_supp_plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.existing_supp_plan_no)));
            sPost += "&new_supp_plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.new_supp_plan_no)));
            sPost += "&alt_rate_schedule_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_rate_schedule_no)));
            sPost += "&num_plan_units=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.num_plan_units)));
            sPost += "&coupon_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.coupon_code)));
            sPost += "&assignment_directive=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.assignment_directive)));
            sPost += "&comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.comments)));
            sPost += "&do_write=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_write)));
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            sPost += "&offset_months=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.offset_months)));
            sPost += "&auto_offset_months_option=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auto_offset_months_option)));
            sPost += "&alt_client_acct_group_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_client_acct_group_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.new_acct_custom_rates, "&new_acct_custom_rates");
            sPost += "&effective_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.effective_date)));
            sPost += "&offset_interval=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.offset_interval)));
            sPost += "&invoice_unbilled_usage=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.invoice_unbilled_usage)));
            sPost += "&sync_mstr_bill_dates_override=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.sync_mstr_bill_dates_override)));
            sPost += "&client_existing_supp_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_existing_supp_plan_id)));
            sPost += "&client_new_supp_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_new_supp_plan_id)));
            sPost += "&client_alt_rate_schedule_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_alt_rate_schedule_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.surcharge_no, "&surcharge_no");
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&in_plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.in_plan_no)));
            sPost += "&in_client_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.in_client_plan_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&in_plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.in_plan_no)));
            sPost += "&in_client_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.in_client_plan_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&user_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.user_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&group_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.group_no)));
            sPost += "&client_acct_group_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_acct_group_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&group_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.group_no)));
            sPost += "&client_acct_group_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_acct_group_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&group_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.group_no)));
            sPost += "&client_acct_group_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_acct_group_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&alt_start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_start_date)));
            sPost += "&client_acct_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_acct_id)));
            sPost += "&userid=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.userid)));
            sPost += "&status_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.status_cd)));
            sPost += "&master_plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.master_plan_no)));
            sPost += "&master_plan_units=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.master_plan_units)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.supp_plans, "&supp_plans");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.supp_plan_units, "&supp_plan_units");
            sPost += "&notify_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.notify_method)));
            sPost += "&promo_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.promo_cd)));
            sPost += "&password=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.password)));
            sPost += "&secret_question=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.secret_question)));
            sPost += "&secret_question_answer=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.secret_question_answer)));
            sPost += "&first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.first_name)));
            sPost += "&mi=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.mi)));
            sPost += "&last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.last_name)));
            sPost += "&company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.company_name)));
            sPost += "&address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.address1)));
            sPost += "&address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.address2)));
            sPost += "&city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.city)));
            sPost += "&locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.locality)));
            sPost += "&state_prov=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.state_prov)));
            sPost += "&country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.country)));
            sPost += "&postal_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.postal_cd)));
            sPost += "&phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.phone)));
            sPost += "&phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.phone_ext)));
            sPost += "&cell_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cell_phone)));
            sPost += "&work_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.work_phone)));
            sPost += "&work_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.work_phone_ext)));
            sPost += "&email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.email)));
            sPost += "&birthdate=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.birthdate)));
            sPost += "&bill_first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_first_name)));
            sPost += "&bill_mi=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_mi)));
            sPost += "&bill_last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_last_name)));
            sPost += "&bill_company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_company_name)));
            sPost += "&bill_address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_address1)));
            sPost += "&bill_address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_address2)));
            sPost += "&bill_city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_city)));
            sPost += "&bill_locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_locality)));
            sPost += "&bill_state_prov=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_state_prov)));
            sPost += "&bill_country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_country)));
            sPost += "&bill_postal_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_postal_cd)));
            sPost += "&bill_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_phone)));
            sPost += "&bill_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_phone_ext)));
            sPost += "&bill_cell_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_cell_phone)));
            sPost += "&bill_work_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_work_phone)));
            sPost += "&bill_work_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_work_phone_ext)));
            sPost += "&bill_email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_email)));
            sPost += "&pay_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.pay_method)));
            sPost += "&cc_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_number)));
            sPost += "&cc_expire_mm=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_expire_mm)));
            sPost += "&cc_expire_yyyy=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_expire_yyyy)));
            sPost += "&bank_acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_acct_no)));
            sPost += "&bank_routing_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_routing_no)));
            sPost += "&resp_level_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.resp_level_cd)));
            sPost += "&senior_acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.senior_acct_no)));
            sPost += "&senior_acct_user_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.senior_acct_user_id)));
            sPost += "&client_senior_acct_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_senior_acct_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.functional_acct_groups, "&functional_acct_groups");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.collections_acct_groups, "&collections_acct_groups");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.supp_field_names, "&supp_field_names");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.supp_field_values, "&supp_field_values");
            sPost += "&test_acct_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.test_acct_ind)));
            sPost += "&status_until_alt_start=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.status_until_alt_start)));
            sPost += "&balance_forward=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.balance_forward)));
            sPost += "&alt_bill_day=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_bill_day)));
            sPost += "&do_full_invoicing=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_full_invoicing)));
            sPost += "&do_prorated_invoicing=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_prorated_invoicing)));
            sPost += "&master_plan_alt_rate_sched_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.master_plan_alt_rate_sched_no)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.supp_plan_alt_rate_sched_no, "&supp_plan_alt_rate_sched_no");
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            sPost += "&currency_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.currency_cd)));
            sPost += "&cvv=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cvv)));
            sPost += "&taxpayer_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.taxpayer_id)));
            sPost += "&bill_agreement_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_agreement_id)));
            sPost += "&retroactive_start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.retroactive_start_date)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.coupon_codes, "&coupon_codes");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.new_acct_custom_rates, "&new_acct_custom_rates");
            sPost += "&alt_msg_template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_msg_template_no)));
            sPost += "&seq_func_group_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.seq_func_group_no)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.new_acct_plan_contracts, "&new_acct_plan_contracts");
            sPost += "&address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.address3)));
            sPost += "&bill_address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_address3)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.usage_accumulation_config, "&usage_accumulation_config");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.enable_usage_pooling_plan_no, "&enable_usage_pooling_plan_no");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.client_func_acct_group_ids, "&client_func_acct_group_ids");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.client_coll_acct_group_ids, "&client_coll_acct_group_ids");
            sPost += "&track_data1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.track_data1)));
            sPost += "&track_data2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.track_data2)));
            sPost += "&do_write=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_write)));
            sPost += "&tax_exemption_level=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.tax_exemption_level)));
            sPost += "&cn_alt_msg_template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cn_alt_msg_template_no)));
            sPost += "&invoice_approval_required=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.invoice_approval_required)));
            sPost += "&create_session=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.create_session)));
            sPost += "&client_master_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_master_plan_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.client_supp_plan_ids, "&client_supp_plan_ids");
            sPost += "&client_mp_alt_rate_sched_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_mp_alt_rate_sched_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.client_sp_alt_rate_sched_ids, "&client_sp_alt_rate_sched_ids");
            sPost += "&client_alt_msg_template_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_alt_msg_template_id)));
            sPost += "&client_cn_alt_msg_template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_cn_alt_msg_template_no)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.surcharge_no, "&surcharge_no");
            sPost += "&iban=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.iban)));
            sPost += "&bank_check_digit=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_check_digit)));
            sPost += "&bank_swift_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_swift_cd)));
            sPost += "&bank_country_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_country_cd)));
            sPost += "&mandate_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.mandate_id)));
            sPost += "&bank_id_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_id_cd)));
            sPost += "&bank_branch_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_branch_cd)));
            sPost += "&bkup_bill_first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_first_name)));
            sPost += "&bkup_bill_mi=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_mi)));
            sPost += "&bkup_bill_last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_last_name)));
            sPost += "&bkup_bill_company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_company_name)));
            sPost += "&bkup_bill_address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_address1)));
            sPost += "&bkup_bill_address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_address2)));
            sPost += "&bkup_bill_address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_address3)));
            sPost += "&bkup_bill_city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_city)));
            sPost += "&bkup_bill_locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_locality)));
            sPost += "&bkup_bill_state_prov=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_state_prov)));
            sPost += "&bkup_bill_country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_country)));
            sPost += "&bkup_bill_postal_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_postal_cd)));
            sPost += "&bkup_bill_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_phone)));
            sPost += "&bkup_bill_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_phone_ext)));
            sPost += "&bkup_bill_cell_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_cell_phone)));
            sPost += "&bkup_bill_work_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_work_phone)));
            sPost += "&bkup_bill_work_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_work_phone_ext)));
            sPost += "&bkup_bill_email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_email)));
            sPost += "&bkup_pay_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_pay_method)));
            sPost += "&bkup_cc_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_cc_number)));
            sPost += "&bkup_cc_expire_mm=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_cc_expire_mm)));
            sPost += "&bkup_cc_expire_yyyy=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_cc_expire_yyyy)));
            sPost += "&bkup_bank_acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bank_acct_no)));
            sPost += "&bkup_bank_routing_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bank_routing_no)));
            sPost += "&bkup_bill_agreement_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_agreement_id)));
            sPost += "&bkup_cvv=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_cvv)));
            sPost += "&seq_func_group_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.seq_func_group_id)));
            sPost += "&revrec_profile_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.revrec_profile_id)));
            sPost += "&revrec_client_defined_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.revrec_client_defined_id)));
            sPost += "&stmnt_email_list=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.stmnt_email_list)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&do_write=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_write)));
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            sPost += "&a1_alt_start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_alt_start_date)));
            sPost += "&a1_client_acct_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_client_acct_id)));
            sPost += "&a1_userid=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_userid)));
            sPost += "&a1_status_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_status_cd)));
            sPost += "&a1_master_plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_master_plan_no)));
            sPost += "&a1_master_plan_units=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_master_plan_units)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a1_supp_plans, "&a1_supp_plans");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a1_supp_plan_units, "&a1_supp_plan_units");
            sPost += "&a1_notify_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_notify_method)));
            sPost += "&a1_promo_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_promo_cd)));
            sPost += "&a1_password=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_password)));
            sPost += "&a1_secret_question=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_secret_question)));
            sPost += "&a1_secret_question_answer=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_secret_question_answer)));
            sPost += "&a1_first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_first_name)));
            sPost += "&a1_mi=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_mi)));
            sPost += "&a1_last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_last_name)));
            sPost += "&a1_company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_company_name)));
            sPost += "&a1_address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_address1)));
            sPost += "&a1_address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_address2)));
            sPost += "&a1_city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_city)));
            sPost += "&a1_locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_locality)));
            sPost += "&a1_state_prov=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_state_prov)));
            sPost += "&a1_country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_country)));
            sPost += "&a1_postal_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_postal_cd)));
            sPost += "&a1_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_phone)));
            sPost += "&a1_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_phone_ext)));
            sPost += "&a1_cell_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_cell_phone)));
            sPost += "&a1_work_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_work_phone)));
            sPost += "&a1_work_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_work_phone_ext)));
            sPost += "&a1_email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_email)));
            sPost += "&a1_birthdate=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_birthdate)));
            sPost += "&a1_bill_first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bill_first_name)));
            sPost += "&a1_bill_mi=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bill_mi)));
            sPost += "&a1_bill_last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bill_last_name)));
            sPost += "&a1_bill_company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bill_company_name)));
            sPost += "&a1_bill_address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bill_address1)));
            sPost += "&a1_bill_address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bill_address2)));
            sPost += "&a1_bill_city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bill_city)));
            sPost += "&a1_bill_locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bill_locality)));
            sPost += "&a1_bill_state_prov=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bill_state_prov)));
            sPost += "&a1_bill_country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bill_country)));
            sPost += "&a1_bill_postal_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bill_postal_cd)));
            sPost += "&a1_bill_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bill_phone)));
            sPost += "&a1_bill_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bill_phone_ext)));
            sPost += "&a1_bill_cell_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bill_cell_phone)));
            sPost += "&a1_bill_work_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bill_work_phone)));
            sPost += "&a1_bill_work_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bill_work_phone_ext)));
            sPost += "&a1_bill_email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bill_email)));
            sPost += "&a1_pay_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_pay_method)));
            sPost += "&a1_cc_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_cc_number)));
            sPost += "&a1_cc_expire_mm=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_cc_expire_mm)));
            sPost += "&a1_cc_expire_yyyy=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_cc_expire_yyyy)));
            sPost += "&a1_bank_acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bank_acct_no)));
            sPost += "&a1_bank_routing_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bank_routing_no)));
            sPost += "&a1_resp_level_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_resp_level_cd)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a1_functional_acct_groups, "&a1_functional_acct_groups");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a1_collections_acct_groups, "&a1_collections_acct_groups");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a1_supp_field_names, "&a1_supp_field_names");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a1_supp_field_values, "&a1_supp_field_values");
            sPost += "&a1_test_acct_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_test_acct_ind)));
            sPost += "&a1_status_until_alt_start=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_status_until_alt_start)));
            sPost += "&a1_balance_forward=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_balance_forward)));
            sPost += "&a1_alt_bill_day=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_alt_bill_day)));
            sPost += "&a1_do_full_invoicing=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_do_full_invoicing)));
            sPost += "&a1_do_prorated_invoicing=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_do_prorated_invoicing)));
            sPost += "&a1_master_plan_alt_rate_sched_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_master_plan_alt_rate_sched_no)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a1_supp_plan_alt_rate_sched_no, "&a1_supp_plan_alt_rate_sched_no");
            sPost += "&a1_currency_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_currency_cd)));
            sPost += "&a1_cvv=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_cvv)));
            sPost += "&a1_taxpayer_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_taxpayer_id)));
            sPost += "&a1_bill_agreement_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bill_agreement_id)));
            sPost += "&a1_retroactive_start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_retroactive_start_date)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a1_coupon_codes, "&a1_coupon_codes");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a1_new_acct_custom_rates, "&a1_new_acct_custom_rates");
            sPost += "&a1_alt_msg_template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_alt_msg_template_no)));
            sPost += "&a1_seq_func_group_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_seq_func_group_no)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a1_new_acct_plan_contracts, "&a1_new_acct_plan_contracts");
            sPost += "&a1_address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_address3)));
            sPost += "&a1_bill_address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bill_address3)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a1_usage_accumulation_config, "&a1_usage_accumulation_config");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a1_enable_usage_pooling_plan_no, "&a1_enable_usage_pooling_plan_no");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a1_client_func_acct_group_ids, "&a1_client_func_acct_group_ids");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a1_client_coll_acct_group_ids, "&a1_client_coll_acct_group_ids");
            sPost += "&a1_track_data1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_track_data1)));
            sPost += "&a1_track_data2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_track_data2)));
            sPost += "&a1_tax_exemption_level=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_tax_exemption_level)));
            sPost += "&a1_cn_alt_msg_template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_cn_alt_msg_template_no)));
            sPost += "&a1_invoice_approval_required=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_invoice_approval_required)));
            sPost += "&a1_create_session=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_create_session)));
            sPost += "&a1_client_master_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_client_master_plan_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a1_client_supp_plan_ids, "&a1_client_supp_plan_ids");
            sPost += "&a1_client_mp_alt_rate_sched_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_client_mp_alt_rate_sched_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a1_client_sp_alt_rate_sched_ids, "&a1_client_sp_alt_rate_sched_ids");
            sPost += "&a1_client_alt_msg_template_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_client_alt_msg_template_id)));
            sPost += "&a1_client_cn_alt_msg_template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_client_cn_alt_msg_template_no)));
            sPost += "&a1_iban=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_iban)));
            sPost += "&a1_bank_check_digit=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bank_check_digit)));
            sPost += "&a1_bank_swift_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bank_swift_cd)));
            sPost += "&a1_bank_country_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bank_country_cd)));
            sPost += "&a1_mandate_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_mandate_id)));
            sPost += "&a1_bank_id_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bank_id_cd)));
            sPost += "&a1_bank_branch_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bank_branch_cd)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a1_surcharge_no, "&a1_surcharge_no");
            sPost += "&a1_bkup_bill_first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bkup_bill_first_name)));
            sPost += "&a1_bkup_bill_mi=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bkup_bill_mi)));
            sPost += "&a1_bkup_bill_last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bkup_bill_last_name)));
            sPost += "&a1_bkup_bill_company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bkup_bill_company_name)));
            sPost += "&a1_bkup_bill_address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bkup_bill_address1)));
            sPost += "&a1_bkup_bill_address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bkup_bill_address2)));
            sPost += "&a1_bkup_bill_address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bkup_bill_address3)));
            sPost += "&a1_bkup_bill_city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bkup_bill_city)));
            sPost += "&a1_bkup_bill_locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bkup_bill_locality)));
            sPost += "&a1_bkup_bill_state_prov=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bkup_bill_state_prov)));
            sPost += "&a1_bkup_bill_country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bkup_bill_country)));
            sPost += "&a1_bkup_bill_postal_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bkup_bill_postal_cd)));
            sPost += "&a1_bkup_bill_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bkup_bill_phone)));
            sPost += "&a1_bkup_bill_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bkup_bill_phone_ext)));
            sPost += "&a1_bkup_bill_cell_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bkup_bill_cell_phone)));
            sPost += "&a1_bkup_bill_work_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bkup_bill_work_phone)));
            sPost += "&a1_bkup_bill_work_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bkup_bill_work_phone_ext)));
            sPost += "&a1_bkup_bill_email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bkup_bill_email)));
            sPost += "&a1_bkup_pay_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bkup_pay_method)));
            sPost += "&a1_bkup_cc_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bkup_cc_number)));
            sPost += "&a1_bkup_cc_expire_mm=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bkup_cc_expire_mm)));
            sPost += "&a1_bkup_cc_expire_yyyy=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bkup_cc_expire_yyyy)));
            sPost += "&a1_bkup_bank_acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bkup_bank_acct_no)));
            sPost += "&a1_bkup_bank_routing_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bkup_bank_routing_no)));
            sPost += "&a1_bkup_bill_agreement_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bkup_bill_agreement_id)));
            sPost += "&a1_bkup_cvv=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_bkup_cvv)));
            sPost += "&a1_seq_func_group_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_seq_func_group_id)));
            sPost += "&a1_revrec_profile_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_revrec_profile_id)));
            sPost += "&a1_revrec_client_defined_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_revrec_client_defined_id)));
            sPost += "&a1_stmnt_email_list=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a1_stmnt_email_list)));
            sPost += "&a2_alt_start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_alt_start_date)));
            sPost += "&a2_client_acct_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_client_acct_id)));
            sPost += "&a2_userid=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_userid)));
            sPost += "&a2_status_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_status_cd)));
            sPost += "&a2_master_plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_master_plan_no)));
            sPost += "&a2_master_plan_units=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_master_plan_units)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a2_supp_plans, "&a2_supp_plans");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a2_supp_plan_units, "&a2_supp_plan_units");
            sPost += "&a2_notify_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_notify_method)));
            sPost += "&a2_promo_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_promo_cd)));
            sPost += "&a2_password=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_password)));
            sPost += "&a2_secret_question=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_secret_question)));
            sPost += "&a2_secret_question_answer=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_secret_question_answer)));
            sPost += "&a2_first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_first_name)));
            sPost += "&a2_mi=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_mi)));
            sPost += "&a2_last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_last_name)));
            sPost += "&a2_company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_company_name)));
            sPost += "&a2_address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_address1)));
            sPost += "&a2_address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_address2)));
            sPost += "&a2_city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_city)));
            sPost += "&a2_locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_locality)));
            sPost += "&a2_state_prov=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_state_prov)));
            sPost += "&a2_country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_country)));
            sPost += "&a2_postal_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_postal_cd)));
            sPost += "&a2_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_phone)));
            sPost += "&a2_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_phone_ext)));
            sPost += "&a2_cell_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_cell_phone)));
            sPost += "&a2_work_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_work_phone)));
            sPost += "&a2_work_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_work_phone_ext)));
            sPost += "&a2_email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_email)));
            sPost += "&a2_birthdate=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_birthdate)));
            sPost += "&a2_bill_first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bill_first_name)));
            sPost += "&a2_bill_mi=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bill_mi)));
            sPost += "&a2_bill_last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bill_last_name)));
            sPost += "&a2_bill_company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bill_company_name)));
            sPost += "&a2_bill_address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bill_address1)));
            sPost += "&a2_bill_address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bill_address2)));
            sPost += "&a2_bill_city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bill_city)));
            sPost += "&a2_bill_locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bill_locality)));
            sPost += "&a2_bill_state_prov=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bill_state_prov)));
            sPost += "&a2_bill_country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bill_country)));
            sPost += "&a2_bill_postal_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bill_postal_cd)));
            sPost += "&a2_bill_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bill_phone)));
            sPost += "&a2_bill_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bill_phone_ext)));
            sPost += "&a2_bill_cell_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bill_cell_phone)));
            sPost += "&a2_bill_work_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bill_work_phone)));
            sPost += "&a2_bill_work_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bill_work_phone_ext)));
            sPost += "&a2_bill_email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bill_email)));
            sPost += "&a2_pay_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_pay_method)));
            sPost += "&a2_cc_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_cc_number)));
            sPost += "&a2_cc_expire_mm=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_cc_expire_mm)));
            sPost += "&a2_cc_expire_yyyy=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_cc_expire_yyyy)));
            sPost += "&a2_bank_acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bank_acct_no)));
            sPost += "&a2_bank_routing_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bank_routing_no)));
            sPost += "&a2_resp_level_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_resp_level_cd)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a2_functional_acct_groups, "&a2_functional_acct_groups");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a2_collections_acct_groups, "&a2_collections_acct_groups");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a2_supp_field_names, "&a2_supp_field_names");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a2_supp_field_values, "&a2_supp_field_values");
            sPost += "&a2_test_acct_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_test_acct_ind)));
            sPost += "&a2_status_until_alt_start=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_status_until_alt_start)));
            sPost += "&a2_balance_forward=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_balance_forward)));
            sPost += "&a2_alt_bill_day=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_alt_bill_day)));
            sPost += "&a2_do_full_invoicing=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_do_full_invoicing)));
            sPost += "&a2_do_prorated_invoicing=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_do_prorated_invoicing)));
            sPost += "&a2_master_plan_alt_rate_sched_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_master_plan_alt_rate_sched_no)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a2_supp_plan_alt_rate_sched_no, "&a2_supp_plan_alt_rate_sched_no");
            sPost += "&a2_currency_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_currency_cd)));
            sPost += "&a2_cvv=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_cvv)));
            sPost += "&a2_taxpayer_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_taxpayer_id)));
            sPost += "&a2_bill_agreement_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bill_agreement_id)));
            sPost += "&a2_retroactive_start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_retroactive_start_date)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a2_coupon_codes, "&a2_coupon_codes");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a2_new_acct_custom_rates, "&a2_new_acct_custom_rates");
            sPost += "&a2_alt_msg_template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_alt_msg_template_no)));
            sPost += "&a2_seq_func_group_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_seq_func_group_no)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a2_new_acct_plan_contracts, "&a2_new_acct_plan_contracts");
            sPost += "&a2_address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_address3)));
            sPost += "&a2_bill_address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bill_address3)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a2_usage_accumulation_config, "&a2_usage_accumulation_config");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a2_enable_usage_pooling_plan_no, "&a2_enable_usage_pooling_plan_no");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a2_client_func_acct_group_ids, "&a2_client_func_acct_group_ids");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a2_client_coll_acct_group_ids, "&a2_client_coll_acct_group_ids");
            sPost += "&a2_track_data1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_track_data1)));
            sPost += "&a2_track_data2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_track_data2)));
            sPost += "&a2_tax_exemption_level=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_tax_exemption_level)));
            sPost += "&a2_cn_alt_msg_template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_cn_alt_msg_template_no)));
            sPost += "&a2_invoice_approval_required=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_invoice_approval_required)));
            sPost += "&a2_create_session=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_create_session)));
            sPost += "&a2_client_master_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_client_master_plan_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a2_client_supp_plan_ids, "&a2_client_supp_plan_ids");
            sPost += "&a2_client_mp_alt_rate_sched_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_client_mp_alt_rate_sched_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a2_client_sp_alt_rate_sched_ids, "&a2_client_sp_alt_rate_sched_ids");
            sPost += "&a2_client_alt_msg_template_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_client_alt_msg_template_id)));
            sPost += "&a2_client_cn_alt_msg_template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_client_cn_alt_msg_template_no)));
            sPost += "&a2_iban=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_iban)));
            sPost += "&a2_bank_check_digit=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bank_check_digit)));
            sPost += "&a2_bank_swift_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bank_swift_cd)));
            sPost += "&a2_bank_country_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bank_country_cd)));
            sPost += "&a2_mandate_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_mandate_id)));
            sPost += "&a2_bank_id_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bank_id_cd)));
            sPost += "&a2_bank_branch_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bank_branch_cd)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a2_surcharge_no, "&a2_surcharge_no");
            sPost += "&a2_bkup_bill_first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bkup_bill_first_name)));
            sPost += "&a2_bkup_bill_mi=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bkup_bill_mi)));
            sPost += "&a2_bkup_bill_last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bkup_bill_last_name)));
            sPost += "&a2_bkup_bill_company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bkup_bill_company_name)));
            sPost += "&a2_bkup_bill_address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bkup_bill_address1)));
            sPost += "&a2_bkup_bill_address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bkup_bill_address2)));
            sPost += "&a2_bkup_bill_address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bkup_bill_address3)));
            sPost += "&a2_bkup_bill_city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bkup_bill_city)));
            sPost += "&a2_bkup_bill_locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bkup_bill_locality)));
            sPost += "&a2_bkup_bill_state_prov=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bkup_bill_state_prov)));
            sPost += "&a2_bkup_bill_country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bkup_bill_country)));
            sPost += "&a2_bkup_bill_postal_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bkup_bill_postal_cd)));
            sPost += "&a2_bkup_bill_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bkup_bill_phone)));
            sPost += "&a2_bkup_bill_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bkup_bill_phone_ext)));
            sPost += "&a2_bkup_bill_cell_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bkup_bill_cell_phone)));
            sPost += "&a2_bkup_bill_work_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bkup_bill_work_phone)));
            sPost += "&a2_bkup_bill_work_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bkup_bill_work_phone_ext)));
            sPost += "&a2_bkup_bill_email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bkup_bill_email)));
            sPost += "&a2_bkup_pay_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bkup_pay_method)));
            sPost += "&a2_bkup_cc_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bkup_cc_number)));
            sPost += "&a2_bkup_cc_expire_mm=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bkup_cc_expire_mm)));
            sPost += "&a2_bkup_cc_expire_yyyy=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bkup_cc_expire_yyyy)));
            sPost += "&a2_bkup_bank_acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bkup_bank_acct_no)));
            sPost += "&a2_bkup_bank_routing_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bkup_bank_routing_no)));
            sPost += "&a2_bkup_bill_agreement_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bkup_bill_agreement_id)));
            sPost += "&a2_bkup_cvv=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_bkup_cvv)));
            sPost += "&a2_seq_func_group_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_seq_func_group_id)));
            sPost += "&a2_revrec_profile_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_revrec_profile_id)));
            sPost += "&a2_revrec_client_defined_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_revrec_client_defined_id)));
            sPost += "&a2_stmnt_email_list=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a2_stmnt_email_list)));
            sPost += "&a3_alt_start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_alt_start_date)));
            sPost += "&a3_client_acct_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_client_acct_id)));
            sPost += "&a3_userid=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_userid)));
            sPost += "&a3_status_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_status_cd)));
            sPost += "&a3_master_plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_master_plan_no)));
            sPost += "&a3_master_plan_units=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_master_plan_units)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a3_supp_plans, "&a3_supp_plans");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a3_supp_plan_units, "&a3_supp_plan_units");
            sPost += "&a3_notify_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_notify_method)));
            sPost += "&a3_promo_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_promo_cd)));
            sPost += "&a3_password=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_password)));
            sPost += "&a3_secret_question=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_secret_question)));
            sPost += "&a3_secret_question_answer=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_secret_question_answer)));
            sPost += "&a3_first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_first_name)));
            sPost += "&a3_mi=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_mi)));
            sPost += "&a3_last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_last_name)));
            sPost += "&a3_company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_company_name)));
            sPost += "&a3_address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_address1)));
            sPost += "&a3_address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_address2)));
            sPost += "&a3_city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_city)));
            sPost += "&a3_locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_locality)));
            sPost += "&a3_state_prov=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_state_prov)));
            sPost += "&a3_country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_country)));
            sPost += "&a3_postal_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_postal_cd)));
            sPost += "&a3_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_phone)));
            sPost += "&a3_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_phone_ext)));
            sPost += "&a3_cell_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_cell_phone)));
            sPost += "&a3_work_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_work_phone)));
            sPost += "&a3_work_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_work_phone_ext)));
            sPost += "&a3_email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_email)));
            sPost += "&a3_birthdate=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_birthdate)));
            sPost += "&a3_bill_first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bill_first_name)));
            sPost += "&a3_bill_mi=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bill_mi)));
            sPost += "&a3_bill_last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bill_last_name)));
            sPost += "&a3_bill_company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bill_company_name)));
            sPost += "&a3_bill_address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bill_address1)));
            sPost += "&a3_bill_address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bill_address2)));
            sPost += "&a3_bill_city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bill_city)));
            sPost += "&a3_bill_locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bill_locality)));
            sPost += "&a3_bill_state_prov=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bill_state_prov)));
            sPost += "&a3_bill_country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bill_country)));
            sPost += "&a3_bill_postal_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bill_postal_cd)));
            sPost += "&a3_bill_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bill_phone)));
            sPost += "&a3_bill_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bill_phone_ext)));
            sPost += "&a3_bill_cell_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bill_cell_phone)));
            sPost += "&a3_bill_work_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bill_work_phone)));
            sPost += "&a3_bill_work_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bill_work_phone_ext)));
            sPost += "&a3_bill_email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bill_email)));
            sPost += "&a3_pay_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_pay_method)));
            sPost += "&a3_cc_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_cc_number)));
            sPost += "&a3_cc_expire_mm=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_cc_expire_mm)));
            sPost += "&a3_cc_expire_yyyy=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_cc_expire_yyyy)));
            sPost += "&a3_bank_acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bank_acct_no)));
            sPost += "&a3_bank_routing_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bank_routing_no)));
            sPost += "&a3_resp_level_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_resp_level_cd)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a3_functional_acct_groups, "&a3_functional_acct_groups");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a3_collections_acct_groups, "&a3_collections_acct_groups");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a3_supp_field_names, "&a3_supp_field_names");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a3_supp_field_values, "&a3_supp_field_values");
            sPost += "&a3_test_acct_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_test_acct_ind)));
            sPost += "&a3_status_until_alt_start=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_status_until_alt_start)));
            sPost += "&a3_balance_forward=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_balance_forward)));
            sPost += "&a3_alt_bill_day=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_alt_bill_day)));
            sPost += "&a3_do_full_invoicing=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_do_full_invoicing)));
            sPost += "&a3_do_prorated_invoicing=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_do_prorated_invoicing)));
            sPost += "&a3_master_plan_alt_rate_sched_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_master_plan_alt_rate_sched_no)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a3_supp_plan_alt_rate_sched_no, "&a3_supp_plan_alt_rate_sched_no");
            sPost += "&a3_currency_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_currency_cd)));
            sPost += "&a3_cvv=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_cvv)));
            sPost += "&a3_taxpayer_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_taxpayer_id)));
            sPost += "&a3_bill_agreement_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bill_agreement_id)));
            sPost += "&a3_retroactive_start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_retroactive_start_date)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a3_coupon_codes, "&a3_coupon_codes");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a3_new_acct_custom_rates, "&a3_new_acct_custom_rates");
            sPost += "&a3_alt_msg_template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_alt_msg_template_no)));
            sPost += "&a3_seq_func_group_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_seq_func_group_no)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a3_new_acct_plan_contracts, "&a3_new_acct_plan_contracts");
            sPost += "&a3_address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_address3)));
            sPost += "&a3_bill_address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bill_address3)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a3_usage_accumulation_config, "&a3_usage_accumulation_config");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a3_enable_usage_pooling_plan_no, "&a3_enable_usage_pooling_plan_no");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a3_client_func_acct_group_ids, "&a3_client_func_acct_group_ids");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a3_client_coll_acct_group_ids, "&a3_client_coll_acct_group_ids");
            sPost += "&a3_track_data1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_track_data1)));
            sPost += "&a3_track_data2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_track_data2)));
            sPost += "&a3_tax_exemption_level=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_tax_exemption_level)));
            sPost += "&a3_cn_alt_msg_template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_cn_alt_msg_template_no)));
            sPost += "&a3_invoice_approval_required=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_invoice_approval_required)));
            sPost += "&a3_create_session=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_create_session)));
            sPost += "&a3_client_master_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_client_master_plan_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a3_client_supp_plan_ids, "&a3_client_supp_plan_ids");
            sPost += "&a3_client_mp_alt_rate_sched_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_client_mp_alt_rate_sched_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a3_client_sp_alt_rate_sched_ids, "&a3_client_sp_alt_rate_sched_ids");
            sPost += "&a3_client_alt_msg_template_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_client_alt_msg_template_id)));
            sPost += "&a3_client_cn_alt_msg_template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_client_cn_alt_msg_template_no)));
            sPost += "&a3_iban=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_iban)));
            sPost += "&a3_bank_check_digit=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bank_check_digit)));
            sPost += "&a3_bank_swift_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bank_swift_cd)));
            sPost += "&a3_bank_country_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bank_country_cd)));
            sPost += "&a3_mandate_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_mandate_id)));
            sPost += "&a3_bank_id_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bank_id_cd)));
            sPost += "&a3_bank_branch_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bank_branch_cd)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a3_surcharge_no, "&a3_surcharge_no");
            sPost += "&a3_bkup_bill_first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bkup_bill_first_name)));
            sPost += "&a3_bkup_bill_mi=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bkup_bill_mi)));
            sPost += "&a3_bkup_bill_last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bkup_bill_last_name)));
            sPost += "&a3_bkup_bill_company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bkup_bill_company_name)));
            sPost += "&a3_bkup_bill_address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bkup_bill_address1)));
            sPost += "&a3_bkup_bill_address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bkup_bill_address2)));
            sPost += "&a3_bkup_bill_address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bkup_bill_address3)));
            sPost += "&a3_bkup_bill_city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bkup_bill_city)));
            sPost += "&a3_bkup_bill_locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bkup_bill_locality)));
            sPost += "&a3_bkup_bill_state_prov=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bkup_bill_state_prov)));
            sPost += "&a3_bkup_bill_country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bkup_bill_country)));
            sPost += "&a3_bkup_bill_postal_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bkup_bill_postal_cd)));
            sPost += "&a3_bkup_bill_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bkup_bill_phone)));
            sPost += "&a3_bkup_bill_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bkup_bill_phone_ext)));
            sPost += "&a3_bkup_bill_cell_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bkup_bill_cell_phone)));
            sPost += "&a3_bkup_bill_work_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bkup_bill_work_phone)));
            sPost += "&a3_bkup_bill_work_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bkup_bill_work_phone_ext)));
            sPost += "&a3_bkup_bill_email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bkup_bill_email)));
            sPost += "&a3_bkup_pay_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bkup_pay_method)));
            sPost += "&a3_bkup_cc_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bkup_cc_number)));
            sPost += "&a3_bkup_cc_expire_mm=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bkup_cc_expire_mm)));
            sPost += "&a3_bkup_cc_expire_yyyy=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bkup_cc_expire_yyyy)));
            sPost += "&a3_bkup_bank_acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bkup_bank_acct_no)));
            sPost += "&a3_bkup_bank_routing_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bkup_bank_routing_no)));
            sPost += "&a3_bkup_bill_agreement_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bkup_bill_agreement_id)));
            sPost += "&a3_bkup_cvv=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_bkup_cvv)));
            sPost += "&a3_seq_func_group_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_seq_func_group_id)));
            sPost += "&a3_revrec_profile_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_revrec_profile_id)));
            sPost += "&a3_revrec_client_defined_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_revrec_client_defined_id)));
            sPost += "&a3_stmnt_email_list=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a3_stmnt_email_list)));
            sPost += "&a4_alt_start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_alt_start_date)));
            sPost += "&a4_client_acct_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_client_acct_id)));
            sPost += "&a4_userid=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_userid)));
            sPost += "&a4_status_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_status_cd)));
            sPost += "&a4_master_plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_master_plan_no)));
            sPost += "&a4_master_plan_units=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_master_plan_units)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a4_supp_plans, "&a4_supp_plans");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a4_supp_plan_units, "&a4_supp_plan_units");
            sPost += "&a4_notify_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_notify_method)));
            sPost += "&a4_promo_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_promo_cd)));
            sPost += "&a4_password=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_password)));
            sPost += "&a4_secret_question=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_secret_question)));
            sPost += "&a4_secret_question_answer=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_secret_question_answer)));
            sPost += "&a4_first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_first_name)));
            sPost += "&a4_mi=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_mi)));
            sPost += "&a4_last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_last_name)));
            sPost += "&a4_company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_company_name)));
            sPost += "&a4_address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_address1)));
            sPost += "&a4_address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_address2)));
            sPost += "&a4_city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_city)));
            sPost += "&a4_locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_locality)));
            sPost += "&a4_state_prov=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_state_prov)));
            sPost += "&a4_country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_country)));
            sPost += "&a4_postal_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_postal_cd)));
            sPost += "&a4_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_phone)));
            sPost += "&a4_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_phone_ext)));
            sPost += "&a4_cell_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_cell_phone)));
            sPost += "&a4_work_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_work_phone)));
            sPost += "&a4_work_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_work_phone_ext)));
            sPost += "&a4_email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_email)));
            sPost += "&a4_birthdate=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_birthdate)));
            sPost += "&a4_bill_first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bill_first_name)));
            sPost += "&a4_bill_mi=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bill_mi)));
            sPost += "&a4_bill_last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bill_last_name)));
            sPost += "&a4_bill_company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bill_company_name)));
            sPost += "&a4_bill_address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bill_address1)));
            sPost += "&a4_bill_address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bill_address2)));
            sPost += "&a4_bill_city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bill_city)));
            sPost += "&a4_bill_locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bill_locality)));
            sPost += "&a4_bill_state_prov=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bill_state_prov)));
            sPost += "&a4_bill_country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bill_country)));
            sPost += "&a4_bill_postal_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bill_postal_cd)));
            sPost += "&a4_bill_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bill_phone)));
            sPost += "&a4_bill_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bill_phone_ext)));
            sPost += "&a4_bill_cell_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bill_cell_phone)));
            sPost += "&a4_bill_work_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bill_work_phone)));
            sPost += "&a4_bill_work_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bill_work_phone_ext)));
            sPost += "&a4_bill_email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bill_email)));
            sPost += "&a4_pay_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_pay_method)));
            sPost += "&a4_cc_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_cc_number)));
            sPost += "&a4_cc_expire_mm=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_cc_expire_mm)));
            sPost += "&a4_cc_expire_yyyy=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_cc_expire_yyyy)));
            sPost += "&a4_bank_acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bank_acct_no)));
            sPost += "&a4_bank_routing_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bank_routing_no)));
            sPost += "&a4_resp_level_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_resp_level_cd)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a4_functional_acct_groups, "&a4_functional_acct_groups");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a4_collections_acct_groups, "&a4_collections_acct_groups");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a4_supp_field_names, "&a4_supp_field_names");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a4_supp_field_values, "&a4_supp_field_values");
            sPost += "&a4_test_acct_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_test_acct_ind)));
            sPost += "&a4_status_until_alt_start=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_status_until_alt_start)));
            sPost += "&a4_balance_forward=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_balance_forward)));
            sPost += "&a4_alt_bill_day=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_alt_bill_day)));
            sPost += "&a4_do_full_invoicing=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_do_full_invoicing)));
            sPost += "&a4_do_prorated_invoicing=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_do_prorated_invoicing)));
            sPost += "&a4_master_plan_alt_rate_sched_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_master_plan_alt_rate_sched_no)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a4_supp_plan_alt_rate_sched_no, "&a4_supp_plan_alt_rate_sched_no");
            sPost += "&a4_currency_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_currency_cd)));
            sPost += "&a4_cvv=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_cvv)));
            sPost += "&a4_taxpayer_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_taxpayer_id)));
            sPost += "&a4_bill_agreement_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bill_agreement_id)));
            sPost += "&a4_retroactive_start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_retroactive_start_date)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a4_coupon_codes, "&a4_coupon_codes");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a4_new_acct_custom_rates, "&a4_new_acct_custom_rates");
            sPost += "&a4_alt_msg_template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_alt_msg_template_no)));
            sPost += "&a4_seq_func_group_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_seq_func_group_no)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a4_new_acct_plan_contracts, "&a4_new_acct_plan_contracts");
            sPost += "&a4_address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_address3)));
            sPost += "&a4_bill_address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bill_address3)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a4_usage_accumulation_config, "&a4_usage_accumulation_config");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a4_enable_usage_pooling_plan_no, "&a4_enable_usage_pooling_plan_no");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a4_client_func_acct_group_ids, "&a4_client_func_acct_group_ids");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a4_client_coll_acct_group_ids, "&a4_client_coll_acct_group_ids");
            sPost += "&a4_track_data1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_track_data1)));
            sPost += "&a4_track_data2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_track_data2)));
            sPost += "&a4_tax_exemption_level=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_tax_exemption_level)));
            sPost += "&a4_cn_alt_msg_template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_cn_alt_msg_template_no)));
            sPost += "&a4_invoice_approval_required=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_invoice_approval_required)));
            sPost += "&a4_create_session=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_create_session)));
            sPost += "&a4_client_master_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_client_master_plan_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a4_client_supp_plan_ids, "&a4_client_supp_plan_ids");
            sPost += "&a4_client_mp_alt_rate_sched_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_client_mp_alt_rate_sched_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a4_client_sp_alt_rate_sched_ids, "&a4_client_sp_alt_rate_sched_ids");
            sPost += "&a4_client_alt_msg_template_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_client_alt_msg_template_id)));
            sPost += "&a4_client_cn_alt_msg_template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_client_cn_alt_msg_template_no)));
            sPost += "&a4_iban=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_iban)));
            sPost += "&a4_bank_check_digit=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bank_check_digit)));
            sPost += "&a4_bank_swift_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bank_swift_cd)));
            sPost += "&a4_bank_country_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bank_country_cd)));
            sPost += "&a4_mandate_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_mandate_id)));
            sPost += "&a4_bank_id_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bank_id_cd)));
            sPost += "&a4_bank_branch_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bank_branch_cd)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a4_surcharge_no, "&a4_surcharge_no");
            sPost += "&a4_bkup_bill_first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bkup_bill_first_name)));
            sPost += "&a4_bkup_bill_mi=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bkup_bill_mi)));
            sPost += "&a4_bkup_bill_last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bkup_bill_last_name)));
            sPost += "&a4_bkup_bill_company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bkup_bill_company_name)));
            sPost += "&a4_bkup_bill_address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bkup_bill_address1)));
            sPost += "&a4_bkup_bill_address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bkup_bill_address2)));
            sPost += "&a4_bkup_bill_address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bkup_bill_address3)));
            sPost += "&a4_bkup_bill_city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bkup_bill_city)));
            sPost += "&a4_bkup_bill_locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bkup_bill_locality)));
            sPost += "&a4_bkup_bill_state_prov=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bkup_bill_state_prov)));
            sPost += "&a4_bkup_bill_country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bkup_bill_country)));
            sPost += "&a4_bkup_bill_postal_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bkup_bill_postal_cd)));
            sPost += "&a4_bkup_bill_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bkup_bill_phone)));
            sPost += "&a4_bkup_bill_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bkup_bill_phone_ext)));
            sPost += "&a4_bkup_bill_cell_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bkup_bill_cell_phone)));
            sPost += "&a4_bkup_bill_work_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bkup_bill_work_phone)));
            sPost += "&a4_bkup_bill_work_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bkup_bill_work_phone_ext)));
            sPost += "&a4_bkup_bill_email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bkup_bill_email)));
            sPost += "&a4_bkup_pay_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bkup_pay_method)));
            sPost += "&a4_bkup_cc_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bkup_cc_number)));
            sPost += "&a4_bkup_cc_expire_mm=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bkup_cc_expire_mm)));
            sPost += "&a4_bkup_cc_expire_yyyy=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bkup_cc_expire_yyyy)));
            sPost += "&a4_bkup_bank_acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bkup_bank_acct_no)));
            sPost += "&a4_bkup_bank_routing_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bkup_bank_routing_no)));
            sPost += "&a4_bkup_bill_agreement_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bkup_bill_agreement_id)));
            sPost += "&a4_bkup_cvv=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_bkup_cvv)));
            sPost += "&a4_seq_func_group_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_seq_func_group_id)));
            sPost += "&a4_revrec_profile_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_revrec_profile_id)));
            sPost += "&a4_revrec_client_defined_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_revrec_client_defined_id)));
            sPost += "&a4_stmnt_email_list=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a4_stmnt_email_list)));
            sPost += "&a5_alt_start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_alt_start_date)));
            sPost += "&a5_client_acct_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_client_acct_id)));
            sPost += "&a5_userid=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_userid)));
            sPost += "&a5_status_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_status_cd)));
            sPost += "&a5_master_plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_master_plan_no)));
            sPost += "&a5_master_plan_units=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_master_plan_units)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a5_supp_plans, "&a5_supp_plans");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a5_supp_plan_units, "&a5_supp_plan_units");
            sPost += "&a5_notify_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_notify_method)));
            sPost += "&a5_promo_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_promo_cd)));
            sPost += "&a5_password=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_password)));
            sPost += "&a5_secret_question=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_secret_question)));
            sPost += "&a5_secret_question_answer=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_secret_question_answer)));
            sPost += "&a5_first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_first_name)));
            sPost += "&a5_mi=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_mi)));
            sPost += "&a5_last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_last_name)));
            sPost += "&a5_company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_company_name)));
            sPost += "&a5_address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_address1)));
            sPost += "&a5_address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_address2)));
            sPost += "&a5_city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_city)));
            sPost += "&a5_locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_locality)));
            sPost += "&a5_state_prov=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_state_prov)));
            sPost += "&a5_country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_country)));
            sPost += "&a5_postal_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_postal_cd)));
            sPost += "&a5_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_phone)));
            sPost += "&a5_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_phone_ext)));
            sPost += "&a5_cell_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_cell_phone)));
            sPost += "&a5_work_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_work_phone)));
            sPost += "&a5_work_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_work_phone_ext)));
            sPost += "&a5_email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_email)));
            sPost += "&a5_birthdate=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_birthdate)));
            sPost += "&a5_bill_first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bill_first_name)));
            sPost += "&a5_bill_mi=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bill_mi)));
            sPost += "&a5_bill_last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bill_last_name)));
            sPost += "&a5_bill_company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bill_company_name)));
            sPost += "&a5_bill_address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bill_address1)));
            sPost += "&a5_bill_address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bill_address2)));
            sPost += "&a5_bill_city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bill_city)));
            sPost += "&a5_bill_locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bill_locality)));
            sPost += "&a5_bill_state_prov=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bill_state_prov)));
            sPost += "&a5_bill_country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bill_country)));
            sPost += "&a5_bill_postal_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bill_postal_cd)));
            sPost += "&a5_bill_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bill_phone)));
            sPost += "&a5_bill_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bill_phone_ext)));
            sPost += "&a5_bill_cell_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bill_cell_phone)));
            sPost += "&a5_bill_work_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bill_work_phone)));
            sPost += "&a5_bill_work_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bill_work_phone_ext)));
            sPost += "&a5_bill_email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bill_email)));
            sPost += "&a5_pay_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_pay_method)));
            sPost += "&a5_cc_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_cc_number)));
            sPost += "&a5_cc_expire_mm=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_cc_expire_mm)));
            sPost += "&a5_cc_expire_yyyy=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_cc_expire_yyyy)));
            sPost += "&a5_bank_acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bank_acct_no)));
            sPost += "&a5_bank_routing_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bank_routing_no)));
            sPost += "&a5_resp_level_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_resp_level_cd)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a5_functional_acct_groups, "&a5_functional_acct_groups");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a5_collections_acct_groups, "&a5_collections_acct_groups");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a5_supp_field_names, "&a5_supp_field_names");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a5_supp_field_values, "&a5_supp_field_values");
            sPost += "&a5_test_acct_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_test_acct_ind)));
            sPost += "&a5_status_until_alt_start=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_status_until_alt_start)));
            sPost += "&a5_balance_forward=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_balance_forward)));
            sPost += "&a5_alt_bill_day=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_alt_bill_day)));
            sPost += "&a5_do_full_invoicing=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_do_full_invoicing)));
            sPost += "&a5_do_prorated_invoicing=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_do_prorated_invoicing)));
            sPost += "&a5_master_plan_alt_rate_sched_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_master_plan_alt_rate_sched_no)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a5_supp_plan_alt_rate_sched_no, "&a5_supp_plan_alt_rate_sched_no");
            sPost += "&a5_currency_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_currency_cd)));
            sPost += "&a5_cvv=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_cvv)));
            sPost += "&a5_taxpayer_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_taxpayer_id)));
            sPost += "&a5_bill_agreement_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bill_agreement_id)));
            sPost += "&a5_retroactive_start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_retroactive_start_date)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a5_coupon_codes, "&a5_coupon_codes");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a5_new_acct_custom_rates, "&a5_new_acct_custom_rates");
            sPost += "&a5_alt_msg_template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_alt_msg_template_no)));
            sPost += "&a5_seq_func_group_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_seq_func_group_no)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a5_new_acct_plan_contracts, "&a5_new_acct_plan_contracts");
            sPost += "&a5_address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_address3)));
            sPost += "&a5_bill_address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bill_address3)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a5_usage_accumulation_config, "&a5_usage_accumulation_config");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a5_enable_usage_pooling_plan_no, "&a5_enable_usage_pooling_plan_no");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a5_client_func_acct_group_ids, "&a5_client_func_acct_group_ids");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a5_client_coll_acct_group_ids, "&a5_client_coll_acct_group_ids");
            sPost += "&a5_track_data1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_track_data1)));
            sPost += "&a5_track_data2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_track_data2)));
            sPost += "&a5_tax_exemption_level=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_tax_exemption_level)));
            sPost += "&a5_cn_alt_msg_template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_cn_alt_msg_template_no)));
            sPost += "&a5_invoice_approval_required=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_invoice_approval_required)));
            sPost += "&a5_create_session=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_create_session)));
            sPost += "&a5_client_master_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_client_master_plan_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a5_client_supp_plan_ids, "&a5_client_supp_plan_ids");
            sPost += "&a5_client_mp_alt_rate_sched_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_client_mp_alt_rate_sched_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a5_client_sp_alt_rate_sched_ids, "&a5_client_sp_alt_rate_sched_ids");
            sPost += "&a5_client_alt_msg_template_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_client_alt_msg_template_id)));
            sPost += "&a5_client_cn_alt_msg_template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_client_cn_alt_msg_template_no)));
            sPost += "&a5_iban=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_iban)));
            sPost += "&a5_bank_check_digit=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bank_check_digit)));
            sPost += "&a5_bank_swift_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bank_swift_cd)));
            sPost += "&a5_bank_country_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bank_country_cd)));
            sPost += "&a5_mandate_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_mandate_id)));
            sPost += "&a5_bank_id_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bank_id_cd)));
            sPost += "&a5_bank_branch_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bank_branch_cd)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.a5_surcharge_no, "&a5_surcharge_no");
            sPost += "&a5_bkup_bill_first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bkup_bill_first_name)));
            sPost += "&a5_bkup_bill_mi=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bkup_bill_mi)));
            sPost += "&a5_bkup_bill_last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bkup_bill_last_name)));
            sPost += "&a5_bkup_bill_company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bkup_bill_company_name)));
            sPost += "&a5_bkup_bill_address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bkup_bill_address1)));
            sPost += "&a5_bkup_bill_address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bkup_bill_address2)));
            sPost += "&a5_bkup_bill_address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bkup_bill_address3)));
            sPost += "&a5_bkup_bill_city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bkup_bill_city)));
            sPost += "&a5_bkup_bill_locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bkup_bill_locality)));
            sPost += "&a5_bkup_bill_state_prov=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bkup_bill_state_prov)));
            sPost += "&a5_bkup_bill_country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bkup_bill_country)));
            sPost += "&a5_bkup_bill_postal_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bkup_bill_postal_cd)));
            sPost += "&a5_bkup_bill_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bkup_bill_phone)));
            sPost += "&a5_bkup_bill_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bkup_bill_phone_ext)));
            sPost += "&a5_bkup_bill_cell_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bkup_bill_cell_phone)));
            sPost += "&a5_bkup_bill_work_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bkup_bill_work_phone)));
            sPost += "&a5_bkup_bill_work_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bkup_bill_work_phone_ext)));
            sPost += "&a5_bkup_bill_email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bkup_bill_email)));
            sPost += "&a5_bkup_pay_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bkup_pay_method)));
            sPost += "&a5_bkup_cc_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bkup_cc_number)));
            sPost += "&a5_bkup_cc_expire_mm=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bkup_cc_expire_mm)));
            sPost += "&a5_bkup_cc_expire_yyyy=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bkup_cc_expire_yyyy)));
            sPost += "&a5_bkup_bank_acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bkup_bank_acct_no)));
            sPost += "&a5_bkup_bank_routing_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bkup_bank_routing_no)));
            sPost += "&a5_bkup_bill_agreement_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bkup_bill_agreement_id)));
            sPost += "&a5_bkup_cvv=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_bkup_cvv)));
            sPost += "&a5_seq_func_group_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_seq_func_group_id)));
            sPost += "&a5_revrec_profile_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_revrec_profile_id)));
            sPost += "&a5_revrec_client_defined_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_revrec_client_defined_id)));
            sPost += "&a5_stmnt_email_list=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.a5_stmnt_email_list)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&coupon_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.coupon_code)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&amount=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.amount)));
            sPost += "&reason_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.reason_code)));
            sPost += "&comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.comments)));
            sPost += "&eligible_plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.eligible_plan_no)));
            sPost += "&eligible_service_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.eligible_service_no)));
            sPost += "&alt_service_no_to_apply=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_service_no_to_apply)));
            sPost += "&frequency_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.frequency_no)));
            sPost += "&frequency_interval_months=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.frequency_interval_months)));
            sPost += "&initial_credit_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.initial_credit_date)));
            sPost += "&percent_amount=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.percent_amount)));
            sPost += "&percent_eval_plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.percent_eval_plan_no)));
            sPost += "&percent_eval_service_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.percent_eval_service_no)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.eligible_service_types, "&eligible_service_types");
            sPost += "&client_eligible_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_eligible_plan_id)));
            sPost += "&client_eligible_service_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_eligible_service_id)));
            sPost += "&client_alt_service_id_to_apply=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_alt_service_id_to_apply)));
            sPost += "&client_percent_eval_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_percent_eval_plan_id)));
            sPost += "&client_percent_eval_service_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_percent_eval_service_id)));
            sPost += "&credit_expiry_type_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.credit_expiry_type_ind)));
            sPost += "&credit_expiry_months=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.credit_expiry_months)));
            sPost += "&credit_expiry_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.credit_expiry_date)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.eligible_service_plans, "&eligible_service_plans");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.client_eligible_service_plan_ids, "&client_eligible_service_plan_ids");
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&user_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.user_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.plan_no)));
            sPost += "&client_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_plan_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.plan_no)));
            sPost += "&type_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.type_no)));
            sPost += "&alt_recur_fee=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_recur_fee)));
            sPost += "&length_months=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.length_months)));
            sPost += "&cancel_fee=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cancel_fee)));
            sPost += "&create_comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.create_comments)));
            sPost += "&start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.start_date)));
            sPost += "&do_auto_discard=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_auto_discard)));
            sPost += "&end_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.end_date)));
            sPost += "&client_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_plan_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&contract_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.contract_no)));
            sPost += "&type_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.type_no)));
            sPost += "&alt_recur_fee=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_recur_fee)));
            sPost += "&length_months=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.length_months)));
            sPost += "&cancel_fee=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cancel_fee)));
            sPost += "&start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.start_date)));
            sPost += "&update_comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.update_comments)));
            sPost += "&end_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.end_date)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&contract_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.contract_no)));
            sPost += "&update_comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.update_comments)));
            sPost += "&close_status=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.close_status)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&specified_usage_type_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.specified_usage_type_no)));
            sPost += "&date_range_start=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.date_range_start)));
            sPost += "&date_range_end=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.date_range_end)));
            sPost += "&specified_usage_type_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.specified_usage_type_code)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.usage_qualifier_1, "&usage_qualifier_1");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.usage_qualifier_2, "&usage_qualifier_2");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.usage_qualifier_3, "&usage_qualifier_3");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.usage_qualifier_4, "&usage_qualifier_4");
            sPost += "&limit=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.limit)));
            sPost += "&offset=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.offset)));
            sPost += "&transaction_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.transaction_id)));
            sPost += "&invoice_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.invoice_no)));
            sPost += "&invoice_line_item=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.invoice_line_item)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&message_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.message_id)));
            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&do_encoding=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_encoding)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&message_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.message_id)));
            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&do_encoding=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_encoding)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&master_plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.master_plan_no)));
            sPost += "&alt_rate_schedule_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_rate_schedule_no)));
            sPost += "&num_plan_units=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.num_plan_units)));
            sPost += "&assignment_directive=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.assignment_directive)));
            sPost += "&do_write=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_write)));
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            sPost += "&force_currency_change=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.force_currency_change)));
            sPost += "&auto_cancel_supp_plans=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auto_cancel_supp_plans)));
            sPost += "&offset_months=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.offset_months)));
            sPost += "&alt_proration_start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_proration_start_date)));
            sPost += "&alt_client_acct_group_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_client_acct_group_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.new_acct_custom_rates, "&new_acct_custom_rates");
            sPost += "&effective_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.effective_date)));
            sPost += "&offset_interval=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.offset_interval)));
            sPost += "&invoice_unbilled_usage=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.invoice_unbilled_usage)));
            sPost += "&coupon_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.coupon_code)));
            sPost += "&client_master_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_master_plan_id)));
            sPost += "&client_alt_rate_schedule_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_alt_rate_schedule_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.surcharge_no, "&surcharge_no");
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.first_name)));
            sPost += "&last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.last_name)));
            sPost += "&middle_initial=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.middle_initial)));
            sPost += "&company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.company_name)));
            sPost += "&address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.address1)));
            sPost += "&address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.address2)));
            sPost += "&city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.city)));
            sPost += "&locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.locality)));
            sPost += "&state_prov=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.state_prov)));
            sPost += "&country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.country)));
            sPost += "&postal_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.postal_cd)));
            sPost += "&phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.phone)));
            sPost += "&phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.phone_ext)));
            sPost += "&cell_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cell_phone)));
            sPost += "&work_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.work_phone)));
            sPost += "&work_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.work_phone_ext)));
            sPost += "&email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.email)));
            sPost += "&birthdate=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.birthdate)));
            sPost += "&bill_first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_first_name)));
            sPost += "&bill_last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_last_name)));
            sPost += "&bill_middle_initial=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_middle_initial)));
            sPost += "&bill_company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_company_name)));
            sPost += "&bill_address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_address1)));
            sPost += "&bill_address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_address2)));
            sPost += "&bill_city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_city)));
            sPost += "&bill_locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_locality)));
            sPost += "&bill_state_prov=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_state_prov)));
            sPost += "&bill_country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_country)));
            sPost += "&bill_postal_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_postal_cd)));
            sPost += "&bill_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_phone)));
            sPost += "&bill_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_phone_ext)));
            sPost += "&bill_cell_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_cell_phone)));
            sPost += "&bill_work_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_work_phone)));
            sPost += "&bill_work_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_work_phone_ext)));
            sPost += "&bill_email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_email)));
            sPost += "&pay_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.pay_method)));
            sPost += "&cc_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_number)));
            sPost += "&cc_expire_mm=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_expire_mm)));
            sPost += "&cc_expire_yyyy=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_expire_yyyy)));
            sPost += "&bank_routing_num=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_routing_num)));
            sPost += "&bank_acct_num=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_acct_num)));
            sPost += "&master_plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.master_plan_no)));
            sPost += "&master_plan_alt_rate_sched_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.master_plan_alt_rate_sched_no)));
            sPost += "&master_plan_units=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.master_plan_units)));
            sPost += "&master_plan_assign_directive=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.master_plan_assign_directive)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.update_acct_supp_field, "&update_acct_supp_field");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.update_acct_func_group, "&update_acct_func_group");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.update_acct_coll_group, "&update_acct_coll_group");
            sPost += "&status_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.status_cd)));
            sPost += "&notify_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.notify_method)));
            sPost += "&password=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.password)));
            sPost += "&secret_question=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.secret_question)));
            sPost += "&secret_question_answer=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.secret_question_answer)));
            sPost += "&pin=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.pin)));
            sPost += "&test_acct_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.test_acct_ind)));
            sPost += "&resp_level_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.resp_level_cd)));
            sPost += "&senior_acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.senior_acct_no)));
            sPost += "&senior_acct_user_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.senior_acct_user_id)));
            sPost += "&client_senior_acct_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_senior_acct_id)));
            sPost += "&client_acct_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_acct_id)));
            sPost += "&do_collect=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_collect)));
            sPost += "&change_status_after_coll=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.change_status_after_coll)));
            sPost += "&reset_dates_after_status=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.reset_dates_after_status)));
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            sPost += "&alt_do_dunning=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_do_dunning)));
            sPost += "&force_currency_change=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.force_currency_change)));
            sPost += "&cvv=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cvv)));
            sPost += "&taxpayer_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.taxpayer_id)));
            sPost += "&bill_agreement_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_agreement_id)));
            sPost += "&auto_cancel_supp_plans=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auto_cancel_supp_plans)));
            sPost += "&offset_months=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.offset_months)));
            sPost += "&alt_proration_start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_proration_start_date)));
            sPost += "&alt_msg_template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_msg_template_no)));
            sPost += "&seq_func_group_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.seq_func_group_no)));
            sPost += "&address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.address3)));
            sPost += "&bill_address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_address3)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.usage_accumulation_config, "&usage_accumulation_config");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.enable_usage_pooling_plan_no, "&enable_usage_pooling_plan_no");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.disable_usage_pooling_plan_no, "&disable_usage_pooling_plan_no");
            sPost += "&alt_client_acct_group_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_client_acct_group_id)));
            sPost += "&track_data1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.track_data1)));
            sPost += "&track_data2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.track_data2)));
            sPost += "&offset_interval=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.offset_interval)));
            sPost += "&tax_exemption_level=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.tax_exemption_level)));
            sPost += "&cn_alt_msg_template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cn_alt_msg_template_no)));
            sPost += "&promo_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.promo_cd)));
            sPost += "&invoice_unbilled_usage=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.invoice_unbilled_usage)));
            sPost += "&coupon_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.coupon_code)));
            sPost += "&userid=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.userid)));
            sPost += "&invoice_approval_required=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.invoice_approval_required)));
            sPost += "&client_master_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_master_plan_id)));
            sPost += "&client_mp_alt_rate_sched_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_mp_alt_rate_sched_id)));
            sPost += "&client_alt_msg_template_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_alt_msg_template_id)));
            sPost += "&client_cn_alt_msg_template_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_cn_alt_msg_template_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.update_surcharge, "&update_surcharge");
            sPost += "&iban=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.iban)));
            sPost += "&bank_check_digit=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_check_digit)));
            sPost += "&bank_swift_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_swift_cd)));
            sPost += "&bank_country_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_country_cd)));
            sPost += "&mandate_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.mandate_id)));
            sPost += "&bank_id_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_id_cd)));
            sPost += "&bank_branch_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_branch_cd)));
            sPost += "&bkup_bill_first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_first_name)));
            sPost += "&bkup_bill_mi=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_mi)));
            sPost += "&bkup_bill_last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_last_name)));
            sPost += "&bkup_bill_company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_company_name)));
            sPost += "&bkup_bill_address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_address1)));
            sPost += "&bkup_bill_address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_address2)));
            sPost += "&bkup_bill_address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_address3)));
            sPost += "&bkup_bill_city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_city)));
            sPost += "&bkup_bill_locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_locality)));
            sPost += "&bkup_bill_state_prov=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_state_prov)));
            sPost += "&bkup_bill_country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_country)));
            sPost += "&bkup_bill_postal_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_postal_cd)));
            sPost += "&bkup_bill_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_phone)));
            sPost += "&bkup_bill_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_phone_ext)));
            sPost += "&bkup_bill_cell_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_cell_phone)));
            sPost += "&bkup_bill_work_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_work_phone)));
            sPost += "&bkup_bill_work_phone_ext=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_work_phone_ext)));
            sPost += "&bkup_bill_email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_email)));
            sPost += "&bkup_pay_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_pay_method)));
            sPost += "&bkup_cc_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_cc_number)));
            sPost += "&bkup_cc_expire_mm=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_cc_expire_mm)));
            sPost += "&bkup_cc_expire_yyyy=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_cc_expire_yyyy)));
            sPost += "&bkup_bank_acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bank_acct_no)));
            sPost += "&bkup_bank_routing_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bank_routing_no)));
            sPost += "&bkup_bill_agreement_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_bill_agreement_id)));
            sPost += "&bkup_cvv=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bkup_cvv)));
            sPost += "&seq_func_group_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.seq_func_group_id)));
            sPost += "&revrec_profile_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.revrec_profile_id)));
            sPost += "&revrec_client_defined_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.revrec_client_defined_id)));
            sPost += "&stmnt_email_list=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.stmnt_email_list)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&start_date_range=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.start_date_range)));
            sPost += "&end_date_range=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.end_date_range)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&resource_threshold_level=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.resource_threshold_level)));
            sPost += "&resource_balance=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.resource_balance)));
            sPost += "&resource_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.resource_name)));
            sPost += "&resource_units_label=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.resource_units_label)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&exemption_level=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.exemption_level)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&install_complete_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.install_complete_ind)));
            sPost += "&comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.comments)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&filter_credit_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.filter_credit_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&primary_or_bkup_pay_mthd_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.primary_or_bkup_pay_mthd_ind)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.custom_acct_rates, "&custom_acct_rates");
            sPost += "&plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.plan_no)));
            sPost += "&service_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.service_no)));
            sPost += "&client_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_plan_id)));
            sPost += "&client_service_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_service_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&pay_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.pay_method)));
            sPost += "&form_payment_acct_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.form_payment_acct_id)));
            sPost += "&bank_routing_num=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_routing_num)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&action_directive=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.action_directive)));
            sPost += "&adjustment_days=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.adjustment_days)));
            sPost += "&comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.comments)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&comment=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.comment)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&date_range_start=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.date_range_start)));
            sPost += "&date_range_end=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.date_range_end)));
            sPost += "&do_url_encoding=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_url_encoding)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.acct_supp_fields, "&acct_supp_fields");
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.plan_no)));
            sPost += "&client_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_plan_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&user_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.user_id)));
            sPost += "&start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.start_date)));
            sPost += "&end_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.end_date)));
            sPost += "&include_invoice_activity_eligibility=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.include_invoice_activity_eligibility)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&user_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.user_id)));
            sPost += "&start_bill_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.start_bill_date)));
            sPost += "&end_bill_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.end_bill_date)));
            sPost += "&include_voided=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.include_voided)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&statement_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.statement_no)));
            sPost += "&do_encoding=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_encoding)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&statement_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.statement_no)));
            sPost += "&do_encoding=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_encoding)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&sku=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.sku)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&user_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.user_id)));
            sPost += "&sku=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.sku)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.supp_plans_to_assign, "&supp_plans_to_assign");
            sPost += "&assignment_directive=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.assignment_directive)));
            sPost += "&do_write=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_write)));
            sPost += "&comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.comments)));
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            sPost += "&alt_proration_start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_proration_start_date)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.coupon_codes, "&coupon_codes");
            sPost += "&effective_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.effective_date)));
            sPost += "&sync_mstr_bill_dates_override=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.sync_mstr_bill_dates_override)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.supp_plan_surcharges, "&supp_plan_surcharges");
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&filter_seq_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.filter_seq_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&send_email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.send_email)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&coupon_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.coupon_cd)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.credit_ids, "&credit_ids");
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&usage_details_flag=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.usage_details_flag)));
            sPost += "&include_all_usage_unit_thresholds=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.include_all_usage_unit_thresholds)));
            sPost += "&plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.plan_no)));
            sPost += "&usage_type_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.usage_type_no)));
            sPost += "&usage_type_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.usage_type_code)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&amount=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.amount)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.usage_unit_thresholds, "&usage_unit_thresholds");
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&amount=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.amount)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.usage_unit_thresholds, "&usage_unit_thresholds");
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&amount=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.amount)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.usage_unit_thresholds, "&usage_unit_thresholds");
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&amount=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.amount)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.usage_unit_thresholds, "&usage_unit_thresholds");
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&contract_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.contract_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.plan_no, "&plan_no");
            sPost += "&type_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.type_no)));
            sPost += "&length_months=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.length_months)));
            sPost += "&create_comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.create_comments)));
            sPost += "&start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.start_date)));
            sPost += "&do_auto_discard=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_auto_discard)));
            sPost += "&end_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.end_date)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.client_plan_id, "&client_plan_id");
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&contract_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.contract_no)));
            sPost += "&type_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.type_no)));
            sPost += "&length_months=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.length_months)));
            sPost += "&start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.start_date)));
            sPost += "&update_comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.update_comments)));
            sPost += "&modify_directive=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.modify_directive)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.plans_input, "&plans_input");
            sPost += "&end_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.end_date)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.client_plan_id, "&client_plan_id");
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&contract_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.contract_no)));
            sPost += "&update_comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.update_comments)));
            sPost += "&close_status=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.close_status)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&type_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.type_no)));
            sPost += "&length_months=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.length_months)));
            sPost += "&create_comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.create_comments)));
            sPost += "&start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.start_date)));
            sPost += "&end_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.end_date)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&contract_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.contract_no)));
            sPost += "&type_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.type_no)));
            sPost += "&length_months=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.length_months)));
            sPost += "&start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.start_date)));
            sPost += "&update_comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.update_comments)));
            sPost += "&end_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.end_date)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&update_comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.update_comments)));
            sPost += "&close_status=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.close_status)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&hierarchy_filter=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.hierarchy_filter)));
            sPost += "&include_current_acct=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.include_current_acct)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&filter_status_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.filter_status_code)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&template_class=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.template_class)));
            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&acct_user_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_user_id)));
            sPost += "&client_acct_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_acct_id)));
            sPost += "&override_template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.override_template_no)));
            sPost += "&behavioral_option=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.behavioral_option)));
            sPost += "&override_template_option=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.override_template_option)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&notification_template_group_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.notification_template_group_id)));
            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&acct_user_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_user_id)));
            sPost += "&client_acct_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_acct_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&acct_user_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_user_id)));
            sPost += "&client_acct_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_acct_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&limit_records=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.limit_records)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&credit_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.credit_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&token=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.token)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&outage_start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.outage_start_date)));
            sPost += "&outage_end_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.outage_end_date)));
            sPost += "&outage_start_time=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.outage_start_time)));
            sPost += "&outage_end_time=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.outage_end_time)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.plans_to_get_outage, "&plans_to_get_outage");
            sPost += "&adjust_percent=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.adjust_percent)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.client_plan_ids_to_get_outage, "&client_plan_ids_to_get_outage");
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

        public get_usage_summary_by_typeResponse get_usage_summary_by_type(get_usage_summary_by_typeRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_usage_summary_by_type");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&user_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.user_id)));
            sPost += "&usage_type_filter=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.usage_type_filter)));
            sPost += "&date_filter_start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.date_filter_start_date)));
            sPost += "&date_filter_start_time=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.date_filter_start_time)));
            sPost += "&date_filter_end_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.date_filter_end_date)));
            sPost += "&date_filter_end_time=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.date_filter_end_time)));
            sPost += "&billed_filter=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.billed_filter)));
            sPost += "&billing_period_flag=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.billing_period_flag)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.usage_qualifier_1, "&usage_qualifier_1");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.usage_qualifier_2, "&usage_qualifier_2");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.usage_qualifier_3, "&usage_qualifier_3");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.usage_qualifier_4, "&usage_qualifier_4");
            sPost += "&usage_type_cd_filter=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.usage_type_cd_filter)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

            JsonSerializer json = new JsonSerializer
                          {
                              NullValueHandling = NullValueHandling.Ignore,
                              ObjectCreationHandling = ObjectCreationHandling.Replace,
                              MissingMemberHandling = MissingMemberHandling.Ignore,
                              ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                          };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_usage_summary_by_typeResponse myDeserializedObj = json.Deserialize(reader, typeof(get_usage_summary_by_typeResponse)) as get_usage_summary_by_typeResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_acct_open_chargesResponse get_acct_open_charges(get_acct_open_chargesRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_acct_open_charges");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

            JsonSerializer json = new JsonSerializer
                          {
                              NullValueHandling = NullValueHandling.Ignore,
                              ObjectCreationHandling = ObjectCreationHandling.Replace,
                              MissingMemberHandling = MissingMemberHandling.Ignore,
                              ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                          };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_acct_open_chargesResponse myDeserializedObj = json.Deserialize(reader, typeof(get_acct_open_chargesResponse)) as get_acct_open_chargesResponse;
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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&transaction_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.transaction_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_no)));
            sPost += "&transaction_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.transaction_id)));
            sPost += "&reason_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.reason_code)));
            sPost += "&comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.comments)));
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_no)));
            sPost += "&transaction_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.transaction_id)));
            sPost += "&comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.comments)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&source_account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.source_account_no)));
            sPost += "&target_account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.target_account_no)));
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_no)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.order_line_items, "&order_line_items");
            sPost += "&bill_immediately=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_immediately)));
            sPost += "&bill_seq=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_seq)));
            sPost += "&client_order_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_order_id)));
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            sPost += "&alt_pay_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_pay_method)));
            sPost += "&cc_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_number)));
            sPost += "&cc_expire_mm=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_expire_mm)));
            sPost += "&cc_expire_yyyy=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_expire_yyyy)));
            sPost += "&bank_routing_num=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_routing_num)));
            sPost += "&bank_acct_num=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_acct_num)));
            sPost += "&bill_company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_company_name)));
            sPost += "&bill_first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_first_name)));
            sPost += "&bill_middle_initial=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_middle_initial)));
            sPost += "&bill_last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_last_name)));
            sPost += "&bill_address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_address1)));
            sPost += "&bill_address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_address2)));
            sPost += "&bill_city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_city)));
            sPost += "&bill_locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_locality)));
            sPost += "&bill_state_prov=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_state_prov)));
            sPost += "&bill_zip=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_zip)));
            sPost += "&bill_country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_country)));
            sPost += "&bill_email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_email)));
            sPost += "&bill_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_phone)));
            sPost += "&bill_phone_extension=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_phone_extension)));
            sPost += "&bill_cell_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_cell_phone)));
            sPost += "&bill_work_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_work_phone)));
            sPost += "&bill_work_phone_extension=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_work_phone_extension)));
            sPost += "&cvv=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cvv)));
            sPost += "&bill_address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_address3)));
            sPost += "&do_write=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_write)));
            sPost += "&coupon_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.coupon_cd)));
            sPost += "&alt_client_acct_group_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_client_acct_group_id)));
            sPost += "&track_data1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.track_data1)));
            sPost += "&track_data2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.track_data2)));
            sPost += "&alt_inv_template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_inv_template_no)));
            sPost += "&client_alt_inv_template_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_alt_inv_template_id)));
            sPost += "&iban=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.iban)));
            sPost += "&bank_check_digit=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_check_digit)));
            sPost += "&bank_swift_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_swift_cd)));
            sPost += "&bank_country_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_country_cd)));
            sPost += "&mandate_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.mandate_id)));
            sPost += "&bank_id_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_id_cd)));
            sPost += "&bank_branch_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_branch_cd)));
            sPost += "&statement_message=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.statement_message)));
            sPost += "&fulfilled_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.fulfilled_date)));
            sPost += "&order_comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.order_comments)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_no)));
            sPost += "&alt_pay_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_pay_method)));
            sPost += "&cc_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_number)));
            sPost += "&cc_expire_mm=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_expire_mm)));
            sPost += "&cc_expire_yyyy=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_expire_yyyy)));
            sPost += "&bank_routing_num=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_routing_num)));
            sPost += "&bank_acct_num=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_acct_num)));
            sPost += "&bill_company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_company_name)));
            sPost += "&bill_first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_first_name)));
            sPost += "&bill_middle_initial=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_middle_initial)));
            sPost += "&bill_last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_last_name)));
            sPost += "&bill_address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_address1)));
            sPost += "&bill_address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_address2)));
            sPost += "&bill_city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_city)));
            sPost += "&bill_locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_locality)));
            sPost += "&bill_state_prov=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_state_prov)));
            sPost += "&bill_zip=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_zip)));
            sPost += "&bill_country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_country)));
            sPost += "&bill_email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_email)));
            sPost += "&bill_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_phone)));
            sPost += "&bill_phone_extension=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_phone_extension)));
            sPost += "&bill_cell_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_cell_phone)));
            sPost += "&bill_work_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_work_phone)));
            sPost += "&bill_work_phone_extension=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_work_phone_extension)));
            sPost += "&cvv=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cvv)));
            sPost += "&bill_address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_address3)));
            sPost += "&alt_client_acct_group_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_client_acct_group_id)));
            sPost += "&track_data1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.track_data1)));
            sPost += "&track_data2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.track_data2)));
            sPost += "&force_balance_scope=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.force_balance_scope)));
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            sPost += "&iban=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.iban)));
            sPost += "&bank_check_digit=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_check_digit)));
            sPost += "&bank_swift_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_swift_cd)));
            sPost += "&bank_country_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_country_cd)));
            sPost += "&mandate_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.mandate_id)));
            sPost += "&bank_id_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_id_cd)));
            sPost += "&bank_branch_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_branch_cd)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_no)));
            sPost += "&amount_to_collect=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.amount_to_collect)));
            sPost += "&bill_seq=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_seq)));
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.specific_charge_transaction_id, "&specific_charge_transaction_id");
            sPost += "&alt_pay_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_pay_method)));
            sPost += "&cc_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_number)));
            sPost += "&cc_expire_mm=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_expire_mm)));
            sPost += "&cc_expire_yyyy=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_expire_yyyy)));
            sPost += "&bank_routing_num=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_routing_num)));
            sPost += "&bank_acct_num=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_acct_num)));
            sPost += "&bill_company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_company_name)));
            sPost += "&bill_first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_first_name)));
            sPost += "&bill_middle_initial=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_middle_initial)));
            sPost += "&bill_last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_last_name)));
            sPost += "&bill_address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_address1)));
            sPost += "&bill_address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_address2)));
            sPost += "&bill_city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_city)));
            sPost += "&bill_locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_locality)));
            sPost += "&bill_state_prov=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_state_prov)));
            sPost += "&bill_zip=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_zip)));
            sPost += "&bill_country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_country)));
            sPost += "&bill_email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_email)));
            sPost += "&bill_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_phone)));
            sPost += "&bill_phone_extension=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_phone_extension)));
            sPost += "&bill_cell_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_cell_phone)));
            sPost += "&bill_work_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_work_phone)));
            sPost += "&bill_work_phone_extension=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_work_phone_extension)));
            sPost += "&cvv=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cvv)));
            sPost += "&bill_address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_address3)));
            sPost += "&alt_client_acct_group_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_client_acct_group_id)));
            sPost += "&track_data1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.track_data1)));
            sPost += "&track_data2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.track_data2)));
            sPost += "&payment_application_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.payment_application_method)));
            sPost += "&iban=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.iban)));
            sPost += "&bank_check_digit=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_check_digit)));
            sPost += "&bank_swift_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_swift_cd)));
            sPost += "&bank_country_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_country_cd)));
            sPost += "&mandate_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.mandate_id)));
            sPost += "&bank_id_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_id_cd)));
            sPost += "&bank_branch_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_branch_cd)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_no)));
            sPost += "&reference_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.reference_code)));
            sPost += "&payment_amount=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.payment_amount)));
            sPost += "&comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.comments)));
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.specific_charge_transaction_id, "&specific_charge_transaction_id");
            sPost += "&external_destination_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.external_destination_id)));
            sPost += "&external_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.external_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.invoice_no, "&invoice_no");
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_no)));
            sPost += "&payment_amount=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.payment_amount)));
            sPost += "&reference_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.reference_code)));
            sPost += "&comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.comments)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_no)));
            sPost += "&credit_amount=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.credit_amount)));
            sPost += "&credit_reason_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.credit_reason_code)));
            sPost += "&comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.comments)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_no)));
            sPost += "&credit_amount=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.credit_amount)));
            sPost += "&credit_reason_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.credit_reason_code)));
            sPost += "&comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.comments)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.specific_charge_transaction_id, "&specific_charge_transaction_id");
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_no)));
            sPost += "&billing_interval_units=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.billing_interval_units)));
            sPost += "&times_to_bill=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.times_to_bill)));
            sPost += "&billing_interval_type=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.billing_interval_type)));
            sPost += "&first_bill_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.first_bill_date)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.standing_order, "&standing_order");
            sPost += "&client_order_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_order_id)));
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            sPost += "&statement_message=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.statement_message)));
            sPost += "&order_comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.order_comments)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&standing_order_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.standing_order_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_no)));
            sPost += "&payment_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.payment_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.specific_charge_transaction_id, "&specific_charge_transaction_id");
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            RestUtilities.addParameterValuesFromArray(ref sPost, request.usage_records, "&usage_records");
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&usage_units=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.usage_units)));
            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&userid=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.userid)));
            sPost += "&usage_type=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.usage_type)));
            sPost += "&usage_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.usage_date)));
            sPost += "&billable_units=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.billable_units)));
            sPost += "&amt=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.amt)));
            sPost += "&rate=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.rate)));
            sPost += "&telco_from=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.telco_from)));
            sPost += "&telco_to=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.telco_to)));
            sPost += "&comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.comments)));
            sPost += "&exclude_from_billing=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.exclude_from_billing)));
            sPost += "&exclusion_comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.exclusion_comments)));
            sPost += "&qualifier_1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.qualifier_1)));
            sPost += "&qualifier_2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.qualifier_2)));
            sPost += "&qualifier_3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.qualifier_3)));
            sPost += "&qualifier_4=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.qualifier_4)));
            sPost += "&parent_usage_rec_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.parent_usage_rec_no)));
            sPost += "&usage_type_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.usage_type_code)));
            sPost += "&client_record_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_record_id)));
            sPost += "&caller_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.caller_id)));
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&my_order_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.my_order_no)));
            sPost += "&my_client_order_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.my_client_order_id)));
            sPost += "&limit_records=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.limit_records)));
            sPost += "&details_flag=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.details_flag)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&my_standing_order=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.my_standing_order)));
            sPost += "&my_client_order_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.my_client_order_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&standing_order_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.standing_order_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&standing_order_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.standing_order_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&log_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.log_id)));
            sPost += "&first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.first_name)));
            sPost += "&mi=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.mi)));
            sPost += "&last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.last_name)));
            sPost += "&address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.address1)));
            sPost += "&address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.address2)));
            sPost += "&city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.city)));
            sPost += "&state_prov_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.state_prov_code)));
            sPost += "&zip_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.zip_code)));
            sPost += "&country_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.country_code)));
            sPost += "&currency_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.currency_code)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.pre_calc_plan, "&pre_calc_plan");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.pre_calc_sku, "&pre_calc_sku");
            sPost += "&tax_exempt_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.tax_exempt_cd)));
            sPost += "&address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.address3)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&order_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.order_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&force_pending=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.force_pending)));
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            sPost += "&alt_bill_day=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_bill_day)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&alt_stmt_template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_stmt_template_no)));
            sPost += "&auto_skip_to_next_bill_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auto_skip_to_next_bill_date)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&invoice_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.invoice_no)));
            sPost += "&do_encoding=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_encoding)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&invoice_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.invoice_no)));
            sPost += "&do_encoding=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_encoding)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&src_transaction_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.src_transaction_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&src_transaction_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.src_transaction_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&src_transaction_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.src_transaction_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&invoice_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.invoice_no)));
            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&action_directive=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.action_directive)));
            sPost += "&bill_seq=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_seq)));
            sPost += "&alt_pay_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_pay_method)));
            sPost += "&cc_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_number)));
            sPost += "&cc_expire_mm=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_expire_mm)));
            sPost += "&cc_expire_yyyy=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_expire_yyyy)));
            sPost += "&bank_routing_num=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_routing_num)));
            sPost += "&bank_acct_num=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_acct_num)));
            sPost += "&bill_company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_company_name)));
            sPost += "&bill_first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_first_name)));
            sPost += "&bill_middle_initial=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_middle_initial)));
            sPost += "&bill_last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_last_name)));
            sPost += "&bill_address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_address1)));
            sPost += "&bill_address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_address2)));
            sPost += "&bill_city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_city)));
            sPost += "&bill_locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_locality)));
            sPost += "&bill_state_prov=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_state_prov)));
            sPost += "&bill_zip=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_zip)));
            sPost += "&bill_country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_country)));
            sPost += "&bill_email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_email)));
            sPost += "&bill_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_phone)));
            sPost += "&bill_phone_extension=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_phone_extension)));
            sPost += "&bill_cell_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_cell_phone)));
            sPost += "&bill_work_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_work_phone)));
            sPost += "&bill_work_phone_extension=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_work_phone_extension)));
            sPost += "&cvv=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cvv)));
            sPost += "&alt_collect_on_approve=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_collect_on_approve)));
            sPost += "&alt_send_statement_on_approve=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_send_statement_on_approve)));
            sPost += "&cancel_orders_on_discard=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cancel_orders_on_discard)));
            sPost += "&bill_address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_address3)));
            sPost += "&track_data1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.track_data1)));
            sPost += "&track_data2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.track_data2)));
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            sPost += "&iban=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.iban)));
            sPost += "&bank_check_digit=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_check_digit)));
            sPost += "&bank_swift_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_swift_cd)));
            sPost += "&bank_country_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_country_cd)));
            sPost += "&mandate_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.mandate_id)));
            sPost += "&bank_id_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_id_cd)));
            sPost += "&bank_branch_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_branch_cd)));
            sPost += "&custom_status_label=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.custom_status_label)));
            sPost += "&client_notes=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_notes)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&order_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.order_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&include_voided=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.include_voided)));
            sPost += "&aria_event_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.aria_event_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.order_line_items, "&order_line_items");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.cart_supp_plans, "&cart_supp_plans");
            sPost += "&client_order_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_order_id)));
            sPost += "&coupon_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.coupon_code)));
            sPost += "&comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.comments)));
            sPost += "&do_write=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_write)));
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            sPost += "&bill_seq=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_seq)));
            sPost += "&alt_pay_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_pay_method)));
            sPost += "&cc_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_number)));
            sPost += "&cc_expire_mm=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_expire_mm)));
            sPost += "&cc_expire_yyyy=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_expire_yyyy)));
            sPost += "&bank_routing_num=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_routing_num)));
            sPost += "&bank_acct_num=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_acct_num)));
            sPost += "&bill_company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_company_name)));
            sPost += "&bill_first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_first_name)));
            sPost += "&bill_middle_initial=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_middle_initial)));
            sPost += "&bill_last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_last_name)));
            sPost += "&bill_address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_address1)));
            sPost += "&bill_address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_address2)));
            sPost += "&bill_city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_city)));
            sPost += "&bill_locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_locality)));
            sPost += "&bill_state_prov=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_state_prov)));
            sPost += "&bill_zip=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_zip)));
            sPost += "&bill_country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_country)));
            sPost += "&bill_email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_email)));
            sPost += "&bill_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_phone)));
            sPost += "&bill_phone_extension=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_phone_extension)));
            sPost += "&bill_cell_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_cell_phone)));
            sPost += "&bill_work_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_work_phone)));
            sPost += "&bill_work_phone_extension=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_work_phone_extension)));
            sPost += "&cvv=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cvv)));
            sPost += "&bill_address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_address3)));
            sPost += "&track_data1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.track_data1)));
            sPost += "&track_data2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.track_data2)));
            sPost += "&alt_inv_template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_inv_template_no)));
            sPost += "&sync_mstr_bill_dates_override=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.sync_mstr_bill_dates_override)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.multiple_coupons, "&multiple_coupons");
            sPost += "&client_alt_inv_template_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_alt_inv_template_id)));
            sPost += "&iban=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.iban)));
            sPost += "&bank_check_digit=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_check_digit)));
            sPost += "&bank_swift_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_swift_cd)));
            sPost += "&bank_country_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_country_cd)));
            sPost += "&mandate_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.mandate_id)));
            sPost += "&bank_id_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_id_cd)));
            sPost += "&bank_branch_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_branch_cd)));
            sPost += "&statement_message=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.statement_message)));
            sPost += "&order_comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.order_comments)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&payment_transaction_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.payment_transaction_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&payment_transaction_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.payment_transaction_id)));
            sPost += "&reason_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.reason_code)));
            sPost += "&total_refund_amount=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.total_refund_amount)));
            sPost += "&refund_check_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.refund_check_number)));
            sPost += "&comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.comments)));
            sPost += "&do_write=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_write)));
            sPost += "&auto_calc_refund=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auto_calc_refund)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.invoices_to_reverse, "&invoices_to_reverse");
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            sPost += "&is_unlinked_refund=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.is_unlinked_refund)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

        public update_refund_check_noResponse update_refund_check_no(update_refund_check_noRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("update_refund_check_no");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&transaction_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.transaction_id)));
            sPost += "&refund_check_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.refund_check_number)));
            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&acct_user_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_user_id)));
            sPost += "&client_acct_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_acct_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

            JsonSerializer json = new JsonSerializer
                          {
                              NullValueHandling = NullValueHandling.Ignore,
                              ObjectCreationHandling = ObjectCreationHandling.Replace,
                              MissingMemberHandling = MissingMemberHandling.Ignore,
                              ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                          };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            update_refund_check_noResponse myDeserializedObj = json.Deserialize(reader, typeof(update_refund_check_noResponse)) as update_refund_check_noResponse;
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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&aria_event_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.aria_event_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&xml_statement_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.xml_statement_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.start_date)));
            sPost += "&end_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.end_date)));
            sPost += "&limit_records=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.limit_records)));
            sPost += "&details_flag=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.details_flag)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&transaction_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.transaction_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&transaction_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.transaction_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            RestUtilities.addParameterValuesFromArray(ref sPost, request.usage_record_nos, "&usage_record_nos");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.client_record_ids, "&client_record_ids");
            sPost += "&exclusion_reason_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.exclusion_reason_cd)));
            sPost += "&exclusion_comment=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.exclusion_comment)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&invoice_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.invoice_no)));
            sPost += "&amount=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.amount)));
            sPost += "&reason_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.reason_code)));
            sPost += "&comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.comments)));
            sPost += "&do_dispute=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_dispute)));
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&dispute_or_writeoff_flag=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.dispute_or_writeoff_flag)));
            sPost += "&details_flag=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.details_flag)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&dispute_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.dispute_no)));
            sPost += "&settlement_action=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.settlement_action)));
            sPost += "&comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.comments)));
            sPost += "&client_receipt_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_receipt_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

        public cancel_recurring_creditsResponse cancel_recurring_credits(cancel_recurring_creditsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("cancel_recurring_credits");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            sPost += "&userid=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.userid)));
            sPost += "&client_acct_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_acct_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.recurring_credit_no, "&recurring_credit_no");
            sPost += "&cancel_comments=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cancel_comments)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

            JsonSerializer json = new JsonSerializer
                          {
                              NullValueHandling = NullValueHandling.Ignore,
                              ObjectCreationHandling = ObjectCreationHandling.Replace,
                              MissingMemberHandling = MissingMemberHandling.Ignore,
                              ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                          };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            cancel_recurring_creditsResponse myDeserializedObj = json.Deserialize(reader, typeof(cancel_recurring_creditsResponse)) as cancel_recurring_creditsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public update_orderResponse update_order(update_orderRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("update_order");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_no)));
            sPost += "&order_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.order_no)));
            sPost += "&bill_immediately=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_immediately)));
            sPost += "&alt_pay_method=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_pay_method)));
            sPost += "&cc_number=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_number)));
            sPost += "&cc_expire_mm=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_expire_mm)));
            sPost += "&cc_expire_yyyy=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cc_expire_yyyy)));
            sPost += "&bank_routing_num=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_routing_num)));
            sPost += "&bank_acct_num=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_acct_num)));
            sPost += "&bill_company_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_company_name)));
            sPost += "&bill_first_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_first_name)));
            sPost += "&bill_middle_initial=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_middle_initial)));
            sPost += "&bill_last_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_last_name)));
            sPost += "&bill_address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_address1)));
            sPost += "&bill_address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_address2)));
            sPost += "&bill_city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_city)));
            sPost += "&bill_locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_locality)));
            sPost += "&bill_state_prov=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_state_prov)));
            sPost += "&bill_zip=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_zip)));
            sPost += "&bill_country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_country)));
            sPost += "&bill_email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_email)));
            sPost += "&bill_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_phone)));
            sPost += "&bill_work_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_work_phone)));
            sPost += "&bill_work_phone_extension=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_work_phone_extension)));
            sPost += "&cvv=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.cvv)));
            sPost += "&bill_address3=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bill_address3)));
            sPost += "&do_write=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.do_write)));
            sPost += "&alt_client_acct_group_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_client_acct_group_id)));
            sPost += "&track_data1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.track_data1)));
            sPost += "&track_data2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.track_data2)));
            sPost += "&alt_inv_template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_inv_template_no)));
            sPost += "&iban=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.iban)));
            sPost += "&bank_check_digit=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_check_digit)));
            sPost += "&bank_swift_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_swift_cd)));
            sPost += "&bank_country_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_country_cd)));
            sPost += "&mandate_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.mandate_id)));
            sPost += "&bank_id_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_id_cd)));
            sPost += "&bank_branch_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bank_branch_cd)));
            sPost += "&fulfilled_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.fulfilled_date)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

            JsonSerializer json = new JsonSerializer
                          {
                              NullValueHandling = NullValueHandling.Ignore,
                              ObjectCreationHandling = ObjectCreationHandling.Replace,
                              MissingMemberHandling = MissingMemberHandling.Ignore,
                              ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                          };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            update_orderResponse myDeserializedObj = json.Deserialize(reader, typeof(update_orderResponse)) as update_orderResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public update_acct_invoiceResponse update_acct_invoice(update_acct_invoiceRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("update_acct_invoice");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&account_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.account_no)));
            sPost += "&src_transaction_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.src_transaction_id)));
            sPost += "&custom_status_label=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.custom_status_label)));
            sPost += "&client_notes=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_notes)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

            JsonSerializer json = new JsonSerializer
                          {
                              NullValueHandling = NullValueHandling.Ignore,
                              ObjectCreationHandling = ObjectCreationHandling.Replace,
                              MissingMemberHandling = MissingMemberHandling.Ignore,
                              ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                          };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            update_acct_invoiceResponse myDeserializedObj = json.Deserialize(reader, typeof(update_acct_invoiceResponse)) as update_acct_invoiceResponse;
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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&user_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.user_id)));
            sPost += "&password=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.password)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&user_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.user_id)));
            sPost += "&acct_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_no)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&session_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.session_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&session_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.session_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&session_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.session_id)));
            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

        public authenticate_callerResponse authenticate_caller(authenticate_callerRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("authenticate_caller");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            
            string returnString = "";
            Stream dataStream = null;
            StreamReader responseReader = null;
            try{
                byte[] content = Encoding.ASCII.GetBytes(sPost);
                WebRequest webRequest = WebRequest.Create(url);
                webRequest.Method = getMethod();
                webRequest.ContentType = getContentType();
                webRequest.ContentLength = content.Length;
                dataStream = webRequest.GetRequestStream();
                dataStream.Write(content, 0, content.Length);

                responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream());
                returnString = responseReader.ReadToEnd();
            }
            finally
            {
                if (dataStream != null)
                {
                    dataStream.Close();
                }
                if (responseReader != null)
                {
                    responseReader.Close();
                }
            }

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

        #endregion Api Calls
    }
}
