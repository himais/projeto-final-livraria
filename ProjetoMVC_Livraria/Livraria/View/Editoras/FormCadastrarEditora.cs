using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Livraria.View.Editoras
{
    public partial class FormCadastrarEditora : Form
    {
        public FormCadastrarEditora()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Model.Editora editora = new Model.Editora();

            
        }
    }
}
