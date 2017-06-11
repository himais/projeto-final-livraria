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
            this.picLogoInicial = new System.Windows.Forms.PictureBox();
            this.tileVendas = new MetroFramework.Controls.MetroTile();
            this.contextMenuVendas = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.cadastrarVendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarVendasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblBemVindo = new MetroFramework.Controls.MetroLabel();
            this.tileGenero = new MetroFramework.Controls.MetroTile();
            this.tileEditora = new MetroFramework.Controls.MetroTile();
            this.tileLivros = new MetroFramework.Controls.MetroTile();
            this.tileAutores = new MetroFramework.Controls.MetroTile();
            this.tileOutros = new MetroFramework.Controls.MetroTile();
            this.menuStripPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicial)).BeginInit();
            this.contextMenuVendas.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.BackColor = System.Drawing.Color.White;
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
            this.tsmiVendas.Size = new System.Drawing.Size(56, 20);
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
            this.tsmiLivroGeneroCadastrar.Click += new System.EventHandler(this.tsmiLivroGeneroCadastrar_Click);
            // 
            // tsmiLivroGeneroListar
            // 
            this.tsmiLivroGeneroListar.Name = "tsmiLivroGeneroListar";
            this.tsmiLivroGeneroListar.Size = new System.Drawing.Size(124, 22);
            this.tsmiLivroGeneroListar.Text = "Listar";
            this.tsmiLivroGeneroListar.Click += new System.EventHandler(this.tsmiLivroGeneroListar_Click);
            // 
            // tsmiFuncionarios
            // 
            this.tsmiFuncionarios.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFuncionariosCadastrar,
            this.tsmiFuncionariosConsultar});
            this.tsmiFuncionarios.Name = "tsmiFuncionarios";
            this.tsmiFuncionarios.Size = new System.Drawing.Size(87, 20);
            this.tsmiFuncionarios.Text = "Funcionários";
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
            this.tsmiEditorasCadastrar.Size = new System.Drawing.Size(152, 22);
            this.tsmiEditorasCadastrar.Text = "Cadastrar";
            this.tsmiEditorasCadastrar.Click += new System.EventHandler(this.tsmiEditorasCadastrar_Click);
            // 
            // tsmiEditorasConsultar
            // 
            this.tsmiEditorasConsultar.Name = "tsmiEditorasConsultar";
            this.tsmiEditorasConsultar.Size = new System.Drawing.Size(152, 22);
            this.tsmiEditorasConsultar.Text = "Consultar";
            this.tsmiEditorasConsultar.Click += new System.EventHandler(this.tsmiEditorasConsultar_Click);
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
            this.tsmiAutoresCadastrar.Click += new System.EventHandler(this.tsmiAutoresCadastrar_Click);
            // 
            // tsmiAutoresConsultar
            // 
            this.tsmiAutoresConsultar.Name = "tsmiAutoresConsultar";
            this.tsmiAutoresConsultar.Size = new System.Drawing.Size(125, 22);
            this.tsmiAutoresConsultar.Text = "Consultar";
            this.tsmiAutoresConsultar.Click += new System.EventHandler(this.tsmiAutoresConsultar_Click);
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
            // tileVendas
            // 
            this.tileVendas.ActiveControl = null;
            this.tileVendas.Location = new System.Drawing.Point(372, 127);
            this.tileVendas.Name = "tileVendas";
            this.tileVendas.Size = new System.Drawing.Size(198, 192);
            this.tileVendas.TabIndex = 11;
            this.tileVendas.Text = "Registrar Venda";
            this.tileVendas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.tileVendas.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.tileVendas.UseSelectable = true;
            this.tileVendas.Click += new System.EventHandler(this.tileVendas_Click);
            // 
            // contextMenuVendas
            // 
            this.contextMenuVendas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarVendaToolStripMenuItem,
            this.consultarVendasToolStripMenuItem});
            this.contextMenuVendas.Name = "contextMenuVendas";
            this.contextMenuVendas.Size = new System.Drawing.Size(166, 48);
            // 
            // cadastrarVendaToolStripMenuItem
            // 
            this.cadastrarVendaToolStripMenuItem.Name = "cadastrarVendaToolStripMenuItem";
            this.cadastrarVendaToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.cadastrarVendaToolStripMenuItem.Text = "Cadastrar Venda";
            // 
            // consultarVendasToolStripMenuItem
            // 
            this.consultarVendasToolStripMenuItem.Name = "consultarVendasToolStripMenuItem";
            this.consultarVendasToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.consultarVendasToolStripMenuItem.Text = "Consultar Vendas";
            // 
            // lblBemVindo
            // 
            this.lblBemVindo.Location = new System.Drawing.Point(398, 97);
            this.lblBemVindo.Name = "lblBemVindo";
            this.lblBemVindo.Size = new System.Drawing.Size(172, 23);
            this.lblBemVindo.TabIndex = 14;
            this.lblBemVindo.Text = "Seja bem-vindo(a),";
            this.lblBemVindo.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tileGenero
            // 
            this.tileGenero.ActiveControl = null;
            this.tileGenero.Location = new System.Drawing.Point(24, 127);
            this.tileGenero.Name = "tileGenero";
            this.tileGenero.Size = new System.Drawing.Size(102, 89);
            this.tileGenero.TabIndex = 15;
            this.tileGenero.Text = "Consultar \r\nGêneros";
            this.tileGenero.UseSelectable = true;
            this.tileGenero.Click += new System.EventHandler(this.tileGenero_Click);
            // 
            // tileEditora
            // 
            this.tileEditora.ActiveControl = null;
            this.tileEditora.Location = new System.Drawing.Point(140, 127);
            this.tileEditora.Name = "tileEditora";
            this.tileEditora.Size = new System.Drawing.Size(102, 89);
            this.tileEditora.TabIndex = 16;
            this.tileEditora.Text = "Consultar\r\nEditoras";
            this.tileEditora.UseSelectable = true;
            this.tileEditora.Click += new System.EventHandler(this.tileEditora_Click);
            // 
            // tileLivros
            // 
            this.tileLivros.ActiveControl = null;
            this.tileLivros.Location = new System.Drawing.Point(24, 230);
            this.tileLivros.Name = "tileLivros";
            this.tileLivros.Size = new System.Drawing.Size(218, 89);
            this.tileLivros.TabIndex = 17;
            this.tileLivros.Text = "Consultar Livros";
            this.tileLivros.UseSelectable = true;
            this.tileLivros.Click += new System.EventHandler(this.tileLivros_Click);
            // 
            // tileAutores
            // 
            this.tileAutores.ActiveControl = null;
            this.tileAutores.Location = new System.Drawing.Point(257, 127);
            this.tileAutores.Name = "tileAutores";
            this.tileAutores.Size = new System.Drawing.Size(102, 89);
            this.tileAutores.TabIndex = 18;
            this.tileAutores.Text = "Consultar\r\nAutores";
            this.tileAutores.UseSelectable = true;
            this.tileAutores.Click += new System.EventHandler(this.tileAutores_Click);
            // 
            // tileOutros
            // 
            this.tileOutros.ActiveControl = null;
            this.tileOutros.Location = new System.Drawing.Point(257, 230);
            this.tileOutros.Name = "tileOutros";
            this.tileOutros.Size = new System.Drawing.Size(102, 89);
            this.tileOutros.TabIndex = 19;
            this.tileOutros.Text = "metroTile6";
            this.tileOutros.UseSelectable = true;
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 342);
            this.Controls.Add(this.tileOutros);
            this.Controls.Add(this.tileAutores);
            this.Controls.Add(this.tileLivros);
            this.Controls.Add(this.tileEditora);
            this.Controls.Add(this.tileGenero);
            this.Controls.Add(this.lblBemVindo);
            this.Controls.Add(this.tileVendas);
            this.Controls.Add(this.picLogoInicial);
            this.Controls.Add(this.menuStripPrincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStripPrincipal;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.Resizable = false;
            this.Text = "       Tela Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicial)).EndInit();
            this.contextMenuVendas.ResumeLayout(false);
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
        private System.Windows.Forms.ToolStripMenuItem tsmiAutoresCadastrar;
        private System.Windows.Forms.ToolStripMenuItem tsmiAutoresConsultar;
        private System.Windows.Forms.PictureBox picLogoInicial;
        private MetroFramework.Controls.MetroTile tileVendas;
        private MetroFramework.Controls.MetroContextMenu contextMenuVendas;
        private System.Windows.Forms.ToolStripMenuItem cadastrarVendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarVendasToolStripMenuItem;
        private MetroFramework.Controls.MetroLabel lblBemVindo;
        private MetroFramework.Controls.MetroTile tileGenero;
        private MetroFramework.Controls.MetroTile tileEditora;
        private MetroFramework.Controls.MetroTile tileLivros;
        private MetroFramework.Controls.MetroTile tileAutores;
        private MetroFramework.Controls.MetroTile tileOutros;
    }
}