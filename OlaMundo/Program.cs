using System;

// Namespace's name, useful when you'd like to use this program on another 
// program with the using tag, like in "using System"
namespace OlaMundo
{
    // Name of the class
    class Program
    {
        /// <summary>
        /// Name of the function and arguments it receives, main receives
        /// arguments from the cmd line.This program just writes "Hello, World!"
        /// and "Bye world" to the console screen
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Prints these phrases to the terminal
            Console.WriteLine("Hello, World!");
            Console.WriteLine("Bye world");
        }
    }
}
