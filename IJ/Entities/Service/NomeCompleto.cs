using IJ.Entities.Interface;

namespace IJ.Entities.Service;

public class NomeCompleto : INomeCompleto
{
    public NomeCompleto(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
        
        string NomeCompleto = Nome + " " + Sobrenome;
    }

    public Guid IdNomeCompleto { get; set; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
}