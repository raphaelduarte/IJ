namespace IJ.Entities.Interface.Endereco;

public interface IBairroCidade
{
    public Guid IdBairroCidade { get; set; }
    IList<IBairro> Bairros { get; set; }
    IList<ICidade> Cidades { get; set; }
}