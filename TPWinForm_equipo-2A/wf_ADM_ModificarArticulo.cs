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
            ImagenCBD imagenCBD = new ImagenCBD();

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
                    lbl_PrecioDetallesMA.Text = art.Precio.ToString("C0", CultureInfo.CurrentCulture);

                    foreach (Imagen img in imagenCBD.Listar())
                    {
                        if(img.IdArticulo == art.Id)
                        {
                            try
                            {
                                pb_ImagenesDetallesMA.Load(img.Url);
                            }
                            catch (Exception)
                            {
                                pb_ImagenesDetallesMA.Load("https://cdn.pixabay.com/photo/2017/11/10/05/24/upload-2935442_1280.png");
                            }
                            break;
                        }
                    }

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

        private void btn_EliminarIMG_Click(object sender, EventArgs e)
        {
            ImagenCBD imagenCBD = new ImagenCBD();
            Imagen imagen = new Imagen();

            Articulo articulo = new Articulo();
            ArticuloCBD articuloCBD = new ArticuloCBD();

            foreach (Imagen img in imagenCBD.Listar())
            {
                foreach (Articulo art in articuloCBD.Listar())
                {
                    if(art.Codigo == input_CodigoArticuloMA.Text)
                    {
                        imagenCBD.Eliminar(art.Id);
                        break;
                    }
                }

                break;
            }

            pb_ImagenesDetallesMA.Load("https://cdn.pixabay.com/photo/2017/11/10/05/24/upload-2935442_1280.png");
        }

        private void btn_AgregarIMG_Click(object sender, EventArgs e)
        {
            Articulo Articulo = new Articulo(); 
            ArticuloCBD articuloCBD = new ArticuloCBD();

            ImagenCBD imagenCBD = new ImagenCBD();
            Imagen imagen = new Imagen();

            foreach (Articulo art in articuloCBD.Listar())
            {
                if (art.Codigo == input_CodigoArticuloMA.Text)
                {
                    imagen.IdArticulo = art.Id;
                    imagen.Url = tb_nuevaUrlImagen.Text;
                    imagenCBD.Agregar(imagen);
                    break;
                }
            }

        }

        private void tb_nuevaUrlImagen_Leave(object sender, EventArgs e)
        {
            try
            {
                pb_ImagenesDetallesMA.Load(tb_nuevaUrlImagen.Text);
            }
            catch (Exception)
            {

                pb_ImagenesDetallesMA.Load("https://cdn.pixabay.com/photo/2017/11/10/05/24/upload-2935442_1280.png");
            }
        }
    }
}
