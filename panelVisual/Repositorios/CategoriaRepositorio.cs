using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using panelVisual.Modelos;

namespace panelVisual.Repositorios
{
    public class CategoriaRepositorio
    {
        public static List<Categoria> Categorias { get; set; }
        public static int lastId = 0;

        //SELECT CON LA BD

        public static void IniciarRepositorio()
        {
            Categorias = new List<Categoria>();

            if (!File.Exists("categorias.txt"))
            {
                StreamWriter archivo = new StreamWriter("categorias.txt");
                archivo.Close();
            }
            else
            {
                StreamReader archivo = new StreamReader("categorias.txt");

                while (!archivo.EndOfStream)
                {
                    string categoria = archivo.ReadLine();
                    string[] datos = categoria.Split(',');

                    Categoria cat = new Categoria()
                    {
                        Id = int.Parse(datos[0]),
                        Nombre = datos[1]
                    };

                    Categorias.Add(cat);
                    lastId = int.Parse(datos[0]);
                }
                archivo.Close();
            }
        }

        //AGREGAR UNA CATEGORIA
        public static void AgregarCategoria(Categoria cat)
        {
            Categorias.Add(cat);
            lastId++;
            GuardarEnMemoria(cat);

            //INSERT CON LA BD
        }

        //ELIMINAR UNA CATEGORIA
        public static void EliminarCategoria(int id)
        {
            Categorias.RemoveAll(e => e.Id.Equals(id));
            GuardarEnMemoriaLista();
        }

        //EDITAR UNA CATEGORIA
        public static void EditarCategoria(int id, Categoria cat)
        {
            int index = Categorias.FindIndex(e => e.Id.Equals(id));
            if (index != -1)
            {
                Categorias[index] = cat;
            }

            GuardarEnMemoriaLista();

            //UPDATE DE LA BD
        }

        //GUARDAR EN MEMORIA
        private static void GuardarEnMemoria(Categoria cat)
        {
            StreamWriter archivo = new StreamWriter("categorias.txt", true);
            archivo.WriteLine(cat.Id + "," + cat.Nombre);
            archivo.Close();
        }

        //GUARDAR EN MEMORIA LISTA
        private static void GuardarEnMemoriaLista()
        {
            StreamWriter archivo = new StreamWriter("categorias.txt");

            foreach (Categoria cat in Categorias)
            {
                archivo.WriteLine(cat.Id + "," + cat.Nombre);
            }
            archivo.Close();
        }

        //OBTENER LA CATEGORIA POR EL NOMBRE
        public static Categoria GetCategoriaByName(string name)
        {
            foreach (var categoria in Categorias)
            {
                if (categoria.Nombre.Equals(name))
                {
                    return categoria;
                }
            }
            return null;
        }

        //OBTENER LA CATEGORIA POR EL ID
        public static Categoria GetCategoriaById(int id)
        {
            foreach (var categoria in Categorias)
            {
                if (categoria.Id.Equals(id))
                {
                    return categoria;
                }
            }
            return null;
        }
    }
}
