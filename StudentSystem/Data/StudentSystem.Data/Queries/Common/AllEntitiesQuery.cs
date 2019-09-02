namespace StudentSystem.Data.Queries.Common
{
    using System.Collections.Generic;

    using StudentSystem.Data.Contracts.Queries;
    using StudentSystem.Data.Models.Base;

    public class AllEntitiesQuery<TEntity> : IQuery<IEnumerable<TEntity>>
        where TEntity : BaseModel
    {
        public AllEntitiesQuery(string table, bool withDeleted)
        {
            Table = table;
            WithDeleted = withDeleted;
        }

        public string Table { get; set; }

        public bool WithDeleted { get; set; }
    }
}