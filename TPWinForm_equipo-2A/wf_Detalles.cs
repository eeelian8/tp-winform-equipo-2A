using Dominio;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_2A
{
    public partial class wf_Detalles : Form
    {
        public wf_Detalles()
        {
            InitializeComponent();
        }

        private void wf_Detalles_Load(object sender, EventArgs e)
        {

        }

        private void btn_DetallesBuscar_Click(object sender, EventArgs e)
        {
            string codArt = input_CodigoArticuloDetalles.Text;
            ArticuloCBD artCBD = new ArticuloCBD();

            List<Articulo> ListaArticulos = new List<Articulo>();
            ListaArticulos = artCBD.Listar();
            foreach (Articulo art in ListaArticulos)
            {
                if (art.Codigo == codArt)
                {
                    lbl_NombreDA.Text = art.Nombre;
                    lbl_DescripcionDA.Text = art.Descripcion;
                    lbl_MarcasDA.Text = art.Marca.Descripcion;
                    lbl_CategoriaDA.Text = art.Categoria.Descripcion;
                    lbl_PrecioDA.Text = art.Precio.ToString("C0", CultureInfo.CurrentCulture);
                }
            }
        }

        private void wf_Detalles_Load_1(object sender, EventArgs e)
        {

        }

        private void lbl_DescripcionDA_Click(object sender, EventArgs e)
        {

        }

        private void lbl_PrecioDA_Click(object sender, EventArgs e)
        {

        }
    }
}
