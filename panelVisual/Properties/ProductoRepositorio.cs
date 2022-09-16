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
            
            if(!File.Exists("products.txt"))
            {
                StreamWriter archivo = new StreamWriter("products.txt");

                archivo.Close();
            }
            else
            {
                StreamReader archivo = new StreamReader("products.txt");
                while(!archivo.EndOfStream)
                {
                    string producto = archivo.ReadLine();
                    string[] datos = producto.Split(";");

                    Producto prod = new Producto()
                    {
                        Id = int.Parse(datos[0]),
                        Nombre = datos[1],
                        Color = datos[2],
                        Precio = double.Parse(datos[3])
                    };

                    Productos.Add(prod);
                }
                archivo.Close();
            }
            
        }

        public static void AgregarProducto(Producto prod)
        {
            Productos.Add(prod);
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
            StreamWriter archivo = new StreamWriter("products.txt", true);

            archivo.WriteLine(prod.Id + ";" + prod.Nombre + ";" + prod.Color + ";" + prod.Precio);
            archivo.Close();
        }

        private static void GuardarEnMemoriaLista()
        {
            StreamWriter archivo = new StreamWriter("products.txt");

            foreach (Producto prod in Productos)
            {
                archivo.WriteLine(prod.Id + ";" + prod.Nombre + ";" + prod.Color + ";" + prod.Precio);
            }
            archivo.Close();
        }


    }
}
