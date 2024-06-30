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
    public partial class pesquisas : Form
    {
        public pesquisas()
        {
            InitializeComponent();
        }


        private void voltar_Click(object sender, EventArgs e)
        {
            home home1 = new home();
            home1.Show();
        }

        private void fornecedoresDeletados_Click(object sender, EventArgs e)
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
                    "SELECT * FROM FornecedoresDeletados", conn);
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pesquisas_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseOculosDataSet1.FornecedoresDeletados' table. You can move, or remove it, as needed.
            this.fornecedoresDeletadosTableAdapter.Fill(this.databaseOculosDataSet1.FornecedoresDeletados);
            // TODO: This line of code loads data into the 'databaseOculosDataSet.buscarOculosCategoria' table. You can move, or remove it, as needed.
            this.buscarOculosCategoriaTableAdapter.Fill(this.databaseOculosDataSet.buscarOculosCategoria);

        }

        private void maisRelatórios_Click(object sender, EventArgs e)
        {
            MaisRelatorios maisRelatorios1 = new MaisRelatorios();
            maisRelatorios1.Show();
        }
    }
}
