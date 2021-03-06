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
    public partial class Form1 : Form
    {
        private List<Articulos> listArticulos;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarArticulos(); 
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            pbArticulo.Load(dgvArticulos.CurrentRow.Cells[4].Value.ToString());
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Agregar ventana_Agregar = new Agregar();
            ventana_Agregar.ShowDialog();
            cargarArticulos();
        } 

        private void cargarArticulos()
        {
            ArticuloNegocio negocioArticulos = new ArticuloNegocio();

            try
            {
               
               listArticulos = negocioArticulos.listar();

                dgvArticulos.DataSource = listArticulos;

                dgvArticulos.Columns["Id"].Visible = false;
                dgvArticulos.Columns["imagenURL"].Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
           
        }

        private void cargarArticulos(string filtro)
        {
            ArticuloNegocio negocioArticulos = new ArticuloNegocio();
            List<Articulos> articulosFiltrados = new List<Articulos>() ;

            try
            { 
                foreach (Articulos item in listArticulos)
                {
                    if (chequearFiltros(item,filtro)) 
                    {
                        articulosFiltrados.Add(item); 
                    }
                }

                dgvArticulos.DataSource = articulosFiltrados; 

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }

        }  

         public bool chequearFiltros( Articulos item, string filtro)
        {
            if(item.Nombre.ToLower().Contains(filtro.ToLower())) 
            {
                return true;
            }
            if (item.Descripcion.ToLower().Contains(filtro.ToLower()))
            {
                return true;
            }
            if (item.Codigo.ToLower() == filtro.ToLower())
            {
                return true;
            }

            if (item.Marca.Descripcion.ToLower() == filtro.ToLower())
            {
                return true;
            }

            if (item.Categoria.Descripcion.ToLower() == filtro.ToLower())
            {
                return true;
            }

            if (item.Precio.ToString().Contains(filtro.ToString()))  
            {
                return true;
            }

            return false; 
        }


        //OPCION DOS
      /* private void cargarArticulosFiltrados(string filtro)
        {
            ArticuloNegocio negocioArticulos = new ArticuloNegocio();

            try
            {

                listArticulos = negocioArticulos.listarFiltrado(filtro);

                dgvArticulos.DataSource = listArticulos;

                dgvArticulos.Columns["imagenURL"].Visible = false;

            }
            catch (Exception)
            {
                MessageBox.Show("errrrror");
            }

        } */

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Detalle detalle = new Detalle(obtenerArticuloDeDataGrid()); 

           detalle.ShowDialog(); 
        } 

       public Articulos obtenerArticuloDeDataGrid()
       {
            Articulos articulo = new Articulos();

            articulo.Codigo = dgvArticulos.CurrentRow.Cells[1].Value.ToString();
            articulo.Nombre = dgvArticulos.CurrentRow.Cells[2].Value.ToString();
            articulo.Descripcion = dgvArticulos.CurrentRow.Cells[3].Value.ToString();
            articulo.imagenURL = dgvArticulos.CurrentRow.Cells[4].Value.ToString();
            articulo.Precio = (decimal)dgvArticulos.CurrentRow.Cells[5].Value;
            articulo.Marca =  new Marca(dgvArticulos.CurrentRow.Cells[6].Value.ToString()); 
            articulo.Categoria=  new Categorias(dgvArticulos.CurrentRow.Cells[7].Value.ToString());
           
            return articulo; 
       } 

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                cargarArticulos(); 
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
           cargarArticulos(txtBuscar.Text);
          // cargarArticulosFiltrados(txtBuscar.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocioArticulos = new ArticuloNegocio(); 

            DialogResult respuesta = MessageBox.Show("¿Desea realmente eliminar este articulo?", "Eliminar", MessageBoxButtons.YesNo); 

            if(respuesta == DialogResult.Yes)
            {
                negocioArticulos.eliminarArticulo(dgvArticulos.CurrentRow.Cells[0].Value.ToString());
                cargarArticulos();
            }

        }
    }
      
}
