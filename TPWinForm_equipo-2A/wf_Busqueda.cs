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
using Servicios;

namespace TPWinForm_equipo_2A
{
    public partial class wf_Busqueda : Form
    {
        private List<Articulo> listaArticulo;
        public wf_Busqueda()
        {
            InitializeComponent();
        }

        private void wf_Busqueda_Load(object sender, EventArgs e)
        {
            ArticuloCBD servicio = new ArticuloCBD();
            listaArticulo = servicio.Listar();
            dgvArticulos.DataSource = listaArticulo;

            //Establecemos el ancho de cada columna
            dgvArticulos.RowHeadersVisible = false;
            dgvArticulos.Columns[0].Width = 25;
            dgvArticulos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvArticulos.Columns[2].Width = 45;
            dgvArticulos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvArticulos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvArticulos.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvArticulos.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //Establecemos el formato de precio:
            dgvArticulos.Columns[6].DefaultCellStyle.Format = "C0";


            cargarImagen(listaArticulo[0].Imagenes);
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                string imagenUrl = seleccionado.VerPrimeraImagen();
                if (!string.IsNullOrEmpty(imagenUrl))
                {
                    cargarImagen(imagenUrl);
                }
                else
                {
                    // Cargar una imagen por defecto si no hay URL
                    cargarImagen("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
                }
            }
        }

        private void cargarImagen(string imagenUrl)
        {
            try
            {
                PbArticulo.Load(imagenUrl);
            }
            catch (Exception ex)
            {
                PbArticulo.Load("https://uning.es/wp-content/uploads/2016/08/ef3-placeholder-image.jpg");
            }
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
