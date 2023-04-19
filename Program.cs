using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Double n1;
            Double quilometro=1.852;
            Double soma;
            Console.WriteLine("coloque o valor em milha marítimas:");
            n1 = Double.Parse(Console.ReadLine());
            soma = n1 * quilometro;
            Console.WriteLine("O valor em quilometros é:{0}",soma);

        }
    }
}
