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
    public partial class AMBProducto : Form
    {
        public AMBProducto()
        {
            InitializeComponent();
        }
        public AMBProducto(Producto producto) : this()
        {
            this.txtDescripciones.Text = producto.Descripciones;
            this.txtCosto.Text = Convert.ToString(producto.Costo);
            this.txtPrecioVenta.Text = Convert.ToString(producto.PrecioVenta);
            this.txtStock.Text = Convert.ToString(producto.Stock);

        }
        public Producto ProductoCreado { get; private set; }
        private void AMBProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto()
            {
                Descripciones = txtDescripciones.Text,
                Stock = int.Parse(txtStock.Text),
                Costo = int.Parse(txtCosto.Text),
                PrecioVenta = int.Parse(txtPrecioVenta.Text),


            };
            this.ProductoCreado = producto;
            this.Close();
        }
    }
}
