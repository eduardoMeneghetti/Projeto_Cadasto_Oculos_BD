namespace projetoOculosV2
{
    partial class cadastroFunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadastroFunc));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textNomeFunc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.voltar = new System.Windows.Forms.Button();
            this.btnCat = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idFuncDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFuncDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfFuncDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEntradaEmpresaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseOculosDataSet = new projetoOculosV2.DatabaseOculosDataSet();
            this.dateDataNasc = new System.Windows.Forms.DateTimePicker();
            this.dateDataInicioEmp = new System.Windows.Forms.DateTimePicker();
            this.databaseOculosDataSet1 = new projetoOculosV2.DatabaseOculosDataSet();
            this.funcionariosTableAdapter = new projetoOculosV2.DatabaseOculosDataSetTableAdapters.funcionariosTableAdapter();
            this.textCPF = new System.Windows.Forms.MaskedTextBox();
            this.textIdFunc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnConsultarFunc = new System.Windows.Forms.Button();
            this.btnUpdateFunc = new System.Windows.Forms.Button();
            this.btnExcluirFunc = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOculosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOculosDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(731, 481);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(88, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Nome do Funcionário";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textNomeFunc
            // 
            this.textNomeFunc.Location = new System.Drawing.Point(91, 184);
            this.textNomeFunc.Name = "textNomeFunc";
            this.textNomeFunc.Size = new System.Drawing.Size(100, 20);
            this.textNomeFunc.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(349, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "CPF";
            this.label1.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(219, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Data Nascimento";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(480, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "Data de Inicio ";
            this.label4.Click += new System.EventHandler(this.label2_Click);
            // 
            // voltar
            // 
            this.voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar.Location = new System.Drawing.Point(44, 106);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(75, 23);
            this.voltar.TabIndex = 47;
            this.voltar.Text = "voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // btnCat
            // 
            this.btnCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCat.Location = new System.Drawing.Point(44, 236);
            this.btnCat.Name = "btnCat";
            this.btnCat.Size = new System.Drawing.Size(75, 23);
            this.btnCat.TabIndex = 48;
            this.btnCat.Text = "Cadastrar";
            this.btnCat.UseVisualStyleBackColor = true;
            this.btnCat.Click += new System.EventHandler(this.btnCat_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFuncDataGridViewTextBoxColumn1,
            this.nomeFuncDataGridViewTextBoxColumn1,
            this.dataNascimentoDataGridViewTextBoxColumn1,
            this.cpfFuncDataGridViewTextBoxColumn1,
            this.dataEntradaEmpresaDataGridViewTextBoxColumn1});
            this.dataGridView1.DataSource = this.funcionariosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(104, 326);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 150);
            this.dataGridView1.TabIndex = 50;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idFuncDataGridViewTextBoxColumn1
            // 
            this.idFuncDataGridViewTextBoxColumn1.DataPropertyName = "idFunc";
            this.idFuncDataGridViewTextBoxColumn1.HeaderText = "idFunc";
            this.idFuncDataGridViewTextBoxColumn1.Name = "idFuncDataGridViewTextBoxColumn1";
            this.idFuncDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // nomeFuncDataGridViewTextBoxColumn1
            // 
            this.nomeFuncDataGridViewTextBoxColumn1.DataPropertyName = "nomeFunc";
            this.nomeFuncDataGridViewTextBoxColumn1.HeaderText = "nomeFunc";
            this.nomeFuncDataGridViewTextBoxColumn1.Name = "nomeFuncDataGridViewTextBoxColumn1";
            // 
            // dataNascimentoDataGridViewTextBoxColumn1
            // 
            this.dataNascimentoDataGridViewTextBoxColumn1.DataPropertyName = "dataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn1.HeaderText = "dataNascimento";
            this.dataNascimentoDataGridViewTextBoxColumn1.Name = "dataNascimentoDataGridViewTextBoxColumn1";
            // 
            // cpfFuncDataGridViewTextBoxColumn1
            // 
            this.cpfFuncDataGridViewTextBoxColumn1.DataPropertyName = "cpfFunc";
            this.cpfFuncDataGridViewTextBoxColumn1.HeaderText = "cpfFunc";
            this.cpfFuncDataGridViewTextBoxColumn1.Name = "cpfFuncDataGridViewTextBoxColumn1";
            // 
            // dataEntradaEmpresaDataGridViewTextBoxColumn1
            // 
            this.dataEntradaEmpresaDataGridViewTextBoxColumn1.DataPropertyName = "dataEntradaEmpresa";
            this.dataEntradaEmpresaDataGridViewTextBoxColumn1.HeaderText = "dataEntradaEmpresa";
            this.dataEntradaEmpresaDataGridViewTextBoxColumn1.Name = "dataEntradaEmpresaDataGridViewTextBoxColumn1";
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "funcionarios";
            this.funcionariosBindingSource.DataSource = this.databaseOculosDataSet;
            this.funcionariosBindingSource.CurrentChanged += new System.EventHandler(this.funcionariosBindingSource_CurrentChanged);
            // 
            // databaseOculosDataSet
            // 
            this.databaseOculosDataSet.DataSetName = "DatabaseOculosDataSet";
            this.databaseOculosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dateDataNasc
            // 
            this.dateDataNasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDataNasc.Location = new System.Drawing.Point(222, 183);
            this.dateDataNasc.Name = "dateDataNasc";
            this.dateDataNasc.Size = new System.Drawing.Size(100, 20);
            this.dateDataNasc.TabIndex = 5;
            this.dateDataNasc.ValueChanged += new System.EventHandler(this.dateDataNasc_TextChanged);
            // 
            // dateDataInicioEmp
            // 
            this.dateDataInicioEmp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDataInicioEmp.Location = new System.Drawing.Point(483, 184);
            this.dateDataInicioEmp.Name = "dateDataInicioEmp";
            this.dateDataInicioEmp.Size = new System.Drawing.Size(100, 20);
            this.dateDataInicioEmp.TabIndex = 5;
            this.dateDataInicioEmp.ValueChanged += new System.EventHandler(this.dateDataInicioEmp_ValueChanged);
            // 
            // databaseOculosDataSet1
            // 
            this.databaseOculosDataSet1.DataSetName = "DatabaseOculosDataSet";
            this.databaseOculosDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionariosTableAdapter
            // 
            this.funcionariosTableAdapter.ClearBeforeFill = true;
            // 
            // textCPF
            // 
            this.textCPF.Location = new System.Drawing.Point(352, 183);
            this.textCPF.Mask = "000,000,000-00";
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(100, 20);
            this.textCPF.TabIndex = 53;
            this.textCPF.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textCPF_MaskInputRejected);
            // 
            // textIdFunc
            // 
            this.textIdFunc.Location = new System.Drawing.Point(536, 239);
            this.textIdFunc.Name = "textIdFunc";
            this.textIdFunc.Size = new System.Drawing.Size(100, 20);
            this.textIdFunc.TabIndex = 54;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(533, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "id Funcionário";
            // 
            // btnConsultarFunc
            // 
            this.btnConsultarFunc.Location = new System.Drawing.Point(642, 237);
            this.btnConsultarFunc.Name = "btnConsultarFunc";
            this.btnConsultarFunc.Size = new System.Drawing.Size(75, 23);
            this.btnConsultarFunc.TabIndex = 56;
            this.btnConsultarFunc.Text = "Consultar";
            this.btnConsultarFunc.UseVisualStyleBackColor = true;
            this.btnConsultarFunc.Click += new System.EventHandler(this.btnConsultarFunc_Click);
            // 
            // btnUpdateFunc
            // 
            this.btnUpdateFunc.Location = new System.Drawing.Point(142, 237);
            this.btnUpdateFunc.Name = "btnUpdateFunc";
            this.btnUpdateFunc.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateFunc.TabIndex = 57;
            this.btnUpdateFunc.Text = "Alterar";
            this.btnUpdateFunc.UseVisualStyleBackColor = true;
            this.btnUpdateFunc.Click += new System.EventHandler(this.btnUpdateFunc_Click);
            // 
            // btnExcluirFunc
            // 
            this.btnExcluirFunc.BackColor = System.Drawing.Color.Red;
            this.btnExcluirFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluirFunc.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnExcluirFunc.FlatAppearance.BorderSize = 0;
            this.btnExcluirFunc.ForeColor = System.Drawing.Color.Black;
            this.btnExcluirFunc.Location = new System.Drawing.Point(642, 263);
            this.btnExcluirFunc.Margin = new System.Windows.Forms.Padding(0);
            this.btnExcluirFunc.Name = "btnExcluirFunc";
            this.btnExcluirFunc.Size = new System.Drawing.Size(75, 30);
            this.btnExcluirFunc.TabIndex = 58;
            this.btnExcluirFunc.Text = "Excluir";
            this.btnExcluirFunc.UseVisualStyleBackColor = false;
            this.btnExcluirFunc.Click += new System.EventHandler(this.btnExcluirFunc_Click);
            // 
            // cadastroFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 474);
            this.Controls.Add(this.btnExcluirFunc);
            this.Controls.Add(this.btnUpdateFunc);
            this.Controls.Add(this.btnConsultarFunc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textIdFunc);
            this.Controls.Add(this.textCPF);
            this.Controls.Add(this.dateDataInicioEmp);
            this.Controls.Add(this.dateDataNasc);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCat);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textNomeFunc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "cadastroFunc";
            this.Text = "cadastroFunc";
            this.Load += new System.EventHandler(this.cadastroFunc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOculosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOculosDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNomeFunc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Button btnCat;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private DatabaseOculosDataSet databaseOculosDataSet;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFuncDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFuncDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfFuncDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEntradaEmpresaDataGridViewTextBoxColumn1;
        private DatabaseOculosDataSet databaseOculosDataSet1;
        private DatabaseOculosDataSetTableAdapters.funcionariosTableAdapter funcionariosTableAdapter;
        private System.Windows.Forms.DateTimePicker dateDataNasc;
        private System.Windows.Forms.DateTimePicker dateDataInicioEmp;
        private System.Windows.Forms.MaskedTextBox textCPF;
        private System.Windows.Forms.TextBox textIdFunc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnConsultarFunc;
        private System.Windows.Forms.Button btnUpdateFunc;
        private System.Windows.Forms.Button btnExcluirFunc;
    }
}