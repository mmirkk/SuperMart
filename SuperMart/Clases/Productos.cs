using SuperMart.Enums;

namespace SuperMart.Clases
{
    public class Producto
    {
        public string NombreProd { get; private set; }
        public Categorias Categoria { get; private set; }
        public double Precio { get; private set; }

        public Producto(string nombreProd, Categorias categoria, double precio)
        {
            NombreProd = nombreProd;
            Categoria = categoria;
            Precio = precio;
        }

    }
}
