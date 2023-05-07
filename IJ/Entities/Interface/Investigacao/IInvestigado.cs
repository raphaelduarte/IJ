namespace IJ.Entities.Interface.Investigacao;

public interface IInvestigado : INomeCompleto, ICpf, ITelefone, IEndereco
{
    Guid IdInvestigado { get; set; }
}