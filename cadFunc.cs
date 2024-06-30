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
    public partial class cadFunc : Form
    {
        public cadFunc()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public void LimparFormFunc()
        {
            textNomeFunc.Clear();
            dateDataNascimento.Text = DateTime.Now();
            textCPF.Clear();
            dateDataIngresso.Clear();

        }

        private void voltar_Click(object sender, EventArgs e)
        {

            home home1 = new home();
            home1.Show();
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
                     "INSERT INTO funcionarios(nomeFunc,dataNascimento,cpfFunc,dataEntradaEmpresa)" +
                     "VALUES (@nomeFunc, @dataNascimento, @cpfFunc, @dataEntradaEmpresa);", conn);
            ;

            comm.Parameters.Add("@nomeFunc", System.Data.SqlDbType.Date);
            comm.Parameters["@nomeFunc"].Value = textNomeFunc.Text;
            comm.Parameters.Add("@dataNascimento", System.Data.SqlDbType.Date);
            comm.Parameters["@idCategoria"].Value = Convert.ToDateTime(dateDataNascimento.Text);
            comm.Parameters.Add("@CPF", System.Data.SqlDbType.Int);
            comm.Parameters["@CPF"].Value = textCPF.Text;
            comm.Parameters.Add("@dataEntradaEmpresa", System.Data.SqlDbType.Date);
            comm.Parameters["@dataEntradaEmpresa"].Value = Convert.ToDateTime(dateDataIngresso.Text);


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
                MessageBox.Show("Funcionario Cadastrado com Sucesso!",
                        "INSERT",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                this.oculosTableAdapter.Fill(this.databaseOculosDataSet.funcionarios);

                LimparFormCat();
            }
        }

        private void cpfFunc_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
