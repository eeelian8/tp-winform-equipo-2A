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
    public partial class wf_AltaMarca : Form
    {
        public wf_AltaMarca()
        {
            InitializeComponent();
        }

        private void btn_agregarAltaMarca_Click(object sender, EventArgs e)
        {
            Marca mar = new Marca();
            MarcaCBD servicio = new MarcaCBD();

            try
            {
                mar.Descripcion = input_nombreAltaMarca.Text;
                servicio.agregar(mar);

                MessageBox.Show("Marca agregada correctamente!!");
                Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void wf_AltaMarca_Load(object sender, EventArgs e)
        {

        }
    }
}
