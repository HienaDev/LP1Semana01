using System;

// Namespace's name, useful when you'd like to use this program on another 
// program with the using tag, like in "using System"
namespace Argumentos
{
    // Name of the class
    class Program
    {
        // Name of the function and arguments it receives, main receives
        // arguments from the cmd line
        static void Main(string[] args)
        {
            //Prints all the arguments received from the cmd line
            for (int i = 0; i < args.Length ; i++)
            {
                Console.WriteLine(args[i]);
            }
        }
    }
}
