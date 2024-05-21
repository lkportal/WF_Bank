using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco.util {
  class SistemaBanco:Cliente {

        public static string Plano { get; set; }  
        private static double saldo =0;
        private static double taxaSaque;
        private static double juros;
        private static double taxaManutencao;
        public static double DepositoIncial { get;  set; }

        public static double Saldo {
            get { return saldo; }
            private set { saldo = value; }
          
        }
        public SistemaBanco(string nome, string email, double renda, string profisso, string senha, string cpf, string telefone, string dataNascimento,double deposito) {
            Nome = nome;
            Email = email;
            Renda = renda;
            Profisso = profisso;
            Senha = senha;
            this.cpf = cpf;
            Telefone = telefone;
            DataNascimento = dataNascimento;
            DepositoIncial = deposito;
        }
        public SistemaBanco(string nome, string email, double renda, string profisso, string senha, string cpf, string telefone, string dataNascimento) {
            Nome = nome;
            Email = email;
            Renda = renda;
            Profisso = profisso;
            Senha = senha;
            this.cpf = cpf;
            Telefone = telefone;
            DataNascimento = dataNascimento;
            
        }

        public static void Depositar(double valor) {
            if(valor < 0) {
                MessageBox.Show("Valor inconsistente");
            }
            else {
                Saldo += valor;
            }

        }
        public  static    void Sacar(double valor) {
            if (Plano.Equals("Essencial", StringComparison.OrdinalIgnoreCase)) {
                taxaSaque = 0.05;
                Saldo -= (valor * taxaSaque);
            } else if (Plano.Equals("Premiun", StringComparison.OrdinalIgnoreCase)) {
                taxaSaque = 0.02;
                Saldo -= (valor * taxaSaque);
            }
            else {
                taxaSaque = 0.1;
                Saldo -= (valor * taxaSaque);
            }

        }

    }
}
