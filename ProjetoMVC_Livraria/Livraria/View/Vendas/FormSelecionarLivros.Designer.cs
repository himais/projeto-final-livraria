namespace Livraria.View.Vendas
{
    partial class FormSelecionarLivros
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
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.IDLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Autores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Selecionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLivros
            // 
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDLivro,
            this.NomeLivro,
            this.Preco,
            this.Editora,
            this.Genero,
            this.Autores,
            this.Selecionar});
            this.dgvLivros.Location = new System.Drawing.Point(23, 63);
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.Size = new System.Drawing.Size(944, 221);
            this.dgvLivros.TabIndex = 0;
            // 
            // IDLivro
            // 
            this.IDLivro.HeaderText = "ID Livro";
            this.IDLivro.Name = "IDLivro";
            this.IDLivro.ReadOnly = true;
            // 
            // NomeLivro
            // 
            this.NomeLivro.HeaderText = "Nome do Livro";
            this.NomeLivro.Name = "NomeLivro";
            this.NomeLivro.ReadOnly = true;
            this.NomeLivro.Width = 280;
            // 
            // Preco
            // 
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            this.Preco.Width = 60;
            // 
            // Editora
            // 
            this.Editora.HeaderText = "Editora";
            this.Editora.Name = "Editora";
            this.Editora.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Gênero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Autores
            // 
            this.Autores.HeaderText = "Autor(es)";
            this.Autores.Name = "Autores";
            this.Autores.ReadOnly = true;
            this.Autores.Width = 200;
            // 
            // Selecionar
            // 
            this.Selecionar.HeaderText = "Selecionar";
            this.Selecionar.Name = "Selecionar";
            this.Selecionar.Width = 60;
            // 
            // FormSelecionarLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 383);
            this.Controls.Add(this.dgvLivros);
            this.Name = "FormSelecionarLivros";
            this.Resizable = false;
            this.Text = "          Escolher livros para venda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLivros;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Autores;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Selecionar;
    }
}