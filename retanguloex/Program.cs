using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retanguloex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("coloque a base do retângulo:");
            double basedoretangulo = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Coloque a altura do retângulo:");
            double altura = Convert.ToDouble(Console.ReadLine());

            double area = basedoretangulo * altura;

            Console.WriteLine($"A área do retângulo é: {area}");
        }
    }
}
