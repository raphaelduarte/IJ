namespace IJ.Domain.Interfaces.Usuarios;

public interface IEntityRepository
{
    public Guid Id { get; protected set; }
}