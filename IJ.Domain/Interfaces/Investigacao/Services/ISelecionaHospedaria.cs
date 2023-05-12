using IJ.Domain.Interfaces.Investigacao.Enums;

namespace IJ.Domain.Interfaces.Investigacao.Services;

public interface ISelecionaHospedaria
{
    ETipoHospedagemRepository HospedagemRepository { get; set; }
}