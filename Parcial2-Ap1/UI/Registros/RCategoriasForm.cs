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
    public partial class RCategoriasForm : Form
    {
        public RCategoriasForm()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            MyerrorProvider.Clear();
        }

        private Categorias LlenaClase()
        {
            Categorias categoria = new Categorias();

            categoria.CategoriaId = (int)IdnumericUpDown.Value;
            categoria.Descripcion = DescripciontextBox.Text;

            return categoria;
        }

        private void LlenaCampos(Categorias categoria)
        {
            IdnumericUpDown.Value = categoria.CategoriaId;
            DescripciontextBox.Text = categoria.Descripcion;
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            Categorias categoria = repositorio.Buscar((int)IdnumericUpDown.Value);

            return (categoria != null);
        }

        private bool Validar()
        {
            bool paso = true;
            MyerrorProvider.Clear();

            if (string.IsNullOrWhiteSpace(DescripciontextBox.Text))
            {
                MyerrorProvider.SetError(DescripciontextBox, "El campo Descripcion no puede estar vacio");
                DescripciontextBox.Focus();
                paso = false;
            }

            return paso;
        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            Categorias categoria;
            bool paso = false;

            if (!Validar())
                return;

            categoria = LlenaClase();

            if (IdnumericUpDown.Value == 0)
                paso = repositorio.Guardar(categoria);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("¡No se puede modificar un registro que no existe!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                paso = repositorio.Modificar(categoria);
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("¡Guardado exitosamente!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("¡No fue posible guardar!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            int id;
            Categorias categoria = new Categorias();
            int.TryParse(Convert.ToString(IdnumericUpDown.Value), out id);

            Limpiar();

            categoria = repositorio.Buscar(id);

            if (categoria != null)
                LlenaCampos(categoria);
            else
                MessageBox.Show("Registro no encontrado", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            MyerrorProvider.Clear();
            RepositorioBase<Categorias> repositorio = new RepositorioBase<Categorias>();
            int id;
            int.TryParse(Convert.ToString(IdnumericUpDown.Value), out id);

            Limpiar();

            if (repositorio.Eliminar(id))
                MessageBox.Show("¡Eliminado!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MyerrorProvider.SetError(IdnumericUpDown, "No se puede eliminar un registro que no existe");
        }

        private void RCategoriasForm_Load(object sender, EventArgs e)
        {

        }
    }
}
