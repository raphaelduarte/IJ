using IJ.Domain.Entities.ValueObjects;

namespace IJ.Domain.Interfaces.Usuarios;

public interface IEmailRepository
{
    public Guid IdEmail { get; set; }
    public IEmailRepository Email { get; set; }
}