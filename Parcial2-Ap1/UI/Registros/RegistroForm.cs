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

namespace Parcial2_Ap1.UI.Registros
{
    public partial class RegistroForm : Form
    {
        public List<RDetalles> Detalles { get; set; }
        public RegistroForm()
        {
            InitializeComponent();
            this.Detalles = new List<RDetalles>();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            MyerrorProvider.Clear();
            IdnumericUpDown.Value = 0;
            EstudiantetextBox.Text = string.Empty;
            ServiciocomboBox.Text = string.Empty;

        }

        private void CargarGrid()
        {
            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = this.Detalles;
        }

        private void Removerbutton_Click(object sender, EventArgs e)
        {
            if(DetalledataGridView.Rows.Count>0 && DetalledataGridView.CurrentRow != null)
            {
                Detalles.RemoveAt(DetalledataGridView.CurrentRow.Index);
                CargarGrid();
            }
        }
    }
}
