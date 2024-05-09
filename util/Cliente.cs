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
        public string Senha { get; private set; }
        public string cpf { get; private set; }
        private string Telefone { get; set; }
        public string DataNascimento { get; set; }


        


    }
}
