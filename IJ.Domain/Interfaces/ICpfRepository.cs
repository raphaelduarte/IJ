namespace IJ.Domain.Interfaces.Usuarios;

public interface ICpfRepository
{
    public Guid IdCpf { get; }
    public long NumeroCpf { get; set; }
}