namespace Livraria.View
{
    partial class FormSobre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSobre));
            this.groupBoxSobre = new System.Windows.Forms.GroupBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.groupBoxSobre.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxSobre
            // 
            this.groupBoxSobre.Controls.Add(this.metroLabel1);
            this.groupBoxSobre.Location = new System.Drawing.Point(24, 64);
            this.groupBoxSobre.Name = "groupBoxSobre";
            this.groupBoxSobre.Size = new System.Drawing.Size(488, 189);
            this.groupBoxSobre.TabIndex = 0;
            this.groupBoxSobre.TabStop = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(6, 10);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(466, 171);
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = resources.GetString("metroLabel1.Text");
            // 
            // FormSobre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 271);
            this.Controls.Add(this.groupBoxSobre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSobre";
            this.Resizable = false;
            this.Text = "Sobre a aplicação";
            this.groupBoxSobre.ResumeLayout(false);
            this.groupBoxSobre.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxSobre;
        private MetroFramework.Controls.MetroLabel metroLabel1;
    }
}