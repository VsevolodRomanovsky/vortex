﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TurnstileServer.TurnstileService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Visitor", Namespace="http://schemas.datacontract.org/2004/07/TurnstileWcfService")]
    [System.SerializableAttribute()]
    public partial class Visitor : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsValidField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string MiddleNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PermitIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] PictureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime RegistrationDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TurnstileServer.TurnstileService.Visit[] VisitsField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FirstName {
            get {
                return this.FirstNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FirstNameField, value) != true)) {
                    this.FirstNameField = value;
                    this.RaisePropertyChanged("FirstName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsValid {
            get {
                return this.IsValidField;
            }
            set {
                if ((this.IsValidField.Equals(value) != true)) {
                    this.IsValidField = value;
                    this.RaisePropertyChanged("IsValid");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string MiddleName {
            get {
                return this.MiddleNameField;
            }
            set {
                if ((object.ReferenceEquals(this.MiddleNameField, value) != true)) {
                    this.MiddleNameField = value;
                    this.RaisePropertyChanged("MiddleName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PermitId {
            get {
                return this.PermitIdField;
            }
            set {
                if ((this.PermitIdField.Equals(value) != true)) {
                    this.PermitIdField = value;
                    this.RaisePropertyChanged("PermitId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Picture {
            get {
                return this.PictureField;
            }
            set {
                if ((object.ReferenceEquals(this.PictureField, value) != true)) {
                    this.PictureField = value;
                    this.RaisePropertyChanged("Picture");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime RegistrationDate {
            get {
                return this.RegistrationDateField;
            }
            set {
                if ((this.RegistrationDateField.Equals(value) != true)) {
                    this.RegistrationDateField = value;
                    this.RaisePropertyChanged("RegistrationDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TurnstileServer.TurnstileService.Visit[] Visits {
            get {
                return this.VisitsField;
            }
            set {
                if ((object.ReferenceEquals(this.VisitsField, value) != true)) {
                    this.VisitsField = value;
                    this.RaisePropertyChanged("Visits");
                }
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
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Visit", Namespace="http://schemas.datacontract.org/2004/07/TurnstileWcfService")]
    [System.SerializableAttribute()]
    public partial class Visit : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime VisitDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int VisitTypeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private TurnstileServer.TurnstileService.Visitor VisitorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<int> Visitor_IdField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime VisitDate {
            get {
                return this.VisitDateField;
            }
            set {
                if ((this.VisitDateField.Equals(value) != true)) {
                    this.VisitDateField = value;
                    this.RaisePropertyChanged("VisitDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int VisitType {
            get {
                return this.VisitTypeField;
            }
            set {
                if ((this.VisitTypeField.Equals(value) != true)) {
                    this.VisitTypeField = value;
                    this.RaisePropertyChanged("VisitType");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public TurnstileServer.TurnstileService.Visitor Visitor {
            get {
                return this.VisitorField;
            }
            set {
                if ((object.ReferenceEquals(this.VisitorField, value) != true)) {
                    this.VisitorField = value;
                    this.RaisePropertyChanged("Visitor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<int> Visitor_Id {
            get {
                return this.Visitor_IdField;
            }
            set {
                if ((this.Visitor_IdField.Equals(value) != true)) {
                    this.Visitor_IdField = value;
                    this.RaisePropertyChanged("Visitor_Id");
                }
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TurnstileService.IServiceVisit")]
    public interface IServiceVisit {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVisit/CheckValidation", ReplyAction="http://tempuri.org/IServiceVisit/CheckValidationResponse")]
        bool CheckValidation(int PermitId, int EnterType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVisit/CheckValidation", ReplyAction="http://tempuri.org/IServiceVisit/CheckValidationResponse")]
        System.Threading.Tasks.Task<bool> CheckValidationAsync(int PermitId, int EnterType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVisit/AllVisitors", ReplyAction="http://tempuri.org/IServiceVisit/AllVisitorsResponse")]
        TurnstileServer.TurnstileService.Visitor[] AllVisitors();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceVisit/AllVisitors", ReplyAction="http://tempuri.org/IServiceVisit/AllVisitorsResponse")]
        System.Threading.Tasks.Task<TurnstileServer.TurnstileService.Visitor[]> AllVisitorsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceVisitChannel : TurnstileServer.TurnstileService.IServiceVisit, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceVisitClient : System.ServiceModel.ClientBase<TurnstileServer.TurnstileService.IServiceVisit>, TurnstileServer.TurnstileService.IServiceVisit {
        
        public ServiceVisitClient() {
        }
        
        public ServiceVisitClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceVisitClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceVisitClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceVisitClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool CheckValidation(int PermitId, int EnterType) {
            return base.Channel.CheckValidation(PermitId, EnterType);
        }
        
        public System.Threading.Tasks.Task<bool> CheckValidationAsync(int PermitId, int EnterType) {
            return base.Channel.CheckValidationAsync(PermitId, EnterType);
        }
        
        public TurnstileServer.TurnstileService.Visitor[] AllVisitors() {
            return base.Channel.AllVisitors();
        }
        
        public System.Threading.Tasks.Task<TurnstileServer.TurnstileService.Visitor[]> AllVisitorsAsync() {
            return base.Channel.AllVisitorsAsync();
        }
    }
}
