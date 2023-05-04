using System.Xml;
using IJ.Entities.Interface;

namespace IJ.Entities.Service;

public class Cpf : ICpf
{
    public Guid IdCpf { get; set; }
    public long NumeroCpf { get; set; }

    public Cpf(Guid idCpf, long cpf)
    {
        IdCpf = idCpf;
        NumeroCpf = cpf;

        if (NumeroCpf is long)
        {
            Console.WriteLine("CPF no formato correto");
        }
        else
        {
            Console.WriteLine("CPF no formato errado. Só pode ter apenas números nesse campo. Não coloque pontos ou vírgulas");
        }
    }
}

