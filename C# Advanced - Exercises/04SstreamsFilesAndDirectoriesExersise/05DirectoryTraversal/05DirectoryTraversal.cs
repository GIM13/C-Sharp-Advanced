using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _05DirectoryTraversal
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            string[] files = Directory.GetFiles(input);

            var extensions = new Dictionary<string, Dictionary<string, double>>();

            foreach (var file in files)
            {
                var fileInfo = new FileInfo(file);

                if (!extensions.ContainsKey(fileInfo.Extension))
                {
                    extensions.Add(fileInfo.Extension, new Dictionary<string, double>());
                }

                extensions[fileInfo.Extension].Add(fileInfo.Name, fileInfo.Length / 1024);
            }

            extensions = extensions
                .OrderByDescending(x => x.Value.Count)
                .ThenBy(x => x.Key)
                .ToDictionary(x => x.Key, y => y.Value);

            string toDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/report.txt ";
            using (var writer = new StreamWriter(toDesktop))
            {
                foreach (var (extension, nameSize) in extensions)
                {
                    writer.WriteLine(extension);

                    var result = nameSize
                        .OrderBy(y => y.Value)
                        .ToDictionary(k => k.Key , v => v.Value);

                    foreach (var (name, size) in result)
                    {
                        writer.WriteLine($"--{name} - {size}kb");
                    }
                }
            }
        }
    }
}
