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
    public partial class wf_EliminarMarca : Form
    {
        public wf_EliminarMarca()
        {
            InitializeComponent();
        }

        private void btn_eliminarMarca_Click(object sender, EventArgs e)
        {
            MarcaCBD marCBD = new MarcaCBD();
            
            Marca mar = new Marca();
            List<Marca> ListaMarcas = new List<Marca>();
            ListaMarcas = marCBD.Listar();

            try
            {
                int idMarca = int.Parse(input_idEliminarMarca.Text);

                if (ListaMarcas.Count == 0)
                {
                    lbl_estadoEliminacionMarca.ForeColor = Color.Red;
                    lbl_estadoEliminacionMarca.Text = "El ID ingresado es inexistente";
                }

                foreach (Marca marca in ListaMarcas)
                {
                    if (marca.Id == idMarca)
                    {
                        marCBD.Eliminar(marca.Id);
                        lbl_estadoEliminacionMarca.ForeColor = Color.Green;
                        lbl_estadoEliminacionMarca.Text = "Eliminado correctamente";
                    }
                    else
                    {
                        lbl_estadoEliminacionMarca.ForeColor = Color.Red;
                        lbl_estadoEliminacionMarca.Text = "El ID ingresado es inexistente";
                    }

                } 
            }
            catch (Exception)
            {
                if (input_idEliminarMarca.Text == null || input_idEliminarMarca.Text.Length == 0)
                {
                    lbl_estadoEliminacionMarca.ForeColor = Color.Yellow;
                    lbl_estadoEliminacionMarca.Text = "Ingrese un valor valido";
                }
            }
        }
    }
}
