using System;
using System.IO;

namespace _04CopyBinaryFile
{
    class Program
    {
        static void Main()
        {
            using (var copy = new FileStream("copyMe.png", FileMode.Open, FileAccess.Read))
            {
                using (var paste = new FileStream("copied.png", FileMode.Create, FileAccess.Write))
                {
                    int bufferSize = 1;

                    while (bufferSize > 0)
                    {
                        var buffer = new byte[4096];
                        bufferSize = copy.Read(buffer, 0, buffer.Length);
                        paste.Write(buffer, 0, bufferSize);
                    }
                }
            }
        }
    }
}
