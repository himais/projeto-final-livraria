namespace Livraria.View.Editoras
{
    partial class FormEditarEditoras
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
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnAtualizar = new MetroFramework.Controls.MetroButton();
            this.picLogoInicial = new System.Windows.Forms.PictureBox();
            this.mtxCnpj = new System.Windows.Forms.MaskedTextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.groupBoxCadastrarEditora = new System.Windows.Forms.GroupBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.lblCNPJ = new MetroFramework.Controls.MetroLabel();
            this.lblRazaoSocial = new MetroFramework.Controls.MetroLabel();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicial)).BeginInit();
            this.groupBoxCadastrarEditora.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(294, 315);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 35);
            this.btnCancelar.TabIndex = 43;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(419, 315);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(117, 35);
            this.btnAtualizar.TabIndex = 42;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseSelectable = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // picLogoInicial
            // 
            this.picLogoInicial.BackColor = System.Drawing.Color.Transparent;
            this.picLogoInicial.Image = global::Livraria.Properties.Resources.logo;
            this.picLogoInicial.Location = new System.Drawing.Point(23, 20);
            this.picLogoInicial.Name = "picLogoInicial";
            this.picLogoInicial.Size = new System.Drawing.Size(38, 33);
            this.picLogoInicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoInicial.TabIndex = 40;
            this.picLogoInicial.TabStop = false;
            // 
            // mtxCnpj
            // 
            this.mtxCnpj.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxCnpj.Location = new System.Drawing.Point(134, 150);
            this.mtxCnpj.Mask = "00,000,000/0000-00";
            this.mtxCnpj.Name = "mtxCnpj";
            this.mtxCnpj.Size = new System.Drawing.Size(350, 24);
            this.mtxCnpj.TabIndex = 38;
            this.mtxCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(134, 191);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(350, 24);
            this.txtEmail.TabIndex = 39;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazaoSocial.Location = new System.Drawing.Point(134, 109);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(350, 24);
            this.txtRazaoSocial.TabIndex = 37;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(134, 68);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(350, 24);
            this.txtNome.TabIndex = 36;
            // 
            // groupBoxCadastrarEditora
            // 
            this.groupBoxCadastrarEditora.Controls.Add(this.txtId);
            this.groupBoxCadastrarEditora.Controls.Add(this.lblId);
            this.groupBoxCadastrarEditora.Controls.Add(this.lblEmail);
            this.groupBoxCadastrarEditora.Controls.Add(this.lblCNPJ);
            this.groupBoxCadastrarEditora.Controls.Add(this.lblRazaoSocial);
            this.groupBoxCadastrarEditora.Controls.Add(this.mtxCnpj);
            this.groupBoxCadastrarEditora.Controls.Add(this.lblNome);
            this.groupBoxCadastrarEditora.Controls.Add(this.txtEmail);
            this.groupBoxCadastrarEditora.Controls.Add(this.txtRazaoSocial);
            this.groupBoxCadastrarEditora.Controls.Add(this.txtNome);
            this.groupBoxCadastrarEditora.Location = new System.Drawing.Point(23, 63);
            this.groupBoxCadastrarEditora.Name = "groupBoxCadastrarEditora";
            this.groupBoxCadastrarEditora.Size = new System.Drawing.Size(513, 246);
            this.groupBoxCadastrarEditora.TabIndex = 41;
            this.groupBoxCadastrarEditora.TabStop = false;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(134, 30);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(80, 24);
            this.txtId.TabIndex = 41;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblId.Location = new System.Drawing.Point(44, 29);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(71, 25);
            this.lblId.TabIndex = 40;
            this.lblId.Text = "Código:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEmail.Location = new System.Drawing.Point(53, 190);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(64, 25);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCNPJ.Location = new System.Drawing.Point(63, 149);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(54, 25);
            this.lblCNPJ.TabIndex = 2;
            this.lblCNPJ.Text = "CNPJ:";
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblRazaoSocial.Location = new System.Drawing.Point(6, 108);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(111, 25);
            this.lblRazaoSocial.TabIndex = 1;
            this.lblRazaoSocial.Text = "Razão Social:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNome.Location = new System.Drawing.Point(52, 67);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(63, 25);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(23, 315);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(117, 35);
            this.btnExcluir.TabIndex = 44;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseSelectable = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // FormEditarEditoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 363);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.picLogoInicial);
            this.Controls.Add(this.groupBoxCadastrarEditora);
            this.MaximizeBox = false;
            this.Name = "FormEditarEditoras";
            this.Resizable = false;
            this.Text = "        Editar Editora";
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicial)).EndInit();
            this.groupBoxCadastrarEditora.ResumeLayout(false);
            this.groupBoxCadastrarEditora.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnAtualizar;
        private System.Windows.Forms.PictureBox picLogoInicial;
        private System.Windows.Forms.MaskedTextBox mtxCnpj;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.GroupBox groupBoxCadastrarEditora;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroLabel lblCNPJ;
        private MetroFramework.Controls.MetroLabel lblRazaoSocial;
        private MetroFramework.Controls.MetroLabel lblNome;
        private System.Windows.Forms.TextBox txtId;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroButton btnExcluir;
    }
}