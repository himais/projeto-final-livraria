namespace Livraria.View.Vendas
{
    partial class FormConsultarVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvVendas = new System.Windows.Forms.DataGridView();
            this.idVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precoTotalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalLivrosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeFuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaDataSet3BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vendaDataSet3 = new Livraria.VendaDataSet3();
            this.vendaTableAdapter = new Livraria.VendaDataSet3TableAdapters.VendaTableAdapter();
            this.picAtencao = new System.Windows.Forms.PictureBox();
            this.lblDica = new MetroFramework.Controls.MetroLabel();
            this.btnVoltar = new MetroFramework.Controls.MetroButton();
            this.picLogoInicial = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaDataSet3BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAtencao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvVendas
            // 
            this.dgvVendas.AllowUserToAddRows = false;
            this.dgvVendas.AllowUserToDeleteRows = false;
            this.dgvVendas.AutoGenerateColumns = false;
            this.dgvVendas.BackgroundColor = System.Drawing.Color.AliceBlue;
            this.dgvVendas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idVendaDataGridViewTextBoxColumn,
            this.dataVendaDataGridViewTextBoxColumn,
            this.precoTotalDataGridViewTextBoxColumn,
            this.totalLivrosDataGridViewTextBoxColumn,
            this.nomeFuncionarioDataGridViewTextBoxColumn});
            this.dgvVendas.DataSource = this.vendaBindingSource;
            this.dgvVendas.Location = new System.Drawing.Point(23, 63);
            this.dgvVendas.Name = "dgvVendas";
            this.dgvVendas.ReadOnly = true;
            this.dgvVendas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVendas.Size = new System.Drawing.Size(693, 293);
            this.dgvVendas.TabIndex = 0;
            this.dgvVendas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVendas_CellDoubleClick);
            this.dgvVendas.MouseEnter += new System.EventHandler(this.dataGridView1_MouseEnter);
            this.dgvVendas.MouseLeave += new System.EventHandler(this.dataGridView1_MouseLeave);
            // 
            // idVendaDataGridViewTextBoxColumn
            // 
            this.idVendaDataGridViewTextBoxColumn.DataPropertyName = "IdVenda";
            this.idVendaDataGridViewTextBoxColumn.HeaderText = "ID Venda";
            this.idVendaDataGridViewTextBoxColumn.Name = "idVendaDataGridViewTextBoxColumn";
            this.idVendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataVendaDataGridViewTextBoxColumn
            // 
            this.dataVendaDataGridViewTextBoxColumn.DataPropertyName = "DataVenda";
            dataGridViewCellStyle1.Format = "G";
            dataGridViewCellStyle1.NullValue = null;
            this.dataVendaDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataVendaDataGridViewTextBoxColumn.HeaderText = "Data e Hora";
            this.dataVendaDataGridViewTextBoxColumn.Name = "dataVendaDataGridViewTextBoxColumn";
            this.dataVendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataVendaDataGridViewTextBoxColumn.Width = 150;
            // 
            // precoTotalDataGridViewTextBoxColumn
            // 
            this.precoTotalDataGridViewTextBoxColumn.DataPropertyName = "PrecoTotal";
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.precoTotalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.precoTotalDataGridViewTextBoxColumn.HeaderText = "Preço Total";
            this.precoTotalDataGridViewTextBoxColumn.Name = "precoTotalDataGridViewTextBoxColumn";
            this.precoTotalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalLivrosDataGridViewTextBoxColumn
            // 
            this.totalLivrosDataGridViewTextBoxColumn.DataPropertyName = "TotalLivros";
            this.totalLivrosDataGridViewTextBoxColumn.HeaderText = "Total de Livros";
            this.totalLivrosDataGridViewTextBoxColumn.Name = "totalLivrosDataGridViewTextBoxColumn";
            this.totalLivrosDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nomeFuncionarioDataGridViewTextBoxColumn
            // 
            this.nomeFuncionarioDataGridViewTextBoxColumn.DataPropertyName = "NomeFuncionario";
            this.nomeFuncionarioDataGridViewTextBoxColumn.HeaderText = "Nome do Funcionario";
            this.nomeFuncionarioDataGridViewTextBoxColumn.Name = "nomeFuncionarioDataGridViewTextBoxColumn";
            this.nomeFuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeFuncionarioDataGridViewTextBoxColumn.Width = 200;
            // 
            // vendaBindingSource
            // 
            this.vendaBindingSource.DataMember = "Venda";
            this.vendaBindingSource.DataSource = this.vendaDataSet3BindingSource;
            // 
            // vendaDataSet3BindingSource
            // 
            this.vendaDataSet3BindingSource.DataSource = this.vendaDataSet3;
            this.vendaDataSet3BindingSource.Position = 0;
            // 
            // vendaDataSet3
            // 
            this.vendaDataSet3.DataSetName = "VendaDataSet3";
            this.vendaDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vendaTableAdapter
            // 
            this.vendaTableAdapter.ClearBeforeFill = true;
            // 
            // picAtencao
            // 
            this.picAtencao.Image = global::Livraria.Properties.Resources.warning;
            this.picAtencao.Location = new System.Drawing.Point(23, 360);
            this.picAtencao.Name = "picAtencao";
            this.picAtencao.Size = new System.Drawing.Size(20, 19);
            this.picAtencao.TabIndex = 40;
            this.picAtencao.TabStop = false;
            this.picAtencao.Visible = false;
            // 
            // lblDica
            // 
            this.lblDica.AutoSize = true;
            this.lblDica.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDica.Location = new System.Drawing.Point(41, 359);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(351, 19);
            this.lblDica.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDica.TabIndex = 39;
            this.lblDica.Text = "Dê um duplo clique na venda que deseja alterar ou excluir.";
            this.lblDica.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDica.UseCustomForeColor = true;
            this.lblDica.UseStyleColors = true;
            this.lblDica.Visible = false;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(597, 372);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(119, 35);
            this.btnVoltar.TabIndex = 41;
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
            this.picLogoInicial.TabIndex = 42;
            this.picLogoInicial.TabStop = false;
            // 
            // FormConsultarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 411);
            this.Controls.Add(this.picLogoInicial);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.picAtencao);
            this.Controls.Add(this.lblDica);
            this.Controls.Add(this.dgvVendas);
            this.Name = "FormConsultarVenda";
            this.Resizable = false;
            this.Text = "      Consultar Vendas";
            this.Load += new System.EventHandler(this.FormConsultarVenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaDataSet3BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vendaDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAtencao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvVendas;
        private System.Windows.Forms.BindingSource vendaDataSet3BindingSource;
        private VendaDataSet3 vendaDataSet3;
        private System.Windows.Forms.BindingSource vendaBindingSource;
        private VendaDataSet3TableAdapters.VendaTableAdapter vendaTableAdapter;
        private System.Windows.Forms.PictureBox picAtencao;
        private MetroFramework.Controls.MetroLabel lblDica;
        private MetroFramework.Controls.MetroButton btnVoltar;
        private System.Windows.Forms.PictureBox picLogoInicial;
        private System.Windows.Forms.DataGridViewTextBoxColumn idVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataVendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precoTotalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalLivrosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeFuncionarioDataGridViewTextBoxColumn;
    }
}