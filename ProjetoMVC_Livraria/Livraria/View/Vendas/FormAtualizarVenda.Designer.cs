namespace Livraria.View.Vendas
{
    partial class FormAtualizarVenda
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtFuncionario = new MetroFramework.Controls.MetroTextBox();
            this.picAtencao = new System.Windows.Forms.PictureBox();
            this.lblDica = new MetroFramework.Controls.MetroLabel();
            this.btnSelecionarLivros = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnAtualizar = new MetroFramework.Controls.MetroButton();
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.IdLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTotalLivros = new MetroFramework.Controls.MetroTextBox();
            this.lblTotalLivros = new MetroFramework.Controls.MetroLabel();
            this.txtPrecoTotal = new MetroFramework.Controls.MetroTextBox();
            this.lblPrecoTotal = new MetroFramework.Controls.MetroLabel();
            this.lblFuncionario = new MetroFramework.Controls.MetroLabel();
            this.picLogoInicial = new System.Windows.Forms.PictureBox();
            this.btnExcluirVenda = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.picAtencao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFuncionario
            // 
            // 
            // 
            // 
            this.txtFuncionario.CustomButton.Image = null;
            this.txtFuncionario.CustomButton.Location = new System.Drawing.Point(304, 1);
            this.txtFuncionario.CustomButton.Name = "";
            this.txtFuncionario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFuncionario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFuncionario.CustomButton.TabIndex = 1;
            this.txtFuncionario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFuncionario.CustomButton.UseSelectable = true;
            this.txtFuncionario.CustomButton.Visible = false;
            this.txtFuncionario.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtFuncionario.Lines = new string[0];
            this.txtFuncionario.Location = new System.Drawing.Point(156, 267);
            this.txtFuncionario.MaxLength = 32767;
            this.txtFuncionario.Name = "txtFuncionario";
            this.txtFuncionario.PasswordChar = '\0';
            this.txtFuncionario.ReadOnly = true;
            this.txtFuncionario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFuncionario.SelectedText = "";
            this.txtFuncionario.SelectionLength = 0;
            this.txtFuncionario.SelectionStart = 0;
            this.txtFuncionario.ShortcutsEnabled = true;
            this.txtFuncionario.Size = new System.Drawing.Size(326, 23);
            this.txtFuncionario.TabIndex = 51;
            this.txtFuncionario.UseSelectable = true;
            this.txtFuncionario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFuncionario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // picAtencao
            // 
            this.picAtencao.Image = global::Livraria.Properties.Resources.warning;
            this.picAtencao.Location = new System.Drawing.Point(26, 228);
            this.picAtencao.Name = "picAtencao";
            this.picAtencao.Size = new System.Drawing.Size(20, 19);
            this.picAtencao.TabIndex = 50;
            this.picAtencao.TabStop = false;
            // 
            // lblDica
            // 
            this.lblDica.AutoSize = true;
            this.lblDica.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDica.Location = new System.Drawing.Point(42, 227);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(292, 19);
            this.lblDica.Style = MetroFramework.MetroColorStyle.Blue;
            this.lblDica.TabIndex = 49;
            this.lblDica.Text = "Clique no número da quantidade para alterá-la!";
            this.lblDica.Theme = MetroFramework.MetroThemeStyle.Light;
            this.lblDica.UseCustomForeColor = true;
            this.lblDica.UseStyleColors = true;
            // 
            // btnSelecionarLivros
            // 
            this.btnSelecionarLivros.Location = new System.Drawing.Point(618, 230);
            this.btnSelecionarLivros.Name = "btnSelecionarLivros";
            this.btnSelecionarLivros.Size = new System.Drawing.Size(97, 23);
            this.btnSelecionarLivros.TabIndex = 48;
            this.btnSelecionarLivros.Text = "Selecionar livros";
            this.btnSelecionarLivros.UseSelectable = true;
            this.btnSelecionarLivros.Click += new System.EventHandler(this.btnSelecionarLivros_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCancelar.Location = new System.Drawing.Point(470, 358);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 28);
            this.btnCancelar.TabIndex = 47;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAtualizar.Location = new System.Drawing.Point(610, 358);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(106, 28);
            this.btnAtualizar.TabIndex = 46;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseSelectable = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // dgvLivros
            // 
            this.dgvLivros.AllowUserToAddRows = false;
            this.dgvLivros.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLivros.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdLivro,
            this.NomeLivro,
            this.Preco,
            this.Estoque,
            this.Quantidade});
            this.dgvLivros.Location = new System.Drawing.Point(23, 74);
            this.dgvLivros.Name = "dgvLivros";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvLivros.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivros.Size = new System.Drawing.Size(693, 150);
            this.dgvLivros.TabIndex = 45;
            this.dgvLivros.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLivros_CellValueChanged);
            this.dgvLivros.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvLivros_RowsAdded);
            this.dgvLivros.MouseEnter += new System.EventHandler(this.dataGridView1_MouseEnter);
            this.dgvLivros.MouseLeave += new System.EventHandler(this.dataGridView1_MouseLeave);
            // 
            // IdLivro
            // 
            this.IdLivro.HeaderText = "ID Livro";
            this.IdLivro.Name = "IdLivro";
            this.IdLivro.ReadOnly = true;
            this.IdLivro.Width = 70;
            // 
            // NomeLivro
            // 
            this.NomeLivro.HeaderText = "Nome do Livro";
            this.NomeLivro.Name = "NomeLivro";
            this.NomeLivro.ReadOnly = true;
            this.NomeLivro.Width = 320;
            // 
            // Preco
            // 
            dataGridViewCellStyle2.Format = "C2";
            dataGridViewCellStyle2.NullValue = null;
            this.Preco.DefaultCellStyle = dataGridViewCellStyle2;
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            // 
            // Estoque
            // 
            this.Estoque.HeaderText = "Estoque";
            this.Estoque.Name = "Estoque";
            this.Estoque.ReadOnly = true;
            this.Estoque.Width = 80;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            this.Quantidade.Width = 80;
            // 
            // txtTotalLivros
            // 
            // 
            // 
            // 
            this.txtTotalLivros.CustomButton.Image = null;
            this.txtTotalLivros.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.txtTotalLivros.CustomButton.Name = "";
            this.txtTotalLivros.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtTotalLivros.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtTotalLivros.CustomButton.TabIndex = 1;
            this.txtTotalLivros.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtTotalLivros.CustomButton.UseSelectable = true;
            this.txtTotalLivros.CustomButton.Visible = false;
            this.txtTotalLivros.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtTotalLivros.Lines = new string[] {
        "0"};
            this.txtTotalLivros.Location = new System.Drawing.Point(156, 310);
            this.txtTotalLivros.MaxLength = 32767;
            this.txtTotalLivros.Name = "txtTotalLivros";
            this.txtTotalLivros.PasswordChar = '\0';
            this.txtTotalLivros.ReadOnly = true;
            this.txtTotalLivros.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtTotalLivros.SelectedText = "";
            this.txtTotalLivros.SelectionLength = 0;
            this.txtTotalLivros.SelectionStart = 0;
            this.txtTotalLivros.ShortcutsEnabled = true;
            this.txtTotalLivros.Size = new System.Drawing.Size(94, 23);
            this.txtTotalLivros.TabIndex = 44;
            this.txtTotalLivros.Text = "0";
            this.txtTotalLivros.UseSelectable = true;
            this.txtTotalLivros.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtTotalLivros.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblTotalLivros
            // 
            this.lblTotalLivros.AutoSize = true;
            this.lblTotalLivros.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTotalLivros.Location = new System.Drawing.Point(32, 309);
            this.lblTotalLivros.Name = "lblTotalLivros";
            this.lblTotalLivros.Size = new System.Drawing.Size(118, 25);
            this.lblTotalLivros.TabIndex = 43;
            this.lblTotalLivros.Text = "Total de livros:";
            // 
            // txtPrecoTotal
            // 
            // 
            // 
            // 
            this.txtPrecoTotal.CustomButton.Image = null;
            this.txtPrecoTotal.CustomButton.Location = new System.Drawing.Point(72, 1);
            this.txtPrecoTotal.CustomButton.Name = "";
            this.txtPrecoTotal.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPrecoTotal.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPrecoTotal.CustomButton.TabIndex = 1;
            this.txtPrecoTotal.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPrecoTotal.CustomButton.UseSelectable = true;
            this.txtPrecoTotal.CustomButton.Visible = false;
            this.txtPrecoTotal.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPrecoTotal.Lines = new string[] {
        "R$0,00"};
            this.txtPrecoTotal.Location = new System.Drawing.Point(388, 310);
            this.txtPrecoTotal.MaxLength = 32767;
            this.txtPrecoTotal.Name = "txtPrecoTotal";
            this.txtPrecoTotal.PasswordChar = '\0';
            this.txtPrecoTotal.ReadOnly = true;
            this.txtPrecoTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecoTotal.SelectedText = "";
            this.txtPrecoTotal.SelectionLength = 0;
            this.txtPrecoTotal.SelectionStart = 0;
            this.txtPrecoTotal.ShortcutsEnabled = true;
            this.txtPrecoTotal.Size = new System.Drawing.Size(94, 23);
            this.txtPrecoTotal.TabIndex = 42;
            this.txtPrecoTotal.Text = "R$0,00";
            this.txtPrecoTotal.UseSelectable = true;
            this.txtPrecoTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecoTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblPrecoTotal
            // 
            this.lblPrecoTotal.AutoSize = true;
            this.lblPrecoTotal.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPrecoTotal.Location = new System.Drawing.Point(285, 308);
            this.lblPrecoTotal.Name = "lblPrecoTotal";
            this.lblPrecoTotal.Size = new System.Drawing.Size(97, 25);
            this.lblPrecoTotal.TabIndex = 41;
            this.lblPrecoTotal.Text = "Preço total:";
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblFuncionario.Location = new System.Drawing.Point(32, 266);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(105, 25);
            this.lblFuncionario.TabIndex = 40;
            this.lblFuncionario.Text = "Funcionário:";
            // 
            // picLogoInicial
            // 
            this.picLogoInicial.BackColor = System.Drawing.Color.Transparent;
            this.picLogoInicial.Image = global::Livraria.Properties.Resources.logo;
            this.picLogoInicial.Location = new System.Drawing.Point(23, 23);
            this.picLogoInicial.Name = "picLogoInicial";
            this.picLogoInicial.Size = new System.Drawing.Size(38, 33);
            this.picLogoInicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoInicial.TabIndex = 52;
            this.picLogoInicial.TabStop = false;
            // 
            // btnExcluirVenda
            // 
            this.btnExcluirVenda.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnExcluirVenda.Location = new System.Drawing.Point(32, 358);
            this.btnExcluirVenda.Name = "btnExcluirVenda";
            this.btnExcluirVenda.Size = new System.Drawing.Size(106, 28);
            this.btnExcluirVenda.TabIndex = 53;
            this.btnExcluirVenda.Text = "Excluir venda";
            this.btnExcluirVenda.UseSelectable = true;
            this.btnExcluirVenda.Click += new System.EventHandler(this.btnExcluirVenda_Click);
            // 
            // FormAtualizarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 401);
            this.Controls.Add(this.btnExcluirVenda);
            this.Controls.Add(this.picLogoInicial);
            this.Controls.Add(this.txtFuncionario);
            this.Controls.Add(this.picAtencao);
            this.Controls.Add(this.lblDica);
            this.Controls.Add(this.btnSelecionarLivros);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dgvLivros);
            this.Controls.Add(this.txtTotalLivros);
            this.Controls.Add(this.lblTotalLivros);
            this.Controls.Add(this.txtPrecoTotal);
            this.Controls.Add(this.lblPrecoTotal);
            this.Controls.Add(this.lblFuncionario);
            this.Name = "FormAtualizarVenda";
            this.Resizable = false;
            this.Text = "      Atualizar Venda";
            ((System.ComponentModel.ISupportInitialize)(this.picAtencao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtFuncionario;
        private System.Windows.Forms.PictureBox picAtencao;
        private MetroFramework.Controls.MetroLabel lblDica;
        private MetroFramework.Controls.MetroButton btnSelecionarLivros;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnAtualizar;
        private System.Windows.Forms.DataGridView dgvLivros;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private MetroFramework.Controls.MetroTextBox txtTotalLivros;
        private MetroFramework.Controls.MetroLabel lblTotalLivros;
        private MetroFramework.Controls.MetroTextBox txtPrecoTotal;
        private MetroFramework.Controls.MetroLabel lblPrecoTotal;
        private MetroFramework.Controls.MetroLabel lblFuncionario;
        private System.Windows.Forms.PictureBox picLogoInicial;
        private MetroFramework.Controls.MetroButton btnExcluirVenda;
    }
}