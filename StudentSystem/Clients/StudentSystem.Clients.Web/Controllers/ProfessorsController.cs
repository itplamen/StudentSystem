﻿namespace StudentSystem.Clients.Web.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    using AutoMapper;

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
            IEnumerable<ProfessorResponseModel> response = await studentSystemApi.Execute(professorsClient.AllAsync);
            IEnumerable<ProfessorResponseViewModel> professors = Mapper.Map<IEnumerable<ProfessorResponseViewModel>>(response);

            return View(professors);
        }

        [HttpPost]
        [AjaxOnly]
        public async Task<JsonResult> Create(ProfessorRequestViewModel viewRequest)
        {
            ProfessorRequestModel request = Mapper.Map<ProfessorRequestModel>(viewRequest);
            ProfessorResponseModel response = await studentSystemApi.Execute(professorsClient.CreateAsync, request);

            ProfessorResponseViewModel viewResponse = Mapper.Map<ProfessorResponseViewModel>(response);

            return Json(viewResponse);
        }

        [HttpGet]
        [AjaxOnly]
        public async Task<JsonResult> Get(int id)
        {
            ProfessorResponseModel response = await studentSystemApi.Execute(professorsClient.GetAsync, id);

            if (response == null)
            {
                return Json(new ProfessorResponseViewModel(), JsonRequestBehavior.AllowGet);
            }

            ProfessorResponseViewModel viewResponse = Mapper.Map<ProfessorResponseViewModel>(response);

            return Json(viewResponse, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        [AjaxOnly]
        public async Task<JsonResult> Update(int id, ProfessorRequestViewModel viewRequest)
        {
            ProfessorRequestModel request = Mapper.Map<ProfessorRequestModel>(viewRequest);
            ProfessorResponseModel response = await studentSystemApi.Execute(professorsClient.UpdateAsync, id, request);

            ProfessorResponseViewModel viewResponse = Mapper.Map<ProfessorResponseViewModel>(response);

            return Json(viewResponse);
        }

        [HttpPost]
        [AjaxOnly]
        public async Task<JsonResult> Delete(int id)
        {
            bool response = await studentSystemApi.Execute(professorsClient.DeleteAsync, id);

            return Json(response);
        }
     }
}