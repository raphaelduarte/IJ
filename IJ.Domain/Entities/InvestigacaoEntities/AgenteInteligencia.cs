namespace IJ.Domain.Entities.Investigacao;

public class AgenteInteligencia : Entity
{
    public AgenteInteligencia(Guid usuarioId)
    {
        UsuarioId = usuarioId;
    }
    private Guid UsuarioId;
    public List<Enum> ClassificacaoAgenteInteligencia { get; set; }
    public List<Guid> InvestigacoesList { get; set; }
}