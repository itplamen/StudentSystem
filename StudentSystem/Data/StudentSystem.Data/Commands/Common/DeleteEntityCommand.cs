namespace StudentSystem.Data.Commands.Common
{
    using StudentSystem.Data.Contracts.Commands;

    public class DeleteEntityCommand : ICommand
    {
        public DeleteEntityCommand(int id, string table)
        {
            Id = id;
            Table = table;
        }

        public int Id { get; set; }

        public string Table { get; set; }
    }
}