using Re_entrega_Proyecto_Segundo_Sabor.models;
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
    public partial class AMBUsuario : Form
    {
        public AMBUsuario()
        {
            InitializeComponent();
        }
        public AMBUsuario(Usuario usuario) : this()
        {
            this.txtNombre.Text = usuario.Nombre;
            this.txtApellido.Text = usuario.Apellido;
            this.txtNombreUsuario.Text = usuario.NombreUsuario;
            this.txtMail.Text = usuario.Mail;
            this.txtContraseña.Text = usuario.Contraseña;
        }
        private void AMBUsuario_Load(object sender, EventArgs e)
        {

        }
        public Usuario UsuarioCreado { get; private set; }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario()
            {
                Apellido = this.txtApellido.Text,
                Nombre = this.txtNombre.Text,
                Contraseña = txtContraseña.Text,
                NombreUsuario = txtNombreUsuario.Text,
                Mail = txtMail.Text
            };
            this.UsuarioCreado = usuario;
            this.Close();
        }
    }
}
