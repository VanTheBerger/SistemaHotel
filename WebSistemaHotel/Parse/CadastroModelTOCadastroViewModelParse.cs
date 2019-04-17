using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebSistemaHotel.Models;
using WebSistemaHotel.ViewModel;

namespace WebSistemaHotel.Parse
{
    public  class CadastroModelTOCadastroViewModelParse
    {
        public static CadastroModel Parse(CadastroViewModel cadastroVm )
        {
            var cadastro = new CadastroModel();

            cadastro.Id = cadastroVm.Id;
            cadastro.Nome = cadastroVm.Nome;
            cadastro.Email = cadastroVm.Email;
            cadastro.Sexo = cadastroVm.Sexo;
            cadastro.Estado = cadastroVm.Estado;
            cadastro.Cidade = cadastroVm.Cidade;
            cadastro.Telefone = cadastroVm.Telefone;
            cadastro.Senha = cadastroVm.Senha;

            return cadastro;
        }
    }
}
