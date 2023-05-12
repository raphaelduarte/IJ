using IJ.Domain.Interfaces.Usuarios;

namespace IJ.Domain.Interfaces.Investigacao;

public interface IInvestigacaoRepository : IEntityRepository
{
    Guid IdInvestigacao { get; }
    string NomeInvestigacao { get; set; }
    IList<IInvestigacaoRepository> AgentesInteligencia { get; set; }
    IList<IAgenteCampanaRepository> AgentesCampana { get; set; }
    IList<IContratanteRepository> Contratantes { get; set; }
    IList<IInvestigadoRepository> Investigados { get; set; }
    IDetalhesInvestigacao DetalhesInvestigacao { get; set; }

}