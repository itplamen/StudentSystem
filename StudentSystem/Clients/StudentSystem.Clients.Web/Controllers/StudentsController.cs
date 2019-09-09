namespace StudentSystem.Clients.Web.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    using AutoMapper;

    using StudentSystem.Clients.Web.Attributes;
    using StudentSystem.Clients.Web.Models.Students;
    using StudentSystem.Services.Api.Contracts;
    using StudentSystem.Services.Api.StudentsServiceSoap;

    public class StudentsController : Controller
    {
        private readonly IStudentSystemApi studentSystemApi;
        private readonly StudentsServiceClient studentsClient;

        public StudentsController(IStudentSystemApi studentSystemApi, StudentsServiceClient studentsClient)
        {
            this.studentSystemApi = studentSystemApi;
            this.studentsClient = studentsClient;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            IEnumerable<StudentResponseModel> response = await studentSystemApi.Execute(studentsClient.AllAsync);
            IEnumerable<StudentResponseViewModel> students = Mapper.Map<IEnumerable<StudentResponseViewModel>>(response);

            return View(students);
        }

        [HttpPost]
        [AjaxOnly]
        public async Task<JsonResult> Create(StudentRequestViewModel viewRequest)
        {
            StudentRequestModel request = Mapper.Map<StudentRequestModel>(viewRequest);
            StudentResponseModel response = await studentSystemApi.Execute(studentsClient.CreateAsync, request);

            StudentResponseModel viewResponse = Mapper.Map<StudentResponseModel>(response);

            return Json(viewResponse);
        }

        [HttpPost]
        [AjaxOnly]
        public async Task<JsonResult> Update(int id, StudentRequestViewModel viewRequest)
        {
            StudentRequestModel request = Mapper.Map<StudentRequestModel>(viewRequest);
            StudentResponseModel response = await studentSystemApi.Execute(studentsClient.UpdateAsync, id, request);

            StudentResponseModel viewResponse = Mapper.Map<StudentResponseModel>(response);

            return Json(viewResponse);
        }

        [HttpPost]
        [AjaxOnly]
        public async Task<JsonResult> Delete(int id)
        {
            bool response = await studentSystemApi.Execute(studentsClient.DeleteAsync, id);

            return Json(response);
        }
    }
}