using Dsw2026Ej8.Domain;
namespace Dsw2026Ej8

{ 
    internal class Program
    {
        static void Main(string[] args)
        {

            ProductHelper helper = new ProductHelper();

            string etiqueta = helper.ObtenerEtiquetaProducto(1001, "Mouse Logitech", 2500);

            Console.WriteLine(etiqueta);
        }
    }
}
