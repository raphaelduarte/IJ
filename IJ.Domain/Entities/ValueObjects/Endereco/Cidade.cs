using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IJ.Domain.Entities.ValueObjects.Endereco
{
    public class Cidade : Entity
    {
        public Cidade(string cidade)
        {
            CidadeName = cidade;
        }
        private string CidadeName { get; set; }
    }
}
