using IJ.Domain.Interfaces.Usuarios;
using IJ.Domain.Validation.ValueObjects;

namespace IJ.Domain.Entities.ValueObjects;

public class Cpf : ICpfRepository
{
    public Guid IdCpf { get; set; }
    public long NumeroCpf { get; set; }
    private CpfValidation _cpfValidation { get; set; }
    
    public Cpf(long numeroCpf, CpfValidation cpfValidation)
    {
        if (cpfValidation.IsValid)
        {
            numeroCpf = NumeroCpf;
        }
    }
}