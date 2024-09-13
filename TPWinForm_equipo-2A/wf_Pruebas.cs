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
using Servicios;

namespace TPWinForm_equipo_2A
{
    public partial class wf_Pruebas : Form
    {

        private List<Categoria> CategoriaList;
        public wf_Pruebas()
        {
            InitializeComponent();
        }

        private void Prueba_Load(object sender, EventArgs e)
        {
            CategoriaCBD art = new CategoriaCBD();
            CategoriaList = art.Listar();
            dgv_Articulos.DataSource = CategoriaList; ;

        }
    }
}
