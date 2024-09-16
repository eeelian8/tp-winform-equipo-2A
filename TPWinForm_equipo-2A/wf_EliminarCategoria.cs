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
using Dominio;

namespace TPWinForm_equipo_2A
{
    public partial class wf_EliminarCategoria : Form
    {
        public wf_EliminarCategoria()
        {
            InitializeComponent();
        }

        private void btn_eliminarCategoria_Click(object sender, EventArgs e)
        {
            CategoriaCBD catCBD = new CategoriaCBD();
            Categoria cat = new Categoria();
            List<Categoria> ListaCategorias = new List<Categoria>();
            ListaCategorias = catCBD.Listar();

            try
            {
                int idCategoria = int.Parse(input_idEliminarCategoria.Text);

                foreach (Categoria categoria in ListaCategorias)
                {

                    if (categoria.Id == idCategoria)
                    {
                        catCBD.Eliminar(categoria.Id);
                        lbl_estadoEliminacionCategoria.ForeColor = Color.Green;
                        lbl_estadoEliminacionCategoria.Text = "Eliminado correctamente";
                        break;
                    }
                    else
                    {
                        lbl_estadoEliminacionCategoria.ForeColor = Color.Red;
                        lbl_estadoEliminacionCategoria.Text = "El ID ingresado es inexistente";
                        break;
                    }

                }

                if (ListaCategorias.Count == 0)
                {
                    lbl_estadoEliminacionCategoria.ForeColor = Color.Red;
                    lbl_estadoEliminacionCategoria.Text = "El ID ingresado es inexistente";
                }
            }
            catch (Exception )
            {
                if(input_idEliminarCategoria.Text == null || input_idEliminarCategoria.Text.Length == 0)
                {
                    lbl_estadoEliminacionCategoria.ForeColor = Color.Yellow;
                    lbl_estadoEliminacionCategoria.Text = "Ingrese un valor valido";
                }
            }
        }
    }
}
