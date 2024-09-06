using SuperMart.Enums;

namespace SuperMart.Clases
{
    public class Tienda
    {
        public TipoUsuario Usuario { get; private set; }
        public List<Producto> Productos { get; private set; } = new List<Producto> { };

        public Tienda(TipoUsuario usuario, Producto producto)
        {
            Usuario = usuario;
            Productos.Add(producto);
        }

        public void MostrarDetalles()
        {
            Console.WriteLine("Detalles");
            Console.WriteLine($"Tipo de Usuario: {Usuario} \n");
            Console.WriteLine($"Productos:");
            foreach (var producto in Productos)
            {
                Console.WriteLine($"Nombre producto: {producto.NombreProd}");
                Console.WriteLine($"Categoria del producto: {producto.Categoria}");
                Console.WriteLine($"Precio del producto: {producto.Precio}\n");

            }
        }

        public void AgregarProducto(Producto producto)
        {
            if (Usuario == TipoUsuario.Admin)
            {
                Productos.Add(producto);
            }
            else
            {
                Console.WriteLine($"No podes agregar el producto {producto.NombreProd} siendo cliente \n");
            }
            
        }
    }


}
