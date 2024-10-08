﻿using Dominio;
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
        private List<string> listaAuxiliarURL = new List<string>();
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
            Imagen imagen = new Imagen();
            ImagenCBD imagenCBD = new ImagenCBD();

            try
            {

                art.Nombre = input_NombreNA.Text;
                art.Descripcion = input_DescripcionNA.Text;
                art.Precio = decimal.Parse(input_PrecioNA.Text);
                art.Marca = (Marca)cb_MarcaNA.SelectedItem;
                art.Categoria = (Categoria)cb_CategoriaNA.SelectedItem;
                art.Codigo = input_CodigoNA.Text;
                artCBD.Agregar(art);

                foreach (Articulo reg in artCBD.Listar())
                {
                    if (reg.Codigo == input_CodigoNA.Text)
                    {
                        foreach (string x in listaAuxiliarURL)
                        {
                            imagen.IdArticulo = reg.Id;
                            imagen.Url = x;
                            imagenCBD.Agregar(imagen);
                        }
                    }
                }

                MessageBox.Show("Agregado correctamente");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
            finally
            {
                listaAuxiliarURL.Clear();
            }
        }

        private void wf_ADM_AgregarArticulo_Load_1(object sender, EventArgs e)
        {
            cargarImagen("img");

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

        private void cargarImagen(string imagen)
        {
            try
            {
                pb_VisorImagen.Load(imagen);
            }
            catch (Exception ex)
            {
                pb_VisorImagen.Load("https://cdn.pixabay.com/photo/2017/11/10/05/24/upload-2935442_1280.png");
            }
        }

        private void input_UrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(input_UrlImagen.Text);
        }

        private void btn_ConfirmarImagen_Click(object sender, EventArgs e)
        {
            listaAuxiliarURL.Add(input_UrlImagen.Text);

            lbl_confirmacionImagen.ForeColor = Color.Green;
            lbl_confirmacionImagen.Text = "La imagen se agrego correctamente";
            input_UrlImagen.Clear();
            cargarImagen("img");
        }

        private void btn_descartarImagen_Click(object sender, EventArgs e)
        {
            lbl_confirmacionImagen.ForeColor = Color.Red;
            lbl_confirmacionImagen.Text = "La imagen fue descartada";
            input_UrlImagen.Clear();
            cargarImagen("img");
        }
    }
}
