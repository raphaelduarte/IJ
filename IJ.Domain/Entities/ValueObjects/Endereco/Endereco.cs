namespace IJ.Domain.Entities.ValueObjects.Endereco;

public class Endereco : Entity
{
    public Endereco(Guid logradouro, Guid numero, Guid bairroCidade, Guid cidadeEstado, Guid pais, Enum eTipoResidencia)
    {
        Logradouro = logradouro;
        Numero = numero;
        BairroCidade = bairroCidade;
        CidadeEstado = cidadeEstado;
        Pais = pais;
        ETipoResidencia = eTipoResidencia;
    }

    private Guid Logradouro { get; set; }
    private Guid Numero { get; set; }
    private Guid BairroCidade { get; set; }
    private Guid CidadeEstado { get; set; }
    private Guid Pais { get; set; }
    private Enum ETipoResidencia { get; }
}