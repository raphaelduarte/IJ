using FluentValidation;
using IJ.Domain.Entities.ValueObjects;
using IJ.Domain.Interfaces.Usuarios;

namespace IJ.Domain.Validation.ValueObjects;

public class TelefoneValidation : AbstractValidator<ITelefoneRepository>
{
    public TelefoneValidation()
    {
        RuleFor(telefone => telefone.NumeroTelefone)
            .NotEmpty().WithMessage("Phone number is required.")
            .Must(BeValidPhone).WithMessage("Invalid phone number.");
    }

    private bool BeValidPhone(long telefone)
    {
        string telefoneString = telefone.ToString();
        
        // Verifique aqui se o número de telefone atende aos requisitos desejados,
        // como o comprimento correto, formato, etc.

        // Exemplo simples: Aceita apenas números e exige 10 dígitos
        
        if (!IsNumeric(telefoneString) || telefoneString.Length != 10)
            return false;

        return true;
    }

    private bool IsNumeric(string value)
    {
        return long.TryParse(value, out _);
    }
}