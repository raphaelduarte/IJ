using IJ.Domain.Interfaces.Investigacao;
using IJ.Domain.Interfaces.Usuarios;

namespace IJ.Domain.Entities;

public sealed class AgenteCampana
{
    private IAgenteCampanaRepository _agenteCampanaRepository { get; set; }
    private IInvestigacaoRepository _investigacaoRepository { get; set; }
    public AgenteCampana(IAgenteCampanaRepository agenteCampanaRepository, IInvestigacaoRepository investigacaoRepository)
    {
        _investigacaoRepository = investigacaoRepository;
        _agenteCampanaRepository = agenteCampanaRepository;

        IEntityRepository Id = _agenteCampanaRepository.AgenteCampana.IdUsuarioRepository;
        INomeCompletoRepository NomeCompleto = _agenteCampanaRepository.AgenteCampana.NomeCompletoRepository;
        ICpfRepository Cpf = _agenteCampanaRepository.AgenteCampana.CpfRepository;
        IList<ITelefoneRepository> Telefones = _agenteCampanaRepository.AgenteCampana.TelefoneRepositories;
        IEmailRepository Email = _agenteCampanaRepository.AgenteCampana.EmailRepository;
        IList<IEnderecoRepository> Enderecos = _agenteCampanaRepository.AgenteCampana.EnderecoRepositories;

        IList<IInvestigacaoRepository> AgentesInteligencia = _investigacaoRepository.AgentesInteligencia;
        IList<IInvestigadoRepository> Investigados = _investigacaoRepository.Investigados;

        string NomeInvestigacao = _investigacaoRepository.NomeInvestigacao;
        IList<string> Investigacoes = new List<string>();

    }
}