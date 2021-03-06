﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Clase08.Entidades_alumnos_;

namespace Clase08.WF_alumnos_
{
    public partial class FrmCatedra : Form
    {
         Catedra catedra=new Catedra();

         List<AlumnoCalificado> listMiAlumos=new List<AlumnoCalificado>();

        public FrmCatedra()
        {
            InitializeComponent();

            //this.catedra = new Catedra();

            foreach(ETipoOrdenamiento tipo in ETipoOrdenamiento.GetValues(typeof(ETipoOrdenamiento)))
            {
                this.cmbTipoOrden.Items.Add(tipo);
            }

            this.cmbTipoOrden.SelectedItem = ETipoOrdenamiento.ApellidoAscendente;
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            FrmAlumno frmAlumo = new FrmAlumno();
            Alumnos newAlumno;
            frmAlumo.ShowDialog();
            bool flagLegajo = false;//bandera para existencia de legajo

            if (frmAlumo.DialogResult == DialogResult.OK)
            {
                newAlumno = frmAlumo.GetAlumnos;
                foreach(Alumnos a in catedra.Alumnos)
                {
                    if (a.Legajo == newAlumno.Legajo)
                    {
                        flagLegajo = true;
                        break;
                    }
                }

                if (flagLegajo == false)
                {
                    catedra.Alumnos.Add(newAlumno);
                    //lo agrego a la lista con una funcion
                    ponerEnLista();
                }
                else
                {
                    MessageBox.Show("Legajo existente");
                }
            }
        }

        /// <summary>
        /// Refresca pantalla
        /// </summary>
        private void listar()
        {
            this.listAlumnos.Items.Clear();
            foreach(Alumnos a in catedra.Alumnos)
            {
                //this.listAlumnos.Items.Add(Alumnos.Mostrar(a));
                this.listAlumnos.Items.Add(a.Tostring());
            }
            this.listAlumnosCalificados.Items.Clear();
            for(int i = 0; i < listMiAlumos.Count; i++)
            {
                //this.listAlumnosCalificados.Items.Add(listMiAlumos[i].Tostring());
                this.listAlumnosCalificados.Items.Add(listMiAlumos[i].Mostrar());
            }


        }

        private void ponerEnLista()
        {
            switch (this.cmbTipoOrden.SelectedItem)
            {
                case ETipoOrdenamiento.ApellidoAscendente:
                    catedra.Alumnos.Sort(Alumnos.OrdenarPorApelidoAsc);
                    listar();
                    break;

                case ETipoOrdenamiento.ApellidoDescendente:
                    catedra.Alumnos.Sort(Alumnos.OrdenarPorApellidoDesc);
                    listar();
                    break;

                case ETipoOrdenamiento.LegajoAscndente:
                    catedra.Alumnos.Sort(Alumnos.OrdenarPorLegajoAsc);
                    listar();
                    break;

                case ETipoOrdenamiento.LegajoDescendente:
                    catedra.Alumnos.Sort(Alumnos.OrdenarPorLegajoADesc);
                    listar();
                    break;
            }
        }

        private void cmbTipoOrden_SelectedIndexChanged(object sender, EventArgs e)
        {
            ponerEnLista();

        }

        private void buttonCalificar_Click(object sender, EventArgs e)
        {
            int indiceSeleccionado = listAlumnos.SelectedIndex;

            if (indiceSeleccionado >= 0)
            {
                FrmAlumnoCalificado AlumCalificado = new FrmAlumnoCalificado(catedra.Alumnos[indiceSeleccionado]);

                AlumCalificado.ShowDialog();
                if (AlumCalificado.DialogResult == DialogResult.OK)
                {
                    catedra.Alumnos.RemoveAt(indiceSeleccionado);

                    listMiAlumos.Add(AlumCalificado.GetAlumnoNota);

                    listar();
                }
            }       
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            int indiceSeleccionado = listAlumnos.SelectedIndex;

            if (indiceSeleccionado >= 0)
            {
                FrmAlumno AlumModifico = new FrmAlumno(catedra.Alumnos[indiceSeleccionado]);

                AlumModifico.ShowDialog();
                if (AlumModifico.DialogResult == DialogResult.OK)
                {
                    catedra.Alumnos.RemoveAt(indiceSeleccionado);
                    catedra.Alumnos.Insert(indiceSeleccionado, AlumModifico.alumno);
                    

                    listar();
                }
            }
        }
    }



}
