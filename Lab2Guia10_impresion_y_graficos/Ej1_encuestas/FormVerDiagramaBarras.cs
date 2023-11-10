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
    public partial class FormVerDiagramaBarras : Form
    {

        public Dictionary<string, string> Lista { get; set; } = new Dictionary<string, string>();


        public FormVerDiagramaBarras()
        {
            InitializeComponent();


        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int w = pictureBox1.Width;
            int h = pictureBox1.Height;

            Brush brush = new SolidBrush(Color.Black);

            int wbarra = (w - 10) / 6;//6 barras

            int pos = 0;
            foreach (KeyValuePair<string, string> key in Lista)
            {
                string clave = key.Key;
                int valor = Convert.ToInt32(key.Value);

                int hbarra = valor;

                int x0 = 10 + pos * wbarra;
                int y0 = (h - 10) - hbarra;
                int wh = wbarra - 2;
                int hh = hbarra;

                pos++;

                g.FillRectangle(brush, x0, y0, wh, hh);

                //hay que realizar mejoras varias!

            }
        }

    }
}
