namespace Livraria.View
{
    partial class FormSplash
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
            this.pgbSplash = new MetroFramework.Controls.MetroProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // pgbSplash
            // 
            this.pgbSplash.Location = new System.Drawing.Point(130, 203);
            this.pgbSplash.Name = "pgbSplash";
            this.pgbSplash.Size = new System.Drawing.Size(224, 31);
            this.pgbSplash.TabIndex = 0;
            this.pgbSplash.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormSplash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Livraria.Properties.Resources.livros;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(484, 297);
            this.Controls.Add(this.pgbSplash);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSplash";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSplash";
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroProgressBar pgbSplash;
        private System.Windows.Forms.Timer timer1;
    }
}