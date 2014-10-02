
namespace Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools {
    
    
            /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class promo_plan_set_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private long promo_plan_set_noField;
        private string promo_plan_set_nameField;
        private string promo_plan_set_descField;
        private string client_plan_type_idField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public long promo_plan_set_no {
            get {
                return this.promo_plan_set_noField;
            }
            set {
                this.promo_plan_set_noField = value;
                this.RaisePropertyChanged("promo_plan_set_no");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string promo_plan_set_name {
            get {
                return this.promo_plan_set_nameField;
            }
            set {
                this.promo_plan_set_nameField = value;
                this.RaisePropertyChanged("promo_plan_set_name");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string promo_plan_set_desc {
            get {
                return this.promo_plan_set_descField;
            }
            set {
                this.promo_plan_set_descField = value;
                this.RaisePropertyChanged("promo_plan_set_desc");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string client_plan_type_id {
            get {
                return this.client_plan_type_idField;
            }
            set {
                this.client_plan_type_idField = value;
                this.RaisePropertyChanged("client_plan_type_id");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class plan_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private long plan_noField;
        private string plan_nameField;
        private string plan_descField;
        private string client_plan_idField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public long plan_no {
            get {
                return this.plan_noField;
            }
            set {
                this.plan_noField = value;
                this.RaisePropertyChanged("plan_no");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string plan_name {
            get {
                return this.plan_nameField;
            }
            set {
                this.plan_nameField = value;
                this.RaisePropertyChanged("plan_name");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string plan_desc {
            get {
                return this.plan_descField;
            }
            set {
                this.plan_descField = value;
                this.RaisePropertyChanged("plan_desc");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string client_plan_id {
            get {
                return this.client_plan_idField;
            }
            set {
                this.client_plan_idField = value;
                this.RaisePropertyChanged("client_plan_id");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class plan_groups_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private int group_noField;
        private string group_nameField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int group_no {
            get {
                return this.group_noField;
            }
            set {
                this.group_noField = value;
                this.RaisePropertyChanged("group_no");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string group_name {
            get {
                return this.group_nameField;
            }
            set {
                this.group_nameField = value;
                this.RaisePropertyChanged("group_name");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class inventory_items_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private int item_noField;
        private string item_nameField;
        private int item_typeField;
        private string client_skuField;
        private int active_indField;
        private string client_item_idField;
        private System.Nullable<float> stock_levelField;
                private bool stock_levelFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int item_no {
            get {
                return this.item_noField;
            }
            set {
                this.item_noField = value;
                this.RaisePropertyChanged("item_no");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string item_name {
            get {
                return this.item_nameField;
            }
            set {
                this.item_nameField = value;
                this.RaisePropertyChanged("item_name");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int item_type {
            get {
                return this.item_typeField;
            }
            set {
                this.item_typeField = value;
                this.RaisePropertyChanged("item_type");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string client_sku {
            get {
                return this.client_skuField;
            }
            set {
                this.client_skuField = value;
                this.RaisePropertyChanged("client_sku");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int active_ind {
            get {
                return this.active_indField;
            }
            set {
                this.active_indField = value;
                this.RaisePropertyChanged("active_ind");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public string client_item_id {
            get {
                return this.client_item_idField;
            }
            set {
                this.client_item_idField = value;
                this.RaisePropertyChanged("client_item_id");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public System.Nullable<float> stock_level {
            get {
                return this.stock_levelField;
            }
            set {
                this.stock_levelField = value;
                this.RaisePropertyChanged("stock_level");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool stock_levelSpecified {
            get {
                return this.stock_levelFieldSpecified;
            }
            set {
                this.stock_levelFieldSpecified = value;
                this.RaisePropertyChanged("stock_levelSpecified");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class pricing_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private string currency_cdField;
        private System.Nullable<float> item_priceField;
                private bool item_priceFieldSpecified;
        private System.Nullable<float> price_per_unitField;
                private bool price_per_unitFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string currency_cd {
            get {
                return this.currency_cdField;
            }
            set {
                this.currency_cdField = value;
                this.RaisePropertyChanged("currency_cd");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public System.Nullable<float> item_price {
            get {
                return this.item_priceField;
            }
            set {
                this.item_priceField = value;
                this.RaisePropertyChanged("item_price");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool item_priceSpecified {
            get {
                return this.item_priceFieldSpecified;
            }
            set {
                this.item_priceFieldSpecified = value;
                this.RaisePropertyChanged("item_priceSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public System.Nullable<float> price_per_unit {
            get {
                return this.price_per_unitField;
            }
            set {
                this.price_per_unitField = value;
                this.RaisePropertyChanged("price_per_unit");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool price_per_unitSpecified {
            get {
                return this.price_per_unitFieldSpecified;
            }
            set {
                this.price_per_unitFieldSpecified = value;
                this.RaisePropertyChanged("price_per_unitSpecified");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class resources_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private int resourcesField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int resources {
            get {
                return this.resourcesField;
            }
            set {
                this.resourcesField = value;
                this.RaisePropertyChanged("resources");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class image_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private string thumbnail_image_urlField;
        private string main_image_urlField;
        private string image_textField;
        private System.Nullable<int> default_indField;
                private bool default_indFieldSpecified;
        private System.Nullable<int> image_class_seq_noField;
                private bool image_class_seq_noFieldSpecified;
        private System.Nullable<int> activeField;
                private bool activeFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string thumbnail_image_url {
            get {
                return this.thumbnail_image_urlField;
            }
            set {
                this.thumbnail_image_urlField = value;
                this.RaisePropertyChanged("thumbnail_image_url");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string main_image_url {
            get {
                return this.main_image_urlField;
            }
            set {
                this.main_image_urlField = value;
                this.RaisePropertyChanged("main_image_url");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public string image_text {
            get {
                return this.image_textField;
            }
            set {
                this.image_textField = value;
                this.RaisePropertyChanged("image_text");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public System.Nullable<int> default_ind {
            get {
                return this.default_indField;
            }
            set {
                this.default_indField = value;
                this.RaisePropertyChanged("default_ind");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool default_indSpecified {
            get {
                return this.default_indFieldSpecified;
            }
            set {
                this.default_indFieldSpecified = value;
                this.RaisePropertyChanged("default_indSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public System.Nullable<int> image_class_seq_no {
            get {
                return this.image_class_seq_noField;
            }
            set {
                this.image_class_seq_noField = value;
                this.RaisePropertyChanged("image_class_seq_no");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool image_class_seq_noSpecified {
            get {
                return this.image_class_seq_noFieldSpecified;
            }
            set {
                this.image_class_seq_noFieldSpecified = value;
                this.RaisePropertyChanged("image_class_seq_noSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public System.Nullable<int> active {
            get {
                return this.activeField;
            }
            set {
                this.activeField = value;
                this.RaisePropertyChanged("active");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool activeSpecified {
            get {
                return this.activeFieldSpecified;
            }
            set {
                this.activeFieldSpecified = value;
                this.RaisePropertyChanged("activeSpecified");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class supplemental_obj_fields_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private string supplemental_obj_fieldField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string supplemental_obj_field {
            get {
                return this.supplemental_obj_fieldField;
            }
            set {
                this.supplemental_obj_fieldField = value;
                this.RaisePropertyChanged("supplemental_obj_field");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class service_types_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private string service_type_nameField;
        private string service_descField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string service_type_name {
            get {
                return this.service_type_nameField;
            }
            set {
                this.service_type_nameField = value;
                this.RaisePropertyChanged("service_type_name");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string service_desc {
            get {
                return this.service_descField;
            }
            set {
                this.service_descField = value;
                this.RaisePropertyChanged("service_desc");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class services_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private int service_noField;
        private int client_service_idField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int service_no {
            get {
                return this.service_noField;
            }
            set {
                this.service_noField = value;
                this.RaisePropertyChanged("service_no");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public int client_service_id {
            get {
                return this.client_service_idField;
            }
            set {
                this.client_service_idField = value;
                this.RaisePropertyChanged("client_service_id");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class rate_schedules_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private string currencyField;
        private Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rate_info_ReturnElement[] rate_infoField;
        private int is_defaultField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
                this.RaisePropertyChanged("currency");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("rate_info", IsNullable=true, Order=1)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rate_info_ReturnElement[] rate_info {
            get {
                return this.rate_infoField;
            }
            set {
                this.rate_infoField = value;
                this.RaisePropertyChanged("rate_info");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int is_default {
            get {
                return this.is_defaultField;
            }
            set {
                this.is_defaultField = value;
                this.RaisePropertyChanged("is_default");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class rate_info_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private int schedule_noField;
        private string schedule_nameField;
        private string client_rate_schedule_idField;
        private string from_unitField;
        private string to_unitField;
        private int rate_per_unitField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int schedule_no {
            get {
                return this.schedule_noField;
            }
            set {
                this.schedule_noField = value;
                this.RaisePropertyChanged("schedule_no");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string schedule_name {
            get {
                return this.schedule_nameField;
            }
            set {
                this.schedule_nameField = value;
                this.RaisePropertyChanged("schedule_name");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string client_rate_schedule_id {
            get {
                return this.client_rate_schedule_idField;
            }
            set {
                this.client_rate_schedule_idField = value;
                this.RaisePropertyChanged("client_rate_schedule_id");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string from_unit {
            get {
                return this.from_unitField;
            }
            set {
                this.from_unitField = value;
                this.RaisePropertyChanged("from_unit");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public string to_unit {
            get {
                return this.to_unitField;
            }
            set {
                this.to_unitField = value;
                this.RaisePropertyChanged("to_unit");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public int rate_per_unit {
            get {
                return this.rate_per_unitField;
            }
            set {
                this.rate_per_unitField = value;
                this.RaisePropertyChanged("rate_per_unit");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class parent_plans_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private int parent_planField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int parent_plan {
            get {
                return this.parent_planField;
            }
            set {
                this.parent_planField = value;
                this.RaisePropertyChanged("parent_plan");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class parent_plan_ids_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private int parent_plan_idField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int parent_plan_id {
            get {
                return this.parent_plan_idField;
            }
            set {
                this.parent_plan_idField = value;
                this.RaisePropertyChanged("parent_plan_id");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class exclusion_plans_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private int exclusion_planField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int exclusion_plan {
            get {
                return this.exclusion_planField;
            }
            set {
                this.exclusion_planField = value;
                this.RaisePropertyChanged("exclusion_plan");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class supp_fields_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private string field_nameField;
        private string field_descField;
        private int field_orderField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string field_name {
            get {
                return this.field_nameField;
            }
            set {
                this.field_nameField = value;
                this.RaisePropertyChanged("field_name");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string field_desc {
            get {
                return this.field_descField;
            }
            set {
                this.field_descField = value;
                this.RaisePropertyChanged("field_desc");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int field_order {
            get {
                return this.field_orderField;
            }
            set {
                this.field_orderField = value;
                this.RaisePropertyChanged("field_order");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class field_options_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private string display_textField;
        private string option_valueField;
        private int field_orderField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string display_text {
            get {
                return this.display_textField;
            }
            set {
                this.display_textField = value;
                this.RaisePropertyChanged("display_text");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string option_value {
            get {
                return this.option_valueField;
            }
            set {
                this.option_valueField = value;
                this.RaisePropertyChanged("option_value");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int field_order {
            get {
                return this.field_orderField;
            }
            set {
                this.field_orderField = value;
                this.RaisePropertyChanged("field_order");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class rules_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private System.Nullable<int> ruleField;
                private bool ruleFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> rule {
            get {
                return this.ruleField;
            }
            set {
                this.ruleField = value;
                this.RaisePropertyChanged("rule");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ruleSpecified {
            get {
                return this.ruleFieldSpecified;
            }
            set {
                this.ruleFieldSpecified = value;
                this.RaisePropertyChanged("ruleSpecified");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class rule_ids_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private System.Nullable<int> ruleField;
                private bool ruleFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> rule {
            get {
                return this.ruleField;
            }
            set {
                this.ruleField = value;
                this.RaisePropertyChanged("rule");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ruleSpecified {
            get {
                return this.ruleFieldSpecified;
            }
            set {
                this.ruleFieldSpecified = value;
                this.RaisePropertyChanged("ruleSpecified");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class plan_no_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private System.Nullable<int> plan_nosField;
                private bool plan_nosFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> plan_nos {
            get {
                return this.plan_nosField;
            }
            set {
                this.plan_nosField = value;
                this.RaisePropertyChanged("plan_nos");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool plan_nosSpecified {
            get {
                return this.plan_nosFieldSpecified;
            }
            set {
                this.plan_nosFieldSpecified = value;
                this.RaisePropertyChanged("plan_nosSpecified");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class client_plan_id_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private System.Nullable<int> client_plan_idsField;
                private bool client_plan_idsFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> client_plan_ids {
            get {
                return this.client_plan_idsField;
            }
            set {
                this.client_plan_idsField = value;
                this.RaisePropertyChanged("client_plan_ids");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool client_plan_idsSpecified {
            get {
                return this.client_plan_idsFieldSpecified;
            }
            set {
                this.client_plan_idsFieldSpecified = value;
                this.RaisePropertyChanged("client_plan_idsSpecified");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class service_no_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private System.Nullable<int> service_nosField;
                private bool service_nosFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> service_nos {
            get {
                return this.service_nosField;
            }
            set {
                this.service_nosField = value;
                this.RaisePropertyChanged("service_nos");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool service_nosSpecified {
            get {
                return this.service_nosFieldSpecified;
            }
            set {
                this.service_nosFieldSpecified = value;
                this.RaisePropertyChanged("service_nosSpecified");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class client_service_id_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private System.Nullable<int> client_service_idsField;
                private bool client_service_idsFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> client_service_ids {
            get {
                return this.client_service_idsField;
            }
            set {
                this.client_service_idsField = value;
                this.RaisePropertyChanged("client_service_ids");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool client_service_idsSpecified {
            get {
                return this.client_service_idsFieldSpecified;
            }
            set {
                this.client_service_idsFieldSpecified = value;
                this.RaisePropertyChanged("client_service_idsSpecified");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class item_no_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private System.Nullable<int> item_nosField;
                private bool item_nosFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> item_nos {
            get {
                return this.item_nosField;
            }
            set {
                this.item_nosField = value;
                this.RaisePropertyChanged("item_nos");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool item_nosSpecified {
            get {
                return this.item_nosFieldSpecified;
            }
            set {
                this.item_nosFieldSpecified = value;
                this.RaisePropertyChanged("item_nosSpecified");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class client_item_id_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private System.Nullable<int> client_item_idsField;
                private bool client_item_idsFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> client_item_ids {
            get {
                return this.client_item_idsField;
            }
            set {
                this.client_item_idsField = value;
                this.RaisePropertyChanged("client_item_ids");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool client_item_idsSpecified {
            get {
                return this.client_item_idsFieldSpecified;
            }
            set {
                this.client_item_idsFieldSpecified = value;
                this.RaisePropertyChanged("client_item_idsSpecified");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class eligible_service_types_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private string eligible_service_typeField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string eligible_service_type {
            get {
                return this.eligible_service_typeField;
            }
            set {
                this.eligible_service_typeField = value;
                this.RaisePropertyChanged("eligible_service_type");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class credit_template_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private int credit_template_noField;
        private string credit_template_nameField;
        private string client_credit_template_idField;
        private System.Nullable<int> eligible_plan_noField;
                private bool eligible_plan_noFieldSpecified;
        private System.Nullable<int> eligible_client_plan_idField;
                private bool eligible_client_plan_idFieldSpecified;
        private System.Nullable<int> eligible_service_noField;
                private bool eligible_service_noFieldSpecified;
        private System.Nullable<int> eligible_client_service_idField;
                private bool eligible_client_service_idFieldSpecified;
        private Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.eligible_service_types_ReturnElement[] eligible_service_typesField;
        private System.Nullable<int> no_of_creditsField;
                private bool no_of_creditsFieldSpecified;
        private System.Nullable<int> time_between_creditsField;
                private bool time_between_creditsFieldSpecified;
        private System.Nullable<int> discount_typeField;
                private bool discount_typeFieldSpecified;
        private System.Nullable<float> discount_amtField;
                private bool discount_amtFieldSpecified;
        private System.Nullable<int> percentage_plan_noField;
                private bool percentage_plan_noFieldSpecified;
        private System.Nullable<int> percentage_client_plan_idField;
                private bool percentage_client_plan_idFieldSpecified;
        private System.Nullable<int> percentage_service_noField;
                private bool percentage_service_noFieldSpecified;
        private System.Nullable<int> percentage_client_service_idField;
                private bool percentage_client_service_idFieldSpecified;
        private System.Nullable<int> alt_service_noField;
                private bool alt_service_noFieldSpecified;
        private int alt_client_service_idField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int credit_template_no {
            get {
                return this.credit_template_noField;
            }
            set {
                this.credit_template_noField = value;
                this.RaisePropertyChanged("credit_template_no");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string credit_template_name {
            get {
                return this.credit_template_nameField;
            }
            set {
                this.credit_template_nameField = value;
                this.RaisePropertyChanged("credit_template_name");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string client_credit_template_id {
            get {
                return this.client_credit_template_idField;
            }
            set {
                this.client_credit_template_idField = value;
                this.RaisePropertyChanged("client_credit_template_id");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public System.Nullable<int> eligible_plan_no {
            get {
                return this.eligible_plan_noField;
            }
            set {
                this.eligible_plan_noField = value;
                this.RaisePropertyChanged("eligible_plan_no");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eligible_plan_noSpecified {
            get {
                return this.eligible_plan_noFieldSpecified;
            }
            set {
                this.eligible_plan_noFieldSpecified = value;
                this.RaisePropertyChanged("eligible_plan_noSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public System.Nullable<int> eligible_client_plan_id {
            get {
                return this.eligible_client_plan_idField;
            }
            set {
                this.eligible_client_plan_idField = value;
                this.RaisePropertyChanged("eligible_client_plan_id");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eligible_client_plan_idSpecified {
            get {
                return this.eligible_client_plan_idFieldSpecified;
            }
            set {
                this.eligible_client_plan_idFieldSpecified = value;
                this.RaisePropertyChanged("eligible_client_plan_idSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public System.Nullable<int> eligible_service_no {
            get {
                return this.eligible_service_noField;
            }
            set {
                this.eligible_service_noField = value;
                this.RaisePropertyChanged("eligible_service_no");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eligible_service_noSpecified {
            get {
                return this.eligible_service_noFieldSpecified;
            }
            set {
                this.eligible_service_noFieldSpecified = value;
                this.RaisePropertyChanged("eligible_service_noSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public System.Nullable<int> eligible_client_service_id {
            get {
                return this.eligible_client_service_idField;
            }
            set {
                this.eligible_client_service_idField = value;
                this.RaisePropertyChanged("eligible_client_service_id");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool eligible_client_service_idSpecified {
            get {
                return this.eligible_client_service_idFieldSpecified;
            }
            set {
                this.eligible_client_service_idFieldSpecified = value;
                this.RaisePropertyChanged("eligible_client_service_idSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("eligible_service_types", IsNullable=true, Order=7)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.eligible_service_types_ReturnElement[] eligible_service_types {
            get {
                return this.eligible_service_typesField;
            }
            set {
                this.eligible_service_typesField = value;
                this.RaisePropertyChanged("eligible_service_types");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
        public System.Nullable<int> no_of_credits {
            get {
                return this.no_of_creditsField;
            }
            set {
                this.no_of_creditsField = value;
                this.RaisePropertyChanged("no_of_credits");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool no_of_creditsSpecified {
            get {
                return this.no_of_creditsFieldSpecified;
            }
            set {
                this.no_of_creditsFieldSpecified = value;
                this.RaisePropertyChanged("no_of_creditsSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
        public System.Nullable<int> time_between_credits {
            get {
                return this.time_between_creditsField;
            }
            set {
                this.time_between_creditsField = value;
                this.RaisePropertyChanged("time_between_credits");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool time_between_creditsSpecified {
            get {
                return this.time_between_creditsFieldSpecified;
            }
            set {
                this.time_between_creditsFieldSpecified = value;
                this.RaisePropertyChanged("time_between_creditsSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=10)]
        public System.Nullable<int> discount_type {
            get {
                return this.discount_typeField;
            }
            set {
                this.discount_typeField = value;
                this.RaisePropertyChanged("discount_type");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool discount_typeSpecified {
            get {
                return this.discount_typeFieldSpecified;
            }
            set {
                this.discount_typeFieldSpecified = value;
                this.RaisePropertyChanged("discount_typeSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
        public System.Nullable<float> discount_amt {
            get {
                return this.discount_amtField;
            }
            set {
                this.discount_amtField = value;
                this.RaisePropertyChanged("discount_amt");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool discount_amtSpecified {
            get {
                return this.discount_amtFieldSpecified;
            }
            set {
                this.discount_amtFieldSpecified = value;
                this.RaisePropertyChanged("discount_amtSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=12)]
        public System.Nullable<int> percentage_plan_no {
            get {
                return this.percentage_plan_noField;
            }
            set {
                this.percentage_plan_noField = value;
                this.RaisePropertyChanged("percentage_plan_no");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool percentage_plan_noSpecified {
            get {
                return this.percentage_plan_noFieldSpecified;
            }
            set {
                this.percentage_plan_noFieldSpecified = value;
                this.RaisePropertyChanged("percentage_plan_noSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=13)]
        public System.Nullable<int> percentage_client_plan_id {
            get {
                return this.percentage_client_plan_idField;
            }
            set {
                this.percentage_client_plan_idField = value;
                this.RaisePropertyChanged("percentage_client_plan_id");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool percentage_client_plan_idSpecified {
            get {
                return this.percentage_client_plan_idFieldSpecified;
            }
            set {
                this.percentage_client_plan_idFieldSpecified = value;
                this.RaisePropertyChanged("percentage_client_plan_idSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=14)]
        public System.Nullable<int> percentage_service_no {
            get {
                return this.percentage_service_noField;
            }
            set {
                this.percentage_service_noField = value;
                this.RaisePropertyChanged("percentage_service_no");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool percentage_service_noSpecified {
            get {
                return this.percentage_service_noFieldSpecified;
            }
            set {
                this.percentage_service_noFieldSpecified = value;
                this.RaisePropertyChanged("percentage_service_noSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=15)]
        public System.Nullable<int> percentage_client_service_id {
            get {
                return this.percentage_client_service_idField;
            }
            set {
                this.percentage_client_service_idField = value;
                this.RaisePropertyChanged("percentage_client_service_id");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool percentage_client_service_idSpecified {
            get {
                return this.percentage_client_service_idFieldSpecified;
            }
            set {
                this.percentage_client_service_idFieldSpecified = value;
                this.RaisePropertyChanged("percentage_client_service_idSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=16)]
        public System.Nullable<int> alt_service_no {
            get {
                return this.alt_service_noField;
            }
            set {
                this.alt_service_noField = value;
                this.RaisePropertyChanged("alt_service_no");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool alt_service_noSpecified {
            get {
                return this.alt_service_noFieldSpecified;
            }
            set {
                this.alt_service_noFieldSpecified = value;
                this.RaisePropertyChanged("alt_service_noSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=17)]
        public int alt_client_service_id {
            get {
                return this.alt_client_service_idField;
            }
            set {
                this.alt_client_service_idField = value;
                this.RaisePropertyChanged("alt_client_service_id");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class discount_rule_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private int rule_noField;
        private string rule_idField;
        private string descriptionField;
        private string ext_descriptionField;
        private int flat_percent_indField;
        private float amountField;
        private string currencyField;
        private string duration_type_indField;
        private System.Nullable<int> max_applicable_monthsField;
                private bool max_applicable_monthsFieldSpecified;
        private System.Nullable<int> max_applications_per_acctField;
                private bool max_applications_per_acctFieldSpecified;
        private string inline_offset_indField;
        private System.Nullable<int> service_code_to_useField;
                private bool service_code_to_useFieldSpecified;
        private System.Nullable<int> alt_service_no_2_applyField;
                private bool alt_service_no_2_applyFieldSpecified;
        private System.Nullable<int> alt_service_id_2_applyField;
                private bool alt_service_id_2_applyFieldSpecified;
        private int scope_noField;
        private Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_no_ReturnElement[] plan_noField;
        private Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_plan_id_ReturnElement[] client_plan_idField;
        private Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_no_ReturnElement[] service_noField;
        private Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_service_id_ReturnElement[] client_service_idField;
        private Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.item_no_ReturnElement[] item_noField;
        private Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_item_id_ReturnElement[] client_item_idField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int rule_no {
            get {
                return this.rule_noField;
            }
            set {
                this.rule_noField = value;
                this.RaisePropertyChanged("rule_no");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string rule_id {
            get {
                return this.rule_idField;
            }
            set {
                this.rule_idField = value;
                this.RaisePropertyChanged("rule_id");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
                this.RaisePropertyChanged("description");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string ext_description {
            get {
                return this.ext_descriptionField;
            }
            set {
                this.ext_descriptionField = value;
                this.RaisePropertyChanged("ext_description");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int flat_percent_ind {
            get {
                return this.flat_percent_indField;
            }
            set {
                this.flat_percent_indField = value;
                this.RaisePropertyChanged("flat_percent_ind");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public float amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
                this.RaisePropertyChanged("amount");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
                this.RaisePropertyChanged("currency");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string duration_type_ind {
            get {
                return this.duration_type_indField;
            }
            set {
                this.duration_type_indField = value;
                this.RaisePropertyChanged("duration_type_ind");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
        public System.Nullable<int> max_applicable_months {
            get {
                return this.max_applicable_monthsField;
            }
            set {
                this.max_applicable_monthsField = value;
                this.RaisePropertyChanged("max_applicable_months");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool max_applicable_monthsSpecified {
            get {
                return this.max_applicable_monthsFieldSpecified;
            }
            set {
                this.max_applicable_monthsFieldSpecified = value;
                this.RaisePropertyChanged("max_applicable_monthsSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
        public System.Nullable<int> max_applications_per_acct {
            get {
                return this.max_applications_per_acctField;
            }
            set {
                this.max_applications_per_acctField = value;
                this.RaisePropertyChanged("max_applications_per_acct");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool max_applications_per_acctSpecified {
            get {
                return this.max_applications_per_acctFieldSpecified;
            }
            set {
                this.max_applications_per_acctFieldSpecified = value;
                this.RaisePropertyChanged("max_applications_per_acctSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string inline_offset_ind {
            get {
                return this.inline_offset_indField;
            }
            set {
                this.inline_offset_indField = value;
                this.RaisePropertyChanged("inline_offset_ind");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
        public System.Nullable<int> service_code_to_use {
            get {
                return this.service_code_to_useField;
            }
            set {
                this.service_code_to_useField = value;
                this.RaisePropertyChanged("service_code_to_use");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool service_code_to_useSpecified {
            get {
                return this.service_code_to_useFieldSpecified;
            }
            set {
                this.service_code_to_useFieldSpecified = value;
                this.RaisePropertyChanged("service_code_to_useSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=12)]
        public System.Nullable<int> alt_service_no_2_apply {
            get {
                return this.alt_service_no_2_applyField;
            }
            set {
                this.alt_service_no_2_applyField = value;
                this.RaisePropertyChanged("alt_service_no_2_apply");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool alt_service_no_2_applySpecified {
            get {
                return this.alt_service_no_2_applyFieldSpecified;
            }
            set {
                this.alt_service_no_2_applyFieldSpecified = value;
                this.RaisePropertyChanged("alt_service_no_2_applySpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=13)]
        public System.Nullable<int> alt_service_id_2_apply {
            get {
                return this.alt_service_id_2_applyField;
            }
            set {
                this.alt_service_id_2_applyField = value;
                this.RaisePropertyChanged("alt_service_id_2_apply");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool alt_service_id_2_applySpecified {
            get {
                return this.alt_service_id_2_applyFieldSpecified;
            }
            set {
                this.alt_service_id_2_applyFieldSpecified = value;
                this.RaisePropertyChanged("alt_service_id_2_applySpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=14)]
        public int scope_no {
            get {
                return this.scope_noField;
            }
            set {
                this.scope_noField = value;
                this.RaisePropertyChanged("scope_no");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("plan_no", IsNullable=true, Order=15)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_no_ReturnElement[] plan_no {
            get {
                return this.plan_noField;
            }
            set {
                this.plan_noField = value;
                this.RaisePropertyChanged("plan_no");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("client_plan_id", IsNullable=true, Order=16)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_plan_id_ReturnElement[] client_plan_id {
            get {
                return this.client_plan_idField;
            }
            set {
                this.client_plan_idField = value;
                this.RaisePropertyChanged("client_plan_id");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("service_no", IsNullable=true, Order=17)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_no_ReturnElement[] service_no {
            get {
                return this.service_noField;
            }
            set {
                this.service_noField = value;
                this.RaisePropertyChanged("service_no");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("client_service_id", IsNullable=true, Order=18)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_service_id_ReturnElement[] client_service_id {
            get {
                return this.client_service_idField;
            }
            set {
                this.client_service_idField = value;
                this.RaisePropertyChanged("client_service_id");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("item_no", IsNullable=true, Order=19)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.item_no_ReturnElement[] item_no {
            get {
                return this.item_noField;
            }
            set {
                this.item_noField = value;
                this.RaisePropertyChanged("item_no");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("client_item_id", IsNullable=true, Order=20)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_item_id_ReturnElement[] client_item_id {
            get {
                return this.client_item_idField;
            }
            set {
                this.client_item_idField = value;
                this.RaisePropertyChanged("client_item_id");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class discount_bundle_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private int bundle_noField;
        private string bundle_nameField;
        private string bundle_idField;
        private string descriptionField;
        private string allow_overlap_indField;
        private Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rules_ReturnElement[] rulesField;
        private Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rule_ids_ReturnElement[] rule_idsField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int bundle_no {
            get {
                return this.bundle_noField;
            }
            set {
                this.bundle_noField = value;
                this.RaisePropertyChanged("bundle_no");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string bundle_name {
            get {
                return this.bundle_nameField;
            }
            set {
                this.bundle_nameField = value;
                this.RaisePropertyChanged("bundle_name");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string bundle_id {
            get {
                return this.bundle_idField;
            }
            set {
                this.bundle_idField = value;
                this.RaisePropertyChanged("bundle_id");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
                this.RaisePropertyChanged("description");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string allow_overlap_ind {
            get {
                return this.allow_overlap_indField;
            }
            set {
                this.allow_overlap_indField = value;
                this.RaisePropertyChanged("allow_overlap_ind");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("rules", IsNullable=true, Order=5)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rules_ReturnElement[] rules {
            get {
                return this.rulesField;
            }
            set {
                this.rulesField = value;
                this.RaisePropertyChanged("rules");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("rule_ids", IsNullable=true, Order=6)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rule_ids_ReturnElement[] rule_ids {
            get {
                return this.rule_idsField;
            }
            set {
                this.rule_idsField = value;
                this.RaisePropertyChanged("rule_ids");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class coupons_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private string coupon_cdField;
        private string coupon_descField;
        private string coupon_msgField;
        private int status_indField;
        private System.Nullable<int> no_of_usesField;
                private bool no_of_usesFieldSpecified;
        private string start_dateField;
        private string end_dateField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string coupon_cd {
            get {
                return this.coupon_cdField;
            }
            set {
                this.coupon_cdField = value;
                this.RaisePropertyChanged("coupon_cd");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string coupon_desc {
            get {
                return this.coupon_descField;
            }
            set {
                this.coupon_descField = value;
                this.RaisePropertyChanged("coupon_desc");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public string coupon_msg {
            get {
                return this.coupon_msgField;
            }
            set {
                this.coupon_msgField = value;
                this.RaisePropertyChanged("coupon_msg");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int status_ind {
            get {
                return this.status_indField;
            }
            set {
                this.status_indField = value;
                this.RaisePropertyChanged("status_ind");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public System.Nullable<int> no_of_uses {
            get {
                return this.no_of_usesField;
            }
            set {
                this.no_of_usesField = value;
                this.RaisePropertyChanged("no_of_uses");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool no_of_usesSpecified {
            get {
                return this.no_of_usesFieldSpecified;
            }
            set {
                this.no_of_usesFieldSpecified = value;
                this.RaisePropertyChanged("no_of_usesSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string start_date {
            get {
                return this.start_dateField;
            }
            set {
                this.start_dateField = value;
                this.RaisePropertyChanged("start_date");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string end_date {
            get {
                return this.end_dateField;
            }
            set {
                this.end_dateField = value;
                this.RaisePropertyChanged("end_date");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class credit_templates_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private int recurring_credit_template_noField;
        private string credit_template_nameField;
        private string client_credit_template_idField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int recurring_credit_template_no {
            get {
                return this.recurring_credit_template_noField;
            }
            set {
                this.recurring_credit_template_noField = value;
                this.RaisePropertyChanged("recurring_credit_template_no");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string credit_template_name {
            get {
                return this.credit_template_nameField;
            }
            set {
                this.credit_template_nameField = value;
                this.RaisePropertyChanged("credit_template_name");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public string client_credit_template_id {
            get {
                return this.client_credit_template_idField;
            }
            set {
                this.client_credit_template_idField = value;
                this.RaisePropertyChanged("client_credit_template_id");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class plans_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private string plan_nameField;
        private string plan_descField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string plan_name {
            get {
                return this.plan_nameField;
            }
            set {
                this.plan_nameField = value;
                this.RaisePropertyChanged("plan_name");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string plan_desc {
            get {
                return this.plan_descField;
            }
            set {
                this.plan_descField = value;
                this.RaisePropertyChanged("plan_desc");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class surcharge_no_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private System.Nullable<int> surcharge_nosField;
                private bool surcharge_nosFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> surcharge_nos {
            get {
                return this.surcharge_nosField;
            }
            set {
                this.surcharge_nosField = value;
                this.RaisePropertyChanged("surcharge_nos");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool surcharge_nosSpecified {
            get {
                return this.surcharge_nosFieldSpecified;
            }
            set {
                this.surcharge_nosFieldSpecified = value;
                this.RaisePropertyChanged("surcharge_nosSpecified");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class client_surcharge_id_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private System.Nullable<int> client_surcharge_idsField;
                private bool client_surcharge_idsFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> client_surcharge_ids {
            get {
                return this.client_surcharge_idsField;
            }
            set {
                this.client_surcharge_idsField = value;
                this.RaisePropertyChanged("client_surcharge_ids");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool client_surcharge_idsSpecified {
            get {
                return this.client_surcharge_idsFieldSpecified;
            }
            set {
                this.client_surcharge_idsFieldSpecified = value;
                this.RaisePropertyChanged("client_surcharge_idsSpecified");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class plan_group_ids_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private int plan_group_idField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int plan_group_id {
            get {
                return this.plan_group_idField;
            }
            set {
                this.plan_group_idField = value;
                this.RaisePropertyChanged("plan_group_id");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class surcharges_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private int surcharge_noField;
        private string client_surcharge_idField;
        private string surcharge_nameField;
        private string surcharge_type_cdField;
        private string currency_cdField;
        private string scope_labelField;
        private string deleteableField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int surcharge_no {
            get {
                return this.surcharge_noField;
            }
            set {
                this.surcharge_noField = value;
                this.RaisePropertyChanged("surcharge_no");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string client_surcharge_id {
            get {
                return this.client_surcharge_idField;
            }
            set {
                this.client_surcharge_idField = value;
                this.RaisePropertyChanged("client_surcharge_id");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string surcharge_name {
            get {
                return this.surcharge_nameField;
            }
            set {
                this.surcharge_nameField = value;
                this.RaisePropertyChanged("surcharge_name");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string surcharge_type_cd {
            get {
                return this.surcharge_type_cdField;
            }
            set {
                this.surcharge_type_cdField = value;
                this.RaisePropertyChanged("surcharge_type_cd");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public string currency_cd {
            get {
                return this.currency_cdField;
            }
            set {
                this.currency_cdField = value;
                this.RaisePropertyChanged("currency_cd");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string scope_label {
            get {
                return this.scope_labelField;
            }
            set {
                this.scope_labelField = value;
                this.RaisePropertyChanged("scope_label");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string deleteable {
            get {
                return this.deleteableField;
            }
            set {
                this.deleteableField = value;
                this.RaisePropertyChanged("deleteable");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class promotions_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private string promo_cdField;
        private string promo_descField;
        private string expires_afterField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string promo_cd {
            get {
                return this.promo_cdField;
            }
            set {
                this.promo_cdField = value;
                this.RaisePropertyChanged("promo_cd");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string promo_desc {
            get {
                return this.promo_descField;
            }
            set {
                this.promo_descField = value;
                this.RaisePropertyChanged("promo_desc");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string expires_after {
            get {
                return this.expires_afterField;
            }
            set {
                this.expires_afterField = value;
                this.RaisePropertyChanged("expires_after");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class usage_types_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private int usage_type_noField;
        private string usage_type_nameField;
        private string usage_type_descField;
        private string unit_typeField;
        private string usage_type_cdField;
        private bool is_editableField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int usage_type_no {
            get {
                return this.usage_type_noField;
            }
            set {
                this.usage_type_noField = value;
                this.RaisePropertyChanged("usage_type_no");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string usage_type_name {
            get {
                return this.usage_type_nameField;
            }
            set {
                this.usage_type_nameField = value;
                this.RaisePropertyChanged("usage_type_name");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string usage_type_desc {
            get {
                return this.usage_type_descField;
            }
            set {
                this.usage_type_descField = value;
                this.RaisePropertyChanged("usage_type_desc");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string unit_type {
            get {
                return this.unit_typeField;
            }
            set {
                this.unit_typeField = value;
                this.RaisePropertyChanged("unit_type");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public string usage_type_cd {
            get {
                return this.usage_type_cdField;
            }
            set {
                this.usage_type_cdField = value;
                this.RaisePropertyChanged("usage_type_cd");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public bool is_editable {
            get {
                return this.is_editableField;
            }
            set {
                this.is_editableField = value;
                this.RaisePropertyChanged("is_editable");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class usage_unit_types_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private int usage_unit_type_noField;
        private string usage_unit_type_descField;
        private string client_usage_unit_type_idField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int usage_unit_type_no {
            get {
                return this.usage_unit_type_noField;
            }
            set {
                this.usage_unit_type_noField = value;
                this.RaisePropertyChanged("usage_unit_type_no");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string usage_unit_type_desc {
            get {
                return this.usage_unit_type_descField;
            }
            set {
                this.usage_unit_type_descField = value;
                this.RaisePropertyChanged("usage_unit_type_desc");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public string client_usage_unit_type_id {
            get {
                return this.client_usage_unit_type_idField;
            }
            set {
                this.client_usage_unit_type_idField = value;
                this.RaisePropertyChanged("client_usage_unit_type_id");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class allowed_values_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private string valueField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
                this.RaisePropertyChanged("value");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class associated_objects_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private string associated_objectField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string associated_object {
            get {
                return this.associated_objectField;
            }
            set {
                this.associated_objectField = value;
                this.RaisePropertyChanged("associated_object");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class coa_list_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private System.Nullable<long> coa_idField;
                private bool coa_idFieldSpecified;
        private string coa_codeField;
        private string coa_descriptionField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<long> coa_id {
            get {
                return this.coa_idField;
            }
            set {
                this.coa_idField = value;
                this.RaisePropertyChanged("coa_id");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool coa_idSpecified {
            get {
                return this.coa_idFieldSpecified;
            }
            set {
                this.coa_idFieldSpecified = value;
                this.RaisePropertyChanged("coa_idSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string coa_code {
            get {
                return this.coa_codeField;
            }
            set {
                this.coa_codeField = value;
                this.RaisePropertyChanged("coa_code");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public string coa_description {
            get {
                return this.coa_descriptionField;
            }
            set {
                this.coa_descriptionField = value;
                this.RaisePropertyChanged("coa_description");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class coa_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private System.Nullable<long> coa_idField;
                private bool coa_idFieldSpecified;
        private string coa_codeField;
        private string coa_descriptionField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<long> coa_id {
            get {
                return this.coa_idField;
            }
            set {
                this.coa_idField = value;
                this.RaisePropertyChanged("coa_id");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool coa_idSpecified {
            get {
                return this.coa_idFieldSpecified;
            }
            set {
                this.coa_idFieldSpecified = value;
                this.RaisePropertyChanged("coa_idSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string coa_code {
            get {
                return this.coa_codeField;
            }
            set {
                this.coa_codeField = value;
                this.RaisePropertyChanged("coa_code");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public string coa_description {
            get {
                return this.coa_descriptionField;
            }
            set {
                this.coa_descriptionField = value;
                this.RaisePropertyChanged("coa_description");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class plan_service_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_no_ReturnElement[] plan_noField;
        private Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_plan_id_ReturnElement[] client_plan_idField;
        private Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_no_ReturnElement[] service_noField;
        private Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_service_id_ReturnElement[] client_service_idField;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("plan_no", IsNullable=true, Order=0)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_no_ReturnElement[] plan_no {
            get {
                return this.plan_noField;
            }
            set {
                this.plan_noField = value;
                this.RaisePropertyChanged("plan_no");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("client_plan_id", IsNullable=true, Order=1)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_plan_id_ReturnElement[] client_plan_id {
            get {
                return this.client_plan_idField;
            }
            set {
                this.client_plan_idField = value;
                this.RaisePropertyChanged("client_plan_id");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("service_no", IsNullable=true, Order=2)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_no_ReturnElement[] service_no {
            get {
                return this.service_noField;
            }
            set {
                this.service_noField = value;
                this.RaisePropertyChanged("service_no");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("client_service_id", IsNullable=true, Order=3)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_service_id_ReturnElement[] client_service_id {
            get {
                return this.client_service_idField;
            }
            set {
                this.client_service_idField = value;
                this.RaisePropertyChanged("client_service_id");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class tier_ReturnElement : object, System.ComponentModel.INotifyPropertyChanged {
        private int fromField;
        private System.Nullable<int> toField;
                private bool toFieldSpecified;
        private System.Nullable<long> rateField;
                private bool rateFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int from {
            get {
                return this.fromField;
            }
            set {
                this.fromField = value;
                this.RaisePropertyChanged("from");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public System.Nullable<int> to {
            get {
                return this.toField;
            }
            set {
                this.toField = value;
                this.RaisePropertyChanged("to");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool toSpecified {
            get {
                return this.toFieldSpecified;
            }
            set {
                this.toFieldSpecified = value;
                this.RaisePropertyChanged("toSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public System.Nullable<long> rate {
            get {
                return this.rateField;
            }
            set {
                this.rateField = value;
                this.RaisePropertyChanged("rate");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rateSpecified {
            get {
                return this.rateFieldSpecified;
            }
            set {
                this.rateFieldSpecified = value;
                this.RaisePropertyChanged("rateSpecified");
            }
        }
                
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
            /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class service_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int service_noField;private string pricing_ruleField;private string high_waterField;private System.Nullable<int> billing_optionField;        private bool billing_optionFieldSpecified;
        private System.Nullable<int> thresholdField;        private bool thresholdFieldSpecified;
        private Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.tier_row[] tierField;/// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int service_no {
            get {
                return this.service_noField;
            }
            set {
                this.service_noField = value;
                this.RaisePropertyChanged("service_no");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string pricing_rule {
            get {
                return this.pricing_ruleField;
            }
            set {
                this.pricing_ruleField = value;
                this.RaisePropertyChanged("pricing_rule");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public string high_water {
            get {
                return this.high_waterField;
            }
            set {
                this.high_waterField = value;
                this.RaisePropertyChanged("high_water");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public System.Nullable<int> billing_option {
            get {
                return this.billing_optionField;
            }
            set {
                this.billing_optionField = value;
                this.RaisePropertyChanged("billing_option");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool billing_optionSpecified {
            get {
                return this.billing_optionFieldSpecified;
            }
            set {
                this.billing_optionFieldSpecified = value;
                this.RaisePropertyChanged("billing_optionSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public System.Nullable<int> threshold {
            get {
                return this.thresholdField;
            }
            set {
                this.thresholdField = value;
                this.RaisePropertyChanged("threshold");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool thresholdSpecified {
            get {
                return this.thresholdFieldSpecified;
            }
            set {
                this.thresholdFieldSpecified = value;
                this.RaisePropertyChanged("thresholdSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("tier", IsNullable=true, Order=5)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.tier_row[] tier {
            get {
                return this.tierField;
            }
            set {
                this.tierField = value;
                this.RaisePropertyChanged("tier");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class image_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string main_image_urlField;private string thumbnail_image_urlField;private string image_textField;private int default_indField;private int activeField;/// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string main_image_url {
            get {
                return this.main_image_urlField;
            }
            set {
                this.main_image_urlField = value;
                this.RaisePropertyChanged("main_image_url");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string thumbnail_image_url {
            get {
                return this.thumbnail_image_urlField;
            }
            set {
                this.thumbnail_image_urlField = value;
                this.RaisePropertyChanged("thumbnail_image_url");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public string image_text {
            get {
                return this.image_textField;
            }
            set {
                this.image_textField = value;
                this.RaisePropertyChanged("image_text");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int default_ind {
            get {
                return this.default_indField;
            }
            set {
                this.default_indField = value;
                this.RaisePropertyChanged("default_ind");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int active {
            get {
                return this.activeField;
            }
            set {
                this.activeField = value;
                this.RaisePropertyChanged("active");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class parent_class_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<int> class_noField;        private bool class_noFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> class_no {
            get {
                return this.class_noField;
            }
            set {
                this.class_noField = value;
                this.RaisePropertyChanged("class_no");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool class_noSpecified {
            get {
                return this.class_noFieldSpecified;
            }
            set {
                this.class_noFieldSpecified = value;
                this.RaisePropertyChanged("class_noSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class supplemental_obj_field_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string supplemental_obj_fieldField;/// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string supplemental_obj_field {
            get {
                return this.supplemental_obj_fieldField;
            }
            set {
                this.supplemental_obj_fieldField = value;
                this.RaisePropertyChanged("supplemental_obj_field");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class rules_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<int> ruleField;        private bool ruleFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> rule {
            get {
                return this.ruleField;
            }
            set {
                this.ruleField = value;
                this.RaisePropertyChanged("rule");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ruleSpecified {
            get {
                return this.ruleFieldSpecified;
            }
            set {
                this.ruleFieldSpecified = value;
                this.RaisePropertyChanged("ruleSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class rule_ids_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<int> rule_idField;        private bool rule_idFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> rule_id {
            get {
                return this.rule_idField;
            }
            set {
                this.rule_idField = value;
                this.RaisePropertyChanged("rule_id");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rule_idSpecified {
            get {
                return this.rule_idFieldSpecified;
            }
            set {
                this.rule_idFieldSpecified = value;
                this.RaisePropertyChanged("rule_idSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class plan_no_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<int> plan_nosField;        private bool plan_nosFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> plan_nos {
            get {
                return this.plan_nosField;
            }
            set {
                this.plan_nosField = value;
                this.RaisePropertyChanged("plan_nos");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool plan_nosSpecified {
            get {
                return this.plan_nosFieldSpecified;
            }
            set {
                this.plan_nosFieldSpecified = value;
                this.RaisePropertyChanged("plan_nosSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class client_plan_id_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<int> client_plan_idsField;        private bool client_plan_idsFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> client_plan_ids {
            get {
                return this.client_plan_idsField;
            }
            set {
                this.client_plan_idsField = value;
                this.RaisePropertyChanged("client_plan_ids");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool client_plan_idsSpecified {
            get {
                return this.client_plan_idsFieldSpecified;
            }
            set {
                this.client_plan_idsFieldSpecified = value;
                this.RaisePropertyChanged("client_plan_idsSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class service_no_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<int> service_nosField;        private bool service_nosFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> service_nos {
            get {
                return this.service_nosField;
            }
            set {
                this.service_nosField = value;
                this.RaisePropertyChanged("service_nos");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool service_nosSpecified {
            get {
                return this.service_nosFieldSpecified;
            }
            set {
                this.service_nosFieldSpecified = value;
                this.RaisePropertyChanged("service_nosSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class client_service_id_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<int> client_service_idsField;        private bool client_service_idsFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> client_service_ids {
            get {
                return this.client_service_idsField;
            }
            set {
                this.client_service_idsField = value;
                this.RaisePropertyChanged("client_service_ids");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool client_service_idsSpecified {
            get {
                return this.client_service_idsFieldSpecified;
            }
            set {
                this.client_service_idsFieldSpecified = value;
                this.RaisePropertyChanged("client_service_idsSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class item_no_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<int> item_nosField;        private bool item_nosFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> item_nos {
            get {
                return this.item_nosField;
            }
            set {
                this.item_nosField = value;
                this.RaisePropertyChanged("item_nos");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool item_nosSpecified {
            get {
                return this.item_nosFieldSpecified;
            }
            set {
                this.item_nosFieldSpecified = value;
                this.RaisePropertyChanged("item_nosSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class client_item_id_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<int> client_item_idsField;        private bool client_item_idsFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> client_item_ids {
            get {
                return this.client_item_idsField;
            }
            set {
                this.client_item_idsField = value;
                this.RaisePropertyChanged("client_item_ids");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool client_item_idsSpecified {
            get {
                return this.client_item_idsFieldSpecified;
            }
            set {
                this.client_item_idsFieldSpecified = value;
                this.RaisePropertyChanged("client_item_idsSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class eligible_service_types_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string eligible_service_typeField;/// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string eligible_service_type {
            get {
                return this.eligible_service_typeField;
            }
            set {
                this.eligible_service_typeField = value;
                this.RaisePropertyChanged("eligible_service_type");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class template_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string credit_template_nameField;private string client_credit_template_idField;private int eligible_plan_noField;private string eligible_client_plan_idField;private int eligible_service_noField;private string eligible_client_service_idField;private Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.eligible_service_types_row[] eligible_service_typesField;private int discount_typeField;private float discount_amtField;private int no_of_creditsField;private int credit_interval_monthsField;private int percentage_plan_noField;private string percentage_client_plan_idField;private int percentage_service_noField;private string percentage_client_service_idField;private int alt_service_noField;private string alt_client_service_idField;/// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string credit_template_name {
            get {
                return this.credit_template_nameField;
            }
            set {
                this.credit_template_nameField = value;
                this.RaisePropertyChanged("credit_template_name");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string client_credit_template_id {
            get {
                return this.client_credit_template_idField;
            }
            set {
                this.client_credit_template_idField = value;
                this.RaisePropertyChanged("client_credit_template_id");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public int eligible_plan_no {
            get {
                return this.eligible_plan_noField;
            }
            set {
                this.eligible_plan_noField = value;
                this.RaisePropertyChanged("eligible_plan_no");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public string eligible_client_plan_id {
            get {
                return this.eligible_client_plan_idField;
            }
            set {
                this.eligible_client_plan_idField = value;
                this.RaisePropertyChanged("eligible_client_plan_id");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int eligible_service_no {
            get {
                return this.eligible_service_noField;
            }
            set {
                this.eligible_service_noField = value;
                this.RaisePropertyChanged("eligible_service_no");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public string eligible_client_service_id {
            get {
                return this.eligible_client_service_idField;
            }
            set {
                this.eligible_client_service_idField = value;
                this.RaisePropertyChanged("eligible_client_service_id");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("eligible_service_types", IsNullable=true, Order=6)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.eligible_service_types_row[] eligible_service_types {
            get {
                return this.eligible_service_typesField;
            }
            set {
                this.eligible_service_typesField = value;
                this.RaisePropertyChanged("eligible_service_types");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public int discount_type {
            get {
                return this.discount_typeField;
            }
            set {
                this.discount_typeField = value;
                this.RaisePropertyChanged("discount_type");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public float discount_amt {
            get {
                return this.discount_amtField;
            }
            set {
                this.discount_amtField = value;
                this.RaisePropertyChanged("discount_amt");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=9)]
        public int no_of_credits {
            get {
                return this.no_of_creditsField;
            }
            set {
                this.no_of_creditsField = value;
                this.RaisePropertyChanged("no_of_credits");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public int credit_interval_months {
            get {
                return this.credit_interval_monthsField;
            }
            set {
                this.credit_interval_monthsField = value;
                this.RaisePropertyChanged("credit_interval_months");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=11)]
        public int percentage_plan_no {
            get {
                return this.percentage_plan_noField;
            }
            set {
                this.percentage_plan_noField = value;
                this.RaisePropertyChanged("percentage_plan_no");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=12)]
        public string percentage_client_plan_id {
            get {
                return this.percentage_client_plan_idField;
            }
            set {
                this.percentage_client_plan_idField = value;
                this.RaisePropertyChanged("percentage_client_plan_id");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=13)]
        public int percentage_service_no {
            get {
                return this.percentage_service_noField;
            }
            set {
                this.percentage_service_noField = value;
                this.RaisePropertyChanged("percentage_service_no");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=14)]
        public string percentage_client_service_id {
            get {
                return this.percentage_client_service_idField;
            }
            set {
                this.percentage_client_service_idField = value;
                this.RaisePropertyChanged("percentage_client_service_id");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public int alt_service_no {
            get {
                return this.alt_service_noField;
            }
            set {
                this.alt_service_noField = value;
                this.RaisePropertyChanged("alt_service_no");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=16)]
        public string alt_client_service_id {
            get {
                return this.alt_client_service_idField;
            }
            set {
                this.alt_client_service_idField = value;
                this.RaisePropertyChanged("alt_client_service_id");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class existing_template_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<int> existing_templatesField;        private bool existing_templatesFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> existing_templates {
            get {
                return this.existing_templatesField;
            }
            set {
                this.existing_templatesField = value;
                this.RaisePropertyChanged("existing_templates");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool existing_templatesSpecified {
            get {
                return this.existing_templatesFieldSpecified;
            }
            set {
                this.existing_templatesFieldSpecified = value;
                this.RaisePropertyChanged("existing_templatesSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class existing_template_id_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<int> existing_template_idsField;        private bool existing_template_idsFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> existing_template_ids {
            get {
                return this.existing_template_idsField;
            }
            set {
                this.existing_template_idsField = value;
                this.RaisePropertyChanged("existing_template_ids");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool existing_template_idsSpecified {
            get {
                return this.existing_template_idsFieldSpecified;
            }
            set {
                this.existing_template_idsFieldSpecified = value;
                this.RaisePropertyChanged("existing_template_idsSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class discount_rule_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string labelField;private string rule_idField;private string descriptionField;private string ext_descriptionField;private int flat_percent_indField;private float amountField;private string currencyField;private string duration_type_indField;private System.Nullable<int> max_applicable_monthsField;        private bool max_applicable_monthsFieldSpecified;
        private System.Nullable<int> max_applications_per_acctField;        private bool max_applications_per_acctFieldSpecified;
        private string inline_offset_indField;private System.Nullable<int> service_code_to_useField;        private bool service_code_to_useFieldSpecified;
        private System.Nullable<int> alt_service_no_2_applyField;        private bool alt_service_no_2_applyFieldSpecified;
        private System.Nullable<int> alt_service_id_2_applyField;        private bool alt_service_id_2_applyFieldSpecified;
        private string applicable_trans_scopeField;private int scope_noField;private Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_no_row[] plan_noField;private Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_plan_id_row[] client_plan_idField;private Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_no_row[] service_noField;private Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_service_id_row[] client_service_idField;private Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.item_no_row[] item_noField;private Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_item_id_row[] client_item_idField;private string use_all_or_nth_subs_ruleField;/// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string label {
            get {
                return this.labelField;
            }
            set {
                this.labelField = value;
                this.RaisePropertyChanged("label");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string rule_id {
            get {
                return this.rule_idField;
            }
            set {
                this.rule_idField = value;
                this.RaisePropertyChanged("rule_id");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
                this.RaisePropertyChanged("description");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string ext_description {
            get {
                return this.ext_descriptionField;
            }
            set {
                this.ext_descriptionField = value;
                this.RaisePropertyChanged("ext_description");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int flat_percent_ind {
            get {
                return this.flat_percent_indField;
            }
            set {
                this.flat_percent_indField = value;
                this.RaisePropertyChanged("flat_percent_ind");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public float amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
                this.RaisePropertyChanged("amount");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string currency {
            get {
                return this.currencyField;
            }
            set {
                this.currencyField = value;
                this.RaisePropertyChanged("currency");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public string duration_type_ind {
            get {
                return this.duration_type_indField;
            }
            set {
                this.duration_type_indField = value;
                this.RaisePropertyChanged("duration_type_ind");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=8)]
        public System.Nullable<int> max_applicable_months {
            get {
                return this.max_applicable_monthsField;
            }
            set {
                this.max_applicable_monthsField = value;
                this.RaisePropertyChanged("max_applicable_months");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool max_applicable_monthsSpecified {
            get {
                return this.max_applicable_monthsFieldSpecified;
            }
            set {
                this.max_applicable_monthsFieldSpecified = value;
                this.RaisePropertyChanged("max_applicable_monthsSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=9)]
        public System.Nullable<int> max_applications_per_acct {
            get {
                return this.max_applications_per_acctField;
            }
            set {
                this.max_applications_per_acctField = value;
                this.RaisePropertyChanged("max_applications_per_acct");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool max_applications_per_acctSpecified {
            get {
                return this.max_applications_per_acctFieldSpecified;
            }
            set {
                this.max_applications_per_acctFieldSpecified = value;
                this.RaisePropertyChanged("max_applications_per_acctSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=10)]
        public string inline_offset_ind {
            get {
                return this.inline_offset_indField;
            }
            set {
                this.inline_offset_indField = value;
                this.RaisePropertyChanged("inline_offset_ind");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=11)]
        public System.Nullable<int> service_code_to_use {
            get {
                return this.service_code_to_useField;
            }
            set {
                this.service_code_to_useField = value;
                this.RaisePropertyChanged("service_code_to_use");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool service_code_to_useSpecified {
            get {
                return this.service_code_to_useFieldSpecified;
            }
            set {
                this.service_code_to_useFieldSpecified = value;
                this.RaisePropertyChanged("service_code_to_useSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=12)]
        public System.Nullable<int> alt_service_no_2_apply {
            get {
                return this.alt_service_no_2_applyField;
            }
            set {
                this.alt_service_no_2_applyField = value;
                this.RaisePropertyChanged("alt_service_no_2_apply");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool alt_service_no_2_applySpecified {
            get {
                return this.alt_service_no_2_applyFieldSpecified;
            }
            set {
                this.alt_service_no_2_applyFieldSpecified = value;
                this.RaisePropertyChanged("alt_service_no_2_applySpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=13)]
        public System.Nullable<int> alt_service_id_2_apply {
            get {
                return this.alt_service_id_2_applyField;
            }
            set {
                this.alt_service_id_2_applyField = value;
                this.RaisePropertyChanged("alt_service_id_2_apply");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool alt_service_id_2_applySpecified {
            get {
                return this.alt_service_id_2_applyFieldSpecified;
            }
            set {
                this.alt_service_id_2_applyFieldSpecified = value;
                this.RaisePropertyChanged("alt_service_id_2_applySpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=14)]
        public string applicable_trans_scope {
            get {
                return this.applicable_trans_scopeField;
            }
            set {
                this.applicable_trans_scopeField = value;
                this.RaisePropertyChanged("applicable_trans_scope");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=15)]
        public int scope_no {
            get {
                return this.scope_noField;
            }
            set {
                this.scope_noField = value;
                this.RaisePropertyChanged("scope_no");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("plan_no", IsNullable=true, Order=16)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_no_row[] plan_no {
            get {
                return this.plan_noField;
            }
            set {
                this.plan_noField = value;
                this.RaisePropertyChanged("plan_no");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("client_plan_id", IsNullable=true, Order=17)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_plan_id_row[] client_plan_id {
            get {
                return this.client_plan_idField;
            }
            set {
                this.client_plan_idField = value;
                this.RaisePropertyChanged("client_plan_id");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("service_no", IsNullable=true, Order=18)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_no_row[] service_no {
            get {
                return this.service_noField;
            }
            set {
                this.service_noField = value;
                this.RaisePropertyChanged("service_no");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("client_service_id", IsNullable=true, Order=19)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_service_id_row[] client_service_id {
            get {
                return this.client_service_idField;
            }
            set {
                this.client_service_idField = value;
                this.RaisePropertyChanged("client_service_id");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("item_no", IsNullable=true, Order=20)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.item_no_row[] item_no {
            get {
                return this.item_noField;
            }
            set {
                this.item_noField = value;
                this.RaisePropertyChanged("item_no");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("client_item_id", IsNullable=true, Order=21)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_item_id_row[] client_item_id {
            get {
                return this.client_item_idField;
            }
            set {
                this.client_item_idField = value;
                this.RaisePropertyChanged("client_item_id");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=22)]
        public string use_all_or_nth_subs_rule {
            get {
                return this.use_all_or_nth_subs_ruleField;
            }
            set {
                this.use_all_or_nth_subs_ruleField = value;
                this.RaisePropertyChanged("use_all_or_nth_subs_rule");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class existing_discount_rule_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<int> existing_rulesField;        private bool existing_rulesFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> existing_rules {
            get {
                return this.existing_rulesField;
            }
            set {
                this.existing_rulesField = value;
                this.RaisePropertyChanged("existing_rules");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool existing_rulesSpecified {
            get {
                return this.existing_rulesFieldSpecified;
            }
            set {
                this.existing_rulesFieldSpecified = value;
                this.RaisePropertyChanged("existing_rulesSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class existing_discount_rule_id_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<int> existing_discount_rule_idsField;        private bool existing_discount_rule_idsFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> existing_discount_rule_ids {
            get {
                return this.existing_discount_rule_idsField;
            }
            set {
                this.existing_discount_rule_idsField = value;
                this.RaisePropertyChanged("existing_discount_rule_ids");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool existing_discount_rule_idsSpecified {
            get {
                return this.existing_discount_rule_idsFieldSpecified;
            }
            set {
                this.existing_discount_rule_idsFieldSpecified = value;
                this.RaisePropertyChanged("existing_discount_rule_idsSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class discount_bundle_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string bundle_nameField;private string bundle_idField;private string bundle_descriptionField;private string allow_overlap_indField;private Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rules_row[] rulesField;private Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rule_ids_row[] rule_idsField;/// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string bundle_name {
            get {
                return this.bundle_nameField;
            }
            set {
                this.bundle_nameField = value;
                this.RaisePropertyChanged("bundle_name");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string bundle_id {
            get {
                return this.bundle_idField;
            }
            set {
                this.bundle_idField = value;
                this.RaisePropertyChanged("bundle_id");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string bundle_description {
            get {
                return this.bundle_descriptionField;
            }
            set {
                this.bundle_descriptionField = value;
                this.RaisePropertyChanged("bundle_description");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string allow_overlap_ind {
            get {
                return this.allow_overlap_indField;
            }
            set {
                this.allow_overlap_indField = value;
                this.RaisePropertyChanged("allow_overlap_ind");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("rules", IsNullable=true, Order=4)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rules_row[] rules {
            get {
                return this.rulesField;
            }
            set {
                this.rulesField = value;
                this.RaisePropertyChanged("rules");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("rule_ids", IsNullable=true, Order=5)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rule_ids_row[] rule_ids {
            get {
                return this.rule_idsField;
            }
            set {
                this.rule_idsField = value;
                this.RaisePropertyChanged("rule_ids");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class existing_discount_bundle_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<int> existing_bundlesField;        private bool existing_bundlesFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> existing_bundles {
            get {
                return this.existing_bundlesField;
            }
            set {
                this.existing_bundlesField = value;
                this.RaisePropertyChanged("existing_bundles");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool existing_bundlesSpecified {
            get {
                return this.existing_bundlesFieldSpecified;
            }
            set {
                this.existing_bundlesFieldSpecified = value;
                this.RaisePropertyChanged("existing_bundlesSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class existing_discount_bundle_id_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<int> existing_bundle_idsField;        private bool existing_bundle_idsFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> existing_bundle_ids {
            get {
                return this.existing_bundle_idsField;
            }
            set {
                this.existing_bundle_idsField = value;
                this.RaisePropertyChanged("existing_bundle_ids");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool existing_bundle_idsSpecified {
            get {
                return this.existing_bundle_idsFieldSpecified;
            }
            set {
                this.existing_bundle_idsFieldSpecified = value;
                this.RaisePropertyChanged("existing_bundle_idsSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class coupon_nos_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<int> coupon_nosField;        private bool coupon_nosFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> coupon_nos {
            get {
                return this.coupon_nosField;
            }
            set {
                this.coupon_nosField = value;
                this.RaisePropertyChanged("coupon_nos");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool coupon_nosSpecified {
            get {
                return this.coupon_nosFieldSpecified;
            }
            set {
                this.coupon_nosFieldSpecified = value;
                this.RaisePropertyChanged("coupon_nosSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class coupon_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string coupon_cdField;private string coupon_descField;private string coupon_msgField;private int status_indField;private System.Nullable<int> no_of_usesField;        private bool no_of_usesFieldSpecified;
        private string start_dateField;private string end_dateField;/// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string coupon_cd {
            get {
                return this.coupon_cdField;
            }
            set {
                this.coupon_cdField = value;
                this.RaisePropertyChanged("coupon_cd");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string coupon_desc {
            get {
                return this.coupon_descField;
            }
            set {
                this.coupon_descField = value;
                this.RaisePropertyChanged("coupon_desc");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public string coupon_msg {
            get {
                return this.coupon_msgField;
            }
            set {
                this.coupon_msgField = value;
                this.RaisePropertyChanged("coupon_msg");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public int status_ind {
            get {
                return this.status_indField;
            }
            set {
                this.status_indField = value;
                this.RaisePropertyChanged("status_ind");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public System.Nullable<int> no_of_uses {
            get {
                return this.no_of_usesField;
            }
            set {
                this.no_of_usesField = value;
                this.RaisePropertyChanged("no_of_uses");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool no_of_usesSpecified {
            get {
                return this.no_of_usesFieldSpecified;
            }
            set {
                this.no_of_usesFieldSpecified = value;
                this.RaisePropertyChanged("no_of_usesSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=5)]
        public string start_date {
            get {
                return this.start_dateField;
            }
            set {
                this.start_dateField = value;
                this.RaisePropertyChanged("start_date");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public string end_date {
            get {
                return this.end_dateField;
            }
            set {
                this.end_dateField = value;
                this.RaisePropertyChanged("end_date");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class existing_coupon_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<int> existing_couponsField;        private bool existing_couponsFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> existing_coupons {
            get {
                return this.existing_couponsField;
            }
            set {
                this.existing_couponsField = value;
                this.RaisePropertyChanged("existing_coupons");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool existing_couponsSpecified {
            get {
                return this.existing_couponsFieldSpecified;
            }
            set {
                this.existing_couponsFieldSpecified = value;
                this.RaisePropertyChanged("existing_couponsSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class template_nos_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<int> template_nosField;        private bool template_nosFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> template_nos {
            get {
                return this.template_nosField;
            }
            set {
                this.template_nosField = value;
                this.RaisePropertyChanged("template_nos");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool template_nosSpecified {
            get {
                return this.template_nosFieldSpecified;
            }
            set {
                this.template_nosFieldSpecified = value;
                this.RaisePropertyChanged("template_nosSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class rule_nos_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<int> rule_nosField;        private bool rule_nosFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> rule_nos {
            get {
                return this.rule_nosField;
            }
            set {
                this.rule_nosField = value;
                this.RaisePropertyChanged("rule_nos");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool rule_nosSpecified {
            get {
                return this.rule_nosFieldSpecified;
            }
            set {
                this.rule_nosFieldSpecified = value;
                this.RaisePropertyChanged("rule_nosSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class bundle_nos_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<int> bundle_nosField;        private bool bundle_nosFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> bundle_nos {
            get {
                return this.bundle_nosField;
            }
            set {
                this.bundle_nosField = value;
                this.RaisePropertyChanged("bundle_nos");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool bundle_nosSpecified {
            get {
                return this.bundle_nosFieldSpecified;
            }
            set {
                this.bundle_nosFieldSpecified = value;
                this.RaisePropertyChanged("bundle_nosSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class price_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<long> amountField;        private bool amountFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<long> amount {
            get {
                return this.amountField;
            }
            set {
                this.amountField = value;
                this.RaisePropertyChanged("amount");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool amountSpecified {
            get {
                return this.amountFieldSpecified;
            }
            set {
                this.amountFieldSpecified = value;
                this.RaisePropertyChanged("amountSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class tier_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int fromField;private System.Nullable<int> toField;        private bool toFieldSpecified;
        private long rateField;/// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int from {
            get {
                return this.fromField;
            }
            set {
                this.fromField = value;
                this.RaisePropertyChanged("from");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public System.Nullable<int> to {
            get {
                return this.toField;
            }
            set {
                this.toField = value;
                this.RaisePropertyChanged("to");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool toSpecified {
            get {
                return this.toFieldSpecified;
            }
            set {
                this.toFieldSpecified = value;
                this.RaisePropertyChanged("toSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public long rate {
            get {
                return this.rateField;
            }
            set {
                this.rateField = value;
                this.RaisePropertyChanged("rate");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class plan_group_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<int> plan_groupField;        private bool plan_groupFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> plan_group {
            get {
                return this.plan_groupField;
            }
            set {
                this.plan_groupField = value;
                this.RaisePropertyChanged("plan_group");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool plan_groupSpecified {
            get {
                return this.plan_groupFieldSpecified;
            }
            set {
                this.plan_groupFieldSpecified = value;
                this.RaisePropertyChanged("plan_groupSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class plan_group_id_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string plan_group_idField;/// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string plan_group_id {
            get {
                return this.plan_group_idField;
            }
            set {
                this.plan_group_idField = value;
                this.RaisePropertyChanged("plan_group_id");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class schedule_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int schedule_noField;private string schedule_nameField;private string client_rate_schedule_idField;private string currency_cdField;private int is_defaultField;/// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int schedule_no {
            get {
                return this.schedule_noField;
            }
            set {
                this.schedule_noField = value;
                this.RaisePropertyChanged("schedule_no");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string schedule_name {
            get {
                return this.schedule_nameField;
            }
            set {
                this.schedule_nameField = value;
                this.RaisePropertyChanged("schedule_name");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=2)]
        public string client_rate_schedule_id {
            get {
                return this.client_rate_schedule_idField;
            }
            set {
                this.client_rate_schedule_idField = value;
                this.RaisePropertyChanged("client_rate_schedule_id");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=3)]
        public string currency_cd {
            get {
                return this.currency_cdField;
            }
            set {
                this.currency_cdField = value;
                this.RaisePropertyChanged("currency_cd");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=4)]
        public int is_default {
            get {
                return this.is_defaultField;
            }
            set {
                this.is_defaultField = value;
                this.RaisePropertyChanged("is_default");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class resource_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<int> resource_noField;        private bool resource_noFieldSpecified;
        private string resource_nameField;private string resource_descriptionField;private System.Nullable<int> flat_thresholdField;        private bool flat_thresholdFieldSpecified;
        private System.Nullable<int> resource_unitsField;        private bool resource_unitsFieldSpecified;
        private string expire_on_paid_throughField;private System.Nullable<int> additional_daysField;        private bool additional_daysFieldSpecified;
        private string reset_on_updateField;/// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> resource_no {
            get {
                return this.resource_noField;
            }
            set {
                this.resource_noField = value;
                this.RaisePropertyChanged("resource_no");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool resource_noSpecified {
            get {
                return this.resource_noFieldSpecified;
            }
            set {
                this.resource_noFieldSpecified = value;
                this.RaisePropertyChanged("resource_noSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=1)]
        public string resource_name {
            get {
                return this.resource_nameField;
            }
            set {
                this.resource_nameField = value;
                this.RaisePropertyChanged("resource_name");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=2)]
        public string resource_description {
            get {
                return this.resource_descriptionField;
            }
            set {
                this.resource_descriptionField = value;
                this.RaisePropertyChanged("resource_description");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=3)]
        public System.Nullable<int> flat_threshold {
            get {
                return this.flat_thresholdField;
            }
            set {
                this.flat_thresholdField = value;
                this.RaisePropertyChanged("flat_threshold");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool flat_thresholdSpecified {
            get {
                return this.flat_thresholdFieldSpecified;
            }
            set {
                this.flat_thresholdFieldSpecified = value;
                this.RaisePropertyChanged("flat_thresholdSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=4)]
        public System.Nullable<int> resource_units {
            get {
                return this.resource_unitsField;
            }
            set {
                this.resource_unitsField = value;
                this.RaisePropertyChanged("resource_units");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool resource_unitsSpecified {
            get {
                return this.resource_unitsFieldSpecified;
            }
            set {
                this.resource_unitsFieldSpecified = value;
                this.RaisePropertyChanged("resource_unitsSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=5)]
        public string expire_on_paid_through {
            get {
                return this.expire_on_paid_throughField;
            }
            set {
                this.expire_on_paid_throughField = value;
                this.RaisePropertyChanged("expire_on_paid_through");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=6)]
        public System.Nullable<int> additional_days {
            get {
                return this.additional_daysField;
            }
            set {
                this.additional_daysField = value;
                this.RaisePropertyChanged("additional_days");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool additional_daysSpecified {
            get {
                return this.additional_daysFieldSpecified;
            }
            set {
                this.additional_daysFieldSpecified = value;
                this.RaisePropertyChanged("additional_daysSpecified");
            }
        }
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=7)]
        public string reset_on_update {
            get {
                return this.reset_on_updateField;
            }
            set {
                this.reset_on_updateField = value;
                this.RaisePropertyChanged("reset_on_update");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class parent_plans_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<int> parent_planField;        private bool parent_planFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> parent_plan {
            get {
                return this.parent_planField;
            }
            set {
                this.parent_planField = value;
                this.RaisePropertyChanged("parent_plan");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool parent_planSpecified {
            get {
                return this.parent_planFieldSpecified;
            }
            set {
                this.parent_planFieldSpecified = value;
                this.RaisePropertyChanged("parent_planSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class parent_client_plan_ids_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<int> parent_client_plan_idField;        private bool parent_client_plan_idFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> parent_client_plan_id {
            get {
                return this.parent_client_plan_idField;
            }
            set {
                this.parent_client_plan_idField = value;
                this.RaisePropertyChanged("parent_client_plan_id");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool parent_client_plan_idSpecified {
            get {
                return this.parent_client_plan_idFieldSpecified;
            }
            set {
                this.parent_client_plan_idFieldSpecified = value;
                this.RaisePropertyChanged("parent_client_plan_idSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class exclusion_plans_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<int> exclusion_plansField;        private bool exclusion_plansFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> exclusion_plans {
            get {
                return this.exclusion_plansField;
            }
            set {
                this.exclusion_plansField = value;
                this.RaisePropertyChanged("exclusion_plans");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool exclusion_plansSpecified {
            get {
                return this.exclusion_plansFieldSpecified;
            }
            set {
                this.exclusion_plansFieldSpecified = value;
                this.RaisePropertyChanged("exclusion_plansSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class child_plans_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string child_planField;/// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public string child_plan {
            get {
                return this.child_planField;
            }
            set {
                this.child_planField = value;
                this.RaisePropertyChanged("child_plan");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class surcharge_no_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int surcharge_nosField;/// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int surcharge_nos {
            get {
                return this.surcharge_nosField;
            }
            set {
                this.surcharge_nosField = value;
                this.RaisePropertyChanged("surcharge_nos");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class client_surcharge_id_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int client_surcharge_idsField;/// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public int client_surcharge_ids {
            get {
                return this.client_surcharge_idsField;
            }
            set {
                this.client_surcharge_idsField = value;
                this.RaisePropertyChanged("client_surcharge_ids");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.0.30319.18408")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api")]
    public partial class plan_nos_row : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Nullable<int> plan_nosField;        private bool plan_nosFieldSpecified;
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true, Order=0)]
        public System.Nullable<int> plan_nos {
            get {
                return this.plan_nosField;
            }
            set {
                this.plan_nosField = value;
                this.RaisePropertyChanged("plan_nos");
            }
        }
                /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool plan_nosSpecified {
            get {
                return this.plan_nosFieldSpecified;
            }
            set {
                this.plan_nosFieldSpecified = value;
                this.RaisePropertyChanged("plan_nosSpecified");
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }    
   
                    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_promo_plan_sets", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_promo_plan_setsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
        
        public get_promo_plan_setsRequest() {
        }
        
        public get_promo_plan_setsRequest(long client_no, string auth_key) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_promo_plan_setsResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_promo_plan_setsResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.promo_plan_set_ReturnElement[] promo_plan_set;
                
        public get_promo_plan_setsResponse() {
        }

                 
        public get_promo_plan_setsResponse(long error_code, string error_msg, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.promo_plan_set_ReturnElement[] promo_plan_set) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.promo_plan_set = promo_plan_set;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_promo_plan_set_details", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_promo_plan_set_detailsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public long promo_plan_set_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public string client_plan_type_id;
                
        public get_promo_plan_set_detailsRequest() {
        }
        
        public get_promo_plan_set_detailsRequest(long client_no, string auth_key, long promo_plan_set_no, string client_plan_type_id) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.promo_plan_set_no = promo_plan_set_no;
                        this.client_plan_type_id = client_plan_type_id;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_promo_plan_set_detailsResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_promo_plan_set_detailsResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public long promo_plan_set_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                public string promo_plan_set_name;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                public string promo_plan_set_desc;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                public string client_plan_type_id;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                [System.Xml.Serialization.XmlElementAttribute("plan", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_ReturnElement[] plan;
                
        public get_promo_plan_set_detailsResponse() {
        }

                 
        public get_promo_plan_set_detailsResponse(long error_code, string error_msg, long promo_plan_set_no, string promo_plan_set_name, string promo_plan_set_desc, string client_plan_type_id, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_ReturnElement[] plan) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.promo_plan_set_no = promo_plan_set_no;
                        this.promo_plan_set_name = promo_plan_set_name;
                        this.promo_plan_set_desc = promo_plan_set_desc;
                        this.client_plan_type_id = client_plan_type_id;
                        this.plan = plan;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create_promo_plan_set", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class create_promo_plan_setRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public string promo_plan_set_name;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public string promo_plan_set_desc;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string client_plan_type_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string plan_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string client_plan_id;
                
        public create_promo_plan_setRequest() {
        }
        
        public create_promo_plan_setRequest(long client_no, string auth_key, string promo_plan_set_name, string promo_plan_set_desc, string client_plan_type_id, string plan_no, string client_plan_id) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.promo_plan_set_name = promo_plan_set_name;
                        this.promo_plan_set_desc = promo_plan_set_desc;
                        this.client_plan_type_id = client_plan_type_id;
                        this.plan_no = plan_no;
                        this.client_plan_id = client_plan_id;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create_promo_plan_setResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class create_promo_plan_setResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public int promo_plan_set_no;
                
        public create_promo_plan_setResponse() {
        }

                 
        public create_promo_plan_setResponse(long error_code, string error_msg, int promo_plan_set_no) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.promo_plan_set_no = promo_plan_set_no;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="update_promo_plan_set", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class update_promo_plan_setRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public int promo_plan_set_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public string promo_plan_set_name;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        public string promo_plan_set_desc;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                        public string client_plan_type_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string plan_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string client_plan_id;
                
        public update_promo_plan_setRequest() {
        }
        
        public update_promo_plan_setRequest(long client_no, string auth_key, int promo_plan_set_no, string promo_plan_set_name, string promo_plan_set_desc, string client_plan_type_id, string plan_no, string client_plan_id) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.promo_plan_set_no = promo_plan_set_no;
                        this.promo_plan_set_name = promo_plan_set_name;
                        this.promo_plan_set_desc = promo_plan_set_desc;
                        this.client_plan_type_id = client_plan_type_id;
                        this.plan_no = plan_no;
                        this.client_plan_id = client_plan_id;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="update_promo_plan_setResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class update_promo_plan_setResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public int promo_plan_set_no;
                
        public update_promo_plan_setResponse() {
        }

                 
        public update_promo_plan_setResponse(long error_code, string error_msg, int promo_plan_set_no) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.promo_plan_set_no = promo_plan_set_no;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="list_promo_sets", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class list_promo_setsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
        
        public list_promo_setsRequest() {
        }
        
        public list_promo_setsRequest(long client_no, string auth_key) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="list_promo_setsResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class list_promo_setsResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_groups_ReturnElement[] plan_groups;
                
        public list_promo_setsResponse() {
        }

                 
        public list_promo_setsResponse(long error_code, string error_msg, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_groups_ReturnElement[] plan_groups) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.plan_groups = plan_groups;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_company_profile", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_company_profileRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
        
        public get_company_profileRequest() {
        }
        
        public get_company_profileRequest(long client_no, string auth_key) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_company_profileResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_company_profileResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public string client_name;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string domain;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string address1;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string address2;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string city;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string locality;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string state_prov;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=9)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string country;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=10)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string postal_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=11)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string phone;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=12)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string contact;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=13)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string contact_address1;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=14)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string contact_address2;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=15)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string contact_city;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=16)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string contact_state;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=17)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string contact_zip;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=18)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string contact_phone;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=19)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string contact_email;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=20)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string billing_contact;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=21)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string billing_address1;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=22)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string billing_address2;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=23)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string billing_city;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=24)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string billing_state;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=25)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string billing_zip;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=26)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string billing_phone;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=27)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string billing_email;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=28)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string contact_country;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=29)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string contact_locality;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=30)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string billing_country;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=31)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string billing_locality;
                
        public get_company_profileResponse() {
        }

                 
        public get_company_profileResponse(long error_code, string error_msg, string client_name, string domain, string address1, string address2, string city, string locality, string state_prov, string country, string postal_code, string phone, string contact, string contact_address1, string contact_address2, string contact_city, string contact_state, string contact_zip, string contact_phone, string contact_email, string billing_contact, string billing_address1, string billing_address2, string billing_city, string billing_state, string billing_zip, string billing_phone, string billing_email, string contact_country, string contact_locality, string billing_country, string billing_locality) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.client_name = client_name;
                        this.domain = domain;
                        this.address1 = address1;
                        this.address2 = address2;
                        this.city = city;
                        this.locality = locality;
                        this.state_prov = state_prov;
                        this.country = country;
                        this.postal_code = postal_code;
                        this.phone = phone;
                        this.contact = contact;
                        this.contact_address1 = contact_address1;
                        this.contact_address2 = contact_address2;
                        this.contact_city = contact_city;
                        this.contact_state = contact_state;
                        this.contact_zip = contact_zip;
                        this.contact_phone = contact_phone;
                        this.contact_email = contact_email;
                        this.billing_contact = billing_contact;
                        this.billing_address1 = billing_address1;
                        this.billing_address2 = billing_address2;
                        this.billing_city = billing_city;
                        this.billing_state = billing_state;
                        this.billing_zip = billing_zip;
                        this.billing_phone = billing_phone;
                        this.billing_email = billing_email;
                        this.contact_country = contact_country;
                        this.contact_locality = contact_locality;
                        this.billing_country = billing_country;
                        this.billing_locality = billing_locality;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="set_company_profile", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class set_company_profileRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string domain;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string address1;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string address2;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string city;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string locality;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string state_prov;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string country;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=9)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string postal_code;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=10)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string phone;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=11)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string contact;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=12)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string contact_address1;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=13)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string contact_address2;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=14)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string contact_city;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=15)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string contact_state;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=16)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string contact_zip;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=17)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string contact_phone;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=18)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string contact_email;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=19)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string billing_contact;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=20)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string billing_address1;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=21)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string billing_address2;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=22)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string billing_city;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=23)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string billing_state;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=24)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string billing_zip;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=25)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string billing_phone;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=26)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string billing_email;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=27)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string contact_country;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=28)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string contact_locality;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=29)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string billing_country;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=30)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string billing_locality;
                
        public set_company_profileRequest() {
        }
        
        public set_company_profileRequest(long client_no, string auth_key, string domain, string address1, string address2, string city, string locality, string state_prov, string country, string postal_code, string phone, string contact, string contact_address1, string contact_address2, string contact_city, string contact_state, string contact_zip, string contact_phone, string contact_email, string billing_contact, string billing_address1, string billing_address2, string billing_city, string billing_state, string billing_zip, string billing_phone, string billing_email, string contact_country, string contact_locality, string billing_country, string billing_locality) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.domain = domain;
                        this.address1 = address1;
                        this.address2 = address2;
                        this.city = city;
                        this.locality = locality;
                        this.state_prov = state_prov;
                        this.country = country;
                        this.postal_code = postal_code;
                        this.phone = phone;
                        this.contact = contact;
                        this.contact_address1 = contact_address1;
                        this.contact_address2 = contact_address2;
                        this.contact_city = contact_city;
                        this.contact_state = contact_state;
                        this.contact_zip = contact_zip;
                        this.contact_phone = contact_phone;
                        this.contact_email = contact_email;
                        this.billing_contact = billing_contact;
                        this.billing_address1 = billing_address1;
                        this.billing_address2 = billing_address2;
                        this.billing_city = billing_city;
                        this.billing_state = billing_state;
                        this.billing_zip = billing_zip;
                        this.billing_phone = billing_phone;
                        this.billing_email = billing_email;
                        this.contact_country = contact_country;
                        this.contact_locality = contact_locality;
                        this.billing_country = billing_country;
                        this.billing_locality = billing_locality;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="set_company_profileResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class set_company_profileResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public string client_name;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string domain;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string address1;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string address2;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string city;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string locality;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string state_prov;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=9)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string country;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=10)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string postal_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=11)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string phone;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=12)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string contact;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=13)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string contact_address1;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=14)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string contact_address2;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=15)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string contact_city;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=16)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string contact_state;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=17)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string contact_zip;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=18)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string contact_phone;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=19)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string contact_email;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=20)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string billing_contact;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=21)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string billing_address1;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=22)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string billing_address2;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=23)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string billing_city;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=24)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string billing_state;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=25)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string billing_zip;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=26)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string billing_phone;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=27)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string billing_email;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=28)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string contact_country;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=29)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string contact_locality;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=30)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string billing_country;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=31)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string billing_locality;
                
        public set_company_profileResponse() {
        }

                 
        public set_company_profileResponse(long error_code, string error_msg, string client_name, string domain, string address1, string address2, string city, string locality, string state_prov, string country, string postal_code, string phone, string contact, string contact_address1, string contact_address2, string contact_city, string contact_state, string contact_zip, string contact_phone, string contact_email, string billing_contact, string billing_address1, string billing_address2, string billing_city, string billing_state, string billing_zip, string billing_phone, string billing_email, string contact_country, string contact_locality, string billing_country, string billing_locality) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.client_name = client_name;
                        this.domain = domain;
                        this.address1 = address1;
                        this.address2 = address2;
                        this.city = city;
                        this.locality = locality;
                        this.state_prov = state_prov;
                        this.country = country;
                        this.postal_code = postal_code;
                        this.phone = phone;
                        this.contact = contact;
                        this.contact_address1 = contact_address1;
                        this.contact_address2 = contact_address2;
                        this.contact_city = contact_city;
                        this.contact_state = contact_state;
                        this.contact_zip = contact_zip;
                        this.contact_phone = contact_phone;
                        this.contact_email = contact_email;
                        this.billing_contact = billing_contact;
                        this.billing_address1 = billing_address1;
                        this.billing_address2 = billing_address2;
                        this.billing_city = billing_city;
                        this.billing_state = billing_state;
                        this.billing_zip = billing_zip;
                        this.billing_phone = billing_phone;
                        this.billing_email = billing_email;
                        this.contact_country = contact_country;
                        this.contact_locality = contact_locality;
                        this.billing_country = billing_country;
                        this.billing_locality = billing_locality;
                    }
            }
                                                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_inventory_items", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_inventory_itemsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
        
        public get_inventory_itemsRequest() {
        }
        
        public get_inventory_itemsRequest(long client_no, string auth_key) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_inventory_itemsResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_inventory_itemsResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                [System.Xml.Serialization.XmlElementAttribute("inventory_items", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.inventory_items_ReturnElement[] inventory_items;
                
        public get_inventory_itemsResponse() {
        }

                 
        public get_inventory_itemsResponse(long error_code, string error_msg, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.inventory_items_ReturnElement[] inventory_items) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.inventory_items = inventory_items;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_inventory_item_details", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_inventory_item_detailsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public int item_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public string client_item_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        public string currency_cd;
                
        public get_inventory_item_detailsRequest() {
        }
        
        public get_inventory_item_detailsRequest(long client_no, string auth_key, int item_no, string client_item_id, string currency_cd) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.item_no = item_no;
                        this.client_item_id = client_item_id;
                        this.currency_cd = currency_cd;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_inventory_item_detailsResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_inventory_item_detailsResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public int item_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string client_item_id;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                public int item_type;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                public string item_name;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                public string item_desc;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                public int active_ind;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                public int service_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=9)]
                public string client_service_id;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=10)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> invoice_advancement_months;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=11)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> plan_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=12)]
                public string client_plan_id;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=13)]
                public string client_sku;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=14)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.pricing_ReturnElement[] pricing;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=15)]
                public string modify_price_ind;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=16)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<float> subunit_qty;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=17)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string subunit_label;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=18)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> days_to_expiry;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=19)]
                [System.Xml.Serialization.XmlElementAttribute("resources", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.resources_ReturnElement[] resources;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=20)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<float> stock_level;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=21)]
                [System.Xml.Serialization.XmlElementAttribute("image", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.image_ReturnElement[] image;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=22)]
                [System.Xml.Serialization.XmlElementAttribute("supplemental_obj_fields", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.supplemental_obj_fields_ReturnElement[] supplemental_obj_fields;
                
        public get_inventory_item_detailsResponse() {
        }

                 
        public get_inventory_item_detailsResponse(long error_code, string error_msg, int item_no, string client_item_id, int item_type, string item_name, string item_desc, int active_ind, int service_no, string client_service_id, System.Nullable<int> invoice_advancement_months, System.Nullable<int> plan_no, string client_plan_id, string client_sku, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.pricing_ReturnElement[] pricing, string modify_price_ind, System.Nullable<float> subunit_qty, string subunit_label, System.Nullable<int> days_to_expiry, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.resources_ReturnElement[] resources, System.Nullable<float> stock_level, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.image_ReturnElement[] image, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.supplemental_obj_fields_ReturnElement[] supplemental_obj_fields) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.item_no = item_no;
                        this.client_item_id = client_item_id;
                        this.item_type = item_type;
                        this.item_name = item_name;
                        this.item_desc = item_desc;
                        this.active_ind = active_ind;
                        this.service_no = service_no;
                        this.client_service_id = client_service_id;
                        this.invoice_advancement_months = invoice_advancement_months;
                        this.plan_no = plan_no;
                        this.client_plan_id = client_plan_id;
                        this.client_sku = client_sku;
                        this.pricing = pricing;
                        this.modify_price_ind = modify_price_ind;
                        this.subunit_qty = subunit_qty;
                        this.subunit_label = subunit_label;
                        this.days_to_expiry = days_to_expiry;
                        this.resources = resources;
                        this.stock_level = stock_level;
                        this.image = image;
                        this.supplemental_obj_fields = supplemental_obj_fields;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create_inventory_item", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class create_inventory_itemRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public int item_type;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public string item_name;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        public string item_desc;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_row[] service;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                        public string client_sku;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                        public string currency_cd;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                        public string item_price;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=9)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string client_item_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=10)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> active_ind;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=11)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> invoice_advancement_months;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=12)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> plan_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=13)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string client_plan_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=14)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public bool tax_inclusive_ind;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=15)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string modify_price_ind;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=16)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> subunit_qty;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=17)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string subunit_label;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=18)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> days_to_expiry;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=19)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string resource_type_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=20)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string resource_units;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=21)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> stock_level_track;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=22)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<float> stock_level_adjust;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=23)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.image_row[] image;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=24)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_class_row[] parent_class;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=25)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.supplemental_obj_field_row[] supplemental_obj_field;
                
        public create_inventory_itemRequest() {
        }
        
        public create_inventory_itemRequest(long client_no, string auth_key, int item_type, string item_name, string item_desc, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_row[] service, string client_sku, string currency_cd, string item_price, string client_item_id, System.Nullable<int> active_ind, System.Nullable<int> invoice_advancement_months, System.Nullable<int> plan_no, string client_plan_id, bool tax_inclusive_ind, string modify_price_ind, System.Nullable<int> subunit_qty, string subunit_label, System.Nullable<int> days_to_expiry, string resource_type_no, string resource_units, System.Nullable<int> stock_level_track, System.Nullable<float> stock_level_adjust, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.image_row[] image, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_class_row[] parent_class, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.supplemental_obj_field_row[] supplemental_obj_field) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.item_type = item_type;
                        this.item_name = item_name;
                        this.item_desc = item_desc;
                        this.service = service;
                        this.client_sku = client_sku;
                        this.currency_cd = currency_cd;
                        this.item_price = item_price;
                        this.client_item_id = client_item_id;
                        this.active_ind = active_ind;
                        this.invoice_advancement_months = invoice_advancement_months;
                        this.plan_no = plan_no;
                        this.client_plan_id = client_plan_id;
                        this.tax_inclusive_ind = tax_inclusive_ind;
                        this.modify_price_ind = modify_price_ind;
                        this.subunit_qty = subunit_qty;
                        this.subunit_label = subunit_label;
                        this.days_to_expiry = days_to_expiry;
                        this.resource_type_no = resource_type_no;
                        this.resource_units = resource_units;
                        this.stock_level_track = stock_level_track;
                        this.stock_level_adjust = stock_level_adjust;
                        this.image = image;
                        this.parent_class = parent_class;
                        this.supplemental_obj_field = supplemental_obj_field;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create_inventory_itemResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class create_inventory_itemResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public string item_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                public string currency_cd;
                
        public create_inventory_itemResponse() {
        }

                 
        public create_inventory_itemResponse(long error_code, string error_msg, string item_no, string currency_cd) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.item_no = item_no;
                        this.currency_cd = currency_cd;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="update_inventory_item", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class update_inventory_itemRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public string item_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public string item_name;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        public string item_desc;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                        public string client_item_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                        public int service_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                        public string client_service_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                        public string currency_cd;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=9)]
                        public string item_price;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=10)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> active_ind;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=11)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> invoice_advancement_months;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=12)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> plan_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=13)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string client_plan_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=14)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string modify_price_ind;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=15)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> subunit_qty;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=16)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string subunit_label;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=17)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> days_to_expiry;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=18)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string resource_type_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=19)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string resource_units;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=20)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> stock_level_track;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=21)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<float> stock_level_adjust;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=22)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.image_row[] image;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=23)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_class_row[] parent_class;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=24)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.supplemental_obj_field_row[] supplemental_obj_field;
                
        public update_inventory_itemRequest() {
        }
        
        public update_inventory_itemRequest(long client_no, string auth_key, string item_no, string item_name, string item_desc, string client_item_id, int service_no, string client_service_id, string currency_cd, string item_price, System.Nullable<int> active_ind, System.Nullable<int> invoice_advancement_months, System.Nullable<int> plan_no, string client_plan_id, string modify_price_ind, System.Nullable<int> subunit_qty, string subunit_label, System.Nullable<int> days_to_expiry, string resource_type_no, string resource_units, System.Nullable<int> stock_level_track, System.Nullable<float> stock_level_adjust, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.image_row[] image, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_class_row[] parent_class, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.supplemental_obj_field_row[] supplemental_obj_field) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.item_no = item_no;
                        this.item_name = item_name;
                        this.item_desc = item_desc;
                        this.client_item_id = client_item_id;
                        this.service_no = service_no;
                        this.client_service_id = client_service_id;
                        this.currency_cd = currency_cd;
                        this.item_price = item_price;
                        this.active_ind = active_ind;
                        this.invoice_advancement_months = invoice_advancement_months;
                        this.plan_no = plan_no;
                        this.client_plan_id = client_plan_id;
                        this.modify_price_ind = modify_price_ind;
                        this.subunit_qty = subunit_qty;
                        this.subunit_label = subunit_label;
                        this.days_to_expiry = days_to_expiry;
                        this.resource_type_no = resource_type_no;
                        this.resource_units = resource_units;
                        this.stock_level_track = stock_level_track;
                        this.stock_level_adjust = stock_level_adjust;
                        this.image = image;
                        this.parent_class = parent_class;
                        this.supplemental_obj_field = supplemental_obj_field;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="update_inventory_itemResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class update_inventory_itemResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public string item_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                public string currency_cd;
                
        public update_inventory_itemResponse() {
        }

                 
        public update_inventory_itemResponse(long error_code, string error_msg, string item_no, string currency_cd) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.item_no = item_no;
                        this.currency_cd = currency_cd;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create_item_class", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class create_item_classRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public string class_name;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string class_desc;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> active_ind;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string client_inventory_class_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_class_row[] parent_class;
                
        public create_item_classRequest() {
        }
        
        public create_item_classRequest(long client_no, string auth_key, string class_name, string class_desc, System.Nullable<int> active_ind, string client_inventory_class_id, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_class_row[] parent_class) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.class_name = class_name;
                        this.class_desc = class_desc;
                        this.active_ind = active_ind;
                        this.client_inventory_class_id = client_inventory_class_id;
                        this.parent_class = parent_class;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create_item_classResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class create_item_classResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public string class_no;
                
        public create_item_classResponse() {
        }

                 
        public create_item_classResponse(long error_code, string error_msg, string class_no) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.class_no = class_no;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="edit_item_class", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class edit_item_classRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public string class_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public string class_name;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        public string client_inventory_class_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string class_desc;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> active_ind;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_class_row[] parent_class;
                
        public edit_item_classRequest() {
        }
        
        public edit_item_classRequest(long client_no, string auth_key, string class_no, string class_name, string client_inventory_class_id, string class_desc, System.Nullable<int> active_ind, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_class_row[] parent_class) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.class_no = class_no;
                        this.class_name = class_name;
                        this.client_inventory_class_id = client_inventory_class_id;
                        this.class_desc = class_desc;
                        this.active_ind = active_ind;
                        this.parent_class = parent_class;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="edit_item_classResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class edit_item_classResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public string class_no;
                
        public edit_item_classResponse() {
        }

                 
        public edit_item_classResponse(long error_code, string error_msg, string class_no) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.class_no = class_no;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_service_types", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_service_typesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
        
        public get_service_typesRequest() {
        }
        
        public get_service_typesRequest(long client_no, string auth_key) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_service_typesResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_service_typesResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                [System.Xml.Serialization.XmlElementAttribute("service_types", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_types_ReturnElement[] service_types;
                
        public get_service_typesResponse() {
        }

                 
        public get_service_typesResponse(long error_code, string error_msg, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_types_ReturnElement[] service_types) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.service_types = service_types;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_services", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_servicesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
        
        public get_servicesRequest() {
        }
        
        public get_servicesRequest(long client_no, string auth_key) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_servicesResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_servicesResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                [System.Xml.Serialization.XmlElementAttribute("services", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.services_ReturnElement[] services;
                
        public get_servicesResponse() {
        }

                 
        public get_servicesResponse(long error_code, string error_msg, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.services_ReturnElement[] services) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.services = services;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_service_details", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_service_detailsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public int service_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public string client_service_id;
                
        public get_service_detailsRequest() {
        }
        
        public get_service_detailsRequest(long client_no, string auth_key, int service_no, string client_service_id) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.service_no = service_no;
                        this.client_service_id = client_service_id;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_service_detailsResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_service_detailsResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public int service_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string client_service_id;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                public string service_name;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                public string service_type;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string gl_cd;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string taxable_ind;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string tax_group;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=9)]
                public string client_tax_group_id;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=10)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> usage_type;
                
        public get_service_detailsResponse() {
        }

                 
        public get_service_detailsResponse(long error_code, string error_msg, int service_no, string client_service_id, string service_name, string service_type, string gl_cd, string taxable_ind, string tax_group, string client_tax_group_id, System.Nullable<int> usage_type) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.service_no = service_no;
                        this.client_service_id = client_service_id;
                        this.service_name = service_name;
                        this.service_type = service_type;
                        this.gl_cd = gl_cd;
                        this.taxable_ind = taxable_ind;
                        this.tax_group = tax_group;
                        this.client_tax_group_id = client_tax_group_id;
                        this.usage_type = usage_type;
                    }
            }
                                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_plan_service_details", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_plan_service_detailsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public int service_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public string client_service_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        public int plan_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                        public string client_plan_id;
                
        public get_plan_service_detailsRequest() {
        }
        
        public get_plan_service_detailsRequest(long client_no, string auth_key, int service_no, string client_service_id, int plan_no, string client_plan_id) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.service_no = service_no;
                        this.client_service_id = client_service_id;
                        this.plan_no = plan_no;
                        this.client_plan_id = client_plan_id;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_plan_service_detailsResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_plan_service_detailsResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> plan_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string client_plan_id;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                public string currency_cd;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                public int service_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                public string service_name;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                public string service_type;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string client_service_id;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=9)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> taxable_ind;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=10)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string tax_group;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=11)]
                public string client_tax_group_id;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=12)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string gl_cd;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=13)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> usage_type;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=14)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string rate_type;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=15)]
                [System.Xml.Serialization.XmlElementAttribute("rate_schedules", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rate_schedules_ReturnElement[] rate_schedules;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=16)]
                [System.Xml.Serialization.XmlElementAttribute("parent_plans", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_plans_ReturnElement[] parent_plans;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=17)]
                [System.Xml.Serialization.XmlElementAttribute("parent_plan_ids", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_plan_ids_ReturnElement[] parent_plan_ids;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=18)]
                [System.Xml.Serialization.XmlElementAttribute("exclusion_plans", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.exclusion_plans_ReturnElement[] exclusion_plans;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=19)]
                [System.Xml.Serialization.XmlElementAttribute("supplemental_obj_fields", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.supplemental_obj_fields_ReturnElement[] supplemental_obj_fields;
                
        public get_plan_service_detailsResponse() {
        }

                 
        public get_plan_service_detailsResponse(long error_code, string error_msg, System.Nullable<int> plan_no, string client_plan_id, string currency_cd, int service_no, string service_name, string service_type, string client_service_id, System.Nullable<int> taxable_ind, string tax_group, string client_tax_group_id, string gl_cd, System.Nullable<int> usage_type, string rate_type, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rate_schedules_ReturnElement[] rate_schedules, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_plans_ReturnElement[] parent_plans, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_plan_ids_ReturnElement[] parent_plan_ids, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.exclusion_plans_ReturnElement[] exclusion_plans, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.supplemental_obj_fields_ReturnElement[] supplemental_obj_fields) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.plan_no = plan_no;
                        this.client_plan_id = client_plan_id;
                        this.currency_cd = currency_cd;
                        this.service_no = service_no;
                        this.service_name = service_name;
                        this.service_type = service_type;
                        this.client_service_id = client_service_id;
                        this.taxable_ind = taxable_ind;
                        this.tax_group = tax_group;
                        this.client_tax_group_id = client_tax_group_id;
                        this.gl_cd = gl_cd;
                        this.usage_type = usage_type;
                        this.rate_type = rate_type;
                        this.rate_schedules = rate_schedules;
                        this.parent_plans = parent_plans;
                        this.parent_plan_ids = parent_plan_ids;
                        this.exclusion_plans = exclusion_plans;
                        this.supplemental_obj_fields = supplemental_obj_fields;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create_service", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class create_serviceRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public string service_name;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public string service_type;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string gl_cd;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string taxable_ind;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string tax_group;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string usage_type;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string client_service_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=9)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.supplemental_obj_field_row[] supplemental_obj_field;
                
        public create_serviceRequest() {
        }
        
        public create_serviceRequest(long client_no, string auth_key, string service_name, string service_type, string gl_cd, string taxable_ind, string tax_group, string usage_type, string client_service_id, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.supplemental_obj_field_row[] supplemental_obj_field) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.service_name = service_name;
                        this.service_type = service_type;
                        this.gl_cd = gl_cd;
                        this.taxable_ind = taxable_ind;
                        this.tax_group = tax_group;
                        this.usage_type = usage_type;
                        this.client_service_id = client_service_id;
                        this.supplemental_obj_field = supplemental_obj_field;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create_serviceResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class create_serviceResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public int service_no;
                
        public create_serviceResponse() {
        }

                 
        public create_serviceResponse(long error_code, string error_msg, int service_no) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.service_no = service_no;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="update_service", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class update_serviceRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public long service_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public string service_name;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        public string service_type;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                        public string client_service_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string gl_cd;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string taxable_ind;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string tax_group;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=9)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string usage_type;
                
        public update_serviceRequest() {
        }
        
        public update_serviceRequest(long client_no, string auth_key, long service_no, string service_name, string service_type, string client_service_id, string gl_cd, string taxable_ind, string tax_group, string usage_type) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.service_no = service_no;
                        this.service_name = service_name;
                        this.service_type = service_type;
                        this.client_service_id = client_service_id;
                        this.gl_cd = gl_cd;
                        this.taxable_ind = taxable_ind;
                        this.tax_group = tax_group;
                        this.usage_type = usage_type;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="update_serviceResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class update_serviceResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public int service_no;
                
        public update_serviceResponse() {
        }

                 
        public update_serviceResponse(long error_code, string error_msg, int service_no) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.service_no = service_no;
                    }
            }
                                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_supp_fields", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_supp_fieldsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
        
        public get_supp_fieldsRequest() {
        }
        
        public get_supp_fieldsRequest(long client_no, string auth_key) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_supp_fieldsResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_supp_fieldsResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                [System.Xml.Serialization.XmlElementAttribute("supp_fields", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.supp_fields_ReturnElement[] supp_fields;
                
        public get_supp_fieldsResponse() {
        }

                 
        public get_supp_fieldsResponse(long error_code, string error_msg, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.supp_fields_ReturnElement[] supp_fields) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.supp_fields = supp_fields;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_supp_field_details", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_supp_field_detailsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public string field_name;
                
        public get_supp_field_detailsRequest() {
        }
        
        public get_supp_field_detailsRequest(long client_no, string auth_key, string field_name) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.field_name = field_name;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_supp_field_detailsResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_supp_field_detailsResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public string field_name;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string field_desc;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                public int field_order;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                public int required_ind;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                public int hidden_ind;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                public string presentation_mode;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> min_no_sel;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=9)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> max_no_sel;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=10)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string additional_html;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=11)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string extra_validation_methods;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=12)]
                [System.Xml.Serialization.XmlElementAttribute("field_options", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.field_options_ReturnElement[] field_options;
                
        public get_supp_field_detailsResponse() {
        }

                 
        public get_supp_field_detailsResponse(long error_code, string error_msg, string field_name, string field_desc, int field_order, int required_ind, int hidden_ind, string presentation_mode, System.Nullable<int> min_no_sel, System.Nullable<int> max_no_sel, string additional_html, string extra_validation_methods, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.field_options_ReturnElement[] field_options) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.field_name = field_name;
                        this.field_desc = field_desc;
                        this.field_order = field_order;
                        this.required_ind = required_ind;
                        this.hidden_ind = hidden_ind;
                        this.presentation_mode = presentation_mode;
                        this.min_no_sel = min_no_sel;
                        this.max_no_sel = max_no_sel;
                        this.additional_html = additional_html;
                        this.extra_validation_methods = extra_validation_methods;
                        this.field_options = field_options;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create_supp_field", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class create_supp_fieldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public string field_name;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public int field_order;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        public string presentation_mode;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string field_desc;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> required_ind;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> hidden_ind;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> sel_ind;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=9)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> min_no_sel;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=10)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> max_no_sel;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=11)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string display_text;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=12)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string option_value;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=13)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> option_value_order;
                
        public create_supp_fieldRequest() {
        }
        
        public create_supp_fieldRequest(long client_no, string auth_key, string field_name, int field_order, string presentation_mode, string field_desc, System.Nullable<int> required_ind, System.Nullable<int> hidden_ind, System.Nullable<int> sel_ind, System.Nullable<int> min_no_sel, System.Nullable<int> max_no_sel, string display_text, string option_value, System.Nullable<int> option_value_order) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.field_name = field_name;
                        this.field_order = field_order;
                        this.presentation_mode = presentation_mode;
                        this.field_desc = field_desc;
                        this.required_ind = required_ind;
                        this.hidden_ind = hidden_ind;
                        this.sel_ind = sel_ind;
                        this.min_no_sel = min_no_sel;
                        this.max_no_sel = max_no_sel;
                        this.display_text = display_text;
                        this.option_value = option_value;
                        this.option_value_order = option_value_order;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create_supp_fieldResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class create_supp_fieldResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public string field_name;
                
        public create_supp_fieldResponse() {
        }

                 
        public create_supp_fieldResponse(long error_code, string error_msg, string field_name) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.field_name = field_name;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="update_supp_field", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class update_supp_fieldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public string field_name;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string field_desc;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> field_order;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> required_ind;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> hidden_ind;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> sel_ind;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string presentation_mode;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=9)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> min_no_sel;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=10)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> max_no_sel;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=11)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string display_text;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=12)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string option_value;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=13)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> option_value_order;
                
        public update_supp_fieldRequest() {
        }
        
        public update_supp_fieldRequest(long client_no, string auth_key, string field_name, string field_desc, System.Nullable<int> field_order, System.Nullable<int> required_ind, System.Nullable<int> hidden_ind, System.Nullable<int> sel_ind, string presentation_mode, System.Nullable<int> min_no_sel, System.Nullable<int> max_no_sel, string display_text, string option_value, System.Nullable<int> option_value_order) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.field_name = field_name;
                        this.field_desc = field_desc;
                        this.field_order = field_order;
                        this.required_ind = required_ind;
                        this.hidden_ind = hidden_ind;
                        this.sel_ind = sel_ind;
                        this.presentation_mode = presentation_mode;
                        this.min_no_sel = min_no_sel;
                        this.max_no_sel = max_no_sel;
                        this.display_text = display_text;
                        this.option_value = option_value;
                        this.option_value_order = option_value_order;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="update_supp_fieldResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class update_supp_fieldResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public string field_name;
                
        public update_supp_fieldResponse() {
        }

                 
        public update_supp_fieldResponse(long error_code, string error_msg, string field_name) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.field_name = field_name;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_coupons", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_couponsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
        
        public get_couponsRequest() {
        }
        
        public get_couponsRequest(long client_no, string auth_key) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_couponsResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_couponsResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                [System.Xml.Serialization.XmlElementAttribute("services", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.services_ReturnElement[] services;
                
        public get_couponsResponse() {
        }

                 
        public get_couponsResponse(long error_code, string error_msg, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.services_ReturnElement[] services) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.services = services;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_coupon_details", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_coupon_detailsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public string coupon_cd;
                
        public get_coupon_detailsRequest() {
        }
        
        public get_coupon_detailsRequest(long client_no, string auth_key, string coupon_cd) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.coupon_cd = coupon_cd;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_coupon_detailsResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_coupon_detailsResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public string coupon_cd;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string coupon_desc;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string coupon_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                public int status_ind;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> no_of_uses;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string start_date;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string end_date;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=9)]
                [System.Xml.Serialization.XmlElementAttribute("credit_template", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.credit_template_ReturnElement[] credit_template;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=10)]
                [System.Xml.Serialization.XmlElementAttribute("discount_rule", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.discount_rule_ReturnElement[] discount_rule;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=11)]
                [System.Xml.Serialization.XmlElementAttribute("discount_bundle", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.discount_bundle_ReturnElement[] discount_bundle;
                
        public get_coupon_detailsResponse() {
        }

                 
        public get_coupon_detailsResponse(long error_code, string error_msg, string coupon_cd, string coupon_desc, string coupon_msg, int status_ind, System.Nullable<int> no_of_uses, string start_date, string end_date, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.credit_template_ReturnElement[] credit_template, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.discount_rule_ReturnElement[] discount_rule, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.discount_bundle_ReturnElement[] discount_bundle) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.coupon_cd = coupon_cd;
                        this.coupon_desc = coupon_desc;
                        this.coupon_msg = coupon_msg;
                        this.status_ind = status_ind;
                        this.no_of_uses = no_of_uses;
                        this.start_date = start_date;
                        this.end_date = end_date;
                        this.credit_template = credit_template;
                        this.discount_rule = discount_rule;
                        this.discount_bundle = discount_bundle;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create_coupon", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class create_couponRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public string coupon_cd;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public int status_ind;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        public string start_date;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                        public string end_date;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string coupon_desc;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string coupon_msg;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> no_of_uses;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=9)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.template_row[] template;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=10)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_template_row[] existing_template;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=11)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_template_id_row[] existing_template_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=12)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.discount_rule_row[] discount_rule;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=13)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_rule_row[] existing_discount_rule;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=14)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_rule_id_row[] existing_discount_rule_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=15)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.discount_bundle_row[] discount_bundle;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=16)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_bundle_row[] existing_discount_bundle;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=17)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_bundle_id_row[] existing_discount_bundle_id;
                
        public create_couponRequest() {
        }
        
        public create_couponRequest(long client_no, string auth_key, string coupon_cd, int status_ind, string start_date, string end_date, string coupon_desc, string coupon_msg, System.Nullable<int> no_of_uses, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.template_row[] template, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_template_row[] existing_template, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_template_id_row[] existing_template_id, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.discount_rule_row[] discount_rule, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_rule_row[] existing_discount_rule, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_rule_id_row[] existing_discount_rule_id, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.discount_bundle_row[] discount_bundle, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_bundle_row[] existing_discount_bundle, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_bundle_id_row[] existing_discount_bundle_id) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.coupon_cd = coupon_cd;
                        this.status_ind = status_ind;
                        this.start_date = start_date;
                        this.end_date = end_date;
                        this.coupon_desc = coupon_desc;
                        this.coupon_msg = coupon_msg;
                        this.no_of_uses = no_of_uses;
                        this.template = template;
                        this.existing_template = existing_template;
                        this.existing_template_id = existing_template_id;
                        this.discount_rule = discount_rule;
                        this.existing_discount_rule = existing_discount_rule;
                        this.existing_discount_rule_id = existing_discount_rule_id;
                        this.discount_bundle = discount_bundle;
                        this.existing_discount_bundle = existing_discount_bundle;
                        this.existing_discount_bundle_id = existing_discount_bundle_id;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create_couponResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class create_couponResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public string coupon_cd;
                
        public create_couponResponse() {
        }

                 
        public create_couponResponse(long error_code, string error_msg, string coupon_cd) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.coupon_cd = coupon_cd;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="update_coupon", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class update_couponRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public string coupon_cd;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public int status_ind;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        public string start_date;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                        public string end_date;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string coupon_desc;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string coupon_msg;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<long> no_of_uses;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=9)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.template_row[] template;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=10)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_template_row[] existing_template;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=11)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_template_id_row[] existing_template_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=12)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.discount_rule_row[] discount_rule;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=13)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_rule_row[] existing_discount_rule;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=14)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_rule_id_row[] existing_discount_rule_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=15)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.discount_bundle_row[] discount_bundle;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=16)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_bundle_row[] existing_discount_bundle;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=17)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_bundle_id_row[] existing_discount_bundle_id;
                
        public update_couponRequest() {
        }
        
        public update_couponRequest(long client_no, string auth_key, string coupon_cd, int status_ind, string start_date, string end_date, string coupon_desc, string coupon_msg, System.Nullable<long> no_of_uses, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.template_row[] template, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_template_row[] existing_template, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_template_id_row[] existing_template_id, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.discount_rule_row[] discount_rule, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_rule_row[] existing_discount_rule, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_rule_id_row[] existing_discount_rule_id, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.discount_bundle_row[] discount_bundle, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_bundle_row[] existing_discount_bundle, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_discount_bundle_id_row[] existing_discount_bundle_id) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.coupon_cd = coupon_cd;
                        this.status_ind = status_ind;
                        this.start_date = start_date;
                        this.end_date = end_date;
                        this.coupon_desc = coupon_desc;
                        this.coupon_msg = coupon_msg;
                        this.no_of_uses = no_of_uses;
                        this.template = template;
                        this.existing_template = existing_template;
                        this.existing_template_id = existing_template_id;
                        this.discount_rule = discount_rule;
                        this.existing_discount_rule = existing_discount_rule;
                        this.existing_discount_rule_id = existing_discount_rule_id;
                        this.discount_bundle = discount_bundle;
                        this.existing_discount_bundle = existing_discount_bundle;
                        this.existing_discount_bundle_id = existing_discount_bundle_id;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="update_couponResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class update_couponResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public string coupon_cd;
                
        public update_couponResponse() {
        }

                 
        public update_couponResponse(long error_code, string error_msg, string coupon_cd) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.coupon_cd = coupon_cd;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="delete_coupons", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class delete_couponsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coupon_nos_row[] coupon_nos;
                
        public delete_couponsRequest() {
        }
        
        public delete_couponsRequest(long client_no, string auth_key, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coupon_nos_row[] coupon_nos) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.coupon_nos = coupon_nos;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="delete_couponsResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class delete_couponsResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                [System.Xml.Serialization.XmlElementAttribute("coupons", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coupons_ReturnElement[] coupons;
                
        public delete_couponsResponse() {
        }

                 
        public delete_couponsResponse(long error_code, string error_msg, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coupons_ReturnElement[] coupons) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.coupons = coupons;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_recurring_credit_templates", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_recurring_credit_templatesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
        
        public get_recurring_credit_templatesRequest() {
        }
        
        public get_recurring_credit_templatesRequest(long client_no, string auth_key) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_recurring_credit_templatesResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_recurring_credit_templatesResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                [System.Xml.Serialization.XmlElementAttribute("credit_templates", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.credit_templates_ReturnElement[] credit_templates;
                
        public get_recurring_credit_templatesResponse() {
        }

                 
        public get_recurring_credit_templatesResponse(long error_code, string error_msg, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.credit_templates_ReturnElement[] credit_templates) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.credit_templates = credit_templates;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_recurring_credit_template_details", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_recurring_credit_template_detailsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public int credit_template_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public string client_credit_template_id;
                
        public get_recurring_credit_template_detailsRequest() {
        }
        
        public get_recurring_credit_template_detailsRequest(long client_no, string auth_key, int credit_template_no, string client_credit_template_id) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.credit_template_no = credit_template_no;
                        this.client_credit_template_id = client_credit_template_id;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_recurring_credit_template_detailsResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_recurring_credit_template_detailsResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public int recurring_credit_template_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                public string credit_template_name;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string client_credit_template_id;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                public int eligible_plan_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string eligible_client_plan_id;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                public int eligible_service_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string eligible_client_service_id;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=9)]
                [System.Xml.Serialization.XmlElementAttribute("eligible_service_types", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.eligible_service_types_ReturnElement[] eligible_service_types;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=10)]
                public int no_of_credits;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=11)]
                public int time_between_credits;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=12)]
                public int discount_type;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=13)]
                public float discount_amt;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=14)]
                public int percentage_plan_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=15)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string percentage_client_plan_id;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=16)]
                public int percentage_service_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=17)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string percentage_client_service_id;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=18)]
                public int alt_service_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=19)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string alt_client_service_id;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=20)]
                [System.Xml.Serialization.XmlElementAttribute("coupons", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coupons_ReturnElement[] coupons;
                
        public get_recurring_credit_template_detailsResponse() {
        }

                 
        public get_recurring_credit_template_detailsResponse(long error_code, string error_msg, int recurring_credit_template_no, string credit_template_name, string client_credit_template_id, int eligible_plan_no, string eligible_client_plan_id, int eligible_service_no, string eligible_client_service_id, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.eligible_service_types_ReturnElement[] eligible_service_types, int no_of_credits, int time_between_credits, int discount_type, float discount_amt, int percentage_plan_no, string percentage_client_plan_id, int percentage_service_no, string percentage_client_service_id, int alt_service_no, string alt_client_service_id, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coupons_ReturnElement[] coupons) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.recurring_credit_template_no = recurring_credit_template_no;
                        this.credit_template_name = credit_template_name;
                        this.client_credit_template_id = client_credit_template_id;
                        this.eligible_plan_no = eligible_plan_no;
                        this.eligible_client_plan_id = eligible_client_plan_id;
                        this.eligible_service_no = eligible_service_no;
                        this.eligible_client_service_id = eligible_client_service_id;
                        this.eligible_service_types = eligible_service_types;
                        this.no_of_credits = no_of_credits;
                        this.time_between_credits = time_between_credits;
                        this.discount_type = discount_type;
                        this.discount_amt = discount_amt;
                        this.percentage_plan_no = percentage_plan_no;
                        this.percentage_client_plan_id = percentage_client_plan_id;
                        this.percentage_service_no = percentage_service_no;
                        this.percentage_client_service_id = percentage_client_service_id;
                        this.alt_service_no = alt_service_no;
                        this.alt_client_service_id = alt_client_service_id;
                        this.coupons = coupons;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create_credit_template", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class create_credit_templateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public string credit_template_name;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public int discount_type;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        public float discount_amt;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                        public int no_of_credits;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                        public int credit_interval_months;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> eligible_plan_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string eligible_client_plan_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=9)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> eligible_service_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=10)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string eligible_client_service_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=11)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.eligible_service_types_row[] eligible_service_types;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=12)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> percentage_plan_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=13)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string percentage_client_plan_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=14)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> percentage_service_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=15)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string percentage_client_service_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=16)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> alt_service_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=17)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string alt_client_service_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=18)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string client_credit_template_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=19)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coupon_row[] coupon;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=20)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_coupon_row[] existing_coupon;
                
        public create_credit_templateRequest() {
        }
        
        public create_credit_templateRequest(long client_no, string auth_key, string credit_template_name, int discount_type, float discount_amt, int no_of_credits, int credit_interval_months, System.Nullable<int> eligible_plan_no, string eligible_client_plan_id, System.Nullable<int> eligible_service_no, string eligible_client_service_id, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.eligible_service_types_row[] eligible_service_types, System.Nullable<int> percentage_plan_no, string percentage_client_plan_id, System.Nullable<int> percentage_service_no, string percentage_client_service_id, System.Nullable<int> alt_service_no, string alt_client_service_id, string client_credit_template_id, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coupon_row[] coupon, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_coupon_row[] existing_coupon) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.credit_template_name = credit_template_name;
                        this.discount_type = discount_type;
                        this.discount_amt = discount_amt;
                        this.no_of_credits = no_of_credits;
                        this.credit_interval_months = credit_interval_months;
                        this.eligible_plan_no = eligible_plan_no;
                        this.eligible_client_plan_id = eligible_client_plan_id;
                        this.eligible_service_no = eligible_service_no;
                        this.eligible_client_service_id = eligible_client_service_id;
                        this.eligible_service_types = eligible_service_types;
                        this.percentage_plan_no = percentage_plan_no;
                        this.percentage_client_plan_id = percentage_client_plan_id;
                        this.percentage_service_no = percentage_service_no;
                        this.percentage_client_service_id = percentage_client_service_id;
                        this.alt_service_no = alt_service_no;
                        this.alt_client_service_id = alt_client_service_id;
                        this.client_credit_template_id = client_credit_template_id;
                        this.coupon = coupon;
                        this.existing_coupon = existing_coupon;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create_credit_templateResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class create_credit_templateResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public string credit_template_no;
                
        public create_credit_templateResponse() {
        }

                 
        public create_credit_templateResponse(long error_code, string error_msg, string credit_template_no) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.credit_template_no = credit_template_no;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="update_credit_template", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class update_credit_templateRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public string credit_template_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public string credit_template_name;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        public int discount_type;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                        public float discount_amt;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                        public int no_of_credits;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                        public int credit_interval_months;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                        public string client_credit_template_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=9)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> eligible_plan_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=10)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string eligible_client_plan_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=11)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> eligible_service_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=12)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string eligible_client_service_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=13)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.eligible_service_types_row[] eligible_service_types;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=14)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> percentage_plan_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=15)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string percentage_client_plan_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=16)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> percentage_service_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=17)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string percentage_client_service_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=18)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> alt_service_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=19)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string alt_client_service_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=20)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coupon_row[] coupon;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=21)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_coupon_row[] existing_coupon;
                
        public update_credit_templateRequest() {
        }
        
        public update_credit_templateRequest(long client_no, string auth_key, string credit_template_no, string credit_template_name, int discount_type, float discount_amt, int no_of_credits, int credit_interval_months, string client_credit_template_id, System.Nullable<int> eligible_plan_no, string eligible_client_plan_id, System.Nullable<int> eligible_service_no, string eligible_client_service_id, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.eligible_service_types_row[] eligible_service_types, System.Nullable<int> percentage_plan_no, string percentage_client_plan_id, System.Nullable<int> percentage_service_no, string percentage_client_service_id, System.Nullable<int> alt_service_no, string alt_client_service_id, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coupon_row[] coupon, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.existing_coupon_row[] existing_coupon) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.credit_template_no = credit_template_no;
                        this.credit_template_name = credit_template_name;
                        this.discount_type = discount_type;
                        this.discount_amt = discount_amt;
                        this.no_of_credits = no_of_credits;
                        this.credit_interval_months = credit_interval_months;
                        this.client_credit_template_id = client_credit_template_id;
                        this.eligible_plan_no = eligible_plan_no;
                        this.eligible_client_plan_id = eligible_client_plan_id;
                        this.eligible_service_no = eligible_service_no;
                        this.eligible_client_service_id = eligible_client_service_id;
                        this.eligible_service_types = eligible_service_types;
                        this.percentage_plan_no = percentage_plan_no;
                        this.percentage_client_plan_id = percentage_client_plan_id;
                        this.percentage_service_no = percentage_service_no;
                        this.percentage_client_service_id = percentage_client_service_id;
                        this.alt_service_no = alt_service_no;
                        this.alt_client_service_id = alt_client_service_id;
                        this.coupon = coupon;
                        this.existing_coupon = existing_coupon;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="update_credit_templateResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class update_credit_templateResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public string credit_template_no;
                
        public update_credit_templateResponse() {
        }

                 
        public update_credit_templateResponse(long error_code, string error_msg, string credit_template_no) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.credit_template_no = credit_template_no;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="delete_templates", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class delete_templatesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.template_nos_row[] template_nos;
                
        public delete_templatesRequest() {
        }
        
        public delete_templatesRequest(long client_no, string auth_key, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.template_nos_row[] template_nos) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.template_nos = template_nos;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="delete_templatesResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class delete_templatesResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                
        public delete_templatesResponse() {
        }

                 
        public delete_templatesResponse(long error_code, string error_msg) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create_discount_rule", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class create_discount_ruleRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public string label;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public string rule_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        public string description;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                        public string ext_description;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                        public int flat_percent_ind;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                        public float amount;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                        public string currency;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=9)]
                        public string duration_type_ind;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=10)]
                        public string inline_offset_ind;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=11)]
                        public int service_code_to_use;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=12)]
                        public int scope_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=13)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> max_applicable_months;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=14)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> max_applications_per_acct;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=15)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> alt_service_no_2_apply;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=16)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> alt_service_id_2_apply;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=17)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string applicable_trans_scope;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=18)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_no_row[] plan_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=19)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_plan_id_row[] client_plan_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=20)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_no_row[] service_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=21)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_service_id_row[] client_service_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=22)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.item_no_row[] item_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=23)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_item_id_row[] client_item_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=24)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string use_all_or_nth_subs_rule;
                
        public create_discount_ruleRequest() {
        }
        
        public create_discount_ruleRequest(long client_no, string auth_key, string label, string rule_id, string description, string ext_description, int flat_percent_ind, float amount, string currency, string duration_type_ind, string inline_offset_ind, int service_code_to_use, int scope_no, System.Nullable<int> max_applicable_months, System.Nullable<int> max_applications_per_acct, System.Nullable<int> alt_service_no_2_apply, System.Nullable<int> alt_service_id_2_apply, string applicable_trans_scope, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_no_row[] plan_no, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_plan_id_row[] client_plan_id, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_no_row[] service_no, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_service_id_row[] client_service_id, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.item_no_row[] item_no, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_item_id_row[] client_item_id, string use_all_or_nth_subs_rule) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.label = label;
                        this.rule_id = rule_id;
                        this.description = description;
                        this.ext_description = ext_description;
                        this.flat_percent_ind = flat_percent_ind;
                        this.amount = amount;
                        this.currency = currency;
                        this.duration_type_ind = duration_type_ind;
                        this.inline_offset_ind = inline_offset_ind;
                        this.service_code_to_use = service_code_to_use;
                        this.scope_no = scope_no;
                        this.max_applicable_months = max_applicable_months;
                        this.max_applications_per_acct = max_applications_per_acct;
                        this.alt_service_no_2_apply = alt_service_no_2_apply;
                        this.alt_service_id_2_apply = alt_service_id_2_apply;
                        this.applicable_trans_scope = applicable_trans_scope;
                        this.plan_no = plan_no;
                        this.client_plan_id = client_plan_id;
                        this.service_no = service_no;
                        this.client_service_id = client_service_id;
                        this.item_no = item_no;
                        this.client_item_id = client_item_id;
                        this.use_all_or_nth_subs_rule = use_all_or_nth_subs_rule;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create_discount_ruleResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class create_discount_ruleResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public string rule_no;
                
        public create_discount_ruleResponse() {
        }

                 
        public create_discount_ruleResponse(long error_code, string error_msg, string rule_no) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.rule_no = rule_no;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create_discount_bundle", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class create_discount_bundleRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public string bundle_name;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public string bundle_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        public string bundle_description;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                        public string allow_overlap_ind;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rules_row[] rules;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rule_ids_row[] rule_ids;
                
        public create_discount_bundleRequest() {
        }
        
        public create_discount_bundleRequest(long client_no, string auth_key, string bundle_name, string bundle_id, string bundle_description, string allow_overlap_ind, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rules_row[] rules, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rule_ids_row[] rule_ids) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.bundle_name = bundle_name;
                        this.bundle_id = bundle_id;
                        this.bundle_description = bundle_description;
                        this.allow_overlap_ind = allow_overlap_ind;
                        this.rules = rules;
                        this.rule_ids = rule_ids;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create_discount_bundleResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class create_discount_bundleResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public string rule_no;
                
        public create_discount_bundleResponse() {
        }

                 
        public create_discount_bundleResponse(long error_code, string error_msg, string rule_no) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.rule_no = rule_no;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_discount_bundles", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_discount_bundlesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
        
        public get_discount_bundlesRequest() {
        }
        
        public get_discount_bundlesRequest(long client_no, string auth_key) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_discount_bundlesResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_discount_bundlesResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public int bundle_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                public string bundle_name;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                public string bundle_id;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                public string description;
                
        public get_discount_bundlesResponse() {
        }

                 
        public get_discount_bundlesResponse(long error_code, string error_msg, int bundle_no, string bundle_name, string bundle_id, string description) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.bundle_no = bundle_no;
                        this.bundle_name = bundle_name;
                        this.bundle_id = bundle_id;
                        this.description = description;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_discount_bundle_details", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_discount_bundle_detailsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public int bundle_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public string bundle_id;
                
        public get_discount_bundle_detailsRequest() {
        }
        
        public get_discount_bundle_detailsRequest(long client_no, string auth_key, int bundle_no, string bundle_id) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.bundle_no = bundle_no;
                        this.bundle_id = bundle_id;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_discount_bundle_detailsResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_discount_bundle_detailsResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public int bundle_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                public string bundle_name;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                public string bundle_id;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                public string description;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                public string allow_overlap_ind;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                [System.Xml.Serialization.XmlElementAttribute("rules", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rules_ReturnElement[] rules;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                [System.Xml.Serialization.XmlElementAttribute("rule_ids", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rule_ids_ReturnElement[] rule_ids;
                
        public get_discount_bundle_detailsResponse() {
        }

                 
        public get_discount_bundle_detailsResponse(long error_code, string error_msg, int bundle_no, string bundle_name, string bundle_id, string description, string allow_overlap_ind, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rules_ReturnElement[] rules, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rule_ids_ReturnElement[] rule_ids) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.bundle_no = bundle_no;
                        this.bundle_name = bundle_name;
                        this.bundle_id = bundle_id;
                        this.description = description;
                        this.allow_overlap_ind = allow_overlap_ind;
                        this.rules = rules;
                        this.rule_ids = rule_ids;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_discount_rules", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_discount_rulesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
        
        public get_discount_rulesRequest() {
        }
        
        public get_discount_rulesRequest(long client_no, string auth_key) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_discount_rulesResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_discount_rulesResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public int rule_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                public string rule_id;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                public string description;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                public string ext_description;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                public int flat_percent_ind;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                public float amount;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                public string currency;
                
        public get_discount_rulesResponse() {
        }

                 
        public get_discount_rulesResponse(long error_code, string error_msg, int rule_no, string rule_id, string description, string ext_description, int flat_percent_ind, float amount, string currency) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.rule_no = rule_no;
                        this.rule_id = rule_id;
                        this.description = description;
                        this.ext_description = ext_description;
                        this.flat_percent_ind = flat_percent_ind;
                        this.amount = amount;
                        this.currency = currency;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_discount_rule_details", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_discount_rule_detailsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public int rule_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public string client_rule_id;
                
        public get_discount_rule_detailsRequest() {
        }
        
        public get_discount_rule_detailsRequest(long client_no, string auth_key, int rule_no, string client_rule_id) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.rule_no = rule_no;
                        this.client_rule_id = client_rule_id;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_discount_rule_detailsResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_discount_rule_detailsResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public int rule_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                public string rule_id;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                public string description;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                public string ext_description;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                public int flat_percent_ind;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                public float amount;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                public string currency;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=9)]
                public string duration_type_ind;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=10)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> max_applicable_months;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=11)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> max_applications_per_acct;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=12)]
                public string inline_offset_ind;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=13)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> service_code_to_use;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=14)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> alt_service_no_2_apply;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=15)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> alt_service_id_2_apply;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=16)]
                public int scope_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=17)]
                [System.Xml.Serialization.XmlElementAttribute("plan_no", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_no_ReturnElement[] plan_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=18)]
                [System.Xml.Serialization.XmlElementAttribute("client_plan_id", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_plan_id_ReturnElement[] client_plan_id;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=19)]
                [System.Xml.Serialization.XmlElementAttribute("service_no", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_no_ReturnElement[] service_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=20)]
                [System.Xml.Serialization.XmlElementAttribute("client_service_id", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_service_id_ReturnElement[] client_service_id;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=21)]
                [System.Xml.Serialization.XmlElementAttribute("item_no", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.item_no_ReturnElement[] item_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=22)]
                [System.Xml.Serialization.XmlElementAttribute("client_item_id", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_item_id_ReturnElement[] client_item_id;
                
        public get_discount_rule_detailsResponse() {
        }

                 
        public get_discount_rule_detailsResponse(long error_code, string error_msg, int rule_no, string rule_id, string description, string ext_description, int flat_percent_ind, float amount, string currency, string duration_type_ind, System.Nullable<int> max_applicable_months, System.Nullable<int> max_applications_per_acct, string inline_offset_ind, System.Nullable<int> service_code_to_use, System.Nullable<int> alt_service_no_2_apply, System.Nullable<int> alt_service_id_2_apply, int scope_no, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_no_ReturnElement[] plan_no, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_plan_id_ReturnElement[] client_plan_id, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_no_ReturnElement[] service_no, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_service_id_ReturnElement[] client_service_id, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.item_no_ReturnElement[] item_no, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_item_id_ReturnElement[] client_item_id) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.rule_no = rule_no;
                        this.rule_id = rule_id;
                        this.description = description;
                        this.ext_description = ext_description;
                        this.flat_percent_ind = flat_percent_ind;
                        this.amount = amount;
                        this.currency = currency;
                        this.duration_type_ind = duration_type_ind;
                        this.max_applicable_months = max_applicable_months;
                        this.max_applications_per_acct = max_applications_per_acct;
                        this.inline_offset_ind = inline_offset_ind;
                        this.service_code_to_use = service_code_to_use;
                        this.alt_service_no_2_apply = alt_service_no_2_apply;
                        this.alt_service_id_2_apply = alt_service_id_2_apply;
                        this.scope_no = scope_no;
                        this.plan_no = plan_no;
                        this.client_plan_id = client_plan_id;
                        this.service_no = service_no;
                        this.client_service_id = client_service_id;
                        this.item_no = item_no;
                        this.client_item_id = client_item_id;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="delete_rules", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class delete_rulesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rule_nos_row[] rule_nos;
                
        public delete_rulesRequest() {
        }
        
        public delete_rulesRequest(long client_no, string auth_key, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.rule_nos_row[] rule_nos) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.rule_nos = rule_nos;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="delete_rulesResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class delete_rulesResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                
        public delete_rulesResponse() {
        }

                 
        public delete_rulesResponse(long error_code, string error_msg) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="delete_bundles", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class delete_bundlesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.bundle_nos_row[] bundle_nos;
                
        public delete_bundlesRequest() {
        }
        
        public delete_bundlesRequest(long client_no, string auth_key, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.bundle_nos_row[] bundle_nos) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.bundle_nos = bundle_nos;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="delete_bundlesResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class delete_bundlesResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                
        public delete_bundlesResponse() {
        }

                 
        public delete_bundlesResponse(long error_code, string error_msg) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_plans", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_plansRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
        
        public get_plansRequest() {
        }
        
        public get_plansRequest(long client_no, string auth_key) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_plansResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_plansResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                [System.Xml.Serialization.XmlElementAttribute("plans", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plans_ReturnElement[] plans;
                
        public get_plansResponse() {
        }

                 
        public get_plansResponse(long error_code, string error_msg, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plans_ReturnElement[] plans) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.plans = plans;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_plan_details", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_plan_detailsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public int plan_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public string client_plan_id;
                
        public get_plan_detailsRequest() {
        }
        
        public get_plan_detailsRequest(long client_no, string auth_key, int plan_no, string client_plan_id) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.plan_no = plan_no;
                        this.client_plan_id = client_plan_id;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_plan_detailsResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_plan_detailsResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public int plan_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                public string client_plan_id;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                public string plan_name;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                public int plan_level;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                public string plan_type;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                public string plan_description;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                [System.Xml.Serialization.XmlElementAttribute("plan_groups", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_groups_ReturnElement[] plan_groups;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=9)]
                [System.Xml.Serialization.XmlElementAttribute("plan_group_ids", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_group_ids_ReturnElement[] plan_group_ids;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=10)]
                public string currency_cd;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=11)]
                public string billing_interval;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=12)]
                public string usage_billing_interval;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=13)]
                public int active_ind;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=14)]
                public string rollover_months;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=15)]
                public int rollover_plan_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=16)]
                public int rollover_client_plan_id;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=17)]
                public string allow_child_accounts;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=18)]
                public int dunning_plan_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=19)]
                public int dunning_client_plan_id;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=20)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> free_trial_type;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=21)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> free_trial_duration;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=22)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> initial_free_months;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=23)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> acct_status_cd;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=24)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> rollover_status_days;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=25)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> rollover_status_cd;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=26)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> template_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=27)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> template_id;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=28)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> plan_cancel_min_month;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=29)]
                public string how_to_apply_min_fee;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=30)]
                public string is_deletable;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=31)]
                [System.Xml.Serialization.XmlElementAttribute("services", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.services_ReturnElement[] services;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=32)]
                [System.Xml.Serialization.XmlElementAttribute("resources", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.resources_ReturnElement[] resources;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=33)]
                [System.Xml.Serialization.XmlElementAttribute("parent_plans", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_plans_ReturnElement[] parent_plans;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=34)]
                [System.Xml.Serialization.XmlElementAttribute("parent_plan_ids", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_plan_ids_ReturnElement[] parent_plan_ids;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=35)]
                [System.Xml.Serialization.XmlElementAttribute("exclusion_plans", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.exclusion_plans_ReturnElement[] exclusion_plans;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=36)]
                [System.Xml.Serialization.XmlElementAttribute("supplemental_obj_fields", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.supplemental_obj_fields_ReturnElement[] supplemental_obj_fields;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=37)]
                [System.Xml.Serialization.XmlElementAttribute("surcharges", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.surcharges_ReturnElement[] surcharges;
                
        public get_plan_detailsResponse() {
        }

                 
        public get_plan_detailsResponse(long error_code, string error_msg, int plan_no, string client_plan_id, string plan_name, int plan_level, string plan_type, string plan_description, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_groups_ReturnElement[] plan_groups, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_group_ids_ReturnElement[] plan_group_ids, string currency_cd, string billing_interval, string usage_billing_interval, int active_ind, string rollover_months, int rollover_plan_no, int rollover_client_plan_id, string allow_child_accounts, int dunning_plan_no, int dunning_client_plan_id, System.Nullable<int> free_trial_type, System.Nullable<int> free_trial_duration, System.Nullable<int> initial_free_months, System.Nullable<int> acct_status_cd, System.Nullable<int> rollover_status_days, System.Nullable<int> rollover_status_cd, System.Nullable<int> template_no, System.Nullable<int> template_id, System.Nullable<int> plan_cancel_min_month, string how_to_apply_min_fee, string is_deletable, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.services_ReturnElement[] services, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.resources_ReturnElement[] resources, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_plans_ReturnElement[] parent_plans, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_plan_ids_ReturnElement[] parent_plan_ids, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.exclusion_plans_ReturnElement[] exclusion_plans, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.supplemental_obj_fields_ReturnElement[] supplemental_obj_fields, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.surcharges_ReturnElement[] surcharges) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.plan_no = plan_no;
                        this.client_plan_id = client_plan_id;
                        this.plan_name = plan_name;
                        this.plan_level = plan_level;
                        this.plan_type = plan_type;
                        this.plan_description = plan_description;
                        this.plan_groups = plan_groups;
                        this.plan_group_ids = plan_group_ids;
                        this.currency_cd = currency_cd;
                        this.billing_interval = billing_interval;
                        this.usage_billing_interval = usage_billing_interval;
                        this.active_ind = active_ind;
                        this.rollover_months = rollover_months;
                        this.rollover_plan_no = rollover_plan_no;
                        this.rollover_client_plan_id = rollover_client_plan_id;
                        this.allow_child_accounts = allow_child_accounts;
                        this.dunning_plan_no = dunning_plan_no;
                        this.dunning_client_plan_id = dunning_client_plan_id;
                        this.free_trial_type = free_trial_type;
                        this.free_trial_duration = free_trial_duration;
                        this.initial_free_months = initial_free_months;
                        this.acct_status_cd = acct_status_cd;
                        this.rollover_status_days = rollover_status_days;
                        this.rollover_status_cd = rollover_status_cd;
                        this.template_no = template_no;
                        this.template_id = template_id;
                        this.plan_cancel_min_month = plan_cancel_min_month;
                        this.how_to_apply_min_fee = how_to_apply_min_fee;
                        this.is_deletable = is_deletable;
                        this.services = services;
                        this.resources = resources;
                        this.parent_plans = parent_plans;
                        this.parent_plan_ids = parent_plan_ids;
                        this.exclusion_plans = exclusion_plans;
                        this.supplemental_obj_fields = supplemental_obj_fields;
                        this.surcharges = surcharges;
                    }
            }
                                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create_new_plan", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class create_new_planRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public string plan_name;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public string plan_description;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        public string plan_type;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                        public string currency;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                        public string billing_interval;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string client_plan_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_group_row[] plan_group;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=9)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_group_id_row[] plan_group_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=10)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string usage_billing_interval;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=11)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> active;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=12)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string rollover_months;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=13)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> rollover_plan_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=14)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string rollover_client_plan_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=15)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> initial_free_months;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=16)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> acct_status_cd;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=17)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> rollover_status_days;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=18)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> rollover_status_cd;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=19)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> dunning_plan_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=20)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string dunning_client_plan_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=21)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> template_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=22)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string client_email_template_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=23)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string apply_cancellation;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=24)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> plan_cancel_min_month;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=25)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string apply_minimum_fee;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=26)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string how_to_apply_minimum_fee;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=27)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.schedule_row[] schedule;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=28)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_row[] service;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=29)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.resource_row[] resource;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=30)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> arc_service_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=31)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_plans_row[] parent_plans;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=32)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_client_plan_ids_row[] parent_client_plan_ids;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=33)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.exclusion_plans_row[] exclusion_plans;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=34)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.supplemental_obj_field_row[] supplemental_obj_field;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=35)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public bool template_ind;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=36)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.child_plans_row[] child_plans;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=37)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string notification_template_group_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=38)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string credit_note_template_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=39)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.surcharge_no_row[] surcharge_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=40)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_surcharge_id_row[] client_surcharge_id;
                
        public create_new_planRequest() {
        }
        
        public create_new_planRequest(long client_no, string auth_key, string plan_name, string plan_description, string plan_type, string currency, string billing_interval, string client_plan_id, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_group_row[] plan_group, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_group_id_row[] plan_group_id, string usage_billing_interval, System.Nullable<int> active, string rollover_months, System.Nullable<int> rollover_plan_no, string rollover_client_plan_id, System.Nullable<int> initial_free_months, System.Nullable<int> acct_status_cd, System.Nullable<int> rollover_status_days, System.Nullable<int> rollover_status_cd, System.Nullable<int> dunning_plan_no, string dunning_client_plan_id, System.Nullable<int> template_no, string client_email_template_id, string apply_cancellation, System.Nullable<int> plan_cancel_min_month, string apply_minimum_fee, string how_to_apply_minimum_fee, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.schedule_row[] schedule, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_row[] service, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.resource_row[] resource, System.Nullable<int> arc_service_no, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_plans_row[] parent_plans, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_client_plan_ids_row[] parent_client_plan_ids, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.exclusion_plans_row[] exclusion_plans, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.supplemental_obj_field_row[] supplemental_obj_field, bool template_ind, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.child_plans_row[] child_plans, string notification_template_group_no, string credit_note_template_no, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.surcharge_no_row[] surcharge_no, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_surcharge_id_row[] client_surcharge_id) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.plan_name = plan_name;
                        this.plan_description = plan_description;
                        this.plan_type = plan_type;
                        this.currency = currency;
                        this.billing_interval = billing_interval;
                        this.client_plan_id = client_plan_id;
                        this.plan_group = plan_group;
                        this.plan_group_id = plan_group_id;
                        this.usage_billing_interval = usage_billing_interval;
                        this.active = active;
                        this.rollover_months = rollover_months;
                        this.rollover_plan_no = rollover_plan_no;
                        this.rollover_client_plan_id = rollover_client_plan_id;
                        this.initial_free_months = initial_free_months;
                        this.acct_status_cd = acct_status_cd;
                        this.rollover_status_days = rollover_status_days;
                        this.rollover_status_cd = rollover_status_cd;
                        this.dunning_plan_no = dunning_plan_no;
                        this.dunning_client_plan_id = dunning_client_plan_id;
                        this.template_no = template_no;
                        this.client_email_template_id = client_email_template_id;
                        this.apply_cancellation = apply_cancellation;
                        this.plan_cancel_min_month = plan_cancel_min_month;
                        this.apply_minimum_fee = apply_minimum_fee;
                        this.how_to_apply_minimum_fee = how_to_apply_minimum_fee;
                        this.schedule = schedule;
                        this.service = service;
                        this.resource = resource;
                        this.arc_service_no = arc_service_no;
                        this.parent_plans = parent_plans;
                        this.parent_client_plan_ids = parent_client_plan_ids;
                        this.exclusion_plans = exclusion_plans;
                        this.supplemental_obj_field = supplemental_obj_field;
                        this.template_ind = template_ind;
                        this.child_plans = child_plans;
                        this.notification_template_group_no = notification_template_group_no;
                        this.credit_note_template_no = credit_note_template_no;
                        this.surcharge_no = surcharge_no;
                        this.client_surcharge_id = client_surcharge_id;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create_new_planResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class create_new_planResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public string plan_no;
                
        public create_new_planResponse() {
        }

                 
        public create_new_planResponse(long error_code, string error_msg, string plan_no) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.plan_no = plan_no;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="edit_plan", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class edit_planRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public string plan_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public string plan_name;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        public string client_plan_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                        public int plan_type;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                        public string billing_interval;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                        public string currency;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string plan_description;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=9)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_group_row[] plan_group;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=10)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_group_id_row[] plan_group_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=11)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> active;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=12)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string usage_billing_interval;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=13)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> template_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=14)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string client_email_template_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=15)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string rollover_months;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=16)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> rollover_plan_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=17)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string rollover_client_plan_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=18)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> dunning_plan_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=19)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string dunning_client_plan_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=20)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> initial_free_months;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=21)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> acct_status_cd;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=22)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> rollover_status_days;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=23)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> rollover_status_cd;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=24)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> allow_child_accts;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=25)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string apply_cancellation;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=26)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> plan_cancel_min_month;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=27)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string apply_minimum_fee;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=28)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> how_to_apply_minimum_fee;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=29)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.schedule_row[] schedule;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=30)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_row[] service;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=31)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.resource_row[] resource;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=32)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> arc_service_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=33)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_plans_row[] parent_plans;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=34)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_client_plan_ids_row[] parent_client_plan_ids;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=35)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.exclusion_plans_row[] exclusion_plans;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=36)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.supplemental_obj_field_row[] supplemental_obj_field;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=37)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.child_plans_row[] child_plans;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=38)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string notification_template_group_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=39)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string credit_note_template_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=40)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.surcharge_no_row[] surcharge_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=41)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_surcharge_id_row[] client_surcharge_id;
                
        public edit_planRequest() {
        }
        
        public edit_planRequest(long client_no, string auth_key, string plan_no, string plan_name, string client_plan_id, int plan_type, string billing_interval, string currency, string plan_description, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_group_row[] plan_group, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_group_id_row[] plan_group_id, System.Nullable<int> active, string usage_billing_interval, System.Nullable<int> template_no, string client_email_template_id, string rollover_months, System.Nullable<int> rollover_plan_no, string rollover_client_plan_id, System.Nullable<int> dunning_plan_no, string dunning_client_plan_id, System.Nullable<int> initial_free_months, System.Nullable<int> acct_status_cd, System.Nullable<int> rollover_status_days, System.Nullable<int> rollover_status_cd, System.Nullable<int> allow_child_accts, string apply_cancellation, System.Nullable<int> plan_cancel_min_month, string apply_minimum_fee, System.Nullable<int> how_to_apply_minimum_fee, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.schedule_row[] schedule, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_row[] service, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.resource_row[] resource, System.Nullable<int> arc_service_no, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_plans_row[] parent_plans, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.parent_client_plan_ids_row[] parent_client_plan_ids, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.exclusion_plans_row[] exclusion_plans, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.supplemental_obj_field_row[] supplemental_obj_field, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.child_plans_row[] child_plans, string notification_template_group_no, string credit_note_template_no, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.surcharge_no_row[] surcharge_no, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_surcharge_id_row[] client_surcharge_id) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.plan_no = plan_no;
                        this.plan_name = plan_name;
                        this.client_plan_id = client_plan_id;
                        this.plan_type = plan_type;
                        this.billing_interval = billing_interval;
                        this.currency = currency;
                        this.plan_description = plan_description;
                        this.plan_group = plan_group;
                        this.plan_group_id = plan_group_id;
                        this.active = active;
                        this.usage_billing_interval = usage_billing_interval;
                        this.template_no = template_no;
                        this.client_email_template_id = client_email_template_id;
                        this.rollover_months = rollover_months;
                        this.rollover_plan_no = rollover_plan_no;
                        this.rollover_client_plan_id = rollover_client_plan_id;
                        this.dunning_plan_no = dunning_plan_no;
                        this.dunning_client_plan_id = dunning_client_plan_id;
                        this.initial_free_months = initial_free_months;
                        this.acct_status_cd = acct_status_cd;
                        this.rollover_status_days = rollover_status_days;
                        this.rollover_status_cd = rollover_status_cd;
                        this.allow_child_accts = allow_child_accts;
                        this.apply_cancellation = apply_cancellation;
                        this.plan_cancel_min_month = plan_cancel_min_month;
                        this.apply_minimum_fee = apply_minimum_fee;
                        this.how_to_apply_minimum_fee = how_to_apply_minimum_fee;
                        this.schedule = schedule;
                        this.service = service;
                        this.resource = resource;
                        this.arc_service_no = arc_service_no;
                        this.parent_plans = parent_plans;
                        this.parent_client_plan_ids = parent_client_plan_ids;
                        this.exclusion_plans = exclusion_plans;
                        this.supplemental_obj_field = supplemental_obj_field;
                        this.child_plans = child_plans;
                        this.notification_template_group_no = notification_template_group_no;
                        this.credit_note_template_no = credit_note_template_no;
                        this.surcharge_no = surcharge_no;
                        this.client_surcharge_id = client_surcharge_id;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="edit_planResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class edit_planResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public string plan_no;
                
        public edit_planResponse() {
        }

                 
        public edit_planResponse(long error_code, string error_msg, string plan_no) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.plan_no = plan_no;
                    }
            }
                                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="delete_plans", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class delete_plansRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_nos_row[] plan_nos;
                
        public delete_plansRequest() {
        }
        
        public delete_plansRequest(long client_no, string auth_key, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_nos_row[] plan_nos) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.plan_nos = plan_nos;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="delete_plansResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class delete_plansResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                [System.Xml.Serialization.XmlElementAttribute("plans", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plans_ReturnElement[] plans;
                
        public delete_plansResponse() {
        }

                 
        public delete_plansResponse(long error_code, string error_msg, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plans_ReturnElement[] plans) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.plans = plans;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="copy_plan", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class copy_planRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public int plan_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public string client_plan_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string plan_name;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string new_client_plan_id;
                
        public copy_planRequest() {
        }
        
        public copy_planRequest(long client_no, string auth_key, int plan_no, string client_plan_id, string plan_name, string new_client_plan_id) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.plan_no = plan_no;
                        this.client_plan_id = client_plan_id;
                        this.plan_name = plan_name;
                        this.new_client_plan_id = new_client_plan_id;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="copy_planResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class copy_planResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> plan_no;
                
        public copy_planResponse() {
        }

                 
        public copy_planResponse(long error_code, string error_msg, System.Nullable<int> plan_no) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.plan_no = plan_no;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="update_master_plan", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class update_master_planRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
        
        public update_master_planRequest() {
        }
        
        public update_master_planRequest(long client_no, string auth_key) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="update_master_planResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class update_master_planResponse {
        
                
        public update_master_planResponse() {
        }

            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="update_supplemental_plan", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class update_supplemental_planRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
        
        public update_supplemental_planRequest() {
        }
        
        public update_supplemental_planRequest(long client_no, string auth_key) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="update_supplemental_planResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class update_supplemental_planResponse {
        
                
        public update_supplemental_planResponse() {
        }

            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_promotions", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_promotionsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
        
        public get_promotionsRequest() {
        }
        
        public get_promotionsRequest(long client_no, string auth_key) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_promotionsResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_promotionsResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                [System.Xml.Serialization.XmlElementAttribute("promotions", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.promotions_ReturnElement[] promotions;
                
        public get_promotionsResponse() {
        }

                 
        public get_promotionsResponse(long error_code, string error_msg, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.promotions_ReturnElement[] promotions) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.promotions = promotions;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_promotion_details", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_promotion_detailsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public string promo_cd;
                
        public get_promotion_detailsRequest() {
        }
        
        public get_promotion_detailsRequest(long client_no, string auth_key, string promo_cd) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.promo_cd = promo_cd;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_promotion_detailsResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_promotion_detailsResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public int client_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                public string promo_cd;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                public string promo_desc;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string start_date;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string exp_date;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string max_uses;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                public string plan_type_name;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=9)]
                public string plan_type_desc;
                
        public get_promotion_detailsResponse() {
        }

                 
        public get_promotion_detailsResponse(long error_code, string error_msg, int client_no, string promo_cd, string promo_desc, string start_date, string exp_date, string max_uses, string plan_type_name, string plan_type_desc) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.client_no = client_no;
                        this.promo_cd = promo_cd;
                        this.promo_desc = promo_desc;
                        this.start_date = start_date;
                        this.exp_date = exp_date;
                        this.max_uses = max_uses;
                        this.plan_type_name = plan_type_name;
                        this.plan_type_desc = plan_type_desc;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create_promotion", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class create_promotionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public string promo_cd;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public string promo_desc;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        public int promo_plan_set_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string no_of_uses;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string start_date;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string exp_date;
                
        public create_promotionRequest() {
        }
        
        public create_promotionRequest(long client_no, string auth_key, string promo_cd, string promo_desc, int promo_plan_set_no, string no_of_uses, string start_date, string exp_date) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.promo_cd = promo_cd;
                        this.promo_desc = promo_desc;
                        this.promo_plan_set_no = promo_plan_set_no;
                        this.no_of_uses = no_of_uses;
                        this.start_date = start_date;
                        this.exp_date = exp_date;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create_promotionResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class create_promotionResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public string promo_cd;
                
        public create_promotionResponse() {
        }

                 
        public create_promotionResponse(long error_code, string error_msg, string promo_cd) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.promo_cd = promo_cd;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="update_promotion", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class update_promotionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public string promo_cd;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public string promo_desc;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        public int promo_plan_set_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string no_of_uses;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string start_date;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string exp_date;
                
        public update_promotionRequest() {
        }
        
        public update_promotionRequest(long client_no, string auth_key, string promo_cd, string promo_desc, int promo_plan_set_no, string no_of_uses, string start_date, string exp_date) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.promo_cd = promo_cd;
                        this.promo_desc = promo_desc;
                        this.promo_plan_set_no = promo_plan_set_no;
                        this.no_of_uses = no_of_uses;
                        this.start_date = start_date;
                        this.exp_date = exp_date;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="update_promotionResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class update_promotionResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public string promo_cd;
                
        public update_promotionResponse() {
        }

                 
        public update_promotionResponse(long error_code, string error_msg, string promo_cd) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.promo_cd = promo_cd;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_usage_types", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_usage_typesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
        
        public get_usage_typesRequest() {
        }
        
        public get_usage_typesRequest(long client_no, string auth_key) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_usage_typesResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_usage_typesResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                [System.Xml.Serialization.XmlElementAttribute("usage_types", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.usage_types_ReturnElement[] usage_types;
                
        public get_usage_typesResponse() {
        }

                 
        public get_usage_typesResponse(long error_code, string error_msg, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.usage_types_ReturnElement[] usage_types) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.usage_types = usage_types;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_usage_type_details", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_usage_type_detailsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public int usage_type_no;
                
        public get_usage_type_detailsRequest() {
        }
        
        public get_usage_type_detailsRequest(long client_no, string auth_key, int usage_type_no) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.usage_type_no = usage_type_no;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_usage_type_detailsResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_usage_type_detailsResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public int usage_type_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                public string usage_type_name;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                public string usage_type_desc;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string usage_type_cd;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                public string usage_unit_type;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                public string client_usage_unit_type_id;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                public bool is_editable;
                
        public get_usage_type_detailsResponse() {
        }

                 
        public get_usage_type_detailsResponse(long error_code, string error_msg, int usage_type_no, string usage_type_name, string usage_type_desc, string usage_type_cd, string usage_unit_type, string client_usage_unit_type_id, bool is_editable) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.usage_type_no = usage_type_no;
                        this.usage_type_name = usage_type_name;
                        this.usage_type_desc = usage_type_desc;
                        this.usage_type_cd = usage_type_cd;
                        this.usage_unit_type = usage_unit_type;
                        this.client_usage_unit_type_id = client_usage_unit_type_id;
                        this.is_editable = is_editable;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_usage_unit_types", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_usage_unit_typesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
        
        public get_usage_unit_typesRequest() {
        }
        
        public get_usage_unit_typesRequest(long client_no, string auth_key) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_usage_unit_typesResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_usage_unit_typesResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                [System.Xml.Serialization.XmlElementAttribute("usage_unit_types", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.usage_unit_types_ReturnElement[] usage_unit_types;
                
        public get_usage_unit_typesResponse() {
        }

                 
        public get_usage_unit_typesResponse(long error_code, string error_msg, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.usage_unit_types_ReturnElement[] usage_unit_types) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.usage_unit_types = usage_unit_types;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create_usage_type", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class create_usage_typeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public string usage_type_name;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public string usage_type_desc;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        public int usage_unit_type_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string usage_type_code;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string usage_type_display_string;
                
        public create_usage_typeRequest() {
        }
        
        public create_usage_typeRequest(long client_no, string auth_key, string usage_type_name, string usage_type_desc, int usage_unit_type_no, string usage_type_code, string usage_type_display_string) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.usage_type_name = usage_type_name;
                        this.usage_type_desc = usage_type_desc;
                        this.usage_unit_type_no = usage_unit_type_no;
                        this.usage_type_code = usage_type_code;
                        this.usage_type_display_string = usage_type_display_string;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create_usage_typeResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class create_usage_typeResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public int usage_type_no;
                
        public create_usage_typeResponse() {
        }

                 
        public create_usage_typeResponse(long error_code, string error_msg, int usage_type_no) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.usage_type_no = usage_type_no;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="update_usage_type", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class update_usage_typeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public int usage_type_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public string usage_type_name;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        public string usage_type_desc;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                        public int usage_unit_type_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string usage_type_code;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string usage_type_display_string;
                
        public update_usage_typeRequest() {
        }
        
        public update_usage_typeRequest(long client_no, string auth_key, int usage_type_no, string usage_type_name, string usage_type_desc, int usage_unit_type_no, string usage_type_code, string usage_type_display_string) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.usage_type_no = usage_type_no;
                        this.usage_type_name = usage_type_name;
                        this.usage_type_desc = usage_type_desc;
                        this.usage_unit_type_no = usage_unit_type_no;
                        this.usage_type_code = usage_type_code;
                        this.usage_type_display_string = usage_type_display_string;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="update_usage_typeResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class update_usage_typeResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public int usage_type_no;
                
        public update_usage_typeResponse() {
        }

                 
        public update_usage_typeResponse(long error_code, string error_msg, int usage_type_no) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.usage_type_no = usage_type_no;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create_supp_obj_field", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class create_supp_obj_fieldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public string field_name;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string description;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string min_no_sel;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> max_no_sel;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string datatype;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string form_input_type;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string use_allowed_vals_ind;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=9)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string option_value;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=10)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string option_value_order;
                
        public create_supp_obj_fieldRequest() {
        }
        
        public create_supp_obj_fieldRequest(long client_no, string auth_key, string field_name, string description, string min_no_sel, System.Nullable<int> max_no_sel, string datatype, string form_input_type, string use_allowed_vals_ind, string option_value, string option_value_order) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.field_name = field_name;
                        this.description = description;
                        this.min_no_sel = min_no_sel;
                        this.max_no_sel = max_no_sel;
                        this.datatype = datatype;
                        this.form_input_type = form_input_type;
                        this.use_allowed_vals_ind = use_allowed_vals_ind;
                        this.option_value = option_value;
                        this.option_value_order = option_value_order;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create_supp_obj_fieldResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class create_supp_obj_fieldResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public int field_no;
                
        public create_supp_obj_fieldResponse() {
        }

                 
        public create_supp_obj_fieldResponse(long error_code, string error_msg, int field_no) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.field_no = field_no;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="update_supp_obj_field", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class update_supp_obj_fieldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public int field_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public string field_name;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string description;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string min_no_sel;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> max_no_sel;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string datatype;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string form_input_type;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=9)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string use_allowed_vals_ind;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=10)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string option_value;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=11)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string option_value_order;
                
        public update_supp_obj_fieldRequest() {
        }
        
        public update_supp_obj_fieldRequest(long client_no, string auth_key, int field_no, string field_name, string description, string min_no_sel, System.Nullable<int> max_no_sel, string datatype, string form_input_type, string use_allowed_vals_ind, string option_value, string option_value_order) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.field_no = field_no;
                        this.field_name = field_name;
                        this.description = description;
                        this.min_no_sel = min_no_sel;
                        this.max_no_sel = max_no_sel;
                        this.datatype = datatype;
                        this.form_input_type = form_input_type;
                        this.use_allowed_vals_ind = use_allowed_vals_ind;
                        this.option_value = option_value;
                        this.option_value_order = option_value_order;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="update_supp_obj_fieldResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class update_supp_obj_fieldResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public int field_no;
                
        public update_supp_obj_fieldResponse() {
        }

                 
        public update_supp_obj_fieldResponse(long error_code, string error_msg, int field_no) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.field_no = field_no;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_supp_obj_fields", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_supp_obj_fieldsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public int field_no;
                
        public get_supp_obj_fieldsRequest() {
        }
        
        public get_supp_obj_fieldsRequest(long client_no, string auth_key, int field_no) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.field_no = field_no;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_supp_obj_fieldsResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_supp_obj_fieldsResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public int field_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                public string field_name;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string description;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string datatype;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string min_no_sel;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> max_no_sel;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string form_input_type;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=9)]
                [System.Xml.Serialization.XmlElementAttribute("allowed_values", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.allowed_values_ReturnElement[] allowed_values;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=10)]
                [System.Xml.Serialization.XmlElementAttribute("associated_objects", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.associated_objects_ReturnElement[] associated_objects;
                
        public get_supp_obj_fieldsResponse() {
        }

                 
        public get_supp_obj_fieldsResponse(long error_code, string error_msg, int field_no, string field_name, string description, string datatype, string min_no_sel, System.Nullable<int> max_no_sel, string form_input_type, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.allowed_values_ReturnElement[] allowed_values, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.associated_objects_ReturnElement[] associated_objects) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.field_no = field_no;
                        this.field_name = field_name;
                        this.description = description;
                        this.datatype = datatype;
                        this.min_no_sel = min_no_sel;
                        this.max_no_sel = max_no_sel;
                        this.form_input_type = form_input_type;
                        this.allowed_values = allowed_values;
                        this.associated_objects = associated_objects;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_plan_groups", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_plan_groupsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
        
        public get_plan_groupsRequest() {
        }
        
        public get_plan_groupsRequest(long client_no, string auth_key) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_plan_groupsResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_plan_groupsResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                [System.Xml.Serialization.XmlElementAttribute("plan_groups", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_groups_ReturnElement[] plan_groups;
                
        public get_plan_groupsResponse() {
        }

                 
        public get_plan_groupsResponse(long error_code, string error_msg, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_groups_ReturnElement[] plan_groups) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.plan_groups = plan_groups;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_plan_group_details", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_plan_group_detailsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public int group_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public int client_plan_change_group_id;
                
        public get_plan_group_detailsRequest() {
        }
        
        public get_plan_group_detailsRequest(long client_no, string auth_key, int group_no, int client_plan_change_group_id) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.group_no = group_no;
                        this.client_plan_change_group_id = client_plan_change_group_id;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_plan_group_detailsResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_plan_group_detailsResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public int group_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                public string group_name;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                public string group_desc;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string client_plan_change_group_id;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                public string group_usage;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                [System.Xml.Serialization.XmlElementAttribute("plans", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plans_ReturnElement[] plans;
                
        public get_plan_group_detailsResponse() {
        }

                 
        public get_plan_group_detailsResponse(long error_code, string error_msg, int group_no, string group_name, string group_desc, string client_plan_change_group_id, string group_usage, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plans_ReturnElement[] plans) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.group_no = group_no;
                        this.group_name = group_name;
                        this.group_desc = group_desc;
                        this.client_plan_change_group_id = client_plan_change_group_id;
                        this.group_usage = group_usage;
                        this.plans = plans;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create_plan_group", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class create_plan_groupRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public string group_name;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public string group_desc;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        public string group_usage;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string client_plan_change_group_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string group_plans;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string group_plan_ids;
                
        public create_plan_groupRequest() {
        }
        
        public create_plan_groupRequest(long client_no, string auth_key, string group_name, string group_desc, string group_usage, string client_plan_change_group_id, string group_plans, string group_plan_ids) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.group_name = group_name;
                        this.group_desc = group_desc;
                        this.group_usage = group_usage;
                        this.client_plan_change_group_id = client_plan_change_group_id;
                        this.group_plans = group_plans;
                        this.group_plan_ids = group_plan_ids;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create_plan_groupResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class create_plan_groupResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public int group_no;
                
        public create_plan_groupResponse() {
        }

                 
        public create_plan_groupResponse(long error_code, string error_msg, int group_no) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.group_no = group_no;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="update_plan_group", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class update_plan_groupRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public int group_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public string group_name;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        public string group_desc;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                        public string group_usage;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                        public string client_plan_change_group_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string group_plans;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string group_plan_ids;
                
        public update_plan_groupRequest() {
        }
        
        public update_plan_groupRequest(long client_no, string auth_key, int group_no, string group_name, string group_desc, string group_usage, string client_plan_change_group_id, string group_plans, string group_plan_ids) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.group_no = group_no;
                        this.group_name = group_name;
                        this.group_desc = group_desc;
                        this.group_usage = group_usage;
                        this.client_plan_change_group_id = client_plan_change_group_id;
                        this.group_plans = group_plans;
                        this.group_plan_ids = group_plan_ids;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="update_plan_groupResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class update_plan_groupResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public int group_no;
                
        public update_plan_groupResponse() {
        }

                 
        public update_plan_groupResponse(long error_code, string error_msg, int group_no) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.group_no = group_no;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="delete_plan_group", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class delete_plan_groupRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public string group_list;
                
        public delete_plan_groupRequest() {
        }
        
        public delete_plan_groupRequest(long client_no, string auth_key, string group_list) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.group_list = group_list;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="delete_plan_groupResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class delete_plan_groupResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_groups_ReturnElement[] plan_groups;
                
        public delete_plan_groupResponse() {
        }

                 
        public delete_plan_groupResponse(long error_code, string error_msg, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_groups_ReturnElement[] plan_groups) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.plan_groups = plan_groups;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="list_coa", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class list_coaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
        
        public list_coaRequest() {
        }
        
        public list_coaRequest(long client_no, string auth_key) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="list_coaResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class list_coaResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                [System.Xml.Serialization.XmlElementAttribute("coa_list", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coa_list_ReturnElement[] coa_list;
                
        public list_coaResponse() {
        }

                 
        public list_coaResponse(long error_code, string error_msg, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coa_list_ReturnElement[] coa_list) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.coa_list = coa_list;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="add_coa", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class add_coaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public string coa_code;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string coa_description;
                
        public add_coaRequest() {
        }
        
        public add_coaRequest(long client_no, string auth_key, string coa_code, string coa_description) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.coa_code = coa_code;
                        this.coa_description = coa_description;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="add_coaResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class add_coaResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                [System.Xml.Serialization.XmlElementAttribute("coa", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coa_ReturnElement[] coa;
                
        public add_coaResponse() {
        }

                 
        public add_coaResponse(long error_code, string error_msg, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coa_ReturnElement[] coa) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.coa = coa;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_coa", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_coaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public long coa_id;
                
        public get_coaRequest() {
        }
        
        public get_coaRequest(long client_no, string auth_key, long coa_id) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.coa_id = coa_id;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_coaResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_coaResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                [System.Xml.Serialization.XmlElementAttribute("coa", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coa_ReturnElement[] coa;
                
        public get_coaResponse() {
        }

                 
        public get_coaResponse(long error_code, string error_msg, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coa_ReturnElement[] coa) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.coa = coa;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="edit_coa", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class edit_coaRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public long coa_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string coa_code;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string coa_description;
                
        public edit_coaRequest() {
        }
        
        public edit_coaRequest(long client_no, string auth_key, long coa_id, string coa_code, string coa_description) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.coa_id = coa_id;
                        this.coa_code = coa_code;
                        this.coa_description = coa_description;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="edit_coaResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class edit_coaResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                [System.Xml.Serialization.XmlElementAttribute("coa", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coa_ReturnElement[] coa;
                
        public edit_coaResponse() {
        }

                 
        public edit_coaResponse(long error_code, string error_msg, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.coa_ReturnElement[] coa) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.coa = coa;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_surcharges", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_surchargesRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
        
        public get_surchargesRequest() {
        }
        
        public get_surchargesRequest(long client_no, string auth_key) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_surchargesResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_surchargesResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                [System.Xml.Serialization.XmlElementAttribute("surcharges", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.surcharges_ReturnElement[] surcharges;
                
        public get_surchargesResponse() {
        }

                 
        public get_surchargesResponse(long error_code, string error_msg, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.surcharges_ReturnElement[] surcharges) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.surcharges = surcharges;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_surcharge_details", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_surcharge_detailsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public int surcharge_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public string client_surcharge_id;
                
        public get_surcharge_detailsRequest() {
        }
        
        public get_surcharge_detailsRequest(long client_no, string auth_key, int surcharge_no, string client_surcharge_id) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.surcharge_no = surcharge_no;
                        this.client_surcharge_id = client_surcharge_id;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="get_surcharge_detailsResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class get_surcharge_detailsResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                public int surcharge_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                public string surcharge_name;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                public string client_surcharge_id;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                public string description;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string ext_description;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                public string currency_cd;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                public string surcharge_type_cd;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=9)]
                public string inline_offset_ind;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=10)]
                public string apply_b4_or_after_discount_cd;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=11)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> apply_to_zero_invoice_ind;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=12)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> tax_group;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=13)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string gl_cd;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=14)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string ar_gl_cd;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=15)]
                public int scope_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=16)]
                [System.Xml.Serialization.XmlElementAttribute("plan_no", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_no_ReturnElement[] plan_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=17)]
                [System.Xml.Serialization.XmlElementAttribute("client_plan_id", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_plan_id_ReturnElement[] client_plan_id;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=18)]
                [System.Xml.Serialization.XmlElementAttribute("service_no", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_no_ReturnElement[] service_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=19)]
                [System.Xml.Serialization.XmlElementAttribute("client_service_id", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_service_id_ReturnElement[] client_service_id;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=20)]
                [System.Xml.Serialization.XmlElementAttribute("item_no", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.item_no_ReturnElement[] item_no;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=21)]
                [System.Xml.Serialization.XmlElementAttribute("client_item_id", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_item_id_ReturnElement[] client_item_id;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=22)]
                [System.Xml.Serialization.XmlElementAttribute("plan_service", IsNullable=true)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_service_ReturnElement[] plan_service;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=23)]
                public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.tier_ReturnElement[] tier;
                
        public get_surcharge_detailsResponse() {
        }

                 
        public get_surcharge_detailsResponse(long error_code, string error_msg, int surcharge_no, string surcharge_name, string client_surcharge_id, string description, string ext_description, string currency_cd, string surcharge_type_cd, string inline_offset_ind, string apply_b4_or_after_discount_cd, System.Nullable<int> apply_to_zero_invoice_ind, System.Nullable<int> tax_group, string gl_cd, string ar_gl_cd, int scope_no, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_no_ReturnElement[] plan_no, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_plan_id_ReturnElement[] client_plan_id, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_no_ReturnElement[] service_no, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_service_id_ReturnElement[] client_service_id, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.item_no_ReturnElement[] item_no, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_item_id_ReturnElement[] client_item_id, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_service_ReturnElement[] plan_service, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.tier_ReturnElement[] tier) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.surcharge_no = surcharge_no;
                        this.surcharge_name = surcharge_name;
                        this.client_surcharge_id = client_surcharge_id;
                        this.description = description;
                        this.ext_description = ext_description;
                        this.currency_cd = currency_cd;
                        this.surcharge_type_cd = surcharge_type_cd;
                        this.inline_offset_ind = inline_offset_ind;
                        this.apply_b4_or_after_discount_cd = apply_b4_or_after_discount_cd;
                        this.apply_to_zero_invoice_ind = apply_to_zero_invoice_ind;
                        this.tax_group = tax_group;
                        this.gl_cd = gl_cd;
                        this.ar_gl_cd = ar_gl_cd;
                        this.scope_no = scope_no;
                        this.plan_no = plan_no;
                        this.client_plan_id = client_plan_id;
                        this.service_no = service_no;
                        this.client_service_id = client_service_id;
                        this.item_no = item_no;
                        this.client_item_id = client_item_id;
                        this.plan_service = plan_service;
                        this.tier = tier;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create_surcharge", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class create_surchargeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public string surcharge_name;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public string description;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        public string ext_description;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                        public string currency_cd;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                        public string surcharge_type_cd;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                        public string inline_offset_ind;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                        public string apply_b4_or_after_discount_cd;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=9)]
                        public int scope_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=10)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.tier_row[] tier;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=11)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string client_surcharge_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=12)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> apply_to_zero_invoice_ind;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=13)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> tax_group;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=14)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string gl_cd;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=15)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string ar_gl_cd;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=16)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_no_row[] plan_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=17)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_plan_id_row[] client_plan_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=18)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_no_row[] service_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=19)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_service_id_row[] client_service_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=20)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.item_no_row[] item_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=21)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_item_id_row[] client_item_id;
                
        public create_surchargeRequest() {
        }
        
        public create_surchargeRequest(long client_no, string auth_key, string surcharge_name, string description, string ext_description, string currency_cd, string surcharge_type_cd, string inline_offset_ind, string apply_b4_or_after_discount_cd, int scope_no, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.tier_row[] tier, string client_surcharge_id, System.Nullable<int> apply_to_zero_invoice_ind, System.Nullable<int> tax_group, string gl_cd, string ar_gl_cd, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_no_row[] plan_no, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_plan_id_row[] client_plan_id, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_no_row[] service_no, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_service_id_row[] client_service_id, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.item_no_row[] item_no, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_item_id_row[] client_item_id) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.surcharge_name = surcharge_name;
                        this.description = description;
                        this.ext_description = ext_description;
                        this.currency_cd = currency_cd;
                        this.surcharge_type_cd = surcharge_type_cd;
                        this.inline_offset_ind = inline_offset_ind;
                        this.apply_b4_or_after_discount_cd = apply_b4_or_after_discount_cd;
                        this.scope_no = scope_no;
                        this.tier = tier;
                        this.client_surcharge_id = client_surcharge_id;
                        this.apply_to_zero_invoice_ind = apply_to_zero_invoice_ind;
                        this.tax_group = tax_group;
                        this.gl_cd = gl_cd;
                        this.ar_gl_cd = ar_gl_cd;
                        this.plan_no = plan_no;
                        this.client_plan_id = client_plan_id;
                        this.service_no = service_no;
                        this.client_service_id = client_service_id;
                        this.item_no = item_no;
                        this.client_item_id = client_item_id;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="create_surchargeResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class create_surchargeResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string surcharge_no;
                
        public create_surchargeResponse() {
        }

                 
        public create_surchargeResponse(long error_code, string error_msg, string surcharge_no) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.surcharge_no = surcharge_no;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="edit_surcharge", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class edit_surchargeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public string surcharge_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                        public string surcharge_name;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=4)]
                        public string client_surcharge_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=5)]
                        public string description;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=6)]
                        public string ext_description;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=7)]
                        public string currency_cd;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=8)]
                        public int scope_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=9)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.tier_row[] tier;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=10)]
                        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public System.Nullable<int> apply_to_zero_invoice_ind;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=11)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_no_row[] plan_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=12)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_plan_id_row[] client_plan_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=13)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_no_row[] service_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=14)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_service_id_row[] client_service_id;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=15)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.item_no_row[] item_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=16)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_item_id_row[] client_item_id;
                
        public edit_surchargeRequest() {
        }
        
        public edit_surchargeRequest(long client_no, string auth_key, string surcharge_no, string surcharge_name, string client_surcharge_id, string description, string ext_description, string currency_cd, int scope_no, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.tier_row[] tier, System.Nullable<int> apply_to_zero_invoice_ind, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.plan_no_row[] plan_no, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_plan_id_row[] client_plan_id, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.service_no_row[] service_no, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_service_id_row[] client_service_id, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.item_no_row[] item_no, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_item_id_row[] client_item_id) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.surcharge_no = surcharge_no;
                        this.surcharge_name = surcharge_name;
                        this.client_surcharge_id = client_surcharge_id;
                        this.description = description;
                        this.ext_description = ext_description;
                        this.currency_cd = currency_cd;
                        this.scope_no = scope_no;
                        this.tier = tier;
                        this.apply_to_zero_invoice_ind = apply_to_zero_invoice_ind;
                        this.plan_no = plan_no;
                        this.client_plan_id = client_plan_id;
                        this.service_no = service_no;
                        this.client_service_id = client_service_id;
                        this.item_no = item_no;
                        this.client_item_id = client_item_id;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="edit_surchargeResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class edit_surchargeResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
                public string surcharge_no;
                
        public edit_surchargeResponse() {
        }

                 
        public edit_surchargeResponse(long error_code, string error_msg, string surcharge_no) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                        this.surcharge_no = surcharge_no;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="delete_surcharge", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class delete_surchargeRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.surcharge_no_row[] surcharge_no;
                        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=3)]
                [System.Xml.Serialization.XmlArrayAttribute(IsNullable=true)]
        public Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_surcharge_id_row[] client_surcharge_id;
                
        public delete_surchargeRequest() {
        }
        
        public delete_surchargeRequest(long client_no, string auth_key, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.surcharge_no_row[] surcharge_no, Aria.SDK.AriaServices.AriaWebServices.AriaAdminTools.client_surcharge_id_row[] client_surcharge_id) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.surcharge_no = surcharge_no;
                        this.client_surcharge_id = client_surcharge_id;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="delete_surchargeResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class delete_surchargeResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                
        public delete_surchargeResponse() {
        }

                 
        public delete_surchargeResponse(long error_code, string error_msg) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                    }
            }
                            [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="validate_admin_session", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class validate_admin_sessionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
        public long client_no;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public string auth_key;
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=2)]
                        public string session_id;
                
        public validate_admin_sessionRequest() {
        }
        
        public validate_admin_sessionRequest(long client_no, string auth_key, string session_id) {
            this.client_no = client_no;
            this.auth_key = auth_key;
                        this.session_id = session_id;
                    }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="validate_admin_sessionResponseElement", WrapperNamespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", IsWrapped=true)]
    public partial class validate_admin_sessionResponse {
        
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=0)]
                public long error_code;
                [System.ServiceModel.MessageBodyMemberAttribute(Namespace="urn:client:api:wsdl:document/literal_wrapped:vers:6.22:aria_complete_" + "api", Order=1)]
                public string error_msg;
                
        public validate_admin_sessionResponse() {
        }

                 
        public validate_admin_sessionResponse(long error_code, string error_msg) {
                        this.error_code = error_code;
                        this.error_msg = error_msg;
                    }
            }
                    
}
