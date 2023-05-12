namespace IJ.Domain.Interfaces.Investigacao;

public interface IInvestigacaoRepository
{
    IAgenteInteligenciaRepository AgenteInteligencia { get; set; }
    IAgenteCampanaRepository AgenteCampana { get; set; }
    IContratanteRepository Contratante { get; set; }
    IDetalhesInvestigacao DetalhesInvestigacao { get; set; }

}