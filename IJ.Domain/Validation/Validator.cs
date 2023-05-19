using FluentValidation;
namespace IJ.Domain.Validation
{
    public class Validator<T> : AbstractValidator<T>
    {
        public T Valor { get; set; }

        public Validator(T valor)
        {
            var validation = Activator.CreateInstance(typeof(T));
            var validationResult = ((AbstractValidator<T>)validation).Validate(valor);
            if (!validationResult.IsValid)
            {
                var errorMessages = string.Join(", ", validationResult.Errors);
                Console.WriteLine($"Validation failed: {errorMessages}");
            }
            else
            {
                Console.WriteLine("Validation passed");
            }
        }
    }
}
