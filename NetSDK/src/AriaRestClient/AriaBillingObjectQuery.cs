using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using Aria.SDK.AriaServices.AriaWebServices.AriaObjectQuery;

namespace Aria.SDK.AriaServices.AriaWebServices
{
    public class AriaBillingObjectQuery : AriaBillingBase
    {
        #region Constructor
        /*Creates a new AriaBillingObjectQuery with no parms*/
        public AriaBillingObjectQuery() : base ("https://secure.unstable.qa.ariasystems.net/api/AriaQuery/objects.php")
        {
        }
        /*Creates a new AriaBillingObjectQuery with URL parm*/
        public AriaBillingObjectQuery(String URL) : base (URL)
        {
        }
        #endregion Constructor

        #region Api Calls
        public get_account_detailsResponse get_account_details(get_account_detailsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_account_details");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&query_string=" + request.query_string;
            url += "&limit=" + request.limit;
            url += "&offset=" + request.offset;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
                          {
                              NullValueHandling = NullValueHandling.Ignore,
                              ObjectCreationHandling = ObjectCreationHandling.Replace,
                              MissingMemberHandling = MissingMemberHandling.Ignore,
                              ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                          };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_account_detailsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_account_detailsResponse)) as get_account_detailsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_account_status_historyResponse get_account_status_history(get_account_status_historyRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_account_status_history");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&query_string=" + request.query_string;
            url += "&limit=" + request.limit;
            url += "&offset=" + request.offset;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
                          {
                              NullValueHandling = NullValueHandling.Ignore,
                              ObjectCreationHandling = ObjectCreationHandling.Replace,
                              MissingMemberHandling = MissingMemberHandling.Ignore,
                              ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                          };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_account_status_historyResponse myDeserializedObj = json.Deserialize(reader, typeof(get_account_status_historyResponse)) as get_account_status_historyResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_account_plan_historyResponse get_account_plan_history(get_account_plan_historyRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_account_plan_history");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&query_string=" + request.query_string;
            url += "&limit=" + request.limit;
            url += "&offset=" + request.offset;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
                          {
                              NullValueHandling = NullValueHandling.Ignore,
                              ObjectCreationHandling = ObjectCreationHandling.Replace,
                              MissingMemberHandling = MissingMemberHandling.Ignore,
                              ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                          };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_account_plan_historyResponse myDeserializedObj = json.Deserialize(reader, typeof(get_account_plan_historyResponse)) as get_account_plan_historyResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_payment_detailsResponse get_payment_details(get_payment_detailsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_payment_details");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&query_string=" + request.query_string;
            url += "&limit=" + request.limit;
            url += "&offset=" + request.offset;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
                          {
                              NullValueHandling = NullValueHandling.Ignore,
                              ObjectCreationHandling = ObjectCreationHandling.Replace,
                              MissingMemberHandling = MissingMemberHandling.Ignore,
                              ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                          };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_payment_detailsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_payment_detailsResponse)) as get_payment_detailsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_order_detailsResponse get_order_details(get_order_detailsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_order_details");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&query_string=" + request.query_string;
            url += "&limit=" + request.limit;
            url += "&offset=" + request.offset;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
                          {
                              NullValueHandling = NullValueHandling.Ignore,
                              ObjectCreationHandling = ObjectCreationHandling.Replace,
                              MissingMemberHandling = MissingMemberHandling.Ignore,
                              ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                          };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_order_detailsResponse myDeserializedObj = json.Deserialize(reader, typeof(get_order_detailsResponse)) as get_order_detailsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_invoice_informationResponse get_invoice_information(get_invoice_informationRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_invoice_information");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&query_string=" + request.query_string;
            url += "&limit=" + request.limit;
            url += "&offset=" + request.offset;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
                          {
                              NullValueHandling = NullValueHandling.Ignore,
                              ObjectCreationHandling = ObjectCreationHandling.Replace,
                              MissingMemberHandling = MissingMemberHandling.Ignore,
                              ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                          };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_invoice_informationResponse myDeserializedObj = json.Deserialize(reader, typeof(get_invoice_informationResponse)) as get_invoice_informationResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_transaction_informationResponse get_transaction_information(get_transaction_informationRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_transaction_information");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&query_string=" + request.query_string;
            url += "&limit=" + request.limit;
            url += "&offset=" + request.offset;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
                          {
                              NullValueHandling = NullValueHandling.Ignore,
                              ObjectCreationHandling = ObjectCreationHandling.Replace,
                              MissingMemberHandling = MissingMemberHandling.Ignore,
                              ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                          };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_transaction_informationResponse myDeserializedObj = json.Deserialize(reader, typeof(get_transaction_informationResponse)) as get_transaction_informationResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_refund_informationResponse get_refund_information(get_refund_informationRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_refund_information");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&query_string=" + request.query_string;
            url += "&limit=" + request.limit;
            url += "&offset=" + request.offset;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
                          {
                              NullValueHandling = NullValueHandling.Ignore,
                              ObjectCreationHandling = ObjectCreationHandling.Replace,
                              MissingMemberHandling = MissingMemberHandling.Ignore,
                              ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                          };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_refund_informationResponse myDeserializedObj = json.Deserialize(reader, typeof(get_refund_informationResponse)) as get_refund_informationResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_coupon_historyResponse get_coupon_history(get_coupon_historyRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_coupon_history");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&query_string=" + request.query_string;
            url += "&limit=" + request.limit;
            url += "&offset=" + request.offset;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
                          {
                              NullValueHandling = NullValueHandling.Ignore,
                              ObjectCreationHandling = ObjectCreationHandling.Replace,
                              MissingMemberHandling = MissingMemberHandling.Ignore,
                              ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                          };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_coupon_historyResponse myDeserializedObj = json.Deserialize(reader, typeof(get_coupon_historyResponse)) as get_coupon_historyResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public list_transaction_typesResponse list_transaction_types(list_transaction_typesRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("list_transaction_types");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&limit=" + request.limit;
            url += "&offset=" + request.offset;
            url += "&query_string=" + request.query_string;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
                          {
                              NullValueHandling = NullValueHandling.Ignore,
                              ObjectCreationHandling = ObjectCreationHandling.Replace,
                              MissingMemberHandling = MissingMemberHandling.Ignore,
                              ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                          };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            list_transaction_typesResponse myDeserializedObj = json.Deserialize(reader, typeof(list_transaction_typesResponse)) as list_transaction_typesResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public list_payment_methodsResponse list_payment_methods(list_payment_methodsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("list_payment_methods");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&limit=" + request.limit;
            url += "&offset=" + request.offset;
            url += "&query_string=" + request.query_string;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
                          {
                              NullValueHandling = NullValueHandling.Ignore,
                              ObjectCreationHandling = ObjectCreationHandling.Replace,
                              MissingMemberHandling = MissingMemberHandling.Ignore,
                              ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                          };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            list_payment_methodsResponse myDeserializedObj = json.Deserialize(reader, typeof(list_payment_methodsResponse)) as list_payment_methodsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public list_payment_processorsResponse list_payment_processors(list_payment_processorsRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("list_payment_processors");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&limit=" + request.limit;
            url += "&offset=" + request.offset;
            url += "&query_string=" + request.query_string;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
                          {
                              NullValueHandling = NullValueHandling.Ignore,
                              ObjectCreationHandling = ObjectCreationHandling.Replace,
                              MissingMemberHandling = MissingMemberHandling.Ignore,
                              ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                          };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            list_payment_processorsResponse myDeserializedObj = json.Deserialize(reader, typeof(list_payment_processorsResponse)) as list_payment_processorsResponse;
            reader.Close();
            return myDeserializedObj;
        }

        public get_all_invoice_informationResponse get_all_invoice_information(get_all_invoice_informationRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("get_all_invoice_information");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&query_string=" + request.query_string;
            url += "&limit=" + request.limit;
            url += "&offset=" + request.offset;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
            JsonSerializer json = new JsonSerializer
                          {
                              NullValueHandling = NullValueHandling.Ignore,
                              ObjectCreationHandling = ObjectCreationHandling.Replace,
                              MissingMemberHandling = MissingMemberHandling.Ignore,
                              ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                          };
            StringReader sr = new StringReader(returnString);
            JsonTextReader reader = new JsonTextReader(sr);
            get_all_invoice_informationResponse myDeserializedObj = json.Deserialize(reader, typeof(get_all_invoice_informationResponse)) as get_all_invoice_informationResponse;
            reader.Close();
            return myDeserializedObj;
        }

        #endregion Api Calls
    }
}
