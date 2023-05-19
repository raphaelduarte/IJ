using FluentValidation;
using FluentValidation.Validators;
using IJ.Domain.Interfaces.Usuarios;
using IJ.Domain.Validation.ValueObjects;

namespace IJ.Domain.Entities.ValueObjects;

public class Email
{
    private IEmailRepository _email;
    private Guid _idEmail;
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
            _idEmail = email.IdEmail;
            _email = email.Email;

            Console.WriteLine("Validation passed.");
        }
    }
    
}
