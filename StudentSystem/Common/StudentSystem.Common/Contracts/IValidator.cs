namespace StudentSystem.Common.Contracts
{
    using StudentSystem.Common.Validators;

    public interface IValidator<in T>
    {
        ValidationResult Validate(T model);
    }
}