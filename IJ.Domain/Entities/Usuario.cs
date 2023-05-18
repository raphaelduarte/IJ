using System.Runtime.InteropServices.ComTypes;
using Flunt.Notifications;
using IJ.Domain.Interfaces.Usuarios;
using IJ.Domain.Validation;

namespace IJ.Domain.Entities;

public sealed class Usuario : IEntityRepository
{
    public Guid Id { get; set; }
    private IUsuarioRepository UsuarioRepository;

    public Usuario(IUsuarioRepository usuarioRepository)
    {
        UsuarioRepository = usuarioRepository;
    }
}