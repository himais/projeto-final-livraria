namespace Livraria.View.Vendas
{
    partial class FormCadastrarVenda
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
            this.lblFuncionario = new MetroFramework.Controls.MetroLabel();
            this.cboFuncionario = new MetroFramework.Controls.MetroComboBox();
            this.lblPrecoTotal = new MetroFramework.Controls.MetroLabel();
            this.txtPrecoTotal = new MetroFramework.Controls.MetroTextBox();
            this.lblTotalLivros = new MetroFramework.Controls.MetroLabel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.dgvLivros = new System.Windows.Forms.DataGridView();
            this.NomeLivro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Preco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblDica = new MetroFramework.Controls.MetroLabel();
            this.btnRegistrar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFuncionario
            // 
            this.lblFuncionario.AutoSize = true;
            this.lblFuncionario.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblFuncionario.Location = new System.Drawing.Point(56, 340);
            this.lblFuncionario.Name = "lblFuncionario";
            this.lblFuncionario.Size = new System.Drawing.Size(105, 25);
            this.lblFuncionario.TabIndex = 0;
            this.lblFuncionario.Text = "Funcionário:";
            // 
            // cboFuncionario
            // 
            this.cboFuncionario.DropDownHeight = 85;
            this.cboFuncionario.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cboFuncionario.FormattingEnabled = true;
            this.cboFuncionario.IntegralHeight = false;
            this.cboFuncionario.ItemHeight = 19;
            this.cboFuncionario.Location = new System.Drawing.Point(180, 340);
            this.cboFuncionario.Name = "cboFuncionario";
            this.cboFuncionario.Size = new System.Drawing.Size(165, 25);
            this.cboFuncionario.TabIndex = 1;
            this.cboFuncionario.UseSelectable = true;
            // 
            // lblPrecoTotal
            // 
            this.lblPrecoTotal.AutoSize = true;
            this.lblPrecoTotal.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPrecoTotal.Location = new System.Drawing.Point(56, 295);
            this.lblPrecoTotal.Name = "lblPrecoTotal";
            this.lblPrecoTotal.Size = new System.Drawing.Size(97, 25);
            this.lblPrecoTotal.TabIndex = 2;
            this.lblPrecoTotal.Text = "Preço total:";
            // 
            // txtPrecoTotal
            // 
            // 
            // 
            // 
            this.txtPrecoTotal.CustomButton.Image = null;
            this.txtPrecoTotal.CustomButton.Location = new System.Drawing.Point(53, 1);
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
            this.txtPrecoTotal.Location = new System.Drawing.Point(180, 296);
            this.txtPrecoTotal.MaxLength = 32767;
            this.txtPrecoTotal.Name = "txtPrecoTotal";
            this.txtPrecoTotal.PasswordChar = '\0';
            this.txtPrecoTotal.ReadOnly = true;
            this.txtPrecoTotal.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPrecoTotal.SelectedText = "";
            this.txtPrecoTotal.SelectionLength = 0;
            this.txtPrecoTotal.SelectionStart = 0;
            this.txtPrecoTotal.ShortcutsEnabled = true;
            this.txtPrecoTotal.Size = new System.Drawing.Size(75, 23);
            this.txtPrecoTotal.TabIndex = 3;
            this.txtPrecoTotal.Text = "R$0,00";
            this.txtPrecoTotal.UseSelectable = true;
            this.txtPrecoTotal.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPrecoTotal.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lblTotalLivros
            // 
            this.lblTotalLivros.AutoSize = true;
            this.lblTotalLivros.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblTotalLivros.Location = new System.Drawing.Point(56, 250);
            this.lblTotalLivros.Name = "lblTotalLivros";
            this.lblTotalLivros.Size = new System.Drawing.Size(118, 25);
            this.lblTotalLivros.TabIndex = 4;
            this.lblTotalLivros.Text = "Total de livros:";
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(53, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.metroTextBox1.Lines = new string[] {
        "0"};
            this.metroTextBox1.Location = new System.Drawing.Point(180, 251);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.ReadOnly = true;
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(75, 23);
            this.metroTextBox1.TabIndex = 5;
            this.metroTextBox1.Text = "0";
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // dgvLivros
            // 
            this.dgvLivros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLivros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeLivro,
            this.Preco,
            this.Quantidade});
            this.dgvLivros.Location = new System.Drawing.Point(24, 63);
            this.dgvLivros.Name = "dgvLivros";
            this.dgvLivros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLivros.Size = new System.Drawing.Size(563, 150);
            this.dgvLivros.TabIndex = 6;
            this.dgvLivros.DoubleClick += new System.EventHandler(this.dgvLivros_DoubleClick);
            this.dgvLivros.MouseEnter += new System.EventHandler(this.dataGridView1_MouseEnter);
            this.dgvLivros.MouseLeave += new System.EventHandler(this.dataGridView1_MouseLeave);
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
            this.Preco.HeaderText = "Preço";
            this.Preco.Name = "Preco";
            this.Preco.ReadOnly = true;
            // 
            // Quantidade
            // 
            this.Quantidade.HeaderText = "Quantidade";
            this.Quantidade.Name = "Quantidade";
            // 
            // lblDica
            // 
            this.lblDica.AutoSize = true;
            this.lblDica.ForeColor = System.Drawing.Color.Red;
            this.lblDica.Location = new System.Drawing.Point(24, 216);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(456, 19);
            this.lblDica.TabIndex = 7;
            this.lblDica.Text = "Clique duas vezes para adicionar livros e clique na quantidade para edità-la!";
            this.lblDica.UseCustomForeColor = true;
            this.lblDica.Visible = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnRegistrar.Location = new System.Drawing.Point(481, 389);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(106, 28);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseSelectable = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCancelar.Location = new System.Drawing.Point(352, 389);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(106, 28);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormCadastrarVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 431);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lblDica);
            this.Controls.Add(this.dgvLivros);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.lblTotalLivros);
            this.Controls.Add(this.txtPrecoTotal);
            this.Controls.Add(this.lblPrecoTotal);
            this.Controls.Add(this.cboFuncionario);
            this.Controls.Add(this.lblFuncionario);
            this.Name = "FormCadastrarVenda";
            this.Resizable = false;
            this.Text = "        Cadastrar Venda";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLivros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblFuncionario;
        private MetroFramework.Controls.MetroComboBox cboFuncionario;
        private MetroFramework.Controls.MetroLabel lblPrecoTotal;
        private MetroFramework.Controls.MetroTextBox txtPrecoTotal;
        private MetroFramework.Controls.MetroLabel lblTotalLivros;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.DataGridView dgvLivros;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeLivro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Preco;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantidade;
        private MetroFramework.Controls.MetroLabel lblDica;
        private MetroFramework.Controls.MetroButton btnRegistrar;
        private MetroFramework.Controls.MetroButton btnCancelar;
    }
}