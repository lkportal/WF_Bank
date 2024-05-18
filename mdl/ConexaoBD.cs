using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlServerCe;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using Banco.util;
namespace Banco.mdl {
 class ConexaoBD {
        public static string caminhoPath = Application.StartupPath + @"\db\bdCadastro.sdf";
        public static string urlBD = "DataSource="+caminhoPath+";password=1234;";
        SqlCeConnection conexao = new SqlCeConnection(urlBD);


        public static void Conectar() {
            SqlCeEngine conn = new SqlCeEngine(urlBD);
            SqlCeConnection conexao = new SqlCeConnection(urlBD);
            
            try {
                if (!File.Exists(caminhoPath)) {
                    conn.CreateDatabase();
                }
               conexao.Open();
                MessageBox.Show("Conectado Banco De dados", "Conectado");
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }


        public static void Desconecta() {
            SqlCeConnection conexao = new SqlCeConnection(urlBD);
            try {
                conexao.Close();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }

        public static void CreateTable() {

            SqlCeConnection conexao = new SqlCeConnection(urlBD);
            conexao.Open();
            string query = $"CREATE TABLE Cliente(" +
                "ID INT PRIMARY KEY," +
                "NOME NVARCHAR(50)," +
                "EMAIL NVARCHAR(50)," +
                "RENDA NUMERIC(10,2)," +
                "PROFISSAO NVARCHAR(50)," +
                "PLANO NVARCHAR (10)," +
                "SENHA NVARCHAR(50)," +
                "CPF NVARCHAR(15)," +
                "TELEFONE NVARCHAR(15)," +
                "DATA_NASCIMENTO DATETIME" +
                ");";
            SqlCeCommand comando = new SqlCeCommand(query,conexao) ;
            try {
                
                comando.CommandText = query;
                comando.ExecuteNonQuery();
                comando.Dispose();
                MessageBox.Show($"Tabela Cliente criada");
            }catch(Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                conexao.Close();
            }  
        }

        public static void InserirDaDos(List<Cliente> dados) {
            int id = new Random(DateTime.Now.Millisecond).Next(0, 5000);
            SqlCeCommand comando = new SqlCeCommand();
            SqlCeConnection conexao = new SqlCeConnection(urlBD);
            conexao.Open();
            comando.Connection = conexao;
            foreach (Cliente cliente in dados) {
                comando.CommandText = "INSERT INTO CLIENTE (ID, NOME, EMAIL, RENDA, PROFISSAO, PLANO, SENHA, CPF, TELEFONE, DATA_NASCIMENTO) " +
                                      "VALUES (@id, @nome, @Email, @Renda, @Profissao, @Plano, @Senha, @cpf, @Telefone, @DataNascimento)";

                comando.Parameters.AddWithValue("@id", id++);
                comando.Parameters.AddWithValue("@nome", Cliente.Nome);
                comando.Parameters.AddWithValue("@Email", cliente.Email);
                comando.Parameters.AddWithValue("@Renda", cliente.Renda);
                comando.Parameters.AddWithValue("@Profissao", cliente.Profisso);
                comando.Parameters.AddWithValue("@Plano", Cliente.Plano);
                comando.Parameters.AddWithValue("@Senha", cliente.Senha);
                comando.Parameters.AddWithValue("@cpf", cliente.cpf);
                comando.Parameters.AddWithValue("@Telefone", cliente.Telefone);
                comando.Parameters.AddWithValue("@DataNascimento", cliente.DataNascimento);
    
              
                comando.ExecuteNonQuery();
                comando.Dispose();
                MessageBox.Show("Cliente Inserido");
            }
            conexao.Close();
        } 


    }
}
