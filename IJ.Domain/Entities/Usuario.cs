using IJ.Domain.Interfaces.Usuarios;
using IJ.Domain.Validation;

namespace IJ.Domain.Entities;

public sealed class Usuario
{
    private IIdRepository _idRepository;
    private IUsuarioRepository _usuarioRepository;
    private INomeCompletoRepository _nomeCompletoRepository;
    private ICpfRepository _cpfRepository;
    private ITelefoneRepository _telefoneRepository;
    private IEnderecoRepository _enderecoRepository;
    private IEmailRepository _emailRepository;
    private ISenhaRepository _senhaRepository;

    public Usuario(
        IIdRepository idRepository,
        IUsuarioRepository usuarioRepository,
        INomeCompletoRepository nomeCompletoRepository,
        ICpfRepository cpfRepository,
        ITelefoneRepository telefoneRepository,
        IEnderecoRepository enderecoRepository,
        IEmailRepository emailRepository,
        ISenhaRepository senhaRepository
    )
    {
        _idRepository = idRepository;
        _usuarioRepository = usuarioRepository;
        _nomeCompletoRepository = nomeCompletoRepository;
        _cpfRepository = cpfRepository;
        _telefoneRepository = telefoneRepository;
        _enderecoRepository = enderecoRepository;
        _emailRepository = emailRepository;
        _senhaRepository = senhaRepository;
    }

    private void ValidateDomain(INomeCompletoRepository nomeCompletoRepository)
    {
        var nomeCompletoRepositoryString = nomeCompletoRepository.ToString();
        DomainExeptionValidation.When(string.IsNullOrEmpty(nomeCompletoRepositoryString), "Nome Inválido");
    }
}