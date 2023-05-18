using FluentValidation;
using Flunt.Br;
using Flunt.Br.Extensions;
using Flunt.Notifications;
using IJ.Domain.Entities.ValueObjects;
using IJ.Domain.Interfaces.Usuarios;

namespace IJ.Domain.Validation.ValueObjects;

public class CpfValidation : AbstractValidator<ICpfRepository>
{
    public CpfValidation(long cpf)
    {
        RuleFor(cpf => cpf.NumeroCpf.ToString())
            .NotEmpty().WithMessage("CPF is required.")
            .Length(11).WithMessage("CPF must have 11 digits.")
            .Must(BeAValidCpf).WithMessage("Invalid CPF.");


        bool BeAValidCpf(string cpf)
        {
            if (string.IsNullOrEmpty(cpf))
                return false;

            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");

            if (!long.TryParse(cpf, out long numericCpf))
                return false;

            int[] cpfDigits = cpf.Select(c => int.Parse(c.ToString())).ToArray();

            if (AreAllDigitsEqual(cpfDigits))
                return false;

            int[] firstVerifierDigits = CalculateVerifierDigits(cpfDigits, 10);
            int[] secondVerifierDigits = CalculateVerifierDigits(cpfDigits, 11);

            return cpfDigits[9] == firstVerifierDigits[0] && cpfDigits[10] == secondVerifierDigits[0];
        }

        bool AreAllDigitsEqual(int[] digits)
        {
            int firstDigit = digits[0];
            foreach (int digit in digits)
            {
                if (digit != firstDigit)
                    return false;
            }
            return true;
        }

        int[] CalculateVerifierDigits(int[] digits, int multiplier)
        {
            int[] verifierDigits = new int[2];
            int sum = 0;

            for (int i = 0; i < digits.Length - 2; i++)
                sum += digits[i] * (multiplier--);

            int firstDigit = (sum % 11) < 2 ? 0 : 11 - (sum % 11);

            sum = 0;
            multiplier = 11;

            for (int i = 0; i < digits.Length - 1; i++)
                sum += digits[i] * (multiplier--);

            int secondDigit = (sum % 11) < 2 ? 0 : 11 - (sum % 11);

            verifierDigits[0] = firstDigit;
            verifierDigits[1] = secondDigit;

            return verifierDigits;
        }
    }
}