using Microsoft.EntityFrameworkCore;
using Re_entrega_Proyecto_Segundo_Sabor.database;
using Re_entrega_Proyecto_Segundo_Sabor.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Re_entrega_Proyecto_Segundo_Sabor.service
{
    public static class ProductoService
    {

        public static List<Producto> ObtenerTodosLosProductos()
        {
            using (CoderContext contexto = new CoderContext())
            {
                List<Producto> productos = contexto.Productos.ToList();
                return productos;
            }
        }

        public static Producto ObtenerProductoPorID(int id)
        {
            using (CoderContext contexto = new CoderContext())
            {
                Producto? productoBuscado = contexto.Productos.Where(p => p.Id == id).FirstOrDefault();
                return productoBuscado;
            }
        }
        public static bool AgregarProducto(Producto producto)
        {
            using (CoderContext contexto = new CoderContext())
            {
                contexto.Productos.Add(producto);
                contexto.SaveChanges();
                return true;
            }
        }




        public static bool EliminarPorId(int id)
        {
            using (CoderContext contexto = new CoderContext())
            {
                Producto productoAEliminar = contexto.Productos.Include(p => p.ProductoVendidos).Where(p => p.Id == id).FirstOrDefault();
                if (productoAEliminar is not null)
                {
                    contexto.Productos.Remove(productoAEliminar);
                    contexto.SaveChanges();
                    return true;
                }

            }
            return false;
        }
        public static bool ActualizarProductoPorId(Producto producto, int id)
        {

            using (CoderContext contexto = new CoderContext())
            {
                Producto? productoBuscado = contexto.Productos.Where(p => p.Id == id).FirstOrDefault();


                productoBuscado.Descripciones = producto.Descripciones;
                productoBuscado.Costo = producto.Costo;
                productoBuscado.PrecioVenta = producto.PrecioVenta;
                productoBuscado.Stock = producto.Stock;

                contexto.Productos.Update(productoBuscado);

                contexto.SaveChanges();

                return true;
            }

        }
    }
}
