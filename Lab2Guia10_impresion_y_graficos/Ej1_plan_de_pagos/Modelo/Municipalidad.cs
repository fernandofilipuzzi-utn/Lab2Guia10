using CalendarioClassLib.Modelo;
using Ej1.Modelo.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej1_plan_de_pagos.Modelo
{
    [Serializable]
    class Municipalidad
    {
        public Calendario Calendario { get; set; } = new Calendario();

        List<PlanDePago> planes= new List<PlanDePago>(); 
        List<Infractor> infractores = new List<Infractor>();

        public Municipalidad()
        {
        }

        public Infractor BuscarInfractor(int dni)
        {
            infractores.Sort();
            int idx = infractores.BinarySearch(new Infractor(dni));

            Infractor buscado = null;
            if (idx >= 0) buscado = infractores[idx];

            return buscado;
        }

        public Infractor AgregarInfractor(int dni, string nombre)
        {
            Infractor nuevo = new Infractor(dni, nombre);
            infractores.Add(nuevo);
            return nuevo;
        }

        public PlanDePago CrearPlanDePagos(int dni, double monto, int cantCuotas,DateTime fechaAltaPlan)
        {
            PlanDePago nuevo = null;
            Infractor destinatario = BuscarInfractor(dni);
            if (destinatario != null)
            {
                nuevo = new PlanDePago(monto, cantCuotas, fechaAltaPlan, destinatario, Calendario);
                planes.Add(nuevo);
            }
            else 
            {
                throw new Exception($"Error al crear ale plan, infractor no encontrado (dni:{dni})");
            }

            return nuevo;
        }

        public void ImportarInfracciones(List<string> lista)
        {
            List<string []> importados = new List<string []>();

            for (int linea = 1; linea < lista.Count; linea++)
            {
                string[] campos = lista[linea].Split(';');

                string dni = campos[0];
                string apellidoYNombre = campos[1];
                string telefono = campos[2];
                string email = campos[3];
                string monto = campos[4];

                try
                {
                    dni = Validator.NormalizarYValidarDNI(dni);
                    apellidoYNombre = Validator.NormalizarYValidarApellidoYNombre(apellidoYNombre);
                    telefono = Validator.NormalizarYValidarTelefono(telefono);
                    email = Validator.NormalizarYValidarEmail(email);
                    monto = Validator.NormalizarYValidarDecimal(monto);

                    importados.Add( new string[] { dni, apellidoYNombre, telefono, email, monto} );
                }
                catch (Exception ex)
                {
                    throw new Exception($"Error en línea {linea + 1}", ex);
                }
            }

            //si el listado fue ok se ingresa
            //normalmente por simplicidad se hace este proceso todo en un solo bucle.
            //aquí se dividió en tres fases, lectura, validación y la importación propiamente.
            foreach (string[] reg in importados)
            {
                int dni = Convert.ToInt32(reg[0]);
                string apellidoYNombre = reg[1];
                double monto = Convert.ToDouble(reg[4]);
                int cantCuotas = 1;
                DateTime hoy = DateTime.Today;

                //conviene trabajar con un sortedlist
                infractores.Sort();
                int idx = infractores.BinarySearch(new Infractor(dni));

                if (idx <= -1)
                {
                    this.AgregarInfractor( dni, apellidoYNombre);
                }
                this.CrearPlanDePagos(dni, monto, cantCuotas, hoy);
            }
        }

        public List<PlanDePago> VerPlanesDelInfractor(int dni)
        {
            List<PlanDePago> planesDelInfractor = new List<PlanDePago>();
            foreach (PlanDePago plan in planes)
            {
                if (plan.Destinatario.Dni == dni)
                    planesDelInfractor.Add(plan);
            }
            return planesDelInfractor;
        }

        public int CantidadInfractores { get { return infractores.Count; } }
        public Infractor VerInfractor(int idx)
        {
            return infractores[idx];
        }
    }
 }
