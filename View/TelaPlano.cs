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
    public partial class TelaPlano : Form {

        public TelaPlano() {
            InitializeComponent();
            
        }
        public static double renda;
        private void radioButton1_CheckedChanged(object sender, EventArgs e) {
            if(radioBasico.Checked) {
                txtPlanoInformation.Visible = true;
                txtPlanoInformation.Text = TxtPlano("Basico", 0.1, 0.02, renda);
                
            }
            else {
                txtPlanoInformation.Visible = false;
            }
        }

        private string TxtPlano(string plano,double taxa,double juros,double renda) {
            return $"Plano: {plano} \nTaxa de saque:{taxa:2}\nJuros ao mes{juros:2} Sua renda:{renda} "; 
        
        }

        private void radioEssencial_CheckedChanged(object sender, EventArgs e) {
            if (radioEssencial.Checked) {
                txtPlanoInformation.Visible = true;
                txtPlanoInformation.Text = TxtPlano("Essencial", 0.05, 0.04,renda);
                if ( renda>= 5000) {
                    Cliente.Plano = "Essencial";
                }
                else {
                    MessageBox.Show("Renda Insuficiente para plano Esencial");
                    radioEssencial.Checked = false;
                }



            }
            else {
                txtPlanoInformation.Visible = false;
            }
        }

        private void radioPremiun_CheckedChanged(object sender, EventArgs e) {
            if (radioPremiun.Checked) {
                txtPlanoInformation.Visible = true;
                txtPlanoInformation.Text = TxtPlano("Premiun", 0.02, 0.07, renda);
                if ( renda >= 25000) {
                    Cliente.Plano = "Premiun";
                }
                else {
                    MessageBox.Show("Renda Insuficiente para plano Premiun");
                    radioPremiun.Checked = false;   
                }
              
               
               
            }
            else {
                txtPlanoInformation.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e) {
            if(Cliente.Plano != null) {
                this.Close();
                Home home = new Home();
                home.ShowDialog();
            }
            else {
                MessageBox.Show("Seleciona seu Plano!");
            }
        }
    }
}
