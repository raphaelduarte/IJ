using IJ.Domain.Entities.ValueObjects;
using IJ.Domain.Entities.ValueObjects.Endereco;
using Microsoft.Extensions.FileProviders.Embedded;

namespace IJ.Domain.Entities.Investigacao;

public class Contratante : Entity
{
    public Contratante(Guid nomeCompleto, List<Guid> endereco, List<Guid> email, Guid cpf, List<Guid> telefone, string? anotacao)
    {
        NomeCompleto = nomeCompleto;
        Endereco = endereco;
        Cpf = cpf;
        Email = email;
        Telefone = telefone;
        AnotacaoList.Add(anotacao);
    }
    private Guid NomeCompleto { get; set; }
    private List<Guid> Endereco { get; set;}
    private List<Guid> Email { get; set;}
    private Guid Cpf { get; set;}
    private List<Guid> Telefone { get; set;}
    private List<string> AnotacaoList { get; set;}
}