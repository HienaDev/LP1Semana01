using System;
using System.Text;

// Namespace's name, useful when you'd like to use this program on another 
// program with the using tag, like in "using System"
namespace VariasStrings
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

            string frase_normal = "\"\u2605 Hello\tWorld! \u2605\"";
            string frase_verbatim = @"""\u2605 Hello\tWorld! \u2605""";
            string frase_emoji = "\u058E \u271E";
            string frase_whitespaces = "\t \r \t \n \b \0 \\ \\ \" \' ";
            string frase_whitespaces_verbatim = @"\t \r \t \n \b \0 \\ \\ "" \' ";

            Console.WriteLine(frase_normal);
            Console.WriteLine(frase_verbatim);
            Console.WriteLine(frase_emoji);
            Console.WriteLine(frase_whitespaces);
            Console.WriteLine(frase_whitespaces_verbatim);
        }
    }
}
