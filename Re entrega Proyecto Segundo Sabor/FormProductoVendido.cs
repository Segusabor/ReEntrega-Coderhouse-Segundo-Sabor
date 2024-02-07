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
    public partial class FormProductoVendido : Form
    {
        public FormProductoVendido()
        {
            InitializeComponent();
        }

        private void FormProductoVendido_Load(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            List<ProductoVendido> productoVendido = ProductoVendidoService.ObtenerTodosLosProductoVendido();
            this.ActualizarDgb(productoVendido);
        }
        private void ActualizarDgb(object objetos)
        {
            this.dgbProductoVendido.DataSource = null;
            this.dgbProductoVendido.DataSource = objetos;
        }

        private void btnBuscarId_Click(object sender, EventArgs e)
        {
            string idString = this.txtBuscarId.Text;
            if (!string.IsNullOrWhiteSpace(idString))
            {
                int id = Convert.ToInt32(idString);

                ProductoVendido productoVendidoBuscado = ProductoVendidoService.ObtenerProductoVendidoPorID(id);
                List<ProductoVendido> lista = new List<ProductoVendido>() { productoVendidoBuscado };
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

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }
    }
}
