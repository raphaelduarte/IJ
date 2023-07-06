using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IJ.Domain.Entities.ValueObjects.Endereco
{
    public class Estado : Entity
    {
        public Estado(string estado)
        {
            EstadoName = estado;
        }
        private string EstadoName { get; set; }
    }
}
