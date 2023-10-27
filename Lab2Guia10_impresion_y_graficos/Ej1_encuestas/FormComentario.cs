using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1_encuestas
{
    public partial class FormComentario : Form
    {
        public FormComentario()
        {
            InitializeComponent();
            toolStripStatusLabel1.Text = $"Caracteres: {tbComentario.Text.Trim().Length}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
       
        }

        private void tbComentario_KeyPress(object sender, KeyPressEventArgs e)
        {
            toolStripStatusLabel1.Text = $"Caracteres: {tbComentario.Text.Trim().Length}";
            if (tbComentario.Text.Trim().Length > 40)
                e.Handled = false;
        }

        private void tbComentario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
