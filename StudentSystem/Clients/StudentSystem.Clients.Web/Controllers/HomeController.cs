namespace StudentSystem.Clients.Web.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    using StudentSystem.Services.Api.Contracts;
    using StudentSystem.Services.Api.StudentsServiceSoap;

    public class HomeController : Controller
    {
        private readonly IStudentSystemApi studentSystemApi;

        public HomeController(IStudentSystemApi studentSystemApi)
        {
            this.studentSystemApi = studentSystemApi;
        }

        public async Task<ActionResult> Index()
        {
            IEnumerable<SemesterResponseModel> response = await studentSystemApi.GetStudentDetailsAsync();

            return View();
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