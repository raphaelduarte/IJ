using IJ.Entities.Interface;

namespace IJ.Entities.Service;

public class Telefone : ITelefone
{
    public Guid IdTelefone { get; set; }
    public int Ddd { get; set; }
    public int NumeroTelefone { get; set; }
}