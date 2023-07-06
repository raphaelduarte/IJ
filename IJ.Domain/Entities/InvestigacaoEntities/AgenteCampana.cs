namespace IJ.Domain.Entities.Investigacao.Investigacao;

public sealed class AgenteCampana : Entity
{
    public AgenteCampana(Guid uduarioId)
    {
        UsuarioId = uduarioId;
    }
    private Guid UsuarioId { get; set; }
    public List<Enum> ClassificacaoAgenteCampana { get; set; }
    public List<Guid> InvestigacoesList { get; set; }
}