using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocios; 

namespace WebApp2
{
    public partial class Products : System.Web.UI.Page
    {
        public List<Articulos> lista;
        public string noImage = "https://upload.wikimedia.org/wikipedia/commons/1/14/No_Image_Available.jpg";
        protected void Page_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                lista = negocio.listar();
                Session.Add("lista", lista);  
            }
            catch (Exception)
            {

                // redirect to error page
            }
            
        }  

        public bool imageError(string image)
        {
            if (!(image.Contains("https:/")) || image == null){
                return true; 
            }
            else return false; 
        }

    }
}