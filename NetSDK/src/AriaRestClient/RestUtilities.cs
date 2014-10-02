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
                        url += "&supp_field_names[" + i + "]=" + row.supp_field_names;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_field_names_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_field_names_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[supp_field_names]=" + row.supp_field_names;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_field_values_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_field_values_row row = array[i];
                        url += "&supp_field_values[" + i + "]=" + row.supp_field_values;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_field_values_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_field_values_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[supp_field_values]=" + row.supp_field_values;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.web_vals_in_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.web_vals_in_row row = array[i];
                        url += "&in_replacement_names[" + i + "]=" + row.in_replacement_names;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.web_vals_in_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.web_vals_in_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[in_replacement_names]=" + row.in_replacement_names;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.event_list_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.event_list_row row = array[i];
                        url += "&event_list[" + i + "]=" + row.event_list;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.event_list_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.event_list_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[event_list]=" + row.event_list;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.in_reg_uss_params_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.in_reg_uss_params_row row = array[i];
                        url += "&param_name[" + i + "]=" + row.param_name;
                                    url += "&param_val[" + i + "]=" + row.param_val;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.in_reg_uss_params_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.in_reg_uss_params_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[param_name]=" + row.param_name;
                                    url += paramPrefix + "[" + i + "]" + "[param_val]=" + row.param_val;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.param_names_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.param_names_row row = array[i];
                        url += "&param_name[" + i + "]=" + row.param_name;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.param_names_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.param_names_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[param_name]=" + row.param_name;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.in_reg_uss_config_params_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.in_reg_uss_config_params_row row = array[i];
                        url += "&param_name[" + i + "]=" + row.param_name;
                                    url += "&param_val[" + i + "]=" + row.param_val;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.in_reg_uss_config_params_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.in_reg_uss_config_params_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[param_name]=" + row.param_name;
                                    url += paramPrefix + "[" + i + "]" + "[param_val]=" + row.param_val;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.inventory_item_stock_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.inventory_item_stock_row row = array[i];
                        url += "&item_no[" + i + "]=" + row.item_no;
                                    url += "&client_sku[" + i + "]=" + row.client_sku;
                                    url += "&update_directive[" + i + "]=" + row.update_directive;
                                    url += "&update_amount[" + i + "]=" + row.update_amount;
                                    url += "&client_item_id[" + i + "]=" + row.client_item_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.inventory_item_stock_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.inventory_item_stock_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[item_no]=" + row.item_no;
                                    url += paramPrefix + "[" + i + "]" + "[client_sku]=" + row.client_sku;
                                    url += paramPrefix + "[" + i + "]" + "[update_directive]=" + row.update_directive;
                                    url += paramPrefix + "[" + i + "]" + "[update_amount]=" + row.update_amount;
                                    url += paramPrefix + "[" + i + "]" + "[client_item_id]=" + row.client_item_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plan_no_to_remove_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plan_no_to_remove_row row = array[i];
                        url += "&queued_plan_no[" + i + "]=" + row.queued_plan_no;
                                    url += "&queued_client_plan_id[" + i + "]=" + row.queued_client_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plan_no_to_remove_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plan_no_to_remove_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[queued_plan_no]=" + row.queued_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[queued_client_plan_id]=" + row.queued_client_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.new_acct_custom_rates_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.new_acct_custom_rates_row row = array[i];
                        url += "&custom_rate_plan_no[" + i + "]=" + row.custom_rate_plan_no;
                                    url += "&custom_rate_service_no[" + i + "]=" + row.custom_rate_service_no;
                                    url += "&custom_rate_seq_no[" + i + "]=" + row.custom_rate_seq_no;
                                    url += "&custom_rate_from_unit[" + i + "]=" + row.custom_rate_from_unit;
                                    url += "&custom_rate_to_unit[" + i + "]=" + row.custom_rate_to_unit;
                                    url += "&custom_rate_per_unit[" + i + "]=" + row.custom_rate_per_unit;
                                    url += "&client_custom_rate_plan_id[" + i + "]=" + row.client_custom_rate_plan_id;
                                    url += "&client_custom_rate_service_id[" + i + "]=" + row.client_custom_rate_service_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.new_acct_custom_rates_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.new_acct_custom_rates_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[custom_rate_plan_no]=" + row.custom_rate_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[custom_rate_service_no]=" + row.custom_rate_service_no;
                                    url += paramPrefix + "[" + i + "]" + "[custom_rate_seq_no]=" + row.custom_rate_seq_no;
                                    url += paramPrefix + "[" + i + "]" + "[custom_rate_from_unit]=" + row.custom_rate_from_unit;
                                    url += paramPrefix + "[" + i + "]" + "[custom_rate_to_unit]=" + row.custom_rate_to_unit;
                                    url += paramPrefix + "[" + i + "]" + "[custom_rate_per_unit]=" + row.custom_rate_per_unit;
                                    url += paramPrefix + "[" + i + "]" + "[client_custom_rate_plan_id]=" + row.client_custom_rate_plan_id;
                                    url += paramPrefix + "[" + i + "]" + "[client_custom_rate_service_id]=" + row.client_custom_rate_service_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plans_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plans_row row = array[i];
                        url += "&supp_plans[" + i + "]=" + row.supp_plans;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plans_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plans_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[supp_plans]=" + row.supp_plans;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plan_units_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plan_units_row row = array[i];
                        url += "&supp_plan_units[" + i + "]=" + row.supp_plan_units;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plan_units_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plan_units_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[supp_plan_units]=" + row.supp_plan_units;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.functional_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.functional_acct_groups_row row = array[i];
                        url += "&functional_acct_groups[" + i + "]=" + row.functional_acct_groups;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.functional_acct_groups_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.functional_acct_groups_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[functional_acct_groups]=" + row.functional_acct_groups;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.collections_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.collections_acct_groups_row row = array[i];
                        url += "&collections_acct_groups[" + i + "]=" + row.collections_acct_groups;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.collections_acct_groups_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.collections_acct_groups_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[collections_acct_groups]=" + row.collections_acct_groups;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plan_alt_rate_sched_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plan_alt_rate_sched_no_row row = array[i];
                        url += "&supp_plan_alt_rate_sched_no[" + i + "]=" + row.supp_plan_alt_rate_sched_no;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plan_alt_rate_sched_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plan_alt_rate_sched_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[supp_plan_alt_rate_sched_no]=" + row.supp_plan_alt_rate_sched_no;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.coupon_codes_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.coupon_codes_row row = array[i];
                        url += "&coupon_codes[" + i + "]=" + row.coupon_codes;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.coupon_codes_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.coupon_codes_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[coupon_codes]=" + row.coupon_codes;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.new_acct_plan_contracts_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.new_acct_plan_contracts_row row = array[i];
                        url += "&contract_plan_no[" + i + "]=" + row.contract_plan_no;
                                    url += "&contract_type_no[" + i + "]=" + row.contract_type_no;
                                    url += "&contract_alt_recur_fee[" + i + "]=" + row.contract_alt_recur_fee;
                                    url += "&contract_length_months[" + i + "]=" + row.contract_length_months;
                                    url += "&contract_cancel_fee[" + i + "]=" + row.contract_cancel_fee;
                                    url += "&contract_comments[" + i + "]=" + row.contract_comments;
                                    url += "&contract_start_date[" + i + "]=" + row.contract_start_date;
                                    url += "&contract_end_date[" + i + "]=" + row.contract_end_date;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.new_acct_plan_contracts_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.new_acct_plan_contracts_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[contract_plan_no]=" + row.contract_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[contract_type_no]=" + row.contract_type_no;
                                    url += paramPrefix + "[" + i + "]" + "[contract_alt_recur_fee]=" + row.contract_alt_recur_fee;
                                    url += paramPrefix + "[" + i + "]" + "[contract_length_months]=" + row.contract_length_months;
                                    url += paramPrefix + "[" + i + "]" + "[contract_cancel_fee]=" + row.contract_cancel_fee;
                                    url += paramPrefix + "[" + i + "]" + "[contract_comments]=" + row.contract_comments;
                                    url += paramPrefix + "[" + i + "]" + "[contract_start_date]=" + row.contract_start_date;
                                    url += paramPrefix + "[" + i + "]" + "[contract_end_date]=" + row.contract_end_date;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_accumulation_config_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_accumulation_config_row row = array[i];
                        url += "&usage_accumulation_plan_no[" + i + "]=" + row.usage_accumulation_plan_no;
                                    url += "&usage_accumulation_reset_months[" + i + "]=" + row.usage_accumulation_reset_months;
                                    url += "&client_usage_accumulation_plan_id[" + i + "]=" + row.client_usage_accumulation_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_accumulation_config_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_accumulation_config_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[usage_accumulation_plan_no]=" + row.usage_accumulation_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[usage_accumulation_reset_months]=" + row.usage_accumulation_reset_months;
                                    url += paramPrefix + "[" + i + "]" + "[client_usage_accumulation_plan_id]=" + row.client_usage_accumulation_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.enable_usage_pooling_plan_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.enable_usage_pooling_plan_no_row row = array[i];
                        url += "&enable_usage_pooling_plan_no[" + i + "]=" + row.enable_usage_pooling_plan_no;
                                    url += "&client_enable_usage_pool_plan_id[" + i + "]=" + row.client_enable_usage_pool_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.enable_usage_pooling_plan_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.enable_usage_pooling_plan_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[enable_usage_pooling_plan_no]=" + row.enable_usage_pooling_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[client_enable_usage_pool_plan_id]=" + row.client_enable_usage_pool_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_func_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_func_acct_group_ids_row row = array[i];
                        url += "&client_func_acct_group_ids[" + i + "]=" + row.client_func_acct_group_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_func_acct_group_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_func_acct_group_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[client_func_acct_group_ids]=" + row.client_func_acct_group_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_coll_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_coll_acct_group_ids_row row = array[i];
                        url += "&client_coll_acct_group_ids[" + i + "]=" + row.client_coll_acct_group_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_coll_acct_group_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_coll_acct_group_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[client_coll_acct_group_ids]=" + row.client_coll_acct_group_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_supp_plan_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_supp_plan_ids_row row = array[i];
                        url += "&client_supp_plan_ids[" + i + "]=" + row.client_supp_plan_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_supp_plan_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_supp_plan_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[client_supp_plan_ids]=" + row.client_supp_plan_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_sp_alt_rate_sched_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_sp_alt_rate_sched_ids_row row = array[i];
                        url += "&client_sp_alt_rate_sched_ids[" + i + "]=" + row.client_sp_alt_rate_sched_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_sp_alt_rate_sched_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_sp_alt_rate_sched_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[client_sp_alt_rate_sched_ids]=" + row.client_sp_alt_rate_sched_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.surcharge_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.surcharge_no_row row = array[i];
                        url += "&surcharge_no[" + i + "]=" + row.surcharge_no;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.surcharge_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.surcharge_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[surcharge_no]=" + row.surcharge_no;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_plans_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_plans_row row = array[i];
                        url += "&a1_supp_plans[" + i + "]=" + row.a1_supp_plans;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_plans_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_plans_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_supp_plans]=" + row.a1_supp_plans;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_plan_units_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_plan_units_row row = array[i];
                        url += "&a1_supp_plan_units[" + i + "]=" + row.a1_supp_plan_units;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_plan_units_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_plan_units_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_supp_plan_units]=" + row.a1_supp_plan_units;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_functional_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_functional_acct_groups_row row = array[i];
                        url += "&a1_functional_acct_groups[" + i + "]=" + row.a1_functional_acct_groups;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_functional_acct_groups_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_functional_acct_groups_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_functional_acct_groups]=" + row.a1_functional_acct_groups;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_collections_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_collections_acct_groups_row row = array[i];
                        url += "&a1_collections_acct_groups[" + i + "]=" + row.a1_collections_acct_groups;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_collections_acct_groups_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_collections_acct_groups_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_collections_acct_groups]=" + row.a1_collections_acct_groups;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_field_names_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_field_names_row row = array[i];
                        url += "&a1_supp_field_names[" + i + "]=" + row.a1_supp_field_names;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_field_names_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_field_names_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_supp_field_names]=" + row.a1_supp_field_names;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_field_values_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_field_values_row row = array[i];
                        url += "&a1_supp_field_values[" + i + "]=" + row.a1_supp_field_values;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_field_values_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_field_values_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_supp_field_values]=" + row.a1_supp_field_values;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_plan_alt_rate_sched_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_plan_alt_rate_sched_no_row row = array[i];
                        url += "&a1_supp_plan_alt_rate_sched_no[" + i + "]=" + row.a1_supp_plan_alt_rate_sched_no;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_plan_alt_rate_sched_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_supp_plan_alt_rate_sched_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_supp_plan_alt_rate_sched_no]=" + row.a1_supp_plan_alt_rate_sched_no;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_coupon_codes_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_coupon_codes_row row = array[i];
                        url += "&a1_coupon_codes[" + i + "]=" + row.a1_coupon_codes;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_coupon_codes_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_coupon_codes_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_coupon_codes]=" + row.a1_coupon_codes;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_new_acct_custom_rates_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_new_acct_custom_rates_row row = array[i];
                        url += "&a1_custom_rate_plan_no[" + i + "]=" + row.a1_custom_rate_plan_no;
                                    url += "&a1_custom_rate_service_no[" + i + "]=" + row.a1_custom_rate_service_no;
                                    url += "&a1_custom_rate_seq_no[" + i + "]=" + row.a1_custom_rate_seq_no;
                                    url += "&a1_custom_rate_from_unit[" + i + "]=" + row.a1_custom_rate_from_unit;
                                    url += "&a1_custom_rate_to_unit[" + i + "]=" + row.a1_custom_rate_to_unit;
                                    url += "&a1_custom_rate_per_unit[" + i + "]=" + row.a1_custom_rate_per_unit;
                                    url += "&a1_client_custom_rate_plan_id[" + i + "]=" + row.a1_client_custom_rate_plan_id;
                                    url += "&a1_client_custom_rate_service_id[" + i + "]=" + row.a1_client_custom_rate_service_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_new_acct_custom_rates_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_new_acct_custom_rates_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_custom_rate_plan_no]=" + row.a1_custom_rate_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[a1_custom_rate_service_no]=" + row.a1_custom_rate_service_no;
                                    url += paramPrefix + "[" + i + "]" + "[a1_custom_rate_seq_no]=" + row.a1_custom_rate_seq_no;
                                    url += paramPrefix + "[" + i + "]" + "[a1_custom_rate_from_unit]=" + row.a1_custom_rate_from_unit;
                                    url += paramPrefix + "[" + i + "]" + "[a1_custom_rate_to_unit]=" + row.a1_custom_rate_to_unit;
                                    url += paramPrefix + "[" + i + "]" + "[a1_custom_rate_per_unit]=" + row.a1_custom_rate_per_unit;
                                    url += paramPrefix + "[" + i + "]" + "[a1_client_custom_rate_plan_id]=" + row.a1_client_custom_rate_plan_id;
                                    url += paramPrefix + "[" + i + "]" + "[a1_client_custom_rate_service_id]=" + row.a1_client_custom_rate_service_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_new_acct_plan_contracts_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_new_acct_plan_contracts_row row = array[i];
                        url += "&a1_contract_plan_no[" + i + "]=" + row.a1_contract_plan_no;
                                    url += "&a1_contract_type_no[" + i + "]=" + row.a1_contract_type_no;
                                    url += "&a1_contract_alt_recur_fee[" + i + "]=" + row.a1_contract_alt_recur_fee;
                                    url += "&a1_contract_length_months[" + i + "]=" + row.a1_contract_length_months;
                                    url += "&a1_contract_cancel_fee[" + i + "]=" + row.a1_contract_cancel_fee;
                                    url += "&a1_contract_comments[" + i + "]=" + row.a1_contract_comments;
                                    url += "&a1_contract_start_date[" + i + "]=" + row.a1_contract_start_date;
                                    url += "&a1_contract_end_date[" + i + "]=" + row.a1_contract_end_date;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_new_acct_plan_contracts_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_new_acct_plan_contracts_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_contract_plan_no]=" + row.a1_contract_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[a1_contract_type_no]=" + row.a1_contract_type_no;
                                    url += paramPrefix + "[" + i + "]" + "[a1_contract_alt_recur_fee]=" + row.a1_contract_alt_recur_fee;
                                    url += paramPrefix + "[" + i + "]" + "[a1_contract_length_months]=" + row.a1_contract_length_months;
                                    url += paramPrefix + "[" + i + "]" + "[a1_contract_cancel_fee]=" + row.a1_contract_cancel_fee;
                                    url += paramPrefix + "[" + i + "]" + "[a1_contract_comments]=" + row.a1_contract_comments;
                                    url += paramPrefix + "[" + i + "]" + "[a1_contract_start_date]=" + row.a1_contract_start_date;
                                    url += paramPrefix + "[" + i + "]" + "[a1_contract_end_date]=" + row.a1_contract_end_date;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_usage_accumulation_config_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_usage_accumulation_config_row row = array[i];
                        url += "&a1_usage_accumulation_plan_no[" + i + "]=" + row.a1_usage_accumulation_plan_no;
                                    url += "&a1_usage_accumulation_reset_months[" + i + "]=" + row.a1_usage_accumulation_reset_months;
                                    url += "&a1_client_usg_accum_plan_id[" + i + "]=" + row.a1_client_usg_accum_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_usage_accumulation_config_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_usage_accumulation_config_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_usage_accumulation_plan_no]=" + row.a1_usage_accumulation_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[a1_usage_accumulation_reset_months]=" + row.a1_usage_accumulation_reset_months;
                                    url += paramPrefix + "[" + i + "]" + "[a1_client_usg_accum_plan_id]=" + row.a1_client_usg_accum_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_enable_usage_pooling_plan_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_enable_usage_pooling_plan_no_row row = array[i];
                        url += "&a1_enable_usage_pooling_plan_no[" + i + "]=" + row.a1_enable_usage_pooling_plan_no;
                                    url += "&a1_client_enable_usg_pool_plan_id[" + i + "]=" + row.a1_client_enable_usg_pool_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_enable_usage_pooling_plan_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_enable_usage_pooling_plan_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_enable_usage_pooling_plan_no]=" + row.a1_enable_usage_pooling_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[a1_client_enable_usg_pool_plan_id]=" + row.a1_client_enable_usg_pool_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_func_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_func_acct_group_ids_row row = array[i];
                        url += "&a1_client_func_acct_group_ids[" + i + "]=" + row.a1_client_func_acct_group_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_func_acct_group_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_func_acct_group_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_client_func_acct_group_ids]=" + row.a1_client_func_acct_group_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_coll_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_coll_acct_group_ids_row row = array[i];
                        url += "&a1_client_coll_acct_group_ids[" + i + "]=" + row.a1_client_coll_acct_group_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_coll_acct_group_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_coll_acct_group_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_client_coll_acct_group_ids]=" + row.a1_client_coll_acct_group_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_supp_plan_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_supp_plan_ids_row row = array[i];
                        url += "&a1_client_supp_plan_ids[" + i + "]=" + row.a1_client_supp_plan_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_supp_plan_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_supp_plan_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_client_supp_plan_ids]=" + row.a1_client_supp_plan_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_sp_alt_rate_sched_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_sp_alt_rate_sched_ids_row row = array[i];
                        url += "&a1_client_sp_alt_rate_sched_ids[" + i + "]=" + row.a1_client_sp_alt_rate_sched_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_sp_alt_rate_sched_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a1_client_sp_alt_rate_sched_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a1_client_sp_alt_rate_sched_ids]=" + row.a1_client_sp_alt_rate_sched_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_plans_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_plans_row row = array[i];
                        url += "&a2_supp_plans[" + i + "]=" + row.a2_supp_plans;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_plans_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_plans_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_supp_plans]=" + row.a2_supp_plans;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_plan_units_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_plan_units_row row = array[i];
                        url += "&a2_supp_plan_units[" + i + "]=" + row.a2_supp_plan_units;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_plan_units_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_plan_units_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_supp_plan_units]=" + row.a2_supp_plan_units;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_functional_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_functional_acct_groups_row row = array[i];
                        url += "&a2_functional_acct_groups[" + i + "]=" + row.a2_functional_acct_groups;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_functional_acct_groups_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_functional_acct_groups_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_functional_acct_groups]=" + row.a2_functional_acct_groups;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_collections_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_collections_acct_groups_row row = array[i];
                        url += "&a2_collections_acct_groups[" + i + "]=" + row.a2_collections_acct_groups;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_collections_acct_groups_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_collections_acct_groups_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_collections_acct_groups]=" + row.a2_collections_acct_groups;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_field_names_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_field_names_row row = array[i];
                        url += "&a2_supp_field_names[" + i + "]=" + row.a2_supp_field_names;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_field_names_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_field_names_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_supp_field_names]=" + row.a2_supp_field_names;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_field_values_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_field_values_row row = array[i];
                        url += "&a2_supp_field_values[" + i + "]=" + row.a2_supp_field_values;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_field_values_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_field_values_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_supp_field_values]=" + row.a2_supp_field_values;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_plan_alt_rate_sched_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_plan_alt_rate_sched_no_row row = array[i];
                        url += "&a2_supp_plan_alt_rate_sched_no[" + i + "]=" + row.a2_supp_plan_alt_rate_sched_no;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_plan_alt_rate_sched_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_supp_plan_alt_rate_sched_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_supp_plan_alt_rate_sched_no]=" + row.a2_supp_plan_alt_rate_sched_no;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_coupon_codes_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_coupon_codes_row row = array[i];
                        url += "&a2_coupon_codes[" + i + "]=" + row.a2_coupon_codes;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_coupon_codes_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_coupon_codes_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_coupon_codes]=" + row.a2_coupon_codes;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_new_acct_custom_rates_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_new_acct_custom_rates_row row = array[i];
                        url += "&a2_custom_rate_plan_no[" + i + "]=" + row.a2_custom_rate_plan_no;
                                    url += "&a2_custom_rate_service_no[" + i + "]=" + row.a2_custom_rate_service_no;
                                    url += "&a2_custom_rate_seq_no[" + i + "]=" + row.a2_custom_rate_seq_no;
                                    url += "&a2_custom_rate_from_unit[" + i + "]=" + row.a2_custom_rate_from_unit;
                                    url += "&a2_custom_rate_to_unit[" + i + "]=" + row.a2_custom_rate_to_unit;
                                    url += "&a2_custom_rate_per_unit[" + i + "]=" + row.a2_custom_rate_per_unit;
                                    url += "&a2_client_custom_rate_plan_id[" + i + "]=" + row.a2_client_custom_rate_plan_id;
                                    url += "&a2_client_custom_rate_service_id[" + i + "]=" + row.a2_client_custom_rate_service_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_new_acct_custom_rates_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_new_acct_custom_rates_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_custom_rate_plan_no]=" + row.a2_custom_rate_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[a2_custom_rate_service_no]=" + row.a2_custom_rate_service_no;
                                    url += paramPrefix + "[" + i + "]" + "[a2_custom_rate_seq_no]=" + row.a2_custom_rate_seq_no;
                                    url += paramPrefix + "[" + i + "]" + "[a2_custom_rate_from_unit]=" + row.a2_custom_rate_from_unit;
                                    url += paramPrefix + "[" + i + "]" + "[a2_custom_rate_to_unit]=" + row.a2_custom_rate_to_unit;
                                    url += paramPrefix + "[" + i + "]" + "[a2_custom_rate_per_unit]=" + row.a2_custom_rate_per_unit;
                                    url += paramPrefix + "[" + i + "]" + "[a2_client_custom_rate_plan_id]=" + row.a2_client_custom_rate_plan_id;
                                    url += paramPrefix + "[" + i + "]" + "[a2_client_custom_rate_service_id]=" + row.a2_client_custom_rate_service_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_new_acct_plan_contracts_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_new_acct_plan_contracts_row row = array[i];
                        url += "&a2_contract_plan_no[" + i + "]=" + row.a2_contract_plan_no;
                                    url += "&a2_contract_type_no[" + i + "]=" + row.a2_contract_type_no;
                                    url += "&a2_contract_alt_recur_fee[" + i + "]=" + row.a2_contract_alt_recur_fee;
                                    url += "&a2_contract_length_months[" + i + "]=" + row.a2_contract_length_months;
                                    url += "&a2_contract_cancel_fee[" + i + "]=" + row.a2_contract_cancel_fee;
                                    url += "&a2_contract_comments[" + i + "]=" + row.a2_contract_comments;
                                    url += "&a2_contract_start_date[" + i + "]=" + row.a2_contract_start_date;
                                    url += "&a2_contract_end_date[" + i + "]=" + row.a2_contract_end_date;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_new_acct_plan_contracts_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_new_acct_plan_contracts_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_contract_plan_no]=" + row.a2_contract_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[a2_contract_type_no]=" + row.a2_contract_type_no;
                                    url += paramPrefix + "[" + i + "]" + "[a2_contract_alt_recur_fee]=" + row.a2_contract_alt_recur_fee;
                                    url += paramPrefix + "[" + i + "]" + "[a2_contract_length_months]=" + row.a2_contract_length_months;
                                    url += paramPrefix + "[" + i + "]" + "[a2_contract_cancel_fee]=" + row.a2_contract_cancel_fee;
                                    url += paramPrefix + "[" + i + "]" + "[a2_contract_comments]=" + row.a2_contract_comments;
                                    url += paramPrefix + "[" + i + "]" + "[a2_contract_start_date]=" + row.a2_contract_start_date;
                                    url += paramPrefix + "[" + i + "]" + "[a2_contract_end_date]=" + row.a2_contract_end_date;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_usage_accumulation_config_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_usage_accumulation_config_row row = array[i];
                        url += "&a2_usage_accumulation_plan_no[" + i + "]=" + row.a2_usage_accumulation_plan_no;
                                    url += "&a2_usage_accumulation_reset_months[" + i + "]=" + row.a2_usage_accumulation_reset_months;
                                    url += "&a2_client_usg_accum_plan_id[" + i + "]=" + row.a2_client_usg_accum_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_usage_accumulation_config_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_usage_accumulation_config_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_usage_accumulation_plan_no]=" + row.a2_usage_accumulation_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[a2_usage_accumulation_reset_months]=" + row.a2_usage_accumulation_reset_months;
                                    url += paramPrefix + "[" + i + "]" + "[a2_client_usg_accum_plan_id]=" + row.a2_client_usg_accum_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_enable_usage_pooling_plan_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_enable_usage_pooling_plan_no_row row = array[i];
                        url += "&a2_enable_usage_pooling_plan_no[" + i + "]=" + row.a2_enable_usage_pooling_plan_no;
                                    url += "&a2_client_enable_usg_pool_plan_id[" + i + "]=" + row.a2_client_enable_usg_pool_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_enable_usage_pooling_plan_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_enable_usage_pooling_plan_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_enable_usage_pooling_plan_no]=" + row.a2_enable_usage_pooling_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[a2_client_enable_usg_pool_plan_id]=" + row.a2_client_enable_usg_pool_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_func_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_func_acct_group_ids_row row = array[i];
                        url += "&a2_client_func_acct_group_ids[" + i + "]=" + row.a2_client_func_acct_group_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_func_acct_group_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_func_acct_group_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_client_func_acct_group_ids]=" + row.a2_client_func_acct_group_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_coll_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_coll_acct_group_ids_row row = array[i];
                        url += "&a2_client_coll_acct_group_ids[" + i + "]=" + row.a2_client_coll_acct_group_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_coll_acct_group_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_coll_acct_group_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_client_coll_acct_group_ids]=" + row.a2_client_coll_acct_group_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_supp_plan_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_supp_plan_ids_row row = array[i];
                        url += "&a2_client_supp_plan_ids[" + i + "]=" + row.a2_client_supp_plan_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_supp_plan_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_supp_plan_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_client_supp_plan_ids]=" + row.a2_client_supp_plan_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_sp_alt_rate_sched_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_sp_alt_rate_sched_ids_row row = array[i];
                        url += "&a2_client_sp_alt_rate_sched_ids[" + i + "]=" + row.a2_client_sp_alt_rate_sched_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_sp_alt_rate_sched_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a2_client_sp_alt_rate_sched_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a2_client_sp_alt_rate_sched_ids]=" + row.a2_client_sp_alt_rate_sched_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_plans_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_plans_row row = array[i];
                        url += "&a3_supp_plans[" + i + "]=" + row.a3_supp_plans;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_plans_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_plans_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_supp_plans]=" + row.a3_supp_plans;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_plan_units_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_plan_units_row row = array[i];
                        url += "&a3_supp_plan_units[" + i + "]=" + row.a3_supp_plan_units;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_plan_units_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_plan_units_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_supp_plan_units]=" + row.a3_supp_plan_units;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_functional_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_functional_acct_groups_row row = array[i];
                        url += "&a3_functional_acct_groups[" + i + "]=" + row.a3_functional_acct_groups;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_functional_acct_groups_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_functional_acct_groups_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_functional_acct_groups]=" + row.a3_functional_acct_groups;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_collections_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_collections_acct_groups_row row = array[i];
                        url += "&a3_collections_acct_groups[" + i + "]=" + row.a3_collections_acct_groups;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_collections_acct_groups_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_collections_acct_groups_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_collections_acct_groups]=" + row.a3_collections_acct_groups;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_field_names_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_field_names_row row = array[i];
                        url += "&a3_supp_field_names[" + i + "]=" + row.a3_supp_field_names;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_field_names_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_field_names_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_supp_field_names]=" + row.a3_supp_field_names;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_field_values_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_field_values_row row = array[i];
                        url += "&a3_supp_field_values[" + i + "]=" + row.a3_supp_field_values;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_field_values_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_field_values_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_supp_field_values]=" + row.a3_supp_field_values;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_plan_alt_rate_sched_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_plan_alt_rate_sched_no_row row = array[i];
                        url += "&a3_supp_plan_alt_rate_sched_no[" + i + "]=" + row.a3_supp_plan_alt_rate_sched_no;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_plan_alt_rate_sched_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_supp_plan_alt_rate_sched_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_supp_plan_alt_rate_sched_no]=" + row.a3_supp_plan_alt_rate_sched_no;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_coupon_codes_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_coupon_codes_row row = array[i];
                        url += "&a3_coupon_codes[" + i + "]=" + row.a3_coupon_codes;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_coupon_codes_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_coupon_codes_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_coupon_codes]=" + row.a3_coupon_codes;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_new_acct_custom_rates_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_new_acct_custom_rates_row row = array[i];
                        url += "&a3_custom_rate_plan_no[" + i + "]=" + row.a3_custom_rate_plan_no;
                                    url += "&a3_custom_rate_service_no[" + i + "]=" + row.a3_custom_rate_service_no;
                                    url += "&a3_custom_rate_seq_no[" + i + "]=" + row.a3_custom_rate_seq_no;
                                    url += "&a3_custom_rate_from_unit[" + i + "]=" + row.a3_custom_rate_from_unit;
                                    url += "&a3_custom_rate_to_unit[" + i + "]=" + row.a3_custom_rate_to_unit;
                                    url += "&a3_custom_rate_per_unit[" + i + "]=" + row.a3_custom_rate_per_unit;
                                    url += "&a3_client_custom_rate_plan_id[" + i + "]=" + row.a3_client_custom_rate_plan_id;
                                    url += "&a3_client_custom_rate_service_id[" + i + "]=" + row.a3_client_custom_rate_service_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_new_acct_custom_rates_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_new_acct_custom_rates_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_custom_rate_plan_no]=" + row.a3_custom_rate_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[a3_custom_rate_service_no]=" + row.a3_custom_rate_service_no;
                                    url += paramPrefix + "[" + i + "]" + "[a3_custom_rate_seq_no]=" + row.a3_custom_rate_seq_no;
                                    url += paramPrefix + "[" + i + "]" + "[a3_custom_rate_from_unit]=" + row.a3_custom_rate_from_unit;
                                    url += paramPrefix + "[" + i + "]" + "[a3_custom_rate_to_unit]=" + row.a3_custom_rate_to_unit;
                                    url += paramPrefix + "[" + i + "]" + "[a3_custom_rate_per_unit]=" + row.a3_custom_rate_per_unit;
                                    url += paramPrefix + "[" + i + "]" + "[a3_client_custom_rate_plan_id]=" + row.a3_client_custom_rate_plan_id;
                                    url += paramPrefix + "[" + i + "]" + "[a3_client_custom_rate_service_id]=" + row.a3_client_custom_rate_service_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_new_acct_plan_contracts_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_new_acct_plan_contracts_row row = array[i];
                        url += "&a3_contract_plan_no[" + i + "]=" + row.a3_contract_plan_no;
                                    url += "&a3_contract_type_no[" + i + "]=" + row.a3_contract_type_no;
                                    url += "&a3_contract_alt_recur_fee[" + i + "]=" + row.a3_contract_alt_recur_fee;
                                    url += "&a3_contract_length_months[" + i + "]=" + row.a3_contract_length_months;
                                    url += "&a3_contract_cancel_fee[" + i + "]=" + row.a3_contract_cancel_fee;
                                    url += "&a3_contract_comments[" + i + "]=" + row.a3_contract_comments;
                                    url += "&a3_contract_start_date[" + i + "]=" + row.a3_contract_start_date;
                                    url += "&a3_contract_end_date[" + i + "]=" + row.a3_contract_end_date;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_new_acct_plan_contracts_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_new_acct_plan_contracts_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_contract_plan_no]=" + row.a3_contract_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[a3_contract_type_no]=" + row.a3_contract_type_no;
                                    url += paramPrefix + "[" + i + "]" + "[a3_contract_alt_recur_fee]=" + row.a3_contract_alt_recur_fee;
                                    url += paramPrefix + "[" + i + "]" + "[a3_contract_length_months]=" + row.a3_contract_length_months;
                                    url += paramPrefix + "[" + i + "]" + "[a3_contract_cancel_fee]=" + row.a3_contract_cancel_fee;
                                    url += paramPrefix + "[" + i + "]" + "[a3_contract_comments]=" + row.a3_contract_comments;
                                    url += paramPrefix + "[" + i + "]" + "[a3_contract_start_date]=" + row.a3_contract_start_date;
                                    url += paramPrefix + "[" + i + "]" + "[a3_contract_end_date]=" + row.a3_contract_end_date;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_usage_accumulation_config_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_usage_accumulation_config_row row = array[i];
                        url += "&a3_usage_accumulation_plan_no[" + i + "]=" + row.a3_usage_accumulation_plan_no;
                                    url += "&a3_usage_accumulation_reset_months[" + i + "]=" + row.a3_usage_accumulation_reset_months;
                                    url += "&a3_client_usg_accum_plan_id[" + i + "]=" + row.a3_client_usg_accum_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_usage_accumulation_config_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_usage_accumulation_config_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_usage_accumulation_plan_no]=" + row.a3_usage_accumulation_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[a3_usage_accumulation_reset_months]=" + row.a3_usage_accumulation_reset_months;
                                    url += paramPrefix + "[" + i + "]" + "[a3_client_usg_accum_plan_id]=" + row.a3_client_usg_accum_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_enable_usage_pooling_plan_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_enable_usage_pooling_plan_no_row row = array[i];
                        url += "&a3_enable_usage_pooling_plan_no[" + i + "]=" + row.a3_enable_usage_pooling_plan_no;
                                    url += "&a3_client_enable_usg_pool_plan_id[" + i + "]=" + row.a3_client_enable_usg_pool_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_enable_usage_pooling_plan_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_enable_usage_pooling_plan_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_enable_usage_pooling_plan_no]=" + row.a3_enable_usage_pooling_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[a3_client_enable_usg_pool_plan_id]=" + row.a3_client_enable_usg_pool_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_func_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_func_acct_group_ids_row row = array[i];
                        url += "&a3_client_func_acct_group_ids[" + i + "]=" + row.a3_client_func_acct_group_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_func_acct_group_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_func_acct_group_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_client_func_acct_group_ids]=" + row.a3_client_func_acct_group_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_coll_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_coll_acct_group_ids_row row = array[i];
                        url += "&a3_client_coll_acct_group_ids[" + i + "]=" + row.a3_client_coll_acct_group_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_coll_acct_group_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_coll_acct_group_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_client_coll_acct_group_ids]=" + row.a3_client_coll_acct_group_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_supp_plan_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_supp_plan_ids_row row = array[i];
                        url += "&a3_client_supp_plan_ids[" + i + "]=" + row.a3_client_supp_plan_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_supp_plan_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_supp_plan_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_client_supp_plan_ids]=" + row.a3_client_supp_plan_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_sp_alt_rate_sched_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_sp_alt_rate_sched_ids_row row = array[i];
                        url += "&a3_client_sp_alt_rate_sched_ids[" + i + "]=" + row.a3_client_sp_alt_rate_sched_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_sp_alt_rate_sched_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a3_client_sp_alt_rate_sched_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a3_client_sp_alt_rate_sched_ids]=" + row.a3_client_sp_alt_rate_sched_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_plans_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_plans_row row = array[i];
                        url += "&a4_supp_plans[" + i + "]=" + row.a4_supp_plans;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_plans_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_plans_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_supp_plans]=" + row.a4_supp_plans;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_plan_units_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_plan_units_row row = array[i];
                        url += "&a4_supp_plan_units[" + i + "]=" + row.a4_supp_plan_units;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_plan_units_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_plan_units_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_supp_plan_units]=" + row.a4_supp_plan_units;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_functional_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_functional_acct_groups_row row = array[i];
                        url += "&a4_functional_acct_groups[" + i + "]=" + row.a4_functional_acct_groups;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_functional_acct_groups_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_functional_acct_groups_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_functional_acct_groups]=" + row.a4_functional_acct_groups;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_collections_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_collections_acct_groups_row row = array[i];
                        url += "&a4_collections_acct_groups[" + i + "]=" + row.a4_collections_acct_groups;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_collections_acct_groups_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_collections_acct_groups_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_collections_acct_groups]=" + row.a4_collections_acct_groups;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_field_names_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_field_names_row row = array[i];
                        url += "&a4_supp_field_names[" + i + "]=" + row.a4_supp_field_names;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_field_names_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_field_names_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_supp_field_names]=" + row.a4_supp_field_names;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_field_values_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_field_values_row row = array[i];
                        url += "&a4_supp_field_values[" + i + "]=" + row.a4_supp_field_values;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_field_values_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_field_values_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_supp_field_values]=" + row.a4_supp_field_values;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_plan_alt_rate_sched_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_plan_alt_rate_sched_no_row row = array[i];
                        url += "&a4_supp_plan_alt_rate_sched_no[" + i + "]=" + row.a4_supp_plan_alt_rate_sched_no;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_plan_alt_rate_sched_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_supp_plan_alt_rate_sched_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_supp_plan_alt_rate_sched_no]=" + row.a4_supp_plan_alt_rate_sched_no;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_coupon_codes_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_coupon_codes_row row = array[i];
                        url += "&a4_coupon_codes[" + i + "]=" + row.a4_coupon_codes;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_coupon_codes_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_coupon_codes_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_coupon_codes]=" + row.a4_coupon_codes;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_new_acct_custom_rates_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_new_acct_custom_rates_row row = array[i];
                        url += "&a4_custom_rate_plan_no[" + i + "]=" + row.a4_custom_rate_plan_no;
                                    url += "&a4_custom_rate_service_no[" + i + "]=" + row.a4_custom_rate_service_no;
                                    url += "&a4_custom_rate_seq_no[" + i + "]=" + row.a4_custom_rate_seq_no;
                                    url += "&a4_custom_rate_from_unit[" + i + "]=" + row.a4_custom_rate_from_unit;
                                    url += "&a4_custom_rate_to_unit[" + i + "]=" + row.a4_custom_rate_to_unit;
                                    url += "&a4_custom_rate_per_unit[" + i + "]=" + row.a4_custom_rate_per_unit;
                                    url += "&a4_client_custom_rate_plan_id[" + i + "]=" + row.a4_client_custom_rate_plan_id;
                                    url += "&a4_client_custom_rate_service_id[" + i + "]=" + row.a4_client_custom_rate_service_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_new_acct_custom_rates_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_new_acct_custom_rates_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_custom_rate_plan_no]=" + row.a4_custom_rate_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[a4_custom_rate_service_no]=" + row.a4_custom_rate_service_no;
                                    url += paramPrefix + "[" + i + "]" + "[a4_custom_rate_seq_no]=" + row.a4_custom_rate_seq_no;
                                    url += paramPrefix + "[" + i + "]" + "[a4_custom_rate_from_unit]=" + row.a4_custom_rate_from_unit;
                                    url += paramPrefix + "[" + i + "]" + "[a4_custom_rate_to_unit]=" + row.a4_custom_rate_to_unit;
                                    url += paramPrefix + "[" + i + "]" + "[a4_custom_rate_per_unit]=" + row.a4_custom_rate_per_unit;
                                    url += paramPrefix + "[" + i + "]" + "[a4_client_custom_rate_plan_id]=" + row.a4_client_custom_rate_plan_id;
                                    url += paramPrefix + "[" + i + "]" + "[a4_client_custom_rate_service_id]=" + row.a4_client_custom_rate_service_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_new_acct_plan_contracts_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_new_acct_plan_contracts_row row = array[i];
                        url += "&a4_contract_plan_no[" + i + "]=" + row.a4_contract_plan_no;
                                    url += "&a4_contract_type_no[" + i + "]=" + row.a4_contract_type_no;
                                    url += "&a4_contract_alt_recur_fee[" + i + "]=" + row.a4_contract_alt_recur_fee;
                                    url += "&a4_contract_length_months[" + i + "]=" + row.a4_contract_length_months;
                                    url += "&a4_contract_cancel_fee[" + i + "]=" + row.a4_contract_cancel_fee;
                                    url += "&a4_contract_comments[" + i + "]=" + row.a4_contract_comments;
                                    url += "&a4_contract_start_date[" + i + "]=" + row.a4_contract_start_date;
                                    url += "&a4_contract_end_date[" + i + "]=" + row.a4_contract_end_date;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_new_acct_plan_contracts_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_new_acct_plan_contracts_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_contract_plan_no]=" + row.a4_contract_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[a4_contract_type_no]=" + row.a4_contract_type_no;
                                    url += paramPrefix + "[" + i + "]" + "[a4_contract_alt_recur_fee]=" + row.a4_contract_alt_recur_fee;
                                    url += paramPrefix + "[" + i + "]" + "[a4_contract_length_months]=" + row.a4_contract_length_months;
                                    url += paramPrefix + "[" + i + "]" + "[a4_contract_cancel_fee]=" + row.a4_contract_cancel_fee;
                                    url += paramPrefix + "[" + i + "]" + "[a4_contract_comments]=" + row.a4_contract_comments;
                                    url += paramPrefix + "[" + i + "]" + "[a4_contract_start_date]=" + row.a4_contract_start_date;
                                    url += paramPrefix + "[" + i + "]" + "[a4_contract_end_date]=" + row.a4_contract_end_date;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_usage_accumulation_config_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_usage_accumulation_config_row row = array[i];
                        url += "&a4_usage_accumulation_plan_no[" + i + "]=" + row.a4_usage_accumulation_plan_no;
                                    url += "&a4_usage_accumulation_reset_months[" + i + "]=" + row.a4_usage_accumulation_reset_months;
                                    url += "&a4_client_usg_accum_plan_id[" + i + "]=" + row.a4_client_usg_accum_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_usage_accumulation_config_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_usage_accumulation_config_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_usage_accumulation_plan_no]=" + row.a4_usage_accumulation_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[a4_usage_accumulation_reset_months]=" + row.a4_usage_accumulation_reset_months;
                                    url += paramPrefix + "[" + i + "]" + "[a4_client_usg_accum_plan_id]=" + row.a4_client_usg_accum_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_enable_usage_pooling_plan_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_enable_usage_pooling_plan_no_row row = array[i];
                        url += "&a4_enable_usage_pooling_plan_no[" + i + "]=" + row.a4_enable_usage_pooling_plan_no;
                                    url += "&a4_client_enable_usg_pool_plan_id[" + i + "]=" + row.a4_client_enable_usg_pool_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_enable_usage_pooling_plan_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_enable_usage_pooling_plan_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_enable_usage_pooling_plan_no]=" + row.a4_enable_usage_pooling_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[a4_client_enable_usg_pool_plan_id]=" + row.a4_client_enable_usg_pool_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_func_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_func_acct_group_ids_row row = array[i];
                        url += "&a4_client_func_acct_group_ids[" + i + "]=" + row.a4_client_func_acct_group_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_func_acct_group_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_func_acct_group_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_client_func_acct_group_ids]=" + row.a4_client_func_acct_group_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_coll_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_coll_acct_group_ids_row row = array[i];
                        url += "&a4_client_coll_acct_group_ids[" + i + "]=" + row.a4_client_coll_acct_group_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_coll_acct_group_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_coll_acct_group_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_client_coll_acct_group_ids]=" + row.a4_client_coll_acct_group_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_supp_plan_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_supp_plan_ids_row row = array[i];
                        url += "&a4_client_supp_plan_ids[" + i + "]=" + row.a4_client_supp_plan_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_supp_plan_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_supp_plan_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_client_supp_plan_ids]=" + row.a4_client_supp_plan_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_sp_alt_rate_sched_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_sp_alt_rate_sched_ids_row row = array[i];
                        url += "&a4_client_sp_alt_rate_sched_ids[" + i + "]=" + row.a4_client_sp_alt_rate_sched_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_sp_alt_rate_sched_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a4_client_sp_alt_rate_sched_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a4_client_sp_alt_rate_sched_ids]=" + row.a4_client_sp_alt_rate_sched_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_plans_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_plans_row row = array[i];
                        url += "&a5_supp_plans[" + i + "]=" + row.a5_supp_plans;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_plans_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_plans_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_supp_plans]=" + row.a5_supp_plans;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_plan_units_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_plan_units_row row = array[i];
                        url += "&a5_supp_plan_units[" + i + "]=" + row.a5_supp_plan_units;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_plan_units_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_plan_units_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_supp_plan_units]=" + row.a5_supp_plan_units;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_functional_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_functional_acct_groups_row row = array[i];
                        url += "&a5_functional_acct_groups[" + i + "]=" + row.a5_functional_acct_groups;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_functional_acct_groups_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_functional_acct_groups_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_functional_acct_groups]=" + row.a5_functional_acct_groups;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_collections_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_collections_acct_groups_row row = array[i];
                        url += "&a5_collections_acct_groups[" + i + "]=" + row.a5_collections_acct_groups;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_collections_acct_groups_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_collections_acct_groups_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_collections_acct_groups]=" + row.a5_collections_acct_groups;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_field_names_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_field_names_row row = array[i];
                        url += "&a5_supp_field_names[" + i + "]=" + row.a5_supp_field_names;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_field_names_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_field_names_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_supp_field_names]=" + row.a5_supp_field_names;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_field_values_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_field_values_row row = array[i];
                        url += "&a5_supp_field_values[" + i + "]=" + row.a5_supp_field_values;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_field_values_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_field_values_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_supp_field_values]=" + row.a5_supp_field_values;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_plan_alt_rate_sched_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_plan_alt_rate_sched_no_row row = array[i];
                        url += "&a5_supp_plan_alt_rate_sched_no[" + i + "]=" + row.a5_supp_plan_alt_rate_sched_no;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_plan_alt_rate_sched_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_supp_plan_alt_rate_sched_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_supp_plan_alt_rate_sched_no]=" + row.a5_supp_plan_alt_rate_sched_no;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_coupon_codes_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_coupon_codes_row row = array[i];
                        url += "&a5_coupon_codes[" + i + "]=" + row.a5_coupon_codes;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_coupon_codes_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_coupon_codes_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_coupon_codes]=" + row.a5_coupon_codes;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_new_acct_custom_rates_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_new_acct_custom_rates_row row = array[i];
                        url += "&a5_custom_rate_plan_no[" + i + "]=" + row.a5_custom_rate_plan_no;
                                    url += "&a5_custom_rate_service_no[" + i + "]=" + row.a5_custom_rate_service_no;
                                    url += "&a5_custom_rate_seq_no[" + i + "]=" + row.a5_custom_rate_seq_no;
                                    url += "&a5_custom_rate_from_unit[" + i + "]=" + row.a5_custom_rate_from_unit;
                                    url += "&a5_custom_rate_to_unit[" + i + "]=" + row.a5_custom_rate_to_unit;
                                    url += "&a5_custom_rate_per_unit[" + i + "]=" + row.a5_custom_rate_per_unit;
                                    url += "&a5_client_custom_rate_plan_id[" + i + "]=" + row.a5_client_custom_rate_plan_id;
                                    url += "&a5_client_custom_rate_service_id[" + i + "]=" + row.a5_client_custom_rate_service_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_new_acct_custom_rates_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_new_acct_custom_rates_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_custom_rate_plan_no]=" + row.a5_custom_rate_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[a5_custom_rate_service_no]=" + row.a5_custom_rate_service_no;
                                    url += paramPrefix + "[" + i + "]" + "[a5_custom_rate_seq_no]=" + row.a5_custom_rate_seq_no;
                                    url += paramPrefix + "[" + i + "]" + "[a5_custom_rate_from_unit]=" + row.a5_custom_rate_from_unit;
                                    url += paramPrefix + "[" + i + "]" + "[a5_custom_rate_to_unit]=" + row.a5_custom_rate_to_unit;
                                    url += paramPrefix + "[" + i + "]" + "[a5_custom_rate_per_unit]=" + row.a5_custom_rate_per_unit;
                                    url += paramPrefix + "[" + i + "]" + "[a5_client_custom_rate_plan_id]=" + row.a5_client_custom_rate_plan_id;
                                    url += paramPrefix + "[" + i + "]" + "[a5_client_custom_rate_service_id]=" + row.a5_client_custom_rate_service_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_new_acct_plan_contracts_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_new_acct_plan_contracts_row row = array[i];
                        url += "&a5_contract_plan_no[" + i + "]=" + row.a5_contract_plan_no;
                                    url += "&a5_contract_type_no[" + i + "]=" + row.a5_contract_type_no;
                                    url += "&a5_contract_alt_recur_fee[" + i + "]=" + row.a5_contract_alt_recur_fee;
                                    url += "&a5_contract_length_months[" + i + "]=" + row.a5_contract_length_months;
                                    url += "&a5_contract_cancel_fee[" + i + "]=" + row.a5_contract_cancel_fee;
                                    url += "&a5_contract_comments[" + i + "]=" + row.a5_contract_comments;
                                    url += "&a5_contract_start_date[" + i + "]=" + row.a5_contract_start_date;
                                    url += "&a5_contract_end_date[" + i + "]=" + row.a5_contract_end_date;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_new_acct_plan_contracts_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_new_acct_plan_contracts_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_contract_plan_no]=" + row.a5_contract_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[a5_contract_type_no]=" + row.a5_contract_type_no;
                                    url += paramPrefix + "[" + i + "]" + "[a5_contract_alt_recur_fee]=" + row.a5_contract_alt_recur_fee;
                                    url += paramPrefix + "[" + i + "]" + "[a5_contract_length_months]=" + row.a5_contract_length_months;
                                    url += paramPrefix + "[" + i + "]" + "[a5_contract_cancel_fee]=" + row.a5_contract_cancel_fee;
                                    url += paramPrefix + "[" + i + "]" + "[a5_contract_comments]=" + row.a5_contract_comments;
                                    url += paramPrefix + "[" + i + "]" + "[a5_contract_start_date]=" + row.a5_contract_start_date;
                                    url += paramPrefix + "[" + i + "]" + "[a5_contract_end_date]=" + row.a5_contract_end_date;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_usage_accumulation_config_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_usage_accumulation_config_row row = array[i];
                        url += "&a5_usage_accumulation_plan_no[" + i + "]=" + row.a5_usage_accumulation_plan_no;
                                    url += "&a5_usage_accumulation_reset_months[" + i + "]=" + row.a5_usage_accumulation_reset_months;
                                    url += "&a5_client_usg_accum_plan_id[" + i + "]=" + row.a5_client_usg_accum_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_usage_accumulation_config_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_usage_accumulation_config_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_usage_accumulation_plan_no]=" + row.a5_usage_accumulation_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[a5_usage_accumulation_reset_months]=" + row.a5_usage_accumulation_reset_months;
                                    url += paramPrefix + "[" + i + "]" + "[a5_client_usg_accum_plan_id]=" + row.a5_client_usg_accum_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_enable_usage_pooling_plan_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_enable_usage_pooling_plan_no_row row = array[i];
                        url += "&a5_enable_usage_pooling_plan_no[" + i + "]=" + row.a5_enable_usage_pooling_plan_no;
                                    url += "&a5_client_enable_usg_pool_plan_id[" + i + "]=" + row.a5_client_enable_usg_pool_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_enable_usage_pooling_plan_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_enable_usage_pooling_plan_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_enable_usage_pooling_plan_no]=" + row.a5_enable_usage_pooling_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[a5_client_enable_usg_pool_plan_id]=" + row.a5_client_enable_usg_pool_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_func_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_func_acct_group_ids_row row = array[i];
                        url += "&a5_client_func_acct_group_ids[" + i + "]=" + row.a5_client_func_acct_group_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_func_acct_group_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_func_acct_group_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_client_func_acct_group_ids]=" + row.a5_client_func_acct_group_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_coll_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_coll_acct_group_ids_row row = array[i];
                        url += "&a5_client_coll_acct_group_ids[" + i + "]=" + row.a5_client_coll_acct_group_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_coll_acct_group_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_coll_acct_group_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_client_coll_acct_group_ids]=" + row.a5_client_coll_acct_group_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_supp_plan_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_supp_plan_ids_row row = array[i];
                        url += "&a5_client_supp_plan_ids[" + i + "]=" + row.a5_client_supp_plan_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_supp_plan_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_supp_plan_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_client_supp_plan_ids]=" + row.a5_client_supp_plan_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_sp_alt_rate_sched_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_sp_alt_rate_sched_ids_row row = array[i];
                        url += "&a5_client_sp_alt_rate_sched_ids[" + i + "]=" + row.a5_client_sp_alt_rate_sched_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_sp_alt_rate_sched_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.a5_client_sp_alt_rate_sched_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[a5_client_sp_alt_rate_sched_ids]=" + row.a5_client_sp_alt_rate_sched_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.eligible_service_types_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.eligible_service_types_row row = array[i];
                        url += "&eligible_service_types[" + i + "]=" + row.eligible_service_types;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.eligible_service_types_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.eligible_service_types_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[eligible_service_types]=" + row.eligible_service_types;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_1_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_1_row row = array[i];
                        url += "&usage_qualifier_1[" + i + "]=" + row.usage_qualifier_1;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_1_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_1_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[usage_qualifier_1]=" + row.usage_qualifier_1;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_2_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_2_row row = array[i];
                        url += "&usage_qualifier_2[" + i + "]=" + row.usage_qualifier_2;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_2_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_2_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[usage_qualifier_2]=" + row.usage_qualifier_2;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_3_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_3_row row = array[i];
                        url += "&usage_qualifier_3[" + i + "]=" + row.usage_qualifier_3;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_3_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_3_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[usage_qualifier_3]=" + row.usage_qualifier_3;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_4_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_4_row row = array[i];
                        url += "&usage_qualifier_4[" + i + "]=" + row.usage_qualifier_4;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_4_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_qualifier_4_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[usage_qualifier_4]=" + row.usage_qualifier_4;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_acct_supp_field_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_acct_supp_field_row row = array[i];
                        url += "&supp_field_names[" + i + "]=" + row.supp_field_names;
                                    url += "&supp_field_values[" + i + "]=" + row.supp_field_values;
                                    url += "&supp_field_directives[" + i + "]=" + row.supp_field_directives;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_acct_supp_field_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_acct_supp_field_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[supp_field_names]=" + row.supp_field_names;
                                    url += paramPrefix + "[" + i + "]" + "[supp_field_values]=" + row.supp_field_values;
                                    url += paramPrefix + "[" + i + "]" + "[supp_field_directives]=" + row.supp_field_directives;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_acct_func_group_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_acct_func_group_row row = array[i];
                        url += "&functional_acct_groups[" + i + "]=" + row.functional_acct_groups;
                                    url += "&functional_group_directives[" + i + "]=" + row.functional_group_directives;
                                    url += "&client_func_acct_group_ids[" + i + "]=" + row.client_func_acct_group_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_acct_func_group_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_acct_func_group_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[functional_acct_groups]=" + row.functional_acct_groups;
                                    url += paramPrefix + "[" + i + "]" + "[functional_group_directives]=" + row.functional_group_directives;
                                    url += paramPrefix + "[" + i + "]" + "[client_func_acct_group_ids]=" + row.client_func_acct_group_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_acct_coll_group_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_acct_coll_group_row row = array[i];
                        url += "&collections_acct_groups[" + i + "]=" + row.collections_acct_groups;
                                    url += "&collections_group_directives[" + i + "]=" + row.collections_group_directives;
                                    url += "&client_coll_acct_group_ids[" + i + "]=" + row.client_coll_acct_group_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_acct_coll_group_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_acct_coll_group_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[collections_acct_groups]=" + row.collections_acct_groups;
                                    url += paramPrefix + "[" + i + "]" + "[collections_group_directives]=" + row.collections_group_directives;
                                    url += paramPrefix + "[" + i + "]" + "[client_coll_acct_group_ids]=" + row.client_coll_acct_group_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.disable_usage_pooling_plan_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.disable_usage_pooling_plan_no_row row = array[i];
                        url += "&disable_usage_pooling_plan_no[" + i + "]=" + row.disable_usage_pooling_plan_no;
                                    url += "&client_disable_usage_pool_plan_id[" + i + "]=" + row.client_disable_usage_pool_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.disable_usage_pooling_plan_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.disable_usage_pooling_plan_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[disable_usage_pooling_plan_no]=" + row.disable_usage_pooling_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[client_disable_usage_pool_plan_id]=" + row.client_disable_usage_pool_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_surcharge_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_surcharge_row row = array[i];
                        url += "&surcharge_no[" + i + "]=" + row.surcharge_no;
                                    url += "&surcharge_directive[" + i + "]=" + row.surcharge_directive;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_surcharge_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.update_surcharge_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[surcharge_no]=" + row.surcharge_no;
                                    url += paramPrefix + "[" + i + "]" + "[surcharge_directive]=" + row.surcharge_directive;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.custom_acct_rates_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.custom_acct_rates_row row = array[i];
                        url += "&rate_seq_no[" + i + "]=" + row.rate_seq_no;
                                    url += "&rate_per_unit[" + i + "]=" + row.rate_per_unit;
                                    url += "&from_unit[" + i + "]=" + row.from_unit;
                                    url += "&to_unit[" + i + "]=" + row.to_unit;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.custom_acct_rates_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.custom_acct_rates_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[rate_seq_no]=" + row.rate_seq_no;
                                    url += paramPrefix + "[" + i + "]" + "[rate_per_unit]=" + row.rate_per_unit;
                                    url += paramPrefix + "[" + i + "]" + "[from_unit]=" + row.from_unit;
                                    url += paramPrefix + "[" + i + "]" + "[to_unit]=" + row.to_unit;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.acct_supp_fields_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.acct_supp_fields_row row = array[i];
                        url += "&supp_field_name[" + i + "]=" + row.supp_field_name;
                                    url += "&supp_field_value[" + i + "]=" + row.supp_field_value;
                                    url += "&supp_field_directive[" + i + "]=" + row.supp_field_directive;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.acct_supp_fields_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.acct_supp_fields_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[supp_field_name]=" + row.supp_field_name;
                                    url += paramPrefix + "[" + i + "]" + "[supp_field_value]=" + row.supp_field_value;
                                    url += paramPrefix + "[" + i + "]" + "[supp_field_directive]=" + row.supp_field_directive;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plans_to_assign_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plans_to_assign_row row = array[i];
                        url += "&supp_plan_no[" + i + "]=" + row.supp_plan_no;
                                    url += "&alt_rate_schedule_no[" + i + "]=" + row.alt_rate_schedule_no;
                                    url += "&num_plan_units[" + i + "]=" + row.num_plan_units;
                                    url += "&contract_type_no[" + i + "]=" + row.contract_type_no;
                                    url += "&contract_alt_recur_fee[" + i + "]=" + row.contract_alt_recur_fee;
                                    url += "&contract_length_months[" + i + "]=" + row.contract_length_months;
                                    url += "&contract_cancel_fee[" + i + "]=" + row.contract_cancel_fee;
                                    url += "&contract_comments[" + i + "]=" + row.contract_comments;
                                    url += "&contract_start_date[" + i + "]=" + row.contract_start_date;
                                    url += "&offset_months[" + i + "]=" + row.offset_months;
                                    url += "&auto_offset_months_option[" + i + "]=" + row.auto_offset_months_option;
                                    url += "&offset_interval[" + i + "]=" + row.offset_interval;
                                    url += "&contract_end_date[" + i + "]=" + row.contract_end_date;
                                    url += "&client_supp_plan_id[" + i + "]=" + row.client_supp_plan_id;
                                    url += "&client_alt_rate_schedule_id[" + i + "]=" + row.client_alt_rate_schedule_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plans_to_assign_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.supp_plans_to_assign_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[supp_plan_no]=" + row.supp_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[alt_rate_schedule_no]=" + row.alt_rate_schedule_no;
                                    url += paramPrefix + "[" + i + "]" + "[num_plan_units]=" + row.num_plan_units;
                                    url += paramPrefix + "[" + i + "]" + "[contract_type_no]=" + row.contract_type_no;
                                    url += paramPrefix + "[" + i + "]" + "[contract_alt_recur_fee]=" + row.contract_alt_recur_fee;
                                    url += paramPrefix + "[" + i + "]" + "[contract_length_months]=" + row.contract_length_months;
                                    url += paramPrefix + "[" + i + "]" + "[contract_cancel_fee]=" + row.contract_cancel_fee;
                                    url += paramPrefix + "[" + i + "]" + "[contract_comments]=" + row.contract_comments;
                                    url += paramPrefix + "[" + i + "]" + "[contract_start_date]=" + row.contract_start_date;
                                    url += paramPrefix + "[" + i + "]" + "[offset_months]=" + row.offset_months;
                                    url += paramPrefix + "[" + i + "]" + "[auto_offset_months_option]=" + row.auto_offset_months_option;
                                    url += paramPrefix + "[" + i + "]" + "[offset_interval]=" + row.offset_interval;
                                    url += paramPrefix + "[" + i + "]" + "[contract_end_date]=" + row.contract_end_date;
                                    url += paramPrefix + "[" + i + "]" + "[client_supp_plan_id]=" + row.client_supp_plan_id;
                                    url += paramPrefix + "[" + i + "]" + "[client_alt_rate_schedule_id]=" + row.client_alt_rate_schedule_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.credit_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.credit_ids_row row = array[i];
                        url += "&credit_ids[" + i + "]=" + row.credit_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.credit_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.credit_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[credit_ids]=" + row.credit_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plan_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plan_no_row row = array[i];
                        url += "&plan_no[" + i + "]=" + row.plan_no;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plan_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plan_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[plan_no]=" + row.plan_no;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_plan_id_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_plan_id_row row = array[i];
                        url += "&client_plan_id[" + i + "]=" + row.client_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_plan_id_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_plan_id_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[client_plan_id]=" + row.client_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plans_input_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plans_input_row row = array[i];
                        url += "&plan_no[" + i + "]=" + row.plan_no;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plans_input_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plans_input_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[plan_no]=" + row.plan_no;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plans_to_get_outage_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plans_to_get_outage_row row = array[i];
                        url += "&plan_no[" + i + "]=" + row.plan_no;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plans_to_get_outage_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.plans_to_get_outage_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[plan_no]=" + row.plan_no;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_plan_ids_to_get_outage_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_plan_ids_to_get_outage_row row = array[i];
                        url += "&client_plan_ids_to_get_outage[" + i + "]=" + row.client_plan_ids_to_get_outage;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_plan_ids_to_get_outage_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_plan_ids_to_get_outage_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[client_plan_ids_to_get_outage]=" + row.client_plan_ids_to_get_outage;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.order_line_items_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.order_line_items_row row = array[i];
                        url += "&client_sku[" + i + "]=" + row.client_sku;
                                    url += "&units[" + i + "]=" + row.units;
                                    url += "&amount[" + i + "]=" + row.amount;
                                    url += "&unit_discount_amount[" + i + "]=" + row.unit_discount_amount;
                                    url += "&line_comments[" + i + "]=" + row.line_comments;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.order_line_items_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.order_line_items_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[client_sku]=" + row.client_sku;
                                    url += paramPrefix + "[" + i + "]" + "[units]=" + row.units;
                                    url += paramPrefix + "[" + i + "]" + "[amount]=" + row.amount;
                                    url += paramPrefix + "[" + i + "]" + "[unit_discount_amount]=" + row.unit_discount_amount;
                                    url += paramPrefix + "[" + i + "]" + "[line_comments]=" + row.line_comments;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.specific_charge_transaction_id_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.specific_charge_transaction_id_row row = array[i];
                        url += "&specific_charge_transaction_id[" + i + "]=" + row.specific_charge_transaction_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.specific_charge_transaction_id_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.specific_charge_transaction_id_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[specific_charge_transaction_id]=" + row.specific_charge_transaction_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.standing_order_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.standing_order_row row = array[i];
                        url += "&client_sku[" + i + "]=" + row.client_sku;
                                    url += "&units[" + i + "]=" + row.units;
                                    url += "&amount[" + i + "]=" + row.amount;
                                    url += "&unit_discount_amount[" + i + "]=" + row.unit_discount_amount;
                                    url += "&line_comments[" + i + "]=" + row.line_comments;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.standing_order_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.standing_order_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[client_sku]=" + row.client_sku;
                                    url += paramPrefix + "[" + i + "]" + "[units]=" + row.units;
                                    url += paramPrefix + "[" + i + "]" + "[amount]=" + row.amount;
                                    url += paramPrefix + "[" + i + "]" + "[unit_discount_amount]=" + row.unit_discount_amount;
                                    url += paramPrefix + "[" + i + "]" + "[line_comments]=" + row.line_comments;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_records_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_records_row row = array[i];
                        url += "&acct_no[" + i + "]=" + row.acct_no;
                                    url += "&userid[" + i + "]=" + row.userid;
                                    url += "&usage_type[" + i + "]=" + row.usage_type;
                                    url += "&usage_units[" + i + "]=" + row.usage_units;
                                    url += "&usage_date[" + i + "]=" + row.usage_date;
                                    url += "&billable_units[" + i + "]=" + row.billable_units;
                                    url += "&amt[" + i + "]=" + row.amt;
                                    url += "&rate[" + i + "]=" + row.rate;
                                    url += "&telco_from[" + i + "]=" + row.telco_from;
                                    url += "&telco_to[" + i + "]=" + row.telco_to;
                                    url += "&comments[" + i + "]=" + row.comments;
                                    url += "&exclude_from_billing[" + i + "]=" + row.exclude_from_billing;
                                    url += "&exclusion_comments[" + i + "]=" + row.exclusion_comments;
                                    url += "&parent_usage_rec_no[" + i + "]=" + row.parent_usage_rec_no;
                                    url += "&qualifier_1[" + i + "]=" + row.qualifier_1;
                                    url += "&qualifier_2[" + i + "]=" + row.qualifier_2;
                                    url += "&qualifier_3[" + i + "]=" + row.qualifier_3;
                                    url += "&qualifier_4[" + i + "]=" + row.qualifier_4;
                                    url += "&usage_type_code[" + i + "]=" + row.usage_type_code;
                                    url += "&client_record_id[" + i + "]=" + row.client_record_id;
                                    url += "&caller_id[" + i + "]=" + row.caller_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_records_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_records_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[acct_no]=" + row.acct_no;
                                    url += paramPrefix + "[" + i + "]" + "[userid]=" + row.userid;
                                    url += paramPrefix + "[" + i + "]" + "[usage_type]=" + row.usage_type;
                                    url += paramPrefix + "[" + i + "]" + "[usage_units]=" + row.usage_units;
                                    url += paramPrefix + "[" + i + "]" + "[usage_date]=" + row.usage_date;
                                    url += paramPrefix + "[" + i + "]" + "[billable_units]=" + row.billable_units;
                                    url += paramPrefix + "[" + i + "]" + "[amt]=" + row.amt;
                                    url += paramPrefix + "[" + i + "]" + "[rate]=" + row.rate;
                                    url += paramPrefix + "[" + i + "]" + "[telco_from]=" + row.telco_from;
                                    url += paramPrefix + "[" + i + "]" + "[telco_to]=" + row.telco_to;
                                    url += paramPrefix + "[" + i + "]" + "[comments]=" + row.comments;
                                    url += paramPrefix + "[" + i + "]" + "[exclude_from_billing]=" + row.exclude_from_billing;
                                    url += paramPrefix + "[" + i + "]" + "[exclusion_comments]=" + row.exclusion_comments;
                                    url += paramPrefix + "[" + i + "]" + "[parent_usage_rec_no]=" + row.parent_usage_rec_no;
                                    url += paramPrefix + "[" + i + "]" + "[qualifier_1]=" + row.qualifier_1;
                                    url += paramPrefix + "[" + i + "]" + "[qualifier_2]=" + row.qualifier_2;
                                    url += paramPrefix + "[" + i + "]" + "[qualifier_3]=" + row.qualifier_3;
                                    url += paramPrefix + "[" + i + "]" + "[qualifier_4]=" + row.qualifier_4;
                                    url += paramPrefix + "[" + i + "]" + "[usage_type_code]=" + row.usage_type_code;
                                    url += paramPrefix + "[" + i + "]" + "[client_record_id]=" + row.client_record_id;
                                    url += paramPrefix + "[" + i + "]" + "[caller_id]=" + row.caller_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.pre_calc_plan_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.pre_calc_plan_row row = array[i];
                        url += "&plan_item_service_no[" + i + "]=" + row.plan_item_service_no;
                                    url += "&plan_item_plan_no[" + i + "]=" + row.plan_item_plan_no;
                                    url += "&plan_item_units[" + i + "]=" + row.plan_item_units;
                                    url += "&plan_item_unit_amount[" + i + "]=" + row.plan_item_unit_amount;
                                    url += "&client_plan_item_service_id[" + i + "]=" + row.client_plan_item_service_id;
                                    url += "&client_plan_item_plan_id[" + i + "]=" + row.client_plan_item_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.pre_calc_plan_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.pre_calc_plan_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[plan_item_service_no]=" + row.plan_item_service_no;
                                    url += paramPrefix + "[" + i + "]" + "[plan_item_plan_no]=" + row.plan_item_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[plan_item_units]=" + row.plan_item_units;
                                    url += paramPrefix + "[" + i + "]" + "[plan_item_unit_amount]=" + row.plan_item_unit_amount;
                                    url += paramPrefix + "[" + i + "]" + "[client_plan_item_service_id]=" + row.client_plan_item_service_id;
                                    url += paramPrefix + "[" + i + "]" + "[client_plan_item_plan_id]=" + row.client_plan_item_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.pre_calc_sku_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.pre_calc_sku_row row = array[i];
                        url += "&sku[" + i + "]=" + row.sku;
                                    url += "&sku_plan_no[" + i + "]=" + row.sku_plan_no;
                                    url += "&sku_units[" + i + "]=" + row.sku_units;
                                    url += "&sku_unit_amount[" + i + "]=" + row.sku_unit_amount;
                                    url += "&client_sku_plan_id[" + i + "]=" + row.client_sku_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.pre_calc_sku_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.pre_calc_sku_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[sku]=" + row.sku;
                                    url += paramPrefix + "[" + i + "]" + "[sku_plan_no]=" + row.sku_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[sku_units]=" + row.sku_units;
                                    url += paramPrefix + "[" + i + "]" + "[sku_unit_amount]=" + row.sku_unit_amount;
                                    url += paramPrefix + "[" + i + "]" + "[client_sku_plan_id]=" + row.client_sku_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.cart_supp_plans_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.cart_supp_plans_row row = array[i];
                        url += "&supp_plan_no[" + i + "]=" + row.supp_plan_no;
                                    url += "&supp_plan_units[" + i + "]=" + row.supp_plan_units;
                                    url += "&assignment_directive[" + i + "]=" + row.assignment_directive;
                                    url += "&client_supp_plan_ids[" + i + "]=" + row.client_supp_plan_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.cart_supp_plans_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.cart_supp_plans_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[supp_plan_no]=" + row.supp_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[supp_plan_units]=" + row.supp_plan_units;
                                    url += paramPrefix + "[" + i + "]" + "[assignment_directive]=" + row.assignment_directive;
                                    url += paramPrefix + "[" + i + "]" + "[client_supp_plan_ids]=" + row.client_supp_plan_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.multiple_coupons_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.multiple_coupons_row row = array[i];
                        url += "&coupon_codes[" + i + "]=" + row.coupon_codes;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.multiple_coupons_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.multiple_coupons_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[coupon_codes]=" + row.coupon_codes;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.invoices_to_reverse_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.invoices_to_reverse_row row = array[i];
                        url += "&invoice_no[" + i + "]=" + row.invoice_no;
                                    url += "&invoice_line_no[" + i + "]=" + row.invoice_line_no;
                                    url += "&invoice_line_reversing_amount[" + i + "]=" + row.invoice_line_reversing_amount;
                                    url += "&invoice_line_reversing_date[" + i + "]=" + row.invoice_line_reversing_date;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.invoices_to_reverse_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.invoices_to_reverse_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[invoice_no]=" + row.invoice_no;
                                    url += paramPrefix + "[" + i + "]" + "[invoice_line_no]=" + row.invoice_line_no;
                                    url += paramPrefix + "[" + i + "]" + "[invoice_line_reversing_amount]=" + row.invoice_line_reversing_amount;
                                    url += paramPrefix + "[" + i + "]" + "[invoice_line_reversing_date]=" + row.invoice_line_reversing_date;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_record_nos_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_record_nos_row row = array[i];
                        url += "&usage_record_no[" + i + "]=" + row.usage_record_no;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_record_nos_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.usage_record_nos_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[usage_record_no]=" + row.usage_record_no;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_record_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_record_ids_row row = array[i];
                        url += "&client_record_id[" + i + "]=" + row.client_record_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_record_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaComplete.client_record_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[client_record_id]=" + row.client_record_id;
                        
        }
    }

            public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_row row = array[i];
                        url += "&service_no[" + i + "]=" + row.service_no;
                                    url += "&pricing_rule[" + i + "]=" + row.pricing_rule;
                                    url += "&high_water[" + i + "]=" + row.high_water;
                                    url += "&billing_option[" + i + "]=" + row.billing_option;
                                    url += "&threshold[" + i + "]=" + row.threshold;
                                    addParameterValuesFromArray(ref url, row.tier,  "&tier[" + i + "]");
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[service_no]=" + row.service_no;
                                    url += paramPrefix + "[" + i + "]" + "[pricing_rule]=" + row.pricing_rule;
                                    url += paramPrefix + "[" + i + "]" + "[high_water]=" + row.high_water;
                                    url += paramPrefix + "[" + i + "]" + "[billing_option]=" + row.billing_option;
                                    url += paramPrefix + "[" + i + "]" + "[threshold]=" + row.threshold;
                                    addParameterValuesFromArray(ref url, row.tier,  paramPrefix + "[" + i + "]" + "[tier]");
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.image_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.image_row row = array[i];
                        url += "&main_image_url[" + i + "]=" + row.main_image_url;
                                    url += "&thumbnail_image_url[" + i + "]=" + row.thumbnail_image_url;
                                    url += "&image_text[" + i + "]=" + row.image_text;
                                    url += "&default_ind[" + i + "]=" + row.default_ind;
                                    url += "&active[" + i + "]=" + row.active;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.image_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.image_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[main_image_url]=" + row.main_image_url;
                                    url += paramPrefix + "[" + i + "]" + "[thumbnail_image_url]=" + row.thumbnail_image_url;
                                    url += paramPrefix + "[" + i + "]" + "[image_text]=" + row.image_text;
                                    url += paramPrefix + "[" + i + "]" + "[default_ind]=" + row.default_ind;
                                    url += paramPrefix + "[" + i + "]" + "[active]=" + row.active;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_class_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_class_row row = array[i];
                        url += "&class_no[" + i + "]=" + row.class_no;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_class_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_class_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[class_no]=" + row.class_no;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.supplemental_obj_field_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.supplemental_obj_field_row row = array[i];
                        url += "&supplemental_obj_field[" + i + "]=" + row.supplemental_obj_field;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.supplemental_obj_field_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.supplemental_obj_field_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[supplemental_obj_field]=" + row.supplemental_obj_field;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rules_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rules_row row = array[i];
                        url += "&rule[" + i + "]=" + row.rule;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rules_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rules_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[rule]=" + row.rule;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rule_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rule_ids_row row = array[i];
                        url += "&rule_id[" + i + "]=" + row.rule_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rule_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rule_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[rule_id]=" + row.rule_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_no_row row = array[i];
                        url += "&plan_nos[" + i + "]=" + row.plan_nos;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[plan_nos]=" + row.plan_nos;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_plan_id_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_plan_id_row row = array[i];
                        url += "&client_plan_ids[" + i + "]=" + row.client_plan_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_plan_id_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_plan_id_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[client_plan_ids]=" + row.client_plan_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_no_row row = array[i];
                        url += "&service_nos[" + i + "]=" + row.service_nos;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[service_nos]=" + row.service_nos;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_service_id_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_service_id_row row = array[i];
                        url += "&client_service_ids[" + i + "]=" + row.client_service_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_service_id_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_service_id_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[client_service_ids]=" + row.client_service_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.item_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.item_no_row row = array[i];
                        url += "&item_nos[" + i + "]=" + row.item_nos;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.item_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.item_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[item_nos]=" + row.item_nos;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_item_id_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_item_id_row row = array[i];
                        url += "&client_item_ids[" + i + "]=" + row.client_item_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_item_id_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_item_id_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[client_item_ids]=" + row.client_item_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.eligible_service_types_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.eligible_service_types_row row = array[i];
                        url += "&eligible_service_type[" + i + "]=" + row.eligible_service_type;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.eligible_service_types_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.eligible_service_types_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[eligible_service_type]=" + row.eligible_service_type;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.template_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.template_row row = array[i];
                        url += "&credit_template_name[" + i + "]=" + row.credit_template_name;
                                    url += "&client_credit_template_id[" + i + "]=" + row.client_credit_template_id;
                                    url += "&eligible_plan_no[" + i + "]=" + row.eligible_plan_no;
                                    url += "&eligible_client_plan_id[" + i + "]=" + row.eligible_client_plan_id;
                                    url += "&eligible_service_no[" + i + "]=" + row.eligible_service_no;
                                    url += "&eligible_client_service_id[" + i + "]=" + row.eligible_client_service_id;
                                    addParameterValuesFromArray(ref url, row.eligible_service_types,  "&eligible_service_types[" + i + "]");
                                    url += "&discount_type[" + i + "]=" + row.discount_type;
                                    url += "&discount_amt[" + i + "]=" + row.discount_amt;
                                    url += "&no_of_credits[" + i + "]=" + row.no_of_credits;
                                    url += "&credit_interval_months[" + i + "]=" + row.credit_interval_months;
                                    url += "&percentage_plan_no[" + i + "]=" + row.percentage_plan_no;
                                    url += "&percentage_client_plan_id[" + i + "]=" + row.percentage_client_plan_id;
                                    url += "&percentage_service_no[" + i + "]=" + row.percentage_service_no;
                                    url += "&percentage_client_service_id[" + i + "]=" + row.percentage_client_service_id;
                                    url += "&alt_service_no[" + i + "]=" + row.alt_service_no;
                                    url += "&alt_client_service_id[" + i + "]=" + row.alt_client_service_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.template_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.template_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[credit_template_name]=" + row.credit_template_name;
                                    url += paramPrefix + "[" + i + "]" + "[client_credit_template_id]=" + row.client_credit_template_id;
                                    url += paramPrefix + "[" + i + "]" + "[eligible_plan_no]=" + row.eligible_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[eligible_client_plan_id]=" + row.eligible_client_plan_id;
                                    url += paramPrefix + "[" + i + "]" + "[eligible_service_no]=" + row.eligible_service_no;
                                    url += paramPrefix + "[" + i + "]" + "[eligible_client_service_id]=" + row.eligible_client_service_id;
                                    addParameterValuesFromArray(ref url, row.eligible_service_types,  paramPrefix + "[" + i + "]" + "[eligible_service_types]");
                                    url += paramPrefix + "[" + i + "]" + "[discount_type]=" + row.discount_type;
                                    url += paramPrefix + "[" + i + "]" + "[discount_amt]=" + row.discount_amt;
                                    url += paramPrefix + "[" + i + "]" + "[no_of_credits]=" + row.no_of_credits;
                                    url += paramPrefix + "[" + i + "]" + "[credit_interval_months]=" + row.credit_interval_months;
                                    url += paramPrefix + "[" + i + "]" + "[percentage_plan_no]=" + row.percentage_plan_no;
                                    url += paramPrefix + "[" + i + "]" + "[percentage_client_plan_id]=" + row.percentage_client_plan_id;
                                    url += paramPrefix + "[" + i + "]" + "[percentage_service_no]=" + row.percentage_service_no;
                                    url += paramPrefix + "[" + i + "]" + "[percentage_client_service_id]=" + row.percentage_client_service_id;
                                    url += paramPrefix + "[" + i + "]" + "[alt_service_no]=" + row.alt_service_no;
                                    url += paramPrefix + "[" + i + "]" + "[alt_client_service_id]=" + row.alt_client_service_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_template_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_template_row row = array[i];
                        url += "&existing_templates[" + i + "]=" + row.existing_templates;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_template_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_template_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[existing_templates]=" + row.existing_templates;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_template_id_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_template_id_row row = array[i];
                        url += "&existing_template_ids[" + i + "]=" + row.existing_template_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_template_id_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_template_id_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[existing_template_ids]=" + row.existing_template_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.discount_rule_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.discount_rule_row row = array[i];
                        url += "&label[" + i + "]=" + row.label;
                                    url += "&rule_id[" + i + "]=" + row.rule_id;
                                    url += "&description[" + i + "]=" + row.description;
                                    url += "&ext_description[" + i + "]=" + row.ext_description;
                                    url += "&flat_percent_ind[" + i + "]=" + row.flat_percent_ind;
                                    url += "&amount[" + i + "]=" + row.amount;
                                    url += "&currency[" + i + "]=" + row.currency;
                                    url += "&duration_type_ind[" + i + "]=" + row.duration_type_ind;
                                    url += "&max_applicable_months[" + i + "]=" + row.max_applicable_months;
                                    url += "&max_applications_per_acct[" + i + "]=" + row.max_applications_per_acct;
                                    url += "&inline_offset_ind[" + i + "]=" + row.inline_offset_ind;
                                    url += "&service_code_to_use[" + i + "]=" + row.service_code_to_use;
                                    url += "&alt_service_no_2_apply[" + i + "]=" + row.alt_service_no_2_apply;
                                    url += "&alt_service_id_2_apply[" + i + "]=" + row.alt_service_id_2_apply;
                                    url += "&applicable_trans_scope[" + i + "]=" + row.applicable_trans_scope;
                                    url += "&scope_no[" + i + "]=" + row.scope_no;
                                    addParameterValuesFromArray(ref url, row.plan_no,  "&plan_no[" + i + "]");
                                    addParameterValuesFromArray(ref url, row.client_plan_id,  "&client_plan_id[" + i + "]");
                                    addParameterValuesFromArray(ref url, row.service_no,  "&service_no[" + i + "]");
                                    addParameterValuesFromArray(ref url, row.client_service_id,  "&client_service_id[" + i + "]");
                                    addParameterValuesFromArray(ref url, row.item_no,  "&item_no[" + i + "]");
                                    addParameterValuesFromArray(ref url, row.client_item_id,  "&client_item_id[" + i + "]");
                                    url += "&use_all_or_nth_subs_rule[" + i + "]=" + row.use_all_or_nth_subs_rule;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.discount_rule_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.discount_rule_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[label]=" + row.label;
                                    url += paramPrefix + "[" + i + "]" + "[rule_id]=" + row.rule_id;
                                    url += paramPrefix + "[" + i + "]" + "[description]=" + row.description;
                                    url += paramPrefix + "[" + i + "]" + "[ext_description]=" + row.ext_description;
                                    url += paramPrefix + "[" + i + "]" + "[flat_percent_ind]=" + row.flat_percent_ind;
                                    url += paramPrefix + "[" + i + "]" + "[amount]=" + row.amount;
                                    url += paramPrefix + "[" + i + "]" + "[currency]=" + row.currency;
                                    url += paramPrefix + "[" + i + "]" + "[duration_type_ind]=" + row.duration_type_ind;
                                    url += paramPrefix + "[" + i + "]" + "[max_applicable_months]=" + row.max_applicable_months;
                                    url += paramPrefix + "[" + i + "]" + "[max_applications_per_acct]=" + row.max_applications_per_acct;
                                    url += paramPrefix + "[" + i + "]" + "[inline_offset_ind]=" + row.inline_offset_ind;
                                    url += paramPrefix + "[" + i + "]" + "[service_code_to_use]=" + row.service_code_to_use;
                                    url += paramPrefix + "[" + i + "]" + "[alt_service_no_2_apply]=" + row.alt_service_no_2_apply;
                                    url += paramPrefix + "[" + i + "]" + "[alt_service_id_2_apply]=" + row.alt_service_id_2_apply;
                                    url += paramPrefix + "[" + i + "]" + "[applicable_trans_scope]=" + row.applicable_trans_scope;
                                    url += paramPrefix + "[" + i + "]" + "[scope_no]=" + row.scope_no;
                                    addParameterValuesFromArray(ref url, row.plan_no,  paramPrefix + "[" + i + "]" + "[plan_no]");
                                    addParameterValuesFromArray(ref url, row.client_plan_id,  paramPrefix + "[" + i + "]" + "[client_plan_id]");
                                    addParameterValuesFromArray(ref url, row.service_no,  paramPrefix + "[" + i + "]" + "[service_no]");
                                    addParameterValuesFromArray(ref url, row.client_service_id,  paramPrefix + "[" + i + "]" + "[client_service_id]");
                                    addParameterValuesFromArray(ref url, row.item_no,  paramPrefix + "[" + i + "]" + "[item_no]");
                                    addParameterValuesFromArray(ref url, row.client_item_id,  paramPrefix + "[" + i + "]" + "[client_item_id]");
                                    url += paramPrefix + "[" + i + "]" + "[use_all_or_nth_subs_rule]=" + row.use_all_or_nth_subs_rule;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_rule_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_rule_row row = array[i];
                        url += "&existing_rules[" + i + "]=" + row.existing_rules;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_rule_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_rule_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[existing_rules]=" + row.existing_rules;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_rule_id_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_rule_id_row row = array[i];
                        url += "&existing_discount_rule_ids[" + i + "]=" + row.existing_discount_rule_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_rule_id_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_rule_id_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[existing_discount_rule_ids]=" + row.existing_discount_rule_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.discount_bundle_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.discount_bundle_row row = array[i];
                        url += "&bundle_name[" + i + "]=" + row.bundle_name;
                                    url += "&bundle_id[" + i + "]=" + row.bundle_id;
                                    url += "&bundle_description[" + i + "]=" + row.bundle_description;
                                    url += "&allow_overlap_ind[" + i + "]=" + row.allow_overlap_ind;
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
                        url += paramPrefix + "[" + i + "]" + "[bundle_name]=" + row.bundle_name;
                                    url += paramPrefix + "[" + i + "]" + "[bundle_id]=" + row.bundle_id;
                                    url += paramPrefix + "[" + i + "]" + "[bundle_description]=" + row.bundle_description;
                                    url += paramPrefix + "[" + i + "]" + "[allow_overlap_ind]=" + row.allow_overlap_ind;
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
                        url += "&existing_bundles[" + i + "]=" + row.existing_bundles;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_bundle_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_bundle_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[existing_bundles]=" + row.existing_bundles;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_bundle_id_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_bundle_id_row row = array[i];
                        url += "&existing_bundle_ids[" + i + "]=" + row.existing_bundle_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_bundle_id_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_bundle_id_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[existing_bundle_ids]=" + row.existing_bundle_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coupon_nos_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coupon_nos_row row = array[i];
                        url += "&coupon_nos[" + i + "]=" + row.coupon_nos;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coupon_nos_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coupon_nos_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[coupon_nos]=" + row.coupon_nos;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coupon_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coupon_row row = array[i];
                        url += "&coupon_cd[" + i + "]=" + row.coupon_cd;
                                    url += "&coupon_desc[" + i + "]=" + row.coupon_desc;
                                    url += "&coupon_msg[" + i + "]=" + row.coupon_msg;
                                    url += "&status_ind[" + i + "]=" + row.status_ind;
                                    url += "&no_of_uses[" + i + "]=" + row.no_of_uses;
                                    url += "&start_date[" + i + "]=" + row.start_date;
                                    url += "&end_date[" + i + "]=" + row.end_date;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coupon_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coupon_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[coupon_cd]=" + row.coupon_cd;
                                    url += paramPrefix + "[" + i + "]" + "[coupon_desc]=" + row.coupon_desc;
                                    url += paramPrefix + "[" + i + "]" + "[coupon_msg]=" + row.coupon_msg;
                                    url += paramPrefix + "[" + i + "]" + "[status_ind]=" + row.status_ind;
                                    url += paramPrefix + "[" + i + "]" + "[no_of_uses]=" + row.no_of_uses;
                                    url += paramPrefix + "[" + i + "]" + "[start_date]=" + row.start_date;
                                    url += paramPrefix + "[" + i + "]" + "[end_date]=" + row.end_date;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_coupon_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_coupon_row row = array[i];
                        url += "&existing_coupons[" + i + "]=" + row.existing_coupons;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_coupon_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_coupon_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[existing_coupons]=" + row.existing_coupons;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.template_nos_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.template_nos_row row = array[i];
                        url += "&template_nos[" + i + "]=" + row.template_nos;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.template_nos_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.template_nos_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[template_nos]=" + row.template_nos;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rule_nos_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rule_nos_row row = array[i];
                        url += "&rule_nos[" + i + "]=" + row.rule_nos;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rule_nos_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rule_nos_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[rule_nos]=" + row.rule_nos;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.bundle_nos_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.bundle_nos_row row = array[i];
                        url += "&bundle_nos[" + i + "]=" + row.bundle_nos;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.bundle_nos_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.bundle_nos_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[bundle_nos]=" + row.bundle_nos;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.price_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.price_row row = array[i];
                        url += "&amount[" + i + "]=" + row.amount;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.price_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.price_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[amount]=" + row.amount;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.tier_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.tier_row row = array[i];
                        url += "&from[" + i + "]=" + row.from;
                                    url += "&to[" + i + "]=" + row.to;
                                    url += "&rate[" + i + "]=" + row.rate;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.tier_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.tier_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[from]=" + row.from;
                                    url += paramPrefix + "[" + i + "]" + "[to]=" + row.to;
                                    url += paramPrefix + "[" + i + "]" + "[rate]=" + row.rate;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_group_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_group_row row = array[i];
                        url += "&plan_group[" + i + "]=" + row.plan_group;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_group_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_group_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[plan_group]=" + row.plan_group;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_group_id_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_group_id_row row = array[i];
                        url += "&plan_group_id[" + i + "]=" + row.plan_group_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_group_id_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_group_id_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[plan_group_id]=" + row.plan_group_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.schedule_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.schedule_row row = array[i];
                        url += "&schedule_no[" + i + "]=" + row.schedule_no;
                                    url += "&schedule_name[" + i + "]=" + row.schedule_name;
                                    url += "&client_rate_schedule_id[" + i + "]=" + row.client_rate_schedule_id;
                                    url += "&currency_cd[" + i + "]=" + row.currency_cd;
                                    url += "&is_default[" + i + "]=" + row.is_default;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.schedule_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.schedule_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[schedule_no]=" + row.schedule_no;
                                    url += paramPrefix + "[" + i + "]" + "[schedule_name]=" + row.schedule_name;
                                    url += paramPrefix + "[" + i + "]" + "[client_rate_schedule_id]=" + row.client_rate_schedule_id;
                                    url += paramPrefix + "[" + i + "]" + "[currency_cd]=" + row.currency_cd;
                                    url += paramPrefix + "[" + i + "]" + "[is_default]=" + row.is_default;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.resource_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.resource_row row = array[i];
                        url += "&resource_no[" + i + "]=" + row.resource_no;
                                    url += "&resource_name[" + i + "]=" + row.resource_name;
                                    url += "&resource_description[" + i + "]=" + row.resource_description;
                                    url += "&flat_threshold[" + i + "]=" + row.flat_threshold;
                                    url += "&resource_units[" + i + "]=" + row.resource_units;
                                    url += "&expire_on_paid_through[" + i + "]=" + row.expire_on_paid_through;
                                    url += "&additional_days[" + i + "]=" + row.additional_days;
                                    url += "&reset_on_update[" + i + "]=" + row.reset_on_update;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.resource_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.resource_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[resource_no]=" + row.resource_no;
                                    url += paramPrefix + "[" + i + "]" + "[resource_name]=" + row.resource_name;
                                    url += paramPrefix + "[" + i + "]" + "[resource_description]=" + row.resource_description;
                                    url += paramPrefix + "[" + i + "]" + "[flat_threshold]=" + row.flat_threshold;
                                    url += paramPrefix + "[" + i + "]" + "[resource_units]=" + row.resource_units;
                                    url += paramPrefix + "[" + i + "]" + "[expire_on_paid_through]=" + row.expire_on_paid_through;
                                    url += paramPrefix + "[" + i + "]" + "[additional_days]=" + row.additional_days;
                                    url += paramPrefix + "[" + i + "]" + "[reset_on_update]=" + row.reset_on_update;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_plans_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_plans_row row = array[i];
                        url += "&parent_plan[" + i + "]=" + row.parent_plan;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_plans_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_plans_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[parent_plan]=" + row.parent_plan;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_client_plan_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_client_plan_ids_row row = array[i];
                        url += "&parent_client_plan_id[" + i + "]=" + row.parent_client_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_client_plan_ids_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_client_plan_ids_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[parent_client_plan_id]=" + row.parent_client_plan_id;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.exclusion_plans_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.exclusion_plans_row row = array[i];
                        url += "&exclusion_plans[" + i + "]=" + row.exclusion_plans;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.exclusion_plans_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.exclusion_plans_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[exclusion_plans]=" + row.exclusion_plans;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.child_plans_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.child_plans_row row = array[i];
                        url += "&child_plan[" + i + "]=" + row.child_plan;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.child_plans_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.child_plans_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[child_plan]=" + row.child_plan;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.surcharge_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.surcharge_no_row row = array[i];
                        url += "&surcharge_nos[" + i + "]=" + row.surcharge_nos;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.surcharge_no_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.surcharge_no_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[surcharge_nos]=" + row.surcharge_nos;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_surcharge_id_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_surcharge_id_row row = array[i];
                        url += "&client_surcharge_ids[" + i + "]=" + row.client_surcharge_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_surcharge_id_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_surcharge_id_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[client_surcharge_ids]=" + row.client_surcharge_ids;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_nos_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_nos_row row = array[i];
                        url += "&plan_nos[" + i + "]=" + row.plan_nos;
                        
        }
    }

    public static void addParameterValuesFromArray(ref string url, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_nos_row[] array, string paramPrefix)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_nos_row row = array[i];
                        url += paramPrefix + "[" + i + "]" + "[plan_nos]=" + row.plan_nos;
                        
        }
    }

            /* ****************** END - ARRAY TO PARM METHODS FOR EACH ARRAY ELEMENT **************************************** */
    }
}
