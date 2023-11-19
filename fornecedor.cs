using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoOculosV2
{
    public partial class fornecedor : Form
    {
        public fornecedor()
        {
            InitializeComponent();
        }

        private void fornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseOculosDataSet.Fornecedores' table. You can move, or remove it, as needed.
            this.fornecedoresTableAdapter.Fill(this.databaseOculosDataSet.Fornecedores);
            // TODO: This line of code loads data into the 'databaseOculosDataSet.Cidades' table. You can move, or remove it, as needed.
            this.cidadesTableAdapter.Fill(this.databaseOculosDataSet.Cidades);

        }

        private void voltar_Click(object sender, EventArgs e)
        {
            home home1 = new home();
            home1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void cadFon_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            SqlCommand comm = null;
            bool bOK = true;

            //  Prepara a string de conexão com o BD
            string connectionString = Properties.Settings.Default.DatabaseOculosConnectionString;

            //  Criar uma conexão com o banco de dados
            conn = new SqlConnection(connectionString);

            // Criar o comando SQL para inserção dos dados na tabela Clientes
            comm = new SqlCommand(
                    "INSERT INTO Fornecedores (nomeFornecedor, idCidade) VALUES (@nomeFornecedor, @idCidade)", conn);
            ;

            comm.Parameters.Add("@idCidade", System.Data.SqlDbType.Int);
            comm.Parameters["@idCidade"].Value = Convert.ToInt32(idCidade.Text);

            comm.Parameters.Add("@nomeFornecedor", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@nomeFornecedor"].Value = nomeForn.Text;

            //tenta fazer a conexão com o banco de dados
            try
            {
                conn.Open();
            }
            catch (Exception error)
            {
                bOK = false;
                MessageBox.Show(error.Message,
                        "Erro ao tentar abrir uma conexão com o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }

            //tenta executar o comando SQL
            try
            {
                comm.ExecuteNonQuery();
            }
            catch (Exception error)
            {
                bOK = false;

                MessageBox.Show(error.Message,
                    "Erro ao tentar executar o comando SQL",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close(); // Fecha a conexão com o BD
            }

            if (bOK == true)
            {
                MessageBox.Show("Fornecedor Cadastrado com Sucesso!",
                        "INSERT",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                this.fornecedoresTableAdapter.Fill(this.databaseOculosDataSet.Fornecedores);
                nomeForn.Clear();
            }
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void consultarForn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            SqlCommand comm = null;
            SqlDataReader reader = null;
            bool bOK = true;

            //  Prepara a string de conexão com o BD
            string connectionString = Properties.Settings.Default.DatabaseOculosConnectionString;

            //  Criar uma conexão com o banco de dados
            conn = new SqlConnection(connectionString);

            // Criar o comando SQL para inserção dos dados na tabela Clientes
            comm = new SqlCommand(
            "SELECT cid.nomeCidade, forn.nomeFornecedor FROM Fornecedores forn INNER JOIN Cidades cid ON forn.idCidade = cid.idCidade"+
            " WHERE forn.idFornecedor = @idForn" 
            , conn);

            comm.Parameters.Add("@idForn", System.Data.SqlDbType.Int);
            comm.Parameters["@idForn"].Value = Convert.ToInt32(idForn.Text);


            try
            {
                // Tenta abrir uma conexão com o BD
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    bOK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar abrir uma conexão com o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                // Tenta executar o comando SQL
                try
                {
                    reader = comm.ExecuteReader();

                    if (reader.Read())
                    {
                        textCidade.Text = reader["nomeCidade"].ToString();
                        nomeForn.Text = reader["nomeFornecedor"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception error)
                {

                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                conn.Close(); // Fecha a conexão com o BD
            }
        }

        private void alterarForn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            SqlCommand comm = null;
            bool bOK = true;

            //  Prepara a string de conexão com o BD
            string connectionString = Properties.Settings.Default.DatabaseOculosConnectionString;
            //  Criar uma conexão com o banco de dados
            conn = new SqlConnection(connectionString);

            // Criar o comando SQL para inserção dos dados na tabela Clientes
            comm = new SqlCommand(
                "UPDATE Fornecedores set idCidade = @idCidade , nomeFornecedor =  @nomeFornecedor WHERE idFornecedor = @idForn"
               , conn);

            comm.Parameters.Add("@idForn", System.Data.SqlDbType.Int);
            comm.Parameters["@idForn"].Value = Convert.ToInt32(idForn.Text);
            comm.Parameters.Add("@idCidade", System.Data.SqlDbType.Int);
            comm.Parameters["@idCidade"].Value = Convert.ToInt32(idCidade.Text);
            comm.Parameters.Add("@nomeFornecedor", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@nomeFornecedor"].Value = nomeForn.Text;

            try
            {
                // Tenta abrir uma conexão com o BD
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {
                    bOK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar abrir uma conexão com o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                // Tenta executar o comando SQL
                try
                {
                    comm.ExecuteNonQuery();
                }
                catch (Exception error)
                {
                    bOK = false;

                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                conn.Close(); // Fecha a conexão com o BD
            }

            if (bOK == true)
            {
                MessageBox.Show("Fornecedor alterado com Sucesso!",
                        "UPDATE",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                this.fornecedoresTableAdapter.Fill(this.databaseOculosDataSet.Fornecedores);

                nomeForn.Clear();
            }
        }

        private void excluirFornecedor_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            SqlCommand comm = null;

            //  Prepara a string de conexão com o BD
            string connectionString = Properties.Settings.Default.DatabaseOculosConnectionString;

            //  Criar uma conexão com o banco de dados
            conn = new SqlConnection(connectionString);

            // Criar o comando SQL para inserção dos dados na tabela Clientes
            comm = new SqlCommand(
                "DELETE FROM Fornecedores where idFornecedor = @idForn"
                , conn);

            comm.Parameters.Add("@idForn", System.Data.SqlDbType.Int);
            comm.Parameters["@idForn"].Value = Convert.ToInt32(idForn.Text);


            try
            {
                // Tenta abrir uma conexão com o BD
                try
                {
                    conn.Open();
                }
                catch (Exception error)
                {


                    MessageBox.Show(error.Message,
                        "Erro ao tentar abrir uma conexão com o Banco de Dados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }

                // Tenta executar o comando SQL
                try
                {
                    comm.ExecuteNonQuery();


                }
                catch (Exception error)
                {

                    MessageBox.Show(error.Message,
                        "Erro ao tentar executar o comando SQL",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
            catch { }
            finally
            {
                conn.Close(); // Fecha a conexão com o BD
                MessageBox.Show("Fornecedor excluído!",
                        "DELETE",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                this.fornecedoresTableAdapter.Fill(this.databaseOculosDataSet.Fornecedores);
            }
        }
    }
    
}
