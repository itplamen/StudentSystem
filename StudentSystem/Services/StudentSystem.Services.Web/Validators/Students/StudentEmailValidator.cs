namespace StudentSystem.Services.Web.Validators.Students
{
    using System.Text.RegularExpressions;

    using StudentSystem.Common.Contracts;
    using StudentSystem.Common.Validators;
    using StudentSystem.Services.Models.Web.Students;

    public class StudentEmailValidator : IValidator<StudentRequestModel>
    {
        private const string EMAIL_REGEX = @"(@)(.+)$";

        public ValidationResult Validate(StudentRequestModel model)
        {
            if (string.IsNullOrEmpty(model.Email) || !Regex.Match(model.Email, EMAIL_REGEX).Success)
            {
                return new ValidationResult("Emails is invalid.");
            }

            return new ValidationResult();
        }
    }
}