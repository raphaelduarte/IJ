namespace IJ.Domain.Interfaces.Usuarios;

public interface ITelefoneRepository
{
    public Guid IdTelefone { get; set; }
    public int Ddd { get; set; }
    public int NumeroTelefone { get; set; }
}