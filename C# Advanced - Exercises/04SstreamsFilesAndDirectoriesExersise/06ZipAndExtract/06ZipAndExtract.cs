using System;
using System.IO.Compression;

namespace _06ZipAndExtract
{
    class Program
    {
        static void Main()
        {
            string toDesktopZip = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/forExtract.zip"; 

            string toDesktopExtract = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/forExtract.zip"; 

            string result = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/final"; 

            ZipFile.CreateFromDirectory("forZip", toDesktopZip);

            ZipFile.ExtractToDirectory(toDesktopExtract, result);
        }
    }
}
