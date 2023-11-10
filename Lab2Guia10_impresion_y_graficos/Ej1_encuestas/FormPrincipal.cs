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
        #region ya podría con esto podría armar una clase gestora/conteneroda
        List<Comentario> comentarios = new List<Comentario>();
        int IdGen;

        //creando mi primera consulta!
        public Dictionary<string, string> CantidadDeComentariosPorPuntaje()
        {
            Dictionary<string, string> lista = new Dictionary<string, string>();

            //inicio el diccionario
            for (int n = 0; n < 6; n++)
                lista[n.ToString()] = "0";

            //uso diccionario, es fantastico para agrupar datos.
            foreach (Comentario comentario in comentarios)
            {
                //hubiera sido mejor un diccionario con valor enteror, 
                                
                string valor = lista[comentario.Valoracion.ToString()];
                valor = (Convert.ToInt32(valor)+1).ToString();//esto es horrible, pero sino tengo mucho que cambiar.

                lista[comentario.Valoracion.ToString()] = valor;

            }

            return lista;
        }

        #endregion region

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            comentarios.Add(new Comentario { Id = IdGen++, Contenido = "Muy buen desarrollo" });
            comentarios.Add(new Comentario { Id = IdGen++, Contenido = "Fue terriblemente malo" });
            comentarios.Add(new Comentario { Id = IdGen++, Contenido = "Fue terriblemente bueno!" });
            comentarios.Add(new Comentario { Id = IdGen++, Contenido = "Es un producto con muy buenas prestaciones" });
            comentarios.Add(new Comentario { Id = IdGen++, Contenido = "Me resulto desepcionante, lo voy a devolver" });
            comentarios.Add(new Comentario { Id = IdGen++, Contenido = "No se lo recomiendo a nadie" });
            comentarios.Add(new Comentario { Id = IdGen++, Contenido = "Se lo he recomentado a todo el que pueda." });
            comentarios.Add(new Comentario { Id = IdGen++, Contenido = "Es increiblemente bueno" });
            comentarios.Add(new Comentario { Id = IdGen++, Contenido = "No esperaba tanto de este producto" });
            comentarios.Add(new Comentario { Id = IdGen++, Contenido = "La entrega fue horrible, estoy muy contento de haber devuelto este producto" });
            comentarios.Add(new Comentario { Id = IdGen++, Contenido = "Ya he encargado otro." });
            comentarios.Add(new Comentario { Id = IdGen++, Contenido = "Sin palabras!" });
            pintar();
        }

        private void btnAgregarComentario_Click(object sender, EventArgs e)
        {
            FormComentario fComentario = new FormComentario();
            if (fComentario.ShowDialog() == DialogResult.OK)
            {
                Comentario nuevo = new Comentario
                {
                    Id = IdGen++,
                    Contenido = fComentario.tbComentario.Text,
                };
                comentarios.Add(nuevo);
                pintar();
            }

            fComentario.Dispose();
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
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
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

            float x = 20, y = 40;

            Image image = Image.FromFile("../../recursos/img/logo.jpg");
            Rectangle rect = new Rectangle((int)x, (int)y, 50, 50);
            g.DrawImage(image, rect);

            y += 70;

            g.DrawString($"{"ID",-10}", font, brush, x + 10, y);
            g.DrawString($"{"COMENTARIO",-25}", font, brush, x + 50, y);
            g.DrawString($"{"VALORACIÓN",-10}", font, brush, x + 500, y);
            y += 20;

            g.DrawLine(pen, x + 10, y, x + 650, y);
            y += 5;

            for (int n = linea, m = 0; linea < comentarios.Count && m < cantXPagina; n++, linea++, m++)
            {
                Comentario c = comentarios[n];
                g.DrawString($"{c.Id.ToString(),-10}", font, brush, x + 10, y);

                string contenido = c.Contenido;
                if (contenido.Length > 25) contenido = contenido.Substring(0, 20);
                g.DrawString($"{contenido,-25}", font, brush, x + 50, y);

                g.DrawString($"{c.Valoracion.ToString(),10}", font, brush, x + 500, y);
                y += 20;
            }

            if (linea >= comentarios.Count)
                e.HasMorePages = false;
            else
                e.HasMorePages = true;
        }

        private void valorarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Evaluador evaluador = new Evaluador();
            evaluador.Evaluar(comentarios);
            pintar();
        }

        private void verÍndiceDeValoracionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVerDiagramaBarras fVer = new FormVerDiagramaBarras();


            #region prueba de concepto
            //Lista["0"] = "23";
            //Lista["1"] = "100";
            //Lista["2"] = "50";
            //Lista["3"] = "103";
            //Lista["4"] = "23";
            //Lista["5"] = "23";
            //Lista["6"] = "23";
            //fVer.Lista = this.Lista;
            #endregion

            //ahora me hice una consulta para sacar los datos de la fuente
            //me está quedando que el formulario hace de gestor de mis datos 
            //estaría bueno tener una clase sistema y pedir todo al sistema.
            fVer.Lista = CantidadDeComentariosPorPuntaje();

            //pasando los datos armaditos la ventana se encargará de dibujar esos datos

            fVer.Show();
        }

        private void índiceDeValoracionessectoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormVerDiagramaTorta fVer = new FormVerDiagramaTorta();

            //hacer consulta para llenar
            //falta las etiquetas con los porcentajes!

            //prueba de concepto
            fVer.Valores = new float[] { 180, 45, 90, 45 };
            fVer.Colores = new Color[] { Color.Red, Color.Blue, Color.Green, Color.White };

            //puedo pensar en seguirlo como lo he seguido con el diagrama de barras.

            fVer.Show();
        }
    }
}
