namespace IJ.Entities.Interface;

public interface ITelefone
{
    public Guid IdTelefone { get; set; }
    public int Ddd { get; set; }
    public int NumeroTelefone { get; set; }
}