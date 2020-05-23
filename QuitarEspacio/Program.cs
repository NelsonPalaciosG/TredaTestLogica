using System;
using System.Linq;

namespace QuitarEspacio
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Ingrese el texto al cual desea eliminarle espacios o guiones : ");
            string cadena = Convert.ToString(Console.ReadLine());
            string cadenaNueva = ToCamelCase(cadena);
            Console.WriteLine(QuitarEspacios(cadenaNueva));
            Console.ReadKey();
        }


        public static string PonerEspacios(string cadena)
        {
            while (cadena.Contains("-") || cadena.Contains("_"))
            {
                cadena = cadena.Replace("-", " ");
                cadena = cadena.Replace("_", " ");
            }

            return cadena;

        }

        public static string QuitarEspacios(string cadena)
        {
            while (cadena.Contains(" ") || cadena.Contains("-") || cadena.Contains("_"))
            {
                cadena = cadena.Replace(" ", "");
                cadena = cadena.Replace("-", "");
                cadena = cadena.Replace("_", "");
            }

            return cadena;

        }

        public static string ToCamelCase(string nuevacadena)
        {
           
            char[] a = nuevacadena.ToLower().ToCharArray();
            for (int i = 1; i < a.Count(); i++)
            {
                a[i] = i == 0 || a[i - 1] == '-' || a[i - 1] == '_' || a[i - 1] == ' ' ? char.ToUpper(a[i]) : a[i];

            }
            
            return new string(a);
            
        }

    }
}
