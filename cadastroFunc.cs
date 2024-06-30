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
    public partial class cadastroFunc : Form
    {
        public cadastroFunc()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        public void limparCadFunc()
        {
            textNomeFunc.Clear();
            textCPF.Clear();
            dateDataInicioEmp.Value = DateTime.Now;
            dateDataNasc.Value = DateTime.Now;  
        }
        private void voltar_Click(object sender, EventArgs e)
        {
            home home1 = new home();
            home1.Show();
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
                     "INSERT INTO funcionarios(nomeFunc,dataNascimento,cpfFunc,dataEntradaEmpresa)" +
                     "VALUES (@nomeFunc, @dataNascimento, @cpfFunc, @dataEntradaEmpresa);", conn);
            

            comm.Parameters.Add("@nomeFunc", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@nomeFunc"].Value = textNomeFunc.Text;

            comm.Parameters.Add("@dataNascimento", System.Data.SqlDbType.Date);
            comm.Parameters["@DataNascimento"].Value = dateDataNasc.Value.Date;

            comm.Parameters.Add("@cpfFunc", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@cpfFunc"].Value = textCPF.Text;

            comm.Parameters.Add("@dataEntradaEmpresa", System.Data.SqlDbType.Date);
            comm.Parameters["@dataEntradaEmpresa"].Value = dateDataInicioEmp.Value.Date;


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
                MessageBox.Show("Funcionário Cadastrado com Sucesso!!!",
                        "INSERT",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                this.funcionariosTableAdapter.Fill(this.databaseOculosDataSet.funcionarios);

                limparCadFunc();
            }
        }

        private void dataFuncView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataFuncView_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cadastroFunc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseOculosDataSet1.funcionarios' table. You can move, or remove it, as needed.
            this.funcionariosTableAdapter.Fill(this.databaseOculosDataSet.funcionarios);

        }

        private void dateDataNasc_TextChanged(object sender, EventArgs e)
        {

        }

        private void funcionariosBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void dateDataInicioEmp_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textCPF_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnConsultarFunc_Click(object sender, EventArgs e)
        {
            SqlDataReader reader;
            SqlConnection conn = null;
            SqlCommand comm = null;
            bool bOK = true;

            //  Prepara a string de conexão com o BD
            string connectionString = Properties.Settings.Default.DatabaseOculosConnectionString;

            //  Criar uma conexão com o banco de dados
            conn = new SqlConnection(connectionString);

            // Criar o comando SQL para inserção dos dados na tabela Clientes
            comm = new SqlCommand(
                     "SELECT f.nomeFunc, f.dataNascimento, f.cpfFunc, f.dataEntradaEmpresa FROM funcionarios f WHERE f.idFunc = @idFunc", conn);

            comm.Parameters.Add("@idFunc", System.Data.SqlDbType.Int);
            comm.Parameters["@idFunc"].Value = Convert.ToInt32(textIdFunc.Text);

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
                        textNomeFunc.Text = reader["nomeFunc"].ToString();
                        dateDataNasc.Text = reader["dataNascimento"].ToString();
                        textCPF.Text = reader["cpfFunc"].ToString();
                        dateDataInicioEmp.Text = reader["dataEntradaEmpresa"].ToString();
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

        private void btnExcluirFunc_Click(object sender, EventArgs e)
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
                "DELETE FROM funcionarios WHERE idFunc = @idFunc", conn);

            comm.Parameters.Add("@idFunc", System.Data.SqlDbType.Int);
            comm.Parameters["@idFunc"].Value = Convert.ToInt32(textIdFunc.Text);

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
                MessageBox.Show("Funcionario excluído  com Sucesso!",
                        "DELETE",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                this.funcionariosTableAdapter.Fill(this.databaseOculosDataSet.funcionarios);
            }
        }

        private void btnUpdateFunc_Click(object sender, EventArgs e)
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
                "UPDATE funcionarios set nomeFunc = @nomeFunc, dataNascimento = @dataNascimento, cpfFunc = @cpfFunc, dataEntradaEmpresa = @dataEntradaEmpresa " + 
                "WHERE idFunc = @idFunc", conn);

            comm.Parameters.Add("@idFunc", System.Data.SqlDbType.Int);
            comm.Parameters["@idFunc"].Value = Convert.ToInt32(textIdFunc.Text);

            comm.Parameters.Add("@nomeFunc", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@nomeFunc"].Value = textNomeFunc.Text;

            comm.Parameters.Add("@dataNascimento", System.Data.SqlDbType.Date);
            comm.Parameters["@DataNascimento"].Value = dateDataNasc.Value.Date;

            comm.Parameters.Add("@cpfFunc", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@cpfFunc"].Value = textCPF.Text;

            comm.Parameters.Add("@dataEntradaEmpresa", System.Data.SqlDbType.Date);
            comm.Parameters["@dataEntradaEmpresa"].Value = dateDataInicioEmp.Value.Date;

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
                MessageBox.Show("Funcionário alterado com Sucesso!!!",
                        "INSERT",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                this.funcionariosTableAdapter.Fill(this.databaseOculosDataSet.funcionarios);
            }
        }
    }
}
