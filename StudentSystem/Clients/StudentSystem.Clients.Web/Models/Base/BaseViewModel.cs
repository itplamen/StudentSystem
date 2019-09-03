namespace StudentSystem.Clients.Web.Models.Base
{
    using System;

    using StudentSystem.Common.Infrastructure.Mapping;
    using StudentSystem.Services.Api.DisciplinesServiceSoap;

    public abstract class BaseViewModel : IMapFrom<BaseResponseModel>
    {
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? DeletedOn { get; set; }
    }
}