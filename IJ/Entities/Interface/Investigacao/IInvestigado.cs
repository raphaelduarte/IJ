namespace IJ.Entities.Interface.Investigacao;

public interface IInvestigado : ICpf, IEndereco, ITelefone, INomeCompleto
{
    public Guid IdInvestigado { get; set; }
    public INomeCompleto NomeCompleto { get; set; }
    public ICpf Cpf { get; set; }
    public ITelefone Telefone { get; set; }
    public IEndereco Endereco { get; set; }
}