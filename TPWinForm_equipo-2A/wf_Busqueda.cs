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

            //Establecemos el ancho de cada columna
            dgvArticulos.RowHeadersVisible = false;
            dgvArticulos.ColumnHeadersVisible = false;

            dgvArticulos.Columns[0].Width = 25;
            dgvArticulos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvArticulos.Columns[2].Width = 55;
            dgvArticulos.Columns[3].Width = 150;
            dgvArticulos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvArticulos.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvArticulos.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //Establecemos el formato de precio:
            dgvArticulos.Columns[6].DefaultCellStyle.Format = "C0";


            MarcaCBD marcaService = new MarcaCBD();
            db_BusquedaMarca.DataSource = marcaService.Listar();
            db_BusquedaMarca.DisplayMember = "Descripcion";
            db_BusquedaMarca.SelectedIndex = -1;


            CategoriaCBD categoriaService = new CategoriaCBD();
            db_BusquedaCategoria.DataSource = categoriaService.Listar();
            db_BusquedaCategoria.DisplayMember = "Descripcion";
            db_BusquedaCategoria.SelectedIndex = -1;


        }

        private void cargar ()
        {
            ArticuloCBD servicio = new ArticuloCBD();
            listaArticulo = servicio.Listar();
            dgvArticulos.DataSource = listaArticulo;
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

            listaFiltrada = listaArticulo.FindAll(art => art.Categoria.Descripcion.ToString() == db_BusquedaCategoria.Text);

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltrada;
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
    }
}
