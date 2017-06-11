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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            this.picLogoInicial = new System.Windows.Forms.PictureBox();
            this.picAtencao = new System.Windows.Forms.PictureBox();
            this.lblDica = new MetroFramework.Controls.MetroLabel();
            this.livroBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAtencao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource1)).BeginInit();
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
            this.dgvLivros.Location = new System.Drawing.Point(23, 72);
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.ReadOnly = true;
            this.dgvLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivros.Size = new System.Drawing.Size(982, 323);
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
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.Preço.DefaultCellStyle = dataGridViewCellStyle1;
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
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(886, 413);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(119, 35);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseSelectable = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // picLogoInicial
            // 
            this.picLogoInicial.BackColor = System.Drawing.Color.Transparent;
            this.picLogoInicial.Image = global::Livraria.Properties.Resources.logo;
            this.picLogoInicial.Location = new System.Drawing.Point(23, 21);
            this.picLogoInicial.Name = "picLogoInicial";
            this.picLogoInicial.Size = new System.Drawing.Size(38, 33);
            this.picLogoInicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoInicial.TabIndex = 35;
            this.picLogoInicial.TabStop = false;
            // 
            // picAtencao
            // 
            this.picAtencao.Image = global::Livraria.Properties.Resources.warning;
            this.picAtencao.Location = new System.Drawing.Point(23, 410);
            this.picAtencao.Name = "picAtencao";
            this.picAtencao.Size = new System.Drawing.Size(20, 19);
            this.picAtencao.TabIndex = 38;
            this.picAtencao.TabStop = false;
            // 
            // lblDica
            // 
            this.lblDica.AutoSize = true;
            this.lblDica.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDica.Location = new System.Drawing.Point(41, 409);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(342, 19);
            this.lblDica.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDica.TabIndex = 37;
            this.lblDica.Text = "Dê um duplo clique no livro que deseja alterar ou excluir.";
            this.lblDica.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDica.UseCustomForeColor = true;
            this.lblDica.UseStyleColors = true;
            // 
            // livroBindingSource1
            // 
            this.livroBindingSource1.DataMember = "Livro";
            // 
            // FormConsultarLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1031, 462);
            this.Controls.Add(this.picAtencao);
            this.Controls.Add(this.lblDica);
            this.Controls.Add(this.picLogoInicial);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.dgvLivros);
            this.MaximizeBox = false;
            this.Name = "FormConsultarLivro";
            this.Resizable = false;
            this.Text = "        Consultar Livro";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAtencao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livroBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLivros;
        private livrariaDataSet livrariaDataSet;
        private System.Windows.Forms.BindingSource livroBindingSource;
        private livrariaDataSetTableAdapters.LivroTableAdapter livroTableAdapter;
        private MetroFramework.Controls.MetroButton btnVoltar;
        private System.Windows.Forms.PictureBox picLogoInicial;
        private System.Windows.Forms.PictureBox picAtencao;
        private MetroFramework.Controls.MetroLabel lblDica;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ISBN;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ano;
        private System.Windows.Forms.DataGridViewTextBoxColumn Editora;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preço;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estoque;
        private System.Windows.Forms.BindingSource livroBindingSource1;

    }
}