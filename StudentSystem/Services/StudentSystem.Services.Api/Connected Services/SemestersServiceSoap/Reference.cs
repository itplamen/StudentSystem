﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentSystem.Services.Api.SemestersServiceSoap {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SemesterRequestModel", Namespace="http://schemas.datacontract.org/2004/07/StudentSystem.Services.Models.Web.Semeste" +
        "rs")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(StudentSystem.Services.Api.SemestersServiceSoap.UpdateSemesterRequestModel))]
    public partial class SemesterRequestModel : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EndDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime StartDateField;
        
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
    [System.Runtime.Serialization.DataContractAttribute(Name="UpdateSemesterRequestModel", Namespace="http://schemas.datacontract.org/2004/07/StudentSystem.Services.Models.Web.Semeste" +
        "rs")]
    [System.SerializableAttribute()]
    public partial class UpdateSemesterRequestModel : StudentSystem.Services.Api.SemestersServiceSoap.SemesterRequestModel {
        
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SemesterResponseModel", Namespace="http://schemas.datacontract.org/2004/07/StudentSystem.Services.Models.Web.Semeste" +
        "rs")]
    [System.SerializableAttribute()]
    public partial class SemesterResponseModel : StudentSystem.Services.Api.SemestersServiceSoap.BaseResponseModel {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private StudentSystem.Services.Api.SemestersServiceSoap.DisciplineResponseModel[] DisciplinesField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime EndDateField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime StartDateField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public StudentSystem.Services.Api.SemestersServiceSoap.DisciplineResponseModel[] Disciplines {
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
    [System.Runtime.Serialization.DataContractAttribute(Name="BaseResponseModel", Namespace="http://schemas.datacontract.org/2004/07/StudentSystem.Services.Models.Web.Base")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(StudentSystem.Services.Api.SemestersServiceSoap.ProfessorResponseModel))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(StudentSystem.Services.Api.SemestersServiceSoap.ScoreResponseModel))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(StudentSystem.Services.Api.SemestersServiceSoap.StudentResponseModel))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(StudentSystem.Services.Api.SemestersServiceSoap.DisciplineResponseModel))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(StudentSystem.Services.Api.SemestersServiceSoap.SemesterResponseModel))]
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
    public partial class ProfessorResponseModel : StudentSystem.Services.Api.SemestersServiceSoap.BaseResponseModel {
        
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ScoreResponseModel", Namespace="http://schemas.datacontract.org/2004/07/StudentSystem.Services.Models.Web.Scores")]
    [System.SerializableAttribute()]
    public partial class ScoreResponseModel : StudentSystem.Services.Api.SemestersServiceSoap.BaseResponseModel {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int DisciplineIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private float MarkField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private StudentSystem.Services.Api.SemestersServiceSoap.StudentResponseModel StudentField;
        
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
        public StudentSystem.Services.Api.SemestersServiceSoap.StudentResponseModel Student {
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
    public partial class StudentResponseModel : StudentSystem.Services.Api.SemestersServiceSoap.BaseResponseModel {
        
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
    [System.Runtime.Serialization.DataContractAttribute(Name="DisciplineResponseModel", Namespace="http://schemas.datacontract.org/2004/07/StudentSystem.Services.Models.Web.Discipl" +
        "ines")]
    [System.SerializableAttribute()]
    public partial class DisciplineResponseModel : StudentSystem.Services.Api.SemestersServiceSoap.BaseResponseModel {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private StudentSystem.Services.Api.SemestersServiceSoap.ProfessorResponseModel ProfessorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ProfessorIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private StudentSystem.Services.Api.SemestersServiceSoap.ScoreResponseModel[] ScoresField;
        
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
        public StudentSystem.Services.Api.SemestersServiceSoap.ProfessorResponseModel Professor {
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
        public StudentSystem.Services.Api.SemestersServiceSoap.ScoreResponseModel[] Scores {
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SemestersServiceSoap.ISemestersService")]
    public interface ISemestersService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISemestersService/Create", ReplyAction="http://tempuri.org/ISemestersService/CreateResponse")]
        bool Create(StudentSystem.Services.Api.SemestersServiceSoap.SemesterRequestModel request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISemestersService/Create", ReplyAction="http://tempuri.org/ISemestersService/CreateResponse")]
        System.Threading.Tasks.Task<bool> CreateAsync(StudentSystem.Services.Api.SemestersServiceSoap.SemesterRequestModel request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISemestersService/Get", ReplyAction="http://tempuri.org/ISemestersService/GetResponse")]
        StudentSystem.Services.Api.SemestersServiceSoap.SemesterResponseModel[] Get();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISemestersService/Get", ReplyAction="http://tempuri.org/ISemestersService/GetResponse")]
        System.Threading.Tasks.Task<StudentSystem.Services.Api.SemestersServiceSoap.SemesterResponseModel[]> GetAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISemestersService/Update", ReplyAction="http://tempuri.org/ISemestersService/UpdateResponse")]
        bool Update(StudentSystem.Services.Api.SemestersServiceSoap.UpdateSemesterRequestModel request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISemestersService/Update", ReplyAction="http://tempuri.org/ISemestersService/UpdateResponse")]
        System.Threading.Tasks.Task<bool> UpdateAsync(StudentSystem.Services.Api.SemestersServiceSoap.UpdateSemesterRequestModel request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISemestersService/Delete", ReplyAction="http://tempuri.org/ISemestersService/DeleteResponse")]
        bool Delete(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ISemestersService/Delete", ReplyAction="http://tempuri.org/ISemestersService/DeleteResponse")]
        System.Threading.Tasks.Task<bool> DeleteAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ISemestersServiceChannel : StudentSystem.Services.Api.SemestersServiceSoap.ISemestersService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SemestersServiceClient : System.ServiceModel.ClientBase<StudentSystem.Services.Api.SemestersServiceSoap.ISemestersService>, StudentSystem.Services.Api.SemestersServiceSoap.ISemestersService {
        
        public SemestersServiceClient() {
        }
        
        public SemestersServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SemestersServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SemestersServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SemestersServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Create(StudentSystem.Services.Api.SemestersServiceSoap.SemesterRequestModel request) {
            return base.Channel.Create(request);
        }
        
        public System.Threading.Tasks.Task<bool> CreateAsync(StudentSystem.Services.Api.SemestersServiceSoap.SemesterRequestModel request) {
            return base.Channel.CreateAsync(request);
        }
        
        public StudentSystem.Services.Api.SemestersServiceSoap.SemesterResponseModel[] Get() {
            return base.Channel.Get();
        }
        
        public System.Threading.Tasks.Task<StudentSystem.Services.Api.SemestersServiceSoap.SemesterResponseModel[]> GetAsync() {
            return base.Channel.GetAsync();
        }
        
        public bool Update(StudentSystem.Services.Api.SemestersServiceSoap.UpdateSemesterRequestModel request) {
            return base.Channel.Update(request);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateAsync(StudentSystem.Services.Api.SemestersServiceSoap.UpdateSemesterRequestModel request) {
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
