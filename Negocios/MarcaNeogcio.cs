using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio; 

namespace Negocios
{
    public class MarcaNeogcio
    { 
        public List<Marca> listar()
        {
            List<Marca> lista = new List<Marca>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("select id, Descripcion from MARCAS");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    int id = (int)datos.Lector["id"];
                    string descripcion = (string)datos.Lector["Descripcion"];

                    lista.Add(new Marca(id, descripcion)); 
                }

                return lista;
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                datos.cerrarConexion(); 
            }
        }
    }
}
