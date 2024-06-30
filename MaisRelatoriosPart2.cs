using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetoOculosV2
{
    public partial class MaisRelatoriosPart2 : Form
    {
        public MaisRelatoriosPart2()
        {
            InitializeComponent();
        }

        private void MaisRelatoriosPart2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'databaseOculosDataSet.Vw_OculosPorFonecedorCidade' table. You can move, or remove it, as needed.
            this.vw_OculosPorFonecedorCidadeTableAdapter.Fill(this.databaseOculosDataSet.Vw_OculosPorFonecedorCidade);
            // TODO: This line of code loads data into the 'databaseOculosDataSet.OculosDeletados' table. You can move, or remove it, as needed.
            this.oculosDeletadosTableAdapter.Fill(this.databaseOculosDataSet.OculosDeletados);

        }

        private void voltar_Click(object sender, EventArgs e)
        {
            MaisRelatorios mais1 = new MaisRelatorios();
            mais1.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
