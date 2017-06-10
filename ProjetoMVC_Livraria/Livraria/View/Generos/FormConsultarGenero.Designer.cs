namespace Livraria.View.Generos
{
    partial class FormConsultarGenero
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
            this.dgvGeneros = new System.Windows.Forms.DataGridView();
            this.livrariaDataSet1 = new Livraria.livrariaDataSet1();
            this.generoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.generoTableAdapter = new Livraria.livrariaDataSet1TableAdapters.GeneroTableAdapter();
            this.idGeneroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeGeneroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picLogoInicial = new System.Windows.Forms.PictureBox();
            this.picAtencao = new System.Windows.Forms.PictureBox();
            this.lblDica = new MetroFramework.Controls.MetroLabel();
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            this.generoDataSet = new Livraria.generoDataSet();
            this.generoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.generoTableAdapter1 = new Livraria.generoDataSetTableAdapters.GeneroTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicial)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAtencao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvGeneros
            // 
            this.dgvGeneros.AllowUserToAddRows = false;
            this.dgvGeneros.AllowUserToDeleteRows = false;
            this.dgvGeneros.AllowUserToResizeColumns = false;
            this.dgvGeneros.AllowUserToResizeRows = false;
            this.dgvGeneros.AutoGenerateColumns = false;
            this.dgvGeneros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idGeneroDataGridViewTextBoxColumn,
            this.nomeGeneroDataGridViewTextBoxColumn});
            this.dgvGeneros.DataSource = this.generoBindingSource1;
            this.dgvGeneros.Location = new System.Drawing.Point(23, 78);
            this.dgvGeneros.Name = "dgvGeneros";
            this.dgvGeneros.ReadOnly = true;
            this.dgvGeneros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGeneros.Size = new System.Drawing.Size(393, 150);
            this.dgvGeneros.TabIndex = 0;
            this.dgvGeneros.DoubleClick += new System.EventHandler(this.dgvGeneros_DoubleClick);
            this.dgvGeneros.MouseEnter += new System.EventHandler(this.dgvGeneros_MouseEnter);
            this.dgvGeneros.MouseLeave += new System.EventHandler(this.dgvGeneros_MouseLeave);
            // 
            // livrariaDataSet1
            // 
            this.livrariaDataSet1.DataSetName = "livrariaDataSet1";
            this.livrariaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generoBindingSource
            // 
            this.generoBindingSource.DataMember = "Genero";
            this.generoBindingSource.DataSource = this.livrariaDataSet1;
            // 
            // generoTableAdapter
            // 
            this.generoTableAdapter.ClearBeforeFill = true;
            // 
            // idGeneroDataGridViewTextBoxColumn
            // 
            this.idGeneroDataGridViewTextBoxColumn.DataPropertyName = "IdGenero";
            this.idGeneroDataGridViewTextBoxColumn.HeaderText = "Id do Gênero";
            this.idGeneroDataGridViewTextBoxColumn.Name = "idGeneroDataGridViewTextBoxColumn";
            this.idGeneroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeGeneroDataGridViewTextBoxColumn
            // 
            this.nomeGeneroDataGridViewTextBoxColumn.DataPropertyName = "NomeGenero";
            this.nomeGeneroDataGridViewTextBoxColumn.HeaderText = "Nome do Gênero";
            this.nomeGeneroDataGridViewTextBoxColumn.Name = "nomeGeneroDataGridViewTextBoxColumn";
            this.nomeGeneroDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeGeneroDataGridViewTextBoxColumn.Width = 250;
            // 
            // picLogoInicial
            // 
            this.picLogoInicial.BackColor = System.Drawing.Color.Transparent;
            this.picLogoInicial.Image = global::Livraria.Properties.Resources.logo;
            this.picLogoInicial.Location = new System.Drawing.Point(21, 23);
            this.picLogoInicial.Name = "picLogoInicial";
            this.picLogoInicial.Size = new System.Drawing.Size(38, 33);
            this.picLogoInicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoInicial.TabIndex = 11;
            this.picLogoInicial.TabStop = false;
            // 
            // picAtencao
            // 
            this.picAtencao.Image = global::Livraria.Properties.Resources.warning;
            this.picAtencao.Location = new System.Drawing.Point(22, 245);
            this.picAtencao.Name = "picAtencao";
            this.picAtencao.Size = new System.Drawing.Size(20, 19);
            this.picAtencao.TabIndex = 38;
            this.picAtencao.TabStop = false;
            // 
            // lblDica
            // 
            this.lblDica.AutoSize = true;
            this.lblDica.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDica.Location = new System.Drawing.Point(40, 244);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(359, 19);
            this.lblDica.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDica.TabIndex = 37;
            this.lblDica.Text = "Dê um duplo clique no gênero que deseja alterar ou excluir.";
            this.lblDica.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDica.UseCustomForeColor = true;
            this.lblDica.UseStyleColors = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(297, 271);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(119, 35);
            this.btnVoltar.TabIndex = 39;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseSelectable = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // generoDataSet
            // 
            this.generoDataSet.DataSetName = "generoDataSet";
            this.generoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generoBindingSource1
            // 
            this.generoBindingSource1.DataMember = "Genero";
            this.generoBindingSource1.DataSource = this.generoDataSet;
            // 
            // generoTableAdapter1
            // 
            this.generoTableAdapter1.ClearBeforeFill = true;
            // 
            // FormConsultarGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 315);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.picAtencao);
            this.Controls.Add(this.lblDica);
            this.Controls.Add(this.picLogoInicial);
            this.Controls.Add(this.dgvGeneros);
            this.Name = "FormConsultarGenero";
            this.Resizable = false;
            this.Text = "        Consultar Gêneros";
            this.Load += new System.EventHandler(this.FormConsultarGenero_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGeneros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrariaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicial)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAtencao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvGeneros;
        private livrariaDataSet1 livrariaDataSet1;
        private System.Windows.Forms.BindingSource generoBindingSource;
        private livrariaDataSet1TableAdapters.GeneroTableAdapter generoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idGeneroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeGeneroDataGridViewTextBoxColumn;
        private System.Windows.Forms.PictureBox picLogoInicial;
        private System.Windows.Forms.PictureBox picAtencao;
        private MetroFramework.Controls.MetroLabel lblDica;
        private MetroFramework.Controls.MetroButton btnVoltar;
        private generoDataSet generoDataSet;
        private System.Windows.Forms.BindingSource generoBindingSource1;
        private generoDataSetTableAdapters.GeneroTableAdapter generoTableAdapter1;

    }
}