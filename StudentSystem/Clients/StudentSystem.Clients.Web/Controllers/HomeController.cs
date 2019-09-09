namespace StudentSystem.Clients.Web.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    using AutoMapper;

    using StudentSystem.Clients.Web.Models.Home;
    using StudentSystem.Services.Api.Contracts;
    using StudentSystem.Services.Api.ReportsServiceSoap;
 
    public class HomeController : Controller
    {
        private readonly IStudentSystemApi studentSystemApi;
        private readonly ReportsServiceClient reportsClient;

        public HomeController(IStudentSystemApi studentSystemApi, ReportsServiceClient reportsClient)
        {
            this.studentSystemApi = studentSystemApi;
            this.reportsClient = reportsClient;
        }

        public async Task<ActionResult> Index()
        {
            IEnumerable<SemesterResponseModel> response = await studentSystemApi.Execute(reportsClient.GetStemestersAsync);
            IEnumerable<ReportSemesterViewModel> viewModel = Mapper.Map<IEnumerable<ReportSemesterViewModel>>(response);

            return View(viewModel);
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