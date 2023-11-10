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

        //descomentar  (ctrl k y ctrol u) este fragmento para entender la idea.
        //private void pictureBox1_Paint(object sender, PaintEventArgs e)
        //{
        //    Graphics g = e.Graphics;

        //    int w = pictureBox1.Width;
        //    int h = pictureBox1.Height;

        //    Brush brush = new SolidBrush(Color.Black);

        //    int wbarra = (w - 10) / 6;//6 barras

        //    int pos = 0;
        //    foreach (KeyValuePair<string, string> key in Lista)
        //    {
        //        string clave = key.Key;
        //        int valor = Convert.ToInt32(key.Value);

        //        int hbarra = valor;

        //        int x0 = 10 + pos * wbarra;
        //        int y0 = (h - 10) - hbarra;
        //        int wh = wbarra - 2;
        //        int hh = hbarra;

        //        pos++;

        //        g.FillRectangle(brush, x0, y0, wh, hh);

        //        //hay que realizar mejoras varias!
        //    }
        //}

        //comentar  (ctrl k y ctrol c) ese fragmento que sigue si descomenta el anterior
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            int w = pictureBox1.Width;
            int h = pictureBox1.Height;

            //agrego la idea de escalamiento, para que el maximo valor ocupe toda la altura disponible
            int maximo = GetMaximo();
            float factorEscala = 1f*h / maximo;// la cosa es que cuando multiplique por el maximo me de 1, 
                                               //ocupando toda la altura disponible, 

            Brush brush = new SolidBrush(Color.Black);

            int wbarra = (w - 10) / 6;//6 barras

            int pos = 0;
            foreach (KeyValuePair<string, string> key in Lista)
            {
                string clave = key.Key;
                int valor = Convert.ToInt32(key.Value);

                int hbarra = (int)factorEscala*valor;

                int x0 = 10 + pos * wbarra;
                int y0 = (h - 10) - hbarra;
                int wh = wbarra - 2;
                int hh = hbarra;

                pos++;

                g.FillRectangle(brush, x0, y0, wh, hh);

                //hay que realizar mejoras varias!
            }
        }

        private int GetMaximo()
        {
            //lo tipico de lab1/prog1!

            int maximo = 0;
            int n = 0;
            foreach (KeyValuePair<string, string> key in Lista)
            {
                string clave = key.Key;
                int valor = Convert.ToInt32(key.Value);

                if (n == 0 || valor >= maximo)
                    maximo = valor;

                n++;
            }

            return maximo;
        }

    }
}
