using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categorias
    {
        public string Descripcion { get; set; }

        public int Id { get; set; }

        public Categorias(string descripcion)
        {
            Descripcion = descripcion; 
        }

        public Categorias(int id, string descripcion)
        {
            Descripcion = descripcion;

            Id = id; 

        }

        public override string ToString()
        {
            return Descripcion; 
        }
    }
}
