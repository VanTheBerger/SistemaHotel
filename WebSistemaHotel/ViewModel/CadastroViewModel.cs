﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSistemaHotel.ViewModel
{
    public class CadastroViewModel
    {
        public int Id { get; set; }
        
        public string Nome { get; set; }

        public string Email { get; set; }

        public string Sexo { get; set; }

        public string Estado { get; set; }

        public string Cidade { get; set; }

        public string Telefone { get; set; }

        public string Senha { get; set; }
        //NetPipeStyleUriParser
    }
}
