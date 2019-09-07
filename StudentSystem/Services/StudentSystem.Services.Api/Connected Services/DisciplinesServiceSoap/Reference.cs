﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentSystem.Services.Api.DisciplinesServiceSoap {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DisciplineRequestModel", Namespace="http://schemas.datacontract.org/2004/07/StudentSystem.Services.Models.Web.Discipl" +
        "ines")]
    [System.SerializableAttribute()]
    public partial class DisciplineRequestModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProfessorIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SemesterIdField;
        
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
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProfessorId {
            get {
                return this.ProfessorIdField;
            }
            set {
                if ((this.ProfessorIdField.Equals(value) != true)) {
                    this.ProfessorIdField = value;
                    this.RaisePropertyChanged("ProfessorId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SemesterId {
            get {
                return this.SemesterIdField;
            }
            set {
                if ((this.SemesterIdField.Equals(value) != true)) {
                    this.SemesterIdField = value;
                    this.RaisePropertyChanged("SemesterId");
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
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(StudentSystem.Services.Api.DisciplinesServiceSoap.ProfessorResponseModel))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(StudentSystem.Services.Api.DisciplinesServiceSoap.SemesterResponseModel))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(StudentSystem.Services.Api.DisciplinesServiceSoap.DisciplineResponseModel))]
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ProfessorResponseModel", Namespace="http://schemas.datacontract.org/2004/07/StudentSystem.Services.Models.Web.Profess" +
        "ors")]
    [System.SerializableAttribute()]
    public partial class ProfessorResponseModel : StudentSystem.Services.Api.DisciplinesServiceSoap.BaseResponseModel {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private StudentSystem.Services.Api.DisciplinesServiceSoap.DisciplineResponseModel[] DisciplinesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public StudentSystem.Services.Api.DisciplinesServiceSoap.DisciplineResponseModel[] Disciplines {
            get {
                return this.DisciplinesField;
            }
            set {
                if ((object.ReferenceEquals(this.DisciplinesField, value) != true)) {
                    this.DisciplinesField = value;
                    this.RaisePropertyChanged("Disciplines");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SemesterResponseModel", Namespace="http://schemas.datacontract.org/2004/07/StudentSystem.Services.Models.Web.Semeste" +
        "rs")]
    [System.SerializableAttribute()]
    public partial class SemesterResponseModel : StudentSystem.Services.Api.DisciplinesServiceSoap.BaseResponseModel {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EndDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime StartDateField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime EndDate {
            get {
                return this.EndDateField;
            }
            set {
                if ((this.EndDateField.Equals(value) != true)) {
                    this.EndDateField = value;
                    this.RaisePropertyChanged("EndDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime StartDate {
            get {
                return this.StartDateField;
            }
            set {
                if ((this.StartDateField.Equals(value) != true)) {
                    this.StartDateField = value;
                    this.RaisePropertyChanged("StartDate");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="DisciplineResponseModel", Namespace="http://schemas.datacontract.org/2004/07/StudentSystem.Services.Models.Web.Discipl" +
        "ines")]
    [System.SerializableAttribute()]
    public partial class DisciplineResponseModel : StudentSystem.Services.Api.DisciplinesServiceSoap.BaseResponseModel {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private StudentSystem.Services.Api.DisciplinesServiceSoap.ProfessorResponseModel ProfessorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProfessorIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private StudentSystem.Services.Api.DisciplinesServiceSoap.SemesterResponseModel SemesterField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SemesterIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public StudentSystem.Services.Api.DisciplinesServiceSoap.ProfessorResponseModel Professor {
            get {
                return this.ProfessorField;
            }
            set {
                if ((object.ReferenceEquals(this.ProfessorField, value) != true)) {
                    this.ProfessorField = value;
                    this.RaisePropertyChanged("Professor");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ProfessorId {
            get {
                return this.ProfessorIdField;
            }
            set {
                if ((this.ProfessorIdField.Equals(value) != true)) {
                    this.ProfessorIdField = value;
                    this.RaisePropertyChanged("ProfessorId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public StudentSystem.Services.Api.DisciplinesServiceSoap.SemesterResponseModel Semester {
            get {
                return this.SemesterField;
            }
            set {
                if ((object.ReferenceEquals(this.SemesterField, value) != true)) {
                    this.SemesterField = value;
                    this.RaisePropertyChanged("Semester");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SemesterId {
            get {
                return this.SemesterIdField;
            }
            set {
                if ((this.SemesterIdField.Equals(value) != true)) {
                    this.SemesterIdField = value;
                    this.RaisePropertyChanged("SemesterId");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="DisciplinesServiceSoap.IDisciplinesService")]
    public interface IDisciplinesService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDisciplinesService/Create", ReplyAction="http://tempuri.org/IDisciplinesService/CreateResponse")]
        StudentSystem.Services.Api.DisciplinesServiceSoap.DisciplineResponseModel Create(StudentSystem.Services.Api.DisciplinesServiceSoap.DisciplineRequestModel request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDisciplinesService/Create", ReplyAction="http://tempuri.org/IDisciplinesService/CreateResponse")]
        System.Threading.Tasks.Task<StudentSystem.Services.Api.DisciplinesServiceSoap.DisciplineResponseModel> CreateAsync(StudentSystem.Services.Api.DisciplinesServiceSoap.DisciplineRequestModel request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDisciplinesService/All", ReplyAction="http://tempuri.org/IDisciplinesService/AllResponse")]
        StudentSystem.Services.Api.DisciplinesServiceSoap.DisciplineResponseModel[] All();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDisciplinesService/All", ReplyAction="http://tempuri.org/IDisciplinesService/AllResponse")]
        System.Threading.Tasks.Task<StudentSystem.Services.Api.DisciplinesServiceSoap.DisciplineResponseModel[]> AllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDisciplinesService/Update", ReplyAction="http://tempuri.org/IDisciplinesService/UpdateResponse")]
        StudentSystem.Services.Api.DisciplinesServiceSoap.DisciplineResponseModel Update(int id, StudentSystem.Services.Api.DisciplinesServiceSoap.DisciplineRequestModel request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDisciplinesService/Update", ReplyAction="http://tempuri.org/IDisciplinesService/UpdateResponse")]
        System.Threading.Tasks.Task<StudentSystem.Services.Api.DisciplinesServiceSoap.DisciplineResponseModel> UpdateAsync(int id, StudentSystem.Services.Api.DisciplinesServiceSoap.DisciplineRequestModel request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDisciplinesService/Delete", ReplyAction="http://tempuri.org/IDisciplinesService/DeleteResponse")]
        bool Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IDisciplinesService/Delete", ReplyAction="http://tempuri.org/IDisciplinesService/DeleteResponse")]
        System.Threading.Tasks.Task<bool> DeleteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IDisciplinesServiceChannel : StudentSystem.Services.Api.DisciplinesServiceSoap.IDisciplinesService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class DisciplinesServiceClient : System.ServiceModel.ClientBase<StudentSystem.Services.Api.DisciplinesServiceSoap.IDisciplinesService>, StudentSystem.Services.Api.DisciplinesServiceSoap.IDisciplinesService {
        
        public DisciplinesServiceClient() {
        }
        
        public DisciplinesServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public DisciplinesServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DisciplinesServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public DisciplinesServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public StudentSystem.Services.Api.DisciplinesServiceSoap.DisciplineResponseModel Create(StudentSystem.Services.Api.DisciplinesServiceSoap.DisciplineRequestModel request) {
            return base.Channel.Create(request);
        }
        
        public System.Threading.Tasks.Task<StudentSystem.Services.Api.DisciplinesServiceSoap.DisciplineResponseModel> CreateAsync(StudentSystem.Services.Api.DisciplinesServiceSoap.DisciplineRequestModel request) {
            return base.Channel.CreateAsync(request);
        }
        
        public StudentSystem.Services.Api.DisciplinesServiceSoap.DisciplineResponseModel[] All() {
            return base.Channel.All();
        }
        
        public System.Threading.Tasks.Task<StudentSystem.Services.Api.DisciplinesServiceSoap.DisciplineResponseModel[]> AllAsync() {
            return base.Channel.AllAsync();
        }
        
        public StudentSystem.Services.Api.DisciplinesServiceSoap.DisciplineResponseModel Update(int id, StudentSystem.Services.Api.DisciplinesServiceSoap.DisciplineRequestModel request) {
            return base.Channel.Update(id, request);
        }
        
        public System.Threading.Tasks.Task<StudentSystem.Services.Api.DisciplinesServiceSoap.DisciplineResponseModel> UpdateAsync(int id, StudentSystem.Services.Api.DisciplinesServiceSoap.DisciplineRequestModel request) {
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
