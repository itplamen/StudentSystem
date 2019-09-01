namespace StudentSystem.Services.Web.Validators.Students
{
    using StudentSystem.Common.Contracts;
    using StudentSystem.Common.Validators;
    using StudentSystem.Services.Models.Web.Students;

    public class StudentNameValidator : IValidator<StudentRequestModel>
    {
        public ValidationResult Validate(StudentRequestModel model)
        {
            if (string.IsNullOrEmpty(model.FirstName) || string.IsNullOrEmpty(model.LastName))
            {
                return new ValidationResult("Student name is invalid!");
            }

            return new ValidationResult();
        }
    }
}