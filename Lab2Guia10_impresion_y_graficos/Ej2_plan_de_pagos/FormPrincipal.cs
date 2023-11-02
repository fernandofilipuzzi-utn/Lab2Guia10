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
using CalendarioClassLib.Modelo;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Ej2_plan_de_pagos.Modelo;

namespace Ej1_plan_de_pagos
{
    public partial class FormPrincipal : Form
    {
        Municipalidad muni;
        string nombreFichero = "sistema.dat";

        Infractor infractorSelected = null;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            string path = Application.StartupPath;

            FileStream fs = null;
            try
            {
                string pathCompleto = Path.Combine(path, nombreFichero);

                if (File.Exists(pathCompleto))//cuando corre por primera vez, se supone que no existe
                {
                    fs = new FileStream(pathCompleto, FileMode.Open, FileAccess.Read);

                    if (fs.Length > 0) //normalmente cuando se crea el fichero y no se hace el close queda de tamaño cero.
                    {
                        BinaryFormatter bf = new BinaryFormatter();
                        muni = bf.Deserialize(fs) as Municipalidad;
                    }
                }
            }
            catch (Exception ex)
            {
                //si hubo cambios en las clases va a dar error de deserialización
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
            }

            //preinicialización
            if (muni == null)
            {
                muni = new Municipalidad();
            }
        }

        /*
        Forma alternativa - ojo aquí para programación 1
        private void btnAgregarFeriado_Click(object sender, EventArgs e)
        {
            FormDatosFeriado fDatoFeriado = new FormDatosFeriado();
            fDatoFeriado.Calendario = muni.Calendario;
            fDatoFeriado.ShowDialog();
        }
        */

        /*Forma recomendada*/
        private void btnAgregarFeriado_Click(object sender, EventArgs e)
        {
            FormDatosFeriado fDatoFeriado = new FormDatosFeriado();

            fDatoFeriado.ShowDialog();

            do
            {
                if (fDatoFeriado.DialogResult == DialogResult.OK)
                {
                    DateTime dia = fDatoFeriado.pickFecha.Value;
                    string descripcion = fDatoFeriado.tbDescripcion.Text;

                    muni.Calendario.AgregarFeriado(dia, descripcion);
                }
                else if (fDatoFeriado.DialogResult == DialogResult.Retry)
                {
                    DateTime dia = fDatoFeriado.pickFecha.Value;

                    Feriado feriado=muni.Calendario.Buscar(dia);
                    if (feriado != null)
                        fDatoFeriado.tbDescripcion.Text = feriado.Descripcion;
                    else
                        fDatoFeriado.tbDescripcion.Clear();
                }
                fDatoFeriado.ShowDialog();

            } while (fDatoFeriado.DialogResult!=DialogResult.Cancel);
        }

        private void btnCrearPlan_Click(object sender, EventArgs e)
        {
            FormEdicionPlan fPlan = new FormEdicionPlan();

            if (infractorSelected != null)
            {
                fPlan.tbDni.Text = infractorSelected.Dni.ToString();
                fPlan.tbApellidosYNombres.Text = infractorSelected.ApelldosYNombres.ToString();
                fPlan.tbApellidosYNombres.Enabled = false;
                fPlan.tbDni.Enabled = false;
            }
            else
            {
                fPlan.tbDni.Text = tbDni.Text;
                fPlan.tbApellidosYNombres.Enabled = true;
            }                

            if (fPlan.ShowDialog() == DialogResult.OK)
            {
                
                double monto = Convert.ToDouble(fPlan.tbMonto.Text);
                int cantCuotas = Convert.ToInt32(fPlan.nupCuotas.Value);
                DateTime fechaAltaPlan = fPlan.pickerInicio.Value;

                //lo agrega si no lo encontro 
                if (infractorSelected == null)
                {
                    int dni = Convert.ToInt32(fPlan.tbDni.Text);
                    string apellidoYNombre = fPlan.tbApellidosYNombres.Text;

                    infractorSelected = muni.AgregarInfractor(dni, apellidoYNombre);
                }

                PlanDePago nuevoPlan = muni.CrearPlanDePagos(infractorSelected.Dni, monto, cantCuotas, fechaAltaPlan);

                FormResumen fResumen = new FormResumen();
                fResumen.tbResumen.Text=nuevoPlan.VerDetalle();
                fResumen.ShowDialog();
                fResumen.Dispose();
            }
            
            fPlan.Dispose();
        }

        private void cerrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            string path = Application.StartupPath;

