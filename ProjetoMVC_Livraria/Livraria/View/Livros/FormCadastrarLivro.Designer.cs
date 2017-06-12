namespace Livraria.View.Livros
{
    partial class FormCadastrarLivro
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
            this.nudAno = new System.Windows.Forms.NumericUpDown();
            this.nudPaginas = new System.Windows.Forms.NumericUpDown();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lstAutores = new System.Windows.Forms.ListBox();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.txtDescricao = new MetroFramework.Controls.MetroTextBox();
            this.generoDataSet = new Livraria.GeneroDataSet();
            this.generoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboEditora = new MetroFramework.Controls.MetroComboBox();
            this.cboGenero = new MetroFramework.Controls.MetroComboBox();
            this.txtISBN = new MetroFramework.Controls.MetroTextBox();
            this.txtPreco = new MetroFramework.Controls.MetroTextBox();
            this.toolTip = new MetroFramework.Components.MetroToolTip();
            this.picLogoInicial = new System.Windows.Forms.PictureBox();
            this.groupBoxCadastrarLivro = new System.Windows.Forms.GroupBox();
            this.lblQuantidade = new MetroFramework.Controls.MetroLabel();
            this.lblPaginas = new MetroFramework.Controls.MetroLabel();
            this.lblPreco = new MetroFramework.Controls.MetroLabel();
            this.lblAno = new MetroFramework.Controls.MetroLabel();
            this.lblAutores = new MetroFramework.Controls.MetroLabel();
            this.lblGenero = new MetroFramework.Controls.MetroLabel();
            this.lblEditora = new MetroFramework.Controls.MetroLabel();
            this.lblISBN = new MetroFramework.Controls.MetroLabel();
            this.lblDescricao = new MetroFramework.Controls.MetroLabel();
            this.lblNomeLivro = new MetroFramework.Controls.MetroLabel();
            this.btnCadastrar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaginas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicial)).BeginInit();
            this.groupBoxCadastrarLivro.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudAno
            // 
            this.nudAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAno.Location = new System.Drawing.Point(417, 183);
            this.nudAno.Maximum = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            this.nudAno.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudAno.Name = "nudAno";
            this.nudAno.Size = new System.Drawing.Size(89, 24);
            this.nudAno.TabIndex = 15;
            this.nudAno.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // nudPaginas
            // 
            this.nudPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPaginas.Location = new System.Drawing.Point(440, 341);
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
            this.nudPaginas.Size = new System.Drawing.Size(89, 24);
            this.nudPaginas.TabIndex = 17;
            this.nudPaginas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantidade.Location = new System.Drawing.Point(440, 381);
            this.nudQuantidade.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(89, 24);
            this.nudQuantidade.TabIndex = 23;
            // 
            // lstAutores
            // 
            this.lstAutores.FormattingEnabled = true;
            this.lstAutores.Location = new System.Drawing.Point(120, 309);
            this.lstAutores.Name = "lstAutores";
            this.lstAutores.Size = new System.Drawing.Size(169, 43);
            this.lstAutores.TabIndex = 30;
            this.toolTip.SetToolTip(this.lstAutores, "Clique duas vezes para selecionar os autores!");
            this.lstAutores.DoubleClick += new System.EventHandler(this.lstAutores_DoubleClick);
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
            this.txtNome.Location = new System.Drawing.Point(143, 102);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(386, 23);
            this.txtNome.TabIndex = 33;
            this.txtNome.UseSelectable = true;
            this.txtNome.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNome.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
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
            this.txtDescricao.Location = new System.Drawing.Point(143, 145);
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
            this.txtDescricao.TabIndex = 34;
            this.txtDescricao.UseSelectable = true;
            this.txtDescricao.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtDescricao.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // generoDataSet
            // 
            this.generoDataSet.DataSetName = "GeneroDataSet";
            this.generoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // generoDataSetBindingSource
            // 
            this.generoDataSetBindingSource.DataSource = this.generoDataSet;
            this.generoDataSetBindingSource.Position = 0;
            // 
            // cboEditora
            // 
            this.cboEditora.DropDownHeight = 85;
            this.cboEditora.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cboEditora.FormattingEnabled = true;
            this.cboEditora.IntegralHeight = false;
            this.cboEditora.ItemHeight = 19;
            this.cboEditora.Location = new System.Drawing.Point(143, 300);
            this.cboEditora.Name = "cboEditora";
            this.cboEditora.Size = new System.Drawing.Size(169, 25);
            this.cboEditora.TabIndex = 35;
            this.cboEditora.UseSelectable = true;
            // 
            // cboGenero
            // 
            this.cboGenero.DropDownHeight = 85;
            this.cboGenero.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.cboGenero.FormattingEnabled = true;
            this.cboGenero.IntegralHeight = false;
            this.cboGenero.ItemHeight = 19;
            this.cboGenero.Location = new System.Drawing.Point(143, 344);
            this.cboGenero.Name = "cboGenero";
            this.cboGenero.Size = new System.Drawing.Size(169, 25);
            this.cboGenero.TabIndex = 36;
            this.cboGenero.UseSelectable = true;
            // 
            // txtISBN
            // 
            // 
            // 
            // 
            this.txtISBN.CustomButton.Image = null;
            this.txtISBN.CustomButton.Location = new System.Drawing.Point(147, 1);
            this.txtISBN.CustomButton.Name = "";
            this.txtISBN.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtISBN.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtISBN.CustomButton.TabIndex = 1;
            this.txtISBN.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtISBN.CustomButton.UseSelectable = true;
            this.txtISBN.CustomButton.Visible = false;
            this.txtISBN.Lines = new string[0];
            this.txtISBN.Location = new System.Drawing.Point(143, 258);
            this.txtISBN.MaxLength = 32767;
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.PasswordChar = '\0';
            this.txtISBN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtISBN.SelectedText = "";
            this.txtISBN.SelectionLength = 0;
            this.txtISBN.SelectionStart = 0;
            this.txtISBN.ShortcutsEnabled = true;
            this.txtISBN.Size = new System.Drawing.Size(169, 23);
            this.txtISBN.TabIndex = 37;
            this.txtISBN.UseSelectable = true;
            this.txtISBN.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtISBN.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtPreco
            // 
            // 
            // 
            // 
            this.txtPreco.CustomButton.Image = null;
            this.txtPreco.CustomButton.Location = new System.Drawing.Point(67, 1);
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
            this.txtPreco.Location = new System.Drawing.Point(440, 298);
            this.txtPreco.MaxLength = 32767;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.PasswordChar = '\0';
            this.txtPreco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPreco.SelectedText = "";
            this.txtPreco.SelectionLength = 0;
            this.txtPreco.SelectionStart = 0;
            this.txtPreco.ShortcutsEnabled = true;
            this.txtPreco.Size = new System.Drawing.Size(89, 23);
            this.txtPreco.TabIndex = 38;
            this.txtPreco.Text = "0,00";
            this.txtPreco.UseSelectable = true;
            this.txtPreco.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPreco.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPreco.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPreco_KeyPress);
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
            this.picLogoInicial.TabIndex = 39;
            this.picLogoInicial.TabStop = false;
            // 
            // groupBoxCadastrarLivro
            // 
            this.groupBoxCadastrarLivro.Controls.Add(this.lblQuantidade);
            this.groupBoxCadastrarLivro.Controls.Add(this.lblPaginas);
            this.groupBoxCadastrarLivro.Controls.Add(this.lblPreco);
            this.groupBoxCadastrarLivro.Controls.Add(this.lblAno);
            this.groupBoxCadastrarLivro.Controls.Add(this.lblAutores);
            this.groupBoxCadastrarLivro.Controls.Add(this.lblGenero);
            this.groupBoxCadastrarLivro.Controls.Add(this.lblEditora);
            this.groupBoxCadastrarLivro.Controls.Add(this.lblISBN);
            this.groupBoxCadastrarLivro.Controls.Add(this.lstAutores);
            this.groupBoxCadastrarLivro.Controls.Add(this.lblDescricao);
            this.groupBoxCadastrarLivro.Controls.Add(this.lblNomeLivro);
            this.groupBoxCadastrarLivro.Controls.Add(this.nudAno);
            this.groupBoxCadastrarLivro.Location = new System.Drawing.Point(23, 72);
            this.groupBoxCadastrarLivro.Name = "groupBoxCadastrarLivro";
            this.groupBoxCadastrarLivro.Size = new System.Drawing.Size(538, 372);
            this.groupBoxCadastrarLivro.TabIndex = 40;
            this.groupBoxCadastrarLivro.TabStop = false;
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblQuantidade.Location = new System.Drawing.Point(328, 308);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(76, 25);
            this.lblQuantidade.TabIndex = 9;
            this.lblQuantidade.Text = "Estoque:";
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPaginas.Location = new System.Drawing.Point(328, 268);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(74, 25);
            this.lblPaginas.TabIndex = 8;
            this.lblPaginas.Text = "Páginas:";
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblPreco.Location = new System.Drawing.Point(328, 224);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(83, 25);
            this.lblPreco.TabIndex = 7;
            this.lblPreco.Text = "Preço: R$";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAno.Location = new System.Drawing.Point(354, 183);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(47, 25);
            this.lblAno.TabIndex = 6;
            this.lblAno.Text = "Ano:";
            // 
            // lblAutores
            // 
            this.lblAutores.AutoSize = true;
            this.lblAutores.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblAutores.Location = new System.Drawing.Point(33, 309);
            this.lblAutores.Name = "lblAutores";
            this.lblAutores.Size = new System.Drawing.Size(74, 25);
            this.lblAutores.TabIndex = 5;
            this.lblAutores.Text = "Autores:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblGenero.Location = new System.Drawing.Point(35, 272);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(72, 25);
            this.lblGenero.TabIndex = 4;
            this.lblGenero.Text = "Gênero:";
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEditora.Location = new System.Drawing.Point(38, 228);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(69, 25);
            this.lblEditora.TabIndex = 3;
            this.lblEditora.Text = "Editora:";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblISBN.Location = new System.Drawing.Point(55, 186);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(52, 25);
            this.lblISBN.TabIndex = 2;
            this.lblISBN.Text = "ISBN:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblDescricao.Location = new System.Drawing.Point(18, 73);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(89, 25);
            this.lblDescricao.TabIndex = 1;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblNomeLivro
            // 
            this.lblNomeLivro.AutoSize = true;
            this.lblNomeLivro.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNomeLivro.Location = new System.Drawing.Point(44, 28);
            this.lblNomeLivro.Name = "lblNomeLivro";
            this.lblNomeLivro.Size = new System.Drawing.Size(63, 25);
            this.lblNomeLivro.TabIndex = 0;
            this.lblNomeLivro.Text = "Nome:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(437, 450);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(124, 35);
            this.btnCadastrar.TabIndex = 41;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseSelectable = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(307, 450);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(124, 35);
            this.btnCancelar.TabIndex = 42;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormCadastrarLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 495);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.picLogoInicial);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.cboEditora);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.nudQuantidade);
            this.Controls.Add(this.nudPaginas);
            this.Controls.Add(this.groupBoxCadastrarLivro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCadastrarLivro";
            this.Resizable = false;
            this.Text = "        Cadastrar Livro";
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaginas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicial)).EndInit();
            this.groupBoxCadastrarLivro.ResumeLayout(false);
            this.groupBoxCadastrarLivro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudAno;
        private System.Windows.Forms.NumericUpDown nudPaginas;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.ListBox lstAutores;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroTextBox txtDescricao;
        private GeneroDataSet generoDataSet;
        private System.Windows.Forms.BindingSource generoDataSetBindingSource;
        private MetroFramework.Controls.MetroComboBox cboEditora;
        private MetroFramework.Controls.MetroComboBox cboGenero;
        private MetroFramework.Controls.MetroTextBox txtISBN;
        private MetroFramework.Controls.MetroTextBox txtPreco;
        private MetroFramework.Components.MetroToolTip toolTip;
        private System.Windows.Forms.PictureBox picLogoInicial;
        private System.Windows.Forms.GroupBox groupBoxCadastrarLivro;
        private MetroFramework.Controls.MetroLabel lblQuantidade;
        private MetroFramework.Controls.MetroLabel lblPaginas;
        private MetroFramework.Controls.MetroLabel lblPreco;
        private MetroFramework.Controls.MetroLabel lblAno;
        private MetroFramework.Controls.MetroLabel lblAutores;
        private MetroFramework.Controls.MetroLabel lblGenero;
        private MetroFramework.Controls.MetroLabel lblEditora;
        private MetroFramework.Controls.MetroLabel lblISBN;
        private MetroFramework.Controls.MetroLabel lblDescricao;
        private MetroFramework.Controls.MetroLabel lblNomeLivro;
        private MetroFramework.Controls.MetroButton btnCadastrar;
        private MetroFramework.Controls.MetroButton btnCancelar;
    }
}