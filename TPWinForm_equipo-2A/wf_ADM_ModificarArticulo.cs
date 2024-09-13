using Dominio;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPWinForm_equipo_2A
{
    public partial class wf_ADM_ModificarArticulo : Form
    {
        public wf_ADM_ModificarArticulo()
        {
            InitializeComponent();
        }

        private void wf_ADM_ModificarArticulo_Load(object sender, EventArgs e)
        {

        }

        private void btn_BuscarMA_Click(object sender, EventArgs e)
        {
            string codArt = input_CodigoArticuloMA.Text;
            ArticuloCBD artCBD = new ArticuloCBD();

            List<Articulo> ListaArticulos = new List<Articulo>();
            ListaArticulos = artCBD.Listar();
            foreach (Articulo art in ListaArticulos)
            {
                if (art.Codigo == codArt)
                {
                    lbl_NombreDetallesMA.Text = art.Nombre;
                    lbl_DescripcionDetallesMA.Text = art.Descripcion;
                    cb_MarcasDetallesMA.Text = art.Marca.Descripcion;
                    cb_CategoriaDetallesMA.Text = art.Categoria.Descripcion;
                    lbl_PrecioDetallesMA.Text = art.Precio.ToString();
                }
            }
        }

        private void wf_ADM_ModificarArticulo_Load_1(object sender, EventArgs e)
        {
            CategoriaCBD catCBD = new CategoriaCBD();
            MarcaCBD marCBD = new MarcaCBD();

            try
            {
                cb_CategoriaDetallesMA.DataSource = catCBD.Listar();
                cb_MarcasDetallesMA.DataSource = marCBD.Listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_ConfirmarModificar_Click(object sender, EventArgs e)
        {
            ArticuloCBD artCBD = new ArticuloCBD();
            string codArt = input_CodigoArticuloMA.Text;
            Articulo reg = artCBD.Buscar(codArt);

            reg.Nombre = lbl_NombreDetallesMA.Text;
            reg.Descripcion = lbl_DescripcionDetallesMA.Text;
            reg.Marca = (Marca)cb_MarcasDetallesMA.SelectedItem;
            reg.Categoria = (Categoria)cb_CategoriaDetallesMA.SelectedItem;
            reg.Precio = decimal.Parse(lbl_PrecioDetallesMA.Text);

            artCBD.Modificar(reg);
            MessageBox.Show("Registro modificado correctamente");
            Close();
        }
    }
}
