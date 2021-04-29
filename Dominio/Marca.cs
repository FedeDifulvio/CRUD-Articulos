using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        public string Descripcion { get; set; }

        public int Id { get; set; }

        public Marca( string descripcion)
        {
            Descripcion = descripcion;
        }

        public Marca( int id, string descripcion)
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
