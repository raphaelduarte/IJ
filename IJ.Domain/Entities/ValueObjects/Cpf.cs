using FluentValidation;
using IJ.Domain.Interfaces.Usuarios;
using IJ.Domain.Validation;
using IJ.Domain.Validation.ValueObjects;

namespace IJ.Domain.Entities.ValueObjects;

public class Cpf : AbstractValidator<ICpfRepository>
{
    private Guid _idCpf { get; }
    private long _numeroCpf { get; set; }
    private ICpfRepository _cpfValidator {  get; set; }

    public Cpf(Guid? idCpf, long numeroCpf, ICpfRepository? cpf, ICpfRepository? cpfValidator,
        Validator<ICpfRepository>? validator)
    {
        _cpfValidator = cpfValidator;


        RuleFor(cpf => cpf.NumeroCpf.ToString())
            .NotEmpty().WithMessage("O número do CPF é obrigatório.")
            .Length(11).WithMessage("O número do CPF deve conter 11 dígitos.")
            .Must(_cpfValidator.BeAValidCpf);



        validator.Validate(cpf);

        idCpf = new Guid();
        _idCpf = (Guid)idCpf;

        _numeroCpf = numeroCpf;
    }
}