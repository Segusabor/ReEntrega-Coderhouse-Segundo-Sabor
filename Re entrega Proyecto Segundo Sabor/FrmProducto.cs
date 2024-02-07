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
    public partial class FrmProducto : Form
    {
        Producto productoSeleccionado;
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<Producto> productos = ProductoService.ObtenerTodosLosProductos();
            this.ActualizarDgb(productos);
        }
        private void ActualizarDgb(object objetos)
        {
            this.dgbProducto.DataSource = null;
            this.dgbProducto.DataSource = objetos;
        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            string idString = this.txtBuscarId.Text;
            if (!string.IsNullOrWhiteSpace(idString))
            {
                int id = Convert.ToInt32(idString);

                Producto productoBuscado = ProductoService.ObtenerProductoPorID(id);
                List<Producto> lista = new List<Producto>() { productoBuscado };
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
            AMBProducto frmAlta = new AMBProducto();
            frmAlta.ShowDialog();
            this.Hide();
            this.Show();

            Producto producto = frmAlta.ProductoCreado;
            if (ProductoService.AgregarProducto(producto))
            {
                MessageBox.Show("Agregue un producto");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string idString = this.txtBuscarId.Text;
            if (!string.IsNullOrWhiteSpace(idString))
            {
                int id = Convert.ToInt32(idString);
                bool resultado = ProductoService.EliminarPorId(id);

                if (resultado)
                {
                    MessageBox.Show("Producto Eliminado");
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
            AMBProducto frm = new AMBProducto(this.productoSeleccionado);
            frm.ShowDialog();
            Producto productoModificado = frm.ProductoCreado;

            if (ProductoService.ActualizarProductoPorId(productoModificado,
                this.productoSeleccionado.Id))
            {
                MessageBox.Show("Actualice");
            }
        }
        private void dgbProducto_SelectionChanged(object sender, EventArgs e)
        {
            var seleccion = this.dgbProducto.SelectedRows;
            if (seleccion.Count > 0)
            {
                object dato = seleccion[0].DataBoundItem;

                this.productoSeleccionado = dato as Producto;
            }
        }
    }
}
