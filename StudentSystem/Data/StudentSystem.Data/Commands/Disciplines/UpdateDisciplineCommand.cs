namespace StudentSystem.Data.Commands.Disciplines
{
    public class UpdateDisciplineCommand : DisciplineCommand
    {
        public UpdateDisciplineCommand(int id, string name, int semesterId, int professorId) 
            : base(name, semesterId, professorId)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}