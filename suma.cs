using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class Calculadora
    {
        public static void Main(String[] args)
        {
            int suma = 0;
            int contador = 0;
            while (contador < 10)
            {
                contador = contador + 1;
                suma = contador + suma;
            }
            Console.WriteLine(contador);
            Console.WriteLine(suma);
        }
    }
}