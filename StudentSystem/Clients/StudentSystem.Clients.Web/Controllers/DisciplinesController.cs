﻿namespace StudentSystem.Clients.Web.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using System.Web.Mvc;

    using AutoMapper;

    using StudentSystem.Clients.Web.Models.Disciplines;
    using StudentSystem.Services.Api.Contracts;
    using StudentSystem.Services.Api.DisciplinesServiceSoap;

    public class DisciplinesController : Controller
    {
        private readonly IStudentSystemApi studentSystemApi;
        private readonly DisciplinesServiceClient disciplinesClient;

        public DisciplinesController(IStudentSystemApi studentSystemApi, DisciplinesServiceClient disciplinesClient)
        {
            this.studentSystemApi = studentSystemApi;
            this.disciplinesClient = disciplinesClient;
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            IEnumerable<DisciplineResponseModel> response = await studentSystemApi.Execute(disciplinesClient.AllAsync);
            IEnumerable<DisciplineResponseViewModel> disciplines = Mapper.Map<IEnumerable<DisciplineResponseViewModel>>(response);

            return View(disciplines);
        }
    }
}