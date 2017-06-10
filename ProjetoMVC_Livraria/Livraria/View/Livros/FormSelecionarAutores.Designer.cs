namespace Livraria.View.Livros
{
    partial class FormSelecionarAutores
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAutoresLivro = new System.Windows.Forms.DataGridView();
            this.idAutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelecionarAutor = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.autorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autorDataSet = new Livraria.AutorDataSet();
            this.autorTableAdapter = new Livraria.AutorDataSetTableAdapters.AutorTableAdapter();
            this.autorDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.picLogoInicial = new System.Windows.Forms.PictureBox();
            this.btnFinalizar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnDesmarcarTodos = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutoresLivro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAutoresLivro
            // 
            this.dgvAutoresLivro.AllowUserToAddRows = false;
            this.dgvAutoresLivro.AllowUserToDeleteRows = false;
            this.dgvAutoresLivro.AutoGenerateColumns = false;
            this.dgvAutoresLivro.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAutoresLivro.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAutoresLivro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAutoresLivro.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAutorDataGridViewTextBoxColumn,
            this.nomeAutorDataGridViewTextBoxColumn,
            this.SelecionarAutor});
            this.dgvAutoresLivro.DataSource = this.autorBindingSource;
            this.dgvAutoresLivro.Location = new System.Drawing.Point(23, 62);
            this.dgvAutoresLivro.Name = "dgvAutoresLivro";
            this.dgvAutoresLivro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutoresLivro.Size = new System.Drawing.Size(543, 265);
            this.dgvAutoresLivro.TabIndex = 0;
            // 
            // idAutorDataGridViewTextBoxColumn
            // 
            this.idAutorDataGridViewTextBoxColumn.DataPropertyName = "IdAutor";
            this.idAutorDataGridViewTextBoxColumn.HeaderText = "Identificação";
            this.idAutorDataGridViewTextBoxColumn.Name = "idAutorDataGridViewTextBoxColumn";
            this.idAutorDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAutorDataGridViewTextBoxColumn.Width = 70;
            // 
            // nomeAutorDataGridViewTextBoxColumn
            // 
            this.nomeAutorDataGridViewTextBoxColumn.DataPropertyName = "NomeAutor";
            this.nomeAutorDataGridViewTextBoxColumn.HeaderText = "Nome do Autor";
            this.nomeAutorDataGridViewTextBoxColumn.Name = "nomeAutorDataGridViewTextBoxColumn";
            this.nomeAutorDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeAutorDataGridViewTextBoxColumn.Width = 330;
            // 
            // SelecionarAutor
            // 
            this.SelecionarAutor.HeaderText = "Selecionar";
            this.SelecionarAutor.Name = "SelecionarAutor";
            // 
            // autorBindingSource
            // 
            this.autorBindingSource.DataMember = "Autor";
            this.autorBindingSource.DataSource = this.autorDataSet;
            // 
            // autorDataSet
            // 
            this.autorDataSet.DataSetName = "AutorDataSet";
            this.autorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autorTableAdapter
            // 
            this.autorTableAdapter.ClearBeforeFill = true;
            // 
            // autorDataSetBindingSource
            // 
            this.autorDataSetBindingSource.DataSource = this.autorDataSet;
            this.autorDataSetBindingSource.Position = 0;
            // 
            // picLogoInicial
            // 
            this.picLogoInicial.BackColor = System.Drawing.Color.Transparent;
            this.picLogoInicial.Image = global::Livraria.Properties.Resources.logo;
            this.picLogoInicial.Location = new System.Drawing.Point(23, 21);
            this.picLogoInicial.Name = "picLogoInicial";
            this.picLogoInicial.Size = new System.Drawing.Size(38, 33);
            this.picLogoInicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoInicial.TabIndex = 40;
            this.picLogoInicial.TabStop = false;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(491, 333);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 35);
            this.btnFinalizar.TabIndex = 41;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseSelectable = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(410, 333);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 35);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnDesmarcarTodos
            // 
            this.btnDesmarcarTodos.Location = new System.Drawing.Point(23, 333);
            this.btnDesmarcarTodos.Name = "btnDesmarcarTodos";
            this.btnDesmarcarTodos.Size = new System.Drawing.Size(128, 35);
            this.btnDesmarcarTodos.TabIndex = 43;
            this.btnDesmarcarTodos.Text = "Desmarcar Todos";
            this.btnDesmarcarTodos.UseSelectable = true;
            this.btnDesmarcarTodos.Click += new System.EventHandler(this.btnDesmarcarTodos_Click);
            // 
            // FormSelecionarAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 380);
            this.Controls.Add(this.btnDesmarcarTodos);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnFinalizar);
            this.Controls.Add(this.picLogoInicial);
            this.Controls.Add(this.dgvAutoresLivro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSelecionarAutores";
            this.Resizable = false;
            this.Text = "        Selecionar autores para o livro cadastrado";
            this.Load += new System.EventHandler(this.FormSelecionarAutores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutoresLivro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicial)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAutoresLivro;
        private AutorDataSet autorDataSet;
        private System.Windows.Forms.BindingSource autorBindingSource;
        private AutorDataSetTableAdapters.AutorTableAdapter autorTableAdapter;
        private System.Windows.Forms.BindingSource autorDataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelecionarAutor;
        private System.Windows.Forms.PictureBox picLogoInicial;
        private MetroFramework.Controls.MetroButton btnFinalizar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnDesmarcarTodos;
    }
}