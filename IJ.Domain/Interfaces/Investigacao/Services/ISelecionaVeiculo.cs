using IJ.Domain.Interfaces.Investigacao.Enums;

namespace IJ.Domain.Interfaces.Investigacao.Services;

public interface ISelecionaVeiculo
{
    ETipoVeiculoRepository TipoVeiculo { get; set; }
}