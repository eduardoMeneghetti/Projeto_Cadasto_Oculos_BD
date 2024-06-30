using System;
using System.Windows.Forms;

namespace projetoOculosV2
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }

        private void categoria_Click(object sender, EventArgs e)
        {
            categoria categoriaCat = new categoria();
            categoriaCat.Show();
        }

        private void fornecedor_Click(object sender, EventArgs e)
        {
            fornecedor cadForn = new fornecedor();
            cadForn.Show();
        }

        private void oculos_Click(object sender, EventArgs e)
        {
            oculos cadOculos = new oculos();
            cadOculos.Show();
        }

        private void cidade_Click(object sender, EventArgs e)
        {
            cidade cadCidade = new cidade();
            cadCidade.Show();
        }

        private void relatorios_Click(object sender, EventArgs e)
        {
            pesquisas pesquisas = new pesquisas();
            pesquisas.Show();
        }

        private void cadFunc_Click(object sender, EventArgs e)
        {
            cadastroFunc cadFun = new cadastroFunc();
            cadFun.Show();
        }
    }
}
