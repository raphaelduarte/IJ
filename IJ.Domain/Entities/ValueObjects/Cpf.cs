using FluentValidation;
using IJ.Domain.Interfaces.Usuarios;
using IJ.Domain.Validation;
using IJ.Domain.Validation.ValueObjects;

namespace IJ.Domain.Entities.ValueObjects;

public class Cpf : AbstractValidator<ICpfRepository>
{
    private Guid _idCpf { get; }
    public long _numeroCpf { get; set; }
    private ICpfRepository _validator {  get; set; }

    public Cpf(Validator<ICpfRepository> validator, ICpfRepository cpf, ICpfRepository validator1)
    {
        _validator = validator1;


        RuleFor(cpf => cpf.NumeroCpf.ToString())
            .NotEmpty().WithMessage("O número do CPF é obrigatório.")
            .Length(11).WithMessage("O número do CPF deve conter 11 dígitos.")
            .Must(_validator.BeAValidCpf);
            


        validator.Validate(cpf);

        _idCpf = cpf.IdCpf;
        _numeroCpf = cpf.NumeroCpf;
    }
}