using Re_entrega_Proyecto_Segundo_Sabor.models;

namespace Re_entrega_Proyecto_Segundo_Sabor
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuario formUsuario = new FrmUsuario();
            formUsuario.ShowDialog();
            this.Hide();
            this.Show();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            FrmProducto productos = new FrmProducto();
            productos.ShowDialog();
            this.Hide();
            this.Show();
        }

        private void btnProductoVendido_Click(object sender, EventArgs e)
        {
            FormProductoVendido productosVendidos = new FormProductoVendido();
            //productosVendidos.ShowDialog();
            //this.Hide();
            //this.Show();
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {

        }
    }
}
