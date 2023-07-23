using System.Configuration;
using Task1.Models;
using Task2.Services;
using System.Reflection;

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var exeFilePath = Assembly.GetExecutingAssembly().Location;
            var exeFolderPath = Path.GetDirectoryName(exeFilePath);
            var staticFileFolderPath = Path.Combine(exeFolderPath, ConfigurationManager.AppSettings.Get("StaticFilesFolderName"));

            Directory.CreateDirectory(staticFileFolderPath);

            Console.WriteLine("Hello, Task3!");


            IInstanceService instanceService = new InstanceService();
            var instances = instanceService.GetInstances<Vehicle>(ConfigurationManager.AppSettings.Get("AssemblyNameToload"));


            Console.WriteLine("All instances:");
            PrintInstanceNamesToConsole(instanceService.GetInstanceNames(instances));


            var searchedInstances = instanceService.SearchInstancesByName(instances, "Bi");

            Console.WriteLine("Searched instances:");
            PrintInstanceNamesToConsole(instanceService.GetInstanceNames(searchedInstances));


            instanceService.SaveInstancesToDisk(
                instances,
                Path.Combine(staticFileFolderPath, ConfigurationManager.AppSettings.Get("InstancesFileName"))
                );
            Console.WriteLine("Instances saved!");


            Console.WriteLine("Task3 ended!");
            Console.ReadKey();
        }

        private static void PrintInstanceNamesToConsole(IEnumerable<string> names)
        {
            foreach ( var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}