namespace IJ.Domain.Interfaces.Usuarios;

public interface ICpfRepository
{
    public Guid IdCpf { get; set; }
    public long NumeroCpf { get; set; }
}