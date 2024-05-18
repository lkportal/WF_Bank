using Banco.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco.View {
    public partial class Home : Form {

        
        public Home() {
            InitializeComponent();


        }
        
        private void Home_Load(object sender, EventArgs e) {
            labelNome.Text = Cliente.Nome;
            labelPlano.Text = Cliente.Plano;
            labelSaldo.Text = SistemaBanco.Saldo.ToString();
        }

        private void btnDeposita_Click(object sender, EventArgs e) {


            SistemaBanco.Depositar(double.Parse(txtDeposita.Text));

        }

        private void btnSaca_Click(object sender, EventArgs e) {
            SistemaBanco.Sacar(double.Parse(txtSacar.Text));
        }
    }
}
