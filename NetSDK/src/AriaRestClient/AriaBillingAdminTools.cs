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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&promo_plan_set_no=" + request.promo_plan_set_no;
            url += "&client_plan_type_id=" + request.client_plan_type_id;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&promo_plan_set_name=" + request.promo_plan_set_name;
            url += "&promo_plan_set_desc=" + request.promo_plan_set_desc;
            url += "&client_plan_type_id=" + request.client_plan_type_id;
            url += "&plan_no=" + request.plan_no;
            url += "&client_plan_id=" + request.client_plan_id;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&promo_plan_set_no=" + request.promo_plan_set_no;
            url += "&promo_plan_set_name=" + request.promo_plan_set_name;
            url += "&promo_plan_set_desc=" + request.promo_plan_set_desc;
            url += "&client_plan_type_id=" + request.client_plan_type_id;
            url += "&plan_no=" + request.plan_no;
            url += "&client_plan_id=" + request.client_plan_id;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&domain=" + request.domain;
            url += "&address1=" + request.address1;
            url += "&address2=" + request.address2;
            url += "&city=" + request.city;
            url += "&locality=" + request.locality;
            url += "&state_prov=" + request.state_prov;
            url += "&country=" + request.country;
            url += "&postal_code=" + request.postal_code;
            url += "&phone=" + request.phone;
            url += "&contact=" + request.contact;
            url += "&contact_address1=" + request.contact_address1;
            url += "&contact_address2=" + request.contact_address2;
            url += "&contact_city=" + request.contact_city;
            url += "&contact_state=" + request.contact_state;
            url += "&contact_zip=" + request.contact_zip;
            url += "&contact_phone=" + request.contact_phone;
            url += "&contact_email=" + request.contact_email;
            url += "&billing_contact=" + request.billing_contact;
            url += "&billing_address1=" + request.billing_address1;
            url += "&billing_address2=" + request.billing_address2;
            url += "&billing_city=" + request.billing_city;
            url += "&billing_state=" + request.billing_state;
            url += "&billing_zip=" + request.billing_zip;
            url += "&billing_phone=" + request.billing_phone;
            url += "&billing_email=" + request.billing_email;
            url += "&contact_country=" + request.contact_country;
            url += "&contact_locality=" + request.contact_locality;
            url += "&billing_country=" + request.billing_country;
            url += "&billing_locality=" + request.billing_locality;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&item_no=" + request.item_no;
            url += "&client_item_id=" + request.client_item_id;
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&item_type=" + request.item_type;
            url += "&item_name=" + request.item_name;
            url += "&item_desc=" + request.item_desc;
            RestUtilities.addParameterValuesFromArray(ref url, request.service, "&service");
            url += "&client_sku=" + request.client_sku;
            url += "&currency_cd=" + request.currency_cd;
            url += "&item_price=" + request.item_price;
            url += "&client_item_id=" + request.client_item_id;
            url += "&active_ind=" + request.active_ind;
            url += "&invoice_advancement_months=" + request.invoice_advancement_months;
            url += "&plan_no=" + request.plan_no;
            url += "&client_plan_id=" + request.client_plan_id;
            url += "&tax_inclusive_ind=" + request.tax_inclusive_ind;
            url += "&modify_price_ind=" + request.modify_price_ind;
            url += "&subunit_qty=" + request.subunit_qty;
            url += "&subunit_label=" + request.subunit_label;
            url += "&days_to_expiry=" + request.days_to_expiry;
            url += "&resource_type_no=" + request.resource_type_no;
            url += "&resource_units=" + request.resource_units;
            url += "&stock_level_track=" + request.stock_level_track;
            url += "&stock_level_adjust=" + request.stock_level_adjust;
            RestUtilities.addParameterValuesFromArray(ref url, request.image, "&image");
            RestUtilities.addParameterValuesFromArray(ref url, request.parent_class, "&parent_class");
            RestUtilities.addParameterValuesFromArray(ref url, request.supplemental_obj_field, "&supplemental_obj_field");
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&item_no=" + request.item_no;
            url += "&item_name=" + request.item_name;
            url += "&item_desc=" + request.item_desc;
            url += "&client_item_id=" + request.client_item_id;
            url += "&service_no=" + request.service_no;
            url += "&client_service_id=" + request.client_service_id;
            url += "&currency_cd=" + request.currency_cd;
            url += "&item_price=" + request.item_price;
            url += "&active_ind=" + request.active_ind;
            url += "&invoice_advancement_months=" + request.invoice_advancement_months;
            url += "&plan_no=" + request.plan_no;
            url += "&client_plan_id=" + request.client_plan_id;
            url += "&modify_price_ind=" + request.modify_price_ind;
            url += "&subunit_qty=" + request.subunit_qty;
            url += "&subunit_label=" + request.subunit_label;
            url += "&days_to_expiry=" + request.days_to_expiry;
            url += "&resource_type_no=" + request.resource_type_no;
            url += "&resource_units=" + request.resource_units;
            url += "&stock_level_track=" + request.stock_level_track;
            url += "&stock_level_adjust=" + request.stock_level_adjust;
            RestUtilities.addParameterValuesFromArray(ref url, request.image, "&image");
            RestUtilities.addParameterValuesFromArray(ref url, request.parent_class, "&parent_class");
            RestUtilities.addParameterValuesFromArray(ref url, request.supplemental_obj_field, "&supplemental_obj_field");
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&class_name=" + request.class_name;
            url += "&class_desc=" + request.class_desc;
            url += "&active_ind=" + request.active_ind;
            url += "&client_inventory_class_id=" + request.client_inventory_class_id;
            RestUtilities.addParameterValuesFromArray(ref url, request.parent_class, "&parent_class");
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&class_no=" + request.class_no;
            url += "&class_name=" + request.class_name;
            url += "&client_inventory_class_id=" + request.client_inventory_class_id;
            url += "&class_desc=" + request.class_desc;
            url += "&active_ind=" + request.active_ind;
            RestUtilities.addParameterValuesFromArray(ref url, request.parent_class, "&parent_class");
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&service_no=" + request.service_no;
            url += "&client_service_id=" + request.client_service_id;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&service_no=" + request.service_no;
            url += "&client_service_id=" + request.client_service_id;
            url += "&plan_no=" + request.plan_no;
            url += "&client_plan_id=" + request.client_plan_id;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&service_name=" + request.service_name;
            url += "&service_type=" + request.service_type;
            url += "&gl_cd=" + request.gl_cd;
            url += "&taxable_ind=" + request.taxable_ind;
            url += "&tax_group=" + request.tax_group;
            url += "&usage_type=" + request.usage_type;
            url += "&client_service_id=" + request.client_service_id;
            RestUtilities.addParameterValuesFromArray(ref url, request.supplemental_obj_field, "&supplemental_obj_field");
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&service_no=" + request.service_no;
            url += "&service_name=" + request.service_name;
            url += "&service_type=" + request.service_type;
            url += "&client_service_id=" + request.client_service_id;
            url += "&gl_cd=" + request.gl_cd;
            url += "&taxable_ind=" + request.taxable_ind;
            url += "&tax_group=" + request.tax_group;
            url += "&usage_type=" + request.usage_type;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&field_name=" + request.field_name;
            url += "&field_order=" + request.field_order;
            url += "&presentation_mode=" + request.presentation_mode;
            url += "&field_desc=" + request.field_desc;
            url += "&required_ind=" + request.required_ind;
            url += "&hidden_ind=" + request.hidden_ind;
            url += "&sel_ind=" + request.sel_ind;
            url += "&min_no_sel=" + request.min_no_sel;
            url += "&max_no_sel=" + request.max_no_sel;
            url += "&display_text=" + request.display_text;
            url += "&option_value=" + request.option_value;
            url += "&option_value_order=" + request.option_value_order;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&field_name=" + request.field_name;
            url += "&field_desc=" + request.field_desc;
            url += "&field_order=" + request.field_order;
            url += "&required_ind=" + request.required_ind;
            url += "&hidden_ind=" + request.hidden_ind;
            url += "&sel_ind=" + request.sel_ind;
            url += "&presentation_mode=" + request.presentation_mode;
            url += "&min_no_sel=" + request.min_no_sel;
            url += "&max_no_sel=" + request.max_no_sel;
            url += "&display_text=" + request.display_text;
            url += "&option_value=" + request.option_value;
            url += "&option_value_order=" + request.option_value_order;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
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

        public create_couponResponse create_coupon(create_couponRequest request)
        {
            if (request == null)
            {
                return null;
            }
            var url = buildUrl("create_coupon");

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&coupon_cd=" + request.coupon_cd;
            url += "&status_ind=" + request.status_ind;
            url += "&start_date=" + request.start_date;
            url += "&end_date=" + request.end_date;
            url += "&coupon_desc=" + request.coupon_desc;
            url += "&coupon_msg=" + request.coupon_msg;
            url += "&no_of_uses=" + request.no_of_uses;
            RestUtilities.addParameterValuesFromArray(ref url, request.template, "&template");
            RestUtilities.addParameterValuesFromArray(ref url, request.existing_template, "&existing_template");
            RestUtilities.addParameterValuesFromArray(ref url, request.existing_template_id, "&existing_template_id");
            RestUtilities.addParameterValuesFromArray(ref url, request.discount_rule, "&discount_rule");
            RestUtilities.addParameterValuesFromArray(ref url, request.existing_discount_rule, "&existing_discount_rule");
            RestUtilities.addParameterValuesFromArray(ref url, request.existing_discount_rule_id, "&existing_discount_rule_id");
            RestUtilities.addParameterValuesFromArray(ref url, request.discount_bundle, "&discount_bundle");
            RestUtilities.addParameterValuesFromArray(ref url, request.existing_discount_bundle, "&existing_discount_bundle");
            RestUtilities.addParameterValuesFromArray(ref url, request.existing_discount_bundle_id, "&existing_discount_bundle_id");
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&coupon_cd=" + request.coupon_cd;
            url += "&status_ind=" + request.status_ind;
            url += "&start_date=" + request.start_date;
            url += "&end_date=" + request.end_date;
            url += "&coupon_desc=" + request.coupon_desc;
            url += "&coupon_msg=" + request.coupon_msg;
            url += "&no_of_uses=" + request.no_of_uses;
            RestUtilities.addParameterValuesFromArray(ref url, request.template, "&template");
            RestUtilities.addParameterValuesFromArray(ref url, request.existing_template, "&existing_template");
            RestUtilities.addParameterValuesFromArray(ref url, request.existing_template_id, "&existing_template_id");
            RestUtilities.addParameterValuesFromArray(ref url, request.discount_rule, "&discount_rule");
            RestUtilities.addParameterValuesFromArray(ref url, request.existing_discount_rule, "&existing_discount_rule");
            RestUtilities.addParameterValuesFromArray(ref url, request.existing_discount_rule_id, "&existing_discount_rule_id");
            RestUtilities.addParameterValuesFromArray(ref url, request.discount_bundle, "&discount_bundle");
            RestUtilities.addParameterValuesFromArray(ref url, request.existing_discount_bundle, "&existing_discount_bundle");
            RestUtilities.addParameterValuesFromArray(ref url, request.existing_discount_bundle_id, "&existing_discount_bundle_id");
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            RestUtilities.addParameterValuesFromArray(ref url, request.coupon_nos, "&coupon_nos");
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&credit_template_no=" + request.credit_template_no;
            url += "&client_credit_template_id=" + request.client_credit_template_id;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&credit_template_name=" + request.credit_template_name;
            url += "&discount_type=" + request.discount_type;
            url += "&discount_amt=" + request.discount_amt;
            url += "&no_of_credits=" + request.no_of_credits;
            url += "&credit_interval_months=" + request.credit_interval_months;
            url += "&eligible_plan_no=" + request.eligible_plan_no;
            url += "&eligible_client_plan_id=" + request.eligible_client_plan_id;
            url += "&eligible_service_no=" + request.eligible_service_no;
            url += "&eligible_client_service_id=" + request.eligible_client_service_id;
            RestUtilities.addParameterValuesFromArray(ref url, request.eligible_service_types, "&eligible_service_types");
            url += "&percentage_plan_no=" + request.percentage_plan_no;
            url += "&percentage_client_plan_id=" + request.percentage_client_plan_id;
            url += "&percentage_service_no=" + request.percentage_service_no;
            url += "&percentage_client_service_id=" + request.percentage_client_service_id;
            url += "&alt_service_no=" + request.alt_service_no;
            url += "&alt_client_service_id=" + request.alt_client_service_id;
            url += "&client_credit_template_id=" + request.client_credit_template_id;
            RestUtilities.addParameterValuesFromArray(ref url, request.coupon, "&coupon");
            RestUtilities.addParameterValuesFromArray(ref url, request.existing_coupon, "&existing_coupon");
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&credit_template_no=" + request.credit_template_no;
            url += "&credit_template_name=" + request.credit_template_name;
            url += "&discount_type=" + request.discount_type;
            url += "&discount_amt=" + request.discount_amt;
            url += "&no_of_credits=" + request.no_of_credits;
            url += "&credit_interval_months=" + request.credit_interval_months;
            url += "&client_credit_template_id=" + request.client_credit_template_id;
            url += "&eligible_plan_no=" + request.eligible_plan_no;
            url += "&eligible_client_plan_id=" + request.eligible_client_plan_id;
            url += "&eligible_service_no=" + request.eligible_service_no;
            url += "&eligible_client_service_id=" + request.eligible_client_service_id;
            RestUtilities.addParameterValuesFromArray(ref url, request.eligible_service_types, "&eligible_service_types");
            url += "&percentage_plan_no=" + request.percentage_plan_no;
            url += "&percentage_client_plan_id=" + request.percentage_client_plan_id;
            url += "&percentage_service_no=" + request.percentage_service_no;
            url += "&percentage_client_service_id=" + request.percentage_client_service_id;
            url += "&alt_service_no=" + request.alt_service_no;
            url += "&alt_client_service_id=" + request.alt_client_service_id;
            RestUtilities.addParameterValuesFromArray(ref url, request.coupon, "&coupon");
            RestUtilities.addParameterValuesFromArray(ref url, request.existing_coupon, "&existing_coupon");
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            RestUtilities.addParameterValuesFromArray(ref url, request.template_nos, "&template_nos");
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&label=" + request.label;
            url += "&rule_id=" + request.rule_id;
            url += "&description=" + request.description;
            url += "&ext_description=" + request.ext_description;
            url += "&flat_percent_ind=" + request.flat_percent_ind;
            url += "&amount=" + request.amount;
            url += "&currency=" + request.currency;
            url += "&duration_type_ind=" + request.duration_type_ind;
            url += "&inline_offset_ind=" + request.inline_offset_ind;
            url += "&service_code_to_use=" + request.service_code_to_use;
            url += "&scope_no=" + request.scope_no;
            url += "&max_applicable_months=" + request.max_applicable_months;
            url += "&max_applications_per_acct=" + request.max_applications_per_acct;
            url += "&alt_service_no_2_apply=" + request.alt_service_no_2_apply;
            url += "&alt_service_id_2_apply=" + request.alt_service_id_2_apply;
            url += "&applicable_trans_scope=" + request.applicable_trans_scope;
            RestUtilities.addParameterValuesFromArray(ref url, request.plan_no, "&plan_no");
            RestUtilities.addParameterValuesFromArray(ref url, request.client_plan_id, "&client_plan_id");
            RestUtilities.addParameterValuesFromArray(ref url, request.service_no, "&service_no");
            RestUtilities.addParameterValuesFromArray(ref url, request.client_service_id, "&client_service_id");
            RestUtilities.addParameterValuesFromArray(ref url, request.item_no, "&item_no");
            RestUtilities.addParameterValuesFromArray(ref url, request.client_item_id, "&client_item_id");
            url += "&use_all_or_nth_subs_rule=" + request.use_all_or_nth_subs_rule;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&bundle_name=" + request.bundle_name;
            url += "&bundle_id=" + request.bundle_id;
            url += "&bundle_description=" + request.bundle_description;
            url += "&allow_overlap_ind=" + request.allow_overlap_ind;
            RestUtilities.addParameterValuesFromArray(ref url, request.rules, "&rules");
            RestUtilities.addParameterValuesFromArray(ref url, request.rule_ids, "&rule_ids");
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&bundle_no=" + request.bundle_no;
            url += "&bundle_id=" + request.bundle_id;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&rule_no=" + request.rule_no;
            url += "&client_rule_id=" + request.client_rule_id;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            RestUtilities.addParameterValuesFromArray(ref url, request.rule_nos, "&rule_nos");
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            RestUtilities.addParameterValuesFromArray(ref url, request.bundle_nos, "&bundle_nos");
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&plan_no=" + request.plan_no;
            url += "&client_plan_id=" + request.client_plan_id;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&plan_name=" + request.plan_name;
            url += "&plan_description=" + request.plan_description;
            url += "&plan_type=" + request.plan_type;
            url += "&currency=" + request.currency;
            url += "&billing_interval=" + request.billing_interval;
            url += "&client_plan_id=" + request.client_plan_id;
            RestUtilities.addParameterValuesFromArray(ref url, request.plan_group, "&plan_group");
            RestUtilities.addParameterValuesFromArray(ref url, request.plan_group_id, "&plan_group_id");
            url += "&usage_billing_interval=" + request.usage_billing_interval;
            url += "&active=" + request.active;
            url += "&rollover_months=" + request.rollover_months;
            url += "&rollover_plan_no=" + request.rollover_plan_no;
            url += "&rollover_client_plan_id=" + request.rollover_client_plan_id;
            url += "&initial_free_months=" + request.initial_free_months;
            url += "&acct_status_cd=" + request.acct_status_cd;
            url += "&rollover_status_days=" + request.rollover_status_days;
            url += "&rollover_status_cd=" + request.rollover_status_cd;
            url += "&dunning_plan_no=" + request.dunning_plan_no;
            url += "&dunning_client_plan_id=" + request.dunning_client_plan_id;
            url += "&template_no=" + request.template_no;
            url += "&client_email_template_id=" + request.client_email_template_id;
            url += "&apply_cancellation=" + request.apply_cancellation;
            url += "&plan_cancel_min_month=" + request.plan_cancel_min_month;
            url += "&apply_minimum_fee=" + request.apply_minimum_fee;
            url += "&how_to_apply_minimum_fee=" + request.how_to_apply_minimum_fee;
            RestUtilities.addParameterValuesFromArray(ref url, request.schedule, "&schedule");
            RestUtilities.addParameterValuesFromArray(ref url, request.service, "&service");
            RestUtilities.addParameterValuesFromArray(ref url, request.resource, "&resource");
            url += "&arc_service_no=" + request.arc_service_no;
            RestUtilities.addParameterValuesFromArray(ref url, request.parent_plans, "&parent_plans");
            RestUtilities.addParameterValuesFromArray(ref url, request.parent_client_plan_ids, "&parent_client_plan_ids");
            RestUtilities.addParameterValuesFromArray(ref url, request.exclusion_plans, "&exclusion_plans");
            RestUtilities.addParameterValuesFromArray(ref url, request.supplemental_obj_field, "&supplemental_obj_field");
            url += "&template_ind=" + request.template_ind;
            RestUtilities.addParameterValuesFromArray(ref url, request.child_plans, "&child_plans");
            url += "&notification_template_group_no=" + request.notification_template_group_no;
            url += "&credit_note_template_no=" + request.credit_note_template_no;
            RestUtilities.addParameterValuesFromArray(ref url, request.surcharge_no, "&surcharge_no");
            RestUtilities.addParameterValuesFromArray(ref url, request.client_surcharge_id, "&client_surcharge_id");
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&plan_no=" + request.plan_no;
            url += "&plan_name=" + request.plan_name;
            url += "&client_plan_id=" + request.client_plan_id;
            url += "&plan_type=" + request.plan_type;
            url += "&billing_interval=" + request.billing_interval;
            url += "&currency=" + request.currency;
            url += "&plan_description=" + request.plan_description;
            RestUtilities.addParameterValuesFromArray(ref url, request.plan_group, "&plan_group");
            RestUtilities.addParameterValuesFromArray(ref url, request.plan_group_id, "&plan_group_id");
            url += "&active=" + request.active;
            url += "&usage_billing_interval=" + request.usage_billing_interval;
            url += "&template_no=" + request.template_no;
            url += "&client_email_template_id=" + request.client_email_template_id;
            url += "&rollover_months=" + request.rollover_months;
            url += "&rollover_plan_no=" + request.rollover_plan_no;
            url += "&rollover_client_plan_id=" + request.rollover_client_plan_id;
            url += "&dunning_plan_no=" + request.dunning_plan_no;
            url += "&dunning_client_plan_id=" + request.dunning_client_plan_id;
            url += "&initial_free_months=" + request.initial_free_months;
            url += "&acct_status_cd=" + request.acct_status_cd;
            url += "&rollover_status_days=" + request.rollover_status_days;
            url += "&rollover_status_cd=" + request.rollover_status_cd;
            url += "&allow_child_accts=" + request.allow_child_accts;
            url += "&apply_cancellation=" + request.apply_cancellation;
            url += "&plan_cancel_min_month=" + request.plan_cancel_min_month;
            url += "&apply_minimum_fee=" + request.apply_minimum_fee;
            url += "&how_to_apply_minimum_fee=" + request.how_to_apply_minimum_fee;
            RestUtilities.addParameterValuesFromArray(ref url, request.schedule, "&schedule");
            RestUtilities.addParameterValuesFromArray(ref url, request.service, "&service");
            RestUtilities.addParameterValuesFromArray(ref url, request.resource, "&resource");
            url += "&arc_service_no=" + request.arc_service_no;
            RestUtilities.addParameterValuesFromArray(ref url, request.parent_plans, "&parent_plans");
            RestUtilities.addParameterValuesFromArray(ref url, request.parent_client_plan_ids, "&parent_client_plan_ids");
            RestUtilities.addParameterValuesFromArray(ref url, request.exclusion_plans, "&exclusion_plans");
            RestUtilities.addParameterValuesFromArray(ref url, request.supplemental_obj_field, "&supplemental_obj_field");
            RestUtilities.addParameterValuesFromArray(ref url, request.child_plans, "&child_plans");
            url += "&notification_template_group_no=" + request.notification_template_group_no;
            url += "&credit_note_template_no=" + request.credit_note_template_no;
            RestUtilities.addParameterValuesFromArray(ref url, request.surcharge_no, "&surcharge_no");
            RestUtilities.addParameterValuesFromArray(ref url, request.client_surcharge_id, "&client_surcharge_id");
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            RestUtilities.addParameterValuesFromArray(ref url, request.plan_nos, "&plan_nos");
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&plan_no=" + request.plan_no;
            url += "&client_plan_id=" + request.client_plan_id;
            url += "&plan_name=" + request.plan_name;
            url += "&new_client_plan_id=" + request.new_client_plan_id;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&promo_cd=" + request.promo_cd;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&promo_cd=" + request.promo_cd;
            url += "&promo_desc=" + request.promo_desc;
            url += "&promo_plan_set_no=" + request.promo_plan_set_no;
            url += "&no_of_uses=" + request.no_of_uses;
            url += "&start_date=" + request.start_date;
            url += "&exp_date=" + request.exp_date;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&promo_cd=" + request.promo_cd;
            url += "&promo_desc=" + request.promo_desc;
            url += "&promo_plan_set_no=" + request.promo_plan_set_no;
            url += "&no_of_uses=" + request.no_of_uses;
            url += "&start_date=" + request.start_date;
            url += "&exp_date=" + request.exp_date;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&usage_type_no=" + request.usage_type_no;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&usage_type_name=" + request.usage_type_name;
            url += "&usage_type_desc=" + request.usage_type_desc;
            url += "&usage_unit_type_no=" + request.usage_unit_type_no;
            url += "&usage_type_code=" + request.usage_type_code;
            url += "&usage_type_display_string=" + request.usage_type_display_string;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&usage_type_no=" + request.usage_type_no;
            url += "&usage_type_name=" + request.usage_type_name;
            url += "&usage_type_desc=" + request.usage_type_desc;
            url += "&usage_unit_type_no=" + request.usage_unit_type_no;
            url += "&usage_type_code=" + request.usage_type_code;
            url += "&usage_type_display_string=" + request.usage_type_display_string;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&field_name=" + request.field_name;
            url += "&description=" + request.description;
            url += "&min_no_sel=" + request.min_no_sel;
            url += "&max_no_sel=" + request.max_no_sel;
            url += "&datatype=" + request.datatype;
            url += "&form_input_type=" + request.form_input_type;
            url += "&use_allowed_vals_ind=" + request.use_allowed_vals_ind;
            url += "&option_value=" + request.option_value;
            url += "&option_value_order=" + request.option_value_order;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&field_no=" + request.field_no;
            url += "&field_name=" + request.field_name;
            url += "&description=" + request.description;
            url += "&min_no_sel=" + request.min_no_sel;
            url += "&max_no_sel=" + request.max_no_sel;
            url += "&datatype=" + request.datatype;
            url += "&form_input_type=" + request.form_input_type;
            url += "&use_allowed_vals_ind=" + request.use_allowed_vals_ind;
            url += "&option_value=" + request.option_value;
            url += "&option_value_order=" + request.option_value_order;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&field_no=" + request.field_no;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&group_no=" + request.group_no;
            url += "&client_plan_change_group_id=" + request.client_plan_change_group_id;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&group_name=" + request.group_name;
            url += "&group_desc=" + request.group_desc;
            url += "&group_usage=" + request.group_usage;
            url += "&client_plan_change_group_id=" + request.client_plan_change_group_id;
            url += "&group_plans=" + request.group_plans;
            url += "&group_plan_ids=" + request.group_plan_ids;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&group_no=" + request.group_no;
            url += "&group_name=" + request.group_name;
            url += "&group_desc=" + request.group_desc;
            url += "&group_usage=" + request.group_usage;
            url += "&client_plan_change_group_id=" + request.client_plan_change_group_id;
            url += "&group_plans=" + request.group_plans;
            url += "&group_plan_ids=" + request.group_plan_ids;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&group_list=" + request.group_list;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&coa_code=" + request.coa_code;
            url += "&coa_description=" + request.coa_description;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&coa_id=" + request.coa_id;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&coa_id=" + request.coa_id;
            url += "&coa_code=" + request.coa_code;
            url += "&coa_description=" + request.coa_description;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&surcharge_no=" + request.surcharge_no;
            url += "&client_surcharge_id=" + request.client_surcharge_id;
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&surcharge_name=" + request.surcharge_name;
            url += "&description=" + request.description;
            url += "&ext_description=" + request.ext_description;
            url += "&currency_cd=" + request.currency_cd;
            url += "&surcharge_type_cd=" + request.surcharge_type_cd;
            url += "&inline_offset_ind=" + request.inline_offset_ind;
            url += "&apply_b4_or_after_discount_cd=" + request.apply_b4_or_after_discount_cd;
            url += "&scope_no=" + request.scope_no;
            RestUtilities.addParameterValuesFromArray(ref url, request.tier, "&tier");
            url += "&client_surcharge_id=" + request.client_surcharge_id;
            url += "&apply_to_zero_invoice_ind=" + request.apply_to_zero_invoice_ind;
            url += "&tax_group=" + request.tax_group;
            url += "&gl_cd=" + request.gl_cd;
            url += "&ar_gl_cd=" + request.ar_gl_cd;
            RestUtilities.addParameterValuesFromArray(ref url, request.plan_no, "&plan_no");
            RestUtilities.addParameterValuesFromArray(ref url, request.client_plan_id, "&client_plan_id");
            RestUtilities.addParameterValuesFromArray(ref url, request.service_no, "&service_no");
            RestUtilities.addParameterValuesFromArray(ref url, request.client_service_id, "&client_service_id");
            RestUtilities.addParameterValuesFromArray(ref url, request.item_no, "&item_no");
            RestUtilities.addParameterValuesFromArray(ref url, request.client_item_id, "&client_item_id");
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            url += "&surcharge_no=" + request.surcharge_no;
            url += "&surcharge_name=" + request.surcharge_name;
            url += "&client_surcharge_id=" + request.client_surcharge_id;
            url += "&description=" + request.description;
            url += "&ext_description=" + request.ext_description;
            url += "&currency_cd=" + request.currency_cd;
            url += "&scope_no=" + request.scope_no;
            RestUtilities.addParameterValuesFromArray(ref url, request.tier, "&tier");
            url += "&apply_to_zero_invoice_ind=" + request.apply_to_zero_invoice_ind;
            RestUtilities.addParameterValuesFromArray(ref url, request.plan_no, "&plan_no");
            RestUtilities.addParameterValuesFromArray(ref url, request.client_plan_id, "&client_plan_id");
            RestUtilities.addParameterValuesFromArray(ref url, request.service_no, "&service_no");
            RestUtilities.addParameterValuesFromArray(ref url, request.client_service_id, "&client_service_id");
            RestUtilities.addParameterValuesFromArray(ref url, request.item_no, "&item_no");
            RestUtilities.addParameterValuesFromArray(ref url, request.client_item_id, "&client_item_id");
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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

            url += "&client_no=" + request.client_no;
            url += "&auth_key=" + request.auth_key;
            RestUtilities.addParameterValuesFromArray(ref url, request.surcharge_no, "&surcharge_no");
            RestUtilities.addParameterValuesFromArray(ref url, request.client_surcharge_id, "&client_surcharge_id");
            
            WebRequest webRequest = WebRequest.Create(url);
            webRequest.Method = getMethod();
            webRequest.ContentType = getContentType();
            string returnString;
            using (var responseReader = new StreamReader(webRequest.GetResponse().GetResponseStream()))
            {
                returnString = responseReader.ReadToEnd();
            }
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
            validate_admin_sessionResponse myDeserializedObj = json.Deserialize(reader, typeof(validate_admin_sessionResponse)) as validate_admin_sessionResponse;
            reader.Close();
            return myDeserializedObj;
        }

        #endregion Api Calls
    }
}
