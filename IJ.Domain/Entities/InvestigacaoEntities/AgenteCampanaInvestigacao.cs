using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IJ.Domain.Entities.InvestigacaoEntities
{
    public class AgenteCampanaInvestigacao : Entity
    {
        public AgenteCampanaInvestigacao(Guid agenteCampana, Guid investigacao)
        {
            AgenteCampana = agenteCampana;
            Investigacao = investigacao;
        }
        private Guid AgenteCampana { get; set;}
        private Guid Investigacao { get; set;}
    }
}
