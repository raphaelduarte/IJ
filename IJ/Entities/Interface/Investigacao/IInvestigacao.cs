namespace IJ.Entities.Interface.Investigacao;

public interface IInvestigacao : IAgenteInteligencia, IAgenteCampana, IContratante, IInvestigado
{
    Guid IdInvestigacao { get; set; }
    string Descricao { get; set; }
    IList<IAgenteInteligencia> AgentesInteligencia { get; set; }
    IList<IAgenteCampana> AgentesCampana { get; set; }
    IList<IContratante> Contratantes { get; set; }
    IList<IInvestigado> Investigados { get; set; }
}