using Banco.mdl;
using Banco.util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco.View {
    public partial class TelaPlano : Form {
       
        public TelaPlano() {
            InitializeComponent();
      
        }
        
        string query = "select top 1 id from cliente order by id desc ";
        public static double renda;
        int id;



        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            if (radioBasico.Checked ) {
                txtPlanoInformation.Visible = true;
                SistemaBanco.Plano = "basico";
                txtPlanoInformation.Text = TxtPlano("Basico", 0.1, 0.02, renda, "Sem valor minimo");
            }
            else {
               
                txtPlanoInformation.Visible = false;
            }
        }

        private string TxtPlano(string plano,double taxa,double juros,double renda,string valoNecessario) {
            return $"Plano: {plano} \n Taxa de saque:{taxa:2}\n Juros ao mes{juros:2} Sua renda:{renda} \n Renda Necessaria: {valoNecessario} "; 
        
        }

        private void radioEssencial_CheckedChanged(object sender, EventArgs e) {

            if ( SistemaBanco.DepositoIncial >= 200 || renda >= 5000) {
                txtPlanoInformation.Visible = true;
                SistemaBanco.Plano = "essencial";
                txtPlanoInformation.Text = TxtPlano("Essencial", 0.05, 0.04, renda, "R$5000,00");    
            }
            else {
                MessageBox.Show("Precisa deposito minimo 200 e Renda  Maior que R$5.000");
                txtPlanoInformation.Visible = false;
                radioEssencial.Checked = false;
            }



        }

        private void radioPremiun_CheckedChanged(object sender, EventArgs e) {
                    if ( SistemaBanco.DepositoIncial >= 1000 || renda >= 25000) {
                        txtPlanoInformation.Visible = true;
                        txtPlanoInformation.Text = TxtPlano("Premiun", 0.02, 0.07, renda, "R$ 25.000,00");
                        SistemaBanco.Plano = "Premiun";
                    }
                    else {
                          MessageBox.Show("Precisa deposito minimo 1000 e Renda Maior que R$ 25.000");
                          txtPlanoInformation.Visible = false;
                           radioPremiun.Checked = false;
                    }
                
           
        }

        private void button1_Click(object sender, EventArgs e) {
            try {
              using  SqlCeConnection conexao = new SqlCeConnection(ConexaoBD.urlBD);
                conexao.Open();
                SqlCeCommand cmd = new SqlCeCommand(query, conexao);
                SqlCeDataAdapter adp = new SqlCeDataAdapter(cmd);
                DataTable dt = new DataTable();
                adp.Fill(dt);
               if(dt.Rows.Count > 0) {
                    id = (int)dt.Rows[0]["ID"];  
                }

                if (!string.IsNullOrEmpty(SistemaBanco.Plano)) {
                    ConexaoBD.InserirDadosTBSistemabanco(SistemaBanco.DepositoIncial, id);
                    this.Close();
                    Home home = new Home();
                    home.ShowDialog();
                }
                else {
                    MessageBox.Show("Selecione seu Plano!");
                }
            }catch(Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                ConexaoBD.Desconecta();
            }
        }
    }
}
