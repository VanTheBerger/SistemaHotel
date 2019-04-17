using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaHotel.Entidades
{
    public class Cadastro
    {
        public Cadastro(string nome, string email, string sexo, string estado, string cidade, string telefone, string senha)
        {          
            Nome = nome;
            Email = email;
            Sexo = sexo;
            Estado = estado;
            Cidade = cidade;
            Telefone = telefone;
            Senha = senha;
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Sexo { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
    }
}


