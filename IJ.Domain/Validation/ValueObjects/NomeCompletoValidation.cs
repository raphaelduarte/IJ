using Flunt.Br;
using Flunt.Notifications;
using IJ.Domain.Interfaces.Usuarios;

namespace IJ.Domain.Validation.ValueObjects;

public class NomeCompletoValidation : Notifiable<Notification>
{

    public NomeCompletoValidation(string nome, string sobrenome)
    {
        AddNotifications(new Contract()
            .Requires()
            .IsLowerThan(
            nome, 
            40, 
            "NomeCompletoRepository.Nome", 
            "Nome deve ter menos de 40 caracteres"));
        
        AddNotifications(new Contract()
            .Requires()
            .IsGreaterThan(
                nome,
                2, 
                "NomeCompletoRepository.Nome", 
                "O nome deve possuir mais de 2 caracteres"));
        
        
        
        
        
        AddNotifications(new Contract()
            .Requires()
            .IsLowerThan(
                sobrenome, 
                256, 
                "NomeCompletoRepository.Sobrenome", 
                "O sobrenome deve possuir menos de 256 caracteres"));
        
        AddNotifications(new Contract()
            .Requires()
            .IsGreaterThan(
                sobrenome,
                30,
                "NomeCompletoRepository.Sobrenome",
                "O sobrenome deve possuir mais de 30 caracteres"));
    }
}