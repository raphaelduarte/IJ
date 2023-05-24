using FluentValidation;
using IJ.Domain.Interfaces.Usuarios;
using IJ.Domain.Validation;

namespace IJ.Domain.Entities.ValueObjects;

public class NomeCompleto : AbstractValidator<INomeCompletoRepository>
{
    private string _nome { get; set; }
    private string _sobrenome { get; set; }
    public NomeCompleto(INomeCompletoRepository nome, INomeCompletoRepository sobrenome, Validator<INomeCompletoRepository> validator)
    {
        RuleFor(m => m.Nome)
            .NotNull().WithMessage("O valor não pode ser vazio não pode ser nulo")
            .NotEmpty().WithMessage("O Nome não pode ser vazio")
            .MaximumLength(40).WithMessage("O Nome não pode ter mais de 40 caracteres")
            .MinimumLength(1).WithMessage("O Nome deve possuir mais de 1 caracter");

        RuleFor(m => m.Sobrenome)
            .NotNull().WithMessage("O valor não pode ser vazio não pode ser nulo")
            .NotEmpty().WithMessage("O valor não pode ser vazio")
            .MaximumLength(300).WithMessage("O Sobrenome não pode ter mais de 300 caracteres")
            .MinimumLength(2).WithMessage("O Sobrenome deve possuir mais de 2 caracter");

        validator.Validate(nome);
        validator.Validate(sobrenome);

        _nome = nome.Nome;
        _sobrenome = sobrenome.Sobrenome;
    }
}