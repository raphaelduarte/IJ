namespace IJ.Entities.Interface.Endereco;

public interface ICidadeEstado
{
    Guid IdCidadeEstado { get; set; }
    IList<ICidade> Cidades { get; set; }
    IList<IEstado> Estados { get; set; }
}