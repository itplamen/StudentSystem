namespace StudentSystem.Clients.Web.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    using AutoMapper;

    using StudentSystem.Clients.Web.Models.Semesters;
    using StudentSystem.Services.Api.Contracts;
    using StudentSystem.Services.Api.SemestersServiceSoap;

    public class SemestersController : Controller
    {
        private readonly IStudentSystemApi studentSystemApi;
        private readonly SemestersServiceClient semestersClient;

        public SemestersController(IStudentSystemApi studentSystemApi, SemestersServiceClient semestersClient)
        {
            this.studentSystemApi = studentSystemApi;
            this.semestersClient = semestersClient;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            IEnumerable<SemesterResponseModel> response = await studentSystemApi.Execute(semestersClient.AllAsync);
            IEnumerable<SemesterResponseViewModel> semesters = Mapper.Map<IEnumerable<SemesterResponseViewModel>>(response);

            return View(semesters);
        }
    }
}