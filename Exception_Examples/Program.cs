using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_Examples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
               Console.WriteLine("Enter a number  X:");
               int  x =int.Parse(Console.ReadLine());
                Console.WriteLine("Enter a number Y:");
                int y = int.Parse(Console.ReadLine());
                int result = x / y;

                int[] marks = { 80, 70, 35, 40, 90 };
                Console.WriteLine($"MArks range:",(marks[6]));
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine($"Error: Division  by Zero cannot be Divided");
                Console.WriteLine(e.Message);
            }
            catch(IndexOutOfRangeException Ex)
            {
                Console.WriteLine($" Error :Arrray index out of bounds");
                Console.WriteLine(Ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Please enter numbers only.");
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Code run successfullyy done ");
            }
        }
    }
}
