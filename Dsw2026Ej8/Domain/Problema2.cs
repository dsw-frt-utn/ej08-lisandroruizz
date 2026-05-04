using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Domain
{
    public class Problema2
    {
        public string CrearResumenVenta(long productCode, string productDescription, int quantity, decimal unitPrice)
        {
            decimal total;

            if (quantity > 0)
            {
                total = quantity * unitPrice;
            }
            else
            {
                total = 0;
            }

            var venta = new
            {
                Code = productCode,
                Description = productDescription,
                Quantity = quantity,
                Total = total
            };

            return $"{venta.Code}-{venta.Description}-{venta.Total}";
        }
    }
}