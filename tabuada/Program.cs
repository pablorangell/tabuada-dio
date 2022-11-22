using System;

namespace tabuada
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int numero = Convert.ToInt32(Console.ReadLine());

            for (int contador = 0; contador <= 10; contador++)
            {
                Console.WriteLine($"{numero} X {contador} = {numero * contador}");
            }
        }
    }
}