using System;
using System.IO;
using LuisManager.Common.Contracts.Helpers;

namespace LuisManager.WPF.Helpers
{
    public class FileHelper : IFileHelper
    {
        public string ActualPath => AppDomain.CurrentDomain.BaseDirectory;

        public string ReadTextFile(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            {
                return reader.ReadToEnd();
            }
        }

        public void WriteTextFile(string filePath, string content)
        {
            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine(content);
            }
        }
    }
}
