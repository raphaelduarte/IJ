using IJ.Domain.Entities.ValueObjects;
using IJ.Domain.Interfaces.Usuarios;
using IJ.Domain.Validation;
using IJ.Domain.Validation.ValueObjects;
using System.ComponentModel.DataAnnotations;
using Xunit;
using System;

namespace IJ.Domin.Tests;

public class CpfUnitTest1
{
    public ICpfRepository _cpf { get; set; }
    public CpfUnitTest1(ICpfRepository cpf, CpfValidation cpfValidation, Validator<ICpfRepository> validator)
    {
        _cpf.NumeroCpf = cpf.NumeroCpf;

        string cpfDeTeste = "14167910780";

        cpfValidation.BeValidCpf(cpfDeTeste);

        Assert.Fail(cpfDeTeste);



    }

   
    




}