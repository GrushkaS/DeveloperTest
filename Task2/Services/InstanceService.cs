using System.Reflection;

namespace Task2.Services
{
    public class InstanceService : IInstanceService
    {
        public IEnumerable<T> GetInstances<T>()
        {
            var instances = new List<T>();

            var types =
                Assembly.LoadFrom("Task1.dll").GetTypes()
                .Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(typeof(T)));

            foreach (var type in types) 
            {
                var instance = (T)Activator.CreateInstance(type);
                instances.Add(instance);
            }

            return instances;
        }
    }
}
