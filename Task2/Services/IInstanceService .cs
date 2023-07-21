﻿namespace Task2.Services
{
    public interface IInstanceService
    {
        IEnumerable<T> GetInstances<T>(string assemblyName);
        void PrintInstanceNamesToConsole<T>(IEnumerable<T> instances);
        IEnumerable<T> SearchInstancesByName<T>(IEnumerable<T> instances, string name);
        void SaveInstancesToDisk<T>(IEnumerable<T> instances, string filePath);
    }
}
