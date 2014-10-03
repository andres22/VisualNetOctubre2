using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appfor
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont1 = 0, cont2 = 0, cont3 = 0, valor = 0;
            float valor1;
            Console.WriteLine("Programa Numeros Enteros");
            Console.WriteLine("Digite Numero:  ");
            valor = int.Parse(Console.ReadLine());
            for (cont1 = 1; cont1 <= valor; cont1++)
            {
                Console.WriteLine("Digite su valor ");
                valor1 = float.Parse(Console.ReadLine());
            }
            if (valor >= 1000)
            {
                cont2 = cont2 + 1;
            }
            else 
            {
                cont3 = cont3 + 1;
            }
            Console.WriteLine("los numeros mayores a 1000 son:  " + cont2);
            Console.WriteLine("los numeros menores a 1000 son:  " + cont3);
            Console.ReadKey();
        }
    }
}
