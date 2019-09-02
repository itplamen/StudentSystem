namespace StudentSystem.Clients.Web.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    using StudentSystem.Clients.Web.Builders;
    using StudentSystem.Clients.Web.Models.Home;
    using StudentSystem.Services.Api.Contracts;
    using StudentSystem.Services.Api.StudentsServiceSoap;

    public class HomeController : Controller
    {
        private readonly IStudentSystemApi studentSystemApi;
        private readonly StudentsServiceClient studentsClient;

        public HomeController(IStudentSystemApi studentSystemApi, StudentsServiceClient studentsClient)
        {
            this.studentSystemApi = studentSystemApi;
            this.studentsClient = studentsClient;
        }

        public async Task<ActionResult> Index()
        {
            IEnumerable<SemesterResponseModel> response = await studentSystemApi.Execute(studentsClient.GetAsync);
            IEnumerable<StudentViewModel> studentViewModels = StudentsBuilder.Build(response);

            return View(studentViewModels);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}