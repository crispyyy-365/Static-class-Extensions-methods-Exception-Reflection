using ConsoleApp1.Models;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 7;
            int num2 = 4;
            string password = "21passWord";
            string str = "A364JHsd88breY";

            Console.WriteLine(Helper.IsOdd(num1));
            Console.WriteLine(Helper.IsEven(num2));
            Console.WriteLine(Helper.HasDIgit(password));
            Console.WriteLine(Helper.CheckPassword(password));
            Console.WriteLine(Helper.Capitalise(str));
        }
    }
}
