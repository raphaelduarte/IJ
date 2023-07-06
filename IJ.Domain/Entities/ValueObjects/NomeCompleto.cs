using FluentValidation;
using IJ.Domain.Interfaces.Usuarios;
using IJ.Domain.Validation;

namespace IJ.Domain.Entities.ValueObjects;

public class NomeCompleto : Entity
{
    public NomeCompleto(string nome, string sobrenome)
    {
        Nome = nome;
        Sobrenome = sobrenome;
    }
    private string Nome { get; set; }
    private string Sobrenome { get; set; }


}