using System;
using ThirdPartyTools;

namespace Prototype.File
{
    public class FileSize: IPrint
    {
        private readonly FileDetails _fileDetails;
        public FileSize(FileDetails fileDetails)
        {
            _fileDetails = fileDetails;
        }
        public void Print(string size)
        {
            Console.WriteLine(_fileDetails.Size(size));
        }
    }
}
