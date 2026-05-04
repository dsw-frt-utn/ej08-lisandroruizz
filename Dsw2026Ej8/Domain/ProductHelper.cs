using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Domain
{

        public partial class ProductHelper
        {
            public string ObtenerEtiquetaProducto(long code, string description, decimal price)
            {
                return $"[{code}] {description} - {FormatearMoneda(price)}";
            }
        }
    }
