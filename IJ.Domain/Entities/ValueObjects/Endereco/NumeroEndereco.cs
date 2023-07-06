using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IJ.Domain.Entities.ValueObjects.Endereco
{
    public class NumeroEndereco : Entity
    {
        public NumeroEndereco(int numeroEndereco)
        {
            Numero = numeroEndereco;
        }
        private int Numero { get; set; }
    }
}
