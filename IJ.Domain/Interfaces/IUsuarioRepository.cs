namespace IJ.Domain.Interfaces.Usuarios;

public interface IUsuarioRepository
{
    public Guid IdUsuarioRepository { get; set; }
    void CriarUsuario();
    void AtualizarUsuario();
}