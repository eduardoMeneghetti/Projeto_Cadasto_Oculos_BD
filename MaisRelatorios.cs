using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoOculosV2
{
    public partial class MaisRelatorios : Form
    {
        public MaisRelatorios()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void voltar_Click(object sender, EventArgs e)
        {
            pesquisas pesquisa1 = new pesquisas();
            pesquisa1.Show();
        }

        private void pesquisarTotalPrecoCat_Click(object sender, EventArgs e)
        {
            decimal valorTotal = 0;
            int catExite = 0;

            SqlConnection conn = null;
            SqlCommand comm = null;
            bool bOK = true;

            //  Prepara a string de conexão com o BD
            string connectionString = Properties.Settings.Default.DatabaseOculosConnectionString;

            //  Criar uma conexão com o banco de dados
            conn = new SqlConnection(connectionString);

            comm = new SqlCommand(
               "SELECT COUNT(*) FROM Categorias WHERE nomeCategoria LIKE '%' + @nomeCat + '%'", conn);

            comm.Parameters.Add("@nomeCat", System.Data.SqlDbType.NVarChar);
            comm.Parameters["@nomeCat"].Value = nomeCat.Text;

            conn.Open();
            catExite = Convert.ToInt32(comm.ExecuteScalar());
            conn.Close();

            if(catExite == 0)
            {
                MessageBox.Show("Categoria digitada não existe");
            }
            else
            {

                comm = new SqlCommand(
                    "SELECT dbo.Fun_SomaOculosPorCategoria(@nomeCat)", conn);

                comm.Parameters.Add("@nomeCat", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@nomeCat"].Value = nomeCat.Text;

                conn.Open();
                valorTotal = Convert.ToDecimal(comm.ExecuteScalar());
                conn.Close();

                MessageBox.Show("O Valor total dos Óculos que estão presentes nesta categoria é R$" + valorTotal,
                            "Retornando o valor Total dos óculos",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void pesquisaColaborador_Click(object sender, EventArgs e)
        {
            int colaboradorExiste = 0;

            SqlConnection conn = null;
            SqlCommand comm = null;

            // Prepara a string de conexão com o BD
            string connectionString = Properties.Settings.Default.DatabaseOculosConnectionString;

           
                // Criar uma conexão com o banco de dados
                conn = new SqlConnection(connectionString);

                // Verificar se o colaborador existe
                comm = new SqlCommand("SELECT COUNT(*) FROM funcionarios WHERE nomeFunc LIKE '%' + @nomeFunc + '%'", conn);

                comm.Parameters.Add("@nomeFunc", System.Data.SqlDbType.NVarChar);
                comm.Parameters["@nomeFunc"].Value = textNomeColaborador.Text;

                conn.Open();
                colaboradorExiste = Convert.ToInt32(comm.ExecuteScalar());
                conn.Close();

                if (colaboradorExiste == 0)
                {
                    MessageBox.Show("Funcionário não cadastrado no sistema");
                }
                else
                {
                    // Criar o comando para chamar a stored procedure
                    comm = new SqlCommand("Proc_CalcularTempoDeCadastro", conn);
                    comm.CommandType = CommandType.StoredProcedure;

                    comm.Parameters.AddWithValue("@nomeFunc", textNomeColaborador.Text);

                    conn.Open();

                    SqlDataAdapter da = new SqlDataAdapter(comm);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

              
                    dataGridFunc.DataSource = dt;

                  
                    dataGridFunc.AutoResizeColumns();

                    conn.Close();

                }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pesquisaCatOculosID_Click(object sender, EventArgs e)
        {

            SqlConnection conn = null;
            SqlCommand comm = null;

            // Prepara a string de conexão com o BD
            string connectionString = Properties.Settings.Default.DatabaseOculosConnectionString;


            // Criar uma conexão com o banco de dados
            conn = new SqlConnection(connectionString);
         
            // Criar o comando para chamar a stored procedure
            comm = new SqlCommand("Proc_buscarOculosPorCategoria", conn);
            comm.CommandType = CommandType.StoredProcedure;

            comm.Parameters.AddWithValue("@id", Convert.ToInt32(idCat.Text));

            conn.Open();

            SqlDataAdapter da = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            da.Fill(dt);


            dataGridOculosCat.DataSource = dt;


            dataGridOculosCat.AutoResizeColumns();

            conn.Close();

            
        }

        private void textNomeCat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void idCat_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaisRelatorios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseOculosDataSet.Categorias' table. You can move, or remove it, as needed.
            this.categoriasTableAdapter.Fill(this.databaseOculosDataSet.Categorias);

        }

        private void maisRelatoriosPart2_Click(object sender, EventArgs e)
        {
            MaisRelatoriosPart2 mais2 = new MaisRelatoriosPart2();
            mais2.Show();
        }
    }

}





    

