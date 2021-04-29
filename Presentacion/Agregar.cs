using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocios;
using Dominio; 

namespace Presentacion
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            MarcaNeogcio marcaNegocio = new MarcaNeogcio();
            NeogcioCategorias categoriasNegocio = new NeogcioCategorias(); 

            try
            {
                cbMarca.DataSource = marcaNegocio.listar();
                cbCategoria.DataSource = categoriasNegocio.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); 
            }
        }

        private void btninsertArticulo_Click(object sender, EventArgs e)
        {
            Articulos articulo = new Articulos();

            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Precio =  decimal.Parse(txtPrecio.Text);
                articulo.imagenURL = txtURL.Text;
                articulo.Marca = (Marca)cbMarca.SelectedItem;
                articulo.Categoria = (Categorias)cbCategoria.SelectedItem;

                negocio.agregarArticulo(articulo);

                MessageBox.Show("¡Agregado con exito!");

                Close(); 
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString()); 
            }

        }
    }
}
