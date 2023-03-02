using System;
using System.Text;

// Namespace's name, useful when you'd like to use this program on another 
// program with the using tag, like in "using System"
namespace TiposVarios
{
    // Name of the class
    class Program
    {
        // Name of the function and arguments it receives, main receives
        // arguments from the cmd line
        static void Main(string[] args)
        {
            
            // This line allows for more complex characters to be displayed
            // on the cmd line
            Console.OutputEncoding = Encoding.UTF8;

            // Initialize interger number variables
            int numero1 = 10;
            int numero2 = 0x89;
            int numero3 = 0b10101001;
            int numero4 = 0;
            int numero5 = -123;

            // Print the values of the interger number variables to the cmd line
            Console.WriteLine(numero1);
            Console.WriteLine(numero2);
            Console.WriteLine(numero3);
            Console.WriteLine(numero4);
            Console.WriteLine(numero5);

            // Initialize char variables
            char caracter1 = 'c';
            char caracter2 = 'z';
            char caracter3 = '\u2605';
            char caracter4 = '\n';
            char caracter5 = '\t';
            
            // Print the values of the char variables to the cmd line
            Console.WriteLine(caracter1);
            Console.WriteLine(caracter2);
            Console.WriteLine(caracter3);
            Console.WriteLine(caracter4);
            Console.WriteLine(caracter5);

            // Initialize real number variables
            float real1 = 4.5f;
            float real2 = 4.234f;
            double real3 = 10.45237;
            double real4 = 9.12387;
            decimal real5 = 2.1287368172638123m;

            // Print the values of the real number variables to the cmd line
            Console.WriteLine(real1);
            Console.WriteLine(real2);
            Console.WriteLine(real3);
            Console.WriteLine(real4);
            Console.WriteLine(real5);

            // Initialize boolean variables
            bool verdade = true;
            bool falso = false;

            // Print the values of the boolean variables to the cmd line
            Console.WriteLine(verdade);
            Console.WriteLine(falso);
        }
    }
}
