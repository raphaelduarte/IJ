using IJ.Domain.Interfaces.Usuarios;

namespace IJ.Domain.Validation.ValueObjects;

public class CpfValidation
{
    ICpfRepository _beValidCpf;

    public CpfValidation(ICpfRepository beValidCpf)
    {
        _beValidCpf = beValidCpf;
    }

    bool BeValidCpf(string cpf)
    {
        if (string.IsNullOrEmpty(cpf) || cpf.Length != 11)
            return false;

        // Algoritmo de validação do CPF
        int[] factors = { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
        int sum = 0;

        for (int i = 0; i < 9; i++)
        {
            sum += int.Parse(cpf[i].ToString()) * factors[i];
        }

        int remainder = sum % 11;
        int digit1 = remainder < 2 ? 0 : 11 - remainder;

        if (int.Parse(cpf[9].ToString()) != digit1)
            return false;

        sum = 0;
        for (int i = 0; i < 10; i++)
        {
            sum += int.Parse(cpf[i].ToString()) * factors[i];
        }

        remainder = sum % 11;
        int digit2 = remainder < 2 ? 0 : 11 - remainder;

        return int.Parse(cpf[10].ToString()) == digit2;
    }
}