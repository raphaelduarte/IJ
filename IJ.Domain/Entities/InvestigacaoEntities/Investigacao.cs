using System.ComponentModel;

namespace IJ.Domain.Entities.InvestigacaoEntities;

public class Investigacao : Entity
{
    public Investigacao(
        List<Guid> agenteCampanaInvestigacao,
        List<Guid> agenteInteligenciaInvestigacao,
        Guid contratante,
        List<Guid> investigadoList,
        List<Guid> localInvestigacaoList,
        string? anocacao
        )
    {
        AgenteCampanaInvestigacao = agenteCampanaInvestigacao;
        AgenteInteligenciaInvestigacao = agenteInteligenciaInvestigacao;
        Contratante = contratante;
        InvestigadoList = investigadoList;
        LocalInvestigacaoList = localInvestigacaoList;
        AnotacoesList.Add(anocacao);
    }
    private List<Guid> AgenteCampanaInvestigacao { get; set; }
    private List<Guid> AgenteInteligenciaInvestigacao { get; set; }
    private Guid Contratante { get; set; }
    private List<Guid> InvestigadoList { get; set; }
    private List<Guid> LocalInvestigacaoList { get; set; }
    private List<string> AnotacoesList { get; set; }
}