namespace StudentSystem.Common.Validators
{
    public class ValidationResult
    {
        public ValidationResult(string errorMessage)
        {
            ErrorMessage = errorMessage;
        }

        public ValidationResult()
        {
        }

        public string ErrorMessage { get; set; }

        public bool HasErrors => !string.IsNullOrEmpty(ErrorMessage);
    }
}