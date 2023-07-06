using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IJ.Domain.Entities.InvestigacaoEntities
{
    public class AgenteInteligenciaInvestigacao : Entity
    {
        public AgenteInteligenciaInvestigacao(Guid investigacao, Guid agenteInteligencia)
        {
            Investigacao = investigacao;

            AgenteInteligencia = agenteInteligencia;
        }
        private Guid Investigacao { get; set; }
        private Guid AgenteInteligencia { get; set; }
    }
}
