namespace projetoOculosV2
{
    partial class categoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(categoria));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCat = new System.Windows.Forms.Button();
            this.nomeCat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseOculosDataSet = new projetoOculosV2.DatabaseOculosDataSet();
            this.categoriasTableAdapter = new projetoOculosV2.DatabaseOculosDataSetTableAdapters.CategoriasTableAdapter();
            this.tableAdapterManager = new projetoOculosV2.DatabaseOculosDataSetTableAdapters.TableAdapterManager();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.voltar = new System.Windows.Forms.Button();
            this.btn_consultar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textIdCategoria = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alterarCat = new System.Windows.Forms.Button();
            this.excluirCat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOculosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(732, 485);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnCat
            // 
            this.btnCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCat.Location = new System.Drawing.Point(34, 230);
            this.btnCat.Name = "btnCat";
            this.btnCat.Size = new System.Drawing.Size(75, 23);
            this.btnCat.TabIndex = 40;
            this.btnCat.Text = "Cadastrar";
            this.btnCat.UseVisualStyleBackColor = true;
            this.btnCat.Click += new System.EventHandler(this.btnCat_Click);
            // 
            // nomeCat
            // 
            this.nomeCat.Location = new System.Drawing.Point(34, 194);
            this.nomeCat.Name = "nomeCat";
            this.nomeCat.Size = new System.Drawing.Size(119, 20);
            this.nomeCat.TabIndex = 39;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(31, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Nome da categoria\r\n";
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "Categorias";
            this.categoriasBindingSource.DataSource = this.databaseOculosDataSet;
            // 
            // databaseOculosDataSet
            // 
            this.databaseOculosDataSet.DataSetName = "DatabaseOculosDataSet";
            this.databaseOculosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriasTableAdapter = this.categoriasTableAdapter;
            this.tableAdapterManager.CidadesTableAdapter = null;
            this.tableAdapterManager.FornecedoresTableAdapter = null;
            this.tableAdapterManager.OculosTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = projetoOculosV2.DatabaseOculosDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // voltar
            // 
            this.voltar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.voltar.Location = new System.Drawing.Point(34, 94);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(75, 23);
            this.voltar.TabIndex = 46;
            this.voltar.Text = "voltar";
            this.voltar.UseVisualStyleBackColor = true;
            this.voltar.Click += new System.EventHandler(this.voltar_Click);
            // 
            // btn_consultar
            // 
            this.btn_consultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_consultar.Location = new System.Drawing.Point(317, 192);
            this.btn_consultar.Name = "btn_consultar";
            this.btn_consultar.Size = new System.Drawing.Size(75, 23);
            this.btn_consultar.TabIndex = 56;
            this.btn_consultar.Text = "Consultar";
            this.btn_consultar.UseVisualStyleBackColor = true;
            this.btn_consultar.Click += new System.EventHandler(this.btn_consultar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(193)))), ((int)(((byte)(131)))));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(208, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 55;
            this.label1.Text = "Id Categoria";
            // 
            // textIdCategoria
            // 
            this.textIdCategoria.Location = new System.Drawing.Point(211, 194);
            this.textIdCategoria.Name = "textIdCategoria";
            this.textIdCategoria.Size = new System.Drawing.Size(100, 20);
            this.textIdCategoria.TabIndex = 54;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCategoriaDataGridViewTextBoxColumn,
            this.nomeCategoriaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.categoriasBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(211, 279);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(243, 150);
            this.dataGridView1.TabIndex = 57;
            // 
            // idCategoriaDataGridViewTextBoxColumn
            // 
            this.idCategoriaDataGridViewTextBoxColumn.DataPropertyName = "idCategoria";
            this.idCategoriaDataGridViewTextBoxColumn.HeaderText = "idCategoria";
            this.idCategoriaDataGridViewTextBoxColumn.Name = "idCategoriaDataGridViewTextBoxColumn";
            this.idCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeCategoriaDataGridViewTextBoxColumn
            // 
            this.nomeCategoriaDataGridViewTextBoxColumn.DataPropertyName = "nomeCategoria";
            this.nomeCategoriaDataGridViewTextBoxColumn.HeaderText = "nomeCategoria";
            this.nomeCategoriaDataGridViewTextBoxColumn.Name = "nomeCategoriaDataGridViewTextBoxColumn";
            // 
            // alterarCat
            // 
            this.alterarCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.alterarCat.Location = new System.Drawing.Point(115, 230);
            this.alterarCat.Name = "alterarCat";
            this.alterarCat.Size = new System.Drawing.Size(75, 23);
            this.alterarCat.TabIndex = 58;
            this.alterarCat.Text = "Alterar";
            this.alterarCat.UseVisualStyleBackColor = true;
            this.alterarCat.Click += new System.EventHandler(this.alterarCat_Click);
            // 
            // excluirCat
            // 
            this.excluirCat.BackColor = System.Drawing.Color.Red;
            this.excluirCat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excluirCat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.excluirCat.FlatAppearance.BorderSize = 0;
            this.excluirCat.ForeColor = System.Drawing.Color.Black;
            this.excluirCat.Location = new System.Drawing.Point(317, 223);
            this.excluirCat.Margin = new System.Windows.Forms.Padding(0);
            this.excluirCat.Name = "excluirCat";
            this.excluirCat.Size = new System.Drawing.Size(75, 30);
            this.excluirCat.TabIndex = 59;
            this.excluirCat.Text = "Excluir";
            this.excluirCat.UseVisualStyleBackColor = false;
            this.excluirCat.Click += new System.EventHandler(this.excluirCat_Click);
            // 
            // categoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 506);
            this.Controls.Add(this.excluirCat);
            this.Controls.Add(this.alterarCat);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_consultar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textIdCategoria);
            this.Controls.Add(this.voltar);
            this.Controls.Add(this.btnCat);
            this.Controls.Add(this.nomeCat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "categoria";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseOculosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnCat;
        private System.Windows.Forms.TextBox nomeCat;
        private System.Windows.Forms.Label label2;
        private DatabaseOculosDataSet databaseOculosDataSet;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private DatabaseOculosDataSetTableAdapters.CategoriasTableAdapter categoriasTableAdapter;
        private DatabaseOculosDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.Button btn_consultar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textIdCategoria;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button alterarCat;
        private System.Windows.Forms.Button excluirCat;
    }
}