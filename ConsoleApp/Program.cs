using Task1.Models;
using Task2.Services;
using Task4.Extensions;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, ConsoleApp!");

            var arr = new int[] { 1, 2, 4, 5, 9 };

            var missingElements = arr.MissingElements();

            var string1 = "hello".ReverseString();
            var palindrom1 = "haah".IsPalindrome();

            IInstanceService instanceService = new InstanceService();

            //var classes = instanceService.GetInstances<Vehicle>();

            Console.WriteLine("Task ended!");
            Console.ReadKey();
        }
    }
}