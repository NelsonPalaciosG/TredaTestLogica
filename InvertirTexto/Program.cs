using System;

namespace InvertirTexto
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Ingrese el texto al cual desea invertir las palabras con mas de 5 caracteres: ");
            string cadena = Convert.ToString(Console.ReadLine());
            string[] trozos = Fragmentar(cadena);
            Console.WriteLine(Invertir(trozos));
            Console.ReadKey();
        }

        public static string[] Fragmentar(string cadena)
        {
            char[] delimitador = { ' ', ',' };
            string[] trozos = cadena.Split(delimitador);
            return trozos;
        }

        public static string Invertir(string[] trozos)
        {
            string concat = default;
            foreach (string trozo in trozos)
            {
                if (trozo.Length > 5)
                {
                    char[] palabra = trozo.ToCharArray();
                    Array.Reverse(palabra);
                    concat += $" {new string(palabra)}";
                }
                else
                {
                    concat += $" {trozo}";
                }
            }
            return concat.Trim();
        }

    }
}
