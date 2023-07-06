namespace IJ.Domain.Entities;

public class Senha
{
    public Senha(string senhaAcess)
    {
        SenhaAcess = senhaAcess;
    }
    private string SenhaAcess { get; set; }
}