namespace projetoOculosV2
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.categoria = new System.Windows.Forms.Button();
            this.oculos = new System.Windows.Forms.Button();
            this.fornecedor = new System.Windows.Forms.Button();
            this.cidade = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(726, 506);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // categoria
            // 
            this.categoria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.categoria.Location = new System.Drawing.Point(259, 176);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(115, 60);
            this.categoria.TabIndex = 1;
            this.categoria.Text = "Categoria";
            this.categoria.UseVisualStyleBackColor = true;
            this.categoria.Click += new System.EventHandler(this.categoria_Click);
            // 
            // oculos
            // 
            this.oculos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.oculos.Location = new System.Drawing.Point(419, 176);
            this.oculos.Name = "oculos";
            this.oculos.Size = new System.Drawing.Size(115, 60);
            this.oculos.TabIndex = 2;
            this.oculos.Text = "Óculos";
            this.oculos.UseVisualStyleBackColor = true;
            this.oculos.Click += new System.EventHandler(this.oculos_Click);
            // 
            // fornecedor
            // 
            this.fornecedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fornecedor.Location = new System.Drawing.Point(419, 277);
            this.fornecedor.Name = "fornecedor";
            this.fornecedor.Size = new System.Drawing.Size(115, 60);
            this.fornecedor.TabIndex = 4;
            this.fornecedor.Text = "Fornecedor";
            this.fornecedor.UseVisualStyleBackColor = true;
            this.fornecedor.Click += new System.EventHandler(this.fornecedor_Click);
            // 
            // cidade
            // 
            this.cidade.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cidade.Location = new System.Drawing.Point(259, 277);
            this.cidade.Name = "cidade";
            this.cidade.Size = new System.Drawing.Size(115, 60);
            this.cidade.TabIndex = 5;
            this.cidade.Text = "Cidade";
            this.cidade.UseVisualStyleBackColor = true;
            this.cidade.Click += new System.EventHandler(this.cidade_Click);
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 501);
            this.Controls.Add(this.cidade);
            this.Controls.Add(this.fornecedor);
            this.Controls.Add(this.oculos);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.pictureBox1);
            this.Name = "home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button categoria;
        private System.Windows.Forms.Button oculos;
        private System.Windows.Forms.Button fornecedor;
        private System.Windows.Forms.Button cidade;
    }
}