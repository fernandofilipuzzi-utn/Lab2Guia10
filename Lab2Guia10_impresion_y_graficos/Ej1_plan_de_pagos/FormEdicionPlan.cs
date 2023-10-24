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
    public partial class FormEdicionPlan : Form
    {
        public FormEdicionPlan()
        {
            InitializeComponent();
        }

        private void btnCrearPlan_Click(object sender, EventArgs e)
        {
            Validar();
        }

        private void tbApellidosYNombres_KeyPress(object sender, KeyPressEventArgs e)
        {
            tbApellidosYNombres.BackColor = Color.White;
        }

        private void tbMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) || e.KeyChar == ',' ||
                    char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        public bool Validar()
        {
            bool isNoOk = false;

            if (string.IsNullOrEmpty(tbDni.Text.Trim()) == true)
            {
                isNoOk |= true;
                tbDni.BackColor = Color.Orange;
            }

            if (string.IsNullOrEmpty(tbApellidosYNombres.Text.Trim()) == true)
            {
                isNoOk |= true;
                tbApellidosYNombres.BackColor = Color.Orange;
            }

            if (string.IsNullOrEmpty(tbMonto.Text.Trim()) == true)
            {
                isNoOk |= true;
                tbMonto.BackColor = Color.Orange;
            }

            return isNoOk == false;
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

        private void btnClearBackColor_TextChanged(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            if(btn !=null)
                btn.BackColor = Color.White;
        }

        private void nupCuotas_ValueChanged(object sender, EventArgs e)
        {
            nupCuotas.BackColor = Color.White;
        }
    }
}
