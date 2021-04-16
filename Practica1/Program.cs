using System;

namespace Practica1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0, fact = 0;
      
            Console.Write("Ingresa el número del que deseas obtener su factorial: ");
            numero = Convert.ToInt32(Console.ReadLine());

            if (numero == 0)
            {
                Console.WriteLine("El factorial de 0 es: 1");
            }
            else
            {
                fact = numero;
                for (int i=numero; i>1; i--)
                {  
                    fact = fact * (i - 1);
                }
                Console.WriteLine("El factorial de " +numero+" es: "+fact);
            }
            Console.ReadKey();

           
        }
    }
}
