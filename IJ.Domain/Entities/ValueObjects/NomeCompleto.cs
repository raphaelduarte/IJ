using Flunt.Notifications;
using IJ.Domain.Interfaces.Usuarios;
using IJ.Domain.Validation.ValueObjects;

namespace IJ.Domain.Entities.ValueObjects;

public class NomeCompleto : INomeCompletoRepository
{
    public Guid IdNomeCompleto { get; set; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }

    public NomeCompleto(Guid idNomeCompleto, Notifiable<Notification> nome, Notifiable<Notification> sobrenome, NomeCompletoValidation nomeCompletoValidation)
    {
        nomeCompletoValidation.AddNotifications(nome,sobrenome);
    }
}