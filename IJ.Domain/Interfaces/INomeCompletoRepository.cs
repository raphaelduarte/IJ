namespace IJ.Domain.Interfaces.Usuarios;

public interface INomeCompletoRepository
{
    public Guid IdNomeCompleto { get; set; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
}