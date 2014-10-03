using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int piezas, contador = 0;
            float longitud;
            Console.WriteLine("Fabrica de perfiles");
            Console.WriteLine("Lea numero de piezas:  ");
            piezas =int.Parse(Console.ReadLine());
            while (contador < piezas)
            {
                Console.WriteLine("Lea la longitud:  ");
                longitud = float.Parse(Console.ReadLine());
                if(longitud >= 1.20 && longitud <= 1.30)
                {
                    Console.WriteLine(" La pieza  " + longitud + " es apta ");
                    contador++;
                }
                else
                {
                    Console.WriteLine(" La pieza  " + longitud + "  no es apta ");
                    contador++;
                }
                
            }
            Console.ReadKey();
        }
    }
}
