using FluentValidation;
using IJ.Domain.Interfaces.Usuarios;
using IJ.Domain.Validation;
using IJ.Domain.Validation.ValueObjects;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Threading.Channels;

namespace IJ.Domain.Entities.ValueObjects;

public class Cpf : AbstractValidator<ICpfRepository>
{
    private ICpfRepository _cpf { get; set; }
    private CpfValidation _cpfValidation {  get; set; }
    private Validator<ICpfRepository> _validator { get; set; }


    private Guid _idCpf { get; }

    private long _numeroCpf { get; set; }

    public Cpf(ICpfRepository cpf, CpfValidation cpfValidation, Validator<ICpfRepository> validator)
    {
        _cpf = cpf;
        _cpfValidation = cpfValidation;
        _validator = validator;


        RuleFor(_cpf => _cpf.NumeroCpf.ToString())
            .NotEmpty().WithMessage("O número do CPF é obrigatório.")
            .Length(11).WithMessage("O número do CPF deve conter 11 dígitos.")
            .Must(_cpfValidation.BeValidCpf).WithMessage("Esse número de CPF é inválido");

        _validator.Validate(_cpf);

        _idCpf = _cpf.IdCpf;
        _numeroCpf = _cpf.NumeroCpf;

        
    }
}