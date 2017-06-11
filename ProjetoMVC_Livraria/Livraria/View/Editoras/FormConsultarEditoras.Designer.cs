namespace Livraria.View.Editoras
{
    partial class FormConsultarEditoras
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
            this.dgvEditoras = new System.Windows.Forms.DataGridView();
            this.idEditoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeEditoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.razaoSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNPJDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editoraDataSet = new Livraria.EditoraDataSet();
            this.funcionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.funcionarioDataSet = new Livraria.FuncionarioDataSet();
            this.funcionarioTableAdapter = new Livraria.FuncionarioDataSetTableAdapters.FuncionarioTableAdapter();
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            this.picAtencao = new System.Windows.Forms.PictureBox();
            this.lblDica = new MetroFramework.Controls.MetroLabel();
            this.picLogoInicial = new System.Windows.Forms.PictureBox();
            this.editoraTableAdapter = new Livraria.EditoraDataSetTableAdapters.EditoraTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAtencao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEditoras
            // 
            this.dgvEditoras.AllowUserToAddRows = false;
            this.dgvEditoras.AllowUserToDeleteRows = false;
            this.dgvEditoras.AutoGenerateColumns = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEditoras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvEditoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEditoras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idEditoraDataGridViewTextBoxColumn,
            this.nomeEditoraDataGridViewTextBoxColumn,
            this.razaoSocialDataGridViewTextBoxColumn,
            this.cNPJDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvEditoras.DataSource = this.editoraBindingSource;
            this.dgvEditoras.Location = new System.Drawing.Point(23, 63);
            this.dgvEditoras.Name = "dgvEditoras";
            this.dgvEditoras.ReadOnly = true;
            this.dgvEditoras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEditoras.Size = new System.Drawing.Size(654, 204);
            this.dgvEditoras.TabIndex = 38;
            this.dgvEditoras.DoubleClick += new System.EventHandler(this.dgvEditoras_DoubleClick);
            this.dgvEditoras.MouseEnter += new System.EventHandler(this.dgvEditoras_MouseEnter);
            this.dgvEditoras.MouseLeave += new System.EventHandler(this.dgvEditoras_MouseLeave);
            // 
            // idEditoraDataGridViewTextBoxColumn
            // 
            this.idEditoraDataGridViewTextBoxColumn.DataPropertyName = "IdEditora";
            this.idEditoraDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idEditoraDataGridViewTextBoxColumn.Name = "idEditoraDataGridViewTextBoxColumn";
            this.idEditoraDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEditoraDataGridViewTextBoxColumn.Width = 20;
            // 
            // nomeEditoraDataGridViewTextBoxColumn
            // 
            this.nomeEditoraDataGridViewTextBoxColumn.DataPropertyName = "NomeEditora";
            this.nomeEditoraDataGridViewTextBoxColumn.HeaderText = "Nome da Editora";
            this.nomeEditoraDataGridViewTextBoxColumn.Name = "nomeEditoraDataGridViewTextBoxColumn";
            this.nomeEditoraDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeEditoraDataGridViewTextBoxColumn.Width = 150;
            // 
            // razaoSocialDataGridViewTextBoxColumn
            // 
            this.razaoSocialDataGridViewTextBoxColumn.DataPropertyName = "RazaoSocial";
            this.razaoSocialDataGridViewTextBoxColumn.HeaderText = "Razão Social";
            this.razaoSocialDataGridViewTextBoxColumn.Name = "razaoSocialDataGridViewTextBoxColumn";
            this.razaoSocialDataGridViewTextBoxColumn.ReadOnly = true;
            this.razaoSocialDataGridViewTextBoxColumn.Width = 180;
            // 
            // cNPJDataGridViewTextBoxColumn
            // 
            this.cNPJDataGridViewTextBoxColumn.DataPropertyName = "CNPJ";
            this.cNPJDataGridViewTextBoxColumn.HeaderText = "CNPJ";
            this.cNPJDataGridViewTextBoxColumn.Name = "cNPJDataGridViewTextBoxColumn";
            this.cNPJDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "E-mail";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 160;
            // 
            // editoraBindingSource
            // 
            this.editoraBindingSource.DataMember = "Editora";
            this.editoraBindingSource.DataSource = this.editoraDataSet;
            // 
            // editoraDataSet
            // 
            this.editoraDataSet.DataSetName = "EditoraDataSet";
            this.editoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionarioBindingSource
            // 
            this.funcionarioBindingSource.DataMember = "Funcionario";
            this.funcionarioBindingSource.DataSource = this.funcionarioDataSet;
            // 
            // funcionarioDataSet
            // 
            this.funcionarioDataSet.DataSetName = "FuncionarioDataSet";
            this.funcionarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // funcionarioTableAdapter
            // 
            this.funcionarioTableAdapter.ClearBeforeFill = true;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(558, 302);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(119, 35);
            this.btnVoltar.TabIndex = 42;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseSelectable = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // picAtencao
            // 
            this.picAtencao.Image = global::Livraria.Properties.Resources.warning;
            this.picAtencao.Location = new System.Drawing.Point(25, 280);
            this.picAtencao.Name = "picAtencao";
            this.picAtencao.Size = new System.Drawing.Size(20, 19);
            this.picAtencao.TabIndex = 41;
            this.picAtencao.TabStop = false;
            // 
            // lblDica
            // 
            this.lblDica.AutoSize = true;
            this.lblDica.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDica.Location = new System.Drawing.Point(43, 279);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(358, 19);
            this.lblDica.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDica.TabIndex = 40;
            this.lblDica.Text = "Dê um duplo clique na editora que deseja alterar ou excluir.";
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
            this.picLogoInicial.TabIndex = 39;
            this.picLogoInicial.TabStop = false;
            // 
            // editoraTableAdapter
            // 
            this.editoraTableAdapter.ClearBeforeFill = true;
            // 
            // FormConsultarEditoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 348);
            this.Controls.Add(this.dgvEditoras);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.picAtencao);
            this.Controls.Add(this.lblDica);
            this.Controls.Add(this.picLogoInicial);
            this.Name = "FormConsultarEditoras";
            this.Resizable = false;
            this.Text = "        Consultar Editoras";
            this.Load += new System.EventHandler(this.FormConsultarEditoras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEditoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.funcionarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAtencao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEditoras;
        private System.Windows.Forms.BindingSource funcionarioBindingSource;
        private FuncionarioDataSet funcionarioDataSet;
        private FuncionarioDataSetTableAdapters.FuncionarioTableAdapter funcionarioTableAdapter;
        private MetroFramework.Controls.MetroButton btnVoltar;
        private System.Windows.Forms.PictureBox picAtencao;
        private MetroFramework.Controls.MetroLabel lblDica;
        private System.Windows.Forms.PictureBox picLogoInicial;
        private EditoraDataSet editoraDataSet;
        private System.Windows.Forms.BindingSource editoraBindingSource;
        private EditoraDataSetTableAdapters.EditoraTableAdapter editoraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEditoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeEditoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn razaoSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNPJDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;

    }
}