namespace StudentSystem.Common.Validators
{
    using System.Collections.Generic;

    using StudentSystem.Common.Contracts;

    public class ValidatorComposite<TModel> : IValidator<TModel>
    {
        private readonly IEnumerable<IValidator<TModel>> validators;

        public ValidatorComposite(IEnumerable<IValidator<TModel>> validators)
        {
            this.validators = validators;
        }

        public ValidationResult Validate(TModel model)
        {
            foreach (var validator in validators)
            {
                ValidationResult result = validator.Validate(model);

                if (result.HasErrors)
                {
                    return result;
                }
            }

            return new ValidationResult();
        }
    }
}