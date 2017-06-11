namespace Livraria.View.Livros
{
    partial class FormEditarLivro
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
            this.txtDescricao = new MetroFramework.Controls.MetroTextBox();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.lstAutores = new System.Windows.Forms.ListBox();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.txtISBN = new System.Windows.Forms.TextBox();
            this.nudPaginas = new System.Windows.Forms.NumericUpDown();
            this.nudAno = new System.Windows.Forms.NumericUpDown();
            this.cboGenero = new MetroFramework.Controls.MetroComboBox();
            this.cboEditora = new MetroFramework.Controls.MetroComboBox();
            this.txtPreco = new MetroFramework.Controls.MetroTextBox();
            this.toolTip = new MetroFramework.Components.MetroToolTip();
            this.picLogoInicial = new System.Windows.Forms.PictureBox();
            this.groupBoxEditarLivro = new System.Windows.Forms.GroupBox();
            this.lblQuantidade = new MetroFramework.Controls.MetroLabel();
            this.lblPaginas = new MetroFramework.Controls.MetroLabel();
            this.lblPreco = new MetroFramework.Controls.MetroLabel();
            this.lblAno = new MetroFramework.Controls.MetroLabel();
            this.lblAutores = new MetroFramework.Controls.MetroLabel();
            this.lblNomeLivro = new MetroFramework.Controls.MetroLabel();
            this.lblGenero = new MetroFramework.Controls.MetroLabel();
            this.lblISBN = new MetroFramework.Controls.MetroLabel();
            this.lblEditora = new MetroFramework.Controls.MetroLabel();
            this.lblDescricao = new MetroFramework.Controls.MetroLabel();
            this.btnAtualizar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaginas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicial)).BeginInit();
            this.groupBoxEditarLivro.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDescricao
            // 
            // 
            // 
            // 
            this.txtDescricao.CustomButton.Image = null;
            this.txtDescricao.CustomButton.Location = new System.Drawing.Point(296, 1);
            this.txtDescricao.CustomButton.Name = "";
            this.txtDescricao.CustomButton.Size = new System.Drawing.Size(89, 89);
            this.txtDescricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescricao.CustomButton.TabIndex = 1;
            this.txtDescricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescricao.CustomButton.UseSelectable = true;
            this.txtDescricao.CustomButton.Visible = false;
            this.txtDescricao.Lines = new string[0];
            this.txtDescricao.Location = new System.Drawing.Point(151, 135);
            this.txtDescricao.MaxLength = 32767;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PasswordChar = '\0';
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricao.SelectedText = "";
            this.txtDescricao.SelectionLength = 0;
            this.txtDescricao.SelectionStart = 0;
            this.txtDescricao.ShortcutsEnabled = true;
            this.txtDescricao.Size = new System.Drawing.Size(386, 91);
            this.txtDescricao.TabIndex = 56;
            this.txtDescricao.UseSelectable = true;
            this.txtDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescricao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(364, 1);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(151, 92);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(386, 23);
            this.txtNome.TabIndex = 55;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lstAutores
            // 
            this.lstAutores.FormattingEnabled = true;
            this.lstAutores.Location = new System.Drawing.Point(128, 307);
            this.lstAutores.Name = "lstAutores";
            this.lstAutores.Size = new System.Drawing.Size(169, 56);
            this.lstAutores.TabIndex = 52;
            this.toolTip.SetToolTip(this.lstAutores, "Clique duas vezes para selecionar os autores!");
            this.lstAutores.DoubleClick += new System.EventHandler(this.lstAutores_DoubleClick);
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantidade.Location = new System.Drawing.Point(419, 302);
            this.nudQuantidade.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(95, 24);
            this.nudQuantidade.TabIndex = 46;
            // 
            // txtISBN
            // 
            this.txtISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtISBN.Location = new System.Drawing.Point(128, 179);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.Size = new System.Drawing.Size(169, 24);
            this.txtISBN.TabIndex = 44;
            // 
            // nudPaginas
            // 
            this.nudPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPaginas.Location = new System.Drawing.Point(419, 262);
            this.nudPaginas.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudPaginas.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudPaginas.Name = "nudPaginas";
            this.nudPaginas.Size = new System.Drawing.Size(95, 24);
            this.nudPaginas.TabIndex = 40;
            this.nudPaginas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudAno
            // 
            this.nudAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAno.Location = new System.Drawing.Point(419, 179);
            this.nudAno.Maximum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.nudAno.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.nudAno.Name = "nudAno";
            this.nudAno.Size = new System.Drawing.Size(95, 24);
            this.nudAno.TabIndex = 38;
            this.nudAno.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownHeight = 85;
            this.cboGenero.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.IntegralHeight = false;
            this.cboGenero.ItemHeight = 19;
            this.cboGenero.Location = new System.Drawing.Point(128, 265);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(169, 25);
            this.cboGenero.TabIndex = 59;
            this.cboGenero.UseSelectable = true;
            // 
            // cboEditora
            // 
            this.cboEditora.DropDownHeight = 85;
            this.cboEditora.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cboEditora.FormattingEnabled = true;
            this.cboEditora.IntegralHeight = false;
            this.cboEditora.ItemHeight = 19;
            this.cboEditora.Location = new System.Drawing.Point(128, 221);
            this.cboEditora.Name = "cboEditora";
            this.cboEditora.Size = new System.Drawing.Size(169, 25);
            this.cboEditora.TabIndex = 58;
            this.cboEditora.UseSelectable = true;
            // 
            // txtPreco
            // 
            // 
            // 
            // 
            this.txtPreco.CustomButton.Image = null;
            this.txtPreco.CustomButton.Location = new System.Drawing.Point(73, 1);
            this.txtPreco.CustomButton.Name = "";
            this.txtPreco.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPreco.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPreco.CustomButton.TabIndex = 1;
            this.txtPreco.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPreco.CustomButton.UseSelectable = true;
            this.txtPreco.CustomButton.Visible = false;
            this.txtPreco.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtPreco.Lines = new string[] {
        "0,00"};
            this.txtPreco.Location = new System.Drawing.Point(419, 219);
            this.txtPreco.MaxLength = 32767;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.PasswordChar = '\0';
            this.txtPreco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPreco.SelectedText = "";
            this.txtPreco.SelectionLength = 0;
            this.txtPreco.SelectionStart = 0;
            this.txtPreco.ShortcutsEnabled = true;
            this.txtPreco.Size = new System.Drawing.Size(95, 23);
            this.txtPreco.TabIndex = 60;
            this.txtPreco.Text = "0,00";
            this.txtPreco.UseSelectable = true;
            this.txtPreco.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPreco.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // toolTip
            // 
            this.toolTip.AutomaticDelay = 120;
            this.toolTip.AutoPopDelay = 4000;
            this.toolTip.InitialDelay = 120;
            this.toolTip.ReshowDelay = 24;
            this.toolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.toolTip.StyleManager = null;
            this.toolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // picLogoInicial
            // 
            this.picLogoInicial.BackColor = System.Drawing.Color.Transparent;
            this.picLogoInicial.Image = global::Livraria.Properties.Resources.logo;
            this.picLogoInicial.Location = new System.Drawing.Point(23, 21);
            this.picLogoInicial.Name = "picLogoInicial";
            this.picLogoInicial.Size = new System.Drawing.Size(38, 33);
            this.picLogoInicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoInicial.TabIndex = 61;
            this.picLogoInicial.TabStop = false;
            // 
            // groupBoxEditarLivro
            // 
            this.groupBoxEditarLivro.Controls.Add(this.lblQuantidade);
            this.groupBoxEditarLivro.Controls.Add(this.lblPaginas);
            this.groupBoxEditarLivro.Controls.Add(this.lblPreco);
            this.groupBoxEditarLivro.Controls.Add(this.lblAno);
            this.groupBoxEditarLivro.Controls.Add(this.txtPreco);
            this.groupBoxEditarLivro.Controls.Add(this.lblAutores);
            this.groupBoxEditarLivro.Controls.Add(this.lblNomeLivro);
            this.groupBoxEditarLivro.Controls.Add(this.nudQuantidade);
            this.groupBoxEditarLivro.Controls.Add(this.cboGenero);
            this.groupBoxEditarLivro.Controls.Add(this.nudPaginas);
            this.groupBoxEditarLivro.Controls.Add(this.lblGenero);
            this.groupBoxEditarLivro.Controls.Add(this.nudAno);
            this.groupBoxEditarLivro.Controls.Add(this.cboEditora);
            this.groupBoxEditarLivro.Controls.Add(this.lblISBN);
            this.groupBoxEditarLivro.Controls.Add(this.lstAutores);
            this.groupBoxEditarLivro.Controls.Add(this.lblEditora);
            this.groupBoxEditarLivro.Controls.Add(this.lblDescricao);
            this.groupBoxEditarLivro.Controls.Add(this.txtISBN);
            this.groupBoxEditarLivro.Location = new System.Drawing.Point(23, 64);
            this.groupBoxEditarLivro.Name = "groupBoxEditarLivro";
            this.groupBoxEditarLivro.Size = new System.Drawing.Size(544, 384);
            this.groupBoxEditarLivro.TabIndex = 62;
            this.groupBoxEditarLivro.TabStop = false;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblQuantidade.Location = new System.Drawing.Point(329, 303);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(76, 25);
            this.lblQuantidade.TabIndex = 71;
            this.lblQuantidade.Text = "Estoque:";
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPaginas.Location = new System.Drawing.Point(329, 263);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(74, 25);
            this.lblPaginas.TabIndex = 70;
            this.lblPaginas.Text = "Páginas:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPreco.Location = new System.Drawing.Point(329, 219);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(83, 25);
            this.lblPreco.TabIndex = 69;
            this.lblPreco.Text = "Preço: R$";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAno.Location = new System.Drawing.Point(355, 178);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(47, 25);
            this.lblAno.TabIndex = 68;
            this.lblAno.Text = "Ano:";
            // 
            // lblAutores
            // 
            this.lblAutores.AutoSize = true;
            this.lblAutores.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAutores.Location = new System.Drawing.Point(33, 302);
            this.lblAutores.Name = "lblAutores";
            this.lblAutores.Size = new System.Drawing.Size(74, 25);
            this.lblAutores.TabIndex = 67;
            this.lblAutores.Text = "Autores:";
            // 
            // lblNomeLivro
            // 
            this.lblNomeLivro.AutoSize = true;
            this.lblNomeLivro.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNomeLivro.Location = new System.Drawing.Point(44, 26);
            this.lblNomeLivro.Name = "lblNomeLivro";
            this.lblNomeLivro.Size = new System.Drawing.Size(63, 25);
            this.lblNomeLivro.TabIndex = 63;
            this.lblNomeLivro.Text = "Nome:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblGenero.Location = new System.Drawing.Point(35, 265);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(72, 25);
            this.lblGenero.TabIndex = 66;
            this.lblGenero.Text = "Gênero:";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblISBN.Location = new System.Drawing.Point(55, 179);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(52, 25);
            this.lblISBN.TabIndex = 64;
            this.lblISBN.Text = "ISBN:";
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEditora.Location = new System.Drawing.Point(38, 221);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(69, 25);
            this.lblEditora.TabIndex = 65;
            this.lblEditora.Text = "Editora:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDescricao.Location = new System.Drawing.Point(18, 66);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(89, 25);
            this.lblDescricao.TabIndex = 63;
            this.lblDescricao.Text = "Descrição:";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(443, 454);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(124, 35);
            this.btnAtualizar.TabIndex = 63;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseSelectable = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(311, 454);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 35);
            this.btnCancelar.TabIndex = 64;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(23, 454);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(124, 35);
            this.btnExcluir.TabIndex = 65;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseSelectable = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // FormEditarLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 503);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.picLogoInicial);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.groupBoxEditarLivro);
            this.MaximizeBox = false;
            this.Name = "FormEditarLivro";
            this.Resizable = false;
            this.Text = "        Editar Livro";
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaginas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicial)).EndInit();
            this.groupBoxEditarLivro.ResumeLayout(false);
            this.groupBoxEditarLivro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txtDescricao;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private System.Windows.Forms.ListBox lstAutores;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.TextBox txtISBN;
        private System.Windows.Forms.NumericUpDown nudPaginas;
        private System.Windows.Forms.NumericUpDown nudAno;
        private MetroFramework.Controls.MetroComboBox cboGenero;
        private MetroFramework.Controls.MetroComboBox cboEditora;
        private MetroFramework.Controls.MetroTextBox txtPreco;
        private MetroFramework.Components.MetroToolTip toolTip;
        private System.Windows.Forms.PictureBox picLogoInicial;
        private System.Windows.Forms.GroupBox groupBoxEditarLivro;
        private MetroFramework.Controls.MetroLabel lblNomeLivro;
        private MetroFramework.Controls.MetroLabel lblAutores;
        private MetroFramework.Controls.MetroLabel lblGenero;
        private MetroFramework.Controls.MetroLabel lblISBN;
        private MetroFramework.Controls.MetroLabel lblEditora;
        private MetroFramework.Controls.MetroLabel lblDescricao;
        private MetroFramework.Controls.MetroLabel lblQuantidade;
        private MetroFramework.Controls.MetroLabel lblPaginas;
        private MetroFramework.Controls.MetroLabel lblPreco;
        private MetroFramework.Controls.MetroLabel lblAno;
        private MetroFramework.Controls.MetroButton btnAtualizar;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnExcluir;
    }
}