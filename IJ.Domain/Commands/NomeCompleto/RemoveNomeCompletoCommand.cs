using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IJ.Domain.Commands.NomeCompleto
{
    public class RemoveNomeCompletoCommand
    {
        public RemoveNomeCompletoCommand()
        {
            
        }

        public RemoveNomeCompletoCommand(Guid id, string nome, string sobrenome)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
        }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
        public Guid Id { get; private set; } 
    }
}
