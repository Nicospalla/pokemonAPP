using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Pokemon
    {
        public int Numero { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public string UrlImagen { get; set; }
        public Elemeto Tipo { get; set; }

        public Elemeto Debilidad { get; set; }
    }
}
