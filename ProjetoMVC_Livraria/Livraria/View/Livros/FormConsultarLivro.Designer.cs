namespace Livraria.View.Livros
{
    partial class FormConsultarLivro
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
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ISBN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ano = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preço = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.livroBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livrariaDataSet = new Livraria.livrariaDataSet();
            this.livroTableAdapter = new Livraria.livrariaDataSetTableAdapters.LivroTableAdapter();
            this.lblDica = new MetroFramework.Controls.MetroLabel();
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLivros
            // 
            this.dgvLivros.AllowUserToAddRows = false;
            this.dgvLivros.AllowUserToDeleteRows = false;
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.ISBN,
            this.Nome,
            this.Ano,
            this.Editora,
            this.Genero,
            this.Preço,
            this.Estoque});
            this.dgvLivros.Location = new System.Drawing.Point(17, 88);
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivros.Size = new System.Drawing.Size(980, 323);
            this.dgvLivros.TabIndex = 0;
            this.dgvLivros.DoubleClick += new System.EventHandler(this.dgvLivros_DoubleClick);
            this.dgvLivros.MouseEnter += new System.EventHandler(this.dgvLivros_MouseEnter);
            this.dgvLivros.MouseLeave += new System.EventHandler(this.dgvLivros_MouseLeave);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID Livro";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // ISBN
            // 
            this.ISBN.HeaderText = "ISBN";
            this.ISBN.Name = "ISBN";
            this.ISBN.ReadOnly = true;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome do Livro";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 320;
            // 
            // Ano
            // 
            this.Ano.HeaderText = "Ano";
            this.Ano.Name = "Ano";
            this.Ano.ReadOnly = true;
            this.Ano.Width = 60;
            // 
            // Editora
            // 
            this.Editora.HeaderText = "Editora";
            this.Editora.Name = "Editora";
            this.Editora.ReadOnly = true;
            this.Editora.Width = 102;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // Preço
            // 
            this.Preço.HeaderText = "Preço";
            this.Preço.Name = "Preço";
            this.Preço.ReadOnly = true;
            this.Preço.Width = 80;
            // 
            // Estoque
            // 
            this.Estoque.HeaderText = "Estoque";
            this.Estoque.Name = "Estoque";
            this.Estoque.ReadOnly = true;
            this.Estoque.Width = 75;
            // 
            // livroBindingSource
            // 
            this.livroBindingSource.DataMember = "Livro";
            this.livroBindingSource.DataSource = this.livrariaDataSet;
            // 
            // livrariaDataSet
            // 
            this.livrariaDataSet.DataSetName = "livrariaDataSet";
            this.livrariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // livroTableAdapter
            // 
            this.livroTableAdapter.ClearBeforeFill = true;
            // 
            // lblDica
            // 
            this.lblDica.AutoSize = true;
            this.lblDica.BackColor = System.Drawing.Color.Red;
            this.lblDica.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDica.ForeColor = System.Drawing.Color.Red;
            this.lblDica.Location = new System.Drawing.Point(17, 429);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(443, 25);
            this.lblDica.Style = MetroFramework.MetroColorStyle.Red;
            this.lblDica.TabIndex = 1;
            this.lblDica.Text = "Dê um duplo clique no livro que deseja alterar ou excluir";
            this.lblDica.UseCustomForeColor = true;
            this.lblDica.Visible = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnVoltar.Location = new System.Drawing.Point(871, 429);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(119, 25);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseSelectable = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // FormConsultarLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 474);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblDica);
            this.Controls.Add(this.dgvLivros);
            this.Name = "FormConsultarLivro";
            this.Resizable = false;
            this.Text = "Consultar Livro";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLivros;
        private livrariaDataSet livrariaDataSet;
        private System.Windows.Forms.BindingSource livroBindingSource;
        private livrariaDataSetTableAdapters.LivroTableAdapter livroTableAdapter;
        private MetroFramework.Controls.MetroLabel lblDica;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estoque;
        private MetroFramework.Controls.MetroButton btnVoltar;
    }
}