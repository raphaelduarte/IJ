using FluentValidation;
using IJ.Domain.Interfaces.Usuarios;
using IJ.Domain.Validation;
using IJ.Domain.Validation.ValueObjects;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Threading.Channels;

namespace IJ.Domain.Entities.ValueObjects;

public class Cpf : Entity
{
    public Cpf(long numeroCpf)
    {
        NumeroCpf = numeroCpf;
    }
    private long NumeroCpf { get; set; }
}