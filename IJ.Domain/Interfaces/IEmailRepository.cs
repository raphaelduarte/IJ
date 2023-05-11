namespace IJ.Domain.Interfaces.Usuarios;

public interface IEmailRepository
{
    public Guid IdEmailRepository { get; set; }
    public string Email { get; set; }
}