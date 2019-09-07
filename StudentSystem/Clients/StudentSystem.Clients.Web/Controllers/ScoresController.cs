namespace StudentSystem.Clients.Web.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    using AutoMapper;

    using StudentSystem.Clients.Web.Attributes;
    using StudentSystem.Clients.Web.Models.Scores;
    using StudentSystem.Services.Api.Contracts;
    using StudentSystem.Services.Api.ScoresServiceSoap;

    public class ScoresController : Controller
    {
        private readonly IStudentSystemApi studentSystemApi;
        private readonly ScoresServiceClient scoresClient;

        public ScoresController(IStudentSystemApi studentSystemApi, ScoresServiceClient scoresClient)
        {
            this.studentSystemApi = studentSystemApi;
            this.scoresClient = scoresClient;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            IEnumerable<ScoreResponseModel> response = await studentSystemApi.Execute(scoresClient.AllAsync);
            IEnumerable<ScoreResponseViewModel> scores = Mapper.Map<IEnumerable<ScoreResponseViewModel>>(response);

            return View(scores);
        }

        [HttpPost]
        [AjaxOnly]
        public async Task<JsonResult> Create(ScoreRequestViewModel viewRequest)
        {
            ScoreRequestModel request = Mapper.Map<ScoreRequestModel>(viewRequest);
            ScoreResponseModel response = await studentSystemApi.Execute(scoresClient.CreateAsync, request);

            ScoreResponseViewModel viewResponse = Mapper.Map<ScoreResponseViewModel>(response);

            return Json(viewResponse);
        }
    }
}