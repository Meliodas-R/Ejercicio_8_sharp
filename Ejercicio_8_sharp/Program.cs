using System;

namespace Ejercicio_8_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca un texto: ");
            string texto = Console.ReadLine();
            Console.WriteLine("\nPrimer caracter de la palabra: " + texto[0]);

            Console.Write("\nIntroduzca la posicion del caracter que desea visualizar:  ");
            int indice = Convert.ToInt32(Console.ReadLine()) - 1;

            if (indice < texto.Length)
            {
                Console.WriteLine("La letra situada en la posición [" + (indice + 1) + "] es: " + texto[indice]);
            }
            else
            {
                Console.WriteLine("La posicion introducida es incorrecta.");
            }
        }
    }
}
