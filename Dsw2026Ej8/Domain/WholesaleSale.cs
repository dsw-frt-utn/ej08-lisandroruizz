using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Domain
{
    public class WholesaleSale : Sale
    {
        public WholesaleSale(decimal amount) : base(amount)
        {
        }

        public override decimal CalculateTotal()
        {
            return amount * 0.90m;
        }
    }
}