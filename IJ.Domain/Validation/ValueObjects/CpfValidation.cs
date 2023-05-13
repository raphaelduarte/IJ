using Flunt.Br;
using Flunt.Br.Extensions;
using Flunt.Notifications;
using IJ.Domain.Interfaces.Usuarios;

namespace IJ.Domain.Validation.ValueObjects;

public class CpfValidation : Notifiable<Notification>
{
    public CpfValidation(string cpf)
    {
        AddNotifications(new Contract().
            IsCpf(cpf,
                "CpfRepository",
                "Cpf inválido"));
    }
}