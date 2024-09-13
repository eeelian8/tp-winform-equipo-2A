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
    public partial class wf_ADM_AgregarArticulo : Form
    {
        public wf_ADM_AgregarArticulo()
        {
            InitializeComponent();
        }

        private void wf_ADM_AgregarArticulo_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregarNA_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo();
            ArticuloCBD artCBD = new ArticuloCBD();

            try
            {
                art.Nombre = input_NombreNA.Text;
                art.Descripcion = input_DescripcionNA.Text;
                art.Precio = decimal.Parse(input_PrecioNA.Text);
                art.Marca = (Marca)cb_MarcaNA.SelectedItem;
                art.Categoria = (Categoria)cb_CategoriaNA.SelectedItem;
                art.Codigo = input_CodigoNA.Text;
                //art.AgregarImagen();

                artCBD.Agregar(art);
                MessageBox.Show("Agregado correctamente");
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void wf_ADM_AgregarArticulo_Load_1(object sender, EventArgs e)
        {
            CategoriaCBD catCBD = new CategoriaCBD();
            MarcaCBD marCBD = new MarcaCBD();

            try
            {
                cb_CategoriaNA.DataSource = catCBD.Listar();
                cb_MarcaNA.DataSource = marCBD.Listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
