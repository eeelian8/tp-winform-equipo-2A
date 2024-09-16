using Dominio;
using Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        private int contadorImg = 0;

        private List<Imagen> imagenesXarticulo = new List<Imagen>();

        private void wf_Detalles_Load(object sender, EventArgs e)
        {

        }

        private void btn_DetallesBuscar_Click(object sender, EventArgs e)
        {
            string codArt = input_CodigoArticuloDetalles.Text;
            ArticuloCBD artCBD = new ArticuloCBD();

            List<Articulo> ListaArticulos = new List<Articulo>();
            ListaArticulos = artCBD.Listar();

            ImagenCBD imagenCBD = new ImagenCBD();

            foreach (Articulo art in ListaArticulos)
            {
                if (art.Codigo == codArt)
                {
                    lbl_NombreDA.Text = art.Nombre;
                    lbl_DescripcionDA.Text = art.Descripcion;
                    lbl_MarcasDA.Text = art.Marca.Descripcion;
                    lbl_CategoriaDA.Text = art.Categoria.Descripcion;
                    lbl_PrecioDA.Text = art.Precio.ToString();

                    foreach (Imagen img in imagenCBD.Listar())
                    {
                        foreach (Articulo reg in ListaArticulos)
                        {
                            if (reg.Codigo == art.Codigo)
                            {
                                if (img.IdArticulo == art.Id)
                                {
                                    imagenesXarticulo.Add(img);
                                }
                            }
                        }
                    }

                }
            }

            pb_ImagenesDA.Load(imagenesXarticulo[contadorImg].Url);
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                contadorImg++;
                pb_ImagenesDA.Load(imagenesXarticulo[contadorImg].Url);
            }
            catch (Exception)
            {

                pb_ImagenesDA.Load("https://cdn.pixabay.com/photo/2017/11/10/05/24/upload-2935442_1280.png");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                contadorImg--;
                pb_ImagenesDA.Load(imagenesXarticulo[contadorImg].Url);
            }
            catch (Exception)
            {

                pb_ImagenesDA.Load("https://cdn.pixabay.com/photo/2017/11/10/05/24/upload-2935442_1280.png");
            }
        }
    }
}
