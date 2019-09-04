namespace StudentSystem.Clients.Web.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    using AutoMapper;

    using Newtonsoft.Json;

    using StudentSystem.Clients.Web.Attributes;
    using StudentSystem.Clients.Web.Models.Professors;
    using StudentSystem.Services.Api.Contracts;
    using StudentSystem.Services.Api.ProfessorsServiceSoap;

    public class ProfessorsController : Controller
    {
        private readonly IStudentSystemApi studentSystemApi;
        private readonly ProfessorsServiceClient professorsClient;

        public ProfessorsController(IStudentSystemApi studentSystemApi, ProfessorsServiceClient professorsClient)
        {
            this.studentSystemApi = studentSystemApi;
            this.professorsClient = professorsClient;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            IEnumerable<ProfessorResponseModel> response = await studentSystemApi.Execute(professorsClient.GetAsync);
            IEnumerable<ProfessorViewModel> professors = Mapper.Map<IEnumerable<ProfessorViewModel>>(response);

            return View(professors);
        }

        [HttpPost]
        [AjaxOnly]
        public async Task<JsonResult> Create(ProfessorCreateViewModel viewModel)
        {
            ProfessorRequestModel request = Mapper.Map<ProfessorRequestModel>(viewModel);
            ProfessorResponseModel response = await studentSystemApi.Execute(professorsClient.CreateAsync, request);

            return Json(JsonConvert.SerializeObject(response));
        }
     }
}