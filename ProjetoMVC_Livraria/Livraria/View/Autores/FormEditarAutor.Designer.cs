namespace Livraria.View.Autores
{
    partial class FormEditarAutor
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
            this.groupBoxCadastrarGenero = new System.Windows.Forms.GroupBox();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.bntAtualizar = new MetroFramework.Controls.MetroButton();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
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
            this.picLogoInicial.TabIndex = 45;
            this.picLogoInicial.TabStop = false;
            // 
            // groupBoxCadastrarGenero
            // 
            this.groupBoxCadastrarGenero.Controls.Add(this.lblNome);
            this.groupBoxCadastrarGenero.Controls.Add(this.lblId);
            this.groupBoxCadastrarGenero.Controls.Add(this.txtNome);
            this.groupBoxCadastrarGenero.Controls.Add(this.txtId);
            this.groupBoxCadastrarGenero.Location = new System.Drawing.Point(23, 63);
            this.groupBoxCadastrarGenero.Name = "groupBoxCadastrarGenero";
            this.groupBoxCadastrarGenero.Size = new System.Drawing.Size(386, 105);
            this.groupBoxCadastrarGenero.TabIndex = 43;
            this.groupBoxCadastrarGenero.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNome.Location = new System.Drawing.Point(17, 64);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(63, 25);
            this.lblNome.TabIndex = 24;
            this.lblNome.Text = "Nome:";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblId.Location = new System.Drawing.Point(9, 27);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(71, 25);
            this.lblId.TabIndex = 24;
            this.lblId.Text = "Código:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(86, 65);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(283, 24);
            this.txtNome.TabIndex = 23;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(86, 28);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(70, 24);
            this.txtId.TabIndex = 23;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(225, 174);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 35);
            this.btnCancelar.TabIndex = 44;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // bntAtualizar
            // 
            this.bntAtualizar.Location = new System.Drawing.Point(321, 174);
            this.bntAtualizar.Name = "bntAtualizar";
            this.bntAtualizar.Size = new System.Drawing.Size(90, 35);
            this.bntAtualizar.TabIndex = 42;
            this.bntAtualizar.Text = "Atualizar";
            this.bntAtualizar.UseSelectable = true;
            this.bntAtualizar.Click += new System.EventHandler(this.bntAtualizar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(22, 174);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 35);
            this.btnExcluir.TabIndex = 46;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseSelectable = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // FormEditarAutor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 227);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.picLogoInicial);
            this.Controls.Add(this.groupBoxCadastrarGenero);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.bntAtualizar);
            this.MaximizeBox = false;
            this.Name = "FormEditarAutor";
            this.Resizable = false;
            this.Text = "       Editar Autor";
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicial)).EndInit();
            this.groupBoxCadastrarGenero.ResumeLayout(false);
            this.groupBoxCadastrarGenero.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogoInicial;
        private System.Windows.Forms.GroupBox groupBoxCadastrarGenero;
        private MetroFramework.Controls.MetroLabel lblId;
        private System.Windows.Forms.TextBox txtId;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton bntAtualizar;
        private MetroFramework.Controls.MetroLabel lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private MetroFramework.Controls.MetroButton btnExcluir;
    }
}