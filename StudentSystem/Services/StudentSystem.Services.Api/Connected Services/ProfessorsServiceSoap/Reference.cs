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
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseResponseModel", Namespace="http://schemas.datacontract.org/2004/07/StudentSystem.Services.Models.Web.Base")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(StudentSystem.Services.Api.ProfessorsServiceSoap.SemesterResponseModel))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(StudentSystem.Services.Api.ProfessorsServiceSoap.DisciplineResponseModel))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(StudentSystem.Services.Api.ProfessorsServiceSoap.ScoreResponseModel))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(StudentSystem.Services.Api.ProfessorsServiceSoap.StudentResponseModel))]
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SemesterResponseModel", Namespace="http://schemas.datacontract.org/2004/07/StudentSystem.Services.Models.Web.Semeste" +
        "rs")]
    [System.SerializableAttribute()]
    public partial class SemesterResponseModel : StudentSystem.Services.Api.ProfessorsServiceSoap.BaseResponseModel {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private StudentSystem.Services.Api.ProfessorsServiceSoap.DisciplineResponseModel[] DisciplinesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EndDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime StartDateField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public StudentSystem.Services.Api.ProfessorsServiceSoap.DisciplineResponseModel[] Disciplines {
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
    public partial class DisciplineResponseModel : StudentSystem.Services.Api.ProfessorsServiceSoap.BaseResponseModel {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorResponseModel ProfessorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProfessorIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private StudentSystem.Services.Api.ProfessorsServiceSoap.ScoreResponseModel[] ScoresField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private StudentSystem.Services.Api.ProfessorsServiceSoap.SemesterResponseModel SemesterField;
        
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
        public StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorResponseModel Professor {
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
        public StudentSystem.Services.Api.ProfessorsServiceSoap.ScoreResponseModel[] Scores {
            get {
                return this.ScoresField;
            }
            set {
                if ((object.ReferenceEquals(this.ScoresField, value) != true)) {
                    this.ScoresField = value;
                    this.RaisePropertyChanged("Scores");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public StudentSystem.Services.Api.ProfessorsServiceSoap.SemesterResponseModel Semester {
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ScoreResponseModel", Namespace="http://schemas.datacontract.org/2004/07/StudentSystem.Services.Models.Web.Scores")]
    [System.SerializableAttribute()]
    public partial class ScoreResponseModel : StudentSystem.Services.Api.ProfessorsServiceSoap.BaseResponseModel {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DisciplineIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float MarkField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private StudentSystem.Services.Api.ProfessorsServiceSoap.StudentResponseModel StudentField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StudentIdField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DisciplineId {
            get {
                return this.DisciplineIdField;
            }
            set {
                if ((this.DisciplineIdField.Equals(value) != true)) {
                    this.DisciplineIdField = value;
                    this.RaisePropertyChanged("DisciplineId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public float Mark {
            get {
                return this.MarkField;
            }
            set {
                if ((this.MarkField.Equals(value) != true)) {
                    this.MarkField = value;
                    this.RaisePropertyChanged("Mark");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public StudentSystem.Services.Api.ProfessorsServiceSoap.StudentResponseModel Student {
            get {
                return this.StudentField;
            }
            set {
                if ((object.ReferenceEquals(this.StudentField, value) != true)) {
                    this.StudentField = value;
                    this.RaisePropertyChanged("Student");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int StudentId {
            get {
                return this.StudentIdField;
            }
            set {
                if ((this.StudentIdField.Equals(value) != true)) {
                    this.StudentIdField = value;
                    this.RaisePropertyChanged("StudentId");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StudentResponseModel", Namespace="http://schemas.datacontract.org/2004/07/StudentSystem.Services.Models.Web.Student" +
        "s")]
    [System.SerializableAttribute()]
    public partial class StudentResponseModel : StudentSystem.Services.Api.ProfessorsServiceSoap.BaseResponseModel {
        
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ProfessorResponseModel", Namespace="http://schemas.datacontract.org/2004/07/StudentSystem.Services.Models.Web.Profess" +
        "ors")]
    [System.SerializableAttribute()]
    public partial class ProfessorResponseModel : StudentSystem.Services.Api.ProfessorsServiceSoap.BaseResponseModel {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private StudentSystem.Services.Api.ProfessorsServiceSoap.DisciplineResponseModel[] DisciplinesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FirstNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string LastNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public StudentSystem.Services.Api.ProfessorsServiceSoap.DisciplineResponseModel[] Disciplines {
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ProfessorsServiceSoap.IProfessorsService")]
    public interface IProfessorsService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorsService/Create", ReplyAction="http://tempuri.org/IProfessorsService/CreateResponse")]
        StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorResponseModel Create(StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorRequestModel request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorsService/Create", ReplyAction="http://tempuri.org/IProfessorsService/CreateResponse")]
        System.Threading.Tasks.Task<StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorResponseModel> CreateAsync(StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorRequestModel request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorsService/Get", ReplyAction="http://tempuri.org/IProfessorsService/GetResponse")]
        StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorResponseModel Get(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorsService/Get", ReplyAction="http://tempuri.org/IProfessorsService/GetResponse")]
        System.Threading.Tasks.Task<StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorResponseModel> GetAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorsService/All", ReplyAction="http://tempuri.org/IProfessorsService/AllResponse")]
        StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorResponseModel[] All();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorsService/All", ReplyAction="http://tempuri.org/IProfessorsService/AllResponse")]
        System.Threading.Tasks.Task<StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorResponseModel[]> AllAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorsService/Update", ReplyAction="http://tempuri.org/IProfessorsService/UpdateResponse")]
        StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorResponseModel Update(int id, StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorRequestModel request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IProfessorsService/Update", ReplyAction="http://tempuri.org/IProfessorsService/UpdateResponse")]
        System.Threading.Tasks.Task<StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorResponseModel> UpdateAsync(int id, StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorRequestModel request);
        
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
        
        public StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorResponseModel Create(StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorRequestModel request) {
            return base.Channel.Create(request);
        }
        
        public System.Threading.Tasks.Task<StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorResponseModel> CreateAsync(StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorRequestModel request) {
            return base.Channel.CreateAsync(request);
        }
        
        public StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorResponseModel Get(int id) {
            return base.Channel.Get(id);
        }
        
        public System.Threading.Tasks.Task<StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorResponseModel> GetAsync(int id) {
            return base.Channel.GetAsync(id);
        }
        
        public StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorResponseModel[] All() {
            return base.Channel.All();
        }
        
        public System.Threading.Tasks.Task<StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorResponseModel[]> AllAsync() {
            return base.Channel.AllAsync();
        }
        
        public StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorResponseModel Update(int id, StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorRequestModel request) {
            return base.Channel.Update(id, request);
        }
        
        public System.Threading.Tasks.Task<StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorResponseModel> UpdateAsync(int id, StudentSystem.Services.Api.ProfessorsServiceSoap.ProfessorRequestModel request) {
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
