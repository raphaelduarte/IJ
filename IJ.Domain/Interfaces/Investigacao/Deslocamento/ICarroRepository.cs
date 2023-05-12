using IJ.Domain.Interfaces.Investigacao.Enums;

namespace IJ.Domain.Interfaces.Investigacao.Deslocamento;

public interface ICarroRepository
{
    ETipoVeiculoRepository Carro { get; set; }
}