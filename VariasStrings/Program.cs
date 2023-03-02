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

            // Initializing variables
            double xx = 0.12345;
            int ii = 18;

            string frase_normal = "\"\u2605 Hello\tWorld! \u2605\"";
            string frase_verbatim = @"""\u2605 Hello\tWorld! \u2605""";
            string frase_emoji = "\u058E \u271E";
            string frase_whitespaces = "\t \r \t \n \b \0 \\ \\ \" \' ";
            string frase_whitespaces_verbatim = @"\t \r \t \n \b \0 \\ \\ "" \' ";

            // Printing variables's values to the cmd line
            Console.WriteLine(frase_normal);
            Console.WriteLine(frase_verbatim);
            Console.WriteLine(frase_emoji);
            Console.WriteLine(frase_whitespaces);
            Console.WriteLine(frase_whitespaces_verbatim);

            // Printing a new line to the cmd line
            Console.WriteLine("\n");

            // Initializing variables
            int x = 123;
            int y = 42;

            string frase_conc = "Hello" + " " + "World!" + " 123";
            string frase_conc_num = "Hello" + " " + "World!" + " " + 123;
            string frase_conc_var = "Hello" + " " + "World!" + " " + x;
            string frase_interpol = $"Hello World! {x}";
            string frase_interpol_sum = $"Hello World! {x} + {y} = {x + y}";
            string frase_interpol_mul = $"Hello World! {x} * {y} = {x * y}";
            
            // Printing variables's values to the cmd line
            Console.WriteLine(frase_conc);
            Console.WriteLine(frase_conc_num);
            Console.WriteLine(frase_conc_var);
            Console.WriteLine(frase_interpol);
            Console.WriteLine(frase_interpol_sum);
            Console.WriteLine(frase_interpol_mul);

            // Printing a new line to the cmd line
            Console.WriteLine("\n");

            // Initializing variables
            string frase_format = String.Format("Hello {0} No. {1}!", 
                                                    "World", 3);
            string frase_format2 = String.Format("Hello{0} {1}{2} {3}!", 
                                    ",", "Good Morning", "!","How you doing?");
            string frase_format3 = String.Format("Hi, {0} * {1} = {2}", x, y, 
                                                                        x * y);

            // Printing variables's values to the cmd line
            Console.WriteLine(frase_format);
            Console.WriteLine(frase_format2);
            Console.WriteLine(frase_format3);

            // Printing directly to the cmd line
            Console.WriteLine("Bye\tWorld\t! x = {0}, y = {1}", x, y);
            Console.WriteLine(@"Bye\tWorld\t! x = {0}, y = {1}", x, y);

            // Printing a new line to the cmd line
            Console.WriteLine("\n");

            Console.WriteLine(" .{0,4:x}. e .{1,-4:x}.", 456, 123);

            // Printing a new line to the cmd line
            Console.WriteLine("\n");

            Console.WriteLine($"{xx:f2}");
            Console.WriteLine($"{xx:p1}");

            // Printing a new line to the cmd line
            Console.WriteLine("\n");

            Console.WriteLine($"{ii:x}");
            Console.WriteLine($"{ii:c}");

        }
    }
}
