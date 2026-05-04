using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej08.Domain
{
    public class Problema6
    {
        public string NormalizarCodigoProducto(string code)
        {
            return code.ToProductCode();
        }
    }
}