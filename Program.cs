using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace working_with_strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String firstName = "RivaRiva";
            String lastName = "Mollarck";
            //concatination

            Console.WriteLine(firstName + " " + lastName);

            //functions with strings
            Console.WriteLine(lastName.Length);
            //methods on strings
            Console.WriteLine(firstName.ToUpper());

            //methods with a paramater eg the contains(), its case sensitive
            Console.Write(firstName.Contains("fu"));

            //access characters using index
            Console.WriteLine(firstName[0]);

            //indexOf will tell u iff the value is there and at what position
            Console.Write("index of a is");
            Console.WriteLine(lastName.IndexOf('a'));

            //substring, to grab from an index onwards 
            Console.WriteLine(firstName.Substring(1));
            
            //you can also give index and length ie how many chars u wanna grab
            Console.WriteLine(firstName.Substring(1,2));

            Console.ReadLine();



















        }
    }
}
