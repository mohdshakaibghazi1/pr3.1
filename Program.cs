using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string value ="865";
                int numeric;
                bool isTrue = int.TryParse(value, out numeric);
                if (isTrue)
                {
                    Console.WriteLine("The Integer value is " + numeric);
                    Console.ReadKey();
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();  
            }
        }
    }
}
