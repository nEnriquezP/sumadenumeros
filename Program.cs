using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNamespace
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, resul;
            Console.WriteLine("Bienvenido... ");
            Console.Write("Ingrese un número por favor ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Ingrese segundo número por favor ");
            b = int.Parse(Console.ReadLine());
            resul = a + b;
            Console.WriteLine("La suma de " + a + " y " + b + " es " + resul);
            Console.ReadLine();
        }
    }

}
