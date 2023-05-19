using IJ.Domain.Entities.ValueObjects;
using IJ.Domain.Validation.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentValidation;
using System.Security.Cryptography.X509Certificates;

namespace IJ.Domain.Validation
{
    public class Validator<T> : AbstractValidator<T>
    {
        public T Valor { get; set; }

        public Validator(T valor)
        {
            var validation = Activator.CreateInstance(typeof(T));
            var validationResult = ((AbstractValidator<T>)validation).Validate(valor);
            if (!validationResult.IsValid)
            {
                var errorMessages = string.Join(", ", validationResult.Errors);
                Console.WriteLine($"Validation failed: {errorMessages}");
            }
            else
            {
                Console.WriteLine("Validation passed");
            }
        }
    }
}
