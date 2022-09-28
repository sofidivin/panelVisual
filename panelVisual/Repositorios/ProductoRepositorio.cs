using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using panelVisual.Modelos;

namespace panelVisual.Repositorios
{
    public class ProductoRepositorio
    {
        public static List<Producto> Productos { get; set; }
        public static int lastId = 0;

        public static void IniciarRepositorio()
        {
            Productos = new List<Producto>();

            if (!File.Exists("productos.txt"))
            {
                StreamWriter archivo = new StreamWriter("productos.txt");

                archivo.Close();
            }
            else
            {
                StreamReader archivo = new StreamReader("productos.txt");
                while (!archivo.EndOfStream)
                {
                    string producto = archivo.ReadLine();
                    string[] datos = producto.Split(",");

                    Producto prod = new Producto()
                    {
                        Id = int.Parse(datos[0]),
                        Nombre = datos[1],
                        Color = datos[2],
                        Precio = double.Parse(datos[3]),
                        Categoria = CategoriaRepositorio.GetCategoriaById(int.Parse(datos[4]))
                    };

                    Productos.Add(prod);
                    lastId = int.Parse(datos[0]);
                }
                archivo.Close();
            }

        }

        public static void AgregarProducto(Producto prod)
        {
            Productos.Add(prod);
            lastId++;
            GuardarEnMemoria(prod);
        }

        public static void EliminarProducto(int Id)
        {
            Productos.RemoveAll(e => e.Id.Equals(Id));
            GuardarEnMemoriaLista();

        }

        public static void EditarProducto(int Id, Producto prod)
        {
            int index = Productos.FindIndex(e => e.Id.Equals(Id));
            if (index != -1)
            {
                Productos[index] = prod;
            }
            GuardarEnMemoriaLista();
        }

        private static void GuardarEnMemoria(Producto prod)
        {
            StreamWriter archivo = new StreamWriter("productos.txt", true);

            archivo.WriteLine(prod.Id + "," + prod.Nombre + "," + prod.Color + "," + prod.Precio + "," + prod.Categoria.Id);
            archivo.Close();
        }

        private static void GuardarEnMemoriaLista()
        {
            StreamWriter archivo = new StreamWriter("productos.txt");

            foreach (Producto prod in Productos)
            {
                archivo.WriteLine(prod.Id + "," + prod.Nombre + "," + prod.Color + "," + prod.Precio + "," + prod.Categoria.Id);
            }
            archivo.Close();
        }

        //OBTENER EL PRODUCTO POR EL ID
        public static Producto GetProductoById(int id)
        {
            foreach (var producto in Productos)
            {
                if (producto.Id.Equals(id))
                {
                    return producto;
                }
            }
            return null;
        }
    }
}
