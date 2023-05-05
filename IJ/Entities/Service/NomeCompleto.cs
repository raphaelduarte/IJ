using IJ.Entities.Interface;

namespace IJ.Entities.Service;

public class NomeCompleto : INomeCompleto
{
    public Guid IdNomeCompleto { get; set; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public void nomeCompleto()
    {
        throw new NotImplementedException();
    }

    public void nomeCompleto(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;

        string nomeCompleto = Nome + " " + Sobrenome;
    }
}