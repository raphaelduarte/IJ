namespace IJ.Domain.Interfaces.Usuarios;

public interface IUsuarioRepository
{
    IEntityRepository IdUsuarioRepository { get; set; }
    INomeCompletoRepository NomeCompletoRepository { get; set; }
    ICpfRepository CpfRepository { get; set; }
    IList<ITelefoneRepository> TelefoneRepositories { get; set; }
    IList<IEnderecoRepository> EnderecoRepositories { get; set; }
    IEmailRepository EmailRepository { get; set; }
    ISenhaRepository SenhaRepository { get; set; }
}