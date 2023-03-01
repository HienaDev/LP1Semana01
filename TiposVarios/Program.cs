using System;
using System.Text;

namespace TiposVarios
{
    class Program
    {

        


        static void Main(string[] args)
        {

            Console.OutputEncoding = Encoding.UTF8;

            int numero1 = 10;
            int numero2 = 0x89;
            int numero3 = 0b10101001;
            int numero4 = 0;
            int numero5 = -123;

            Console.WriteLine(numero1);
            Console.WriteLine(numero2);
            Console.WriteLine(numero3);
            Console.WriteLine(numero4);
            Console.WriteLine(numero5);

            char caracter1 = 'c';
            char caracter2 = 'z';
            char caracter3 = '\u2605';
            char caracter4 = '\n';
            char caracter5 = '\t';
            
            Console.WriteLine(caracter1);
            Console.WriteLine(caracter2);
            Console.WriteLine(caracter3);
            Console.WriteLine(caracter4);
            Console.WriteLine(caracter5);
        }
    }
}
