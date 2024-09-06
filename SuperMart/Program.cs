//Estás desarrollando un sistema para "SuperMart", una tienda virtual enfocada en mejorar la gestión 
//    de su inventario de productos. Los administradores de "SuperMart" necesitan una herramienta que
//    les permita categorizar y organizar los artículos disponibles, abarcando desde alimentos hasta 
//    dispositivos electrónicos y ropa. Este sistema será clave para mantener un control eficiente del 
//    inventario, permitiendo que los administradores puedan actualizar, agregar y consultar productos 
//    de manera clara y organizada.

//El sistema está diseñado para gestionar una variedad de productos, que se agrupan según su categoría. 
//Cada tipo de producto debe poder mostrar la información necesaria para que tanto los administradores 
//como los clientes puedan identificar sus detalles más relevantes. A través de este enfoque unificado, los 
//administradores pueden realizar modificaciones o agregar nuevos artículos sin complicaciones.

// enum tipousuario
// enum categorias
// productos 
// tienda

using SuperMart.Clases;
using SuperMart.Enums;

class Program
{
    static void Main()
    {
        Console.Write("Ingrese 1 para ingresar como ADMIN y 2 como CLIENTE: ");
        int codigo;
        int.TryParse(Console.ReadLine(), out codigo);
        TipoUsuario usuario = TipoUsuario.Cliente;
        if(codigo == 1)
        {
            usuario = TipoUsuario.Admin;
        }else if(codigo == 2){
            usuario = TipoUsuario.Cliente;
        }
        else
        {
            Console.WriteLine("El ingreso no es valido");
        }


        Producto producto1 = new Producto("Fideos", Categorias.Alimentos, 1800);
        Producto producto2 = new Producto("Remera", Categorias.Ropa, 8000);
        Producto producto3 = new Producto("Monitor", Categorias.DispositivoElectronico, 35000);

        Tienda tienda = new Tienda(usuario, producto1);
        tienda.AgregarProducto(producto2);
        tienda.AgregarProducto(producto3);
        tienda.MostrarDetalles();
    }
}