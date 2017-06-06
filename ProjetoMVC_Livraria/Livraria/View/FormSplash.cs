using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria.View
{
    public partial class FormSplash : Form
    {
        public FormSplash()
        {
            InitializeComponent();
            pgbSplash.Visible = false;
            this.Opacity = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //pgbSplash.Increment(1);
            if(this.Opacity <= 100)
                this.Opacity = this.Opacity + 0.04;

           // pgbSplash.Increment(1);
        }
    }
}
