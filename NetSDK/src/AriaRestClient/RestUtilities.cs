using Aria.SDK.AriaServices.AriaWebServices.AriaComplete;

namespace Aria.SDK.AriaServices.AriaWebServices
{
    class RestUtilities
    {
    /* ****************** ARRAY TO PARM METHODS FOR EACH ARRAY ELEMENT ********************************************** */
    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_field_names_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_field_names_row row = array[i];
                        url += "&supp_field_names[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.supp_field_names)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_field_names_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_field_names_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[supp_field_names]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.supp_field_names)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_field_values_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_field_values_row row = array[i];
                        url += "&supp_field_values[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.supp_field_values)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_field_values_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_field_values_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[supp_field_values]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.supp_field_values)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.web_vals_in_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.web_vals_in_row row = array[i];
                        url += "&in_replacement_names[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.in_replacement_names)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.web_vals_in_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.web_vals_in_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[in_replacement_names]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.in_replacement_names)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.event_list_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.event_list_row row = array[i];
                        url += "&event_list[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.event_list)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.event_list_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.event_list_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[event_list]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.event_list)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.in_reg_uss_params_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.in_reg_uss_params_row row = array[i];
                        url += "&param_name[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.param_name)));
                                    url += "&param_val[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.param_val)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.in_reg_uss_params_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.in_reg_uss_params_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[param_name]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.param_name)));
                                    url += paramPrefix + "[" + i + "]" + "[param_val]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.param_val)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.param_names_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.param_names_row row = array[i];
                        url += "&param_name[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.param_name)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.param_names_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.param_names_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[param_name]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.param_name)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.in_reg_uss_config_params_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.in_reg_uss_config_params_row row = array[i];
                        url += "&param_name[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.param_name)));
                                    url += "&param_val[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.param_val)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.in_reg_uss_config_params_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.in_reg_uss_config_params_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[param_name]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.param_name)));
                                    url += paramPrefix + "[" + i + "]" + "[param_val]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.param_val)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.inventory_item_stock_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.inventory_item_stock_row row = array[i];
                        url += "&item_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.item_no)));
                                    url += "&client_sku[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_sku)));
                                    url += "&update_directive[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.update_directive)));
                                    url += "&update_amount[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.update_amount)));
                                    url += "&client_item_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_item_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.inventory_item_stock_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.inventory_item_stock_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[item_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.item_no)));
                                    url += paramPrefix + "[" + i + "]" + "[client_sku]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_sku)));
                                    url += paramPrefix + "[" + i + "]" + "[update_directive]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.update_directive)));
                                    url += paramPrefix + "[" + i + "]" + "[update_amount]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.update_amount)));
                                    url += paramPrefix + "[" + i + "]" + "[client_item_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_item_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plan_no_to_remove_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plan_no_to_remove_row row = array[i];
                        url += "&queued_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.queued_plan_no)));
                                    url += "&queued_client_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.queued_client_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plan_no_to_remove_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plan_no_to_remove_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[queued_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.queued_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[queued_client_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.queued_client_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.new_acct_custom_rates_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.new_acct_custom_rates_row row = array[i];
                        url += "&custom_rate_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.custom_rate_plan_no)));
                                    url += "&custom_rate_service_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.custom_rate_service_no)));
                                    url += "&custom_rate_seq_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.custom_rate_seq_no)));
                                    url += "&custom_rate_from_unit[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.custom_rate_from_unit)));
                                    url += "&custom_rate_to_unit[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.custom_rate_to_unit)));
                                    url += "&custom_rate_per_unit[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.custom_rate_per_unit)));
                                    url += "&client_custom_rate_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_custom_rate_plan_id)));
                                    url += "&client_custom_rate_service_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_custom_rate_service_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.new_acct_custom_rates_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.new_acct_custom_rates_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[custom_rate_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.custom_rate_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[custom_rate_service_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.custom_rate_service_no)));
                                    url += paramPrefix + "[" + i + "]" + "[custom_rate_seq_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.custom_rate_seq_no)));
                                    url += paramPrefix + "[" + i + "]" + "[custom_rate_from_unit]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.custom_rate_from_unit)));
                                    url += paramPrefix + "[" + i + "]" + "[custom_rate_to_unit]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.custom_rate_to_unit)));
                                    url += paramPrefix + "[" + i + "]" + "[custom_rate_per_unit]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.custom_rate_per_unit)));
                                    url += paramPrefix + "[" + i + "]" + "[client_custom_rate_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_custom_rate_plan_id)));
                                    url += paramPrefix + "[" + i + "]" + "[client_custom_rate_service_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_custom_rate_service_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.surcharge_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.surcharge_no_row row = array[i];
                        url += "&surcharge_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.surcharge_no)));
                                    url += "&rate_schedule_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.rate_schedule_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.surcharge_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.surcharge_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[surcharge_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.surcharge_no)));
                                    url += paramPrefix + "[" + i + "]" + "[rate_schedule_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.rate_schedule_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plans_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plans_row row = array[i];
                        url += "&supp_plans[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.supp_plans)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plans_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plans_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[supp_plans]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.supp_plans)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plan_units_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plan_units_row row = array[i];
                        url += "&supp_plan_units[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.supp_plan_units)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plan_units_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plan_units_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[supp_plan_units]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.supp_plan_units)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.functional_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.functional_acct_groups_row row = array[i];
                        url += "&functional_acct_groups[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.functional_acct_groups)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.functional_acct_groups_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.functional_acct_groups_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[functional_acct_groups]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.functional_acct_groups)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.collections_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.collections_acct_groups_row row = array[i];
                        url += "&collections_acct_groups[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.collections_acct_groups)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.collections_acct_groups_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.collections_acct_groups_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[collections_acct_groups]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.collections_acct_groups)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plan_alt_rate_sched_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plan_alt_rate_sched_no_row row = array[i];
                        url += "&supp_plan_alt_rate_sched_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.supp_plan_alt_rate_sched_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plan_alt_rate_sched_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plan_alt_rate_sched_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[supp_plan_alt_rate_sched_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.supp_plan_alt_rate_sched_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.coupon_codes_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.coupon_codes_row row = array[i];
                        url += "&coupon_codes[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.coupon_codes)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.coupon_codes_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.coupon_codes_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[coupon_codes]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.coupon_codes)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.new_acct_plan_contracts_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.new_acct_plan_contracts_row row = array[i];
                        url += "&contract_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.contract_plan_no)));
                                    url += "&contract_type_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.contract_type_no)));
                                    url += "&contract_alt_recur_fee[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.contract_alt_recur_fee)));
                                    url += "&contract_length_months[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.contract_length_months)));
                                    url += "&contract_cancel_fee[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.contract_cancel_fee)));
                                    url += "&contract_comments[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.contract_comments)));
                                    url += "&contract_start_date[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.contract_start_date)));
                                    url += "&contract_end_date[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.contract_end_date)));
                                    url += "&client_contract_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_contract_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.new_acct_plan_contracts_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.new_acct_plan_contracts_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[contract_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.contract_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[contract_type_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.contract_type_no)));
                                    url += paramPrefix + "[" + i + "]" + "[contract_alt_recur_fee]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.contract_alt_recur_fee)));
                                    url += paramPrefix + "[" + i + "]" + "[contract_length_months]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.contract_length_months)));
                                    url += paramPrefix + "[" + i + "]" + "[contract_cancel_fee]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.contract_cancel_fee)));
                                    url += paramPrefix + "[" + i + "]" + "[contract_comments]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.contract_comments)));
                                    url += paramPrefix + "[" + i + "]" + "[contract_start_date]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.contract_start_date)));
                                    url += paramPrefix + "[" + i + "]" + "[contract_end_date]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.contract_end_date)));
                                    url += paramPrefix + "[" + i + "]" + "[client_contract_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_contract_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_accumulation_config_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_accumulation_config_row row = array[i];
                        url += "&usage_accumulation_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.usage_accumulation_plan_no)));
                                    url += "&usage_accumulation_reset_months[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.usage_accumulation_reset_months)));
                                    url += "&client_usage_accumulation_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_usage_accumulation_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_accumulation_config_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_accumulation_config_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[usage_accumulation_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.usage_accumulation_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[usage_accumulation_reset_months]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.usage_accumulation_reset_months)));
                                    url += paramPrefix + "[" + i + "]" + "[client_usage_accumulation_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_usage_accumulation_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.enable_usage_pooling_plan_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.enable_usage_pooling_plan_no_row row = array[i];
                        url += "&enable_usage_pooling_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.enable_usage_pooling_plan_no)));
                                    url += "&client_enable_usage_pool_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_enable_usage_pool_plan_id)));
                                    url += "&usage_threshold_applicability[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.usage_threshold_applicability)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.enable_usage_pooling_plan_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.enable_usage_pooling_plan_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[enable_usage_pooling_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.enable_usage_pooling_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[client_enable_usage_pool_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_enable_usage_pool_plan_id)));
                                    url += paramPrefix + "[" + i + "]" + "[usage_threshold_applicability]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.usage_threshold_applicability)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_func_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_func_acct_group_ids_row row = array[i];
                        url += "&client_func_acct_group_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_func_acct_group_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_func_acct_group_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_func_acct_group_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[client_func_acct_group_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_func_acct_group_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_coll_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_coll_acct_group_ids_row row = array[i];
                        url += "&client_coll_acct_group_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_coll_acct_group_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_coll_acct_group_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_coll_acct_group_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[client_coll_acct_group_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_coll_acct_group_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_supp_plan_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_supp_plan_ids_row row = array[i];
                        url += "&client_supp_plan_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_supp_plan_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_supp_plan_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_supp_plan_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[client_supp_plan_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_supp_plan_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_sp_alt_rate_sched_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_sp_alt_rate_sched_ids_row row = array[i];
                        url += "&client_sp_alt_rate_sched_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_sp_alt_rate_sched_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_sp_alt_rate_sched_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_sp_alt_rate_sched_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[client_sp_alt_rate_sched_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_sp_alt_rate_sched_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_plans_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_plans_row row = array[i];
                        url += "&a1_supp_plans[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_supp_plans)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_plans_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_plans_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_supp_plans]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_supp_plans)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_plan_units_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_plan_units_row row = array[i];
                        url += "&a1_supp_plan_units[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_supp_plan_units)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_plan_units_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_plan_units_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_supp_plan_units]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_supp_plan_units)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_functional_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_functional_acct_groups_row row = array[i];
                        url += "&a1_functional_acct_groups[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_functional_acct_groups)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_functional_acct_groups_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_functional_acct_groups_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_functional_acct_groups]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_functional_acct_groups)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_collections_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_collections_acct_groups_row row = array[i];
                        url += "&a1_collections_acct_groups[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_collections_acct_groups)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_collections_acct_groups_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_collections_acct_groups_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_collections_acct_groups]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_collections_acct_groups)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_field_names_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_field_names_row row = array[i];
                        url += "&a1_supp_field_names[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_supp_field_names)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_field_names_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_field_names_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_supp_field_names]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_supp_field_names)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_field_values_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_field_values_row row = array[i];
                        url += "&a1_supp_field_values[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_supp_field_values)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_field_values_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_field_values_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_supp_field_values]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_supp_field_values)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_plan_alt_rate_sched_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_plan_alt_rate_sched_no_row row = array[i];
                        url += "&a1_supp_plan_alt_rate_sched_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_supp_plan_alt_rate_sched_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_plan_alt_rate_sched_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_plan_alt_rate_sched_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_supp_plan_alt_rate_sched_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_supp_plan_alt_rate_sched_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_coupon_codes_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_coupon_codes_row row = array[i];
                        url += "&a1_coupon_codes[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_coupon_codes)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_coupon_codes_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_coupon_codes_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_coupon_codes]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_coupon_codes)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_new_acct_custom_rates_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_new_acct_custom_rates_row row = array[i];
                        url += "&a1_custom_rate_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_custom_rate_plan_no)));
                                    url += "&a1_custom_rate_service_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_custom_rate_service_no)));
                                    url += "&a1_custom_rate_seq_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_custom_rate_seq_no)));
                                    url += "&a1_custom_rate_from_unit[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_custom_rate_from_unit)));
                                    url += "&a1_custom_rate_to_unit[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_custom_rate_to_unit)));
                                    url += "&a1_custom_rate_per_unit[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_custom_rate_per_unit)));
                                    url += "&a1_client_custom_rate_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_client_custom_rate_plan_id)));
                                    url += "&a1_client_custom_rate_service_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_client_custom_rate_service_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_new_acct_custom_rates_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_new_acct_custom_rates_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_custom_rate_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_custom_rate_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a1_custom_rate_service_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_custom_rate_service_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a1_custom_rate_seq_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_custom_rate_seq_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a1_custom_rate_from_unit]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_custom_rate_from_unit)));
                                    url += paramPrefix + "[" + i + "]" + "[a1_custom_rate_to_unit]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_custom_rate_to_unit)));
                                    url += paramPrefix + "[" + i + "]" + "[a1_custom_rate_per_unit]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_custom_rate_per_unit)));
                                    url += paramPrefix + "[" + i + "]" + "[a1_client_custom_rate_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_client_custom_rate_plan_id)));
                                    url += paramPrefix + "[" + i + "]" + "[a1_client_custom_rate_service_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_client_custom_rate_service_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_new_acct_plan_contracts_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_new_acct_plan_contracts_row row = array[i];
                        url += "&a1_contract_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_contract_plan_no)));
                                    url += "&a1_contract_type_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_contract_type_no)));
                                    url += "&a1_contract_alt_recur_fee[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_contract_alt_recur_fee)));
                                    url += "&a1_contract_length_months[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_contract_length_months)));
                                    url += "&a1_contract_cancel_fee[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_contract_cancel_fee)));
                                    url += "&a1_contract_comments[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_contract_comments)));
                                    url += "&a1_contract_start_date[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_contract_start_date)));
                                    url += "&a1_contract_end_date[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_contract_end_date)));
                                    url += "&a1_client_contract_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_client_contract_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_new_acct_plan_contracts_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_new_acct_plan_contracts_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_contract_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_contract_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a1_contract_type_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_contract_type_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a1_contract_alt_recur_fee]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_contract_alt_recur_fee)));
                                    url += paramPrefix + "[" + i + "]" + "[a1_contract_length_months]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_contract_length_months)));
                                    url += paramPrefix + "[" + i + "]" + "[a1_contract_cancel_fee]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_contract_cancel_fee)));
                                    url += paramPrefix + "[" + i + "]" + "[a1_contract_comments]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_contract_comments)));
                                    url += paramPrefix + "[" + i + "]" + "[a1_contract_start_date]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_contract_start_date)));
                                    url += paramPrefix + "[" + i + "]" + "[a1_contract_end_date]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_contract_end_date)));
                                    url += paramPrefix + "[" + i + "]" + "[a1_client_contract_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_client_contract_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_usage_accumulation_config_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_usage_accumulation_config_row row = array[i];
                        url += "&a1_usage_accumulation_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_usage_accumulation_plan_no)));
                                    url += "&a1_usage_accumulation_reset_months[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_usage_accumulation_reset_months)));
                                    url += "&a1_client_usg_accum_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_client_usg_accum_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_usage_accumulation_config_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_usage_accumulation_config_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_usage_accumulation_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_usage_accumulation_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a1_usage_accumulation_reset_months]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_usage_accumulation_reset_months)));
                                    url += paramPrefix + "[" + i + "]" + "[a1_client_usg_accum_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_client_usg_accum_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_enable_usage_pooling_plan_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_enable_usage_pooling_plan_no_row row = array[i];
                        url += "&a1_enable_usage_pooling_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_enable_usage_pooling_plan_no)));
                                    url += "&a1_client_enable_usg_pool_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_client_enable_usg_pool_plan_id)));
                                    url += "&a1_usage_threshold_applicability[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_usage_threshold_applicability)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_enable_usage_pooling_plan_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_enable_usage_pooling_plan_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_enable_usage_pooling_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_enable_usage_pooling_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a1_client_enable_usg_pool_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_client_enable_usg_pool_plan_id)));
                                    url += paramPrefix + "[" + i + "]" + "[a1_usage_threshold_applicability]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_usage_threshold_applicability)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_func_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_func_acct_group_ids_row row = array[i];
                        url += "&a1_client_func_acct_group_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_client_func_acct_group_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_func_acct_group_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_func_acct_group_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_client_func_acct_group_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_client_func_acct_group_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_coll_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_coll_acct_group_ids_row row = array[i];
                        url += "&a1_client_coll_acct_group_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_client_coll_acct_group_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_coll_acct_group_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_coll_acct_group_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_client_coll_acct_group_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_client_coll_acct_group_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_supp_plan_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_supp_plan_ids_row row = array[i];
                        url += "&a1_client_supp_plan_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_client_supp_plan_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_supp_plan_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_supp_plan_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_client_supp_plan_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_client_supp_plan_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_sp_alt_rate_sched_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_sp_alt_rate_sched_ids_row row = array[i];
                        url += "&a1_client_sp_alt_rate_sched_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_client_sp_alt_rate_sched_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_sp_alt_rate_sched_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_sp_alt_rate_sched_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_client_sp_alt_rate_sched_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_client_sp_alt_rate_sched_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_surcharge_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_surcharge_no_row row = array[i];
                        url += "&a1_surcharge_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_surcharge_no)));
                                    url += "&a1_rate_schedule_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_rate_schedule_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_surcharge_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_surcharge_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_surcharge_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_surcharge_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a1_rate_schedule_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a1_rate_schedule_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_plans_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_plans_row row = array[i];
                        url += "&a2_supp_plans[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_supp_plans)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_plans_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_plans_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_supp_plans]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_supp_plans)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_plan_units_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_plan_units_row row = array[i];
                        url += "&a2_supp_plan_units[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_supp_plan_units)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_plan_units_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_plan_units_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_supp_plan_units]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_supp_plan_units)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_functional_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_functional_acct_groups_row row = array[i];
                        url += "&a2_functional_acct_groups[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_functional_acct_groups)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_functional_acct_groups_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_functional_acct_groups_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_functional_acct_groups]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_functional_acct_groups)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_collections_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_collections_acct_groups_row row = array[i];
                        url += "&a2_collections_acct_groups[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_collections_acct_groups)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_collections_acct_groups_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_collections_acct_groups_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_collections_acct_groups]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_collections_acct_groups)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_field_names_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_field_names_row row = array[i];
                        url += "&a2_supp_field_names[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_supp_field_names)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_field_names_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_field_names_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_supp_field_names]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_supp_field_names)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_field_values_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_field_values_row row = array[i];
                        url += "&a2_supp_field_values[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_supp_field_values)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_field_values_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_field_values_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_supp_field_values]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_supp_field_values)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_plan_alt_rate_sched_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_plan_alt_rate_sched_no_row row = array[i];
                        url += "&a2_supp_plan_alt_rate_sched_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_supp_plan_alt_rate_sched_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_plan_alt_rate_sched_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_plan_alt_rate_sched_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_supp_plan_alt_rate_sched_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_supp_plan_alt_rate_sched_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_coupon_codes_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_coupon_codes_row row = array[i];
                        url += "&a2_coupon_codes[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_coupon_codes)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_coupon_codes_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_coupon_codes_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_coupon_codes]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_coupon_codes)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_new_acct_custom_rates_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_new_acct_custom_rates_row row = array[i];
                        url += "&a2_custom_rate_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_custom_rate_plan_no)));
                                    url += "&a2_custom_rate_service_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_custom_rate_service_no)));
                                    url += "&a2_custom_rate_seq_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_custom_rate_seq_no)));
                                    url += "&a2_custom_rate_from_unit[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_custom_rate_from_unit)));
                                    url += "&a2_custom_rate_to_unit[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_custom_rate_to_unit)));
                                    url += "&a2_custom_rate_per_unit[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_custom_rate_per_unit)));
                                    url += "&a2_client_custom_rate_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_client_custom_rate_plan_id)));
                                    url += "&a2_client_custom_rate_service_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_client_custom_rate_service_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_new_acct_custom_rates_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_new_acct_custom_rates_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_custom_rate_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_custom_rate_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a2_custom_rate_service_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_custom_rate_service_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a2_custom_rate_seq_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_custom_rate_seq_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a2_custom_rate_from_unit]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_custom_rate_from_unit)));
                                    url += paramPrefix + "[" + i + "]" + "[a2_custom_rate_to_unit]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_custom_rate_to_unit)));
                                    url += paramPrefix + "[" + i + "]" + "[a2_custom_rate_per_unit]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_custom_rate_per_unit)));
                                    url += paramPrefix + "[" + i + "]" + "[a2_client_custom_rate_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_client_custom_rate_plan_id)));
                                    url += paramPrefix + "[" + i + "]" + "[a2_client_custom_rate_service_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_client_custom_rate_service_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_new_acct_plan_contracts_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_new_acct_plan_contracts_row row = array[i];
                        url += "&a2_contract_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_contract_plan_no)));
                                    url += "&a2_contract_type_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_contract_type_no)));
                                    url += "&a2_contract_alt_recur_fee[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_contract_alt_recur_fee)));
                                    url += "&a2_contract_length_months[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_contract_length_months)));
                                    url += "&a2_contract_cancel_fee[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_contract_cancel_fee)));
                                    url += "&a2_contract_comments[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_contract_comments)));
                                    url += "&a2_contract_start_date[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_contract_start_date)));
                                    url += "&a2_contract_end_date[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_contract_end_date)));
                                    url += "&a2_client_contract_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_client_contract_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_new_acct_plan_contracts_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_new_acct_plan_contracts_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_contract_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_contract_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a2_contract_type_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_contract_type_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a2_contract_alt_recur_fee]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_contract_alt_recur_fee)));
                                    url += paramPrefix + "[" + i + "]" + "[a2_contract_length_months]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_contract_length_months)));
                                    url += paramPrefix + "[" + i + "]" + "[a2_contract_cancel_fee]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_contract_cancel_fee)));
                                    url += paramPrefix + "[" + i + "]" + "[a2_contract_comments]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_contract_comments)));
                                    url += paramPrefix + "[" + i + "]" + "[a2_contract_start_date]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_contract_start_date)));
                                    url += paramPrefix + "[" + i + "]" + "[a2_contract_end_date]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_contract_end_date)));
                                    url += paramPrefix + "[" + i + "]" + "[a2_client_contract_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_client_contract_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_usage_accumulation_config_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_usage_accumulation_config_row row = array[i];
                        url += "&a2_usage_accumulation_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_usage_accumulation_plan_no)));
                                    url += "&a2_usage_accumulation_reset_months[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_usage_accumulation_reset_months)));
                                    url += "&a2_client_usg_accum_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_client_usg_accum_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_usage_accumulation_config_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_usage_accumulation_config_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_usage_accumulation_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_usage_accumulation_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a2_usage_accumulation_reset_months]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_usage_accumulation_reset_months)));
                                    url += paramPrefix + "[" + i + "]" + "[a2_client_usg_accum_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_client_usg_accum_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_enable_usage_pooling_plan_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_enable_usage_pooling_plan_no_row row = array[i];
                        url += "&a2_enable_usage_pooling_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_enable_usage_pooling_plan_no)));
                                    url += "&a2_client_enable_usg_pool_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_client_enable_usg_pool_plan_id)));
                                    url += "&a2_usage_threshold_applicability[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_usage_threshold_applicability)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_enable_usage_pooling_plan_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_enable_usage_pooling_plan_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_enable_usage_pooling_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_enable_usage_pooling_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a2_client_enable_usg_pool_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_client_enable_usg_pool_plan_id)));
                                    url += paramPrefix + "[" + i + "]" + "[a2_usage_threshold_applicability]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_usage_threshold_applicability)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_func_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_func_acct_group_ids_row row = array[i];
                        url += "&a2_client_func_acct_group_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_client_func_acct_group_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_func_acct_group_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_func_acct_group_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_client_func_acct_group_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_client_func_acct_group_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_coll_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_coll_acct_group_ids_row row = array[i];
                        url += "&a2_client_coll_acct_group_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_client_coll_acct_group_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_coll_acct_group_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_coll_acct_group_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_client_coll_acct_group_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_client_coll_acct_group_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_supp_plan_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_supp_plan_ids_row row = array[i];
                        url += "&a2_client_supp_plan_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_client_supp_plan_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_supp_plan_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_supp_plan_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_client_supp_plan_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_client_supp_plan_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_sp_alt_rate_sched_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_sp_alt_rate_sched_ids_row row = array[i];
                        url += "&a2_client_sp_alt_rate_sched_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_client_sp_alt_rate_sched_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_sp_alt_rate_sched_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_sp_alt_rate_sched_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_client_sp_alt_rate_sched_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_client_sp_alt_rate_sched_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_surcharge_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_surcharge_no_row row = array[i];
                        url += "&a2_surcharge_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_surcharge_no)));
                                    url += "&a2_rate_schedule_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_rate_schedule_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_surcharge_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_surcharge_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_surcharge_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_surcharge_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a2_rate_schedule_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a2_rate_schedule_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_plans_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_plans_row row = array[i];
                        url += "&a3_supp_plans[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_supp_plans)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_plans_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_plans_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_supp_plans]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_supp_plans)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_plan_units_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_plan_units_row row = array[i];
                        url += "&a3_supp_plan_units[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_supp_plan_units)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_plan_units_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_plan_units_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_supp_plan_units]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_supp_plan_units)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_functional_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_functional_acct_groups_row row = array[i];
                        url += "&a3_functional_acct_groups[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_functional_acct_groups)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_functional_acct_groups_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_functional_acct_groups_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_functional_acct_groups]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_functional_acct_groups)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_collections_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_collections_acct_groups_row row = array[i];
                        url += "&a3_collections_acct_groups[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_collections_acct_groups)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_collections_acct_groups_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_collections_acct_groups_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_collections_acct_groups]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_collections_acct_groups)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_field_names_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_field_names_row row = array[i];
                        url += "&a3_supp_field_names[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_supp_field_names)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_field_names_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_field_names_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_supp_field_names]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_supp_field_names)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_field_values_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_field_values_row row = array[i];
                        url += "&a3_supp_field_values[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_supp_field_values)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_field_values_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_field_values_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_supp_field_values]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_supp_field_values)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_plan_alt_rate_sched_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_plan_alt_rate_sched_no_row row = array[i];
                        url += "&a3_supp_plan_alt_rate_sched_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_supp_plan_alt_rate_sched_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_plan_alt_rate_sched_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_plan_alt_rate_sched_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_supp_plan_alt_rate_sched_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_supp_plan_alt_rate_sched_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_coupon_codes_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_coupon_codes_row row = array[i];
                        url += "&a3_coupon_codes[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_coupon_codes)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_coupon_codes_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_coupon_codes_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_coupon_codes]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_coupon_codes)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_new_acct_custom_rates_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_new_acct_custom_rates_row row = array[i];
                        url += "&a3_custom_rate_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_custom_rate_plan_no)));
                                    url += "&a3_custom_rate_service_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_custom_rate_service_no)));
                                    url += "&a3_custom_rate_seq_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_custom_rate_seq_no)));
                                    url += "&a3_custom_rate_from_unit[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_custom_rate_from_unit)));
                                    url += "&a3_custom_rate_to_unit[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_custom_rate_to_unit)));
                                    url += "&a3_custom_rate_per_unit[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_custom_rate_per_unit)));
                                    url += "&a3_client_custom_rate_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_client_custom_rate_plan_id)));
                                    url += "&a3_client_custom_rate_service_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_client_custom_rate_service_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_new_acct_custom_rates_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_new_acct_custom_rates_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_custom_rate_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_custom_rate_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a3_custom_rate_service_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_custom_rate_service_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a3_custom_rate_seq_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_custom_rate_seq_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a3_custom_rate_from_unit]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_custom_rate_from_unit)));
                                    url += paramPrefix + "[" + i + "]" + "[a3_custom_rate_to_unit]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_custom_rate_to_unit)));
                                    url += paramPrefix + "[" + i + "]" + "[a3_custom_rate_per_unit]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_custom_rate_per_unit)));
                                    url += paramPrefix + "[" + i + "]" + "[a3_client_custom_rate_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_client_custom_rate_plan_id)));
                                    url += paramPrefix + "[" + i + "]" + "[a3_client_custom_rate_service_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_client_custom_rate_service_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_new_acct_plan_contracts_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_new_acct_plan_contracts_row row = array[i];
                        url += "&a3_contract_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_contract_plan_no)));
                                    url += "&a3_contract_type_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_contract_type_no)));
                                    url += "&a3_contract_alt_recur_fee[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_contract_alt_recur_fee)));
                                    url += "&a3_contract_length_months[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_contract_length_months)));
                                    url += "&a3_contract_cancel_fee[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_contract_cancel_fee)));
                                    url += "&a3_contract_comments[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_contract_comments)));
                                    url += "&a3_contract_start_date[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_contract_start_date)));
                                    url += "&a3_contract_end_date[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_contract_end_date)));
                                    url += "&a3_client_contract_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_client_contract_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_new_acct_plan_contracts_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_new_acct_plan_contracts_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_contract_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_contract_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a3_contract_type_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_contract_type_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a3_contract_alt_recur_fee]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_contract_alt_recur_fee)));
                                    url += paramPrefix + "[" + i + "]" + "[a3_contract_length_months]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_contract_length_months)));
                                    url += paramPrefix + "[" + i + "]" + "[a3_contract_cancel_fee]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_contract_cancel_fee)));
                                    url += paramPrefix + "[" + i + "]" + "[a3_contract_comments]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_contract_comments)));
                                    url += paramPrefix + "[" + i + "]" + "[a3_contract_start_date]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_contract_start_date)));
                                    url += paramPrefix + "[" + i + "]" + "[a3_contract_end_date]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_contract_end_date)));
                                    url += paramPrefix + "[" + i + "]" + "[a3_client_contract_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_client_contract_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_usage_accumulation_config_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_usage_accumulation_config_row row = array[i];
                        url += "&a3_usage_accumulation_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_usage_accumulation_plan_no)));
                                    url += "&a3_usage_accumulation_reset_months[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_usage_accumulation_reset_months)));
                                    url += "&a3_client_usg_accum_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_client_usg_accum_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_usage_accumulation_config_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_usage_accumulation_config_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_usage_accumulation_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_usage_accumulation_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a3_usage_accumulation_reset_months]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_usage_accumulation_reset_months)));
                                    url += paramPrefix + "[" + i + "]" + "[a3_client_usg_accum_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_client_usg_accum_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_enable_usage_pooling_plan_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_enable_usage_pooling_plan_no_row row = array[i];
                        url += "&a3_enable_usage_pooling_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_enable_usage_pooling_plan_no)));
                                    url += "&a3_client_enable_usg_pool_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_client_enable_usg_pool_plan_id)));
                                    url += "&a3_usage_threshold_applicability[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_usage_threshold_applicability)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_enable_usage_pooling_plan_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_enable_usage_pooling_plan_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_enable_usage_pooling_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_enable_usage_pooling_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a3_client_enable_usg_pool_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_client_enable_usg_pool_plan_id)));
                                    url += paramPrefix + "[" + i + "]" + "[a3_usage_threshold_applicability]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_usage_threshold_applicability)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_func_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_func_acct_group_ids_row row = array[i];
                        url += "&a3_client_func_acct_group_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_client_func_acct_group_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_func_acct_group_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_func_acct_group_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_client_func_acct_group_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_client_func_acct_group_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_coll_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_coll_acct_group_ids_row row = array[i];
                        url += "&a3_client_coll_acct_group_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_client_coll_acct_group_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_coll_acct_group_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_coll_acct_group_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_client_coll_acct_group_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_client_coll_acct_group_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_supp_plan_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_supp_plan_ids_row row = array[i];
                        url += "&a3_client_supp_plan_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_client_supp_plan_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_supp_plan_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_supp_plan_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_client_supp_plan_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_client_supp_plan_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_sp_alt_rate_sched_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_sp_alt_rate_sched_ids_row row = array[i];
                        url += "&a3_client_sp_alt_rate_sched_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_client_sp_alt_rate_sched_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_sp_alt_rate_sched_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_sp_alt_rate_sched_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_client_sp_alt_rate_sched_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_client_sp_alt_rate_sched_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_surcharge_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_surcharge_no_row row = array[i];
                        url += "&a3_surcharge_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_surcharge_no)));
                                    url += "&a3_rate_schedule_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_rate_schedule_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_surcharge_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_surcharge_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_surcharge_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_surcharge_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a3_rate_schedule_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a3_rate_schedule_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_plans_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_plans_row row = array[i];
                        url += "&a4_supp_plans[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_supp_plans)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_plans_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_plans_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_supp_plans]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_supp_plans)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_plan_units_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_plan_units_row row = array[i];
                        url += "&a4_supp_plan_units[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_supp_plan_units)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_plan_units_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_plan_units_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_supp_plan_units]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_supp_plan_units)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_functional_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_functional_acct_groups_row row = array[i];
                        url += "&a4_functional_acct_groups[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_functional_acct_groups)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_functional_acct_groups_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_functional_acct_groups_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_functional_acct_groups]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_functional_acct_groups)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_collections_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_collections_acct_groups_row row = array[i];
                        url += "&a4_collections_acct_groups[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_collections_acct_groups)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_collections_acct_groups_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_collections_acct_groups_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_collections_acct_groups]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_collections_acct_groups)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_field_names_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_field_names_row row = array[i];
                        url += "&a4_supp_field_names[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_supp_field_names)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_field_names_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_field_names_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_supp_field_names]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_supp_field_names)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_field_values_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_field_values_row row = array[i];
                        url += "&a4_supp_field_values[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_supp_field_values)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_field_values_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_field_values_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_supp_field_values]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_supp_field_values)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_plan_alt_rate_sched_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_plan_alt_rate_sched_no_row row = array[i];
                        url += "&a4_supp_plan_alt_rate_sched_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_supp_plan_alt_rate_sched_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_plan_alt_rate_sched_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_plan_alt_rate_sched_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_supp_plan_alt_rate_sched_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_supp_plan_alt_rate_sched_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_coupon_codes_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_coupon_codes_row row = array[i];
                        url += "&a4_coupon_codes[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_coupon_codes)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_coupon_codes_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_coupon_codes_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_coupon_codes]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_coupon_codes)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_new_acct_custom_rates_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_new_acct_custom_rates_row row = array[i];
                        url += "&a4_custom_rate_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_custom_rate_plan_no)));
                                    url += "&a4_custom_rate_service_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_custom_rate_service_no)));
                                    url += "&a4_custom_rate_seq_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_custom_rate_seq_no)));
                                    url += "&a4_custom_rate_from_unit[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_custom_rate_from_unit)));
                                    url += "&a4_custom_rate_to_unit[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_custom_rate_to_unit)));
                                    url += "&a4_custom_rate_per_unit[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_custom_rate_per_unit)));
                                    url += "&a4_client_custom_rate_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_client_custom_rate_plan_id)));
                                    url += "&a4_client_custom_rate_service_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_client_custom_rate_service_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_new_acct_custom_rates_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_new_acct_custom_rates_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_custom_rate_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_custom_rate_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a4_custom_rate_service_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_custom_rate_service_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a4_custom_rate_seq_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_custom_rate_seq_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a4_custom_rate_from_unit]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_custom_rate_from_unit)));
                                    url += paramPrefix + "[" + i + "]" + "[a4_custom_rate_to_unit]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_custom_rate_to_unit)));
                                    url += paramPrefix + "[" + i + "]" + "[a4_custom_rate_per_unit]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_custom_rate_per_unit)));
                                    url += paramPrefix + "[" + i + "]" + "[a4_client_custom_rate_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_client_custom_rate_plan_id)));
                                    url += paramPrefix + "[" + i + "]" + "[a4_client_custom_rate_service_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_client_custom_rate_service_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_new_acct_plan_contracts_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_new_acct_plan_contracts_row row = array[i];
                        url += "&a4_contract_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_contract_plan_no)));
                                    url += "&a4_contract_type_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_contract_type_no)));
                                    url += "&a4_contract_alt_recur_fee[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_contract_alt_recur_fee)));
                                    url += "&a4_contract_length_months[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_contract_length_months)));
                                    url += "&a4_contract_cancel_fee[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_contract_cancel_fee)));
                                    url += "&a4_contract_comments[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_contract_comments)));
                                    url += "&a4_contract_start_date[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_contract_start_date)));
                                    url += "&a4_contract_end_date[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_contract_end_date)));
                                    url += "&a4_client_contract_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_client_contract_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_new_acct_plan_contracts_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_new_acct_plan_contracts_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_contract_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_contract_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a4_contract_type_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_contract_type_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a4_contract_alt_recur_fee]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_contract_alt_recur_fee)));
                                    url += paramPrefix + "[" + i + "]" + "[a4_contract_length_months]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_contract_length_months)));
                                    url += paramPrefix + "[" + i + "]" + "[a4_contract_cancel_fee]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_contract_cancel_fee)));
                                    url += paramPrefix + "[" + i + "]" + "[a4_contract_comments]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_contract_comments)));
                                    url += paramPrefix + "[" + i + "]" + "[a4_contract_start_date]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_contract_start_date)));
                                    url += paramPrefix + "[" + i + "]" + "[a4_contract_end_date]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_contract_end_date)));
                                    url += paramPrefix + "[" + i + "]" + "[a4_client_contract_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_client_contract_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_usage_accumulation_config_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_usage_accumulation_config_row row = array[i];
                        url += "&a4_usage_accumulation_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_usage_accumulation_plan_no)));
                                    url += "&a4_usage_accumulation_reset_months[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_usage_accumulation_reset_months)));
                                    url += "&a4_client_usg_accum_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_client_usg_accum_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_usage_accumulation_config_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_usage_accumulation_config_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_usage_accumulation_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_usage_accumulation_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a4_usage_accumulation_reset_months]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_usage_accumulation_reset_months)));
                                    url += paramPrefix + "[" + i + "]" + "[a4_client_usg_accum_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_client_usg_accum_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_enable_usage_pooling_plan_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_enable_usage_pooling_plan_no_row row = array[i];
                        url += "&a4_enable_usage_pooling_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_enable_usage_pooling_plan_no)));
                                    url += "&a4_client_enable_usg_pool_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_client_enable_usg_pool_plan_id)));
                                    url += "&a4_usage_threshold_applicability[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_usage_threshold_applicability)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_enable_usage_pooling_plan_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_enable_usage_pooling_plan_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_enable_usage_pooling_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_enable_usage_pooling_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a4_client_enable_usg_pool_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_client_enable_usg_pool_plan_id)));
                                    url += paramPrefix + "[" + i + "]" + "[a4_usage_threshold_applicability]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_usage_threshold_applicability)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_func_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_func_acct_group_ids_row row = array[i];
                        url += "&a4_client_func_acct_group_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_client_func_acct_group_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_func_acct_group_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_func_acct_group_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_client_func_acct_group_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_client_func_acct_group_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_coll_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_coll_acct_group_ids_row row = array[i];
                        url += "&a4_client_coll_acct_group_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_client_coll_acct_group_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_coll_acct_group_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_coll_acct_group_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_client_coll_acct_group_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_client_coll_acct_group_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_supp_plan_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_supp_plan_ids_row row = array[i];
                        url += "&a4_client_supp_plan_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_client_supp_plan_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_supp_plan_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_supp_plan_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_client_supp_plan_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_client_supp_plan_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_sp_alt_rate_sched_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_sp_alt_rate_sched_ids_row row = array[i];
                        url += "&a4_client_sp_alt_rate_sched_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_client_sp_alt_rate_sched_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_sp_alt_rate_sched_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_sp_alt_rate_sched_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_client_sp_alt_rate_sched_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_client_sp_alt_rate_sched_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_surcharge_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_surcharge_no_row row = array[i];
                        url += "&a4_surcharge_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_surcharge_no)));
                                    url += "&a4_rate_schedule_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_rate_schedule_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_surcharge_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_surcharge_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_surcharge_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_surcharge_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a4_rate_schedule_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a4_rate_schedule_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_plans_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_plans_row row = array[i];
                        url += "&a5_supp_plans[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_supp_plans)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_plans_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_plans_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_supp_plans]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_supp_plans)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_plan_units_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_plan_units_row row = array[i];
                        url += "&a5_supp_plan_units[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_supp_plan_units)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_plan_units_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_plan_units_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_supp_plan_units]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_supp_plan_units)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_functional_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_functional_acct_groups_row row = array[i];
                        url += "&a5_functional_acct_groups[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_functional_acct_groups)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_functional_acct_groups_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_functional_acct_groups_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_functional_acct_groups]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_functional_acct_groups)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_collections_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_collections_acct_groups_row row = array[i];
                        url += "&a5_collections_acct_groups[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_collections_acct_groups)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_collections_acct_groups_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_collections_acct_groups_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_collections_acct_groups]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_collections_acct_groups)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_field_names_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_field_names_row row = array[i];
                        url += "&a5_supp_field_names[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_supp_field_names)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_field_names_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_field_names_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_supp_field_names]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_supp_field_names)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_field_values_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_field_values_row row = array[i];
                        url += "&a5_supp_field_values[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_supp_field_values)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_field_values_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_field_values_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_supp_field_values]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_supp_field_values)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_plan_alt_rate_sched_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_plan_alt_rate_sched_no_row row = array[i];
                        url += "&a5_supp_plan_alt_rate_sched_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_supp_plan_alt_rate_sched_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_plan_alt_rate_sched_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_plan_alt_rate_sched_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_supp_plan_alt_rate_sched_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_supp_plan_alt_rate_sched_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_coupon_codes_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_coupon_codes_row row = array[i];
                        url += "&a5_coupon_codes[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_coupon_codes)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_coupon_codes_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_coupon_codes_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_coupon_codes]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_coupon_codes)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_new_acct_custom_rates_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_new_acct_custom_rates_row row = array[i];
                        url += "&a5_custom_rate_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_custom_rate_plan_no)));
                                    url += "&a5_custom_rate_service_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_custom_rate_service_no)));
                                    url += "&a5_custom_rate_seq_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_custom_rate_seq_no)));
                                    url += "&a5_custom_rate_from_unit[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_custom_rate_from_unit)));
                                    url += "&a5_custom_rate_to_unit[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_custom_rate_to_unit)));
                                    url += "&a5_custom_rate_per_unit[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_custom_rate_per_unit)));
                                    url += "&a5_client_custom_rate_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_client_custom_rate_plan_id)));
                                    url += "&a5_client_custom_rate_service_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_client_custom_rate_service_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_new_acct_custom_rates_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_new_acct_custom_rates_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_custom_rate_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_custom_rate_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a5_custom_rate_service_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_custom_rate_service_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a5_custom_rate_seq_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_custom_rate_seq_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a5_custom_rate_from_unit]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_custom_rate_from_unit)));
                                    url += paramPrefix + "[" + i + "]" + "[a5_custom_rate_to_unit]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_custom_rate_to_unit)));
                                    url += paramPrefix + "[" + i + "]" + "[a5_custom_rate_per_unit]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_custom_rate_per_unit)));
                                    url += paramPrefix + "[" + i + "]" + "[a5_client_custom_rate_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_client_custom_rate_plan_id)));
                                    url += paramPrefix + "[" + i + "]" + "[a5_client_custom_rate_service_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_client_custom_rate_service_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_new_acct_plan_contracts_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_new_acct_plan_contracts_row row = array[i];
                        url += "&a5_contract_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_contract_plan_no)));
                                    url += "&a5_contract_type_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_contract_type_no)));
                                    url += "&a5_contract_alt_recur_fee[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_contract_alt_recur_fee)));
                                    url += "&a5_contract_length_months[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_contract_length_months)));
                                    url += "&a5_contract_cancel_fee[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_contract_cancel_fee)));
                                    url += "&a5_contract_comments[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_contract_comments)));
                                    url += "&a5_contract_start_date[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_contract_start_date)));
                                    url += "&a5_contract_end_date[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_contract_end_date)));
                                    url += "&a5_client_contract_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_client_contract_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_new_acct_plan_contracts_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_new_acct_plan_contracts_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_contract_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_contract_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a5_contract_type_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_contract_type_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a5_contract_alt_recur_fee]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_contract_alt_recur_fee)));
                                    url += paramPrefix + "[" + i + "]" + "[a5_contract_length_months]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_contract_length_months)));
                                    url += paramPrefix + "[" + i + "]" + "[a5_contract_cancel_fee]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_contract_cancel_fee)));
                                    url += paramPrefix + "[" + i + "]" + "[a5_contract_comments]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_contract_comments)));
                                    url += paramPrefix + "[" + i + "]" + "[a5_contract_start_date]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_contract_start_date)));
                                    url += paramPrefix + "[" + i + "]" + "[a5_contract_end_date]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_contract_end_date)));
                                    url += paramPrefix + "[" + i + "]" + "[a5_client_contract_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_client_contract_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_usage_accumulation_config_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_usage_accumulation_config_row row = array[i];
                        url += "&a5_usage_accumulation_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_usage_accumulation_plan_no)));
                                    url += "&a5_usage_accumulation_reset_months[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_usage_accumulation_reset_months)));
                                    url += "&a5_client_usg_accum_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_client_usg_accum_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_usage_accumulation_config_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_usage_accumulation_config_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_usage_accumulation_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_usage_accumulation_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a5_usage_accumulation_reset_months]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_usage_accumulation_reset_months)));
                                    url += paramPrefix + "[" + i + "]" + "[a5_client_usg_accum_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_client_usg_accum_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_enable_usage_pooling_plan_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_enable_usage_pooling_plan_no_row row = array[i];
                        url += "&a5_enable_usage_pooling_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_enable_usage_pooling_plan_no)));
                                    url += "&a5_client_enable_usg_pool_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_client_enable_usg_pool_plan_id)));
                                    url += "&a5_usage_threshold_applicability[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_usage_threshold_applicability)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_enable_usage_pooling_plan_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_enable_usage_pooling_plan_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_enable_usage_pooling_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_enable_usage_pooling_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a5_client_enable_usg_pool_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_client_enable_usg_pool_plan_id)));
                                    url += paramPrefix + "[" + i + "]" + "[a5_usage_threshold_applicability]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_usage_threshold_applicability)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_func_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_func_acct_group_ids_row row = array[i];
                        url += "&a5_client_func_acct_group_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_client_func_acct_group_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_func_acct_group_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_func_acct_group_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_client_func_acct_group_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_client_func_acct_group_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_coll_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_coll_acct_group_ids_row row = array[i];
                        url += "&a5_client_coll_acct_group_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_client_coll_acct_group_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_coll_acct_group_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_coll_acct_group_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_client_coll_acct_group_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_client_coll_acct_group_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_supp_plan_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_supp_plan_ids_row row = array[i];
                        url += "&a5_client_supp_plan_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_client_supp_plan_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_supp_plan_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_supp_plan_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_client_supp_plan_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_client_supp_plan_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_sp_alt_rate_sched_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_sp_alt_rate_sched_ids_row row = array[i];
                        url += "&a5_client_sp_alt_rate_sched_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_client_sp_alt_rate_sched_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_sp_alt_rate_sched_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_sp_alt_rate_sched_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_client_sp_alt_rate_sched_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_client_sp_alt_rate_sched_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_surcharge_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_surcharge_no_row row = array[i];
                        url += "&a5_surcharge_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_surcharge_no)));
                                    url += "&a5_rate_schedule_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_rate_schedule_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_surcharge_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_surcharge_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_surcharge_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_surcharge_no)));
                                    url += paramPrefix + "[" + i + "]" + "[a5_rate_schedule_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.a5_rate_schedule_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.eligible_service_types_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.eligible_service_types_row row = array[i];
                        url += "&eligible_service_types[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.eligible_service_types)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.eligible_service_types_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.eligible_service_types_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[eligible_service_types]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.eligible_service_types)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.eligible_service_plans_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.eligible_service_plans_row row = array[i];
                        url += "&plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.plan_no)));
                                    url += "&service_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.service_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.eligible_service_plans_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.eligible_service_plans_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[service_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.service_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_eligible_service_plan_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_eligible_service_plan_ids_row row = array[i];
                        url += "&client_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_plan_id)));
                                    url += "&client_service_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_service_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_eligible_service_plan_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_eligible_service_plan_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[client_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_plan_id)));
                                    url += paramPrefix + "[" + i + "]" + "[client_service_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_service_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_1_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_1_row row = array[i];
                        url += "&usage_qualifier_1[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.usage_qualifier_1)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_1_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_1_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[usage_qualifier_1]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.usage_qualifier_1)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_2_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_2_row row = array[i];
                        url += "&usage_qualifier_2[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.usage_qualifier_2)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_2_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_2_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[usage_qualifier_2]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.usage_qualifier_2)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_3_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_3_row row = array[i];
                        url += "&usage_qualifier_3[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.usage_qualifier_3)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_3_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_3_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[usage_qualifier_3]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.usage_qualifier_3)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_4_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_4_row row = array[i];
                        url += "&usage_qualifier_4[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.usage_qualifier_4)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_4_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_4_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[usage_qualifier_4]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.usage_qualifier_4)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_acct_supp_field_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_acct_supp_field_row row = array[i];
                        url += "&supp_field_names[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.supp_field_names)));
                                    url += "&supp_field_values[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.supp_field_values)));
                                    url += "&supp_field_directives[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.supp_field_directives)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_acct_supp_field_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_acct_supp_field_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[supp_field_names]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.supp_field_names)));
                                    url += paramPrefix + "[" + i + "]" + "[supp_field_values]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.supp_field_values)));
                                    url += paramPrefix + "[" + i + "]" + "[supp_field_directives]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.supp_field_directives)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_acct_func_group_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_acct_func_group_row row = array[i];
                        url += "&functional_acct_groups[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.functional_acct_groups)));
                                    url += "&functional_group_directives[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.functional_group_directives)));
                                    url += "&client_func_acct_group_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_func_acct_group_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_acct_func_group_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_acct_func_group_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[functional_acct_groups]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.functional_acct_groups)));
                                    url += paramPrefix + "[" + i + "]" + "[functional_group_directives]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.functional_group_directives)));
                                    url += paramPrefix + "[" + i + "]" + "[client_func_acct_group_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_func_acct_group_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_acct_coll_group_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_acct_coll_group_row row = array[i];
                        url += "&collections_acct_groups[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.collections_acct_groups)));
                                    url += "&collections_group_directives[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.collections_group_directives)));
                                    url += "&client_coll_acct_group_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_coll_acct_group_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_acct_coll_group_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_acct_coll_group_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[collections_acct_groups]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.collections_acct_groups)));
                                    url += paramPrefix + "[" + i + "]" + "[collections_group_directives]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.collections_group_directives)));
                                    url += paramPrefix + "[" + i + "]" + "[client_coll_acct_group_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_coll_acct_group_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.disable_usage_pooling_plan_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.disable_usage_pooling_plan_no_row row = array[i];
                        url += "&disable_usage_pooling_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.disable_usage_pooling_plan_no)));
                                    url += "&client_disable_usage_pool_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_disable_usage_pool_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.disable_usage_pooling_plan_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.disable_usage_pooling_plan_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[disable_usage_pooling_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.disable_usage_pooling_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[client_disable_usage_pool_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_disable_usage_pool_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_surcharge_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_surcharge_row row = array[i];
                        url += "&surcharge_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.surcharge_no)));
                                    url += "&surcharge_directive[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.surcharge_directive)));
                                    url += "&rate_schedule_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.rate_schedule_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_surcharge_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_surcharge_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[surcharge_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.surcharge_no)));
                                    url += paramPrefix + "[" + i + "]" + "[surcharge_directive]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.surcharge_directive)));
                                    url += paramPrefix + "[" + i + "]" + "[rate_schedule_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.rate_schedule_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.custom_acct_rates_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.custom_acct_rates_row row = array[i];
                        url += "&rate_seq_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.rate_seq_no)));
                                    url += "&rate_per_unit[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.rate_per_unit)));
                                    url += "&from_unit[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.from_unit)));
                                    url += "&to_unit[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.to_unit)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.custom_acct_rates_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.custom_acct_rates_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[rate_seq_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.rate_seq_no)));
                                    url += paramPrefix + "[" + i + "]" + "[rate_per_unit]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.rate_per_unit)));
                                    url += paramPrefix + "[" + i + "]" + "[from_unit]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.from_unit)));
                                    url += paramPrefix + "[" + i + "]" + "[to_unit]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.to_unit)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.acct_supp_fields_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.acct_supp_fields_row row = array[i];
                        url += "&supp_field_name[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.supp_field_name)));
                                    url += "&supp_field_value[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.supp_field_value)));
                                    url += "&supp_field_directive[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.supp_field_directive)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.acct_supp_fields_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.acct_supp_fields_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[supp_field_name]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.supp_field_name)));
                                    url += paramPrefix + "[" + i + "]" + "[supp_field_value]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.supp_field_value)));
                                    url += paramPrefix + "[" + i + "]" + "[supp_field_directive]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.supp_field_directive)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plans_to_assign_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plans_to_assign_row row = array[i];
                        url += "&supp_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.supp_plan_no)));
                                    url += "&alt_rate_schedule_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.alt_rate_schedule_no)));
                                    url += "&num_plan_units[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.num_plan_units)));
                                    url += "&contract_type_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.contract_type_no)));
                                    url += "&contract_alt_recur_fee[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.contract_alt_recur_fee)));
                                    url += "&contract_length_months[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.contract_length_months)));
                                    url += "&contract_cancel_fee[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.contract_cancel_fee)));
                                    url += "&contract_comments[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.contract_comments)));
                                    url += "&contract_start_date[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.contract_start_date)));
                                    url += "&offset_months[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.offset_months)));
                                    url += "&auto_offset_months_option[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.auto_offset_months_option)));
                                    url += "&offset_interval[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.offset_interval)));
                                    url += "&contract_end_date[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.contract_end_date)));
                                    url += "&client_supp_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_supp_plan_id)));
                                    url += "&client_alt_rate_schedule_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_alt_rate_schedule_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plans_to_assign_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plans_to_assign_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[supp_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.supp_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[alt_rate_schedule_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.alt_rate_schedule_no)));
                                    url += paramPrefix + "[" + i + "]" + "[num_plan_units]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.num_plan_units)));
                                    url += paramPrefix + "[" + i + "]" + "[contract_type_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.contract_type_no)));
                                    url += paramPrefix + "[" + i + "]" + "[contract_alt_recur_fee]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.contract_alt_recur_fee)));
                                    url += paramPrefix + "[" + i + "]" + "[contract_length_months]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.contract_length_months)));
                                    url += paramPrefix + "[" + i + "]" + "[contract_cancel_fee]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.contract_cancel_fee)));
                                    url += paramPrefix + "[" + i + "]" + "[contract_comments]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.contract_comments)));
                                    url += paramPrefix + "[" + i + "]" + "[contract_start_date]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.contract_start_date)));
                                    url += paramPrefix + "[" + i + "]" + "[offset_months]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.offset_months)));
                                    url += paramPrefix + "[" + i + "]" + "[auto_offset_months_option]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.auto_offset_months_option)));
                                    url += paramPrefix + "[" + i + "]" + "[offset_interval]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.offset_interval)));
                                    url += paramPrefix + "[" + i + "]" + "[contract_end_date]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.contract_end_date)));
                                    url += paramPrefix + "[" + i + "]" + "[client_supp_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_supp_plan_id)));
                                    url += paramPrefix + "[" + i + "]" + "[client_alt_rate_schedule_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_alt_rate_schedule_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plan_surcharges_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plan_surcharges_row row = array[i];
                        url += "&surcharge_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.surcharge_no)));
                                    url += "&rate_schedule_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.rate_schedule_no)));
                                    url += "&surcharge_supp_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.surcharge_supp_plan_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plan_surcharges_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plan_surcharges_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[surcharge_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.surcharge_no)));
                                    url += paramPrefix + "[" + i + "]" + "[rate_schedule_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.rate_schedule_no)));
                                    url += paramPrefix + "[" + i + "]" + "[surcharge_supp_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.surcharge_supp_plan_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.credit_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.credit_ids_row row = array[i];
                        url += "&credit_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.credit_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.credit_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.credit_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[credit_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.credit_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_unit_thresholds_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_unit_thresholds_row row = array[i];
                        url += "&plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.plan_no)));
                                    url += "&usage_type_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.usage_type_no)));
                                    url += "&usage_type_code[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.usage_type_code)));
                                    url += "&threshold_units[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.threshold_units)));
                                    url += "&threshold_level_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.threshold_level_no)));
                                    url += "&threshold_level_value[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.threshold_level_value)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_unit_thresholds_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_unit_thresholds_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[usage_type_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.usage_type_no)));
                                    url += paramPrefix + "[" + i + "]" + "[usage_type_code]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.usage_type_code)));
                                    url += paramPrefix + "[" + i + "]" + "[threshold_units]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.threshold_units)));
                                    url += paramPrefix + "[" + i + "]" + "[threshold_level_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.threshold_level_no)));
                                    url += paramPrefix + "[" + i + "]" + "[threshold_level_value]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.threshold_level_value)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plan_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plan_no_row row = array[i];
                        url += "&plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.plan_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plan_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plan_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.plan_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_plan_id_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_plan_id_row row = array[i];
                        url += "&client_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_plan_id_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_plan_id_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[client_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plans_input_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plans_input_row row = array[i];
                        url += "&plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.plan_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plans_input_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plans_input_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.plan_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plans_to_get_outage_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plans_to_get_outage_row row = array[i];
                        url += "&plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.plan_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plans_to_get_outage_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plans_to_get_outage_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.plan_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_plan_ids_to_get_outage_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_plan_ids_to_get_outage_row row = array[i];
                        url += "&client_plan_ids_to_get_outage[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_plan_ids_to_get_outage)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_plan_ids_to_get_outage_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_plan_ids_to_get_outage_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[client_plan_ids_to_get_outage]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_plan_ids_to_get_outage)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.order_line_items_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.order_line_items_row row = array[i];
                        url += "&client_sku[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_sku)));
                                    url += "&units[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.units)));
                                    url += "&amount[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.amount)));
                                    url += "&unit_discount_amount[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.unit_discount_amount)));
                                    url += "&line_comments[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.line_comments)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.order_line_items_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.order_line_items_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[client_sku]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_sku)));
                                    url += paramPrefix + "[" + i + "]" + "[units]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.units)));
                                    url += paramPrefix + "[" + i + "]" + "[amount]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.amount)));
                                    url += paramPrefix + "[" + i + "]" + "[unit_discount_amount]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.unit_discount_amount)));
                                    url += paramPrefix + "[" + i + "]" + "[line_comments]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.line_comments)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.specific_charge_transaction_id_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.specific_charge_transaction_id_row row = array[i];
                        url += "&specific_charge_transaction_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.specific_charge_transaction_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.specific_charge_transaction_id_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.specific_charge_transaction_id_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[specific_charge_transaction_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.specific_charge_transaction_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.invoice_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.invoice_no_row row = array[i];
                        url += "&invoice_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.invoice_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.invoice_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.invoice_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[invoice_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.invoice_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.standing_order_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.standing_order_row row = array[i];
                        url += "&client_sku[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_sku)));
                                    url += "&units[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.units)));
                                    url += "&amount[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.amount)));
                                    url += "&unit_discount_amount[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.unit_discount_amount)));
                                    url += "&line_comments[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.line_comments)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.standing_order_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.standing_order_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[client_sku]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_sku)));
                                    url += paramPrefix + "[" + i + "]" + "[units]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.units)));
                                    url += paramPrefix + "[" + i + "]" + "[amount]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.amount)));
                                    url += paramPrefix + "[" + i + "]" + "[unit_discount_amount]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.unit_discount_amount)));
                                    url += paramPrefix + "[" + i + "]" + "[line_comments]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.line_comments)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_records_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_records_row row = array[i];
                        url += "&acct_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.acct_no)));
                                    url += "&userid[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.userid)));
                                    url += "&usage_type[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.usage_type)));
                                    url += "&usage_units[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.usage_units)));
                                    url += "&usage_date[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.usage_date)));
                                    url += "&billable_units[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.billable_units)));
                                    url += "&amt[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.amt)));
                                    url += "&rate[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.rate)));
                                    url += "&telco_from[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.telco_from)));
                                    url += "&telco_to[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.telco_to)));
                                    url += "&comments[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.comments)));
                                    url += "&exclude_from_billing[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.exclude_from_billing)));
                                    url += "&exclusion_comments[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.exclusion_comments)));
                                    url += "&parent_usage_rec_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.parent_usage_rec_no)));
                                    url += "&qualifier_1[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.qualifier_1)));
                                    url += "&qualifier_2[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.qualifier_2)));
                                    url += "&qualifier_3[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.qualifier_3)));
                                    url += "&qualifier_4[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.qualifier_4)));
                                    url += "&usage_type_code[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.usage_type_code)));
                                    url += "&client_record_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_record_id)));
                                    url += "&caller_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.caller_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_records_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_records_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[acct_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.acct_no)));
                                    url += paramPrefix + "[" + i + "]" + "[userid]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.userid)));
                                    url += paramPrefix + "[" + i + "]" + "[usage_type]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.usage_type)));
                                    url += paramPrefix + "[" + i + "]" + "[usage_units]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.usage_units)));
                                    url += paramPrefix + "[" + i + "]" + "[usage_date]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.usage_date)));
                                    url += paramPrefix + "[" + i + "]" + "[billable_units]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.billable_units)));
                                    url += paramPrefix + "[" + i + "]" + "[amt]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.amt)));
                                    url += paramPrefix + "[" + i + "]" + "[rate]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.rate)));
                                    url += paramPrefix + "[" + i + "]" + "[telco_from]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.telco_from)));
                                    url += paramPrefix + "[" + i + "]" + "[telco_to]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.telco_to)));
                                    url += paramPrefix + "[" + i + "]" + "[comments]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.comments)));
                                    url += paramPrefix + "[" + i + "]" + "[exclude_from_billing]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.exclude_from_billing)));
                                    url += paramPrefix + "[" + i + "]" + "[exclusion_comments]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.exclusion_comments)));
                                    url += paramPrefix + "[" + i + "]" + "[parent_usage_rec_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.parent_usage_rec_no)));
                                    url += paramPrefix + "[" + i + "]" + "[qualifier_1]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.qualifier_1)));
                                    url += paramPrefix + "[" + i + "]" + "[qualifier_2]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.qualifier_2)));
                                    url += paramPrefix + "[" + i + "]" + "[qualifier_3]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.qualifier_3)));
                                    url += paramPrefix + "[" + i + "]" + "[qualifier_4]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.qualifier_4)));
                                    url += paramPrefix + "[" + i + "]" + "[usage_type_code]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.usage_type_code)));
                                    url += paramPrefix + "[" + i + "]" + "[client_record_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_record_id)));
                                    url += paramPrefix + "[" + i + "]" + "[caller_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.caller_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.pre_calc_plan_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.pre_calc_plan_row row = array[i];
                        url += "&plan_item_service_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.plan_item_service_no)));
                                    url += "&plan_item_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.plan_item_plan_no)));
                                    url += "&plan_item_units[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.plan_item_units)));
                                    url += "&plan_item_unit_amount[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.plan_item_unit_amount)));
                                    url += "&client_plan_item_service_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_plan_item_service_id)));
                                    url += "&client_plan_item_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_plan_item_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.pre_calc_plan_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.pre_calc_plan_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[plan_item_service_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.plan_item_service_no)));
                                    url += paramPrefix + "[" + i + "]" + "[plan_item_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.plan_item_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[plan_item_units]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.plan_item_units)));
                                    url += paramPrefix + "[" + i + "]" + "[plan_item_unit_amount]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.plan_item_unit_amount)));
                                    url += paramPrefix + "[" + i + "]" + "[client_plan_item_service_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_plan_item_service_id)));
                                    url += paramPrefix + "[" + i + "]" + "[client_plan_item_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_plan_item_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.pre_calc_sku_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.pre_calc_sku_row row = array[i];
                        url += "&sku[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.sku)));
                                    url += "&sku_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.sku_plan_no)));
                                    url += "&sku_units[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.sku_units)));
                                    url += "&sku_unit_amount[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.sku_unit_amount)));
                                    url += "&client_sku_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_sku_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.pre_calc_sku_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.pre_calc_sku_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[sku]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.sku)));
                                    url += paramPrefix + "[" + i + "]" + "[sku_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.sku_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[sku_units]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.sku_units)));
                                    url += paramPrefix + "[" + i + "]" + "[sku_unit_amount]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.sku_unit_amount)));
                                    url += paramPrefix + "[" + i + "]" + "[client_sku_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_sku_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.cart_supp_plans_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.cart_supp_plans_row row = array[i];
                        url += "&supp_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.supp_plan_no)));
                                    url += "&supp_plan_units[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.supp_plan_units)));
                                    url += "&assignment_directive[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.assignment_directive)));
                                    url += "&client_supp_plan_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_supp_plan_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.cart_supp_plans_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.cart_supp_plans_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[supp_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.supp_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[supp_plan_units]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.supp_plan_units)));
                                    url += paramPrefix + "[" + i + "]" + "[assignment_directive]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.assignment_directive)));
                                    url += paramPrefix + "[" + i + "]" + "[client_supp_plan_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_supp_plan_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.multiple_coupons_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.multiple_coupons_row row = array[i];
                        url += "&coupon_codes[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.coupon_codes)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.multiple_coupons_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.multiple_coupons_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[coupon_codes]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.coupon_codes)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.invoices_to_reverse_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.invoices_to_reverse_row row = array[i];
                        url += "&invoice_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.invoice_no)));
                                    url += "&invoice_line_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.invoice_line_no)));
                                    url += "&invoice_line_reversing_amount[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.invoice_line_reversing_amount)));
                                    url += "&invoice_line_reversing_date[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.invoice_line_reversing_date)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.invoices_to_reverse_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.invoices_to_reverse_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[invoice_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.invoice_no)));
                                    url += paramPrefix + "[" + i + "]" + "[invoice_line_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.invoice_line_no)));
                                    url += paramPrefix + "[" + i + "]" + "[invoice_line_reversing_amount]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.invoice_line_reversing_amount)));
                                    url += paramPrefix + "[" + i + "]" + "[invoice_line_reversing_date]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.invoice_line_reversing_date)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_record_nos_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_record_nos_row row = array[i];
                        url += "&usage_record_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.usage_record_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_record_nos_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_record_nos_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[usage_record_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.usage_record_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_record_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_record_ids_row row = array[i];
                        url += "&client_record_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_record_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_record_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_record_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[client_record_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_record_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.recurring_credit_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.recurring_credit_no_row row = array[i];
                        url += "&recurring_credit_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.recurring_credit_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.recurring_credit_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.recurring_credit_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[recurring_credit_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.recurring_credit_no)));
                        
        }
    }

            public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.price_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.price_row row = array[i];
                        url += "&amount[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.amount)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.price_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.price_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[amount]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.amount)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.tier_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.tier_row row = array[i];
                        url += "&from[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.from)));
                                    url += "&to[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.to)));
                                    addParameterValuesFromArray(ref url, row.price,  "&price[" + i + "]");
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.tier_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.tier_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[from]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.from)));
                                    url += paramPrefix + "[" + i + "]" + "[to]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.to)));
                                    addParameterValuesFromArray(ref url, row.price,  paramPrefix + "[" + i + "]" + "[price]");
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_row row = array[i];
                        url += "&service_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.service_no)));
                                    url += "&pricing_rule[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.pricing_rule)));
                                    url += "&high_water[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.high_water)));
                                    url += "&billing_option[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.billing_option)));
                                    url += "&threshold[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.threshold)));
                                    url += "&client_service_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_service_id)));
                                    url += "&name[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.name)));
                                    url += "&gl_cd[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.gl_cd)));
                                    url += "&taxable[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.taxable)));
                                    url += "&taxable_ind[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.taxable_ind)));
                                    url += "&tax_group[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.tax_group)));
                                    url += "&service_type[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.service_type)));
                                    url += "&usage_type[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.usage_type)));
                                    url += "&rate_type[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.rate_type)));
                                    url += "&tax_inclusive_ind[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.tax_inclusive_ind)));
                                    addParameterValuesFromArray(ref url, row.tier,  "&tier[" + i + "]");
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[service_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.service_no)));
                                    url += paramPrefix + "[" + i + "]" + "[pricing_rule]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.pricing_rule)));
                                    url += paramPrefix + "[" + i + "]" + "[high_water]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.high_water)));
                                    url += paramPrefix + "[" + i + "]" + "[billing_option]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.billing_option)));
                                    url += paramPrefix + "[" + i + "]" + "[threshold]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.threshold)));
                                    url += paramPrefix + "[" + i + "]" + "[client_service_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_service_id)));
                                    url += paramPrefix + "[" + i + "]" + "[name]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.name)));
                                    url += paramPrefix + "[" + i + "]" + "[gl_cd]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.gl_cd)));
                                    url += paramPrefix + "[" + i + "]" + "[taxable]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.taxable)));
                                    url += paramPrefix + "[" + i + "]" + "[taxable_ind]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.taxable_ind)));
                                    url += paramPrefix + "[" + i + "]" + "[tax_group]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.tax_group)));
                                    url += paramPrefix + "[" + i + "]" + "[service_type]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.service_type)));
                                    url += paramPrefix + "[" + i + "]" + "[usage_type]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.usage_type)));
                                    url += paramPrefix + "[" + i + "]" + "[rate_type]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.rate_type)));
                                    url += paramPrefix + "[" + i + "]" + "[tax_inclusive_ind]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.tax_inclusive_ind)));
                                    addParameterValuesFromArray(ref url, row.tier,  paramPrefix + "[" + i + "]" + "[tier]");
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.image_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.image_row row = array[i];
                        url += "&main_image_url[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.main_image_url)));
                                    url += "&thumbnail_image_url[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.thumbnail_image_url)));
                                    url += "&image_text[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.image_text)));
                                    url += "&default_ind[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.default_ind)));
                                    url += "&active[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.active)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.image_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.image_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[main_image_url]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.main_image_url)));
                                    url += paramPrefix + "[" + i + "]" + "[thumbnail_image_url]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.thumbnail_image_url)));
                                    url += paramPrefix + "[" + i + "]" + "[image_text]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.image_text)));
                                    url += paramPrefix + "[" + i + "]" + "[default_ind]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.default_ind)));
                                    url += paramPrefix + "[" + i + "]" + "[active]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.active)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_class_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_class_row row = array[i];
                        url += "&class_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.class_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_class_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_class_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[class_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.class_no)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.supplemental_obj_field_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.supplemental_obj_field_row row = array[i];
                        url += "&supplemental_obj_field[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.supplemental_obj_field)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.supplemental_obj_field_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.supplemental_obj_field_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[supplemental_obj_field]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.supplemental_obj_field)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rules_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rules_row row = array[i];
                        url += "&rule[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.rule)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rules_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rules_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[rule]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.rule)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rule_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rule_ids_row row = array[i];
                        url += "&rule_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.rule_id)));
                                    url += "&rule[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.rule)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rule_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rule_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[rule_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.rule_id)));
                                    url += paramPrefix + "[" + i + "]" + "[rule]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.rule)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_no_row row = array[i];
                        url += "&plan_nos[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.plan_nos)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[plan_nos]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.plan_nos)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_plan_id_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_plan_id_row row = array[i];
                        url += "&client_plan_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_plan_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_plan_id_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_plan_id_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[client_plan_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_plan_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_no_row row = array[i];
                        url += "&service_nos[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.service_nos)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[service_nos]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.service_nos)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_service_id_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_service_id_row row = array[i];
                        url += "&client_service_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_service_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_service_id_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_service_id_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[client_service_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_service_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.item_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.item_no_row row = array[i];
                        url += "&item_nos[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.item_nos)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.item_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.item_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[item_nos]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.item_nos)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_item_id_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_item_id_row row = array[i];
                        url += "&client_item_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_item_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_item_id_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_item_id_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[client_item_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_item_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.eligible_service_types_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.eligible_service_types_row row = array[i];
                        url += "&eligible_service_type[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.eligible_service_type)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.eligible_service_types_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.eligible_service_types_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[eligible_service_type]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.eligible_service_type)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.template_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.template_row row = array[i];
                        url += "&credit_template_name[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.credit_template_name)));
                                    url += "&client_credit_template_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_credit_template_id)));
                                    url += "&eligible_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.eligible_plan_no)));
                                    url += "&eligible_client_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.eligible_client_plan_id)));
                                    url += "&eligible_service_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.eligible_service_no)));
                                    url += "&eligible_client_service_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.eligible_client_service_id)));
                                    addParameterValuesFromArray(ref url, row.eligible_service_types,  "&eligible_service_types[" + i + "]");
                                    url += "&discount_type[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.discount_type)));
                                    url += "&discount_amt[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.discount_amt)));
                                    url += "&no_of_credits[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.no_of_credits)));
                                    url += "&credit_interval_months[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.credit_interval_months)));
                                    url += "&percentage_plan_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.percentage_plan_no)));
                                    url += "&percentage_client_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.percentage_client_plan_id)));
                                    url += "&percentage_service_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.percentage_service_no)));
                                    url += "&percentage_client_service_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.percentage_client_service_id)));
                                    url += "&alt_service_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.alt_service_no)));
                                    url += "&alt_client_service_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.alt_client_service_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.template_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.template_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[credit_template_name]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.credit_template_name)));
                                    url += paramPrefix + "[" + i + "]" + "[client_credit_template_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_credit_template_id)));
                                    url += paramPrefix + "[" + i + "]" + "[eligible_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.eligible_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[eligible_client_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.eligible_client_plan_id)));
                                    url += paramPrefix + "[" + i + "]" + "[eligible_service_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.eligible_service_no)));
                                    url += paramPrefix + "[" + i + "]" + "[eligible_client_service_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.eligible_client_service_id)));
                                    addParameterValuesFromArray(ref url, row.eligible_service_types,  paramPrefix + "[" + i + "]" + "[eligible_service_types]");
                                    url += paramPrefix + "[" + i + "]" + "[discount_type]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.discount_type)));
                                    url += paramPrefix + "[" + i + "]" + "[discount_amt]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.discount_amt)));
                                    url += paramPrefix + "[" + i + "]" + "[no_of_credits]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.no_of_credits)));
                                    url += paramPrefix + "[" + i + "]" + "[credit_interval_months]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.credit_interval_months)));
                                    url += paramPrefix + "[" + i + "]" + "[percentage_plan_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.percentage_plan_no)));
                                    url += paramPrefix + "[" + i + "]" + "[percentage_client_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.percentage_client_plan_id)));
                                    url += paramPrefix + "[" + i + "]" + "[percentage_service_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.percentage_service_no)));
                                    url += paramPrefix + "[" + i + "]" + "[percentage_client_service_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.percentage_client_service_id)));
                                    url += paramPrefix + "[" + i + "]" + "[alt_service_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.alt_service_no)));
                                    url += paramPrefix + "[" + i + "]" + "[alt_client_service_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.alt_client_service_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_template_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_template_row row = array[i];
                        url += "&existing_templates[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.existing_templates)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_template_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_template_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[existing_templates]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.existing_templates)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_template_id_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_template_id_row row = array[i];
                        url += "&existing_template_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.existing_template_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_template_id_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_template_id_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[existing_template_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.existing_template_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.discount_rule_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.discount_rule_row row = array[i];
                        url += "&label[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.label)));
                                    url += "&rule_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.rule_id)));
                                    url += "&description[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.description)));
                                    url += "&ext_description[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.ext_description)));
                                    url += "&flat_percent_ind[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.flat_percent_ind)));
                                    url += "&amount[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.amount)));
                                    url += "&currency[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.currency)));
                                    url += "&duration_type_ind[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.duration_type_ind)));
                                    url += "&max_applicable_months[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.max_applicable_months)));
                                    url += "&max_applications_per_acct[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.max_applications_per_acct)));
                                    url += "&inline_offset_ind[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.inline_offset_ind)));
                                    url += "&service_code_to_use[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.service_code_to_use)));
                                    url += "&alt_service_no_2_apply[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.alt_service_no_2_apply)));
                                    url += "&alt_service_id_2_apply[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.alt_service_id_2_apply)));
                                    url += "&applicable_trans_scope[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.applicable_trans_scope)));
                                    url += "&scope_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.scope_no)));
                                    addParameterValuesFromArray(ref url, row.plan_no,  "&plan_no[" + i + "]");
                                    addParameterValuesFromArray(ref url, row.client_plan_id,  "&client_plan_id[" + i + "]");
                                    addParameterValuesFromArray(ref url, row.service_no,  "&service_no[" + i + "]");
                                    addParameterValuesFromArray(ref url, row.client_service_id,  "&client_service_id[" + i + "]");
                                    addParameterValuesFromArray(ref url, row.item_no,  "&item_no[" + i + "]");
                                    addParameterValuesFromArray(ref url, row.client_item_id,  "&client_item_id[" + i + "]");
                                    url += "&use_all_or_nth_subs_rule[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.use_all_or_nth_subs_rule)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.discount_rule_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.discount_rule_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[label]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.label)));
                                    url += paramPrefix + "[" + i + "]" + "[rule_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.rule_id)));
                                    url += paramPrefix + "[" + i + "]" + "[description]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.description)));
                                    url += paramPrefix + "[" + i + "]" + "[ext_description]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.ext_description)));
                                    url += paramPrefix + "[" + i + "]" + "[flat_percent_ind]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.flat_percent_ind)));
                                    url += paramPrefix + "[" + i + "]" + "[amount]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.amount)));
                                    url += paramPrefix + "[" + i + "]" + "[currency]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.currency)));
                                    url += paramPrefix + "[" + i + "]" + "[duration_type_ind]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.duration_type_ind)));
                                    url += paramPrefix + "[" + i + "]" + "[max_applicable_months]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.max_applicable_months)));
                                    url += paramPrefix + "[" + i + "]" + "[max_applications_per_acct]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.max_applications_per_acct)));
                                    url += paramPrefix + "[" + i + "]" + "[inline_offset_ind]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.inline_offset_ind)));
                                    url += paramPrefix + "[" + i + "]" + "[service_code_to_use]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.service_code_to_use)));
                                    url += paramPrefix + "[" + i + "]" + "[alt_service_no_2_apply]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.alt_service_no_2_apply)));
                                    url += paramPrefix + "[" + i + "]" + "[alt_service_id_2_apply]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.alt_service_id_2_apply)));
                                    url += paramPrefix + "[" + i + "]" + "[applicable_trans_scope]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.applicable_trans_scope)));
                                    url += paramPrefix + "[" + i + "]" + "[scope_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.scope_no)));
                                    addParameterValuesFromArray(ref url, row.plan_no,  paramPrefix + "[" + i + "]" + "[plan_no]");
                                    addParameterValuesFromArray(ref url, row.client_plan_id,  paramPrefix + "[" + i + "]" + "[client_plan_id]");
                                    addParameterValuesFromArray(ref url, row.service_no,  paramPrefix + "[" + i + "]" + "[service_no]");
                                    addParameterValuesFromArray(ref url, row.client_service_id,  paramPrefix + "[" + i + "]" + "[client_service_id]");
                                    addParameterValuesFromArray(ref url, row.item_no,  paramPrefix + "[" + i + "]" + "[item_no]");
                                    addParameterValuesFromArray(ref url, row.client_item_id,  paramPrefix + "[" + i + "]" + "[client_item_id]");
                                    url += paramPrefix + "[" + i + "]" + "[use_all_or_nth_subs_rule]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.use_all_or_nth_subs_rule)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_rule_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_rule_row row = array[i];
                        url += "&existing_rules[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.existing_rules)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_rule_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_rule_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[existing_rules]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.existing_rules)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_rule_id_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_rule_id_row row = array[i];
                        url += "&existing_discount_rule_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.existing_discount_rule_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_rule_id_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_rule_id_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[existing_discount_rule_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.existing_discount_rule_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.discount_bundle_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.discount_bundle_row row = array[i];
                        url += "&bundle_name[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.bundle_name)));
                                    url += "&bundle_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.bundle_id)));
                                    url += "&bundle_description[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.bundle_description)));
                                    url += "&allow_overlap_ind[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.allow_overlap_ind)));
                                    addParameterValuesFromArray(ref url, row.rules,  "&rules[" + i + "]");
                                    addParameterValuesFromArray(ref url, row.rule_ids,  "&rule_ids[" + i + "]");
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.discount_bundle_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.discount_bundle_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[bundle_name]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.bundle_name)));
                                    url += paramPrefix + "[" + i + "]" + "[bundle_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.bundle_id)));
                                    url += paramPrefix + "[" + i + "]" + "[bundle_description]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.bundle_description)));
                                    url += paramPrefix + "[" + i + "]" + "[allow_overlap_ind]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.allow_overlap_ind)));
                                    addParameterValuesFromArray(ref url, row.rules,  paramPrefix + "[" + i + "]" + "[rules]");
                                    addParameterValuesFromArray(ref url, row.rule_ids,  paramPrefix + "[" + i + "]" + "[rule_ids]");
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_bundle_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_bundle_row row = array[i];
                        url += "&existing_bundles[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.existing_bundles)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_bundle_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_bundle_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[existing_bundles]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.existing_bundles)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_bundle_id_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_bundle_id_row row = array[i];
                        url += "&existing_bundle_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.existing_bundle_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_bundle_id_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_bundle_id_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[existing_bundle_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.existing_bundle_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coupon_nos_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coupon_nos_row row = array[i];
                        url += "&coupon_nos[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.coupon_nos)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coupon_nos_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coupon_nos_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[coupon_nos]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.coupon_nos)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coupon_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coupon_row row = array[i];
                        url += "&coupon_cd[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.coupon_cd)));
                                    url += "&coupon_desc[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.coupon_desc)));
                                    url += "&coupon_msg[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.coupon_msg)));
                                    url += "&status_ind[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.status_ind)));
                                    url += "&no_of_uses[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.no_of_uses)));
                                    url += "&start_date[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.start_date)));
                                    url += "&end_date[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.end_date)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coupon_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coupon_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[coupon_cd]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.coupon_cd)));
                                    url += paramPrefix + "[" + i + "]" + "[coupon_desc]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.coupon_desc)));
                                    url += paramPrefix + "[" + i + "]" + "[coupon_msg]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.coupon_msg)));
                                    url += paramPrefix + "[" + i + "]" + "[status_ind]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.status_ind)));
                                    url += paramPrefix + "[" + i + "]" + "[no_of_uses]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.no_of_uses)));
                                    url += paramPrefix + "[" + i + "]" + "[start_date]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.start_date)));
                                    url += paramPrefix + "[" + i + "]" + "[end_date]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.end_date)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_coupon_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_coupon_row row = array[i];
                        url += "&existing_coupons[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.existing_coupons)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_coupon_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_coupon_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[existing_coupons]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.existing_coupons)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.template_nos_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.template_nos_row row = array[i];
                        url += "&template_nos[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.template_nos)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.template_nos_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.template_nos_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[template_nos]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.template_nos)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rule_nos_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rule_nos_row row = array[i];
                        url += "&rule_nos[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.rule_nos)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rule_nos_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rule_nos_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[rule_nos]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.rule_nos)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.bundle_nos_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.bundle_nos_row row = array[i];
                        url += "&bundle_nos[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.bundle_nos)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.bundle_nos_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.bundle_nos_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[bundle_nos]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.bundle_nos)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_group_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_group_row row = array[i];
                        url += "&plan_group[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.plan_group)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_group_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_group_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[plan_group]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.plan_group)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_group_id_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_group_id_row row = array[i];
                        url += "&plan_group_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.plan_group_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_group_id_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_group_id_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[plan_group_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.plan_group_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.schedule_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.schedule_row row = array[i];
                        url += "&schedule_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.schedule_no)));
                                    url += "&schedule_name[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.schedule_name)));
                                    url += "&client_rate_schedule_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_rate_schedule_id)));
                                    url += "&currency_cd[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.currency_cd)));
                                    url += "&is_default[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.is_default)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.schedule_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.schedule_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[schedule_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.schedule_no)));
                                    url += paramPrefix + "[" + i + "]" + "[schedule_name]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.schedule_name)));
                                    url += paramPrefix + "[" + i + "]" + "[client_rate_schedule_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_rate_schedule_id)));
                                    url += paramPrefix + "[" + i + "]" + "[currency_cd]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.currency_cd)));
                                    url += paramPrefix + "[" + i + "]" + "[is_default]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.is_default)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.resource_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.resource_row row = array[i];
                        url += "&resource_no[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.resource_no)));
                                    url += "&resource_name[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.resource_name)));
                                    url += "&resource_description[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.resource_description)));
                                    url += "&flat_threshold[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.flat_threshold)));
                                    url += "&resource_units[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.resource_units)));
                                    url += "&expire_on_paid_through[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.expire_on_paid_through)));
                                    url += "&additional_days[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.additional_days)));
                                    url += "&reset_on_update[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.reset_on_update)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.resource_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.resource_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[resource_no]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.resource_no)));
                                    url += paramPrefix + "[" + i + "]" + "[resource_name]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.resource_name)));
                                    url += paramPrefix + "[" + i + "]" + "[resource_description]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.resource_description)));
                                    url += paramPrefix + "[" + i + "]" + "[flat_threshold]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.flat_threshold)));
                                    url += paramPrefix + "[" + i + "]" + "[resource_units]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.resource_units)));
                                    url += paramPrefix + "[" + i + "]" + "[expire_on_paid_through]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.expire_on_paid_through)));
                                    url += paramPrefix + "[" + i + "]" + "[additional_days]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.additional_days)));
                                    url += paramPrefix + "[" + i + "]" + "[reset_on_update]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.reset_on_update)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_plans_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_plans_row row = array[i];
                        url += "&parent_plan[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.parent_plan)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_plans_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_plans_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[parent_plan]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.parent_plan)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_client_plan_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_client_plan_ids_row row = array[i];
                        url += "&parent_client_plan_id[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.parent_client_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_client_plan_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_client_plan_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[parent_client_plan_id]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.parent_client_plan_id)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.exclusion_plans_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.exclusion_plans_row row = array[i];
                        url += "&exclusion_plans[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.exclusion_plans)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.exclusion_plans_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.exclusion_plans_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[exclusion_plans]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.exclusion_plans)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.child_plans_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.child_plans_row row = array[i];
                        url += "&child_plan[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.child_plan)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.child_plans_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.child_plans_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[child_plan]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.child_plan)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.surcharge_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.surcharge_no_row row = array[i];
                        url += "&surcharge_nos[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.surcharge_nos)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.surcharge_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.surcharge_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[surcharge_nos]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.surcharge_nos)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_surcharge_id_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_surcharge_id_row row = array[i];
                        url += "&client_surcharge_ids[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_surcharge_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_surcharge_id_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_surcharge_id_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[client_surcharge_ids]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.client_surcharge_ids)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_nos_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_nos_row row = array[i];
                        url += "&plan_nos[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.plan_nos)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_nos_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_nos_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[plan_nos]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.plan_nos)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.surcharge_tier_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.surcharge_tier_row row = array[i];
                        url += "&from[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.from)));
                                    url += "&to[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.to)));
                                    url += "&rate[" + i + "]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.rate)));
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.surcharge_tier_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.surcharge_tier_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[from]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.from)));
                                    url += paramPrefix + "[" + i + "]" + "[to]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.to)));
                                    url += paramPrefix + "[" + i + "]" + "[rate]=" + HttpUtility.UrlEncode(Encoding.UTF8.GetBytes(Convert.ToString(row.rate)));
                        
        }
    }

            /* ****************** END - ARRAY TO PARM METHODS FOR EACH ARRAY ELEMENT **************************************** */
    }
}
