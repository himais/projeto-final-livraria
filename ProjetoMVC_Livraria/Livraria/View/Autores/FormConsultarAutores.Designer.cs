namespace Livraria.View.Autores
{
    partial class FormConsultarAutores
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
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            this.lblDica = new MetroFramework.Controls.MetroLabel();
            this.picLogoInicial = new System.Windows.Forms.PictureBox();
            this.dgvAutores = new System.Windows.Forms.DataGridView();
            this.idAutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeAutorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.autorDataSet = new Livraria.autorDataSet();
            this.autorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livrariaDataSet2 = new Livraria.livrariaDataSet2();
            this.picAtencao = new System.Windows.Forms.PictureBox();
            this.autorTableAdapter = new Livraria.livrariaDataSet2TableAdapters.AutorTableAdapter();
            this.autorTableAdapter1 = new Livraria.autorDataSetTableAdapters.AutorTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAtencao)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(297, 273);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(119, 35);
            this.btnVoltar.TabIndex = 43;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseSelectable = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblDica
            // 
            this.lblDica.AutoSize = true;
            this.lblDica.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDica.Location = new System.Drawing.Point(40, 246);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(348, 19);
            this.lblDica.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDica.TabIndex = 42;
            this.lblDica.Text = "Dê um duplo clique no autor que deseja alterar ou excluir.";
            this.lblDica.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDica.UseCustomForeColor = true;
            this.lblDica.UseStyleColors = true;
            // 
            // picLogoInicial
            // 
            this.picLogoInicial.BackColor = System.Drawing.Color.Transparent;
            this.picLogoInicial.Image = global::Livraria.Properties.Resources.logo;
            this.picLogoInicial.Location = new System.Drawing.Point(21, 23);
            this.picLogoInicial.Name = "picLogoInicial";
            this.picLogoInicial.Size = new System.Drawing.Size(38, 33);
            this.picLogoInicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoInicial.TabIndex = 41;
            this.picLogoInicial.TabStop = false;
            // 
            // dgvAutores
            // 
            this.dgvAutores.AllowUserToAddRows = false;
            this.dgvAutores.AllowUserToDeleteRows = false;
            this.dgvAutores.AllowUserToResizeColumns = false;
            this.dgvAutores.AllowUserToResizeRows = false;
            this.dgvAutores.AutoGenerateColumns = false;
            this.dgvAutores.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAutorDataGridViewTextBoxColumn,
            this.nomeAutorDataGridViewTextBoxColumn});
            this.dgvAutores.DataSource = this.autorBindingSource1;
            this.dgvAutores.Location = new System.Drawing.Point(23, 80);
            this.dgvAutores.Name = "dgvAutores";
            this.dgvAutores.ReadOnly = true;
            this.dgvAutores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAutores.Size = new System.Drawing.Size(393, 150);
            this.dgvAutores.TabIndex = 40;
            this.dgvAutores.CellMouseLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAutores_CellMouseLeave);
            this.dgvAutores.DoubleClick += new System.EventHandler(this.dgvAutores_DoubleClick);
            this.dgvAutores.MouseEnter += new System.EventHandler(this.dgvAutores_MouseEnter);
            this.dgvAutores.MouseLeave += new System.EventHandler(this.dgvAutores_MouseLeave);
            // 
            // idAutorDataGridViewTextBoxColumn
            // 
            this.idAutorDataGridViewTextBoxColumn.DataPropertyName = "IdAutor";
            this.idAutorDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idAutorDataGridViewTextBoxColumn.Name = "idAutorDataGridViewTextBoxColumn";
            this.idAutorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeAutorDataGridViewTextBoxColumn
            // 
            this.nomeAutorDataGridViewTextBoxColumn.DataPropertyName = "NomeAutor";
            this.nomeAutorDataGridViewTextBoxColumn.HeaderText = "Nome do Autor";
            this.nomeAutorDataGridViewTextBoxColumn.Name = "nomeAutorDataGridViewTextBoxColumn";
            this.nomeAutorDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeAutorDataGridViewTextBoxColumn.Width = 250;
            // 
            // autorBindingSource1
            // 
            this.autorBindingSource1.DataMember = "Autor";
            this.autorBindingSource1.DataSource = this.autorDataSet;
            // 
            // autorDataSet
            // 
            this.autorDataSet.DataSetName = "autorDataSet";
            this.autorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // autorBindingSource
            // 
            this.autorBindingSource.DataMember = "Autor";
            this.autorBindingSource.DataSource = this.livrariaDataSet2;
            // 
            // livrariaDataSet2
            // 
            this.livrariaDataSet2.DataSetName = "livrariaDataSet2";
            this.livrariaDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // picAtencao
            // 
            this.picAtencao.Image = global::Livraria.Properties.Resources.warning;
            this.picAtencao.Location = new System.Drawing.Point(21, 246);
            this.picAtencao.Name = "picAtencao";
            this.picAtencao.Size = new System.Drawing.Size(20, 19);
            this.picAtencao.TabIndex = 44;
            this.picAtencao.TabStop = false;
            // 
            // autorTableAdapter
            // 
            this.autorTableAdapter.ClearBeforeFill = true;
            // 
            // autorTableAdapter1
            // 
            this.autorTableAdapter1.ClearBeforeFill = true;
            // 
            // FormConsultarAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 322);
            this.Controls.Add(this.picAtencao);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.lblDica);
            this.Controls.Add(this.picLogoInicial);
            this.Controls.Add(this.dgvAutores);
            this.Name = "FormConsultarAutores";
            this.Text = "       Consultar Autores";
            this.Load += new System.EventHandler(this.FormConsultarAutores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAutores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.autorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAtencao)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnVoltar;
        private MetroFramework.Controls.MetroLabel lblDica;
        private System.Windows.Forms.PictureBox picLogoInicial;
        private System.Windows.Forms.DataGridView dgvAutores;
        private System.Windows.Forms.PictureBox picAtencao;
        private livrariaDataSet2 livrariaDataSet2;
        private System.Windows.Forms.BindingSource autorBindingSource;
        private livrariaDataSet2TableAdapters.AutorTableAdapter autorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAutorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeAutorDataGridViewTextBoxColumn;
        private autorDataSet autorDataSet;
        private System.Windows.Forms.BindingSource autorBindingSource1;
        private autorDataSetTableAdapters.AutorTableAdapter autorTableAdapter1;

    }
}