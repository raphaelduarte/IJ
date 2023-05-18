using FluentValidation;
using Flunt.Br;
using Flunt.Notifications;
using IJ.Domain.Entities.ValueObjects;
using IJ.Domain.Interfaces.Usuarios;

namespace IJ.Domain.Validation.ValueObjects;

public class NomeCompletoValidation : AbstractValidator<INomeCompletoRepository>
{

    public NomeCompletoValidation()
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
    }
}