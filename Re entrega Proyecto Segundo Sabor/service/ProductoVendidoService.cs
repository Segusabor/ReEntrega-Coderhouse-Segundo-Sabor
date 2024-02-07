using Re_entrega_Proyecto_Segundo_Sabor.database;
using Re_entrega_Proyecto_Segundo_Sabor.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re_entrega_Proyecto_Segundo_Sabor.service
{
    internal class ProductoVendidoService
    {
        public static List<ProductoVendido> ObtenerTodosLosProductoVendido()
        {
            using (CoderContext contexto = new CoderContext())
            {
                List<ProductoVendido> productoVendido = contexto.ProductoVendido.ToList();
                return productoVendido;
            }
        }
    }
}
