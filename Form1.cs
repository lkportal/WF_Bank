using Banco.mdl;
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
        List<SistemaBanco> clientes;

        double saldo;
        double rendas;

        


        public Form1() {
            InitializeComponent();
            clientes= new List<SistemaBanco>();  
        }

        private void btnCadastrar_Click(object sender, EventArgs e) {
            
            try {
                ConexaoBD.Conectar();
               

                if (txtNome.Text.Equals("") || txtEmail.Text.Equals("") || txtData.Text.Equals("") ||
               txtProfissao.Text.Equals("") || txtRendas.Text.Equals("") || txtTelefone.Text.Equals("")
               || txtSenha.Text.Equals("") || txtCPF.Text.Equals("") || txtDeposito.Text.Equals("")) {
                    MessageBox.Show("Prencha os campo vazios!");
                    txtNome.Focus();
                    return;
                }
                else {
                    rendas = double.Parse(txtRendas.Text);
                    saldo = double.Parse(txtDeposito.Text);
                    clientes.Add(new SistemaBanco(txtNome.Text, txtEmail.Text,rendas, txtProfissao.Text, txtSenha.Text, txtCPF.Text, txtTelefone.Text, txtData.Text,saldo));

                    SistemaBanco.DepositoIncial = double.Parse(txtDeposito.Text);
                    TelaPlano.renda = double.Parse(txtRendas.Text);
                    ConexaoBD.InserirDaDos(clientes);
                }

            } catch(Exception ex) { 
                MessageBox.Show(ex.Message);
            } finally {
                ConexaoBD.Desconecta();
            }

        }

        private void btnEntrar_Click(object sender, EventArgs e) {
       
                if (ConexaoBD.ChecaValidacao(txtLemail.Text, txtLsenha.Text)) {
                    TelaPlano tela = new TelaPlano();
                    tela.ShowDialog();    
                    this.Visible = false;
                  
                }
                else{
                    MessageBox.Show("Email ou Senha incorretas ");
                }

            
        }

      
    }
    }

