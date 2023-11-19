using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoOculosV2
{
    public partial class cidade : Form
    {
        public cidade()
        {
            InitializeComponent();
        }
        private void LimparFormCid()
        {
            nomeCid.Clear();
            nomeEst.Clear();
        }
        private void cadCid_Click(object sender, EventArgs e)
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
                    "INSERT INTO Cidades (nomeCidade, nomeEstado) VALUES (@nomeCidade, @nomeEstado);", conn);
            ;

            comm.Parameters.Add("@nomeCidade", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@nomeCidade"].Value = nomeCid.Text;

            comm.Parameters.Add("@nomeEstado", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@nomeEstado"].Value = nomeEst.Text;

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
                MessageBox.Show("Cidade Cadastrada!",
                        "INSERT",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                this.cidadesTableAdapter.Fill(this.databaseOculosDataSet.Cidades);

                LimparFormCid();
            }
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            home home1 = new home();
            home1.Show();
        }

        private void cidade_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseOculosDataSet.Cidades' table. You can move, or remove it, as needed.
            this.cidadesTableAdapter.Fill(this.databaseOculosDataSet.Cidades);

        }

        private void consultaCid_Click(object sender, EventArgs e)
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
                "SELECT nomeCidade, nomeEstado FROM Cidades WHERE idCidade = @idCidade"
                , conn);

            comm.Parameters.Add("@idCidade", System.Data.SqlDbType.Int);
            comm.Parameters["@idCidade"].Value = Convert.ToInt32(idCid.Text);


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
                        nomeCid.Text = reader["nomeCidade"].ToString();
                        nomeEst.Text = reader["nomeEstado"].ToString();
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

        private void alterarCid_Click(object sender, EventArgs e)
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
                "UPDATE Cidades SET nomeCidade = @nomeCidade, nomeEstado = @nomeEstado WHERE idCidade = @idCidade"
               , conn);

            comm.Parameters.Add("@idCidade", System.Data.SqlDbType.Int);
            comm.Parameters["@idCidade"].Value = Convert.ToInt32(idCid.Text);

            comm.Parameters.Add("@nomeCidade", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@nomeCidade"].Value = nomeCid.Text;

            comm.Parameters.Add("@nomeEstado", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@nomeEstado"].Value = nomeEst.Text;


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
                MessageBox.Show("Cidade Alterado com Sucesso!",
                        "UPDATE",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                this.cidadesTableAdapter.Fill(this.databaseOculosDataSet.Cidades);

                LimparFormCid();
            }
        }

        private void excluirCid_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            SqlCommand comm = null;

            //  Prepara a string de conexão com o BD
            string connectionString = Properties.Settings.Default.DatabaseOculosConnectionString;

            //  Criar uma conexão com o banco de dados
            conn = new SqlConnection(connectionString);

            // Criar o comando SQL para inserção dos dados na tabela Clientes
            comm = new SqlCommand(
                "DELETE FROM Cidades WHERE idCidade = @idCidade"
                , conn);


            comm.Parameters.Add("@idCidade", System.Data.SqlDbType.Int);
            comm.Parameters["@idCidade"].Value = Convert.ToInt32(idCid.Text);


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
                MessageBox.Show("Cidade excluída!",
                        "DELETE",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                this.cidadesTableAdapter.Fill(this.databaseOculosDataSet.Cidades);
            }
        }
    }

}
