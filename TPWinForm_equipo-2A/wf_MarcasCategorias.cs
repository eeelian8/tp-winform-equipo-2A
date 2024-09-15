using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Servicios;
using System.Text.RegularExpressions;
using TPWinForm_equipo_2A;

namespace TPWinForm_equipo_2A
{
    public partial class wf_MarcasCategorias : Form
    {
        private void cargarMarcas()
        {
            lv_MarcasMC.Items.Clear();
            MarcaCBD marCBD = new MarcaCBD();
            foreach (Marca mar in marCBD.Listar())
            {
                lv_MarcasMC.Items.Add("ID: " + mar.Id.ToString() + " - " + mar.Descripcion);
            }
        }
        private void cargarCategorias()
        {
            lv_CategoriasMC.Items.Clear();
            CategoriaCBD catCBD = new CategoriaCBD();
            foreach (Categoria cat in catCBD.Listar())
            {
                lv_CategoriasMC.Items.Add("ID: " +cat.Id.ToString() + " - " + cat.Descripcion);
            }
        }

        public wf_MarcasCategorias()
        {
            InitializeComponent();
        }

        private void wf_MarcasCategorias_Load(object sender, EventArgs e)
        {
        }

        private void wf_MarcasCategorias_Load_1(object sender, EventArgs e)
        {
            cargarMarcas();
            cargarCategorias();
        }

        private void btn_AgregarMarcasMC_Click(object sender, EventArgs e)
        {
            wf_AltaMarca formAltaMarca = new wf_AltaMarca();
            formAltaMarca.ShowDialog();
            cargarMarcas();
        }

        private void btn_AgregarCategoriasMC_Click(object sender, EventArgs e)
        {
            wf_AltaCategoria formAltaCategoria = new wf_AltaCategoria();
            formAltaCategoria.ShowDialog();
            cargarCategorias();
        }

        private void btn_EliminarMarcasMC_Click(object sender, EventArgs e)
        {
            wf_EliminarMarca formEliminarMarca = new wf_EliminarMarca();
            formEliminarMarca.ShowDialog();
            cargarMarcas();
        }

        private void btn_EliminarCategoriasMC_Click(object sender, EventArgs e)
        {
            wf_EliminarCategoria formEliminarCategoria = new wf_EliminarCategoria();
            formEliminarCategoria.ShowDialog();
            cargarCategorias();
        }
    }
}
