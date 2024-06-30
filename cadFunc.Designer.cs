namespace projetoOculosV2
{
    partial class cadFunc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cadFunc));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textNomeFunc = new System.Windows.Forms.TextBox();
            this.textCPFfunc = new System.Windows.Forms.TextBox();
            this.textDataNascimento = new System.Windows.Forms.TextBox();
            this.dataIngresso = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateDataNascimento = new System.Windows.Forms.Label();
            this.textCPF = new System.Windows.Forms.Label();
            this.dateDataIngresso = new System.Windows.Forms.Label();
            this.voltar = new System.Windows.Forms.Button();
            this.cadOcu = new System.Windows.Forms.Button();
            this.dataCadFunc = new System.Windows.Forms.DataGridView();
            this.idFuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataNascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfFuncDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataEntradaEmpresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.funcionariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseOculosDataSet = new projetoOculosV2.DatabaseOculosDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCadFunc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOculosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-8, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(731, 509);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textNomeFunc
            // 
            this.textNomeFunc.Location = new System.Drawing.Point(12, 227);
            this.textNomeFunc.Name = "textNomeFunc";
            this.textNomeFunc.Size = new System.Drawing.Size(100, 20);
            this.textNomeFunc.TabIndex = 2;
            this.textNomeFunc.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textCPFfunc
            // 
            this.textCPFfunc.Location = new System.Drawing.Point(364, 227);
            this.textCPFfunc.Name = "textCPFfunc";
            this.textCPFfunc.Size = new System.Drawing.Size(100, 20);
            this.textCPFfunc.TabIndex = 3;
            this.textCPFfunc.TextChanged += new System.EventHandler(this.cpfFunc_TextChanged);
            // 
            // textDataNascimento
            // 
            this.textDataNascimento.Location = new System.Drawing.Point(192, 227);
            this.textDataNascimento.Name = "textDataNascimento";
            this.textDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.textDataNascimento.TabIndex = 4;
            // 
            // dataIngresso
            // 
            this.dataIngresso.Location = new System.Drawing.Point(540, 227);
            this.dataIngresso.Name = "dataIngresso";
            this.dataIngresso.Size = new System.Drawing.Size(100, 20);
            this.dataIngresso.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Nome do funcionário";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // dateDataNascimento
            // 
            this.dateDataNascimento.AutoSize = true;
            this.dateDataNascimento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.dateDataNascimento.ForeColor = System.Drawing.Color.Black;
            this.dateDataNascimento.Location = new System.Drawing.Point(189, 211);
            this.dateDataNascimento.Name = "dateDataNascimento";
            this.dateDataNascimento.Size = new System.Drawing.Size(102, 13);
            this.dateDataNascimento.TabIndex = 24;
            this.dateDataNascimento.Text = "data de Nascimento";
            // 
            // textCPF
            // 
            this.textCPF.AutoSize = true;
            this.textCPF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.textCPF.ForeColor = System.Drawing.Color.Black;
            this.textCPF.Location = new System.Drawing.Point(362, 211);
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(27, 13);
            this.textCPF.TabIndex = 25;
            this.textCPF.Text = "CPF";
            this.textCPF.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateDataIngresso
            // 
            this.dateDataIngresso.AutoSize = true;
            this.dateDataIngresso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.dateDataIngresso.ForeColor = System.Drawing.Color.Black;
            this.dateDataIngresso.Location = new System.Drawing.Point(537, 211);
            this.dateDataIngresso.Name = "dateDataIngresso";
            this.dateDataIngresso.Size = new System.Drawing.Size(88, 13);
            this.dateDataIngresso.TabIndex = 26;
            this.dateDataIngresso.Text = "Data de Ingresso";
            // 
            // voltar
            // 
            this.voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar.Location = new System.Drawing.Point(12, 128);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(75, 23);
            this.voltar.TabIndex = 44;
            this.voltar.Text = "voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // cadOcu
            // 
            this.cadOcu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadOcu.Location = new System.Drawing.Point(12, 295);
            this.cadOcu.Name = "cadOcu";
            this.cadOcu.Size = new System.Drawing.Size(75, 23);
            this.cadOcu.TabIndex = 45;
            this.cadOcu.Text = "Cadastrar";
            this.cadOcu.UseVisualStyleBackColor = true;
            this.cadOcu.Click += new System.EventHandler(this.cadOcu_Click);
            // 
            // dataCadFunc
            // 
            this.dataCadFunc.AutoGenerateColumns = false;
            this.dataCadFunc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCadFunc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFuncDataGridViewTextBoxColumn,
            this.nomeFuncDataGridViewTextBoxColumn,
            this.dataNascimentoDataGridViewTextBoxColumn,
            this.cpfFuncDataGridViewTextBoxColumn,
            this.dataEntradaEmpresaDataGridViewTextBoxColumn});
            this.dataCadFunc.DataSource = this.funcionariosBindingSource;
            this.dataCadFunc.Location = new System.Drawing.Point(3, 358);
            this.dataCadFunc.Name = "dataCadFunc";
            this.dataCadFunc.Size = new System.Drawing.Size(544, 150);
            this.dataCadFunc.TabIndex = 46;
            // 
            // idFuncDataGridViewTextBoxColumn
            // 
            this.idFuncDataGridViewTextBoxColumn.DataPropertyName = "idFunc";
            this.idFuncDataGridViewTextBoxColumn.HeaderText = "idFunc";
            this.idFuncDataGridViewTextBoxColumn.Name = "idFuncDataGridViewTextBoxColumn";
            this.idFuncDataGridViewTextBoxColumn.ReadOnly = true;
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
            // cpfFuncDataGridViewTextBoxColumn
            // 
            this.cpfFuncDataGridViewTextBoxColumn.DataPropertyName = "cpfFunc";
            this.cpfFuncDataGridViewTextBoxColumn.HeaderText = "cpfFunc";
            this.cpfFuncDataGridViewTextBoxColumn.Name = "cpfFuncDataGridViewTextBoxColumn";
            // 
            // dataEntradaEmpresaDataGridViewTextBoxColumn
            // 
            this.dataEntradaEmpresaDataGridViewTextBoxColumn.DataPropertyName = "dataEntradaEmpresa";
            this.dataEntradaEmpresaDataGridViewTextBoxColumn.HeaderText = "dataEntradaEmpresa";
            this.dataEntradaEmpresaDataGridViewTextBoxColumn.Name = "dataEntradaEmpresaDataGridViewTextBoxColumn";
            // 
            // funcionariosBindingSource
            // 
            this.funcionariosBindingSource.DataMember = "funcionarios";
            this.funcionariosBindingSource.DataSource = this.databaseOculosDataSet;
            // 
            // databaseOculosDataSet
            // 
            this.databaseOculosDataSet.DataSetName = "DatabaseOculosDataSet";
            this.databaseOculosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 503);
            this.Controls.Add(this.dataCadFunc);
            this.Controls.Add(this.cadOcu);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.dateDataIngresso);
            this.Controls.Add(this.textCPF);
            this.Controls.Add(this.dateDataNascimento);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataIngresso);
            this.Controls.Add(this.textDataNascimento);
            this.Controls.Add(this.textCPFfunc);
            this.Controls.Add(this.textNomeFunc);
            this.Controls.Add(this.pictureBox1);
            this.Name = "cadFunc";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataCadFunc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOculosDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textNomeFunc;
        private System.Windows.Forms.TextBox textCPFfunc;
        private System.Windows.Forms.TextBox textDataNascimento;
        private System.Windows.Forms.TextBox dataIngresso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label dateDataNascimento;
        private System.Windows.Forms.Label textCPF;
        private System.Windows.Forms.Label dateDataIngresso;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Button cadOcu;
        private System.Windows.Forms.DataGridView dataCadFunc;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataNascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfFuncDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataEntradaEmpresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource funcionariosBindingSource;
        private DatabaseOculosDataSet databaseOculosDataSet;
    }
}