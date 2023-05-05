using IJ.Entities.Interface;

namespace IJ.Entities.Service;

public class Endereco : IEndereco
{
    public Guid IdEndereco { get; set; }
    public string Rua { get; set; }
    public int Numero { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public string Pais { get; set; }

    public Endereco(string rua, int numero, string bairro, string cidade, string estado, string pais )
    {
        if (numero is int)
        {
            Console.WriteLine("Número no formato correto");
        }
        else
        {
            Console.WriteLine("Se a sua residência não possui número, digite o número zero (0)");
        }
        
        Rua = rua;
        Numero = numero;
        Bairro = bairro;
        Cidade = cidade;
        Estado = estado;
        Pais = pais;
    }
}