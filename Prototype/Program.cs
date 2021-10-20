using System;
using Prototype.File;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            IPrint file = FileHelper.GetFile(args);            
            file.Print(args[1]);

            Console.ReadKey();
        }
    }
}
