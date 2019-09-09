using StudentSystem.Services.Models.Web.Semesters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace StudentSystem.Services.Web.Contracts
{
    [ServiceContract]
    public interface IReportsService
    {
        [OperationContract]
        IEnumerable<SemesterResponseModel> GetStemesters();
    }
}
