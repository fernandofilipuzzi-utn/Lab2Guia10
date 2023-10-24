using CalendarioClassLib.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej1_plan_de_pagos
{
    public partial class FormDatosFeriado : Form
    {
        public Calendario Calendario { get; set; }

        public FormDatosFeriado()
        {
            InitializeComponent();
        }

        private void FormDatosFeriado_Load(object sender, EventArgs e)
        {
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool isNoOk = false;

            if (string.IsNullOrEmpty(tbDescripcion.Text.Trim()) == true)
            {
                isNoOk |= true;
                tbDescripcion.BackColor = Color.Orange;
            }

            if (isNoOk == false)
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.None;
        }

        private void tbDescripcion_TextChanged(object sender, EventArgs e)
        {
            tbDescripcion.BackColor = Color.White;
        }

        private void pickFecha_ValueChanged(object sender, EventArgs e)
        {
            pickFecha.BackColor = Color.White;

            DialogResult = DialogResult.Retry;
        }

        /*
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool isNoOk = false;

            if (string.IsNullOrEmpty(tbDescripcion.Text.Trim()) == true)
            {
                isNoOk |= true;
                tbDescripcion.BackColor = Color.Orange;
            }

            if (isNoOk == false)
            {
                DateTime dia = pickFecha.Value;
                string descripcion = tbDescripcion.Text;

                Calendario.AgregarFeriado(dia, descripcion);
            }

            if (isNoOk == false)
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.None;
        }

        private void tbDescripcion_TextChanged(object sender, EventArgs e)
        {
            tbDescripcion.BackColor = Color.White;
        }

        private void pickFecha_ValueChanged(object sender, EventArgs e)
        {
            pickFecha.BackColor = Color.White;

            DateTime selectedDate = pickFecha.Value;

            Feriado consulta = Calendario.Buscar(selectedDate);

            if (consulta != null)
                tbDescripcion.Text = consulta.Descripcion;
        }
        */
    }
}
