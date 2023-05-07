namespace IJ.Entities.Interface.Endereco;

public interface IBairroCidade
{
    Guid IdBairroCidade { get; set; }
    IList<IBairro> Bairros { get; set; }
    IList<ICidade> Cidades { get; set; }
}