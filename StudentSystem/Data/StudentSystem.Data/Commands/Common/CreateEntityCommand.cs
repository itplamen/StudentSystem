namespace StudentSystem.Data.Commands.Common
{
    using System.Collections.Generic;

    using StudentSystem.Data.Contracts.Commands;

    public class CreateEntityCommand : ICommand
    {
        public CreateEntityCommand()
        {
            Columns = new Dictionary<object, object>();
        }

        public string Table { get; set; }

        public IDictionary<object, object> Columns { get; set; }
    }
}