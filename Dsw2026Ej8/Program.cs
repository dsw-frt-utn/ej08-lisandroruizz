using Dsw2026Ej8.Domain;
namespace Dsw2026Ej8

{ 
    internal class Program
    {
        static void Main(string[] args)
        {

            ProductHelper helper = new ProductHelper();

            string etiqueta = helper.ObtenerEtiquetaProducto(1001, "Mouse Logitech", 2500);

            Problema2 problema2 = new Problema2();

            string resumen1 = problema2.CrearResumenVenta(1001, "Teclado", 3, 1500);
            string resumen2 = problema2.CrearResumenVenta(1002, "Mouse", 0, 2500);

            Problema3 problema3 = new Problema3();

            Product producto = new Product("Producto original");

            string resultado = problema3.CompararCopias(12, producto);


            Console.WriteLine(etiqueta);
            Console.WriteLine(resumen1);
            Console.WriteLine(resumen2);
            Console.WriteLine(resultado);

        }
    }
}
