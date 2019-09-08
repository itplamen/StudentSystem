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
        where To : BaseModel, new()
    {
        public virtual To Map(TFrom from)
        {
            To to = new To()
            {
                Id = Map<int>(from, "Id"),
                CreatedOn = Map<DateTime>(from, "CreatedOn"),
                ModifiedOn = Map<DateTime?>(from, "ModifiedOn"),
                IsDeleted = Map<bool>(from, "IsDeleted"),
                DeletedOn = Map<DateTime>(from, "DeletedOn")
            };

            return to;
        }

        public virtual IEnumerable<To> Map(IEnumerable<TFrom> from)
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

        protected T Map<T>(SqlDataReader reader, string columnName)
        {
            if (DoesColumnExist(reader, columnName))
            {
                int columnOrdinal = reader.GetOrdinal(columnName);

                if (!reader.IsDBNull(columnOrdinal))
                {
                    return (T)reader[columnName];
                }
            }

            return default(T);
        }

        private bool DoesColumnExist(SqlDataReader reader, string columnName)
        {
            for (int i = 0; i < reader.FieldCount; i++)
            {
                if (reader.GetName(i).Equals(columnName, StringComparison.InvariantCultureIgnoreCase))
                {
                    return true;
                }
            }

            return false;
        }
    }
}