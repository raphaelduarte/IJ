using FluentValidation;
using IJ.Domain.Interfaces.Usuarios;
using IJ.Domain.Validation;

namespace IJ.Domain.Entities.ValueObjects;

public class Email : AbstractValidator<IEmailRepository>
{
    private readonly Guid _idEmail;
    private readonly string _email;
    public Email(Validator<IEmailRepository> validator, IEmailRepository email)
    {
        RuleFor(m => m.Email)
            .NotEmpty().WithMessage("O Email é obrigatório.")
            .NotNull().WithMessage("Este campo não pode ter valor nulo")
            .EmailAddress<IEmailRepository>().WithMessage("endereço de email inválido.");

        validator.Validate(email);

        _email = email.Email;
        _idEmail = email.IdEmail;
    }
    
}
