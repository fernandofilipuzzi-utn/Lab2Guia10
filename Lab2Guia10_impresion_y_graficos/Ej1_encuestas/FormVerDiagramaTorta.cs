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
    public partial class FormVerDiagramaTorta : Form
    {
        public FormVerDiagramaTorta()
        {
            InitializeComponent();
        }

        public float[] Valores { get; set; } =new float[] { };
        public Color[] Colores { get; set; } = new Color[] { };

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int w = pictureBox1.Width;
            int h = pictureBox1.Height;

            #region margenes
            float m = 20;
            #endregion

            #region area cliente
            float wc = w - 2 * m;
            float hc = h - 2 * m;
            #endregion

            #region centro
            float x0 = wc / 2 + m;
            float y0 = hc / 2 + m;
            #endregion

            float ang0 = 0;
            int n = 0;
            foreach (float valor in Valores)
            {
                Brush brush = new SolidBrush(Colores[n++]);
                g.FillPie(brush, x0 - w / 2, y0 - hc / 2, wc, hc, ang0, valor);
                ang0 += valor;
            }
        }
    }
}
