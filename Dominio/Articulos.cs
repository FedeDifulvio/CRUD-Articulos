using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public  class Articulos
    {
        public int Id { get; set; }
        public string Codigo { get; set; }

        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public string imagenURL { get; set; }

        public decimal Precio { get; set; }

        public Marca Marca { get; set; }

        public Categorias Categoria { get; set; }

    }
}
