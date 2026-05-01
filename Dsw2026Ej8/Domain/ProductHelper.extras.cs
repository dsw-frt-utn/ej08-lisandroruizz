using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Domain
{
    public partial class ProductHelper
    {
        private string FormatearMoneda(decimal price)
        {
            return $"${price:N2}";
        }
    }
}
