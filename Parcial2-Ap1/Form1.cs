using Parcial2_Ap1.UI.Consultas;
using Parcial2_Ap1.UI.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial2_Ap1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RCategoriasForm frm = new RCategoriasForm();
            frm.Show();
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaForm frm = new ConsultaForm();
            frm.Show();


        }

        private void registroDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroForm frm = new RegistroForm();
            frm.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
