using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TPWinForm_equipo_2A;

namespace TPWinForm_equipo_2A
{
    public partial class wf_Inicio : Form
    {
        public wf_Inicio()
        {
            InitializeComponent();
        }

        private void btn_Busqueda_Click(object sender, EventArgs e)
        {
            wf_Busqueda FormBusqueda = new wf_Busqueda();
            FormBusqueda.ShowDialog();
        }

        private void btn_AgregarArticulo_Click(object sender, EventArgs e)
        {
            wf_ADM_AgregarArticulo FormAgregarArticulo = new wf_ADM_AgregarArticulo();
            FormAgregarArticulo.ShowDialog();
        }

        private void btn_EliminarArticulo_Click(object sender, EventArgs e)
        {
            wf_ADM_EliminarArticulo FormEliminarArticulo = new wf_ADM_EliminarArticulo();
            FormEliminarArticulo.ShowDialog();
        }

        private void btn_ModificarArticulo_Click(object sender, EventArgs e)
        {
            wf_ADM_ModificarArticulo FormModificarArticulo = new wf_ADM_ModificarArticulo();
            FormModificarArticulo.ShowDialog();
        }

        private void btn_DetallesArticulos_Click(object sender, EventArgs e)
        {
            wf_Detalles FormDetalles = new wf_Detalles();
            FormDetalles.ShowDialog();
        }

        private void btn_MarcasCategorias_Click(object sender, EventArgs e)
        {
            wf_MarcasCategorias FormMarcasCategorias = new wf_MarcasCategorias();
            FormMarcasCategorias.ShowDialog();
        }
    }
}
