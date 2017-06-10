namespace Livraria.View.Editoras
{
    partial class FormCadastrarEditoras
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtRazaoSocial = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.mtxCnpj = new System.Windows.Forms.MaskedTextBox();
            this.picLogoInicial = new System.Windows.Forms.PictureBox();
            this.groupBoxCadastrarEditora = new System.Windows.Forms.GroupBox();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.lblCNPJ = new MetroFramework.Controls.MetroLabel();
            this.lblRazaoSocial = new MetroFramework.Controls.MetroLabel();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.btnCadastrar = new MetroFramework.Controls.MetroButton();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicial)).BeginInit();
            this.groupBoxCadastrarEditora.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(158, 221);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(350, 24);
            this.txtEmail.TabIndex = 28;
            // 
            // txtRazaoSocial
            // 
            this.txtRazaoSocial.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazaoSocial.Location = new System.Drawing.Point(158, 139);
            this.txtRazaoSocial.Name = "txtRazaoSocial";
            this.txtRazaoSocial.Size = new System.Drawing.Size(350, 24);
            this.txtRazaoSocial.TabIndex = 25;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(158, 98);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(350, 24);
            this.txtNome.TabIndex = 22;
            // 
            // mtxCnpj
            // 
            this.mtxCnpj.CutCopyMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxCnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxCnpj.Location = new System.Drawing.Point(158, 180);
            this.mtxCnpj.Mask = "00,000,000/0000-00";
            this.mtxCnpj.Name = "mtxCnpj";
            this.mtxCnpj.Size = new System.Drawing.Size(350, 24);
            this.mtxCnpj.TabIndex = 27;
            this.mtxCnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // picLogoInicial
            // 
            this.picLogoInicial.BackColor = System.Drawing.Color.Transparent;
            this.picLogoInicial.Image = global::Livraria.Properties.Resources.logo;
            this.picLogoInicial.Location = new System.Drawing.Point(23, 21);
            this.picLogoInicial.Name = "picLogoInicial";
            this.picLogoInicial.Size = new System.Drawing.Size(38, 33);
            this.picLogoInicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoInicial.TabIndex = 32;
            this.picLogoInicial.TabStop = false;
            // 
            // groupBoxCadastrarEditora
            // 
            this.groupBoxCadastrarEditora.Controls.Add(this.lblEmail);
            this.groupBoxCadastrarEditora.Controls.Add(this.lblCNPJ);
            this.groupBoxCadastrarEditora.Controls.Add(this.lblRazaoSocial);
            this.groupBoxCadastrarEditora.Controls.Add(this.lblNome);
            this.groupBoxCadastrarEditora.Location = new System.Drawing.Point(23, 64);
            this.groupBoxCadastrarEditora.Name = "groupBoxCadastrarEditora";
            this.groupBoxCadastrarEditora.Size = new System.Drawing.Size(513, 213);
            this.groupBoxCadastrarEditora.TabIndex = 33;
            this.groupBoxCadastrarEditora.TabStop = false;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblEmail.Location = new System.Drawing.Point(54, 156);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(64, 25);
            this.lblEmail.TabIndex = 3;
            this.lblEmail.Text = "E-mail:";
            // 
            // lblCNPJ
            // 
            this.lblCNPJ.AutoSize = true;
            this.lblCNPJ.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblCNPJ.Location = new System.Drawing.Point(64, 115);
            this.lblCNPJ.Name = "lblCNPJ";
            this.lblCNPJ.Size = new System.Drawing.Size(54, 25);
            this.lblCNPJ.TabIndex = 2;
            this.lblCNPJ.Text = "CNPJ:";
            // 
            // lblRazaoSocial
            // 
            this.lblRazaoSocial.AutoSize = true;
            this.lblRazaoSocial.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblRazaoSocial.Location = new System.Drawing.Point(7, 74);
            this.lblRazaoSocial.Name = "lblRazaoSocial";
            this.lblRazaoSocial.Size = new System.Drawing.Size(111, 25);
            this.lblRazaoSocial.TabIndex = 1;
            this.lblRazaoSocial.Text = "Razão Social:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNome.Location = new System.Drawing.Point(53, 33);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(63, 25);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(419, 283);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(117, 35);
            this.btnCadastrar.TabIndex = 34;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseSelectable = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(296, 283);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(117, 35);
            this.btnCancelar.TabIndex = 35;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // FormCadastrarEditoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 332);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.picLogoInicial);
            this.Controls.Add(this.mtxCnpj);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtRazaoSocial);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.groupBoxCadastrarEditora);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCadastrarEditoras";
            this.Resizable = false;
            this.Text = "        Cadastrar Editora";
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicial)).EndInit();
            this.groupBoxCadastrarEditora.ResumeLayout(false);
            this.groupBoxCadastrarEditora.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtRazaoSocial;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.MaskedTextBox mtxCnpj;
        private System.Windows.Forms.PictureBox picLogoInicial;
        private System.Windows.Forms.GroupBox groupBoxCadastrarEditora;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroLabel lblCNPJ;
        private MetroFramework.Controls.MetroLabel lblRazaoSocial;
        private MetroFramework.Controls.MetroLabel lblNome;
        private MetroFramework.Controls.MetroButton btnCadastrar;
        private MetroFramework.Controls.MetroButton btnCancelar;
    }
}