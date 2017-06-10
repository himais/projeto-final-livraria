using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Livraria.View.Vendas
{
    public partial class FormCadastrarVenda : MetroForm
    {
        public FormCadastrarVenda()
        {
            InitializeComponent();
        }

        private void dataGridView1_MouseEnter(object sender, EventArgs e)
        {
            lblDica.Visible = true;
        }

        private void dataGridView1_MouseLeave(object sender, EventArgs e)
        {
            lblDica.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvLivros_DoubleClick(object sender, EventArgs e)
        {
            new FormSelecionarLivros(dgvLivros).ShowDialog(this);
        }
    }
}
