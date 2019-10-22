using Parcial2_Ap1.BLL;
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
        public List<CategoriasDetalle> Detalle { get; set; }
        public RegistroForm()
        {
            InitializeComponent();
            this.Detalle = new List<CategoriasDetalle>();
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            FechadateTimePicker.Value = DateTime.Now;
            EstudiantetextBox.Text = string.Empty;
            CategoriacomboBox.ResetText();
            CantidadnumericUpDown.Value = 0;
            PrecionumericUpDown.Value = 0;
            ImportetextBox.Text = string.Empty;
            TotaltextBox.Text = "0.00";
            MyerrorProvider.Clear();
            this.Detalle = new List<CategoriasDetalle>();
            CargarGrid();
        }

        private Estudiantes LlenaClase()
        {
            Estudiantes estudiante = new Estudiantes();

            estudiante.EstudianteId = (int)IdnumericUpDown.Value;
            estudiante.Fecha = FechadateTimePicker.Value;
            estudiante.Estudiante = EstudiantetextBox.Text;
            estudiante.Total = Convert.ToDecimal(TotaltextBox.Text);
            estudiante.Categorias = this.Detalle;

            return estudiante;
        }

        private void LlenaCampo(Estudiantes estudiante)
        {
            IdnumericUpDown.Value = estudiante.EstudianteId;
            FechadateTimePicker.Value = estudiante.Fecha;
            EstudiantetextBox.Text = estudiante.Estudiante;
            TotaltextBox.Text = Convert.ToString(estudiante.Total);
            this.Detalle = estudiante.Categorias;
            CargarGrid();
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            ERepositorio repositorio = new ERepositorio();
            Estudiantes estudiante = new Estudiantes();

            estudiante = repositorio.Buscar((int)IdnumericUpDown.Value);

            return (estudiante != null);
        }

        private bool Validar()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(EstudiantetextBox.Text))
            {
                MyerrorProvider.SetError(EstudiantetextBox, "El campo Estudiante no puede estar vacio");
                EstudiantetextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private bool ValidarCamposDetalle()
        {
            bool paso = true;

            if (string.IsNullOrWhiteSpace(CategoriacomboBox.Text))
            {
                MyerrorProvider.SetError(CategoriacomboBox, "El campo Categoria no puede estar vacio");
                CategoriacomboBox.Focus();
                paso = false;
            }

            if (CantidadnumericUpDown.Value == 0)
            {
                MyerrorProvider.SetError(CantidadnumericUpDown, "El campo Cantidad no puede ser cero");
                CantidadnumericUpDown.Focus();
                paso = false;
            }

            if (PrecionumericUpDown.Value == 0)
            {
                MyerrorProvider.SetError(PrecionumericUpDown, "El campo Precio no puede ser cero");
                PrecionumericUpDown.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(ImportetextBox.Text))
            {
                MyerrorProvider.SetError(ImportetextBox, "El campo Importe no puede ser cero");
                ImportetextBox.Focus();
                paso = false;
            }

            return paso;
        }






        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            ERepositorio repositorio = new ERepositorio();
            Estudiantes estudiante = new Estudiantes();
            int id;
            int.TryParse(Convert.ToString(IdnumericUpDown.Value), out id);

            Limpiar();

            estudiante = repositorio.Buscar(id);

            if (estudiante != null)
                LlenaCampo(estudiante);
            else
                MessageBox.Show("Registro no encontrado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void CargarGrid()
        {
            DetalledataGridView.DataSource = null;
            DetalledataGridView.DataSource = this.Detalle;
        }

        private void Removerbutton_Click(object sender, EventArgs e)
        {
            if (DetalledataGridView.Rows.Count > 0 && DetalledataGridView.CurrentRow != null)
            {
                this.Detalle.RemoveAt(DetalledataGridView.CurrentRow.Index);
                CargarGrid();
            }
        }

        private void RegistroForm_Load(object sender, EventArgs e)
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            List<Categorias> categoria = new List<Categorias>();

            categoria = repositorio.GetList(p => true).ToList();

            foreach (var item in categoria)
            {
                CategoriacomboBox.Items.Add(item.Descripcion);
            }

            TotaltextBox.Text = "0.00";
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            bool paso = false;
            Estudiantes estudiante;
            ERepositorio repositorio = new ERepositorio();

            if (!Validar())
                return;

            estudiante = LlenaClase();

            if (IdnumericUpDown.Value == 0)
                paso = repositorio.Guardar(estudiante);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un registro que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(estudiante);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No fue posible guardar", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            ERepositorio repositorio = new ERepositorio();
            int id;
            int.TryParse(Convert.ToString(IdnumericUpDown.Value), out id);

            Limpiar();

            if (repositorio.Eliminar(id))
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MyerrorProvider.SetError(IdnumericUpDown, "No fue posible eliminar");
        }

        private void Sbutton_Click(object sender, EventArgs e)
        {
            if (DetalledataGridView.DataSource != null)
                this.Detalle = (List<CategoriasDetalle>)DetalledataGridView.DataSource;

            if (!ValidarCamposDetalle())
                return;

            this.Detalle.Add(new CategoriasDetalle
                            (CategoriaDetalleId: 0,
                             EstudianteId: (int)IdnumericUpDown.Value,
                             NombreCategoria: CategoriacomboBox.Text,
                             Cantidad: Convert.ToInt32(CantidadnumericUpDown.Value),
                             Precio: PrecionumericUpDown.Value,
                             Importe: Convert.ToDecimal(ImportetextBox.Text)
                            ));

            CargarGrid();
            TotaltextBox.Text = Convert.ToString(Convert.ToDecimal(TotaltextBox.Text) + Convert.ToDecimal(ImportetextBox.Text));
            CategoriacomboBox.Focus();
            CategoriacomboBox.Text = string.Empty;
            CantidadnumericUpDown.Value = 0;
            PrecionumericUpDown.Value = 0;
            ImportetextBox.Text = string.Empty;
        }

        private void ImportetextBox_TextChanged(object sender, EventArgs e)
        {
            if (CantidadnumericUpDown.Value != 0 && PrecionumericUpDown.Value != 0)
                ImportetextBox.Text = Convert.ToString(CantidadnumericUpDown.Value * PrecionumericUpDown.Value);
        }

        private void CantidadnumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (PrecionumericUpDown.Value == 0)
                ImportetextBox.Text = Convert.ToString(CantidadnumericUpDown.Value);
            else
                ImportetextBox.Text = Convert.ToString(CantidadnumericUpDown.Value * PrecionumericUpDown.Value);
        }

        private void PrecionumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            if (CantidadnumericUpDown.Value == 0)
                ImportetextBox.Text = Convert.ToString(PrecionumericUpDown.Value);
            else
                ImportetextBox.Text = Convert.ToString(CantidadnumericUpDown.Value * PrecionumericUpDown.Value);
        }
    }
}
