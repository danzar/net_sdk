using Aria.SDK.AriaServices.AriaWebServices.AriaComplete;

namespace Aria.SDK.AriaServices.AriaWebServices
{
    class RestUtilities
    {
    /* ****************** ARRAY TO PARM METHODS FOR EACH ARRAY ELEMENT ********************************************** */
    public static void addParameterValuesFromArray(ref string url, supp_field_names_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            supp_field_names_row row = array[i];
            url += "&supp_field_names[" + i + "]=" + row.supp_field_names;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, supp_field_values_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            supp_field_values_row row = array[i];
            url += "&supp_field_values[" + i + "]=" + row.supp_field_values;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, web_vals_in_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            web_vals_in_row row = array[i];
            url += "&in_replacement_names[" + i + "]=" + row.in_replacement_names;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, event_list_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            event_list_row row = array[i];
            url += "&event_list[" + i + "]=" + row.event_list;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, in_reg_uss_params_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            in_reg_uss_params_row row = array[i];
            url += "&param_name[" + i + "]=" + row.param_name;
            url += "&param_val[" + i + "]=" + row.param_val;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, param_names_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            param_names_row row = array[i];
            url += "&param_name[" + i + "]=" + row.param_name;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, in_reg_uss_config_params_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            in_reg_uss_config_params_row row = array[i];
            url += "&param_name[" + i + "]=" + row.param_name;
            url += "&param_val[" + i + "]=" + row.param_val;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, inventory_item_stock_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            inventory_item_stock_row row = array[i];
            url += "&item_no[" + i + "]=" + row.item_no;
            url += "&client_sku[" + i + "]=" + row.client_sku;
            url += "&update_directive[" + i + "]=" + row.update_directive;
            url += "&update_amount[" + i + "]=" + row.update_amount;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, plan_no_to_remove_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            plan_no_to_remove_row row = array[i];
            url += "&queued_plan_no[" + i + "]=" + row.queued_plan_no;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, new_acct_custom_rates_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            new_acct_custom_rates_row row = array[i];
            url += "&custom_rate_plan_no[" + i + "]=" + row.custom_rate_plan_no;
            url += "&custom_rate_service_no[" + i + "]=" + row.custom_rate_service_no;
            url += "&custom_rate_seq_no[" + i + "]=" + row.custom_rate_seq_no;
            url += "&custom_rate_from_unit[" + i + "]=" + row.custom_rate_from_unit;
            url += "&custom_rate_to_unit[" + i + "]=" + row.custom_rate_to_unit;
            url += "&custom_rate_per_unit[" + i + "]=" + row.custom_rate_per_unit;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, supp_plans_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            supp_plans_row row = array[i];
            url += "&supp_plans[" + i + "]=" + row.supp_plans;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, supp_plan_units_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            supp_plan_units_row row = array[i];
            url += "&supp_plan_units[" + i + "]=" + row.supp_plan_units;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, functional_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            functional_acct_groups_row row = array[i];
            url += "&functional_acct_groups[" + i + "]=" + row.functional_acct_groups;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, collections_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            collections_acct_groups_row row = array[i];
            url += "&collections_acct_groups[" + i + "]=" + row.collections_acct_groups;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, supp_plan_alt_rate_sched_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            supp_plan_alt_rate_sched_no_row row = array[i];
            url += "&supp_plan_alt_rate_sched_no[" + i + "]=" + row.supp_plan_alt_rate_sched_no;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, coupon_codes_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            coupon_codes_row row = array[i];
            url += "&coupon_codes[" + i + "]=" + row.coupon_codes;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, new_acct_plan_contracts_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            new_acct_plan_contracts_row row = array[i];
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

    public static void addParameterValuesFromArray(ref string url, usage_accumulation_config_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            usage_accumulation_config_row row = array[i];
            url += "&usage_accumulation_plan_no[" + i + "]=" + row.usage_accumulation_plan_no;
            url += "&usage_accumulation_reset_months[" + i + "]=" + row.usage_accumulation_reset_months;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, enable_usage_pooling_plan_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            enable_usage_pooling_plan_no_row row = array[i];
            url += "&enable_usage_pooling_plan_no[" + i + "]=" + row.enable_usage_pooling_plan_no;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, client_func_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            client_func_acct_group_ids_row row = array[i];
            url += "&client_func_acct_group_ids[" + i + "]=" + row.client_func_acct_group_ids;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, client_coll_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            client_coll_acct_group_ids_row row = array[i];
            url += "&client_coll_acct_group_ids[" + i + "]=" + row.client_coll_acct_group_ids;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a1_supp_plans_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a1_supp_plans_row row = array[i];
            url += "&a1_supp_plans[" + i + "]=" + row.a1_supp_plans;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a1_supp_plan_units_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a1_supp_plan_units_row row = array[i];
            url += "&a1_supp_plan_units[" + i + "]=" + row.a1_supp_plan_units;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a1_functional_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a1_functional_acct_groups_row row = array[i];
            url += "&a1_functional_acct_groups[" + i + "]=" + row.a1_functional_acct_groups;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a1_collections_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a1_collections_acct_groups_row row = array[i];
            url += "&a1_collections_acct_groups[" + i + "]=" + row.a1_collections_acct_groups;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a1_supp_field_names_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a1_supp_field_names_row row = array[i];
            url += "&a1_supp_field_names[" + i + "]=" + row.a1_supp_field_names;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a1_supp_field_values_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a1_supp_field_values_row row = array[i];
            url += "&a1_supp_field_values[" + i + "]=" + row.a1_supp_field_values;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a1_supp_plan_alt_rate_sched_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a1_supp_plan_alt_rate_sched_no_row row = array[i];
            url += "&a1_supp_plan_alt_rate_sched_no[" + i + "]=" + row.a1_supp_plan_alt_rate_sched_no;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a1_coupon_codes_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a1_coupon_codes_row row = array[i];
            url += "&a1_coupon_codes[" + i + "]=" + row.a1_coupon_codes;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a1_new_acct_custom_rates_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a1_new_acct_custom_rates_row row = array[i];
            url += "&a1_custom_rate_plan_no[" + i + "]=" + row.a1_custom_rate_plan_no;
            url += "&a1_custom_rate_service_no[" + i + "]=" + row.a1_custom_rate_service_no;
            url += "&a1_custom_rate_seq_no[" + i + "]=" + row.a1_custom_rate_seq_no;
            url += "&a1_custom_rate_from_unit[" + i + "]=" + row.a1_custom_rate_from_unit;
            url += "&a1_custom_rate_to_unit[" + i + "]=" + row.a1_custom_rate_to_unit;
            url += "&a1_custom_rate_per_unit[" + i + "]=" + row.a1_custom_rate_per_unit;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a1_new_acct_plan_contracts_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a1_new_acct_plan_contracts_row row = array[i];
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

    public static void addParameterValuesFromArray(ref string url, a1_usage_accumulation_config_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a1_usage_accumulation_config_row row = array[i];
            url += "&a1_usage_accumulation_plan_no[" + i + "]=" + row.a1_usage_accumulation_plan_no;
            url += "&a1_usage_accumulation_reset_months[" + i + "]=" + row.a1_usage_accumulation_reset_months;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a1_enable_usage_pooling_plan_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a1_enable_usage_pooling_plan_no_row row = array[i];
            url += "&a1_enable_usage_pooling_plan_no[" + i + "]=" + row.a1_enable_usage_pooling_plan_no;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a1_client_func_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a1_client_func_acct_group_ids_row row = array[i];
            url += "&a1_client_func_acct_group_ids[" + i + "]=" + row.a1_client_func_acct_group_ids;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a1_client_coll_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a1_client_coll_acct_group_ids_row row = array[i];
            url += "&a1_client_coll_acct_group_ids[" + i + "]=" + row.a1_client_coll_acct_group_ids;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a2_supp_plans_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a2_supp_plans_row row = array[i];
            url += "&a2_supp_plans[" + i + "]=" + row.a2_supp_plans;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a2_supp_plan_units_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a2_supp_plan_units_row row = array[i];
            url += "&a2_supp_plan_units[" + i + "]=" + row.a2_supp_plan_units;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a2_functional_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a2_functional_acct_groups_row row = array[i];
            url += "&a2_functional_acct_groups[" + i + "]=" + row.a2_functional_acct_groups;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a2_collections_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a2_collections_acct_groups_row row = array[i];
            url += "&a2_collections_acct_groups[" + i + "]=" + row.a2_collections_acct_groups;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a2_supp_field_names_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a2_supp_field_names_row row = array[i];
            url += "&a2_supp_field_names[" + i + "]=" + row.a2_supp_field_names;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a2_supp_field_values_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a2_supp_field_values_row row = array[i];
            url += "&a2_supp_field_values[" + i + "]=" + row.a2_supp_field_values;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a2_supp_plan_alt_rate_sched_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a2_supp_plan_alt_rate_sched_no_row row = array[i];
            url += "&a2_supp_plan_alt_rate_sched_no[" + i + "]=" + row.a2_supp_plan_alt_rate_sched_no;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a2_coupon_codes_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a2_coupon_codes_row row = array[i];
            url += "&a2_coupon_codes[" + i + "]=" + row.a2_coupon_codes;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a2_new_acct_custom_rates_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a2_new_acct_custom_rates_row row = array[i];
            url += "&a2_custom_rate_plan_no[" + i + "]=" + row.a2_custom_rate_plan_no;
            url += "&a2_custom_rate_service_no[" + i + "]=" + row.a2_custom_rate_service_no;
            url += "&a2_custom_rate_seq_no[" + i + "]=" + row.a2_custom_rate_seq_no;
            url += "&a2_custom_rate_from_unit[" + i + "]=" + row.a2_custom_rate_from_unit;
            url += "&a2_custom_rate_to_unit[" + i + "]=" + row.a2_custom_rate_to_unit;
            url += "&a2_custom_rate_per_unit[" + i + "]=" + row.a2_custom_rate_per_unit;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a2_new_acct_plan_contracts_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a2_new_acct_plan_contracts_row row = array[i];
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

    public static void addParameterValuesFromArray(ref string url, a2_usage_accumulation_config_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a2_usage_accumulation_config_row row = array[i];
            url += "&a2_usage_accumulation_plan_no[" + i + "]=" + row.a2_usage_accumulation_plan_no;
            url += "&a2_usage_accumulation_reset_months[" + i + "]=" + row.a2_usage_accumulation_reset_months;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a2_enable_usage_pooling_plan_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a2_enable_usage_pooling_plan_no_row row = array[i];
            url += "&a2_enable_usage_pooling_plan_no[" + i + "]=" + row.a2_enable_usage_pooling_plan_no;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a2_client_func_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a2_client_func_acct_group_ids_row row = array[i];
            url += "&a2_client_func_acct_group_ids[" + i + "]=" + row.a2_client_func_acct_group_ids;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a2_client_coll_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a2_client_coll_acct_group_ids_row row = array[i];
            url += "&a2_client_coll_acct_group_ids[" + i + "]=" + row.a2_client_coll_acct_group_ids;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a3_supp_plans_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a3_supp_plans_row row = array[i];
            url += "&a3_supp_plans[" + i + "]=" + row.a3_supp_plans;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a3_supp_plan_units_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a3_supp_plan_units_row row = array[i];
            url += "&a3_supp_plan_units[" + i + "]=" + row.a3_supp_plan_units;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a3_functional_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a3_functional_acct_groups_row row = array[i];
            url += "&a3_functional_acct_groups[" + i + "]=" + row.a3_functional_acct_groups;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a3_collections_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a3_collections_acct_groups_row row = array[i];
            url += "&a3_collections_acct_groups[" + i + "]=" + row.a3_collections_acct_groups;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a3_supp_field_names_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a3_supp_field_names_row row = array[i];
            url += "&a3_supp_field_names[" + i + "]=" + row.a3_supp_field_names;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a3_supp_field_values_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a3_supp_field_values_row row = array[i];
            url += "&a3_supp_field_values[" + i + "]=" + row.a3_supp_field_values;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a3_supp_plan_alt_rate_sched_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a3_supp_plan_alt_rate_sched_no_row row = array[i];
            url += "&a3_supp_plan_alt_rate_sched_no[" + i + "]=" + row.a3_supp_plan_alt_rate_sched_no;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a3_coupon_codes_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a3_coupon_codes_row row = array[i];
            url += "&a3_coupon_codes[" + i + "]=" + row.a3_coupon_codes;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a3_new_acct_custom_rates_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a3_new_acct_custom_rates_row row = array[i];
            url += "&a3_custom_rate_plan_no[" + i + "]=" + row.a3_custom_rate_plan_no;
            url += "&a3_custom_rate_service_no[" + i + "]=" + row.a3_custom_rate_service_no;
            url += "&a3_custom_rate_seq_no[" + i + "]=" + row.a3_custom_rate_seq_no;
            url += "&a3_custom_rate_from_unit[" + i + "]=" + row.a3_custom_rate_from_unit;
            url += "&a3_custom_rate_to_unit[" + i + "]=" + row.a3_custom_rate_to_unit;
            url += "&a3_custom_rate_per_unit[" + i + "]=" + row.a3_custom_rate_per_unit;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a3_new_acct_plan_contracts_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a3_new_acct_plan_contracts_row row = array[i];
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

    public static void addParameterValuesFromArray(ref string url, a3_usage_accumulation_config_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a3_usage_accumulation_config_row row = array[i];
            url += "&a3_usage_accumulation_plan_no[" + i + "]=" + row.a3_usage_accumulation_plan_no;
            url += "&a3_usage_accumulation_reset_months[" + i + "]=" + row.a3_usage_accumulation_reset_months;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a3_enable_usage_pooling_plan_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a3_enable_usage_pooling_plan_no_row row = array[i];
            url += "&a3_enable_usage_pooling_plan_no[" + i + "]=" + row.a3_enable_usage_pooling_plan_no;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a3_client_func_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a3_client_func_acct_group_ids_row row = array[i];
            url += "&a3_client_func_acct_group_ids[" + i + "]=" + row.a3_client_func_acct_group_ids;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a3_client_coll_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a3_client_coll_acct_group_ids_row row = array[i];
            url += "&a3_client_coll_acct_group_ids[" + i + "]=" + row.a3_client_coll_acct_group_ids;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a4_supp_plans_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a4_supp_plans_row row = array[i];
            url += "&a4_supp_plans[" + i + "]=" + row.a4_supp_plans;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a4_supp_plan_units_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a4_supp_plan_units_row row = array[i];
            url += "&a4_supp_plan_units[" + i + "]=" + row.a4_supp_plan_units;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a4_functional_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a4_functional_acct_groups_row row = array[i];
            url += "&a4_functional_acct_groups[" + i + "]=" + row.a4_functional_acct_groups;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a4_collections_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a4_collections_acct_groups_row row = array[i];
            url += "&a4_collections_acct_groups[" + i + "]=" + row.a4_collections_acct_groups;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a4_supp_field_names_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a4_supp_field_names_row row = array[i];
            url += "&a4_supp_field_names[" + i + "]=" + row.a4_supp_field_names;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a4_supp_field_values_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a4_supp_field_values_row row = array[i];
            url += "&a4_supp_field_values[" + i + "]=" + row.a4_supp_field_values;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a4_supp_plan_alt_rate_sched_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a4_supp_plan_alt_rate_sched_no_row row = array[i];
            url += "&a4_supp_plan_alt_rate_sched_no[" + i + "]=" + row.a4_supp_plan_alt_rate_sched_no;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a4_coupon_codes_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a4_coupon_codes_row row = array[i];
            url += "&a4_coupon_codes[" + i + "]=" + row.a4_coupon_codes;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a4_new_acct_custom_rates_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a4_new_acct_custom_rates_row row = array[i];
            url += "&a4_custom_rate_plan_no[" + i + "]=" + row.a4_custom_rate_plan_no;
            url += "&a4_custom_rate_service_no[" + i + "]=" + row.a4_custom_rate_service_no;
            url += "&a4_custom_rate_seq_no[" + i + "]=" + row.a4_custom_rate_seq_no;
            url += "&a4_custom_rate_from_unit[" + i + "]=" + row.a4_custom_rate_from_unit;
            url += "&a4_custom_rate_to_unit[" + i + "]=" + row.a4_custom_rate_to_unit;
            url += "&a4_custom_rate_per_unit[" + i + "]=" + row.a4_custom_rate_per_unit;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a4_new_acct_plan_contracts_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a4_new_acct_plan_contracts_row row = array[i];
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

    public static void addParameterValuesFromArray(ref string url, a4_usage_accumulation_config_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a4_usage_accumulation_config_row row = array[i];
            url += "&a4_usage_accumulation_plan_no[" + i + "]=" + row.a4_usage_accumulation_plan_no;
            url += "&a4_usage_accumulation_reset_months[" + i + "]=" + row.a4_usage_accumulation_reset_months;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a4_enable_usage_pooling_plan_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a4_enable_usage_pooling_plan_no_row row = array[i];
            url += "&a4_enable_usage_pooling_plan_no[" + i + "]=" + row.a4_enable_usage_pooling_plan_no;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a4_client_func_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a4_client_func_acct_group_ids_row row = array[i];
            url += "&a4_client_func_acct_group_ids[" + i + "]=" + row.a4_client_func_acct_group_ids;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a4_client_coll_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a4_client_coll_acct_group_ids_row row = array[i];
            url += "&a4_client_coll_acct_group_ids[" + i + "]=" + row.a4_client_coll_acct_group_ids;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a5_supp_plans_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a5_supp_plans_row row = array[i];
            url += "&a5_supp_plans[" + i + "]=" + row.a5_supp_plans;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a5_supp_plan_units_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a5_supp_plan_units_row row = array[i];
            url += "&a5_supp_plan_units[" + i + "]=" + row.a5_supp_plan_units;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a5_functional_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a5_functional_acct_groups_row row = array[i];
            url += "&a5_functional_acct_groups[" + i + "]=" + row.a5_functional_acct_groups;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a5_collections_acct_groups_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a5_collections_acct_groups_row row = array[i];
            url += "&a5_collections_acct_groups[" + i + "]=" + row.a5_collections_acct_groups;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a5_supp_field_names_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a5_supp_field_names_row row = array[i];
            url += "&a5_supp_field_names[" + i + "]=" + row.a5_supp_field_names;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a5_supp_field_values_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a5_supp_field_values_row row = array[i];
            url += "&a5_supp_field_values[" + i + "]=" + row.a5_supp_field_values;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a5_supp_plan_alt_rate_sched_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a5_supp_plan_alt_rate_sched_no_row row = array[i];
            url += "&a5_supp_plan_alt_rate_sched_no[" + i + "]=" + row.a5_supp_plan_alt_rate_sched_no;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a5_coupon_codes_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a5_coupon_codes_row row = array[i];
            url += "&a5_coupon_codes[" + i + "]=" + row.a5_coupon_codes;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a5_new_acct_custom_rates_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a5_new_acct_custom_rates_row row = array[i];
            url += "&a5_custom_rate_plan_no[" + i + "]=" + row.a5_custom_rate_plan_no;
            url += "&a5_custom_rate_service_no[" + i + "]=" + row.a5_custom_rate_service_no;
            url += "&a5_custom_rate_seq_no[" + i + "]=" + row.a5_custom_rate_seq_no;
            url += "&a5_custom_rate_from_unit[" + i + "]=" + row.a5_custom_rate_from_unit;
            url += "&a5_custom_rate_to_unit[" + i + "]=" + row.a5_custom_rate_to_unit;
            url += "&a5_custom_rate_per_unit[" + i + "]=" + row.a5_custom_rate_per_unit;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a5_new_acct_plan_contracts_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a5_new_acct_plan_contracts_row row = array[i];
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

    public static void addParameterValuesFromArray(ref string url, a5_usage_accumulation_config_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a5_usage_accumulation_config_row row = array[i];
            url += "&a5_usage_accumulation_plan_no[" + i + "]=" + row.a5_usage_accumulation_plan_no;
            url += "&a5_usage_accumulation_reset_months[" + i + "]=" + row.a5_usage_accumulation_reset_months;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a5_enable_usage_pooling_plan_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a5_enable_usage_pooling_plan_no_row row = array[i];
            url += "&a5_enable_usage_pooling_plan_no[" + i + "]=" + row.a5_enable_usage_pooling_plan_no;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a5_client_func_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a5_client_func_acct_group_ids_row row = array[i];
            url += "&a5_client_func_acct_group_ids[" + i + "]=" + row.a5_client_func_acct_group_ids;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, a5_client_coll_acct_group_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            a5_client_coll_acct_group_ids_row row = array[i];
            url += "&a5_client_coll_acct_group_ids[" + i + "]=" + row.a5_client_coll_acct_group_ids;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, usage_qualifier_1_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            usage_qualifier_1_row row = array[i];
            url += "&usage_qualifier_1[" + i + "]=" + row.usage_qualifier_1;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, usage_qualifier_2_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            usage_qualifier_2_row row = array[i];
            url += "&usage_qualifier_2[" + i + "]=" + row.usage_qualifier_2;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, usage_qualifier_3_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            usage_qualifier_3_row row = array[i];
            url += "&usage_qualifier_3[" + i + "]=" + row.usage_qualifier_3;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, usage_qualifier_4_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            usage_qualifier_4_row row = array[i];
            url += "&usage_qualifier_4[" + i + "]=" + row.usage_qualifier_4;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, update_acct_supp_field_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            update_acct_supp_field_row row = array[i];
            url += "&supp_field_names[" + i + "]=" + row.supp_field_names;
            url += "&supp_field_values[" + i + "]=" + row.supp_field_values;
            url += "&supp_field_directives[" + i + "]=" + row.supp_field_directives;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, update_acct_func_group_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            update_acct_func_group_row row = array[i];
            url += "&functional_acct_groups[" + i + "]=" + row.functional_acct_groups;
            url += "&functional_group_directives[" + i + "]=" + row.functional_group_directives;
            url += "&client_func_acct_group_ids[" + i + "]=" + row.client_func_acct_group_ids;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, update_acct_coll_group_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            update_acct_coll_group_row row = array[i];
            url += "&collections_acct_groups[" + i + "]=" + row.collections_acct_groups;
            url += "&collections_group_directives[" + i + "]=" + row.collections_group_directives;
            url += "&client_coll_acct_group_ids[" + i + "]=" + row.client_coll_acct_group_ids;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, disable_usage_pooling_plan_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            disable_usage_pooling_plan_no_row row = array[i];
            url += "&disable_usage_pooling_plan_no[" + i + "]=" + row.disable_usage_pooling_plan_no;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, custom_acct_rates_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            custom_acct_rates_row row = array[i];
            url += "&rate_seq_no[" + i + "]=" + row.rate_seq_no;
            url += "&rate_per_unit[" + i + "]=" + row.rate_per_unit;
            url += "&from_unit[" + i + "]=" + row.from_unit;
            url += "&to_unit[" + i + "]=" + row.to_unit;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, acct_supp_fields_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            acct_supp_fields_row row = array[i];
            url += "&supp_field_name[" + i + "]=" + row.supp_field_name;
            url += "&supp_field_value[" + i + "]=" + row.supp_field_value;
            url += "&supp_field_directive[" + i + "]=" + row.supp_field_directive;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, supp_plans_to_assign_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            supp_plans_to_assign_row row = array[i];
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
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, credit_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            credit_ids_row row = array[i];
            url += "&credit_ids[" + i + "]=" + row.credit_ids;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, plan_no_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            plan_no_row row = array[i];
            url += "&plan_no[" + i + "]=" + row.plan_no;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, plans_input_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            plans_input_row row = array[i];
            url += "&plan_no[" + i + "]=" + row.plan_no;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, plans_to_get_outage_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            plans_to_get_outage_row row = array[i];
            url += "&plan_no[" + i + "]=" + row.plan_no;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, order_line_items_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            order_line_items_row row = array[i];
            url += "&client_sku[" + i + "]=" + row.client_sku;
            url += "&units[" + i + "]=" + row.units;
            url += "&amount[" + i + "]=" + row.amount;
            url += "&unit_discount_amount[" + i + "]=" + row.unit_discount_amount;
            url += "&line_comments[" + i + "]=" + row.line_comments;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, specific_charge_transaction_id_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            specific_charge_transaction_id_row row = array[i];
            url += "&specific_charge_transaction_id[" + i + "]=" + row.specific_charge_transaction_id;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, standing_order_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            standing_order_row row = array[i];
            url += "&client_sku[" + i + "]=" + row.client_sku;
            url += "&units[" + i + "]=" + row.units;
            url += "&amount[" + i + "]=" + row.amount;
            url += "&unit_discount_amount[" + i + "]=" + row.unit_discount_amount;
            url += "&line_comments[" + i + "]=" + row.line_comments;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, usage_records_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            usage_records_row row = array[i];
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

    public static void addParameterValuesFromArray(ref string url, pre_calc_plan_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            pre_calc_plan_row row = array[i];
            url += "&plan_item_service_no[" + i + "]=" + row.plan_item_service_no;
            url += "&plan_item_plan_no[" + i + "]=" + row.plan_item_plan_no;
            url += "&plan_item_units[" + i + "]=" + row.plan_item_units;
            url += "&plan_item_unit_amount[" + i + "]=" + row.plan_item_unit_amount;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, pre_calc_sku_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            pre_calc_sku_row row = array[i];
            url += "&sku[" + i + "]=" + row.sku;
            url += "&sku_plan_no[" + i + "]=" + row.sku_plan_no;
            url += "&sku_units[" + i + "]=" + row.sku_units;
            url += "&sku_unit_amount[" + i + "]=" + row.sku_unit_amount;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, cart_supp_plans_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            cart_supp_plans_row row = array[i];
            url += "&supp_plan_no[" + i + "]=" + row.supp_plan_no;
            url += "&supp_plan_units[" + i + "]=" + row.supp_plan_units;
            url += "&assignment_directive[" + i + "]=" + row.assignment_directive;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, invoices_to_reverse_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            invoices_to_reverse_row row = array[i];
            url += "&invoice_no[" + i + "]=" + row.invoice_no;
            url += "&invoice_line_no[" + i + "]=" + row.invoice_line_no;
            url += "&invoice_line_reversing_amount[" + i + "]=" + row.invoice_line_reversing_amount;
            url += "&invoice_line_reversing_date[" + i + "]=" + row.invoice_line_reversing_date;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, usage_record_nos_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            usage_record_nos_row row = array[i];
            url += "&usage_record_no[" + i + "]=" + row.usage_record_no;
            
        }
    }

    public static void addParameterValuesFromArray(ref string url, client_record_ids_row[] array)
    {
        if (array == null) return;
        for (int i = 0; i < array.Length; i++)
        {
            client_record_ids_row row = array[i];
            url += "&client_record_id[" + i + "]=" + row.client_record_id;
            
        }
    }

    /* ****************** END - ARRAY TO PARM METHODS FOR EACH ARRAY ELEMENT **************************************** */
    }
}