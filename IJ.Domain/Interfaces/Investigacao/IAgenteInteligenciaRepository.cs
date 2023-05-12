using IJ.Domain.Interfaces.Usuarios;

namespace IJ.Domain.Interfaces.Investigacao;

public interface IAgenteInteligenciaRepository
{
    IUsuarioRepository AgenteInteligencia { get; set; }
}