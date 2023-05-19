using FluentValidation;
using FluentValidation.Validators;
using IJ.Domain.Interfaces.Usuarios;
using IJ.Domain.Validation;
using IJ.Domain.Validation.ValueObjects;

namespace IJ.Domain.Entities.ValueObjects;

public class Email : AbstractValidator<IEmailRepository>
{
    private readonly Guid _idEmail;
    private readonly string _email;
    public Email(Validator<IEmailRepository> validator, IEmailRepository email)
    {
        RuleFor(m => m.Email)
            .NotEmpty().WithMessage("O Email é obrigatório.")
            .EmailAddress<IEmailRepository>().WithMessage("endereço de email inválido.");

        validator.Validate(email);

        _email = email.Email;
        _idEmail = email.IdEmail;
    }
    
}
