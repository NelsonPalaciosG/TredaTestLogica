using System;

namespace SumaMultiplos
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Ingrese el número para el cual desea verificar sus multiplos: ");
            var numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(SumarMultiplo(numero));
            Console.ReadKey();

        }

        public static int SumarMultiplo(int numero)
        {
            int suma = 0;
            int i;
            for (i = 1; i < numero; i++)
            {
                if (i % 5 == 0)
                {
                    suma += i;
                }

                if (i % 3 == 0)
                {
                    suma += i;
                }

            }

            return suma;
        }
        

    }
}
