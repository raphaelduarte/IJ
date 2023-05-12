using System.Runtime.InteropServices.ComTypes;
using IJ.Domain.Interfaces.Usuarios;
using IJ.Domain.Validation;

namespace IJ.Domain.Entities;

public sealed class Usuario : IEntityRepository
{
    public Guid Id { get; set; }
    private IUsuarioRepository UsuarioRepository;

    public Usuario(IUsuarioRepository usuarioRepository)
    {
        UsuarioRepository = usuarioRepository;

        /*
         void ValidateDomainCpf(ICpfRepository cpfRepository)
         {
             var cpfRepositoryString = cpfRepository.ToString();
             DomainExeptionValidation.When(string.IsNullOrEmpty(cpfRepositoryString), "Cpf Inválido");
         }
         _cpfRepository = cpfRepository;
         
         
         
         void ValidateDomainNomeCompleto(INomeCompletoRepository nomeCompletoRepository)
         {
             var nomeCompletoRepositoryString = nomeCompletoRepository.ToString();
             DomainExeptionValidation.When(string.IsNullOrEmpty(nomeCompletoRepositoryString), "Nome Inválido");
         }
         _nomeCompletoRepository = nomeCompletoRepository;
         
         
         void ValidateDomainTelefone(IList<ITelefoneRepository> telefoneRepository)
         {
             if (telefoneRepository.Count > 0)
             {
                 _telefoneRepository = telefoneRepository;
             }
             else
             {
                 string erroTelefone = "Telefone vazio, coloque um número de telefone";
             }
         }
         
         
         void ValidateDomainEndereco(IList<IEnderecoRepository> enderecoRepository)
         {
             if (enderecoRepository.Count > 0)
             {
                 _enderecoRepository = enderecoRepository;
             }
             else
             {
                 string erroEndereco = "Endereco Inválido";
             }
         }
         
         
         void ValidateEmail(IEmailRepository emailRepository)
         {
             var emailRepositoryString = emailRepository.ToString();
             DomainExeptionValidation.When(string.IsNullOrEmpty(emailRepositoryString), "Email Inválido");
         }
         _emailRepository = emailRepository;
         
         
         void ValidateSenha(ISenhaRepository senhaRepository)
         {
             var senhaRepositoryString = senhaRepository.ToString();
             DomainExeptionValidation.When(string.IsNullOrEmpty(senhaRepositoryString), "Senha Inválida");
         }
         _senhaRepository = senhaRepository;
         
         
         void ValidateUsuario(IUsuarioRepository usuarioRepository)
         {
             var usuarioRepositoryString = usuarioRepository.ToString();
             DomainExeptionValidation.When(string.IsNullOrEmpty(usuarioRepositoryString), "Usuário Inválido");
         }
         _usuarioRepository = usuarioRepository;
         
         */
    }
    
    
    
    
}