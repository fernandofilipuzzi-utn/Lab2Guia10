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
            linea = 0;
            if (printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        int linea = 0;
        int cantXPagina = 30;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font font = new Font("Arial", 12);
            Brush brush = new SolidBrush(Color.Black);
            Pen pen = new Pen(brush);
         
            float x=20, y=40;

            g.DrawString($"{"ID",-10}", font, brush, x+ 10, y);
            g.DrawString($"{"COMENTARIO",-25}", font, brush, x + 50, y);
            g.DrawString($"{"VALORACIÓN",-10}", font, brush, x + 500, y);
            y += 20;

            g.DrawLine(pen, x + 10,y, x + 650, y);
            y += 5;

            for (int n=linea,m=0 ; linea< comentarios.Count && m< cantXPagina; n++, linea++,m++)
            {
                Comentario c = comentarios[n];
                g.DrawString($"{c.Id.ToString(),-10}", font, brush,x+10,y);

                string contenido = c.Contenido;
                if (contenido.Length > 25) contenido=contenido.Substring(0, 20);
                g.DrawString($"{contenido,-25}", font, brush, x + 50, y);

                g.DrawString($"{c.Valoracion.ToString(),10}", font, brush, x + 500, y);
                y += 20;
            }

            if (linea >= comentarios.Count)
                e.HasMorePages = false;
            else
                e.HasMorePages = true;
        }
    }
}
