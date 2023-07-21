using Newtonsoft.Json;
using System.Reflection;

namespace Task2.Services
{
    public class InstanceService : IInstanceService
    {
        public IEnumerable<T> GetInstances<T>(string assemblyName)
        {
            var instances = new List<T>();

            var types =
                Assembly.LoadFrom(assemblyName).GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(T)));

            foreach (var type in types)
            {
                var instance = (T)Activator.CreateInstance(type);
                instances.Add(instance);
            }

            return instances;
        }

        public void PrintInstanceNamesToConsole<T>(IEnumerable<T> instances)
        {
            var instancesNames = instances.Select(x => x.GetType().Name).ToList();
            instancesNames.Sort();

            foreach (var name in instancesNames)
            {
                Console.WriteLine(name);
            }
        }

        public void SaveInstancesToDisk<T>(IEnumerable<T> instances, string filePath)
        {
            var json = JsonConvert.SerializeObject(instances);

            File.AppendAllText(filePath, json);
        }

        public IEnumerable<T> SearchInstancesByName<T>(IEnumerable<T> instances, string name)
        {
            return instances.Where(instance => instance.GetType().Name.Contains(name)).ToList();
        }
    }
}
