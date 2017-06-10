namespace Livraria.View.Autores
{
    partial class FormCadastrarAutor
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
            this.picLogoInicial = new System.Windows.Forms.PictureBox();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.bntCadastrar = new MetroFramework.Controls.MetroButton();
            this.groupBoxCadastrarGenero = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicial)).BeginInit();
            this.groupBoxCadastrarGenero.SuspendLayout();
            this.SuspendLayout();
            // 
            // picLogoInicial
            // 
            this.picLogoInicial.BackColor = System.Drawing.Color.Transparent;
            this.picLogoInicial.Image = global::Livraria.Properties.Resources.logo;
            this.picLogoInicial.Location = new System.Drawing.Point(22, 20);
            this.picLogoInicial.Name = "picLogoInicial";
            this.picLogoInicial.Size = new System.Drawing.Size(38, 33);
            this.picLogoInicial.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picLogoInicial.TabIndex = 41;
            this.picLogoInicial.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNome.Location = new System.Drawing.Point(17, 27);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(63, 25);
            this.lblNome.TabIndex = 24;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(86, 28);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(283, 24);
            this.txtNome.TabIndex = 23;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(223, 145);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 35);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // bntCadastrar
            // 
            this.bntCadastrar.Location = new System.Drawing.Point(319, 145);
            this.bntCadastrar.Name = "bntCadastrar";
            this.bntCadastrar.Size = new System.Drawing.Size(90, 35);
            this.bntCadastrar.TabIndex = 38;
            this.bntCadastrar.Text = "Cadastrar";
            this.bntCadastrar.UseSelectable = true;
            this.bntCadastrar.Click += new System.EventHandler(this.bntCadastrar_Click);
            // 
            // groupBoxCadastrarGenero
            // 
            this.groupBoxCadastrarGenero.Controls.Add(this.lblNome);
            this.groupBoxCadastrarGenero.Controls.Add(this.txtNome);
            this.groupBoxCadastrarGenero.Location = new System.Drawing.Point(23, 63);
            this.groupBoxCadastrarGenero.Name = "groupBoxCadastrarGenero";
            this.groupBoxCadastrarGenero.Size = new System.Drawing.Size(386, 76);
            this.groupBoxCadastrarGenero.TabIndex = 39;
            this.groupBoxCadastrarGenero.TabStop = false;
            // 
            // FormCadastrarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 202);
            this.Controls.Add(this.picLogoInicial);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.bntCadastrar);
            this.Controls.Add(this.groupBoxCadastrarGenero);
            this.Name = "FormCadastrarAutor";
            this.Resizable = false;
            this.Text = "       Cadastrar Autor";
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicial)).EndInit();
            this.groupBoxCadastrarGenero.ResumeLayout(false);
            this.groupBoxCadastrarGenero.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogoInicial;
        private MetroFramework.Controls.MetroLabel lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton bntCadastrar;
        private System.Windows.Forms.GroupBox groupBoxCadastrarGenero;
    }
}