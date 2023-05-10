using IJ.Domain.Interfaces.Usuarios;

namespace IJ.Domain.Entities;

public class Id : IIdRepository
{
    public Guid Id { get; set; }

    public Id()
    {
        Id = Guid.NewGuid();
    }
}