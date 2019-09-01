namespace StudentSystem.Common.Contracts
{
    using StudentSystem.Common.Validators;

    public interface IValidator<in TModel>
    {
        ValidationResult Validate(TModel model);
    }
}