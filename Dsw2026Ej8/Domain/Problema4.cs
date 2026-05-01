using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8.Domain
{
    public class Problema4
    {
        public double CalcularPromedio(int? nota1, int? nota2, int? nota3)
        {
            int suma = 0;
            int cantidad = 0;

            if (nota1 is int valor1 && valor1 >= 0 && valor1 <= 10)
            {
                suma += valor1;
                cantidad++;
            }

            if (nota2 is int valor2 && valor2 >= 0 && valor2 <= 10)
            {
                suma += valor2;
                cantidad++;
            }

            if (nota3 is int valor3 && valor3 >= 0 && valor3 <= 10)
            {
                suma += valor3;
                cantidad++;
            }

            if (cantidad == 0)
            {
                return 0;
            }

            return (double)suma / cantidad;
        }
    }
}
