using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco.util {
     class Cliente {

        public static string Nome { get; set; }
        public string Email { get; set; }
        public double Renda { get; set; }
        public string Profisso { get; set; }
        public static string Plano { get; set; } = "Basico";
        public string Senha { get;  set; }
        public string cpf { get;  set; }
        public string Telefone { get; set; }
        public string DataNascimento { get; set; }

        public Cliente(string nome, string email, double renda, string profisso, string senha, string cpf, string telefone, string dataNascimento) {
            Nome = nome;
            Email = email;
            Renda = renda;
            Profisso = profisso;
            Senha = senha;
            this.cpf = cpf;
            Telefone = telefone;
            DataNascimento = dataNascimento;
        }
        public Cliente() { }    
    }
}
