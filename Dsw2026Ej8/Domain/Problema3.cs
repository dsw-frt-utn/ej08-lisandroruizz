using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Domain
{
    public class Problema3
    {
        public string CompararCopias(int originalValue, Product product)
        {
            int valorCopia = originalValue;
            valorCopia++;

            Product productoCopiado = product;
            productoCopiado.ChangeDescription("Producto modificado");

            return $"{originalValue}-{valorCopia}-{product.GetDescription()}";
        }
    }
}

