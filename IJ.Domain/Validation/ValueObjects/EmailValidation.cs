using FluentValidation;
using IJ.Domain.Interfaces.Usuarios;

namespace IJ.Domain.Validation.ValueObjects;

public class EmailValidation : AbstractValidator<IEmailRepository>
{
    public EmailValidation()
    {
        RuleFor(email => email.Email)
            .NotEmpty().WithMessage("Email is required.")
            .EmailAddress().WithMessage("Invalid email address.");
    }
}