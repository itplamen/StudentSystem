namespace StudentSystem.Data.Builders.StudentDetails
{
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Contracts.Builders;
    using StudentSystem.Data.Models;

    public class ProfessorsBuilder : IBuilder<SqlDataReader, Professor>
    {
        private readonly IMapper<SqlDataReader, Professor> professorsMapper;

        public ProfessorsBuilder(IMapper<SqlDataReader, Professor> professorsMapper)
        {
            this.professorsMapper = professorsMapper;
        }

        public IEnumerable<Professor> Build(IEnumerable<SqlDataReader> from)
        {
            if (from.First().NextResult())
            {
                IEnumerable<Professor> professors = professorsMapper.Map(from);

                return professors;
            }

            return Enumerable.Empty<Professor>();
        }
    }
}