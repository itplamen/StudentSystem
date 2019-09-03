﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentSystem.Services.Api.ProfessorsServiceSoap {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProfessorRequestModel", Namespace="http://schemas.datacontract.org/2004/07/StudentSystem.Services.Models.Web.Profess" +
        "ors")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(StudentSystem.Services.Api.ProfessorsServiceSoap.UpdateProfessorRequestModel))]
    public partial class ProfessorRequestModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UpdateProfessorRequestModel", Namespace="http://schemas.datacontract.org/2004/07/StudentSystem.Services.Models.Web.Profess" +
        "ors")]
    [System.SerializableAttribute()]
    public partial class UpdateProfessorRequestModel : StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorRequestModel {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
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
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProfessorResponseModel", Namespace="http://schemas.datacontract.org/2004/07/StudentSystem.Services.Models.Web.Profess" +
        "ors")]
    [System.SerializableAttribute()]
    public partial class ProfessorResponseModel : StudentSystem.Services.Api.ProfessorsServiceSoap.BaseResponseModel {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
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
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseResponseModel", Namespace="http://schemas.datacontract.org/2004/07/StudentSystem.Services.Models.Web.Base")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorResponseModel))]
    public partial class BaseResponseModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime CreatedOnField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> DeletedOnField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsDeletedField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.Nullable<System.DateTime> ModifiedOnField;
        
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
        public System.DateTime CreatedOn {
            get {
                return this.CreatedOnField;
            }
            set {
                if ((this.CreatedOnField.Equals(value) != true)) {
                    this.CreatedOnField = value;
                    this.RaisePropertyChanged("CreatedOn");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> DeletedOn {
            get {
                return this.DeletedOnField;
            }
            set {
                if ((this.DeletedOnField.Equals(value) != true)) {
                    this.DeletedOnField = value;
                    this.RaisePropertyChanged("DeletedOn");
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
        public bool IsDeleted {
            get {
                return this.IsDeletedField;
            }
            set {
                if ((this.IsDeletedField.Equals(value) != true)) {
                    this.IsDeletedField = value;
                    this.RaisePropertyChanged("IsDeleted");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Nullable<System.DateTime> ModifiedOn {
            get {
                return this.ModifiedOnField;
            }
            set {
                if ((this.ModifiedOnField.Equals(value) != true)) {
                    this.ModifiedOnField = value;
                    this.RaisePropertyChanged("ModifiedOn");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProfessorsServiceSoap.IProfessorsService")]
    public interface IProfessorsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorsService/Create", ReplyAction="http://tempuri.org/IProfessorsService/CreateResponse")]
        bool Create(StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorRequestModel request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorsService/Create", ReplyAction="http://tempuri.org/IProfessorsService/CreateResponse")]
        System.Threading.Tasks.Task<bool> CreateAsync(StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorRequestModel request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorsService/Get", ReplyAction="http://tempuri.org/IProfessorsService/GetResponse")]
        StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorResponseModel[] Get();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorsService/Get", ReplyAction="http://tempuri.org/IProfessorsService/GetResponse")]
        System.Threading.Tasks.Task<StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorResponseModel[]> GetAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorsService/Update", ReplyAction="http://tempuri.org/IProfessorsService/UpdateResponse")]
        bool Update(StudentSystem.Services.Api.ProfessorsServiceSoap.UpdateProfessorRequestModel request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorsService/Update", ReplyAction="http://tempuri.org/IProfessorsService/UpdateResponse")]
        System.Threading.Tasks.Task<bool> UpdateAsync(StudentSystem.Services.Api.ProfessorsServiceSoap.UpdateProfessorRequestModel request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorsService/Delete", ReplyAction="http://tempuri.org/IProfessorsService/DeleteResponse")]
        bool Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorsService/Delete", ReplyAction="http://tempuri.org/IProfessorsService/DeleteResponse")]
        System.Threading.Tasks.Task<bool> DeleteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IProfessorsServiceChannel : StudentSystem.Services.Api.ProfessorsServiceSoap.IProfessorsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ProfessorsServiceClient : System.ServiceModel.ClientBase<StudentSystem.Services.Api.ProfessorsServiceSoap.IProfessorsService>, StudentSystem.Services.Api.ProfessorsServiceSoap.IProfessorsService {
        
        public ProfessorsServiceClient() {
        }
        
        public ProfessorsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ProfessorsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProfessorsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ProfessorsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Create(StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorRequestModel request) {
            return base.Channel.Create(request);
        }
        
        public System.Threading.Tasks.Task<bool> CreateAsync(StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorRequestModel request) {
            return base.Channel.CreateAsync(request);
        }
        
        public StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorResponseModel[] Get() {
            return base.Channel.Get();
        }
        
        public System.Threading.Tasks.Task<StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorResponseModel[]> GetAsync() {
            return base.Channel.GetAsync();
        }
        
        public bool Update(StudentSystem.Services.Api.ProfessorsServiceSoap.UpdateProfessorRequestModel request) {
            return base.Channel.Update(request);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateAsync(StudentSystem.Services.Api.ProfessorsServiceSoap.UpdateProfessorRequestModel request) {
            return base.Channel.UpdateAsync(request);
        }
        
        public bool Delete(int id) {
            return base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
    }
}
