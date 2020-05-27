using System;
using System.IO.Compression;

namespace _06ZipAndExtract
{
    class Program
    {
        static void Main()
        {
            string toDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/forExtract.zip";

            string result = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/final";

            string forZip = "./forZip";

            ZipFile.CreateFromDirectory(forZip, toDesktop);

            ZipFile.ExtractToDirectory(toDesktop, result);
        }
    }
}
