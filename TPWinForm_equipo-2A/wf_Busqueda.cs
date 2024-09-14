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

            dgvArticulos.RowHeadersVisible = false;
            dgvArticulos.Columns[0].Width = 25;
            dgvArticulos.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvArticulos.Columns[2].Width = 45;
            dgvArticulos.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvArticulos.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvArticulos.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvArticulos.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvArticulos.Columns[6].DefaultCellStyle.Format = "C0";
        }

    }
}
