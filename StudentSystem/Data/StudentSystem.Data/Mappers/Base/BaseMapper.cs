namespace StudentSystem.Data.Mappers.Base
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using System.Linq;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Data.Models.Base;

    public abstract class BaseMapper<TFrom, To> : IMapper<TFrom, To>
        where TFrom : SqlDataReader
        where To : BaseModel
    {
        public abstract To Map(TFrom from);

        public IEnumerable<To> Map(IEnumerable<TFrom> from)
        {
            TFrom reader = from.FirstOrDefault();

            if (reader != null)
            {
                ICollection<To> result = new List<To>();

                while (reader.Read())
                {
                    To to = Map(reader);

                    result.Add(to);
                }

                return result;
            }

            return Enumerable.Empty<To>();
        }

        protected DateTime? Map(SqlDataReader reader, string columnName)
        {
            int columnOrdinal = reader.GetOrdinal(columnName);

            if (reader.IsDBNull(columnOrdinal))
            {
                return null;
            }

            return (DateTime?)reader.GetDateTime(columnOrdinal);
        }
    }
}