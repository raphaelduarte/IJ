namespace IJ.Entities.Interface.Investigacao;

public interface IContratante : INomeCompleto, ICpf, ITelefone, IEndereco
{
    Guid IdContratante { get; set; }
}