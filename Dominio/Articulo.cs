using Dominio;
using System.Collections.Generic;

public class Articulo
{
    private Categoria _categoria;

    public List<Imagen> Imagenes = new List<Imagen>();
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Codigo { get; set; }
    public string Descripcion { get; set; }
    public Marca Marca { get; set; }
    public Categoria Categoria
    {
        get
        {
            return _categoria ?? new Categoria();
        }
        set
        {
            _categoria = value;
        }
    }
    public decimal Precio { get; set; }

    public void AgregarImagen(Imagen img)
    {
        Imagenes.Add(img);
    }

    public string VerPrimeraImagen()
    {
        if (Imagenes.Count > 0)
        {
            return Imagenes[0].Url;
        }
        return null;
    }
}