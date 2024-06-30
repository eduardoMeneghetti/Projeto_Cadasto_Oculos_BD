namespace projetoOculosV2
{
    partial class pesquisas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pesquisas));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedoresDeletadosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.databaseOculosDataSet1 = new projetoOculosV2.DatabaseOculosDataSet();
            this.voltar = new System.Windows.Forms.Button();
            this.maisRelatórios = new System.Windows.Forms.Button();
            this.fornecedoresDeletadosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseOculosDataSet = new projetoOculosV2.DatabaseOculosDataSet();
            this.buscarOculosCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOculosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeOculosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloOculosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buscarOculosCategoriaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.buscarOculosCategoriaTableAdapter = new projetoOculosV2.DatabaseOculosDataSetTableAdapters.buscarOculosCategoriaTableAdapter();
            this.fornecedoresDeletadosTableAdapter = new projetoOculosV2.DatabaseOculosDataSetTableAdapters.FornecedoresDeletadosTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresDeletadosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOculosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresDeletadosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOculosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarOculosCategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarOculosCategoriaBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(727, 532);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFornecedorDataGridViewTextBoxColumn,
            this.idCidadeDataGridViewTextBoxColumn,
            this.nomeFornecedorDataGridViewTextBoxColumn,
            this.dataDelDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.fornecedoresDeletadosBindingSource1;
            this.dataGridView2.Location = new System.Drawing.Point(77, 173);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(442, 150);
            this.dataGridView2.TabIndex = 5;
            // 
            // idFornecedorDataGridViewTextBoxColumn
            // 
            this.idFornecedorDataGridViewTextBoxColumn.DataPropertyName = "idFornecedor";
            this.idFornecedorDataGridViewTextBoxColumn.HeaderText = "idFornecedor";
            this.idFornecedorDataGridViewTextBoxColumn.Name = "idFornecedorDataGridViewTextBoxColumn";
            // 
            // idCidadeDataGridViewTextBoxColumn
            // 
            this.idCidadeDataGridViewTextBoxColumn.DataPropertyName = "idCidade";
            this.idCidadeDataGridViewTextBoxColumn.HeaderText = "idCidade";
            this.idCidadeDataGridViewTextBoxColumn.Name = "idCidadeDataGridViewTextBoxColumn";
            // 
            // nomeFornecedorDataGridViewTextBoxColumn
            // 
            this.nomeFornecedorDataGridViewTextBoxColumn.DataPropertyName = "nomeFornecedor";
            this.nomeFornecedorDataGridViewTextBoxColumn.HeaderText = "nomeFornecedor";
            this.nomeFornecedorDataGridViewTextBoxColumn.Name = "nomeFornecedorDataGridViewTextBoxColumn";
            // 
            // dataDelDataGridViewTextBoxColumn
            // 
            this.dataDelDataGridViewTextBoxColumn.DataPropertyName = "dataDel";
            this.dataDelDataGridViewTextBoxColumn.HeaderText = "dataDel";
            this.dataDelDataGridViewTextBoxColumn.Name = "dataDelDataGridViewTextBoxColumn";
            // 
            // fornecedoresDeletadosBindingSource1
            // 
            this.fornecedoresDeletadosBindingSource1.DataMember = "FornecedoresDeletados";
            this.fornecedoresDeletadosBindingSource1.DataSource = this.databaseOculosDataSet1;
            // 
            // databaseOculosDataSet1
            // 
            this.databaseOculosDataSet1.DataSetName = "DatabaseOculosDataSet";
            this.databaseOculosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // voltar
            // 
            this.voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar.Location = new System.Drawing.Point(77, 71);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(75, 23);
            this.voltar.TabIndex = 43;
            this.voltar.Text = "voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // maisRelatórios
            // 
            this.maisRelatórios.Location = new System.Drawing.Point(545, 71);
            this.maisRelatórios.Name = "maisRelatórios";
            this.maisRelatórios.Size = new System.Drawing.Size(94, 23);
            this.maisRelatórios.TabIndex = 44;
            this.maisRelatórios.Text = "+ Relatórios";
            this.maisRelatórios.UseVisualStyleBackColor = true;
            this.maisRelatórios.Click += new System.EventHandler(this.maisRelatórios_Click);
            // 
            // fornecedoresDeletadosBindingSource
            // 
            this.fornecedoresDeletadosBindingSource.DataMember = "FornecedoresDeletados";
            this.fornecedoresDeletadosBindingSource.DataSource = this.databaseOculosDataSet;
            // 
            // databaseOculosDataSet
            // 
            this.databaseOculosDataSet.DataSetName = "DatabaseOculosDataSet";
            this.databaseOculosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buscarOculosCategoriaBindingSource
            // 
            this.buscarOculosCategoriaBindingSource.DataMember = "buscarOculosCategoria";
            this.buscarOculosCategoriaBindingSource.DataSource = this.databaseOculosDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCategoriaDataGridViewTextBoxColumn,
            this.nomeCategoriaDataGridViewTextBoxColumn,
            this.idOculosDataGridViewTextBoxColumn,
            this.nomeOculosDataGridViewTextBoxColumn,
            this.modeloOculosDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.buscarOculosCategoriaBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(77, 369);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(541, 150);
            this.dataGridView1.TabIndex = 46;
            // 
            // idCategoriaDataGridViewTextBoxColumn
            // 
            this.idCategoriaDataGridViewTextBoxColumn.DataPropertyName = "idCategoria";
            this.idCategoriaDataGridViewTextBoxColumn.HeaderText = "idCategoria";
            this.idCategoriaDataGridViewTextBoxColumn.Name = "idCategoriaDataGridViewTextBoxColumn";
            // 
            // nomeCategoriaDataGridViewTextBoxColumn
            // 
            this.nomeCategoriaDataGridViewTextBoxColumn.DataPropertyName = "nomeCategoria";
            this.nomeCategoriaDataGridViewTextBoxColumn.HeaderText = "nomeCategoria";
            this.nomeCategoriaDataGridViewTextBoxColumn.Name = "nomeCategoriaDataGridViewTextBoxColumn";
            // 
            // idOculosDataGridViewTextBoxColumn
            // 
            this.idOculosDataGridViewTextBoxColumn.DataPropertyName = "idOculos";
            this.idOculosDataGridViewTextBoxColumn.HeaderText = "idOculos";
            this.idOculosDataGridViewTextBoxColumn.Name = "idOculosDataGridViewTextBoxColumn";
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
            // buscarOculosCategoriaBindingSource1
            // 
            this.buscarOculosCategoriaBindingSource1.DataMember = "buscarOculosCategoria";
            this.buscarOculosCategoriaBindingSource1.DataSource = this.databaseOculosDataSet;
            // 
            // buscarOculosCategoriaTableAdapter
            // 
            this.buscarOculosCategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // fornecedoresDeletadosTableAdapter
            // 
            this.fornecedoresDeletadosTableAdapter.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(74, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 13);
            this.label3.TabIndex = 48;
            this.label3.Text = "Fornecedores deletados do sistema";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(74, 353);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "Óculos por categoria";
            // 
            // pesquisas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 531);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.maisRelatórios);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "pesquisas";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.pesquisas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresDeletadosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOculosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresDeletadosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOculosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarOculosCategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.buscarOculosCategoriaBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Button maisRelatórios;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDelDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fornecedoresDeletadosBindingSource;
        private DatabaseOculosDataSet databaseOculosDataSet;
        private System.Windows.Forms.BindingSource buscarOculosCategoriaBindingSource;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource buscarOculosCategoriaBindingSource1;
        private DatabaseOculosDataSetTableAdapters.buscarOculosCategoriaTableAdapter buscarOculosCategoriaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOculosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeOculosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloOculosDataGridViewTextBoxColumn;
        private DatabaseOculosDataSet databaseOculosDataSet1;
        private System.Windows.Forms.BindingSource fornecedoresDeletadosBindingSource1;
        private DatabaseOculosDataSetTableAdapters.FornecedoresDeletadosTableAdapter fornecedoresDeletadosTableAdapter;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
    }
}