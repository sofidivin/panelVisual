using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panelVisual.Properties
{
    public class ProductoRepositorio
    {
        public static List<Producto> Productos { get; set; }

        public static void IniciarRepositorio()
        {
            Productos = new List<Producto>();   
        }

        public static void AgregarProducto(Producto prod)
        {
            Productos.Add(prod);
        }

        public static void EliminarProducto(int Id)
        {
            Productos.RemoveAll(e => e.Id.Equals(Id));
        }

        public static void EditarProducto(int Id, Producto prod)
        {
            int index = Productos.FindIndex(e => e.Id.Equals(Id));
            if (index != -1)
            {
                Productos[index] = prod;
            }
        }
    }
}
