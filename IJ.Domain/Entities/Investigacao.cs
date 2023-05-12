using IJ.Domain.Interfaces.Investigacao;

namespace IJ.Domain.Entities;

public sealed class Investigacao
{
    private IInvestigacaoRepository InvestigacaoRepository;

    public Investigacao(IInvestigacaoRepository investigacaoRepository)
    {
        InvestigacaoRepository = investigacaoRepository;
    }
}