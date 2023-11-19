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
    public partial class categoria : Form
    {
        public categoria()
        {
            InitializeComponent();
        }
        private void LimparFormCat()
        {
            nomeCat.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseOculosDataSet.Categorias' table. You can move, or remove it, as needed.
            this.categoriasTableAdapter.Fill(this.databaseOculosDataSet.Categorias);

        }

        private void btnCat_Click(object sender, EventArgs e)
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
                    "INSERT INTO Categorias(nomeCategoria) values(@nomeCategoria)", conn);
            ;

            comm.Parameters.Add("@nomeCategoria", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@nomeCategoria"].Value = nomeCat.Text;

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
                MessageBox.Show("Categoria Cadastrada com suceso!",
                        "INSERT",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                this.categoriasTableAdapter.Fill(this.databaseOculosDataSet.Categorias);

                LimparFormCat();
            }
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.categoriasTableAdapter.FillBy(this.databaseOculosDataSet.Categorias);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.categoriasTableAdapter.Fill(this.databaseOculosDataSet.Categorias);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.categoriasTableAdapter.FillBy(this.databaseOculosDataSet.Categorias);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void voltar_Click(object sender, EventArgs e)
        {
            home home1 = new home();
            home1.Show();
        }

        private void btn_consultar_Click(object sender, EventArgs e)
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
                "SELECT nomeCategoria FROM Categorias WHERE idCategoria = @idCategoria"
                , conn);

            comm.Parameters.Add("@idCategoria", System.Data.SqlDbType.Int);
            comm.Parameters["@idCategoria"].Value = Convert.ToInt32(textIdCategoria.Text);


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
                        nomeCat.Text = reader["nomeCategoria"].ToString();
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

        private void alterarCat_Click(object sender, EventArgs e)
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
                "UPDATE Categorias SET nomeCategoria = @nomeCategoria WHERE idCategoria = @idCategoria"
               , conn);

            comm.Parameters.Add("@idCategoria", System.Data.SqlDbType.Int);
            comm.Parameters["@idCategoria"].Value = Convert.ToInt32(textIdCategoria.Text);
            comm.Parameters.Add("@nomeCategoria", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@nomeCategoria"].Value = nomeCat.Text;


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
                MessageBox.Show("Categoria alterada com Sucesso!",
                        "UPDATE",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                this.categoriasTableAdapter.Fill(this.databaseOculosDataSet.Categorias);

                LimparFormCat();
            }
        }

        private void excluirCat_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            SqlCommand comm = null;

            //  Prepara a string de conexão com o BD
            string connectionString = Properties.Settings.Default.DatabaseOculosConnectionString;

            //  Criar uma conexão com o banco de dados
            conn = new SqlConnection(connectionString);

            // Criar o comando SQL para inserção dos dados na tabela Clientes
            comm = new SqlCommand(
                "DELETE FROM Categorias WHERE idCategoria = @idCategoria"
                , conn);

            comm.Parameters.Add("@idCategoria", System.Data.SqlDbType.Int);
            comm.Parameters["@idCategoria"].Value = Convert.ToInt32(textIdCategoria.Text);


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
                MessageBox.Show("Categoria excluída!",
                        "DELETE",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                this.categoriasTableAdapter.Fill(this.databaseOculosDataSet.Categorias);
            }
        }
    }
}
