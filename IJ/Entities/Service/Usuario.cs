using System.Reflection.Metadata.Ecma335;
using IJ.Entities.Interface;

namespace IJ.Entities.Service;

public class Usuario : IUsuario
{
    public Guid IdUsuario { get; }
    public INomeCompleto NomeCompleto { get; set; }
    public ICpf Cpf { get; set; }
    public IList<ITelefone> Telefones { get; set; }
    public IList<IEndereco> Enderecos { get; set; }
    public IList<IImage> Imagens { get; set; }
    
    
    

    public Guid IdNomeCompleto { get; set; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    

    public Guid IdCpf { get; set; }
    public long NumeroCpf { get; set; }
    
    
    public Guid IdTelefone { get; set; }
    public int Ddd { get; set; }
    public int NumeroTelefone { get; set; }
    
    
    public Guid IdEndereco { get; set; }
    public string Rua { get; set; }
    public int Numero { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public string Pais { get; set; }
    
    
    public Guid IdImage { get; set; }
    public string Image { get; set; }
}