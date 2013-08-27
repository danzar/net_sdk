using Aria.SDK.AriaServices.AriaWebServices.AriaComplete;

namespace Aria.SDK.AriaServices.AriaWebServices
{
    class RestUtilities
    {
	/* ****************** ARRAY TO PARM METHODS FOR EACH ARRAY ELEMENT ********************************************** */
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

	public static void addParameterValuesFromArray(ref string url, supp_plan_alt_rate_sched_no_row[] array)
	{
		if (array == null) return;
		for (int i = 0; i < array.Length; i++)
		{
			supp_plan_alt_rate_sched_no_row row = array[i];
			url += "&supp_plan_alt_rate_sched_no[" + i + "]=" + row.supp_plan_alt_rate_sched_no;
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

	/* ****************** END - ARRAY TO PARM METHODS FOR EACH ARRAY ELEMENT **************************************** */

	}
}