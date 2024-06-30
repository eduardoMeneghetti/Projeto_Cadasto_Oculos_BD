using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoOculosV2
{
    public partial class oculos : Form
    {
        public oculos()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void LimparFormCat()
        {
            textGrau.Clear();
            textModelo.Clear();
            textPreco.Clear();
            textQtdGrau.Clear();
            textNomeOculos.Clear();
            textModelo.Clear();
        }

        private void voltar_Click(object sender, EventArgs e)
        {
            home home1 = new home();
            home1.Show();
        }

        private void oculos_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseOculosDataSet.Oculos' table. You can move, or remove it, as needed.
            this.oculosTableAdapter.Fill(this.databaseOculosDataSet.Oculos);
            // TODO: This line of code loads data into the 'databaseOculosDataSet.Fornecedores' table. You can move, or remove it, as needed.
            this.fornecedoresTableAdapter.Fill(this.databaseOculosDataSet.Fornecedores);
            // TODO: This line of code loads data into the 'databaseOculosDataSet.Categorias' table. You can move, or remove it, as needed.
            this.categoriasTableAdapter.Fill(this.databaseOculosDataSet.Categorias);

        }

        private void cadOcu_Click(object sender, EventArgs e)
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
                     "INSERT INTO Oculos (nomeOculos, idCategoria, idFornecedor, modeloOculos, possuiGrau, qtdGrau, precoOculos)" +
                     "VALUES (@nomeOculos, @idCategoria, @idFornecedor, @modeloOculos, @possuiGrau, @qtdGrau, @precoOculos);", conn);
            ;

            comm.Parameters.Add("@nomeOculos", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@nomeOculos"].Value = textNomeOculos.Text;
            comm.Parameters.Add("@idCategoria", System.Data.SqlDbType.Int); 
            comm.Parameters["@idCategoria"].Value = Convert.ToInt32(idCategoria.Text);
            comm.Parameters.Add("@idFornecedor", System.Data.SqlDbType.Int); 
            comm.Parameters["@idFornecedor"].Value = Convert.ToInt32(idFornecedor.Text);
            comm.Parameters.Add("@modeloOculos", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@modeloOculos"].Value = textModelo.Text;
            comm.Parameters.Add("@possuiGrau", System.Data.SqlDbType.Char, 1);
            comm.Parameters["@possuiGrau"].Value = Convert.ToChar(textGrau.Text);
            comm.Parameters.Add("@qtdGrau", System.Data.SqlDbType.Float);
            comm.Parameters["@qtdGrau"].Value = float.Parse(textQtdGrau.Text);
            comm.Parameters.Add("@precoOculos", System.Data.SqlDbType.Money);
            comm.Parameters["@precoOculos"].Value = Convert.ToDouble(textPreco.Text);



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
                MessageBox.Show("Óculos cadastrado com Sucesso!",
                        "INSERT",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                this.oculosTableAdapter.Fill(this.databaseOculosDataSet.Oculos);

                LimparFormCat();
            }
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
                "SELECT cat.nomeCategoria, forn.nomeFornecedor, oc.nomeOculos, oc.modeloOculos, oc.precoOculos, oc.possuiGrau, oc.qtdGrau"+
                " FROM Oculos oc INNER JOIN Fornecedores forn ON oc.idFornecedor = forn.idFornecedor" +
                " INNER JOIN Categorias cat ON oc.idCategoria = cat.idCategoria WHERE oc.idOculos = @idOculos"
                , conn);

            comm.Parameters.Add("@idOculos", System.Data.SqlDbType.Int);
            comm.Parameters["@idOculos"].Value = Convert.ToInt32(textIdOculos.Text);


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
                        textCat.Text = reader["nomeCategoria"].ToString();
                        textFonecedor.Text = reader["nomeFornecedor"].ToString();
                        textNomeOculos.Text = reader["nomeOculos"].ToString();
                        textModelo.Text = reader["modeloOculos"].ToString();
                        textPreco.Text = reader["precoOculos"].ToString();
                        textGrau.Text = reader["possuiGrau"].ToString();
                        textQtdGrau.Text = reader["qtdGrau"].ToString();
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

        private void alterarOcu_Click(object sender, EventArgs e)
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
                "UPDATE Oculos set idCategoria = @idCategoria, idFornecedor = @idFornecedor,  nomeOculos = @nomeOculos, modeloOculos = @modeloOculos," +
                " precoOculos = @precoOculos, possuiGrau = @possuiGrau, qtdGrau = @qtdGrau" +
                " WHERE idOculos = @idOculos"
               , conn);


            comm.Parameters.Add("@idOculos", System.Data.SqlDbType.Int);
            comm.Parameters["@idOculos"].Value = Convert.ToInt32(textIdOculos.Text);
            comm.Parameters.Add("@nomeOculos", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@nomeOculos"].Value = textNomeOculos.Text;
            comm.Parameters.Add("@idCategoria", System.Data.SqlDbType.Int);
            comm.Parameters["@idCategoria"].Value = Convert.ToInt32(idCategoria.Text);
            comm.Parameters.Add("@idFornecedor", System.Data.SqlDbType.Int);
            comm.Parameters["@idFornecedor"].Value = Convert.ToInt32(idFornecedor.Text);
            comm.Parameters.Add("@modeloOculos", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@modeloOculos"].Value = textModelo.Text;
            comm.Parameters.Add("@possuiGrau", System.Data.SqlDbType.Char, 1);
            comm.Parameters["@possuiGrau"].Value = Convert.ToChar(textGrau.Text);
            comm.Parameters.Add("@qtdGrau", System.Data.SqlDbType.Float);
            comm.Parameters["@qtdGrau"].Value = float.Parse(textQtdGrau.Text);
            comm.Parameters.Add("@precoOculos", System.Data.SqlDbType.Money);
            comm.Parameters["@precoOculos"].Value = Convert.ToDouble(textPreco.Text);

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
                MessageBox.Show("Óculos Alterado com Sucesso!",
                        "UPDATE",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                this.oculosTableAdapter.Fill(this.databaseOculosDataSet.Oculos);

                LimparFormCat();
            }
        }

        private void excluirOcu_Click(object sender, EventArgs e)
        {
            SqlConnection conn = null;
            SqlCommand comm = null;

            //  Prepara a string de conexão com o BD
            string connectionString = Properties.Settings.Default.DatabaseOculosConnectionString;

            //  Criar uma conexão com o banco de dados
            conn = new SqlConnection(connectionString);

            // Criar o comando SQL para inserção dos dados na tabela Clientes
            comm = new SqlCommand(
                "DELETE FROM Oculos WHERE idOculos = @idOculos"
                , conn);

            comm.Parameters.Add("@idOculos", System.Data.SqlDbType.Int);
            comm.Parameters["@idOculos"].Value = Convert.ToInt32(textIdOculos.Text);


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
                MessageBox.Show("Óculos excluído!",
                        "DELETE",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                this.oculosTableAdapter.Fill(this.databaseOculosDataSet.Oculos);
            }
        }

        private void dataGridOculos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void categoriasBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
