using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPromedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, numero, promedio, suma=0, contador=1;
            Console.WriteLine("Programa que caldula el promedio ");
            valor = int.Parse(Console.ReadLine());
            while (contador <= valor)
            {
                Console.WriteLine("Digite un Valor:  ");
                numero = int.Parse(Console.ReadLine());
                suma = suma + numero;
                contador++;
                
            }
            Console.WriteLine("La Suma es:  " + suma); 
            promedio = suma / valor;
            Console.WriteLine("El Promedio es:   " + promedio);
            Console.ReadKey();
        }

    }
}
