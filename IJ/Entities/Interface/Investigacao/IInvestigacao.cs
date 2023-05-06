namespace IJ.Entities.Interface.Investigacao;

public interface IInvestigacao : IAgenteInteligencia, IAgenteCampana, IContratante,IInvestigado
{
    public Guid IdInvestigacao { get; set; }
    public string NomeInvestigacao { get; set; }
    public IAgenteInteligencia AgenteInteligencia { get; set; }
    public IAgenteCampana AgenteCampana { get; set; }
    public IContratante Contratante { get; set; }
    public IInvestigado Investigado { get; set; }   
}