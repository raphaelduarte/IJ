using FluentValidation;
using IJ.Domain.Interfaces.Usuarios;
using IJ.Domain.Validation;

namespace IJ.Domain.Entities.ValueObjects;

public class Email : Entity
{
    public Email(string emailAdress)
    {
        EmailAdress = emailAdress;
    }
    private string EmailAdress { get; set; }
}
