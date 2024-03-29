﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentSystem.Services.Api.StudentsServiceSoap {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StudentRequestModel", Namespace="http://schemas.datacontract.org/2004/07/StudentSystem.Services.Models.Web.Student" +
        "s")]
    [System.SerializableAttribute()]
    public partial class StudentRequestModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateOfBirthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
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
        public System.DateTime DateOfBirth {
            get {
                return this.DateOfBirthField;
            }
            set {
                if ((this.DateOfBirthField.Equals(value) != true)) {
                    this.DateOfBirthField = value;
                    this.RaisePropertyChanged("DateOfBirth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
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
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseResponseModel", Namespace="http://schemas.datacontract.org/2004/07/StudentSystem.Services.Models.Web.Base")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(StudentSystem.Services.Api.StudentsServiceSoap.StudentResponseModel))]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StudentResponseModel", Namespace="http://schemas.datacontract.org/2004/07/StudentSystem.Services.Models.Web.Student" +
        "s")]
    [System.SerializableAttribute()]
    public partial class StudentResponseModel : StudentSystem.Services.Api.StudentsServiceSoap.BaseResponseModel {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime DateOfBirthField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmailField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime DateOfBirth {
            get {
                return this.DateOfBirthField;
            }
            set {
                if ((this.DateOfBirthField.Equals(value) != true)) {
                    this.DateOfBirthField = value;
                    this.RaisePropertyChanged("DateOfBirth");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Email {
            get {
                return this.EmailField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailField, value) != true)) {
                    this.EmailField = value;
                    this.RaisePropertyChanged("Email");
                }
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
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StudentsServiceSoap.IStudentsService")]
    public interface IStudentsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentsService/Create", ReplyAction="http://tempuri.org/IStudentsService/CreateResponse")]
        StudentSystem.Services.Api.StudentsServiceSoap.StudentResponseModel Create(StudentSystem.Services.Api.StudentsServiceSoap.StudentRequestModel request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentsService/Create", ReplyAction="http://tempuri.org/IStudentsService/CreateResponse")]
        System.Threading.Tasks.Task<StudentSystem.Services.Api.StudentsServiceSoap.StudentResponseModel> CreateAsync(StudentSystem.Services.Api.StudentsServiceSoap.StudentRequestModel request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentsService/All", ReplyAction="http://tempuri.org/IStudentsService/AllResponse")]
        StudentSystem.Services.Api.StudentsServiceSoap.StudentResponseModel[] All();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentsService/All", ReplyAction="http://tempuri.org/IStudentsService/AllResponse")]
        System.Threading.Tasks.Task<StudentSystem.Services.Api.StudentsServiceSoap.StudentResponseModel[]> AllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentsService/Update", ReplyAction="http://tempuri.org/IStudentsService/UpdateResponse")]
        StudentSystem.Services.Api.StudentsServiceSoap.StudentResponseModel Update(int id, StudentSystem.Services.Api.StudentsServiceSoap.StudentRequestModel request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentsService/Update", ReplyAction="http://tempuri.org/IStudentsService/UpdateResponse")]
        System.Threading.Tasks.Task<StudentSystem.Services.Api.StudentsServiceSoap.StudentResponseModel> UpdateAsync(int id, StudentSystem.Services.Api.StudentsServiceSoap.StudentRequestModel request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentsService/Delete", ReplyAction="http://tempuri.org/IStudentsService/DeleteResponse")]
        bool Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentsService/Delete", ReplyAction="http://tempuri.org/IStudentsService/DeleteResponse")]
        System.Threading.Tasks.Task<bool> DeleteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStudentsServiceChannel : StudentSystem.Services.Api.StudentsServiceSoap.IStudentsService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StudentsServiceClient : System.ServiceModel.ClientBase<StudentSystem.Services.Api.StudentsServiceSoap.IStudentsService>, StudentSystem.Services.Api.StudentsServiceSoap.IStudentsService {
        
        public StudentsServiceClient() {
        }
        
        public StudentsServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StudentsServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentsServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentsServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public StudentSystem.Services.Api.StudentsServiceSoap.StudentResponseModel Create(StudentSystem.Services.Api.StudentsServiceSoap.StudentRequestModel request) {
            return base.Channel.Create(request);
        }
        
        public System.Threading.Tasks.Task<StudentSystem.Services.Api.StudentsServiceSoap.StudentResponseModel> CreateAsync(StudentSystem.Services.Api.StudentsServiceSoap.StudentRequestModel request) {
            return base.Channel.CreateAsync(request);
        }
        
        public StudentSystem.Services.Api.StudentsServiceSoap.StudentResponseModel[] All() {
            return base.Channel.All();
        }
        
        public System.Threading.Tasks.Task<StudentSystem.Services.Api.StudentsServiceSoap.StudentResponseModel[]> AllAsync() {
            return base.Channel.AllAsync();
        }
        
        public StudentSystem.Services.Api.StudentsServiceSoap.StudentResponseModel Update(int id, StudentSystem.Services.Api.StudentsServiceSoap.StudentRequestModel request) {
            return base.Channel.Update(id, request);
        }
        
        public System.Threading.Tasks.Task<StudentSystem.Services.Api.StudentsServiceSoap.StudentResponseModel> UpdateAsync(int id, StudentSystem.Services.Api.StudentsServiceSoap.StudentRequestModel request) {
            return base.Channel.UpdateAsync(id, request);
        }
        
        public bool Delete(int id) {
            return base.Channel.Delete(id);
        }
        
        public System.Threading.Tasks.Task<bool> DeleteAsync(int id) {
            return base.Channel.DeleteAsync(id);
        }
    }
}
