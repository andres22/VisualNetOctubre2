using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWhile2
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, contador = 1;
            Console.WriteLine(" Programa valor ingresado");
            Console.WriteLine(" Digite Valor:  ");
            valor = int.Parse(Console.ReadLine());
            while (contador <= valor)
            {
                Console.WriteLine(contador);
                contador++;
            }
            Console.ReadKey();
        }
    }
}