            FileStream fs = null;
            try
            {
                string pathCompleto = Path.Combine(path, nombreFichero);

                fs = new FileStream(pathCompleto, FileMode.OpenOrCreate, FileAccess.Write);
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(fs, muni);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (fs != null) fs.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbDni.Text.Trim())==false)
            {
                int dni = Convert.ToInt32(tbDni.Text);

                infractorSelected = muni.BuscarInfractor(dni);

                if (infractorSelected != null)
                {
                    tbApellidosYNombres.Text = infractorSelected.ApelldosYNombres;
                    btnCrearPlan.Enabled = true;

                    cbPlanesDelInfractor.Enabled = true;
                    List<PlanDePago> planes=muni.VerPlanesDelInfractor(dni);
                    cbPlanesDelInfractor.Items.AddRange(planes.ToArray());
                }
                else
                {
                    tbApellidosYNombres.Text = "";
                    tbApellidosYNombres.Enabled = false;
                    btnCrearPlan.Enabled = true;
                }
            }
        }

        private void btnConsultarPlanes_Click(object sender, EventArgs e)
        {
            PlanDePago selected=cbPlanesDelInfractor.SelectedItem as PlanDePago;
            if (selected != null)
            {
                FormResumen fResumen = new FormResumen();
                fResumen.tbResumen.Text = selected.VerDetalle();
                fResumen.ShowDialog();
                fResumen.Dispose();
            }
        }

        private void tbDni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void importraciónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> listado = new List<string>();

            openFileDialog1.Filter = "archivo csv (*.csv)|*.csv|archivo texto plano(*.txt) | *.txt | otros(*.*) | *.* ";
            openFileDialog1.FilterIndex = 1;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamReader sr = null;
                try
                {
                    string path = openFileDialog1.FileName;

                    //creamos el manejador
                    fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read);

                    //flujo de texto
                    sr = new StreamReader(fs);

                    //ciclo de lectura
                    while(sr.EndOfStream==false)
                    {
                        string linea=sr.ReadLine();
                        listado.Add(linea);
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error en el proceso de importación.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    //cerrando el flujo
                    if (fs != null)
                    {
                        if (sr != null) sr.Close();
                        fs.Close();
                    }
                }
            }

            try
            {
                muni.ImportarInfracciones(listado);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.Replace("\r\n","|"));
            }
        }

        private void btnClearBackColor_TextChanged(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if (btn != null)
                btn.BackColor = Color.White;
        }

        private void exportarPlanesDePagoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<string> listado = new List<string>();

            saveFileDialog1.Filter = "archivo csv (*.csv)|*.csv|archivo texto plano(*.txt) | *.txt | otros(*.*) | *.* ";
            saveFileDialog1.FilterIndex = 1;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = null;
                StreamWriter sw = null;
                try
                {
                    string path = saveFileDialog1.FileName;

                    //creamos el manejador
                    fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Write);

                    //flujo de texto
                    sw = new StreamWriter(fs);

                    //ciclo de escritura
                    string linea = "";

                    #region creando la cabecera
                    linea = $"Infractor; DNI; Apellido Y Nombre";
                    sw.WriteLine(linea);
                    linea = $"PlanDePago; Monto; Cantidad Cuotas; Fecha de Alta; Monto Financiado";
                    sw.WriteLine(linea);
                    linea = $"Cuota; numero; Monto Base; Porc. Pago Voluntario; Monto Voluntario; Fecha Primer venc.; Fecha Seg. Venc.;  Sobrecargo; Monto Segundo Vencimiento";
                    sw.WriteLine(linea);
                    #endregion

                    for (int n=0; n<muni.CantidadInfractores; n++)
                    {
                        Infractor infr = muni.VerInfractor(n);

                        linea =$"{ "Infractor"}; {infr.Dni.ToString()}; {infr.ApelldosYNombres}";
                        sw.WriteLine(linea);

                        foreach(PlanDePago plan in muni.VerPlanesDelInfractor(infr.Dni))
                        {
                            linea = $"{"PlanDePago"};{plan.Monto.ToString("0.00")};{plan.CantidadCuotas};" +
                                        $"{plan.FechaAlta:dd/MM/yyyy};{plan.MontoTotalFinanciado:f2}";
                            sw.WriteLine(linea);

                            for (int m=0; m<plan.CantidadCuotas; m++)
                            {
                                Cuota cuota = plan.VerCuota(m);
                                linea = $"Cuota;{cuota.Numero};{cuota.MontoBase:f2};{cuota.PorcenVoluntario}" +
                                    $"{cuota.FechaPrimerVenc:dd/MM/yyyy};{cuota.FechaSegundoVenc:dd/MM/yyyy};" +
                                    $"{cuota.SobreCargoMontoSegundoVenc};{cuota.MontoSegundoVenc}";
                                sw.WriteLine(linea);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error en el proceso de exportación.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    //cerrando el flujo
                    if (fs != null)
                    {
                        if (sw != null) sw.Close();
                        fs.Close();
                    }
                }
            }
        }
    }
}
