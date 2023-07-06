namespace IJ.Domain.Entities;
public class Usuario : Entity
{
    public Usuario(Guid nomeCompletoId ,Guid cpfId, Guid telefoneId, Guid enderecoCompletoId, Guid enderecoEmailId, Enum eTipoUsuario)
    {
        NomeCompletoId = nomeCompletoId;
        CpfId = cpfId;
        TelefoneId = telefoneId;
        EnderecoCompletoId = enderecoCompletoId;
        EnderecoEmailId = enderecoEmailId;
        ETipoUsuario = eTipoUsuario;
    }
    private Guid NomeCompletoId { get; set; }
    private Guid CpfId { get; set; }
    private Guid TelefoneId { get; set; }
    private Guid EnderecoCompletoId { get; set; }
    private Guid EnderecoEmailId { get; set; }
    private Enum ETipoUsuario { get; }
    private List<ValueObjects.Endereco.Endereco> EnderecoCompletoList { get; set; }
}