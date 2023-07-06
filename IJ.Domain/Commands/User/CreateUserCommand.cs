using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using FluentValidation;
using IJ.Domain.Interfaces.Usuarios;

namespace IJ.Domain.Commands.User
{
    public class CreateUserCommand
    {
        public CreateUserCommand() { }

        public CreateUserCommand
        (IUsuarioRepository usuario)
        {
            NomeUsuario = usuario.NomeCompletoRepository.Nome;
            SobrenomeUsuario = usuario.NomeCompletoRepository.Sobrenome;
            CpfUsuario = usuario.CpfRepository.NumeroCpf;
            EmailUsuario = usuario.EmailRepository.Email;
            

        }

        private string NomeUsuario { get; set; }
        private string SobrenomeUsuario { get; set; }
        private long CpfUsuario { get; set; }
        private string EmailUsuario { get; set;}
        private int Ddd { get; set; }
        private long _telefoneUsuario { get;set; }

        private string _rua { get; set; }
        private int _numeroEndereco { get; set; }
        private string _bairro { get; set; }
        private string _cidade { get; set; }
        private string _estado { get; set; }
        private string _pais { get; set; }
    }
}
