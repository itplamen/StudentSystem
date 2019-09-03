namespace StudentSystem.Data.Commands.Common
{
    public class UpdateEntityCommand : EntityCommand
    {
        public UpdateEntityCommand(string table, int id) 
            : base(table)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}