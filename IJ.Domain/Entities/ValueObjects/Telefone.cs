using FluentValidation;
using IJ.Domain.Interfaces.Usuarios;
using IJ.Domain.Validation;
using IJ.Domain.Validation.ValueObjects;

namespace IJ.Domain.Entities.ValueObjects;

public class Telefone : Entity
{
    public Telefone(int ddd, long telefoneNumber)
    {
        Ddd = ddd;
        TelefoneNumber = telefoneNumber;
    }

    private int Ddd { get; set; }
    private long TelefoneNumber { get; set; }
}