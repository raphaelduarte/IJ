using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using IJ.Domain.Commands;
using IJ.Domain.Commands.Contracts;
using IJ.Domain.Commands.NomeCompleto;
using IJ.Domain.Entities.ValueObjects;
using IJ.Domain.Handlers.Contracts;
using IJ.Domain.Repositories;

namespace IJ.Domain.Handlers
{
    public class NomeCompletoHandler : 
        IHandler<CreateNomeCompletoCommand>,
        IHandler<UpdateNomeCompletoCommand>,
        IHandler<RemoveNomeCompletoCommand>
    {
        private readonly INomeCompletoRepository _nomeCompletoRepository;

        public NomeCompletoHandler(INomeCompletoRepository nomeCompletoRepository)
        {
            _nomeCompletoRepository = nomeCompletoRepository;
        }
        public ICommandResult Handler(CreateNomeCompletoCommand command)
        {
            var nomeCompleto = new NomeCompleto(command.Nome, command.Sobrenome);
            _nomeCompletoRepository.Create(nomeCompleto);

            return new GenericCommandResult(true, "Nome Completo salvo", nomeCompleto);

        }

        public ICommandResult Handler(UpdateNomeCompletoCommand command)
        {
            throw new NotImplementedException();
        }

        public ICommandResult Handler(RemoveNomeCompletoCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
