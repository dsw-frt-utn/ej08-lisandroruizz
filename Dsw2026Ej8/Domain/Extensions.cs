using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej08.Domain
{
    public static class Extensions
    {
        public static string ToProductCode(this string code)
        {
            if (code == null)
            {
                return "SIN-CODIGO";
            }

            string codigo = code.Trim();
            codigo = codigo.ToUpper();
            codigo = codigo.Replace(" ", "-");

            return codigo;
        }
    }
}