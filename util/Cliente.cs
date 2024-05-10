using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.util {
     class Cliente {

        public string Nome { get; set; }
        public string Email { get; set; }
        public double Renda { get; set; }
        public string Profisso { get; set; }
        public string Plano { get;  set; }
        public string Senha { get;  set; }
        public string cpf { get;  set; }
        private string Telefone { get; set; }
        public string DataNascimento { get; set; }

        public Cliente(string nome, string email, double renda, string profisso, string plano, string senha, string cpf, string telefone, string dataNascimento) {
            Nome = nome;
            Email = email;
            Renda = renda;
            Profisso = profisso;
            this.Plano = null;
            Senha = senha;
            this.cpf = cpf;
            Telefone = telefone;
            DataNascimento = dataNascimento;
        }
    }
}
