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
using System.Data;
using System.Collections;

namespace Banco.mdl {
 class ConexaoBD {
        public static string caminhoPath = Application.StartupPath + @"\db\bdCadastro.sdf";
        public static string urlBD = "DataSource="+caminhoPath+";password=1234;";

        int checandoLinha;

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
            string query = $"CREATE TABLE CLIENTE(" +
                "ID INT PRIMARY KEY IDENTITY," +
                "NOME NVARCHAR(50)," +
                "EMAIL NVARCHAR(50)," +
                "RENDA NUMERIC(10,2)," +
                "PROFISSAO NVARCHAR(50)," +
                "SENHA NVARCHAR(50)," +
                "CPF NVARCHAR(15)," +
                "TELEFONE NVARCHAR(15)," +
                "DATA_NASCIMENTO DATETIME" +
                ")";
            string query2 = $"CREATE TABLE SISTEMA_BANCO" +
                $"(" +
                $"ID INT PRIMARY KEY IDENTITY," +
                $"PLANO NVARCHAR(10)," +
                $"SALDO NUMERIC(20,2)," +
                $"TAXA_MANUTENCAO NUMERIC(10,2)," +
                $"TAXA_JUROS NUMERIC(10,2)," +
                $"TAXA_SAQUE NUMERIC(10,2)," +
                $"CLIENTE_FK INT," +
                $"FOREIGN KEY (CLIENTE_FK) REFERENCES CLIENTE(ID) " +
                $")";

       
            try {

                using SqlCeCommand comando = new SqlCeCommand(query, conexao);
                comando.ExecuteNonQuery();
                comando.Dispose();
                using SqlCeCommand comando1 = new SqlCeCommand(query2, conexao);
                comando1.ExecuteNonQuery(); 
                comando1.Dispose();
                MessageBox.Show($"Tabela Cliente criada");
            }catch(Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                conexao.Close();
            }  
        }
      public static void InserirDadosTBSistemabanco(double saldo,int id) {
            SqlCeCommand comando = new SqlCeCommand();
            SqlCeConnection conexao = new SqlCeConnection(urlBD);
            conexao.Open();
            string query = "INSERT INTO SISTEMA_BANCO (PLANO,SALDO,TAXA_MANUTENCAO,TAXA_JUROS,TAXA_SAQUE,CLIENTE_FK) VALUES (@PLANO,@SALDO,@TAXA_MANUTENCAO," +
                "@TAXA_JUROS," +
                "@TAXA_SAQUE," +
                "@IDCLIENTE)";
            try {
                comando.Connection = conexao;
                comando.CommandText = query;
                if (SistemaBanco.Plano.Equals("basico",StringComparison.OrdinalIgnoreCase)) {

                    comando.Parameters.AddWithValue("@PLANO", SistemaBanco.Plano = "Básico");
                    comando.Parameters.AddWithValue("@SALDO",saldo);
                    comando.Parameters.AddWithValue("@TAXA_MANUTENCAO",0.05);
                    comando.Parameters.AddWithValue("@TAXA_JUROS",0.02);
                    comando.Parameters.AddWithValue("@TAXA_SAQUE", 0.1);
                    comando.Parameters.AddWithValue("@IDCLIENTE",id);
                    comando.Connection = conexao;
                    comando.ExecuteNonQuery();
                    comando.Dispose();
                    MessageBox.Show("Usuario inserido basico");
                   

                }
                else if (SistemaBanco.Plano.Equals("essencial", StringComparison.OrdinalIgnoreCase)) {

                    comando.Parameters.AddWithValue("@PLANO", SistemaBanco.Plano = "Essencial");
                    comando.Parameters.AddWithValue("@SALDO", saldo);
                    comando.Parameters.AddWithValue("@TAXA_MANUTENCAO", 0.07);
                    comando.Parameters.AddWithValue("@TAXA_JUROS", 0.04);
                    comando.Parameters.AddWithValue("@TAXA_SAQUE", 0.05);
                    comando.Parameters.AddWithValue("@IDCLIENTE", id);
                    comando.Connection = conexao;
                    comando.ExecuteNonQuery();
                    comando.Dispose();
                    MessageBox.Show("Usuario inserido essencial");
                }
                else if (SistemaBanco.Plano.Equals("premiun", StringComparison.OrdinalIgnoreCase)) {

                    comando.Parameters.AddWithValue("@PLANO", SistemaBanco.Plano = "Premiun");
                    comando.Parameters.AddWithValue("@SALDO", saldo);
                    comando.Parameters.AddWithValue("@TAXA_MANUTENCAO", 0.1);
                    comando.Parameters.AddWithValue("@TAXA_JUROS", 0.07);
                    comando.Parameters.AddWithValue("@TAXA_SAQUE", 0.02);
                    comando.Parameters.AddWithValue("@IDCLIENTE", id);
                    comando.Connection = conexao;
                    comando.ExecuteNonQuery();
                    comando.Dispose();
                    MessageBox.Show("Usuario inserido premiun");
                }
                else {
                    MessageBox.Show("Plano não definido");
                }
            }catch(Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                conexao.Close();
            }
            



        }
        public static void InserirDaDos(List<SistemaBanco> dados) {
            int id = 0;
            SqlCeCommand comando = new SqlCeCommand();
            SqlCeConnection conexao = new SqlCeConnection(urlBD);
            conexao.Open();
            comando.Connection = conexao;
            foreach (SistemaBanco cliente in dados) {
                comando.CommandText = "INSERT INTO CLIENTE ( NOME, EMAIL, RENDA, PROFISSAO, SENHA, CPF, TELEFONE, DATA_NASCIMENTO) " +
                                      "VALUES ( @nome, @Email, @Renda, @Profissao, @Senha, @cpf, @Telefone, @DataNascimento)";

                
                comando.Parameters.AddWithValue("@nome", Cliente.Nome);
                comando.Parameters.AddWithValue("@Email", cliente.Email);
                comando.Parameters.AddWithValue("@Renda", cliente.Renda);
                comando.Parameters.AddWithValue("@Profissao", cliente.Profisso);
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

      

        public static bool ChecaValidacao(string email, string senha) {
           string query = "SELECT EMAIL, SENHA FROM CLIENTE WHERE EMAIL = @Email AND SENHA = @Senha";
     
            using (SqlCeConnection conexao = new SqlCeConnection(urlBD)) {
                try {
                    conexao.Open();
                    using (SqlCeCommand comando = new SqlCeCommand(query, conexao)) {
                        comando.Parameters.AddWithValue("@Email", email);
                        comando.Parameters.AddWithValue("@Senha", senha);

                        using (SqlCeDataAdapter adaptador = new SqlCeDataAdapter(comando)) {
                            DataTable dt = new DataTable();
                            adaptador.Fill(dt);
                            comando.Dispose();
                            foreach (DataRow linha in dt.Rows) {
                                if (linha["EMAIL"].Equals(email) && linha["SENHA"].Equals(senha)) {
                                    return true;
                                }
                                MessageBox.Show($"Email: {linha["EMAIL"]}, Senha: {linha["SENHA"]}");
                            }
                        }
                    }
                } catch (Exception ex) {
                    MessageBox.Show("Erro: " + ex.Message);
                } finally {
                    conexao.Close();
                    
                }
            }

            return false ;


        }
    }
}
