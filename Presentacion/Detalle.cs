using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Presentacion
{
    public partial class Detalle : Form
    {
        public Detalle( Articulos articulo)
        {
            InitializeComponent();

            detNombre.Text = articulo.Nombre;
            detCodigo.Text = articulo.Codigo;
            detDescripcion.Text = articulo.Descripcion;
            detPrecio.Text = articulo.Precio.ToString(); 
            detMarca.Text = articulo.Marca.Descripcion;
            detCategoria.Text = articulo.Categoria.Descripcion; 

        }

        private void detSalir_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
