using IJ.Domain.Interfaces.Usuarios;

namespace IJ.Domain.Interfaces.Investigacao;

public interface IAgenteCampanaRepository
{
    IUsuarioRepository AgenteCampana { get; }
    IList<IInvestigacaoRepository> Investigacoes { get; }
}