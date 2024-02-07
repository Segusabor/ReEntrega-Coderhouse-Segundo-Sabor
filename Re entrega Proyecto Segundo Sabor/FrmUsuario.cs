using Re_entrega_Proyecto_Segundo_Sabor.models;
using Re_entrega_Proyecto_Segundo_Sabor.service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Re_entrega_Proyecto_Segundo_Sabor
{
    public partial class FrmUsuario : Form
    {
        Usuario usuarioSeleccionado;
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<Usuario> usuarios = UsuarioService.ObtenerTodosLosUsuarios();
            this.ActualizarDgb(usuarios);
        }
        private void ActualizarDgb(object objetos)
        {
            this.dgbUsuario.DataSource = null;
            this.dgbUsuario.DataSource = objetos;
        }
        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            string idString = this.txtBuscarId.Text;
            if (!string.IsNullOrWhiteSpace(idString))
            {
                int id = Convert.ToInt32(idString);

                Usuario usuarioBuscado = UsuarioService.ObtenerUsuarioPorID(id);
                List<Usuario> lista = new List<Usuario>() { usuarioBuscado };
                this.ActualizarDgb(lista);
            }
            else
            {
                MessageBox.Show("Complete id", "Error");
                this.txtBuscarId.Focus();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AMBUsuario frmAlta = new AMBUsuario();
            frmAlta.ShowDialog();
            this.Hide();
            this.Show();

            Usuario usuario = frmAlta.UsuarioCreado;
            if (UsuarioService.AgregarUsuario(usuario))
            {
                MessageBox.Show("Agregue Usuario");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string idString = this.txtBuscarId.Text;
            if (!string.IsNullOrWhiteSpace(idString))
            {
                int id = Convert.ToInt32(idString);
                bool resultado = UsuarioService.EliminarUsuario(id);

                if (resultado)
                {
                    MessageBox.Show("Usuario Eliminado");
                }

            }
            else
            {
                MessageBox.Show("Complete id", "Error");
                this.txtBuscarId.Focus();
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            AMBUsuario frm = new AMBUsuario(this.usuarioSeleccionado);
            frm.ShowDialog();
            Usuario usuarioModificado = frm.UsuarioCreado;

            if (UsuarioService.ActualizarUsuarioPorId(usuarioModificado,
                this.usuarioSeleccionado.Id))
            {
                MessageBox.Show("Actualice");
            }
        }
        private void dgbUsuario_SelectionChanged(object sender, EventArgs e)
        {
            var seleccion = this.dgbUsuario.SelectedRows;
            if (seleccion.Count > 0)
            {
                object dato = seleccion[0].DataBoundItem;

                this.usuarioSeleccionado = dato as Usuario;
            }
        }
    }
}
