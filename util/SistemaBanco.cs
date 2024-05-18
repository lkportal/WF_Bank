using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco.util {
    static class SistemaBanco {

        private static double saldo =0;
        private static double taxaSaque;
        private static double juros;


        public static double Saldo {
            get { return saldo; }
            private set { saldo = value; }
          
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
            if (Cliente.Plano.Equals("Essencial", StringComparison.OrdinalIgnoreCase)) {
                taxaSaque = 0.05;
                Saldo -= (valor * taxaSaque);
            } else if (Cliente.Plano.Equals("Premiun", StringComparison.OrdinalIgnoreCase)) {
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
