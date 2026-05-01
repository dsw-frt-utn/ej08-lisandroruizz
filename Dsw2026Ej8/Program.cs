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

            Problema4 problema4 = new Problema4();

            Console.WriteLine(problema4.CalcularPromedio(8, null, 10));
            Console.WriteLine(problema4.CalcularPromedio(null, null, null));
            Console.WriteLine(problema4.CalcularPromedio(8, 20, 10));
            Console.WriteLine(problema4.CalcularPromedio(-1, 7, 9));

            Problema5 problema5 = new Problema5();

            Sale ventaMinorista = new RetailSale(1000);
            Sale ventaMayorista = new WholesaleSale(1000);

            decimal totalMinorista = problema5.ObtenerImporteFinal(ventaMinorista);
            decimal totalMayorista = problema5.ObtenerImporteFinal(ventaMayorista);

            Console.WriteLine($"Venta minorista: importe final {totalMinorista:C}");
            Console.WriteLine($"Venta mayorista: importe final {totalMayorista:C}");


            Console.WriteLine(etiqueta);
            Console.WriteLine(resumen1);
            Console.WriteLine(resumen2);
            Console.WriteLine(resultado);

        }
    }
}
