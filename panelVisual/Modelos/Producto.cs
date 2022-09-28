using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace panelVisual.Modelos
{
    public class Producto
    {
        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Color { get; set; }

        public double Precio { get; set; }

        public Categoria Categoria { get; set; }

    }
}
