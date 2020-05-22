using System;
using System.Text;

namespace InvertirTexto
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("Ingrese el texto al cual desea invertir las palabras: ");
            string cadena = Convert.ToString(Console.ReadLine());
            char[] delimitador = { ' ', ',' };
            string[] trozos = cadena.Split(delimitador);
            int i;
            for (i = 0; i < trozos.Length /*&& trozos.Length > 5*/; i++)
            {
                char[] cadenanueva = trozos[i].ToCharArray();
                Array.Reverse(cadenanueva);
                Console.WriteLine(cadenanueva);
                
               
            }
           // string fragmento = Fragmentar(cadena);
            //string Invertida = Invertir(cadena);
           // Console.WriteLine(Invertida);
            Console.ReadKey();
        }

        //public static string InvertirManualmente(string cadena)
        //{
        //    string cadenaInvertida = "";
        //    // Recorrer cadena letra por letra
        //    foreach (char letra in cadena)
        //    {
        //        // Anteponer la letra a la cadena invertida
        //        cadenaInvertida = letra + cadenaInvertida;
        //    }
        //    return cadenaInvertida;
        //}

        //public static string Invertir(string cadena)
        //{
        //    Console.Write("Ingrese el número texto al cual desea eliminarle los espacios: ");
        //    string cadena = Convert.ToString(Console.ReadLine());
        //    char[] delimitador = { ' ', ',' };
        //    string[] trozos = cadena.Split(delimitador);
        //    int i;
        //    for (i = 0; i < trozos.Length /*&& trozos.Length > 5*/; i++)
        //    {
        //        char[] cadenanueva = trozos[i].ToCharArray();
        //        Array.Reverse(cadenanueva);
        //        Console.WriteLine(cadenanueva);


        //    }
        //    // string fragmento = Fragmentar(cadena);
        //    //string Invertida = Invertir(cadena);
        //    // Console.WriteLine(Invertida);
        //    Console.ReadKey();
        //}

        //public static string Fragmentar(string cadena)
        //{
        //    char[] delimitador = { ' ', ',' };
        //    string[] trozos = cadena.Split(delimitador);
        //    int i;
        //    for (i=0; i<trozos.Length && trozos.Length>5; i++)
        //    {
        //        Console.WriteLine( trozos[i]);
        //        char [] cadenanueva = trozos[i].ToCharArray();
        //        Array.Reverse(cadenanueva);
        //        return new string (cadenanueva);
        //    }
        //    Console.ReadKey();
        //}                    

    }
}
