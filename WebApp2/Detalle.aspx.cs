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
    public partial class Detalle : System.Web.UI.Page
    {
        public Articulos detalle;
        protected void Page_Load(object sender, EventArgs e)
        {
            int id =int.Parse(Request.QueryString["id"]);
            List<Articulos> articulos = (List<Articulos>)Session["lista"];
             detalle = articulos.Find(x => x.Id == id); 
        }
    }
}