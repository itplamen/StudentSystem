﻿namespace StudentSystem.Clients.Web.Models.Professors
{
    using System.Collections.Generic;

    using StudentSystem.Clients.Web.Models.Base;
    using StudentSystem.Common.Infrastructure.Mapping;
    using StudentSystem.Services.Api.ProfessorsServiceSoap;
    
    public class ProfessorResponseViewModel : BaseViewModel, IMapFrom<ProfessorResponseModel>
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public IEnumerable<ProfessorDisciplinesViewModel> Disciplines { get; set; }
    }
}