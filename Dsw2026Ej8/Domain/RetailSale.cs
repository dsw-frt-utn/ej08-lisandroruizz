using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Domain
{
    public class RetailSale : Sale
    {
        public RetailSale(decimal amount) : base(amount)
        {
        }

        public override decimal CalculateTotal()
        {
            return amount;
        }
    }
}
