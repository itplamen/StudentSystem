namespace StudentSystem.Clients.Web.Mappers
{
    using System;

    internal static class DateTimeMapper
    {
        internal static string Map(DateTime? dateTime)
        {
            if (dateTime.HasValue)
            {
                return dateTime.Value.ToString("dd/MM/yyyy HH:mm");
            }

            return string.Empty;
        }
    }
}