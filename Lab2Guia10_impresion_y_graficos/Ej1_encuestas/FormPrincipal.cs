using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Collections;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Ej1_encuestas.Modelo;

namespace Ej1_encuestas
{
    public partial class FormPrincipal : Form
    {
        List<Comentario> comentarios = new List < Comentario >();
        int IdGen;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            comentarios.Add(new Comentario { Id = IdGen++, Contenido = "Muy buen desarrollo" });
            comentarios.Add(new Comentario { Id = IdGen++, Contenido = "Fue terriblemente malo" });
            comentarios.Add(new Comentario { Id = IdGen++, Contenido = "Fue terriblemente bueno!" });
            pintar();
        }
        
        private void btnAgregarComentario_Click(object sender, EventArgs e)
        {
            FormComentario fComentario = new FormComentario(); 
            if (fComentario.ShowDialog() == DialogResult.OK)
            {
                Comentario nuevo = new Comentario {
                    Id = IdGen++,
                        Contenido=fComentario.tbComentario.Text,
                };
                comentarios.Add(nuevo);
                pintar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Evaluador evaluador = new Evaluador();
            evaluador.Evaluar(comentarios);
            pintar();
        }

        private void pintar()
        {
            dataGridView1.Rows.Clear();
            foreach (Comentario c in comentarios)
            {
                dataGridView1.Rows.Add(new object[] { c.Id, c.Contenido, c.Valoracion });
            }
        }

        private void imprimirListadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
                linea = 0;
            }
        }

        int linea = 10;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 12);
            Brush brush = new SolidBrush(Color.Black);
         
            float x=10, y=10;
            
            for(int n=linea,m=0 ; linea< comentarios.Count && m<2; n++, linea++,m++)
            {
                Comentario c = comentarios[n];
                g.DrawString(c.Id.ToString(),font, brush, x+10,y);
                g.DrawString(c.Contenido, font, brush, x + 60, y);
                g.DrawString(c.Valoracion.ToString(), font, brush, x + 200, y+=23);
            }

            if (linea >= comentarios.Count)
                e.HasMorePages = false;
            else
                e.HasMorePages = true;
        }
    }
}
