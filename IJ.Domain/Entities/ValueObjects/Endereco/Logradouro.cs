using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IJ.Domain.Entities.ValueObjects.Endereco
{
    public class Logradouro : Entity
    {
        public Logradouro(string logradouroName)
        {
            LogradouroName = logradouroName;
        }
        private string LogradouroName;
    }
}
