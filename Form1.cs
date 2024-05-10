using Banco.util;
using Banco.View;
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
        double rendas;
        


        public Form1() {
            InitializeComponent();
            clientes= new List<Cliente>();  
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {

            if (txtNome.Text.Equals("") || txtEmail.Text.Equals("") || txtData.Text.Equals("") ||
                 txtProfissao.Text.Equals("") || txtRendas.Text.Equals("") || txtTelefone.Text.Equals("")
                 || txtSenha.Text.Equals("") || txtCPF.Text.Equals("")) {
                MessageBox.Show("Prencha os campo vazios!");
                txtNome.Focus();  
                return;
            }
            else {
                clientes.Add(new Cliente(txtNome.Text, txtEmail.Text, rendas, txtProfissao.Text,plano,txtSenha.Text,txtCPF.Text,txtTelefone.Text,txtData.Text));
                rendas = double.Parse(txtRendas.Text);
                txtLemail.Text = txtEmail.Text;
                txtLsenha.Text = txtLsenha.Text;

            }


           
            txtNome.Text = "";
            txtEmail.Text = "";
            txtCPF.Text = "";
            txtData.Text = "";
            txtProfissao.Text = "";
            txtSenha.Text = "";
            txtRendas.Text = "";

        }

        private void btnEntrar_Click(object sender, EventArgs e) {
            foreach(Cliente cliente in clientes) {

                if (txtLemail.Text.Equals(cliente.Email) && txtLsenha.Text.Equals(cliente.Senha)) {
                    TelaPlano tela = new TelaPlano();
                    tela.ShowDialog();
                    this.Close();
                  
                }
                else{
                    MessageBox.Show("Email ou Senha incorretas ");
                }

            }
        }
    }
}
