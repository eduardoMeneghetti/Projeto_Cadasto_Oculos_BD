namespace projetoOculosV2
{
    partial class MaisRelatoriosPart2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaisRelatoriosPart2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.voltar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.databaseOculosDataSet = new projetoOculosV2.DatabaseOculosDataSet();
            this.oculosDeletadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oculosDeletadosTableAdapter = new projetoOculosV2.DatabaseOculosDataSetTableAdapters.OculosDeletadosTableAdapter();
            this.idOculosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeOculosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloOculosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoOculosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.possuiGrauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdGrauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDeleteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.vwOculosPorFonecedorCidadeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vw_OculosPorFonecedorCidadeTableAdapter = new projetoOculosV2.DatabaseOculosDataSetTableAdapters.Vw_OculosPorFonecedorCidadeTableAdapter();
            this.idOculosDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeOculosDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloOculosDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOculosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oculosDeletadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwOculosPorFonecedorCidadeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(730, 540);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 13);
            this.label2.TabIndex = 41;
            this.label2.Text = "Verificar Óculos deletados";
            // 
            // voltar
            // 
            this.voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar.Location = new System.Drawing.Point(58, 91);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(75, 23);
            this.voltar.TabIndex = 43;
            this.voltar.Text = "voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOculosDataGridViewTextBoxColumn,
            this.idCategoriaDataGridViewTextBoxColumn,
            this.idFornecedorDataGridViewTextBoxColumn,
            this.nomeOculosDataGridViewTextBoxColumn,
            this.modeloOculosDataGridViewTextBoxColumn,
            this.precoOculosDataGridViewTextBoxColumn,
            this.possuiGrauDataGridViewTextBoxColumn,
            this.qtdGrauDataGridViewTextBoxColumn,
            this.dataDeleteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.oculosDeletadosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 170);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(639, 150);
            this.dataGridView1.TabIndex = 44;
            // 
            // databaseOculosDataSet
            // 
            this.databaseOculosDataSet.DataSetName = "DatabaseOculosDataSet";
            this.databaseOculosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // oculosDeletadosBindingSource
            // 
            this.oculosDeletadosBindingSource.DataMember = "OculosDeletados";
            this.oculosDeletadosBindingSource.DataSource = this.databaseOculosDataSet;
            // 
            // oculosDeletadosTableAdapter
            // 
            this.oculosDeletadosTableAdapter.ClearBeforeFill = true;
            // 
            // idOculosDataGridViewTextBoxColumn
            // 
            this.idOculosDataGridViewTextBoxColumn.DataPropertyName = "idOculos";
            this.idOculosDataGridViewTextBoxColumn.HeaderText = "idOculos";
            this.idOculosDataGridViewTextBoxColumn.Name = "idOculosDataGridViewTextBoxColumn";
            // 
            // idCategoriaDataGridViewTextBoxColumn
            // 
            this.idCategoriaDataGridViewTextBoxColumn.DataPropertyName = "idCategoria";
            this.idCategoriaDataGridViewTextBoxColumn.HeaderText = "idCategoria";
            this.idCategoriaDataGridViewTextBoxColumn.Name = "idCategoriaDataGridViewTextBoxColumn";
            // 
            // idFornecedorDataGridViewTextBoxColumn
            // 
            this.idFornecedorDataGridViewTextBoxColumn.DataPropertyName = "idFornecedor";
            this.idFornecedorDataGridViewTextBoxColumn.HeaderText = "idFornecedor";
            this.idFornecedorDataGridViewTextBoxColumn.Name = "idFornecedorDataGridViewTextBoxColumn";
            // 
            // nomeOculosDataGridViewTextBoxColumn
            // 
            this.nomeOculosDataGridViewTextBoxColumn.DataPropertyName = "nomeOculos";
            this.nomeOculosDataGridViewTextBoxColumn.HeaderText = "nomeOculos";
            this.nomeOculosDataGridViewTextBoxColumn.Name = "nomeOculosDataGridViewTextBoxColumn";
            // 
            // modeloOculosDataGridViewTextBoxColumn
            // 
            this.modeloOculosDataGridViewTextBoxColumn.DataPropertyName = "modeloOculos";
            this.modeloOculosDataGridViewTextBoxColumn.HeaderText = "modeloOculos";
            this.modeloOculosDataGridViewTextBoxColumn.Name = "modeloOculosDataGridViewTextBoxColumn";
            // 
            // precoOculosDataGridViewTextBoxColumn
            // 
            this.precoOculosDataGridViewTextBoxColumn.DataPropertyName = "precoOculos";
            this.precoOculosDataGridViewTextBoxColumn.HeaderText = "precoOculos";
            this.precoOculosDataGridViewTextBoxColumn.Name = "precoOculosDataGridViewTextBoxColumn";
            // 
            // possuiGrauDataGridViewTextBoxColumn
            // 
            this.possuiGrauDataGridViewTextBoxColumn.DataPropertyName = "possuiGrau";
            this.possuiGrauDataGridViewTextBoxColumn.HeaderText = "possuiGrau";
            this.possuiGrauDataGridViewTextBoxColumn.Name = "possuiGrauDataGridViewTextBoxColumn";
            // 
            // qtdGrauDataGridViewTextBoxColumn
            // 
            this.qtdGrauDataGridViewTextBoxColumn.DataPropertyName = "qtdGrau";
            this.qtdGrauDataGridViewTextBoxColumn.HeaderText = "qtdGrau";
            this.qtdGrauDataGridViewTextBoxColumn.Name = "qtdGrauDataGridViewTextBoxColumn";
            // 
            // dataDeleteDataGridViewTextBoxColumn
            // 
            this.dataDeleteDataGridViewTextBoxColumn.DataPropertyName = "dataDelete";
            this.dataDeleteDataGridViewTextBoxColumn.HeaderText = "dataDelete";
            this.dataDeleteDataGridViewTextBoxColumn.Name = "dataDeleteDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 361);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Verificar Óculos por Fornecedor";
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOculosDataGridViewTextBoxColumn1,
            this.nomeOculosDataGridViewTextBoxColumn1,
            this.modeloOculosDataGridViewTextBoxColumn1,
            this.nomeFornecedorDataGridViewTextBoxColumn,
            this.nomeCidadeDataGridViewTextBoxColumn,
            this.nomeEstadoDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.vwOculosPorFonecedorCidadeBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 377);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(639, 150);
            this.dataGridView2.TabIndex = 46;
            // 
            // vwOculosPorFonecedorCidadeBindingSource
            // 
            this.vwOculosPorFonecedorCidadeBindingSource.DataMember = "Vw_OculosPorFonecedorCidade";
            this.vwOculosPorFonecedorCidadeBindingSource.DataSource = this.databaseOculosDataSet;
            // 
            // vw_OculosPorFonecedorCidadeTableAdapter
            // 
            this.vw_OculosPorFonecedorCidadeTableAdapter.ClearBeforeFill = true;
            // 
            // idOculosDataGridViewTextBoxColumn1
            // 
            this.idOculosDataGridViewTextBoxColumn1.DataPropertyName = "idOculos";
            this.idOculosDataGridViewTextBoxColumn1.HeaderText = "idOculos";
            this.idOculosDataGridViewTextBoxColumn1.Name = "idOculosDataGridViewTextBoxColumn1";
            // 
            // nomeOculosDataGridViewTextBoxColumn1
            // 
            this.nomeOculosDataGridViewTextBoxColumn1.DataPropertyName = "nomeOculos";
            this.nomeOculosDataGridViewTextBoxColumn1.HeaderText = "nomeOculos";
            this.nomeOculosDataGridViewTextBoxColumn1.Name = "nomeOculosDataGridViewTextBoxColumn1";
            // 
            // modeloOculosDataGridViewTextBoxColumn1
            // 
            this.modeloOculosDataGridViewTextBoxColumn1.DataPropertyName = "modeloOculos";
            this.modeloOculosDataGridViewTextBoxColumn1.HeaderText = "modeloOculos";
            this.modeloOculosDataGridViewTextBoxColumn1.Name = "modeloOculosDataGridViewTextBoxColumn1";
            // 
            // nomeFornecedorDataGridViewTextBoxColumn
            // 
            this.nomeFornecedorDataGridViewTextBoxColumn.DataPropertyName = "nomeFornecedor";
            this.nomeFornecedorDataGridViewTextBoxColumn.HeaderText = "nomeFornecedor";
            this.nomeFornecedorDataGridViewTextBoxColumn.Name = "nomeFornecedorDataGridViewTextBoxColumn";
            // 
            // nomeCidadeDataGridViewTextBoxColumn
            // 
            this.nomeCidadeDataGridViewTextBoxColumn.DataPropertyName = "nomeCidade";
            this.nomeCidadeDataGridViewTextBoxColumn.HeaderText = "nomeCidade";
            this.nomeCidadeDataGridViewTextBoxColumn.Name = "nomeCidadeDataGridViewTextBoxColumn";
            // 
            // nomeEstadoDataGridViewTextBoxColumn
            // 
            this.nomeEstadoDataGridViewTextBoxColumn.DataPropertyName = "nomeEstado";
            this.nomeEstadoDataGridViewTextBoxColumn.HeaderText = "nomeEstado";
            this.nomeEstadoDataGridViewTextBoxColumn.Name = "nomeEstadoDataGridViewTextBoxColumn";
            // 
            // MaisRelatoriosPart2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 535);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MaisRelatoriosPart2";
            this.Text = "MaisRelatoriosPart2";
            this.Load += new System.EventHandler(this.MaisRelatoriosPart2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOculosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oculosDeletadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vwOculosPorFonecedorCidadeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseOculosDataSet databaseOculosDataSet;
        private System.Windows.Forms.BindingSource oculosDeletadosBindingSource;
        private DatabaseOculosDataSetTableAdapters.OculosDeletadosTableAdapter oculosDeletadosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOculosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeOculosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloOculosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoOculosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn possuiGrauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdGrauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDeleteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource vwOculosPorFonecedorCidadeBindingSource;
        private DatabaseOculosDataSetTableAdapters.Vw_OculosPorFonecedorCidadeTableAdapter vw_OculosPorFonecedorCidadeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOculosDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeOculosDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloOculosDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeEstadoDataGridViewTextBoxColumn;
    }
}