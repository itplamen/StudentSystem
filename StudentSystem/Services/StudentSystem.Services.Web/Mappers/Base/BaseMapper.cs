namespace StudentSystem.Services.Web.Mappers.Base
{
    using System.Collections.Generic;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Models.Base;
    using StudentSystem.Services.Models.Web.Base;

    public abstract class BaseMapper<TFrom, To> : IMapper<TFrom, To>
        where TFrom : BaseModel
        where To : BaseResponseModel
    {
        public abstract To Map(TFrom from);

        public IEnumerable<To> Map(IEnumerable<TFrom> from)
        {
            ICollection<To> responseModels = new List<To>();

            foreach (var dataModel in from)
            {
                To to = Map(dataModel);

                responseModels.Add(to);
            }

            return responseModels;
        }
    }
}