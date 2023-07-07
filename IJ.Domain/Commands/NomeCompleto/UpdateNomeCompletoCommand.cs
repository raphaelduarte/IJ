using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IJ.Domain.Commands.NomeCompleto
{
    public class UpdateNomeCompletoCommand
    {
        public UpdateNomeCompletoCommand()
        {
            
        }

        public UpdateNomeCompletoCommand(Guid id, string nome, string sobrenome)
        {
            Id = id;
            Nome = nome;
            Sobrenome = sobrenome;
        }
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
    }
}
