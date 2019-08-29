﻿namespace StudentSystem.Services.Web.Contracts
{
    using System.Collections.Generic;
    using System.ServiceModel;
    using System.ServiceModel.Web;

    using StudentSystem.Services.Models.Web;

    [ServiceContract]
    public interface IStudentsService
    {
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        [OperationContract]
        IEnumerable<StudentModel> GetAll();
    }
}