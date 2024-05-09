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

namespace Banco {
    public partial class Form1 : Form {
        List<Cliente> clientes;

        string plano;
        


        public Form1() {
            InitializeComponent();
            clientes= new List<Cliente>();  
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {

            if (txtNome.Text.Equals("") || txtEmail.Text.Equals("") || txtData.Text.Equals("") ||
                 txtProfissao.Text.Equals("") || txtRenda.Text.Equals("") || txtTelefone.Text.Equals("")
                 || txtSenha.Text.Equals("") || txtCPF.Text.Equals("")) {
                MessageBox.Show("Prencha os campo vazios!");
                txtNome.Focus();  
                return;
            }
            else {
                clientes.Add(new Cliente() { Nome = txtNome.Text });
                clientes.Add(new Cliente() { Email = txtEmail.Text });  
                list.Text+=txtNome.Text;
                list.Text+=txtEmail.Text;
            }
        }


        public string TextoInformativoPlano(double taxa, int juro, string plano) {
            return String.Format("Plano {0}\n Taxa de Saque: {1:N2}%\n Juros ao Mes {2}%",plano,taxa,juro);
        }


        private void radioBasico_CheckedChanged(object sender, EventArgs e) {
            if (radioBasico.Checked) {
                plano = "Basico";
                list.Visible = true;
                list.Text = TextoInformativoPlano(0.10, 2, "Basico");
            }
            else {
                list.Visible = false;
            }
        }

        private void radioEssencial_CheckedChanged(object sender, EventArgs e) {
            if (radioEssencial.Checked) {
                plano = "Essencial";
                list.Visible = true;
                list.Text = TextoInformativoPlano(0.05, 4, "Essencial");
            }
            else {
                list.Visible = false;
            }
        }

        private void radioPremiun_CheckedChanged(object sender, EventArgs e) {
            if (radioPremiun.Checked) {
                plano = "Premiun";
                list.Visible = true;
                list.Text = TextoInformativoPlano(0.02, 7, "Premiun");
            }
            else {
                list.Visible = false;
            }
            
        }
    }
}
