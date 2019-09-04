namespace StudentSystem.Data.Queries.Common
{
    using StudentSystem.Data.Contracts.Queries;
    using StudentSystem.Data.Models.Base;

    public class EntityByIdQuery<TEntity> : IQuery<TEntity>
        where TEntity : BaseModel
    {
        public EntityByIdQuery(string table, int id)
        {
            Table = table;
            Id = id;
        }

        public string Table { get; set; }

        public int Id { get; set; }
    }
}