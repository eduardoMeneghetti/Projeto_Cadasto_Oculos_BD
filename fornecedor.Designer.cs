namespace projetoOculosV2
{
    partial class fornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fornecedor));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idCidade = new System.Windows.Forms.TextBox();
            this.cidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseOculosDataSet = new projetoOculosV2.DatabaseOculosDataSet();
            this.textCidade = new System.Windows.Forms.ComboBox();
            this.cadFon = new System.Windows.Forms.Button();
            this.nomeForn = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cidadesTableAdapter = new projetoOculosV2.DatabaseOculosDataSetTableAdapters.CidadesTableAdapter();
            this.voltar = new System.Windows.Forms.Button();
            this.idForn = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.consultarForn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fornecedoresTableAdapter = new projetoOculosV2.DatabaseOculosDataSetTableAdapters.FornecedoresTableAdapter();
            this.alterarForn = new System.Windows.Forms.Button();
            this.excluirFornecedor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOculosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(721, 373);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // idCidade
            // 
            this.idCidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cidadesBindingSource, "idCidade", true));
            this.idCidade.Location = new System.Drawing.Point(148, 176);
            this.idCidade.Name = "idCidade";
            this.idCidade.Size = new System.Drawing.Size(18, 20);
            this.idCidade.TabIndex = 41;
            // 
            // cidadesBindingSource
            // 
            this.cidadesBindingSource.DataMember = "Cidades";
            this.cidadesBindingSource.DataSource = this.databaseOculosDataSet;
            // 
            // databaseOculosDataSet
            // 
            this.databaseOculosDataSet.DataSetName = "DatabaseOculosDataSet";
            this.databaseOculosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // textCidade
            // 
            this.textCidade.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cidadesBindingSource, "nomeCidade", true));
            this.textCidade.DataSource = this.cidadesBindingSource;
            this.textCidade.DisplayMember = "nomeCidade";
            this.textCidade.FormattingEnabled = true;
            this.textCidade.Location = new System.Drawing.Point(23, 176);
            this.textCidade.Name = "textCidade";
            this.textCidade.Size = new System.Drawing.Size(121, 21);
            this.textCidade.TabIndex = 40;
            this.textCidade.SelectedIndexChanged += new System.EventHandler(this.textCidade_SelectedIndexChanged);
            // 
            // cadFon
            // 
            this.cadFon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadFon.Location = new System.Drawing.Point(23, 253);
            this.cadFon.Name = "cadFon";
            this.cadFon.Size = new System.Drawing.Size(75, 23);
            this.cadFon.TabIndex = 39;
            this.cadFon.Text = "Cadastrar";
            this.cadFon.UseVisualStyleBackColor = true;
            this.cadFon.Click += new System.EventHandler(this.cadFon_Click);
            // 
            // nomeForn
            // 
            this.nomeForn.Location = new System.Drawing.Point(23, 223);
            this.nomeForn.Name = "nomeForn";
            this.nomeForn.Size = new System.Drawing.Size(119, 20);
            this.nomeForn.TabIndex = 38;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(20, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(89, 13);
            this.label11.TabIndex = 37;
            this.label11.Text = "Nome fornecedor";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(20, 160);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Cidade";
            // 
            // cidadesTableAdapter
            // 
            this.cidadesTableAdapter.ClearBeforeFill = true;
            // 
            // voltar
            // 
            this.voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar.Location = new System.Drawing.Point(23, 90);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(75, 23);
            this.voltar.TabIndex = 42;
            this.voltar.Text = "voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // idForn
            // 
            this.idForn.Location = new System.Drawing.Point(235, 176);
            this.idForn.Name = "idForn";
            this.idForn.Size = new System.Drawing.Size(100, 20);
            this.idForn.TabIndex = 43;
            this.idForn.TextChanged += new System.EventHandler(this.idForn_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(232, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Id Fornecedor";
            // 
            // consultarForn
            // 
            this.consultarForn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.consultarForn.Location = new System.Drawing.Point(341, 174);
            this.consultarForn.Name = "consultarForn";
            this.consultarForn.Size = new System.Drawing.Size(75, 23);
            this.consultarForn.TabIndex = 45;
            this.consultarForn.Text = "Consultar";
            this.consultarForn.UseVisualStyleBackColor = true;
            this.consultarForn.Click += new System.EventHandler(this.consultarForn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFornecedorDataGridViewTextBoxColumn,
            this.idCidadeDataGridViewTextBoxColumn,
            this.nomeFornecedorDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fornecedoresBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(377, 264);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 108);
            this.dataGridView1.TabIndex = 46;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idFornecedorDataGridViewTextBoxColumn
            // 
            this.idFornecedorDataGridViewTextBoxColumn.DataPropertyName = "idFornecedor";
            this.idFornecedorDataGridViewTextBoxColumn.HeaderText = "idFornecedor";
            this.idFornecedorDataGridViewTextBoxColumn.Name = "idFornecedorDataGridViewTextBoxColumn";
            this.idFornecedorDataGridViewTextBoxColumn.ReadOnly = true;
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
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "Fornecedores";
            this.fornecedoresBindingSource.DataSource = this.databaseOculosDataSet;
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // alterarForn
            // 
            this.alterarForn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alterarForn.Location = new System.Drawing.Point(104, 253);
            this.alterarForn.Name = "alterarForn";
            this.alterarForn.Size = new System.Drawing.Size(75, 23);
            this.alterarForn.TabIndex = 47;
            this.alterarForn.Text = "Alterar";
            this.alterarForn.UseVisualStyleBackColor = true;
            this.alterarForn.Click += new System.EventHandler(this.alterarForn_Click);
            // 
            // excluirFornecedor
            // 
            this.excluirFornecedor.BackColor = System.Drawing.Color.Red;
            this.excluirFornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excluirFornecedor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.excluirFornecedor.FlatAppearance.BorderSize = 0;
            this.excluirFornecedor.ForeColor = System.Drawing.Color.Black;
            this.excluirFornecedor.Location = new System.Drawing.Point(341, 200);
            this.excluirFornecedor.Margin = new System.Windows.Forms.Padding(0);
            this.excluirFornecedor.Name = "excluirFornecedor";
            this.excluirFornecedor.Size = new System.Drawing.Size(75, 30);
            this.excluirFornecedor.TabIndex = 56;
            this.excluirFornecedor.Text = "Excluir";
            this.excluirFornecedor.UseVisualStyleBackColor = false;
            this.excluirFornecedor.Click += new System.EventHandler(this.excluirFornecedor_Click);
            // 
            // fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 371);
            this.Controls.Add(this.excluirFornecedor);
            this.Controls.Add(this.alterarForn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.consultarForn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idForn);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.idCidade);
            this.Controls.Add(this.textCidade);
            this.Controls.Add(this.cadFon);
            this.Controls.Add(this.nomeForn);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.pictureBox1);
            this.Name = "fornecedor";
            this.Text = "fornecedor";
            this.Load += new System.EventHandler(this.fornecedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOculosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox idCidade;
        private System.Windows.Forms.ComboBox textCidade;
        private System.Windows.Forms.Button cadFon;
        private System.Windows.Forms.TextBox nomeForn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private DatabaseOculosDataSet databaseOculosDataSet;
        private System.Windows.Forms.BindingSource cidadesBindingSource;
        private DatabaseOculosDataSetTableAdapters.CidadesTableAdapter cidadesTableAdapter;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.TextBox idForn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button consultarForn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private DatabaseOculosDataSetTableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button alterarForn;
        private System.Windows.Forms.Button excluirFornecedor;
    }
}