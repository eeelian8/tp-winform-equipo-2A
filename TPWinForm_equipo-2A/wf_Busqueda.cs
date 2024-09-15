using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Servicios;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
            cargar();
            formatoDgv();
            limpiarFiltros();

        }

        private void cargar()
        {
            ArticuloCBD servicio = new ArticuloCBD();
            listaArticulo = servicio.Listar();
            dgvArticulos.DataSource = listaArticulo;
        }
        private void limpiarFiltros()
        {
            MarcaCBD marcaService = new MarcaCBD();
            db_BusquedaMarca.DataSource = marcaService.Listar();
            db_BusquedaMarca.DisplayMember = "Descripcion";
            db_BusquedaMarca.SelectedIndex = -1;


            CategoriaCBD categoriaService = new CategoriaCBD();
            db_BusquedaCategoria.DataSource = categoriaService.Listar();
            db_BusquedaCategoria.DisplayMember = "Descripcion";
            db_BusquedaCategoria.SelectedIndex = -1;
        }

        private void formatoDgv()
        {
            //Establecemos el ancho de cada columna
            dgvArticulos.RowHeadersVisible = false;
            dgvArticulos.ColumnHeadersVisible = false;

            dgvArticulos.Columns[0].Width = 25;
            dgvArticulos.Columns[1].Width = 150;
            dgvArticulos.Columns[2].Width = 45;
            dgvArticulos.Columns[3].Width = 325;
            dgvArticulos.Columns[4].Width = 100;
            dgvArticulos.Columns[5].Width = 100;
            dgvArticulos.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //Establecemos el formato de precio:
            dgvArticulos.Columns[6].DefaultCellStyle.Format = "C0";
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_MarcaBusqueda_Click(object sender, EventArgs e)
        {

        }

        private void dgvArticulos_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lb_BusquedaMarca_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lbl_RangoPrecioBusqueda_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtroNombre = TbNombre.Text;
            string filtroCategoria = db_BusquedaCategoria.Text;

            if (filtroCategoria != "")
            {
                //listaFiltrada = listaArticulo.FindAll(art => art.Nombre.ToUpper().Contains(filtroNombre.ToUpper()) );
                listaFiltrada = listaArticulo.FindAll(art => art.Categoria.Descripcion.ToString() == filtroCategoria);
            }
            else 
            {
                listaFiltrada = listaArticulo;
            }
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            formatoDgv();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void db_BusquedaCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TbNombre_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtroNombre = TbNombre.Text;
            listaFiltrada = listaArticulo.FindAll(art => art.Nombre.ToUpper().Contains(filtroNombre.ToUpper()));

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
            formatoDgv();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            limpiarFiltros();
            cargar();
        }
    }
}
