using IJ.Domain.Interfaces.Usuarios;

namespace IJ.Domain.Interfaces.Investigacao;

public interface IContratanteRepository
{
    INoUsuarioRepository Contratante { get; set; }
}