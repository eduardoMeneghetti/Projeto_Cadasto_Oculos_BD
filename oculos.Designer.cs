namespace projetoOculosV2
{
    partial class oculos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(oculos));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cadOcu = new System.Windows.Forms.Button();
            this.textQtdGrau = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textGrau = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textPreco = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textModelo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textNomeOculos = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.voltar = new System.Windows.Forms.Button();
            this.textCat = new System.Windows.Forms.ComboBox();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseOculosDataSet = new projetoOculosV2.DatabaseOculosDataSet();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.idCategoria = new System.Windows.Forms.TextBox();
            this.categoriasTableAdapter = new projetoOculosV2.DatabaseOculosDataSetTableAdapters.CategoriasTableAdapter();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.idFornecedor = new System.Windows.Forms.TextBox();
            this.fornecedoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textFonecedor = new System.Windows.Forms.ComboBox();
            this.fornecedoresTableAdapter = new projetoOculosV2.DatabaseOculosDataSetTableAdapters.FornecedoresTableAdapter();
            this.dataGridOculos = new System.Windows.Forms.DataGridView();
            this.idOculosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idFornecedorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeOculosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloOculosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoOculosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.possuiGrauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdGrauDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.oculosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oculosTableAdapter = new projetoOculosV2.DatabaseOculosDataSetTableAdapters.OculosTableAdapter();
            this.textIdOculos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.alterarOcu = new System.Windows.Forms.Button();
            this.excluirOcu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOculosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOculos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oculosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(728, 538);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cadOcu
            // 
            this.cadOcu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadOcu.Location = new System.Drawing.Point(12, 485);
            this.cadOcu.Name = "cadOcu";
            this.cadOcu.Size = new System.Drawing.Size(75, 23);
            this.cadOcu.TabIndex = 36;
            this.cadOcu.Text = "Cadastrar";
            this.cadOcu.UseVisualStyleBackColor = true;
            this.cadOcu.Click += new System.EventHandler(this.cadOcu_Click);
            // 
            // textQtdGrau
            // 
            this.textQtdGrau.Location = new System.Drawing.Point(12, 424);
            this.textQtdGrau.Name = "textQtdGrau";
            this.textQtdGrau.Size = new System.Drawing.Size(119, 20);
            this.textQtdGrau.TabIndex = 35;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(9, 408);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 34;
            this.label10.Text = "Quantidade Grau";
            // 
            // textGrau
            // 
            this.textGrau.Location = new System.Drawing.Point(12, 379);
            this.textGrau.Name = "textGrau";
            this.textGrau.Size = new System.Drawing.Size(119, 20);
            this.textGrau.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(9, 363);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "Possui grau?";
            // 
            // textPreco
            // 
            this.textPreco.Location = new System.Drawing.Point(12, 330);
            this.textPreco.Name = "textPreco";
            this.textPreco.Size = new System.Drawing.Size(119, 20);
            this.textPreco.TabIndex = 31;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(9, 314);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Preço óculos";
            // 
            // textModelo
            // 
            this.textModelo.Location = new System.Drawing.Point(12, 286);
            this.textModelo.Name = "textModelo";
            this.textModelo.Size = new System.Drawing.Size(119, 20);
            this.textModelo.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(9, 270);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 28;
            this.label7.Text = "Modelo";
            // 
            // textNomeOculos
            // 
            this.textNomeOculos.Location = new System.Drawing.Point(12, 243);
            this.textNomeOculos.Name = "textNomeOculos";
            this.textNomeOculos.Size = new System.Drawing.Size(119, 20);
            this.textNomeOculos.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(9, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Nome óculos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(9, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Fornecedor\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Categoria\r\n";
            // 
            // voltar
            // 
            this.voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar.Location = new System.Drawing.Point(12, 85);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(75, 23);
            this.voltar.TabIndex = 43;
            this.voltar.Text = "voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // textCat
            // 
            this.textCat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriasBindingSource, "nomeCategoria", true));
            this.textCat.DataSource = this.categoriasBindingSource;
            this.textCat.DisplayMember = "nomeCategoria";
            this.textCat.FormattingEnabled = true;
            this.textCat.Location = new System.Drawing.Point(12, 151);
            this.textCat.Name = "textCat";
            this.textCat.Size = new System.Drawing.Size(121, 21);
            this.textCat.TabIndex = 44;
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "Categorias";
            this.categoriasBindingSource.DataSource = this.databaseOculosDataSet;
            this.categoriasBindingSource.CurrentChanged += new System.EventHandler(this.categoriasBindingSource_CurrentChanged);
            // 
            // databaseOculosDataSet
            // 
            this.databaseOculosDataSet.DataSetName = "DatabaseOculosDataSet";
            this.databaseOculosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // idCategoria
            // 
            this.idCategoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.categoriasBindingSource, "idCategoria", true));
            this.idCategoria.Location = new System.Drawing.Point(140, 151);
            this.idCategoria.Name = "idCategoria";
            this.idCategoria.Size = new System.Drawing.Size(18, 20);
            this.idCategoria.TabIndex = 46;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // idFornecedor
            // 
            this.idFornecedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "idFornecedor", true));
            this.idFornecedor.Location = new System.Drawing.Point(140, 198);
            this.idFornecedor.Name = "idFornecedor";
            this.idFornecedor.Size = new System.Drawing.Size(18, 20);
            this.idFornecedor.TabIndex = 48;
            // 
            // fornecedoresBindingSource
            // 
            this.fornecedoresBindingSource.DataMember = "Fornecedores";
            this.fornecedoresBindingSource.DataSource = this.databaseOculosDataSet;
            // 
            // textFonecedor
            // 
            this.textFonecedor.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fornecedoresBindingSource, "nomeFornecedor", true));
            this.textFonecedor.DataSource = this.fornecedoresBindingSource;
            this.textFonecedor.DisplayMember = "nomeFornecedor";
            this.textFonecedor.FormattingEnabled = true;
            this.textFonecedor.Location = new System.Drawing.Point(13, 197);
            this.textFonecedor.Name = "textFonecedor";
            this.textFonecedor.Size = new System.Drawing.Size(121, 21);
            this.textFonecedor.TabIndex = 49;
            // 
            // fornecedoresTableAdapter
            // 
            this.fornecedoresTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridOculos
            // 
            this.dataGridOculos.AutoGenerateColumns = false;
            this.dataGridOculos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOculos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idOculosDataGridViewTextBoxColumn,
            this.idCategoriaDataGridViewTextBoxColumn,
            this.idFornecedorDataGridViewTextBoxColumn,
            this.nomeOculosDataGridViewTextBoxColumn,
            this.modeloOculosDataGridViewTextBoxColumn,
            this.precoOculosDataGridViewTextBoxColumn,
            this.possuiGrauDataGridViewTextBoxColumn,
            this.qtdGrauDataGridViewTextBoxColumn});
            this.dataGridOculos.DataSource = this.oculosBindingSource;
            this.dataGridOculos.Location = new System.Drawing.Point(1, 531);
            this.dataGridOculos.Name = "dataGridOculos";
            this.dataGridOculos.Size = new System.Drawing.Size(728, 150);
            this.dataGridOculos.TabIndex = 50;
            this.dataGridOculos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridOculos_CellContentClick);
            // 
            // idOculosDataGridViewTextBoxColumn
            // 
            this.idOculosDataGridViewTextBoxColumn.DataPropertyName = "idOculos";
            this.idOculosDataGridViewTextBoxColumn.HeaderText = "idOculos";
            this.idOculosDataGridViewTextBoxColumn.Name = "idOculosDataGridViewTextBoxColumn";
            this.idOculosDataGridViewTextBoxColumn.ReadOnly = true;
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
            // oculosBindingSource
            // 
            this.oculosBindingSource.DataMember = "Oculos";
            this.oculosBindingSource.DataSource = this.databaseOculosDataSet;
            // 
            // oculosTableAdapter
            // 
            this.oculosTableAdapter.ClearBeforeFill = true;
            // 
            // textIdOculos
            // 
            this.textIdOculos.Location = new System.Drawing.Point(226, 151);
            this.textIdOculos.Name = "textIdOculos";
            this.textIdOculos.Size = new System.Drawing.Size(100, 20);
            this.textIdOculos.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(223, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 52;
            this.label1.Text = "Id Óculos";
            // 
            // btn_consultar
            // 
            this.btn_consultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_consultar.Location = new System.Drawing.Point(332, 149);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_consultar.TabIndex = 53;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // alterarOcu
            // 
            this.alterarOcu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alterarOcu.Location = new System.Drawing.Point(93, 485);
            this.alterarOcu.Name = "alterarOcu";
            this.alterarOcu.Size = new System.Drawing.Size(75, 23);
            this.alterarOcu.TabIndex = 54;
            this.alterarOcu.Text = "Alterar";
            this.alterarOcu.UseVisualStyleBackColor = true;
            this.alterarOcu.Click += new System.EventHandler(this.alterarOcu_Click);
            // 
            // excluirOcu
            // 
            this.excluirOcu.BackColor = System.Drawing.Color.Red;
            this.excluirOcu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excluirOcu.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.excluirOcu.FlatAppearance.BorderSize = 0;
            this.excluirOcu.ForeColor = System.Drawing.Color.Black;
            this.excluirOcu.Location = new System.Drawing.Point(332, 175);
            this.excluirOcu.Margin = new System.Windows.Forms.Padding(0);
            this.excluirOcu.Name = "excluirOcu";
            this.excluirOcu.Size = new System.Drawing.Size(75, 30);
            this.excluirOcu.TabIndex = 55;
            this.excluirOcu.Text = "Excluir";
            this.excluirOcu.UseVisualStyleBackColor = false;
            this.excluirOcu.Click += new System.EventHandler(this.excluirOcu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 446);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 13);
            this.label2.TabIndex = 56;
            this.label2.Text = "* Caso o óculos não tenha Grau Adicione o número 0";
            // 
            // oculos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 679);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.excluirOcu);
            this.Controls.Add(this.alterarOcu);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textIdOculos);
            this.Controls.Add(this.dataGridOculos);
            this.Controls.Add(this.textFonecedor);
            this.Controls.Add(this.idFornecedor);
            this.Controls.Add(this.idCategoria);
            this.Controls.Add(this.textCat);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.cadOcu);
            this.Controls.Add(this.textQtdGrau);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textGrau);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textPreco);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textModelo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textNomeOculos);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Name = "oculos";
            this.Text = "oculos";
            this.Load += new System.EventHandler(this.oculos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOculosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOculos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oculosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cadOcu;
        private System.Windows.Forms.TextBox textQtdGrau;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textGrau;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textPreco;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textModelo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textNomeOculos;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.ComboBox textCat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox idCategoria;
        private DatabaseOculosDataSet databaseOculosDataSet;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private DatabaseOculosDataSetTableAdapters.CategoriasTableAdapter categoriasTableAdapter;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.TextBox idFornecedor;
        private System.Windows.Forms.ComboBox textFonecedor;
        private System.Windows.Forms.BindingSource fornecedoresBindingSource;
        private DatabaseOculosDataSetTableAdapters.FornecedoresTableAdapter fornecedoresTableAdapter;
        private System.Windows.Forms.DataGridView dataGridOculos;
        private System.Windows.Forms.BindingSource oculosBindingSource;
        private DatabaseOculosDataSetTableAdapters.OculosTableAdapter oculosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idOculosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFornecedorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeOculosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloOculosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoOculosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn possuiGrauDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdGrauDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textIdOculos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Button alterarOcu;
        private System.Windows.Forms.Button excluirOcu;
        private System.Windows.Forms.Label label2;
    }
}