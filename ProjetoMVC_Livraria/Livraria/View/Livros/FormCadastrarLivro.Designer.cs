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
            this.lblNomeLivro = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.lblAno = new System.Windows.Forms.Label();
            this.nudAno = new System.Windows.Forms.NumericUpDown();
            this.lblPaginas = new System.Windows.Forms.Label();
            this.nudPaginas = new System.Windows.Forms.NumericUpDown();
            this.lblPreco = new System.Windows.Forms.Label();
            this.lblISBN = new System.Windows.Forms.Label();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.nudQuantidade = new System.Windows.Forms.NumericUpDown();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblEditora = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lstAutores = new System.Windows.Forms.ListBox();
            this.lblAutores = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtNome = new MetroFramework.Controls.MetroTextBox();
            this.txtDescricao = new MetroFramework.Controls.MetroTextBox();
            this.generoDataSet = new Livraria.GeneroDataSet();
            this.generoDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cboEditora = new MetroFramework.Controls.MetroComboBox();
            this.cboGenero = new MetroFramework.Controls.MetroComboBox();
            this.txtISBN = new MetroFramework.Controls.MetroTextBox();
            this.txtPreco = new MetroFramework.Controls.MetroTextBox();
            this.toolTip = new MetroFramework.Components.MetroToolTip();
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaginas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNomeLivro
            // 
            this.lblNomeLivro.AutoSize = true;
            this.lblNomeLivro.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeLivro.Location = new System.Drawing.Point(38, 75);
            this.lblNomeLivro.Name = "lblNomeLivro";
            this.lblNomeLivro.Size = new System.Drawing.Size(58, 18);
            this.lblNomeLivro.TabIndex = 11;
            this.lblNomeLivro.Text = "Nome:";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescricao.Location = new System.Drawing.Point(38, 118);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(90, 18);
            this.lblDescricao.TabIndex = 13;
            this.lblDescricao.Text = "Descrição:";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAno.Location = new System.Drawing.Point(370, 230);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(42, 18);
            this.lblAno.TabIndex = 14;
            this.lblAno.Text = "Ano:";
            // 
            // nudAno
            // 
            this.nudAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAno.Location = new System.Drawing.Point(460, 228);
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
            this.nudAno.Size = new System.Drawing.Size(56, 24);
            this.nudAno.TabIndex = 15;
            this.nudAno.Value = new decimal(new int[] {
            2017,
            0,
            0,
            0});
            // 
            // lblPaginas
            // 
            this.lblPaginas.AutoSize = true;
            this.lblPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaginas.Location = new System.Drawing.Point(370, 313);
            this.lblPaginas.Name = "lblPaginas";
            this.lblPaginas.Size = new System.Drawing.Size(73, 18);
            this.lblPaginas.TabIndex = 16;
            this.lblPaginas.Text = "Páginas:";
            // 
            // nudPaginas
            // 
            this.nudPaginas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudPaginas.Location = new System.Drawing.Point(460, 311);
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
            this.nudPaginas.Size = new System.Drawing.Size(61, 24);
            this.nudPaginas.TabIndex = 17;
            this.nudPaginas.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblPreco
            // 
            this.lblPreco.AutoSize = true;
            this.lblPreco.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreco.Location = new System.Drawing.Point(370, 270);
            this.lblPreco.Name = "lblPreco";
            this.lblPreco.Size = new System.Drawing.Size(84, 18);
            this.lblPreco.TabIndex = 18;
            this.lblPreco.Text = "Preço: R$";
            // 
            // lblISBN
            // 
            this.lblISBN.AutoSize = true;
            this.lblISBN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblISBN.Location = new System.Drawing.Point(38, 230);
            this.lblISBN.Name = "lblISBN";
            this.lblISBN.Size = new System.Drawing.Size(51, 18);
            this.lblISBN.TabIndex = 20;
            this.lblISBN.Text = "ISBN:";
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.AutoSize = true;
            this.lblQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(370, 354);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(75, 18);
            this.lblQuantidade.TabIndex = 22;
            this.lblQuantidade.Text = "Estoque:";
            // 
            // nudQuantidade
            // 
            this.nudQuantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudQuantidade.Location = new System.Drawing.Point(460, 351);
            this.nudQuantidade.Maximum = new decimal(new int[] {
            3000,
            0,
            0,
            0});
            this.nudQuantidade.Name = "nudQuantidade";
            this.nudQuantidade.Size = new System.Drawing.Size(61, 24);
            this.nudQuantidade.TabIndex = 23;
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.Location = new System.Drawing.Point(38, 317);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(69, 18);
            this.lblGenero.TabIndex = 25;
            this.lblGenero.Text = "Gênero:";
            // 
            // lblEditora
            // 
            this.lblEditora.AutoSize = true;
            this.lblEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditora.Location = new System.Drawing.Point(38, 273);
            this.lblEditora.Name = "lblEditora";
            this.lblEditora.Size = new System.Drawing.Size(67, 18);
            this.lblEditora.TabIndex = 27;
            this.lblEditora.Text = "Editora:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(440, 427);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(99, 29);
            this.btnCadastrar.TabIndex = 29;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lstAutores
            // 
            this.lstAutores.FormattingEnabled = true;
            this.lstAutores.Location = new System.Drawing.Point(135, 354);
            this.lstAutores.Name = "lstAutores";
            this.lstAutores.Size = new System.Drawing.Size(169, 56);
            this.lstAutores.TabIndex = 30;
            this.toolTip.SetToolTip(this.lstAutores, "Clique duas vezes para selecionar os autores!");
            this.lstAutores.DoubleClick += new System.EventHandler(this.lstAutores_DoubleClick);
            // 
            // lblAutores
            // 
            this.lblAutores.AutoSize = true;
            this.lblAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutores.Location = new System.Drawing.Point(38, 357);
            this.lblAutores.Name = "lblAutores";
            this.lblAutores.Size = new System.Drawing.Size(71, 18);
            this.lblAutores.TabIndex = 31;
            this.lblAutores.Text = "Autores:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(313, 427);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(99, 29);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNome
            // 
            // 
            // 
            // 
            this.txtNome.CustomButton.Image = null;
            this.txtNome.CustomButton.Location = new System.Drawing.Point(398, 1);
            this.txtNome.CustomButton.Name = "";
            this.txtNome.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNome.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNome.CustomButton.TabIndex = 1;
            this.txtNome.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNome.CustomButton.UseSelectable = true;
            this.txtNome.CustomButton.Visible = false;
            this.txtNome.Lines = new string[0];
            this.txtNome.Location = new System.Drawing.Point(135, 72);
            this.txtNome.MaxLength = 32767;
            this.txtNome.Name = "txtNome";
            this.txtNome.PasswordChar = '\0';
            this.txtNome.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNome.SelectedText = "";
            this.txtNome.SelectionLength = 0;
            this.txtNome.SelectionStart = 0;
            this.txtNome.ShortcutsEnabled = true;
            this.txtNome.Size = new System.Drawing.Size(420, 23);
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
            this.txtDescricao.CustomButton.Location = new System.Drawing.Point(330, 1);
            this.txtDescricao.CustomButton.Name = "";
            this.txtDescricao.CustomButton.Size = new System.Drawing.Size(89, 89);
            this.txtDescricao.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtDescricao.CustomButton.TabIndex = 1;
            this.txtDescricao.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtDescricao.CustomButton.UseSelectable = true;
            this.txtDescricao.CustomButton.Visible = false;
            this.txtDescricao.Lines = new string[0];
            this.txtDescricao.Location = new System.Drawing.Point(135, 115);
            this.txtDescricao.MaxLength = 32767;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.PasswordChar = '\0';
            this.txtDescricao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescricao.SelectedText = "";
            this.txtDescricao.SelectionLength = 0;
            this.txtDescricao.SelectionStart = 0;
            this.txtDescricao.ShortcutsEnabled = true;
            this.txtDescricao.Size = new System.Drawing.Size(420, 91);
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
            this.cboEditora.Location = new System.Drawing.Point(135, 270);
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
            this.cboGenero.Location = new System.Drawing.Point(135, 314);
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
            this.txtISBN.Location = new System.Drawing.Point(135, 228);
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
            this.txtPreco.CustomButton.Location = new System.Drawing.Point(39, 1);
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
            this.txtPreco.Location = new System.Drawing.Point(460, 268);
            this.txtPreco.MaxLength = 32767;
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.PasswordChar = '\0';
            this.txtPreco.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPreco.SelectedText = "";
            this.txtPreco.SelectionLength = 0;
            this.txtPreco.SelectionStart = 0;
            this.txtPreco.ShortcutsEnabled = true;
            this.txtPreco.Size = new System.Drawing.Size(61, 23);
            this.txtPreco.TabIndex = 38;
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
            // FormCadastrarLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 468);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtISBN);
            this.Controls.Add(this.cboGenero);
            this.Controls.Add(this.cboEditora);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblAutores);
            this.Controls.Add(this.lstAutores);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.lblEditora);
            this.Controls.Add(this.lblGenero);
            this.Controls.Add(this.nudQuantidade);
            this.Controls.Add(this.lblQuantidade);
            this.Controls.Add(this.lblISBN);
            this.Controls.Add(this.lblPreco);
            this.Controls.Add(this.nudPaginas);
            this.Controls.Add(this.lblPaginas);
            this.Controls.Add(this.nudAno);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.lblNomeLivro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCadastrarLivro";
            this.Resizable = false;
            this.Text = "Cadastrar Livro";
            ((System.ComponentModel.ISupportInitialize)(this.nudAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPaginas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.generoDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNomeLivro;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.NumericUpDown nudAno;
        private System.Windows.Forms.Label lblPaginas;
        private System.Windows.Forms.NumericUpDown nudPaginas;
        private System.Windows.Forms.Label lblPreco;
        private System.Windows.Forms.Label lblISBN;
        private System.Windows.Forms.Label lblQuantidade;
        private System.Windows.Forms.NumericUpDown nudQuantidade;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblEditora;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.ListBox lstAutores;
        private System.Windows.Forms.Label lblAutores;
        private System.Windows.Forms.Button btnCancelar;
        private MetroFramework.Controls.MetroTextBox txtNome;
        private MetroFramework.Controls.MetroTextBox txtDescricao;
        private GeneroDataSet generoDataSet;
        private System.Windows.Forms.BindingSource generoDataSetBindingSource;
        private MetroFramework.Controls.MetroComboBox cboEditora;
        private MetroFramework.Controls.MetroComboBox cboGenero;
        private MetroFramework.Controls.MetroTextBox txtISBN;
        private MetroFramework.Controls.MetroTextBox txtPreco;
        private MetroFramework.Components.MetroToolTip toolTip;
    }
}