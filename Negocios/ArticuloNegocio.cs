using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocios
{
    public class ArticuloNegocio 
    {
        public List<Articulos> listar()
        {
            List<Articulos> lista = new List<Articulos>();
            AccesoDatos datos = new AccesoDatos();
            string consulta = "select A.Codigo, A.Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categorias, A.ImagenUrl, A.Precio from Articulos A inner join Categorias C on A.IdCategoria = C.Id inner join Marcas M on M.Id = A.IdMarca ";
         
            try
            {

                datos.setearConsulta(consulta);
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Articulos articulo = new Articulos();
                    articulo.Codigo = (string)datos.Lector["Codigo"];
                    articulo.Nombre = (string)datos.Lector["Nombre"];
                    articulo.Descripcion = (string)datos.Lector["Descripcion"];
                    articulo.imagenURL = (string)datos.Lector["ImagenUrl"];
                    articulo.Precio = (decimal)datos.Lector["Precio"];
                    articulo.Marca = new Marca((string)datos.Lector["Marca"]);
                    articulo.Categoria= new Categorias((string)datos.Lector["Categorias"]);

                    lista.Add(articulo); 

                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        } 

        public void agregarArticulo(Articulos articulo)
        {
            AccesoDatos datos = new AccesoDatos();

            string query = "insert into articulos( Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) " +

                "VALUES('"+ articulo.Codigo + "', '"+ articulo.Nombre +"','"+ articulo.Descripcion +"',"+ articulo.Marca.Id +", "+ articulo.Categoria.Id +",'"+ articulo.imagenURL +"', "+ articulo.Precio +")";

            try
            {
                datos.setearConsulta(query);
                datos.ejectutarAccion();

            }
            catch (Exception ex)
            {
                throw ex; 
               
            }
            finally
            {
                datos.cerrarConexion(); 
            }
           
        }


    }

}
