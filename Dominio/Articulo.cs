using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        List<Imagen> Imagenes = new List<Imagen>();
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
        public Marca Marca { get; set; }
        public Categoria Categoria { get; set; }
        public decimal Precio { get; set; }
        public void AgregarImagen(Imagen img)
        {
            Imagenes.Add(img);

        }
        public string VerImagenes()
        {
            return Imagenes[0].Url;
        }

        //public articulo()
        //{
        //   Imagenes = new List<imagen>();
        //}

    }
}
