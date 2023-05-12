namespace IJ.Domain.Interfaces.Usuarios;

public interface IUsuarioRepository
{
    Guid IdUsuarioRepository { get; set; }
    INomeCompletoRepository NomeCompletoRepository { get; set; }
    ICpfRepository CpfRepository { get; set; }
    ITelefoneRepository TelefoneRepository { get; set; }
    IEnderecoRepository EnderecoRepository { get; set; }
    IEmailRepository EmailRepository { get; set; }
    ISenhaRepository SenhaRepository { get; set; }
}