namespace Livraria.View.Generos
{
    partial class FormEditarGenero
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
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.bntAtualizar = new MetroFramework.Controls.MetroButton();
            this.groupBoxCadastrarGenero = new System.Windows.Forms.GroupBox();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnExcluir = new MetroFramework.Controls.MetroButton();
            this.lblNome = new MetroFramework.Controls.MetroLabel();
            this.txtNome = new System.Windows.Forms.TextBox();
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
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(223, 175);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(90, 35);
            this.btnCancelar.TabIndex = 40;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // bntAtualizar
            // 
            this.bntAtualizar.Location = new System.Drawing.Point(319, 175);
            this.bntAtualizar.Name = "bntAtualizar";
            this.bntAtualizar.Size = new System.Drawing.Size(90, 35);
            this.bntAtualizar.TabIndex = 38;
            this.bntAtualizar.Text = "Atualizar";
            this.bntAtualizar.UseSelectable = true;
            this.bntAtualizar.Click += new System.EventHandler(this.bntAtualizar_Click);
            // 
            // groupBoxCadastrarGenero
            // 
            this.groupBoxCadastrarGenero.Controls.Add(this.lblNome);
            this.groupBoxCadastrarGenero.Controls.Add(this.txtNome);
            this.groupBoxCadastrarGenero.Controls.Add(this.lblId);
            this.groupBoxCadastrarGenero.Controls.Add(this.txtId);
            this.groupBoxCadastrarGenero.Location = new System.Drawing.Point(23, 63);
            this.groupBoxCadastrarGenero.Name = "groupBoxCadastrarGenero";
            this.groupBoxCadastrarGenero.Size = new System.Drawing.Size(386, 106);
            this.groupBoxCadastrarGenero.TabIndex = 39;
            this.groupBoxCadastrarGenero.TabStop = false;
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Enabled = false;
            this.lblId.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblId.Location = new System.Drawing.Point(17, 27);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(32, 25);
            this.lblId.TabIndex = 24;
            this.lblId.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(86, 28);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(55, 24);
            this.txtId.TabIndex = 23;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(22, 175);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(90, 35);
            this.btnExcluir.Style = MetroFramework.MetroColorStyle.Red;
            this.btnExcluir.TabIndex = 42;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseSelectable = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblNome.Location = new System.Drawing.Point(17, 63);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(63, 25);
            this.lblNome.TabIndex = 26;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(86, 64);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(283, 24);
            this.txtNome.TabIndex = 25;
            // 
            // FormEditarGenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 226);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.picLogoInicial);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.bntAtualizar);
            this.Controls.Add(this.groupBoxCadastrarGenero);
            this.Name = "FormEditarGenero";
            this.Resizable = false;
            this.Text = "        Editar Gênero";
            ((System.ComponentModel.ISupportInitialize)(this.picLogoInicial)).EndInit();
            this.groupBoxCadastrarGenero.ResumeLayout(false);
            this.groupBoxCadastrarGenero.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picLogoInicial;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton bntAtualizar;
        private System.Windows.Forms.GroupBox groupBoxCadastrarGenero;
        private MetroFramework.Controls.MetroLabel lblId;
        private System.Windows.Forms.TextBox txtId;
        private MetroFramework.Controls.MetroButton btnExcluir;
        private MetroFramework.Controls.MetroLabel lblNome;
        private System.Windows.Forms.TextBox txtNome;


    }
}