namespace Livraria.View
{
    partial class FormPrincipal
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
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.tsmiArquivo = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSobre = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSair = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVendas = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVendasRealizar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiVendasConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLivros = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLivroAdicionar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLivroConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLivroGenero = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLivroGeneroCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLivroGeneroListar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFuncionarios = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFuncionariosCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiFuncionariosConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditoras = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditorasCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditorasConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAutores = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAutoresCadastrar = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAutoresConsultar = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBemVindo = new System.Windows.Forms.Label();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.opçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opção2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.picLogoInicial = new System.Windows.Forms.PictureBox();
            this.menuStripPrincipal.SuspendLayout();
            this.metroContextMenu1.SuspendLayout();
            this.metroTabControl1.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicial)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiArquivo,
            this.tsmiVendas,
            this.tsmiLivros,
            this.tsmiFuncionarios,
            this.tsmiEditoras,
            this.tsmiAutores});
            this.menuStripPrincipal.Location = new System.Drawing.Point(20, 60);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new System.Drawing.Size(550, 24);
            this.menuStripPrincipal.TabIndex = 0;
            this.menuStripPrincipal.Text = "menuStrip1";
            // 
            // tsmiArquivo
            // 
            this.tsmiArquivo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSobre,
            this.tsmiSair});
            this.tsmiArquivo.Name = "tsmiArquivo";
            this.tsmiArquivo.Size = new System.Drawing.Size(61, 20);
            this.tsmiArquivo.Text = "Arquivo";
            // 
            // tsmiSobre
            // 
            this.tsmiSobre.Name = "tsmiSobre";
            this.tsmiSobre.Size = new System.Drawing.Size(104, 22);
            this.tsmiSobre.Text = "Sobre";
            this.tsmiSobre.Click += new System.EventHandler(this.sobreToolStripMenuItem_Click);
            // 
            // tsmiSair
            // 
            this.tsmiSair.Name = "tsmiSair";
            this.tsmiSair.Size = new System.Drawing.Size(104, 22);
            this.tsmiSair.Text = "Sair";
            this.tsmiSair.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // tsmiVendas
            // 
            this.tsmiVendas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiVendasRealizar,
            this.tsmiVendasConsultar});
            this.tsmiVendas.Name = "tsmiVendas";
            this.tsmiVendas.Size = new System.Drawing.Size(57, 20);
            this.tsmiVendas.Text = "Vendas";
            // 
            // tsmiVendasRealizar
            // 
            this.tsmiVendasRealizar.Name = "tsmiVendasRealizar";
            this.tsmiVendasRealizar.Size = new System.Drawing.Size(160, 22);
            this.tsmiVendasRealizar.Text = "Realizar venda";
            // 
            // tsmiVendasConsultar
            // 
            this.tsmiVendasConsultar.Name = "tsmiVendasConsultar";
            this.tsmiVendasConsultar.Size = new System.Drawing.Size(160, 22);
            this.tsmiVendasConsultar.Text = "Consultar venda";
            // 
            // tsmiLivros
            // 
            this.tsmiLivros.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLivroAdicionar,
            this.tsmiLivroConsultar,
            this.tsmiLivroGenero});
            this.tsmiLivros.Name = "tsmiLivros";
            this.tsmiLivros.Size = new System.Drawing.Size(50, 20);
            this.tsmiLivros.Text = "Livros";
            // 
            // tsmiLivroAdicionar
            // 
            this.tsmiLivroAdicionar.Name = "tsmiLivroAdicionar";
            this.tsmiLivroAdicionar.Size = new System.Drawing.Size(125, 22);
            this.tsmiLivroAdicionar.Text = "Adicionar";
            this.tsmiLivroAdicionar.Click += new System.EventHandler(this.tsmiLivroAdicionar_Click);
            // 
            // tsmiLivroConsultar
            // 
            this.tsmiLivroConsultar.Name = "tsmiLivroConsultar";
            this.tsmiLivroConsultar.Size = new System.Drawing.Size(125, 22);
            this.tsmiLivroConsultar.Text = "Consultar";
            this.tsmiLivroConsultar.Click += new System.EventHandler(this.tsmiLivroConsultar_Click);
            // 
            // tsmiLivroGenero
            // 
            this.tsmiLivroGenero.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiLivroGeneroCadastrar,
            this.tsmiLivroGeneroListar});
            this.tsmiLivroGenero.Name = "tsmiLivroGenero";
            this.tsmiLivroGenero.Size = new System.Drawing.Size(125, 22);
            this.tsmiLivroGenero.Text = "Gênero";
            // 
            // tsmiLivroGeneroCadastrar
            // 
            this.tsmiLivroGeneroCadastrar.Name = "tsmiLivroGeneroCadastrar";
            this.tsmiLivroGeneroCadastrar.Size = new System.Drawing.Size(124, 22);
            this.tsmiLivroGeneroCadastrar.Text = "Cadastrar";
            // 
            // tsmiLivroGeneroListar
            // 
            this.tsmiLivroGeneroListar.Name = "tsmiLivroGeneroListar";
            this.tsmiLivroGeneroListar.Size = new System.Drawing.Size(124, 22);
            this.tsmiLivroGeneroListar.Text = "Listar";
            // 
            // tsmiFuncionarios
            // 
            this.tsmiFuncionarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFuncionariosCadastrar,
            this.tsmiFuncionariosConsultar});
            this.tsmiFuncionarios.Name = "tsmiFuncionarios";
            this.tsmiFuncionarios.Size = new System.Drawing.Size(87, 20);
            this.tsmiFuncionarios.Text = "Funcionarios";
            // 
            // tsmiFuncionariosCadastrar
            // 
            this.tsmiFuncionariosCadastrar.Name = "tsmiFuncionariosCadastrar";
            this.tsmiFuncionariosCadastrar.Size = new System.Drawing.Size(125, 22);
            this.tsmiFuncionariosCadastrar.Text = "Cadastrar";
            this.tsmiFuncionariosCadastrar.Click += new System.EventHandler(this.tsmiFuncionariosCadastrar_Click);
            // 
            // tsmiFuncionariosConsultar
            // 
            this.tsmiFuncionariosConsultar.Name = "tsmiFuncionariosConsultar";
            this.tsmiFuncionariosConsultar.Size = new System.Drawing.Size(125, 22);
            this.tsmiFuncionariosConsultar.Text = "Consultar";
            this.tsmiFuncionariosConsultar.Click += new System.EventHandler(this.tsmiFuncionariosConsultar_Click);
            // 
            // tsmiEditoras
            // 
            this.tsmiEditoras.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiEditorasCadastrar,
            this.tsmiEditorasConsultar});
            this.tsmiEditoras.Name = "tsmiEditoras";
            this.tsmiEditoras.Size = new System.Drawing.Size(61, 20);
            this.tsmiEditoras.Text = "Editoras";
            // 
            // tsmiEditorasCadastrar
            // 
            this.tsmiEditorasCadastrar.Name = "tsmiEditorasCadastrar";
            this.tsmiEditorasCadastrar.Size = new System.Drawing.Size(125, 22);
            this.tsmiEditorasCadastrar.Text = "Cadastrar";
            this.tsmiEditorasCadastrar.Click += new System.EventHandler(this.tsmiEditorasCadastrar_Click);
            // 
            // tsmiEditorasConsultar
            // 
            this.tsmiEditorasConsultar.Name = "tsmiEditorasConsultar";
            this.tsmiEditorasConsultar.Size = new System.Drawing.Size(125, 22);
            this.tsmiEditorasConsultar.Text = "Consultar";
            // 
            // tsmiAutores
            // 
            this.tsmiAutores.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAutoresCadastrar,
            this.tsmiAutoresConsultar});
            this.tsmiAutores.Name = "tsmiAutores";
            this.tsmiAutores.Size = new System.Drawing.Size(60, 20);
            this.tsmiAutores.Text = "Autores";
            // 
            // tsmiAutoresCadastrar
            // 
            this.tsmiAutoresCadastrar.Name = "tsmiAutoresCadastrar";
            this.tsmiAutoresCadastrar.Size = new System.Drawing.Size(125, 22);
            this.tsmiAutoresCadastrar.Text = "Cadastrar";
            // 
            // tsmiAutoresConsultar
            // 
            this.tsmiAutoresConsultar.Name = "tsmiAutoresConsultar";
            this.tsmiAutoresConsultar.Size = new System.Drawing.Size(125, 22);
            this.tsmiAutoresConsultar.Text = "Consultar";
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.AutoSize = true;
            this.lblBemVindo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBemVindo.Location = new System.Drawing.Point(331, 97);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(114, 18);
            this.lblBemVindo.TabIndex = 1;
            this.lblBemVindo.Text = "Seja bem-vindo,";
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Location = new System.Drawing.Point(47, 6);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(245, 56);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Realizar venda";
            this.metroTile1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.metroTile1.UseSelectable = true;
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.opçãoToolStripMenuItem,
            this.opção2ToolStripMenuItem});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(116, 48);
            // 
            // opçãoToolStripMenuItem
            // 
            this.opçãoToolStripMenuItem.Name = "opçãoToolStripMenuItem";
            this.opçãoToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.opçãoToolStripMenuItem.Text = "Opção";
            // 
            // opção2ToolStripMenuItem
            // 
            this.opção2ToolStripMenuItem.Name = "opção2ToolStripMenuItem";
            this.opção2ToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.opção2ToolStripMenuItem.Text = "Opção2";
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Controls.Add(this.metroTabPage2);
            this.metroTabControl1.Location = new System.Drawing.Point(34, 118);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(411, 169);
            this.metroTabControl1.TabIndex = 3;
            this.metroTabControl1.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.Controls.Add(this.metroTile1);
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(403, 127);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "metroTabPage1";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 10;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Size = new System.Drawing.Size(403, 127);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "metroTabPage2";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            // 
            // picLogoInicial
            // 
            this.picLogoInicial.BackColor = System.Drawing.Color.Transparent;
            this.picLogoInicial.Image = global::Livraria.Properties.Resources.logo;
            this.picLogoInicial.Location = new System.Drawing.Point(24, 19);
            this.picLogoInicial.Name = "picLogoInicial";
            this.picLogoInicial.Size = new System.Drawing.Size(38, 33);
            this.picLogoInicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoInicial.TabIndex = 10;
            this.picLogoInicial.TabStop = false;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 342);
            this.Controls.Add(this.picLogoInicial);
            this.Controls.Add(this.metroTabControl1);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.menuStripPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripPrincipal;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.Resizable = false;
            this.Text = "      Tela Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.metroContextMenu1.ResumeLayout(false);
            this.metroTabControl1.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem tsmiArquivo;
        private System.Windows.Forms.ToolStripMenuItem tsmiSobre;
        private System.Windows.Forms.ToolStripMenuItem tsmiSair;
        private System.Windows.Forms.ToolStripMenuItem tsmiVendas;
        private System.Windows.Forms.ToolStripMenuItem tsmiVendasRealizar;
        private System.Windows.Forms.ToolStripMenuItem tsmiVendasConsultar;
        private System.Windows.Forms.ToolStripMenuItem tsmiLivros;
        private System.Windows.Forms.ToolStripMenuItem tsmiLivroAdicionar;
        private System.Windows.Forms.ToolStripMenuItem tsmiLivroConsultar;
        private System.Windows.Forms.ToolStripMenuItem tsmiFuncionarios;
        private System.Windows.Forms.ToolStripMenuItem tsmiFuncionariosCadastrar;
        private System.Windows.Forms.ToolStripMenuItem tsmiFuncionariosConsultar;
        private System.Windows.Forms.ToolStripMenuItem tsmiLivroGenero;
        private System.Windows.Forms.ToolStripMenuItem tsmiLivroGeneroCadastrar;
        private System.Windows.Forms.ToolStripMenuItem tsmiLivroGeneroListar;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditoras;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditorasCadastrar;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditorasConsultar;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutores;
        private System.Windows.Forms.Label lblBemVindo;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutoresCadastrar;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutoresConsultar;
        private MetroFramework.Controls.MetroTile metroTile1;
        private MetroFramework.Controls.MetroContextMenu metroContextMenu1;
        private System.Windows.Forms.ToolStripMenuItem opçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opção2ToolStripMenuItem;
        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTabPage metroTabPage2;
        private System.Windows.Forms.PictureBox picLogoInicial;
    }
}