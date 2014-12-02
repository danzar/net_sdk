using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools;

namespace Aria.SDK.AriaServices.AriaWebServices
{
    public class AriaBillingAdminTools : AriaBillingBase
    {
        #region Constructor
        /*Creates a new AriaBillingAdminTools with no parms*/
        public AriaBillingAdminTools() : base ("https://admintools.unstable.qa.ariasystems.net/index.php/Dispatcher/index")
        {
        }
        /*Creates a new AriaBillingAdminTools with URL parm*/
        public AriaBillingAdminTools(String URL) : base (URL)
        {
        }
        #endregion Constructor

        #region Api Calls
        public get_promo_plan_setsResponse get_promo_plan_sets(get_promo_plan_setsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_promo_plan_sets");

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
            get_promo_plan_setsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_promo_plan_setsResponse)) as get_promo_plan_setsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_promo_plan_set_detailsResponse get_promo_plan_set_details(get_promo_plan_set_detailsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_promo_plan_set_details");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&promo_plan_set_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.promo_plan_set_no)));
            sPost += "&client_plan_type_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_plan_type_id)));
            
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
            get_promo_plan_set_detailsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_promo_plan_set_detailsResponse)) as get_promo_plan_set_detailsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public create_promo_plan_setResponse create_promo_plan_set(create_promo_plan_setRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("create_promo_plan_set");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&promo_plan_set_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.promo_plan_set_name)));
            sPost += "&promo_plan_set_desc=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.promo_plan_set_desc)));
            sPost += "&client_plan_type_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_plan_type_id)));
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
            create_promo_plan_setResponse myDeserializedObj = json.Deserialize(reader, typeof(create_promo_plan_setResponse)) as create_promo_plan_setResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public update_promo_plan_setResponse update_promo_plan_set(update_promo_plan_setRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("update_promo_plan_set");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&promo_plan_set_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.promo_plan_set_no)));
            sPost += "&promo_plan_set_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.promo_plan_set_name)));
            sPost += "&promo_plan_set_desc=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.promo_plan_set_desc)));
            sPost += "&client_plan_type_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_plan_type_id)));
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
            update_promo_plan_setResponse myDeserializedObj = json.Deserialize(reader, typeof(update_promo_plan_setResponse)) as update_promo_plan_setResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public list_promo_setsResponse list_promo_sets(list_promo_setsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("list_promo_sets");

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
            list_promo_setsResponse myDeserializedObj = json.Deserialize(reader, typeof(list_promo_setsResponse)) as list_promo_setsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_company_profileResponse get_company_profile(get_company_profileRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_company_profile");

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
            get_company_profileResponse myDeserializedObj = json.Deserialize(reader, typeof(get_company_profileResponse)) as get_company_profileResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public set_company_profileResponse set_company_profile(set_company_profileRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("set_company_profile");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&domain=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.domain)));
            sPost += "&address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.address1)));
            sPost += "&address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.address2)));
            sPost += "&city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.city)));
            sPost += "&locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.locality)));
            sPost += "&state_prov=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.state_prov)));
            sPost += "&country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.country)));
            sPost += "&postal_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.postal_code)));
            sPost += "&phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.phone)));
            sPost += "&contact=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.contact)));
            sPost += "&contact_address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.contact_address1)));
            sPost += "&contact_address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.contact_address2)));
            sPost += "&contact_city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.contact_city)));
            sPost += "&contact_state=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.contact_state)));
            sPost += "&contact_zip=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.contact_zip)));
            sPost += "&contact_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.contact_phone)));
            sPost += "&contact_email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.contact_email)));
            sPost += "&billing_contact=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.billing_contact)));
            sPost += "&billing_address1=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.billing_address1)));
            sPost += "&billing_address2=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.billing_address2)));
            sPost += "&billing_city=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.billing_city)));
            sPost += "&billing_state=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.billing_state)));
            sPost += "&billing_zip=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.billing_zip)));
            sPost += "&billing_phone=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.billing_phone)));
            sPost += "&billing_email=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.billing_email)));
            sPost += "&contact_country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.contact_country)));
            sPost += "&contact_locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.contact_locality)));
            sPost += "&billing_country=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.billing_country)));
            sPost += "&billing_locality=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.billing_locality)));
            
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
            set_company_profileResponse myDeserializedObj = json.Deserialize(reader, typeof(set_company_profileResponse)) as set_company_profileResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_inventory_itemsResponse get_inventory_items(get_inventory_itemsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_inventory_items");

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
            get_inventory_itemsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_inventory_itemsResponse)) as get_inventory_itemsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_inventory_item_detailsResponse get_inventory_item_details(get_inventory_item_detailsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_inventory_item_details");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&item_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.item_no)));
            sPost += "&client_item_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_item_id)));
            sPost += "&currency_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.currency_cd)));
            
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
            get_inventory_item_detailsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_inventory_item_detailsResponse)) as get_inventory_item_detailsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public create_inventory_itemResponse create_inventory_item(create_inventory_itemRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("create_inventory_item");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&item_type=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.item_type)));
            sPost += "&item_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.item_name)));
            sPost += "&item_desc=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.item_desc)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.service, "&service");
            sPost += "&client_sku=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_sku)));
            sPost += "&currency_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.currency_cd)));
            sPost += "&item_price=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.item_price)));
            sPost += "&client_item_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_item_id)));
            sPost += "&active_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.active_ind)));
            sPost += "&invoice_advancement_months=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.invoice_advancement_months)));
            sPost += "&plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.plan_no)));
            sPost += "&client_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_plan_id)));
            sPost += "&tax_inclusive_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.tax_inclusive_ind)));
            sPost += "&modify_price_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.modify_price_ind)));
            sPost += "&subunit_qty=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.subunit_qty)));
            sPost += "&subunit_label=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.subunit_label)));
            sPost += "&days_to_expiry=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.days_to_expiry)));
            sPost += "&resource_type_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.resource_type_no)));
            sPost += "&resource_units=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.resource_units)));
            sPost += "&stock_level_track=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.stock_level_track)));
            sPost += "&stock_level_adjust=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.stock_level_adjust)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.image, "&image");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.parent_class, "&parent_class");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.supplemental_obj_field, "&supplemental_obj_field");
            
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
            create_inventory_itemResponse myDeserializedObj = json.Deserialize(reader, typeof(create_inventory_itemResponse)) as create_inventory_itemResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public update_inventory_itemResponse update_inventory_item(update_inventory_itemRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("update_inventory_item");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&item_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.item_no)));
            sPost += "&item_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.item_name)));
            sPost += "&item_desc=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.item_desc)));
            sPost += "&client_item_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_item_id)));
            sPost += "&service_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.service_no)));
            sPost += "&client_service_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_service_id)));
            sPost += "&currency_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.currency_cd)));
            sPost += "&item_price=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.item_price)));
            sPost += "&active_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.active_ind)));
            sPost += "&invoice_advancement_months=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.invoice_advancement_months)));
            sPost += "&plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.plan_no)));
            sPost += "&client_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_plan_id)));
            sPost += "&modify_price_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.modify_price_ind)));
            sPost += "&subunit_qty=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.subunit_qty)));
            sPost += "&subunit_label=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.subunit_label)));
            sPost += "&days_to_expiry=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.days_to_expiry)));
            sPost += "&resource_type_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.resource_type_no)));
            sPost += "&resource_units=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.resource_units)));
            sPost += "&stock_level_track=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.stock_level_track)));
            sPost += "&stock_level_adjust=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.stock_level_adjust)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.image, "&image");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.parent_class, "&parent_class");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.supplemental_obj_field, "&supplemental_obj_field");
            
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
            update_inventory_itemResponse myDeserializedObj = json.Deserialize(reader, typeof(update_inventory_itemResponse)) as update_inventory_itemResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public create_item_classResponse create_item_class(create_item_classRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("create_item_class");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&class_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.class_name)));
            sPost += "&class_desc=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.class_desc)));
            sPost += "&active_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.active_ind)));
            sPost += "&client_inventory_class_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_inventory_class_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.parent_class, "&parent_class");
            
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
            create_item_classResponse myDeserializedObj = json.Deserialize(reader, typeof(create_item_classResponse)) as create_item_classResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public edit_item_classResponse edit_item_class(edit_item_classRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("edit_item_class");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&class_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.class_no)));
            sPost += "&class_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.class_name)));
            sPost += "&client_inventory_class_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_inventory_class_id)));
            sPost += "&class_desc=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.class_desc)));
            sPost += "&active_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.active_ind)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.parent_class, "&parent_class");
            
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
            edit_item_classResponse myDeserializedObj = json.Deserialize(reader, typeof(edit_item_classResponse)) as edit_item_classResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_service_typesResponse get_service_types(get_service_typesRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_service_types");

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
            get_service_typesResponse myDeserializedObj = json.Deserialize(reader, typeof(get_service_typesResponse)) as get_service_typesResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_servicesResponse get_services(get_servicesRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_services");

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
            get_servicesResponse myDeserializedObj = json.Deserialize(reader, typeof(get_servicesResponse)) as get_servicesResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_service_detailsResponse get_service_details(get_service_detailsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_service_details");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&service_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.service_no)));
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
            get_service_detailsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_service_detailsResponse)) as get_service_detailsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_plan_service_detailsResponse get_plan_service_details(get_plan_service_detailsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_plan_service_details");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&service_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.service_no)));
            sPost += "&client_service_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_service_id)));
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
            get_plan_service_detailsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_plan_service_detailsResponse)) as get_plan_service_detailsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public create_serviceResponse create_service(create_serviceRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("create_service");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&service_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.service_name)));
            sPost += "&service_type=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.service_type)));
            sPost += "&gl_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.gl_cd)));
            sPost += "&taxable_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.taxable_ind)));
            sPost += "&tax_group=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.tax_group)));
            sPost += "&usage_type=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.usage_type)));
            sPost += "&client_service_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_service_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.supplemental_obj_field, "&supplemental_obj_field");
            
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
            create_serviceResponse myDeserializedObj = json.Deserialize(reader, typeof(create_serviceResponse)) as create_serviceResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public update_serviceResponse update_service(update_serviceRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("update_service");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&service_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.service_no)));
            sPost += "&service_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.service_name)));
            sPost += "&service_type=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.service_type)));
            sPost += "&client_service_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_service_id)));
            sPost += "&gl_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.gl_cd)));
            sPost += "&taxable_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.taxable_ind)));
            sPost += "&tax_group=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.tax_group)));
            sPost += "&usage_type=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.usage_type)));
            
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
            update_serviceResponse myDeserializedObj = json.Deserialize(reader, typeof(update_serviceResponse)) as update_serviceResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_supp_fieldsResponse get_supp_fields(get_supp_fieldsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_supp_fields");

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
            get_supp_fieldsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_supp_fieldsResponse)) as get_supp_fieldsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_supp_field_detailsResponse get_supp_field_details(get_supp_field_detailsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_supp_field_details");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

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
            get_supp_field_detailsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_supp_field_detailsResponse)) as get_supp_field_detailsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public create_supp_fieldResponse create_supp_field(create_supp_fieldRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("create_supp_field");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&field_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.field_name)));
            sPost += "&field_order=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.field_order)));
            sPost += "&presentation_mode=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.presentation_mode)));
            sPost += "&field_desc=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.field_desc)));
            sPost += "&required_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.required_ind)));
            sPost += "&hidden_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.hidden_ind)));
            sPost += "&sel_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.sel_ind)));
            sPost += "&min_no_sel=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.min_no_sel)));
            sPost += "&max_no_sel=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.max_no_sel)));
            sPost += "&display_text=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.display_text)));
            sPost += "&option_value=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.option_value)));
            sPost += "&option_value_order=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.option_value_order)));
            
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
            create_supp_fieldResponse myDeserializedObj = json.Deserialize(reader, typeof(create_supp_fieldResponse)) as create_supp_fieldResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public update_supp_fieldResponse update_supp_field(update_supp_fieldRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("update_supp_field");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&field_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.field_name)));
            sPost += "&field_desc=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.field_desc)));
            sPost += "&field_order=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.field_order)));
            sPost += "&required_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.required_ind)));
            sPost += "&hidden_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.hidden_ind)));
            sPost += "&sel_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.sel_ind)));
            sPost += "&presentation_mode=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.presentation_mode)));
            sPost += "&min_no_sel=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.min_no_sel)));
            sPost += "&max_no_sel=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.max_no_sel)));
            sPost += "&display_text=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.display_text)));
            sPost += "&option_value=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.option_value)));
            sPost += "&option_value_order=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.option_value_order)));
            
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
            update_supp_fieldResponse myDeserializedObj = json.Deserialize(reader, typeof(update_supp_fieldResponse)) as update_supp_fieldResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_couponsResponse get_coupons(get_couponsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_coupons");

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
            get_couponsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_couponsResponse)) as get_couponsResponse;
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

        public create_couponResponse create_coupon(create_couponRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("create_coupon");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&coupon_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.coupon_cd)));
            sPost += "&status_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.status_ind)));
            sPost += "&start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.start_date)));
            sPost += "&end_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.end_date)));
            sPost += "&coupon_desc=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.coupon_desc)));
            sPost += "&coupon_msg=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.coupon_msg)));
            sPost += "&no_of_uses=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.no_of_uses)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.template, "&template");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.existing_template, "&existing_template");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.existing_template_id, "&existing_template_id");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.discount_rule, "&discount_rule");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.existing_discount_rule, "&existing_discount_rule");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.existing_discount_rule_id, "&existing_discount_rule_id");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.discount_bundle, "&discount_bundle");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.existing_discount_bundle, "&existing_discount_bundle");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.existing_discount_bundle_id, "&existing_discount_bundle_id");
            
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
            create_couponResponse myDeserializedObj = json.Deserialize(reader, typeof(create_couponResponse)) as create_couponResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public update_couponResponse update_coupon(update_couponRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("update_coupon");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&coupon_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.coupon_cd)));
            sPost += "&status_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.status_ind)));
            sPost += "&start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.start_date)));
            sPost += "&end_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.end_date)));
            sPost += "&coupon_desc=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.coupon_desc)));
            sPost += "&coupon_msg=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.coupon_msg)));
            sPost += "&no_of_uses=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.no_of_uses)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.template, "&template");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.existing_template, "&existing_template");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.existing_template_id, "&existing_template_id");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.discount_rule, "&discount_rule");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.existing_discount_rule, "&existing_discount_rule");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.existing_discount_rule_id, "&existing_discount_rule_id");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.discount_bundle, "&discount_bundle");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.existing_discount_bundle, "&existing_discount_bundle");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.existing_discount_bundle_id, "&existing_discount_bundle_id");
            
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
            update_couponResponse myDeserializedObj = json.Deserialize(reader, typeof(update_couponResponse)) as update_couponResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public delete_couponsResponse delete_coupons(delete_couponsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("delete_coupons");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            RestUtilities.addParameterValuesFromArray(ref sPost, request.coupon_nos, "&coupon_nos");
            
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
            delete_couponsResponse myDeserializedObj = json.Deserialize(reader, typeof(delete_couponsResponse)) as delete_couponsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_recurring_credit_templatesResponse get_recurring_credit_templates(get_recurring_credit_templatesRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_recurring_credit_templates");

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
            get_recurring_credit_templatesResponse myDeserializedObj = json.Deserialize(reader, typeof(get_recurring_credit_templatesResponse)) as get_recurring_credit_templatesResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_recurring_credit_template_detailsResponse get_recurring_credit_template_details(get_recurring_credit_template_detailsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_recurring_credit_template_details");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&credit_template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.credit_template_no)));
            sPost += "&client_credit_template_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_credit_template_id)));
            
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
            get_recurring_credit_template_detailsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_recurring_credit_template_detailsResponse)) as get_recurring_credit_template_detailsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public create_credit_templateResponse create_credit_template(create_credit_templateRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("create_credit_template");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&credit_template_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.credit_template_name)));
            sPost += "&discount_type=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.discount_type)));
            sPost += "&discount_amt=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.discount_amt)));
            sPost += "&no_of_credits=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.no_of_credits)));
            sPost += "&credit_interval_months=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.credit_interval_months)));
            sPost += "&eligible_plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.eligible_plan_no)));
            sPost += "&eligible_client_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.eligible_client_plan_id)));
            sPost += "&eligible_service_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.eligible_service_no)));
            sPost += "&eligible_client_service_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.eligible_client_service_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.eligible_service_types, "&eligible_service_types");
            sPost += "&percentage_plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.percentage_plan_no)));
            sPost += "&percentage_client_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.percentage_client_plan_id)));
            sPost += "&percentage_service_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.percentage_service_no)));
            sPost += "&percentage_client_service_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.percentage_client_service_id)));
            sPost += "&alt_service_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_service_no)));
            sPost += "&alt_client_service_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_client_service_id)));
            sPost += "&client_credit_template_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_credit_template_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.coupon, "&coupon");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.existing_coupon, "&existing_coupon");
            
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
            create_credit_templateResponse myDeserializedObj = json.Deserialize(reader, typeof(create_credit_templateResponse)) as create_credit_templateResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public update_credit_templateResponse update_credit_template(update_credit_templateRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("update_credit_template");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&credit_template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.credit_template_no)));
            sPost += "&credit_template_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.credit_template_name)));
            sPost += "&discount_type=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.discount_type)));
            sPost += "&discount_amt=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.discount_amt)));
            sPost += "&no_of_credits=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.no_of_credits)));
            sPost += "&credit_interval_months=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.credit_interval_months)));
            sPost += "&client_credit_template_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_credit_template_id)));
            sPost += "&eligible_plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.eligible_plan_no)));
            sPost += "&eligible_client_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.eligible_client_plan_id)));
            sPost += "&eligible_service_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.eligible_service_no)));
            sPost += "&eligible_client_service_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.eligible_client_service_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.eligible_service_types, "&eligible_service_types");
            sPost += "&percentage_plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.percentage_plan_no)));
            sPost += "&percentage_client_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.percentage_client_plan_id)));
            sPost += "&percentage_service_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.percentage_service_no)));
            sPost += "&percentage_client_service_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.percentage_client_service_id)));
            sPost += "&alt_service_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_service_no)));
            sPost += "&alt_client_service_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_client_service_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.coupon, "&coupon");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.existing_coupon, "&existing_coupon");
            
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
            update_credit_templateResponse myDeserializedObj = json.Deserialize(reader, typeof(update_credit_templateResponse)) as update_credit_templateResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public delete_templatesResponse delete_templates(delete_templatesRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("delete_templates");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            RestUtilities.addParameterValuesFromArray(ref sPost, request.template_nos, "&template_nos");
            
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
            delete_templatesResponse myDeserializedObj = json.Deserialize(reader, typeof(delete_templatesResponse)) as delete_templatesResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public create_discount_ruleResponse create_discount_rule(create_discount_ruleRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("create_discount_rule");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&label=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.label)));
            sPost += "&rule_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.rule_id)));
            sPost += "&description=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.description)));
            sPost += "&ext_description=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.ext_description)));
            sPost += "&flat_percent_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.flat_percent_ind)));
            sPost += "&amount=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.amount)));
            sPost += "&currency=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.currency)));
            sPost += "&duration_type_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.duration_type_ind)));
            sPost += "&inline_offset_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.inline_offset_ind)));
            sPost += "&service_code_to_use=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.service_code_to_use)));
            sPost += "&scope_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.scope_no)));
            sPost += "&max_applicable_months=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.max_applicable_months)));
            sPost += "&max_applications_per_acct=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.max_applications_per_acct)));
            sPost += "&alt_service_no_2_apply=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_service_no_2_apply)));
            sPost += "&alt_service_id_2_apply=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.alt_service_id_2_apply)));
            sPost += "&applicable_trans_scope=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.applicable_trans_scope)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.plan_no, "&plan_no");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.client_plan_id, "&client_plan_id");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.service_no, "&service_no");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.client_service_id, "&client_service_id");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.item_no, "&item_no");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.client_item_id, "&client_item_id");
            sPost += "&use_all_or_nth_subs_rule=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.use_all_or_nth_subs_rule)));
            
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
            create_discount_ruleResponse myDeserializedObj = json.Deserialize(reader, typeof(create_discount_ruleResponse)) as create_discount_ruleResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public create_discount_bundleResponse create_discount_bundle(create_discount_bundleRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("create_discount_bundle");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&bundle_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bundle_name)));
            sPost += "&bundle_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bundle_id)));
            sPost += "&bundle_description=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bundle_description)));
            sPost += "&allow_overlap_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.allow_overlap_ind)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.rules, "&rules");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.rule_ids, "&rule_ids");
            
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
            create_discount_bundleResponse myDeserializedObj = json.Deserialize(reader, typeof(create_discount_bundleResponse)) as create_discount_bundleResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_discount_bundlesResponse get_discount_bundles(get_discount_bundlesRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_discount_bundles");

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
            get_discount_bundlesResponse myDeserializedObj = json.Deserialize(reader, typeof(get_discount_bundlesResponse)) as get_discount_bundlesResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_discount_bundle_detailsResponse get_discount_bundle_details(get_discount_bundle_detailsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_discount_bundle_details");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&bundle_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bundle_no)));
            sPost += "&bundle_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.bundle_id)));
            
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
            get_discount_bundle_detailsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_discount_bundle_detailsResponse)) as get_discount_bundle_detailsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_discount_rulesResponse get_discount_rules(get_discount_rulesRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_discount_rules");

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
            get_discount_rulesResponse myDeserializedObj = json.Deserialize(reader, typeof(get_discount_rulesResponse)) as get_discount_rulesResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_discount_rule_detailsResponse get_discount_rule_details(get_discount_rule_detailsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_discount_rule_details");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&rule_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.rule_no)));
            sPost += "&client_rule_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_rule_id)));
            
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
            get_discount_rule_detailsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_discount_rule_detailsResponse)) as get_discount_rule_detailsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public delete_rulesResponse delete_rules(delete_rulesRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("delete_rules");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            RestUtilities.addParameterValuesFromArray(ref sPost, request.rule_nos, "&rule_nos");
            
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
            delete_rulesResponse myDeserializedObj = json.Deserialize(reader, typeof(delete_rulesResponse)) as delete_rulesResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public delete_bundlesResponse delete_bundles(delete_bundlesRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("delete_bundles");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            RestUtilities.addParameterValuesFromArray(ref sPost, request.bundle_nos, "&bundle_nos");
            
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
            delete_bundlesResponse myDeserializedObj = json.Deserialize(reader, typeof(delete_bundlesResponse)) as delete_bundlesResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_plansResponse get_plans(get_plansRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_plans");

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
            get_plansResponse myDeserializedObj = json.Deserialize(reader, typeof(get_plansResponse)) as get_plansResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_plan_detailsResponse get_plan_details(get_plan_detailsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_plan_details");

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
            get_plan_detailsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_plan_detailsResponse)) as get_plan_detailsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public create_new_planResponse create_new_plan(create_new_planRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("create_new_plan");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&plan_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.plan_name)));
            sPost += "&plan_description=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.plan_description)));
            sPost += "&plan_type=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.plan_type)));
            sPost += "&currency=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.currency)));
            sPost += "&billing_interval=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.billing_interval)));
            sPost += "&client_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_plan_id)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.plan_group, "&plan_group");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.plan_group_id, "&plan_group_id");
            sPost += "&usage_billing_interval=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.usage_billing_interval)));
            sPost += "&active=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.active)));
            sPost += "&rollover_months=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.rollover_months)));
            sPost += "&rollover_plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.rollover_plan_no)));
            sPost += "&rollover_client_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.rollover_client_plan_id)));
            sPost += "&initial_free_months=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.initial_free_months)));
            sPost += "&acct_status_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_status_cd)));
            sPost += "&rollover_status_days=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.rollover_status_days)));
            sPost += "&rollover_status_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.rollover_status_cd)));
            sPost += "&dunning_plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.dunning_plan_no)));
            sPost += "&dunning_client_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.dunning_client_plan_id)));
            sPost += "&template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.template_no)));
            sPost += "&client_email_template_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_email_template_id)));
            sPost += "&apply_cancellation=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.apply_cancellation)));
            sPost += "&plan_cancel_min_month=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.plan_cancel_min_month)));
            sPost += "&apply_minimum_fee=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.apply_minimum_fee)));
            sPost += "&how_to_apply_minimum_fee=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.how_to_apply_minimum_fee)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.schedule, "&schedule");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.service, "&service");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.resource, "&resource");
            sPost += "&arc_service_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.arc_service_no)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.parent_plans, "&parent_plans");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.parent_client_plan_ids, "&parent_client_plan_ids");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.exclusion_plans, "&exclusion_plans");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.supplemental_obj_field, "&supplemental_obj_field");
            sPost += "&template_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.template_ind)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.child_plans, "&child_plans");
            sPost += "&notification_template_group_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.notification_template_group_no)));
            sPost += "&credit_note_template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.credit_note_template_no)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.surcharge_no, "&surcharge_no");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.client_surcharge_id, "&client_surcharge_id");
            
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
            create_new_planResponse myDeserializedObj = json.Deserialize(reader, typeof(create_new_planResponse)) as create_new_planResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public edit_planResponse edit_plan(edit_planRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("edit_plan");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.plan_no)));
            sPost += "&plan_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.plan_name)));
            sPost += "&client_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_plan_id)));
            sPost += "&plan_type=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.plan_type)));
            sPost += "&billing_interval=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.billing_interval)));
            sPost += "&currency=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.currency)));
            sPost += "&plan_description=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.plan_description)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.plan_group, "&plan_group");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.plan_group_id, "&plan_group_id");
            sPost += "&active=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.active)));
            sPost += "&usage_billing_interval=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.usage_billing_interval)));
            sPost += "&template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.template_no)));
            sPost += "&client_email_template_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_email_template_id)));
            sPost += "&rollover_months=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.rollover_months)));
            sPost += "&rollover_plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.rollover_plan_no)));
            sPost += "&rollover_client_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.rollover_client_plan_id)));
            sPost += "&dunning_plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.dunning_plan_no)));
            sPost += "&dunning_client_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.dunning_client_plan_id)));
            sPost += "&initial_free_months=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.initial_free_months)));
            sPost += "&acct_status_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.acct_status_cd)));
            sPost += "&rollover_status_days=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.rollover_status_days)));
            sPost += "&rollover_status_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.rollover_status_cd)));
            sPost += "&allow_child_accts=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.allow_child_accts)));
            sPost += "&apply_cancellation=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.apply_cancellation)));
            sPost += "&plan_cancel_min_month=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.plan_cancel_min_month)));
            sPost += "&apply_minimum_fee=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.apply_minimum_fee)));
            sPost += "&how_to_apply_minimum_fee=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.how_to_apply_minimum_fee)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.schedule, "&schedule");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.service, "&service");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.resource, "&resource");
            sPost += "&arc_service_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.arc_service_no)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.parent_plans, "&parent_plans");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.parent_client_plan_ids, "&parent_client_plan_ids");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.exclusion_plans, "&exclusion_plans");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.supplemental_obj_field, "&supplemental_obj_field");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.child_plans, "&child_plans");
            sPost += "&notification_template_group_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.notification_template_group_no)));
            sPost += "&credit_note_template_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.credit_note_template_no)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.surcharge_no, "&surcharge_no");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.client_surcharge_id, "&client_surcharge_id");
            
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
            edit_planResponse myDeserializedObj = json.Deserialize(reader, typeof(edit_planResponse)) as edit_planResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public delete_plansResponse delete_plans(delete_plansRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("delete_plans");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            RestUtilities.addParameterValuesFromArray(ref sPost, request.plan_nos, "&plan_nos");
            
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
            delete_plansResponse myDeserializedObj = json.Deserialize(reader, typeof(delete_plansResponse)) as delete_plansResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public copy_planResponse copy_plan(copy_planRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("copy_plan");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&plan_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.plan_no)));
            sPost += "&client_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_plan_id)));
            sPost += "&plan_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.plan_name)));
            sPost += "&new_client_plan_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.new_client_plan_id)));
            
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
            copy_planResponse myDeserializedObj = json.Deserialize(reader, typeof(copy_planResponse)) as copy_planResponse;
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

        public update_supplemental_planResponse update_supplemental_plan(update_supplemental_planRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("update_supplemental_plan");

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
            update_supplemental_planResponse myDeserializedObj = json.Deserialize(reader, typeof(update_supplemental_planResponse)) as update_supplemental_planResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_promotionsResponse get_promotions(get_promotionsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_promotions");

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
            get_promotionsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_promotionsResponse)) as get_promotionsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_promotion_detailsResponse get_promotion_details(get_promotion_detailsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_promotion_details");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&promo_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.promo_cd)));
            
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
            get_promotion_detailsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_promotion_detailsResponse)) as get_promotion_detailsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public create_promotionResponse create_promotion(create_promotionRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("create_promotion");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&promo_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.promo_cd)));
            sPost += "&promo_desc=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.promo_desc)));
            sPost += "&promo_plan_set_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.promo_plan_set_no)));
            sPost += "&no_of_uses=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.no_of_uses)));
            sPost += "&start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.start_date)));
            sPost += "&exp_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.exp_date)));
            
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
            create_promotionResponse myDeserializedObj = json.Deserialize(reader, typeof(create_promotionResponse)) as create_promotionResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public update_promotionResponse update_promotion(update_promotionRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("update_promotion");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&promo_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.promo_cd)));
            sPost += "&promo_desc=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.promo_desc)));
            sPost += "&promo_plan_set_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.promo_plan_set_no)));
            sPost += "&no_of_uses=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.no_of_uses)));
            sPost += "&start_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.start_date)));
            sPost += "&exp_date=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.exp_date)));
            
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
            update_promotionResponse myDeserializedObj = json.Deserialize(reader, typeof(update_promotionResponse)) as update_promotionResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_usage_typesResponse get_usage_types(get_usage_typesRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_usage_types");

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
            get_usage_typesResponse myDeserializedObj = json.Deserialize(reader, typeof(get_usage_typesResponse)) as get_usage_typesResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_usage_type_detailsResponse get_usage_type_details(get_usage_type_detailsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_usage_type_details");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&usage_type_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.usage_type_no)));
            
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
            get_usage_type_detailsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_usage_type_detailsResponse)) as get_usage_type_detailsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_usage_unit_typesResponse get_usage_unit_types(get_usage_unit_typesRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_usage_unit_types");

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
            get_usage_unit_typesResponse myDeserializedObj = json.Deserialize(reader, typeof(get_usage_unit_typesResponse)) as get_usage_unit_typesResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public create_usage_typeResponse create_usage_type(create_usage_typeRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("create_usage_type");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&usage_type_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.usage_type_name)));
            sPost += "&usage_type_desc=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.usage_type_desc)));
            sPost += "&usage_unit_type_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.usage_unit_type_no)));
            sPost += "&usage_type_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.usage_type_code)));
            sPost += "&usage_type_display_string=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.usage_type_display_string)));
            
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
            create_usage_typeResponse myDeserializedObj = json.Deserialize(reader, typeof(create_usage_typeResponse)) as create_usage_typeResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public update_usage_typeResponse update_usage_type(update_usage_typeRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("update_usage_type");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&usage_type_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.usage_type_no)));
            sPost += "&usage_type_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.usage_type_name)));
            sPost += "&usage_type_desc=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.usage_type_desc)));
            sPost += "&usage_unit_type_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.usage_unit_type_no)));
            sPost += "&usage_type_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.usage_type_code)));
            sPost += "&usage_type_display_string=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.usage_type_display_string)));
            
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
            update_usage_typeResponse myDeserializedObj = json.Deserialize(reader, typeof(update_usage_typeResponse)) as update_usage_typeResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public create_supp_obj_fieldResponse create_supp_obj_field(create_supp_obj_fieldRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("create_supp_obj_field");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&field_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.field_name)));
            sPost += "&description=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.description)));
            sPost += "&min_no_sel=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.min_no_sel)));
            sPost += "&max_no_sel=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.max_no_sel)));
            sPost += "&datatype=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.datatype)));
            sPost += "&form_input_type=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.form_input_type)));
            sPost += "&use_allowed_vals_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.use_allowed_vals_ind)));
            sPost += "&option_value=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.option_value)));
            sPost += "&option_value_order=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.option_value_order)));
            
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
            create_supp_obj_fieldResponse myDeserializedObj = json.Deserialize(reader, typeof(create_supp_obj_fieldResponse)) as create_supp_obj_fieldResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public update_supp_obj_fieldResponse update_supp_obj_field(update_supp_obj_fieldRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("update_supp_obj_field");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&field_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.field_no)));
            sPost += "&field_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.field_name)));
            sPost += "&description=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.description)));
            sPost += "&min_no_sel=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.min_no_sel)));
            sPost += "&max_no_sel=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.max_no_sel)));
            sPost += "&datatype=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.datatype)));
            sPost += "&form_input_type=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.form_input_type)));
            sPost += "&use_allowed_vals_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.use_allowed_vals_ind)));
            sPost += "&option_value=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.option_value)));
            sPost += "&option_value_order=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.option_value_order)));
            
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
            update_supp_obj_fieldResponse myDeserializedObj = json.Deserialize(reader, typeof(update_supp_obj_fieldResponse)) as update_supp_obj_fieldResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_supp_obj_fieldsResponse get_supp_obj_fields(get_supp_obj_fieldsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_supp_obj_fields");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&field_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.field_no)));
            
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
            get_supp_obj_fieldsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_supp_obj_fieldsResponse)) as get_supp_obj_fieldsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_plan_groupsResponse get_plan_groups(get_plan_groupsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_plan_groups");

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
            get_plan_groupsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_plan_groupsResponse)) as get_plan_groupsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_plan_group_detailsResponse get_plan_group_details(get_plan_group_detailsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_plan_group_details");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&group_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.group_no)));
            sPost += "&client_plan_change_group_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_plan_change_group_id)));
            
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
            get_plan_group_detailsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_plan_group_detailsResponse)) as get_plan_group_detailsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public create_plan_groupResponse create_plan_group(create_plan_groupRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("create_plan_group");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&group_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.group_name)));
            sPost += "&group_desc=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.group_desc)));
            sPost += "&group_usage=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.group_usage)));
            sPost += "&client_plan_change_group_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_plan_change_group_id)));
            sPost += "&group_plans=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.group_plans)));
            sPost += "&group_plan_ids=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.group_plan_ids)));
            
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
            create_plan_groupResponse myDeserializedObj = json.Deserialize(reader, typeof(create_plan_groupResponse)) as create_plan_groupResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public update_plan_groupResponse update_plan_group(update_plan_groupRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("update_plan_group");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&group_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.group_no)));
            sPost += "&group_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.group_name)));
            sPost += "&group_desc=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.group_desc)));
            sPost += "&group_usage=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.group_usage)));
            sPost += "&client_plan_change_group_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_plan_change_group_id)));
            sPost += "&group_plans=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.group_plans)));
            sPost += "&group_plan_ids=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.group_plan_ids)));
            
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
            update_plan_groupResponse myDeserializedObj = json.Deserialize(reader, typeof(update_plan_groupResponse)) as update_plan_groupResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public delete_plan_groupResponse delete_plan_group(delete_plan_groupRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("delete_plan_group");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&group_list=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.group_list)));
            
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
            delete_plan_groupResponse myDeserializedObj = json.Deserialize(reader, typeof(delete_plan_groupResponse)) as delete_plan_groupResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public list_coaResponse list_coa(list_coaRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("list_coa");

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
            list_coaResponse myDeserializedObj = json.Deserialize(reader, typeof(list_coaResponse)) as list_coaResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public add_coaResponse add_coa(add_coaRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("add_coa");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&coa_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.coa_code)));
            sPost += "&coa_description=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.coa_description)));
            
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
            add_coaResponse myDeserializedObj = json.Deserialize(reader, typeof(add_coaResponse)) as add_coaResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_coaResponse get_coa(get_coaRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_coa");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&coa_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.coa_id)));
            
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
            get_coaResponse myDeserializedObj = json.Deserialize(reader, typeof(get_coaResponse)) as get_coaResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public edit_coaResponse edit_coa(edit_coaRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("edit_coa");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&coa_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.coa_id)));
            sPost += "&coa_code=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.coa_code)));
            sPost += "&coa_description=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.coa_description)));
            
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
            edit_coaResponse myDeserializedObj = json.Deserialize(reader, typeof(edit_coaResponse)) as edit_coaResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_surchargesResponse get_surcharges(get_surchargesRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_surcharges");

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
            get_surchargesResponse myDeserializedObj = json.Deserialize(reader, typeof(get_surchargesResponse)) as get_surchargesResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_surcharge_detailsResponse get_surcharge_details(get_surcharge_detailsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_surcharge_details");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&surcharge_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.surcharge_no)));
            sPost += "&client_surcharge_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_surcharge_id)));
            
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
            get_surcharge_detailsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_surcharge_detailsResponse)) as get_surcharge_detailsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public create_surchargeResponse create_surcharge(create_surchargeRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("create_surcharge");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&surcharge_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.surcharge_name)));
            sPost += "&description=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.description)));
            sPost += "&ext_description=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.ext_description)));
            sPost += "&currency_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.currency_cd)));
            sPost += "&surcharge_type_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.surcharge_type_cd)));
            sPost += "&inline_offset_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.inline_offset_ind)));
            sPost += "&apply_b4_or_after_discount_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.apply_b4_or_after_discount_cd)));
            sPost += "&scope_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.scope_no)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.surcharge_tier, "&surcharge_tier");
            sPost += "&client_surcharge_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_surcharge_id)));
            sPost += "&apply_to_zero_invoice_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.apply_to_zero_invoice_ind)));
            sPost += "&tax_group=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.tax_group)));
            sPost += "&gl_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.gl_cd)));
            sPost += "&ar_gl_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.ar_gl_cd)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.plan_no, "&plan_no");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.client_plan_id, "&client_plan_id");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.service_no, "&service_no");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.client_service_id, "&client_service_id");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.item_no, "&item_no");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.client_item_id, "&client_item_id");
            
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
            create_surchargeResponse myDeserializedObj = json.Deserialize(reader, typeof(create_surchargeResponse)) as create_surchargeResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public edit_surchargeResponse edit_surcharge(edit_surchargeRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("edit_surcharge");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            sPost += "&surcharge_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.surcharge_no)));
            sPost += "&surcharge_name=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.surcharge_name)));
            sPost += "&client_surcharge_id=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_surcharge_id)));
            sPost += "&description=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.description)));
            sPost += "&ext_description=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.ext_description)));
            sPost += "&currency_cd=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.currency_cd)));
            sPost += "&scope_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.scope_no)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.surcharge_tier, "&surcharge_tier");
            sPost += "&apply_to_zero_invoice_ind=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.apply_to_zero_invoice_ind)));
            RestUtilities.addParameterValuesFromArray(ref sPost, request.plan_no, "&plan_no");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.client_plan_id, "&client_plan_id");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.service_no, "&service_no");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.client_service_id, "&client_service_id");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.item_no, "&item_no");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.client_item_id, "&client_item_id");
            
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
            edit_surchargeResponse myDeserializedObj = json.Deserialize(reader, typeof(edit_surchargeResponse)) as edit_surchargeResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public delete_surchargeResponse delete_surcharge(delete_surchargeRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("delete_surcharge");

            string sPost = "";

            sPost += "&client_no=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.client_no)));
            sPost += "&auth_key=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(request.auth_key)));

            RestUtilities.addParameterValuesFromArray(ref sPost, request.surcharge_no, "&surcharge_no");
            RestUtilities.addParameterValuesFromArray(ref sPost, request.client_surcharge_id, "&client_surcharge_id");
            
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
            delete_surchargeResponse myDeserializedObj = json.Deserialize(reader, typeof(delete_surchargeResponse)) as delete_surchargeResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public validate_admin_sessionResponse validate_admin_session(validate_admin_sessionRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("validate_admin_session");

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
            validate_admin_sessionResponse myDeserializedObj = json.Deserialize(reader, typeof(validate_admin_sessionResponse)) as validate_admin_sessionResponse;
            reader.Close();
            return myDeserializedObj;
        }

        #endregion Api Calls
    }
}
