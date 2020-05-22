using System;

namespace SumaMultiplos
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            int suma =0;
            int i;
           // int acum;
            Console.Write("Ingrese el número para el cual desea verificar sus multiplos: ");
            a = Convert.ToInt32(Console.ReadLine());
            
            for (i = 1; i<a; i++)
            {
                //acum = 0;
                if (i % 5 == 0)
                {
                    suma = suma + i;
                    Console.Write("{0} |", suma );

                }

                if (i % 3 == 0)
                {
                    suma = suma + i;
                    Console.Write("{0} |", suma );

                }

            }


            Console.ReadKey();

        }

    }
}
