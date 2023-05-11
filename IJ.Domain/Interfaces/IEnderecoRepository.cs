namespace IJ.Domain.Interfaces.Usuarios;

public interface IEnderecoRepository
{
    public Guid IdEndereco { get; set; }
    public string Rua { get; set; }
    public int Numero { get; set; }
    public string Bairro { get; set; }
    public string Cidade { get; set; }
    public string Estado { get; set; }
    public string Pais { get; set; }
}