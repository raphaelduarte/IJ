using FluentValidation;
using FluentValidation.Validators;
using IJ.Domain.Interfaces.Usuarios;
using IJ.Domain.Validation.ValueObjects;

namespace IJ.Domain.Entities.ValueObjects;

public class Email
{
    private IEmailRepository _email;
    public Email(IEmailRepository email, EmailValidation emailValidation)
    {
        var validationResult = emailValidation.Validate(email);
        if (!validationResult.IsValid)
        {
            var errorMessages = string.Join(", ", validationResult.Errors);
            Console.WriteLine($"Validation failed: {errorMessages}");
        }
        else
        {
            email = _email;
            Console.WriteLine("Validation passed.");
        }
    }
}
