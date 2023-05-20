using FluentValidation;
using IJ.Domain.Interfaces.Usuarios;
using IJ.Domain.Validation;
using IJ.Domain.Validation.ValueObjects;

namespace IJ.Domain.Entities.ValueObjects;

public class Cpf : AbstractValidator<ICpfRepository>, ICpfRepository
{
    private ICpfRepository _cpfValidator {  get; set; }

    Guid ICpfRepository.IdCpf { get; }

    long ICpfRepository.NumeroCpf { get; set; }

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
        IdCpf = idCpf;

        NumeroCpf = numeroCpf;
    }

    public bool BeAValidCpf(string value)
    {
        throw new NotImplementedException();
    }

    bool ICpfRepository.BeAValidCpf(string value)
    {
        throw new NotImplementedException();
    }
}