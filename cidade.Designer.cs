namespace projetoOculosV2
{
    partial class cidade
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cidade));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cadCid = new System.Windows.Forms.Button();
            this.nomeEst = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.nomeCid = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.voltar = new System.Windows.Forms.Button();
            this.excluirCid = new System.Windows.Forms.Button();
            this.alterarCid = new System.Windows.Forms.Button();
            this.consultaCid = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.idCid = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.databaseOculosDataSet = new projetoOculosV2.DatabaseOculosDataSet();
            this.cidadesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cidadesTableAdapter = new projetoOculosV2.DatabaseOculosDataSetTableAdapters.CidadesTableAdapter();
            this.idCidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeEstadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOculosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(715, 469);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // cadCid
            // 
            this.cadCid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cadCid.Location = new System.Drawing.Point(36, 250);
            this.cadCid.Name = "cadCid";
            this.cadCid.Size = new System.Drawing.Size(75, 23);
            this.cadCid.TabIndex = 38;
            this.cadCid.Text = "Cadastrar";
            this.cadCid.UseVisualStyleBackColor = true;
            this.cadCid.Click += new System.EventHandler(this.cadCid_Click);
            // 
            // nomeEst
            // 
            this.nomeEst.Location = new System.Drawing.Point(36, 220);
            this.nomeEst.Name = "nomeEst";
            this.nomeEst.Size = new System.Drawing.Size(119, 20);
            this.nomeEst.TabIndex = 37;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(33, 204);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(40, 13);
            this.label14.TabIndex = 36;
            this.label14.Text = "Estado\r\n";
            // 
            // nomeCid
            // 
            this.nomeCid.Location = new System.Drawing.Point(36, 173);
            this.nomeCid.Name = "nomeCid";
            this.nomeCid.Size = new System.Drawing.Size(119, 20);
            this.nomeCid.TabIndex = 35;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(33, 157);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 13);
            this.label15.TabIndex = 34;
            this.label15.Text = "Nome Cidade";
            // 
            // voltar
            // 
            this.voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar.Location = new System.Drawing.Point(36, 93);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(75, 23);
            this.voltar.TabIndex = 47;
            this.voltar.Text = "voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // excluirCid
            // 
            this.excluirCid.BackColor = System.Drawing.Color.Red;
            this.excluirCid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excluirCid.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.excluirCid.FlatAppearance.BorderSize = 0;
            this.excluirCid.ForeColor = System.Drawing.Color.Black;
            this.excluirCid.Location = new System.Drawing.Point(316, 197);
            this.excluirCid.Margin = new System.Windows.Forms.Padding(0);
            this.excluirCid.Name = "excluirCid";
            this.excluirCid.Size = new System.Drawing.Size(75, 30);
            this.excluirCid.TabIndex = 61;
            this.excluirCid.Text = "Excluir";
            this.excluirCid.UseVisualStyleBackColor = false;
            this.excluirCid.Click += new System.EventHandler(this.excluirCid_Click);
            // 
            // alterarCid
            // 
            this.alterarCid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alterarCid.Location = new System.Drawing.Point(121, 250);
            this.alterarCid.Name = "alterarCid";
            this.alterarCid.Size = new System.Drawing.Size(75, 23);
            this.alterarCid.TabIndex = 60;
            this.alterarCid.Text = "Alterar";
            this.alterarCid.UseVisualStyleBackColor = true;
            this.alterarCid.Click += new System.EventHandler(this.alterarCid_Click);
            // 
            // consultaCid
            // 
            this.consultaCid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.consultaCid.Location = new System.Drawing.Point(316, 171);
            this.consultaCid.Name = "consultaCid";
            this.consultaCid.Size = new System.Drawing.Size(75, 23);
            this.consultaCid.TabIndex = 59;
            this.consultaCid.Text = "Consultar";
            this.consultaCid.UseVisualStyleBackColor = true;
            this.consultaCid.Click += new System.EventHandler(this.consultaCid_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(207, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 58;
            this.label1.Text = "Id Cidade";
            // 
            // idCid
            // 
            this.idCid.Location = new System.Drawing.Point(210, 173);
            this.idCid.Name = "idCid";
            this.idCid.Size = new System.Drawing.Size(100, 20);
            this.idCid.TabIndex = 57;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCidadeDataGridViewTextBoxColumn,
            this.nomeCidadeDataGridViewTextBoxColumn,
            this.nomeEstadoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cidadesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(222, 283);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 150);
            this.dataGridView1.TabIndex = 62;
            // 
            // databaseOculosDataSet
            // 
            this.databaseOculosDataSet.DataSetName = "DatabaseOculosDataSet";
            this.databaseOculosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cidadesBindingSource
            // 
            this.cidadesBindingSource.DataMember = "Cidades";
            this.cidadesBindingSource.DataSource = this.databaseOculosDataSet;
            // 
            // cidadesTableAdapter
            // 
            this.cidadesTableAdapter.ClearBeforeFill = true;
            // 
            // idCidadeDataGridViewTextBoxColumn
            // 
            this.idCidadeDataGridViewTextBoxColumn.DataPropertyName = "idCidade";
            this.idCidadeDataGridViewTextBoxColumn.HeaderText = "idCidade";
            this.idCidadeDataGridViewTextBoxColumn.Name = "idCidadeDataGridViewTextBoxColumn";
            this.idCidadeDataGridViewTextBoxColumn.ReadOnly = true;
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
            // cidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 469);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.excluirCid);
            this.Controls.Add(this.alterarCid);
            this.Controls.Add(this.consultaCid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.idCid);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.cadCid);
            this.Controls.Add(this.nomeEst);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.nomeCid);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.pictureBox1);
            this.Name = "cidade";
            this.Text = "cidade";
            this.Load += new System.EventHandler(this.cidade_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOculosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cidadesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button cadCid;
        private System.Windows.Forms.TextBox nomeEst;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox nomeCid;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Button excluirCid;
        private System.Windows.Forms.Button alterarCid;
        private System.Windows.Forms.Button consultaCid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idCid;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DatabaseOculosDataSet databaseOculosDataSet;
        private System.Windows.Forms.BindingSource cidadesBindingSource;
        private DatabaseOculosDataSetTableAdapters.CidadesTableAdapter cidadesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeEstadoDataGridViewTextBoxColumn;
    }
}