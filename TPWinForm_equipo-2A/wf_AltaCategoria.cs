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
    public partial class wf_AltaCategoria : Form
    {
        public wf_AltaCategoria()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_agregarAltaCategoria_Click(object sender, EventArgs e)
        {
            Categoria cat = new Categoria();
            CategoriaCBD servicio = new CategoriaCBD();

            try
            {
                cat.Descripcion = input_nombreAltaCategoria.Text;
                servicio.agregar(cat);

                MessageBox.Show("Categoria Agregada Satisfactoriamente!");
                Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
