namespace projetoOculosV2
{
    partial class MaisRelatorios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaisRelatorios));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nomeCat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.voltar = new System.Windows.Forms.Button();
            this.pesquisarTotalPrecoCat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pesquisaColaborador = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textNomeColaborador = new System.Windows.Forms.TextBox();
            this.dataGridFunc = new System.Windows.Forms.DataGridView();
            this.nomeFuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tempodesdecadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procCalcularTempoDeCadastroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseOculosDataSet = new projetoOculosV2.DatabaseOculosDataSet();
            this.proc_CalcularTempoDeCadastroTableAdapter = new projetoOculosV2.DatabaseOculosDataSetTableAdapters.Proc_CalcularTempoDeCadastroTableAdapter();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridOculosCat = new System.Windows.Forms.DataGridView();
            this.idCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idOculosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeOculosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloOculosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.procbuscarOculosPorCategoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseOculosDataSet1 = new projetoOculosV2.DatabaseOculosDataSet();
            this.proc_buscarOculosPorCategoriaTableAdapter = new projetoOculosV2.DatabaseOculosDataSetTableAdapters.Proc_buscarOculosPorCategoriaTableAdapter();
            this.pesquisaCatOculosID = new System.Windows.Forms.Button();
            this.idCat = new System.Windows.Forms.TextBox();
            this.textNomeCat = new System.Windows.Forms.ComboBox();
            this.procbuscarOculosPorCategoriaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.procbuscarOculosPorCategoriaBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriasTableAdapter = new projetoOculosV2.DatabaseOculosDataSetTableAdapters.CategoriasTableAdapter();
            this.maisRelatoriosPart2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procCalcularTempoDeCadastroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOculosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOculosCat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procbuscarOculosPorCategoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOculosDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procbuscarOculosPorCategoriaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.procbuscarOculosPorCategoriaBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(730, 540);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // nomeCat
            // 
            this.nomeCat.Location = new System.Drawing.Point(12, 162);
            this.nomeCat.Name = "nomeCat";
            this.nomeCat.Size = new System.Drawing.Size(112, 20);
            this.nomeCat.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(9, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Valor total de óculos por Categoria";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // voltar
            // 
            this.voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar.Location = new System.Drawing.Point(71, 80);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(75, 23);
            this.voltar.TabIndex = 44;
            this.voltar.Text = "voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // pesquisarTotalPrecoCat
            // 
            this.pesquisarTotalPrecoCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pesquisarTotalPrecoCat.Location = new System.Drawing.Point(140, 159);
            this.pesquisarTotalPrecoCat.Name = "pesquisarTotalPrecoCat";
            this.pesquisarTotalPrecoCat.Size = new System.Drawing.Size(75, 23);
            this.pesquisarTotalPrecoCat.TabIndex = 45;
            this.pesquisarTotalPrecoCat.Text = "Pesquisar";
            this.pesquisarTotalPrecoCat.UseVisualStyleBackColor = true;
            this.pesquisarTotalPrecoCat.Click += new System.EventHandler(this.pesquisarTotalPrecoCat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "*Filtre pelo nome da categoria desejada";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "*Filtre pelo nome do colaborador desejado";
            // 
            // pesquisaColaborador
            // 
            this.pesquisaColaborador.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pesquisaColaborador.Location = new System.Drawing.Point(140, 241);
            this.pesquisaColaborador.Name = "pesquisaColaborador";
            this.pesquisaColaborador.Size = new System.Drawing.Size(75, 23);
            this.pesquisaColaborador.TabIndex = 49;
            this.pesquisaColaborador.Text = "Pesquisar";
            this.pesquisaColaborador.UseVisualStyleBackColor = true;
            this.pesquisaColaborador.Click += new System.EventHandler(this.pesquisaColaborador_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 48;
            this.label4.Text = "Verifica idade do colaborador";
            // 
            // textNomeColaborador
            // 
            this.textNomeColaborador.Location = new System.Drawing.Point(12, 244);
            this.textNomeColaborador.Name = "textNomeColaborador";
            this.textNomeColaborador.Size = new System.Drawing.Size(112, 20);
            this.textNomeColaborador.TabIndex = 47;
            // 
            // dataGridFunc
            // 
            this.dataGridFunc.AutoGenerateColumns = false;
            this.dataGridFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridFunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeFuncDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.tempodesdecadastroDataGridViewTextBoxColumn});
            this.dataGridFunc.DataSource = this.procCalcularTempoDeCadastroBindingSource;
            this.dataGridFunc.Location = new System.Drawing.Point(12, 283);
            this.dataGridFunc.Name = "dataGridFunc";
            this.dataGridFunc.Size = new System.Drawing.Size(343, 150);
            this.dataGridFunc.TabIndex = 51;
            // 
            // nomeFuncDataGridViewTextBoxColumn
            // 
            this.nomeFuncDataGridViewTextBoxColumn.DataPropertyName = "nomeFunc";
            this.nomeFuncDataGridViewTextBoxColumn.HeaderText = "nomeFunc";
            this.nomeFuncDataGridViewTextBoxColumn.Name = "nomeFuncDataGridViewTextBoxColumn";
            // 
            // dataNascimentoDataGridViewTextBoxColumn
            // 
            this.dataNascimentoDataGridViewTextBoxColumn.DataPropertyName = "dataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.HeaderText = "dataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn.Name = "dataNascimentoDataGridViewTextBoxColumn";
            // 
            // tempodesdecadastroDataGridViewTextBoxColumn
            // 
            this.tempodesdecadastroDataGridViewTextBoxColumn.DataPropertyName = "tempo_desde_cadastro";
            this.tempodesdecadastroDataGridViewTextBoxColumn.HeaderText = "tempo_desde_cadastro";
            this.tempodesdecadastroDataGridViewTextBoxColumn.Name = "tempodesdecadastroDataGridViewTextBoxColumn";
            this.tempodesdecadastroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // procCalcularTempoDeCadastroBindingSource
            // 
            this.procCalcularTempoDeCadastroBindingSource.DataMember = "Proc_CalcularTempoDeCadastro";
            this.procCalcularTempoDeCadastroBindingSource.DataSource = this.databaseOculosDataSet;
            // 
            // databaseOculosDataSet
            // 
            this.databaseOculosDataSet.DataSetName = "DatabaseOculosDataSet";
            this.databaseOculosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proc_CalcularTempoDeCadastroTableAdapter
            // 
            this.proc_CalcularTempoDeCadastroTableAdapter.ClearBeforeFill = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(407, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(183, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Verifica Óculos por categoria digitada";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(407, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 13);
            this.label6.TabIndex = 50;
            this.label6.Text = "* Filtre pelo ID da categoria";
            // 
            // dataGridOculosCat
            // 
            this.dataGridOculosCat.AutoGenerateColumns = false;
            this.dataGridOculosCat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOculosCat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCategoriaDataGridViewTextBoxColumn,
            this.nomeCategoriaDataGridViewTextBoxColumn,
            this.idOculosDataGridViewTextBoxColumn,
            this.nomeOculosDataGridViewTextBoxColumn,
            this.modeloOculosDataGridViewTextBoxColumn});
            this.dataGridOculosCat.DataSource = this.procbuscarOculosPorCategoriaBindingSource;
            this.dataGridOculosCat.Location = new System.Drawing.Point(395, 283);
            this.dataGridOculosCat.Name = "dataGridOculosCat";
            this.dataGridOculosCat.Size = new System.Drawing.Size(321, 150);
            this.dataGridOculosCat.TabIndex = 52;
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
            // procbuscarOculosPorCategoriaBindingSource
            // 
            this.procbuscarOculosPorCategoriaBindingSource.DataMember = "Proc_buscarOculosPorCategoria";
            this.procbuscarOculosPorCategoriaBindingSource.DataSource = this.databaseOculosDataSet1;
            // 
            // databaseOculosDataSet1
            // 
            this.databaseOculosDataSet1.DataSetName = "DatabaseOculosDataSet";
            this.databaseOculosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // proc_buscarOculosPorCategoriaTableAdapter
            // 
            this.proc_buscarOculosPorCategoriaTableAdapter.ClearBeforeFill = true;
            // 
            // pesquisaCatOculosID
            // 
            this.pesquisaCatOculosID.Location = new System.Drawing.Point(574, 243);
            this.pesquisaCatOculosID.Name = "pesquisaCatOculosID";
            this.pesquisaCatOculosID.Size = new System.Drawing.Size(75, 23);
            this.pesquisaCatOculosID.TabIndex = 53;
            this.pesquisaCatOculosID.Text = "Pesquisar";
            this.pesquisaCatOculosID.UseVisualStyleBackColor = true;
            this.pesquisaCatOculosID.Click += new System.EventHandler(this.pesquisaCatOculosID_Click);
            // 
            // idCat
            // 
            this.idCat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriasBindingSource, "idCategoria", true));
            this.idCat.Location = new System.Drawing.Point(537, 245);
            this.idCat.Name = "idCat";
            this.idCat.Size = new System.Drawing.Size(18, 20);
            this.idCat.TabIndex = 55;
            this.idCat.TextChanged += new System.EventHandler(this.idCat_TextChanged);
            // 
            // textNomeCat
            // 
            this.textNomeCat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.procbuscarOculosPorCategoriaBindingSource2, "nomeCategoria", true));
            this.textNomeCat.DataSource = this.categoriasBindingSource;
            this.textNomeCat.DisplayMember = "nomeCategoria";
            this.textNomeCat.FormattingEnabled = true;
            this.textNomeCat.Location = new System.Drawing.Point(410, 244);
            this.textNomeCat.Name = "textNomeCat";
            this.textNomeCat.Size = new System.Drawing.Size(121, 21);
            this.textNomeCat.TabIndex = 54;
            this.textNomeCat.SelectedIndexChanged += new System.EventHandler(this.textNomeCat_SelectedIndexChanged);
            // 
            // procbuscarOculosPorCategoriaBindingSource1
            // 
            this.procbuscarOculosPorCategoriaBindingSource1.DataMember = "Proc_buscarOculosPorCategoria";
            this.procbuscarOculosPorCategoriaBindingSource1.DataSource = this.databaseOculosDataSet;
            // 
            // procbuscarOculosPorCategoriaBindingSource2
            // 
            this.procbuscarOculosPorCategoriaBindingSource2.DataMember = "Proc_buscarOculosPorCategoria";
            this.procbuscarOculosPorCategoriaBindingSource2.DataSource = this.databaseOculosDataSet;
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "Categorias";
            this.categoriasBindingSource.DataSource = this.databaseOculosDataSet;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // maisRelatoriosPart2
            // 
            this.maisRelatoriosPart2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.maisRelatoriosPart2.Location = new System.Drawing.Point(495, 80);
            this.maisRelatoriosPart2.Name = "maisRelatoriosPart2";
            this.maisRelatoriosPart2.Size = new System.Drawing.Size(75, 23);
            this.maisRelatoriosPart2.TabIndex = 56;
            this.maisRelatoriosPart2.Text = "+ Relatórios";
            this.maisRelatoriosPart2.UseVisualStyleBackColor = true;
            this.maisRelatoriosPart2.Click += new System.EventHandler(this.maisRelatoriosPart2_Click);
            // 
            // MaisRelatorios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 538);
            this.Controls.Add(this.maisRelatoriosPart2);
            this.Controls.Add(this.idCat);
            this.Controls.Add(this.textNomeCat);
            this.Controls.Add(this.pesquisaCatOculosID);
            this.Controls.Add(this.dataGridOculosCat);
            this.Controls.Add(this.dataGridFunc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pesquisaColaborador);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textNomeColaborador);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pesquisarTotalPrecoCat);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomeCat);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MaisRelatorios";
            this.Text = "MaisRelatorios";
            this.Load += new System.EventHandler(this.MaisRelatorios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridFunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procCalcularTempoDeCadastroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOculosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOculosCat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procbuscarOculosPorCategoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOculosDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procbuscarOculosPorCategoriaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.procbuscarOculosPorCategoriaBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox nomeCat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Button pesquisarTotalPrecoCat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pesquisaColaborador;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textNomeColaborador;
        private System.Windows.Forms.DataGridView dataGridFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tempodesdecadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource procCalcularTempoDeCadastroBindingSource;
        private DatabaseOculosDataSet databaseOculosDataSet;
        private DatabaseOculosDataSetTableAdapters.Proc_CalcularTempoDeCadastroTableAdapter proc_CalcularTempoDeCadastroTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridOculosCat;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOculosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeOculosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloOculosDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource procbuscarOculosPorCategoriaBindingSource;
        private DatabaseOculosDataSet databaseOculosDataSet1;
        private DatabaseOculosDataSetTableAdapters.Proc_buscarOculosPorCategoriaTableAdapter proc_buscarOculosPorCategoriaTableAdapter;
        private System.Windows.Forms.Button pesquisaCatOculosID;
        private System.Windows.Forms.TextBox idCat;
        private System.Windows.Forms.ComboBox textNomeCat;
        private System.Windows.Forms.BindingSource procbuscarOculosPorCategoriaBindingSource1;
        private System.Windows.Forms.BindingSource procbuscarOculosPorCategoriaBindingSource2;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private DatabaseOculosDataSetTableAdapters.CategoriasTableAdapter categoriasTableAdapter;
        private System.Windows.Forms.Button maisRelatoriosPart2;
    }
}