using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IJ.Domain.Entities.ValueObjects.Endereco
{
    public class BairroCidade : Entity
    {
        public BairroCidade(Guid bairro, Guid cidade)
        {
            Bairro = bairro;
            Cidade = cidade;
        }
        private Guid Bairro { get; set; }
        private Guid Cidade { get; set; }
    }
}
