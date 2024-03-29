﻿using Parcial2_Ap1.BLL;
using Parcial2_Ap1.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_Ap1.UI.Consultas
{
    public partial class ConsultaForm : Form
    {
        public ConsultaForm()
        {
            InitializeComponent();
        }

        private void Consultarbutton_Click(object sender, EventArgs e)
        {
            ERepositorio repositorio = new ERepositorio();
            List<Estudiantes> listado = new List<Estudiantes>();

            if (CriteriotextBox.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox.SelectedIndex)
                {
                    case 0://Todos
                        listado = repositorio.GetList(p => true);
                        break;

                    case 1://Id
                        int id = Convert.ToInt32(CriteriotextBox.Text);
                        listado = repositorio.GetList(p => p.EstudianteId == id);
                        break;

                    case 2://Estudiante
                        listado = repositorio.GetList(p => p.Estudiante.Contains(CriteriotextBox.Text));
                        break;

                    case 3://Total
                        decimal total = Convert.ToDecimal(CriteriotextBox.Text);
                        listado = repositorio.GetList(p => p.Total == total);
                        break;
                }

                listado = listado.Where(c => c.Fecha.Date >= DesdedateTimePicker.Value.Date && c.Fecha.Date <= HastadateTimePicker.Value.Date).ToList();
            }
            else
            {
                listado = repositorio.GetList(p => true);
            }

            ConsultadataGridView.DataSource = null;
            ConsultadataGridView.DataSource = listado;
        }
    }
}
