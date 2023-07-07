using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IJ.Domain.Commands.NomeCompleto
{
    public class CreateNomeCompletoCommand
    {
        public CreateNomeCompletoCommand()
        {

        }

        public CreateNomeCompletoCommand(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        public string Nome { get; private set; }
        public string Sobrenome { get; private set; }
    }
}
