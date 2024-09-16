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
    public partial class wf_ADM_EliminarArticulo : Form
    {
        public wf_ADM_EliminarArticulo()
        {
            InitializeComponent();
        }

        private void wf_ADM_EliminarArticulo_Load(object sender, EventArgs e)
        {

        }

        private void btn_EliminarEA_Click(object sender, EventArgs e)
        {
            ArticuloCBD artCBD = new ArticuloCBD();
            Articulo art = new Articulo();
            List<Articulo> ListaArticulos = new List<Articulo>();
            ListaArticulos = artCBD.Listar();

            try
            {
                string codArticuloInput = input_CodigoArticuloEA.Text;

                foreach (Articulo articulo in ListaArticulos)
                {

                    if (articulo.Codigo == codArticuloInput)
                    {
                        artCBD.Eliminar(articulo.Codigo);
                        lbl_EstadoEliminacion.ForeColor = Color.Green;
                        lbl_EstadoEliminacion.Text = "Eliminado correctamente";
                        break;
                    }
                    else
                    {
                        lbl_EstadoEliminacion.ForeColor = Color.Red;
                        lbl_EstadoEliminacion.Text = "El codigo ingresado es inexistente";
                        break;
                    }

                }

                if (ListaArticulos.Count == 0)
                {
                    lbl_EstadoEliminacion.ForeColor = Color.Red;
                    lbl_EstadoEliminacion.Text = "El codigo ingresado es inexistente";
                }
            }
            catch (Exception)
            {
                if (input_CodigoArticuloEA.Text == null || input_CodigoArticuloEA.Text.Length == 0)
                {
                    lbl_EstadoEliminacion.ForeColor = Color.Yellow;
                    lbl_EstadoEliminacion.Text = "Ingrese un valor valido";
                }
            }
        }
    }
}
