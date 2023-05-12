using IJ.Domain.Interfaces.Usuarios;

namespace IJ.Domain.Interfaces.Investigacao;

public interface INoUsuarioRepository
{
    INomeCompletoRepository NomeCompletoRepository { get; set; }
    ICpfRepository CpfRepository { get; set; }
    ITelefoneRepository TelefoneRepository { get; set; }
    IEnderecoRepository EnderecoRepository { get; set; }
    IEmailRepository EmailRepository { get; set; }
}