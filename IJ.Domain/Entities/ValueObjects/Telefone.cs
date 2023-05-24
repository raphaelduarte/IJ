using FluentValidation;
using IJ.Domain.Interfaces.Usuarios;
using IJ.Domain.Validation;
using IJ.Domain.Validation.ValueObjects;

namespace IJ.Domain.Entities.ValueObjects;

public class Telefone : AbstractValidator<ITelefoneRepository>
{
    TelefoneValidation _telefoneValidation { get; set; }
    ITelefoneRepository _telefone { get; set; }

    int _ddd { get; set; }
    long _numeroTelefone { get; set; }


    public Telefone(ITelefoneRepository telefone, TelefoneValidation telefoneValidation, Validator<ITelefoneRepository> validator )
    {
        _telefoneValidation = telefoneValidation;

        RuleFor(telefone => telefone.NumeroTelefone)
            .NotEmpty().WithMessage("Phone number is required.")
            .Must(_telefoneValidation.BeValidPhone).WithMessage("Invalid phone number.");

        RuleFor(ddd => ddd.Ddd)
           .NotEmpty().WithMessage("DDD is required.");

        validator.Validate(telefone);

        _ddd = telefone.Ddd;
        _numeroTelefone = telefone.NumeroTelefone;
    }
}