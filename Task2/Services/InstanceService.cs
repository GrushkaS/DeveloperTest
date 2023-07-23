using Newtonsoft.Json;
using System.Reflection;
using Common.Extensions;

namespace Task2.Services
{
    public class InstanceService : IInstanceService
    {
        public IEnumerable<T> GetInstances<T>(string assemblyName)
        {
            if (assemblyName.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(assemblyName));
            }

            var instances = new List<T>();

            var types =
                Assembly.LoadFrom(assemblyName).GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(T)));

            foreach (var type in types)
            {
                var instance = (T)Activator.CreateInstance(type);

                if (instance != null)
                {
                    instances.Add(instance);
                }
            }

            return instances;
        }

        public IEnumerable<string> GetInstanceNames<T>(IEnumerable<T> instances)
        {
            if (instances.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(instances));
            }

            var instancesNames = instances.Select(x => x.GetType().Name).ToList();
            instancesNames.Sort();

            return instancesNames;
        }

        public void SaveInstancesToDisk<T>(IEnumerable<T> instances, string filePath)
        {
            if (instances.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(instances));
            }

            var json = JsonConvert.SerializeObject(instances);

            File.AppendAllText(filePath, json);
        }

        public IEnumerable<T> SearchInstancesByName<T>(IEnumerable<T> instances, string name)
        {
            if (instances.IsNullOrEmpty())
            {
                throw new ArgumentNullException(nameof(instances));
            }

            return instances.Where(instance => instance.GetType().Name.Contains(name)).ToList();
        }
    }
}
