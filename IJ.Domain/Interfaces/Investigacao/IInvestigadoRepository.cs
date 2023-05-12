namespace IJ.Domain.Interfaces.Investigacao;

public interface IInvestigadoRepository
{
    INoUsuarioRepository Investigado { get; set; }
}